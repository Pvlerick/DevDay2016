using System.Collections.Generic;

namespace Singletons
{
    public interface IPersonRespository
    {
        IEnumerable<Person> GetAll();
    }
}