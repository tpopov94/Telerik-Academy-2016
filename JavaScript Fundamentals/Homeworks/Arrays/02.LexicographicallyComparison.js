function LexicographicallyComparison(args) {
    'use strict';

    var arr = args[0].split('\n'),
        firstArrayOfCharrs = String(arr[0]),
        secondArrayOfCharrs = String(arr[1]);


    if (firstArrayOfCharrs > secondArrayOfCharrs) {
        console.log('>');
    }
    else if (firstArrayOfCharrs < secondArrayOfCharrs) {
        console.log('<');
    } else if (firstArrayOfCharrs === secondArrayOfCharrs) {
        console.log('=');
    }
}

LexicographicallyComparison(23);