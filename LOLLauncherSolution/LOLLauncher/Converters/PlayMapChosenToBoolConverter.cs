using LOLLauncher.Common.Enums;
using System;
using System.Globalization;
using System.Windows.Data;

namespace LOLLauncher.Converters
{
	public class PlayMapChosenToBoolConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var mapType = (Map)Enum.Parse(typeof(Map), parameter.ToString()!);
			var chosenMapType = (Map)Enum.Parse(typeof(Map), value.ToString()!);

			return mapType == chosenMapType;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return new object();
		}
	}
}
