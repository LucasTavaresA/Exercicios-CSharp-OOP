using System;
using System.Collections.Generic;
using System.IO;
using _35_lendo_arquivos.Entities;

namespace _35_lendo_arquivos
{
    class Program
    {
        static void Main()
        {
            HashSet<LogRecord> logRecord = new();
            try
            {
                using StreamReader sr = File.OpenText(@"c:\temp\in.txt");
                while(!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(' ');
                    string name = line[0];
                    logRecord.Add(new LogRecord(name));
                }
                Console.Write("Total users: " + logRecord.Count);
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
