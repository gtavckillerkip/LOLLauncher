using LOLLauncher.ViewModels.User_profile_panel;
using System;
using System.Globalization;
using System.Windows.Data;

namespace LOLLauncher.Converters
{
	public class IconIdToURIConverter : IValueConverter

	{
		public object? Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var iconsDictionary = UserProfilePanelVM.AvailableIconIdToURIDictionary;
			return iconsDictionary.ContainsKey((int)value) ? iconsDictionary[(int)value] : null;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return new object();
		}
	}
}
