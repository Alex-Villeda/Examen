// Clase Nota que implementa la interfaz INota
class Nota : INota
{
    private double notaParcial1;
    private double notaParcial2;
    private double notaParcial3;

    // Constructor con parámetros
    public Nota(double notaParcial1, double notaParcial2, double notaParcial3)
    {
        this.notaParcial1 = notaParcial1;
        this.notaParcial2 = notaParcial2;
        this.notaParcial3 = notaParcial3;
    }

    // Constructor sin parámetros
    public Nota()
    {
        // Inicializar las notas en 0 por defecto
        notaParcial1 = 0;
        notaParcial2 = 0;
        notaParcial3 = 0;
    }

    // Implementación del método CalcularNotaFinal
    public double CalcularNotaFinal(double notaParcial1, double notaParcial2, double notaParcial3)
    {
        if (ValidarNotas(notaParcial1, notaParcial2, notaParcial3))
        {
            return notaParcial1 + notaParcial2 + notaParcial3;
        }
        else
        {
            Console.WriteLine("¡Error! Nota parcial fuera de rango.");
            return -1; // Retornar un valor indicativo de error
        }
    }

    // Implementación del método MensajeNota
    public string MensajeNota(double notaFinal)
    {
        if (notaFinal < 0)
        {
            return "Error al calcular la nota final.";
        }

        if (notaFinal >= 0 && notaFinal < 60)
        {
            return "Reprobado";
        }
        else if (notaFinal >= 60 && notaFinal < 80)
        {
            return "Bueno";
        }
        else if (notaFinal >= 80 && notaFinal < 90)
        {
            return "Muy Bueno";
        }
        else if (notaFinal >= 90 && notaFinal <= 100)
        {
            return "Sobresaliente";
        }
        else
        {
            return "Error al determinar el rango de notas.";
        }
    }

    // Método privado para validar las notas parciales
    private bool ValidarNotas(double notaParcial1, double notaParcial2, double notaParcial3)
    {
        // Validar que las notas estén dentro del rango permitido
        if (notaParcial1 > 30 || notaParcial2 > 30 || notaParcial3 > 40)
        {
            return false;
        }
        return true;
    }
}