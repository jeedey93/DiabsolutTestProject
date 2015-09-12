var personApp = angular.module('personApp', []);

personApp.controller('personController', ['$scope', function ($scope) {
    $scope.name = 'Mary Jane';
    $scope.age = "1";
}]);

personApp.factory('personFactory', function () {
    function getName() {
        return "Mary Jane";
    }

    var service = {
        getName: getName
    };

    return service;
});