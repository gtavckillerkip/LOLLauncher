using LOLLauncher.Commands;
using LOLLauncher.Common.Enums;
using LOLLauncher.Common.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace LOLLauncher.ViewModels.The_biggest_area.Play_content.Training
{
	/// <summary>
	/// VM-компонент PVP игры.
	/// </summary>
	public class TrainingVM : INotifyPropertyChanged, IGameTypedVM
	{
		/// <summary>
		/// Выбранная карта.
		/// </summary>
		private Map _selectedMap;

		/// <summary>
		/// Конструктор VM-компонента.
		/// </summary>
		public TrainingVM()
		{
			_selectedMap = Map.HowlingAbyss;
			MapClickCommand = new PlayMapCommand(this);
			Maps = new Dictionary<Map, object>
			{
				[Map.HowlingAbyss] = new
				{
					Title = "ОБУЧЕНИЕ",
					Description = "Изучите основы игры на тренировочном поле боя."
				},
				[Map.SummonersRift] = new
				{
					Title = "ИНСТРУМЕНТ\nДЛЯ\nТРЕНИРОВКИ",
					Description = "Тренируйтесь играть своим любимым чемпионом в спортзале Ущелья призывателей для одного игрока."
				},
			};
			MapRegimes = new Dictionary<Map, List<object>>();
			SelectedRegimes = new ObservableCollection<int>();
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
