namespace TalentHubBR.UI.TelasSistema
{
    partial class CustomMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            lblMensagem = new Label();
            btnOk = new Button();
            SuspendLayout();
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.BackColor = Color.MidnightBlue;
            lblMensagem.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensagem.ForeColor = SystemColors.HighlightText;
            lblMensagem.Location = new Point(30, 27);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(22, 22);
            lblMensagem.TabIndex = 0;
            lblMensagem.Text = "...";
            lblMensagem.Click += lblMensagem_Click;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.MidnightBlue;
            btnOk.BackgroundImageLayout = ImageLayout.Center;
            btnOk.Font = new Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOk.ForeColor = SystemColors.Highlight;
            btnOk.Location = new Point(30, 62);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(66, 31);
            btnOk.TabIndex = 1;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(348, 138);
            Controls.Add(btnOk);
            Controls.Add(lblMensagem);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CustomMessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomMessageBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensagem;
        private Button btnOk;
    }
}