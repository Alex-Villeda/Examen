// Clase Asignatura que hereda de Alumno
class Asignatura : Alumno
{
    public string NombreAsignatura { get; set; }
    public string Horario { get; set; }
    public string Docente { get; set; }

    // Implementación del método Imprimir
    public override void Imprimir()
    {
        Console.WriteLine($"Datos del Alumno:");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Número de Cuenta: {NumeroCuenta}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Datos de la Asignatura:");
        Console.WriteLine($"Nombre de la Asignatura: {NombreAsignatura}");
        Console.WriteLine($"Horario: {Horario}");
        Console.WriteLine($"Docente: {Docente}");
    }
}