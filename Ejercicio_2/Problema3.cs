using (System);

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese los kilometros: ");
                int Kilometro = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese los Litros: ");
                int Litro = Convert.ToInt32(Console.ReadLine());            

                Console.WriteLine("Resultado kilometro por litro = ", KilometroPorLitro(Kilometro, Litro));
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

        static public int KilometroPorLitro(int Kilometro, int Litro)
        {
            return Kilometro / Litro;
        }
    }
}