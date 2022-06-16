using System;

namespace hw17june
{
    class Program
    {
        static void Main(string[] args)
        {

            string option;
            do
            {
                Console.WriteLine("1.Employee elave et");
                Console.WriteLine("2.Student elave et");
                Console.WriteLine("3.Employeelerin sayini goster");
                Console.WriteLine("4.Studentlerin sayini goster");
                Console.WriteLine("5.Employeelere bax");
                Console.WriteLine("6.Studentlere bax");
                Console.WriteLine("7.Insanlar uzere axtaris et");
                Console.WriteLine("0.Menudan cix");

                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Employee elave et");
                        break;
                    case "2":
                        Console.WriteLine("Student elave et");
                        break;
                    case "3":
                        Console.WriteLine("Employeelerin sayini goster");
                        break; 
                    case "4":
                        Console.WriteLine("Studentlerin sayini goster");
                        break;
                    default:
                        break;


                }



            } while (option != "1" && option != "2" && option != "3" && option != "4"


            && option != "5" && option != "6" && option != "7" && option != "0");
            

        }
    }
}
