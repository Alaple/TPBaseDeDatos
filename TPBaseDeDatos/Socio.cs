using System;
using System.Collections.Generic;
using System.Text;

namespace TPClass
{
    class Socio
    {
        private string usuario;
        private string nombre;
        private string apellido;
        private string clave;
        private string sexo;
        private int edad;
        private double peso;
        private double altura;

        // Constructor
        public Socio(string usuario, string nombre, string apellido, string clave, string sexo, int edad, double peso, double altura)
        {
            this.usuario = usuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.clave = clave;
            this.sexo = sexo;
            this.edad = edad;
            this.peso = peso;
            this.altura = altura;
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
    }
}
