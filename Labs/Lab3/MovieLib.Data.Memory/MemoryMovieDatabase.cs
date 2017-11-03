/*
 * Matthew Huizar
 * ITSE 1430
 * 10/30/2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib.Data.Memory
{
    public class MemoryMovieDatabase : IMovieDatabase
    {
        /// <summary>Adds a movie.</summary>
        /// <param name="product">The movie to add.</param>
        /// <returns>The added movie.</returns>
        public Movie Add( Movie movie )
        {
            if (movie == null)
                return null;

            var newMovie = CopyMovie(movie);
            _movies.Add(newMovie);

            if (newMovie.Id <= 0)
                newMovie.Id = _nextId++;
            else if (newMovie.Id >= _nextId)
                _nextId = newMovie.Id + 1;

            return CopyMovie(newMovie);
        }

        /// <summary>Get a specific movie.</summary>
        /// <param name="id">The id to get.</param>
        /// <returns>The movie, if it exists.</returns>
        public Movie Get( int id )
        {
            if (id < 0)
                return null;

            var movie = FindMovie(id);

            return (movie != null) ? CopyMovie(movie) : null;
        }

        /// <summary>Get all movies.</summary>
        /// <returns>The movies.</returns>
        public IEnumerable<Movie> GetAll()
        {
            foreach (var movie in _movies)
                yield return CopyMovie(movie);
        }

        /// <summary>Removes the movie.</summary>
        /// <param name="movie">The movie to remove.</param>
        public void Remove( int id )
        {
            var movie = FindMovie(id);
            if (movie != null)
                _movies.Remove(movie);
        }

        /// <summary>Updates a movie.</summary>
        /// <param name="movie">The movie to update.</param>
        /// <returns>The updated movie.</returns>
        public Movie Update( Movie movie)
        {
            //TODO: Validate
            if (movie == null)
                return null;

            //Using IValidatableObject
            //if (!ObjectValidator.TryValidate(movie, out var errors))
             //   return null;
            //if (!String.IsNullOrEmpty(product.Validate()))
            //    return null;

            //Get existing product
            var existing = Get(movie.Id);
            //if (existing == null)
               // return null;

            return UpdateCore(existing, movie);
        }

        /// <summary>Updates a product.</summary>
        /// <param name="product">The product to update.</param>
        /// <returns>The updated product.</returns>
        private Movie UpdateCore( Movie existing, Movie movie )
        {
            //Replace 
            existing = FindMovie(movie.Id);
            _movies.Remove(existing);

            var newMovie = CopyMovie(movie);
            _movies.Add(newMovie);

            return CopyMovie(newMovie);
        }

        private Movie CopyMovie( Movie movie )
        {
            //if (movie == null)
            //    return null;

            var newMovie = new Movie();
            newMovie.Id = movie.Id;
            newMovie.Title = movie.Title;
            newMovie.Description = movie.Description;
            newMovie.Length = movie.Length;
            newMovie.IsOwned = movie.IsOwned;

            return newMovie;
        }
        
        private Movie FindMovie( int id )
        {
            foreach (var movie in _movies)
            {
                if (movie.Id == id)
                    return movie;
            };

            return null;
        }

        private List<Movie> _movies = new List<Movie>();
        private int _nextId = 1;
    }
}
