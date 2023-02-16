using System.Windows.Controls;

namespace LOLLauncher.Views.The_biggest_area.Contents
{
    /// <summary>
    /// Логика взаимодействия для InventoryContent.xaml
    /// </summary>
    public partial class InventoryContent : UserControl
    {
		private static InventoryContent? instance = null;

		private InventoryContent()
		{
			InitializeComponent();
		}

		public static InventoryContent GetInstance()
		{
			return instance ??= new InventoryContent();
		}
	}
}
