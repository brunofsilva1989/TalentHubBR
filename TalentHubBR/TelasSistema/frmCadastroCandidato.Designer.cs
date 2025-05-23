namespace TalentHubBR.UI.TelasSistema
{
    partial class frmCadastroCandidato
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
            lblEmail = new Label();
            lblTelefone = new Label();
            lblEndereco = new Label();
            lblDataNascimento = new Label();
            lblEscolaridade = new Label();
            lblExperiencia = new Label();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            txtHabilidades = new TextBox();
            txtEndereco = new TextBox();
            txtTelefone = new TextBox();
            dateDataNascimento = new DateTimePicker();
            cmbStatus = new ComboBox();
            dataGridView1 = new DataGridView();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            txtExperienciaProfissional = new TextBox();
            lblStatus = new Label();
            lblHabilidades = new Label();
            txtEscolaridade = new TextBox();
            dtgCandidatos = new Label();
            lblBairro = new Label();
            lblCep = new Label();
            lblCidade = new Label();
            lblEstadoCivil = new Label();
            txtBairro = new TextBox();
            txtCep = new TextBox();
            txtCidade = new TextBox();
            txtEstado = new TextBox();
            grpFormCandidato = new GroupBox();
            lblSecaoEleitor = new Label();
            txtSecaoTituloEleitor = new TextBox();
            lblZonaEleitor = new Label();
            txtZonaTituloEleitor = new TextBox();
            lblTituloEleitor = new Label();
            txtTituloEleitor = new TextBox();
            lblSerieCTPS = new Label();
            txtSerieCTPS = new TextBox();
            lblNumeroCTPS = new Label();
            txtNumeroCTPS = new TextBox();
            txtNomeMae = new TextBox();
            lblNomeMae = new Label();
            lblOrgaoEmissor = new Label();
            txtOrgaoEmissor = new TextBox();
            txtRg = new TextBox();
            lblRg = new Label();
            lblCpfCnpj = new Label();
            txtCpf = new TextBox();
            txtNacionalidade = new TextBox();
            label1 = new Label();
            txtCidadeNatal = new TextBox();
            lblCidadeNatal = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpFormCandidato.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(6, 19);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(288, 19);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(554, 19);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(54, 15);
            lblTelefone.TabIndex = 2;
            lblTelefone.Text = "Telefone:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(715, 19);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(59, 15);
            lblEndereco.TabIndex = 3;
            lblEndereco.Text = "Endereço:";
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(379, 174);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(101, 15);
            lblDataNascimento.TabIndex = 4;
            lblDataNascimento.Text = "Data Nascimento:";
            // 
            // lblEscolaridade
            // 
            lblEscolaridade.AutoSize = true;
            lblEscolaridade.Location = new Point(634, 174);
            lblEscolaridade.Name = "lblEscolaridade";
            lblEscolaridade.Size = new Size(76, 15);
            lblEscolaridade.TabIndex = 5;
            lblEscolaridade.Text = "Escolaridade:";
            // 
            // lblExperiencia
            // 
            lblExperiencia.AutoSize = true;
            lblExperiencia.Location = new Point(6, 228);
            lblExperiencia.Name = "lblExperiencia";
            lblExperiencia.Size = new Size(70, 15);
            lblExperiencia.TabIndex = 6;
            lblExperiencia.Text = "Experiência:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(288, 37);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(249, 23);
            txtEmail.TabIndex = 10;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(6, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(276, 23);
            txtNome.TabIndex = 11;
            // 
            // txtHabilidades
            // 
            txtHabilidades.Location = new Point(82, 270);
            txtHabilidades.Name = "txtHabilidades";
            txtHabilidades.Size = new Size(1004, 23);
            txtHabilidades.TabIndex = 13;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(715, 37);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(371, 23);
            txtEndereco.TabIndex = 14;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(543, 37);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(166, 23);
            txtTelefone.TabIndex = 15;
            txtTelefone.TextChanged += textBox7_TextChanged;
            // 
            // dateDataNascimento
            // 
            dateDataNascimento.Location = new Point(377, 192);
            dateDataNascimento.Name = "dateDataNascimento";
            dateDataNascimento.Size = new Size(249, 23);
            dateDataNascimento.TabIndex = 16;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(889, 192);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(197, 23);
            cmbStatus.TabIndex = 17;
            cmbStatus.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 359);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1103, 263);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(417, 633);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 19;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(545, 633);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(669, 633);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 21;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // txtExperienciaProfissional
            // 
            txtExperienciaProfissional.Location = new Point(82, 228);
            txtExperienciaProfissional.Name = "txtExperienciaProfissional";
            txtExperienciaProfissional.Size = new Size(1004, 23);
            txtExperienciaProfissional.TabIndex = 22;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(885, 174);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status:";
            // 
            // lblHabilidades
            // 
            lblHabilidades.AutoSize = true;
            lblHabilidades.Location = new Point(6, 273);
            lblHabilidades.Name = "lblHabilidades";
            lblHabilidades.Size = new Size(72, 15);
            lblHabilidades.TabIndex = 7;
            lblHabilidades.Text = "Habilidades:";
            // 
            // txtEscolaridade
            // 
            txtEscolaridade.Location = new Point(634, 192);
            txtEscolaridade.Name = "txtEscolaridade";
            txtEscolaridade.Size = new Size(249, 23);
            txtEscolaridade.TabIndex = 23;
            // 
            // dtgCandidatos
            // 
            dtgCandidatos.AutoSize = true;
            dtgCandidatos.Location = new Point(18, 341);
            dtgCandidatos.Name = "dtgCandidatos";
            dtgCandidatos.Size = new Size(110, 15);
            dtgCandidatos.TabIndex = 24;
            dtgCandidatos.Text = "Lista de Candidatos";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(6, 72);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 25;
            lblBairro.Text = "Bairro";
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(289, 72);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 26;
            lblCep.Text = "Cep";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(432, 72);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 27;
            lblCidade.Text = "Cidade";
            // 
            // lblEstadoCivil
            // 
            lblEstadoCivil.AutoSize = true;
            lblEstadoCivil.Location = new Point(687, 72);
            lblEstadoCivil.Name = "lblEstadoCivil";
            lblEstadoCivil.Size = new Size(42, 15);
            lblEstadoCivil.TabIndex = 28;
            lblEstadoCivil.Text = "Estado";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(6, 90);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(276, 23);
            txtBairro.TabIndex = 29;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(288, 90);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(138, 23);
            txtCep.TabIndex = 30;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(432, 90);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(249, 23);
            txtCidade.TabIndex = 31;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(687, 90);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(101, 23);
            txtEstado.TabIndex = 32;
            // 
            // grpFormCandidato
            // 
            grpFormCandidato.Controls.Add(lblSecaoEleitor);
            grpFormCandidato.Controls.Add(txtSecaoTituloEleitor);
            grpFormCandidato.Controls.Add(txtExperienciaProfissional);
            grpFormCandidato.Controls.Add(txtEscolaridade);
            grpFormCandidato.Controls.Add(lblZonaEleitor);
            grpFormCandidato.Controls.Add(txtZonaTituloEleitor);
            grpFormCandidato.Controls.Add(txtHabilidades);
            grpFormCandidato.Controls.Add(lblTituloEleitor);
            grpFormCandidato.Controls.Add(lblHabilidades);
            grpFormCandidato.Controls.Add(txtTituloEleitor);
            grpFormCandidato.Controls.Add(cmbStatus);
            grpFormCandidato.Controls.Add(lblSerieCTPS);
            grpFormCandidato.Controls.Add(lblExperiencia);
            grpFormCandidato.Controls.Add(txtSerieCTPS);
            grpFormCandidato.Controls.Add(lblStatus);
            grpFormCandidato.Controls.Add(lblNumeroCTPS);
            grpFormCandidato.Controls.Add(dateDataNascimento);
            grpFormCandidato.Controls.Add(txtNumeroCTPS);
            grpFormCandidato.Controls.Add(txtNomeMae);
            grpFormCandidato.Controls.Add(lblNomeMae);
            grpFormCandidato.Controls.Add(lblEscolaridade);
            grpFormCandidato.Controls.Add(lblOrgaoEmissor);
            grpFormCandidato.Controls.Add(txtOrgaoEmissor);
            grpFormCandidato.Controls.Add(txtRg);
            grpFormCandidato.Controls.Add(lblDataNascimento);
            grpFormCandidato.Controls.Add(lblRg);
            grpFormCandidato.Controls.Add(lblCpfCnpj);
            grpFormCandidato.Controls.Add(txtCpf);
            grpFormCandidato.Controls.Add(txtNacionalidade);
            grpFormCandidato.Controls.Add(label1);
            grpFormCandidato.Controls.Add(txtCidadeNatal);
            grpFormCandidato.Controls.Add(lblCidadeNatal);
            grpFormCandidato.Controls.Add(txtNome);
            grpFormCandidato.Controls.Add(lblEstadoCivil);
            grpFormCandidato.Controls.Add(txtEstado);
            grpFormCandidato.Controls.Add(lblNome);
            grpFormCandidato.Controls.Add(txtCidade);
            grpFormCandidato.Controls.Add(lblCidade);
            grpFormCandidato.Controls.Add(txtEmail);
            grpFormCandidato.Controls.Add(txtCep);
            grpFormCandidato.Controls.Add(lblEmail);
            grpFormCandidato.Controls.Add(txtBairro);
            grpFormCandidato.Controls.Add(lblTelefone);
            grpFormCandidato.Controls.Add(lblCep);
            grpFormCandidato.Controls.Add(txtTelefone);
            grpFormCandidato.Controls.Add(lblEndereco);
            grpFormCandidato.Controls.Add(txtEndereco);
            grpFormCandidato.Controls.Add(lblBairro);
            grpFormCandidato.Location = new Point(12, 15);
            grpFormCandidato.Name = "grpFormCandidato";
            grpFormCandidato.Size = new Size(1109, 318);
            grpFormCandidato.TabIndex = 33;
            grpFormCandidato.TabStop = false;
            // 
            // lblSecaoEleitor
            // 
            lblSecaoEleitor.AutoSize = true;
            lblSecaoEleitor.Location = new Point(271, 174);
            lblSecaoEleitor.Name = "lblSecaoEleitor";
            lblSecaoEleitor.Size = new Size(38, 15);
            lblSecaoEleitor.TabIndex = 54;
            lblSecaoEleitor.Text = "Seção";
            // 
            // txtSecaoTituloEleitor
            // 
            txtSecaoTituloEleitor.Location = new Point(271, 192);
            txtSecaoTituloEleitor.Name = "txtSecaoTituloEleitor";
            txtSecaoTituloEleitor.Size = new Size(100, 23);
            txtSecaoTituloEleitor.TabIndex = 53;
            // 
            // lblZonaEleitor
            // 
            lblZonaEleitor.AutoSize = true;
            lblZonaEleitor.Location = new Point(165, 174);
            lblZonaEleitor.Name = "lblZonaEleitor";
            lblZonaEleitor.Size = new Size(34, 15);
            lblZonaEleitor.TabIndex = 52;
            lblZonaEleitor.Text = "Zona";
            // 
            // txtZonaTituloEleitor
            // 
            txtZonaTituloEleitor.Location = new Point(165, 192);
            txtZonaTituloEleitor.Name = "txtZonaTituloEleitor";
            txtZonaTituloEleitor.Size = new Size(100, 23);
            txtZonaTituloEleitor.TabIndex = 51;
            // 
            // lblTituloEleitor
            // 
            lblTituloEleitor.AutoSize = true;
            lblTituloEleitor.Location = new Point(6, 174);
            lblTituloEleitor.Name = "lblTituloEleitor";
            lblTituloEleitor.Size = new Size(90, 15);
            lblTituloEleitor.TabIndex = 50;
            lblTituloEleitor.Text = "N° Título Eleitor";
            lblTituloEleitor.Click += lblTituloEleitor_Click;
            // 
            // txtTituloEleitor
            // 
            txtTituloEleitor.Location = new Point(6, 192);
            txtTituloEleitor.Name = "txtTituloEleitor";
            txtTituloEleitor.Size = new Size(153, 23);
            txtTituloEleitor.TabIndex = 49;
            // 
            // lblSerieCTPS
            // 
            lblSerieCTPS.AutoSize = true;
            lblSerieCTPS.Location = new Point(926, 121);
            lblSerieCTPS.Name = "lblSerieCTPS";
            lblSerieCTPS.Size = new Size(62, 15);
            lblSerieCTPS.TabIndex = 48;
            lblSerieCTPS.Text = "Série CTPS";
            // 
            // txtSerieCTPS
            // 
            txtSerieCTPS.Location = new Point(926, 139);
            txtSerieCTPS.Name = "txtSerieCTPS";
            txtSerieCTPS.Size = new Size(160, 23);
            txtSerieCTPS.TabIndex = 47;
            // 
            // lblNumeroCTPS
            // 
            lblNumeroCTPS.AutoSize = true;
            lblNumeroCTPS.Location = new Point(762, 122);
            lblNumeroCTPS.Name = "lblNumeroCTPS";
            lblNumeroCTPS.Size = new Size(51, 15);
            lblNumeroCTPS.TabIndex = 46;
            lblNumeroCTPS.Text = "N° CTPS";
            // 
            // txtNumeroCTPS
            // 
            txtNumeroCTPS.Location = new Point(762, 140);
            txtNumeroCTPS.Name = "txtNumeroCTPS";
            txtNumeroCTPS.Size = new Size(158, 23);
            txtNumeroCTPS.TabIndex = 45;
            // 
            // txtNomeMae
            // 
            txtNomeMae.Location = new Point(502, 140);
            txtNomeMae.Name = "txtNomeMae";
            txtNomeMae.Size = new Size(253, 23);
            txtNomeMae.TabIndex = 44;
            // 
            // lblNomeMae
            // 
            lblNomeMae.AutoSize = true;
            lblNomeMae.Location = new Point(499, 122);
            lblNomeMae.Name = "lblNomeMae";
            lblNomeMae.Size = new Size(82, 15);
            lblNomeMae.TabIndex = 43;
            lblNomeMae.Text = "Nome da Mãe";
            // 
            // lblOrgaoEmissor
            // 
            lblOrgaoEmissor.AutoSize = true;
            lblOrgaoEmissor.Location = new Point(396, 122);
            lblOrgaoEmissor.Name = "lblOrgaoEmissor";
            lblOrgaoEmissor.Size = new Size(84, 15);
            lblOrgaoEmissor.TabIndex = 42;
            lblOrgaoEmissor.Text = "Orgão Emissor";
            // 
            // txtOrgaoEmissor
            // 
            txtOrgaoEmissor.Location = new Point(396, 140);
            txtOrgaoEmissor.Name = "txtOrgaoEmissor";
            txtOrgaoEmissor.Size = new Size(100, 23);
            txtOrgaoEmissor.TabIndex = 41;
            // 
            // txtRg
            // 
            txtRg.Location = new Point(224, 140);
            txtRg.Name = "txtRg";
            txtRg.Size = new Size(166, 23);
            txtRg.TabIndex = 40;
            // 
            // lblRg
            // 
            lblRg.AutoSize = true;
            lblRg.Location = new Point(224, 122);
            lblRg.Name = "lblRg";
            lblRg.Size = new Size(21, 15);
            lblRg.TabIndex = 39;
            lblRg.Text = "Rg";
            // 
            // lblCpfCnpj
            // 
            lblCpfCnpj.AutoSize = true;
            lblCpfCnpj.Location = new Point(6, 122);
            lblCpfCnpj.Name = "lblCpfCnpj";
            lblCpfCnpj.Size = new Size(75, 15);
            lblCpfCnpj.TabIndex = 38;
            lblCpfCnpj.Text = "CPF ou CNPJ";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(6, 140);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(212, 23);
            txtCpf.TabIndex = 37;
            // 
            // txtNacionalidade
            // 
            txtNacionalidade.Location = new Point(933, 90);
            txtNacionalidade.Name = "txtNacionalidade";
            txtNacionalidade.Size = new Size(153, 23);
            txtNacionalidade.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(926, 69);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 35;
            label1.Text = "Nacionalidade";
            // 
            // txtCidadeNatal
            // 
            txtCidadeNatal.Location = new Point(794, 90);
            txtCidadeNatal.Name = "txtCidadeNatal";
            txtCidadeNatal.Size = new Size(133, 23);
            txtCidadeNatal.TabIndex = 34;
            // 
            // lblCidadeNatal
            // 
            lblCidadeNatal.AutoSize = true;
            lblCidadeNatal.Location = new Point(794, 72);
            lblCidadeNatal.Name = "lblCidadeNatal";
            lblCidadeNatal.Size = new Size(75, 15);
            lblCidadeNatal.TabIndex = 33;
            lblCidadeNatal.Text = "Cidade Natal";
            // 
            // frmCadastroCandidato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 668);
            Controls.Add(grpFormCandidato);
            Controls.Add(dtgCandidatos);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(dataGridView1);
            Name = "frmCadastroCandidato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Cadastro do Candidato";
            Load += frmCadastroCandidato_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpFormCandidato.ResumeLayout(false);
            grpFormCandidato.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblEmail;
        private Label lblTelefone;
        private Label lblEndereco;
        private Label lblDataNascimento;
        private Label lblEscolaridade;
        private Label lblExperiencia;
        private TextBox txtEmail;
        private TextBox txtNome;
        private TextBox txtHabilidades;
        private TextBox txtEndereco;
        private TextBox txtTelefone;
        private DateTimePicker dateDataNascimento;
        private ComboBox cmbStatus;
        private DataGridView dataGridView1;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
        private TextBox txtExperienciaProfissional;
        private Label lblStatus;
        private Label lblHabilidades;
        private TextBox txtEscolaridade;
        private Label dtgCandidatos;
        private Label lblBairro;
        private Label lblCep;
        private Label lblCidade;
        private Label lblEstadoCivil;
        private TextBox txtBairro;
        private TextBox txtCep;
        private TextBox txtCidade;
        private TextBox txtEstado;
        private GroupBox grpFormCandidato;
        private TextBox txtCidadeNatal;
        private Label lblCidadeNatal;
        private Label lblRg;
        private Label lblCpfCnpj;
        private TextBox txtCpf;
        private TextBox txtNacionalidade;
        private Label label1;
        private TextBox txtRg;
        private TextBox txtNomeMae;
        private Label lblNomeMae;
        private Label lblOrgaoEmissor;
        private TextBox txtOrgaoEmissor;
        private Label lblSerieCTPS;
        private TextBox txtSerieCTPS;
        private Label lblNumeroCTPS;
        private TextBox txtNumeroCTPS;
        private Label lblTituloEleitor;
        private TextBox txtTituloEleitor;
        private Label lblSecaoEleitor;
        private TextBox txtSecaoTituloEleitor;
        private Label lblZonaEleitor;
        private TextBox txtZonaTituloEleitor;
    }
}