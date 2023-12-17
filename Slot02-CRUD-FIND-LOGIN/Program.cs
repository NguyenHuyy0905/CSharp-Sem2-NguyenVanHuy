using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<User> users = new List<User>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Create user");
            Console.WriteLine("2. Read users");
            Console.WriteLine("3. Update user");
            Console.WriteLine("4. Delete user");
            Console.WriteLine("5. Find user");
            Console.WriteLine("6. Login");
            Console.WriteLine("7. Exit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateUser();
                    break;
                case "2":
                    ReadUsers();
                    break;
                case "3":
                    UpdateUser();
                    break;
                case "4":
                    DeleteUser();
                    break;
                case "5":
                    FindUser();
                    break;
                case "6":
                    Login();
                    break;
                case "7":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CreateUser()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        User newUser = new User { Username = username, Password = password };
        users.Add(newUser);

        Console.WriteLine("User created successfully.");
    }

    static void ReadUsers()
    {
        if (users.Any())
        {
            Console.WriteLine("List of users:");
            foreach (var user in users)
            {
                Console.WriteLine($"Username: {user.Username}, Password: {user.Password}");
            }
        }
        else
        {
            Console.WriteLine("No users found.");
        }
    }

    static void UpdateUser()
    {
        Console.Write("Enter username to update: ");
        string username = Console.ReadLine();

        User userToUpdate = users.FirstOrDefault(u => u.Username == username);

        if (userToUpdate != null)
        {
            Console.Write("Enter new password: ");
            string newPassword = Console.ReadLine();

            userToUpdate.Password = newPassword;
            Console.WriteLine("User updated successfully.");
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }

    static void DeleteUser()
    {
        Console.Write("Enter username to delete: ");
        string username = Console.ReadLine();

        User userToDelete = users.FirstOrDefault(u => u.Username == username);

        if (userToDelete != null)
        {
            users.Remove(userToDelete);
            Console.WriteLine("User deleted successfully.");
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }

    static void FindUser()
    {
        Console.Write("Enter username to find: ");
        string username = Console.ReadLine();

        User foundUser = users.FirstOrDefault(u => u.Username == username);

        if (foundUser != null)
        {
            Console.WriteLine($"User found - Username: {foundUser.Username}, Password: {foundUser.Password}");
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }

    static void Login()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        User loginUser = users.FirstOrDefault(u => u.Username == username && u.Password == password);

        if (loginUser != null)
        {
            Console.WriteLine("Login successful.");
        }
        else
        {
            Console.WriteLine("Login failed. Invalid username or password.");
        }
    }
}

class User
{
    public string Username { get; set; }
    public string Password { get; set; }
}
