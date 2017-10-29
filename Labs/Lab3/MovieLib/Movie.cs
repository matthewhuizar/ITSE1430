/*
 * Matthew Huizar
 * ITSE 1430
 * 10/13/2017
 */

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
        public int Length { get; set; } = 0;

        /// <summary>Determines if owned.</summary>
        public bool IsOwned { get; set; }

        public override string ToString()
        {
            return Title;
        }

        /// <summary>Validates the object.<summary>///
        /// <returns>The error message or null.</returns>
        public virtual string Validate()
        {
            //Name cannot be empty
            //Length cannot be < 0
            if (Length < 0 )
                return "Length must be >= 0.";
            if (String.IsNullOrEmpty(Title))
               return "Name cannot be empty.";

            return null;
        }

        private string _name;
        private string _description;
    }
}
