using System;

// Clase abstracta Alumno
abstract class Alumno
{
    public string Nombre { get; set; }
    public string NumeroCuenta { get; set; }
    public string Email { get; set; }

    // Método abstracto Imprimir
    public abstract void Imprimir();
}