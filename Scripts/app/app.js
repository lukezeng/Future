var restaurantApp = angular.module('restaurantApp', []);

restaurantApp.controller('navigationCtrl', function ($scope) {
    $scope.tabVal = 3;
    this.setTab = function (val) {
        $scope.tabVal = val;
    }
    this.isSet = function (val) {
        return $scope.tabVal === val;
    }
});


restaurantApp.controller('restaurantListCtrl', function ($scope, $http) {
    $http({ method: 'POST', url: '/AjaxHandler/GetRestautants' }).
    success(function (data, status, headers, config) {
        // this callback will be called asynchronously
        // when the response is available
        $scope.restaurants = data;
    }).
    error(function (data, status, headers, config) {
        // called asynchronously if an error occurs
        // or server returns response with an error status.
    });

    
});

