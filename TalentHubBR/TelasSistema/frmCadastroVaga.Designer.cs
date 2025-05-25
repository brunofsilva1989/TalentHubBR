namespace TalentHubBR.UI.TelasSistema
{
    partial class frmCadastroVaga
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
            lblDescricao = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDescricao = new TextBox();
            txtEscopoVaga = new TextBox();
            cmbStatus = new ComboBox();
            cmbEmpresa = new ComboBox();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            dgvVagas = new DataGridView();
            lblVagas = new Label();
            groupBox1 = new GroupBox();
            btnNovo = new Button();
            label7 = new Label();
            label6 = new Label();
            dtpDataExpiracao = new DateTimePicker();
            dtpDataAbertura = new DateTimePicker();
            label5 = new Label();
            label1 = new Label();
            txtSalario = new TextBox();
            txtCargo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvVagas).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(6, 19);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 0;
            lblDescricao.Text = "Descrição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(397, 19);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 1;
            label2.Text = "Escopo da Vaga";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 72);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 72);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 3;
            label4.Text = "Empresa";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(6, 37);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(385, 23);
            txtDescricao.TabIndex = 4;
            // 
            // txtEscopoVaga
            // 
            txtEscopoVaga.Location = new Point(397, 37);
            txtEscopoVaga.Name = "txtEscopoVaga";
            txtEscopoVaga.Size = new Size(687, 23);
            txtEscopoVaga.TabIndex = 5;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Aberta", "Fechada", "EmAnalise", "Cancelada" });
            cmbStatus.Location = new Point(6, 90);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(91, 23);
            cmbStatus.TabIndex = 6;
            // 
            // cmbEmpresa
            // 
            cmbEmpresa.FormattingEnabled = true;
            cmbEmpresa.Location = new Point(103, 90);
            cmbEmpresa.Name = "cmbEmpresa";
            cmbEmpresa.Size = new Size(188, 23);
            cmbEmpresa.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(397, 515);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(568, 515);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(743, 515);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dgvVagas
            // 
            dgvVagas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVagas.Location = new Point(6, 152);
            dgvVagas.Name = "dgvVagas";
            dgvVagas.Size = new Size(1078, 357);
            dgvVagas.TabIndex = 11;
            dgvVagas.CellContentClick += dgvVagas_CellContentClick;
            // 
            // lblVagas
            // 
            lblVagas.AutoSize = true;
            lblVagas.Location = new Point(6, 134);
            lblVagas.Name = "lblVagas";
            lblVagas.Size = new Size(37, 15);
            lblVagas.TabIndex = 12;
            lblVagas.Text = "Vagas";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNovo);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dtpDataExpiracao);
            groupBox1.Controls.Add(dtpDataAbertura);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSalario);
            groupBox1.Controls.Add(txtCargo);
            groupBox1.Controls.Add(lblDescricao);
            groupBox1.Controls.Add(dgvVagas);
            groupBox1.Controls.Add(lblVagas);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(txtEscopoVaga);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbStatus);
            groupBox1.Controls.Add(cmbEmpresa);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(0, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1112, 565);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(220, 515);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 21;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(837, 72);
            label7.Name = "label7";
            label7.Size = new Size(113, 15);
            label7.TabIndex = 20;
            label7.Text = "Data expiração vaga";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(585, 72);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 19;
            label6.Text = "Data abertura vaga";
            // 
            // dtpDataExpiracao
            // 
            dtpDataExpiracao.Location = new Point(837, 90);
            dtpDataExpiracao.Name = "dtpDataExpiracao";
            dtpDataExpiracao.Size = new Size(247, 23);
            dtpDataExpiracao.TabIndex = 18;
            // 
            // dtpDataAbertura
            // 
            dtpDataAbertura.Location = new Point(585, 90);
            dtpDataAbertura.Name = "dtpDataAbertura";
            dtpDataAbertura.Size = new Size(246, 23);
            dtpDataAbertura.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(480, 72);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 16;
            label5.Text = "Salario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(297, 72);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 15;
            label1.Text = "Cargo";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(480, 90);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(99, 23);
            txtSalario.TabIndex = 14;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(297, 90);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(177, 23);
            txtCargo.TabIndex = 13;
            // 
            // frmCadastroVaga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 568);
            Controls.Add(groupBox1);
            Name = "frmCadastroVaga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Cadastro de Vaga";
            Load += frmCadastroVaga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVagas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblDescricao;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDescricao;
        private TextBox txtEscopoVaga;
        private ComboBox cmbStatus;
        private ComboBox cmbEmpresa;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
        private DataGridView dgvVagas;
        private Label lblVagas;
        private GroupBox groupBox1;
        private Label label5;
        private Label label1;
        private TextBox txtSalario;
        private TextBox txtCargo;
        private Label label7;
        private Label label6;
        private DateTimePicker dtpDataExpiracao;
        private DateTimePicker dtpDataAbertura;
        private Button btnNovo;
    }
}