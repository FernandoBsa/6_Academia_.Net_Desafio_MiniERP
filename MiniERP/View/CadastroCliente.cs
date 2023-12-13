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
    public partial class CadastroCliente : Form
    {
        MiniErp2Context contexto = new MiniErp2Context();
        public CadastroCliente()
        {
            InitializeComponent();
            dataGridView_Clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button_CadastroCliente_Click(object sender, EventArgs e)
        {
            FormularioCadastroCliente formulariocadastro = new FormularioCadastroCliente();
            formulariocadastro.Show();
        }

        private void button_ConsultaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string consulta = textBox_ConsultaCliente.Text.Trim();

                if (string.IsNullOrWhiteSpace(consulta))
                {
                    CarregarDadosGrid();
                }
                else
                {
                    var clientesFiltrados = contexto.Clientes
                        .Where(c => c.NomeRazãoSocial.Contains(consulta))
                        .ToList();
                    dataGridView_Clientes.DataSource = clientesFiltrados;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao consultar clientes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarDadosGrid()
        {
            dataGridView_Clientes.DataSource = contexto.Clientes.ToList();
        }

        private void button_FechaCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
