/* globals document */

function onGetBouncingBall() {
    "use strict";

    var ctx = document.getElementById('theCanvas').getContext('2d'),
        totalWidth = ctx.canvas.width,
        totalHeight = ctx.canvas.height,
        movementByX = 'P',
        movementByY = 'P',
        positionX = totalWidth / 2,
        positionY = totalHeight / 2,
        radius = 20,
        speed = 2;

    function drawCircle() {
        ctx.beginPath();
        ctx.fillStyle = '#2A8EC2';
        ctx.moveTo(positionX, positionY);
        ctx.arc(positionX, positionY, radius, 0, 7);
        ctx.fill();
    }

    function updateDirections() {
        if (movementByX == 'P') {
            positionX += speed;
            if (positionX + radius > totalWidth) {
                movementByX = 'N';
                positionX -= 2 * speed;
            }
        }
        else if (movementByX == 'N') {
            positionX -= speed;
            if (positionX - radius < 0) {
                movementByX = 'P';
                positionX += 2 * speed;
            }
        }
        if (movementByY == 'P') {
            positionY += speed;
            if (positionY + radius > totalHeight) {
                movementByY = 'N';
                positionY -= 2 * speed;
            }
        }
        else if (movementByY == 'N') {
            positionY -= speed;
            if (positionY - radius < 0) {
                movementByY = 'P';
                positionY += 2 * speed;
            }
        }
    }

    function cMove() {
        ctx.clearRect(0, 0, totalWidth, totalHeight);
        updateDirections();
        drawCircle();
    }

    setInterval(cMove, 10);
    ctx.canvas.width = window.innerWidth;
    ctx.canvas.height = window.innerHeight;
}