namespace TestUi
{
	partial class MainForm
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
			this.chooseLanguageButton = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.languagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// chooseLanguageButton
			// 
			this.chooseLanguageButton.Location = new System.Drawing.Point(12, 27);
			this.chooseLanguageButton.Name = "chooseLanguageButton";
			this.chooseLanguageButton.Size = new System.Drawing.Size(138, 23);
			this.chooseLanguageButton.TabIndex = 0;
			this.chooseLanguageButton.Text = "Choose language";
			this.chooseLanguageButton.UseVisualStyleBackColor = true;
			this.chooseLanguageButton.Click += new System.EventHandler(this.ChooseLanguageButtonClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.languagesToolStripMenuItem,
									this.aboutProgramToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(292, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// languagesToolStripMenuItem
			// 
			this.languagesToolStripMenuItem.Name = "languagesToolStripMenuItem";
			this.languagesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.languagesToolStripMenuItem.Text = "Languages";
			// 
			// aboutProgramToolStripMenuItem
			// 
			this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
			this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
			this.aboutProgramToolStripMenuItem.Text = "About program";
			this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.AboutProgramToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 59);
			this.Controls.Add(this.chooseLanguageButton);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Sample";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button chooseLanguageButton;
		private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem languagesToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
