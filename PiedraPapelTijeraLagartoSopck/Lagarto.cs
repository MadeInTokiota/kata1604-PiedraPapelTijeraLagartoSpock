using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiedraPapelTijeraLagartoSopck
{
    public class Lagarto: Gesto
    {

        public List<Type> ganadores { get; set; }

        public Lagarto()
        {
            ganadores = new List<Type>()
            {
                typeof(Papel),
                typeof(Spock)
            };
        }
        public override bool Gana(Gesto gestoJugador2)
        {
           // if (gestoJugador2.GetType() == typeof(Papel) || gestoJugador2.GetType() == typeof(Spock)) return true;

            return ganadores.Contains(gestoJugador2.GetType());


        }
    }
}
