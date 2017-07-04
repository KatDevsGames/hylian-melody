namespace HylianMelody
{
    partial class SandboxWindow
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
            this.nspcTracker1 = new HylianMelody.NSPC.NSPCTracker();
            this.SuspendLayout();
            // 
            // nspcTracker1
            // 
            this.nspcTracker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nspcTracker1.Location = new System.Drawing.Point(0, 0);
            this.nspcTracker1.Name = "nspcTracker1";
            this.nspcTracker1.Size = new System.Drawing.Size(687, 382);
            this.nspcTracker1.TabIndex = 0;
            this.nspcTracker1.Text = "nspcTracker1";
            // 
            // SandboxWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 382);
            this.Controls.Add(this.nspcTracker1);
            this.Name = "SandboxWindow";
            this.Text = "SandboxWindow";
            this.Shown += new System.EventHandler(this.SandboxWindow_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private NSPC.NSPCTracker nspcTracker1;
    }
}