using PeopleWork.Services;
using System;

namespace PeopleWork
{
    class Program
    {
        static void Main(string[] args)
        {
            IPeopleRepasitory people = new PeopleRepasitory();
            people.AddPeople();
            var data = people.SearchPeople(2);
            Console.WriteLine(data);
        }
    }
}