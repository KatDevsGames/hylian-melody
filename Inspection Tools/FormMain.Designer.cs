namespace Inspection_Tools
{
    partial class FormMain
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("General Information");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Spoiler Log");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("ROM", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("File 1");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("File 2");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("File 3");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Trace");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("SRAM", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerROM = new System.Windows.Forms.SplitContainer();
            this.treeViewROM = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerROM)).BeginInit();
            this.splitContainerROM.Panel1.SuspendLayout();
            this.splitContainerROM.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "&Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // splitContainerROM
            // 
            this.splitContainerROM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerROM.Location = new System.Drawing.Point(0, 24);
            this.splitContainerROM.Name = "splitContainerROM";
            // 
            // splitContainerROM.Panel1
            // 
            this.splitContainerROM.Panel1.Controls.Add(this.treeViewROM);
            this.splitContainerROM.Size = new System.Drawing.Size(653, 340);
            this.splitContainerROM.SplitterDistance = 150;
            this.splitContainerROM.TabIndex = 0;
            // 
            // treeViewROM
            // 
            this.treeViewROM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewROM.Location = new System.Drawing.Point(0, 0);
            this.treeViewROM.Name = "treeViewROM";
            treeNode1.Name = "NodeROMInfo";
            treeNode1.Text = "General Information";
            treeNode2.Name = "NodeROMSpoiler";
            treeNode2.Text = "Spoiler Log";
            treeNode3.Name = "NodeROM";
            treeNode3.Text = "ROM";
            treeNode4.Name = "NodeSRAMFile1";
            treeNode4.Text = "File 1";
            treeNode5.Name = "NodeSRAMFile2";
            treeNode5.Text = "File 2";
            treeNode6.Name = "NodeSRAMFile3";
            treeNode6.Text = "File 3";
            treeNode7.Name = "NodeSRAMTrace";
            treeNode7.Text = "Trace";
            treeNode8.Name = "NodeSRAM";
            treeNode8.Text = "SRAM";
            this.treeViewROM.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode8});
            this.treeViewROM.Size = new System.Drawing.Size(150, 340);
            this.treeViewROM.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 364);
            this.Controls.Add(this.splitContainerROM);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Randomizer Inspection Tools";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainerROM.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerROM)).EndInit();
            this.splitContainerROM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainerROM;
        private System.Windows.Forms.TreeView treeViewROM;
    }
}

