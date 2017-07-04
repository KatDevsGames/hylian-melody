using System.ComponentModel;
using System.Windows.Forms;

namespace HylianMelody
{
    partial class TrackEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.Properties = new System.Windows.Forms.GroupBox();
            this.groupActions = new System.Windows.Forms.GroupBox();
            this.listCommands = new System.Windows.Forms.ListBox();
            this.tableMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.AutoSize = true;
            this.tableMain.ColumnCount = 2;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain.Controls.Add(this.Properties, 1, 0);
            this.tableMain.Controls.Add(this.groupActions, 1, 1);
            this.tableMain.Controls.Add(this.listCommands, 0, 0);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 2;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain.Size = new System.Drawing.Size(525, 405);
            this.tableMain.TabIndex = 0;
            // 
            // Properties
            // 
            this.Properties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Properties.Location = new System.Drawing.Point(265, 3);
            this.Properties.Name = "Properties";
            this.Properties.Size = new System.Drawing.Size(257, 196);
            this.Properties.TabIndex = 1;
            this.Properties.TabStop = false;
            this.Properties.Text = "Properties";
            // 
            // groupActions
            // 
            this.groupActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupActions.Location = new System.Drawing.Point(265, 205);
            this.groupActions.Name = "groupActions";
            this.groupActions.Size = new System.Drawing.Size(257, 197);
            this.groupActions.TabIndex = 2;
            this.groupActions.TabStop = false;
            this.groupActions.Text = "Actions";
            // 
            // listCommands
            // 
            this.listCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCommands.FormattingEnabled = true;
            this.listCommands.Location = new System.Drawing.Point(3, 3);
            this.listCommands.Name = "listCommands";
            this.tableMain.SetRowSpan(this.listCommands, 2);
            this.listCommands.Size = new System.Drawing.Size(256, 399);
            this.listCommands.TabIndex = 3;
            // 
            // TrackEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableMain);
            this.Name = "TrackEditor";
            this.Size = new System.Drawing.Size(525, 405);
            this.tableMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableMain;
        private GroupBox Properties;
        private GroupBox groupActions;
        private ListBox listCommands;
    }
}
