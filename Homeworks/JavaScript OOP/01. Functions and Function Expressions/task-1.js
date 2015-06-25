/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum(numbers) {
    'use strict';
    var sumOfNumbers;
    if (!Array.isArray(numbers)) {
        throw new Error('Numbers should be array');
    }

    if (numbers.length === 0) {
        return null;
    }

    sumOfNumbers = numbers.reduce(function (s, n) {
        if (isNaN(n) || n === '' || typeof n === 'boolean') {
            throw new Error('Elements should be convertible to Number');
        }

        return s + Number(n);
    }, 0);

    return sumOfNumbers;
}

module.exports = sum;