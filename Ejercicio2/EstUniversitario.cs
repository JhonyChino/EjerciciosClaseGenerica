using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgra.Ejercicio2
{
    public class EstUniversitario : Estudiante
    {
        public EstUniversitario(string nombre, List<double> notas) : base(nombre, notas)
        {
        }

        public string GetPromedio()
        {
            double promedio1 = 0;
            double promedio2 = 0;
            double sum1 = 0;
            double sum2 = 0;

            for (int i = 0; i < 6; i++)
            {
                sum1 = sum1 + notas[i];
            }
            for (int i = 6; i < 12; i++)
            {
                sum2 = sum2 + notas[i];
            }
            promedio1 = sum1 / 6;
            promedio2 = sum2 / 6;

            return $"El promedio del 1er Semestre es : {promedio1} y del segundo es: {promedio2} ";
        }
    }
}
