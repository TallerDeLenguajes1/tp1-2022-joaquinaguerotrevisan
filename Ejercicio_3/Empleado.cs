using System;
namespace Ejercicio3;

public class Empleado
{
    public string Nombre;
    public string Apellido;
    public string Dirrecion { get; set; }
    public string Nombre_Univ { get; set; }
    public int DNI;
    public int Hijos { get; set; }
    public float Sueldo_Basico { get; set; }
    public bool Titulo_Univ { get; set; }    
    public DateTime Fecha_Ingreso;
    public DateTime Fecha_Nacimiento;   
    public DateTime Fecha_Divorcio;
    public Estado_Civil Estado_Civil { get; set; }
    public enum Estado_Civil
    {
        Casado,
        Divorciado
    }

    public Empleado(string _Nombre, string _Apellido, DateTime _Fecha_Nacimiento, int _DNI, string _Direccion, DateTime _Fecha_Ingreso, float _Sueldo_Basico, int _Hijos, DateTime _Fecha_Divorcio, bool _Titulo_Univ, string _Nombre_Univ, Estado_Civil _Estado_Civil)
    {
        Nombre = _Nombre;
        Apellido = _Apellido;
        Fecha_Nacimiento = _Fecha_Nacimiento;
        DNI = _DNI;
        Direccion = _Direccion;
        Fecha_Ingreso = _Fecha_Ingreso;
        Sueldo_Basico = _Sueldo_Basico;
        Hijos = _Hijos;
        Fecha_Divorcio = _Fecha_Divorcio;
        Titulo_Univ = _Titulo_Univ;
        Nombre_Univ = _Nombre_Univ;
        Estado_Civil = _Estado_Civil;
    }

    public int Antiguedad (DateTime Fecha_Ingreso)
    {
        DateTime F_A = DateTime.Today;
        
        int Antiguedad = F_A.Year - Fecha_Ingreso.Year;

        if (Fecha_Ingreso.Month > F_A.Month)
        {
            --Antiguedad;
        }

        return Antiguedad;

    }

    public int Edad (DateTime Fecha_Nacimiento)
    {
        DateTime F_A = DateTime.Today;

        int Edad = F_A.Year - Fecha_Nacimiento.Year;

        if (Fecha_Nacimiento.Month > F_A.Month)
        {
            --Edad;
        }

        return Edad;
        
    }

    public float Salario(float Sueldo_Basico, int Antiguedad)
    {
        if (Antiguedad > 20)
        {
            return(Sueldo_Basico + Sueldo_Basico*0.25 - Sueldo_Basico*0.15);
        }

        return(Sueldo_Basico + Sueldo_Basico%Antiguedad - Sueldo_Basico*0.15);
    }

};