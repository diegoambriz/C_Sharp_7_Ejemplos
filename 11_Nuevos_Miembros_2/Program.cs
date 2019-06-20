﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Nuevos_Miembros_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo 9: Nuevos miembros con expresiones en su definición

            Usuario UsuarioGenerico = new Usuario();
            Basico UsuarioBasico = new Basico("", 35, "m");
            Premium UsuarioPremium = new Premium("Diana", 26, "f", true);

            //UsuarioBasico.Nombre = null;
            /*if(UsuarioBasico.Nombre == null) {
                throw new ArgumentNullException(
                     paramName: nameof(UsuarioBasico.Nombre),
                     message: "Nombre de usuario nulo");
             }*/

            Console.WriteLine($"Usuario: {UsuarioBasico.Nombre}");

            string nombreA = UsuarioBasico.ObtenerNombre();
            Console.WriteLine($"Nombre: {nombreA}");
            Console.ReadLine();
        }
    }
    #region Clases

    class Usuario
    {
        string _nombre;
        Int16 _edad;
        string _gen;
        public string Nombre
        {
            get => _nombre;
            set => _nombre = value ?? throw new ArgumentNullException(
                     paramName: nameof(Nombre),
                     message: "Nombre de usuario nulo");
        }
        public Int16 Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }
        public string Genero
        {
            get { return _gen; }
            set { _gen = value; }
        }
        public string ObtenerNombre()
        {
            var nombre = Nombre.Split(null);
            return (nombre.Length > 1)
                ? nombre[0]
                : throw new InvalidOperationException("Sin nombre");
        }

        public bool UsuarioAdulto() => Edad > 18 ? true : false;
    }

    class Basico : Usuario
    {
        public string ListaReprod { get; set; }

        public Basico(string nombre, Int16 edad, string genero, string lista = null)
        {
            Nombre = nombre;
            Edad = edad;
            Genero = genero;
            ListaReprod = lista;
        }
        ~Basico() => Console.WriteLine("Deconstructor");
    }

    class Premium : Usuario
    {
        public List<string> ListasReprod { get; set; }
        public bool PerfilPublico { get; set; }

        public Premium(string nombre, Int16 edad, string genero, bool perfilPublico, List<string> listas = null)
        {
            Nombre = nombre;
            Edad = edad;
            Genero = genero;
            ListasReprod = listas;
            PerfilPublico = perfilPublico;
        }
    }

    #endregion
}
