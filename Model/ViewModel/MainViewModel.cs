using ProjektSmestralny.Core;
using ProjektSmestralny.Model.ViewModel;
using ProjektSmestralny.Model.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSmestralny.Model.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public HomeViewModel HomeVm { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                 _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
        }

        // public static string? Films { get; set; }
        // public static string? Actors { get; set; }
        // public static string? Movie_Studio { get; set; }
        // public static string? Category { get; set; }

    }
}
