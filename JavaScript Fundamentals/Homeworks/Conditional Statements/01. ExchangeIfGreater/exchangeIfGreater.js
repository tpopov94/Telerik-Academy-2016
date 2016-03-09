
function exchangeIfGreater() {
    "use strict";
    var inputOne = +document.getElementById('inputFormOne').value,
        inputTwo = +document.getElementById('inputFormTwo').value,
        bigger = inputOne;

    if (isNaN(inputOne) || isNaN(inputTwo)) {
        window.console.log('Enter only Numbers');
        document.getElementById('console').innerHTML +='Enter only Numbers';
    }

    else {
        if(bigger > inputTwo) {
            inputOne = inputTwo;
            inputTwo = bigger;
                document.getElementById('console').innerHTML += 'a = ' + inputOne + ' b = ' + inputTwo;
                window.console.log('a = ' + inputOne + ' b = ' + inputTwo);
        }
        else {
            document.getElementById('console').innerHTML += 'a = ' + inputOne + ' b = ' + inputTwo;
            window.console.log('a = ' + inputOne + ' b = ' + inputTwo);
        }
    }
}