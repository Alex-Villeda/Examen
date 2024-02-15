class Program
{
    static void Main()
    {
        // Bloque try / catch para capturar los datos del alumno y asignatura
        try
        {
            Console.Write("Ingrese el nombre del alumno: ");
            string nombreAlumno = Console.ReadLine();

            Console.Write("Ingrese el número de cuenta del alumno: ");
            string numeroCuenta = Console.ReadLine();

            Console.Write("Ingrese el email del alumno: ");
            string email = Console.ReadLine();

            Console.Write("Ingrese el nombre de la asignatura: ");
            string nombreAsignatura = Console.ReadLine();

            Console.Write("Ingrese el horario de la asignatura: ");
            string horario = Console.ReadLine();

            Console.Write("Ingrese el docente de la asignatura: ");
            string docente = Console.ReadLine();

            // Crear objeto de la clase Asignatura
            Asignatura asignatura = new Asignatura
            {
                Nombre = nombreAlumno,
                NumeroCuenta = numeroCuenta,
                Email = email,
                NombreAsignatura = nombreAsignatura,
                Horario = horario,
                Docente = docente
            };

            // Imprimir datos del alumno y asignatura
            asignatura.Imprimir();

            // Bloque try / catch para capturar las notas parciales
            try
            {
                Console.Write("Ingrese la nota del primer parcial: ");
                double notaParcial1 = double.Parse(Console.ReadLine());

                Console.Write("Ingrese la nota del segundo parcial: ");
                double notaParcial2 = double.Parse(Console.ReadLine());

                Console.Write("Ingrese la nota del tercer parcial: ");
                double notaParcial3 = double.Parse(Console.ReadLine());

                // Crear objeto de la clase Nota
                Nota nota = new Nota();

                // Calcular la nota final
                double notaFinal = nota.CalcularNotaFinal(notaParcial1, notaParcial2, notaParcial3);

                // Mostrar el mensaje de la nota
                Console.WriteLine($"Resultado: {nota.MensajeNota(notaFinal)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("¡Error! Ingrese un valor numérico para las notas.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"¡Error! {ex.Message}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"¡Error! {ex.Message}");
        }
    }
}