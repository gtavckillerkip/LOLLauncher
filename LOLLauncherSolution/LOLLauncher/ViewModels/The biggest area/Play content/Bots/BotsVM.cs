using LOLLauncher.Commands;
using LOLLauncher.Common.Enums;
using LOLLauncher.Common.Interfaces;
using System.ComponentModel;
using System.Windows.Input;

namespace LOLLauncher.ViewModels.The_biggest_area.Play_content.Bots
{
	/// <summary>
	/// VM-компонент PVP игры.
	/// </summary>
	public class BotsVM : INotifyPropertyChanged, IGameTypedVM
	{
		/// <summary>
		/// Выбранная карта.
		/// </summary>
		private Map _selectedMap;

		/// <summary>
		/// Конструктор VM-компонента.
		/// </summary>
		public BotsVM()
		{
			_selectedMap = Map.SummonersRift;
			MapClickCommand = new PlayMapCommand(this);
		}

		/// <inheritdoc/>
		public Map SelectedMap
		{
			get => _selectedMap;
			set
			{
				_selectedMap = value;
				OnPropertyChanged(nameof(SelectedMap));
			}
		}

		/// <inheritdoc/>
		public ICommand MapClickCommand { get; set; }

		#region INotifyPropertyChanged
		public event PropertyChangedEventHandler? PropertyChanged;

		private void OnPropertyChanged(string propertyName = "") =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		#endregion
	}
}
