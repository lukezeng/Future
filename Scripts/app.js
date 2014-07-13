var restaurantApp = angular.module('restaurantApp', ["ngRoute", "ngResource"]).
    config(function ($routeProvider) {
        $routeProvider.
            when('/', {
                controller: 'restaurantListCtrl',
                templateUrl: 'Templates/RestaurantList.html'
            }).
            when('/topCompanies', {
                controller: 'topCompaniesListCtrl',
                templateUrl: 'Templates/topCompanies.html'
            }).
            when('/topCompanies/:companyName', {
                controller: 'companyCtrl',
                templateUrl: 'Templates/company.html'
            }).
            when('/angualrExamples', {
                controller: 'examplesCtrl',
                templateUrl: 'Templates/angualrExamples.html'
            }).
            when('/:unknown', {
                controller: 'unknownPageCtrl',
                templateUrl: 'Templates/404unknown.html'
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
    $scope.tabVal = 1;
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





restaurantApp.controller('topCompaniesListCtrl', function ($scope, $http, companies) {

    $scope.companies = [];
    companies.list(function (companiesList) {
        $scope.companies = companiesList;
    });
    $scope.companiesPerPage = 9;
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
        return Math.ceil($scope.companies.length / $scope.companiesPerPage) - 1;
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

restaurantApp.factory('companies', function ($http) {
    function getCompanyList(callback) {
        $http({
            method: 'POST',
            url: '/api/company/GetAllCompanies',
            cache: true
        }).
        success(callback).
        error(function (data, status, headers, config) {
            // called asynchronously if an error occurs
            // or server returns response with an error status.
        });
    }
    
    return {
        list: getCompanyList,
    }
})

restaurantApp.controller('examplesCtrl', function ($scope, $http) {
    $scope.sortOrder = 'lastName';
    $scope.textToShow = "here is the text to show";
    $scope.nameList = ['Luke', 'Kaixin', 'Jianmin'];
    $scope.addName = function () {
        $scope.nameList.push($scope.nameToAdd);
        $scope.nameToAdd = '';
    }
    $scope.UserList = [
        {firstName:'Luke',lastName:'Zeng'},
        {firstName:'Kaixin',lastName:'Li'},
        {firstName:'Jianmin',lastName:'Chen'}
    ];
    $scope.addUser = function () {
        $scope.UserList.push({ firstName: $scope.userFirstName, lastName: $scope.userLastName });
        $scope.userFirstName = '';
        $scope.userLastName = '';
    }


});

restaurantApp.controller('companyCtrl', function ($scope, $routeParams) {

    $scope.companyName = $routeParams.companyName;


});


restaurantApp.controller('unknownPageCtrl', function ($scope, $routeParams) {

    $scope.unknownString = $routeParams.unknown;


});







