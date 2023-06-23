using Nbg_Shop_2023.Models;
using Nbg_Shop_2023.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nbg_Shop_2023.Services
{
    public class EshopService : IEshopService
    {
        private IPersonRepository _personRepository;

        public Person Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool Logout(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Person Register(Person person)
        {
            return _personRepository.Create(person);
        }
    }
}
