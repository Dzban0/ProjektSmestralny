using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSmestralny
{
    public class MainViewModel
    {
        private DataTable _dataTable = new DataTable();



        public void Start()
        {

        }
        public static string Films { get; set; }
        public static string Actors { get; set; }
        public static string Movie_Studio { get; set; }
        public static string Category { get; set; }

    }
}
