namespace TalentHubBR.UI.TelasSistema
{
    partial class frmAjuda
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            lblManualUsuario = new Label();
            label2 = new Label();
            label3 = new Label();
            helpProvider1 = new HelpProvider();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(165, 20);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Abrir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(165, 84);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Abrir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(165, 148);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Abrir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lblManualUsuario
            // 
            lblManualUsuario.AutoSize = true;
            lblManualUsuario.Location = new Point(36, 24);
            lblManualUsuario.Name = "lblManualUsuario";
            lblManualUsuario.Size = new Size(107, 15);
            lblManualUsuario.TabIndex = 3;
            lblManualUsuario.Text = "Manual do Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 88);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 4;
            label2.Text = "Manual de Atalhos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 152);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 5;
            label3.Text = "Versão do Software";
            // 
            // frmAjuda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 215);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblManualUsuario);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "frmAjuda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ajuda do Usuário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label lblManualUsuario;
        private Label label2;
        private Label label3;
        private HelpProvider helpProvider1;
    }
}