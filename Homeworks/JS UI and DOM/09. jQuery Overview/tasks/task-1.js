/* globals $ */

/* 

Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:   
  * The UL must have a class `items-list`
  * Each of the LIs must:
    * have a class `list-item`
    * content "List item #INDEX"
      * The indices are zero-based
  * If the provided selector does not selects anything, do nothing
  * Throws if
    * COUNT is a `Number`, but is less than 1
    * COUNT is **missing**, or **not convertible** to `Number`
      * _Example:_
        * Valid COUNT values:
          * 1, 2, 3, '1', '4', '1123'
        * Invalid COUNT values:
          * '123px' 'John', {}, [] 
*/

function solve() {
  return function (selector, count) {
    function checkCount(count) {
      if (typeof count === 'undefined') {
        throw 'undefined';
      }

      if (!(typeof count === 'number' || typeof count === 'string')) {
        throw 'not a number nor string';
      }

      if (typeof count === 'number') {
        if (count < 1) {
          throw 'number less than 1';
        }
      }

      if (typeof count === 'string') {
        if (isNaN(count)) {
          throw 'NaN';
        }

        if (count === ''){
          throw 'empty string';
        }

        count = +count;

        if (count < 1) {
          throw 'string number less than 1';
        }
      }
    }
    function checkSelector(selector) {
      if (typeof selector !== 'string') {
        throw 'selector should be a string';
      }
    }

    checkCount(count);
    checkSelector(selector);

    var $selector = $(selector),
        $ul = $('<ul/>');

    $ul.addClass('items-list');

    for (var i = 0; i < count; i++) {
      var $li = $("<li/>");
      $li
        .addClass('list-item')
        .html('List item #' + i)
        .appendTo($ul);
    }

    $ul.appendTo($selector);
  };
};

module.exports = solve;