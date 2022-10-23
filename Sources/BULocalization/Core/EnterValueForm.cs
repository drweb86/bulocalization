using System;
using System.Drawing;
using System.Windows.Forms;

namespace BULocalization.Core
{
	public partial class EnterValueForm : Form
	{
		public string Value
		{
			get { return valueTextBox.Text; }
		}
		
		public EnterValueForm(string caption, string text, string defaultValue)
		{
			InitializeComponent();
			
			infoLabel.Text = text;
			this.Text = caption;
			valueTextBox.Text = defaultValue;
			okButton.Enabled = !string.IsNullOrEmpty(valueTextBox.Text.Trim());
		}
		
		private void okButtonClick(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(valueTextBox.Text.Trim()))
			{
				DialogResult = DialogResult.OK;
			}
		}
		
		private void valueTextBoxTextChanged(object sender, EventArgs e)
		{
			okButton.Enabled = !string.IsNullOrEmpty(valueTextBox.Text.Trim());
		}
	}
}
