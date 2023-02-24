using System.Windows.Controls;

namespace LOLLauncher.Views.The_biggest_area.Contents.Play_content
{
	/// <summary>
	/// Логика взаимодействия для CreateCustom.xaml
	/// </summary>
	public partial class CreateCustom : UserControl
	{
		private static CreateCustom? _instance = null;

		private CreateCustom()
		{
			InitializeComponent();
		}

		public static CreateCustom GetInstance()
		{
			return _instance ??= new CreateCustom();
		}
	}
}
