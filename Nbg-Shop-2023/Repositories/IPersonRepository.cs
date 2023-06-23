using Nbg_Shop_2023.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nbg_Shop_2023.Repositories
{
    public interface IPersonRepository
    {
        //CRUD
        public Person Create(Person person);
        public IEnumerable<Person> GetAll();
        public Person GetByPersonId(int personId);
        public Person Update(int personId, Person person);
        public bool DeletePerson(int personId);
    }
}
