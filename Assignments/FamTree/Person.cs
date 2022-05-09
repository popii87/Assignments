using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamTree
{
    public class Person
    {
        public string Name { get; set; }
        public List<Person> Childs { get; set; }

        public bool hasChilds { get; set; }
        public void PrintData(Person p, int indent)
        {
            // Print me
            PrintWithIndent(p.ToString(), indent);

            if (p.hasChilds == true)
            {
                foreach (var child in p.Childs)
                {
                    PrintData(child, indent + 1); // Increase the indent for children
                }
            }
        }


        public void PrintWithIndent(string value, int indent)
        {
            Console.WriteLine("{0}{1}", new string(' ', indent * 2), value);
        }
    }

    
}
