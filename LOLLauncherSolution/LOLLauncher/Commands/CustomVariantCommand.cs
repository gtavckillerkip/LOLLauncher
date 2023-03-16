using LOLLauncher.ViewModels.The_biggest_area.Play_content.Custom;
using System;
using System.Windows.Input;

namespace LOLLauncher.Commands
{
	/// <summary>
	/// Команда для работы с вариантами взаимодействия со своей игрой.
	/// </summary>
	class CustomVariantCommand : ICommand
    {
		/// <summary>
		/// VM-компонент содержимого, связанного с кнопкой "Своя игра".
		/// </summary>
		private readonly CustomVM _customVM;

		/// <summary>
		/// Конструктор команды.
		/// </summary>
		/// <param name="customVM"> VM-компонент содержимого, связанного с кнопкой "Играть". </param>
		public CustomVariantCommand(CustomVM customVM)
		{
			_customVM = customVM;
		}

		public event EventHandler? CanExecuteChanged;

		public bool CanExecute(object? parameter)
		{
			return true;
		}

		public void Execute(object? parameter)
		{
			var clicked = (CustomVM.CustomVariant)Enum.Parse(typeof(CustomVM.CustomVariant), parameter!.ToString()!);
			if (_customVM.ChosenVariant != clicked)
			{
				_customVM.ChosenVariant = clicked;
			}
		}
	}
}
