using Microsoft.EntityFrameworkCore;
using MiniERP.Model;
using System.Data;

namespace MiniERP.View
{
    public partial class LancamentoNota : Form
    {
        private List<ProdutoViewModel> produtos = new List<ProdutoViewModel>();

        MiniErp2Context contexto = new MiniErp2Context();
        public LancamentoNota()
        {
            InitializeComponent();
            this.Shown += maskedTextBox_DataNota_Shown;
        }

        private bool comboBoxClientesCarregado = false;
        private void CarregarClientesNoComboBox()
        {
            if (!comboBoxClientesCarregado)
            {
                var clientes = contexto.Clientes.ToList();
                comboBox_ClienteNota.DisplayMember = "NomeRazãoSocial";
                comboBox_ClienteNota.ValueMember = "Id";
                comboBox_ClienteNota.DataSource = clientes;
                comboBoxClientesCarregado = true;
            }
        }

        private bool comboBoxProdutosCarregado = false;
        private void CarregarProdutosNoComboBox()
        {
            if (!comboBoxProdutosCarregado)
            {
                var produtos = contexto.Produtos.ToList();
                comboBox_ProdutoNota.DisplayMember = "Nome";
                comboBox_ProdutoNota.ValueMember = "Id";
                comboBox_ProdutoNota.DataSource = produtos;
                comboBoxProdutosCarregado = true;
            }
        }

        private void comboBox_ClienteNota_DropDown(object sender, EventArgs e)
        {
            CarregarClientesNoComboBox();
        }

        private void comboBox_ProdutoNota_DropDown(object sender, EventArgs e)
        {
            CarregarProdutosNoComboBox();
        }
        private void maskedTextBox_DataNota_Shown(object sender, EventArgs e)
        {
            maskedTextBox_DataNota.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void button_FecharNota_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_SalvarNota_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes clienteSelecionado = null;
                decimal valorTotal = 0;

                if (comboBox_ClienteNota.SelectedItem is Clientes cliente)
                {
                    clienteSelecionado = cliente;

                    if (decimal.TryParse(textBox_TotalNota.Text, out decimal total))
                    {
                        valorTotal = total;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira um valor total válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // 1. Salvar a Nota Fiscal
                NotasFiscais novaNota = new NotasFiscais
                {
                    ClienteId = clienteSelecionado.Id,
                    Data = DateTime.Now,
                    Total = valorTotal
                };

                contexto.NotasFiscais.Add(novaNota);
                contexto.SaveChanges();

                // 2. Obter o ID da Nota Fiscal Criada
                int notaFiscalId = novaNota.NotaFiscalId;

                // 3. Salvar os Produtos Associados à Nota Fiscal
                foreach (ProdutoViewModel produtoViewModel in produtos)
                {
                    Produtos produtoBanco = contexto.Produtos.FirstOrDefault(p => p.Nome == produtoViewModel.Nome);

                    if (produtoBanco != null)
                    {
                        NotaFiscalProdutos notaFiscalProduto = new NotaFiscalProdutos
                        {
                            NotaFiscalId = notaFiscalId,
                            ProdutoId = produtoBanco.Id,
                            Quantidade = produtoViewModel.Quantidade,
                            PrecoUnitario = produtoViewModel.ValorUnitario
                        };

                        contexto.NotaFiscalProdutos.Add(notaFiscalProduto);
                    }
                    else
                    {
                        MessageBox.Show($"Erro ao encontrar o produto '{produtoViewModel.Nome}' no banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                contexto.SaveChanges();

                LimparCampos();

                MessageBox.Show("Nota fiscal salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Erro ao salvar a nota fiscal: {ex.InnerException?.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar a nota fiscal: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            comboBox_ProdutoNota.SelectedIndex = -1;
            comboBox_ClienteNota.SelectedIndex = -1;
            textBox_QuantidadeNota.Text = string.Empty;
            textBox_TotalNota.Text = string.Empty;
            listView_ProdutosNota.Items.Clear();
        }
        private void button_AdicionarNota_Click(object sender, EventArgs e)
        {
            if (comboBox_ProdutoNota.SelectedItem is Produtos produtoSelecionado &&
                int.TryParse(textBox_QuantidadeNota.Text, out int quantidade))
            {

                var produtoExistente = produtos.FirstOrDefault(p => p.Nome == produtoSelecionado.Nome);

                if (produtoExistente != null)
                {
                    produtoExistente.Quantidade += quantidade;
                }
                else
                {
                    decimal valorUnitario = produtoSelecionado.Preco ?? 0;

                    var produtoViewModel = new ProdutoViewModel
                    {
                        Nome = produtoSelecionado.Nome,
                        Quantidade = quantidade,
                        ValorUnitario = valorUnitario
                    };

                    produtos.Add(produtoViewModel);
                }
                AtualizarListView();
                CalcularTotalProdutos();
                textBox_QuantidadeNota.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor, preencha os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarListView()
        {
            listView_ProdutosNota.Items.Clear();

            foreach (var produto in produtos)
            {
                ListViewItem item = new ListViewItem(produto.Nome);
                item.SubItems.Add(produto.Quantidade.ToString());
                item.SubItems.Add(produto.ValorUnitario.ToString());
                listView_ProdutosNota.Items.Add(item);
            }
        }

        private void CalcularTotalProdutos()
        {
            decimal totalProdutos = produtos.Sum(produto => produto.Quantidade * produto.ValorUnitario);
            textBox_TotalNota.Text = totalProdutos.ToString();
        }
    }
}
