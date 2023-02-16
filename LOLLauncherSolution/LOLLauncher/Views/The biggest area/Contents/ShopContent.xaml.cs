using System.Windows.Controls;

namespace LOLLauncher.Views.The_biggest_area.Contents
{
    /// <summary>
    /// Логика взаимодействия для ShopContent.xaml
    /// </summary>
    public partial class ShopContent : UserControl
    {
		private static ShopContent? instance = null;

		private ShopContent()
		{
			InitializeComponent();
		}

		public static ShopContent GetInstance()
		{
			return instance ??= new ShopContent();
		}
	}
}
