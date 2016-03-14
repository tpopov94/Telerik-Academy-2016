function theBiggestOfThreeNumbers(){
    'use strict';

    var firstNumber = +document.getElementById('inputFormOne').value,
        secondNumber = +document.getElementById('inputFormTwo').value,
        thirdNumber = +document.getElementById('inputFormThree').value;

    // Input check if all values are numbers

    if (isNaN(firstNumber) || isNaN(secondNumber) || isNaN(thirdNumber)) {
        window.console.log('Please enter only numbers');
        document.getElementById('console').innerHTML+= 'Please enter only numbers';
    }

    else {
        if(firstNumber >= secondNumber && firstNumber >= thirdNumber ) {
            window.console.log('The biggest number is: ' + firstNumber);
            document.getElementById('console').innerHTML+= 'The biggest number is: ' + firstNumber + '<br>';
        }

        else {
            if (secondNumber >= firstNumber && secondNumber >= thirdNumber) {
                window.console.log('The biggest number is: ' + secondNumber);
                document.getElementById('console').innerHTML+= 'The biggest number is: ' + secondNumber + '<br>';
            }

            else {
                if(thirdNumber >= firstNumber && thirdNumber >= secondNumber) {
                    window.console.log('The biggest number is: ' + thirdNumber);
                    document.getElementById('console').innerHTML+= 'The biggest number is: ' + thirdNumber + '<br>';
                }
            }
        }
    }
}