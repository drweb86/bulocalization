namespace BULocalization
{
	partial class AddModifyLanguageForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddModifyLanguageForm));
			this.nameComboBox = new System.Windows.Forms.ComboBox();
			this.Closebutton = new System.Windows.Forms.Button();
			this.AddModifybutton = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// nameComboBox
			// 
			this.nameComboBox.AllowDrop = true;
			this.nameComboBox.AutoCompleteCustomSource.AddRange(new string[] {
									"default",
									"Afrikaans",
									"Albanian",
									"Arabic",
									"Belarusian",
									"Bengali",
									"Bosnian",
									"Brazilian Portuguese",
									"Bulgarian",
									"Catalan",
									"Chinese Simplified",
									"Chinese Traditional",
									"Croatian",
									"Czech",
									"Danish",
									"Dutch",
									"English",
									"Esperanto",
									"Estonian",
									"Finnish",
									"French",
									"Galician",
									"German",
									"Greek",
									"Hebrew",
									"Hindi",
									"Hungarian",
									"Icelandic",
									"Indonesian",
									"Irish Gaelic",
									"Italian",
									"Japanese",
									"Javanese",
									"Kirghiz",
									"Korean",
									"Latin",
									"Latvian",
									"Lithuanian",
									"Macedonian",
									"Malagasy",
									"Malay",
									"Maltese",
									"Marathi",
									"Mongolian",
									"Norwegian",
									"Panjabi",
									"Persian",
									"Polish",
									"Portuguese",
									"Romanian",
									"Russian",
									"Serbian",
									"Slovak",
									"Slovene",
									"Spanish",
									"Swahili",
									"Swedish",
									"Tamil",
									"Telugu",
									"Thai",
									"Turkish",
									"Ukrainian",
									"Urdu",
									"Vietnamese"});
			this.nameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.nameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.nameComboBox.FormattingEnabled = true;
			this.nameComboBox.Items.AddRange(new object[] {
									"Afrikaans",
									"Albanian",
									"Arabic",
									"Belarusian",
									"Bengali",
									"Bosnian",
									"Brazilian Portuguese",
									"Bulgarian",
									"Catalan",
									"Chinese Simplified",
									"Chinese Traditional",
									"Croatian",
									"Czech",
									"Danish",
									"Dutch",
									"English",
									"Esperanto",
									"Estonian",
									"Finnish",
									"French",
									"Galician",
									"German",
									"Greek",
									"Hebrew",
									"Hindi",
									"Hungarian",
									"Icelandic",
									"Indonesian",
									"Irish Gaelic",
									"Italian",
									"Japanese",
									"Javanese",
									"Kirghiz",
									"Korean",
									"Latin",
									"Latvian",
									"Lithuanian",
									"Macedonian",
									"Malagasy",
									"Malay",
									"Maltese",
									"Marathi",
									"Mongolian",
									"Norwegian",
									"Panjabi",
									"Persian",
									"Polish",
									"Portuguese",
									"Romanian",
									"Russian",
									"Serbian",
									"Slovak",
									"Slovene",
									"Spanish",
									"Swahili",
									"Swedish",
									"Tamil",
									"Telugu",
									"Thai",
									"Turkish",
									"Ukrainian",
									"Urdu",
									"Vietnamese"});
			this.nameComboBox.Location = new System.Drawing.Point(12, 26);
			this.nameComboBox.Name = "nameComboBox";
			this.nameComboBox.Size = new System.Drawing.Size(220, 21);
			this.nameComboBox.TabIndex = 0;
			this.nameComboBox.TextChanged += new System.EventHandler(this.NameComboBoxTextChanged);
			// 
			// Closebutton
			// 
			this.Closebutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Closebutton.Location = new System.Drawing.Point(157, 53);
			this.Closebutton.Name = "Closebutton";
			this.Closebutton.Size = new System.Drawing.Size(75, 23);
			this.Closebutton.TabIndex = 2;
			this.Closebutton.Text = "Cancel";
			this.Closebutton.UseVisualStyleBackColor = true;
			// 
			// AddModifybutton
			// 
			this.AddModifybutton.Location = new System.Drawing.Point(76, 53);
			this.AddModifybutton.Name = "AddModifybutton";
			this.AddModifybutton.Size = new System.Drawing.Size(75, 23);
			this.AddModifybutton.TabIndex = 1;
			this.AddModifybutton.Text = "OK";
			this.AddModifybutton.UseVisualStyleBackColor = true;
			this.AddModifybutton.Click += new System.EventHandler(this.AddModifybuttonClick);
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = "Language file|*.Language";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(220, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Please, specify name of language in English:";
			// 
			// AddModifyLanguageForm
			// 
			this.AcceptButton = this.AddModifybutton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Closebutton;
			this.ClientSize = new System.Drawing.Size(240, 84);
			this.Controls.Add(this.nameComboBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AddModifybutton);
			this.Controls.Add(this.Closebutton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddModifyLanguageForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Translation Properties - BULocalization";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox nameComboBox;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button AddModifybutton;
		private System.Windows.Forms.Button Closebutton;
	}
}
