using System.Windows;

namespace LOLLauncher.Helpers
{
    /// <summary>
    /// Вспомогательный класс для работы с кнопками верхней панели.
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
	}
}
