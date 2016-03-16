function increaseArrayMembers() {
    'use strict';

    var arr = [],
        i;

    for(i = 0; i < 20; i+=1) {
        arr[i] = i * 5;
    }

    window.console.log(arr);
    document.getElementById('console').innerHTML += arr.join(' ') + '<br>';
}