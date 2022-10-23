using System;
using System.Windows.Forms;
using System.Globalization;

namespace BULocalization.Core
{
	public static class DialogsUtil
	{
		private const string _ErrorCaption = "Error";
		private const string _InformationCaption = "Information";
		private const string _About = "Making programs closer to user\n\n{0} version {1}";

		public static void ShowErrorMessage(string message)
		{
			MessageBox.Show(message, _ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0);
		}

		public static void ShowInformationMessage(string message)
		{
			MessageBox.Show(message, _InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0);
		}

		public static void ShowAboutProgramMessage(string programName, string version)
		{
			MessageBox.Show(string.Format(CultureInfo.CurrentCulture, _About, programName, version), programName, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0);
		}
	}
}
