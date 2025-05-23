namespace TalentHubBR.UI.TelasSistema
{
    partial class a
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
            lblSelecionado = new Label();
            lblTipo = new Label();
            cmbSelecionado = new ComboBox();
            cmbTipoRelatorio = new ComboBox();
            btnGerarRelatorio = new Button();
            dgvRelatorios = new DataGridView();
            lblRelatorios = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorios).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSelecionado
            // 
            lblSelecionado.AutoSize = true;
            lblSelecionado.Location = new Point(515, 41);
            lblSelecionado.Name = "lblSelecionado";
            lblSelecionado.Size = new Size(74, 15);
            lblSelecionado.TabIndex = 0;
            lblSelecionado.Text = "Selecionado:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(6, 41);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo";
            // 
            // cmbSelecionado
            // 
            cmbSelecionado.FormattingEnabled = true;
            cmbSelecionado.Location = new Point(515, 59);
            cmbSelecionado.Name = "cmbSelecionado";
            cmbSelecionado.Size = new Size(461, 23);
            cmbSelecionado.TabIndex = 2;
            cmbSelecionado.Text = "Nome x";
            // 
            // cmbTipoRelatorio
            // 
            cmbTipoRelatorio.FormattingEnabled = true;
            cmbTipoRelatorio.Location = new Point(6, 59);
            cmbTipoRelatorio.Name = "cmbTipoRelatorio";
            cmbTipoRelatorio.Size = new Size(503, 23);
            cmbTipoRelatorio.TabIndex = 3;
            cmbTipoRelatorio.Text = "Por Candidato";
            // 
            // btnGerarRelatorio
            // 
            btnGerarRelatorio.Location = new Point(982, 59);
            btnGerarRelatorio.Name = "btnGerarRelatorio";
            btnGerarRelatorio.Size = new Size(100, 23);
            btnGerarRelatorio.TabIndex = 4;
            btnGerarRelatorio.Text = "Gerar Relatório";
            btnGerarRelatorio.UseVisualStyleBackColor = true;
            // 
            // dgvRelatorios
            // 
            dgvRelatorios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRelatorios.Location = new Point(6, 127);
            dgvRelatorios.Name = "dgvRelatorios";
            dgvRelatorios.Size = new Size(1076, 293);
            dgvRelatorios.TabIndex = 5;
            // 
            // lblRelatorios
            // 
            lblRelatorios.AutoSize = true;
            lblRelatorios.Location = new Point(6, 98);
            lblRelatorios.Name = "lblRelatorios";
            lblRelatorios.Size = new Size(59, 15);
            lblRelatorios.TabIndex = 6;
            lblRelatorios.Text = "Relatorios";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvRelatorios);
            groupBox1.Controls.Add(lblRelatorios);
            groupBox1.Controls.Add(lblSelecionado);
            groupBox1.Controls.Add(btnGerarRelatorio);
            groupBox1.Controls.Add(lblTipo);
            groupBox1.Controls.Add(cmbTipoRelatorio);
            groupBox1.Controls.Add(cmbSelecionado);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1088, 426);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // a
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 450);
            Controls.Add(groupBox1);
            Name = "a";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela de Relatório";
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
    }
}