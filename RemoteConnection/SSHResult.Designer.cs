namespace RemoteConnection
{
    partial class SSHResult
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
            this.pBoxScreenShot = new System.Windows.Forms.PictureBox();
            this.txtBoxSSHResult = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxScreenShot)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxScreenShot
            // 
            this.pBoxScreenShot.Location = new System.Drawing.Point(29, 118);
            this.pBoxScreenShot.Name = "pBoxScreenShot";
            this.pBoxScreenShot.Size = new System.Drawing.Size(245, 146);
            this.pBoxScreenShot.TabIndex = 0;
            this.pBoxScreenShot.TabStop = false;
            // 
            // txtBoxSSHResult
            // 
            this.txtBoxSSHResult.Location = new System.Drawing.Point(25, 12);
            this.txtBoxSSHResult.Name = "txtBoxSSHResult";
            this.txtBoxSSHResult.Size = new System.Drawing.Size(256, 96);
            this.txtBoxSSHResult.TabIndex = 1;
            this.txtBoxSSHResult.Text = "";
            // 
            // SSHResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.txtBoxSSHResult);
            this.Controls.Add(this.pBoxScreenShot);
            this.Name = "SSHResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSHResult";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxScreenShot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxScreenShot;
        private System.Windows.Forms.RichTextBox txtBoxSSHResult;
    }
}