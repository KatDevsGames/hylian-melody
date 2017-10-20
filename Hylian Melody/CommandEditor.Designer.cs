namespace HylianMelody
{
    partial class CommandEditor
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
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupCommand = new System.Windows.Forms.GroupBox();
            this.comboCommand = new System.Windows.Forms.ComboBox();
            this.groupParameters = new System.Windows.Forms.GroupBox();
            this.tableParameters = new System.Windows.Forms.TableLayoutPanel();
            this.numericParameter3 = new HylianMelody.HexNumericUpDown();
            this.numericParameter2 = new HylianMelody.HexNumericUpDown();
            this.numericParameter1 = new HylianMelody.HexNumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupSubroutines = new System.Windows.Forms.GroupBox();
            this.comboSubroutines = new System.Windows.Forms.ComboBox();
            this.tableMain.SuspendLayout();
            this.groupCommand.SuspendLayout();
            this.groupParameters.SuspendLayout();
            this.tableParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericParameter3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericParameter2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericParameter1)).BeginInit();
            this.groupSubroutines.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.AutoSize = true;
            this.tableMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableMain.ColumnCount = 2;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain.Controls.Add(this.buttonCancel, 0, 3);
            this.tableMain.Controls.Add(this.groupCommand, 0, 0);
            this.tableMain.Controls.Add(this.groupParameters, 0, 1);
            this.tableMain.Controls.Add(this.buttonSave, 1, 3);
            this.tableMain.Controls.Add(this.groupSubroutines, 0, 2);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 4;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.Size = new System.Drawing.Size(340, 129);
            this.tableMain.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancel.Location = new System.Drawing.Point(3, 146);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(164, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupCommand
            // 
            this.groupCommand.AutoSize = true;
            this.groupCommand.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableMain.SetColumnSpan(this.groupCommand, 2);
            this.groupCommand.Controls.Add(this.comboCommand);
            this.groupCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupCommand.Location = new System.Drawing.Point(3, 3);
            this.groupCommand.Name = "groupCommand";
            this.groupCommand.Size = new System.Drawing.Size(334, 40);
            this.groupCommand.TabIndex = 0;
            this.groupCommand.TabStop = false;
            this.groupCommand.Text = "Command";
            // 
            // comboCommand
            // 
            this.comboCommand.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboCommand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCommand.FormattingEnabled = true;
            this.comboCommand.Location = new System.Drawing.Point(3, 16);
            this.comboCommand.Name = "comboCommand";
            this.comboCommand.Size = new System.Drawing.Size(328, 21);
            this.comboCommand.TabIndex = 0;
            this.comboCommand.SelectedIndexChanged += new System.EventHandler(this.comboCommand_SelectedIndexChanged);
            // 
            // groupParameters
            // 
            this.groupParameters.AutoSize = true;
            this.groupParameters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableMain.SetColumnSpan(this.groupParameters, 2);
            this.groupParameters.Controls.Add(this.tableParameters);
            this.groupParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupParameters.Location = new System.Drawing.Point(3, 49);
            this.groupParameters.Name = "groupParameters";
            this.groupParameters.Size = new System.Drawing.Size(334, 45);
            this.groupParameters.TabIndex = 1;
            this.groupParameters.TabStop = false;
            this.groupParameters.Text = "Parameters";
            this.groupParameters.Visible = false;
            // 
            // tableParameters
            // 
            this.tableParameters.AutoSize = true;
            this.tableParameters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableParameters.ColumnCount = 3;
            this.tableParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableParameters.Controls.Add(this.numericParameter3, 2, 0);
            this.tableParameters.Controls.Add(this.numericParameter2, 1, 0);
            this.tableParameters.Controls.Add(this.numericParameter1, 0, 0);
            this.tableParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableParameters.Location = new System.Drawing.Point(3, 16);
            this.tableParameters.Name = "tableParameters";
            this.tableParameters.RowCount = 1;
            this.tableParameters.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableParameters.Size = new System.Drawing.Size(328, 26);
            this.tableParameters.TabIndex = 0;
            // 
            // numericParameter3
            // 
            this.numericParameter3.AutoSize = true;
            this.numericParameter3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericParameter3.Hexadecimal = true;
            this.numericParameter3.Location = new System.Drawing.Point(221, 3);
            this.numericParameter3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericParameter3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericParameter3.Name = "numericParameter3";
            this.numericParameter3.Size = new System.Drawing.Size(104, 20);
            this.numericParameter3.TabIndex = 2;
            this.numericParameter3.Value = ((long)(0));
            // 
            // numericParameter2
            // 
            this.numericParameter2.AutoSize = true;
            this.numericParameter2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericParameter2.Hexadecimal = true;
            this.numericParameter2.Location = new System.Drawing.Point(112, 3);
            this.numericParameter2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericParameter2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericParameter2.Name = "numericParameter2";
            this.numericParameter2.Size = new System.Drawing.Size(103, 20);
            this.numericParameter2.TabIndex = 1;
            this.numericParameter2.Value = ((long)(0));
            // 
            // numericParameter1
            // 
            this.numericParameter1.AutoSize = true;
            this.numericParameter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericParameter1.Hexadecimal = true;
            this.numericParameter1.Location = new System.Drawing.Point(3, 3);
            this.numericParameter1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericParameter1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericParameter1.Name = "numericParameter1";
            this.numericParameter1.Size = new System.Drawing.Size(103, 20);
            this.numericParameter1.TabIndex = 0;
            this.numericParameter1.Value = ((long)(0));
            // 
            // buttonSave
            // 
            this.buttonSave.AutoSize = true;
            this.buttonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.Location = new System.Drawing.Point(173, 146);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(164, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupSubroutines
            // 
            this.groupSubroutines.AutoSize = true;
            this.groupSubroutines.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableMain.SetColumnSpan(this.groupSubroutines, 2);
            this.groupSubroutines.Controls.Add(this.comboSubroutines);
            this.groupSubroutines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupSubroutines.Location = new System.Drawing.Point(3, 100);
            this.groupSubroutines.Name = "groupSubroutines";
            this.groupSubroutines.Size = new System.Drawing.Size(334, 40);
            this.groupSubroutines.TabIndex = 4;
            this.groupSubroutines.TabStop = false;
            this.groupSubroutines.Text = "Subroutines";
            this.groupSubroutines.Visible = false;
            // 
            // comboSubroutines
            // 
            this.comboSubroutines.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboSubroutines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSubroutines.FormattingEnabled = true;
            this.comboSubroutines.Location = new System.Drawing.Point(3, 16);
            this.comboSubroutines.Name = "comboSubroutines";
            this.comboSubroutines.Size = new System.Drawing.Size(328, 21);
            this.comboSubroutines.TabIndex = 0;
            // 
            // CommandEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 129);
            this.Controls.Add(this.tableMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CommandEditor";
            this.Text = "Edit Command";
            this.Shown += new System.EventHandler(this.CommandEditor_Shown);
            this.tableMain.ResumeLayout(false);
            this.tableMain.PerformLayout();
            this.groupCommand.ResumeLayout(false);
            this.groupParameters.ResumeLayout(false);
            this.groupParameters.PerformLayout();
            this.tableParameters.ResumeLayout(false);
            this.tableParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericParameter3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericParameter2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericParameter1)).EndInit();
            this.groupSubroutines.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.GroupBox groupCommand;
        private System.Windows.Forms.ComboBox comboCommand;
        private System.Windows.Forms.GroupBox groupParameters;
        private System.Windows.Forms.TableLayoutPanel tableParameters;
        private HexNumericUpDown numericParameter3;
        private HexNumericUpDown numericParameter2;
        private HexNumericUpDown numericParameter1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupSubroutines;
        private System.Windows.Forms.ComboBox comboSubroutines;
    }
}