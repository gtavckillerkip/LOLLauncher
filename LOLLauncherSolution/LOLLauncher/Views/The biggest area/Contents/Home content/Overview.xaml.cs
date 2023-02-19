using System.Windows.Controls;

namespace LOLLauncher.Views.The_biggest_area.Contents.Home_content
{
    /// <summary>
    /// Логика взаимодействия для Overview.xaml
    /// </summary>
    public partial class Overview : UserControl
    {
        private static Overview? _instance = null;

        private Overview()
        {
            InitializeComponent();
        }

        public static Overview GetInstance()
        {
            return _instance ??= new Overview();
        }
    }
}
