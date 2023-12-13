namespace MiniERP
{
    partial class FormularioCadastroFornecedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            maskedTextBox_TelefoneForncedor = new MaskedTextBox();
            textBox_NomeFornecedor = new TextBox();
            textBox_CPFCNPJFornecedor = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox_BairroFornecedor = new TextBox();
            textBox_NumeroFornecedor = new TextBox();
            label9 = new Label();
            label8 = new Label();
            textBox_RuaFornecedor = new TextBox();
            label7 = new Label();
            textBox_CidadeFornecedor = new TextBox();
            label6 = new Label();
            textBox_EstadoFornecedor = new TextBox();
            label5 = new Label();
            textBox_PaisFornecedor = new TextBox();
            label4 = new Label();
            button_CancelarCliente = new Button();
            button_AdicionarCliente = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskedTextBox_TelefoneForncedor);
            groupBox1.Controls.Add(textBox_NomeFornecedor);
            groupBox1.Controls.Add(textBox_CPFCNPJFornecedor);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(554, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do Fornecedor";
            // 
            // maskedTextBox_TelefoneForncedor
            // 
            maskedTextBox_TelefoneForncedor.Location = new Point(66, 79);
            maskedTextBox_TelefoneForncedor.Mask = "(99)00000-0000";
            maskedTextBox_TelefoneForncedor.Name = "maskedTextBox_TelefoneForncedor";
            maskedTextBox_TelefoneForncedor.Size = new Size(101, 23);
            maskedTextBox_TelefoneForncedor.TabIndex = 8;
            // 
            // textBox_NomeFornecedor
            // 
            textBox_NomeFornecedor.Location = new Point(127, 49);
            textBox_NomeFornecedor.Name = "textBox_NomeFornecedor";
            textBox_NomeFornecedor.Size = new Size(418, 23);
            textBox_NomeFornecedor.TabIndex = 4;
            // 
            // textBox_CPFCNPJFornecedor
            // 
            textBox_CPFCNPJFornecedor.Location = new Point(75, 22);
            textBox_CPFCNPJFornecedor.Name = "textBox_CPFCNPJFornecedor";
            textBox_CPFCNPJFornecedor.Size = new Size(182, 23);
            textBox_CPFCNPJFornecedor.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 87);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 57);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome/Razão social:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "CPF/CNPJ:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox_BairroFornecedor);
            groupBox2.Controls.Add(textBox_NumeroFornecedor);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox_RuaFornecedor);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox_CidadeFornecedor);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox_EstadoFornecedor);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox_PaisFornecedor);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 153);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 140);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Endereco do Fornecedor";
            // 
            // textBox_BairroFornecedor
            // 
            textBox_BairroFornecedor.Location = new Point(53, 86);
            textBox_BairroFornecedor.Name = "textBox_BairroFornecedor";
            textBox_BairroFornecedor.Size = new Size(235, 23);
            textBox_BairroFornecedor.TabIndex = 11;
            // 
            // textBox_NumeroFornecedor
            // 
            textBox_NumeroFornecedor.Location = new Point(631, 55);
            textBox_NumeroFornecedor.Name = "textBox_NumeroFornecedor";
            textBox_NumeroFornecedor.Size = new Size(52, 23);
            textBox_NumeroFornecedor.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 94);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 9;
            label9.Text = "Bairro:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(571, 63);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 8;
            label8.Text = "Numero:";
            // 
            // textBox_RuaFornecedor
            // 
            textBox_RuaFornecedor.Location = new Point(42, 55);
            textBox_RuaFornecedor.Name = "textBox_RuaFornecedor";
            textBox_RuaFornecedor.Size = new Size(509, 23);
            textBox_RuaFornecedor.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 63);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 6;
            label7.Text = "Rua:";
            // 
            // textBox_CidadeFornecedor
            // 
            textBox_CidadeFornecedor.Location = new Point(551, 21);
            textBox_CidadeFornecedor.Name = "textBox_CidadeFornecedor";
            textBox_CidadeFornecedor.Size = new Size(215, 23);
            textBox_CidadeFornecedor.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(498, 29);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 4;
            label6.Text = "Cidade:";
            // 
            // textBox_EstadoFornecedor
            // 
            textBox_EstadoFornecedor.Location = new Point(294, 21);
            textBox_EstadoFornecedor.Name = "textBox_EstadoFornecedor";
            textBox_EstadoFornecedor.Size = new Size(189, 23);
            textBox_EstadoFornecedor.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(243, 29);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 2;
            label5.Text = "Estado:";
            // 
            // textBox_PaisFornecedor
            // 
            textBox_PaisFornecedor.Location = new Point(46, 21);
            textBox_PaisFornecedor.Name = "textBox_PaisFornecedor";
            textBox_PaisFornecedor.Size = new Size(181, 23);
            textBox_PaisFornecedor.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 29);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 0;
            label4.Text = "País :";
            // 
            // button_CancelarCliente
            // 
            button_CancelarCliente.Location = new Point(713, 308);
            button_CancelarCliente.Name = "button_CancelarCliente";
            button_CancelarCliente.Size = new Size(75, 23);
            button_CancelarCliente.TabIndex = 5;
            button_CancelarCliente.Text = "Cancelar";
            button_CancelarCliente.UseVisualStyleBackColor = true;
            button_CancelarCliente.Click += button_CancelarCliente_Click;
            // 
            // button_AdicionarCliente
            // 
            button_AdicionarCliente.Location = new Point(632, 308);
            button_AdicionarCliente.Name = "button_AdicionarCliente";
            button_AdicionarCliente.Size = new Size(75, 23);
            button_AdicionarCliente.TabIndex = 4;
            button_AdicionarCliente.Text = "Ok";
            button_AdicionarCliente.UseVisualStyleBackColor = true;
            button_AdicionarCliente.Click += button_AdicionarCliente_Click;
            // 
            // FormularioCadastroFornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(799, 346);
            Controls.Add(button_CancelarCliente);
            Controls.Add(button_AdicionarCliente);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormularioCadastroFornecedores";
            Text = "FormularioCadastroFornecedores";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox_NomeFornecedor;
        private TextBox textBox_CPFCNPJFornecedor;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox textBox_BairroFornecedor;
        private TextBox textBox_NumeroFornecedor;
        private Label label9;
        private Label label8;
        private TextBox textBox_RuaFornecedor;
        private Label label7;
        private TextBox textBox_CidadeFornecedor;
        private Label label6;
        private TextBox textBox_EstadoFornecedor;
        private Label label5;
        private TextBox textBox_PaisFornecedor;
        private Label label4;
        private Button button_CancelarCliente;
        private Button button_AdicionarCliente;
        private MaskedTextBox maskedTextBox_TelefoneForncedor;
    }
}