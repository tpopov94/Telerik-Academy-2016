function MaximalSequence(args) {
    'use strict';

    //var arrayOfNumbers = args[0].split('\n'),
    var arrayOfNumbers = ['10', '2', '1', '1', '2', '3', '3', '2', '2', '2', '1'],
        i,
        currentBest = 1,
        bestSequence = 1;

    for (i = 0; i < arrayOfNumbers.length - 1; i += 1) {

        if (arrayOfNumbers[i] === arrayOfNumbers[i + 1]) {
            currentBest += 1;
        }
        else {
            if (currentBest > bestSequence) {
                bestSequence = currentBest;
            }
            currentBest = 1;
        }


    }

    console.log(bestSequence);
}

MaximalSequence(5);