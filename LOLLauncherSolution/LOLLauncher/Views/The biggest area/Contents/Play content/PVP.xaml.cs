using System.Windows.Controls;

namespace LOLLauncher.Views.The_biggest_area.Contents.Play_content
{
	/// <summary>
	/// Логика взаимодействия для PVP.xaml
	/// </summary>
	public partial class PVP : UserControl
	{
		private static PVP? _instance = null;

		private PVP()
		{
			InitializeComponent();
		}

		public static PVP GetInstance()
		{
			return _instance ??= new PVP();
		}
	}
}
