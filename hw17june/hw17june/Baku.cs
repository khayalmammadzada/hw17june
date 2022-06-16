using System;
namespace hw17june
{
    public class Baku : ICity
    {

        private Human[] _humans;
        public Human[] Humans { get => _humans;}

        public void AddHuman(Human human)
        {
            Array.Resize(ref _humans, _humans.Length + 1);
            _humans[_humans.Length - 1] = human;
        }

        public void GetStudents()
        {
            Human[] stdArr = new Student[0];
          
            foreach(var item in _humans)
            {
                if (item is Student)
                {
                    
                    Array.Resize(ref stdArr, stdArr.Length + 1);
                    stdArr[stdArr.Length - 1] = item;
                }
            }
        }


        public void GetEmployees()
        {
            Human[] empArr = new Employee[0];

            foreach (var item in _humans)
            {
                if (item is Employee)
                {

                    Array.Resize(ref empArr, empArr.Length + 1);
                    empArr[empArr.Length - 1] = item;
                }
            }
        }


        
        public string SearchHumans(Human[] humans, string str)
        {
            string fullname = "";
            
            
            for (int i = 0; i < humans.Length; i++)
                
            if (fullname.Contains(str))
            {
                    foreach(var item in humans)
                    {
                        
                    }
            }
            
        }





    }
}
