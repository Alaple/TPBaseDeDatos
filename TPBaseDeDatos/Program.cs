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
            //AgregarEmpresa("THE BIG BANG THEORY");
            //AgregarEmpresa("FRIENDS");

            //ConsultarEmpresa(4);
            //ListarEmpresas();
            ActualizarEliminar(7, "THE OFFICE", 8);
        }

        static void AgregarEmpresa(string nombre)
        {
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

        static void ConsultarEmpresa(int id)
        {
            using (var context = new DBContext())
            {
                var consulta = context.Empresas.Where(s => s.EmpresaId == id);
                var empresa = consulta.FirstOrDefault<Empresa>();
                Console.WriteLine("Encontré al estudiante " + id + " y se llama " + empresa.nombre);
            }
        }

        static void ListarEmpresas()
        {
            using (var context = new DBContext())
            {
                var empresas = from s in context.Empresas
                               orderby s.nombre
                               select s;
                foreach (var item in empresas)
                {
                    Console.WriteLine("Empresas ", item.nombre);
                }
            }
        }

        static void ActualizarEliminar(int idActualizar, string nombreActualizado, int idEliminar)
        {
            using (var context = new DBContext())
            {
                var listaEstudiantes = context.Empresas.ToList<Empresa>();
                Console.WriteLine(listaEstudiantes);

                //Agrega una nueva empresa
                context.Empresas.Add(new Empresa()
                {
                    nombre = "THE OFFICE",
                });

                //Actualiza un estudiante
                Empresa estudianteActualizado = listaEstudiantes.Where(s =>
                s.EmpresaId == idActualizar).FirstOrDefault<Empresa>();
                estudianteActualizado.nombre = nombreActualizado;

                //Elimina un estudiante en posición 3RODRIGO
                context.Empresas.Remove(listaEstudiantes.ElementAt<Empresa>(idEliminar));

                //Ejecuta instrucciones Insert, Update & Delete en la base de datos
                context.SaveChanges();
            }
        }
    }
}
