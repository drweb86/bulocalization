namespace BULocalization
{
	partial class SettingsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.Okbutton = new System.Windows.Forms.Button();
			this.Cancelbutton = new System.Windows.Forms.Button();
			this.SMPTgroupBox = new System.Windows.Forms.GroupBox();
			this.portNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.HosttextBox = new System.Windows.Forms.TextBox();
			this.Portlabel = new System.Windows.Forms.Label();
			this.SMPTlabel = new System.Windows.Forms.Label();
			this.emailtemplategroupBox = new System.Windows.Forms.GroupBox();
			this.BodytextBox = new System.Windows.Forms.TextBox();
			this.bodylabel = new System.Windows.Forms.Label();
			this.SubjecttextBox = new System.Windows.Forms.TextBox();
			this.Subjectlabel = new System.Windows.Forms.Label();
			this.templateSignsgroupBox = new System.Windows.Forms.GroupBox();
			this.Infolabel = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.FullNamelabel = new System.Windows.Forms.Label();
			this.otherContactInformationTextBox = new System.Windows.Forms.TextBox();
			this.emailLabel = new System.Windows.Forms.Label();
			this.OtherInfolabel = new System.Windows.Forms.Label();
			this.translatorNameTextBox = new System.Windows.Forms.TextBox();
			this.SMPTgroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).BeginInit();
			this.emailtemplategroupBox.SuspendLayout();
			this.templateSignsgroupBox.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Okbutton
			// 
			this.Okbutton.Location = new System.Drawing.Point(479, 449);
			this.Okbutton.Name = "Okbutton";
			this.Okbutton.Size = new System.Drawing.Size(75, 23);
			this.Okbutton.TabIndex = 10;
			this.Okbutton.Text = "Ok";
			this.Okbutton.UseVisualStyleBackColor = true;
			this.Okbutton.Click += new System.EventHandler(this.OkbuttonClick);
			// 
			// Cancelbutton
			// 
			this.Cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancelbutton.Location = new System.Drawing.Point(560, 449);
			this.Cancelbutton.Name = "Cancelbutton";
			this.Cancelbutton.Size = new System.Drawing.Size(73, 23);
			this.Cancelbutton.TabIndex = 11;
			this.Cancelbutton.Text = "Cancel";
			this.Cancelbutton.UseVisualStyleBackColor = true;
			// 
			// SMPTgroupBox
			// 
			this.SMPTgroupBox.Controls.Add(this.portNumericUpDown);
			this.SMPTgroupBox.Controls.Add(this.HosttextBox);
			this.SMPTgroupBox.Controls.Add(this.Portlabel);
			this.SMPTgroupBox.Controls.Add(this.SMPTlabel);
			this.SMPTgroupBox.Location = new System.Drawing.Point(421, 100);
			this.SMPTgroupBox.Name = "SMPTgroupBox";
			this.SMPTgroupBox.Size = new System.Drawing.Size(212, 71);
			this.SMPTgroupBox.TabIndex = 3;
			this.SMPTgroupBox.TabStop = false;
			this.SMPTgroupBox.Text = "SMTP configuration for Email delivering";
			// 
			// portNumericUpDown
			// 
			this.portNumericUpDown.Location = new System.Drawing.Point(58, 39);
			this.portNumericUpDown.Maximum = new decimal(new int[] {
									10000,
									0,
									0,
									0});
			this.portNumericUpDown.Minimum = new decimal(new int[] {
									25,
									0,
									0,
									0});
			this.portNumericUpDown.Name = "portNumericUpDown";
			this.portNumericUpDown.Size = new System.Drawing.Size(117, 20);
			this.portNumericUpDown.TabIndex = 5;
			this.portNumericUpDown.Value = new decimal(new int[] {
									25,
									0,
									0,
									0});
			// 
			// HosttextBox
			// 
			this.HosttextBox.Location = new System.Drawing.Point(58, 13);
			this.HosttextBox.Name = "HosttextBox";
			this.HosttextBox.Size = new System.Drawing.Size(117, 20);
			this.HosttextBox.TabIndex = 4;
			this.HosttextBox.Text = "127.0.0.1";
			// 
			// Portlabel
			// 
			this.Portlabel.Location = new System.Drawing.Point(6, 41);
			this.Portlabel.Name = "Portlabel";
			this.Portlabel.Size = new System.Drawing.Size(46, 16);
			this.Portlabel.TabIndex = 1;
			this.Portlabel.Text = "Port:";
			// 
			// SMPTlabel
			// 
			this.SMPTlabel.Location = new System.Drawing.Point(6, 16);
			this.SMPTlabel.Name = "SMPTlabel";
			this.SMPTlabel.Size = new System.Drawing.Size(51, 18);
			this.SMPTlabel.TabIndex = 0;
			this.SMPTlabel.Text = "Host:";
			// 
			// emailtemplategroupBox
			// 
			this.emailtemplategroupBox.Controls.Add(this.BodytextBox);
			this.emailtemplategroupBox.Controls.Add(this.bodylabel);
			this.emailtemplategroupBox.Controls.Add(this.SubjecttextBox);
			this.emailtemplategroupBox.Controls.Add(this.Subjectlabel);
			this.emailtemplategroupBox.Location = new System.Drawing.Point(12, 12);
			this.emailtemplategroupBox.Name = "emailtemplategroupBox";
			this.emailtemplategroupBox.Size = new System.Drawing.Size(403, 230);
			this.emailtemplategroupBox.TabIndex = 0;
			this.emailtemplategroupBox.TabStop = false;
			this.emailtemplategroupBox.Text = "E-mail template";
			// 
			// BodytextBox
			// 
			this.BodytextBox.Location = new System.Drawing.Point(6, 81);
			this.BodytextBox.Multiline = true;
			this.BodytextBox.Name = "BodytextBox";
			this.BodytextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.BodytextBox.Size = new System.Drawing.Size(390, 138);
			this.BodytextBox.TabIndex = 2;
			this.BodytextBox.Text = resources.GetString("BodytextBox.Text");
			// 
			// bodylabel
			// 
			this.bodylabel.Location = new System.Drawing.Point(6, 64);
			this.bodylabel.Name = "bodylabel";
			this.bodylabel.Size = new System.Drawing.Size(100, 18);
			this.bodylabel.TabIndex = 2;
			this.bodylabel.Text = "Body:";
			// 
			// SubjecttextBox
			// 
			this.SubjecttextBox.Location = new System.Drawing.Point(6, 33);
			this.SubjecttextBox.Name = "SubjecttextBox";
			this.SubjecttextBox.Size = new System.Drawing.Size(390, 20);
			this.SubjecttextBox.TabIndex = 1;
			this.SubjecttextBox.Text = "Please update translation!!!";
			// 
			// Subjectlabel
			// 
			this.Subjectlabel.Location = new System.Drawing.Point(6, 16);
			this.Subjectlabel.Name = "Subjectlabel";
			this.Subjectlabel.Size = new System.Drawing.Size(51, 18);
			this.Subjectlabel.TabIndex = 0;
			this.Subjectlabel.Text = "Subject:";
			// 
			// templateSignsgroupBox
			// 
			this.templateSignsgroupBox.Controls.Add(this.Infolabel);
			this.templateSignsgroupBox.Location = new System.Drawing.Point(421, 12);
			this.templateSignsgroupBox.Name = "templateSignsgroupBox";
			this.templateSignsgroupBox.Size = new System.Drawing.Size(212, 82);
			this.templateSignsgroupBox.TabIndex = 4;
			this.templateSignsgroupBox.TabStop = false;
			this.templateSignsgroupBox.Text = "Exchange abbreviations";
			// 
			// Infolabel
			// 
			this.Infolabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.Infolabel.Location = new System.Drawing.Point(6, 16);
			this.Infolabel.Name = "Infolabel";
			this.Infolabel.Size = new System.Drawing.Size(200, 46);
			this.Infolabel.TabIndex = 0;
			this.Infolabel.Text = "$translator - full name of translator\r\n$translation_english_name - english name o" +
			"f the translation";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.emailTextBox);
			this.groupBox1.Controls.Add(this.FullNamelabel);
			this.groupBox1.Controls.Add(this.otherContactInformationTextBox);
			this.groupBox1.Controls.Add(this.emailLabel);
			this.groupBox1.Controls.Add(this.OtherInfolabel);
			this.groupBox1.Controls.Add(this.translatorNameTextBox);
			this.groupBox1.Location = new System.Drawing.Point(12, 248);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(400, 200);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Your contact information for translations you edit";
			// 
			// emailTextBox
			// 
			this.emailTextBox.Location = new System.Drawing.Point(83, 42);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(242, 20);
			this.emailTextBox.TabIndex = 8;
			// 
			// FullNamelabel
			// 
			this.FullNamelabel.Location = new System.Drawing.Point(15, 19);
			this.FullNamelabel.Name = "FullNamelabel";
			this.FullNamelabel.Size = new System.Drawing.Size(62, 17);
			this.FullNamelabel.TabIndex = 0;
			this.FullNamelabel.Text = "Full name:";
			// 
			// otherContactInformationTextBox
			// 
			this.otherContactInformationTextBox.Location = new System.Drawing.Point(15, 86);
			this.otherContactInformationTextBox.Multiline = true;
			this.otherContactInformationTextBox.Name = "otherContactInformationTextBox";
			this.otherContactInformationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.otherContactInformationTextBox.Size = new System.Drawing.Size(379, 108);
			this.otherContactInformationTextBox.TabIndex = 9;
			// 
			// emailLabel
			// 
			this.emailLabel.Location = new System.Drawing.Point(15, 45);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(62, 17);
			this.emailLabel.TabIndex = 1;
			this.emailLabel.Text = "e-Mail:";
			// 
			// OtherInfolabel
			// 
			this.OtherInfolabel.Location = new System.Drawing.Point(15, 65);
			this.OtherInfolabel.Name = "OtherInfolabel";
			this.OtherInfolabel.Size = new System.Drawing.Size(100, 18);
			this.OtherInfolabel.TabIndex = 3;
			this.OtherInfolabel.Text = "Other information:";
			// 
			// translatorNameTextBox
			// 
			this.translatorNameTextBox.Location = new System.Drawing.Point(83, 16);
			this.translatorNameTextBox.Name = "translatorNameTextBox";
			this.translatorNameTextBox.Size = new System.Drawing.Size(242, 20);
			this.translatorNameTextBox.TabIndex = 7;
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Cancelbutton;
			this.ClientSize = new System.Drawing.Size(645, 484);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.templateSignsgroupBox);
			this.Controls.Add(this.emailtemplategroupBox);
			this.Controls.Add(this.SMPTgroupBox);
			this.Controls.Add(this.Cancelbutton);
			this.Controls.Add(this.Okbutton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Settings - BULocalization";
			this.SMPTgroupBox.ResumeLayout(false);
			this.SMPTgroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).EndInit();
			this.emailtemplategroupBox.ResumeLayout(false);
			this.emailtemplategroupBox.PerformLayout();
			this.templateSignsgroupBox.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox translatorNameTextBox;
		private System.Windows.Forms.TextBox otherContactInformationTextBox;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.Label OtherInfolabel;
		private System.Windows.Forms.Label emailLabel;
		private System.Windows.Forms.Label FullNamelabel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown portNumericUpDown;
		private System.Windows.Forms.TextBox BodytextBox;
		private System.Windows.Forms.Label Infolabel;
		private System.Windows.Forms.GroupBox templateSignsgroupBox;
		private System.Windows.Forms.Label Subjectlabel;
		private System.Windows.Forms.TextBox SubjecttextBox;
		private System.Windows.Forms.Label bodylabel;
		private System.Windows.Forms.GroupBox emailtemplategroupBox;
		private System.Windows.Forms.Label SMPTlabel;
		private System.Windows.Forms.Label Portlabel;
		private System.Windows.Forms.TextBox HosttextBox;
		private System.Windows.Forms.GroupBox SMPTgroupBox;
		private System.Windows.Forms.Button Cancelbutton;
		private System.Windows.Forms.Button Okbutton;
	}
}
