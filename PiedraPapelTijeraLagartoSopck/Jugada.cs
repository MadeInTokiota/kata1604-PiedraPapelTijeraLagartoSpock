using System;
using System.Linq;

namespace PiedraPapelTijeraLagartoSopck
{

   
    public class Jugada
    {

        //Para hacer con una clase abstracta
        public Constantes.resultados EvaluaJugada(Gesto gestoJugador1, Gesto gestoJugador2)
        {
            if (gestoJugador1.GetType() == gestoJugador2.GetType())
            {
                return Constantes.resultados.empate;
            }
            if (gestoJugador1.Gana(gestoJugador2))
            {
                return Constantes.resultados.jugador1;
            }
            return Constantes.resultados.jugador2;

        }



//public class JugadaFactory
//    {
//        public T Lanzar<T>() where T : Jugada, new()
//        {
//            return new T();
//        }
//    } 



    }
}


