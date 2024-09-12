using System.ComponentModel.DataAnnotations;

public class Usuario
{
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(50, 
        ErrorMessage = "El nombre no puede tener más de 50 caracteres")]
    public string Nombre { get; set; }
    [Required(ErrorMessage = "El correo es obligatorio.")]
    [EmailAddress(
        ErrorMessage = "Debe proporcionar una dirección de correo válida")]
    public string CorreoElectronico { get; set;}
    [Required(ErrorMessage = "La edad es obligatoria.")]
    [Range(18, 99, 
        ErrorMessage = "La edad debe estar entre 18 y 99 años")]
    public int Edad { get; set; }
    [RegularExpression(@"^\d{9}$", 
        ErrorMessage = "El número de teléfono debe tener exactamente 9 dígitos.")]
    public string NumeroTelefono { get; set; }
}

