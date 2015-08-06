function solve() {
    $.fn.datepicker = function () {
        var MONTH_NAMES = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
        var WEEK_DAY_NAMES = ['Su', 'Mo', 'Tu', 'We', 'Th', 'Fr', 'Sa'];

        Date.prototype.getMonthName = function () {
            return MONTH_NAMES[this.getMonth()];
        };

        Date.prototype.getDayName = function () {
            return WEEK_DAY_NAMES[this.getDay()];
        };

		// you are welcome :)
		var date = new Date();

		//console.log(date.getDayName());
		//console.log(date.getMonthName());



        var $container = this.parent().addClass('datepicker-wrapper');
        this.addClass('datepicker');

        console.log($container)

        var $calendar = $('<div/>').addClass('datepicker-content').appendTo($container).hide();

        this.on('click', function () {
            $calendar.show();
        })


        var $table = $('<table/>').addClass('calendar').appendTo($calendar);

        for (var i = 0; i < 7; i++) {
            var $row = $('<tr/>');

            for (var j = 0; j < 7; j++) {
                var $col = $('<td/>');

                if (i === 0) {

                }
                $row.append($col);
            }
            $table.append($row)
        }

        return this;

    };
}