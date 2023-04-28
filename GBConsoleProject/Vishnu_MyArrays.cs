using System;

namespace GBConsoleProject
{
    class Program
    {
/*
* Author: Arya Vishnu
* Purpose: Practice of core programming concepts and manipulation of 2-D lists
* Description: Gather movie reviews and utilise the data in different ways
*/
        static void Vishnu_displayArray(int[,] ratingTable)
        {
            int r = ratingTable.GetLength(0); // set local variable r to represent reviewers (rows)
			int m = ratingTable.GetLength(1); // set local variable m to represent movies (columns)

            // Title
            Console.WriteLine("====================================");
            Console.WriteLine("           Rating Table "); 
            Console.WriteLine("====================================");

			//Header Formatting
            Console.Write("Reviewer| "); 
			for (int i = 0;  i < (m-1); i++) 
			{
				Console.Write(" ");
			}
            Console.WriteLine("Movie"); 
			Console.Write("        |   "); 
			for (int i = 0; i < m; i++) 
			{
				Console.Write($"{i} ");
				
			}

            //Displaying matrix values, printing movie ratings for each reviewer
            Console.WriteLine("\n---------------------------------------");
            for (int i = 0; i < r; i++) 
			{
                Console.Write($"    {i}   |   "); 
                for (int j = 0; j < m; j++) 
				{
					Console.Write(ratingTable[i,j]);
					Console.Write(" "); 
				}
                Console.Write("\n"); 
            }
        }

        static void Vishnu_printHighestLowestReviewerRating(int[,] ratingTable)
        {
          
			int r = ratingTable.GetLength(0); 
			int m = ratingTable.GetLength(1); 

            //For each reviewee finds & displays their highest & lowest rating 
			for (int i = 0;i < r; i++) 
			{
				int high = ratingTable[i, 0]; 
				int low = ratingTable[i, 0]; 
				for (int j = 0;j < m; j++) 
				{
					if (ratingTable[i, j] > high) 
					{
						high = ratingTable[i, j];
					}
					else if (ratingTable[i, j] < low)
					{
						low = ratingTable[i, j];
					}
				}
                Console.WriteLine($"Highest and Lowest rating of Reviewee #{i}: {high} , {low}"); 
            }
        }

        static void Vishnu_printAverageMovieRating(int[,] ratingTable)
        {
            int r = ratingTable.GetLength(0); 
			int m = ratingTable.GetLength(1); 

            //For each movie, adds up reviews 
            //and divides by number of reviewees 
            //to output avg
			for (int i = 0; i < m; i++) 
			{
				int total = 0; 
				for (int j = 0;j < r; j++) 
				{
					total += ratingTable[j, i];
				}
				double average = Convert.ToDouble(total) / Convert.ToDouble(r);
                
                Console.WriteLine($"The average rating of movie #{i} is {Math.Round(average,2)}."); 
            }

        }
        public static void Main(string[] args)
        {
            

            Console.WriteLine("How many reviewers?: ");

            
            int reviewerNum = Convert.ToInt32(Console.ReadLine()); // ask for number of movies
            Console.WriteLine("Enter the number of movies: ");
            int movieNum = Convert.ToInt32(Console.ReadLine()); // ask for number of reviewers
			int[,] ratingTable = new int[reviewerNum,movieNum];

            //Collecting data & filling rating table
            for (int i = 0; i < reviewerNum; i++) 
			{
                Console.WriteLine($"------------------------\nReviewer {i}, enter your rate on a scale of 1-10: ");
                for (int j = 0; j < movieNum;)
				{
                    Console.WriteLine($"Enter your integer review for movie #{j}: ");
					int x = Convert.ToInt32(Console.ReadLine());

					// input verification (must be between 1-10 inclusive)
					if (x >= 1 && x <= 10) 
					{
						ratingTable[i, j] = x;
						j++; 
					}
					else
					{
                        Console.WriteLine("INVALID INPUT :(");
                    }
                }
			}
            
            //Calling helper functions
            Vishnu_displayArray(ratingTable); 
			Vishnu_printHighestLowestReviewerRating(ratingTable); 
			Vishnu_printAverageMovieRating(ratingTable);

        }
    }
}
