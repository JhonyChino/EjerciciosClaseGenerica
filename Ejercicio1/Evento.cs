using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgra.Ejercicio1
{
    public abstract class Evento
    {

        string tiempo { get; set; }

        public Evento(string tiempo)
        {
            this.tiempo = tiempo;
        }

        public string GetTiempo ()
        {
            return tiempo;
        }
    }
}
