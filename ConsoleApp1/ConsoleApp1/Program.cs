using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Введите название файла, который хотите распарсить в формате [имя_файла].[формат]:");
            Console.WriteLine("Допустимые расширения файлов: .xml, .rtf, .html");
            Console.WriteLine("");
            string fileName = Console.ReadLine();
            FileParser parser = FileParser.GetParser(fileName);
            if (parser is FileParser _parser)
            {
                _parser.Parse();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Формат файла не соответствует допустимому.");
            }
            Console.ReadKey();
        }
    }
}
