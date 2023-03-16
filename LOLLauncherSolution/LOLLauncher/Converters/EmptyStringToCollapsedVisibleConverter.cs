using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace LOLLauncher.Converters
{
	public class EmptyStringToCollapsedVisibleConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return ((string)value).Length == 0 ? Visibility.Collapsed : Visibility.Visible;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return new object();
		}
	}
}
