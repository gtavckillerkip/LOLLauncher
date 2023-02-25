using System.ComponentModel;

namespace LOLLauncher.ViewModels
{
	/// <summary>
	/// VM-компонент главного окна.
	/// </summary>
	public class MainWindowVM : INotifyPropertyChanged
	{
		/// <summary>
		/// URI-ссылка на фон.
		/// </summary>
		private string _expandedBackgroundURI;

		/// <summary>
		/// Конструктор VM-компонента.
		/// </summary>
        public MainWindowVM()
        {
			Instance = this;
			_expandedBackgroundURI = "";
        }

		/// <summary>
		/// URI-ссылка на фон.
		/// </summary>
		public string ExpandedBackgroundURI
		{
			get => _expandedBackgroundURI;
			set
			{
				_expandedBackgroundURI = value;
				OnPropertyChanged(nameof(ExpandedBackgroundURI));
			}
		}

		/// <summary>
		/// Ссылка на созданный VM-компонент.
		/// </summary>
		public static MainWindowVM? Instance { get; set; }

		#region INotifyPropertyChanged
		public event PropertyChangedEventHandler? PropertyChanged;

		private void OnPropertyChanged(string propertyName = "") =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		#endregion
	}
}
