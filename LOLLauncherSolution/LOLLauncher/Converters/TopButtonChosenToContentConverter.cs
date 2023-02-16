using LOLLauncher.ViewModels.Top_panel;
using LOLLauncher.Views.The_biggest_area.Contents;
using System;
using System.Globalization;
using System.Windows.Data;

namespace LOLLauncher.Converters
{
	public class TopButtonChosenToContentConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return (TopButtonsVM.MainButtons)value switch
			{
				TopButtonsVM.MainButtons.Play =>		PlayContent.GetInstance(),
				TopButtonsVM.MainButtons.Home =>		HomeContent.GetInstance(),
				TopButtonsVM.MainButtons.TFT =>			TFTContent.GetInstance(),
				TopButtonsVM.MainButtons.Clash =>		ClashContent.GetInstance(),
				TopButtonsVM.MainButtons.Profile =>		ProfileContent.GetInstance(),
				TopButtonsVM.MainButtons.Collection => CollectionContent.GetInstance(),
				TopButtonsVM.MainButtons.Inventory =>	InventoryContent.GetInstance(),
				TopButtonsVM.MainButtons.Shop =>		ShopContent.GetInstance(),
				_ => new object(),
			};
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return new object();
		}
	}
}
