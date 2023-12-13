using MiniERP.View;

namespace MiniERP
{
    public partial class MiniERP : Form
    {
        public MiniERP()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProduto cadastroProduto = new CadastroProduto();
            cadastroProduto.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroForncedor cadastroForncedor = new CadastroForncedor();
            cadastroForncedor.Show();
        }

        private void lançamentoDeNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LancamentoNota lancamentoNota = new LancamentoNota();
            lancamentoNota.Show();
        }

        private void consultarNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarNotasFiscais consultarNotasFiscais = new ConsultarNotasFiscais();
            consultarNotasFiscais.Show();
        }
    }
}