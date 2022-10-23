namespace BULocalization.TranslationEditor
{
	partial class TranslationConfigurationForm
	{
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranslationConfigurationForm));
			this.OKbutton = new System.Windows.Forms.Button();
			this._isSupportcheckBox = new System.Windows.Forms.CheckBox();
			this.helplsnlabel = new System.Windows.Forms.Label();
			this._naturalNameTextBox = new System.Windows.Forms.TextBox();
			this.lsnlabel = new System.Windows.Forms.Label();
			this.settingsGroupBox = new System.Windows.Forms.GroupBox();
			this.cancelButton = new System.Windows.Forms.Button();
			this.settingsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// OKbutton
			// 
			this.OKbutton.Location = new System.Drawing.Point(190, 100);
			this.OKbutton.Name = "OKbutton";
			this.OKbutton.Size = new System.Drawing.Size(79, 23);
			this.OKbutton.TabIndex = 3;
			this.OKbutton.Text = "OK";
			this.OKbutton.UseVisualStyleBackColor = true;
			this.OKbutton.Click += new System.EventHandler(this.OKbuttonClick);
			// 
			// _isSupportcheckBox
			// 
			this._isSupportcheckBox.Checked = true;
			this._isSupportcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this._isSupportcheckBox.Location = new System.Drawing.Point(6, 51);
			this._isSupportcheckBox.Name = "_isSupportcheckBox";
			this._isSupportcheckBox.Size = new System.Drawing.Size(254, 24);
			this._isSupportcheckBox.TabIndex = 2;
			this._isSupportcheckBox.Text = "Yes, I would like to support my translation";
			this._isSupportcheckBox.UseVisualStyleBackColor = true;
			// 
			// helplsnlabel
			// 
			this.helplsnlabel.Location = new System.Drawing.Point(144, 36);
			this.helplsnlabel.Name = "helplsnlabel";
			this.helplsnlabel.Size = new System.Drawing.Size(139, 22);
			this.helplsnlabel.TabIndex = 2;
			this.helplsnlabel.Text = "For example: Русский";
			// 
			// _naturalNameTextBox
			// 
			this._naturalNameTextBox.Location = new System.Drawing.Point(144, 13);
			this._naturalNameTextBox.Name = "_naturalNameTextBox";
			this._naturalNameTextBox.Size = new System.Drawing.Size(182, 20);
			this._naturalNameTextBox.TabIndex = 1;
			// 
			// lsnlabel
			// 
			this.lsnlabel.Location = new System.Drawing.Point(6, 16);
			this.lsnlabel.Name = "lsnlabel";
			this.lsnlabel.Size = new System.Drawing.Size(130, 17);
			this.lsnlabel.TabIndex = 0;
			this.lsnlabel.Text = "Language specific name:";
			// 
			// settingsGroupBox
			// 
			this.settingsGroupBox.Controls.Add(this.lsnlabel);
			this.settingsGroupBox.Controls.Add(this._isSupportcheckBox);
			this.settingsGroupBox.Controls.Add(this.helplsnlabel);
			this.settingsGroupBox.Controls.Add(this._naturalNameTextBox);
			this.settingsGroupBox.Location = new System.Drawing.Point(12, 12);
			this.settingsGroupBox.Name = "settingsGroupBox";
			this.settingsGroupBox.Size = new System.Drawing.Size(338, 82);
			this.settingsGroupBox.TabIndex = 0;
			this.settingsGroupBox.TabStop = false;
			this.settingsGroupBox.Text = "Settings";
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(275, 100);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 4;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// TranslationConfigurationForm
			// 
			this.AcceptButton = this.OKbutton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(359, 134);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.settingsGroupBox);
			this.Controls.Add(this.OKbutton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TranslationConfigurationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Translation Settings - BULocalization";
			this.settingsGroupBox.ResumeLayout(false);
			this.settingsGroupBox.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.GroupBox settingsGroupBox;
		private System.Windows.Forms.CheckBox _isSupportcheckBox;
		private System.Windows.Forms.TextBox _naturalNameTextBox;
		private System.Windows.Forms.Label lsnlabel;
		private System.Windows.Forms.Label helplsnlabel;
		private System.Windows.Forms.Button OKbutton;
	}
}
