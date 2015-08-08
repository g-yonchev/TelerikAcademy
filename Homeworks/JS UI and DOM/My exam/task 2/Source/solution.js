function solve() {
    $.fn.datepicker = function () {
        var date = new Date();

        var MONTH_NAMES = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
        var WEEK_DAY_NAMES = ['Su', 'Mo', 'Tu', 'We', 'Th', 'Fr', 'Sa'];

        var w = {
            Su: 0,
            Mo: 1,
            Tu: 2,
            We: 3,
            Th: 4,
            Fr: 5,
            Sa: 6
        };

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

        $('.datepicker').on('click', function() {
            $content.addClass('datepicker-content-visible');
        });

        var $controls = $('<div/>').addClass('controls').appendTo($content);
        var $table = $('<table/>').addClass('calendar').appendTo($content);
        var $currentDate = $('<div/>').addClass('current-date').appendTo($content);

        var $leftControl = $('<button/>').addClass('btn').html('&lt').appendTo($controls);
        var $currentMonth = $('<span/>').addClass('current-month').html(currentMonthName + ' ' + currentYear).appendTo($controls);
        var $rightControl = $('<button/>').addClass('btn').html('&gt').appendTo($controls);

        var $currentDateLink = $('<a/>').addClass('current-date-link').appendTo($currentDate);

        $currentDateLink.html(currentDay + ' ' + currentMonthName + ' ' + currentYear).css({cursor: 'pointer'});

        $currentDateLink.on('click', function() {
            $this.val(date.getDate() + '/' + (date.getMonth() + 1) + '/' + date.getFullYear());
            $content.removeClass('datepicker-content-visible');
        });




        function getFirstDayName(month, year) {
            var d = new Date(year, month, 1);
            var name = d.getDayName();
            return w[name];
        }

        function getCountDays(month, year) {
            var d = new Date(year, month + 1, 0);
            return d.getDate();
        }

        function getArray(startDay, countDays, prevMonthDays) {
            startDay;
            var rest = 42 - countDays;
            rest = rest - startDay;

            if (startDay === 0) {
                rest = rest - 7;
            }

            var arr = [];
            for (var i = 1; i <= countDays; i++) {
                arr.push(i);
            }

            //if startday === 0 7 first another month
            if (startDay !== 0) {
                for (var i = 0; i < startDay; i++) {
                    arr.unshift(prevMonthDays);
                    prevMonthDays--;
                }

                for (var i = 0; i < rest; i++) {
                    arr.push(i + 1);
                }
            } else {
                for (var i = 0; i < 7; i++) {
                    arr.unshift(prevMonthDays);
                    prevMonthDays--;
                }

                for (var i = 0; i < rest; i++) {
                    arr.push(i + 1);
                }
            }
            return arr;

        }

        $leftControl.on('click', function() {
            currentMonthNumber--;
            if (currentMonthNumber === -1) {
                currentYear--;
                currentMonthNumber = 11;
            }
            $currentMonth.html(MONTH_NAMES[currentMonthNumber] + ' ' + currentYear);


            //console.log(MONTH_NAMES[currentMonthNumber] + ' ' + currentMonthNumber + ' ' + currentYear)
            var firtsDayName = getFirstDayName(currentMonthNumber, currentYear);
            var allDays = getCountDays(currentMonthNumber, currentYear);
            var prevMonthAllDays = getCountDays(currentMonthNumber - 1, currentYear);
            var arr = getArray(firtsDayName, allDays, prevMonthAllDays);


            updateCalendar(arr);


        });

        $rightControl.on('click', function() {
            currentMonthNumber++;
            if (currentMonthNumber === 12) {
                currentYear++;
                currentMonthNumber = 0;
            }
            $currentMonth.html(MONTH_NAMES[currentMonthNumber] + ' ' + currentYear);


            var firtsDayName = getFirstDayName(currentMonthNumber, currentYear);
            var allDays = getCountDays(currentMonthNumber, currentYear);
            var prevMonthAllDays = getCountDays(currentMonthNumber - 1, currentYear);

            var arr = getArray(firtsDayName, allDays, prevMonthAllDays);


            updateCalendar(arr);
        });


        function updateCalendar (arr) {

            $table.empty();
            var $thead = $('<thead/>').appendTo($table);
            var $tbody = $('<tbody/>').appendTo($table);
            var $rowHead = $('<tr/>').appendTo($thead);

            for (var i = 0; i < 7; i++) {
                $('<th/>').appendTo($rowHead).html(WEEK_DAY_NAMES[i]);
            }
            var counter = 0;
            var flag = false;
            for (i = 0; i < 6; i++) {
                var $tr = $('<tr/>').appendTo($tbody);
                for (var j = 0; j < 7; j++) {
                    if (currentArr[counter] === 1) {
                        flag = !flag;
                    }

                    if (!flag) {
                        $('<td/>').appendTo($tr).addClass('another-month').html(arr[counter]);
                    } else {
                        $('<td/>').appendTo($tr).addClass('current-month').html(arr[counter])
                    }
                    counter++;
                }
            }

        }





        var currFirtsDayName = getFirstDayName(currentMonthNumber, currentYear);
        var currAllDays = getCountDays(currentMonthNumber, currentYear);
        var currPrevMonthAllDays = getCountDays(currentMonthNumber - 1, currentYear);
        var currentArr = getArray(currFirtsDayName, currAllDays, currPrevMonthAllDays);


        var $thead = $('<thead/>').appendTo($table);
        var $tbody = $('<tbody/>').appendTo($table);
        var $rowHead = $('<tr/>').appendTo($thead);

        for (var i = 0; i < 7; i++) {
            $('<th/>').appendTo($rowHead).html(WEEK_DAY_NAMES[i]);
        }
        var counter = 0;
        var flag = false;
        for (i = 0; i < 6; i++) {
            var $tr = $('<tr/>').appendTo($tbody);
            for (var j = 0; j < 7; j++) {
                if (currentArr[counter] === 1) {
                    flag = !flag;
                }

                if (!flag) {
                    $('<td/>').appendTo($tr).addClass('another-month').html(currentArr[counter]);
                } else {
                    $('<td/>').appendTo($tr).addClass('current-month').html(currentArr[counter])
                }
                counter++;
            }
        }

        $('.calendar').on('click', '.current-month', function () {
            $this.val($(this).html() + '/' + (currentMonthNumber+1) + '/' + currentYear);
            $content.removeClass('datepicker-content-visible');
        });

        $('html').on('click', function(ev) {
            var $target = $(ev.target)
            if (!$target.parents().hasClass('datepicker-wrapper') && !$target.hasClass('datepicker-wrapper')) {
                $content.removeClass('datepicker-content-visible');
            }
        })

        return $this;
    };
}