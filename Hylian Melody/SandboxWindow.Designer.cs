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
            this.nspcTracker = new HylianMelody.NSPC.NSPCTracker();
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.tableMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // nspcTracker
            // 
            this.nspcTracker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nspcTracker.Location = new System.Drawing.Point(3, 3);
            this.nspcTracker.Name = "nspcTracker";
            this.nspcTracker.Scroll = 0F;
            this.nspcTracker.Size = new System.Drawing.Size(664, 376);
            this.nspcTracker.TabIndex = 0;
            this.nspcTracker.Text = "nspcTracker";
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 2;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableMain.Controls.Add(this.nspcTracker, 0, 0);
            this.tableMain.Controls.Add(this.vScrollBar, 1, 0);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 1;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Size = new System.Drawing.Size(687, 382);
            this.tableMain.TabIndex = 1;
            // 
            // vScrollBar
            // 
            this.vScrollBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vScrollBar.Location = new System.Drawing.Point(670, 0);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(17, 382);
            this.vScrollBar.TabIndex = 1;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Scroll);
            // 
            // SandboxWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 382);
            this.Controls.Add(this.tableMain);
            this.Name = "SandboxWindow";
            this.Text = "SandboxWindow";
            this.Shown += new System.EventHandler(this.SandboxWindow_Shown);
            this.tableMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NSPC.NSPCTracker nspcTracker;
        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.VScrollBar vScrollBar;
    }
}