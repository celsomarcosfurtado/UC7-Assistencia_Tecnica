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
    public partial class FrmClientes : Form
    {

        private List<Cliente> clientes = new List<Cliente>();

        public FrmClientes()
        {
            InitializeComponent();
            DesabilitarBotoesCancelarSalvar();
            CarregarGridClientes();
        }

        private void CarregarGridClientes()
        {
            // Criar o repositório
            ClienteRepository clienteRepository = new ClienteRepository();

            // Obter a lista do repositório
            clientes = clienteRepository.ListarTodos();

            // Carregar o DatagridView com os dados
            DatagridViewClientes.Columns.Clear();
            DatagridViewClientes.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colunaId = new DataGridViewTextBoxColumn();
            colunaId.DataPropertyName = "Id";
            colunaId.HeaderText = "Código";
            DatagridViewClientes.Columns.Add(colunaId);

            DataGridViewTextBoxColumn colunaNome = new DataGridViewTextBoxColumn();
            colunaNome.DataPropertyName = "Nome";
            colunaNome.HeaderText = "Nome do cliente";
            DatagridViewClientes.Columns.Add(colunaNome);

            // Informar de onde vem os dados da datagridview
            DatagridViewClientes.DataSource = clientes;

        }

        private void DesabilitarBotoesCancelarSalvar()
        {
            toolStripButtonNovo.Enabled = true;
            toolStripButtonEditar.Enabled = true;
            toolStripButtonExcluir.Enabled = true;
            toolStripButtonSalvar.Enabled = false;
            toolStripButtonCancelar.Enabled = false;
            GroupBoxDadosCliente.Enabled = false;
        }

        private void HabilitarBotoesCancelarSalvar()
        {
            toolStripButtonNovo.Enabled = false;
            toolStripButtonEditar.Enabled = false;
            toolStripButtonExcluir.Enabled = false;
            toolStripButtonSalvar.Enabled = true;
            toolStripButtonCancelar.Enabled = true;
            GroupBoxDadosCliente.Enabled = true;
        }

        private void toolStripButtonNovo_Click(object sender, EventArgs e)
        {
            HabilitarBotoesCancelarSalvar();
            LimparCampos();
        }

        private void LimparCampos()
        {
            TxtNome.Clear();
            TxtEmail.Clear();
            TxtEndereco.Clear();
            TxtTelefone.Clear();
            LabelId.Text = "";
            TxtNome.Focus();
        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            HabilitarBotoesCancelarSalvar();
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarBotoesCancelarSalvar();
        }

        private void toolStripButtonSalvar_Click(object sender, EventArgs e)
        {

            // Criar um objeto Cliente
            Cliente cliente = new Cliente();
            cliente.Nome = TxtNome.Text;
            cliente.Telefone = TxtTelefone.Text;
            cliente.Email = TxtEmail.Text;
            cliente.Endereco = TxtEndereco.Text;

            // Criar um repositório de cliente
            ClienteRepository clienteRepository = new ClienteRepository();
            var clienteId = clienteRepository.Salvar(cliente);

            // Mostrar o id do novo cliente cadastrado
            LabelId.Text = clienteId.ToString();

            DesabilitarBotoesCancelarSalvar();
        }
    }
}
