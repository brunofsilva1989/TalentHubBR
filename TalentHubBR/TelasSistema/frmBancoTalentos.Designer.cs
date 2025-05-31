
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBancoTalentos));
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnReativarCandidato = new Button();
            dgvTalentos = new DataGridView();
            btnBuscar = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTalentos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(14, 28);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(55, 19);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(13, 50);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(1064, 29);
            txtBuscar.TabIndex = 1;
            // 
            // btnReativarCandidato
            // 
            btnReativarCandidato.BackgroundImage = (Image)resources.GetObject("btnReativarCandidato.BackgroundImage");
            btnReativarCandidato.BackgroundImageLayout = ImageLayout.Center;
            btnReativarCandidato.Location = new Point(14, 377);
            btnReativarCandidato.Name = "btnReativarCandidato";
            btnReativarCandidato.Size = new Size(55, 46);
            btnReativarCandidato.TabIndex = 2;
            btnReativarCandidato.UseVisualStyleBackColor = true;
            btnReativarCandidato.Click += btnReativarCandidato_Click;
            // 
            // dgvTalentos
            // 
            dgvTalentos.BackgroundColor = SystemColors.HighlightText;
            dgvTalentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTalentos.Location = new Point(12, 146);
            dgvTalentos.Name = "dgvTalentos";
            dgvTalentos.Size = new Size(1065, 215);
            dgvTalentos.TabIndex = 3;
            dgvTalentos.CellContentClick += dgvTalentos_CellContentClick;
            // 
            // btnBuscar
            // 
            btnBuscar.BackgroundImage = (Image)resources.GetObject("btnBuscar.BackgroundImage");
            btnBuscar.BackgroundImageLayout = ImageLayout.Center;
            btnBuscar.ForeColor = SystemColors.Control;
            btnBuscar.Location = new Point(1017, 85);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(60, 55);
            btnBuscar.TabIndex = 4;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblBuscar);
            groupBox1.Controls.Add(btnReativarCandidato);
            groupBox1.Controls.Add(dgvTalentos);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(txtBuscar);
            groupBox1.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(-1, -11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1097, 441);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(1026, 377);
            button1.Name = "button1";
            button1.Size = new Size(51, 52);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 124);
            label1.Name = "label1";
            label1.Size = new Size(124, 19);
            label1.TabIndex = 5;
            label1.Text = "Lista de Talentos";
            // 
            // frmBancoTalentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 425);
            Controls.Add(groupBox1);
            Name = "frmBancoTalentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Banco de Talentos";
            Load += frmBancoTalentos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTalentos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnReativarCandidato;
        private DataGridView dgvTalentos;
        private Button btnBuscar;
        private GroupBox groupBox1;
        private Label label1;
        private Button button1;
    }
}