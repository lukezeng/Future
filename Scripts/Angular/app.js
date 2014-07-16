var restaurantApp = angular.module('restaurantApp', ["ngRoute", "ngResource", "ngAnimate"]).
    config(function ($routeProvider, $locationProvider) {
        $routeProvider.
            when('/', {
                controller: 'ProfilePageCtrl',
                templateUrl: '/Templates/ProfilePage.html'
            }).
            when('/topCompanies', {
                controller: 'topCompaniesViewCtrl',
                templateUrl: '/Templates/topCompanies.html'
            }).
            when('/angualrExamples', {
                controller: 'examplesCtrl',
                templateUrl: '/Templates/angualrExamples.html'
            });
        //$locationProvider.html5Mode(true);
    });









