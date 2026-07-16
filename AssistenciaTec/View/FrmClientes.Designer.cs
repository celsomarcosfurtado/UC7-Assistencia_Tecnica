namespace AssistenciaTec.View
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            GroupBoxDadosCliente = new GroupBox();
            TxtEndereco = new TextBox();
            label5 = new Label();
            TxtTelefone = new TextBox();
            label4 = new Label();
            TxtEmail = new TextBox();
            label2 = new Label();
            TxtNome = new TextBox();
            label3 = new Label();
            LabelId = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            DatagridViewClientes = new DataGridView();
            btnBuscar = new Button();
            textBox1 = new TextBox();
            label6 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripButtonNovo = new ToolStripButton();
            toolStripButtonEditar = new ToolStripButton();
            toolStripButtonExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButtonCancelar = new ToolStripButton();
            toolStripButtonSalvar = new ToolStripButton();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            GroupBoxDadosCliente.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DatagridViewClientes).BeginInit();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // GroupBoxDadosCliente
            // 
            GroupBoxDadosCliente.Controls.Add(TxtEndereco);
            GroupBoxDadosCliente.Controls.Add(label5);
            GroupBoxDadosCliente.Controls.Add(TxtTelefone);
            GroupBoxDadosCliente.Controls.Add(label4);
            GroupBoxDadosCliente.Controls.Add(TxtEmail);
            GroupBoxDadosCliente.Controls.Add(label2);
            GroupBoxDadosCliente.Controls.Add(TxtNome);
            GroupBoxDadosCliente.Controls.Add(label3);
            GroupBoxDadosCliente.Controls.Add(LabelId);
            GroupBoxDadosCliente.Controls.Add(label1);
            GroupBoxDadosCliente.Enabled = false;
            GroupBoxDadosCliente.Location = new Point(12, 75);
            GroupBoxDadosCliente.Name = "GroupBoxDadosCliente";
            GroupBoxDadosCliente.Size = new Size(316, 454);
            GroupBoxDadosCliente.TabIndex = 0;
            GroupBoxDadosCliente.TabStop = false;
            GroupBoxDadosCliente.Text = "Dados do cliente:";
            // 
            // TxtEndereco
            // 
            TxtEndereco.Location = new Point(18, 314);
            TxtEndereco.Multiline = true;
            TxtEndereco.Name = "TxtEndereco";
            TxtEndereco.Size = new Size(271, 124);
            TxtEndereco.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 293);
            label5.Name = "label5";
            label5.Size = new Size(168, 18);
            label5.TabIndex = 8;
            label5.Text = "Endereço do cliente:";
            // 
            // TxtTelefone
            // 
            TxtTelefone.Location = new Point(18, 253);
            TxtTelefone.Name = "TxtTelefone";
            TxtTelefone.Size = new Size(168, 25);
            TxtTelefone.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 232);
            label4.Name = "label4";
            label4.Size = new Size(168, 18);
            label4.TabIndex = 6;
            label4.Text = "Telefone do cliente:";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(18, 186);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(271, 25);
            TxtEmail.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 165);
            label2.Name = "label2";
            label2.Size = new Size(152, 18);
            label2.TabIndex = 4;
            label2.Text = "E-mail do cliente:";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(18, 122);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(271, 25);
            TxtNome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 101);
            label3.Name = "label3";
            label3.Size = new Size(136, 18);
            label3.TabIndex = 2;
            label3.Text = "Nome do cliente:";
            // 
            // LabelId
            // 
            LabelId.BackColor = Color.FromArgb(255, 192, 128);
            LabelId.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelId.Location = new Point(156, 42);
            LabelId.Name = "LabelId";
            LabelId.Size = new Size(69, 36);
            LabelId.TabIndex = 1;
            LabelId.Text = "458";
            LabelId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 51);
            label1.Name = "label1";
            label1.Size = new Size(120, 18);
            label1.TabIndex = 0;
            label1.Text = "ID do cliente:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DatagridViewClientes);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(334, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(508, 454);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de clientes cadastrados:";
            // 
            // DatagridViewClientes
            // 
            DatagridViewClientes.AllowUserToResizeColumns = false;
            DatagridViewClientes.AllowUserToResizeRows = false;
            DatagridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DatagridViewClientes.Location = new Point(15, 101);
            DatagridViewClientes.Name = "DatagridViewClientes";
            DatagridViewClientes.ReadOnly = true;
            DatagridViewClientes.Size = new Size(473, 337);
            DatagridViewClientes.TabIndex = 3;
            DatagridViewClientes.CellClick += DatagridViewClientes_CellClick;
            DatagridViewClientes.CellEnter += DatagridViewClientes_CellEnter;
            // 
            // btnBuscar
            // 
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(442, 43);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(46, 42);
            btnBuscar.TabIndex = 2;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(421, 25);
            textBox1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 31);
            label6.Name = "label6";
            label6.Size = new Size(200, 18);
            label6.TabIndex = 0;
            label6.Text = "Buscar cliente por nome:";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonNovo, toolStripButtonEditar, toolStripButtonExcluir, toolStripSeparator1, toolStripButtonCancelar, toolStripButtonSalvar });
            toolStrip1.Location = new Point(0, 543);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(854, 35);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNovo
            // 
            toolStripButtonNovo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonNovo.Image = (Image)resources.GetObject("toolStripButtonNovo.Image");
            toolStripButtonNovo.ImageTransparentColor = Color.Magenta;
            toolStripButtonNovo.Name = "toolStripButtonNovo";
            toolStripButtonNovo.Size = new Size(28, 32);
            toolStripButtonNovo.Text = "toolStripButton1";
            toolStripButtonNovo.ToolTipText = "Novo Cliente";
            toolStripButtonNovo.Click += toolStripButtonNovo_Click;
            // 
            // toolStripButtonEditar
            // 
            toolStripButtonEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonEditar.Image = (Image)resources.GetObject("toolStripButtonEditar.Image");
            toolStripButtonEditar.ImageTransparentColor = Color.Magenta;
            toolStripButtonEditar.Name = "toolStripButtonEditar";
            toolStripButtonEditar.Size = new Size(28, 32);
            toolStripButtonEditar.Text = "toolStripButton2";
            toolStripButtonEditar.ToolTipText = "Editar cliente selecioado";
            toolStripButtonEditar.Click += toolStripButtonEditar_Click;
            // 
            // toolStripButtonExcluir
            // 
            toolStripButtonExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonExcluir.Image = (Image)resources.GetObject("toolStripButtonExcluir.Image");
            toolStripButtonExcluir.ImageTransparentColor = Color.Magenta;
            toolStripButtonExcluir.Name = "toolStripButtonExcluir";
            toolStripButtonExcluir.Size = new Size(28, 32);
            toolStripButtonExcluir.Text = "toolStripButton3";
            toolStripButtonExcluir.ToolTipText = "Excluir cliente selecionado";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 35);
            // 
            // toolStripButtonCancelar
            // 
            toolStripButtonCancelar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonCancelar.Image = (Image)resources.GetObject("toolStripButtonCancelar.Image");
            toolStripButtonCancelar.ImageTransparentColor = Color.Magenta;
            toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            toolStripButtonCancelar.Size = new Size(28, 32);
            toolStripButtonCancelar.Text = "toolStripButton4";
            toolStripButtonCancelar.ToolTipText = "Cancelar operação";
            toolStripButtonCancelar.Click += toolStripButtonCancelar_Click;
            // 
            // toolStripButtonSalvar
            // 
            toolStripButtonSalvar.AutoSize = false;
            toolStripButtonSalvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSalvar.Image = (Image)resources.GetObject("toolStripButtonSalvar.Image");
            toolStripButtonSalvar.ImageTransparentColor = Color.Magenta;
            toolStripButtonSalvar.Name = "toolStripButtonSalvar";
            toolStripButtonSalvar.Size = new Size(32, 32);
            toolStripButtonSalvar.Text = "toolStripButton5";
            toolStripButtonSalvar.ToolTipText = "Gravar alterações";
            toolStripButtonSalvar.Click += toolStripButtonSalvar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(854, 61);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(75, 15);
            label7.Name = "label7";
            label7.Size = new Size(314, 32);
            label7.TabIndex = 0;
            label7.Text = "Cadastro de Clientes";
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 578);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Controls.Add(groupBox1);
            Controls.Add(GroupBoxDadosCliente);
            Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmClientes";
            GroupBoxDadosCliente.ResumeLayout(false);
            GroupBoxDadosCliente.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DatagridViewClientes).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GroupBoxDadosCliente;
        private Label LabelId;
        private Label label1;
        private Label label3;
        private TextBox TxtTelefone;
        private Label label4;
        private TextBox TxtEmail;
        private Label label2;
        private TextBox TxtNome;
        private TextBox TxtEndereco;
        private Label label5;
        private GroupBox groupBox1;
        private Label label6;
        private Button btnBuscar;
        private TextBox textBox1;
        private DataGridView DatagridViewClientes;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonNovo;
        private ToolStripButton toolStripButtonEditar;
        private ToolStripButton toolStripButtonExcluir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonCancelar;
        private ToolStripButton toolStripButtonSalvar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label7;
    }
}