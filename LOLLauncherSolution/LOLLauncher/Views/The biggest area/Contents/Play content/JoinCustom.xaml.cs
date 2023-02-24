using System.Windows.Controls;

namespace LOLLauncher.Views.The_biggest_area.Contents.Play_content
{
	/// <summary>
	/// Логика взаимодействия для JoinCustom.xaml
	/// </summary>
	public partial class JoinCustom : UserControl
	{
		private static JoinCustom? _instance = null;

		private JoinCustom()
		{
			InitializeComponent();
		}

		public static JoinCustom GetInstance()
		{
			return _instance ??= new JoinCustom();
		}
	}
}
