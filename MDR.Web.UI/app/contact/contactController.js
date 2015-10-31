(function () {
    "use strict";
    angular.module("mdrApp").
    controller("contactController", ContactController);

    function ContactController() {
        var vm = this;
        vm.sendMessage = function (isValid) {
            if (isValid) {
                alert("Form is valid");
            }
            else {
                alert("Form is invalid");
            }
        };
    };
})();