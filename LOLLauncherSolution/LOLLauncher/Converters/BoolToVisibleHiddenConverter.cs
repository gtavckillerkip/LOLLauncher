﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace LOLLauncher.Converters
{
    public class BoolToVisibleHiddenConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? Visibility.Visible : Visibility.Hidden;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new object();
        }
    }
}
