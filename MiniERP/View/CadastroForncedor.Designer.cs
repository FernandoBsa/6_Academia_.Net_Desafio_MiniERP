namespace MiniERP
{
    partial class CadastroForncedor
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
            label1 = new Label();
            button_FecharFornecedores = new Button();
            button_CadastroForncedor = new Button();
            button_ConsultaForncedor = new Button();
            textBox_ConsultaFornecedor = new TextBox();
            dataGridView_Fornecedores = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Fornecedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(107, 45);
            label1.Name = "label1";
            label1.Size = new Size(47, 17);
            label1.TabIndex = 13;
            label1.Text = "Nome:";
            // 
            // button_FecharFornecedores
            // 
            button_FecharFornecedores.Location = new Point(788, 476);
            button_FecharFornecedores.Name = "button_FecharFornecedores";
            button_FecharFornecedores.Size = new Size(75, 23);
            button_FecharFornecedores.TabIndex = 12;
            button_FecharFornecedores.Text = "Fechar";
            button_FecharFornecedores.UseVisualStyleBackColor = true;
            button_FecharFornecedores.Click += button_FecharFornecedores_Click;
            // 
            // button_CadastroForncedor
            // 
            button_CadastroForncedor.Location = new Point(12, 476);
            button_CadastroForncedor.Name = "button_CadastroForncedor";
            button_CadastroForncedor.Size = new Size(75, 23);
            button_CadastroForncedor.TabIndex = 10;
            button_CadastroForncedor.Text = "Cadastrar";
            button_CadastroForncedor.UseVisualStyleBackColor = true;
            button_CadastroForncedor.Click += button_CadastroForncedor_Click;
            // 
            // button_ConsultaForncedor
            // 
            button_ConsultaForncedor.Location = new Point(632, 39);
            button_ConsultaForncedor.Name = "button_ConsultaForncedor";
            button_ConsultaForncedor.Size = new Size(75, 23);
            button_ConsultaForncedor.TabIndex = 9;
            button_ConsultaForncedor.Text = "Consultar";
            button_ConsultaForncedor.UseVisualStyleBackColor = true;
            button_ConsultaForncedor.Click += button_ConsultaForncedor_Click;
            // 
            // textBox_ConsultaFornecedor
            // 
            textBox_ConsultaFornecedor.Location = new Point(160, 39);
            textBox_ConsultaFornecedor.Name = "textBox_ConsultaFornecedor";
            textBox_ConsultaFornecedor.Size = new Size(466, 23);
            textBox_ConsultaFornecedor.TabIndex = 8;
            // 
            // dataGridView_Fornecedores
            // 
            dataGridView_Fornecedores.BackgroundColor = SystemColors.Control;
            dataGridView_Fornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Fornecedores.Location = new Point(12, 68);
            dataGridView_Fornecedores.Name = "dataGridView_Fornecedores";
            dataGridView_Fornecedores.RowTemplate.Height = 25;
            dataGridView_Fornecedores.Size = new Size(851, 389);
            dataGridView_Fornecedores.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.entregador;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // CadastroForncedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(875, 520);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button_FecharFornecedores);
            Controls.Add(button_CadastroForncedor);
            Controls.Add(button_ConsultaForncedor);
            Controls.Add(textBox_ConsultaFornecedor);
            Controls.Add(dataGridView_Fornecedores);
            Name = "CadastroForncedor";
            Text = "Cadastro de Forncedor";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Fornecedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_FecharFornecedores;
        private Button button_CadastroForncedor;
        private Button button_ConsultaForncedor;
        private TextBox textBox_ConsultaFornecedor;
        private DataGridView dataGridView_Fornecedores;
        private PictureBox pictureBox1;
    }
}