using LOLLauncher.Commands;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;

namespace LOLLauncher.ViewModels.The_biggest_area.Play_content
{
	/// <summary>
	/// VM-компонент содержимого, связанного с кнопкой "Играть".
	/// </summary>
	public class PlayContentVM : INotifyPropertyChanged
	{
		/// <summary>
		/// Кнопки для переключения вкладок содержимого под кнопкой "Главная".
		/// </summary>
		public enum PlayContentButtons
		{
			/// <summary>
			/// PVP.
			/// </summary>
			PVP,

			/// <summary>
			/// Боты.
			/// </summary>
			Bots,

			/// <summary>
			/// Тренировка.
			/// </summary>
			Training,

			/// <summary>
			/// Своя игра.
			/// </summary>
			Custom,
		}

		/// <summary>
		/// Выбранная кнопка.
		/// </summary>
		private PlayContentButtons _chosenButton;

		/// <summary>
		/// Конструктор VM-компонента.
		/// </summary>
		public PlayContentVM()
		{
			_chosenButton = PlayContentButtons.PVP;
			ClickCommand = new PlayContentTabCommand(this);
			ButtonsNames = new Dictionary<PlayContentButtons, string>
			{
				[PlayContentButtons.PVP] = "PVP",
				[PlayContentButtons.Bots] = "ПРОТИВ БОТОВ",
				[PlayContentButtons.Custom] = "СВОЯ ИГРА",
				[PlayContentButtons.Training] = "ТРЕНИРОВКА",
			};
		}

		/// <summary>
		/// Названия кнопок.
		/// </summary>
		public Dictionary<PlayContentButtons, string> ButtonsNames { get; set; }

		/// <summary>
		/// Выбранная кнопка.
		/// </summary>
		public PlayContentButtons ChosenButton
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
