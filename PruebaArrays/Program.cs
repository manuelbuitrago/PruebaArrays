namespace PruebaArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] miArray = new int[5,5];
            
            Random num = new Random();

            Console.WriteLine("Introduce un número");
            
            Console.WriteLine("___________________");

            int elige = int.Parse(Console.ReadLine());

            Console.WriteLine();

            bool es = false;

            Console.WriteLine("ARRAY DE NUMEROS ALEATORIOS \n");

            for (int i = 0;i < miArray.GetLength(0);i++)
            {
                for (int j = 0;j < miArray.GetLength(1); j++)
                {
                    int aleatorio = num.Next(1, 100);

                    miArray[i, j] = aleatorio;

                    Console.Write(miArray[i,j] + " ");
                    
                    if (elige == miArray[i, j]) es = true;
                }

                Console.WriteLine("\n");
            }

            if (es == true)
            {
                Console.WriteLine($"El número {elige} está en el array");
            }
            else Console.WriteLine($"El número {elige} no está en el array");
        }
    }
}