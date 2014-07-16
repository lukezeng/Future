restaurantApp.factory('companies', function ($resource) {
    var urlGetAllCompanies = 'rest/Company/:id';
    return $resource(
                urlGetAllCompanies
            );

})

$(function () {
    $.ajax({
        type: 'POST',
        //url: '/api/company/GetAllCompanies',
        url: 'http://schedule.psu.edu/act_advanced_search_get_seats.cfm',
        data: {
            CEcrseloc: 'All',
            _cf_clientid: 'C49B8BC4A88DA1DC77413AF0ADADE119',
            _cf_nocache: 'true',
            _cf_nodebug: 'true',
            crseName: 'CMPSC',
            crseNum: '496',
            location: 'UP',
            semester: 'SUMMER 2014'
        }
    }).success(function(result){
        alert(result);
    });
});

restaurantApp.factory('getSeat', function ($http) {
    var urlGetSeat = 'http://schedule.psu.edu/act_advanced_search_get_seats.cfm';
    function getSeat(callback) {
        $http({
            method: 'POST',
            //url: '/api/company/GetAllCompanies',
            url: urlGetSeat,
            cache: true,
            data: {
                CEcrseloc: 'All',
                _cf_clientid: 'C49B8BC4A88DA1DC77413AF0ADADE119',
                _cf_nocache: 'true',
                _cf_nodebug: 'true',
                crseName: 'CMPSC',
                crseNum: '496',
                location: 'UP',
                semester: 'SUMMER 2014'
            }
        }).
        success(callback).
        error(function (data, status, headers, config) {
            // called asynchronously if an error occurs
            // or server returns response with an error status.
        });
    }
    return {
        list: getSeat,
    }
})