(function () {
    "use strict";

    angular.module("mdrApp", ['ngRoute', 'ngMessages'])
    .config(routeConfig);

    function routeConfig($routeProvider, $locationProvider) {
        $routeProvider.
            when('/damageReport', {
                templateUrl: '/app/damageReport/damageReport.html',
                controller: 'damageReportController'
            }).
            when('/contact', {
                templateUrl: '/app/contact/contact.html',
                controller: 'contactController'
            })
            .otherwise({ redirectTo: '/damageReport' });

        $locationProvider.html5Mode({
            enabled: true,
            requireBase: false
        });
    };
})();