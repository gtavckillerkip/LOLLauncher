using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Data;

namespace LOLLauncher.Converters
{
	public class NotificationsPresenceToBoolConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return ((ObservableCollection<string>)value).Count > 0;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return new object();
		}
	}
}
