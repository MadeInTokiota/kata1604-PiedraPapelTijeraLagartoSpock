/// <reference path="gameUi.js" />
/// <reference path="gameController.js" />

describe("gameUi Tests", function () {

    var ui = PiedraPapelTijeraLagartoSpock.Ui;

    //This is not unit testing
    it("gameUi module members", function () {
        expect(ui.initialize).toBeDefined();
        expect(ui.configure).toBeDefined();
        expect(ui.registerEvents).toBeDefined();
        expect(ui.playGame).toBeDefined();
    });

    //test initialize
    it("gameUi initialize method", function () {        
        ui.initialize();
        //check if its controller has been assigned
        expect(ui.controller).toBeDefined();
    });

    //test configure
    it("gameUi configure method", function () {

        spyOn(ui.controller, 'getLegalHands').and.callThrough();

        ui.configure();
        //check if its controller has been assigned
        expect(ui.controller.getLegalHands).toHaveBeenCalled();
    });

    //TODO test registerEvents
    //

    //TODO test playGame
    //spy on controller

});