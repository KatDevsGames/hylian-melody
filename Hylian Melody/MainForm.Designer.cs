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
            this.groupTrackEditor = new System.Windows.Forms.GroupBox();
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.groupSongs = new System.Windows.Forms.GroupBox();
            this.tableSongs = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSongRemove = new System.Windows.Forms.Button();
            this.listSongs = new System.Windows.Forms.ListBox();
            this.buttonSongAdd = new System.Windows.Forms.Button();
            this.groupSegments = new System.Windows.Forms.GroupBox();
            this.tableSegments = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSegmentRemove = new System.Windows.Forms.Button();
            this.listSegments = new System.Windows.Forms.ListBox();
            this.buttonSegmentAdd = new System.Windows.Forms.Button();
            this.tableLeft = new System.Windows.Forms.TableLayoutPanel();
            this.groupSubroutines = new System.Windows.Forms.GroupBox();
            this.tableSubroutines = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSubroutineRemove = new System.Windows.Forms.Button();
            this.listSubroutines = new System.Windows.Forms.ListBox();
            this.buttonSubroutineAdd = new System.Windows.Forms.Button();
            this.nspcTracker = new HylianMelody.NSPC.NSPCTracker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.groupTrackEditor.SuspendLayout();
            this.tableMain.SuspendLayout();
            this.groupSongs.SuspendLayout();
            this.tableSongs.SuspendLayout();
            this.groupSegments.SuspendLayout();
            this.tableSegments.SuspendLayout();
            this.tableLeft.SuspendLayout();
            this.groupSubroutines.SuspendLayout();
            this.tableSubroutines.SuspendLayout();
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
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
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
            this.splitMain.Panel1.Controls.Add(this.tableLeft);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.groupTrackEditor);
            this.splitMain.Size = new System.Drawing.Size(710, 385);
            this.splitMain.SplitterDistance = 192;
            this.splitMain.TabIndex = 2;
            // 
            // groupTrackEditor
            // 
            this.groupTrackEditor.Controls.Add(this.tableMain);
            this.groupTrackEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTrackEditor.Location = new System.Drawing.Point(0, 0);
            this.groupTrackEditor.Name = "groupTrackEditor";
            this.groupTrackEditor.Size = new System.Drawing.Size(514, 385);
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
            this.tableMain.Size = new System.Drawing.Size(508, 366);
            this.tableMain.TabIndex = 2;
            // 
            // vScrollBar
            // 
            this.vScrollBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vScrollBar.Location = new System.Drawing.Point(491, 0);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(17, 366);
            this.vScrollBar.TabIndex = 1;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Scroll);
            // 
            // groupSongs
            // 
            this.groupSongs.Controls.Add(this.tableSongs);
            this.groupSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupSongs.Location = new System.Drawing.Point(3, 3);
            this.groupSongs.Name = "groupSongs";
            this.groupSongs.Size = new System.Drawing.Size(186, 122);
            this.groupSongs.TabIndex = 0;
            this.groupSongs.TabStop = false;
            this.groupSongs.Text = "Songs";
            // 
            // tableSongs
            // 
            this.tableSongs.ColumnCount = 2;
            this.tableSongs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableSongs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSongs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSongs.Controls.Add(this.buttonSongRemove, 1, 1);
            this.tableSongs.Controls.Add(this.listSongs, 0, 0);
            this.tableSongs.Controls.Add(this.buttonSongAdd, 0, 1);
            this.tableSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSongs.Location = new System.Drawing.Point(3, 16);
            this.tableSongs.Name = "tableSongs";
            this.tableSongs.RowCount = 2;
            this.tableSongs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSongs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSongs.Size = new System.Drawing.Size(180, 103);
            this.tableSongs.TabIndex = 2;
            // 
            // buttonSongRemove
            // 
            this.buttonSongRemove.AutoSize = true;
            this.buttonSongRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSongRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSongRemove.Location = new System.Drawing.Point(92, 77);
            this.buttonSongRemove.Name = "buttonSongRemove";
            this.buttonSongRemove.Size = new System.Drawing.Size(85, 23);
            this.buttonSongRemove.TabIndex = 2;
            this.buttonSongRemove.Text = "Remove";
            this.buttonSongRemove.UseVisualStyleBackColor = true;
            this.buttonSongRemove.Click += new System.EventHandler(this.buttonSongRemove_Click);
            // 
            // listSongs
            // 
            this.tableSongs.SetColumnSpan(this.listSongs, 2);
            this.listSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSongs.FormattingEnabled = true;
            this.listSongs.IntegralHeight = false;
            this.listSongs.Location = new System.Drawing.Point(3, 3);
            this.listSongs.Name = "listSongs";
            this.listSongs.Size = new System.Drawing.Size(174, 68);
            this.listSongs.TabIndex = 0;
            this.listSongs.SelectedIndexChanged += new System.EventHandler(this.listSongs_SelectedIndexChanged);
            // 
            // buttonSongAdd
            // 
            this.buttonSongAdd.AutoSize = true;
            this.buttonSongAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSongAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSongAdd.Location = new System.Drawing.Point(3, 77);
            this.buttonSongAdd.Name = "buttonSongAdd";
            this.buttonSongAdd.Size = new System.Drawing.Size(83, 23);
            this.buttonSongAdd.TabIndex = 1;
            this.buttonSongAdd.Text = "Add";
            this.buttonSongAdd.UseVisualStyleBackColor = true;
            this.buttonSongAdd.Click += new System.EventHandler(this.buttonSongAdd_Click);
            // 
            // groupSegments
            // 
            this.groupSegments.Controls.Add(this.tableSegments);
            this.groupSegments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupSegments.Location = new System.Drawing.Point(3, 131);
            this.groupSegments.Name = "groupSegments";
            this.groupSegments.Size = new System.Drawing.Size(186, 122);
            this.groupSegments.TabIndex = 1;
            this.groupSegments.TabStop = false;
            this.groupSegments.Text = "Segments";
            // 
            // tableSegments
            // 
            this.tableSegments.ColumnCount = 2;
            this.tableSegments.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableSegments.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSegments.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSegments.Controls.Add(this.buttonSegmentRemove, 1, 1);
            this.tableSegments.Controls.Add(this.listSegments, 0, 0);
            this.tableSegments.Controls.Add(this.buttonSegmentAdd, 0, 1);
            this.tableSegments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSegments.Location = new System.Drawing.Point(3, 16);
            this.tableSegments.Name = "tableSegments";
            this.tableSegments.RowCount = 2;
            this.tableSegments.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSegments.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSegments.Size = new System.Drawing.Size(180, 103);
            this.tableSegments.TabIndex = 1;
            // 
            // buttonSegmentRemove
            // 
            this.buttonSegmentRemove.AutoSize = true;
            this.buttonSegmentRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSegmentRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSegmentRemove.Location = new System.Drawing.Point(92, 77);
            this.buttonSegmentRemove.Name = "buttonSegmentRemove";
            this.buttonSegmentRemove.Size = new System.Drawing.Size(85, 23);
            this.buttonSegmentRemove.TabIndex = 2;
            this.buttonSegmentRemove.Text = "Remove";
            this.buttonSegmentRemove.UseVisualStyleBackColor = true;
            this.buttonSegmentRemove.Click += new System.EventHandler(this.buttonSegmentRemove_Click);
            // 
            // listSegments
            // 
            this.tableSegments.SetColumnSpan(this.listSegments, 2);
            this.listSegments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSegments.FormattingEnabled = true;
            this.listSegments.IntegralHeight = false;
            this.listSegments.Location = new System.Drawing.Point(3, 3);
            this.listSegments.Name = "listSegments";
            this.listSegments.Size = new System.Drawing.Size(174, 68);
            this.listSegments.TabIndex = 0;
            this.listSegments.SelectedIndexChanged += new System.EventHandler(this.listSegments_SelectedIndexChanged);
            // 
            // buttonSegmentAdd
            // 
            this.buttonSegmentAdd.AutoSize = true;
            this.buttonSegmentAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSegmentAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSegmentAdd.Location = new System.Drawing.Point(3, 77);
            this.buttonSegmentAdd.Name = "buttonSegmentAdd";
            this.buttonSegmentAdd.Size = new System.Drawing.Size(83, 23);
            this.buttonSegmentAdd.TabIndex = 1;
            this.buttonSegmentAdd.Text = "Add";
            this.buttonSegmentAdd.UseVisualStyleBackColor = true;
            this.buttonSegmentAdd.Click += new System.EventHandler(this.buttonSegmentAdd_Click);
            // 
            // tableLeft
            // 
            this.tableLeft.ColumnCount = 1;
            this.tableLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLeft.Controls.Add(this.groupSubroutines, 0, 2);
            this.tableLeft.Controls.Add(this.groupSongs, 0, 0);
            this.tableLeft.Controls.Add(this.groupSegments, 0, 1);
            this.tableLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLeft.Location = new System.Drawing.Point(0, 0);
            this.tableLeft.Name = "tableLeft";
            this.tableLeft.RowCount = 3;
            this.tableLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLeft.Size = new System.Drawing.Size(192, 385);
            this.tableLeft.TabIndex = 0;
            // 
            // groupSubroutines
            // 
            this.groupSubroutines.Controls.Add(this.tableSubroutines);
            this.groupSubroutines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupSubroutines.Location = new System.Drawing.Point(3, 259);
            this.groupSubroutines.Name = "groupSubroutines";
            this.groupSubroutines.Size = new System.Drawing.Size(186, 123);
            this.groupSubroutines.TabIndex = 3;
            this.groupSubroutines.TabStop = false;
            this.groupSubroutines.Text = "Subroutines";
            // 
            // tableSubroutines
            // 
            this.tableSubroutines.ColumnCount = 2;
            this.tableSubroutines.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableSubroutines.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSubroutines.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSubroutines.Controls.Add(this.buttonSubroutineRemove, 1, 1);
            this.tableSubroutines.Controls.Add(this.listSubroutines, 0, 0);
            this.tableSubroutines.Controls.Add(this.buttonSubroutineAdd, 0, 1);
            this.tableSubroutines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSubroutines.Location = new System.Drawing.Point(3, 16);
            this.tableSubroutines.Name = "tableSubroutines";
            this.tableSubroutines.RowCount = 2;
            this.tableSubroutines.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSubroutines.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSubroutines.Size = new System.Drawing.Size(180, 104);
            this.tableSubroutines.TabIndex = 1;
            // 
            // buttonSubroutineRemove
            // 
            this.buttonSubroutineRemove.AutoSize = true;
            this.buttonSubroutineRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSubroutineRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSubroutineRemove.Location = new System.Drawing.Point(92, 78);
            this.buttonSubroutineRemove.Name = "buttonSubroutineRemove";
            this.buttonSubroutineRemove.Size = new System.Drawing.Size(85, 23);
            this.buttonSubroutineRemove.TabIndex = 2;
            this.buttonSubroutineRemove.Text = "Remove";
            this.buttonSubroutineRemove.UseVisualStyleBackColor = true;
            this.buttonSubroutineRemove.Click += new System.EventHandler(this.buttonSubroutineRemove_Click);
            // 
            // listSubroutines
            // 
            this.tableSubroutines.SetColumnSpan(this.listSubroutines, 2);
            this.listSubroutines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSubroutines.FormattingEnabled = true;
            this.listSubroutines.IntegralHeight = false;
            this.listSubroutines.Location = new System.Drawing.Point(3, 3);
            this.listSubroutines.Name = "listSubroutines";
            this.listSubroutines.Size = new System.Drawing.Size(174, 69);
            this.listSubroutines.TabIndex = 0;
            this.listSubroutines.SelectedIndexChanged += new System.EventHandler(this.listSubroutines_SelectedIndexChanged);
            // 
            // buttonSubroutineAdd
            // 
            this.buttonSubroutineAdd.AutoSize = true;
            this.buttonSubroutineAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSubroutineAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSubroutineAdd.Location = new System.Drawing.Point(3, 78);
            this.buttonSubroutineAdd.Name = "buttonSubroutineAdd";
            this.buttonSubroutineAdd.Size = new System.Drawing.Size(83, 23);
            this.buttonSubroutineAdd.TabIndex = 1;
            this.buttonSubroutineAdd.Text = "Add";
            this.buttonSubroutineAdd.UseVisualStyleBackColor = true;
            this.buttonSubroutineAdd.Click += new System.EventHandler(this.buttonSubroutineAdd_Click);
            // 
            // nspcTracker
            // 
            this.nspcTracker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nspcTracker.Location = new System.Drawing.Point(3, 3);
            this.nspcTracker.Name = "nspcTracker";
            this.nspcTracker.Scroll = 0F;
            this.nspcTracker.Size = new System.Drawing.Size(485, 360);
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
            this.groupTrackEditor.ResumeLayout(false);
            this.tableMain.ResumeLayout(false);
            this.groupSongs.ResumeLayout(false);
            this.tableSongs.ResumeLayout(false);
            this.tableSongs.PerformLayout();
            this.groupSegments.ResumeLayout(false);
            this.tableSegments.ResumeLayout(false);
            this.tableSegments.PerformLayout();
            this.tableLeft.ResumeLayout(false);
            this.groupSubroutines.ResumeLayout(false);
            this.tableSubroutines.ResumeLayout(false);
            this.tableSubroutines.PerformLayout();
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
        private TableLayoutPanel tableSegments;
        private Button buttonSegmentRemove;
        private ListBox listSegments;
        private Button buttonSegmentAdd;
        private GroupBox groupTrackEditor;
        private ToolStripSeparator toolStripSeparator1;
        private TableLayoutPanel tableMain;
        private NSPC.NSPCTracker nspcTracker;
        private VScrollBar vScrollBar;
        private TableLayoutPanel tableSongs;
        private Button buttonSongRemove;
        private Button buttonSongAdd;
        private TableLayoutPanel tableLeft;
        private GroupBox groupSubroutines;
        private TableLayoutPanel tableSubroutines;
        private Button buttonSubroutineRemove;
        private ListBox listSubroutines;
        private Button buttonSubroutineAdd;
    }
}

