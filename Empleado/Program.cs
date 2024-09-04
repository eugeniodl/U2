Empleado empleado = new Empleado("Ana", "Programadora", 33500m);
empleado.AumentarSalario(10);

public class Empleado
{
    public string Nombre { get; set; }
    public string Puesto { get; set; }
    private decimal _salario;

    // Constructor principal que inicializa el nombre, puesto y salario
    public Empleado(string nombre, string puesto, decimal salario)
    {
        Nombre = nombre;
        Puesto = puesto;
        _salario = salario;
    }

    // Método para aumentar el salario
    public void AumentarSalario(decimal porcentaje)
    {
        if(porcentaje > 0)
        {
            _salario += _salario * porcentaje / 100;
            Console.WriteLine($"El salario de {Nombre} ha sido aumentado en " +
                $"{porcentaje}%. Nuevo salario: {_salario:C}");
        }
    }
}