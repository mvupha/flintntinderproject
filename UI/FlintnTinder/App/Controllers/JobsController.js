AngularApp.controller('JobsController',
    [
        '$scope','$window','JobsService',
        function ($scope, $window, JobsService) {
            
            $scope.back = function () {
                $scope.$broadcast("show-errors-reset");
                $window.history.back();
            };

            var handleError = function (error) {
                $scope.hasError = true;
                $scope.errorMessage = error.data.message;
            };
             $scope.sortKeyOrder = {
                key: "Client",
                order: "ASC"
            };

            $scope.totalItems = 0;
            $scope.currentPage = 1;
            $scope.maxSize = 5;
            $scope.recordsPerPage = 10;
            $scope.numberOfPageButtons = 5;

            $scope.sort = function (col) {
                if ($scope.sortKeyOrder.key === col) {
                    if ($scope.sortKeyOrder.order == 'ASC')
                        $scope.sortKeyOrder.order = 'DESC';
                    else
                        $scope.sortKeyOrder.order = 'ASC';
                } else {
                    $scope.sortKeyOrder.key = col;
                    $scope.sortKeyOrder.order = 'ASC';
                }
                loadGrid();
            };

            $scope.searchFor = '';

            $scope.search = function () {
                loadGrid();
            }

            var loadGrid = function () {
                var searchfor = '';
                JobsService.JobsGrid($scope.currentPage, $scope.recordsPerPage,
                                      $scope.sortKeyOrder.key, $scope.sortKeyOrder.order, $scope.searchFor).then(

                        function (result) {
                            $scope.populateGrid = result.data.results;
                            $scope.totalItems = result.data.recordCount;
                        },
                        function (error) {
                            handleError(error);
                        });
            };
            $scope.pageChanged = function () {
                loadGrid();
            };
            loadGrid();

}]);