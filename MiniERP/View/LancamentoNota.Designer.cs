namespace MiniERP.View
{
    partial class LancamentoNota
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
            ListViewItem listViewItem1 = new ListViewItem("");
            ListViewItem listViewItem2 = new ListViewItem("");
            ListViewItem listViewItem3 = new ListViewItem("");
            label1 = new Label();
            comboBox_ClienteNota = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            maskedTextBox_DataNota = new MaskedTextBox();
            comboBox_ProdutoNota = new ComboBox();
            textBox_QuantidadeNota = new TextBox();
            textBox_TotalNota = new TextBox();
            button_SalvarNota = new Button();
            button_FecharNota = new Button();
            button_AdicionarNota = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            listView_ProdutosNota = new ListView();
            ColumnHeader_NomeProdutoNota = new ColumnHeader();
            columnHeader_QuantidadeProdutoNota = new ColumnHeader();
            columnHeader_PrecoProdutoNota = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // comboBox_ClienteNota
            // 
            comboBox_ClienteNota.FormattingEnabled = true;
            comboBox_ClienteNota.Location = new Point(70, 36);
            comboBox_ClienteNota.Name = "comboBox_ClienteNota";
            comboBox_ClienteNota.Size = new Size(191, 23);
            comboBox_ClienteNota.TabIndex = 1;
            comboBox_ClienteNota.DropDown += comboBox_ClienteNota_DropDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 76);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 2;
            label2.Text = "Produto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(280, 39);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 3;
            label3.Text = "Data:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(280, 76);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 4;
            label4.Text = "Quantidade:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(18, 395);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 5;
            label5.Text = "Total:";
            // 
            // maskedTextBox_DataNota
            // 
            maskedTextBox_DataNota.Location = new Point(330, 36);
            maskedTextBox_DataNota.Mask = "00/00/0000";
            maskedTextBox_DataNota.Name = "maskedTextBox_DataNota";
            maskedTextBox_DataNota.ReadOnly = true;
            maskedTextBox_DataNota.Size = new Size(71, 23);
            maskedTextBox_DataNota.TabIndex = 7;
            maskedTextBox_DataNota.ValidatingType = typeof(DateTime);
            // 
            // comboBox_ProdutoNota
            // 
            comboBox_ProdutoNota.FormattingEnabled = true;
            comboBox_ProdutoNota.Location = new Point(77, 73);
            comboBox_ProdutoNota.Name = "comboBox_ProdutoNota";
            comboBox_ProdutoNota.Size = new Size(185, 23);
            comboBox_ProdutoNota.TabIndex = 8;
            comboBox_ProdutoNota.DropDown += comboBox_ProdutoNota_DropDown;
            // 
            // textBox_QuantidadeNota
            // 
            textBox_QuantidadeNota.Location = new Point(376, 73);
            textBox_QuantidadeNota.Name = "textBox_QuantidadeNota";
            textBox_QuantidadeNota.Size = new Size(100, 23);
            textBox_QuantidadeNota.TabIndex = 9;
            // 
            // textBox_TotalNota
            // 
            textBox_TotalNota.Location = new Point(69, 392);
            textBox_TotalNota.Name = "textBox_TotalNota";
            textBox_TotalNota.ReadOnly = true;
            textBox_TotalNota.Size = new Size(132, 23);
            textBox_TotalNota.TabIndex = 10;
            // 
            // button_SalvarNota
            // 
            button_SalvarNota.Location = new Point(633, 395);
            button_SalvarNota.Name = "button_SalvarNota";
            button_SalvarNota.Size = new Size(74, 23);
            button_SalvarNota.TabIndex = 11;
            button_SalvarNota.Text = "Salvar";
            button_SalvarNota.UseVisualStyleBackColor = true;
            button_SalvarNota.Click += button_SalvarNota_Click;
            // 
            // button_FecharNota
            // 
            button_FecharNota.Location = new Point(713, 396);
            button_FecharNota.Name = "button_FecharNota";
            button_FecharNota.Size = new Size(75, 23);
            button_FecharNota.TabIndex = 12;
            button_FecharNota.Text = "Fechar";
            button_FecharNota.UseVisualStyleBackColor = true;
            button_FecharNota.Click += button_FecharNota_Click;
            // 
            // button_AdicionarNota
            // 
            button_AdicionarNota.Location = new Point(495, 73);
            button_AdicionarNota.Name = "button_AdicionarNota";
            button_AdicionarNota.Size = new Size(74, 23);
            button_AdicionarNota.TabIndex = 14;
            button_AdicionarNota.Text = "Adicionar";
            button_AdicionarNota.UseVisualStyleBackColor = true;
            button_AdicionarNota.Click += button_AdicionarNota_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button_AdicionarNota);
            groupBox1.Controls.Add(comboBox_ClienteNota);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox_QuantidadeNota);
            groupBox1.Controls.Add(maskedTextBox_DataNota);
            groupBox1.Controls.Add(comboBox_ProdutoNota);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 132);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Da Nota Fiscal";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView_ProdutosNota);
            groupBox2.Location = new Point(12, 150);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(775, 201);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Produtos da Nota";
            // 
            // listView_ProdutosNota
            // 
            listView_ProdutosNota.Columns.AddRange(new ColumnHeader[] { ColumnHeader_NomeProdutoNota, columnHeader_QuantidadeProdutoNota, columnHeader_PrecoProdutoNota });
            listView_ProdutosNota.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            listView_ProdutosNota.Location = new Point(6, 22);
            listView_ProdutosNota.Name = "listView_ProdutosNota";
            listView_ProdutosNota.Size = new Size(763, 173);
            listView_ProdutosNota.TabIndex = 0;
            listView_ProdutosNota.UseCompatibleStateImageBehavior = false;
            listView_ProdutosNota.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader_NomeProdutoNota
            // 
            ColumnHeader_NomeProdutoNota.Text = "Nome";
            ColumnHeader_NomeProdutoNota.Width = 300;
            // 
            // columnHeader_QuantidadeProdutoNota
            // 
            columnHeader_QuantidadeProdutoNota.Text = "Quantidade";
            columnHeader_QuantidadeProdutoNota.Width = 200;
            // 
            // columnHeader_PrecoProdutoNota
            // 
            columnHeader_PrecoProdutoNota.Text = "Valor Unitario";
            columnHeader_PrecoProdutoNota.Width = 300;
            // 
            // LancamentoNota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(799, 430);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button_SalvarNota);
            Controls.Add(button_FecharNota);
            Controls.Add(label5);
            Controls.Add(textBox_TotalNota);
            Name = "LancamentoNota";
            Text = "Lancamento de Nota";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox_ClienteNota;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaskedTextBox maskedTextBox_DataNota;
        private ComboBox comboBox_ProdutoNota;
        private TextBox textBox_QuantidadeNota;
        private TextBox textBox_TotalNota;
        private Button button_SalvarNota;
        private Button button_FecharNota;
        private Button button_AdicionarNota;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListView listView_ProdutosNota;
        private ColumnHeader ColumnHeader_NomeProdutoNota;
        private ColumnHeader columnHeader_QuantidadeProdutoNota;
        private ColumnHeader columnHeader_PrecoProdutoNota;
    }
}