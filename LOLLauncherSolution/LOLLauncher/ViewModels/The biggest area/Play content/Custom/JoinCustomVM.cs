using LOLLauncher.Commands;
using LOLLauncher.Common.Enums;
using LOLLauncher.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace LOLLauncher.ViewModels.The_biggest_area.Play_content.Custom
{
	/// <summary>
	/// VM-компонент страницы присоединения к своей игре.
	/// </summary>
	public class JoinCustomVM : INotifyPropertyChanged
	{
		/// <summary>
		/// Название игры для поиска.
		/// </summary>
		private string _searchGameName;

		/// <summary>
		/// Сортировка списка лобби по названию.
		/// </summary>
		private SortDirection _sortedByName;

		/// <summary>
		/// Сортировка списка лобби по имени владельца.
		/// </summary>
		private SortDirection _sortedByOwner;

		/// <summary>
		/// Сортировка списка лобби по названию карты.
		/// </summary>
		private SortDirection _sortedByMap;

		/// <summary>
		/// Конструктор VM-компонента.
		/// </summary>
        public JoinCustomVM()
        {
			_searchGameName = "";
			SpectatorsAllowmentCheckBoxContent = "Допускаются наблюдатели";
			OnlyClosedLobbiesCheckBoxContent = "Показать только закрытые лобби";

			Lobbies = new ObservableCollection<Lobby>
			{
				new Lobby("Игра MAMINNAGIBATOR3000", "MAMINNAGIBATOR3000", Map.SummonersRift, 10, SpectatorsAllowment.All, false),
				new Lobby("Игра DRUGNAGIBATORA3000", "DRUGNAGIBATORA3000", Map.SummonersRift, 10, SpectatorsAllowment.Lobby, false),
				new Lobby("Игра MUZHNAGIBATORA3000", "MUZHNAGIBATORA3000", Map.HowlingAbyss, 2, SpectatorsAllowment.None, true),
                new Lobby("Игра MAMINNAGIBATOR3000", "MAMINNAGIBATOR3000", Map.SummonersRift, 10, SpectatorsAllowment.All, false),
                new Lobby("Игра DRUGNAGIBATORA3000", "DRUGNAGIBATORA3000", Map.SummonersRift, 10, SpectatorsAllowment.Lobby, false),
                new Lobby("Игра MUZHNAGIBATORA3000", "MUZHNAGIBATORA3000", Map.HowlingAbyss, 2, SpectatorsAllowment.None, true),
                new Lobby("Игра MAMINNAGIBATOR3000", "MAMINNAGIBATOR3000", Map.SummonersRift, 10, SpectatorsAllowment.All, false),
                new Lobby("Игра DRUGNAGIBATORA3000", "DRUGNAGIBATORA3000", Map.SummonersRift, 10, SpectatorsAllowment.Lobby, false),
                new Lobby("Игра MUZHNAGIBATORA3000", "MUZHNAGIBATORA3000", Map.HowlingAbyss, 2, SpectatorsAllowment.None, true),
                new Lobby("Игра MAMINNAGIBATOR3000", "MAMINNAGIBATOR3000", Map.SummonersRift, 10, SpectatorsAllowment.All, false),
                new Lobby("Игра DRUGNAGIBATORA3000", "DRUGNAGIBATORA3000", Map.SummonersRift, 10, SpectatorsAllowment.Lobby, false),
                new Lobby("Игра MUZHNAGIBATORA3000", "MUZHNAGIBATORA3000", Map.HowlingAbyss, 2, SpectatorsAllowment.None, true),
                new Lobby("Игра MAMINNAGIBATOR3000", "MAMINNAGIBATOR3000", Map.SummonersRift, 10, SpectatorsAllowment.All, false),
                new Lobby("Игра DRUGNAGIBATORA3000", "DRUGNAGIBATORA3000", Map.SummonersRift, 10, SpectatorsAllowment.Lobby, false),
                new Lobby("Игра MUZHNAGIBATORA3000", "MUZHNAGIBATORA3000", Map.HowlingAbyss, 2, SpectatorsAllowment.None, true),
                new Lobby("Игра MAMINNAGIBATOR3000", "MAMINNAGIBATOR3000", Map.SummonersRift, 10, SpectatorsAllowment.All, false),
                new Lobby("Игра DRUGNAGIBATORA3000", "DRUGNAGIBATORA3000", Map.SummonersRift, 10, SpectatorsAllowment.Lobby, false),
                new Lobby("Игра MUZHNAGIBATORA3000", "MUZHNAGIBATORA3000", Map.HowlingAbyss, 2, SpectatorsAllowment.None, true),
                new Lobby("Игра MAMINNAGIBATOR3000", "MAMINNAGIBATOR3000", Map.SummonersRift, 10, SpectatorsAllowment.All, false),
                new Lobby("Игра DRUGNAGIBATORA3000", "DRUGNAGIBATORA3000", Map.SummonersRift, 10, SpectatorsAllowment.Lobby, false),
                new Lobby("Игра MUZHNAGIBATORA3000", "MUZHNAGIBATORA3000", Map.HowlingAbyss, 2, SpectatorsAllowment.None, true),
                new Lobby("Игра MAMINNAGIBATOR3000", "MAMINNAGIBATOR3000", Map.SummonersRift, 10, SpectatorsAllowment.All, false),
                new Lobby("Игра DRUGNAGIBATORA3000", "DRUGNAGIBATORA3000", Map.SummonersRift, 10, SpectatorsAllowment.Lobby, false),
                new Lobby("Игра MUZHNAGIBATORA3000", "MUZHNAGIBATORA3000", Map.HowlingAbyss, 2, SpectatorsAllowment.None, true),
                new Lobby("Игра MAMINNAGIBATOR3000", "MAMINNAGIBATOR3000", Map.SummonersRift, 10, SpectatorsAllowment.All, false),
                new Lobby("Игра DRUGNAGIBATORA3000", "DRUGNAGIBATORA3000", Map.SummonersRift, 10, SpectatorsAllowment.Lobby, false),
                new Lobby("Игра MUZHNAGIBATORA3000", "MUZHNAGIBATORA3000", Map.HowlingAbyss, 2, SpectatorsAllowment.None, true),
            };

			_sortedByName = SortDirection.None;
			_sortedByOwner = SortDirection.None;
			_sortedByMap = SortDirection.None;

			SortByNameButtonContent = "НАЗВАНИЕ ЛОББИ";
			SortByOwnerButtonContent = "ВЛАДЕЛЕЦ";
			SortByMapButtonContent = "КАРТА";

			CustomGameSortButtonCommand = new CustomGameSortButtonCommand(this);
		}

		/// <summary>
		/// Название игры для поиска.
		/// </summary>
		public string SearchGameName
		{
			get => _searchGameName;
			set
			{
				_searchGameName = value;
				OnPropertyChanged(nameof(SearchGameName));
			}
		}

		/// <summary>
		/// Надпись на CheckBox разрешения наблюдателей.
		/// </summary>
		public string SpectatorsAllowmentCheckBoxContent { get; set; }

		/// <summary>
		/// Надпись на CheckBox закрытых лобби.
		/// </summary>
		public string OnlyClosedLobbiesCheckBoxContent { get; set; }

		/// <summary>
		/// Список лобби.
		/// </summary>
		public ObservableCollection<Lobby> Lobbies { get; set; }

		/// <summary>
		/// Сортировка списка лобби по названию.
		/// </summary>
		public SortDirection SortedByName
		{
			get => _sortedByName;
			set
			{
				_sortedByName = value;
				OnPropertyChanged(nameof(SortedByName));
			}
		}

		/// <summary>
		/// Сортировка списка лобби по имени владельца.
		/// </summary>
		public SortDirection SortedByOwner
		{
			get => _sortedByOwner;
			set
			{
				_sortedByOwner = value;
				OnPropertyChanged(nameof(SortedByOwner));
			}
		}

		/// <summary>
		/// Сортировка списка лобби по названию карты.
		/// </summary>
		public SortDirection SortedByMap
		{
			get => _sortedByMap;
			set
			{
				_sortedByMap = value;
				OnPropertyChanged(nameof(SortedByMap));
			}
		}

		/// <summary>
		/// Команда сортировки списка лобби.
		/// </summary>
		public CustomGameSortButtonCommand CustomGameSortButtonCommand { get; set; }

		/// <summary>
		/// Надпись кнопки сортировки по названию.
		/// </summary>
		public string SortByNameButtonContent { get; set; }

		/// <summary>
		/// Надпись кнопки сортировки по имени владельца.
		/// </summary>
		public string SortByOwnerButtonContent { get; set; }

		/// <summary>
		/// Надпись кнопки сортировки по названию карты.
		/// </summary>
		public string SortByMapButtonContent { get; set; }

		#region INotifyPropertyChanged
		public event PropertyChangedEventHandler? PropertyChanged;

		private void OnPropertyChanged(string propertyName = "") =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		#endregion
	}
}
