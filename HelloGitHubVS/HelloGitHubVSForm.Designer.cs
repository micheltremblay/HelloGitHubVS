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
            this.SuspendLayout();
            // 
            // helloButton
            // 
            this.helloButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.helloButton.Location = new System.Drawing.Point(93, 73);
            this.helloButton.Name = "helloButton";
            this.helloButton.Size = new System.Drawing.Size(153, 36);
            this.helloButton.TabIndex = 0;
            this.helloButton.Text = "Hello GitHub";
            this.helloButton.UseVisualStyleBackColor = false;
            this.helloButton.Click += new System.EventHandler(this.helloButton_Click);
            // 
            // HelloGitHubVSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 192);
            this.Controls.Add(this.helloButton);
            this.Name = "HelloGitHubVSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GitHub et Git pour Visual Studio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button helloButton;
    }
}

