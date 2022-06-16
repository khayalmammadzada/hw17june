using System;
namespace hw17june
{
    public class Human
    {
        public Human(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name;
        public string Surname;
        public byte Age;
       

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} - Surname: {Surname} - Age: {Age}");
        }

        

        public bool CheckName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                for(int i=0; i<name.Length; i++)
                {
                    if (!Char.IsLetter(name[i]))
                        return false;
                    
                }
                return true;
            }
            return false;
        }



        public bool CheckSurname(string surname)
        {
            if (!string.IsNullOrWhiteSpace(surname))
            {
                for (int i = 0; i < surname.Length; i++)
                {
                    if (!Char.IsLetter(surname[i]))
                        return false;

                }
                return true;
            }
            return false;
        }



    }
}
