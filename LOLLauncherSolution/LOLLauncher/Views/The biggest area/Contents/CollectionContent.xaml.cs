using System.Windows.Controls;

namespace LOLLauncher.Views.The_biggest_area.Contents
{
    /// <summary>
    /// Логика взаимодействия для CollectionContent.xaml
    /// </summary>
    public partial class CollectionContent : UserControl
    {
		private static CollectionContent? instance = null;

		private CollectionContent()
		{
			InitializeComponent();
		}

		public static CollectionContent GetInstance()
		{
			return instance ??= new CollectionContent();
		}
	}
}
