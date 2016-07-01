/*globals console*/

function ExtractTextFromHTML(args) {
    "use strict";

    var input = args,
        finalResult = '';

    for (let index = 0; index < input.length; index += 1) {
        let currentText = input[index].replace(/\<.*?\>\s?/g, "");

        finalResult += currentText.trim();
    }

    console.log(finalResult);
}

ExtractTextFromHTML([
    '<html>',
    '  <head>',
    '    <title>Sample site</title>',
    '  </head>',
    '  <body>',
    '    <div>text',
    '      <div>more text</div>',
    '      and more...',
    '    </div>',
    '    in body',
    '  </body>',
    '</html>'
]);