using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiedraPapelTijeraLagartoSopck
{
    public class Piedra : Gesto
    {
        public override bool Gana(Gesto gestoJugador2)
        {
            //return (Constantes.GANAPIEDRA.Contains(gestoJugador2));
            //if (gestoJugador2.Equals(new Lagarto()) || gestoJugador2 == new Tijeras()) return true;

            if (gestoJugador2.GetType() == typeof (Lagarto) || gestoJugador2.GetType() == typeof (Tijeras)) return true;
            return false;
        }
    }
}
