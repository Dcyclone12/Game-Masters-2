using System;
using System.Text.RegularExpressions;

class InputValidator
{
    // Username validation
    public static bool IsUsernameValid(string username)
    {
        
        // For example, allowing alphanumeric characters and underscores, with a length between 3 and 20
        string pattern = @"^[a-zA-Z0-9_]{3,20}$";
        return Regex.IsMatch(username, pattern);
    }

        // Password validation
    public static bool IsPasswordValid(string password)
    {
       
        // requiring a minimum of 8 characters, including at least one uppercase letter, one lowercase letter, and one digit
        string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";
        return Regex.IsMatch(password, pattern);
    }

        // Email validation
    public static bool IsEmailValid(string email)
    {
        // email validation regex 
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        return Regex.IsMatch(email, pattern);
    }

        // Date validation 
    public static bool IsDateValid(string date)
    {
        
        return DateTime.TryParse(date, out _);
    }

    static void Main()
    {
        Console.Write("Enter a username: ");
        string username = Console.ReadLine();

        if (IsUsernameValid(username))
        {
            Console.WriteLine("Username is valid!");
        }
        else
        {
            Console.WriteLine("Invalid username. Please follow the specified rules.");
        }

        Console.Write("Enter a password: ");
        string password = Console.ReadLine();

        if (IsPasswordValid(password))
        {
            Console.WriteLine("Password is valid!");
        }
        else
        {
            Console.WriteLine("Invalid password. Please follow the specified rules.");
        }

        Console.Write("Enter an email address: ");
        string email = Console.ReadLine();

        if (IsEmailValid(email))
        {
            Console.WriteLine("Email is valid!");
        }
        else
        {
            Console.WriteLine("Invalid email. Please enter a valid email address.");
        }

        Console.Write("Enter a date (MM/DD/YYYY): ");
        string dateInput = Console.ReadLine();

        if (IsDateValid(dateInput))
        {
            Console.WriteLine("Date is valid!");
        }
        else
        {
            Console.WriteLine("Invalid date. Please enter a valid date in the specified format.");
        }
    }
}

