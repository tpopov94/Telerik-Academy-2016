function MaximalIncreasingSequence(args) {
    'use strict';

    var array = args[0].split('\n'),
        n = +array[0],
        arrayOfNumbers = array.Slice(1),
        //arrayOfNumbers = ['8', '7', '3', '2', '3', '4', '2', '2', '4'],
        currentBestSequence = 1,
        bestSequence = 0,
        i;


    for (i = 1; i < n; i += 1) {
        if (+arrayOfNumbers[i - 1] < +arrayOfNumbers[i]) {
            currentBestSequence += 1;
        }
        else {
            if (currentBestSequence > bestSequence) {
                bestSequence = currentBestSequence;
            }
            currentBestSequence = 1;
        }
    }

    console.log(bestSequence);
}


MaximalIncreasingSequence('8', '7', '3', '2', '3', '4', '2', '2', '4');