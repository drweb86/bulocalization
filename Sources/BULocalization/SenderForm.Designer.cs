/*
 * (c)Cuchuk Sergey Alexandrovich, 2007
 * Cuchuk.Sergey@gmail.com
 * toCuchukSergey@yandex.ru
 * 
 * Developed in #Develop IDE
 */
namespace BULocalization
{
	partial class SenderForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SenderForm));
			this.emailgroupBox = new System.Windows.Forms.GroupBox();
			this.emailpictureBox = new System.Windows.Forms.PictureBox();
			this.TotextBox = new System.Windows.Forms.TextBox();
			this.Tolabel = new System.Windows.Forms.Label();
			this.AttachtextBox = new System.Windows.Forms.TextBox();
			this.Attachlabel = new System.Windows.Forms.Label();
			this.fromTextBox = new System.Windows.Forms.TextBox();
			this.Fromlabel = new System.Windows.Forms.Label();
			this.BodytextBox = new System.Windows.Forms.TextBox();
			this.bodylabel = new System.Windows.Forms.Label();
			this.SubjecttextBox = new System.Windows.Forms.TextBox();
			this.Subjectlabel = new System.Windows.Forms.Label();
			this.Closebutton = new System.Windows.Forms.Button();
			this.emailgroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.emailpictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// emailgroupBox
			// 
			this.emailgroupBox.Controls.Add(this.emailpictureBox);
			this.emailgroupBox.Controls.Add(this.TotextBox);
			this.emailgroupBox.Controls.Add(this.Tolabel);
			this.emailgroupBox.Controls.Add(this.AttachtextBox);
			this.emailgroupBox.Controls.Add(this.Attachlabel);
			this.emailgroupBox.Controls.Add(this.fromTextBox);
			this.emailgroupBox.Controls.Add(this.Fromlabel);
			this.emailgroupBox.Controls.Add(this.BodytextBox);
			this.emailgroupBox.Controls.Add(this.bodylabel);
			this.emailgroupBox.Controls.Add(this.SubjecttextBox);
			this.emailgroupBox.Controls.Add(this.Subjectlabel);
			this.emailgroupBox.Location = new System.Drawing.Point(12, 12);
			this.emailgroupBox.Name = "emailgroupBox";
			this.emailgroupBox.Size = new System.Drawing.Size(336, 374);
			this.emailgroupBox.TabIndex = 0;
			this.emailgroupBox.TabStop = false;
			this.emailgroupBox.Text = "E-mail";
			// 
			// emailpictureBox
			// 
			this.emailpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("emailpictureBox.Image")));
			this.emailpictureBox.Location = new System.Drawing.Point(233, 15);
			this.emailpictureBox.Name = "emailpictureBox";
			this.emailpictureBox.Size = new System.Drawing.Size(91, 46);
			this.emailpictureBox.TabIndex = 10;
			this.emailpictureBox.TabStop = false;
			// 
			// TotextBox
			// 
			this.TotextBox.Location = new System.Drawing.Point(52, 41);
			this.TotextBox.Name = "TotextBox";
			this.TotextBox.ReadOnly = true;
			this.TotextBox.Size = new System.Drawing.Size(161, 20);
			this.TotextBox.TabIndex = 2;
			// 
			// Tolabel
			// 
			this.Tolabel.Location = new System.Drawing.Point(7, 44);
			this.Tolabel.Name = "Tolabel";
			this.Tolabel.Size = new System.Drawing.Size(39, 17);
			this.Tolabel.TabIndex = 8;
			this.Tolabel.Text = "To:";
			// 
			// AttachtextBox
			// 
			this.AttachtextBox.Location = new System.Drawing.Point(18, 332);
			this.AttachtextBox.Name = "AttachtextBox";
			this.AttachtextBox.ReadOnly = true;
			this.AttachtextBox.Size = new System.Drawing.Size(306, 20);
			this.AttachtextBox.TabIndex = 5;
			this.AttachtextBox.Text = "<language attachement>";
			// 
			// Attachlabel
			// 
			this.Attachlabel.Location = new System.Drawing.Point(7, 311);
			this.Attachlabel.Name = "Attachlabel";
			this.Attachlabel.Size = new System.Drawing.Size(100, 18);
			this.Attachlabel.TabIndex = 6;
			this.Attachlabel.Text = "Attachment:";
			// 
			// fromTextBox
			// 
			this.fromTextBox.Location = new System.Drawing.Point(52, 15);
			this.fromTextBox.Name = "fromTextBox";
			this.fromTextBox.ReadOnly = true;
			this.fromTextBox.Size = new System.Drawing.Size(161, 20);
			this.fromTextBox.TabIndex = 1;
			this.fromTextBox.Text = "someemail@somesite.com";
			// 
			// Fromlabel
			// 
			this.Fromlabel.Location = new System.Drawing.Point(7, 18);
			this.Fromlabel.Name = "Fromlabel";
			this.Fromlabel.Size = new System.Drawing.Size(39, 18);
			this.Fromlabel.TabIndex = 4;
			this.Fromlabel.Text = "From:";
			// 
			// BodytextBox
			// 
			this.BodytextBox.Location = new System.Drawing.Point(18, 146);
			this.BodytextBox.Multiline = true;
			this.BodytextBox.Name = "BodytextBox";
			this.BodytextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.BodytextBox.Size = new System.Drawing.Size(306, 162);
			this.BodytextBox.TabIndex = 4;
			this.BodytextBox.Text = resources.GetString("BodytextBox.Text");
			// 
			// bodylabel
			// 
			this.bodylabel.Location = new System.Drawing.Point(7, 125);
			this.bodylabel.Name = "bodylabel";
			this.bodylabel.Size = new System.Drawing.Size(100, 18);
			this.bodylabel.TabIndex = 2;
			this.bodylabel.Text = "Body:";
			// 
			// SubjecttextBox
			// 
			this.SubjecttextBox.Location = new System.Drawing.Point(18, 102);
			this.SubjecttextBox.Name = "SubjecttextBox";
			this.SubjecttextBox.Size = new System.Drawing.Size(306, 20);
			this.SubjecttextBox.TabIndex = 3;
			this.SubjecttextBox.Text = "Please update translation!!!";
			// 
			// Subjectlabel
			// 
			this.Subjectlabel.Location = new System.Drawing.Point(7, 81);
			this.Subjectlabel.Name = "Subjectlabel";
			this.Subjectlabel.Size = new System.Drawing.Size(100, 18);
			this.Subjectlabel.TabIndex = 0;
			this.Subjectlabel.Text = "Subject:";
			// 
			// Closebutton
			// 
			this.Closebutton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Closebutton.Location = new System.Drawing.Point(273, 392);
			this.Closebutton.Name = "Closebutton";
			this.Closebutton.Size = new System.Drawing.Size(75, 23);
			this.Closebutton.TabIndex = 6;
			this.Closebutton.Text = "Close";
			this.Closebutton.UseVisualStyleBackColor = true;
			this.Closebutton.Click += new System.EventHandler(this.ClosebuttonClick);
			// 
			// SenderForm
			// 
			this.AcceptButton = this.Closebutton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(356, 422);
			this.Controls.Add(this.Closebutton);
			this.Controls.Add(this.emailgroupBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SenderForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sender - BULocalization";
			this.emailgroupBox.ResumeLayout(false);
			this.emailgroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.emailpictureBox)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox fromTextBox;
		private System.Windows.Forms.PictureBox emailpictureBox;
		private System.Windows.Forms.Label Tolabel;
		private System.Windows.Forms.TextBox TotextBox;
		private System.Windows.Forms.Button Closebutton;
		private System.Windows.Forms.Label Subjectlabel;
		private System.Windows.Forms.TextBox SubjecttextBox;
		private System.Windows.Forms.Label bodylabel;
		private System.Windows.Forms.TextBox BodytextBox;
		private System.Windows.Forms.Label Fromlabel;
		private System.Windows.Forms.Label Attachlabel;
		private System.Windows.Forms.TextBox AttachtextBox;
		private System.Windows.Forms.GroupBox emailgroupBox;
	}
}
