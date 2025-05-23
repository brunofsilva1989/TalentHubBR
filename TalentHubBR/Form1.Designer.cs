namespace TalentHubBR.UI
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            cadastrarEmpresaToolStripMenuItem = new ToolStripMenuItem();
            cadastrarEmpresaToolStripMenuItem1 = new ToolStripMenuItem();
            cadastrarVagaToolStripMenuItem = new ToolStripMenuItem();
            cadastrarCandidatoToolStripMenuItem = new ToolStripMenuItem();
            uploadDeDocumentosToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            bancoDeTalentosToolStripMenuItem = new ToolStripMenuItem();
            aToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrarEmpresaToolStripMenuItem, relatóriosToolStripMenuItem, bancoDeTalentosToolStripMenuItem, aToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1015, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarEmpresaToolStripMenuItem
            // 
            cadastrarEmpresaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarEmpresaToolStripMenuItem1, cadastrarVagaToolStripMenuItem, cadastrarCandidatoToolStripMenuItem, uploadDeDocumentosToolStripMenuItem });
            cadastrarEmpresaToolStripMenuItem.Name = "cadastrarEmpresaToolStripMenuItem";
            cadastrarEmpresaToolStripMenuItem.Size = new Size(71, 20);
            cadastrarEmpresaToolStripMenuItem.Text = "Cadastros";
            cadastrarEmpresaToolStripMenuItem.Click += cadastrarEmpresaToolStripMenuItem_Click;
            // 
            // cadastrarEmpresaToolStripMenuItem1
            // 
            cadastrarEmpresaToolStripMenuItem1.Name = "cadastrarEmpresaToolStripMenuItem1";
            cadastrarEmpresaToolStripMenuItem1.Size = new Size(199, 22);
            cadastrarEmpresaToolStripMenuItem1.Text = "Cadastrar Empresa";
            cadastrarEmpresaToolStripMenuItem1.Click += cadastrarEmpresaToolStripMenuItem1_Click;
            // 
            // cadastrarVagaToolStripMenuItem
            // 
            cadastrarVagaToolStripMenuItem.Name = "cadastrarVagaToolStripMenuItem";
            cadastrarVagaToolStripMenuItem.Size = new Size(199, 22);
            cadastrarVagaToolStripMenuItem.Text = "Cadastrar Vaga";
            cadastrarVagaToolStripMenuItem.Click += cadastrarVagaToolStripMenuItem_Click;
            // 
            // cadastrarCandidatoToolStripMenuItem
            // 
            cadastrarCandidatoToolStripMenuItem.Name = "cadastrarCandidatoToolStripMenuItem";
            cadastrarCandidatoToolStripMenuItem.Size = new Size(199, 22);
            cadastrarCandidatoToolStripMenuItem.Text = "Cadastrar Candidato";
            cadastrarCandidatoToolStripMenuItem.Click += cadastrarCandidatoToolStripMenuItem_Click;
            // 
            // uploadDeDocumentosToolStripMenuItem
            // 
            uploadDeDocumentosToolStripMenuItem.Name = "uploadDeDocumentosToolStripMenuItem";
            uploadDeDocumentosToolStripMenuItem.Size = new Size(199, 22);
            uploadDeDocumentosToolStripMenuItem.Text = "Upload de Documentos";
            uploadDeDocumentosToolStripMenuItem.Click += uploadDeDocumentosToolStripMenuItem_Click;
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            relatóriosToolStripMenuItem.Click += relatóriosToolStripMenuItem_Click;
            // 
            // bancoDeTalentosToolStripMenuItem
            // 
            bancoDeTalentosToolStripMenuItem.Name = "bancoDeTalentosToolStripMenuItem";
            bancoDeTalentosToolStripMenuItem.Size = new Size(114, 20);
            bancoDeTalentosToolStripMenuItem.Text = "Banco de Talentos";
            bancoDeTalentosToolStripMenuItem.Click += bancoDeTalentosToolStripMenuItem_Click;
            // 
            // aToolStripMenuItem
            // 
            aToolStripMenuItem.Name = "aToolStripMenuItem";
            aToolStripMenuItem.Size = new Size(50, 20);
            aToolStripMenuItem.Text = "Ajuda";
            aToolStripMenuItem.Click += aToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 578);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrarEmpresaToolStripMenuItem;
        private ToolStripMenuItem cadastrarEmpresaToolStripMenuItem1;
        private ToolStripMenuItem cadastrarVagaToolStripMenuItem;
        private ToolStripMenuItem cadastrarCandidatoToolStripMenuItem;
        private ToolStripMenuItem uploadDeDocumentosToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem bancoDeTalentosToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItem;
    }
}