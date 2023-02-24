using LOLLauncher.ViewModels.The_biggest_area.Play_content;
using LOLLauncher.Views.The_biggest_area.Contents.Play_content;
using System;
using System.Globalization;
using System.Windows.Data;

namespace LOLLauncher.Converters
{
	public class PlayContentTabChosenToContentConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return (PlayContentVM.PlayContentButtons)value switch
			{
				PlayContentVM.PlayContentButtons.PVP =>				PVP.GetInstance(),
				PlayContentVM.PlayContentButtons.Bots =>			Bots.GetInstance(),
				PlayContentVM.PlayContentButtons.Training =>		Training.GetInstance(),
				PlayContentVM.PlayContentButtons.CreateCustom =>	CreateCustom.GetInstance(),
				PlayContentVM.PlayContentButtons.JoinCustom =>		JoinCustom.GetInstance(),
				_ => new object(),
			};
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return new object();
		}
	}
}
