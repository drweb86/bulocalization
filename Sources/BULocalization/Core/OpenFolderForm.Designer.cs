namespace BULocalization.Core
{
	partial class OpenFolderForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenFolderForm));
			this.infoLabel = new System.Windows.Forms.Label();
			this.projectFolderTextBox = new System.Windows.Forms.TextBox();
			this.browseButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.projectFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// infoLabel
			// 
			this.infoLabel.Location = new System.Drawing.Point(12, 13);
			this.infoLabel.Name = "infoLabel";
			this.infoLabel.Size = new System.Drawing.Size(208, 14);
			this.infoLabel.TabIndex = 0;
			this.infoLabel.Text = "Please, select project folder:";
			// 
			// projectFolderTextBox
			// 
			this.projectFolderTextBox.Location = new System.Drawing.Point(12, 30);
			this.projectFolderTextBox.Name = "projectFolderTextBox";
			this.projectFolderTextBox.Size = new System.Drawing.Size(418, 20);
			this.projectFolderTextBox.TabIndex = 1;
			this.projectFolderTextBox.TextChanged += new System.EventHandler(this.projectFolderTextBoxTextChanged);
			// 
			// browseButton
			// 
			this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.browseButton.Location = new System.Drawing.Point(436, 29);
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new System.Drawing.Size(34, 23);
			this.browseButton.TabIndex = 2;
			this.browseButton.Text = "...";
			this.browseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.browseButton.UseVisualStyleBackColor = true;
			this.browseButton.Click += new System.EventHandler(this.browseButtonClick);
			// 
			// okButton
			// 
			this.okButton.Enabled = false;
			this.okButton.Location = new System.Drawing.Point(313, 58);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 3;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.OkButtonClick);
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(394, 58);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 4;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// OpenFolderForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(481, 90);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.browseButton);
			this.Controls.Add(this.projectFolderTextBox);
			this.Controls.Add(this.infoLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OpenFolderForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Choose Project Folder";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.FolderBrowserDialog projectFolderBrowserDialog;
		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.TextBox projectFolderTextBox;
		private System.Windows.Forms.Label infoLabel;
	}
}
