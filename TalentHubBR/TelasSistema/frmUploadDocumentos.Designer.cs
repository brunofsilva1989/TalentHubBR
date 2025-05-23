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
            ((System.ComponentModel.ISupportInitialize)dgvDocumentos).BeginInit();
            SuspendLayout();
            // 
            // lblArquivo
            // 
            lblArquivo.AutoSize = true;
            lblArquivo.Location = new Point(32, 127);
            lblArquivo.Name = "lblArquivo";
            lblArquivo.Size = new Size(49, 15);
            lblArquivo.TabIndex = 0;
            lblArquivo.Text = "Arquivo";
            // 
            // lblTipoDoc
            // 
            lblTipoDoc.AutoSize = true;
            lblTipoDoc.Location = new Point(32, 83);
            lblTipoDoc.Name = "lblTipoDoc";
            lblTipoDoc.Size = new Size(60, 15);
            lblTipoDoc.TabIndex = 1;
            lblTipoDoc.Text = "Tipo Doc.:";
            // 
            // lblCandidato
            // 
            lblCandidato.AutoSize = true;
            lblCandidato.Location = new Point(32, 36);
            lblCandidato.Name = "lblCandidato";
            lblCandidato.Size = new Size(65, 15);
            lblCandidato.TabIndex = 2;
            lblCandidato.Text = "Candidato:";
            // 
            // txtArquivo
            // 
            txtArquivo.Location = new Point(103, 124);
            txtArquivo.Name = "txtArquivo";
            txtArquivo.Size = new Size(184, 23);
            txtArquivo.TabIndex = 3;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(103, 80);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(265, 23);
            txtTipo.TabIndex = 4;
            // 
            // cmbCandidato
            // 
            cmbCandidato.FormattingEnabled = true;
            cmbCandidato.Items.AddRange(new object[] { "Nome" });
            cmbCandidato.Location = new Point(103, 33);
            cmbCandidato.Name = "cmbCandidato";
            cmbCandidato.Size = new Size(265, 23);
            cmbCandidato.TabIndex = 5;
            cmbCandidato.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(32, 171);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(75, 23);
            btnUpload.TabIndex = 6;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            // 
            // btnSelecionarArquivo
            // 
            btnSelecionarArquivo.Location = new Point(293, 124);
            btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            btnSelecionarArquivo.Size = new Size(75, 23);
            btnSelecionarArquivo.TabIndex = 7;
            btnSelecionarArquivo.Text = "Selecionar...";
            btnSelecionarArquivo.UseVisualStyleBackColor = true;
            // 
            // dgvDocumentos
            // 
            dgvDocumentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocumentos.Location = new Point(12, 230);
            dgvDocumentos.Name = "dgvDocumentos";
            dgvDocumentos.Size = new Size(376, 208);
            dgvDocumentos.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblDocumentos
            // 
            lblDocumentos.AutoSize = true;
            lblDocumentos.Location = new Point(12, 212);
            lblDocumentos.Name = "lblDocumentos";
            lblDocumentos.Size = new Size(75, 15);
            lblDocumentos.TabIndex = 9;
            lblDocumentos.Text = "Documentos";
            // 
            // frmUploadDocumentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 450);
            Controls.Add(lblDocumentos);
            Controls.Add(dgvDocumentos);
            Controls.Add(btnSelecionarArquivo);
            Controls.Add(btnUpload);
            Controls.Add(cmbCandidato);
            Controls.Add(txtTipo);
            Controls.Add(txtArquivo);
            Controls.Add(lblCandidato);
            Controls.Add(lblTipoDoc);
            Controls.Add(lblArquivo);
            Name = "frmUploadDocumentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela de Upload de Documentos";
            ((System.ComponentModel.ISupportInitialize)dgvDocumentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}