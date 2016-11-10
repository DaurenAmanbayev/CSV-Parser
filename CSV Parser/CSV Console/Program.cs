using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Console
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.OutputEncoding = System.Text.Encoding.GetEncoding("Cyrillic");
          //  Console.WriteLine("Яхууу");
           // Console.Write('\u2103');
            String[] lines = File.ReadAllLines(@"d:\table.csv", Encoding.GetEncoding(1251));

            foreach (var line in lines)
            {
                string[] values = line.Split(',');
                foreach (var val in values)
                {
                    Console.Write(val);
                }
                Console.WriteLine();   
            }

            Console.ReadKey();
        }
    }
}
