using LOLLauncher.ViewModels.The_biggest_area.Home_content;
using System;
using System.Windows.Input;

namespace LOLLauncher.Commands
{
	/// <summary>
	/// Команда, обрабатывающая нажатие кнопки на панели вкладок (содержимое под кнопкой "Главная").
	/// </summary>
	public class HomeContentTabCommand : ICommand
	{
		/// <summary>
		/// VM-компонент содержимого, связанного с кнопкой "Главная".
		/// </summary>
		private readonly HomeContentVM _homeContentVM;

		/// <summary>
		/// Конструктор команды.
		/// </summary>
		/// <param name="homeContentVM"> VM-компонент содержимого, связанного с кнопкой "Главная". </param>
		public HomeContentTabCommand(HomeContentVM homeContentVM)
		{
			_homeContentVM = homeContentVM;
		}

		public event EventHandler? CanExecuteChanged;

		public bool CanExecute(object? parameter)
		{
			return true;
		}

		public void Execute(object? parameter)
		{
			var clicked = (HomeContentVM.HomeContentButtons)Enum.Parse(typeof(HomeContentVM.HomeContentButtons), parameter!.ToString()!);
			if (_homeContentVM.ChosenButton != clicked)
			{
				_homeContentVM.ChosenButton = clicked;
			}
		}
	}
}
