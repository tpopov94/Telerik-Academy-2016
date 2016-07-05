/* globals console */
function solve(params) {
    "use strict";
    var s = params[0].split(' ').map(Number),
        currentBestSum = 0,
        bestSum = 0,
        len = s.length,
        flagUp = false,
        flagDown = true;

   /* for (let i = 0; i < len; i += 1) {
        if (currentBestSum > bestSum) {
            bestSum = currentBestSum
        }

        if (flagDown) {
            if (input[i] > input[i + 1]) {
                currentBestSum += input[i + 1];
            }
            else {
                flagUp = true;
                flagDown = false;
            }
        }
        if (flagUp) {
            if (input[i] < input[i + 1]) {
                currentBestSum += input[i + 1];
            }
            else {
                flagUp = false;
                flagDown = true;
            }
        }
            }*/

    for (let i = 0; i < len; i += 1) {
        for (let j = i; j < len; j += 1) {
            if (s[j] > s[j + 1]) {
                currentBestSum += s[j];
            } else if (s[j] < s[j + 1]) {
                currentBestSum += s[j];
                if (s[j + 1] < s[j + 2])
                    continue;
                else {
                    currentBestSum += s[j + 1];
                    break;
                }
            }
        }
        if (currentBestSum > bestSum)
            bestSum = currentBestSum;
        currentBestSum = 0;
    }
    console.log(bestSum);
}

solve(["5 1 7 4 8"]);
console.log(19);
solve(["5 1 7 6 5 6 4 2 3 8"]);
console.log(24);