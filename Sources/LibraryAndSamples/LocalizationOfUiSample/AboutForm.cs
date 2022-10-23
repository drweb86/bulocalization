using System;
using System.Drawing;
using System.Windows.Forms;
using BULocalization;

namespace TestUi
{
	public partial class AboutForm : Form
	{
		public AboutForm()
		{
			InitializeComponent();
			
			Translation translation = Translation.Current;
			aboutTextBox.Lines = translation.ToSetOfLines(1);
			Text = translation[2];
		}
	}
}
