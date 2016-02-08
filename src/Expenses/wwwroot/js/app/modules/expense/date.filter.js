(function () {
    'use strict';

    angular
        .module('app.expense')
        .filter('month', month);

    month.$inject = [];

    function month() {
        return function (items, month) {
            if (month) {
                //get date of start month&year
                var fromMonth = Date.parse(month.slice(1, -1));
                //get date of end month&year
                var toMonth = new Date(fromMonth).setMonth(new Date(fromMonth).getMonth() + 1);

                //get items which contain field Create beetwen start and end
                var arrayToReturn = [];
                for (var i = 0; i < items.length; i++) {
                    var expenseDate = Date.parse(items[i].create);
                    if (expenseDate >= fromMonth && expenseDate < toMonth) {
                        arrayToReturn.push(items[i]);
                    }
                }

                return arrayToReturn;
            }
            return items;
        };
    };
})();