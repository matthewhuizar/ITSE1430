/*
 * Matthew Huizar
 * ITSE 1430
 * 9/6/17
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Host 
{
    class Program {
        static void Main( string[] args )
        {
            Console.WriteLine(100 - 2 * 5 / 2);
            bool quit = false;
            do
            {
                char choice = GetInput();
                switch (choice)
                {
                    case 'a':
                    case 'A':
                    AddProduct();
                    break;

                    case 'l':
                    case 'L':
                    ListProduct();
                    break;

                    case 'q':
                    case 'Q': quit = true;
                    break;
                };
            } while (!quit);
        }

        private static void ListProduct()
        {
            //Name $price [Discontinued]
            //Description
            //string msg = String.Format("{0}\t\t\t{1}\t\t{2}", productName, productPrice
            //, productDiscontinued ? "[Discontinued]" : "");
            string msg = $"{productName}\t\t\t${productPrice}\t\t{(productDiscontinued ? "[Discontinued]" : "")}";

           Console.WriteLine(msg);
           Console.WriteLine(productDescription);
        }

        private static void AddProduct()
        {
            Console.Write("Enter product name: ");
            productName = Console.ReadLine().Trim();
            
            //Ensure not empty (validate)

            Console.Write("Enter price (> 0): ");
            productPrice = ReadDecimal();

            Console.Write("Enter optional description: ");
            string description = Console.ReadLine().Trim();

            Console.Write("It is discontinued (Y/N): ");
            productDiscontinued = ReadYesNo();
        }

        static char GetInput()
        {
            while(true)
            {
            Console.WriteLine("Main Menu");
            Console.WriteLine("".PadLeft(10, '-'));
            Console.WriteLine("A)dd Product");
            Console.WriteLine("L)ist Products");
            Console.WriteLine("Q)uit");

            var input = Console.ReadLine().Trim();

                //Option 1 = string literal
                //if (input != "")

                //Option 2 = string field
                //if (input != String.Empty)
                
                //Option 3 = length
                if (input != null && input.Length != 0)
                {
                    //String comparison
                    if (String.Compare(input, "A", true) == 0)
                        return 'A';

                    //Char comparison
                    char letter = Char.ToUpper(input[0]);
                    if (letter == 'A')
                        return 'A';
                    else if (letter == 'L')
                        return 'L';
                    else if (letter == 'Q')
                        return 'Q';
                };
                
             //Error
             Console.WriteLine("Please choose a valid option");
            };

        }
        static void Main2( string[] args )
        {
            int hours;

            hours = 10;

            //hours = Math.Min(hours, 56);

            string name = "John";

            //Concat
            name = name + " Williams";

            //Copy
            name = "Hello";

            bool areEqual = name == "Hello";
            bool areNotEqual = name != "Hello";

            //Verbatim string - no escape sequences
            string path = @"C:\Temp\test.txt";

            /*
            //Option 1
            string names = "John" + "William" + "Henry";

            //Option 2
            StringBuilder builder = new StringBuilder();
            builder.Append("John");
            builder.Append("William");
            string names2 = builder.ToString();

            //Option 3
            string names3 = String.Concat("John", " William", " Murphy", "Charles", " Henry");
            */

            //String formatting - John worked 10 hours

            //Option 1
            string format1 = name + " worked " + hours.ToString() + " hours";

            //Option 2
            string format2 = String.Format("{0} worked for {1} hours", name, hours);

            //Option 3
            string format3 = $"{name} worked for {hours}";

            //value type
            int value1 = 10;
            var program = new Program();

            var areEqual1 = value1 == 10;
            var areEqual2 = program == program;
            var areEqual3 = program == new Program();
        }

        /// <summary>Reads a decimal from Console.</summary>
        /// <returns>The decimal value</returns>
        static bool ReadYesNo()
        {
            do
            {
                string input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input))
                {
                    switch (Char.ToUpper(input[0]))
                    {
                        case 'Y': return true;
                        case 'N': return false;
                    };
                };

                Console.WriteLine("Enter either Y or N");
            } while (true);
        }

        /// <summary>Reads a decimal from Console.</summary>
        /// <returns>The decimal value</returns>
        static decimal ReadDecimal ()
        {
            do
            {
                var input = Console.ReadLine();

                //decimal result;
                if (Decimal.TryParse(input, out decimal result))
                    return result;
                Console.WriteLine("Enter a valid decimal");
            }while(true);
        }
        static string ReadString( string errorMessage, bool allowEmpty)
        {
            //if (errorMessage == null)
            //    errorMessage = "Enter a valid string";
           // else
             // errorMessage = errorMessage.Trim();
            //null coalesce
            errorMessage = errorMessage ?? "Enter a valid string";

            //null conditional
            errorMessage = errorMessage?.Trim();

            do
            {
                var input = Console.ReadLine();
                if (String.IsNullOrEmpty(input) && allowEmpty)
                    return "";
                else if (!String.IsNullOrEmpty(input))
                    return input;

                Console.WriteLine(errorMessage);
            } while (true);
        }

        //Product
        static string productName;
        static decimal productPrice;
        static string productDescription;
        static bool productDiscontinued;
    }
}
