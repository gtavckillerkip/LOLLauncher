using LOLLauncher.Commands;
using LOLLauncher.Common.Enums;
using LOLLauncher.Common.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace LOLLauncher.ViewModels.The_biggest_area.Play_content.PVP
{
    /// <summary>
    /// VM-компонент PVP игры.
    /// </summary>
    public class PVPVM : INotifyPropertyChanged, IGameTypedVM
    {
        /// <summary>
        /// Выбранная карта.
        /// </summary>
        private Map _selectedMap;

        /// <summary>
        /// Конструктор VM-компонента.
        /// </summary>
        public PVPVM()
        {
            _selectedMap = Map.SummonersRift;
            MapClickCommand = new PlayMapCommand(this);
            Maps = new Dictionary<Map, object>
            {
                [Map.SummonersRift] = new
                {
                    Title = "УЩЕЛЬЕ\nПРИЗЫВАТЕЛЕЙ",
                    Description = "Побеждайте в эпических командных боях пять на пять и уничтожайте вражеский нексус."
                },
                [Map.HowlingAbyss] = new
                {
                    Title = "ARAM",
                    Description = "Десять случайных чемпионов встречаются на мосту в заснеженных землях. Пересеките мост, уничтожая всё на своём пути."
                },
                [Map.TeamfightTactics] = new
                {
                    Title = "TEAMFIGHT\nTACTICS",
                    Description = "Соберите отряд чемпионов, который будет сражаться за вас. Продержитесь в игре дольше семи соперников и станьте последним выжившим."
                },
            };
            MapRegimes = new Dictionary<Map, List<object>>
            {
                [Map.SummonersRift] = new List<object>
                {
                    new { Title = "ВЫБОР ВСЛЕПУЮ", Info = "" },
					new { Title = "РЕЖИМ ВЫБОРА", Info = "" },
					new { Title = "РАНГОВАЯ ОДИНОЧНАЯ/\nПАРНАЯ", Info = "" },
					new { Title = "РАНГОВАЯ ГИБКАЯ", Info = "Группы из 4 игроков отключены" },
				},
                [Map.HowlingAbyss] = new List<object>
                {
                    new { Title = "ARAM", Info = "" },
                },
                [Map.TeamfightTactics] = new List<object>
                {
                    new { Title = "ОБЫЧНАЯ", Info = "" },
					new { Title = "РАНГОВАЯ", Info = "" },
					new { Title = "ВА-БАНК", Info = "" },
					new { Title = "\"ДВОЙНОЙ УДАР\"\n(МАСТЕРСКАЯ)", Info = "" },
				},
            };
            SelectedRegimes = new ObservableCollection<int>
            {
                0,
                0,
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
