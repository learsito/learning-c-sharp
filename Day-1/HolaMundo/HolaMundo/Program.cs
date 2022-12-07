using System;

namespace HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            string a = "Hola como estas";
            int num1 = 13;
            int num2 = 5;
            int sum = num1 + num2;
            //Conversion Implícita
            double miDouble = 3.14;
            int miInt;
            miInt = (int)miDouble;
            //Conversion de Tipo
            string miString = miDouble.ToString();
            //Imprimiendo en terminal y recibiendo un imput
            Console.WriteLine("Hola Mundo");
            string userName = Console.ReadLine();
            Console.WriteLine("Hola " + userName + "!");
            Console.WriteLine("El resultado de sumar " + num1 + " mas " + num2 + " es igual a " + sum);
            a = a.ToLower(); //Método
            int b = a.Length; //Propiedad
            Console.WriteLine(a + b);
            Console.Read();

            //tipos de variables:
            //int soyUnEntero = 5;
            //float SoyUnDecimal = 3.14; //float n = 99.99f; ('f' para indicar que se trata de un flotante. Sin ella, se considera un double. El flotante tiene un precision de 7 dígitos, el double de 15)
            //bool soyUnBooleano = false;
            //string soyUnaCadena = "Hola mundo";
            //char soyUnCaracterSimple = 'A'; Siempre comillas simples. Solo un carácter, siempre.
            //sbyte x = 120; => (Primitivo) Puede contener valores etre -128 y 127, util para ocupar poco espacio, o un programa de buena Performance.
            //short y = 30000; => (Primitivo) Almacena entre -32,767 a 32,767
            //long z = 9mil millones como máximo.
            //double h = 1.5; (Precisión de 15 dígitos)
            //decimal v = 1.5; (Con una precisión de 28 dígitos)
            //
        }
    }
}
