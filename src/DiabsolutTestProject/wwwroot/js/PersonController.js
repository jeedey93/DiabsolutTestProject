var personApp = angular.module('personApp', []);

personApp.controller('personController', ['$scope', '$http', function ($scope, $http) {
    $scope.name = "Mary";
    $scope.age = "15";

    $http.get('http://localhost:4306/api/processes').
        success(function (data, status, headers, config) {
            $scope.yo = data;
        }).
        error(function (data, status, headers, config) {
            alert("error");
        });

    $http.get('http://localhost:4306/api/people').
        success(function (data, status, headers, config) {
            $scope.persons = data;
        }).
        error(function (data, status, headers, config) {
            alert("error");
        });



}]);
