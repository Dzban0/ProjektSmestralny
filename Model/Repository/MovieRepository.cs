using ProjektSmestralny.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ProjektSmestralny.Model.Repository
{
    public class MovieRepository
    {
        public List<Films> movieRepository { get; set; }

        public MovieRepository()
        {
            movieRepository = GetMovieRepo();
        }

        public List<Films> GetMovieRepo()
        {
            List<Films> listOfMovies = new List<Films>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString))
            {
                if (conn == null)
                {
                    throw new Exception("Connection String is Null. Set the value of Connection String in MovieCatalog->Properties-?Settings.settings");
                }

                SqlCommand query = new SqlCommand("SELECT * from Movie", conn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    Films m = new Films();
                    m.Id = (int)row["id"];
                    m.Title = row["Title"].ToString();
                    m.ReleaseYear = (int)row["ReleaseYear"];
                    m.Genre = row["Genre"].ToString();
                    m.Duration = (int)row["Duration"];

                    listOfMovies.Add(m);
                }

                return listOfMovies;
            }
        }

        public List<Films> GetMovieRepoSearch(string searchQuery)
        {
            List<Films> listOfMovies = new List<Films>();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString))
            {
                if (conn == null)
                {
                    throw new Exception("Connection String is Null. Set the value of Connection String in MovieCatalog->Properties-?Settings.settings");
                }
                SqlCommand query = new SqlCommand("retRecords", conn);
                conn.Open();
                query.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("TitlePhrase", SqlDbType.VarChar);
                param.Value = searchQuery;
                query.Parameters.Add(param);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    Films z = new Films();
                    z.Id = (int)row["id"];
                    z.Title = row["Title"].ToString();
                    z.ReleaseYear = (int)row["ReleaseYear"];
                    z.Genre = row["Genre"].ToString();
                    z.Duration = (int)row["Duration"];
                    listOfMovies.Add(z);
                }
                return listOfMovies;
            }
        }

        public void addNewRecord(Films movieRecord)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString))
            {
                if (conn == null)
                {
                    throw new Exception("Connection String is Null. Set the value of Connection String in MovieCatalog->Properties-?Settings.settings");
                }
                else if (movieRecord == null)
                    throw new Exception("The passed argument 'movieRecord' is null");

                SqlCommand query = new SqlCommand("addRecord", conn);
                conn.Open();
                query.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("pTitle", SqlDbType.VarChar);
                SqlParameter param2 = new SqlParameter("pReleaseYear", SqlDbType.Int);
                SqlParameter param3 = new SqlParameter("pGenre", SqlDbType.VarChar);
                SqlParameter param4 = new SqlParameter("pDuration", SqlDbType.Int);

                param1.Value = movieRecord.Title;
                param2.Value = movieRecord.ReleaseYear;
                param3.Value = movieRecord.Genre;
                param4.Value = movieRecord.Duration;

                query.Parameters.Add(param1);
                query.Parameters.Add(param2);
                query.Parameters.Add(param3);
                query.Parameters.Add(param4);

                query.ExecuteNonQuery();
            }
        }

        public void DelRecord(int id)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString))
            {
                if (conn == null)
                {
                    throw new Exception("Connection String is Null. Set the value of Connection String in MovieCatalog->Properties-?Settings.settings");
                }

                SqlCommand query = new SqlCommand("deleteRecord", conn);
                conn.Open();
                query.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("pId", SqlDbType.Int);
                param1.Value = id;
                query.Parameters.Add(param1);

                query.ExecuteNonQuery();
            }
        }

        public void UpdateRecord(Films movieRecord)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString))
            {
                if (conn == null)
                {
                    throw new Exception("Connection String is Null. Set the value of Connection String in MovieCatalog->Properties-?Settings.settings");
                }

                SqlCommand query = new SqlCommand("updateRecord", conn);
                conn.Open();
                query.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("pId", SqlDbType.Int);
                SqlParameter param2 = new SqlParameter("pTitle", SqlDbType.VarChar);
                SqlParameter param3 = new SqlParameter("pReleaseYear", SqlDbType.Int);
                SqlParameter param4 = new SqlParameter("pGenre", SqlDbType.VarChar);
                SqlParameter param5 = new SqlParameter("pDuration", SqlDbType.Int);

                param1.Value = movieRecord.Id;
                param2.Value = movieRecord.Title;
                param3.Value = movieRecord.ReleaseYear;
                param4.Value = movieRecord.Genre;
                param5.Value = movieRecord.Duration;

                query.Parameters.Add(param1);
                query.Parameters.Add(param2);
                query.Parameters.Add(param3);
                query.Parameters.Add(param4);
                query.Parameters.Add(param5);

                query.ExecuteNonQuery();
            }
        }
    }
}
