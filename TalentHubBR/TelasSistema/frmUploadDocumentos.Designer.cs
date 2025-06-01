
namespace TalentHubBR.UI.TelasSistema
{
    partial class frmUploadDocumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUploadDocumentos));
            lblArquivo = new Label();
            lblTipoDoc = new Label();
            lblCandidato = new Label();
            txtArquivo = new TextBox();
            txtTipo = new TextBox();
            cmbCandidato = new ComboBox();
            btnUpload = new Button();
            btnSelecionarArquivo = new Button();
            dgvDocumentos = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            groupBox1 = new GroupBox();
            button1 = new Button();
            lblNomeDoc = new Label();
            txtNome = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDocumentos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblArquivo
            // 
            lblArquivo.AutoSize = true;
            lblArquivo.Location = new Point(604, 73);
            lblArquivo.Name = "lblArquivo";
            lblArquivo.Size = new Size(64, 19);
            lblArquivo.TabIndex = 6;
            lblArquivo.Text = "Arquivo";
            // 
            // lblTipoDoc
            // 
            lblTipoDoc.AutoSize = true;
            lblTipoDoc.Location = new Point(304, 73);
            lblTipoDoc.Name = "lblTipoDoc";
            lblTipoDoc.Size = new Size(76, 19);
            lblTipoDoc.TabIndex = 4;
            lblTipoDoc.Text = "Tipo Doc.:";
            // 
            // lblCandidato
            // 
            lblCandidato.AutoSize = true;
            lblCandidato.Location = new Point(6, 19);
            lblCandidato.Name = "lblCandidato";
            lblCandidato.Size = new Size(166, 19);
            lblCandidato.TabIndex = 0;
            lblCandidato.Text = "Selecione o Candidato:";
            // 
            // txtArquivo
            // 
            txtArquivo.Location = new Point(604, 95);
            txtArquivo.Name = "txtArquivo";
            txtArquivo.Size = new Size(316, 29);
            txtArquivo.TabIndex = 7;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(304, 95);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(294, 29);
            txtTipo.TabIndex = 5;
            // 
            // cmbCandidato
            // 
            cmbCandidato.FormattingEnabled = true;
            cmbCandidato.Items.AddRange(new object[] { "Nome" });
            cmbCandidato.Location = new Point(6, 42);
            cmbCandidato.Name = "cmbCandidato";
            cmbCandidato.Size = new Size(183, 27);
            cmbCandidato.TabIndex = 1;
            cmbCandidato.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnUpload
            // 
            btnUpload.BackgroundImage = (Image)resources.GetObject("btnUpload.BackgroundImage");
            btnUpload.BackgroundImageLayout = ImageLayout.Center;
            btnUpload.Location = new Point(994, 80);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(48, 54);
            btnUpload.TabIndex = 10;
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnSelecionarArquivo
            // 
            btnSelecionarArquivo.BackgroundImage = (Image)resources.GetObject("btnSelecionarArquivo.BackgroundImage");
            btnSelecionarArquivo.BackgroundImageLayout = ImageLayout.Center;
            btnSelecionarArquivo.Location = new Point(937, 80);
            btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            btnSelecionarArquivo.Size = new Size(51, 55);
            btnSelecionarArquivo.TabIndex = 9;
            btnSelecionarArquivo.UseVisualStyleBackColor = true;
            btnSelecionarArquivo.Click += btnSelecionarArquivo_Click;
            // 
            // dgvDocumentos
            // 
            dgvDocumentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDocumentos.BackgroundColor = SystemColors.HighlightText;
            dgvDocumentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocumentos.Location = new Point(6, 151);
            dgvDocumentos.Name = "dgvDocumentos";
            dgvDocumentos.Size = new Size(1036, 299);
            dgvDocumentos.TabIndex = 8;
            dgvDocumentos.CellContentClick += dgvDocumentos_CellContentClick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(lblNomeDoc);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(txtTipo);
            groupBox1.Controls.Add(lblArquivo);
            groupBox1.Controls.Add(dgvDocumentos);
            groupBox1.Controls.Add(lblTipoDoc);
            groupBox1.Controls.Add(btnSelecionarArquivo);
            groupBox1.Controls.Add(lblCandidato);
            groupBox1.Controls.Add(btnUpload);
            groupBox1.Controls.Add(txtArquivo);
            groupBox1.Controls.Add(cmbCandidato);
            groupBox1.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, -13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1061, 466);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(994, 20);
            button1.Name = "button1";
            button1.Size = new Size(48, 54);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblNomeDoc
            // 
            lblNomeDoc.AutoSize = true;
            lblNomeDoc.Location = new Point(6, 73);
            lblNomeDoc.Name = "lblNomeDoc";
            lblNomeDoc.Size = new Size(83, 19);
            lblNomeDoc.TabIndex = 2;
            lblNomeDoc.Text = "Nome Doc";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(6, 95);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(292, 29);
            txtNome.TabIndex = 3;
            // 
            // frmUploadDocumentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1056, 450);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmUploadDocumentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela de Upload de Documentos";
            Load += frmUploadDocumentos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDocumentos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private Label lblArquivo;
        private Label lblTipoDoc;
        private Label lblCandidato;
        private TextBox txtArquivo;
        private TextBox txtTipo;
        private ComboBox cmbCandidato;
        private Button btnUpload;
        private Button btnSelecionarArquivo;
        private DataGridView dgvDocumentos;
        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox1;
        private Label lblNomeDoc;
        private TextBox txtNome;
        private Button button1;
    }
}