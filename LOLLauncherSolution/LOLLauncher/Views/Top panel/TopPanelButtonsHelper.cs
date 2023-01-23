﻿using System.Windows;

namespace LOLLauncher.Views.Top_panel
{
    /// <summary>
    /// Вспомогательный класс для работы с кнопками верхней панели.
    /// </summary>
    public static class TopPanelButtonsHelper
    {
        public static DependencyProperty IsSelectedProperty = DependencyProperty.RegisterAttached(
            "IsSelected",
            typeof(bool),
            typeof(TopPanelButtonsHelper));

        public static bool GetIsSelected(DependencyObject dependency) =>
            (bool)dependency.GetValue(IsSelectedProperty);

        public static void SetIsSelected(DependencyObject dependency, bool value) =>
            dependency.SetValue(IsSelectedProperty, value);
    }
}
