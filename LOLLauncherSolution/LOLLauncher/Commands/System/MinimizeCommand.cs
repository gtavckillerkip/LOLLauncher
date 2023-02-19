using System;
using System.Windows.Input;

namespace LOLLauncher.Commands.System
{
	/// <summary>
	/// Команда, чтобы свернуть окно лаунчера.
	/// </summary>
	public class MinimizeCommand : ICommand
	{
		public event EventHandler? CanExecuteChanged;

		public bool CanExecute(object? parameter)
		{
			return true;
		}

		public void Execute(object? parameter)
		{
			// TODO
		}
	}
}
