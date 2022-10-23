namespace BULocalization.TranslationEditor
{
	partial class EmailForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailForm));
			this.Fromlabel = new System.Windows.Forms.Label();
			this.Tolabel = new System.Windows.Forms.Label();
			this.Subjectlabel = new System.Windows.Forms.Label();
			this.Textlabel = new System.Windows.Forms.Label();
			this.Attachmentlabel = new System.Windows.Forms.Label();
			this.FromtextBox = new System.Windows.Forms.TextBox();
			this.TotextBox = new System.Windows.Forms.TextBox();
			this.SubjecttextBox = new System.Windows.Forms.TextBox();
			this.TexttextBox = new System.Windows.Forms.TextBox();
			this.AttachmenttextBox = new System.Windows.Forms.TextBox();
			this.Sendbutton = new System.Windows.Forms.Button();
			this.Closebutton = new System.Windows.Forms.Button();
			this.e_mailgroupBox = new System.Windows.Forms.GroupBox();
			this.e_mailgroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// Fromlabel
			// 
			this.Fromlabel.Location = new System.Drawing.Point(6, 16);
			this.Fromlabel.Name = "Fromlabel";
			this.Fromlabel.Size = new System.Drawing.Size(37, 17);
			this.Fromlabel.TabIndex = 0;
			this.Fromlabel.Text = "From:";
			// 
			// Tolabel
			// 
			this.Tolabel.Location = new System.Drawing.Point(6, 42);
			this.Tolabel.Name = "Tolabel";
			this.Tolabel.Size = new System.Drawing.Size(37, 17);
			this.Tolabel.TabIndex = 1;
			this.Tolabel.Text = "To:";
			// 
			// Subjectlabel
			// 
			this.Subjectlabel.Location = new System.Drawing.Point(6, 66);
			this.Subjectlabel.Name = "Subjectlabel";
			this.Subjectlabel.Size = new System.Drawing.Size(49, 17);
			this.Subjectlabel.TabIndex = 2;
			this.Subjectlabel.Text = "Subject:";
			// 
			// Textlabel
			// 
			this.Textlabel.Location = new System.Drawing.Point(6, 88);
			this.Textlabel.Name = "Textlabel";
			this.Textlabel.Size = new System.Drawing.Size(49, 19);
			this.Textlabel.TabIndex = 3;
			this.Textlabel.Text = "Body:";
			// 
			// Attachmentlabel
			// 
			this.Attachmentlabel.Location = new System.Drawing.Point(6, 168);
			this.Attachmentlabel.Name = "Attachmentlabel";
			this.Attachmentlabel.Size = new System.Drawing.Size(100, 15);
			this.Attachmentlabel.TabIndex = 4;
			this.Attachmentlabel.Text = "Attachment file:";
			// 
			// FromtextBox
			// 
			this.FromtextBox.Location = new System.Drawing.Point(49, 13);
			this.FromtextBox.Name = "FromtextBox";
			this.FromtextBox.ReadOnly = true;
			this.FromtextBox.Size = new System.Drawing.Size(232, 20);
			this.FromtextBox.TabIndex = 6;
			// 
			// TotextBox
			// 
			this.TotextBox.Location = new System.Drawing.Point(49, 39);
			this.TotextBox.Name = "TotextBox";
			this.TotextBox.ReadOnly = true;
			this.TotextBox.Size = new System.Drawing.Size(232, 20);
			this.TotextBox.TabIndex = 7;
			// 
			// SubjecttextBox
			// 
			this.SubjecttextBox.Location = new System.Drawing.Point(61, 63);
			this.SubjecttextBox.Name = "SubjecttextBox";
			this.SubjecttextBox.Size = new System.Drawing.Size(388, 20);
			this.SubjecttextBox.TabIndex = 8;
			this.SubjecttextBox.Text = "Translation into <> language";
			// 
			// TexttextBox
			// 
			this.TexttextBox.Location = new System.Drawing.Point(6, 108);
			this.TexttextBox.Multiline = true;
			this.TexttextBox.Name = "TexttextBox";
			this.TexttextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TexttextBox.Size = new System.Drawing.Size(443, 57);
			this.TexttextBox.TabIndex = 9;
			// 
			// AttachmenttextBox
			// 
			this.AttachmenttextBox.Location = new System.Drawing.Point(6, 186);
			this.AttachmenttextBox.Name = "AttachmenttextBox";
			this.AttachmenttextBox.ReadOnly = true;
			this.AttachmenttextBox.Size = new System.Drawing.Size(443, 20);
			this.AttachmenttextBox.TabIndex = 10;
			// 
			// Sendbutton
			// 
			this.Sendbutton.Location = new System.Drawing.Point(316, 234);
			this.Sendbutton.Name = "Sendbutton";
			this.Sendbutton.Size = new System.Drawing.Size(74, 23);
			this.Sendbutton.TabIndex = 11;
			this.Sendbutton.Text = "Send";
			this.Sendbutton.UseVisualStyleBackColor = true;
			this.Sendbutton.Click += new System.EventHandler(this.SendbuttonClick);
			// 
			// Closebutton
			// 
			this.Closebutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Closebutton.Location = new System.Drawing.Point(396, 234);
			this.Closebutton.Name = "Closebutton";
			this.Closebutton.Size = new System.Drawing.Size(75, 23);
			this.Closebutton.TabIndex = 12;
			this.Closebutton.Text = "Close";
			this.Closebutton.UseVisualStyleBackColor = true;
			// 
			// e_mailgroupBox
			// 
			this.e_mailgroupBox.Controls.Add(this.Fromlabel);
			this.e_mailgroupBox.Controls.Add(this.Tolabel);
			this.e_mailgroupBox.Controls.Add(this.Subjectlabel);
			this.e_mailgroupBox.Controls.Add(this.FromtextBox);
			this.e_mailgroupBox.Controls.Add(this.AttachmenttextBox);
			this.e_mailgroupBox.Controls.Add(this.TotextBox);
			this.e_mailgroupBox.Controls.Add(this.TexttextBox);
			this.e_mailgroupBox.Controls.Add(this.Attachmentlabel);
			this.e_mailgroupBox.Controls.Add(this.SubjecttextBox);
			this.e_mailgroupBox.Controls.Add(this.Textlabel);
			this.e_mailgroupBox.Location = new System.Drawing.Point(12, 12);
			this.e_mailgroupBox.Name = "e_mailgroupBox";
			this.e_mailgroupBox.Size = new System.Drawing.Size(455, 216);
			this.e_mailgroupBox.TabIndex = 14;
			this.e_mailgroupBox.TabStop = false;
			this.e_mailgroupBox.Text = "E-mail";
			// 
			// EmailForm
			// 
			this.AcceptButton = this.Sendbutton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Closebutton;
			this.ClientSize = new System.Drawing.Size(483, 266);
			this.Controls.Add(this.e_mailgroupBox);
			this.Controls.Add(this.Closebutton);
			this.Controls.Add(this.Sendbutton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EmailForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Send E-mail - BULocalization";
			this.e_mailgroupBox.ResumeLayout(false);
			this.e_mailgroupBox.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.GroupBox e_mailgroupBox;
		private System.Windows.Forms.Button Closebutton;
		private System.Windows.Forms.Button Sendbutton;
		private System.Windows.Forms.TextBox AttachmenttextBox;
		private System.Windows.Forms.TextBox TexttextBox;
		private System.Windows.Forms.TextBox SubjecttextBox;
		private System.Windows.Forms.TextBox TotextBox;
		private System.Windows.Forms.TextBox FromtextBox;
		private System.Windows.Forms.Label Attachmentlabel;
		private System.Windows.Forms.Label Textlabel;
		private System.Windows.Forms.Label Subjectlabel;
		private System.Windows.Forms.Label Tolabel;
		private System.Windows.Forms.Label Fromlabel;
	}
}
