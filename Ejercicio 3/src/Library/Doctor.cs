using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        public string nombre 
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.nombre = "Error, no valido.";
                }
                else
                {
                    this.nombre = value;
                }
            }
        }

        public string especialidad 
        {
            get
            {
                return this.especialidad;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.especialidad = "Error, no valido.";
                }
                else
                {
                    this.especialidad = value;
                }
            }
        }

        

    }
}

