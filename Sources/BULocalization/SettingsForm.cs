using System;
using System.Windows.Forms;

using BULocalization.TranslationEditor;
using BULocalization.Core;

namespace BULocalization
{
	internal partial class SettingsForm : Form
	{
		private const string _SpecifyName = "Please specify your name, please";
		private const string _SpecifyEmail = "Please specify your email, please";

		private readonly AppController _controller;
		
		public SettingsForm(AppController controller)
		{
			_controller = controller;
			InitializeComponent();
			SubjecttextBox.Text = Settings.LetterSubject;
			BodytextBox.Lines = BUTranslation.CreateEditableText(Settings.LetterBody);
			HosttextBox.Text = Settings.SmtpHost;
			portNumericUpDown.Value = Settings.SmtpPort;
			emailTextBox.Text = Settings.Email;
			translatorNameTextBox.Text = Settings.Name;
			otherContactInformationTextBox.Text = Settings.OtherContactInformation;
		}
		
		void OkbuttonClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(translatorNameTextBox.Text))
			{
				DialogsUtil.ShowErrorMessage(_SpecifyName);
				return;
			}

			if (string.IsNullOrEmpty(emailTextBox.Text))
			{
				DialogsUtil.ShowErrorMessage(_SpecifyEmail);
				return;
			}

			Settings.LetterSubject = SubjecttextBox.Text;
			Settings.LetterBody = BUTranslation.CreateFormattedText(BodytextBox.Lines);
			Settings.SmtpHost = HosttextBox.Text;
			Settings.SmtpPort = Convert.ToInt32(portNumericUpDown.Value);
			Settings.Name = translatorNameTextBox.Text;
			Settings.Email = emailTextBox.Text;
			Settings.OtherContactInformation = otherContactInformationTextBox.Text;

			if (_controller.SaveSettings())
				this.DialogResult = DialogResult.OK;
		}
	}
}
