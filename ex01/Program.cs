namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 5, 31, 6, 13, 4, 7, 2, 45, 22, 1 };
            Console.WriteLine("Cuantos nElem quieres: ");
            int nElem = Convert.ToInt32(Console.ReadLine());
            int[] array2 = CreateArray2(array1.Length, nElem);

            Console.WriteLine("Array1: " + string.Join(", ", array1));
            Console.WriteLine("Array2: " + string.Join(", ", array2));
        }

        static int[] CreateArray2(int mida, int nElem)
        {
            Random rand = new Random();
            int[] array2 = new int[nElem];

            for (int i = 0; i < nElem; i++)
            {
                array2[i] = rand.Next(mida);
            }

            Array.Sort(array2);

            return array2;
        }
    }
}