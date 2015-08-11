using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXMLHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement books = XElement.Parse
            (@"
            <books>
                <book>
                    <title>Title</title>
                    <author>Joe ratzz</author>
                </book>
                <book>
                    <title>Title</title>
                    <author>Joe ratzz</author>
                </book>
                <book>
                    <title>Title</title>
                    <author>Joe ratzz</author>
                </book>
                <book>
                    <title>Title</title>
                    <author>Joe ratzz</author>
                </book>
            </books>");
            var titles = from book in books.Elements("book") where (string)book.Element("author") == "Joe ratzz" select book.Element("title");
            foreach(var title in titles)
            {
                Console.WriteLine(title.Value + " title ");
            }
            Console.ReadLine();
        }
    }
}
