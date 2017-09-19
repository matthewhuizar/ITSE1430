/*
 * Matthew Huizar
 * ITSE 1430
 * 9/1/2017
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1 {
    class Lab1 {

        static void Main( string[] args )
        {
            bool quit = false;
            do
            {
                char choice = GetInput();
                switch (choice)
                {
                    case 'l':
                    case 'L':
                    ListMovies();
                    break;

                    case 'a':
                    case 'A':
                    AddMovies();
                    break;

                    case 'r':
                    case 'R':
                    RemoveMovie();
                    break;

                    case 'q':
                    case 'Q':
                    quit = true;
                    break;
                };
            } while (!quit);

        }

        private static void ListMovies()
        {
            //No movie available
            if (movieTitle == null || movieTitle == "")
                Console.WriteLine("\nNo movies available.\n");

            //Validate if movie is available
            if (movieTitle != null && movieTitle != "")
            {
                string msg = $"\nMovie Collection\n----------\nTitle: {movieTitle}\n" +
                $"Description: {movieDescription}\n" +
                $"Duration: {movieLength} minutes\n" +
                $"{(movieStatus ? "Status: Owned" : "Status = Not Owned")}\n";

                Console.WriteLine(msg);
            };
        }

        private static void AddMovies()
        {
            Console.Write("\nEnter the movie title: ");
            movieTitle = Console.ReadLine().Trim();

            //Ensure not empty (validate)
            while (movieTitle == "")
            {
                Console.Write("Please enter a valid movie title: ");
                movieTitle = Console.ReadLine().Trim();
            }

            Console.Write("Enter an optional description: ");
            movieDescription = Console.ReadLine().Trim();

            Console.Write("Enter the optional length in minutes: ");
            movieLength = ReadInt();

            Console.Write("Do you own this movie? (Y/N): ");
            movieStatus = ReadYesNo();
            Console.WriteLine("\n");
        }

        private static void RemoveMovie()
        {
            bool clear = false;
            while (!clear)
            {
                Console.Write("\nAre you sure you want to delete the movie (Y/N?): ");
                var input = Console.ReadLine().Trim();
                if (input != null && input.Length != 0)
                {
                    char letter = Char.ToUpper(input[0]);
                    if (letter == 'Y')
                    {
                        movieTitle = "";
                        movieDescription = "";
                        movieLength = 0;
                        movieStatus = false;
                        Console.WriteLine("\n");
                        break;
                    } else if (letter == 'N')
                    {
                        clear = true;
                        Console.WriteLine("\n");
                    };

                }
            }
        }

        static int ReadInt()
        {
            do
            {
                string input = Console.ReadLine().Trim();

                if (input == "")
                    input = "0";

                if (Int32.TryParse(input, out int result) && result >= 0)
                    return result;
                Console.WriteLine("Enter a length >= 0.");
            } while (true);
        }

        static char GetInput()
        {
            while (true)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("".PadLeft(10, '-'));
                Console.WriteLine("L)ist Movies");
                Console.WriteLine("A)dd Movie");
                Console.WriteLine("R)emove Movie");
                Console.WriteLine("Q)uit");

                var input = Console.ReadLine().Trim();

                if (input != null && input.Length != 0)
                {
                    //Char comparison
                    char letter = Char.ToUpper(input[0]);
                    if (letter == 'L')
                        return 'L';
                    else if (letter == 'A')
                        return 'A';
                    else if (letter == 'R')
                        return 'R';
                    else if (letter == 'Q')
                        return 'Q';
                };

                //Error
                Console.WriteLine("Please choose a valid option.\n");
            }
        }

        static bool ReadYesNo()
        {
            do
            {
                string input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input))
                {
                    switch (Char.ToUpper(input[0]))
                    {
                        case 'Y':
                        return true;
                        case 'N':
                        return false;
                    };
                };

                Console.Write("Enter either Y or N: ");
            } while (true);
        }

        //Movie details
        static string movieTitle;
        static string movieDescription;
        static int movieLength;
        static bool movieStatus;
    }
}

