using System.Collections.Generic;

namespace PeoplePets.BusinessLayer.Interface
{
    public interface IPeople
    {
        IEnumerable<Owner> GetOwnerCatNames();
    }
}
