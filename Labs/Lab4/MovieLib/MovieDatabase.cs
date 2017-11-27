/*
 * Matthew Huizar
 * ITSE 1430
 * 11/20/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib 
{
    public abstract class MovieDatabase : IMovieDatabase
    {
        /// <summary>Adds a movie.</summary>
        /// <param name="movie">The movie to add.</param>
        /// <returns>The added movie.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="movie"/> is null.</exception>
        /// <exception cref="ValidationException"><paramref name="movie"/> is invalid.</exception>
        public Movie Add( Movie movie )
        {
            if (movie == null)
                throw new ArgumentNullException(nameof(movie), "Movie was null");

            ObjectValidator.Validate(movie);

            try
            {
                return AddCore(movie);
            } catch (Exception e)
            {
                throw new Exception("Add failed", e);
                throw;
            };
        }

        /// <summary>Get a specific movie.</summary>
        /// <param name="id">The id to get.</param>
        /// <returns>The movie, if it exists.</returns>
        public Movie Get( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");

            return GetCore(id);
        }

        /// <summary>Get all movies.</summary>
        /// <returns>The movies.</returns>
        public IEnumerable<Movie> GetAll()
        {
            return GetAllCore();
        }

        /// <summary>Removes the movie.</summary>
        /// <param name="movie">The movie to remove.</param>
        public void Remove( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");

            RemoveCore(id);
        }

        /// <summary>Updates a movie.</summary>
        /// <param name="movie">The movie to update.</param>
        /// <returns>The updated movie.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="movie"/> is null.</exception>
        /// <exception cref="ValidationException"><paramref name="movie"/> is invalid.</exception>
        /// <exception cref="Exception">Movie not found.</exception>
        public Movie Update( Movie movie )
        {
            if (movie == null)
                throw new ArgumentNullException(nameof(movie));

            ObjectValidator.Validate(movie);

            var existing = GetCore(movie.Id) ?? throw new Exception("Movie not found.");

            return UpdateCore(existing, movie);
        }

        #region Protected Members

        protected abstract Movie GetCore( int id );

        protected abstract IEnumerable<Movie> GetAllCore();

        protected abstract void RemoveCore( int id );

        protected abstract Movie UpdateCore( Movie existing, Movie newItem );

        protected abstract Movie AddCore( Movie movie );
        #endregion
    }
}
