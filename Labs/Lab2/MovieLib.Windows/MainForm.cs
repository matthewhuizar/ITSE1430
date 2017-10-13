/*
 * Matthew Huizar
 * ITSE 1430
 * 10/13/2017
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLib.Windows 
{
    public partial class MainForm : Form 
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnMovieAdd( object sender, EventArgs e )
        {

            var child = new MovieDetailForm(); //create form

            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //Save form 
            _movie = child.Movie;            
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

        private void OnMovieEdit( object sender, EventArgs e )
        {
            if (_movie.Title == "")
            {
                MessageBox.Show("No movies available.");
                return;
            };

            var child = new MovieDetailForm(); //create form
            child.Movie = _movie;
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //Save form 
            _movie = child.Movie;
        }

        private void OnMovieDelete( object sender, EventArgs e )
        {
            if (_movie.Title == "")
            {
                MessageBox.Show("No movies available.");
                return;
            };

            if (MessageBox.Show(this, $"Are you sure you want to delete '{_movie.Title}'?",
                                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No);
            if (_movie.Title !=  "")
            {
                _movie.Title = "";
                _movie.Description = "";
                _movie.Length = 0;
                _movie.IsOwned = false;
            }
        }

        private Movie _movie = new Movie();
    }
}
