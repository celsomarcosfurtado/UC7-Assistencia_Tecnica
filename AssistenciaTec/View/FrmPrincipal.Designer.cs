namespace AssistenciaTec
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            TsmPrincipal = new MenuStrip();
            MenuItemArquivo = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            MenuItemCadastro = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            técnicosToolStripMenuItem = new ToolStripMenuItem();
            MenuItemOS = new ToolStripMenuItem();
            oSToolStripMenuItem = new ToolStripMenuItem();
            MenuItemConectar = new ToolStripMenuItem();
            TsmPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // TsmPrincipal
            // 
            TsmPrincipal.Items.AddRange(new ToolStripItem[] { MenuItemArquivo, MenuItemCadastro, MenuItemOS, MenuItemConectar });
            TsmPrincipal.Location = new Point(0, 0);
            TsmPrincipal.Name = "TsmPrincipal";
            TsmPrincipal.Size = new Size(842, 24);
            TsmPrincipal.TabIndex = 1;
            TsmPrincipal.Text = "menuStrip1";
            // 
            // MenuItemArquivo
            // 
            MenuItemArquivo.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            MenuItemArquivo.Name = "MenuItemArquivo";
            MenuItemArquivo.Size = new Size(61, 20);
            MenuItemArquivo.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(93, 22);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // MenuItemCadastro
            // 
            MenuItemCadastro.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, técnicosToolStripMenuItem });
            MenuItemCadastro.Name = "MenuItemCadastro";
            MenuItemCadastro.Size = new Size(66, 20);
            MenuItemCadastro.Text = "Cadastro";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(180, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // técnicosToolStripMenuItem
            // 
            técnicosToolStripMenuItem.Name = "técnicosToolStripMenuItem";
            técnicosToolStripMenuItem.Size = new Size(180, 22);
            técnicosToolStripMenuItem.Text = "Técnicos";
            // 
            // MenuItemOS
            // 
            MenuItemOS.DropDownItems.AddRange(new ToolStripItem[] { oSToolStripMenuItem });
            MenuItemOS.Name = "MenuItemOS";
            MenuItemOS.Size = new Size(34, 20);
            MenuItemOS.Text = "OS";
            // 
            // oSToolStripMenuItem
            // 
            oSToolStripMenuItem.Name = "oSToolStripMenuItem";
            oSToolStripMenuItem.Size = new Size(120, 22);
            oSToolStripMenuItem.Text = "Nova OS";
            // 
            // MenuItemConectar
            // 
            MenuItemConectar.Name = "MenuItemConectar";
            MenuItemConectar.Size = new Size(67, 20);
            MenuItemConectar.Text = "Conectar";
            MenuItemConectar.Click += MenuItemConectar_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 425);
            Controls.Add(TsmPrincipal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = TsmPrincipal;
            Name = "FrmPrincipal";
            Text = "Gestão de Ordens de Serviço";
            WindowState = FormWindowState.Maximized;
            TsmPrincipal.ResumeLayout(false);
            TsmPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip TsmPrincipal;
        private ToolStripMenuItem MenuItemArquivo;
        private ToolStripMenuItem MenuItemCadastro;
        private ToolStripMenuItem MenuItemOS;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem técnicosToolStripMenuItem;
        private ToolStripMenuItem oSToolStripMenuItem;
        private ToolStripMenuItem MenuItemConectar;
    }
}
