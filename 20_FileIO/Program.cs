using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write2File();
            string fn = @"D:\New\Yeni\TextNew.txt";

            var TextDoc= File.ReadAllText(fn);
            Console.WriteLine(TextDoc);
            Console.WriteLine("---------------------------");
            FileInfo fileInfo = new FileInfo(fn);

            Console.WriteLine(fileInfo.FullName);
            Console.WriteLine(fileInfo.Name);
            Console.WriteLine(fileInfo.Length);
            Console.WriteLine(fileInfo.CreationTime);

            Console.WriteLine("---------------------------");

            Console.WriteLine("bitti");


        }

        private static void Write2File()
        {
            string TextDoc = "merhaba";
            string fn = "d:\\TextNew.txt";
            File.WriteAllText(fn, TextDoc);
        }
    }
}
