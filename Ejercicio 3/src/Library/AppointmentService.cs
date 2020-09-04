using System;
using System.Text;


namespace Library
{
    public class Appointment
    {
        private Socio socio {get; set;}
        private Doctor doctor {get;set;} 
        private Clinica clinica {get;set;}
        public string CreateAppointment(Socio socio1, Doctor doctor1, Clinica clinica1)
        {
            this.socio = socio1;
            this.doctor = doctor1;
            this.clinica = clinica1;

            return $"Cita creada para el socio {socio1.nombre} con el doctor {doctor1.nombre} en la clinica {clinica.nombre}";
            
        }

    }
}
