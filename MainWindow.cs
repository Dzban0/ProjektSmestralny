using MahApps.Metro.Controls;

namespace ProjektSmestralny
{
    public partial class MainWindow
    {
        /// <summary>
        /// Interaction logic for MainWindow.xaml
        /// </summary>
        public partial class MainWindow : MetroWindow
        {
            public MainWindow()
            {
                InitializeComponent();
                DataContext = new MainViewModel();
            }
        }
    }
}
