using System;
using System.IO;

namespace Activity_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;

            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\rayli\\source\\repos\\StreamReader.txt");

                line = sr.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }

                sr.Close();

                StreamWriter sw = new StreamWriter("C:\\Users\\rayli\\source\\repos\\StreamReader.txt");

                sw.WriteLine("Hello Activity_5!!");
                sw.WriteLine("From Activity_5");

                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}

