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
            String[] Array1;
            string winner;


        //Execute other functions
        static void Main(string[] args) 

        {
           
            readIn();
            
          
               
        }
            
       public static void readIn()
         {
    //Local Variables
            String data = "";

 // identifys the location of the file , and reads in the file
            try
            {
                StreamReader reader = new StreamReader(@"\\GCASTUDENTFS.glasgowclyde.ac.uk\homedrives$\20178947\Work\Outcome 2 Assesment\Data.csv");
             data = reader.ReadToEnd();
            Char[] punctuation = new char[] { };
            String[] Array1 = data.Split(punctuation);

            reader.Close();
            reader.Dispose();
            Console.WriteLine(Array1);
            Console.Read();
            }
           catch (FileNotFoundException)
            {
                Console.WriteLine("File has not been found. Please try again.");
                Console.Read();
            }

            

           
          }
      
        public static string findhighmark(String[] Array1)
       {

           String currentwinner;
           currentwinner = Array1[0];

           for (int i = 0 ; i < Array1.Length ; i+= 3)
           {
               Console.WriteLine(Array1[i]);
           }
           Console.Read();
           return "0";
          
       }
        
    
     
        



        }    
    }

