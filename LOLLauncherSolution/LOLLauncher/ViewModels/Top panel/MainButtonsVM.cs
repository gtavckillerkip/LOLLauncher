using System.ComponentModel;

namespace LOLLauncher.ViewModels.Top_panel
{
    /// <summary>
    /// VM-компонент для основных кнопок.
    /// </summary>
    public class MainButtonsVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Выбрана ли кнопка "Главная".
        /// </summary>
        private bool _isHomeButtonChosen;

        /// <summary>
        /// Выбрана ли кнопка "TFT".
        /// </summary>
        private bool _isTFTButtonChosen;

        /// <summary>
        /// Выбрана ли кнопка "Clash".
        /// </summary>
        private bool _isClashButtonChosen;

        /// <summary>
        /// Конструктор VM-компонента.
        /// </summary>
        public MainButtonsVM()
        {
            _isHomeButtonChosen = true;
        }

        /// <summary>
        /// Выбрана ли кнопка "Главная".
        /// </summary>
        public bool IsHomeButtonChosen
        {
            get => _isHomeButtonChosen;
            set
            {
                _isHomeButtonChosen = value;
                OnPropertyChanged(nameof(IsHomeButtonChosen));
            }
        }

        /// <summary>
        /// Выбрана ли кнопка "TFT".
        /// </summary>
        public bool IsTFTButtonChosen
        {
            get => _isTFTButtonChosen;
            set
            {
                _isTFTButtonChosen = value;
                OnPropertyChanged(nameof(IsTFTButtonChosen));
            }
        }

        /// <summary>
        /// Выбрана ли кнопка "Clash".
        /// </summary>
        public bool IsClashButtonChosen
        {
            get => _isClashButtonChosen;
            set
            {
                _isClashButtonChosen = value;
                OnPropertyChanged(nameof(IsClashButtonChosen));
            }
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion
    }
}
