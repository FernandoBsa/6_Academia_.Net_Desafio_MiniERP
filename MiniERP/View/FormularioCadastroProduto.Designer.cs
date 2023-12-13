namespace MiniERP
{
    partial class FormularioCadastroProduto
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
            comboBox_Produtos = new ComboBox();
            label5 = new Label();
            textBox_ValorProduto = new TextBox();
            label3 = new Label();
            textBox_MarcaProduto = new TextBox();
            label2 = new Label();
            textBox_NomeProduto = new TextBox();
            label1 = new Label();
            button_CancelarProduto = new Button();
            button_AdicionarProduto = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox_Produtos);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox_ValorProduto);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox_MarcaProduto);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox_NomeProduto);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(546, 147);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do Produto";
            // 
            // comboBox_Produtos
            // 
            comboBox_Produtos.FormattingEnabled = true;
            comboBox_Produtos.Location = new Point(141, 109);
            comboBox_Produtos.Name = "comboBox_Produtos";
            comboBox_Produtos.Size = new Size(121, 23);
            comboBox_Produtos.TabIndex = 9;
            comboBox_Produtos.DropDown += comboBox_Produtos_DropDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 117);
            label5.Name = "label5";
            label5.Size = new Size(129, 15);
            label5.TabIndex = 8;
            label5.Text = "Codigo do Fornecedor:";
            // 
            // textBox_ValorProduto
            // 
            textBox_ValorProduto.Location = new Point(97, 80);
            textBox_ValorProduto.Name = "textBox_ValorProduto";
            textBox_ValorProduto.Size = new Size(118, 23);
            textBox_ValorProduto.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 88);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 4;
            label3.Text = "Preço Unitário:";
            // 
            // textBox_MarcaProduto
            // 
            textBox_MarcaProduto.Location = new Point(55, 51);
            textBox_MarcaProduto.Name = "textBox_MarcaProduto";
            textBox_MarcaProduto.Size = new Size(241, 23);
            textBox_MarcaProduto.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 59);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Marca:";
            // 
            // textBox_NomeProduto
            // 
            textBox_NomeProduto.Location = new Point(55, 20);
            textBox_NomeProduto.Name = "textBox_NomeProduto";
            textBox_NomeProduto.Size = new Size(485, 23);
            textBox_NomeProduto.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // button_CancelarProduto
            // 
            button_CancelarProduto.Location = new Point(483, 166);
            button_CancelarProduto.Name = "button_CancelarProduto";
            button_CancelarProduto.Size = new Size(75, 23);
            button_CancelarProduto.TabIndex = 1;
            button_CancelarProduto.Text = "Cancelar";
            button_CancelarProduto.UseVisualStyleBackColor = true;
            button_CancelarProduto.Click += button_CancelarProduto_Click;
            // 
            // button_AdicionarProduto
            // 
            button_AdicionarProduto.Location = new Point(402, 166);
            button_AdicionarProduto.Name = "button_AdicionarProduto";
            button_AdicionarProduto.Size = new Size(75, 23);
            button_AdicionarProduto.TabIndex = 2;
            button_AdicionarProduto.Text = "Adicionar";
            button_AdicionarProduto.UseVisualStyleBackColor = true;
            button_AdicionarProduto.Click += button_AdicionarProduto_Click;
            // 
            // FormularioCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(570, 201);
            Controls.Add(button_AdicionarProduto);
            Controls.Add(button_CancelarProduto);
            Controls.Add(groupBox1);
            Name = "FormularioCadastroProduto";
            Text = "FormularioCadastroProduto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox_MarcaProduto;
        private Label label2;
        private TextBox textBox_NomeProduto;
        private Label label1;
        private TextBox textBox_ValorProduto;
        private Label label3;
        private Button button_CancelarProduto;
        private Button button_AdicionarProduto;
        private Label label5;
        private ComboBox comboBox_Produtos;
    }
}