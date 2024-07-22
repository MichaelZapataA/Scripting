 namespace Taller1Scripting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5 / 3;

            string respuesta = x > 0 ? "A" : "B";

            Console.WriteLine(respuesta);
            Console.WriteLine(x);

            
        }

        public static void imprimirMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write("| ");
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        Console.Write(matriz[i, j] + " ");

                    }
                    else
                    {

                        Console.Write(" " + matriz[i, j] + " ");
                    }
                }
                Console.Write(" |");
                Console.WriteLine();
            }
        }

        public static void funcion1()
        {
            int[,] matriz = { { -1, 2, -3 }, { 6, -8, 9 }, { -3, 4, -5 } };

            Console.WriteLine("Matriz original");

            imprimirMatriz(matriz);


            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = matriz[i, j] < 0 ? matriz[i, j] * -1 : matriz[i, j];
                }
            }

            Console.WriteLine("Matriz final");

            imprimirMatriz(matriz);
            
        }

        public static string funcion6()
        {
            Console.Write("Ingrese la cantidad de numeros impares que desea sumar: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int impar = 1;
            int suma = 0;
            do
            {
                suma += impar;
                impar += 2;
                i++;
            }while (i < n);

            return "La suma de los primeros " + n + " numeros primos es: " + suma;
        }


        public static string funcion9() {

            Console.Write("Ingrese la frase: ");

            string frase = Console.ReadLine();

            string fraseFinal = System.Globalization.CultureInfo.InvariantCulture.TextInfo.ToTitleCase(frase);

            return fraseFinal;
        }

        public static void funcion15()
        {
            Console.Write("Ingrese la frase: ");

            string frase = Console.ReadLine().ToLower().Replace(" ", "");


            string fraseR = "";

            for (int i = frase.Length - 1; i >= 0; i--)
            {
                fraseR += frase[i];
            }

            if (frase == fraseR)
            {
                Console.WriteLine("La frase ingresada es un palindromo");
            }
            else
            {
                Console.WriteLine("La frase ingresada NO es un palindromo");

            }
        }

        public static string funcion18()
        {

            Console.Write("Ingrese el numero de maximo 8 cifras: ");

            string num = Console.ReadLine();
            int suma = 0;
            int aux = 0;

            while (num.Length > 1) {
                for (int i = 0; i < num.Length; i++)
                {
                    aux = Convert.ToInt32(Convert.ToString(num[i]));
                    suma += aux;
                }
                num = Convert.ToString(suma);
                Console.WriteLine(suma);
                suma = 0;
            }

            return "El resultado es: " + num;
        }

        //public static void teorica4()
        //{
        //    int c;
        //    c = ++c;
        //    Console.WriteLine(c);
        //}

        
    }
}
