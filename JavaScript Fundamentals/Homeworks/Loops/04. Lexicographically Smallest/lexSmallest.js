function lexSmallest() {
    'use strict';

    var min = 'zzz',
        max = '',
        prop;

    for(prop in document) {
        if(prop > max) {
            max = prop;
        }

        if(prop < min) {
            min = prop;
        }
    }

    document.getElementById('console').innerHTML += 'Document - Min: ' + min + ' Max: ' + max + '<br>';
    window.console.log('Document - Min: ' + min + ' Max: ' + max);

    min = 'zzz';
    max = '';

    for(prop in window) {
        if(prop > max) {
            max = prop;
        }

        if(prop < min) {
            min = prop;
        }
    }

    document.getElementById('console').innerHTML += 'Window - Min: ' + min + ' Max: ' + max + '<br>';
    window.console.log('Window - Min: ' + min + ' Max: ' + max);

    min = 'zzz';
    max = '';

    for(prop in navigator) {
        if(prop > max) {
            max = prop;
        }

        if(prop < min) {
            min = prop;
        }
    }

    document.getElementById('console').innerHTML += 'Navigator - Min: ' + min + ' Max: ' + max + '<br>';
    window.console.log('Navigator - Min: ' + min + ' Max: ' + max);

}