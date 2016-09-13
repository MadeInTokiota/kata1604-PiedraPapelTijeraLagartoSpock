using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiedraPapelTijeraLagartoSopck
{
    public class Tijeras : Gesto
    {
        public override bool Gana(Gesto gestoJugador2)
        {
            if (gestoJugador2.GetType() == typeof(Papel) || gestoJugador2.GetType() == typeof(Lagarto)) return true;
            return false;
        }
    }
}
