/* globals console */

function solve(args) {
    "use strict";

    var rowsAndColsInput = args[0].split(' '),
        debrisLocation = args[1].split(';'),
        moves = +args[2],
        commandsArray = args.slice(3),
        cukiTanks = 4,
        kocetoTanks = 4,
        rows = +rowsAndColsInput[0],
        cols = +rowsAndColsInput[1],
        board = createArray(rows, cols);

//tanks
    var tank0 = {
            id: 0,
            currentRow: 0,
            currentCol: 0
        },
        tank1 = {
            id: 1,
            currentRow: 0,
            currentCol: 1
        },
        tank2 = {
            id: 2,
            currentRow: 0,
            currentCol: 2
        },
        tank3 = {
            id: 3,
            currentRow: 0,
            currentCol: 3
        },
        tank4 = {
            id: 4,
            currentRow: rows - 1,
            currentCol: cols - 1
        },
        tank5 = {
            id: 5,
            currentRow: rows - 1,
            currentCol: cols - 2
        },
        tank6 = {
            id: 6,
            currentRow: rows - 1,
            currentCol: cols - 3
        },
        tank7 = {
            id: 7,
            currentRow: rows - 1,
            currentCol: cols - 4
        };

    for (let row = 0; row < rows; row += 1) {
        for (let col = 0; col < cols; col += 1) {
            board[row][col] = true;
        }
    }

    // putting debries
    for (let i = 0; i < debrisLocation.length; i++) {
        let currentDebryRow = +debrisLocation[i][0];
        let currentDebryCol = +debrisLocation[i][2];

        board[currentDebryRow][currentDebryCol] = 'x';
    }

    board[0][0] = tank0;
    board[0][1] = tank1;
    board[0][2] = tank2;
    board[0][3] = tank3;
    // Cuki tanks
    board[rows - 1][cols - 1] = tank4;
    board[rows - 1][cols - 2] = tank5;
    board[rows - 1][cols - 3] = tank6;
    board[rows - 1][cols - 4] = tank7;

    //console.log(board);
    for (let i = 0; i < moves; i++) {
        let curCommands = commandsArray[i].split(" "),
            curCommand = curCommands[0],
            idOfTank,
            direction,
            numberOfMoves;

        if (curCommand === "mv") {
            idOfTank = curCommands[1];
            numberOfMoves = curCommands[2];
            direction = curCommands[3];
        }
        else if (curCommand === "x") {
            idOfTank = curCommands[1];
            direction = curCommands[2];
        }

        // magic

        if (curCommand === "mv") {
            Move(board, direction, numberOfMoves, ChooseTank(idOfTank));
        }

        if (curCommand === "x") {
            Shoot(board, direction, ChooseTank(idOfTank));
        }

        if (cukiTanks === 0) {
            console.log("Cuki is gg");
            break;
        }
        if (kocetoTanks === 0) {
            console.log("Koceto is gg");
            break;
        }

        //console.log(board);
        //console.log("------------------------");
    }

    function Move(board, direction, numberOfMoves, tank) {

        if (direction === "l") {
            for (let i = 0; i < numberOfMoves; i += 1) {
                //board[tank.currentRow][tank.currentCol] = true;
                if (tank.currentCol === 0) {
                    board[tank.currentRow][tank.currentCol] = tank;
                    break;
                }
                else {
                    if (board[tank.currentRow][tank.currentCol - 1] !== true) {
                        break;
                    }
                    else {
                        board[tank.currentRow][tank.currentCol] = true;
                        tank.currentCol -= 1;
                        board[tank.currentRow][tank.currentCol] = tank;
                    }
                }
            }
        }

        if (direction === "d") {
            for (let i = 0; i < numberOfMoves; i += 1) {
                if (tank.currentRow === rows - 1) {
                    board[tank.currentRow][tank.currentCol] = tank;
                    break;
                }
                else {
                    if (board[tank.currentRow + 1][tank.currentCol] !== true) {
                        break;
                    }
                    else {
                        board[tank.currentRow][tank.currentCol] = true;
                        tank.currentRow += 1;
                        board[tank.currentRow][tank.currentCol] = tank;
                    }
                }
            }
        }

        if (direction === "r") {
            for (let i = 0; i < numberOfMoves; i += 1) {
                if (tank.currentCol === cols - 1) {
                    board[tank.currentRow][tank.currentCol] = tank;
                    break;
                }
                else {
                    if (board[tank.currentRow][tank.currentCol + 1] !== true) {
                        break;
                    }
                    else {
                        board[tank.currentRow][tank.currentCol] = true;
                        tank.currentCol += 1;
                        board[tank.currentRow][tank.currentCol] = tank;
                    }
                }
            }
        }

        if (direction === "u") {
            for (let i = 0; i < numberOfMoves; i += 1) {
                if (tank.currentRow === 0) {
                    board[tank.currentRow][tank.currentCol] = tank;
                    break;
                }
                else {
                    if (board[tank.currentRow - 1][tank.currentCol] !== true) {
                        break;
                    }
                    else {
                        board[tank.currentRow][tank.currentCol] = true;
                        tank.currentRow -= 1;
                        board[tank.currentRow][tank.currentCol] = tank;
                    }
                }
            }
        }
    }

    function createArray(length) {
        var arr = new Array(length || 0),
            i = length;

        if (arguments.length > 1) {
            var args = Array.prototype.slice.call(arguments, 1);
            while (i--) {
                arr[length - 1 - i] = createArray.apply(this, args);
            }
        }

        return arr;

    }

    function ChooseTank(tank) {
        if (+tank === 7) {
            return tank7;
        }

        if (+tank === 0) {
            return tank0;
        }

        if (+tank === 1) {
            return tank1;
        }

        if (+tank === 2) {
            return tank2;
        }

        if (+tank === 3) {
            return tank3;
        }

        if (+tank === 4) {
            return tank4;
        }

        if (+tank === 5) {
            return tank5;
        }

        if (+tank === 6) {
            return tank6;
        }
    }

    function Shoot(board, direction, tank) {
        let startRow = tank.currentRow,
            startCol = tank.currentCol;

        if (direction === "l") {

            startCol -= 1;
            while (startCol >= 0) {
                if (board[startRow][startCol] === "x") {
                    board[startRow][startCol] = true;
                    break;
                }
                if (board[startRow][startCol] !== true && board[startRow][startCol] !== "x") {
                    AttackedTankLocation(board, startRow, startCol);
                    break;
                }
                startCol -= 1;
            }
        }

        if (direction === "r") {

            startCol += 1;
            while (startCol < cols) {
                if (board[startRow][startCol] === "x") {
                    board[startRow][startCol] = true;
                    break;
                }
                if (board[startRow][startCol] !== true && board[startRow][startCol] !== "x") {
                    AttackedTankLocation(board, startRow, startCol);
                    break;
                }

                startCol += 1;
            }
        }

        if (direction === "d") {

            startRow += 1;
            while (startRow < rows) {
                if (board[startRow][startCol] === "x") {
                    board[startRow][startCol] = true;
                    break;
                }
                if (board[startRow][startCol] !== true && board[startRow][startCol] !== "x") {
                    AttackedTankLocation(board, startRow, startCol);
                    break;
                }
                startRow += 1;
            }
        }

        if (direction === "u") {

            startRow -= 1;
            while (startRow > -1) {
                if (board[startRow][startCol] === "x") {
                    board[startRow][startCol] = true;
                    break;
                }
                if (board[startRow][startCol] !== true && board[startRow][startCol] !== "x") {
                    AttackedTankLocation(board, startRow, startCol);
                    break;
                }
                startRow -= 1;
            }
        }
    }

    function AttackedTankLocation(board, row, col) {
        if (board[row][col] === tank7) {
            console.log("Tank 7 is gg");
            board[row][col] = true;
            cukiTanks -= 1;
        }
        if (board[row][col] === tank0) {
            console.log("Tank 0 is gg");
            kocetoTanks -= 1;
            board[row][col] = true;
        }
        if (board[row][col] === tank1) {
            console.log("Tank 1 is gg");
            board[row][col] = true;
            kocetoTanks -= 1;
        }
        if (board[row][col] === tank2) {
            console.log("Tank 2 is gg");
            board[row][col] = true;
            kocetoTanks -= 1;
        }
        if (board[row][col] === tank3) {
            console.log("Tank 3 is gg");
            board[row][col] = true;
            kocetoTanks -= 1;
        }
        if (board[row][col] === tank4) {
            console.log("Tank 4 is gg");
            board[row][col] = true;
            cukiTanks -= 1;
        }
        if (board[row][col] === tank5) {
            console.log("Tank 5 is gg");
            board[row][col] = true;
            cukiTanks -= 1;
        }
        if (board[row][col] === tank6) {
            console.log("Tank 6 is gg");
            board[row][col] = true;
            cukiTanks -= 1;
        }
    }
}

