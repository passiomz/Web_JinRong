using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.DAL;

namespace WebApp.Service.Impl
{
    public class PersonService:IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }


        public void SavePerson(Model.Person person)
        {
            _personRepository.Insert(person);
        }
    }
}
