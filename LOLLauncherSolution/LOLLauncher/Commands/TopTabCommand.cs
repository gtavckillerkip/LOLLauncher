using LOLLauncher.ViewModels.Top_panel;
using System;
using System.Windows.Input;

namespace LOLLauncher.Commands
{
	/// <summary>
	/// Команда, обрабатывающая нажатие на кнопку верхней панели.
	/// </summary>
	public class TopTabCommand : ICommand
	{
		/// <summary>
		/// VM-компонент набора верхних кнопок.
		/// </summary>
		private readonly TopTabsVM _topButtonsVM;

		/// <summary>
		/// Конструктор команды.
		/// </summary>
		/// <param name="topTabsVM"> VM-компонент набора верхних кнопок. </param>
		public TopTabCommand(TopTabsVM topTabsVM)
		{
			_topButtonsVM = topTabsVM;
		}

		public event EventHandler? CanExecuteChanged;

		public bool CanExecute(object? parameter)
		{
			return true;
		}

		public void Execute(object? parameter)
		{
			var clicked = (TopTabsVM.MainButtons)Enum.Parse(typeof(TopTabsVM.MainButtons), parameter!.ToString()!);
			if (_topButtonsVM.ChosenButton != clicked)
			{
				_topButtonsVM.ChosenButton = clicked;
			}
		}
	}
}
