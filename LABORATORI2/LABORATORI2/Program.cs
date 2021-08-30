using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORI2
{
    class Program
    {
        static void Main(string[] args)
        {
            clsPersona clspersona = new clsPersona();
            Persona persona = new Persona();
            //ClsPersona clsPersona = new ClsPersona();
            Console.WriteLine("Escriba los siguientes datos" +
                "\n\n Escribe tu nombre :");
            String nombre = Console.ReadLine();
            Console.WriteLine("Ahora edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el sexo  : ");
            string sexo = Console.ReadLine();
            Console.WriteLine("Ingresa la altura : ");
            string altura = Console.ReadLine();

            ClsPersona clsPersona = new ClsPersona(nombre, edad, sexo);
        }
    }
}
