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
                    case '+':
                        total = add(firstnum, secondnum);
                        break;
                    case '-':
                        total = sub(firstnum, secondnum);
                        break;

                }

            } while (ch == 'y');

            Console.ReadLine("-----Do you want to continue, 'y' for yes and 'n' for no------");


            Double add(Double num1, Double num2)
            {
                Double result;
                result = num1 + num2;
                return result;
            }

            Double sub(Double num1, Double num2)
            {
                Double result;
                reuslt = num1 + num2;
                return result;
            }


        }
    }
}
