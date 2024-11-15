using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepcioness
{
    internal class Empleado
    {
        private int id;
        private string nombre;
        private int edad;


        public int Id 
        { 
    
            get { return id; } 
            
            set { id = value;
                if (id <= 0)
                    throw new Exception("Verifia tu captura no se aceptan negativos");    
                 }
        }

        public string Nombre { 
            get { return nombre; }
            set { nombre = value;
                if (nombre == "")
                    throw new Exception("No se permiten nulos en el nombre");
            }
        }

        public int Edad
        {
            get { return edad; }
            set
            {
                edad = value;
                if (edad >= 18 || edad <= 65)
                {
                    throw new Exception("La edad no esta dentro del rango permitido");
                }
            }
        }





    }
}
