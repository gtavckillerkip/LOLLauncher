using System;
using System.Globalization;
using System.Windows.Data;

namespace LOLLauncher.Converters
{
	public class SelectedRadioIndexToIsCheckedConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return (int)value == int.Parse((string)parameter);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return int.Parse((string)parameter);
		}
	}
}
