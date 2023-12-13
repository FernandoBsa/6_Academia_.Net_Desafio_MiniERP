namespace MiniERP
{
    partial class FormularioCadastroCliente
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
            maskedTextBox_TelefoneCliente = new MaskedTextBox();
            label3 = new Label();
            textBox_NomeCliente = new TextBox();
            label2 = new Label();
            textBox_ClienteCPF = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox_BairroCliente = new TextBox();
            textBox_NumeroCliente = new TextBox();
            label9 = new Label();
            label8 = new Label();
            textBox_RuaCliente = new TextBox();
            label7 = new Label();
            textBox_CidadeCliente = new TextBox();
            label6 = new Label();
            textBox_EstadoCliente = new TextBox();
            label5 = new Label();
            textBox_PaisCliente = new TextBox();
            label4 = new Label();
            button_AdicionarCliente = new Button();
            button_CancelarCliente = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskedTextBox_TelefoneCliente);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox_NomeCliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox_ClienteCPF);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 117);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do Cliente";
            // 
            // maskedTextBox_TelefoneCliente
            // 
            maskedTextBox_TelefoneCliente.Location = new Point(66, 77);
            maskedTextBox_TelefoneCliente.Mask = "(99)00000-0000";
            maskedTextBox_TelefoneCliente.Name = "maskedTextBox_TelefoneCliente";
            maskedTextBox_TelefoneCliente.Size = new Size(101, 23);
            maskedTextBox_TelefoneCliente.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 83);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Telefone:";
            // 
            // textBox_NomeCliente
            // 
            textBox_NomeCliente.Location = new Point(124, 45);
            textBox_NomeCliente.Name = "textBox_NomeCliente";
            textBox_NomeCliente.Size = new Size(642, 23);
            textBox_NomeCliente.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 53);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome/Razão social:";
            // 
            // textBox_ClienteCPF
            // 
            textBox_ClienteCPF.Location = new Point(75, 16);
            textBox_ClienteCPF.MaxLength = 14;
            textBox_ClienteCPF.Name = "textBox_ClienteCPF";
            textBox_ClienteCPF.Size = new Size(187, 23);
            textBox_ClienteCPF.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "CPF/CNPJ:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox_BairroCliente);
            groupBox2.Controls.Add(textBox_NumeroCliente);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox_RuaCliente);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox_CidadeCliente);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox_EstadoCliente);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox_PaisCliente);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 135);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 140);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Endereco do Cliente";
            // 
            // textBox_BairroCliente
            // 
            textBox_BairroCliente.Location = new Point(53, 86);
            textBox_BairroCliente.Name = "textBox_BairroCliente";
            textBox_BairroCliente.Size = new Size(235, 23);
            textBox_BairroCliente.TabIndex = 11;
            // 
            // textBox_NumeroCliente
            // 
            textBox_NumeroCliente.Location = new Point(631, 55);
            textBox_NumeroCliente.Name = "textBox_NumeroCliente";
            textBox_NumeroCliente.Size = new Size(52, 23);
            textBox_NumeroCliente.TabIndex = 10;
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
            // textBox_RuaCliente
            // 
            textBox_RuaCliente.Location = new Point(42, 55);
            textBox_RuaCliente.Name = "textBox_RuaCliente";
            textBox_RuaCliente.Size = new Size(509, 23);
            textBox_RuaCliente.TabIndex = 7;
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
            // textBox_CidadeCliente
            // 
            textBox_CidadeCliente.Location = new Point(551, 21);
            textBox_CidadeCliente.Name = "textBox_CidadeCliente";
            textBox_CidadeCliente.Size = new Size(215, 23);
            textBox_CidadeCliente.TabIndex = 5;
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
            // textBox_EstadoCliente
            // 
            textBox_EstadoCliente.Location = new Point(294, 21);
            textBox_EstadoCliente.Name = "textBox_EstadoCliente";
            textBox_EstadoCliente.Size = new Size(189, 23);
            textBox_EstadoCliente.TabIndex = 3;
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
            // textBox_PaisCliente
            // 
            textBox_PaisCliente.Location = new Point(46, 21);
            textBox_PaisCliente.Name = "textBox_PaisCliente";
            textBox_PaisCliente.Size = new Size(181, 23);
            textBox_PaisCliente.TabIndex = 1;
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
            // button_AdicionarCliente
            // 
            button_AdicionarCliente.Location = new Point(632, 291);
            button_AdicionarCliente.Name = "button_AdicionarCliente";
            button_AdicionarCliente.Size = new Size(75, 23);
            button_AdicionarCliente.TabIndex = 2;
            button_AdicionarCliente.Text = "Ok";
            button_AdicionarCliente.UseVisualStyleBackColor = true;
            button_AdicionarCliente.Click += button_AdicionarCliente_Click;
            // 
            // button_CancelarCliente
            // 
            button_CancelarCliente.Location = new Point(713, 291);
            button_CancelarCliente.Name = "button_CancelarCliente";
            button_CancelarCliente.Size = new Size(75, 23);
            button_CancelarCliente.TabIndex = 3;
            button_CancelarCliente.Text = "Cancelar";
            button_CancelarCliente.UseVisualStyleBackColor = true;
            button_CancelarCliente.Click += button_CancelarCliente_Click;
            // 
            // FormularioCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(800, 335);
            Controls.Add(button_CancelarCliente);
            Controls.Add(button_AdicionarCliente);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "FormularioCadastroCliente";
            Text = "Formulario Cadastro de Cliente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private MaskedTextBox maskedTextBox_TelefoneCliente;
        private Label label3;
        private TextBox textBox_NomeCliente;
        private Label label2;
        private TextBox textBox_ClienteCPF;
        private Label label8;
        private TextBox textBox_RuaCliente;
        private Label label7;
        private TextBox textBox_CidadeCliente;
        private Label label6;
        private TextBox textBox_EstadoCliente;
        private Label label5;
        private TextBox textBox_PaisCliente;
        private Label label4;
        private TextBox textBox_BairroCliente;
        private TextBox textBox_NumeroCliente;
        private Label label9;
        private Button button_AdicionarCliente;
        private Button button_CancelarCliente;
    }
}