// 13.	Crear un programa que pida un número, hacer la suma de los números naturales igual e inferiores
// a dicho número ingresado y mostrar el resultado. me piden una suma, desde el uno hasta el numero solicitado
// int num, min = 1, acumulador = 0 
// 

public class Punto13
{
    static void MAIN(string[] args)
    {
        int num, acumulador = 0, min = 1;
        bool retorno = false;
        const string MESSAGE = "Ingrese un número natural valido mayor a 0";

        do
        {
            Console.Write("Ingrese un número: ");
            if (int.TryParse(Console.ReadLine(), out num))
            {
                if (num < 0)
                {
                    Console.WriteLine(MESSAGE);
                    retorno = true;
                }
                else
                {
                    while (min <= num)
                    {
                        acumulador += min;
                        min++;
                    }
                    Console.WriteLine(String.Format("La suma de los números naturales desde el 1 hasta el {0} es de {1}", num, acumulador));
                }          
            }
            else
            {
                Console.Write(MESSAGE);
                retorno = false;
            }
        } while (retorno);
          
    }
}
