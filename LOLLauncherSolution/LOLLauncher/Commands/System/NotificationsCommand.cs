using System;
using System.Windows.Input;

namespace LOLLauncher.Commands.System
{
	/// <summary>
	/// Команда для отображения уведомлений.
	/// </summary>
	public class NotificationsCommand : ICommand
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
