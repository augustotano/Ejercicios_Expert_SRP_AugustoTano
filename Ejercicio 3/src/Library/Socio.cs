using System;
using System.Text;

namespace Library
{
    public class Socio
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

        public string id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.id = "Error, no valido.";
                }
                else
                {
                    this.id = value;
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

