using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_7
{
    class Patrones
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

            //Constante
            if (UsuarioBasico.ListaReprod is null) Console.WriteLine("Lista de usuario básico es nula");
            if (UsuarioPremium.Edad is 28) Console.WriteLine("Edad usuario premium es 26");
            Console.ReadLine();

            //Tipo
            if (UsuarioBasico.ListaReprod is string) Console.WriteLine("Lista de usuario básico es string");
            if (UsuarioBasico.ListaReprod is string miLista) Console.WriteLine($"Lista de usuario básico es string {miLista}");
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
