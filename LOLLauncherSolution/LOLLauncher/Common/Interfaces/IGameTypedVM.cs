using LOLLauncher.Common.Enums;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Windows.Input;

namespace LOLLauncher.Common.Interfaces
{
	/// <summary>
	/// Интерфейс для игр, отличающихся по типу.
	/// </summary>
	public interface IGameTypedVM
	{
		/// <summary>
		/// Выбранная карта.
		/// </summary>
		Map SelectedMap { get; set; }

		/// <summary>
		/// Выбранные режимы на картах.
		/// </summary>
		ObservableCollection<int> SelectedRegimes { get; set; }

		/// <summary>
		/// Команда нажатия на кнопку с картой.
		/// </summary>
		ICommand MapClickCommand { get; set; }

		/// <summary>
		/// Карты, доступные для данного типа игры.
		/// </summary>
		Dictionary<Map, object> Maps { get; set; }

		/// <summary>
		/// Режимы, доступные на картах.
		/// </summary>
		Dictionary<Map, List<object>> MapRegimes { get; set; }
    }
}
