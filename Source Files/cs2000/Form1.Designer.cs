namespace cs2000
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.multiPanel = new cs2000.MultiPanel();
            this.WaitPage = new cs2000.MultiPanelPage();
            this.Wait_pictureBox = new System.Windows.Forms.PictureBox();
            this.WaitStatus_label = new System.Windows.Forms.Label();
            this.DataPage = new cs2000.MultiPanelPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RCOnly_radioButton = new System.Windows.Forms.RadioButton();
            this.ACOnly_radioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.ACandRC_radioButton = new System.Windows.Forms.RadioButton();
            this.Download_progressBar = new System.Windows.Forms.ProgressBar();
            this.fileName_label = new System.Windows.Forms.Label();
            this.Download_button = new System.Windows.Forms.Button();
            this.Versions_listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Notes_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Model_comboBox = new System.Windows.Forms.ComboBox();
            this.Refresh_button = new System.Windows.Forms.Button();
            this.multiPanel.SuspendLayout();
            this.WaitPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Wait_pictureBox)).BeginInit();
            this.DataPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "All files (*.*)|*.*";
            this.saveFileDialog.Title = "Save Firmware";
            // 
            // multiPanel
            // 
            this.multiPanel.Controls.Add(this.WaitPage);
            this.multiPanel.Controls.Add(this.DataPage);
            this.multiPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiPanel.Location = new System.Drawing.Point(0, 0);
            this.multiPanel.Name = "multiPanel";
            this.multiPanel.SelectedPage = this.DataPage;
            this.multiPanel.Size = new System.Drawing.Size(607, 607);
            this.multiPanel.TabIndex = 0;
            // 
            // WaitPage
            // 
            this.WaitPage.BackColor = System.Drawing.Color.White;
            this.WaitPage.Controls.Add(this.Wait_pictureBox);
            this.WaitPage.Controls.Add(this.WaitStatus_label);
            this.WaitPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WaitPage.Location = new System.Drawing.Point(0, 0);
            this.WaitPage.Name = "WaitPage";
            this.WaitPage.Size = new System.Drawing.Size(607, 526);
            this.WaitPage.TabIndex = 0;
            this.WaitPage.Text = "Wait page";
            // 
            // Wait_pictureBox
            // 
            this.Wait_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wait_pictureBox.Image = global::cs2000.Properties.Resources.drone_flying;
            this.Wait_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.Wait_pictureBox.Name = "Wait_pictureBox";
            this.Wait_pictureBox.Size = new System.Drawing.Size(607, 503);
            this.Wait_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Wait_pictureBox.TabIndex = 0;
            this.Wait_pictureBox.TabStop = false;
            // 
            // WaitStatus_label
            // 
            this.WaitStatus_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WaitStatus_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WaitStatus_label.Location = new System.Drawing.Point(0, 503);
            this.WaitStatus_label.Name = "WaitStatus_label";
            this.WaitStatus_label.Size = new System.Drawing.Size(607, 23);
            this.WaitStatus_label.TabIndex = 1;
            this.WaitStatus_label.Text = "Wait for data...";
            this.WaitStatus_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DataPage
            // 
            this.DataPage.Controls.Add(this.label6);
            this.DataPage.Controls.Add(this.label5);
            this.DataPage.Controls.Add(this.RCOnly_radioButton);
            this.DataPage.Controls.Add(this.ACOnly_radioButton);
            this.DataPage.Controls.Add(this.label4);
            this.DataPage.Controls.Add(this.ACandRC_radioButton);
            this.DataPage.Controls.Add(this.Download_progressBar);
            this.DataPage.Controls.Add(this.fileName_label);
            this.DataPage.Controls.Add(this.Download_button);
            this.DataPage.Controls.Add(this.Versions_listView);
            this.DataPage.Controls.Add(this.Notes_textBox);
            this.DataPage.Controls.Add(this.label3);
            this.DataPage.Controls.Add(this.label2);
            this.DataPage.Controls.Add(this.label1);
            this.DataPage.Controls.Add(this.Model_comboBox);
            this.DataPage.Controls.Add(this.Refresh_button);
            this.DataPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataPage.Location = new System.Drawing.Point(0, 0);
            this.DataPage.Name = "DataPage";
            this.DataPage.Size = new System.Drawing.Size(607, 607);
            this.DataPage.TabIndex = 1;
            this.DataPage.Text = "Data page";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(57, 555);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(532, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "https://github.com/cs2000/DankDroneDownloader";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.gitVisit);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(57, 502);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(532, 30);
            this.label5.TabIndex = 14;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RCOnly_radioButton
            // 
            this.RCOnly_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RCOnly_radioButton.AutoSize = true;
            this.RCOnly_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RCOnly_radioButton.Location = new System.Drawing.Point(200, 335);
            this.RCOnly_radioButton.Name = "RCOnly_radioButton";
            this.RCOnly_radioButton.Size = new System.Drawing.Size(61, 17);
            this.RCOnly_radioButton.TabIndex = 13;
            this.RCOnly_radioButton.Text = "RC only";
            this.RCOnly_radioButton.UseVisualStyleBackColor = true;
            this.RCOnly_radioButton.CheckedChanged += new System.EventHandler(this.Model_comboBox_SelectedIndexChanged);
            // 
            // ACOnly_radioButton
            // 
            this.ACOnly_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ACOnly_radioButton.AutoSize = true;
            this.ACOnly_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ACOnly_radioButton.Location = new System.Drawing.Point(134, 335);
            this.ACOnly_radioButton.Name = "ACOnly_radioButton";
            this.ACOnly_radioButton.Size = new System.Drawing.Size(60, 17);
            this.ACOnly_radioButton.TabIndex = 12;
            this.ACOnly_radioButton.Text = "AC only";
            this.ACOnly_radioButton.UseVisualStyleBackColor = true;
            this.ACOnly_radioButton.CheckedChanged += new System.EventHandler(this.Model_comboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Show:";
            // 
            // ACandRC_radioButton
            // 
            this.ACandRC_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ACandRC_radioButton.AutoSize = true;
            this.ACandRC_radioButton.Checked = true;
            this.ACandRC_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ACandRC_radioButton.Location = new System.Drawing.Point(63, 335);
            this.ACandRC_radioButton.Name = "ACandRC_radioButton";
            this.ACandRC_radioButton.Size = new System.Drawing.Size(65, 17);
            this.ACandRC_radioButton.TabIndex = 10;
            this.ACandRC_radioButton.TabStop = true;
            this.ACandRC_radioButton.Text = "AC && RC";
            this.ACandRC_radioButton.UseVisualStyleBackColor = true;
            this.ACandRC_radioButton.CheckedChanged += new System.EventHandler(this.Model_comboBox_SelectedIndexChanged);
            // 
            // Download_progressBar
            // 
            this.Download_progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Download_progressBar.Location = new System.Drawing.Point(220, 574);
            this.Download_progressBar.Name = "Download_progressBar";
            this.Download_progressBar.Size = new System.Drawing.Size(288, 12);
            this.Download_progressBar.TabIndex = 9;
            this.Download_progressBar.Visible = false;
            // 
            // fileName_label
            // 
            this.fileName_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileName_label.AutoEllipsis = true;
            this.fileName_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fileName_label.Location = new System.Drawing.Point(266, 335);
            this.fileName_label.Name = "fileName_label";
            this.fileName_label.Size = new System.Drawing.Size(323, 15);
            this.fileName_label.TabIndex = 8;
            this.fileName_label.Text = "File name:";
            this.fileName_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Download_button
            // 
            this.Download_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Download_button.Enabled = false;
            this.Download_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Download_button.Location = new System.Drawing.Point(63, 574);
            this.Download_button.Name = "Download_button";
            this.Download_button.Size = new System.Drawing.Size(151, 23);
            this.Download_button.TabIndex = 7;
            this.Download_button.Text = "Download Firmware";
            this.Download_button.UseVisualStyleBackColor = true;
            this.Download_button.Click += new System.EventHandler(this.Download_button_Click);
            // 
            // Versions_listView
            // 
            this.Versions_listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Versions_listView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Versions_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.Versions_listView.FullRowSelect = true;
            this.Versions_listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Versions_listView.HideSelection = false;
            this.Versions_listView.Location = new System.Drawing.Point(63, 42);
            this.Versions_listView.MultiSelect = false;
            this.Versions_listView.Name = "Versions_listView";
            this.Versions_listView.Size = new System.Drawing.Size(526, 289);
            this.Versions_listView.TabIndex = 3;
            this.Versions_listView.UseCompatibleStateImageBehavior = false;
            this.Versions_listView.View = System.Windows.Forms.View.Details;
            this.Versions_listView.SelectedIndexChanged += new System.EventHandler(this.Versions_listView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Version";
            this.columnHeader1.Width = 290;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 54;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Release Notes";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 82;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Size";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Notes_textBox
            // 
            this.Notes_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Notes_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.Notes_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Notes_textBox.Location = new System.Drawing.Point(63, 356);
            this.Notes_textBox.Multiline = true;
            this.Notes_textBox.Name = "Notes_textBox";
            this.Notes_textBox.ReadOnly = true;
            this.Notes_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Notes_textBox.Size = new System.Drawing.Size(526, 143);
            this.Notes_textBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Notes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Version:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Model:";
            // 
            // Model_comboBox
            // 
            this.Model_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Model_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Model_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Model_comboBox.FormattingEnabled = true;
            this.Model_comboBox.Location = new System.Drawing.Point(63, 13);
            this.Model_comboBox.Name = "Model_comboBox";
            this.Model_comboBox.Size = new System.Drawing.Size(526, 21);
            this.Model_comboBox.TabIndex = 1;
            this.Model_comboBox.SelectedIndexChanged += new System.EventHandler(this.Model_comboBox_SelectedIndexChanged);
            // 
            // Refresh_button
            // 
            this.Refresh_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Refresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_button.Location = new System.Drawing.Point(514, 574);
            this.Refresh_button.Name = "Refresh_button";
            this.Refresh_button.Size = new System.Drawing.Size(75, 23);
            this.Refresh_button.TabIndex = 0;
            this.Refresh_button.Text = "Refresh";
            this.Refresh_button.UseVisualStyleBackColor = true;
            this.Refresh_button.Click += new System.EventHandler(this.Refresh_button_ClickAsync);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(607, 607);
            this.Controls.Add(this.multiPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DankDroneDownloader v1.0 - cs2000";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.multiPanel.ResumeLayout(false);
            this.WaitPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Wait_pictureBox)).EndInit();
            this.DataPage.ResumeLayout(false);
            this.DataPage.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private MultiPanel multiPanel;
		private MultiPanelPage WaitPage;
		private System.Windows.Forms.PictureBox Wait_pictureBox;
		private MultiPanelPage DataPage;
		private System.Windows.Forms.Label WaitStatus_label;
		private System.Windows.Forms.Button Refresh_button;
		private System.Windows.Forms.Button Download_button;
		private System.Windows.Forms.TextBox Notes_textBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListView Versions_listView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox Model_comboBox;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Label fileName_label;
		private System.Windows.Forms.ProgressBar Download_progressBar;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.RadioButton RCOnly_radioButton;
		private System.Windows.Forms.RadioButton ACOnly_radioButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton ACandRC_radioButton;
		private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

