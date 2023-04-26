using LOLLauncher.Commands;
using LOLLauncher.Common.Enums;
using LOLLauncher.Common.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace LOLLauncher.ViewModels.The_biggest_area.Play_content.Custom
{
	/// <summary>
	/// VM-компонент PVP игры.
	/// </summary>
	public class CreateCustomVM : INotifyPropertyChanged, IGameTypedVM
	{
		/// <summary>
		/// Тип игры.
		/// </summary>
		public enum CustomGameType
		{
			/// <summary>
			/// Выбор вслепую.
			/// </summary>
			Blind,

			/// <summary>
			/// Режим выбора.
			/// </summary>
			Choice,

			/// <summary>
			/// Случайные чемпионы.
			/// </summary>
			RandomChampions,

			/// <summary>
			/// Выбор для турнира.
			/// </summary>
			Tournament,
		}

		/// <summary>
		/// Выбранная карта.
		/// </summary>
		private Map _selectedMap;

		/// <summary>
		/// Название игры.
		/// </summary>
		private string _title;

		/// <summary>
		/// Выбранный размер команды.
		/// </summary>
		private int _selectedTeamCapacity;

		/// <summary>
		/// Пароль.
		/// </summary>
		private string _password;

		/// <summary>
		/// Выбранный тип.
		/// </summary>
		private int _selectedGameType;

		/// <summary>
		/// Выбранное разрешение наблюдателей.
		/// </summary>
		private int _selectedSpectatorsAllowment;

		/// <summary>
		/// Конструктор VM-компонента.
		/// </summary>
		public CreateCustomVM()
		{
			_selectedMap = Map.SummonersRift;
			MapClickCommand = new PlayMapCommand(this);
			Maps = new Dictionary<Map, object>
			{
				[Map.SummonersRift] = new
				{
					Title = "УЩЕЛЬЕ\nПРИЗЫВАТЕЛЕЙ",
					Description = "",
				},
				[Map.HowlingAbyss] = new
				{
					Title = "ВОЮЩАЯ\nБЕЗДНА",
					Description = "",
				},
			};
			MapRegimes = new Dictionary<Map, List<object>>();
			SelectedRegimes = new ObservableCollection<int>();

			_title = "Игра";
			TeamCapacities = new List<int> { 1, 2, 3, 4, 5 };
			SelectedTeamCapacity = TeamCapacities[0];
			_password = "";

			CustomGameTypes = new Dictionary<CustomGameType, object>
			{
				[CustomGameType.Blind] = new
				{
					Title = "Выбор вслепую",
					Info = "",
				},
				[CustomGameType.Choice] = new
				{
					Title = "Режим выбора",
					Info = "",
				},
				[CustomGameType.RandomChampions] = new
				{
					Title = "Случайные чемпионы",
				Info = "",
			},
				[CustomGameType.Tournament] = new
				{
					Title = "Выбор для турнира",
					Info = "",
				},
			};
			SelectedGameType = 0;

			SpectatorsAllowments = new Dictionary<SpectatorsAllowment, object>
			{
				[SpectatorsAllowment.All] = new
				{
					Title = "Все",
					Info = "",
				},
				[SpectatorsAllowment.Lobby] = new
				{
					Title = "Лобби",
					Info = "",
				},
				[SpectatorsAllowment.FriendsOnly] = new
				{
					Title = "Только из списка друзей",
					Info = "",
				},
				[SpectatorsAllowment.None] = new
				{
					Title = "Нет",
					Info = "",
				},
			};
			SelectedSpectatorsAllowment = 0;
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

		/// <summary>
		/// Название игры.
		/// </summary>
		public string Title
		{
			get => _title;
			set
			{
				_title = value;
				OnPropertyChanged(nameof(Title));
			}
		}

		/// <summary>
		/// Размеры команды.
		/// </summary>
		public List<int> TeamCapacities { get; set; }

		/// <summary>
		/// Выбранный размер команды.
		/// </summary>
		public int SelectedTeamCapacity
		{
			get => _selectedTeamCapacity;
			set
			{
				_selectedTeamCapacity = value;
				OnPropertyChanged(nameof(SelectedTeamCapacity));
			}
		}

		/// <summary>
		/// Пароль.
		/// </summary>
		public string Password
		{
			get => _password;
			set
			{
				_password = value;
				OnPropertyChanged(nameof(Password));
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

		/// <summary>
		/// Именованные типы своей игры.
		/// </summary>
		public Dictionary<CustomGameType, object> CustomGameTypes { get; set; }

		/// <summary>
		/// Выбранный тип.
		/// </summary>
		public int SelectedGameType
		{
			get => _selectedGameType;
			set
			{
				_selectedGameType = value;
				OnPropertyChanged(nameof(SelectedGameType));
			}
		}

		/// <summary>
		/// Именованные разрешения наблюдателей.
		/// </summary>
		public Dictionary<SpectatorsAllowment, object> SpectatorsAllowments { get; set; }

		/// <summary>
		/// Выбранное разрешение наблюдателей.
		/// </summary>
		public int SelectedSpectatorsAllowment
		{
			get => _selectedSpectatorsAllowment;
			set
			{
				_selectedSpectatorsAllowment = value;
				OnPropertyChanged(nameof(SelectedSpectatorsAllowment));
			}
		}

		#region INotifyPropertyChanged
		public event PropertyChangedEventHandler? PropertyChanged;

		private void OnPropertyChanged(string propertyName = "") =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		#endregion
	}
}
