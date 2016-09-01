/* globals console */
/*Write a function that sums an array of numbers:

 Numbers must be always of type Number
 Returns null if the array is empty
 Throws Error if the parameter is not passed (undefined)
 Throws if any of the elements is not convertible to Number
 */

function sum(arr) {
    "use strict";
    var sum = 0;

    if (arr === undefined) {
        throw "You must enter an array of numbers";
    }
    if (arr.length === 0) {
        return null;
    }

    if (Array.isArray(arr)) {
        for (let i = 0, len = arr.length; i < len; i += 1) {
            if (isNaN(arr[i])) {
                throw "Array must contain only numbers";
            } else {
                sum += +arr[i];
            }
        }
    }

    return sum;
}

module.exports = sum;