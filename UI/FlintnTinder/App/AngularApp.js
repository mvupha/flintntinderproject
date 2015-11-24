var AngularApp = angular.module('AngularApp',
    ['ngRoute','ui.bootstrap','validation.match','ui.bootstrap.showErrors',
    'angular-loading-bar','ngAnimate'
]);

AngularApp.config(
    ['$routeProvider','$httpProvider','$locationProvider',
    function ($routeProvider, $httpProvider, $locationProvider) {
        
        $routeProvider
        .when("/",{
            templateUrl: "App/Views/Home/Home.html",
            controller: "IndexController"

        })
        .when("/home",{
            templateUrl:"App/Views/Home/Home.html",
            controller:"IndexController"

        })
        .when("/jobsGrid",{
            templateUrl:"App/Views/Jobs/JobsGrid.html",
            controller: "JobsController"
        })
        .otherwise({
        redirectTo:'/'
        });

        $locationProvider.html5Mode(true);

        $httpProvider.interceptors.push('AuthHttpResponseInterceptor');

        ////initialize get if not there
        if (!$httpProvider.defaults.headers.get) {
            $httpProvider.defaults.headers.get = {};
        }

        $httpProvider.defaults.headers.get['If-Modified-Since'] = 'Mon, 26 Jul 1997 05:00:00 GMT';
        $httpProvider.defaults.headers.get['Cache-Control'] = 'no-cache';
        $httpProvider.defaults.headers.get['Pragma'] = 'no-cache';


    }]);