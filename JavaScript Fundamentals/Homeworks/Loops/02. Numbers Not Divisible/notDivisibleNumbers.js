//Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time

function notDivisibleNumbers() {
    'use strict';

    var input = +document.getElementById('inputForm').value,
        i;

    if(isNaN(input)) {
        window.console.log('Please enter a valid number');
        document.getElementById('console').innerHTML += 'Please enter a valid number' + '<br>';
    }

    else {
        for(i = 0; i <= input; i+=1) {
            if(i % 21 !== 0){
                window.console.log(i);
                document.getElementById('console').innerHTML += i + '<br>';
            }
        }
    }
}