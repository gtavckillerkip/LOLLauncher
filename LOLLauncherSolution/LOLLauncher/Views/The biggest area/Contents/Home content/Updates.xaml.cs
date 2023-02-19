using System.Windows.Controls;

namespace LOLLauncher.Views.The_biggest_area.Contents.Home_content
{
    /// <summary>
    /// Логика взаимодействия для Updates.xaml
    /// </summary>
    public partial class Updates : UserControl
    {
        private static Updates? _instance = null;

        private Updates()
        {
            InitializeComponent();
        }

        public static Updates GetInstance()
        {
            return _instance ??= new Updates();
        }
    }
}
