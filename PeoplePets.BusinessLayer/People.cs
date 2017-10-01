using System;
using System.Collections.Generic;
using System.Linq;
using PeoplePets.BusinessLayer.Interface;
using PeoplePets.ServiceWrapper;

namespace PeoplePets.BusinessLayer
{
    public class People : IPeople
    {
        public IEnumerable<Owner> GetOwnerCatNames()
        {
            try
            {
                var owners = new PeopleWrapper().GetOwners();
                if (owners != null && owners.Any())
                {
                    var maleOwnerCatNames = owners.Where(o => o.Gender.Equals("male", StringComparison.InvariantCultureIgnoreCase) && o.Pets != null)
                        .SelectMany(o => o.Pets.Where(p => p.Type.Equals("cat", StringComparison.InvariantCultureIgnoreCase)))
                        .OrderBy(p => p.Name)
                        .Select(p => p.Name).ToList();

                    var maleOwner = new Owner()
                    {
                        Gender = "Male",
                        CatNames = maleOwnerCatNames
                    };

                    var femaleOwnerCatNames = owners.Where(o => o.Gender.Equals("female", StringComparison.InvariantCultureIgnoreCase) && o.Pets != null)
                        .SelectMany(o => o.Pets.Where(p => p.Type.Equals("cat", StringComparison.InvariantCultureIgnoreCase)))
                        .OrderBy(p => p.Name)
                        .Select(p => p.Name).ToList();

                    var femaleOwner = new Owner()
                    {
                        Gender = "Female",
                        CatNames = femaleOwnerCatNames
                    };

                    return new List<Owner>() { maleOwner, femaleOwner };
                }
                else
                {
                    return new List<Owner>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}