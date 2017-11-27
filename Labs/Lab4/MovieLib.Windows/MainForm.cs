/*
 * Matthew Huizar
 * ITSE 1430
 * 11/20/2017
 */
using System;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using MovieLib.Data;

namespace MovieLib.Windows
{
    public partial class MainForm : Form 
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);
            
            var connString = ConfigurationManager.ConnectionStrings["MovieDatabase"].ConnectionString;
            _database = new MovieLib.Data.Sql.SqlMovieDatabase(connString);

            _gridMovies.AutoGenerateColumns = false;

            UpdateList();
        }

        private void OnMovieAdd( object sender, EventArgs e )
        {
            var child = new MovieDetailForm("Movie Details");

            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                _database.Add(child.Movie);
            } catch (ValidationException ex)
            {
                DisplayError(ex, "Validation Failed");
            } catch (Exception ex)
            {
                DisplayError(ex, "Add Failed");
            };
            UpdateList();
        }

        private void OnMovieDelete( object sender, EventArgs e )
        {
            var movie = GetSelectedMovie();
            if (movie == null)
                return;

            DeleteMovie(movie);
        }

        private void OnMovieEdit( object sender, EventArgs e )
        {
            var movie = GetSelectedMovie();
            if (movie == null)
            {
                MessageBox.Show("No movies available.");
                return;
            };

            EditMovie(movie);
        }

        private void OnHelpAbout( object sender, EventArgs e )
        {
            var about = new AboutBox();
            about.ShowDialog(this);
        }

        private void OnFileExit( object sender, EventArgs e )
        {
            Close();
        }

        private void OnEditRow( object sender, DataGridViewCellEventArgs e )
        {
            var grid = sender as DataGridView;

            if (e.RowIndex < 0)
                return;

            var row = grid.Rows[e.RowIndex];
            var item = row.DataBoundItem as Movie;

            if (item != null)
                EditMovie(item);
        }

        private void OnKeyDownGrid( object sender, KeyEventArgs e )
        {
            if (e.KeyCode != Keys.Delete)
                return;

            var movie = GetSelectedMovie();
            if (movie != null)
                DeleteMovie(movie);
        }

        private void DeleteMovie( Movie movie )
        {
            if (MessageBox.Show(this, $"Are you sure you want to delete '{movie.Title}'?",
                                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                _database.Remove(movie.Id);
            } catch (Exception e)
            {
                DisplayError(e, "Delete Failed");
            };
            UpdateList();
        }

        private void DisplayError( Exception error, string title = "Error" )
        {
            DisplayError(error.Message, title);
        }

        private void DisplayError( string message, string title = "Error" )
        {
            MessageBox.Show(this, message, title ?? "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EditMovie( Movie movie )
        {
            var child = new MovieDetailForm("Movie Details");
            child.Movie = movie;
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                _database.Update(child.Movie);
            } catch (Exception ex)
            {
                DisplayError(ex, "Update Failed");
            };
            UpdateList();
        }

        private Movie GetSelectedMovie()
        {
            if (_gridMovies.SelectedRows.Count > 0)
                return _gridMovies.SelectedRows[0].DataBoundItem as Movie;

            return null;
        }

        private void UpdateList()
        {
            try
            {
              _bsMovies.DataSource = _database.GetAll().ToList();
            } catch (Exception e)
            {
                DisplayError(e, "Refresh Failed");
                _bsMovies.DataSource = null;
            };
        }

        private IMovieDatabase _database = new MovieLib.Data.Memory.MemoryMovieDatabase();
    }
}