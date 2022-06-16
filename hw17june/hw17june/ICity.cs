using System;
namespace hw17june
{
    public interface ICity
    {


        Human[] Humans { get;}
        


        void AddHuman(Human human);

        void SearchHumans(string str);

    }

}
