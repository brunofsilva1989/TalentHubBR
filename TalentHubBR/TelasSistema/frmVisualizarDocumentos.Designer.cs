namespace TalentHubBR.UI.TelasSistema
{
    partial class frmVisualizarDocumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizarDocumentos));
            groupBox1 = new GroupBox();
            button1 = new Button();
            dgvDocumentos = new DataGridView();
            lblCandidato = new Label();
            btnVerDoc = new Button();
            cmbCandidato = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocumentos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dgvDocumentos);
            groupBox1.Controls.Add(lblCandidato);
            groupBox1.Controls.Add(btnVerDoc);
            groupBox1.Controls.Add(cmbCandidato);
            groupBox1.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(1, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1102, 541);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(1047, 0);
            button1.Name = "button1";
            button1.Size = new Size(55, 49);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvDocumentos
            // 
            dgvDocumentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDocumentos.BackgroundColor = SystemColors.HighlightText;
            dgvDocumentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocumentos.Location = new Point(11, 99);
            dgvDocumentos.Name = "dgvDocumentos";
            dgvDocumentos.Size = new Size(1085, 436);
            dgvDocumentos.TabIndex = 2;
            dgvDocumentos.CellContentClick += dgvDocumentos_CellContentClick;
            // 
            // lblCandidato
            // 
            lblCandidato.AutoSize = true;
            lblCandidato.Location = new Point(11, 17);
            lblCandidato.Name = "lblCandidato";
            lblCandidato.Size = new Size(166, 19);
            lblCandidato.TabIndex = 0;
            lblCandidato.Text = "Selecione o Candidato:";
            // 
            // btnVerDoc
            // 
            btnVerDoc.BackgroundImage = (Image)resources.GetObject("btnVerDoc.BackgroundImage");
            btnVerDoc.BackgroundImageLayout = ImageLayout.Center;
            btnVerDoc.Location = new Point(200, 22);
            btnVerDoc.Name = "btnVerDoc";
            btnVerDoc.Size = new Size(57, 58);
            btnVerDoc.TabIndex = 3;
            btnVerDoc.UseVisualStyleBackColor = true;
            btnVerDoc.Click += btnVerDoc_Click;
            // 
            // cmbCandidato
            // 
            cmbCandidato.FormattingEnabled = true;
            cmbCandidato.Items.AddRange(new object[] { "Nome" });
            cmbCandidato.Location = new Point(11, 39);
            cmbCandidato.Name = "cmbCandidato";
            cmbCandidato.Size = new Size(183, 27);
            cmbCandidato.TabIndex = 1;
            cmbCandidato.SelectedIndexChanged += cmbCandidato_SelectedIndexChanged;
            // 
            // frmVisualizarDocumentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1115, 565);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmVisualizarDocumentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualizar Documentos do Candidato";
            Load += frmVisualizarDocumentos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocumentos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvDocumentos;
        private Label lblCandidato;
        private Button btnVerDoc;
        private ComboBox cmbCandidato;
        private Button button1;
    }
}