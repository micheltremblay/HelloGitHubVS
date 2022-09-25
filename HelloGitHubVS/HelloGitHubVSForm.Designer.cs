namespace HelloGitHubVS
{
    partial class HelloGitHubVSForm
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
            this.helloButton = new System.Windows.Forms.Button();
            this.modifierButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helloButton
            // 
            this.helloButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.helloButton.Location = new System.Drawing.Point(99, 40);
            this.helloButton.Name = "helloButton";
            this.helloButton.Size = new System.Drawing.Size(153, 36);
            this.helloButton.TabIndex = 0;
            this.helloButton.Text = "Hello GitHub";
            this.helloButton.UseVisualStyleBackColor = false;
            this.helloButton.Click += new System.EventHandler(this.helloButton_Click);
            // 
            // modifierButton
            // 
            this.modifierButton.Location = new System.Drawing.Point(99, 83);
            this.modifierButton.Name = "modifierButton";
            this.modifierButton.Size = new System.Drawing.Size(153, 52);
            this.modifierButton.TabIndex = 1;
            this.modifierButton.Text = "Modifier la couleur de l\'arrière-plan du formulaire";
            this.modifierButton.UseVisualStyleBackColor = true;
            this.modifierButton.Click += new System.EventHandler(this.modifierButton_Click);
            // 
            // HelloGitHubVSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 192);
            this.Controls.Add(this.modifierButton);
            this.Controls.Add(this.helloButton);
            this.Name = "HelloGitHubVSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GitHub et Git pour Visual Studio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button helloButton;
        private System.Windows.Forms.Button modifierButton;
    }
}

