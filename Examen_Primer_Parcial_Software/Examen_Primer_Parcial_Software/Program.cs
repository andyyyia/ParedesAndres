namespace Examen_Primer_Parcial_Software;

class Program
{
    static void Main(string[] args)
    {
        // ===================================
        // PARTE 1: SOLUCIÓN REFACTORIZADA
        // ===================================

        int[] vectorOriginal = LeerVector();

        int[] indicesAscendentes = ObtenerIndicesOrdenados(vectorOriginal, true);
        int[] indicesDescendentes = ObtenerIndicesOrdenados(vectorOriginal, false);


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

    static int[] ObtenerIndicesOrdenados(int[] vector, bool ascendente)
    {
        int cantidad = vector.Length;
        int[] indicesOrdenados = new int[cantidad];
        bool[] usados = new bool[cantidad];
        int k = 0;

        while (k < cantidad)
        {
            int mejorIndice = -1;

            for (int i = 0; i < cantidad; i++)
            {
                if (usados[i] == false)
                {
                    if (mejorIndice == -1)
                    {
                        mejorIndice = i;
                    }
                    else
                    {
                        bool esMejor = ascendente
                            ? vector[i] < vector[mejorIndice]
                            : vector[i] > vector[mejorIndice];

                        if (esMejor)
                        {
                            mejorIndice = i;
                        }
                    }
                }
            }

            indicesOrdenados[k] = mejorIndice;
            usados[mejorIndice] = true;
            k++;
        }

        return indicesOrdenados;
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