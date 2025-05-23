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
            txtEscopo = new TextBox();
            cmbStatus = new ComboBox();
            cmbEmpresa = new ComboBox();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            dgvVagas = new DataGridView();
            lblVagas = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvVagas).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(6, 47);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 0;
            lblDescricao.Text = "Descrição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 47);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Escopo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(526, 47);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(793, 47);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 3;
            label4.Text = "Empresa";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(15, 65);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(249, 23);
            txtDescricao.TabIndex = 4;
            // 
            // txtEscopo
            // 
            txtEscopo.Location = new Point(270, 65);
            txtEscopo.Name = "txtEscopo";
            txtEscopo.Size = new Size(249, 23);
            txtEscopo.TabIndex = 5;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(526, 65);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(261, 23);
            cmbStatus.TabIndex = 6;
            // 
            // cmbEmpresa
            // 
            cmbEmpresa.FormattingEnabled = true;
            cmbEmpresa.Location = new Point(793, 65);
            cmbEmpresa.Name = "cmbEmpresa";
            cmbEmpresa.Size = new Size(291, 23);
            cmbEmpresa.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(312, 409);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(490, 409);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(664, 409);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // dgvVagas
            // 
            dgvVagas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVagas.Location = new Point(6, 123);
            dgvVagas.Name = "dgvVagas";
            dgvVagas.Size = new Size(1078, 280);
            dgvVagas.TabIndex = 11;
            // 
            // lblVagas
            // 
            lblVagas.AutoSize = true;
            lblVagas.Location = new Point(6, 105);
            lblVagas.Name = "lblVagas";
            lblVagas.Size = new Size(37, 15);
            lblVagas.TabIndex = 12;
            lblVagas.Text = "Vagas";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblDescricao);
            groupBox1.Controls.Add(dgvVagas);
            groupBox1.Controls.Add(lblVagas);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(txtEscopo);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbStatus);
            groupBox1.Controls.Add(cmbEmpresa);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1090, 442);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // frmCadastroVaga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 466);
            Controls.Add(groupBox1);
            Name = "frmCadastroVaga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Cadastro de Vaga";
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
        private TextBox txtEscopo;
        private ComboBox cmbStatus;
        private ComboBox cmbEmpresa;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
        private DataGridView dgvVagas;
        private Label lblVagas;
        private GroupBox groupBox1;
    }
}