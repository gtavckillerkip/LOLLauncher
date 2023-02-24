using LOLLauncher.ViewModels.Top_panel;
using System;
using System.Globalization;
using System.Windows.Data;

namespace LOLLauncher.Converters
{
	public class TopTabChosenToBoolConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var buttonType = (TopTabsVM.MainButtons)Enum.Parse(typeof(TopTabsVM.MainButtons), parameter.ToString()!);
			var chosenButtonType = (TopTabsVM.MainButtons)Enum.Parse(typeof(TopTabsVM.MainButtons), value.ToString()!);

			return buttonType == chosenButtonType;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return new object();
		}
	}
}
