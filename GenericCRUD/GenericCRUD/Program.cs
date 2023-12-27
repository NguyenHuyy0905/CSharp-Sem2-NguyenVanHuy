using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var personRepository = new GenericRepository<Person>();

        // Thêm mới
        var newPerson = new Person { Id = 1, Name = "John Doe", Age = 30 };
        personRepository.Insert(newPerson);
        personRepository.Save();

        // Lấy tất cả
        Console.WriteLine("All Persons:");
        DisplayPerson(personRepository.GetAll());

        // Cập nhật
        var personToUpdate = personRepository.GetById(1);
        if (personToUpdate != null)
        {
            personToUpdate.Age = 31;
            personRepository.Update(personToUpdate);
            personRepository.Save();
        }
        Console.WriteLine("Persons after update:");
        DisplayPerson(personRepository.GetAll());

        // Xóa
        personRepository.Delete(1);
        personRepository.Save();
        Console.WriteLine("Persons after delete:");
        DisplayPerson(personRepository.GetAll());

        // --------------------------------

        var productRepository = new GenericRepository<Product>();
        // Thêm mới
        var newProduct = new Product { Id = 1, Name = "iphone12", Price = 1000 };
        productRepository.Insert(newProduct);
        productRepository.Save();

        // Lấy tất cả
        Console.WriteLine("All Products:");
        DisplayProduct(productRepository.GetAll());

        // Cập nhật
        var newProductUpdate = productRepository.GetById(1);
        if (newProductUpdate != null)
        {
            newProductUpdate.Price = 1200;
            productRepository.Update(newProductUpdate);
            productRepository.Save();
        }
        Console.WriteLine("Products after update:");
        DisplayProduct(productRepository.GetAll());

        // Xóa
        productRepository.Delete(1);
        productRepository.Save();
        Console.WriteLine("Products after delete:");
        DisplayProduct(productRepository.GetAll());
    }

    static void DisplayPerson(List<Person> persons)
    {
        foreach (var person in persons)
        {
            Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, Age: {person.Age}");
        }
        Console.WriteLine();
    }

    static void DisplayProduct(List<Product> products)
    {
        foreach (var product in products)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
        }
        Console.WriteLine();
    }
}