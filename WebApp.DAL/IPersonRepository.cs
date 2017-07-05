using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Model;

namespace WebApp.DAL
{
    public interface IPersonRepository : IRepository<Person, int>
    {

    }
}
