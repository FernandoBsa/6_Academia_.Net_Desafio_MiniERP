using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP
{
    public partial class CadastroProduto : Form
    {
        MiniErp2Context contexto = new MiniErp2Context();
        public CadastroProduto()
        {
            InitializeComponent();
            dataGridView_Produtos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button_CadastroProduto_Click(object sender, EventArgs e)
        {
            FormularioCadastroProduto formularioProduto = new FormularioCadastroProduto();
            formularioProduto.Show();
        }

        private void button_ConsultaProduto_Click(object sender, EventArgs e)
        {
            try
            {
                string consulta = textBox_ConsultaProduto.Text.Trim();

                if (string.IsNullOrWhiteSpace(consulta))
                {
                    //ConfigurarDataGridView();
                    CarregarDadosGrid();
                }
                else
                {
                    var produtoFiltrado = contexto.Produtos
                        .Where(c => c.Nome.Contains(consulta))
                        .ToList();
                    dataGridView_Produtos.DataSource = produtoFiltrado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao consultar Produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            dataGridView_Produtos.AutoGenerateColumns = false;

            dataGridView_Produtos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Nome",
                HeaderText = "Nome do Produto"
            });

            dataGridView_Produtos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Marca",
                HeaderText = "Marca"
            });

            dataGridView_Produtos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Preco",
                HeaderText = "Preço"
            });
            dataGridView_Produtos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "FornecedorId",
                HeaderText = "ID do Fornecedor"
            });
            dataGridView_Produtos.DataSource = contexto.Produtos
            .Select(p => new
            {
                p.Nome,
                p.Marca,
                p.Preco,
                p.FornecedorId
            })
            .ToList();
        }
        private void CarregarDadosGrid()
        {
            dataGridView_Produtos.DataSource = contexto.Produtos.ToList();
        }

        private void button_FechaProduto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
