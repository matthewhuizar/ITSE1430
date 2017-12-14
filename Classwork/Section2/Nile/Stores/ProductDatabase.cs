using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Stores
{
    /// <summary>Base class for product database.</summary>
    public abstract class ProductDatabase : IProductDatabase 
    {
        public Product Add ( Product product )
        {
            //TODO: Validate
            if (product == null)
                return null;

            //Using IValidatableObject
            if (!ObjectValidator.TryValidate(product, out var errors))
                return null;

            //Emulate database by storing copy
            return AddCore(product);
        }

        /// <summary>Get a specific product.</summary>
        /// <returns>The product, if it exists.</returns>
        public Product Get ( int id )
        {
            //TODO: Validate
            if (id <= 0)
                return null;

            return GetCore(id);
        }

        protected abstract Product GetCore( int id );

        /// <summary>Gets all products.</summary>
        /// <returns>The products.</returns>
        public IEnumerable<Product> GetAll ()
        {
            return GetAllCore();
        }

        protected abstract IEnumerable<Product> GetAllCore();

        /// <summary>Removes the product.</summary>
        /// <param name="product">The product to remove.</param>
        public void Remove ( int id )
        {
            //TODO: Validate
            if (id <= 0)
                return;

            RemoveCore(id);     
        }

        protected abstract void RemoveCore( int id );

        /// <summary>Updates a product.</summary>
        /// <param name="product">The product to update.</param>
        /// <returns>The updated product.</returns>
        public Product Update ( Product product )
        {
            //TODO: Validate
            if (product == null)
                return null;

            //Using IValidatableObject
            if (!ObjectValidator.TryValidate(product, out var errors))
                return null;

            //Get existing product
            var existing = GetCore(product.Id);
            if (existing == null)
                return null;

            return UpdateCore(existing, product);
        }

        protected abstract Product UpdateCore( Product existing, Product newItem );

        protected abstract Product AddCore( Product product );
    }
}
