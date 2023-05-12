using System;
// A namespace is used to organize your code and is collection of classes,
// interfaces, structs, enums and delegates

// variables are case-sensitive
namespace IntroductionToCsharp
{
    internal class Program
    {
        static void Main(string[] args) // Main method is the entry point of program
        // static void Main()
        {
            /*
            Console.WriteLine("Welcome to C# Training");
            */



            // PART-2 = Reading and Writing to the console
            /*
            Console.Write("Please enter your name: ");
            string str = Console.ReadLine();
            Console.WriteLine("Hello "+str); // Concat name with hello word and print
            Console.WriteLine("Hello {0}",str); // Placeholder syntax to print name with hello word
            // {0} {1} {2} ...
            Console.WriteLine("Hello {0} {1}", "Kunjesh", "Ramani");
            */



            // PART-3 = Build-in Types
            bool b = true; // false
            /*
            [1]BUILD-IN Datatypes;
            Boolean type = true or false
            Integral type = sbyte, byte, short, ushort, int, uint, long, ulong, char
            Floating type = float, double
            Decimal type
            String type
            LINK: https://www.javatpoint.com/csharp-data-types

            [2] ESCAPE SEQUENCES IN C#
            LINK: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/


            [3] VERBATIM LITERAL


             */
            Console.WriteLine(int.MinValue); //-2147483648
            Console.WriteLine(float.MinValue); // -3.4028235E+38

            string str = "\"Kunjesh\""; // Escape Sequence Character
            string str2 = "Kunjesh\nAryan\nAnsh";
            string str3 = "C:\\Program Files\\Visual Studio";
            // There are lot of double-\(which is further converted into single) 
            // In order to copy-paste the link and we want 2 \\, we have to remove all the back slashes
            // So not to do that, we have verbatim Literal in c#

            string str4 = @"C:\\Program Files\\Visual Studio";

            Console.WriteLine(str3); // C:\Program Files\Visual Studio
            Console.WriteLine(str4); // C:\\Program Files\\Visual Studio






        }
    }
}