using System.Windows;

namespace LOLLauncher.Helpers
{
    public static class NotificationsHelper
    {
        public static DependencyProperty HasAnyNotificationsProperty = DependencyProperty.RegisterAttached(
            "HasAnyNotifications",
            typeof(bool),
            typeof(NotificationsHelper));

        public static bool GetHasAnyNotifications(DependencyObject dependency) =>
            (bool)dependency.GetValue(HasAnyNotificationsProperty);

        public static void SetHasAnyNotifications(DependencyObject dependency, bool value) =>
            dependency.SetValue(HasAnyNotificationsProperty, value);
    }
}
