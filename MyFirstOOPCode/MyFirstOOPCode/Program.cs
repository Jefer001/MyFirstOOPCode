using System;

namespace MyFirstOOPCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var dateObject = new Date(2025, 2, 29);

                Console.WriteLine("");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
