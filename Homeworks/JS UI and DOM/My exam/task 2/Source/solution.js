function solve() {
    $.fn.datepicker = function () {
        var date = new Date();

        var MONTH_NAMES = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
        var WEEK_DAY_NAMES = ['Su', 'Mo', 'Tu', 'We', 'Th', 'Fr', 'Sa'];

        Date.prototype.getMonthName = function () {
            return MONTH_NAMES[this.getMonth()];
        };

        Date.prototype.getDayName = function () {
            return WEEK_DAY_NAMES[this.getDay()];
        };

        var currentDay = date.getDate();
        var currentMonthNumber = date.getMonth();
        var currentMonthName = date.getMonthName();
        var currentYear = date.getFullYear();

        var $this = $(this).wrap($('<div/>').addClass('datepicker-wrapper'));
        $this.addClass('datepicker');
        var $wrapper = $('.datepicker-wrapper');

        var $content = $('<div/>').addClass('datepicker-content').appendTo($wrapper);
        $content.hide();

        $('.datepicker').on('click', function() {
            $content.show();
        });

        var $controls = $('<div/>').addClass('controls').appendTo($content);
        var $table = $('<table/>').addClass('calendar').appendTo($content);
        var $currentDate = $('<div/>').addClass('current-date').appendTo($content);

        var $leftControl = $('<button/>').addClass('btn').appendTo($controls);
        var $currentMonth = $('<span/>').addClass('current-month').html(currentMonthName + ' ' + currentYear).appendTo($controls);
        var $rightControl = $('<button/>').addClass('btn').appendTo($controls);

        var $currentDateLink = $('<a/>').addClass('current-date-link').appendTo($currentDate);

        $currentDateLink.html(currentDay + ' ' + currentMonthName + ' ' + currentYear).css({cursor: 'pointer'});

        $currentDateLink.on('click', function() {
            $this.val(date.getDate() + '/' + (date.getMonth() + 1) + '/' + date.getFullYear());
            $content.hide();
        });

        $leftControl.on('click', function() {
            currentMonthNumber--;
            if (currentMonthNumber === -1) {
                currentYear--;
                currentMonthNumber = 11;
            }
            $currentMonth.html(MONTH_NAMES[currentMonthNumber] + ' ' + currentYear);
        });

        $rightControl.on('click', function() {
            currentMonthNumber++;
            if (currentMonthNumber === 12) {
                currentYear++;
                currentMonthNumber = 0;
            }
            $currentMonth.html(MONTH_NAMES[currentMonthNumber] + ' ' + currentYear);
        });

        var $thead = $('<thead/>').appendTo($table);
        var $tbody = $('<tbody/>').appendTo($table);
        var $rowHead = $('<tr/>').appendTo($thead);

        for (var k = 0; k < 7; k += 1) {
            $('<th/>').appendTo($rowHead).html(WEEK_DAY_NAMES[k]);
        }


        var counter = 0;
        for (var i = 0; i < 6; i+= 1) {
            var $tr = $('<tr/>').appendTo($tbody);
            for (var j = 0; j < 7; j++) {
                $('<td/>').appendTo($tr).addClass('current-month').html(j);
            }
        }


        $('.calendar').on('click', '.current-month', function () {
            $this.val(date.getDate() + '/' + (currentMonthNumber+1) + '/' + currentYear);
            $content.hide();
        });

        return $this;
    };
}