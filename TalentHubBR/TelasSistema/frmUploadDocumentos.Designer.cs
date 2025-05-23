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
            lblDocumentos = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvDocumentos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblArquivo
            // 
            lblArquivo.AutoSize = true;
            lblArquivo.Location = new Point(604, 28);
            lblArquivo.Name = "lblArquivo";
            lblArquivo.Size = new Size(49, 15);
            lblArquivo.TabIndex = 0;
            lblArquivo.Text = "Arquivo";
            // 
            // lblTipoDoc
            // 
            lblTipoDoc.AutoSize = true;
            lblTipoDoc.Location = new Point(304, 27);
            lblTipoDoc.Name = "lblTipoDoc";
            lblTipoDoc.Size = new Size(60, 15);
            lblTipoDoc.TabIndex = 1;
            lblTipoDoc.Text = "Tipo Doc.:";
            // 
            // lblCandidato
            // 
            lblCandidato.AutoSize = true;
            lblCandidato.Location = new Point(6, 27);
            lblCandidato.Name = "lblCandidato";
            lblCandidato.Size = new Size(65, 15);
            lblCandidato.TabIndex = 2;
            lblCandidato.Text = "Candidato:";
            // 
            // txtArquivo
            // 
            txtArquivo.Location = new Point(604, 46);
            txtArquivo.Name = "txtArquivo";
            txtArquivo.Size = new Size(316, 23);
            txtArquivo.TabIndex = 3;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(304, 45);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(294, 23);
            txtTipo.TabIndex = 4;
            // 
            // cmbCandidato
            // 
            cmbCandidato.FormattingEnabled = true;
            cmbCandidato.Items.AddRange(new object[] { "Nome" });
            cmbCandidato.Location = new Point(6, 45);
            cmbCandidato.Name = "cmbCandidato";
            cmbCandidato.Size = new Size(292, 23);
            cmbCandidato.TabIndex = 5;
            cmbCandidato.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(1007, 45);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(75, 23);
            btnUpload.TabIndex = 6;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            // 
            // btnSelecionarArquivo
            // 
            btnSelecionarArquivo.Location = new Point(926, 45);
            btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            btnSelecionarArquivo.Size = new Size(75, 23);
            btnSelecionarArquivo.TabIndex = 7;
            btnSelecionarArquivo.Text = "Selecionar...";
            btnSelecionarArquivo.UseVisualStyleBackColor = true;
            // 
            // dgvDocumentos
            // 
            dgvDocumentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocumentos.Location = new Point(6, 101);
            dgvDocumentos.Name = "dgvDocumentos";
            dgvDocumentos.Size = new Size(1076, 319);
            dgvDocumentos.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblDocumentos
            // 
            lblDocumentos.AutoSize = true;
            lblDocumentos.Location = new Point(6, 83);
            lblDocumentos.Name = "lblDocumentos";
            lblDocumentos.Size = new Size(75, 15);
            lblDocumentos.TabIndex = 9;
            lblDocumentos.Text = "Documentos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTipo);
            groupBox1.Controls.Add(lblDocumentos);
            groupBox1.Controls.Add(lblArquivo);
            groupBox1.Controls.Add(dgvDocumentos);
            groupBox1.Controls.Add(lblTipoDoc);
            groupBox1.Controls.Add(btnSelecionarArquivo);
            groupBox1.Controls.Add(lblCandidato);
            groupBox1.Controls.Add(btnUpload);
            groupBox1.Controls.Add(txtArquivo);
            groupBox1.Controls.Add(cmbCandidato);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1088, 426);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // frmUploadDocumentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 450);
            Controls.Add(groupBox1);
            Name = "frmUploadDocumentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela de Upload de Documentos";
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
        private Label lblDocumentos;
        private GroupBox groupBox1;
    }
}