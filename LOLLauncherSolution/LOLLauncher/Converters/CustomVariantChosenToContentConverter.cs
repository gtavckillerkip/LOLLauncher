using LOLLauncher.ViewModels.The_biggest_area.Play_content.Custom;
using LOLLauncher.Views.The_biggest_area.Contents.Play_content;
using LOLLauncher.Views.The_biggest_area.Contents.Play_content.Custom;
using System;
using System.Globalization;
using System.Windows.Data;

namespace LOLLauncher.Converters
{
	public class CustomVariantChosenToContentConverter : IValueConverter
    {
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return (CustomVM.CustomVariant)value switch
			{
				CustomVM.CustomVariant.Base =>			BaseCustom.GetInstance(),
				CustomVM.CustomVariant.CreateCustom =>	CreateCustom.GetInstance(),
				CustomVM.CustomVariant.JoinCustom =>	JoinCustom.GetInstance(),
				_ => new object(),
			};
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return new object();
		}
	}
}
