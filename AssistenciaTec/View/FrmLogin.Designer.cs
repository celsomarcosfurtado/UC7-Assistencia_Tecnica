namespace AssistenciaTec.View
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtLogin = new TextBox();
            TxtSenha = new TextBox();
            label4 = new Label();
            BtnLogin = new Button();
            BtnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(37, 49);
            label1.Name = "label1";
            label1.Size = new Size(122, 51);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ScrollBar;
            label2.Location = new Point(48, 100);
            label2.Name = "label2";
            label2.Size = new Size(230, 15);
            label2.TabIndex = 1;
            label2.Text = "Forneça seus dados para acessar o sistema";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ScrollBar;
            label3.Location = new Point(48, 171);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 2;
            label3.Text = "Login do usuário";
            // 
            // TxtLogin
            // 
            TxtLogin.Font = new Font("Segoe UI", 14F);
            TxtLogin.Location = new Point(48, 189);
            TxtLogin.Name = "TxtLogin";
            TxtLogin.PlaceholderText = "Digite o seu e-mail aqui";
            TxtLogin.Size = new Size(254, 32);
            TxtLogin.TabIndex = 3;
            // 
            // TxtSenha
            // 
            TxtSenha.Font = new Font("Segoe UI", 14F);
            TxtSenha.Location = new Point(48, 256);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.PlaceholderText = "Digite a sua senha aqui";
            TxtSenha.Size = new Size(254, 32);
            TxtSenha.TabIndex = 5;
            TxtSenha.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ScrollBar;
            label4.Location = new Point(48, 238);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 4;
            label4.Text = "Senha do usuário";
            // 
            // BtnLogin
            // 
            BtnLogin.Image = (Image)resources.GetObject("BtnLogin.Image");
            BtnLogin.Location = new Point(247, 316);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(55, 45);
            BtnLogin.TabIndex = 6;
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Image = (Image)resources.GetObject("BtnCancelar.Image");
            BtnCancelar.Location = new Point(186, 316);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(55, 45);
            BtnCancelar.TabIndex = 7;
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(353, 404);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnLogin);
            Controls.Add(TxtSenha);
            Controls.Add(label4);
            Controls.Add(TxtLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autenticar usuário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtLogin;
        private TextBox TxtSenha;
        private Label label4;
        private Button BtnLogin;
        private Button BtnCancelar;
    }
}