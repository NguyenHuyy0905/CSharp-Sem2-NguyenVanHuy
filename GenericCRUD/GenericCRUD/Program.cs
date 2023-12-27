using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var repository = new GenericRepository<Person>();

        // Thêm mới
        var newPerson = new Person { Id = 1, Name = "John Doe", Age = 30 };
        repository.Insert(newPerson);
        repository.Save();

        // Lấy tất cả
        Console.WriteLine("All Persons:");
        DisplayPersons(repository.GetAll());

        // Cập nhật
        var personToUpdate = repository.GetById(1);
        if (personToUpdate != null)
        {
            personToUpdate.Age = 31;
            repository.Update(personToUpdate);
            repository.Save();
        }
        Console.WriteLine("Persons after update:");
        DisplayPersons(repository.GetAll());

        // Xóa
        repository.Delete(1);
        repository.Save();
        Console.WriteLine("Persons after delete:");
        DisplayPersons(repository.GetAll());
    }

    static void DisplayPersons(List<Person> persons)
    {
        foreach (var person in persons)
        {
            Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, Age: {person.Age}");
        }
        Console.WriteLine();
    }
}