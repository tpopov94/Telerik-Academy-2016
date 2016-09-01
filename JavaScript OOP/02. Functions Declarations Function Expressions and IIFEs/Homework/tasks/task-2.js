/* Task description */
/*
 Write a function that finds all the prime numbers in a range
 1) it should return the prime numbers in an array
 2) it must throw an Error if any on the range params is not convertible to `Number`
 3) it must throw an Error if any of the range params is missing
 */

/*globals module*/
function findPrimes(startNumber, endNumber) {
    "use strict";
    if (arguments.length < 2) {
        throw "Error! Pass 2 arguments!";
    } else if (isNaN(arguments[0]) || isNaN(arguments[1])) {
        throw "Error! Arguments must be convertible to numbers.";
    }
    var result = [],
        i,
        j,
        maxDivisor,
        isPrime;
    startNumber *= 1;
    endNumber *= 1;

    for (i = startNumber; i <= endNumber; i += 1) {
        maxDivisor = Math.sqrt(i);
        isPrime = true;

        if (i < 2) {
            isPrime = false;
        }
        for (j = 2; j <= maxDivisor; j += 1) {
            if (!(i % j)) {
                isPrime = false;
                break;
            }
        }
        if (isPrime) {
            result.push(i);
        }
    }
    return result;
}

module.exports = findPrimes;
