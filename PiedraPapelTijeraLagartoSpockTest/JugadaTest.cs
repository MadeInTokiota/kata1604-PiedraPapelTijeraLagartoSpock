using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PiedraPapelTijeraLagartoSopck;


namespace PiedraPapelTijeraLagartoSpockTest
{
    [TestClass]
    public class PapelPiedraTijeraLagartoSpockTestClase
    {

        //*****************PIEDRA********************************************
        [TestMethod]
        public void EmpateTest()
        {
            Jugada jugada = new Jugada(); //Inicialización
            var resultado = jugada.EvaluaJugada(new Piedra(), new Piedra());//Ejecucion
            Assert.AreEqual(Constantes.resultados.empate, resultado); //Comprobacion

        }

        [TestMethod]
        public void PiedraGanaTijerasTest()
        {
            Jugada jugada = new Jugada(); //Inicialización
            Assert.AreEqual(Constantes.resultados.jugador1, jugada.EvaluaJugada(new Piedra(), new Tijeras())); //Ejecucion y Comprobacion
            Assert.AreEqual(Constantes.resultados.jugador2, jugada.EvaluaJugada(new Tijeras(), new Piedra())); //Ejecucion y Comprobacion
            Assert.AreEqual(Constantes.resultados.jugador1, jugada.EvaluaJugada(new Piedra(), new Tijeras())); //Ejecucion y Comprobacion
            Assert.AreEqual(Constantes.resultados.jugador2, jugada.EvaluaJugada(new Tijeras(), new Piedra())); //Ejecucion y Comprobacion

        }

        [TestMethod]
        public void PiedraGanaLagartoTest()
        {
            Jugada jugada = new Jugada();
            Assert.AreEqual(Constantes.resultados.jugador1, jugada.EvaluaJugada(new Piedra(), new Lagarto()));
            Assert.AreEqual(Constantes.resultados.jugador2, jugada.EvaluaJugada(new Lagarto(), new Piedra()));
        }

        [TestMethod]
        public void PiedraPierdePapelTest()
        {
            Jugada jugada = new Jugada();
            Assert.AreEqual(Constantes.resultados.jugador2, jugada.EvaluaJugada(new Piedra(), new Papel()));
            Assert.AreEqual(Constantes.resultados.jugador1, jugada.EvaluaJugada(new Papel(), new Piedra()));

        }

        [TestMethod]
        public void PiedraPierdeSpockTest()
        {
            Jugada jugada = new Jugada();
            Assert.AreEqual(Constantes.resultados.jugador2, jugada.EvaluaJugada(new Piedra(), new Spock()));
            Assert.AreEqual(Constantes.resultados.jugador1, jugada.EvaluaJugada(new Spock(), new Piedra()));
        }

        //*****************PAPEL********************************************

        [TestMethod]
        public void PapelGanaPiedraTest()
        {
            Jugada jugada = new Jugada(); //Inicialización
            Assert.AreEqual(Constantes.resultados.jugador1, jugada.EvaluaJugada(new Papel(), new Piedra()));
            Assert.AreEqual(Constantes.resultados.jugador2, jugada.EvaluaJugada(new Piedra(), new Papel()));

        }

        [TestMethod]
        public void PapelGanaSpockTest()
        {
            Jugada jugada = new Jugada();
            Assert.AreEqual(Constantes.resultados.jugador1, jugada.EvaluaJugada(new Papel(), new Spock()));
            Assert.AreEqual(Constantes.resultados.jugador2, jugada.EvaluaJugada(new Spock(), new Papel()));
        }

        [TestMethod]
        public void PapelPierdeTijerasTest()
        {
            Jugada jugada = new Jugada();
            Assert.AreEqual(Constantes.resultados.jugador2, jugada.EvaluaJugada(new Papel(), new Tijeras()));
            Assert.AreEqual(Constantes.resultados.jugador1, jugada.EvaluaJugada(new Tijeras(), new Papel()));
        }

        [TestMethod]
        public void PiedraPierdeLagartoTest()
        {
            Jugada jugada = new Jugada();
            Assert.AreEqual(Constantes.resultados.jugador2, jugada.EvaluaJugada(new Papel(), new Lagarto()));
            Assert.AreEqual(Constantes.resultados.jugador1, jugada.EvaluaJugada(new Lagarto(), new Papel()));
        }
        //*****************TIJERAS********************************************
        [TestMethod]
        public void TijerasGanaPapelTest()
        {
            Jugada jugada = new Jugada(); //Inicialización
            Assert.AreEqual(Constantes.resultados.jugador1, jugada.EvaluaJugada(new Tijeras(), new Papel()));
            Assert.AreEqual(Constantes.resultados.jugador2, jugada.EvaluaJugada(new Papel(), new Tijeras()));
        }

