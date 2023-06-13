using ProjektSmestralny.Model.ViewModel;
using ProjektSmestralny.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MovieCatalog
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        MovieViewModel MovieVM;
        Frame Frame;
        public AddPage()
        {
            InitializeComponent();
        }

        public AddPage(Frame frame1, MovieViewModel movieVM)
        {
            InitializeComponent();
            this.Frame = frame1;
            this.MovieVM = movieVM;
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            duration_TBox.Text = "";
            duration_TBox.FontStyle = FontStyles.Normal;
            duration_TBox.FontWeight = FontWeights.Normal;
        }

        private void Title_TBox_GotFocus(object sender, RoutedEventArgs e)
        {
            Title_TBox.Text = "";
            Title_TBox.FontStyle = FontStyles.Normal;
            Title_TBox.FontWeight = FontWeights.Normal;
        }

        private void Genre_TBox_GotFocus(object sender, RoutedEventArgs e)
        {
            Genre_TBox.Text = "";
            Genre_TBox.FontStyle = FontStyles.Normal;
            Genre_TBox.FontWeight = FontWeights.Normal;
        }

        private void ReleaseYear_TBox_GotFocus(object sender, RoutedEventArgs e)
        {
            ReleaseYear_TBox.Text = "";
            ReleaseYear_TBox.FontStyle = FontStyles.Normal;
            ReleaseYear_TBox.FontWeight = FontWeights.Normal;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Films movie = new Films();
            movie.Title = Title_TBox.Text;
            movie.ReleaseYear = int.Parse(ReleaseYear_TBox.Text);
            movie.Genre = Genre_TBox.Text;
            movie.Duration = int.Parse(duration_TBox.Text);

            MovieVM.AddRecordToRepo(movie);
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.NavigationService.GoBack();
        }
    }
}
