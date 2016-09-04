var PiedraPapelTijeraLagartoSpock = PiedraPapelTijeraLagartoSpock || {};
PiedraPapelTijeraLagartoSpock.Controller = PiedraPapelTijeraLagartoSpock.Controller || (function () {
    "use strict";

    var controller = {};
    
    controller.getLegalHands = function (args) {

        //return possible options
        return ["Piedra", "Papel", "Tijera", "Lagarto", "Spock"];

    };
    
    controller.checkGame = function (player1Hand, player2Hand) {
        // TODO: This application is about to be suspended. Save any state
        // that needs to persist across suspensions here. You might use the
        // WinJS.Application.sessionState object, which is automatically
        // saved and restored across suspension. If you need to complete an
        // asynchronous operation before your application is suspended, call
        // args.setPromise().
    };

    return controller;
})();