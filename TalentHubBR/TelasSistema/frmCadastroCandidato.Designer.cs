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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroCandidato));
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
            boEmpresaServiceBindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            lblStatus = new Label();
            lblHabilidades = new Label();
            lblBairro = new Label();
            lblCep = new Label();
            lblCidade = new Label();
            lblUf = new Label();
            txtBairro = new TextBox();
            txtCep = new TextBox();
            txtCidade = new TextBox();
            grpFormCandidato = new GroupBox();
            label2 = new Label();
            cmbEstadoCivil = new ComboBox();
            cmbExperiencia = new ComboBox();
            cmbEscolaridade = new ComboBox();
            cmbUF = new ComboBox();
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
            boEmpresaServiceBindingSource = new BindingSource(components);
            btnNovo = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)boEmpresaServiceBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpFormCandidato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)boEmpresaServiceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(7, 24);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(55, 19);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(289, 23);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 19);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(543, 23);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(71, 19);
            lblTelefone.TabIndex = 4;
            lblTelefone.Text = "Telefone:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(717, 22);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(76, 19);
            lblEndereco.TabIndex = 6;
            lblEndereco.Text = "Endereço:";
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(635, 194);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(131, 19);
            lblDataNascimento.TabIndex = 40;
            lblDataNascimento.Text = "Data Nascimento:";
            // 
            // lblEscolaridade
            // 
            lblEscolaridade.AutoSize = true;
            lblEscolaridade.Location = new Point(6, 261);
            lblEscolaridade.Name = "lblEscolaridade";
            lblEscolaridade.Size = new Size(99, 19);
            lblEscolaridade.TabIndex = 44;
            lblEscolaridade.Text = "Escolaridade:";
            // 
            // lblExperiencia
            // 
            lblExperiencia.AutoSize = true;
            lblExperiencia.Location = new Point(367, 261);
            lblExperiencia.Name = "lblExperiencia";
            lblExperiencia.Size = new Size(90, 19);
            lblExperiencia.TabIndex = 46;
            lblExperiencia.Text = "Experiência:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(288, 47);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(249, 29);
            txtEmail.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(7, 47);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(276, 29);
            txtNome.TabIndex = 1;
            // 
            // txtHabilidades
            // 
            txtHabilidades.Location = new Point(111, 294);
            txtHabilidades.Name = "txtHabilidades";
            txtHabilidades.Size = new Size(981, 29);
            txtHabilidades.TabIndex = 49;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(715, 45);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(377, 29);
            txtEndereco.TabIndex = 7;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(543, 46);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(166, 29);
            txtTelefone.TabIndex = 5;
            txtTelefone.TextChanged += textBox7_TextChanged;
            // 
            // dateDataNascimento
            // 
            dateDataNascimento.Location = new Point(634, 218);
            dateDataNascimento.Name = "dateDataNascimento";
            dateDataNascimento.Size = new Size(311, 29);
            dateDataNascimento.TabIndex = 41;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Ativo", "BancoDeTalentos", "Rejeitado" });
            cmbStatus.Location = new Point(951, 218);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(141, 27);
            cmbStatus.TabIndex = 43;
            cmbStatus.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // boEmpresaServiceBindingSource1
            // 
            boEmpresaServiceBindingSource1.DataSource = typeof(TalentHub.BLL.Services.BoEmpresaService);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 340);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1086, 240);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnSalvar
            // 
            btnSalvar.BackgroundImage = (Image)resources.GetObject("btnSalvar.BackgroundImage");
            btnSalvar.BackgroundImageLayout = ImageLayout.Center;
            btnSalvar.Location = new Point(423, 596);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(65, 60);
            btnSalvar.TabIndex = 2;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackgroundImage = (Image)resources.GetObject("btnEditar.BackgroundImage");
            btnEditar.BackgroundImageLayout = ImageLayout.Center;
            btnEditar.Location = new Point(540, 596);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(65, 60);
            btnEditar.TabIndex = 3;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackgroundImage = (Image)resources.GetObject("btnExcluir.BackgroundImage");
            btnExcluir.BackgroundImageLayout = ImageLayout.Center;
            btnExcluir.Location = new Point(656, 596);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(64, 60);
            btnExcluir.TabIndex = 4;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(951, 195);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(55, 19);
            lblStatus.TabIndex = 42;
            lblStatus.Text = "Status:";
            // 
            // lblHabilidades
            // 
            lblHabilidades.AutoSize = true;
            lblHabilidades.Location = new Point(6, 294);
            lblHabilidades.Name = "lblHabilidades";
            lblHabilidades.Size = new Size(93, 19);
            lblHabilidades.TabIndex = 48;
            lblHabilidades.Text = "Habilidades:";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(7, 80);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(51, 19);
            lblBairro.TabIndex = 8;
            lblBairro.Text = "Bairro";
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(290, 80);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(36, 19);
            lblCep.TabIndex = 10;
            lblCep.Text = "Cep";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(432, 80);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(57, 19);
            lblCidade.TabIndex = 12;
            lblCidade.Text = "Cidade";
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Location = new Point(687, 80);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(28, 19);
            lblUf.TabIndex = 14;
            lblUf.Text = "UF";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(6, 103);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(276, 29);
            txtBairro.TabIndex = 9;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(288, 103);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(138, 29);
            txtCep.TabIndex = 11;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(432, 103);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(249, 29);
            txtCidade.TabIndex = 13;
            // 
            // grpFormCandidato
            // 
            grpFormCandidato.BackColor = SystemColors.ActiveCaption;
            grpFormCandidato.BackgroundImage = (Image)resources.GetObject("grpFormCandidato.BackgroundImage");
            grpFormCandidato.Controls.Add(label2);
            grpFormCandidato.Controls.Add(cmbEstadoCivil);
            grpFormCandidato.Controls.Add(cmbExperiencia);
            grpFormCandidato.Controls.Add(cmbEscolaridade);
            grpFormCandidato.Controls.Add(cmbUF);
            grpFormCandidato.Controls.Add(lblSecaoEleitor);
            grpFormCandidato.Controls.Add(txtSecaoTituloEleitor);
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
            grpFormCandidato.Controls.Add(lblUf);
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
            grpFormCandidato.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpFormCandidato.Location = new Point(1, -9);
            grpFormCandidato.Name = "grpFormCandidato";
            grpFormCandidato.Size = new Size(1112, 343);
            grpFormCandidato.TabIndex = 33;
            grpFormCandidato.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 195);
            label2.Name = "label2";
            label2.Size = new Size(85, 19);
            label2.TabIndex = 32;
            label2.Text = "Estato Cívil";
            // 
            // cmbEstadoCivil
            // 
            cmbEstadoCivil.FormattingEnabled = true;
            cmbEstadoCivil.Items.AddRange(new object[] { "Solteiro", "Casado", "Divorciado", "Viuvo", "Separado" });
            cmbEstadoCivil.Location = new Point(6, 218);
            cmbEstadoCivil.Name = "cmbEstadoCivil";
            cmbEstadoCivil.Size = new Size(251, 27);
            cmbEstadoCivil.TabIndex = 33;
            // 
            // cmbExperiencia
            // 
            cmbExperiencia.FormattingEnabled = true;
            cmbExperiencia.Items.AddRange(new object[] { "Nenhuma", "MenosDeUmAno", "UmAno", "DoisAnos", "TresAnosOuMais" });
            cmbExperiencia.Location = new Point(462, 261);
            cmbExperiencia.Name = "cmbExperiencia";
            cmbExperiencia.Size = new Size(289, 27);
            cmbExperiencia.TabIndex = 47;
            // 
            // cmbEscolaridade
            // 
            cmbEscolaridade.FormattingEnabled = true;
            cmbEscolaridade.Items.AddRange(new object[] { "FundamentalIncompleto", "FundamentalCompleto", "MedioIncompleto", "MedioCompleto", "SuperiorIncompleto", "SuperiorCompleto", "PosGraduacaoIncompleto", "PosGraduacaoCompleto" });
            cmbEscolaridade.Location = new Point(111, 261);
            cmbEscolaridade.Name = "cmbEscolaridade";
            cmbEscolaridade.Size = new Size(251, 27);
            cmbEscolaridade.TabIndex = 45;
            // 
            // cmbUF
            // 
            cmbUF.FormattingEnabled = true;
            cmbUF.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cmbUF.Location = new Point(687, 103);
            cmbUF.Name = "cmbUF";
            cmbUF.Size = new Size(101, 27);
            cmbUF.TabIndex = 15;
            // 
            // lblSecaoEleitor
            // 
            lblSecaoEleitor.AutoSize = true;
            lblSecaoEleitor.Location = new Point(530, 194);
            lblSecaoEleitor.Name = "lblSecaoEleitor";
            lblSecaoEleitor.Size = new Size(50, 19);
            lblSecaoEleitor.TabIndex = 38;
            lblSecaoEleitor.Text = "Seção";
            // 
            // txtSecaoTituloEleitor
            // 
            txtSecaoTituloEleitor.Location = new Point(528, 219);
            txtSecaoTituloEleitor.Name = "txtSecaoTituloEleitor";
            txtSecaoTituloEleitor.Size = new Size(100, 29);
            txtSecaoTituloEleitor.TabIndex = 39;
            // 
            // lblZonaEleitor
            // 
            lblZonaEleitor.AutoSize = true;
            lblZonaEleitor.Location = new Point(423, 195);
            lblZonaEleitor.Name = "lblZonaEleitor";
            lblZonaEleitor.Size = new Size(44, 19);
            lblZonaEleitor.TabIndex = 36;
            lblZonaEleitor.Text = "Zona";
            // 
            // txtZonaTituloEleitor
            // 
            txtZonaTituloEleitor.Location = new Point(422, 219);
            txtZonaTituloEleitor.Name = "txtZonaTituloEleitor";
            txtZonaTituloEleitor.Size = new Size(100, 29);
            txtZonaTituloEleitor.TabIndex = 37;
            // 
            // lblTituloEleitor
            // 
            lblTituloEleitor.AutoSize = true;
            lblTituloEleitor.Location = new Point(264, 196);
            lblTituloEleitor.Name = "lblTituloEleitor";
            lblTituloEleitor.Size = new Size(118, 19);
            lblTituloEleitor.TabIndex = 34;
            lblTituloEleitor.Text = "N° Título Eleitor";
            lblTituloEleitor.Click += lblTituloEleitor_Click;
            // 
            // txtTituloEleitor
            // 
            txtTituloEleitor.Location = new Point(263, 219);
            txtTituloEleitor.Name = "txtTituloEleitor";
            txtTituloEleitor.Size = new Size(153, 29);
            txtTituloEleitor.TabIndex = 35;
            // 
            // lblSerieCTPS
            // 
            lblSerieCTPS.AutoSize = true;
            lblSerieCTPS.Location = new Point(926, 135);
            lblSerieCTPS.Name = "lblSerieCTPS";
            lblSerieCTPS.Size = new Size(84, 19);
            lblSerieCTPS.TabIndex = 30;
            lblSerieCTPS.Text = "Série CTPS";
            // 
            // txtSerieCTPS
            // 
            txtSerieCTPS.Location = new Point(926, 159);
            txtSerieCTPS.Name = "txtSerieCTPS";
            txtSerieCTPS.Size = new Size(166, 29);
            txtSerieCTPS.TabIndex = 31;
            // 
            // lblNumeroCTPS
            // 
            lblNumeroCTPS.AutoSize = true;
            lblNumeroCTPS.Location = new Point(762, 135);
            lblNumeroCTPS.Name = "lblNumeroCTPS";
            lblNumeroCTPS.Size = new Size(67, 19);
            lblNumeroCTPS.TabIndex = 28;
            lblNumeroCTPS.Text = "N° CTPS";
            // 
            // txtNumeroCTPS
            // 
            txtNumeroCTPS.Location = new Point(762, 159);
            txtNumeroCTPS.Name = "txtNumeroCTPS";
            txtNumeroCTPS.Size = new Size(158, 29);
            txtNumeroCTPS.TabIndex = 29;
            // 
            // txtNomeMae
            // 
            txtNomeMae.Location = new Point(502, 159);
            txtNomeMae.Name = "txtNomeMae";
            txtNomeMae.Size = new Size(253, 29);
            txtNomeMae.TabIndex = 27;
            // 
            // lblNomeMae
            // 
            lblNomeMae.AutoSize = true;
            lblNomeMae.Location = new Point(502, 135);
            lblNomeMae.Name = "lblNomeMae";
            lblNomeMae.Size = new Size(107, 19);
            lblNomeMae.TabIndex = 26;
            lblNomeMae.Text = "Nome da Mãe";
            // 
            // lblOrgaoEmissor
            // 
            lblOrgaoEmissor.AutoSize = true;
            lblOrgaoEmissor.Location = new Point(382, 136);
            lblOrgaoEmissor.Name = "lblOrgaoEmissor";
            lblOrgaoEmissor.Size = new Size(112, 19);
            lblOrgaoEmissor.TabIndex = 24;
            lblOrgaoEmissor.Text = "Orgão Emissor";
            // 
            // txtOrgaoEmissor
            // 
            txtOrgaoEmissor.Location = new Point(382, 160);
            txtOrgaoEmissor.Name = "txtOrgaoEmissor";
            txtOrgaoEmissor.Size = new Size(114, 29);
            txtOrgaoEmissor.TabIndex = 25;
            // 
            // txtRg
            // 
            txtRg.Location = new Point(224, 160);
            txtRg.Name = "txtRg";
            txtRg.Size = new Size(152, 29);
            txtRg.TabIndex = 23;
            // 
            // lblRg
            // 
            lblRg.AutoSize = true;
            lblRg.Location = new Point(226, 137);
            lblRg.Name = "lblRg";
            lblRg.Size = new Size(28, 19);
            lblRg.TabIndex = 22;
            lblRg.Text = "Rg";
            // 
            // lblCpfCnpj
            // 
            lblCpfCnpj.AutoSize = true;
            lblCpfCnpj.Location = new Point(6, 137);
            lblCpfCnpj.Name = "lblCpfCnpj";
            lblCpfCnpj.Size = new Size(99, 19);
            lblCpfCnpj.TabIndex = 20;
            lblCpfCnpj.Text = "CPF ou CNPJ";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(6, 160);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(212, 29);
            txtCpf.TabIndex = 21;
            // 
            // txtNacionalidade
            // 
            txtNacionalidade.Location = new Point(933, 102);
            txtNacionalidade.Name = "txtNacionalidade";
            txtNacionalidade.Size = new Size(159, 29);
            txtNacionalidade.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(933, 78);
            label1.Name = "label1";
            label1.Size = new Size(108, 19);
            label1.TabIndex = 18;
            label1.Text = "Nacionalidade";
            // 
            // txtCidadeNatal
            // 
            txtCidadeNatal.Location = new Point(794, 101);
            txtCidadeNatal.Name = "txtCidadeNatal";
            txtCidadeNatal.Size = new Size(133, 29);
            txtCidadeNatal.TabIndex = 17;
            // 
            // lblCidadeNatal
            // 
            lblCidadeNatal.AutoSize = true;
            lblCidadeNatal.Location = new Point(794, 78);
            lblCidadeNatal.Name = "lblCidadeNatal";
            lblCidadeNatal.Size = new Size(98, 19);
            lblCidadeNatal.TabIndex = 16;
            lblCidadeNatal.Text = "Cidade Natal";
            // 
            // boEmpresaServiceBindingSource
            // 
            boEmpresaServiceBindingSource.DataSource = typeof(TalentHub.BLL.Services.BoEmpresaService);
            // 
            // btnNovo
            // 
            btnNovo.BackgroundImage = (Image)resources.GetObject("btnNovo.BackgroundImage");
            btnNovo.BackgroundImageLayout = ImageLayout.Center;
            btnNovo.Location = new Point(312, 596);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(65, 60);
            btnNovo.TabIndex = 1;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(1039, 600);
            button1.Name = "button1";
            button1.Size = new Size(54, 52);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmCadastroCandidato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1112, 668);
            Controls.Add(button1);
            Controls.Add(btnNovo);
            Controls.Add(grpFormCandidato);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadastroCandidato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Cadastro do Candidato";
            Load += frmCadastroCandidato_Load;
            ((System.ComponentModel.ISupportInitialize)boEmpresaServiceBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpFormCandidato.ResumeLayout(false);
            grpFormCandidato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)boEmpresaServiceBindingSource).EndInit();
            ResumeLayout(false);
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
        private Label lblStatus;
        private Label lblHabilidades;
        private Label lblBairro;
        private Label lblCep;
        private Label lblCidade;
        private Label lblUf;
        private TextBox txtBairro;
        private TextBox txtCep;
        private TextBox txtCidade;
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
        private BindingSource boEmpresaServiceBindingSource1;
        private BindingSource boEmpresaServiceBindingSource;
        private ComboBox cmbUF;
        private ComboBox cmbEscolaridade;
        private ComboBox cmbExperiencia;
        private Label label2;
        private ComboBox cmbEstadoCivil;
        private Button btnNovo;
        private Button button1;
    }
}