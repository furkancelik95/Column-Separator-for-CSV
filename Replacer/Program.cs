using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding encode = System.Text.Encoding.Default;
            Console.WriteLine("Lütfen Değiştirmek istediğiniz CSV dosyasını bu EXE ile aynı klasöre koyun ve ismini yazın" +
            " Örnek:Maptriks.csv ise sadece Maptriks yazın");
            string path2 = (Console.ReadLine());
            string path = @"" + path2 + ".csv";
            File.WriteAllText(path, Regex.Replace(File.ReadAllText(path, encode), ",", ";"));

        }
    }
}
