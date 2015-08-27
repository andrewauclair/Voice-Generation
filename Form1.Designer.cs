namespace VoiceGeneration
{
	partial class Form1
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
			this.text_rate = new System.Windows.Forms.TextBox();
			this.text_bps = new System.Windows.Forms.TextBox();
			this.text_channel = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGrid = new System.Windows.Forms.DataGridView();
			this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button_listen = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// text_rate
			// 
			this.text_rate.Enabled = false;
			this.text_rate.Location = new System.Drawing.Point(198, 6);
			this.text_rate.Name = "text_rate";
			this.text_rate.Size = new System.Drawing.Size(100, 20);
			this.text_rate.TabIndex = 0;
			this.text_rate.Text = "41000";
			// 
			// text_bps
			// 
			this.text_bps.Enabled = false;
			this.text_bps.Location = new System.Drawing.Point(198, 32);
			this.text_bps.Name = "text_bps";
			this.text_bps.Size = new System.Drawing.Size(100, 20);
			this.text_bps.TabIndex = 1;
			this.text_bps.Text = "16";
			// 
			// text_channel
			// 
			this.text_channel.Enabled = false;
			this.text_channel.Location = new System.Drawing.Point(198, 59);
			this.text_channel.Name = "text_channel";
			this.text_channel.Size = new System.Drawing.Size(100, 20);
			this.text_channel.TabIndex = 2;
			this.text_channel.Text = "2";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(347, 24);
			this.menuStrip1.TabIndex = 7;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.loadToolStripMenuItem.Text = "Open";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.saveAsToolStripMenuItem.Text = "Save As";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(139, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Channels";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(112, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Bits per Sample";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(124, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Sample Rate";
			// 
			// dataGrid
			// 
			this.dataGrid.AllowDrop = true;
			this.dataGrid.AllowUserToResizeRows = false;
			this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.Line});
			this.dataGrid.Location = new System.Drawing.Point(17, 91);
			this.dataGrid.Name = "dataGrid";
			this.dataGrid.Size = new System.Drawing.Size(318, 366);
			this.dataGrid.TabIndex = 14;
			this.dataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
			this.dataGrid.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGrid_DragDrop);
			this.dataGrid.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGrid_DragEnter);
			this.dataGrid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGrid_KeyUp);
			// 
			// FileName
			// 
			this.FileName.HeaderText = "File Name";
			this.FileName.Name = "FileName";
			this.FileName.Width = 150;
			// 
			// Line
			// 
			this.Line.HeaderText = "Line";
			this.Line.Name = "Line";
			// 
			// button_listen
			// 
			this.button_listen.Location = new System.Drawing.Point(17, 57);
			this.button_listen.Name = "button_listen";
			this.button_listen.Size = new System.Drawing.Size(75, 23);
			this.button_listen.TabIndex = 15;
			this.button_listen.Text = "Play";
			this.button_listen.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(17, 27);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 16;
			this.button1.Text = "Generate";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(347, 469);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button_listen);
			this.Controls.Add(this.dataGrid);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.text_channel);
			this.Controls.Add(this.text_bps);
			this.Controls.Add(this.text_rate);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox text_rate;
		private System.Windows.Forms.TextBox text_bps;
		private System.Windows.Forms.TextBox text_channel;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Line;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.Button button_listen;
		private System.Windows.Forms.Button button1;
	}
}

