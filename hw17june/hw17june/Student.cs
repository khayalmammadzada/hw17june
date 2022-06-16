using System;
namespace hw17june
{
    public class Student: Human
    {
        public Student(string name, string surname):base(name,surname)
        {

        }

        public int Grade;
        public string GroupNo;

        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} - Surname: {Surname} - Age: {Age} - Grade: { Grade} - GroupNo: { GroupNo}");
        }

    }
}
