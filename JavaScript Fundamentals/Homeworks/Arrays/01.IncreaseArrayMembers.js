function increaseArrayMembers(args) {
    'use strict';

    var input = +args[0],
    arrayOfNumbers = [],
    i;

    for (i = 0; i < input; i += 1) {
        arrayOfNumbers[i] = i * 5; 
    }

    console.log(arrayOfNumbers.join('\n'));
}
increaseArrayMembers(13);
