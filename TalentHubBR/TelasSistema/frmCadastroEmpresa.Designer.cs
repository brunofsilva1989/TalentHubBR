
namespace TalentHubBR.UI.TelasSistema
{
    partial class frmCadastroEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroEmpresa));
            lblNome = new Label();
            txtNomeEmpresa = new TextBox();
            lblContato = new Label();
            txtContatoEmpresa = new TextBox();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            dgvEmpresas = new DataGridView();
            lblListaEmpresasCadastradas = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmpresas).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = SystemColors.ActiveCaption;
            lblNome.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(12, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(116, 19);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome Empresa";
            lblNome.Click += label1_Click;
            // 
            // txtNomeEmpresa
            // 
            txtNomeEmpresa.Location = new Point(12, 31);
            txtNomeEmpresa.Name = "txtNomeEmpresa";
            txtNomeEmpresa.Size = new Size(368, 23);
            txtNomeEmpresa.TabIndex = 1;
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.BackColor = SystemColors.ActiveCaption;
            lblContato.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContato.Location = new Point(386, 9);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(64, 19);
            lblContato.TabIndex = 2;
            lblContato.Text = "Contato";
            lblContato.Click += lblContato_Click;
            // 
            // txtContatoEmpresa
            // 
            txtContatoEmpresa.Location = new Point(386, 31);
            txtContatoEmpresa.Name = "txtContatoEmpresa";
            txtContatoEmpresa.Size = new Size(246, 23);
            txtContatoEmpresa.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(582, 151);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(50, 54);
            btnSalvar.TabIndex = 8;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(582, 211);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(50, 51);
            btnEditar.TabIndex = 9;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.Location = new Point(582, 268);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(50, 51);
            btnExcluir.TabIndex = 10;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dgvEmpresas
            // 
            dgvEmpresas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEmpresas.BackgroundColor = SystemColors.ButtonFace;
            dgvEmpresas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpresas.Location = new Point(12, 151);
            dgvEmpresas.Name = "dgvEmpresas";
            dgvEmpresas.Size = new Size(555, 328);
            dgvEmpresas.TabIndex = 7;
            dgvEmpresas.CellContentClick += dgvEmpresas_CellContentClick;
            // 
            // lblListaEmpresasCadastradas
            // 
            lblListaEmpresasCadastradas.AutoSize = true;
            lblListaEmpresasCadastradas.BackColor = SystemColors.ActiveCaption;
            lblListaEmpresasCadastradas.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblListaEmpresasCadastradas.Location = new Point(12, 129);
            lblListaEmpresasCadastradas.Name = "lblListaEmpresasCadastradas";
            lblListaEmpresasCadastradas.Size = new Size(162, 19);
            lblListaEmpresasCadastradas.TabIndex = 6;
            lblListaEmpresasCadastradas.Text = "Empresas cadastradas";
            lblListaEmpresasCadastradas.Click += lblListaEmpresasCadastradas_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 89);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(402, 23);
            txtEmail.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(47, 19);
            label1.TabIndex = 4;
            label1.Text = "Email";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(582, 428);
            button1.Name = "button1";
            button1.Size = new Size(50, 51);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmCadastroEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(644, 488);
            Controls.Add(button1);
            Controls.Add(btnExcluir);
            Controls.Add(dgvEmpresas);
            Controls.Add(btnEditar);
            Controls.Add(txtEmail);
            Controls.Add(btnSalvar);
            Controls.Add(lblListaEmpresasCadastradas);
            Controls.Add(label1);
            Controls.Add(lblNome);
            Controls.Add(txtNomeEmpresa);
            Controls.Add(lblContato);
            Controls.Add(txtContatoEmpresa);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadastroEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Cadastro de Empresa";
            Load += frmCadastroEmpresa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpresas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNomeEmpresa;
        private Label lblContato;
        private TextBox txtContatoEmpresa;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
        private DataGridView dgvEmpresas;
        private Label lblListaEmpresasCadastradas;
        private TextBox txtEmail;
        private Label label1;
        private Button button1;
    }
}