using System.Windows.Controls;

namespace LOLLauncher.Views.The_biggest_area.Contents
{
    /// <summary>
    /// Логика взаимодействия для ClashContent.xaml
    /// </summary>
    public partial class ClashContent : UserControl
    {
		private static ClashContent? instance = null;

		private ClashContent()
		{
			InitializeComponent();
		}

		public static ClashContent GetInstance()
		{
			return instance ??= new ClashContent();
		}
	}
}
