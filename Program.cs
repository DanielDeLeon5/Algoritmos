using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numeros = new int[100];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(1, 99);
            }

            Console.WriteLine("1. Obtener el numero mayor y el numero menor");
            int mayor = 0, menor = 99;
            for(int i = 0; i < numeros.Length; i++)
            {
                if(mayor < numeros[i])
                {
                    mayor = numeros[i];
                }

                if(menor > numeros[i])
                {
                    menor = numeros[i];
                }
            }
            Console.WriteLine("Mayor: " + mayor);
            Console.WriteLine("Menor: " + menor);

            Console.WriteLine("\n2. Arreglo ardenado");
            int[] arregloA = numeros;
            for (int i = 0; i < arregloA.Length; i++)
            {
                for (int n = 0; n < arregloA.Length - i - 1; n++)
                {
                    if (arregloA[n] < arregloA[n + 1])
                    {
                        int tmp = arregloA[n + 1];
                        arregloA[n + 1] = arregloA[n];
                        arregloA[n] = tmp;
                    }
                }
            }
            for(int i = 0; i < arregloA.Length; i++)
            {
                Console.WriteLine(arregloA[i]);
            }

            Console.WriteLine("\n3. Nuevo arreglo sin elementos repetidos");
            List<int> arregloB = new List<int>();
            for (int i = 0; i < numeros.Length; i++)
            {   
                int cont = 0;
                foreach(int n in arregloB)
                {
                    if(numeros[i] == n)
                    {
                        cont++;
                    }
                }
                if(cont == 0)
                {
                    arregloB.Add(numeros[i]);
                }
            }
  
            for ( int i = 0; i < arregloB.Count(); i++)
            {
                Console.WriteLine(arregloB[i]);
            }

            Console.WriteLine("\n4. Cantidad de veces que aparece una letra en un string");
            var randomLetras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] cadena = new char[100];
  
            Dictionary<char, int> letras = new Dictionary<char, int>();
            for (int i = 0; i < cadena.Length; i++)
            {
                cadena[i] = randomLetras[random.Next(randomLetras.Length)];
            }

            for(int i = 0; i < cadena.Length; i++)
            {
                int cont = 1;
               
                foreach(KeyValuePair<char, int> l in letras)
                {
                    if(l.Key == cadena[i])
                    {
                        cont = l.Value + 1;
                    }
                }
                if(cont == 1)
                {
                    letras.Add(cadena[i], cont);
                }
                else
                {
                    letras[cadena[i]] = cont;
                }
            }
            Console.WriteLine(cadena);

            foreach (KeyValuePair<char, int> l in letras)
            {
                Console.WriteLine(l.Key + ": " + l.Value);
            }

            Console.WriteLine("\n5. Palabra mas larga de un string");
            string frase = "Esta es una frase para comprobar cual es la palabra mas grande";
            //List<string> palabras = new List<string>();
            string[] palabras = frase.Split(' ');
            int indiceMayor = 0;
            int cantidadMayor = 0;
            for(int i = 0; i < palabras.Length; i++)
            {
                if(cantidadMayor < palabras[i].Length)
                {
                    indiceMayor = i;
                    cantidadMayor = palabras[i].Length;
                }
            }

            Console.WriteLine("Palabra mas grande: " + palabras[indiceMayor]);
            Console.WriteLine("Cantidad de letras: " + cantidadMayor);


            Console.ReadKey();
        }
    }
}
