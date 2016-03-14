function printNumbers() {
    'use strict';

    var n = +document.getElementById('inputForm').value,
        i;

    if(isNaN(n)) {
        window.console.log('Please enter a valid number');
        document.getElementById('console').innerHTML += 'Please enter a valid number' + '<br>';
    }

    else {
        for (i = 1; i <= n; i+= 1) {
            window.console.log(i);
            document.getElementById('console').innerHTML += i + '  ';
        }

        /* With while loop

         i = 1;
         while(i <= n) {
            window.console.log(i);
            document.getElementById('console').innerHTML += i + '<br>';
         i+= 1;
         }
        * */

    }
}