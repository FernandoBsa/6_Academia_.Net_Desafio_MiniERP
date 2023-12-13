namespace MiniERP.View
{
    partial class ConsultarNotasFiscais
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button_FecharFornecedores = new Button();
            button_ConsultaForncedor = new Button();
            textBox_ConsultaNotaFiscal = new TextBox();
            dataGridView_NotasFiscais = new DataGridView();
            button_VisualizarNota = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_NotasFiscais).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.taxa;
            pictureBox1.Location = new Point(21, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(102, 41);
            label1.Name = "label1";
            label1.Size = new Size(75, 17);
            label1.TabIndex = 20;
            label1.Text = "ID da Nota:";
            // 
            // button_FecharFornecedores
            // 
            button_FecharFornecedores.Location = new Point(382, 467);
            button_FecharFornecedores.Name = "button_FecharFornecedores";
            button_FecharFornecedores.Size = new Size(75, 23);
            button_FecharFornecedores.TabIndex = 19;
            button_FecharFornecedores.Text = "Fechar";
            button_FecharFornecedores.UseVisualStyleBackColor = true;
            button_FecharFornecedores.Click += button_FecharFornecedores_Click;
            // 
            // button_ConsultaForncedor
            // 
            button_ConsultaForncedor.Location = new Point(368, 35);
            button_ConsultaForncedor.Name = "button_ConsultaForncedor";
            button_ConsultaForncedor.Size = new Size(75, 23);
            button_ConsultaForncedor.TabIndex = 17;
            button_ConsultaForncedor.Text = "Consultar";
            button_ConsultaForncedor.UseVisualStyleBackColor = true;
            button_ConsultaForncedor.Click += button_ConsultaForncedor_Click;
            // 
            // textBox_ConsultaNotaFiscal
            // 
            textBox_ConsultaNotaFiscal.Location = new Point(183, 35);
            textBox_ConsultaNotaFiscal.Name = "textBox_ConsultaNotaFiscal";
            textBox_ConsultaNotaFiscal.Size = new Size(179, 23);
            textBox_ConsultaNotaFiscal.TabIndex = 16;
            // 
            // dataGridView_NotasFiscais
            // 
            dataGridView_NotasFiscais.BackgroundColor = SystemColors.Control;
            dataGridView_NotasFiscais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_NotasFiscais.Location = new Point(7, 64);
            dataGridView_NotasFiscais.Name = "dataGridView_NotasFiscais";
            dataGridView_NotasFiscais.RowTemplate.Height = 25;
            dataGridView_NotasFiscais.Size = new Size(450, 389);
            dataGridView_NotasFiscais.TabIndex = 15;
            // 
            // button_VisualizarNota
            // 
            button_VisualizarNota.Location = new Point(7, 467);
            button_VisualizarNota.Name = "button_VisualizarNota";
            button_VisualizarNota.Size = new Size(75, 23);
            button_VisualizarNota.TabIndex = 22;
            button_VisualizarNota.Text = "Visualizar";
            button_VisualizarNota.UseVisualStyleBackColor = true;
            button_VisualizarNota.Click += button_VisualizarNota_Click;
            // 
            // ConsultarNotasFiscais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(469, 502);
            Controls.Add(button_VisualizarNota);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button_FecharFornecedores);
            Controls.Add(button_ConsultaForncedor);
            Controls.Add(textBox_ConsultaNotaFiscal);
            Controls.Add(dataGridView_NotasFiscais);
            Name = "ConsultarNotasFiscais";
            Text = "Consultar Notas Fiscais";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_NotasFiscais).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button_FecharFornecedores;
        private Button button_ConsultaForncedor;
        private TextBox textBox_ConsultaNotaFiscal;
        private DataGridView dataGridView_NotasFiscais;
        private Button button_VisualizarNota;
    }
}