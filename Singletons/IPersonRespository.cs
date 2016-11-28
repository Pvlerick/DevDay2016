using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletons
{
    public interface IPersonRespository
    {
        IEnumerable<Person> GetAll();
    }
}
