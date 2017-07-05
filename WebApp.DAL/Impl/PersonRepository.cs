using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.DAL;
using WebApp.Model;

namespace WebApp.DAL.Impl
{
    public class PersonRepository : Repository<Person, int>, IPersonRepository
    {

    }
}
