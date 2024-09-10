string message = "Hello World!";
string upperMessage = message.ToUpperIfContainsLower();

var people = new Person[]
{
    new Person{ Name = "Urania", Age = 25 },
    new Person{ Name = "Pedro", Age = 14 },
    new Person{ Name = "Lizeth", Age = 30 }
};

var adults = people.FilterByAge(21);

foreach (Person person in adults)
{
    Console.WriteLine($"{person.Name}, Age: {person.Age}");
}

public static class StringExtenssions
{
    public static string ToUpperIfContainsLower(this string str)
    {
        if(string.IsNullOrEmpty(str))
            return str;

        if(str.Any(char.IsLower))
            return str.ToUpper();

        return str;
    }
}