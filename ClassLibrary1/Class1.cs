namespace PersonLibrary
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public static string GetPersonInfo(Person person)
        {
            return $"Name: {person.Name}, Age: {person.Age}";
        }
    }
}