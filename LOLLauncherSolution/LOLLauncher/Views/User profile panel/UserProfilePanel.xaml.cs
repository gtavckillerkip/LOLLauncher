using System;
using System.Windows;
using System.Windows.Controls;

namespace LOLLauncher.Views.User_profile_panel
{
	/// <summary>
	/// Логика взаимодействия для UserProfilePanel.xaml
	/// </summary>
	public partial class UserProfilePanel : UserControl
	{
		public UserProfilePanel()
		{
			InitializeComponent();
		}

		public void Exit_Click_Temporary(object sender, EventArgs e)
		{
			Application.Current.Shutdown();
		}
	}
}