/*solve([
 '5 5',
 '2 1;2 2;2 3;2 4',
 '4',
 'mv 4 1 u',
 'mv 4 4 l',
 'x 4 u',
 'mv 4 2 r'
 ]);
 */
/*solve([
 '5 5',
 '2 0;2 1;2 2;2 3;2 4',
 '13',
 'mv 7 2 l',
 'x 7 u',
 'x 0 d',
 'x 6 u',
 'x 5 u',
 'x 2 d',
 'x 3 d',
 'mv 4 1 u',
 'mv 4 4 l',
 'mv 1 1 l',
 'x 4 u',
 'mv 4 2 r',
 'x 2 d'
 ]);
 */

solve(['10 10',
    '1 0;1 1;1 2;1 3;1 4;4 1;4 2;4 3;4 4',
    '8',
    'mv 4 9 u',
    'x 4 l',
    'x 4 l',
    'x 4 l',
    'x 0 r',
    'mv 0 9 r',
    'mv 5 1 r',
    'x 5 u']);

/*solve([
 '10 5',
 '1 0;1 1;1 2;1 3;1 4;3 1;3 3;4 0;4 2;4 4',
 '43',
 'mv 6 5 r',
 'mv 0 6 d',
 'x 0 d',
 'x 0 d',
 'x 6 u',
 'x 6 u',
 'x 6 u',
 'x 6 u',
 'x 6 u',
 'x 7 u',
 'x 7 u',
 'x 7 u',
 'x 7 u',
 'x 7 u',
 'x 3 d',
 'x 3 d',
 'x 3 d',
 'x 3 d',
 'x 3 d',
 'x 4 u',
 'x 4 u',
 'x 4 u',
 'x 4 u',
 'x 4 u',
 'x 0 r',
 'mv 0 6 d',
 'mv 0 9 r',
 'x 0 d',
 'mv 0 1 l',
 'x 0 d',
 'mv 0 1 l',
 'x 0 d',
 'mv 0 1 l',
 'x 0 d',
 'mv 0 1 l',
 'x 0 d',
 'mv 0 1 l',
 'x 0 d',
 'mv 0 1 l',
 'x 0 d',
 'mv 0 1 l',
 'x 0 d',
 'mv 0 1 l',
 'x 0 d'
 ]);*/