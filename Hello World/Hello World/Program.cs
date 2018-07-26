using System;


namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {

            // output is the name of the string variable
            string output = "Hello World";
            Console.WriteLine(output);

            // \n creates a new line - same code from above on one line 
            Console.WriteLine("\nHello World");

            //prints the words inside the "" on screen
            Console.WriteLine("\nPlease push enter to exit application");

            //Reads the above code and stops the application from automatically closing
            Console.ReadLine();
        }
    }
}
