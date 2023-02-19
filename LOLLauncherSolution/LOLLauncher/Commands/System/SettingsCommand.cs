using System;
using System.Windows.Input;

namespace LOLLauncher.Commands.System
{
	/// <summary>
	/// Команда вызова настроек.
	/// </summary>
	public class SettingsCommand : ICommand
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
