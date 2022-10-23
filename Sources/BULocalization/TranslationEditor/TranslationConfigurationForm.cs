using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

using BULocalization.Core;

namespace BULocalization.TranslationEditor
{
	internal partial class TranslationConfigurationForm : Form
	{
		private const string _SpecifyNaturalName = "Please specify natural language name!";
		private readonly LocalizationController _controller;
		
		public TranslationConfigurationForm(LocalizationController controller)
		{
			_controller = controller;

			InitializeComponent();

			if (_controller.LoadedLanguage)
			{
				_naturalNameTextBox.Text = _controller.CurrentTranslationNaturalName;
				_isSupportcheckBox.Checked = _controller.CurrentTranslationIsSupported;
			}
		}

		private void OKbuttonClick(object sender, EventArgs e)
		{
			if (_controller.LoadedLanguage)
			{
				if (string.IsNullOrEmpty(_naturalNameTextBox.Text))
				{
					DialogsUtil.ShowErrorMessage(_SpecifyNaturalName);
					return;
				}
				
				_controller.CurrentTranslationIsSupported = _isSupportcheckBox.Checked;
				_controller.CurrentTranslationNaturalName = _naturalNameTextBox.Text;
			}

			DialogResult = DialogResult.OK;
		}
	}
}
