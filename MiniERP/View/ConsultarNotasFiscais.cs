using Microsoft.EntityFrameworkCore;
using MiniERP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP.View
{
    public partial class ConsultarNotasFiscais : Form
    {
        MiniErp2Context contexto = new MiniErp2Context();
        public ConsultarNotasFiscais()
        {
            InitializeComponent();
            dataGridView_NotasFiscais.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CarregarNotasFiscaisNoDataGridView()
        {
            dataGridView_NotasFiscais.AutoGenerateColumns = false;

            dataGridView_NotasFiscais.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "NotaFiscalId",
                HeaderText = "ID"
            });

            dataGridView_NotasFiscais.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ClienteNome",
                HeaderText = "Cliente"
            });

            dataGridView_NotasFiscais.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Data",
                HeaderText = "Data"
            });

            dataGridView_NotasFiscais.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Total",
                HeaderText = "Total"
            });

            dataGridView_NotasFiscais.DataSource = contexto.NotasFiscais
                .Include(nf => nf.Cliente)
                .Select(nf => new
                {
                    NotaFiscalId = nf.NotaFiscalId,
                    ClienteNome = nf.Cliente.NomeRazãoSocial,
                    Data = nf.Data,
                    Total = nf.Total
                })
                .ToList();
        }

        private void button_ConsultaForncedor_Click(object sender, EventArgs e)
        {
            string consulta = textBox_ConsultaNotaFiscal.Text.Trim();

            if (string.IsNullOrWhiteSpace(consulta))
            {
                CarregarNotasFiscaisNoDataGridView();
            }
            else
            {
                if (int.TryParse(consulta, out int notaFiscalId))
                {
                    var notasFiltradas = contexto.NotasFiscais
                        .Where(nf => nf.NotaFiscalId == notaFiscalId)
                        .Select(nf => new
                        {
                            Id = nf.NotaFiscalId,
                            Cliente = nf.Cliente.NomeRazãoSocial,
                            Data = nf.Data,
                            Total = nf.Total
                        })
                        .ToList();

                    dataGridView_NotasFiscais.DataSource = notasFiltradas;
                }
                else
                {
                    MessageBox.Show("Por favor, insira um ID de nota fiscal válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_FecharFornecedores_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_VisualizarNota_Click(object sender, EventArgs e)
        {
            if (dataGridView_NotasFiscais.SelectedRows.Count > 0)
            {
                bool notaSelecionada = int.TryParse(dataGridView_NotasFiscais.SelectedRows[0].Cells[0].Value.ToString(), out int codigoNotaFiscalId);
                NotasFiscais notaFiscal = contexto.NotasFiscais
                    .Include(nf => nf.Cliente)
                    .Include(nf => nf.NotaFiscalProdutos)  
                        .ThenInclude(np => np.Produto)    
                    .FirstOrDefault(nf => nf.NotaFiscalId == codigoNotaFiscalId);

                if (notaFiscal != null)
                {
                    VisualizarNota visualizarNota = new VisualizarNota(codigoNotaFiscalId)
                    {
                        NotaFiscalId = notaFiscal.NotaFiscalId,
                        Data = notaFiscal.Data ?? DateTime.MinValue,
                        ClienteNome = notaFiscal.Cliente?.NomeRazãoSocial,
                        Produtos = notaFiscal.NotaFiscalProdutos.Select(p => new ProdutoViewModel
                        {
                            Nome = p.Produto?.Nome,
                            Quantidade = p.Quantidade ?? 0,
                            ValorUnitario = p.PrecoUnitario ?? 0
                        }).ToList()
                    };

                    visualizarNota.PreencherDadosNota();
                    visualizarNota.Show();
                }
                else
                {
                    MessageBox.Show("Nota fiscal não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma nota fiscal antes de abrir os detalhes.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
