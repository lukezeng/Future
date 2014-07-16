restaurantApp.controller('navigationCtrl', function ($scope) {
    //$scope.tabVal = 1;
    this.setTab = function (val) {
        $scope.tabVal = val;
    }

    this.isSet = function (val) {
        return $scope.tabVal === val;
    }

});

restaurantApp.controller('ProfilePageCtrl', function ($scope, $http, getSeat) {
    $scope.items = [];
    $scope.seat = 100;
    $scope.addItems = function () {
        for (i = 10; i--;) {
            $scope.items.push({ title: "item" + i, });
        }
    }
    $scope.clearItems = function () {
        $scope.items = [];
    }
    $scope.removeItem = function (index) {
        $scope.items.splice(index, 1);

    }

    getSeat.list(function (getSeat) {
        $scope.seat = getSeat;
    });
});





restaurantApp.controller('topCompaniesViewCtrl', function ($scope, $http, companies) {
    $scope.company = {};
    $scope.companies = companies.query();
    $scope.companiesPerPage = 9;
    $scope.currentPage = 0;

    $scope.SaveCompany = function () {
        $scope.companies.push($scope.company);
    }


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


restaurantApp.controller('examplesCtrl', function ($scope, $http) {
    $scope.sortOrder = 'lastName';
    $scope.textToShow = "here is the text to show";
    $scope.nameList = ['Luke', 'Kaixin', 'Jianmin'];
    $scope.addName = function () {
        $scope.nameList.push($scope.nameToAdd);
        $scope.nameToAdd = '';
    }
    $scope.UserList = [
        { firstName: 'Luke', lastName: 'Zeng' },
        { firstName: 'Kaixin', lastName: 'Li' },
        { firstName: 'Jianmin', lastName: 'Chen' }
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