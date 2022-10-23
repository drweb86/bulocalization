/*

Sample for using library in Ui applications
with subforms

*/
using System;
using System.Windows.Forms;
using BULocalization;

namespace TestUi
{
	internal partial class MainForm : Form
	{
		private readonly AppController _controller = new AppController();
		
		public MainForm()
		{
			InitializeComponent();

            _controller.LocalizationManager.Init();
            _controller.LocalizationManager.OnApplyLanguage += onApplyLanguage;
            _controller.LocalizationManager.GenerateMenuWithLanguages(languagesToolStripMenuItem);
            _controller.LocalizationManager.Apply();
			
		}

		void onApplyLanguage(Translation translation)
		{
			chooseLanguageButton.Text = translation[3];
			aboutProgramToolStripMenuItem.Text = translation[2];
		}
		
		void ChooseLanguageButtonClick(object sender, EventArgs e)
		{
            _controller.LocalizationManager.ShowSelectLanguageDialog(true, true);
		}
		
		void AboutProgramToolStripMenuItemClick(object sender, EventArgs e)
		{
			using (AboutForm form = new AboutForm())
			{
				form.ShowDialog();
			}
		}
	}
	

}
