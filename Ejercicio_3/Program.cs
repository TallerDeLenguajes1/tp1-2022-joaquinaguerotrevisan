using System;
namespace Ejercicio3;

class Program
{
    static void Main(string[] args)
    {
        int Numero_Empleados, DNI, Hijos, Estado_Civil;
        string Nombre, Apellido, Direccion, Nombre_Univ;
        float Sueldo_Basico;
        bool Titulo_Univ;
        DateTime Anio_Ingreso, Anio_Nacimiento, Fecha_Divorcio;
        

        List<Empleado> Lista_Empleados = new List<Empleado>();

        try
        {
            Console.WriteLine("___|EMPLEADOS|_____________________");

            Console.WriteLine("    - Ingrese numero empleados: ");
            Numero_Empleados = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Numero_Empleados; i++)
            {
                Console.WriteLine("    - Nombre: ");
                Nombre = Convert.ToString(Console.ReadLine());

                Console.WriteLine("    - Apellido: ");
                Apellido = Convert.ToString(Console.ReadLine());

                Console.WriteLine("    - DNI: ");
                Nombre = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("    - Direccion: ");
                Direccion = Convert.ToString(Console.ReadLine());

                Console.WriteLine("    - Fechas:");
                Anio_Nacimiento = new DateTime(2005, 03, 01);
                Anio_Ingreso = new DateTime(2030, 02, 02);

                Console.WriteLine("    - Sueldo Basico: ");
                Sueldo_Basico = Console.ReadLine();

                Console.WriteLine("    - Tiene titulo universitario?: ");
                Titulo_Univ = Convert.ToBoolean(Console.ReadLine());

                if (Titulo_Univ)
                {
                    Console.WriteLine("    - Nombre de la Universidad: ");
                    Nombre_Univ = Convert.ToString(Console.ReadLine());
                } else
                {
                    Nombre_Univ = "None";
                }

                Console.WriteLine("    - Estado_Civil: ");
                Estado_Civil = Convert.ToInt32(Console.ReadLine());

                if (Estado_Civil = 0)
                {
                    Console.WriteLine("    - Cantidad de Hijos/as: ");
                    Hijos = Convert.ToInt32(Console.ReadLine());
                    Fecha_Divorcio = new DateTime();
                } 
                else if (Estado_Civil = 1)
                {
                    Console.WriteLine("    - Fecha de divorcio:");
                    Fecha_Divorcio = Convert.ToDateTime(Console.ReadLine());
                    Hijos = 0;
                }

                Lista_Empleados.Add(new Empleado(Nombre, Apellido, Anio_Nacimiento, DNI, Direccion, Anio_Ingreso, Sueldo_Basico, Hijos, Fecha_Divorcio, Titulo_Univ, Nombre_Univ, Estado_Civil));
                
            }

            foreach (var e in Lista_Empleados)
            {
                Console.WriteLine("    --- LISTA DE EMPLEADOS ---");
                Console.WriteLine("    ["+ e.DNI +"] ");
                Console.WriteLine("     - Nombre: "+ e.Nombre);
                Console.WriteLine("     - Apellido: "+ e.Apellido);
                Console.WriteLine("     - Edad: "+ e.Edad);
                Console.WriteLine("     - Antiguedad: "+ e.Antiguedad);
                Console.WriteLine("     - Salario: "+ e.Salario);
            }

        }
        catch (FormatException)
        {
            Console.WriteLine("Error de formato!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error de representacion!");
        }
        catch(UnderflowException)
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
}