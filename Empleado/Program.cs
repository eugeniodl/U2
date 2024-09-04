Empleado empleado = new Empleado("Ana", "Programadora", 33500m);
empleado.AumentarSalario(10);
Console.WriteLine($"Salario actual de {empleado.Nombre}: " +
    $"{empleado.ConsultarSalario():C}");

public class Empleado
{
    public string Nombre { get; set; }
    public string Puesto { get; set; }
    private decimal salario;

    // Constructor principal que inicializa el nombre, puesto y salario
    public Empleado(string nombre, string puesto, decimal salario)
    {
        Nombre = nombre;
        Puesto = puesto;
        this.salario = salario;
    }

    // Método para aumentar el salario
    public void AumentarSalario(decimal porcentaje)
    {
        if (porcentaje > 0)
        {
            salario += salario * porcentaje / 100;
            Console.WriteLine($"El salario de {Nombre} ha sido aumentado en " +
                $"{porcentaje}%. Nuevo salario: {salario:C}");
        }
    }

    // Método para consultar el salario
    public decimal ConsultarSalario()
    {
        return salario;
    }
}
