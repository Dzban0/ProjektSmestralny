using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjektSmestralny
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Interaction logic for MainWindow.xaml
        /// </summary>
        public partial class MainWindow : MetroWindow
        {
            public MainWindow()
            {
                InitializeComponent();
            }
        }
        public void Start()
        {

        }
        public static partial class MyConsoleApp
        {
            public static string Films { get; set; }
            public static string Actors { get; set; }
            public static string Movie_Studio { get; set; }




        }
    }
}
