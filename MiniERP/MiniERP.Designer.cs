namespace MiniERP
{
    partial class MiniERP
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniERP));
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            lancamentoToolStripMenuItem = new ToolStripMenuItem();
            lançamentoDeNotaToolStripMenuItem = new ToolStripMenuItem();
            consultarNotasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Turquoise;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, lancamentoToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(838, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, produtosToolStripMenuItem, fornecedoresToolStripMenuItem });
            cadastroToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cadastroToolStripMenuItem.ForeColor = SystemColors.ControlText;
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(84, 25);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.BackColor = Color.MediumTurquoise;
            clientesToolStripMenuItem.Image = Properties.Resources.cliente;
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(174, 26);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.BackColor = Color.MediumTurquoise;
            produtosToolStripMenuItem.Image = Properties.Resources.adicionar_pacote;
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(174, 26);
            produtosToolStripMenuItem.Text = "Produtos";
            produtosToolStripMenuItem.Click += produtosToolStripMenuItem_Click;
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.BackColor = Color.MediumTurquoise;
            fornecedoresToolStripMenuItem.Image = Properties.Resources.entregador;
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            fornecedoresToolStripMenuItem.Size = new Size(174, 26);
            fornecedoresToolStripMenuItem.Text = "Fornecedores";
            fornecedoresToolStripMenuItem.Click += fornecedoresToolStripMenuItem_Click;
            // 
            // lancamentoToolStripMenuItem
            // 
            lancamentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lançamentoDeNotaToolStripMenuItem, consultarNotasToolStripMenuItem });
            lancamentoToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lancamentoToolStripMenuItem.Name = "lancamentoToolStripMenuItem";
            lancamentoToolStripMenuItem.Size = new Size(112, 25);
            lancamentoToolStripMenuItem.Text = "Notas Fiscais";
            // 
            // lançamentoDeNotaToolStripMenuItem
            // 
            lançamentoDeNotaToolStripMenuItem.BackColor = Color.MediumTurquoise;
            lançamentoDeNotaToolStripMenuItem.Image = Properties.Resources.taxa;
            lançamentoDeNotaToolStripMenuItem.Name = "lançamentoDeNotaToolStripMenuItem";
            lançamentoDeNotaToolStripMenuItem.Size = new Size(224, 26);
            lançamentoDeNotaToolStripMenuItem.Text = "Lançamento de Nota";
            lançamentoDeNotaToolStripMenuItem.Click += lançamentoDeNotaToolStripMenuItem_Click;
            // 
            // consultarNotasToolStripMenuItem
            // 
            consultarNotasToolStripMenuItem.BackColor = Color.MediumTurquoise;
            consultarNotasToolStripMenuItem.Image = Properties.Resources.taxa;
            consultarNotasToolStripMenuItem.Name = "consultarNotasToolStripMenuItem";
            consultarNotasToolStripMenuItem.Size = new Size(224, 26);
            consultarNotasToolStripMenuItem.Text = "Consultar Notas";
            consultarNotasToolStripMenuItem.Click += consultarNotasToolStripMenuItem_Click;
            // 
            // MiniERP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ERP_explained_best_ERP_solutions_for_small_businesses;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(838, 489);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MiniERP";
            Text = "Mini ERP";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem lancamentoToolStripMenuItem;
        private ToolStripMenuItem lançamentoDeNotaToolStripMenuItem;
        private ToolStripMenuItem consultarNotasToolStripMenuItem;
    }
}