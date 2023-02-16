using LOLLauncher.ViewModels.Top_panel;
using System;
using System.Windows;
using System.Windows.Input;

namespace LOLLauncher.Commands
{
	public class TopButtonClickCommand : ICommand
	{
		/// <summary>
		/// VM-компонент набора верхних кнопок.
		/// </summary>
		private readonly TopButtonsVM _topButtonsVM;

		/// <summary>
		/// Конструктор команды.
		/// </summary>
		/// <param name="topButtonsVM"> VM-компонент набора верхних кнопок. </param>
		public TopButtonClickCommand(TopButtonsVM topButtonsVM)
		{
			_topButtonsVM = topButtonsVM;
		}

		public event EventHandler? CanExecuteChanged;

		public bool CanExecute(object? parameter)
		{
			return true;
		}

		public void Execute(object? parameter)
		{
			var clicked = (TopButtonsVM.MainButtons)Enum.Parse(typeof(TopButtonsVM.MainButtons), parameter!.ToString()!);
			if (_topButtonsVM.ChosenButton != clicked)
			{
				_topButtonsVM.ChosenButton = clicked;
			}
		}
	}
}
