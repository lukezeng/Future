var mainApp = angular.module('restaurantApp', ["ngRoute", "ngResource", "ngAnimate","ui.bootstrap"]).
    config(function ($routeProvider, $locationProvider) {
        $routeProvider.
            when('/', {
                controller: 'ProfilePageCtrl',
                templateUrl: '/Templates/ProfilePage.html'
            }).
            when('/casual', {
                controller: 'ProfilePageCtrl',
                templateUrl: '/Templates/ProfilePage1.html'
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









