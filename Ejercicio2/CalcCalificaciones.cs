using EjerciciosProgra.Ejercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgra.Ejercicio2
{
    public class CalcCalificaciones  <T> where T : Estudiante
    {
        public string GetCalificaciones (T t)
        {
            Type tipoClase = typeof(T);
            switch (tipoClase.Name)
            {
                case "EstUniversitario":
                    EstUniversitario university = (EstUniversitario)(object)t;
                    return $"El estudiante : {university.nombre} -> {university.GetPromedio()}";
                case "EstSecundaria":
                    EstSecundaria highschool = (EstSecundaria)(object)t;
                    return $"El estudiante : {highschool.nombre} -> {highschool.GetPromedio()}";

                case "EstPrimaria":
                    EstPrimaria primary = (EstPrimaria)(object)t;
                    return $"El estudiante : {primary.nombre} -> {primary.GetPromedio()}";

                default:
                    return "No pertenece a ningun tipo de estudiante";
            }
        }
    }
}
