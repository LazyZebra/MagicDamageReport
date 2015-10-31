(function () {
    "use strict";

    angular.module("mdrApp", ['ngRoute'])
    .config(routeConfig);

    function routeConfig($routeProvider) {
        $routeProvider.
            when('/', {
                templateUrl: 'app/damageReport/damageReport.html',
                controller: 'damageReportController'
            }).
            when('/contact', {
                templateUrl: 'app/contact/contact.html',
                controller: 'contactController'
            })
            .otherwise({ redirectTo: '/' });
    };
})();