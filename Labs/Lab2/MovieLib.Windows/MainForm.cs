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
            if (child.ShowDialog(this) != DialogResult.OK) //validate
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
            var child = new MovieDetailForm(); //create form
            if (child.ShowDialog(this) != DialogResult.OK) //validate
                return;

            //Save form 
            _movie = child.Movie;
        }

        private Movie _movie = new Movie();
    }
}
