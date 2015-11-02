(function () {
    "use strict";
    angular.module("mdrApp").
    controller("contactController", ['contactService', ContactController]);

    function ContactController(contactService) {
        var vm = this;

        vm.sendMessage = function () {
            contactService.sendContactMessage(vm.contactForm).then(
                //success
                function () {

                },
                //error
                function () {

                }
            )
        };
    };
})();