using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgra.Ejercicio2
{
    public class EstSecundaria : Estudiante
    {
        public EstSecundaria(string nombre, List<double> notas) : base(nombre, notas)
        {
        }
        public string GetPromedio()
        {
            double promedio1 = 0;
            double promedio2 = 0;
            double promedio3 = 0;
            double promedio4 = 0;
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double sum4 = 0;

            for (int i = 0; i < 4; i++)
            {
                sum1 = sum1 + notas[i];
            }
            for (int i = 4; i < 6; i++)
            {
                sum2 = sum2 + notas[i];
            }
            for (int i = 6; i < 10; i++)
            {
                sum3 = sum4 + notas[i];
            }
            for (int i = 10; i < 12; i++)
            {
                sum4 = sum4 + notas[i];
            }
            promedio1 = sum1 / 3;
            promedio2 = sum2 / 3;
            promedio3 = sum3 / 3;
            promedio4 = sum4 / 3;

            return $"El promedio del 1er trimestre es : {promedio1} , del segundo es: {promedio2}, del tercero es: {promedio3}, del cuarto es: {promedio4} ";
        }
    }
}
