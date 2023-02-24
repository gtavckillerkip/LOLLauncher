using LOLLauncher.ViewModels.Top_panel;

namespace LOLLauncher.ViewModels.The_biggest_area
{
    /// <summary>
    /// VM-компонент основной области содержимого.
    /// </summary>
    public class TheBiggestAreaVM
    {
        /// <summary>
        /// Конструктор VM-компонента.
        /// </summary>
        public TheBiggestAreaVM()
        {
            TopTabsVM = TopTabsVM.Instance;
        }

        /// <summary>
        /// VM-компонент панели с верхними кнопками.
        /// </summary>
        public TopTabsVM? TopTabsVM { get; set; }
    }
}
