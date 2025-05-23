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
            ((System.ComponentModel.ISupportInitialize)dgvRelatorios).BeginInit();
            SuspendLayout();
            // 
            // lblSelecionado
            // 
            lblSelecionado.AutoSize = true;
            lblSelecionado.Location = new Point(12, 73);
            lblSelecionado.Name = "lblSelecionado";
            lblSelecionado.Size = new Size(74, 15);
            lblSelecionado.TabIndex = 0;
            lblSelecionado.Text = "Selecionado:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(12, 36);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo";
            // 
            // cmbSelecionado
            // 
            cmbSelecionado.FormattingEnabled = true;
            cmbSelecionado.Location = new Point(101, 73);
            cmbSelecionado.Name = "cmbSelecionado";
            cmbSelecionado.Size = new Size(208, 23);
            cmbSelecionado.TabIndex = 2;
            cmbSelecionado.Text = "Nome x";
            // 
            // cmbTipoRelatorio
            // 
            cmbTipoRelatorio.FormattingEnabled = true;
            cmbTipoRelatorio.Location = new Point(101, 36);
            cmbTipoRelatorio.Name = "cmbTipoRelatorio";
            cmbTipoRelatorio.Size = new Size(208, 23);
            cmbTipoRelatorio.TabIndex = 3;
            cmbTipoRelatorio.Text = "Por Candidato";
            // 
            // btnGerarRelatorio
            // 
            btnGerarRelatorio.Location = new Point(12, 102);
            btnGerarRelatorio.Name = "btnGerarRelatorio";
            btnGerarRelatorio.Size = new Size(100, 23);
            btnGerarRelatorio.TabIndex = 4;
            btnGerarRelatorio.Text = "Gerar Relatório";
            btnGerarRelatorio.UseVisualStyleBackColor = true;
            // 
            // dgvRelatorios
            // 
            dgvRelatorios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRelatorios.Location = new Point(12, 160);
            dgvRelatorios.Name = "dgvRelatorios";
            dgvRelatorios.Size = new Size(297, 278);
            dgvRelatorios.TabIndex = 5;
            // 
            // lblRelatorios
            // 
            lblRelatorios.AutoSize = true;
            lblRelatorios.Location = new Point(12, 142);
            lblRelatorios.Name = "lblRelatorios";
            lblRelatorios.Size = new Size(59, 15);
            lblRelatorios.TabIndex = 6;
            lblRelatorios.Text = "Relatorios";
            // 
            // a
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 450);
            Controls.Add(lblRelatorios);
            Controls.Add(dgvRelatorios);
            Controls.Add(btnGerarRelatorio);
            Controls.Add(cmbTipoRelatorio);
            Controls.Add(cmbSelecionado);
            Controls.Add(lblTipo);
            Controls.Add(lblSelecionado);
            Name = "a";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela de Relatório";
            ((System.ComponentModel.ISupportInitialize)dgvRelatorios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSelecionado;
        private Label lblTipo;
        private ComboBox cmbSelecionado;
        private ComboBox cmbTipoRelatorio;
        private Button btnGerarRelatorio;
        private DataGridView dgvRelatorios;
        private Label lblRelatorios;
    }
}