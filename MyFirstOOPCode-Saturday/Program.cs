using System;

namespace MyFirstOOPCode_Saturday
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var dateObject = new Date(5, 4, 100);
                Console.WriteLine("Ingresar el año");
                
                Console.WriteLine(dateObject.ToString());
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
