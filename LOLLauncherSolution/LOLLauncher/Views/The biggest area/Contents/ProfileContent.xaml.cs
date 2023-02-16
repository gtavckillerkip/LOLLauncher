using System.Windows.Controls;

namespace LOLLauncher.Views.The_biggest_area.Contents
{
    /// <summary>
    /// Логика взаимодействия для ProfileContent.xaml
    /// </summary>
    public partial class ProfileContent : UserControl
    {
		private static ProfileContent? instance = null;

		private ProfileContent()
		{
			InitializeComponent();
		}

		public static ProfileContent GetInstance()
		{
			return instance ??= new ProfileContent();
		}
	}
}
