/* globals console*/

function ReplaceNbsp(args) {
    "use strict";

    var text = args[0],
        replacedText;

    replacedText = text.replace(/ /g, "&nbsp");

    console.log(replacedText);
}

ReplaceNbsp(['This text contains 4 spaces!!']);