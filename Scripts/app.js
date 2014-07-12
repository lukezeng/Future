var restaurantApp = angular.module('restaurantApp', ["ngRoute", "ngResource"]).
    config(function ($routeProvider) {
        $routeProvider.
            when('/', {
                controller: 'restaurantListCtrl',
                templateUrl: 'Templates/RestaurantList.html'
            }).
            when('/about', {
                controller: 'restaurantListCtrl1',
                templateUrl: 'Templates/about.html'
            }).
            otherwise({ redirectTo: '/' });
    }).
    directive('greet', function () {
    return {
        template: '<h2>Greeting from {{from}} to {{to}}</h2>',
        controller: function ($scope, $element, $attrs) {
            $scope.from = $attrs.from;
            $scope.to = $attrs.greet;
        }
    }
})

restaurantApp.controller('navigationCtrl', function ($scope) {
    $scope.tabVal = 3;
    this.setTab = function (val) {
        $scope.tabVal = val;
    }

    this.isSet = function (val) {
        return $scope.tabVal === val;
    }

    
});

restaurantApp.filter('offset', function () {
    return function (input, start) {
        start = parseInt(start, 10);
        return input.slice(start);
    };
});

restaurantApp.controller('restaurantListCtrl', function ($scope, $http) {

    $scope.restaurants = [];
    //$http({ method: 'POST', url: '/AjaxHandler/GetRestautants' }).
    $http({ method: 'POST', url: '/api/restaurant/GetAllRestaurants' }).
    success(function (data, status, headers, config) {
        // this callback will be called asynchronously
        // when the response is available
        $scope.restaurants = data;

    }).
    error(function (data, status, headers, config) {
        // called asynchronously if an error occurs
        // or server returns response with an error status.
    });

    $scope.restaurantsPerPage = 5;
    $scope.currentPage = 0;




    $scope.prevPage = function () {
        if ($scope.currentPage > 0) {
            $scope.currentPage--;
        }
    };

    $scope.prevPageDisabled = function () {
        return $scope.currentPage === 0 ? "disabled" : "";
    };

    $scope.pageCount = function () {
        return Math.ceil($scope.restaurants.length / $scope.restaurantsPerPage) - 1;
    };

    $scope.nextPage = function () {
        if ($scope.currentPage < $scope.pageCount()) {
            $scope.currentPage++;
        }
    };

    $scope.nextPageDisabled = function () {
        return $scope.currentPage === $scope.pageCount() ? "disabled" : "";
    };

    $scope.setPage = function (n) {
        $scope.currentPage = n;
    };

    $scope.range = function () {
        var rangeSize = 4;
        var ret = [];
        var start;

        start = $scope.currentPage;
        if (start > $scope.pageCount() - rangeSize) {
            start = $scope.pageCount() - rangeSize + 1;
        }

        for (var i = start; i < start + rangeSize; i++) {
            if (i - 1 < $scope.pageCount() && i >= 0) { ret.push(i); }
        }
        return ret;
    };


});





restaurantApp.controller('restaurantListCtrl1', function ($scope, $http) {

    $scope.restaurants = [];
    //$http({ method: 'POST', url: '/AjaxHandler/GetRestautants' }).
    $http({ method: 'POST', url: '/api/restaurant/GetAllRestaurants' }).
    success(function (data, status, headers, config) {
        // this callback will be called asynchronously
        // when the response is available
        $scope.restaurants = data;

    }).
    error(function (data, status, headers, config) {
        // called asynchronously if an error occurs
        // or server returns response with an error status.
    });

    $scope.restaurantsPerPage = 5;
    $scope.currentPage = 0;




    $scope.prevPage = function () {
        if ($scope.currentPage > 0) {
            $scope.currentPage--;
        }
    };

    $scope.prevPageDisabled = function () {
        return $scope.currentPage === 0 ? "disabled" : "";
    };

    $scope.pageCount = function () {
        return Math.ceil($scope.restaurants.length / $scope.restaurantsPerPage) - 1;
    };

    $scope.nextPage = function () {
        if ($scope.currentPage < $scope.pageCount()) {
            $scope.currentPage++;
        }
    };

    $scope.nextPageDisabled = function () {
        return $scope.currentPage === $scope.pageCount() ? "disabled" : "";
    };

    $scope.setPage = function (n) {
        $scope.currentPage = n;
    };

    $scope.range = function () {
        var rangeSize = 4;
        var ret = [];
        var start;

        start = $scope.currentPage;
        if (start > $scope.pageCount() - rangeSize) {
            start = $scope.pageCount() - rangeSize + 1;
        }

        for (var i = start; i < start + rangeSize; i++) {
            if (i - 1 < $scope.pageCount() && i >= 0) { ret.push(i); }
        }
        return ret;
    };

    
});



