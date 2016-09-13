using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiedraPapelTijeraLagartoSopck
{
    public class Constantes
    {
        //public const string[] GESTOS = {"piedra","papel","tijeras","lagarto","spock"}; 
        // LOs array no se pueden poner como constantes se deben de poner como static readonly  porq 
        //The reason is that const can only be applied to a field whose value is known at compile-time. 
        //The array initializer you've shown is not a constant expression in C#, so it produces a compiler error.
        //Declaring it readonly solves that problem because the value is not initialized until run-time
        //(although it's guaranteed to have initialized before the first time that the array is used).

        // NO se si se puede poner tb un enum habria qu mirar la diferencia entre enum y const y reaonly staic
        //public enum GESTOS { "piedra", "papel", "tijeras", "lagarto", "spock" };
       // public static readonly gestoEnum[] GESTOS = { gestoEnum.piedra,gestoEnum.papel, gestoEnum.tijeras, gestoEnum.lagarto, gestoEnum.spock};

        //public static readonly Array <Gesto> GANAPIEDRA = {}
        public static readonly gestoEnum[] GANAPIEDRA = { gestoEnum.tijeras, gestoEnum.lagarto };
        public static readonly gestoEnum[] GANAPAPEL = { gestoEnum.piedra, gestoEnum.spock };
        public static readonly gestoEnum[] GANATIJERAS = { gestoEnum.papel, gestoEnum.lagarto };
        public static readonly gestoEnum[] GANALAGARTO = { gestoEnum.papel, gestoEnum.spock };
        public static readonly gestoEnum[] GANASPOCK = { gestoEnum.piedra, gestoEnum.tijeras };

         public enum gestoEnum
         {
            piedra,
            papel, 
            tijeras,
            lagarto,
            spock
         }

        public enum resultados
        {
            jugador1,
            jugador2,
            empate,
            NoValido
        }


    }
}
