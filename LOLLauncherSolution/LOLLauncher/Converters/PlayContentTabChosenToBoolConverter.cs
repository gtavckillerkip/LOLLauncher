using LOLLauncher.ViewModels.The_biggest_area.Play_content;
using System;
using System.Globalization;
using System.Windows.Data;

namespace LOLLauncher.Converters
{
	public class PlayContentTabChosenToBoolConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var buttonType = (PlayContentVM.PlayContentButtons)Enum.Parse(typeof(PlayContentVM.PlayContentButtons), parameter.ToString()!);
			var chosenButtonType = (PlayContentVM.PlayContentButtons)Enum.Parse(typeof(PlayContentVM.PlayContentButtons), value.ToString()!);

			return buttonType == chosenButtonType;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return new object();
		}
	}
}
