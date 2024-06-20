using EjerciciosProgra.Ejercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgra.Ejercicio3
{
    public class SistemaReservas <T> where T : EventoSocial
    {
            public string GetReservas(T t)
            {
                Type tipoClase = typeof(T);
                switch (tipoClase.Name)
                {
                    case "ReservaRestaurant":
                        ReservaRestaurant rRestaurant = (ReservaRestaurant)(object)t;
                        return $"El restaurant tiene el precio de: Bs. {rRestaurant.precio}.-";
                    case "ReservaHotel":
                        ReservaHotel rHotel = (ReservaHotel)(object)t;
                        return $"El Hotel tiene el precio de: Bs. {rHotel.precio} .-";

                    case "ReservaActividad":
                        ReservaActividad rActividad = (ReservaActividad)(object)t;
                        return $"La Actividad tiene el precio de: Bs.{rActividad.precio}.-";

                    default:
                        return "No pertenece a ningun Evento";
                }
            }
    }
}
