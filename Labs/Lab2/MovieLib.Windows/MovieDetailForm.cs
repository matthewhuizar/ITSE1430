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

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            if (DesignMode)
                if (Movie != null)
                {
                    _txtTitle.Text = Movie.Title;
                    _txtDescription.Text = Movie.Description;
                    _txtLength.Text = Movie.Length.ToString();
                    _chkOwned.Checked = Movie.IsOwned;
                };

            ValidateChildren();
        }

        /// <summary>Gets or sets the product being shown.</summary>
        public Movie Movie { get; set; }

        private void OnCancel( object sender, EventArgs e )
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ShowError( string message, string title )
        {
            MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnSave( object sender, EventArgs e )
        {
            if (!ValidateChildren())
            {
                return;
            }
            var movie = new Movie();
            movie.Title = _txtTitle.Text;
            movie.Description = _txtDescription.Text;
            movie.Length = GetLength(_txtLength);
            movie.IsOwned = _chkOwned.Checked;

            ////Add validation
            var error = movie.Validate();
            if (!String.IsNullOrEmpty(error))
            {
                //Show the error
                ShowError(error, "Validation Error");
                return;
            };

            //Movie = movie;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private int GetLength( TextBox control )
        {
            if (Int32.TryParse(control.Text, out int price))
                return price;

            //Validate price
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
                _errors.SetError(_txtLength, "Price must be >= 0");
            } else
                _errors.SetError(_txtLength, "");
        }

        private void OnCheckOwned( object sender, EventArgs e )
        {

        }
    }
}
