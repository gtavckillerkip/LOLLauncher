using LOLLauncher.ViewModels.The_biggest_area.Home_content;
using LOLLauncher.Views.The_biggest_area.Contents.Home_content;
using System;
using System.Globalization;
using System.Windows.Data;

namespace LOLLauncher.Converters
{
	public class HCButtonChosenToContentConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return (HomeContentVM.HomeContentButtons)value switch
			{
				HomeContentVM.HomeContentButtons.Overview =>	Overview.GetInstance(),
				HomeContentVM.HomeContentButtons.Updates =>		Updates.GetInstance(),
				_ => new object(),
			};
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return new object();
		}
	}
}
