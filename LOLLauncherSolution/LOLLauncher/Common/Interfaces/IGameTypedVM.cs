using LOLLauncher.Common.Enums;
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
		/// Команда нажатия на кнопку с картой.
		/// </summary>
		ICommand MapClickCommand { get; set; }
    }
}
