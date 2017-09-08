using System.ComponentModel;
using System.Windows.Forms;

namespace HylianMelody
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.splitLeft = new System.Windows.Forms.SplitContainer();
            this.groupSongs = new System.Windows.Forms.GroupBox();
            this.listSongs = new System.Windows.Forms.ListBox();
            this.groupSegments = new System.Windows.Forms.GroupBox();
            this.tableSegmentList = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSegmentRemove = new System.Windows.Forms.Button();
            this.listSegments = new System.Windows.Forms.ListBox();
            this.buttonSegmentAdd = new System.Windows.Forms.Button();
            this.groupTrackEditor = new System.Windows.Forms.GroupBox();
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSongRemove = new System.Windows.Forms.Button();
            this.buttonSongAdd = new System.Windows.Forms.Button();
            this.nspcTracker = new HylianMelody.NSPC.NSPCTracker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLeft)).BeginInit();
            this.splitLeft.Panel1.SuspendLayout();
            this.splitLeft.Panel2.SuspendLayout();
            this.splitLeft.SuspendLayout();
            this.groupSongs.SuspendLayout();
            this.groupSegments.SuspendLayout();
            this.tableSegmentList.SuspendLayout();
            this.groupTrackEditor.SuspendLayout();
            this.tableMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(710, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
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
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 24);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.splitLeft);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.groupTrackEditor);
            this.splitMain.Size = new System.Drawing.Size(710, 385);
            this.splitMain.SplitterDistance = 194;
            this.splitMain.TabIndex = 2;
            // 
            // splitLeft
            // 
            this.splitLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLeft.Location = new System.Drawing.Point(0, 0);
            this.splitLeft.Name = "splitLeft";
            this.splitLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitLeft.Panel1
            // 
            this.splitLeft.Panel1.Controls.Add(this.groupSongs);
            // 
            // splitLeft.Panel2
            // 
            this.splitLeft.Panel2.Controls.Add(this.groupSegments);
            this.splitLeft.Size = new System.Drawing.Size(194, 385);
            this.splitLeft.SplitterDistance = 193;
            this.splitLeft.TabIndex = 0;
            // 
            // groupSongs
            // 
            this.groupSongs.Controls.Add(this.tableLayoutPanel1);
            this.groupSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupSongs.Location = new System.Drawing.Point(0, 0);
            this.groupSongs.Name = "groupSongs";
            this.groupSongs.Size = new System.Drawing.Size(194, 193);
            this.groupSongs.TabIndex = 0;
            this.groupSongs.TabStop = false;
            this.groupSongs.Text = "Songs";
            // 
            // listSongs
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.listSongs, 2);
            this.listSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSongs.FormattingEnabled = true;
            this.listSongs.Location = new System.Drawing.Point(3, 3);
            this.listSongs.Name = "listSongs";
            this.listSongs.Size = new System.Drawing.Size(182, 139);
            this.listSongs.TabIndex = 0;
            this.listSongs.SelectedIndexChanged += new System.EventHandler(this.listSongs_SelectedIndexChanged);
            // 
            // groupSegments
            // 
            this.groupSegments.Controls.Add(this.tableSegmentList);
            this.groupSegments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupSegments.Location = new System.Drawing.Point(0, 0);
            this.groupSegments.Name = "groupSegments";
            this.groupSegments.Size = new System.Drawing.Size(194, 188);
            this.groupSegments.TabIndex = 1;
            this.groupSegments.TabStop = false;
            this.groupSegments.Text = "Segments";
            // 
            // tableSegmentList
            // 
            this.tableSegmentList.ColumnCount = 2;
            this.tableSegmentList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableSegmentList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSegmentList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSegmentList.Controls.Add(this.buttonSegmentRemove, 1, 1);
            this.tableSegmentList.Controls.Add(this.listSegments, 0, 0);
            this.tableSegmentList.Controls.Add(this.buttonSegmentAdd, 0, 1);
            this.tableSegmentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSegmentList.Location = new System.Drawing.Point(3, 16);
            this.tableSegmentList.Name = "tableSegmentList";
            this.tableSegmentList.RowCount = 2;
            this.tableSegmentList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSegmentList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSegmentList.Size = new System.Drawing.Size(188, 169);
            this.tableSegmentList.TabIndex = 1;
            // 
            // buttonSegmentRemove
            // 
            this.buttonSegmentRemove.AutoSize = true;
            this.buttonSegmentRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSegmentRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSegmentRemove.Location = new System.Drawing.Point(96, 143);
            this.buttonSegmentRemove.Name = "buttonSegmentRemove";
            this.buttonSegmentRemove.Size = new System.Drawing.Size(89, 23);
            this.buttonSegmentRemove.TabIndex = 2;
            this.buttonSegmentRemove.Text = "Remove";
            this.buttonSegmentRemove.UseVisualStyleBackColor = true;
            this.buttonSegmentRemove.Click += new System.EventHandler(this.buttonSegmentRemove_Click);
            // 
            // listSegments
            // 
            this.tableSegmentList.SetColumnSpan(this.listSegments, 2);
            this.listSegments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSegments.FormattingEnabled = true;
            this.listSegments.Location = new System.Drawing.Point(3, 3);
            this.listSegments.Name = "listSegments";
            this.listSegments.Size = new System.Drawing.Size(182, 134);
            this.listSegments.TabIndex = 0;
            this.listSegments.SelectedIndexChanged += new System.EventHandler(this.listSegments_SelectedIndexChanged);
            // 
            // buttonSegmentAdd
            // 
            this.buttonSegmentAdd.AutoSize = true;
            this.buttonSegmentAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSegmentAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSegmentAdd.Location = new System.Drawing.Point(3, 143);
            this.buttonSegmentAdd.Name = "buttonSegmentAdd";
            this.buttonSegmentAdd.Size = new System.Drawing.Size(87, 23);
            this.buttonSegmentAdd.TabIndex = 1;
            this.buttonSegmentAdd.Text = "Add";
            this.buttonSegmentAdd.UseVisualStyleBackColor = true;
            this.buttonSegmentAdd.Click += new System.EventHandler(this.buttonSegmentAdd_Click);
            // 
            // groupTrackEditor
            // 
            this.groupTrackEditor.Controls.Add(this.tableMain);
            this.groupTrackEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTrackEditor.Location = new System.Drawing.Point(0, 0);
            this.groupTrackEditor.Name = "groupTrackEditor";
            this.groupTrackEditor.Size = new System.Drawing.Size(512, 385);
            this.groupTrackEditor.TabIndex = 4;
            this.groupTrackEditor.TabStop = false;
            this.groupTrackEditor.Text = "Track Editor";
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 2;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableMain.Controls.Add(this.nspcTracker, 0, 0);
            this.tableMain.Controls.Add(this.vScrollBar, 1, 0);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(3, 16);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 1;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Size = new System.Drawing.Size(506, 366);
            this.tableMain.TabIndex = 2;
            // 
            // vScrollBar
            // 
            this.vScrollBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vScrollBar.Location = new System.Drawing.Point(489, 0);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(17, 366);
            this.vScrollBar.TabIndex = 1;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Scroll);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.buttonSongRemove, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listSongs, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSongAdd, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(188, 174);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // buttonSongRemove
            // 
            this.buttonSongRemove.AutoSize = true;
            this.buttonSongRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSongRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSongRemove.Location = new System.Drawing.Point(96, 148);
            this.buttonSongRemove.Name = "buttonSongRemove";
            this.buttonSongRemove.Size = new System.Drawing.Size(89, 23);
            this.buttonSongRemove.TabIndex = 2;
            this.buttonSongRemove.Text = "Remove";
            this.buttonSongRemove.UseVisualStyleBackColor = true;
            this.buttonSongRemove.Click += new System.EventHandler(this.buttonSongRemove_Click);
            // 
            // buttonSongAdd
            // 
            this.buttonSongAdd.AutoSize = true;
            this.buttonSongAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSongAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSongAdd.Location = new System.Drawing.Point(3, 148);
            this.buttonSongAdd.Name = "buttonSongAdd";
            this.buttonSongAdd.Size = new System.Drawing.Size(87, 23);
            this.buttonSongAdd.TabIndex = 1;
            this.buttonSongAdd.Text = "Add";
            this.buttonSongAdd.UseVisualStyleBackColor = true;
            this.buttonSongAdd.Click += new System.EventHandler(this.buttonSongAdd_Click);
            // 
            // nspcTracker
            // 
            this.nspcTracker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nspcTracker.Location = new System.Drawing.Point(3, 3);
            this.nspcTracker.Name = "nspcTracker";
            this.nspcTracker.Scroll = 0F;
            this.nspcTracker.Size = new System.Drawing.Size(483, 360);
            this.nspcTracker.TabIndex = 0;
            this.nspcTracker.Text = "nspcTracker";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 409);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Hylian Melody";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.splitLeft.Panel1.ResumeLayout(false);
            this.splitLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLeft)).EndInit();
            this.splitLeft.ResumeLayout(false);
            this.groupSongs.ResumeLayout(false);
            this.groupSegments.ResumeLayout(false);
            this.tableSegmentList.ResumeLayout(false);
            this.tableSegmentList.PerformLayout();
            this.groupTrackEditor.ResumeLayout(false);
            this.tableMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private SplitContainer splitMain;
        private GroupBox groupSongs;
        private ListBox listSongs;
        private GroupBox groupSegments;
        private TableLayoutPanel tableSegmentList;
        private Button buttonSegmentRemove;
        private ListBox listSegments;
        private Button buttonSegmentAdd;
        private GroupBox groupTrackEditor;
        private SplitContainer splitLeft;
        private ToolStripSeparator toolStripSeparator1;
        private TableLayoutPanel tableMain;
        private NSPC.NSPCTracker nspcTracker;
        private VScrollBar vScrollBar;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonSongRemove;
        private Button buttonSongAdd;
    }
}

