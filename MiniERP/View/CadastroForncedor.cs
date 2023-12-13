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
    public partial class CadastroForncedor : Form
    {
        MiniErp2Context contexto = new MiniErp2Context();
        public CadastroForncedor()
        {
            InitializeComponent();
        }

        private void button_CadastroForncedor_Click(object sender, EventArgs e)
        {
            FormularioCadastroFornecedores formularioCadastroFornecedores = new FormularioCadastroFornecedores();
            formularioCadastroFornecedores.Show();
        }

        private void button_ConsultaForncedor_Click(object sender, EventArgs e)
        {
            try
            {
                string consulta = textBox_ConsultaFornecedor.Text.Trim();

                if (string.IsNullOrWhiteSpace(consulta))
                {
                    CarregarDadosGrid();
                }
                else
                {
                    var fornecedoresFiltrados = contexto.Fornecedores
                        .Where(c => c.NomeRazãoSocial.Contains(consulta))
                        .ToList();
                    dataGridView_Fornecedores.DataSource = fornecedoresFiltrados;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao consultar Forncedores: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarDadosGrid()
        {
            dataGridView_Fornecedores.DataSource = contexto.Fornecedores.ToList();
        }

        private void button_FecharFornecedores_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
    }
}
