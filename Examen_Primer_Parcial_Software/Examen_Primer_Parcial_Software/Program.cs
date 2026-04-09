namespace Examen_Primer_Parcial_Software;

class Program
{
    static void Main(string[] args)
    {
        // ===================================
        // PARTE 1: SOLUCIÓN REFACTORIZADA
        // ===================================

        int[] vectorOriginal = LeerVector();


        // ========================================
        // PARTE 2: NUEVA SOLUCIÓN (ALGORITMO)
        // ========================================
    }

    static int[] LeerVector()
    {
        Console.Write("Ingrese tamaño del vector: ");
        int cantidad = int.Parse(Console.ReadLine()!);

        int[] vector = new int[cantidad];
        int i = 0;

        while (i < cantidad)
        {
            Console.Write("Ingrese valor [" + i + "]: ");
            vector[i] = int.Parse(Console.ReadLine()!);
            i++;
        }

        return vector;
    }

    // ==============================
    // PARTE 3: JUSTIFICACIÓN
    // ==============================
    //
    // 1. Cambios realizados:
    // - ...
    //
    // 2. Decisiones de diseño:
    // - ...
    //
    // 3. Explicación del nuevo algoritmo:
    // - ...
    //
}