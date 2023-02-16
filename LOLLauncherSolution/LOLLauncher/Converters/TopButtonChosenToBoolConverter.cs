using LOLLauncher.ViewModels.Top_panel;
using System;
using System.Globalization;
using System.Windows.Data;

namespace LOLLauncher.Converters
{
	public class TopButtonChosenToBoolConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var buttonType = (TopButtonsVM.MainButtons)Enum.Parse(typeof(TopButtonsVM.MainButtons), parameter.ToString()!);
			var chosenButtonType = (TopButtonsVM.MainButtons)Enum.Parse(typeof(TopButtonsVM.MainButtons), value.ToString()!);

			return buttonType == chosenButtonType;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return new object();
		}
	}
}
