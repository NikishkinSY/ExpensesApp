(function () {
    'use strict';

    angular
        .module('app.core')
        .factory('coreApi', coreApi);

    coreApi.$inject = ['$http'];

    function coreApi($http) {
        var service = {
            getExpenses: getExpenses,
            getCategories: getCategories,
            addExpense: addExpense
        };

        return service;

        function getExpenses() {
            return $http({
                url: "/Expense/Get",
                method: "GET",
                })
                .then(function (response) {
                    return response.data;
                })
                .catch(console.log.bind(console));
        };

        function addExpense(expense) {
            return $http({
                    url: "/Expense/Save",
                    method: "POST",
                    data: expense
                })
                .then(function (response) {
                    return response;
                })
                .catch(console.log.bind(console));
        };

        function getCategories() {
            return $http({
                    url: "/Expense/GetCategories",
                    method: "GET"
                })
                .then(function (response) {
                    return response.data;
                })
                .catch(console.log.bind(console));
        };
    }
})();