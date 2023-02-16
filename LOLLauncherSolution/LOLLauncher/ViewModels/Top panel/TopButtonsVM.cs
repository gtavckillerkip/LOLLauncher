using LOLLauncher.Commands;
using System.ComponentModel;
using System.Windows.Input;

namespace LOLLauncher.ViewModels.Top_panel
{
    /// <summary>
    /// VM-компонент для основных кнопок.
    /// </summary>
    public class TopButtonsVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Кнопки верхней панели.
        /// </summary>
        public enum MainButtons
        {
            /// <summary>
            /// Играть.
            /// </summary>
            Play,

            /// <summary>
            /// Главная.
            /// </summary>
            Home,

            /// <summary>
            /// TFT.
            /// </summary>
            TFT,

            /// <summary>
            /// Clash.
            /// </summary>
            Clash,

            /// <summary>
            /// Профиль.
            /// </summary>
            Profile,

			/// <summary>
			/// Коллекция.
			/// </summary>
			Collection,

			/// <summary>
			/// Инвентарь.
			/// </summary>
			Inventory,

            /// <summary>
            /// Магазин.
            /// </summary>
            Shop,
        }

        /// <summary>
        /// Выбранная кнопка.
        /// </summary>
        private MainButtons _chosenButton;

        /// <summary>
        /// Конструктор VM-компонента.
        /// </summary>
        public TopButtonsVM()
        {
            Instance = this;
            _chosenButton = MainButtons.Home;
            ClickCommand = new TopButtonClickCommand(this);
        }

        /// <summary>
        /// Выбранная кнопка.
        /// </summary>
        public MainButtons ChosenButton
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

		/// <summary>
		/// Последний созданный экземпляр VM.
		/// </summary>
		public static TopButtonsVM? Instance { get; private set; }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion
    }
}
