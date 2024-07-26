# Taller 1

---

## Punto 1

### Funciones

#### Ejercicio 15

> Realizar una función que calcule si una cadena es palindroma. 

```cs

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

```

![image](https://github.com/user-attachments/assets/3af6fb7e-fcd8-4353-8f09-ba1316653126)

#### Ejercicio 18

> Realice una función, que lea un número de máximo 8 cifras y luego sume cada dígito hasta obtener un valor de un solo dígito.
> ![image](https://github.com/user-attachments/assets/c604945d-568b-4dde-83b2-c330582c4722)

```cs

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

```

![image](https://github.com/user-attachments/assets/422589c3-76ff-4101-9858-cb89b8806375)

### Arreglos/Matrices

#### Ejercicio 1

> Recorra una matriz nxm y reemplace los valores negativos por un número positivo, como muestra el ejemplo:
> ![image](https://github.com/user-attachments/assets/2db8e1d5-de0b-4ca8-8bf3-3aaf2eeed044)

```cs

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

```

![image](https://github.com/user-attachments/assets/c3eeefb0-fe7c-4645-9fcd-db2d44e2153c)

### Condicionales/Ciclos

#### Ejercicio 6

> Usando un ciclo do-while calcule la suma de los primeros n números impares.


```cs

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

```

![image](https://github.com/user-attachments/assets/2de85fd2-9f95-4fb7-ac59-7eb8c00933bb)


### Cadenas

#### Ejercicio 9

> Lea una frase de mínimo 3 palabras y convierta cada palabra a minúscula y con mayúscula inicial como muestra el ejemplo:
> ![image](https://github.com/user-attachments/assets/fde0641e-abc7-4bc6-a289-32df2efe17cc)

```cs

    public static string funcion9() {

    Console.Write("Ingrese la frase: ");

    string frase = Console.ReadLine();

    string fraseFinal = System.Globalization.CultureInfo.InvariantCulture.TextInfo.ToTitleCase(frase);

    return fraseFinal;
}

```

![image](https://github.com/user-attachments/assets/f2ae274b-2503-4608-b8fe-32cdbead8fa9)


### Teoricas

#### Pregunta 9

> ¿Cuál es la respuesta al ejecutar las siguientes sentencias de código?
> ![image](https://github.com/user-attachments/assets/3a5cadb0-cdb1-40af-9774-e374e12b35d8)


> [!NOTE]
> Como la variable _x_ es un entero, se aplica la función piso y toma el valor _1_, por lo que en el operador ternario, la variable _respuesta_ toma el valor de _"A"_, sin embargo, no hay ninguna impresión por consola entonces no arroja ningún dato.

#### Pregunta 7 

> Escriba 10 palabras reservadas

> [!NOTE]
> 1. public
> 2. static
> 3. void
> 4. int
> 5. abstract
> 6. for
> 7. while
> 8. long
> 9. float
> 10. bool


---

## Punto 3

![image](https://github.com/user-attachments/assets/bff5dfae-061f-45ad-bfcd-a7a4ad3e3ec3)


---

## Punto 4

> Realizar 20 firmas diferentes de funciones con sus respectivas invocaciones, se debe evidenciar diferentes variaciones de funciones, con parametros, sin parametros, con retorno, sin retorno, usar diferentes tipos de datos como clases, cadenas, matrices, etc,.


1. ```cs
   //Firma
   public void empezar();
   //Invocacion
   empezar();
   ```
2. ```cs
   //Firma
   public static int suma(int a, int b);
   //Invocacion
   int sum = suma(1, 6);
   ```
3. ```cs
   //Firma
   private bool palindromo(string frase);
   //Invocacion
   bool pal = palindromo("Hannah");
   ```
4. ```cs
   //Firma
   private string numToLetra(int n);
   //Invocacion
   Console.WriteLine(numToLetra(3));
   ```
5. ```cs
   //Firma
   public static void reiniciar(bool VoF);
   //Invocacion
   reiniciar(true);
   ```
6. ```cs
   //Firma
   public float dividir(float numerador, float divisor);
   //Invocacion
   float resultado = dividir(4.8, 2.4);
   ```
7. ```cs
   //Firma
   private void imprimirMatriz(int[,] matriz);
   //Invocacion
   imprimirMatriz({{1 ,2}, {3, 4}});
   ```
8. ```cs
   //Firma
   public static string concatenar(string p1, string p2, string p3);
   //Invocacion
   string frase = concatenar("Buenos", "dias", "amigazo");
   ```
9. ```cs
   //Firma
   public int min(int[,] lista);
   //Invocacion
   int menor = min([1, 2, 5, -3]);
   ```
10. ```cs
    //Firma
    private char primeraLetra(string palabra);
    //Invocacion
    string letra = primeraLetra("Excelencia");
    ```
11. ```cs
    //Firma
    public static string mulPalabra(string palabra, int n);
    //Invocacion
    string palabraMult = mulPalabra("Hola", 7);
    ```
12. ```cs
    //Firma
    private int[,] crearMatriz(int[] a, int[] b, int[] c);
    //Invocacion
    int[,] matriz = crearMatriz([1,2,3],[4,5,6],[7,8,9]);
    ```
13. ```cs
    //Firma
    public static void llamarLista(string[] nombres);
    //Invocacion
    llamarLista(["Carlos", "Mauricio", "Vanessa"]);
    ```
14. ```cs
    //Firma
    private bool esPar(int n);
    //Invocacion
    if (esPar(2)){};
    ```
15. ```cs
    //Firma
    public float convertirAint(string numero);
    //Invocacion
    float num = convertirAint("7.2");
    ```
16. ```cs
    //Firma
    private static float calcularAreaRectangulo(float a, float b);
    //Invocacion
    float area = calcularAreaRectangulo(4.3, 7.9);
    ```
17. ```cs
    //Firma
    public string seleccionFruta(string[] frutas);
    //Invocacion
    string fruta = seleccionFruta(["Pera", "Manzana", "Fresa", "Uva"]);
    ```
18. ```cs
    //Firma
    public static string[] ordenarLista(string[] palabras, bool orden);
    //Invocacion
    string[] listaOrdenada = ordenarLista(["Camion", "Camisa", "Pato"], false);
    ```
19. ```cs
    //Firma
    private int potencia(int n, int exp);
    //Invocacion
    int resultado = potencia(3, 2);
    ```
20. ```cs
    //Firma
    public float pitagoras(float cateto1, float cateto2);
    //Invocacion
    float hipotenusa = pitagoras(3.5, 4.2);
    ```

---

## Bibliografía

- https://www.stationx.net/unix-commands-cheat-sheet/
- https://www.hostinger.co/tutoriales/comando-grep-linux
- https://escarbandocodigo.wordpress.com/2011/07/02/truco-capitalizar-una-frase-en-c-dejar-la-primer-letra-en-mayuscula/
  
