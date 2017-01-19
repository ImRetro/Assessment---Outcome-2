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
        public static string[] firstname;
        public static string[] secondname;
        public static int[] score;
        public static string winner;


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
                StreamReader reader = new StreamReader(@"\\GCASTUDENTFS.glasgowclyde.ac.uk\homedrives$\20178947\Work\Outcome 2 Assesment\Data.csv");
                Data = reader.ReadToEnd();
                Console.WriteLine("Found File");

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File has not been found. Please try again.");
                Console.Read();
            }


            Char [] Punctuation = new char[] { '\n', ',' };
            Array1 = Data.Split(Punctuation);

            for (int i = 2; i < Array1.Length; i+=3)
            {
                

            }


                return Data;


        }
        public static void findhighmark()
        {






            winner = Array1[2];


            for (int i = 2; i < Array1.Length; i +=3)
            {

                Console.WriteLine(Array1[i]);
                string value = int.Parse(Console.ReadLine());

                if (value > winner)
                {

                }
                
                    
            }
           
            Console.Read();


        }
        public  static void displayresults()
        {
            StreamWriter writer = new StreamWriter(@"U:\Work\Outcome 2 Assesment\Results.txt");
            writer.WriteLine(winner);




        }
    }
}
