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
            string[] Array1; 
            string winner;


        //Execute other functions
        static void Main(string[] args) 

        {

            readIn();
            
            
          
               
        }
            
       public static string readIn()
         {
    //Local Variables
            String data = "";

 // identifys the location of the file , and reads in the file
            try
            {
                StreamReader reader = new StreamReader(@"\\GCASTUDENTFS.glasgowclyde.ac.uk\homedrives$\20178947\Work\Outcome 2 Assesment\Data.csv");
                data = reader.ReadToEnd();
                

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File has not been found. Please try again.");
                Console.Read();
            }

            return data;

           
          }
        public static void findhighmark(String [] Array1, String [] str)
       {
           String[] Array2;
            char[] punctuation = new char[] { ' ', ',', '.' };
           Array2 = str.Split

           String currentwinner;
           currentwinner = Array1[0];

           for (int i = 0 ; i < Array1.Length ; i+= 3)
           {
               Console.WriteLine(Array1[i]);
           }
           Console.Read();
          
          
       }
        
    
     
        



        }    
    }


