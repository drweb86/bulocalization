using System;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

using BULocalization.Core;

namespace BULocalization.TranslationEditor
{
	internal partial class EmailForm : Form
	{
		private const string _NoTargetEmail = "There's no e-mail to whom translation should be send\n\nThis translation is corrupted!!!";
		private const string _SubjectFormatString = "Translation on {0} updated : {1}";
		
		private LocalizationController _controller;
		
		public EmailForm(LocalizationController controller, string attachmentFile)
		{
			_controller = controller;

			InitializeComponent();

			TotextBox.Text = _controller.SendToEmail;
			AttachmenttextBox.Text = attachmentFile;
			FromtextBox.Text = Settings.Email;

			string justFileName = System.IO.Path.GetFileNameWithoutExtension(_controller.TranslationFile);
			
			SubjecttextBox.Text =
				string.Format(CultureInfo.InvariantCulture,
				              _SubjectFormatString, 
				              justFileName, 
				              DateTime.Now.ToLongDateString());
			
			if (string.IsNullOrEmpty(_controller.SendToEmail))
			{
				DialogsUtil.ShowErrorMessage(_NoTargetEmail);
				TotextBox.ReadOnly = false;
			}
			
			TexttextBox.Text = Settings.OtherContactInformation;
		}
		
		private void SendbuttonClick(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(TotextBox.Text))
			{
				Mailer.SendIt(FromtextBox.Text,
			              TotextBox.Text,
			              SubjecttextBox.Text,
			              TexttextBox.Text,
			              AttachmenttextBox.Text,
			              Settings.SmtpHost,
			              Settings.SmtpPort,
			              true);
			}
		}
	}
}
