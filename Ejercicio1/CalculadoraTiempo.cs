using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgra.Ejercicio1
{
    public class CalculadoraTiempo <T> where T :Evento
    {
        public string GetTiempo (T t)
        {
            Type tipoClase =  typeof(T);
            switch (tipoClase.Name)
            {
                case "EventoAcademico":
                    EventoAcademico eventAcademic = (EventoAcademico)(object)t;
                    return $"El evento Academico inicia a las {eventAcademic.GetTiempo()} y termina en 4 horas";
                case "EventoCultural":
                    EventoCultural eventCultural = (EventoCultural)(object)t;
                    return $"El evento cultural inicia a las {eventCultural.GetTiempo()} y termina en 12 horas";
                
                case "EventoDeportivo":
                    EventoDeportivo eventoDeportivo = (EventoDeportivo)(object)t;
                    return $"El evento deportivo inicia a las {eventoDeportivo.GetTiempo()} y termina en 2 horas";

                default:
                    return "No pertenece a ningun Evento";
            }
        }        
    }
}
