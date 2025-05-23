namespace TalentHubBR.UI.TelasSistema
{
    partial class frmBancoTalentos
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
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnReativarCandidato = new Button();
            dgvTalentos = new DataGridView();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTalentos).BeginInit();
            SuspendLayout();
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(31, 39);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(42, 15);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(31, 57);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(385, 23);
            txtBuscar.TabIndex = 1;
            // 
            // btnReativarCandidato
            // 
            btnReativarCandidato.Location = new Point(31, 274);
            btnReativarCandidato.Name = "btnReativarCandidato";
            btnReativarCandidato.Size = new Size(126, 23);
            btnReativarCandidato.TabIndex = 2;
            btnReativarCandidato.Text = "Reativar Candidato";
            btnReativarCandidato.UseVisualStyleBackColor = true;
            // 
            // dgvTalentos
            // 
            dgvTalentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTalentos.Location = new Point(31, 86);
            dgvTalentos.Name = "dgvTalentos";
            dgvTalentos.Size = new Size(466, 182);
            dgvTalentos.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(422, 57);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmBancoTalentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 318);
            Controls.Add(btnBuscar);
            Controls.Add(dgvTalentos);
            Controls.Add(btnReativarCandidato);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Name = "frmBancoTalentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Banco de Talentos";
            ((System.ComponentModel.ISupportInitialize)dgvTalentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnReativarCandidato;
        private DataGridView dgvTalentos;
        private Button btnBuscar;
    }
}