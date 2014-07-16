restaurantApp.factory('companies', function ($resource) {
    var urlGetAllCompanies = 'rest/Company/:id';
    return $resource(
                urlGetAllCompanies
            );
})