/*
 * Matthew Huizar
 * ITSE 1430
 * 11/20/2017
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib.Data.Sql
{
    /// <summary>Provides an implementation of <see cref="IMovieDatabase"/> using SQL Server.</summary>
    public class SqlMovieDatabase : IMovieDatabase
    {
        #region Construction

        public SqlMovieDatabase( string connectionString )
        {
            _connectionString = connectionString;
        }

        private readonly string _connectionString;
        #endregion

        public Movie Add( Movie movie )
        {
            var id = 0;
            using (var conn = OpenDatabase())
            {
                var cmd = new SqlCommand("AddMovie", conn) { CommandType = CommandType.StoredProcedure };

                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = movie.Title;
                cmd.Parameters.AddWithValue("@description", movie.Description);
                cmd.Parameters.AddWithValue("@length", movie.Length);
                cmd.Parameters.AddWithValue("@isOwned", movie.IsOwned);

                id = Convert.ToInt32(cmd.ExecuteScalar());
            };

            return Get(id);
        }

        public Movie Get( int id )
        {
            using (var conn = OpenDatabase())
            {
                var cmd = new SqlCommand("GetMovie", conn) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@id", id);

                var ds = new DataSet();
                var da = new SqlDataAdapter() {
                    SelectCommand = cmd
                };

                da.Fill(ds);

                var table = ds.Tables.OfType<DataTable>().FirstOrDefault();
                if (table != null)
                {
                    var row = table.AsEnumerable().FirstOrDefault();
                    if (row != null)
                    {
                        return new Movie() {
                            Id = Convert.ToInt32(row["Id"]),
                            Title = row.Field<string>("Title"),
                            Description = row.Field<string>("Description"),
                            Length = row.Field<int>("Length"),
                            IsOwned = row.Field<bool>("IsOwned")
                        };
                    };
                };
            };

            return null;
        }

        public IEnumerable<Movie> GetAll()
        {
            var movies = new List<Movie>();
            using (var connection = OpenDatabase())
            {
                var cmd = new SqlCommand("GetAllMovies", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var movie = new Movie() {
                            Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                            Title = reader.GetFieldValue<string>(1),
                            Length = reader.GetInt32(3),
                            Description = reader.GetString(2),
                            IsOwned = reader.GetBoolean(4)
                        };
                        movies.Add(movie);
                    };
                };
                return movies;
            };
        }

        public void Remove( int id )
        {
            using (var conn = OpenDatabase())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "RemoveMovie";
                cmd.CommandType = CommandType.StoredProcedure;

                var parameter = new SqlParameter("@id", id);
                cmd.Parameters.Add(parameter);

                cmd.ExecuteNonQuery();
            };
        }

        public Movie Update( Movie movie )
        {
            using (var conn = OpenDatabase())
            {
                var cmd = new SqlCommand("UpdateMovie", conn) { CommandType = CommandType.StoredProcedure };

                cmd.Parameters.AddWithValue("@id", movie.Id);
                cmd.Parameters.AddWithValue("@title", movie.Title);
                cmd.Parameters.AddWithValue("@description", movie.Description);
                cmd.Parameters.AddWithValue("@length", movie.Length);
                cmd.Parameters.AddWithValue("@isOwned", movie.IsOwned);

                cmd.ExecuteNonQuery();
            };

            return Get(movie.Id);
        }

        private SqlConnection OpenDatabase()
        {
            var connection = new SqlConnection(_connectionString);

            connection.Open();

            return connection;
        }
    }
}
