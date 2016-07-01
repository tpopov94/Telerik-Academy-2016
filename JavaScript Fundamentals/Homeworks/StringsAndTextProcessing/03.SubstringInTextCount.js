/* globals console*/

function SubstringInTextCount(args) {
    "use strict";

    var searchedString = args[0],
        text = args[1],
        appearanceCounter = text.split(searchedString);

    console.log(appearanceCounter.length - 1);
}


//SubstringInTextCount(['in',
//    'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.']);

SubstringInTextCount(['joro', 'pesho joro pesho peshopespeshoho joro']);