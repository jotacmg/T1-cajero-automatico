using System;

class Program
{
    static void Main()
    {
        string opcion = "";
        double saldo = 1000;
       while (opcion != "4")
        {
            Console.Clear();    Console.WriteLine("---- CAJERO AUTOMATICO ----");
            Console.WriteLine("1. Ver saldo");
            Console.WriteLine("2. Depositar");
        Console.WriteLine("3. Retirar");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opcion: ");
       opcion = Console.ReadLine() ?? "";
            if (opcion == "1")
            {
                Console.WriteLine("Tu saldo es: " + saldo);
            }
            else if (opcion == "2")
            {
                Console.Write("Monto a depositar: ");
                double dep = double.Parse(Console.ReadLine() ?? "0");
                saldo += dep;
                Console.WriteLine("Deposito exitoso.");
            }
            else if (opcion == "3")
            {
                Console.Write("Monto a retirar: ");
                double ret = double.Parse(Console.ReadLine() ?? "0");

                if (ret <= saldo)
                {
                    saldo -= ret;
                    Console.WriteLine("Retiro exitoso.");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente.");
                }
            }
            else if (opcion == "4")
            {
                Console.WriteLine("Gracias por usar el cajero.");
            }
            else
            {
                Console.WriteLine("Opcion invalida.");
            }
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadKey();
        }
    }
}