
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
            lblNome = new Label();
            txtNomeEmpresa = new TextBox();
            lblContato = new Label();
            txtContatoEmpresa = new TextBox();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            dataGridView1 = new DataGridView();
            lblListaEmpresasCadastradas = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(22, 33);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            lblNome.Click += label1_Click;
            // 
            // txtNomeEmpresa
            // 
            txtNomeEmpresa.Location = new Point(80, 30);
            txtNomeEmpresa.Name = "txtNomeEmpresa";
            txtNomeEmpresa.Size = new Size(294, 23);
            txtNomeEmpresa.TabIndex = 1;
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Location = new Point(22, 69);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(50, 15);
            lblContato.TabIndex = 2;
            lblContato.Text = "Contato";
            // 
            // txtContatoEmpresa
            // 
            txtContatoEmpresa.Location = new Point(78, 66);
            txtContatoEmpresa.Name = "txtContatoEmpresa";
            txtContatoEmpresa.Size = new Size(296, 23);
            txtContatoEmpresa.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(78, 108);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(188, 108);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(299, 108);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(393, 347);
            dataGridView1.TabIndex = 7;
            // 
            // lblListaEmpresasCadastradas
            // 
            lblListaEmpresasCadastradas.AutoSize = true;
            lblListaEmpresasCadastradas.Location = new Point(12, 168);
            lblListaEmpresasCadastradas.Name = "lblListaEmpresasCadastradas";
            lblListaEmpresasCadastradas.Size = new Size(153, 15);
            lblListaEmpresasCadastradas.TabIndex = 8;
            lblListaEmpresasCadastradas.Text = "Listar Empresas cadastradas";
            // 
            // frmCadastroEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 545);
            Controls.Add(lblListaEmpresasCadastradas);
            Controls.Add(dataGridView1);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(txtContatoEmpresa);
            Controls.Add(lblContato);
            Controls.Add(txtNomeEmpresa);
            Controls.Add(lblNome);
            Name = "frmCadastroEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Cadastro de Empresa";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Label lblListaEmpresasCadastradas;
    }
}