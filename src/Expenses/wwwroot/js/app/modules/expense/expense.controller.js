(function () {
    'use strict';

    angular
        .module('app.expense')
        .controller('ExpenseController', Expense);

    Expense.$inject = ['coreApi'];

    function Expense(coreApi) {
        var vm = this;
        vm.title = 'expense';
        vm.newExpense = {};
        vm.expenses = [];
        vm.categories = [];
        vm.months = [];

        vm.getExpenses = function () {
            coreApi.getExpenses()
                .then(function (data) {
                    vm.expenses = data;
                    getMonths();
                });
        };

        vm.addExpense = function () {
            vm.newExpense.create = new Date();
            coreApi.addExpense(vm.newExpense)
                .then(function (response) {
                    vm.expenses.push(vm.newExpense);
                    vm.newExpense = {};
                    getMonths();
                    closeModal();
                });
        };

        vm.getCategories = function () {
            coreApi.getCategories()
                .then(function (response) {
                    vm.categories = response;
                });
        };

        function closeModal() {
            angular.element('#addExpenseModal').modal('hide');
        };

        function getMonths() {
            for (var i = 0; i < vm.expenses.length; i++) {
                var month = new Date(Date.parse(vm.expenses[i].create));
                
                if (vm.months.length == 0) {
                    vm.months.push(month);
                }
                else {
                    for (var j = 0; j < vm.months.length; j++) {
                        var notExistsMonth = true;
                        if (vm.months[j].getFullYear() == month.getFullYear() &&
                            vm.months[j].getMonth() == month.getMonth()) {
                            notExistsMonth = false;
                            break;
                        }
                    }
                    if (notExistsMonth) {
                        vm.months.push(month);
                    }
                }

            }
        };
    }
})();
