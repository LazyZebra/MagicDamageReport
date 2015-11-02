(function () {
    "use strict";

    angular.module("mdrApp").
        factory('contactService', ['$http',
        function ($http) {
            var sendContactMessage = function (contactMessage) {
                return $http.post("Contact/Post", contactMessage);
            };

            return {
                sendContactMessage: sendContactMessage
            }
        }]);
})();