using System;
using System.Windows.Forms;
using BULocalization.Core;

namespace BULocalization
{
	public partial class AddModifyLanguageForm : Form
	{
		private LanguageInfo _language;

		public LanguageInfo Language
		{
			get { return _language; }
		}
		
		private string ChosenName
		{
			get { return nameComboBox.Text.Trim(); }
		}

		public AddModifyLanguageForm(LanguageInfo language)
		{
			_language = language;
			
			InitializeComponent();
			
			nameComboBox.Text = _language.Name;
			NameComboBoxTextChanged(null, null);
		}
		
		private void AddModifybuttonClick(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(ChosenName))
			{
				_language.Name = ChosenName;
				_language.SpecificName = string.Empty;

				this.DialogResult = DialogResult.OK;
			}
		}
		
		private void NameComboBoxTextChanged(object sender, EventArgs e)
		{
			AddModifybutton.Enabled = (!string.IsNullOrEmpty(ChosenName));
		}
	}
}
