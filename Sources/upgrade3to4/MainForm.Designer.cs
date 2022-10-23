/*
 * (c)Cuchuk Sergey Alexandrovich, 2007
 * Cuchuk.Sergey@gmail.com
 * toCuchukSergey@yandex.ru
 * 
 * Developed in #Develop IDE
 */
namespace upgrade3to4
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.Helplabel = new System.Windows.Forms.Label();
			this.HelpStepslabel = new System.Windows.Forms.Label();
			this.DidBackupcheckBox = new System.Windows.Forms.CheckBox();
			this.HelpStep2label = new System.Windows.Forms.Label();
			this.LocalProjectLocationtextBox = new System.Windows.Forms.TextBox();
			this.Selectbutton = new System.Windows.Forms.Button();
			this.helpstep3label = new System.Windows.Forms.Label();
			this.Upgradebutton = new System.Windows.Forms.Button();
			this.helpstep4label = new System.Windows.Forms.Label();
			this.codetextBox = new System.Windows.Forms.TextBox();
			this.Closebutton = new System.Windows.Forms.Button();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(12, 210);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(579, 28);
			this.progressBar.TabIndex = 0;
			// 
			// Helplabel
			// 
			this.Helplabel.BackColor = System.Drawing.Color.White;
			this.Helplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Helplabel.Location = new System.Drawing.Point(-1, -1);
			this.Helplabel.Name = "Helplabel";
			this.Helplabel.Size = new System.Drawing.Size(606, 41);
			this.Helplabel.TabIndex = 1;
			this.Helplabel.Text = "This Wizard will help you to upgrade from 3-rd format version(1.5-1.6) to 4-th(1." +
			"7)!!!";
			this.Helplabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// HelpStepslabel
			// 
			this.HelpStepslabel.Location = new System.Drawing.Point(12, 54);
			this.HelpStepslabel.Name = "HelpStepslabel";
			this.HelpStepslabel.Size = new System.Drawing.Size(579, 32);
			this.HelpStepslabel.TabIndex = 2;
			this.HelpStepslabel.Text = "Please follow next steps:\r\n1) backup your previous format language data(required)" +
			"";
			// 
			// DidBackupcheckBox
			// 
			this.DidBackupcheckBox.Location = new System.Drawing.Point(12, 89);
			this.DidBackupcheckBox.Name = "DidBackupcheckBox";
			this.DidBackupcheckBox.Size = new System.Drawing.Size(579, 24);
			this.DidBackupcheckBox.TabIndex = 3;
			this.DidBackupcheckBox.Text = "Yes, i did such a backup";
			this.DidBackupcheckBox.UseVisualStyleBackColor = true;
			// 
			// HelpStep2label
			// 
			this.HelpStep2label.Location = new System.Drawing.Point(12, 116);
			this.HelpStep2label.Name = "HelpStep2label";
			this.HelpStep2label.Size = new System.Drawing.Size(579, 33);
			this.HelpStep2label.TabIndex = 4;
			this.HelpStep2label.Text = "2) Please choose folder with your localization project(note: in this folder confi" +
			"guration file LanguageOptions.xml (if you use it) will be deleted)";
			// 
			// LocalProjectLocationtextBox
			// 
			this.LocalProjectLocationtextBox.Location = new System.Drawing.Point(35, 151);
			this.LocalProjectLocationtextBox.Name = "LocalProjectLocationtextBox";
			this.LocalProjectLocationtextBox.ReadOnly = true;
			this.LocalProjectLocationtextBox.Size = new System.Drawing.Size(440, 20);
			this.LocalProjectLocationtextBox.TabIndex = 5;
			// 
			// Selectbutton
			// 
			this.Selectbutton.Location = new System.Drawing.Point(481, 151);
			this.Selectbutton.Name = "Selectbutton";
			this.Selectbutton.Size = new System.Drawing.Size(110, 20);
			this.Selectbutton.TabIndex = 6;
			this.Selectbutton.Text = "Select...";
			this.Selectbutton.UseVisualStyleBackColor = true;
			this.Selectbutton.Click += new System.EventHandler(this.SelectbuttonClick);
			// 
			// helpstep3label
			// 
			this.helpstep3label.Location = new System.Drawing.Point(12, 184);
			this.helpstep3label.Name = "helpstep3label";
			this.helpstep3label.Size = new System.Drawing.Size(579, 23);
			this.helpstep3label.TabIndex = 7;
			this.helpstep3label.Text = "3) Press button Upgrade";
			// 
			// Upgradebutton
			// 
			this.Upgradebutton.Location = new System.Drawing.Point(481, 244);
			this.Upgradebutton.Name = "Upgradebutton";
			this.Upgradebutton.Size = new System.Drawing.Size(110, 23);
			this.Upgradebutton.TabIndex = 8;
			this.Upgradebutton.Text = "Upgrade!!!";
			this.Upgradebutton.UseVisualStyleBackColor = true;
			this.Upgradebutton.Click += new System.EventHandler(this.UpgradebuttonClick);
			// 
			// helpstep4label
			// 
			this.helpstep4label.Location = new System.Drawing.Point(12, 272);
			this.helpstep4label.Name = "helpstep4label";
			this.helpstep4label.Size = new System.Drawing.Size(579, 23);
			this.helpstep4label.TabIndex = 9;
			this.helpstep4label.Text = "4) changes in code";
			// 
			// codetextBox
			// 
			this.codetextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.codetextBox.Location = new System.Drawing.Point(35, 298);
			this.codetextBox.Multiline = true;
			this.codetextBox.Name = "codetextBox";
			this.codetextBox.ReadOnly = true;
			this.codetextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.codetextBox.Size = new System.Drawing.Size(556, 73);
			this.codetextBox.TabIndex = 10;
			this.codetextBox.Text = resources.GetString("codetextBox.Text");
			// 
			// Closebutton
			// 
			this.Closebutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Closebutton.Location = new System.Drawing.Point(481, 377);
			this.Closebutton.Name = "Closebutton";
			this.Closebutton.Size = new System.Drawing.Size(110, 26);
			this.Closebutton.TabIndex = 11;
			this.Closebutton.Text = "Close";
			this.Closebutton.UseVisualStyleBackColor = true;
			this.Closebutton.Click += new System.EventHandler(this.ClosebuttonClick);
			// 
			// folderBrowserDialog
			// 
			this.folderBrowserDialog.Description = "Localization project location";
			this.folderBrowserDialog.ShowNewFolderButton = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Closebutton;
			this.ClientSize = new System.Drawing.Size(603, 415);
			this.ControlBox = false;
			this.Controls.Add(this.Closebutton);
			this.Controls.Add(this.codetextBox);
			this.Controls.Add(this.helpstep4label);
			this.Controls.Add(this.Upgradebutton);
			this.Controls.Add(this.helpstep3label);
			this.Controls.Add(this.Selectbutton);
			this.Controls.Add(this.LocalProjectLocationtextBox);
			this.Controls.Add(this.HelpStep2label);
			this.Controls.Add(this.DidBackupcheckBox);
			this.Controls.Add(this.HelpStepslabel);
			this.Controls.Add(this.Helplabel);
			this.Controls.Add(this.progressBar);
			this.MaximumSize = new System.Drawing.Size(611, 449);
			this.MinimumSize = new System.Drawing.Size(611, 449);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "Upgrading from 3 to 4 format version - supporting old versions Wizard";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.Button Closebutton;
		private System.Windows.Forms.TextBox codetextBox;
		private System.Windows.Forms.Label helpstep4label;
		private System.Windows.Forms.Button Upgradebutton;
		private System.Windows.Forms.Label helpstep3label;
		private System.Windows.Forms.Button Selectbutton;
		private System.Windows.Forms.TextBox LocalProjectLocationtextBox;
		private System.Windows.Forms.Label HelpStep2label;
		private System.Windows.Forms.CheckBox DidBackupcheckBox;
		private System.Windows.Forms.Label HelpStepslabel;
		private System.Windows.Forms.Label Helplabel;
	}
}
