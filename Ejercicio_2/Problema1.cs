using (System);

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese un numero para obtener su cuadrado: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Resultado = ", n*n);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error de formato!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error de representacion!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception encontrada! ", e);
            }
        }
    }
}