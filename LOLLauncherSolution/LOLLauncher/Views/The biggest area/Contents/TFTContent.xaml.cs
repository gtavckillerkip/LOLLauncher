using System.Windows.Controls;

namespace LOLLauncher.Views.The_biggest_area.Contents
{
    /// <summary>
    /// Логика взаимодействия для TFTContent.xaml
    /// </summary>
    public partial class TFTContent : UserControl
    {
		private static TFTContent? instance = null;

		private TFTContent()
		{
			InitializeComponent();
		}

		public static TFTContent GetInstance()
		{
			return instance ??= new TFTContent();
		}
	}
}
