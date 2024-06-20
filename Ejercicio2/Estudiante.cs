using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgra.Ejercicio2
{
    public class Estudiante
    {
        public Estudiante(string nombre, List<double> notas)
        {
            this.nombre = nombre;
            this.notas = notas;
        }

        public string nombre { get; set; }
        public List<double> notas { get; set; } //12 notas
    }
}
