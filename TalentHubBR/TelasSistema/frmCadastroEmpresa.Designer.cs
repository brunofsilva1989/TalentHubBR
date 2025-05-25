
namespace TalentHubBR.UI.TelasSistema
{
    partial class frmCadastroEmpresa
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
            lblNome = new Label();
            txtNomeEmpresa = new TextBox();
            lblContato = new Label();
            txtContatoEmpresa = new TextBox();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            dgvEmpresas = new DataGridView();
            lblListaEmpresasCadastradas = new Label();
            groupBox1 = new GroupBox();
            txtEmail = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmpresas).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(13, 32);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(88, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome Empresa";
            lblNome.Click += label1_Click;
            // 
            // txtNomeEmpresa
            // 
            txtNomeEmpresa.Location = new Point(13, 55);
            txtNomeEmpresa.Name = "txtNomeEmpresa";
            txtNomeEmpresa.Size = new Size(368, 23);
            txtNomeEmpresa.TabIndex = 1;
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Location = new Point(387, 32);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(50, 15);
            lblContato.TabIndex = 2;
            lblContato.Text = "Contato";
            // 
            // txtContatoEmpresa
            // 
            txtContatoEmpresa.Location = new Point(387, 55);
            txtContatoEmpresa.Name = "txtContatoEmpresa";
            txtContatoEmpresa.Size = new Size(308, 23);
            txtContatoEmpresa.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(348, 502);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(510, 502);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(666, 502);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dgvEmpresas
            // 
            dgvEmpresas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpresas.Location = new Point(13, 112);
            dgvEmpresas.Name = "dgvEmpresas";
            dgvEmpresas.Size = new Size(1083, 383);
            dgvEmpresas.TabIndex = 7;
            dgvEmpresas.CellContentClick += dgvEmpresas_CellContentClick;
            // 
            // lblListaEmpresasCadastradas
            // 
            lblListaEmpresasCadastradas.AutoSize = true;
            lblListaEmpresasCadastradas.Location = new Point(13, 94);
            lblListaEmpresasCadastradas.Name = "lblListaEmpresasCadastradas";
            lblListaEmpresasCadastradas.Size = new Size(122, 15);
            lblListaEmpresasCadastradas.TabIndex = 8;
            lblListaEmpresasCadastradas.Text = "Empresas cadastradas";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblNome);
            groupBox1.Controls.Add(dgvEmpresas);
            groupBox1.Controls.Add(lblListaEmpresasCadastradas);
            groupBox1.Controls.Add(txtNomeEmpresa);
            groupBox1.Controls.Add(lblContato);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(txtContatoEmpresa);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Location = new Point(-1, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1116, 531);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(703, 55);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(393, 23);
            txtEmail.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(703, 32);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 9;
            label1.Text = "Email";
            // 
            // frmCadastroEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 545);
            Controls.Add(groupBox1);
            Name = "frmCadastroEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Cadastro de Empresa";
            Load += frmCadastroEmpresa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpresas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }


        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNomeEmpresa;
        private Label lblContato;
        private TextBox txtContatoEmpresa;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
        private DataGridView dgvEmpresas;
        private Label lblListaEmpresasCadastradas;
        private GroupBox groupBox1;
        private TextBox txtEmail;
        private Label label1;
    }
}