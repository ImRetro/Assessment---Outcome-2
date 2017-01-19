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


            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File has not been found. Please try again.");
                Console.Read();
            }

           

            Array1 =  new[] { Data };

            return Data; 


        }
        public static void findhighmark()
        {
            
            char[] punctuation = new char[] { ' ', ',', '.' };
            for (int i = 0; i<Array1.Length;i ++)
            {
               Array1 = Array1[i].Split(punctuation);
            }
            
            winner = Array1[0];

            for (int i = 0; i < Array1.Length; i += 3)
            {
                Console.WriteLine(Array1[i]);
            }
            Console.Read();


        }
        public static string displayresults();
        {




        }








    }
}
