﻿/*
 * Matthew Huizar
 * ITSE 1430
 * 10/30/2017
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib 
{
    /// <summary>Represents a movie.</summary>
    public class Movie : IValidatableObject
    {
        /// <summary>Gets or sets the unique identifier.</summary>
        public int Id { get; set; }

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

        /// <summary>Validates the object.</summary>
        /// <returns>The error message or null.</returns>      
        public IEnumerable<ValidationResult> Validate( ValidationContext validationContext )
        {
            //Name cannot be empty
            if (String.IsNullOrEmpty(Title))
                yield return new ValidationResult("Title cannot be empty.", new[] { nameof(Title) });

            //Length >= 0
            if (Length < 0)
                yield return new ValidationResult("Length must be >= 0.", new[] { nameof(Length) });
        }

        private string _name;
        private string _description;
    }
}
