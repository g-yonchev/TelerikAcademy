/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes(from, to) {
    'use strict';
    var primes = [],
        i;

    function isNumber(n) {
        if (isNaN(n) || n === '' || typeof(n) === 'boolean') {
            return false;
        }
        return true;
    }

    function isPrime(n) {
        var j;

        if (n < 2) {
            return false;
        }

        for (j = 2; j <= Math.sqrt(n) ; j += 1) {
            if (n % j === 0) {
                return false;
            }
        }
        return true;
    }

    if (from === undefined || to === undefined) {
        throw new Error('Missing parametars');
    }

    if (!isNumber(from) || !isNumber(to)) {
        throw new Error('Parametars should be numbers');
    }

    from = Number(from);
    to = Number(to);

    for (i = from; i <= to; i += 1) {
        if (isPrime(i)) {
            primes.push(i);
        }
    }
    return primes;
}

module.exports = findPrimes;
