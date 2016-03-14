function multiplicationSign() {
    "use strict";

    var firstNumber = +document.getElementById('inputFormOne').value,
        secondNumber = +document.getElementById('inputFormTwo').value,
        thirdNumber = +document.getElementById('inputFormThree').value;

    // Input check if all values are numbers

    if (isNaN(firstNumber) || isNaN(secondNumber) || isNaN(thirdNumber)) {
        window.console.log('Please enter only numbers');
        document.getElementById('console').innerHTML+= 'Please enter only numbers';
    }

    else {
        if(firstNumber === 0 || secondNumber === 0 || thirdNumber === 0) {
            window.console.log('Multiplication sign of ' + firstNumber + ' ' + secondNumber + ' ' + thirdNumber + ' is: 0');
            document.getElementById('console').innerHTML+= 'Multiplication sign of ' + firstNumber + ' ' + secondNumber + ' ' + thirdNumber + ' is: 0';
        }
        if(firstNumber > 0 && secondNumber > 0 && thirdNumber > 0) {
            window.console.log('Multiplication sign of ' + firstNumber + ' ' + secondNumber + ' ' + thirdNumber + ' is: +');
            document.getElementById('console').innerHTML+= 'Multiplication sign of ' + firstNumber + ' ' + secondNumber + ' ' + thirdNumber + ' is: +' + '<br>';
        }
        if((firstNumber < 0 && secondNumber > 0 && thirdNumber > 0) || (firstNumber > 0 && secondNumber < 0 && thirdNumber > 0) ||
            (firstNumber > 0 && secondNumber > 0 && thirdNumber < 0)) {
            window.console.log('Multiplication sign of ' + firstNumber + ' ' + secondNumber + ' ' + thirdNumber + ' is: -');
            document.getElementById('console').innerHTML+= 'Multiplication sign of ' + firstNumber + ' ' + secondNumber + ' ' + thirdNumber + ' is: -' + '<br>';
        }
        if((firstNumber < 0 && secondNumber < 0 && thirdNumber > 0) || (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0) ||
            (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0)) {
            window.console.log('Multiplication sign of ' + firstNumber + ' ' + secondNumber + ' ' + thirdNumber + ' is: +');
            document.getElementById('console').innerHTML+= 'Multiplication sign of ' + firstNumber + ' ' + secondNumber + ' ' + thirdNumber + ' is: +' + '<br>';
        }
        if(firstNumber < 0 && secondNumber < 0 && thirdNumber < 0) {
            window.console.log('Multiplication sign of ' + firstNumber + ' ' + secondNumber + ' ' + thirdNumber + ' is: -');
            document.getElementById('console').innerHTML+= 'Multiplication sign of ' + firstNumber + ' ' + secondNumber + ' ' + thirdNumber + ' is: -' + '<br>';
        }
    }
}