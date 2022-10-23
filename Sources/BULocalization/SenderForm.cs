using System;
using System.Net.Mail;
using System.Windows.Forms;
using System.Globalization;
using BULocalization.Core;

namespace BULocalization
{
	internal partial class SenderForm : Form
	{
		private readonly string _CouldNotSend = "Could not send letter {0}\n\nYou can copy information from this form to your e-mail client, send it through browswer";
		
		public SenderForm(string from, string to, string subject, string body, string file)
		{
			InitializeComponent();
			
			fromTextBox.Text = from;
			TotextBox.Text = to;
			SubjecttextBox.Text = subject;
			BodytextBox.Text = body;
			AttachtextBox.Text = file;

			Send();
		}
		
		private void Send()
		{
			try
			{
				MailAddress from = new MailAddress(fromTextBox.Text);
				MailAddress to = new MailAddress(TotextBox.Text);
				MailMessage message = new MailMessage(from, to);
				Attachment file = new Attachment(AttachtextBox.Text);
			
				message.Subject = SubjecttextBox.Text;
				message.Body = BodytextBox.Text;
				message.Attachments.Add(file);
			
				SmtpClient client = new SmtpClient(Settings.SmtpHost, Convert.ToInt32(Settings.SmtpPort, CultureInfo.CurrentCulture));
				
				client.Send(message);
			}
			catch(Exception ee)
			{
				DialogsUtil.ShowErrorMessage(string.Format(CultureInfo.CurrentCulture, _CouldNotSend, ee.Message));
				return;
			}
			
			DialogResult = DialogResult.OK;
		}
		
		private void ClosebuttonClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}
	}
}
