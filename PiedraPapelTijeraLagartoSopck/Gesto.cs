using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PiedraPapelTijeraLagartoSopck;

namespace PiedraPapelTijeraLagartoSopck
{
    public abstract class Gesto
    {
        public abstract bool Gana(Gesto gestoJugador2);
    }


    //no son igual ni equal, pq son instancias diferentes y no está comparando el tipo, sino las instancias
    //public override bool Equals(Gesto gesto)
    //{
    //    Gesto.GetType() == typeof (gesto)) return true;
    //    return false;

    //}

}
