(function () {
    'use strict';

    angular.module('mdrApp')
        .controller('topnavController', topnavController);

    function topnavController($route) {
        var vm = this;

        vm.isRoute = isRoute;

        function isRoute(r) {
            return $route.current.title.substr(0, r.length) === r;
        }
    }
}());


