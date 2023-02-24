using LOLLauncher.ViewModels.The_biggest_area.Play_content;
using System;
using System.Windows.Input;

namespace LOLLauncher.Commands
{
	/// <summary>
	/// Команда, обрабатывающая нажатие кнопки на панели вкладок (содержимое под кнопкой "Играть").
	/// </summary>
	public class PlayContentTabCommand : ICommand
	{
		/// <summary>
		/// VM-компонент содержимого, связанного с кнопкой "Играть".
		/// </summary>
		private readonly PlayContentVM _playContentVM;

		/// <summary>
		/// Конструктор команды.
		/// </summary>
		/// <param name="playContentVM"> VM-компонент содержимого, связанного с кнопкой "Играть". </param>
		public PlayContentTabCommand(PlayContentVM playContentVM)
		{
			_playContentVM = playContentVM;
		}

		public event EventHandler? CanExecuteChanged;

		public bool CanExecute(object? parameter)
		{
			return true;
		}

		public void Execute(object? parameter)
		{
			var clicked = (PlayContentVM.PlayContentButtons)Enum.Parse(typeof(PlayContentVM.PlayContentButtons), parameter!.ToString()!);
			if (_playContentVM.ChosenButton != clicked)
			{
				_playContentVM.ChosenButton = clicked;
			}
		}
	}
}
