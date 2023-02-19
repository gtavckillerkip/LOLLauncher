using System.Windows.Controls;

namespace LOLLauncher.Views.The_biggest_area.Contents.Home_content
{
    /// <summary>
    /// Логика взаимодействия для HomeContent.xaml
    /// </summary>
    public partial class HomeContent : UserControl
    {
        private static HomeContent? instance = null;

        private HomeContent()
        {
            InitializeComponent();
        }

        public static HomeContent GetInstance()
        {
            return instance ??= new HomeContent();
        }
    }
}
