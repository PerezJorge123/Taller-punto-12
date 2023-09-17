// 12.	Programe un algoritmo que pida a usuario 2 números por pantalla y que muestre todos los
// números comprendidos entre ambos números incluyéndolos.

public class Punto12
{
    static void Main(string[] args)
    {
        int num1, num2, min, max, numero;
        const string MESSAGE = "Ingrese un número valido. Presione la tecla enter"; //declaro variables
        bool retorno = false;

        do
        {
            Console.Clear();
            Console.Write("Ingrese el primer número: "); //pido números
            if (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine(MESSAGE);
                retorno = true;
                Console.ReadKey();
            }
            else
            {
                retorno = false;
            }
        }
        while (retorno);

        do
        {
            Console.Clear();
            Console.Write("Ingrese el segundo número: ");
            if (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine(MESSAGE);
                retorno = true;
                Console.ReadKey();
            }
            else
            {
                retorno = false;
            }
        }
        while (retorno);
        

        min = Math.Min(num1, num2);
        max = Math.Max(num1, num2);

        numero = min;
        while (numero <= max)
        {
            Console.Write(String.Format("{0} ", numero));
            numero++;
        }
    }
}