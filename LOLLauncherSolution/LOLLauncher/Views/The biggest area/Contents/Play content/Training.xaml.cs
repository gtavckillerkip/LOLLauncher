using System.Windows.Controls;

namespace LOLLauncher.Views.The_biggest_area.Contents.Play_content
{
	/// <summary>
	/// Логика взаимодействия для Training.xaml
	/// </summary>
	public partial class Training : UserControl
	{
		private static Training? _instance = null;

		private Training()
		{
			InitializeComponent();
		}

		public static Training GetInstance()
		{
			return _instance ??= new Training();
		}
	}
}
