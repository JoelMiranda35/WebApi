using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Repositorios;

namespace WebApi.Modelos
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Curso { get; set; }

        internal static RPAlumno FirstOrDefault()
        {
            throw new NotImplementedException();
        }
    }
}
