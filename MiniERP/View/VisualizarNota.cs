using Microsoft.EntityFrameworkCore;
using MiniERP.Model;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Reflection.Metadata;
using Document = iTextSharp.text.Document;

namespace MiniERP.View
{
    public partial class VisualizarNota : Form
    {
        MiniErp2Context contexto = new MiniErp2Context();
        public int NotaFiscalId { get; set; }
        public DateTime? Data { get; set; }
        public string ClienteNome { get; set; }
        public decimal Total { get; set; }
        public List<ProdutoViewModel> Produtos { get; set; }

        public VisualizarNota(int notaFiscalId)
        {
            InitializeComponent();
            NotaFiscalId = notaFiscalId;
            CarregarNotaFiscal();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_GerarPDF_Click(object sender, EventArgs e)
        {
            GerarPDF();
        }

        private void GerarPDF()
        {

            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Arquivos PDF (*.pdf)|*.pdf";
                saveFileDialog.Title = "Salvar PDF Nota Fiscal - Mini ERP";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string caminhoDoPDF = saveFileDialog.FileName;

                    FileStream arquivoPdf = new FileStream(caminhoDoPDF, FileMode.Create);
                    Document doc = new Document(PageSize.A4);
                    PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPdf);
                    string dados = "";
                    doc.Open();
                    Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
                    paragrafo.Alignment = Element.ALIGN_CENTER;
                    paragrafo.Add("Nota Fiscal\n");

                    Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
                    paragrafo2.Alignment = Element.ALIGN_CENTER;
                    paragrafo2.Add("Detalhes da Nota Fiscal\n\n");

                    Paragraph paragrafo3 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12));
                    paragrafo3.Alignment = Element.ALIGN_LEFT;
                    paragrafo3.Add($"ID da Nota Fiscal: {NotaFiscalId}");

                    Paragraph paragrafo4 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12));
                    paragrafo4.Alignment = Element.ALIGN_LEFT;
                    paragrafo4.Add($"Nome do Cliente: {ClienteNome}");

                    Paragraph paragrafo5 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12));
                    paragrafo5.Alignment = Element.ALIGN_LEFT;
                    paragrafo5.Add($"Data: {Data}\n\n");

                    Paragraph paragrafo6 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
                    paragrafo6.Alignment = Element.ALIGN_CENTER;
                    paragrafo6.Add("Produto(s):\n\n");

                    Paragraph paragrafo7 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12));
                    paragrafo6.Alignment = Element.ALIGN_CENTER;
                    foreach (var produto in Produtos)
                    {
                        paragrafo7.Add($"Nome: {produto.Nome}\n");
                        paragrafo7.Add($"Quantidade: {produto.Quantidade}\n");
                        paragrafo7.Add($"Valor Unitário: {produto.ValorUnitario:C}\n");
                        paragrafo7.Add("\n");
                    }

                    Paragraph paragrafo8 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
                    paragrafo8.Alignment = Element.ALIGN_CENTER;
                    paragrafo8.Add($"Total:{Total}");


                    doc.Add(paragrafo);
                    doc.Add(paragrafo2);
                    doc.Add(paragrafo3);
                    doc.Add(paragrafo4);
                    doc.Add(paragrafo5);
                    doc.Add(paragrafo6);
                    doc.Add(paragrafo7);
                    doc.Add(paragrafo8);
                    doc.Close();

                    MessageBox.Show("Nota fiscal salva como PDF.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro ao salvar nota fiscal como PDF: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CarregarNotaFiscal()
        {

            NotasFiscais notaFiscal = contexto.NotasFiscais
                .Include(nf => nf.Cliente)
                .Include(nf => nf.NotaFiscalProdutos)
                .ThenInclude(nfp => nfp.Produto)
                .FirstOrDefault(nf => nf.NotaFiscalId == NotaFiscalId);

            if (notaFiscal != null)
            {

                Data = notaFiscal.Data;
                ClienteNome = notaFiscal.Cliente.NomeRazãoSocial;
                Total = (decimal)notaFiscal.Total;
                Produtos = notaFiscal.NotaFiscalProdutos.Select(p => new ProdutoViewModel
                {
                    Nome = p.Produto.Nome,
                    Quantidade = p.Quantidade ?? 0,
                    ValorUnitario = p.PrecoUnitario ?? 0
                }).ToList();


                PreencherDadosNota();
            }
            else
            {
                MessageBox.Show("Nota fiscal não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        public void PreencherDadosNota()
        {
            label_VisualIdNotafiscal.Text = NotaFiscalId.ToString();
            label_VisualData.Text = Data.ToString();
            label_VisualNomeC.Text = ClienteNome;
            label_VisualTotal.Text = Total.ToString();

            Clientes cliente = contexto.Clientes.FirstOrDefault(c => c.NomeRazãoSocial == ClienteNome);
            if (cliente != null)
            {
                label_VisualTel.Text = cliente.Telefone;
                label_VisualCPF.Text = cliente.CpfCnpj;
                label_VisualRua.Text = cliente.Rua;
                label_VisualNum.Text = cliente.Numero.ToString();
                label_VisualBairro.Text = cliente.Bairro;
            }
            listView_VisualProdutosNota.Items.Clear();
            foreach (var produto in Produtos)
            {
                ListViewItem item = new ListViewItem(produto.Nome);
                item.SubItems.Add(produto.Quantidade.ToString());
                item.SubItems.Add(produto.ValorUnitario.ToString());
                listView_VisualProdutosNota.Items.Add(item);
            }
        }
    }
}
