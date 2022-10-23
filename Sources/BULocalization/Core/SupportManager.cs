using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace BULocalization.Core
{
	internal enum ProgramUrls
	{
		Support,
		NewFeature,
		Bug,
		Homepage
	}

	internal static class SupportManager
	{ 
		private const string SupportRequestURL = "http://sourceforge.net/tracker/?func=add&group_id=199027&atid=967843";
		private const string FeatureRequestURL = "https://sourceforge.net/tracker/?func=add&group_id=199027&atid=967845";
		private const string ReportABugURL = "https://sourceforge.net/tracker/?func=add&group_id=199027&atid=967842";
		private const string VisitHomepageURL = "https://sourceforge.net/projects/bulocalization/";
		private static readonly string _helpFile;

		static SupportManager()
		{
			string binFolder = Application.StartupPath;
			string installFolder = Directory.GetParent(binFolder).FullName;
			_helpFile = Path.Combine(
				Path.Combine(installFolder, "end-user-docs"),
				"documentation.txt");
		}
		
		public static void WriteEmail(string email)
		{
			StartProcess("mailto:" + email, string.Empty);
		}

		public static void OpenHelp()
		{
			StartProcess(_helpFile, string.Empty);
		}

		public static void OpenUrl(string url)
		{
			StartProcess(url, string.Empty);
		}

		public static void Open(ProgramUrls url)
		{
			switch (url)
			{
				case ProgramUrls.Support:
					OpenUrl(SupportRequestURL);
					break;
				case ProgramUrls.NewFeature:
					OpenUrl(FeatureRequestURL);
					break;
				case ProgramUrls.Bug:
					OpenUrl(ReportABugURL);
					break;
				case ProgramUrls.Homepage:
					OpenUrl(VisitHomepageURL);
					break;
				default:
					throw new NotImplementedException(url.ToString());
			}
		}
		
		public static void work(object state)
		{
			string linkOrProcess = ((string[])state)[0];
			string parameter = ((string[])state)[1];

			Process browser = new Process();
			browser.StartInfo.UseShellExecute = true;
			browser.StartInfo.FileName = linkOrProcess;
			
			if (!string.IsNullOrEmpty(parameter))
			{
				browser.StartInfo.Arguments = "\"" + parameter + "\"";
				browser.StartInfo.UseShellExecute = false;
			}
			
			try
			{
				browser.Start();
			}
			catch (ObjectDisposedException e)
			{
				DialogsUtil.ShowErrorMessage(linkOrProcess + Environment.NewLine + e.Message);
			}
			catch (System.ComponentModel.Win32Exception e)
			{
				DialogsUtil.ShowErrorMessage(linkOrProcess + Environment.NewLine + e.Message);
			}
		}
		
		public static void StartProcess(string linkOrProcess, string parameter)
		{
			ThreadPool.QueueUserWorkItem(work, new string[] {linkOrProcess, parameter});
		}
	}
}
