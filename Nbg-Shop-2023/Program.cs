// See https://aka.ms/new-console-template for more information
using Nbg_Shop_2023.Models;
using Nbg_Shop_2023.Repositories;

Console.WriteLine("Hello, World!");

var person = new Person{ 
    Id = 3, 
    Name = "Mar", 
};

Console.WriteLine($"Name= {person.Name} " +
    $"Age= {person.Age} Rank= {person.Rank}" +
    $" Category={person.Category}");


IPersonRepository personRepository = new EmployeeRepository();

personRepository.Create( person );

