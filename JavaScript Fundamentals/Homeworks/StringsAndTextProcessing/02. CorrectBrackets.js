/* globals console */

function CorrectBrackets(args) {
    "use strict";

    var input = args[0],
        bracketsCount = 0;

    for (let symbol of input) {

        if (symbol === '(') {
            bracketsCount += 1;
        }
        else if (symbol === ')') {
            bracketsCount -= 1;
        }

        if (bracketsCount < 0) {
            console.log('Incorrect');
            break;
        }
    }

    if (bracketsCount > 0) {
        console.log('Incorrect');
    }
    if (bracketsCount === 0) {
        console.log('Correct');
    }
}

CorrectBrackets([')(a+b))']);
//CorrectBrackets(['((a+b)/5-d)']);