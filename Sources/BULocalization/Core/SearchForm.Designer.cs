namespace BULocalization.Core
{
	partial class SearchForm
	{
		private System.ComponentModel.IContainer components = null;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
			this.searchButton = new System.Windows.Forms.Button();
			this.enterLabel = new System.Windows.Forms.Label();
			this.textToSearchTextBox = new System.Windows.Forms.TextBox();
			this.closeButton = new System.Windows.Forms.Button();
			this.resultsLabel = new System.Windows.Forms.Label();
			this.resultsTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(304, 22);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 23);
			this.searchButton.TabIndex = 1;
			this.searchButton.Text = "Search...";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.SearchbuttonClick);
			// 
			// enterLabel
			// 
			this.enterLabel.Location = new System.Drawing.Point(10, 9);
			this.enterLabel.Name = "enterLabel";
			this.enterLabel.Size = new System.Drawing.Size(209, 23);
			this.enterLabel.TabIndex = 1;
			this.enterLabel.Text = "Enter text fragment you want to search:";
			// 
			// textToSearchTextBox
			// 
			this.textToSearchTextBox.Location = new System.Drawing.Point(12, 24);
			this.textToSearchTextBox.Name = "textToSearchTextBox";
			this.textToSearchTextBox.Size = new System.Drawing.Size(282, 20);
			this.textToSearchTextBox.TabIndex = 0;
			// 
			// closeButton
			// 
			this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.closeButton.Location = new System.Drawing.Point(304, 192);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 3;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.ClosebuttonClick);
			// 
			// resultsLabel
			// 
			this.resultsLabel.Location = new System.Drawing.Point(10, 47);
			this.resultsLabel.Name = "resultsLabel";
			this.resultsLabel.Size = new System.Drawing.Size(135, 23);
			this.resultsLabel.TabIndex = 4;
			this.resultsLabel.Text = "Results:";
			// 
			// resultsTextBox
			// 
			this.resultsTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.resultsTextBox.Location = new System.Drawing.Point(12, 68);
			this.resultsTextBox.Multiline = true;
			this.resultsTextBox.Name = "resultsTextBox";
			this.resultsTextBox.ReadOnly = true;
			this.resultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.resultsTextBox.Size = new System.Drawing.Size(367, 118);
			this.resultsTextBox.TabIndex = 2;
			// 
			// SearchForm
			// 
			this.AcceptButton = this.searchButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.closeButton;
			this.ClientSize = new System.Drawing.Size(391, 225);
			this.Controls.Add(this.resultsTextBox);
			this.Controls.Add(this.resultsLabel);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.textToSearchTextBox);
			this.Controls.Add(this.enterLabel);
			this.Controls.Add(this.searchButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SearchForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Search - BULocalization";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchFormFormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textToSearchTextBox;
		private System.Windows.Forms.TextBox resultsTextBox;
		private System.Windows.Forms.Label resultsLabel;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Label enterLabel;
		private System.Windows.Forms.Button searchButton;
	}
}
