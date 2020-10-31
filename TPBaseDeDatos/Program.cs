using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using TPClass;

namespace TPBaseDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
           AgregarEmpresa("THE BIG BANG THEORY");
           AgregarEmpresa("FRIENDS");

            ConsultarEmpresa(1);
        }

        static void AgregarEmpresa(string nombre) {
            using (var context = new DBContext())
            {
                var emp = new Empresa()
                {
                    nombre = nombre
                };
                context.Empresas.Add(emp);
                context.SaveChanges();
            }
            Console.WriteLine("Estudiante agregado!");
        }

        static void ConsultarEmpresa(int id) {
            using (var context = new DBContext())
            {
                var consulta = context.Empresas.Where(s => s.EmpresaId == id);
                var empresa = consulta.FirstOrDefault<Empresa>();
                Console.WriteLine("Encontré al estudiante 2 y se llama " + empresa.nombre);
            }
        }
    }
}
