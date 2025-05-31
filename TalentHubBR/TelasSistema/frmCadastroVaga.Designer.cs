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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroVaga));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            button1 = new Button();
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
            lblDescricao.BackColor = SystemColors.ActiveCaption;
            lblDescricao.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(6, 15);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(76, 19);
            lblDescricao.TabIndex = 0;
            lblDescricao.Text = "Descrição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(397, 15);
            label2.Name = "label2";
            label2.Size = new Size(118, 19);
            label2.TabIndex = 1;
            label2.Text = "Escopo da Vaga";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 68);
            label3.Name = "label3";
            label3.Size = new Size(52, 19);
            label3.TabIndex = 2;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(103, 69);
            label4.Name = "label4";
            label4.Size = new Size(69, 19);
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
            txtEscopoVaga.Size = new Size(720, 23);
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
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(1123, 213);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(58, 55);
            btnSalvar.TabIndex = 8;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(1123, 274);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(58, 55);
            btnEditar.TabIndex = 9;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.Location = new Point(1121, 335);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(60, 55);
            btnExcluir.TabIndex = 10;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dgvVagas
            // 
            dataGridViewCellStyle1.BackColor = Color.Blue;
            dgvVagas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVagas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvVagas.BackgroundColor = SystemColors.Control;
            dgvVagas.BorderStyle = BorderStyle.Fixed3D;
            dgvVagas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVagas.Location = new Point(6, 152);
            dgvVagas.Name = "dgvVagas";
            dgvVagas.Size = new Size(1111, 357);
            dgvVagas.TabIndex = 11;
            dgvVagas.CellContentClick += dgvVagas_CellContentClick;
            // 
            // lblVagas
            // 
            lblVagas.AutoSize = true;
            lblVagas.BackColor = SystemColors.ActiveCaption;
            lblVagas.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVagas.Location = new Point(6, 130);
            lblVagas.Name = "lblVagas";
            lblVagas.Size = new Size(51, 19);
            lblVagas.TabIndex = 12;
            lblVagas.Text = "Vagas";
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(button1);
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
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1212, 551);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(1123, 454);
            button1.Name = "button1";
            button1.Size = new Size(60, 55);
            button1.TabIndex = 22;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnNovo
            // 
            btnNovo.BackgroundImage = (Image)resources.GetObject("btnNovo.BackgroundImage");
            btnNovo.BackgroundImageLayout = ImageLayout.Center;
            btnNovo.Location = new Point(1123, 152);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(58, 55);
            btnNovo.TabIndex = 21;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(854, 69);
            label7.Name = "label7";
            label7.Size = new Size(148, 19);
            label7.TabIndex = 20;
            label7.Text = "Data expiração vaga";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(602, 68);
            label6.Name = "label6";
            label6.Size = new Size(141, 19);
            label6.TabIndex = 19;
            label6.Text = "Data abertura vaga";
            // 
            // dtpDataExpiracao
            // 
            dtpDataExpiracao.Location = new Point(854, 90);
            dtpDataExpiracao.Name = "dtpDataExpiracao";
            dtpDataExpiracao.Size = new Size(263, 23);
            dtpDataExpiracao.TabIndex = 18;
            // 
            // dtpDataAbertura
            // 
            dtpDataAbertura.Location = new Point(602, 90);
            dtpDataAbertura.Name = "dtpDataAbertura";
            dtpDataAbertura.Size = new Size(246, 23);
            dtpDataAbertura.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(480, 68);
            label5.Name = "label5";
            label5.Size = new Size(57, 19);
            label5.TabIndex = 16;
            label5.Text = "Salario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(297, 68);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 15;
            label1.Text = "Cargo";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(480, 90);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(116, 23);
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
            ClientSize = new Size(1210, 531);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadastroVaga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TalentHub BR - Cadastro de Vaga";
            Load += frmCadastroVaga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVagas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button button1;
    }
}