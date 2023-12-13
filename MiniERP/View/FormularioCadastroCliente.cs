using MiniERP.Model;

namespace MiniERP
{
    public partial class FormularioCadastroCliente : Form
    {
        MiniErp2Context contexto = new MiniErp2Context();
        public FormularioCadastroCliente()
        {
            InitializeComponent();
        }

        private void button_AdicionarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes novoCliente = new Clientes();
                string cpf = textBox_ClienteCPF.Text.Trim();

                if (contexto.Clientes.Any(c => c.CpfCnpj == cpf))
                {
                    MessageBox.Show("Cliente já cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                novoCliente.CpfCnpj = textBox_ClienteCPF.Text;
                novoCliente.NomeRazãoSocial = textBox_NomeCliente.Text;
                novoCliente.Telefone = maskedTextBox_TelefoneCliente.Text;
                novoCliente.Pais = textBox_PaisCliente.Text;
                novoCliente.Estado = textBox_EstadoCliente.Text;
                novoCliente.Cidade = textBox_CidadeCliente.Text;
                novoCliente.Rua = textBox_RuaCliente.Text;
                if (!string.IsNullOrWhiteSpace(textBox_NumeroCliente.Text) && int.TryParse(textBox_NumeroCliente.Text, out int numero))
                {
                    novoCliente.Numero = numero;
                }
                else
                {
                    novoCliente.Numero = null;
                }
                novoCliente.Bairro = textBox_BairroCliente.Text;

                contexto.Clientes.Add(novoCliente);
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
            textBox_ClienteCPF.Clear();
            textBox_NomeCliente.Clear();
            maskedTextBox_TelefoneCliente.Clear();
            textBox_PaisCliente.Clear();
            textBox_EstadoCliente.Clear();
            textBox_CidadeCliente.Clear();
            textBox_RuaCliente.Clear();
            textBox_NumeroCliente.Clear();
            textBox_BairroCliente.Clear();
        }

        private void button_CancelarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
