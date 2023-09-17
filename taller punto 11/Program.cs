// 11.	Construir un algoritmo que pida N números por pantalla, cuando el usuario ingrese un
// número negativo, el programa debe finalizar y mostrar en consola la cantidad total de números
// positivos que ingresó hasta antes de ingresarse el número negativo.

using System;

public class Punto11
{
    static void Main(string[] args)
    {
        //int n,num, contador = 0; // declarar variables

        //Console.Write("Ingresar la cantidad de números que desea evaluar: ");
        //n = Convert.ToInt32(Console.ReadLine());

        //do
        //{
        //    Console.Write("Ingrese el numero: ");
        //    num = Convert.ToInt32(Console.ReadLine());

        //    if (num >= 0)
        //    {
        //        contador++;
        //    }
        //    else
        //    {
        //        break;
        //    }
        //}
        //while (contador < n);

        //Console.Write(String.Format("La cantidad de número positivos ingresados es de {0}", contador));*/
        ///*int num, contador = 0; // declarar variables
        //  bool isPositivo = true;
        //  do
        //  {
        //    Console.Write("Ingrese el numero: ");
        //    num = Convert.ToInt32(Console.ReadLine());

        //      if (num >= 0)
        //         {
        //            contador++;
        //         }
        //         else
        //         {
        //            isPositivo = false;
        //         }
        //  }
        //   while (isPositivo);

        //   Console.Write(String.Format("La cantidad de número positivos ingresados es de {0}", contador));

        int num, contador = 0; // declarar variables

        Console.Write("Ingrese el numero: ");
        num = Convert.ToInt32(Console.ReadLine());

        while (num >= 0)
        {
            contador++;
            Console.Write("Ingrese otro número: ");
            num = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write(String.Format("La cantidad de número positivos ingresados es de {0}", contador));
    }
}