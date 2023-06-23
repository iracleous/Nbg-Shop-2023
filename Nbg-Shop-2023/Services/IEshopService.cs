using Nbg_Shop_2023.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nbg_Shop_2023.Services
{
    public interface IEshopService
    {
        public PersonDto Login(string username, string password);
        public bool Logout(string username, string password);
        public Person Register(Person person);
    }
}
