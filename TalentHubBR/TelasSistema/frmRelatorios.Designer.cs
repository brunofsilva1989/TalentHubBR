namespace TalentHubBR.UI.TelasSistema
{
    partial class frmRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorio));
            lblSelecionado = new Label();
            lblTipo = new Label();
            cmbSelecionado = new ComboBox();
            cmbTipoRelatorio = new ComboBox();
            btnGerarRelatorio = new Button();
            dgvRelatorios = new DataGridView();
            lblRelatorios = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorios).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSelecionado
            // 
            lblSelecionado.AutoSize = true;
            lblSelecionado.BackColor = SystemColors.ActiveCaption;
            lblSelecionado.Location = new Point(515, 25);
            lblSelecionado.Name = "lblSelecionado";
            lblSelecionado.Size = new Size(96, 19);
            lblSelecionado.TabIndex = 2;
            lblSelecionado.Text = "Selecionado:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = SystemColors.ActiveCaption;
            lblTipo.ForeColor = SystemColors.ActiveCaptionText;
            lblTipo.Location = new Point(6, 25);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(39, 19);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo";
            // 
            // cmbSelecionado
            // 
            cmbSelecionado.FormattingEnabled = true;
            cmbSelecionado.Items.AddRange(new object[] { "Geral" });
            cmbSelecionado.Location = new Point(515, 48);
            cmbSelecionado.Name = "cmbSelecionado";
            cmbSelecionado.Size = new Size(500, 27);
            cmbSelecionado.TabIndex = 3;
            cmbSelecionado.SelectedIndexChanged += cmbSelecionado_SelectedIndexChanged;
            // 
            // cmbTipoRelatorio
            // 
            cmbTipoRelatorio.FormattingEnabled = true;
            cmbTipoRelatorio.Items.AddRange(new object[] { "Selecione", "Candidatos", "Empresas", "Vagas", "Feedbacks" });
            cmbTipoRelatorio.Location = new Point(6, 48);
            cmbTipoRelatorio.Name = "cmbTipoRelatorio";
            cmbTipoRelatorio.Size = new Size(503, 27);
            cmbTipoRelatorio.TabIndex = 1;
            cmbTipoRelatorio.Text = "Ex: Rel. Candidato";
            cmbTipoRelatorio.SelectedIndexChanged += cmbTipoRelatorio_SelectedIndexChanged;
            // 
            // btnGerarRelatorio
            // 
            btnGerarRelatorio.Image = (Image)resources.GetObject("btnGerarRelatorio.Image");
            btnGerarRelatorio.Location = new Point(1021, 48);
            btnGerarRelatorio.Name = "btnGerarRelatorio";
            btnGerarRelatorio.Size = new Size(61, 46);
            btnGerarRelatorio.TabIndex = 6;
            btnGerarRelatorio.UseVisualStyleBackColor = true;
            btnGerarRelatorio.Click += btnGerarRelatorio_Click;
            // 
            // dgvRelatorios
            // 
            dgvRelatorios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRelatorios.BackgroundColor = SystemColors.ButtonHighlight;
            dgvRelatorios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRelatorios.Location = new Point(6, 127);
            dgvRelatorios.Name = "dgvRelatorios";
            dgvRelatorios.Size = new Size(1076, 260);
            dgvRelatorios.TabIndex = 5;
            dgvRelatorios.CellContentClick += dgvRelatorios_CellContentClick;
            // 
            // lblRelatorios
            // 
            lblRelatorios.AutoSize = true;
            lblRelatorios.BackColor = SystemColors.ActiveCaption;
            lblRelatorios.Location = new Point(6, 105);
            lblRelatorios.Name = "lblRelatorios";
            lblRelatorios.Size = new Size(79, 19);
            lblRelatorios.TabIndex = 4;
            lblRelatorios.Text = "Relatorios";
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dgvRelatorios);
            groupBox1.Controls.Add(lblRelatorios);
            groupBox1.Controls.Add(lblSelecionado);
            groupBox1.Controls.Add(btnGerarRelatorio);
            groupBox1.Controls.Add(lblTipo);
            groupBox1.Controls.Add(cmbTipoRelatorio);
            groupBox1.Controls.Add(cmbSelecionado);
            groupBox1.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(-2, -10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1090, 465);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(1029, 393);
            button1.Name = "button1";
            button1.Size = new Size(53, 52);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmRelatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 450);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRelatorio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TalentHub Br - Relatórios";
            Load += a_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRelatorios).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblSelecionado;
        private Label lblTipo;
        private ComboBox cmbSelecionado;
        private ComboBox cmbTipoRelatorio;
        private Button btnGerarRelatorio;
        private DataGridView dgvRelatorios;
        private Label lblRelatorios;
        private GroupBox groupBox1;
        private Button button1;
    }
}