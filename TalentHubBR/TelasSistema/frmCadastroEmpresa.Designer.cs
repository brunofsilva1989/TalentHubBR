
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
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(13, 32);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            lblNome.Click += label1_Click;
            // 
            // txtNomeEmpresa
            // 
            txtNomeEmpresa.Location = new Point(13, 55);
            txtNomeEmpresa.Name = "txtNomeEmpresa";
            txtNomeEmpresa.Size = new Size(368, 23);
            txtNomeEmpresa.TabIndex = 1;
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Location = new Point(387, 32);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(50, 15);
            lblContato.TabIndex = 2;
            lblContato.Text = "Contato";
            // 
            // txtContatoEmpresa
            // 
            txtContatoEmpresa.Location = new Point(387, 55);
            txtContatoEmpresa.Name = "txtContatoEmpresa";
            txtContatoEmpresa.Size = new Size(354, 23);
            txtContatoEmpresa.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(348, 502);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(510, 502);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(666, 502);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1090, 363);
            dataGridView1.TabIndex = 7;
            // 
            // lblListaEmpresasCadastradas
            // 
            lblListaEmpresasCadastradas.AutoSize = true;
            lblListaEmpresasCadastradas.Location = new Point(6, 114);
            lblListaEmpresasCadastradas.Name = "lblListaEmpresasCadastradas";
            lblListaEmpresasCadastradas.Size = new Size(153, 15);
            lblListaEmpresasCadastradas.TabIndex = 8;
            lblListaEmpresasCadastradas.Text = "Listar Empresas cadastradas";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblNome);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(lblListaEmpresasCadastradas);
            groupBox1.Controls.Add(txtNomeEmpresa);
            groupBox1.Controls.Add(lblContato);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(txtContatoEmpresa);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Location = new Point(-1, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1116, 531);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // frmCadastroEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 545);
            Controls.Add(groupBox1);
            Name = "frmCadastroEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Cadastro de Empresa";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox groupBox1;
    }
}