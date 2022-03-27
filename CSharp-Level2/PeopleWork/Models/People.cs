using System.Collections.Generic;

namespace PeopleWork.Models
{
    public class People
    {
        public Dictionary<int, string> PeopleName { get; set; }
        public Dictionary<int, int> PeopleAge { get; set; }
        public Dictionary<int, double> PeopleSalery { get; set; }
        public Dictionary<int, bool> PeopleMarriage { get; set; }
        public List<PeopleFamily> PeopleFamily { get; set; }
        public List<PeopleCar> PeopleCar { get; set; }
    }
}