using System.Windows.Controls;

namespace LOLLauncher.Views.The_biggest_area.Contents.Play_content.Custom
{
	/// <summary>
	/// Логика взаимодействия для BaseCustom.xaml
	/// </summary>
	public partial class BaseCustom : UserControl
    {
		private static BaseCustom? _instance = null;

		private BaseCustom()
		{
			InitializeComponent();
		}

		public static BaseCustom GetInstance()
		{
			return _instance ??= new BaseCustom();
		}
	}
}
