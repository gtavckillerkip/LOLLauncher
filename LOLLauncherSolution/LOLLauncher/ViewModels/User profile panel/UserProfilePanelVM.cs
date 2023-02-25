using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace LOLLauncher.ViewModels.User_profile_panel
{
	/// <summary>
	/// VM-компонент панели профиля.
	/// </summary>
    public class UserProfilePanelVM : INotifyPropertyChanged
    {
		/// <summary>
		/// Статусы.
		/// </summary>
		public enum Statuses
		{
			/// <summary>
			/// В сети.
			/// </summary>
			Online,

			/// <summary>
			/// Не в сети.
			/// </summary>
			Offline,

			/// <summary>
			/// Отошёл.
			/// </summary>
			AFK,

			/// <summary>
			/// В очереди.
			/// </summary>
			Queue,

			/// <summary>
			/// Выбирает чемпиона.
			/// </summary>
			Picking,

			/// <summary>
			/// В игре.
			/// </summary>
			Playing,
		}

		/// <summary>
		/// Соответствия статусов сообщениям.
		/// </summary>
		public static Dictionary<Statuses, string> StatusesToStringDictionary = new Dictionary<Statuses, string>
		{
			[Statuses.Online]	= "В сети",
			[Statuses.Offline]	= "Не в сети",
			[Statuses.AFK]		= "Отсутствует",
			[Statuses.Queue]	= "В очереди",
			[Statuses.Picking]	= "Выбирает чемпиона",
			[Statuses.Playing]	= "В игре",
		};

		/// <summary>
		/// Словарь доступных иконок профиля.
		/// </summary>
		public static Dictionary<int, string> AvailableIconIdToURIDictionary = new Dictionary<int, string>
		{
			[1] = "/LOLLauncher;component/Resources/Pictures/Icons/Seraphine_Icon_T1.jpg",
			[2] = "/LOLLauncher;component/Resources/Pictures/Icons/Seraphine_Icon_T3.jpg",
		};

		/// <summary>
		/// Ник.
		/// </summary>
		private string _nickname;

		/// <summary>
		/// Идентификатор иконки профиля.
		/// </summary>
		private int _iconId;

		/// <summary>
		/// Статус.
		/// </summary>
		private Statuses _status;

		/// <summary>
		/// Сообщение в статусе.
		/// </summary>
		private string _statusMessage;

		/// <summary>
		/// Оповещения.
		/// </summary>
		private ObservableCollection<string> _notifications;

		/// <summary>
		/// Конструктор VM-компонента.
		/// </summary>
        public UserProfilePanelVM()
        {
			_nickname = "Nickkkkk";
			_iconId = 1;
			_status = Statuses.Online;
			_statusMessage = StatusesToStringDictionary[_status];
			_notifications = new ObservableCollection<string>();
        }

		/// <summary>
		/// Ник.
		/// </summary>
		public string Nickname
		{
			get => _nickname;
			set
			{
				_nickname = value;
				OnPropertyChanged(nameof(Nickname));
			}
		}

		/// <summary>
		/// Идентификатор иконки профиля.
		/// </summary>
		public int IconId
		{
			get => _iconId;
			set
			{
				_iconId = value;
				OnPropertyChanged(nameof(IconId));
			}
		}

		/// <summary>
		/// Статус.
		/// </summary>
		public Statuses Status
		{
			get => _status;
			set
			{
				_status = value;
				OnPropertyChanged(nameof(Status));
			}
		}

		/// <summary>
		/// Сообщение в статусе.
		/// </summary>
		public string StatusMessage
		{
			get => _statusMessage;
			set
			{
				_statusMessage = value.Length > 0 ? $"\"{value}\"" : StatusesToStringDictionary[Status];
				OnPropertyChanged(nameof(StatusMessage));
			}
		}

		/// <summary>
		/// Оповещения.
		/// </summary>
		public ObservableCollection<string> Notifications
		{
			get => _notifications;
			set
			{
				_notifications = value;
				OnPropertyChanged(nameof(Notifications));
			}
		}

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;

		private void OnPropertyChanged(string propertyName = "") =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		#endregion
	}
}
