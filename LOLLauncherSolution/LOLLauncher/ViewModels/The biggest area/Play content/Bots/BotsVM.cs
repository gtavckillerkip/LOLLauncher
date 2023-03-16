using LOLLauncher.Commands;
using LOLLauncher.Common.Enums;
using LOLLauncher.Common.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
			Maps = new Dictionary<Map, object>
			{
				[Map.SummonersRift] = new
				{
					Title = "УЩЕЛЬЕ\nПРИЗЫВАТЕЛЕЙ",
					Description = "Объединитесь с другими игроками против команды ботов и уничтожьте вражеский нексус."
				},
			};
			MapRegimes = new Dictionary<Map, List<object>>
			{
				[Map.SummonersRift] = new List<object>
				{
					new { Title = "БОТЫ-НАСТАВНИКИ", Info = "" },
					new { Title = "БОТЫ-НОВИЧКИ", Info = "" },
					new { Title = "БОТЫ-МАСТЕРА", Info = "" },
				},
			};
			SelectedRegimes = new ObservableCollection<int>
			{
				0,
			};
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
		public ObservableCollection<int> SelectedRegimes { get; set; }

		/// <inheritdoc/>
		public ICommand MapClickCommand { get; set; }

		/// <inheritdoc/>
		public Dictionary<Map, object> Maps { get; set; }

		/// <inheritdoc/>
		public Dictionary<Map, List<object>> MapRegimes { get; set; }

		#region INotifyPropertyChanged
		public event PropertyChangedEventHandler? PropertyChanged;

		private void OnPropertyChanged(string propertyName = "") =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		#endregion
	}
}
