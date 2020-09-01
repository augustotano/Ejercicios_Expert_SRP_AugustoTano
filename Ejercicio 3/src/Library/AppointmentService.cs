using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {   
        //Horrible, se piden muchas cosas que tendrían que estar subdivididas. Tampoco hay mucha especificación de que es cada cosa.
        //Parametros "name", "phoneNumber" e "id" tendrían que estar en una clase que sea socio. Appointment pediría un objeto de tipo socio.
        //Parametros "date" y "appointmentPlace" podrían conservarse dentro del metodo que lo crea.
        //Parametros como "doctorName" serían ideal en una clase nueva con nombre doctor para cualquier futura ampliación.
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            
            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
