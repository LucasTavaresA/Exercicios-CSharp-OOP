using System.IO;
using System;
using System.Globalization;

namespace _43_Escrevendo_Arquivos
{
    class Program
    {
        static void Main()
        {
            string path = @"c:\temp\temp.csv";
            string targetPath = @"c:\temp\out\summary.csv";
            try
            {
                string[] lines = File.ReadAllLines(path);

                using(StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        string[] lin = line.Split(',');
                        string name = lin[0];
                        double price = double.Parse(lin[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(lin[2]);
                        double total = price * quantity;
                        string writeLine = name + ", $" + total.ToString("F2", CultureInfo.InvariantCulture);
                        Console.WriteLine(writeLine);
                        sw.WriteLine(writeLine);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("IOException!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
