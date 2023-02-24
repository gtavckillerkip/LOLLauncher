using System.Windows.Controls;

namespace LOLLauncher.Views.The_biggest_area.Contents
{
	/// <summary>
	/// Логика взаимодействия для PlayContent.xaml
	/// </summary>
	public partial class PlayContent : UserControl
	{
		private static PlayContent? instance = null;

		private PlayContent()
		{
			InitializeComponent();
		}

		public static PlayContent GetInstance()
		{
			return instance ??= new PlayContent();
		}
	}
}
