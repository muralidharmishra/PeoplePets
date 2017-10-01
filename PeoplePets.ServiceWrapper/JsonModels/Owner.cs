using System.Collections.Generic;

namespace PeoplePets.ServiceWrapper.JsonModels
{
    public class Owner
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public List<Pet> Pets { get; set; }
    }
}