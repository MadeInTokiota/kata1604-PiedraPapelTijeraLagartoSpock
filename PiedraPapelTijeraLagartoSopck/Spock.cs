using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiedraPapelTijeraLagartoSopck
{
    public class Spock: Gesto
    {
        public override bool Gana(Gesto gestoJugador2)
        {
            if (gestoJugador2.GetType() == typeof(Piedra) || gestoJugador2.GetType() == typeof(Tijeras)) return true;
            return false;
        }
    }
}
