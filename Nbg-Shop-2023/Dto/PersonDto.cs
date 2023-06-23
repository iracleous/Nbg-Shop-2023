using Nbg_Shop_2023.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nbg_Shop_2023.Dto
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
        public Category? Category { get; set; }
        public int? Age { get; set; }
        public int Rank { get; set; }
        public string? AccountName { get; set; } 

         
    }
}
