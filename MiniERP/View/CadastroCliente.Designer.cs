namespace MiniERP
{
    partial class CadastroCliente
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
            dataGridView_Clientes = new DataGridView();
            textBox_ConsultaCliente = new TextBox();
            button_ConsultaCliente = new Button();
            button_CadastroCliente = new Button();
            button_FechaCliente = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Clientes
            // 
            dataGridView_Clientes.BackgroundColor = SystemColors.Control;
            dataGridView_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Clientes.Location = new Point(12, 68);
            dataGridView_Clientes.Name = "dataGridView_Clientes";
            dataGridView_Clientes.RowTemplate.Height = 25;
            dataGridView_Clientes.Size = new Size(851, 389);
            dataGridView_Clientes.TabIndex = 0;
            // 
            // textBox_ConsultaCliente
            // 
            textBox_ConsultaCliente.Location = new Point(161, 39);
            textBox_ConsultaCliente.Name = "textBox_ConsultaCliente";
            textBox_ConsultaCliente.Size = new Size(466, 23);
            textBox_ConsultaCliente.TabIndex = 1;
            // 
            // button_ConsultaCliente
            // 
            button_ConsultaCliente.Location = new Point(658, 39);
            button_ConsultaCliente.Name = "button_ConsultaCliente";
            button_ConsultaCliente.Size = new Size(75, 23);
            button_ConsultaCliente.TabIndex = 2;
            button_ConsultaCliente.Text = "Consultar";
            button_ConsultaCliente.UseVisualStyleBackColor = true;
            button_ConsultaCliente.Click += button_ConsultaCliente_Click;
            // 
            // button_CadastroCliente
            // 
            button_CadastroCliente.Location = new Point(12, 476);
            button_CadastroCliente.Name = "button_CadastroCliente";
            button_CadastroCliente.Size = new Size(75, 23);
            button_CadastroCliente.TabIndex = 3;
            button_CadastroCliente.Text = "Cadastrar";
            button_CadastroCliente.UseVisualStyleBackColor = true;
            button_CadastroCliente.Click += button_CadastroCliente_Click;
            // 
            // button_FechaCliente
            // 
            button_FechaCliente.Location = new Point(788, 476);
            button_FechaCliente.Name = "button_FechaCliente";
            button_FechaCliente.Size = new Size(75, 23);
            button_FechaCliente.TabIndex = 5;
            button_FechaCliente.Text = "Fechar";
            button_FechaCliente.UseVisualStyleBackColor = true;
            button_FechaCliente.Click += button_FechaCliente_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(108, 45);
            label1.Name = "label1";
            label1.Size = new Size(47, 17);
            label1.TabIndex = 6;
            label1.Text = "Nome:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cliente;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(875, 510);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button_FechaCliente);
            Controls.Add(button_CadastroCliente);
            Controls.Add(button_ConsultaCliente);
            Controls.Add(textBox_ConsultaCliente);
            Controls.Add(dataGridView_Clientes);
            MaximizeBox = false;
            Name = "CadastroCliente";
            Text = "Cadastro de Clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_Clientes;
        private TextBox textBox_ConsultaCliente;
        private Button button_ConsultaCliente;
        private Button button_CadastroCliente;
        private Button button_FechaCliente;
        private Label label1;
        private PictureBox pictureBox1;
    }
}