using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Double firstnum;
            Double secondnum;
            Double total;
            var calType = "";
            var ch = "";
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("-----------Welcome to calculator------------------");

            do
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("----Enter first number---");
                var ini = Console.ReadLine();
                firstnum = Convert.ToDouble(ini);
                Console.WriteLine("-----Enter second number------");
                var inis = Console.ReadLine();
                secondnum = Convert.ToDouble(inis);

                Console.WriteLine("Select '+' for addition or '-' for subtracton");
                calType = Console.ReadLine();


                switch (calType)
                {
                    case "+":
                        total = add(firstnum, secondnum);
                        Console.WriteLine($"Sum is {total}");
                        break;
                    case "-":
                        total = sub(firstnum, secondnum);
                        Console.WriteLine($"Difference is {total}");
                        break;

                }

                Console.WriteLine("-----Do you want to continue, 'y' for yes and 'n' for no------");
                ch = Console.ReadLine();

            } while (ch == "y");




            Double add(Double a, Double b)
            {
                Double result;
                result = a + b;
                return result;
            }

            Double sub(Double num1, Double num2)
            {
                Double result;
                if (num1 < num2)
                    result = num2 - num1;
                else
                    result = num1 - num2;

                return result;
            }


        }
    }
}
