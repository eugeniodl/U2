using System.ComponentModel.DataAnnotations;

var usuario = new Usuario()
{
    Nombre = "Juan Pérez",
    CorreoElectronico = "juan.perez@ejemplo.com",
    Edad = 25,
    NumeroTelefono = "123456789"
};

var contexto = new ValidationContext(usuario, 
    serviceProvider: null, items: null);
var resultados = new List<ValidationResult>();

bool esValido = Validator.TryValidateObject(usuario,
    contexto, resultados, true);

if(esValido)
{
    Console.WriteLine("El usuario es válido");
}
else
{
    foreach(var item in resultados)
    { 
        Console.WriteLine(item.ErrorMessage); 
    }
}