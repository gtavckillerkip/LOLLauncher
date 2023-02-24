using System.Windows.Controls;

namespace LOLLauncher.Views.The_biggest_area.Contents.Play_content
{
	/// <summary>
	/// Логика взаимодействия для Bots.xaml
	/// </summary>
	public partial class Bots : UserControl
	{
		private static Bots? _instance = null;

		private Bots()
		{
			InitializeComponent();
		}

		public static Bots GetInstance()
		{
			return _instance ??= new Bots();
		}
	}
}
