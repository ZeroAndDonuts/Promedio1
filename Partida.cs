using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1
{
    internal class Partida
    {
        Jugador jugador;
        List<Partida> Enemigos;
        List<Partida> Batalla;
        public Partida() 
        {
            jugador = new Jugador();
            Enemigos = new List<Partida>();
            Batalla = new List<Partida>();
        }
        public void CreaciónDePersonaje()
        {
            float VidaJugador = 0f;
            Console.WriteLine("Elige la vida de tu personaje");
            VidaJugador = float.Parse(Console.ReadLine());
            float AtaqueJugador = 0f;
            Console.WriteLine("Elige el ataque de tu personaje");
            AtaqueJugador = float.Parse(Console.ReadLine());
            Console.WriteLine($"Tu personaje tiene {VidaJugador} de vida y {AtaqueJugador} de ataque");
        }
        public void CreaciónDeEnemigo()
        {
            int Cantidad = 0;
            Console.WriteLine("Elige la cantidad de enemigos");
            Cantidad = int.Parse(Console.ReadLine());
            float VidaEnemigo = 0f;
            Console.WriteLine("Elige la vida de tu enemigo");
            VidaEnemigo = float.Parse(Console.ReadLine());
            float AtaqueEnemigo = 0f;
            Console.WriteLine("Elige el ataque de tu enemigo");
            AtaqueEnemigo = float.Parse(Console.ReadLine());
            Console.WriteLine($"Cantidad de enemigo(s): {Cantidad}, tiene(n) {VidaEnemigo} de vida y {AtaqueEnemigo} de ataque");
            Enemigos.Clear();
        }
        public void Combate()
        {
            Console.WriteLine("Inicia la batalla");
            foreach ( var item in Enemigos ) 
            { 
                Console.WriteLine(item);
            }
            //Enemigos.Count = 0;

        }
    }
}
