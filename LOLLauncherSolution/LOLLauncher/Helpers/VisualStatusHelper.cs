using LOLLauncher.ViewModels.User_profile_panel;
using System.Windows;

namespace LOLLauncher.Helpers
{
    /// <summary>
    /// В помощь с работой с отображением статусов.
    /// </summary>
    public static class VisualStatusHelper
    {
        public static DependencyProperty StatusProperty = DependencyProperty.RegisterAttached(
            "Status",
            typeof(UserProfilePanelVM.Statuses),
            typeof(VisualStatusHelper));

        public static UserProfilePanelVM.Statuses GetStatus(DependencyObject dependency) =>
            (UserProfilePanelVM.Statuses)dependency.GetValue(StatusProperty);

        public static void SetStatus(DependencyObject dependency, UserProfilePanelVM.Statuses value) =>
            dependency.SetValue(StatusProperty, value);
    }
}
