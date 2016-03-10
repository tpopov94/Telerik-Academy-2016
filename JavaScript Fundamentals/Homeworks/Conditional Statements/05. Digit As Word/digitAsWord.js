function digitAsWord() {
    'use strict';

    var input = +document.getElementById('inputForm').value;

    switch (input) {

        case 0: window.console.log('Zero');
            document.getElementById('console').innerHTML += 'Zero' + '<br>';
            break;
        case 1:
            window.console.log('One');
            document.getElementById('console').innerHTML += 'One' + '<br>';
            break;
        case 2:
            window.console.log('Two');
            document.getElementById('console').innerHTML += 'Two' + '<br>';
            break;
        case 3:
            window.console.log('Three');
            document.getElementById('console').innerHTML += 'Three' + '<br>';
            break;
        case 4:
            window.console.log('Four');
            document.getElementById('console').innerHTML += 'Four' + '<br>';
            break;
        case 5:
            window.console.log('Five');
            document.getElementById('console').innerHTML += 'Five' + '<br>';
            break;
        case 6:
            window.console.log('Six');
            document.getElementById('console').innerHTML += 'Six' + '<br>';
            break;
        case 7:
            window.console.log('Seven');
            document.getElementById('console').innerHTML += 'Seven' + '<br>';
            break;
        case 8:
            window.console.log('Eight');
            document.getElementById('console').innerHTML += 'Eight' + '<br>';
            break;
        case 9:
            window.console.log('Nine');
            document.getElementById('console').innerHTML += 'Nine' + '<br>';
            break;
        default:
            window.console.log('Not a digit');
            document.getElementById('console').innerHTML += 'Not a digit' + '<br>';
    }
}