        [TestMethod]
        public void TijerasGanaLagartoTest()
        {
            Jugada jugada = new Jugada();
            Assert.AreEqual(Constantes.resultados.jugador1, jugada.EvaluaJugada(new Tijeras(), new Lagarto()));
            Assert.AreEqual(Constantes.resultados.jugador2, jugada.EvaluaJugada(new Lagarto(), new Tijeras()));
        }

        [TestMethod]
        public void TijerasPierdePiedraTest()
        {
            Jugada jugada = new Jugada();
            Assert.AreEqual(Constantes.resultados.jugador2, jugada.EvaluaJugada(new Tijeras(), new Piedra()));
            Assert.AreEqual(Constantes.resultados.jugador1, jugada.EvaluaJugada(new Piedra(), new Tijeras()));
        }

        [TestMethod]
        public void TijerasPierdeSpockTest()
        {
            Jugada jugada = new Jugada();
            Assert.AreEqual(Constantes.resultados.jugador2, jugada.EvaluaJugada(new Tijeras(), new Spock()));
            Assert.AreEqual(Constantes.resultados.jugador1, jugada.EvaluaJugada(new Spock(), new Tijeras()));
        }
        //*****************LAGARTO********************************************

        [TestMethod]
        public void LagartoGanaspockTest()
        {
            Jugada jugada = new Jugada();
            Assert.AreEqual(Constantes.resultados.jugador1, jugada.EvaluaJugada(new Lagarto(), new Spock()));
            Assert.AreEqual(Constantes.resultados.jugador2, jugada.EvaluaJugada(new Spock(), new Lagarto()));
        }

        [TestMethod]
        public void LagartoGanaPapelTest()
        {
            Jugada jugada = new Jugada();
            Assert.AreEqual(Constantes.resultados.jugador1, jugada.EvaluaJugada(new Lagarto(), new Papel()));
            Assert.AreEqual(Constantes.resultados.jugador2, jugada.EvaluaJugada(new Papel(), new Lagarto()));
        }

        [TestMethod]
        public void LagartoPierdePiedraTest()
        {
            Jugada jugada = new Jugada();
            Assert.AreEqual(Constantes.resultados.jugador2, jugada.EvaluaJugada(new Lagarto(), new Piedra()));
            Assert.AreEqual(Constantes.resultados.jugador1, jugada.EvaluaJugada(new Piedra(), new Lagarto()));

        }

        [TestMethod]
        public void LagartoPierdeTijerasTest()
        {
            Jugada jugada = new Jugada();
            Assert.AreEqual(Constantes.resultados.jugador2, jugada.EvaluaJugada(new Lagarto(), new Tijeras()));
            Assert.AreEqual(Constantes.resultados.jugador1, jugada.EvaluaJugada(new Tijeras(), new Lagarto()));
        }
        //*****************SPOCK********************************************

        [TestMethod]
        public void SpockGanaTijerasTest()
        {
            Jugada jugada = new Jugada(); //Inicialización
            Assert.AreEqual(Constantes.resultados.jugador1, jugada.EvaluaJugada(new Spock(), new Tijeras()));
            Assert.AreEqual(Constantes.resultados.jugador2, jugada.EvaluaJugada(new Tijeras(), new Spock()));

        }

        [TestMethod]
        public void SpockGanaPiedraTest()
        {
            Jugada jugada = new Jugada();
            Assert.AreEqual(Constantes.resultados.jugador1, jugada.EvaluaJugada(new Spock(), new Piedra()));
            Assert.AreEqual(Constantes.resultados.jugador2, jugada.EvaluaJugada(new Piedra(), new Spock()));
        }

        [TestMethod]
        public void SpockPierdePapelTest()
        {
            Jugada jugada = new Jugada();
            Assert.AreEqual(Constantes.resultados.jugador2, jugada.EvaluaJugada(new Spock(), new Papel()));
            Assert.AreEqual(Constantes.resultados.jugador1, jugada.EvaluaJugada(new Papel(), new Spock()));

        }

        [TestMethod]
        public void SpockPierdeLagartoTest()
        {
            Jugada jugada = new Jugada();
            Assert.AreEqual(Constantes.resultados.jugador2, jugada.EvaluaJugada(new Spock(), new Lagarto()));
            Assert.AreEqual(Constantes.resultados.jugador1, jugada.EvaluaJugada(new Lagarto(), new Spock()));
        }
    }
}
