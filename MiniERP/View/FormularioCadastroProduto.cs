using MiniERP.Model;

namespace MiniERP
{
    public partial class FormularioCadastroProduto : Form
    {
        MiniErp2Context contexto = new MiniErp2Context();
        public FormularioCadastroProduto()
        {
            InitializeComponent();
        }

        private void button_AdicionarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                Produtos novoProduto = new Produtos();
                novoProduto.Nome = textBox_NomeProduto.Text;
                novoProduto.Marca = textBox_MarcaProduto.Text;
                novoProduto.Preco = (decimal?)double.Parse(textBox_ValorProduto.Text);
                if (comboBox_Produtos.SelectedItem is Fornecedores fornecedorSelecionado)
                {
                    novoProduto.Fornecedor = fornecedorSelecionado;
                }
                else
                {
                    MessageBox.Show("Selecione um fornecedor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                contexto.Produtos.Add(novoProduto);
                contexto.SaveChanges();
                LimparCampos();
                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar o produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            textBox_NomeProduto.Clear();
            textBox_MarcaProduto.Clear();
            textBox_ValorProduto.Clear();
            comboBox_Produtos.SelectedIndex = -1;
        }

        private bool comboBoxCarregado = false;
        private void CarregarFornecedoresNoComboBox()
        {
            if (!comboBoxCarregado)
            {
                var fornecedores = contexto.Fornecedores.ToList();
                comboBox_Produtos.DisplayMember = "NomeRazãoSocial";
                comboBox_Produtos.ValueMember = "Id";
                comboBox_Produtos.DataSource = fornecedores;
                comboBoxCarregado = true;
            }
        }

        private void comboBox_Produtos_DropDown(object sender, EventArgs e)
        {
            CarregarFornecedoresNoComboBox();
        }

        private void button_CancelarProduto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
