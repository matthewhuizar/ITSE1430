/*
 * Matthew Huizar
 * ITSE 1430
 * 11/20/2017
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
    public partial class MovieDetailForm : Form 
    {
        public MovieDetailForm()
        {
            InitializeComponent();
        }

        public MovieDetailForm( string title ) : this()
        {
            Text = title;
        }

        public MovieDetailForm( string title, Movie movie ) : this(title)
        {
            Text = title;
            Movie = movie;
        }

        /// <summary>Gets or sets the movie being shown.</summary>
        public Movie Movie { get; set; }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);
            if (Movie != null)
            {
                _txtTitle.Text = Movie.Title;
                _txtDescription.Text = Movie.Description;
                _txtLength.Text = Movie.Length.ToString();
                _chkOwned.Checked = Movie.IsOwned;
            };

            ValidateChildren();
        }
        
        private void OnCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
            
        private void ShowError( string message, string title )
        {
            MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnSave( object sender, EventArgs e )
        {
            var movie = new Movie() {
                Id = Movie?.Id ?? 0,
                Title = _txtTitle.Text,
                Description = _txtDescription.Text,
                Length = GetLength(_txtLength),
                IsOwned = _chkOwned.Checked,
            };

            if (!ObjectValidator.TryValidate(movie, out var errors))
            {
                //Show the error
                ShowError("Not valid", "Validation Error");
                return;
            };

            Movie = movie;
            DialogResult = DialogResult.OK;
            Close();
        }

        private int GetLength( TextBox control )
        {
            if (Int32.TryParse(control.Text, out int length))
                return length;

            //Validate length
            return -1;
        }

        private void OnValidatingName( object sender, CancelEventArgs e )
        {
            var tb = sender as TextBox;
            if (String.IsNullOrEmpty(tb.Text))
                _errors.SetError(tb, "Name is required");
            else
                _errors.SetError(tb, "");
        }

        private void OnValidatingLength( object sender, CancelEventArgs e )
        {
            var tb = sender as TextBox;

            if (GetLength(tb) < 0)
            {
                e.Cancel = true;
                _errors.SetError(_txtLength, "Length must be >= 0");
            } else
                _errors.SetError(_txtLength, "");
        }

        private void OnCheckOwned( object sender, EventArgs e )
        {

        }

        private void MovieDetailForm_Load( object sender, EventArgs e )
        {

        }
    }
}
