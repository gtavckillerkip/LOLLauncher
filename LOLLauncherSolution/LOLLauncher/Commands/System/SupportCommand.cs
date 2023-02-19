using System;
using System.Windows.Input;

namespace LOLLauncher.Commands.System
{
	/// <summary>
	/// Команда, перенаправляющая на раздел поддержки.
	/// </summary>
	public class SupportCommand : ICommand
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
