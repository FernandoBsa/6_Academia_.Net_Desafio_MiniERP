using MiniERP.Model;

namespace MiniERP
{
    public partial class FormularioCadastroFornecedores : Form
    {
        MiniErp2Context contexto = new MiniErp2Context();
        public FormularioCadastroFornecedores()
        {
            InitializeComponent();
        }

        private void button_AdicionarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Fornecedores novoFornecedor = new Fornecedores();
                string cpf = textBox_CPFCNPJFornecedor.Text.Trim();

                if (contexto.Clientes.Any(c => c.CpfCnpj == cpf))
                {
                    MessageBox.Show("Cliente já cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                novoFornecedor.CpfCnpj = textBox_CPFCNPJFornecedor.Text;
                novoFornecedor.NomeRazãoSocial = textBox_NomeFornecedor.Text;
                novoFornecedor.Telefone = maskedTextBox_TelefoneForncedor.Text;
                novoFornecedor.Pais = textBox_PaisFornecedor.Text;
                novoFornecedor.Estado = textBox_EstadoFornecedor.Text;
                novoFornecedor.Cidade = textBox_CidadeFornecedor.Text;
                novoFornecedor.Rua = textBox_RuaFornecedor.Text;
                if (!string.IsNullOrWhiteSpace(textBox_NumeroFornecedor.Text) && int.TryParse(textBox_NumeroFornecedor.Text, out int numero))
                {
                    novoFornecedor.Numero = numero;
                }
                else
                {
                    novoFornecedor.Numero = null;
                }
                novoFornecedor.Bairro = textBox_BairroFornecedor.Text;

                contexto.Fornecedores.Add(novoFornecedor);
                contexto.SaveChanges();
                LimparCampos();
                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar o Cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            textBox_CPFCNPJFornecedor.Clear();
            textBox_NomeFornecedor.Clear();
            maskedTextBox_TelefoneForncedor.Clear();
            textBox_PaisFornecedor.Clear();
            textBox_EstadoFornecedor.Clear();
            textBox_CidadeFornecedor.Clear();
            textBox_RuaFornecedor.Clear();
            textBox_NumeroFornecedor.Clear();
            textBox_BairroFornecedor.Clear();
        }

        private void button_CancelarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
