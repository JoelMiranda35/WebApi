using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Modelos;

namespace WebApi.Repositorios
{
    public class RPAlumno
    {
        
            public static List<Alumno> _listaAlummnos = new List<Alumno>()
        {
            new Alumno() { Id = 1, Nombre = "Cliente 1" , Apellido = "Apellido 1" },
            new Alumno() { Id = 2, Nombre = "Cliente 2" , Apellido = "Apellido 2" },
            new Alumno() { Id = 3, Nombre = "Cliente 3" , Apellido = "Apellido 3" }
        };

        internal object ObtenerAlumno()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Alumno> ObtenerClientes()
            {
                return _listaAlummnos;
            }

            public RPAlumno ObtenerAlumno(int id)
            {
                var alumno = _listaAlummnos.Where(cli => cli.Id == id);

                return Alumno.FirstOrDefault();
            }

            public void Agregar(Alumno nuevoAlumno)
            {
                _listaAlummnos.Add(nuevoAlumno);
            }
        }
    }



