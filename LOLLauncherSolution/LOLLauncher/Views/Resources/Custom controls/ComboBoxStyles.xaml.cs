using System.Windows;

namespace LOLLauncher.Views.Resources.Custom_controls
{
    public partial class ComboBoxStyles : ResourceDictionary
    {
		/// <summary>
		/// Отмена (пропуск) автоматической прокрутки содержимого выпадающего списка.
		/// </summary>
		public void ComboBox_RequestBringIntoView(object sender, RequestBringIntoViewEventArgs e)
		{
			e.Handled = true;
		}
	}
}
