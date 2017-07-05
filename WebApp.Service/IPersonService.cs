using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Model;

namespace WebApp.Service
{
    public interface IPersonService
    {
         void SavePerson(Person person);
    }
}
