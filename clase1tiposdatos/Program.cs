using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace clase1tiposdatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definición de variables 
           int num1 = 10;   // variables enteras 32 bits
           int num2, num3;
           long larga = 10000000000; // variable entera larga 64 bits
           short corta = 10; // variable entera corta 16 bits
           byte byte1 = 255; // variable entera byte 8 bits 0 a 255
           sbyte byte2 = 25; // variable entera byte con signo 8 bits

            const float IVA = 13.0f; // variable constante de tipo string
             

            float flotante = 10.5f; // variable de punto flotante 32 bits
           double doble = 10.5; // variable de punto doble  64 bits
           decimal Decimal = 10.5m; // variable decimal 128 bits   

            char caracter = 'A'; // variable caracter 16 bits
            string cadena = "Hola Mundo"; // variable cadena de caracteres
            bool booleano = true; // variable booleana 1 bit
            object objeto = "Hola Mundo"; // variable objeto 32 bits

            // Definición de variables de tipo var

            var variableEntera = 3.5f; // variable entera
                variableEntera = 8.3f; // Asignación de valor a la variable variableEntera

            //Definición de variables de tipo dynamic


            int v1 = int.Parse(Console.ReadLine()); // Leer un valor de tipo int desde la consola
            float v2 = float.Parse(Console.ReadLine()); // Leer un valor de tipo float desde la consola                 

            double v3 = double.Parse(Console.ReadLine()); // Leer un valor de tipo double desde la consola
            decimal v4 = decimal.Parse(Console.ReadLine()); // Leer un valor de tipo decimal desde la consola
            byte v5 = byte.Parse(Console.ReadLine()); // Leer un valor de tipo byte desde la consola    



            dynamic variableDinamica = 3.5f; // variable dinámica
            variableDinamica = "Hola Mundo"; // Asignación de valor a la variable variableDinamica
            variableDinamica = 10; // Asignación de valor a la variable variableDinamica
            variableDinamica = 10.5; // Asignación de valor a la variable variableDinamica
            variableDinamica = 10.5m; // Asignación de valor a la variable variableDinamica
            variableDinamica = true; // Asignación de valor a la variable variableDinamica

            Console.Write("Digite el nombre: ");
            string nombre = Console.ReadLine(); // Leer un valor de tipo string desde la consola
           

            Console.Write("Digite su edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Mi nombre es: " + nombre + " tengo: " +  edad + " años");  // contenacion
            Console.WriteLine($"Mi nombre es: {nombre} tengo: {edad} años"); // interpolacion
            Console.WriteLine("Mi nombre es: {0} tengo: {1} años", nombre, edad); // interpolacion
            Console.Read();

        }
    }
}
