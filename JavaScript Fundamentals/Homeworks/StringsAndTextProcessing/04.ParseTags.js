/* globals console*/

function ParseTags(args) {
    "use strict";


        var input = args[0],
            parsedText;

    parsedText = input.search(/<upcase>.*\/upcase>/g);

    console.log(parsedText);
}

ParseTags([ 'We are <orgcase>liViNg</orgcase> in a <upcase>yellow submarine</upcase>. We <orgcase>doN\\t</orgcase> have <lowcase>anything</lowcase> else.']);

/* <upcase>text</upcase> to uppercase.
 <lowcase>text</lowcase> to lowercase
 <orgcase>text</orgcase> does not change casing
* */