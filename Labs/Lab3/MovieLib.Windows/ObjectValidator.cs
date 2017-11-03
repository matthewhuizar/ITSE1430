﻿/*
 * Matthew Huizar
 * ITSE 1430
 * 10/30/2017
 */
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieLib.Windows {
    internal class ObjectValidator {
        public static bool TryValidate( IValidatableObject value, out IEnumerable<ValidationResult> errors )
        {
            var context = new ValidationContext(value);
            var results = new List<ValidationResult>();

            errors = results;
            return Validator.TryValidateObject(value, context, results);
        }
    }
}