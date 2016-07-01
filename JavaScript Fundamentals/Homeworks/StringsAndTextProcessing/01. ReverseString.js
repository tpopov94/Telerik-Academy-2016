/* globals console */

function ReverseString(args) {
    "use strict";

    var input = args[0],
        reversedInput = "";

    for (let index = input.length - 1; index >= 0; index -= 1) {

        reversedInput += input[index];
    }

    console.log(reversedInput);
}

ReverseString(["Joro"]);