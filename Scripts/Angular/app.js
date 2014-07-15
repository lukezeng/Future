var restaurantApp = angular.module('restaurantApp', ["ngRoute", "ngResource", "ngAnimate"]).
    config(function ($routeProvider,$locationProvider) {
        $routeProvider.
            when('/', {
                controller: 'topCompaniesViewCtrl',
                templateUrl: '/Templates/topCompanies.html'
            }).
            when('/topCompanies', {
                controller: 'topCompaniesViewCtrl',
                templateUrl: '/Templates/topCompanies.html'
            });
        //$locationProvider.html5Mode(true);
    }).
    directive('greet', function () {
        return {
            template: '<h2>Greeting from {{from}} to {{to}}</h2>',
            controller: function ($scope, $element, $attrs) {
                $scope.from = $attrs.from;
                $scope.to = $attrs.greet;
            }
        }
    });









