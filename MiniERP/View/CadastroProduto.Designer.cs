namespace MiniERP
{
    partial class CadastroProduto
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
            button_ConsultaProduto = new Button();
            textBox_ConsultaProduto = new TextBox();
            button_FechaProduto = new Button();
            button_CadastroProduto = new Button();
            dataGridView_Produtos = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Produtos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(105, 37);
            label1.Name = "label1";
            label1.Size = new Size(47, 17);
            label1.TabIndex = 9;
            label1.Text = "Nome:";
            // 
            // button_ConsultaProduto
            // 
            button_ConsultaProduto.Location = new Point(469, 31);
            button_ConsultaProduto.Name = "button_ConsultaProduto";
            button_ConsultaProduto.Size = new Size(75, 23);
            button_ConsultaProduto.TabIndex = 8;
            button_ConsultaProduto.Text = "Consultar";
            button_ConsultaProduto.UseVisualStyleBackColor = true;
            button_ConsultaProduto.Click += button_ConsultaProduto_Click;
            // 
            // textBox_ConsultaProduto
            // 
            textBox_ConsultaProduto.Location = new Point(158, 31);
            textBox_ConsultaProduto.Name = "textBox_ConsultaProduto";
            textBox_ConsultaProduto.Size = new Size(303, 23);
            textBox_ConsultaProduto.TabIndex = 7;
            // 
            // button_FechaProduto
            // 
            button_FechaProduto.Location = new Point(431, 482);
            button_FechaProduto.Name = "button_FechaProduto";
            button_FechaProduto.Size = new Size(75, 23);
            button_FechaProduto.TabIndex = 13;
            button_FechaProduto.Text = "Fechar";
            button_FechaProduto.UseVisualStyleBackColor = true;
            button_FechaProduto.Click += button_FechaProduto_Click;
            // 
            // button_CadastroProduto
            // 
            button_CadastroProduto.Location = new Point(60, 482);
            button_CadastroProduto.Name = "button_CadastroProduto";
            button_CadastroProduto.Size = new Size(75, 23);
            button_CadastroProduto.TabIndex = 11;
            button_CadastroProduto.Text = "Cadastrar";
            button_CadastroProduto.UseVisualStyleBackColor = true;
            button_CadastroProduto.Click += button_CadastroProduto_Click;
            // 
            // dataGridView_Produtos
            // 
            dataGridView_Produtos.BackgroundColor = SystemColors.Control;
            dataGridView_Produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Produtos.Location = new Point(60, 68);
            dataGridView_Produtos.Name = "dataGridView_Produtos";
            dataGridView_Produtos.RowTemplate.Height = 25;
            dataGridView_Produtos.Size = new Size(446, 389);
            dataGridView_Produtos.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.adicionar_pacote;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(556, 520);
            Controls.Add(pictureBox1);
            Controls.Add(button_FechaProduto);
            Controls.Add(button_CadastroProduto);
            Controls.Add(dataGridView_Produtos);
            Controls.Add(label1);
            Controls.Add(button_ConsultaProduto);
            Controls.Add(textBox_ConsultaProduto);
            Name = "CadastroProduto";
            Text = "Cadastro de Produto";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Produtos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_ConsultaProduto;
        private TextBox textBox_ConsultaProduto;
        private Button button_FechaProduto;
        private Button button_CadastroProduto;
        private DataGridView dataGridView_Produtos;
        private PictureBox pictureBox1;
    }
}