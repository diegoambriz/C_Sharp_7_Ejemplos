using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_2
{
    class Patrones_2
    {
        static void Main(string[] args)
        {
            //Ejemplo 2: Patrones
            Usuario UsuarioGenerico = new Usuario();
            Basico UsuarioBasico = new Basico("Juan", 35, "m", "kjufn");
            var listas = new List<string>()
            {   "kjB4",
                "dfS8",
                "kjc1"
            };
            Premium UsuarioPremium = new Premium("Diana", 26, "f", true, listas);
            UsuarioPremium = null;
            //Switch
            switch (UsuarioPremium)
            {
                case null:
                    Console.WriteLine("Usuario premium es nulo");
                    break;
                case Usuario usuario when usuario.Nombre.StartsWith("D"):
                    Console.WriteLine($" Nombre de usuario: {usuario.Nombre} , inicia con D");
                    break;
                case Premium usuarioP:
                    Console.WriteLine($" Usuario premium: {usuarioP.Nombre}");
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
    #region Clases

    class Usuario
    {
        public string Nombre { get; set; }
        public Int16 Edad { get; set; }
        public string Genero { get; set; }
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
