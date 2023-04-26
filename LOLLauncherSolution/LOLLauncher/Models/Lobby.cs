using LOLLauncher.Common.Enums;

namespace LOLLauncher.Models
{
    /// <summary>
    /// Игровое лобби.
    /// </summary>
    public class Lobby
    {
		/// <summary>
		/// Конструктор лобби.
		/// </summary>
		/// <param name="name"> Название лобби. </param>
		/// <param name="owner"> Имя владельца. </param>
		/// <param name="map"> Карта. </param>
		/// <param name="playersCapacity"> Максимум игроков. </param>
		/// <param name="spectatorsAllowment"> Разрешение наблюдателей. </param>
		/// <param name="isClosed"> Лобби закрытое. </param>
		public Lobby(string name, string owner, Map map, int playersCapacity, SpectatorsAllowment spectatorsAllowment, bool isClosed)
        {
            Name = name;
            OwnerName = owner;
            Map = map;
            PlayersCapacity = playersCapacity;
            CurrentPlayersAmount = 1;
            SpectatorsAllowment = spectatorsAllowment;
            IsClosed = isClosed;
        }

        /// <summary>
        /// Название лобби.
        /// </summary>
        public string Name { get; init; }

        /// <summary>
        /// Имя владельца.
        /// </summary>
        public string OwnerName { get; set; }

        /// <summary>
        /// Карта.
        /// </summary>
        public Map Map { get; set; }

        /// <summary>
        /// Максимум игроков.
        /// </summary>
        public int PlayersCapacity { get; set; }

        /// <summary>
        /// Текущее число игроков.
        /// </summary>
        public int CurrentPlayersAmount { get; set; }

        /// <summary>
        /// Разрешение наблюдателей.
        /// </summary>
        public SpectatorsAllowment SpectatorsAllowment { get; set; }

        /// <summary>
        /// Лобби закрытое.
        /// </summary>
        public bool IsClosed { get; set; }
    }
}
