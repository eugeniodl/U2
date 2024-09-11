public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public static class PersonExtensions
{
    // Método de extensión para filtrar personas por edad
    public static Person[] FilterByAge(this Person[] people, int minAge)
    {
        // Contar cuántas personas cumplen con el criterio
        int count = 0;
        foreach (Person person in people)
        {
            if (person.Age >= minAge)
                count++;
        }

        // Crear un nuevo arreglo del tamaño adecuado
        var result = new Person[count];
        int index = 0;

        // Rellenar el nuevo arreglo con las personas que cumplen con el criterio
        foreach(Person person in people)
        {
            if(person.Age >= minAge)
                result[index++] = person;
        }
        return result;
    }
}