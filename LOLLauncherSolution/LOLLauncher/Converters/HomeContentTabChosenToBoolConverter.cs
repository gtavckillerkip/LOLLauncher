using LOLLauncher.ViewModels.The_biggest_area.Home_content;
using System;
using System.Globalization;
using System.Windows.Data;

namespace LOLLauncher.Converters
{
	public class HomeContentTabChosenToBoolConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var buttonType = (HomeContentVM.HomeContentButtons)Enum.Parse(typeof(HomeContentVM.HomeContentButtons), parameter.ToString()!);
			var chosenButtonType = (HomeContentVM.HomeContentButtons)Enum.Parse(typeof(HomeContentVM.HomeContentButtons), value.ToString()!);

			return buttonType == chosenButtonType;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return new object();
		}
	}
}
