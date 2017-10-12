using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib 
{
    /// <summary>Represents a movie.</summary>
    /// <remarks></remarks>
    public class Movie 
    {
        public Movie()
        {
        }

        /// <summary>Gets or sets the name.</summary>
        /// <value>Never returns null.</value>
        public string Title
        {
            //string get_Name ()
            get {
                //null coalesce
                return _name ?? "";
            }

            //void set_Name ( string value )
            set {
                //null conditional
                _name = value?.Trim();
            }
        }

        /// <summary>Gets or sets the description.</summary>
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value?.Trim(); }
        }

        /// <summary>Gets or sets the length.</summary>
        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }

        /// <summary>Determines if discontinued.</summary>
        public bool IsOwned { get; set; }

        public override string ToString()
        {
            return Title;
        }

        //public abstract string Validate2();
        /// <summary>Validates the object.<summary>///
        /// <returns>The error message or null.</returns>
        public virtual string Validate()
        {
            //Name cannot be empty
            if (String.IsNullOrEmpty(Title))
                return "Name cannot be empty.";
            //Price >= 0
           // if (Length < 0)
            //    return "Price must be >= 0.";

            return null;
        }

        private string _name;
        private string _description;
        private int _length;
    }
}
