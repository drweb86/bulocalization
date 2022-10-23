using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Globalization;
using BULocalization.Core;

namespace BULocalization.Core
{
	public static class Mailer
	{
		private const string _CouldNotSendLetter = "Could not send letter due to: {0}";
		private const string _SentSuccesfully = "E-mail sent succesfully";
		
		public static bool SendIt(string fromEmail, 
		                          string toEmail, 
		                          string subject, 
		                          string body, 
		                          string attachedFile, 
		                          string smtpHost,
		                          int smtpPort,
		                          bool showFinishedExclamation)
		{
			MailAddress from;
			MailAddress to;
			MailMessage message;
			Attachment file;
			SmtpClient client;
			
			try
			{
				from = new MailAddress(fromEmail);
				to = new MailAddress(toEmail);
				message = new MailMessage(from, to);
				file = new Attachment(attachedFile);
			
				message.Subject = subject;
				message.Body = body;
				message.Attachments.Add(file);
			
				client = new SmtpClient(smtpHost, smtpPort);
				client.Send(message);
			}
			catch(FormatException ee)
			{
				errorHelper(_CouldNotSendLetter, ee);
				return false;
			}
			catch(ArgumentOutOfRangeException ee)
			{
				errorHelper(_CouldNotSendLetter, ee);
				return false;
			}
			catch(System.Net.Mail.SmtpFailedRecipientException ee)
			{
				errorHelper(_CouldNotSendLetter, ee);
				return false;
			}
			catch(InvalidOperationException ee)
			{
				errorHelper(_CouldNotSendLetter, ee);
				return false;
			}
			catch(System.Net.Mail.SmtpException ee)
			{
				errorHelper(_CouldNotSendLetter, ee);
				return false;			
			}
			
			if (showFinishedExclamation)
			{
				DialogsUtil.ShowInformationMessage(_SentSuccesfully);
			}
			
			return true;
		}
		
		private static void errorHelper(string formatString, Exception e)
		{
			DialogsUtil.ShowErrorMessage(
				string.Format(CultureInfo.CurrentCulture, 
				              formatString, 
				              e.Message));
		}
	}
}
