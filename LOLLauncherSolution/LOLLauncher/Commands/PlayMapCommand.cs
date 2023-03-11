using LOLLauncher.Common.Enums;
using LOLLauncher.Common.Interfaces;
using LOLLauncher.ViewModels.The_biggest_area.Play_content.PVP;
using System;
using System.Windows.Input;

namespace LOLLauncher.Commands
{
	/// <summary>
	/// Команда, обрабатывающая нажатие кнопки карты.
	/// </summary>
	public class PlayMapCommand : ICommand
	{
		/// <summary>
		/// VM-компонент содержимого, связанного с типом игры.
		/// </summary>
		private readonly IGameTypedVM _gameTypedVM;

		/// <summary>
		/// Конструктор команды.
		/// </summary>
		/// <param name="gameTypedVM"> VM-компонент содержимого, связанного с типом игры. </param>
		public PlayMapCommand(IGameTypedVM gameTypedVM)
		{
			_gameTypedVM = gameTypedVM;
		}

		public event EventHandler? CanExecuteChanged;

		public bool CanExecute(object? parameter)
		{
			return true;
		}

		public void Execute(object? parameter)
		{
			var clicked = (Map)Enum.Parse(typeof(Map), parameter!.ToString()!);
			if (_gameTypedVM.SelectedMap != clicked)
			{
				_gameTypedVM.SelectedMap = clicked;
			}
		}
	}
}
