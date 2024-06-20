using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjerciciosProgra.Ejercicio1;
using EjerciciosProgra.Ejercicio2;
using EjerciciosProgra.Ejercicio3;
namespace EjerciciosProgra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region Ejericio1
            DateTime horaActual = DateTime.Now;
            string horaMinuto = horaActual.ToString("HH:mm");

            EventoAcademico eventAcademico = new EventoAcademico(horaMinuto);
            EventoCultural eventFolk = new EventoCultural(horaMinuto);
            EventoDeportivo eventDeport = new EventoDeportivo(horaMinuto);

            CalculadoraTiempo<EventoAcademico> ea = new CalculadoraTiempo<EventoAcademico>();
            CalculadoraTiempo<EventoCultural> ec = new CalculadoraTiempo<EventoCultural>();
            CalculadoraTiempo<EventoDeportivo> ed = new CalculadoraTiempo<EventoDeportivo>();

            Console.WriteLine($"{ea.GetTiempo(eventAcademico)}");
            Console.WriteLine($"{ec.GetTiempo(eventFolk)}");
            Console.WriteLine($"{ed.GetTiempo(eventDeport)}");

            Console.ReadKey();
            #endregion
            

            
            #region Ejericio2
            List<double> notasAleatoria = new List<double>();
            Random random = new Random();

            for (int i = 0; i < 12; i++)
            {
                double notaAleatoria = random.NextDouble() + 1 * 100;
                notasAleatoria.Add(notaAleatoria);
            }

            EstUniversitario eu = new EstUniversitario("lizzz", notasAleatoria);
            EstSecundaria es = new EstSecundaria("Pedrito", notasAleatoria);
            EstPrimaria ep = new EstPrimaria("Wendy", notasAleatoria);

            CalcCalificaciones<EstUniversitario> estUni = new CalcCalificaciones<EstUniversitario>();
            CalcCalificaciones<EstSecundaria> esSec = new CalcCalificaciones<EstSecundaria>();
            CalcCalificaciones<EstPrimaria> esPri = new CalcCalificaciones<EstPrimaria>();

            Console.WriteLine($"{estUni.GetCalificaciones(eu)}");
            Console.WriteLine($"{esSec.GetCalificaciones(es)}");
            Console.WriteLine($"{esPri.GetCalificaciones(ep)}");

            Console.ReadKey();
            #endregion
            

            #region Ejercicio3
            ReservaActividad rA = new ReservaActividad();
            ReservaHotel rH = new ReservaHotel();
            ReservaRestaurant rR = new ReservaRestaurant();

            SistemaReservas<ReservaActividad> actividad = new SistemaReservas<ReservaActividad>();
            SistemaReservas<ReservaHotel> hotel = new SistemaReservas<ReservaHotel>();
            SistemaReservas<ReservaRestaurant> restaurant = new SistemaReservas<ReservaRestaurant>();

            Console.WriteLine($"{actividad.GetReservas(rA)}");
            Console.WriteLine($"{hotel.GetReservas(rH)}");
            Console.WriteLine($"{restaurant.GetReservas(rR)}");

            Console.ReadKey();
            #endregion
        }
    }
}
