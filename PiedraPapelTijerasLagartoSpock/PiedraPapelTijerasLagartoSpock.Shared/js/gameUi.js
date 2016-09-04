var PiedraPapelTijeraLagartoSpock = PiedraPapelTijeraLagartoSpock || {};
PiedraPapelTijeraLagartoSpock.Ui = PiedraPapelTijeraLagartoSpock.Ui || (function () {
    "use strict";
    
    var ui = { controller : null, player1Option: null, player2Option: null };
    
    ui.initialize = function () {
        //initialize gameController processor
        ui.controller = PiedraPapelTijeraLagartoSpock.Controller;
    };

    ui.configure = function () {

        //ask gameController for legal options and print them on combo boxes
        var legalOptions = ui.controller.getLegalHands();

    };

    ui.registerEvents = function () {
        //register combo onchange event
        var player1Options = document.getElementById("player1Options");
        player1Options.addEventListener("change", function (event) { ui.player1Option = this.valueOf(); });

        var player2Options = document.getElementById("player2Options");
        player2Options.addEventListener("change", function (event) { ui.player2Option = this.valueOf(); });

        //register button play event
        var playButton = document.getElementById("playButton");
        playButton.addEventListener("click", ui.playGame);
    };
    
    ui.playGame = function () {
        //ask controller for game results
        ui.controller.checkGame(ui.player1Option, ui.player2Option);
    };
    
    return ui;

})();