using (System);

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese el dividendo: ");
                int Dividendo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el divisor: ");
                int Divisor = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Resultado = ", Dividir(Divisor, Dividendo));
            }
            catch (FormatException)
            {
                Console.WriteLine("Error de formato!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error de representacion!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir en 0!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception encontrada! ", e);
            }
            
        }

        static public int Dividir(int Divisor, int Dividendo)
        {
            return Dividendo/Divisor;
        }
    }
}