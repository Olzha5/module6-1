using PersonLibrary;
using System;

class Program
{
    static void Main()
    {
        Person person = new Person { Name = "John", Age = 30 };
        string info = Person.GetPersonInfo(person);
        Console.WriteLine(info);
        Console.WriteLine(Constants.Message);
        Console.WriteLine(Constants.Number);

    }
}

  