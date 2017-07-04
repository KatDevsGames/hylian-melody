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
            this.tabControlTrackEditor = new System.Windows.Forms.TabControl();
            this.tabTrackEdit1 = new System.Windows.Forms.TabPage();
            this.trackEditor1 = new HylianMelody.TrackEditor();
            this.tabTrackEdit2 = new System.Windows.Forms.TabPage();
            this.trackEditor2 = new HylianMelody.TrackEditor();
            this.tabTrackEdit3 = new System.Windows.Forms.TabPage();
            this.trackEditor3 = new HylianMelody.TrackEditor();
            this.tabTrackEdit4 = new System.Windows.Forms.TabPage();
            this.trackEditor4 = new HylianMelody.TrackEditor();
            this.tabTrackEdit5 = new System.Windows.Forms.TabPage();
            this.trackEditor5 = new HylianMelody.TrackEditor();
            this.tabTrackEdit6 = new System.Windows.Forms.TabPage();
            this.trackEditor6 = new HylianMelody.TrackEditor();
            this.tabTrackEdit7 = new System.Windows.Forms.TabPage();
            this.trackEditor7 = new HylianMelody.TrackEditor();
            this.tabTrackEdit8 = new System.Windows.Forms.TabPage();
            this.trackEditor8 = new HylianMelody.TrackEditor();
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
            this.tabControlTrackEditor.SuspendLayout();
            this.tabTrackEdit1.SuspendLayout();
            this.tabTrackEdit2.SuspendLayout();
            this.tabTrackEdit3.SuspendLayout();
            this.tabTrackEdit4.SuspendLayout();
            this.tabTrackEdit5.SuspendLayout();
            this.tabTrackEdit6.SuspendLayout();
            this.tabTrackEdit7.SuspendLayout();
            this.tabTrackEdit8.SuspendLayout();
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
            this.groupSongs.Controls.Add(this.listSongs);
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
            this.listSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSongs.FormattingEnabled = true;
            this.listSongs.Location = new System.Drawing.Point(3, 16);
            this.listSongs.Name = "listSongs";
            this.listSongs.Size = new System.Drawing.Size(188, 174);
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
            this.groupTrackEditor.Controls.Add(this.tabControlTrackEditor);
            this.groupTrackEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTrackEditor.Location = new System.Drawing.Point(0, 0);
            this.groupTrackEditor.Name = "groupTrackEditor";
            this.groupTrackEditor.Size = new System.Drawing.Size(512, 385);
            this.groupTrackEditor.TabIndex = 4;
            this.groupTrackEditor.TabStop = false;
            this.groupTrackEditor.Text = "Track Editor";
            // 
            // tabControlTrackEditor
            // 
            this.tabControlTrackEditor.Controls.Add(this.tabTrackEdit1);
            this.tabControlTrackEditor.Controls.Add(this.tabTrackEdit2);
            this.tabControlTrackEditor.Controls.Add(this.tabTrackEdit3);
            this.tabControlTrackEditor.Controls.Add(this.tabTrackEdit4);
            this.tabControlTrackEditor.Controls.Add(this.tabTrackEdit5);
            this.tabControlTrackEditor.Controls.Add(this.tabTrackEdit6);
            this.tabControlTrackEditor.Controls.Add(this.tabTrackEdit7);
            this.tabControlTrackEditor.Controls.Add(this.tabTrackEdit8);
            this.tabControlTrackEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTrackEditor.ItemSize = new System.Drawing.Size(21, 18);
            this.tabControlTrackEditor.Location = new System.Drawing.Point(3, 16);
            this.tabControlTrackEditor.Name = "tabControlTrackEditor";
            this.tabControlTrackEditor.SelectedIndex = 0;
            this.tabControlTrackEditor.Size = new System.Drawing.Size(506, 366);
            this.tabControlTrackEditor.TabIndex = 2;
            // 
            // tabTrackEdit1
            // 
            this.tabTrackEdit1.Controls.Add(this.trackEditor1);
            this.tabTrackEdit1.Location = new System.Drawing.Point(4, 22);
            this.tabTrackEdit1.Name = "tabTrackEdit1";
            this.tabTrackEdit1.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrackEdit1.Size = new System.Drawing.Size(498, 340);
            this.tabTrackEdit1.TabIndex = 0;
            this.tabTrackEdit1.Text = "1";
            this.tabTrackEdit1.UseVisualStyleBackColor = true;
            // 
            // trackEditor1
            // 
            this.trackEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackEditor1.Location = new System.Drawing.Point(3, 3);
            this.trackEditor1.Name = "trackEditor1";
            this.trackEditor1.Size = new System.Drawing.Size(492, 334);
            this.trackEditor1.TabIndex = 0;
            // 
            // tabTrackEdit2
            // 
            this.tabTrackEdit2.Controls.Add(this.trackEditor2);
            this.tabTrackEdit2.Location = new System.Drawing.Point(4, 22);
            this.tabTrackEdit2.Name = "tabTrackEdit2";
            this.tabTrackEdit2.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrackEdit2.Size = new System.Drawing.Size(498, 340);
            this.tabTrackEdit2.TabIndex = 1;
            this.tabTrackEdit2.Text = "2";
            this.tabTrackEdit2.UseVisualStyleBackColor = true;
            // 
            // trackEditor2
            // 
            this.trackEditor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackEditor2.Location = new System.Drawing.Point(3, 3);
            this.trackEditor2.Name = "trackEditor2";
            this.trackEditor2.Size = new System.Drawing.Size(492, 334);
            this.trackEditor2.TabIndex = 1;
            // 
            // tabTrackEdit3
            // 
            this.tabTrackEdit3.Controls.Add(this.trackEditor3);
            this.tabTrackEdit3.Location = new System.Drawing.Point(4, 22);
            this.tabTrackEdit3.Name = "tabTrackEdit3";
            this.tabTrackEdit3.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrackEdit3.Size = new System.Drawing.Size(498, 340);
            this.tabTrackEdit3.TabIndex = 0;
            this.tabTrackEdit3.Text = "3";
            this.tabTrackEdit3.UseVisualStyleBackColor = true;
            // 
            // trackEditor3
            // 
            this.trackEditor3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackEditor3.Location = new System.Drawing.Point(3, 3);
            this.trackEditor3.Name = "trackEditor3";
            this.trackEditor3.Size = new System.Drawing.Size(492, 334);
            this.trackEditor3.TabIndex = 1;
            // 
            // tabTrackEdit4
            // 
            this.tabTrackEdit4.Controls.Add(this.trackEditor4);
            this.tabTrackEdit4.Location = new System.Drawing.Point(4, 22);
            this.tabTrackEdit4.Name = "tabTrackEdit4";
            this.tabTrackEdit4.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrackEdit4.Size = new System.Drawing.Size(498, 340);
            this.tabTrackEdit4.TabIndex = 0;
            this.tabTrackEdit4.Text = "4";
            this.tabTrackEdit4.UseVisualStyleBackColor = true;
            // 
            // trackEditor4
            // 
            this.trackEditor4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackEditor4.Location = new System.Drawing.Point(3, 3);
            this.trackEditor4.Name = "trackEditor4";
            this.trackEditor4.Size = new System.Drawing.Size(492, 334);
            this.trackEditor4.TabIndex = 1;
            // 
            // tabTrackEdit5
            // 
            this.tabTrackEdit5.Controls.Add(this.trackEditor5);
            this.tabTrackEdit5.Location = new System.Drawing.Point(4, 22);
            this.tabTrackEdit5.Name = "tabTrackEdit5";
            this.tabTrackEdit5.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrackEdit5.Size = new System.Drawing.Size(498, 340);
            this.tabTrackEdit5.TabIndex = 0;
            this.tabTrackEdit5.Text = "5";
            this.tabTrackEdit5.UseVisualStyleBackColor = true;
            // 
            // trackEditor5
            // 
            this.trackEditor5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackEditor5.Location = new System.Drawing.Point(3, 3);
            this.trackEditor5.Name = "trackEditor5";
            this.trackEditor5.Size = new System.Drawing.Size(492, 334);
            this.trackEditor5.TabIndex = 1;
            // 
            // tabTrackEdit6
            // 
            this.tabTrackEdit6.Controls.Add(this.trackEditor6);
            this.tabTrackEdit6.Location = new System.Drawing.Point(4, 22);
            this.tabTrackEdit6.Name = "tabTrackEdit6";
            this.tabTrackEdit6.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrackEdit6.Size = new System.Drawing.Size(498, 340);
            this.tabTrackEdit6.TabIndex = 0;
            this.tabTrackEdit6.Text = "6";
            this.tabTrackEdit6.UseVisualStyleBackColor = true;
            // 
            // trackEditor6
            // 
            this.trackEditor6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackEditor6.Location = new System.Drawing.Point(3, 3);
            this.trackEditor6.Name = "trackEditor6";
            this.trackEditor6.Size = new System.Drawing.Size(492, 334);
            this.trackEditor6.TabIndex = 1;
            // 
            // tabTrackEdit7
            // 
            this.tabTrackEdit7.Controls.Add(this.trackEditor7);
            this.tabTrackEdit7.Location = new System.Drawing.Point(4, 22);
            this.tabTrackEdit7.Name = "tabTrackEdit7";
            this.tabTrackEdit7.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrackEdit7.Size = new System.Drawing.Size(498, 340);
            this.tabTrackEdit7.TabIndex = 0;
            this.tabTrackEdit7.Text = "7";
            this.tabTrackEdit7.UseVisualStyleBackColor = true;
            // 
            // trackEditor7
            // 
            this.trackEditor7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackEditor7.Location = new System.Drawing.Point(3, 3);
            this.trackEditor7.Name = "trackEditor7";
            this.trackEditor7.Size = new System.Drawing.Size(492, 334);
            this.trackEditor7.TabIndex = 1;
            // 
            // tabTrackEdit8
            // 
            this.tabTrackEdit8.Controls.Add(this.trackEditor8);
            this.tabTrackEdit8.Location = new System.Drawing.Point(4, 22);
            this.tabTrackEdit8.Name = "tabTrackEdit8";
            this.tabTrackEdit8.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrackEdit8.Size = new System.Drawing.Size(498, 340);
            this.tabTrackEdit8.TabIndex = 0;
            this.tabTrackEdit8.Text = "8";
            this.tabTrackEdit8.UseVisualStyleBackColor = true;
            // 
            // trackEditor8
            // 
            this.trackEditor8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackEditor8.Location = new System.Drawing.Point(3, 3);
            this.trackEditor8.Name = "trackEditor8";
            this.trackEditor8.Size = new System.Drawing.Size(492, 334);
            this.trackEditor8.TabIndex = 1;
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
            this.tabControlTrackEditor.ResumeLayout(false);
            this.tabTrackEdit1.ResumeLayout(false);
            this.tabTrackEdit2.ResumeLayout(false);
            this.tabTrackEdit3.ResumeLayout(false);
            this.tabTrackEdit4.ResumeLayout(false);
            this.tabTrackEdit5.ResumeLayout(false);
            this.tabTrackEdit6.ResumeLayout(false);
            this.tabTrackEdit7.ResumeLayout(false);
            this.tabTrackEdit8.ResumeLayout(false);
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
        private TabControl tabControlTrackEditor;
        private TabPage tabTrackEdit1;
        private TabPage tabTrackEdit2;
        private TabPage tabTrackEdit3;
        private TabPage tabTrackEdit4;
        private TabPage tabTrackEdit5;
        private TabPage tabTrackEdit6;
        private TabPage tabTrackEdit7;
        private TabPage tabTrackEdit8;
        private SplitContainer splitLeft;
        private TrackEditor trackEditor1;
        private TrackEditor trackEditor2;
        private TrackEditor trackEditor3;
        private TrackEditor trackEditor4;
        private TrackEditor trackEditor5;
        private TrackEditor trackEditor6;
        private TrackEditor trackEditor7;
        private TrackEditor trackEditor8;
        private ToolStripSeparator toolStripSeparator1;
    }
}

