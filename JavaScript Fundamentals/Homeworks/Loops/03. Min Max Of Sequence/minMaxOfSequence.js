// Write a script that finds the max and min number from a sequence of numbers.

function minMaxOfSequence() {
    'use strict';

    var input = document.getElementById('inputForm').value.split(' '),
        i,
        min = Number.MAX_VALUE,
        max = Number.MIN_VALUE;

    window.console.log(max + ' ' + min);
   for(i = 0; i < input.length; i+=1) {
        if(+input[i] < min) {
            min = +input[i];
        }

       if(+input[i] > max) {
           max = +input[i];
       }
   }

    window.console.log('Max: ' + max + ' Min: ' + min );
    document.getElementById('console').innerHTML += 'Max: ' + max + ' Min: ' + min + '<br>';
}