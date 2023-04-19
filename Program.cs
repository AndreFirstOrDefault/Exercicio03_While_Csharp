using System;

namespace ExercicioWhile03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (numero != 4) 
            {
                numero = int.Parse(Console.ReadLine());

                if (numero == 1) 
                {
                    alcool++;
                }
                else if(numero == 2)
                {
                    gasolina++;
                }
                else if(numero == 3)
                {
                    diesel++;
                }
                else if (numero == 4)
                {
                    Console.WriteLine("MUITO OBRIGADO\nAlcool: " + alcool + "\nGasolina: " +gasolina+ "\nDiesel: " +  diesel);
                    break;
                }
            }
        }
    }
}
