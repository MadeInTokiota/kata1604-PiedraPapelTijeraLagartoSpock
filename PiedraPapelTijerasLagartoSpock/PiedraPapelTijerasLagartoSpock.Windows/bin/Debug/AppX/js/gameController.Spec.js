/// <reference path="gameController.js" />

describe("gameController Tests", function () {

    var controller = PiedraPapelTijeraLagartoSpock.Controller;

    //This is not unit Testing
    it("gameController module members", function () {
        expect(controller.initialize).toBeDefined();
        expect(controller.checkGame).toBeDefined();
    });

});
