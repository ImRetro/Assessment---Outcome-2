using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Outcome_2
{
    class Program
    {

        // Global Variables
        public static string[] Array1;
        public static string firstname = "";
        public static string secondname = "";
        public static int score;
        public static string winner = "";




        //Execute other functions
        static void Main(string[] args)
        {

            readIn();
            findhighmark();
            displayresults();




        }

        public static string readIn()
        {
            //Local Variables
            String Data = "";

            // identifys the location of the file , and reads in the file
            try
            {
                // reads in from file
                StreamReader reader = new StreamReader(@"\\GCASTUDENTFS.glasgowclyde.ac.uk\homedrives$\20178947\Work\Outcome 2 Assesment\Data.csv");
                Data = reader.ReadToEnd();
                Console.WriteLine("Found File");

            }
                //activates if the file path is incorrect or cannot happen
            catch (FileNotFoundException)
            {
                Console.WriteLine("File has not been found. Please try again.");
                Console.Read();
            }

            //separates the array
            Char [] Punctuation = new char[] { '\n', ',' };
            Array1 = Data.Split(Punctuation);

            
            //returns data
                return Data;


        }
        public static void findhighmark()
        {

            //sets score as a element from the array
            score = int.Parse(Array1[2]);

            // local variables
            int Mark;

            //starts a loop
            for (int i = 2; i < Array1.Length; i+= 3)

            {

                //sets mark to the current element in the array
                Mark = int.Parse(Array1[i]);
                

                //compares mark with score
                if (Mark > score)
                {
                    //sets information
                    score = Mark;
                    firstname = Array1[i - 2];
                    secondname = Array1[i - 1];
                    
                    
                }
            }

            //puts data into 1 variable
            winner = (firstname + " " + secondname + " "  + score);
            Console.WriteLine(winner);
            


        }
        public  static void displayresults()
        {
            //trys to do the action
            try
            {

                //writes to a file
                StreamWriter writer = new StreamWriter(@"\\GCASTUDENTFS.glasgowclyde.ac.uk\homedrives$\20178947\Work\Outcome 2 Assesment\Results.txt");
                writer.Flush();
                writer.WriteLine(winner);
                writer.Close(); 
                Console.WriteLine("Written to file");
                Console.Read();

            }
                //activates if the file path is incorrect or cannot happen
            catch (FileNotFoundException)
            {
                Console.WriteLine("File Not Found");
                Console.Read();

            }

          



        }
    }
}

    

