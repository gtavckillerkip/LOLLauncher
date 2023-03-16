using LOLLauncher.Commands;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Input;

namespace LOLLauncher.ViewModels.The_biggest_area.Play_content.Custom
{
	/// <summary>
	/// VM-компонент своей игры.
	/// </summary>
    public class CustomVM : INotifyPropertyChanged
    {
		/// <summary>
		/// Варианты взаимодействия со своей игрой.
		/// </summary>
        public enum CustomVariant
        {
			/// <summary>
			/// Начальный.
			/// </summary>
			Base,

			/// <summary>
			/// Создать свою игру.
			/// </summary>
			CreateCustom,

			/// <summary>
			/// Присоединиться к своей игре.
			/// </summary>
			JoinCustom,
		}

		/// <summary>
		/// Выбранный вариант.
		/// </summary>
		private CustomVariant _chosenVariant;

		/// <summary>
		/// Конструктор VM-компонента.
		/// </summary>
        public CustomVM()
        {
            ChosenVariant = CustomVariant.Base;
			ClickCommand = new CustomVariantCommand(this);
			CustomVariantsDescriptions = new Dictionary<CustomVariant, object>
			{
				[CustomVariant.CreateCustom] = new
				{
					Title = "СОЗДАТЬ\nСВОЮ ИГРУ",
					Description = "Создавайте лобби, приглашайте друзей и добавляйте ботов.",
				},
				[CustomVariant.JoinCustom] = new
				{
					Title = "ПРИСОЕДИНИТЬСЯ\nК СВОЕЙ ИГРЕ",
					Description = "Присоединяйтесь к созданным другими игроками играм или просто наблюдайте.",
				},
			};
        }

		/// <summary>
		/// Выбранный вариант.
		/// </summary>
		public CustomVariant ChosenVariant
		{
			get => _chosenVariant;
			set
			{
				_chosenVariant = value;
				OnPropertyChanged(nameof(ChosenVariant));
			}
		}

		/// <summary>
		/// Команда обработки нажатия на один из вариантов.
		/// </summary>
		public ICommand ClickCommand { get; set; }

		/// <summary>
		/// Описания вариантов.
		/// </summary>
		public Dictionary<CustomVariant, object> CustomVariantsDescriptions { get; set; }

		#region INotifyPropertyChanged
		public event PropertyChangedEventHandler? PropertyChanged;

		private void OnPropertyChanged(string propertyName = "") =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		#endregion
	}
}
