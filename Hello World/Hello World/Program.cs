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

            //Basic addition calculation
            int x = 0;
            int y = 0;

            Console.WriteLine("Please enter first number");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter second number");
            y = Convert.ToInt32(Console.ReadLine());

            int ans = x + y;
            Console.WriteLine("The answer of {0} + {1} is {2}", x, y, ans);

            //prints the words inside the "" on screen
            Console.WriteLine("\nPlease push enter to exit application");

            //Reads the above code and stops the application from automatically closing
            Console.ReadLine();
        }
    }
}
