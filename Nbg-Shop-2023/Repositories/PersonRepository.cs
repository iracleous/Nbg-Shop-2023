using Nbg_Shop_2023.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nbg_Shop_2023.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly List<Person> _people;

        public PersonRepository()
        {
            _people = new List<Person>();
           
        }

        public Person Create(Person person)
        {
            _people.Add(person);
            return person;
        }

        public bool DeletePerson(int personId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public Person GetByPersonId(int personId)
        {
            throw new NotImplementedException();
        }

        public Person Update(int personId, Person person)
        {
            throw new NotImplementedException();
        }
    }
}
