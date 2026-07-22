using AssistenciaTec.Model;
using AssistenciaTec.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistenciaTec.View
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Criar o repositório de Usuario
            UsuarioRepository repositorio = new UsuarioRepository();

            Usuario usuario = repositorio.Login(TxtLogin.Text, TxtSenha.Text);

            if (usuario != null) {
                new FrmPrincipal().Show();
                this.Hide();
            } else
            {
                MessageBox.Show(
                    "Login falhou! E-mail ou senha incorretos.",
                    "Erro na autenticação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                TxtLogin.Focus();
            }
        }
    }
}
