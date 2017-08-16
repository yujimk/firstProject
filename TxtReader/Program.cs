using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxtReader
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var reader = new TxtReader();
                reader.FileStremRead(@"G:\TestData\first.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
        }
    }
}
