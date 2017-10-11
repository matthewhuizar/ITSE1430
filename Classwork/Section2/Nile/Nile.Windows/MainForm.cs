﻿using System;
using System.Windows.Forms;

namespace Nile.Windows 
{
    public partial class MainForm : Form 
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            var products = _database.GetAll();
        }

        //private int FindAvailableElement ( ) // 
        //{
        //    for( var index = 0; index < _products.Length; ++index) 
        //    {
        //        if (_products[index] == null)
        //            return index;
        //    };

        //    return -1; //Return -1 if nothing is there
        //}

        //private int FindFirstProduct ( )
        //{
        //    for (var index = 0; index < _products.Length; ++index)
        //    {
        //        if (_products[index] != null)
        //            return index;
        //    };

        //    return -1; //Return -1 if nothing is there
        //}
        private void OnFileExit( object sender, EventArgs e )
        {
            Close();
        }

        private void OnProductAdd( object sender, EventArgs e )
        {
            ////Make sure there is room left
            //var index = FindAvailableElement();
            //if (index < 0) // .Length tells you size of the array
            //{
            //    MessageBox.Show("No more products available.");
            //    return;
            //}

            var child = new ProductDetailForm("Product Details");
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //Save product
            _database.Add(child.Product);
        }

        private void OnProductEdit( object sender, EventArgs e )
        {
            //Are there any products?
            //var index = FindFirstProduct(); 
            //if (index < 0) //Check if 0 has stored data
            //{
            //    MessageBox.Show("No products available.");
            //    return;
            //}
            var product = _database.Get();

            var child = new ProductDetailForm("Product Details");
            child.Product = product;
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //Save product
            _database.Update(child.Product);
        }

        private void OnProductDelete( object sender, EventArgs e )
        {
            //var index = FindFirstProduct();
            //if (index < 0) //If nothing, return
            //    return;

            //var product = _products[index]; //Create new variable to reference array element

            var product = _database.Get();

            //Confirm
            if (MessageBox.Show(this, $"Are you sure you want to delete '{product.Name}'?",
                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            //Delete product
            _database.Remove(product);
        }

        private void OnHelpAbout( object sender, EventArgs e )
        {
            var about = new AboutBox();
            about.ShowDialog(this);

            //CallButton(OnProductAdd);
        } //Add an about box

        public delegate void ButtonClickCall( object sender, EventArgs e );

        private void CallButton (ButtonClickCall functionToCall)
        {
            functionToCall(this, EventArgs.Empty);
        }

        private ProductDatabase _database = new ProductDatabase();
        //private Product[] _products = new Product[100]; //Array of 100 nulls
            
    }
}
