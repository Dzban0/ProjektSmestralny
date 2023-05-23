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
        public MainWindow()
        {
            InitializeComponent();

            string connectionString = "SERVER=localhost;DATABASE=test_db;UID=root;PASSWORD=;";

            projekt connection = new projekt(connectionString);

            projekt cmd = new projekt("select * from test_users", connection);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExcuteReader());
            connection.Close();

            dtGrid.DataContext = dt;

        }
        public void Start()
        {

        }
        public static partial class MyConsoleApp
        {

            private static void StartupMessage()
            {
                ConsoleColor consoleColor = Console.ForegroundColor; // previous color
                StringBuilder sb = new StringBuilder();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                sb.AppendLine("Welcome!");
                sb.AppendLine("In this app you can add Marathon members and compare their times.");
                sb.AppendLine("To do so, you can use the following commands:");
                sb.AppendLine();
                Console.WriteLine(sb);

                Console.ForegroundColor = ConsoleColor.Cyan;
                sb.AppendLine("ADD <Name> <Surname> <Time hh:mm:ss> - adds new entry with a new member");
                sb.AppendLine("DEL <ID> - remove a race member");
                sb.AppendLine("CMP <ID> <ID> - compares two race members");
                sb.AppendLine("LST - list all race members");
                sb.AppendLine("CLS - close the program");
                sb.AppendLine();
                Console.WriteLine(sb);

                Console.ForegroundColor = consoleColor;
            }

            private static void ExitMessage()
            {
                ConsoleColor consoleColor = Console.ForegroundColor; // previous color
                StringBuilder sb = new StringBuilder();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                sb.AppendLine("Quitting...");
                sb.AppendLine();
                Console.WriteLine(sb);

                Console.ForegroundColor = consoleColor;
            }

            private static int NextMovie()
            {
                nextMovie++;
                return nextMovie;
            }
        }
    }
}
