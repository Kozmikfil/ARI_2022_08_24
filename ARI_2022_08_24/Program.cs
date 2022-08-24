using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARI_2022_08_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Text = "Larissa Murat Eren Derya Elif Furkan-erhan/Yaşar";
            var words = Text.Split(new char[] {' ', '/', '-'});
            
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------");
            Console.WriteLine(words.Length);
        }
    }
}
