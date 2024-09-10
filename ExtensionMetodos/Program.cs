string message = "Hello World";
string upperMessage = message.ToUpperIfContainsLower();
Console.WriteLine(upperMessage);

var people = new Person[]
{
    new Person { Name = "Leticia", Age = 30 },
    new Person { Name = "Rodrigo", Age = 18 },
    new Person { Name = "Ernesto", Age = 17 },
    new Person { Name = "Tania", Age = 24 },
    new Person { Name = "Pedro", Age = 21 }
};
var adults = people.FilterByAge(21);

foreach (Person person in adults)
    Console.WriteLine($"{person.Name}, Age: {person.Age}");


public static class StringExtensions
{
    public static string ToUpperIfContainsLower(this string str)
    {
        if(string.IsNullOrEmpty(str))
            return str;

        if(str.Any(char.IsLower))
        {
            return str.ToUpper();
        }

        return str;
    }
}