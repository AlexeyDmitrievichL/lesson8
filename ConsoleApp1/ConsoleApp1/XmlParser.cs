using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class XmlParser : FileParser
    {
        public override string ParserFormat { get => ".xml"; }

        public XmlParser(string fileName) : base(fileName)
        { }

        public override void Open() {
            Console.WriteLine($"{nameof(XmlParser)}: Файл {base.FileName}, был открыт");
        }

        public override void Read()
        {
            Console.WriteLine($"{nameof(XmlParser)}: Файл {base.FileName}, был прочитан");
        }

        public override void Analize()
        {
            Console.WriteLine($"{nameof(XmlParser)}: Файл {base.FileName}, был проанализирован");
        }

        public override void Close()
        {
            Console.WriteLine($"{nameof(XmlParser)}: Файл {base.FileName}, был закрыт");
        }
    }
}
