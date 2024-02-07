namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 5, 31, 6, 13, 4, 7, 2, 45, 22, 1 };
            Console.WriteLine("Cuantos nElem quieres: ");
            int nElem = Convert.ToInt32(Console.ReadLine());
            int[] array2 = CrearSegundaArrray(array1.Length, nElem);

            Console.WriteLine("Array1: " + string.Join(", ", array1));
            Console.WriteLine("Array2: " + string.Join(", ", array2));
            int[] array1ParcialmenteOrganizado = OrganizarParcialmenteArray1(array1, array2);
            Console.WriteLine("Array1: " + string.Join(", ", array1ParcialmenteOrganizado));
        }

        static int[] CrearSegundaArrray(int mida, int nElem)
        {
            Random rand = new Random();
            int[] array2 = new int[nElem];
            int contador = 0;
            for (int i = 0; i < nElem; i++)
            {
                if (contador == 0)
                {
                    array2[i] = rand.Next(mida);
                    contador++;
                    i++;
                }
                int num;
                do
                {
                    num = rand.Next(mida);
                } while (Array.IndexOf(array2, num) != -1);
                array2[i] = num;
                contador++;
            }

            Array.Sort(array2);

            return array2;
        }
        static int[] OrganizarParcialmenteArray1(int[] array1, int[] array2)
        {
            int[] array1ParcialmenteOrganizado = (int[])array1.Clone();
            int[] elementosSeleccionados = new int[array2.Length];

            for (int i = 0; i < array2.Length; i++)
            {
                elementosSeleccionados[i] = array1[array2[i]];
            }

            Array.Sort(elementosSeleccionados);

            for (int i = 0; i < array2.Length; i++)
            {
                array1ParcialmenteOrganizado[array2[i]] = elementosSeleccionados[i];
            }

            return array1ParcialmenteOrganizado;
        }
    }
}