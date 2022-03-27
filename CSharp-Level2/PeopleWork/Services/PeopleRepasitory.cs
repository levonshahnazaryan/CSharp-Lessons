using PeopleWork.Enums;
using PeopleWork.Models;
using System.Collections.Generic;

namespace PeopleWork.Services
{
    public class PeopleRepasitory : People, IPeopleRepasitory
    {
        public void AddPeople()
        {
            PeopleName = new Dictionary<int, string>();
            PeopleAge = new Dictionary<int, int>();
            PeopleSalery = new Dictionary<int, double>();
            PeopleMarriage = new Dictionary<int, bool>();
            PeopleFamily = new List<PeopleFamily>();
            PeopleCar = new List<PeopleCar>();

            PeopleName.Add(1, "Vahagn");
            PeopleName.Add(2, "Samvel");

            PeopleAge.Add(1, 37);
            PeopleAge.Add(2, 34);

            PeopleSalery.Add(1, 500000);
            PeopleSalery.Add(2, 300000);

            PeopleMarriage.Add(1, true);
            PeopleMarriage.Add(2, false);

            PeopleFamily.Add(new PeopleFamily
            {
                PeopleId = 1,
                Type = (int)FamilyType.Wife,
                Name = "Arevik"
            });
            PeopleFamily.Add(new PeopleFamily
            {
                PeopleId = 1,
                Type = (int)FamilyType.Sun,
                Name = "Arsen"
            });

            PeopleCar.Add(new PeopleCar
            {
                PeopleId = 1,
                CarMark = "Kia",
                CarPrice = 25000
            });

            PeopleCar.Add(new PeopleCar
            {
                PeopleId = 2,
                CarMark = "Reno",
                CarPrice = 3000
            });
        }

        public string SearchPeople(double salery)
        {
            int peopleId = 0;
            foreach (var item in PeopleSalery)
            {
                if (item.Value.Equals(salery))
                    peopleId = item.Key;
            }
            if (peopleId == 0)
                return "No Data";
            return GetPeopleData(peopleId);
        }
        public string SearchPeople(decimal carPrice)
        {
            int peopleId = 0;
            foreach (var item in PeopleCar)
            {
                if (item.CarPrice.Equals(carPrice))
                    peopleId = item.PeopleId;
            }
            if (peopleId == 0)
                return "No Data";
            return GetPeopleData(peopleId);
        }
        public string SearchPeople(int familyCount)
        {
            var data = PeopleFamily;

            return "";
        }
        public string SearchPeople(string name)
        {
            int peopleId = 0;
            foreach (var item in PeopleName)
            {
                if (item.Value.Equals(name))
                    peopleId = item.Key;
            }
            if (peopleId == 0)
                return "No Data";
            return GetPeopleData(peopleId);
        }
        private string GetPeopleData(int peopleId)
        {
            PeopleName.TryGetValue(peopleId, out string name);
            PeopleAge.TryGetValue(peopleId, out int age);
            PeopleSalery.TryGetValue(peopleId, out double salery);
            PeopleMarriage.TryGetValue(peopleId, out bool isMarriage);

            string family = "";
            foreach (var item in PeopleFamily)
            {
                if (item.PeopleId == peopleId)
                    family += item.Name + ", ";
            }
            if (string.IsNullOrEmpty(family))
                family = "No Data, ";

            string car = "";
            foreach (var item in PeopleCar)
            {
                if (item.PeopleId == peopleId)
                    car += item.CarMark + ", " + item.CarPrice + "$";
            }
            if (string.IsNullOrEmpty(car))
                car = "No Data, ";

            return $"Name: {name}, Age: {age}, Salery: {salery}$, Is Marriage: {isMarriage}, Family: {family} Car: {car}";
        }
    }
}