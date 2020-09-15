using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace brev
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a TextBox object  

            TextBox dynamicTextBox = newTextBox();

            Console.WriteLine("Write your firstname here: ");
            string firstname = Console.ReadLine();
            
            Console.WriteLine("Write your lastname here: ");
            string lastname = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Dato: " + (DateTime.Now.ToString("dddd, dd MMMM yyyy")));

            string name = firstname + " " + lastname;
            Console.WriteLine(name);

            Console.WriteLine("Unicorn Heaven 4 \n4000 Infinity");
            Console.WriteLine();

            Console.WriteLine();
            Console.ReadKey();
        }

        private static TextBox newTextBox()
        {
            throw new NotImplementedException();
        }
    }
}
