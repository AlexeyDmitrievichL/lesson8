using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class FileParser
    {
        public abstract string ParserFormat { get; }
        public string FileName { get; }

        public FileParser (string fileName)
        {
            FileName = fileName;
        }

        public abstract void Open();
        public abstract void Read();
        public abstract void Analize();
        public abstract void Close();

        public virtual void Parse()
        {
            Open();
            Read();
            Analize();
            Close();
        }

        public static FileParser GetParser(string fileName)
        {
            if (fileName.EndsWith(".xml"))
            {
                return new XmlParser(fileName);
            }
            if (fileName.EndsWith(".rtf"))
            {
                return new RtfParser(fileName);
            }
            if (fileName.EndsWith(".html"))
            {
                return new HtmlParser(fileName);
            }
            return null;
        }
    }
}
