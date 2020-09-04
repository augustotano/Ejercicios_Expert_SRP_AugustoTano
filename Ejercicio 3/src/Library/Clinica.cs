using System;
using System.Text;

namespace Library
{
    public class Clinica
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

        public string direccion
        {
            get
            {
                return this.direccion;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.direccion = "Error, no valido.";
                }
                else
                {
                    this.direccion = value;
                }
            }
        }

                public string phoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.phoneNumber = "Error, no valido.";
                }
                else
                {
                    this.phoneNumber = value;
                }
            }
        }

        

    }
}

