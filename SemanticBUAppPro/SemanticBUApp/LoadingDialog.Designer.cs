namespace SemanticBUApp
{
    partial class LoadingDialog
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
            this.panelloading = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panelloading.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelloading
            // 
            this.panelloading.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelloading.Controls.Add(this.label7);
            this.panelloading.Location = new System.Drawing.Point(0, 0);
            this.panelloading.Name = "panelloading";
            this.panelloading.Size = new System.Drawing.Size(316, 144);
            this.panelloading.TabIndex = 17;
            this.panelloading.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 18F);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(74, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Loading...";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // LoadingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 148);
            this.Controls.Add(this.panelloading);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panelloading.ResumeLayout(false);
            this.panelloading.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelloading;
        private System.Windows.Forms.Label label7;
    }
}