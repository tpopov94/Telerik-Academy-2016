function quadraticEquation() {
    'use strict';

    var a = +document.getElementById('inputFormOne').value,
        b = +document.getElementById('inputFormTwo').value,
        c = +document.getElementById('inputFormThree').value,
        discriminant,
        rootOne,
        rootTwo;

    if(isNaN(a) || isNaN(b) || isNaN(c)) {
        window.console.log('Please enter only numbers !');
        document.getElementById('console').innerHTML += 'Please enter only numbers !' + '<br>';
    }

    else {
        discriminant = (b * b) - (4 * a * c);

        if(discriminant < 0) {
            window.console.log('No real roots !');
            document.getElementById('console').innerHTML += 'No real roots !' + '<br>';
        }

        if(discriminant === 0) {
            rootOne = -(b / (2 * a));
            window.console.log('x1 = x2 = ' + rootOne);
            document.getElementById('console').innerHTML += 'x1 = x2 = ' + rootOne + '<br>';
        }

        if(discriminant > 0) {
            rootOne = (-b + Math.sqrt(discriminant)) / (2 * a);
            rootTwo = (-b - Math.sqrt(discriminant)) / (2 * a);

            window.console.log('x1 = ' + rootOne + ' x2 = ' + rootTwo);
            document.getElementById('console').innerHTML += 'x1 = ' + rootOne + ' x2 = ' + rootTwo + '<br>';
        }
    }
}