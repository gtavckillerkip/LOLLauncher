using LOLLauncher.Commands;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace LOLLauncher.ViewModels.The_biggest_area.Home_content
{
	/// <summary>
	/// VM-компонент содержимого, связанного с кнопкой "Главная".
	/// </summary>
	public class HomeContentVM : INotifyPropertyChanged
	{
		/// <summary>
		/// Кнопки для переключения вкладок содержимого под кнопкой "Главная".
		/// </summary>
		public enum HomeContentButtons
		{
			/// <summary>
			/// Обзор.
			/// </summary>
			Overview,

			/// <summary>
			/// Обновления.
			/// </summary>
			Updates,
		}

		/// <summary>
		/// Выбранная кнопка.
		/// </summary>
		private HomeContentButtons _chosenButton;

		/// <summary>
		/// Конструктор VM-компонента.
		/// </summary>
		public HomeContentVM()
		{
			_chosenButton = HomeContentButtons.Overview;
			ClickCommand = new HCButtonClickCommand(this);
		}

		/// <summary>
		/// Выбранная кнопка.
		/// </summary>
		public HomeContentButtons ChosenButton
		{
			get => _chosenButton;
			set
			{
				_chosenButton = value;
				OnPropertyChanged(nameof(ChosenButton));
			}
		}

		/// <summary>
		/// Команда нажатия кнопки.
		/// </summary>
		public ICommand ClickCommand { get; set; }

		#region INotifyPropertyChanged
		public event PropertyChangedEventHandler? PropertyChanged;

		private void OnPropertyChanged(string propertyName = "") =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		#endregion
	}
}
