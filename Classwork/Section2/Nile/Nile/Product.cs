using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile
{
    /// <summary>Represents a product.</summary>
    /// <remarks>
    /// This will represnt a product with other stuff.
    /// </remarks>
    public class Product 
    {
        //public readonly Product None = new Product(); //set at moment instance is created

        /// <summary>Gets or sets the name.</summary>
        /// <value>Never returns null.</value>
        public string Name
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

        /// <summary>Gets or sets the price.</summary>
        public decimal Price { get; set; } = 0;

        /// <summary>Determines if discontinued.</summary>
        public bool IsDiscontinued { get; set; }

        public const decimal DiscontinuedDiscountRate = 0.10M;
        /// <summary>Gets the discounted price, if applicable.</summary>
        public decimal DiscountedPrice
        {
            get 
            {
                if (IsDiscontinued)
                    return Price * DiscontinuedDiscountRate;

                return Price;
            }
        }

        public int ICanOnlySetIt { get; private set; }
        public int ICanOnlySetIt2 { get; }

        private string _name;
        private string _description;

        private readonly double _someValueICannotChange = 10; //alternative to const, only works on field, fixed at moment is created
    }
}
