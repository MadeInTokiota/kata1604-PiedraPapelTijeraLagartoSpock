using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiedraPapelTijeraLagartoSopck
{
    public class Papel : Gesto
    {
        public override bool Gana(Gesto gestoJugador2)
        {
            if (gestoJugador2.GetType() == typeof(Piedra) || gestoJugador2.GetType() == typeof(Spock)) return true;
            return false;
        }
    }
}
