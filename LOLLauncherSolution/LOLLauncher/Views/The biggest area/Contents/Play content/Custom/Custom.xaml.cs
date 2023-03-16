using LOLLauncher.ViewModels.The_biggest_area.Play_content.Custom;
using System.Windows.Controls;

namespace LOLLauncher.Views.The_biggest_area.Contents.Play_content.Custom
{
	/// <summary>
	/// Логика взаимодействия для Custom.xaml
	/// </summary>
	public partial class Custom : UserControl
    {
		private static Custom? _instance = null;

		private Custom()
		{
			InitializeComponent();
		}

		public static Custom GetInstance()
		{
			if (_instance != null)
				(_instance.DataContext as CustomVM)!.ChosenVariant = CustomVM.CustomVariant.Base;

			return _instance ??= new Custom();
		}
	}
}
