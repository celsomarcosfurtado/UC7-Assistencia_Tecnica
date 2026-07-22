using AssistenciaTec.Data;
using AssistenciaTec.View;

namespace AssistenciaTec
{
    public partial class FrmPrincipal : Form
    {

        private FrmClientes frmClientes = null;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void MenuItemConectar_Click(object sender, EventArgs e)
        {
            Conexao.GetConexao();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (frmClientes == null || frmClientes.IsDisposed)
            {
                frmClientes = new FrmClientes();
                frmClientes.MdiParent = this;
                frmClientes.Show();
            }
            else
            {
                if (frmClientes.WindowState == FormWindowState.Minimized)
                {
                    frmClientes.WindowState = FormWindowState.Normal;
                }
            }

        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {

            var resposta = MessageBox.Show(
                "Deseja realmente fechar a aplicação?",
                "Fechar a aplicação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
