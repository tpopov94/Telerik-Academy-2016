function sortThreeNumbers() {
    'use strict';

    var firstNumber = +document.getElementById('inputOne').value,
        secondNumber = +document.getElementById('inputTwo').value,
        thirdNumber = +document.getElementById('inputThree').value;

    // Input check if all values are numbers

    if (isNaN(firstNumber) || isNaN(secondNumber) || isNaN(thirdNumber)) {
        window.console.log('Please enter only numbers');
        document.getElementById('console').innerHTML+= 'Please enter only numbers';
    }

    else {
        if(firstNumber >= secondNumber && firstNumber >= thirdNumber) {
            if(secondNumber > thirdNumber) {
                window.console.log('Descending order: ' + firstNumber + ' ' + secondNumber + ' ' + thirdNumber);
                document.getElementById('console').innerHTML += 'Descending order: ' + firstNumber + ' ' + secondNumber + ' ' + thirdNumber + '<br>';
            }

            else {
                window.console.log('Descending order: ' + firstNumber + ' ' + thirdNumber + ' ' + secondNumber);
                document.getElementById('console').innerHTML += 'Descending order: ' + firstNumber + ' ' + thirdNumber + ' ' + secondNumber + '<br>';
            }
        }

        if(secondNumber > firstNumber && secondNumber > thirdNumber) {
            if(firstNumber > thirdNumber) {
                window.console.log('Descending order: ' + secondNumber + ' ' + firstNumber + ' ' + thirdNumber);
                document.getElementById('console').innerHTML += 'Descending order: ' + secondNumber + ' ' + firstNumber + ' ' + thirdNumber + '<br>';
            }

            else {
                window.console.log('Descending order: ' + secondNumber + ' ' + thirdNumber + ' ' + firstNumber);
                document.getElementById('console').innerHTML += 'Descending order: ' + secondNumber + ' ' + thirdNumber + ' ' + firstNumber + '<br>';
            }
        }

        if(thirdNumber > firstNumber && thirdNumber > secondNumber) {
            if(firstNumber > secondNumber) {
                window.console.log('Descending order: ' + thirdNumber + ' ' + firstNumber + ' ' + secondNumber);
                document.getElementById('console').innerHTML += 'Descending order: ' + thirdNumber + ' ' + firstNumber + ' ' + secondNumber + '<br>';
            }

            else {
                window.console.log('Descending order: ' + thirdNumber + ' ' + secondNumber + ' ' + firstNumber);
                document.getElementById('console').innerHTML += 'Descending order: ' + thirdNumber + ' ' + secondNumber + ' ' + firstNumber + '<br>';
            }
        }

    }
}
