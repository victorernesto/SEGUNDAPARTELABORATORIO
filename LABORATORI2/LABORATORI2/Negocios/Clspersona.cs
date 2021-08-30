using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORI2.Negocios
{
    class Clspersona
    {

        ClsPersona persona = new ClsPersona();
        public string calcularIMC()
        {


            double pro = persona.Peso / Math.Pow(persona.Altura, 2);


            if (pro < 20)
            {
                return "peso es ideal";
            }
            if (pro > 25)
            {
                return "tiene sobre peso";
            }
            


        }
        public string esMayorDeEdad()
        {
            if (persona.Edad >= 18)
            {
                return "Es mayor de edad";
            }
            else
                return "No es mayor de edad";


        }
}
