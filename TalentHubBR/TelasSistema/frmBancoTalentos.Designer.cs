
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTalentos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(14, 32);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(42, 15);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(13, 50);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(1065, 23);
            txtBuscar.TabIndex = 1;
            // 
            // btnReativarCandidato
            // 
            btnReativarCandidato.Location = new Point(14, 329);
            btnReativarCandidato.Name = "btnReativarCandidato";
            btnReativarCandidato.Size = new Size(126, 23);
            btnReativarCandidato.TabIndex = 2;
            btnReativarCandidato.Text = "Reativar Candidato";
            btnReativarCandidato.UseVisualStyleBackColor = true;
            btnReativarCandidato.Click += btnReativarCandidato_Click;
            // 
            // dgvTalentos
            // 
            dgvTalentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTalentos.Location = new Point(14, 108);
            dgvTalentos.Name = "dgvTalentos";
            dgvTalentos.Size = new Size(1065, 215);
            dgvTalentos.TabIndex = 3;
            dgvTalentos.CellContentClick += dgvTalentos_CellContentClick;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(1004, 79);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblBuscar);
            groupBox1.Controls.Add(btnReativarCandidato);
            groupBox1.Controls.Add(dgvTalentos);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(txtBuscar);
            groupBox1.Location = new Point(-1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1108, 380);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 87);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 5;
            label1.Text = "Lista de Talentos";
            // 
            // frmBancoTalentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 382);
            Controls.Add(groupBox1);
            Name = "frmBancoTalentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Banco de Talentos";
            ((System.ComponentModel.ISupportInitialize)dgvTalentos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            Load += frmBancoTalentos_Load;
        }
       
        #endregion

        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnReativarCandidato;
        private DataGridView dgvTalentos;
        private Button btnBuscar;
        private GroupBox groupBox1;
        private Label label1;
    }
}