using System;
namespace hw17june
{
    public class Employee:Human
    {
        public string Position;
        public Employee(string name, string surname):base(name,surname)
        {

        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} - Surname: {Surname} - Age: {Age} - Position: {Position}");
        }



    }
}
