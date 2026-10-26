using System;
namespace program
{
    class program1
    {
     static void Main(string[] args)
        {
            string name = "Gulzaman";
            int myNum = 15;
            myNum = 20;
            //Console.WriteLine(myNum);
            //Console.WriteLine(name);

            // Multiples Variables

            int myNum1 = 10;
            double doubleNum = 5.6;
            char letter = 'G';
            Boolean status = true;
            string name1 = name;

            Console.WriteLine(myNum1);
            Console.WriteLine(doubleNum);
            Console.WriteLine(letter);
            Console.WriteLine(status);
            Console.WriteLine(name1);

            // const variables

            // This will declare the variable as "constant", which means unchangeable and read-only:

            const int mynum2 = 40;
            // mynum2 = 13       Error aye ga keo k yae change nh ho skta 

            // Declare Many Variables


            // To declare more than one variable of the same type, use a comma-separated list:

            int x = 5, y = 10, z = 57;
            Console.WriteLine(x + y + z);

            // You can also assign the same value to multiple variables in one line:

            int a, b, c;
            a = b = c = 40;
            Console.Write(a +  b + c);









        }

    }
}