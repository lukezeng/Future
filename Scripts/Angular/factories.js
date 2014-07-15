restaurantApp.factory('companies', function ($http) {
    function getCompanyList(callback) {
        $http({
            method: 'POST',
            //url: '/api/company/GetAllCompanies',
            url: 'api/Company/GetAllCompanies',
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

restaurantApp.factory('companyCEOs', function ($http) {
    function getCompanyCEOList(callback) {
        $http({
            method: 'POST',
            //url: '/api/company/GetAllCompanies',
            url: 'api/Company/GetAllCompanyCEOs',
            cache: true
        }).
        success(callback).
        error(function (data, status, headers, config) {
            // called asynchronously if an error occurs
            // or server returns response with an error status.
        });
    }

    return {
        list: getCompanyCEOList,
    }
})