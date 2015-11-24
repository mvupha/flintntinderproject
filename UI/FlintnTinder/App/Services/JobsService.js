AngularApp.factory('JobsService',
    ['$http',
        function($http){
            
            var jobsGrid = function(currentPage,recordsPerPage,sortKey,sortOrder,searchFor){
                
                var request = {
                    CurrentPage:currentPage,
                    RecordsPerPage:recordsPerPage,
                    SortKey:sortKey,
                    SortOrder:sortOrder,
                    SearchFor:searchFor
                }
                return $http.post("/Jobs/JobsGrid", request);

            };

            return{
                JobsGrid:jobsGrid
            }
}]);