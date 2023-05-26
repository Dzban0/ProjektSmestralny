using MahApps.Metro.Controls;

namespace ProjektSmestralny
{
    public partial class MainWindow : MetroWindow
    {
        /// <summary>
        /// Interaction logic for MainWindow.xaml
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

    }
}
