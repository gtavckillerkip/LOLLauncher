using LOLLauncher.ViewModels.Top_panel;
using LOLLauncher.Views.The_biggest_area.Contents;
using LOLLauncher.Views.The_biggest_area.Contents.Home_content;
using System;
using System.Globalization;
using System.Windows.Data;

namespace LOLLauncher.Converters
{
	public class TopTabChosenToContentConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return (TopTabsVM.MainButtons)value switch
			{
				TopTabsVM.MainButtons.Play =>		PlayContent.GetInstance(),
				TopTabsVM.MainButtons.Home =>		HomeContent.GetInstance(),
				TopTabsVM.MainButtons.TFT =>		TFTContent.GetInstance(),
				TopTabsVM.MainButtons.Clash =>		ClashContent.GetInstance(),
				TopTabsVM.MainButtons.Profile =>	ProfileContent.GetInstance(),
				TopTabsVM.MainButtons.Collection => CollectionContent.GetInstance(),
				TopTabsVM.MainButtons.Inventory =>	InventoryContent.GetInstance(),
				TopTabsVM.MainButtons.Shop =>		ShopContent.GetInstance(),
				_ => new object(),
			};
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return new object();
		}
	}
}
