namespace Examen_Primer_Parcial_Software;

class Program
{
    static void Main(string[] args)
    {
        int[] vectorOriginal = LeerVector();

        // ===================================
        // PARTE 1: SOLUCIÓN REFACTORIZADA
        // ===================================

        int[] indicesAscendentes = ObtenerIndicesOrdenados(vectorOriginal, true);
        int[] indicesDescendentes = ObtenerIndicesOrdenados(vectorOriginal, false);

        Console.WriteLine("\n===== PARTE 1: SOLUCIÓN REFACTORIZADA =====");

        Console.WriteLine("\nVector ordenado ascendente:");
        ImprimirVectorOrdenado(vectorOriginal, indicesAscendentes);

        Console.WriteLine("\nVector ordenado descendente:");
        ImprimirVectorOrdenado(vectorOriginal, indicesDescendentes);

        // ========================================
        // PARTE 2: NUEVA SOLUCIÓN (ALGORITMO)
        // ========================================

        int[] indicesAscBurbuja = ObtenerIndicesOrdenadosBurbuja(vectorOriginal, true);
        int[] indicesDescBurbuja = ObtenerIndicesOrdenadosBurbuja(vectorOriginal, false);

        Console.WriteLine("\n===== PARTE 2: NUEVA SOLUCIÓN (ALGORITMO) =====");

        Console.WriteLine("\nVector ordenado ascendente:");
        ImprimirVectorOrdenado(vectorOriginal, indicesAscBurbuja);

        Console.WriteLine("\nVector ordenado descendente:");
        ImprimirVectorOrdenado(vectorOriginal, indicesDescBurbuja);

        Console.WriteLine("")
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
    static void ImprimirVectorOrdenado(int[] vector, int[] indices)
    {
        for (int i = 0; i < indices.Length; i++)
        {
            Console.WriteLine(vector[indices[i]]);
        }
    }

    static int[] ObtenerIndicesOrdenadosBurbuja(int[] vector, bool ascendente)
    {
        int[] indices = CrearVectorDeIndices(vector.Length);
        bool huboCambios;

        do
        {
            huboCambios = false;

            for (int i = 0; i < indices.Length - 1; i++)
            {
                bool estanFueraDeOrden = ascendente
                    ? vector[indices[i]] > vector[indices[i + 1]]
                    : vector[indices[i]] < vector[indices[i + 1]];

                if (estanFueraDeOrden)
                {
                    Intercambiar(indices, i, i + 1);
                    huboCambios = true;
                }
            }

        } while (huboCambios);

        return indices;
    }

    static int[] CrearVectorDeIndices(int cantidad)
    {
        int[] indices = new int[cantidad];

        for (int i = 0; i < cantidad; i++)
        {
            indices[i] = i;
        }

        return indices;
    }

    static void Intercambiar(int[] vector, int posicionA, int posicionB)
    {
        int temporal = vector[posicionA];
        vector[posicionA] = vector[posicionB];
        vector[posicionB] = temporal;
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