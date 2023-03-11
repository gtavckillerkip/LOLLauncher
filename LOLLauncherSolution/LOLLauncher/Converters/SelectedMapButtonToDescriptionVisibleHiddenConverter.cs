using LOLLauncher.Common.Enums;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace LOLLauncher.Converters
{
	public class SelectedMapButtonToDescriptionVisibleHiddenConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var map = (Map)Enum.Parse(typeof(Map), parameter.ToString()!);
			var selectedMap = (Map)Enum.Parse(typeof(Map), value.ToString()!);

			return map == selectedMap ? Visibility.Visible : Visibility.Hidden;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return new object();
		}
	}
}
