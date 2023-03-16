using System.Windows;

namespace LOLLauncher.Helpers
{
    /// <summary>
    /// Вспомогательный класс для работы с кнопками.
    /// </summary>
    public static class ButtonsHelper
    {
        /// <summary>
        /// Выбрана ли кнопка.
        /// </summary>
        public static DependencyProperty IsSelectedProperty = DependencyProperty.RegisterAttached(
            "IsSelected",
            typeof(bool),
            typeof(ButtonsHelper));

        public static bool GetIsSelected(DependencyObject dependency) =>
            (bool)dependency.GetValue(IsSelectedProperty);

        public static void SetIsSelected(DependencyObject dependency, bool value) =>
            dependency.SetValue(IsSelectedProperty, value);

		/// <summary>
		/// Наведена ли мышь на соответствующую описанию кнопку.
		/// </summary>
        /// <remarks>
        /// Свойство использовать для текста описания карты.
        /// </remarks>
		public static DependencyProperty IsMouseOverButtonProperty = DependencyProperty.RegisterAttached(
			"IsMouseOverButton",
			typeof(bool),
			typeof(ButtonsHelper));

		public static bool GetIsMouseOverButton(DependencyObject dependency) =>
			(bool)dependency.GetValue(IsMouseOverButtonProperty);

		public static void SetIsMouseOverButton(DependencyObject dependency, bool value) =>
			dependency.SetValue(IsMouseOverButtonProperty, value);
	}
}
