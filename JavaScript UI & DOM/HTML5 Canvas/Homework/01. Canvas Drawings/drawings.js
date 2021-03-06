/* globals document */

function Draw() {
    var canvas = document.getElementById("the-canvas"),
        ctx = canvas.getContext("2d");
    // Funny head

    //Main head
    ctx.beginPath();
    ctx.fillStyle = "#90cad7";
    ctx.strokeStyle = "#22545F";
    ctx.lineWidth = 3;
    ctx.moveTo(100 + 75, 225);
    ctx.arc(100, 225, 75, 0, 2 * Math.PI);
    ctx.fill();
    ctx.closePath();
    ctx.stroke();

    // Nose
    ctx.beginPath();
    ctx.moveTo(95, 245);
    ctx.lineTo(75, 245);
    ctx.lineTo(95, 210);
    ctx.stroke();
    ctx.closePath();

    // Eyes
    // left
    ctx.fillStyle = "#22545F";
    ctx.beginPath();
    ctx.save();
    ctx.scale(1, 0.7); // 1.43 = 1 / 0.7
    ctx.moveTo(63 + 15, 203 * 1.43);
    ctx.arc(63, 203 * 1.43, 15, 0, 2 * Math.PI);
    ctx.restore();
    ctx.stroke();
    ctx.closePath();

    ctx.beginPath();
    ctx.save();
    ctx.scale(0.6, 1);
    ctx.moveTo(57 * 1.67 + 8, 204);
    ctx.arc(57 * 1.67, 204, 8, 0, 2 * Math.PI);
    ctx.restore();
    ctx.fill();
    ctx.closePath();

    // Right

    ctx.beginPath();
    ctx.save();
    ctx.scale(1, 0.7); // 1.43 = 1 / 0.7
    ctx.moveTo(126 + 15, 203 * 1.43);
    ctx.arc(126, 203 * 1.43, 15, 0, 2 * Math.PI);
    ctx.restore();
    ctx.stroke();
    ctx.closePath();

    ctx.beginPath();
    ctx.save();
    ctx.scale(0.6, 1);
    ctx.moveTo(120 * 1.67 + 8, 204);
    ctx.arc(120 * 1.67, 204, 8, 0, 2 * Math.PI);
    ctx.restore();
    ctx.fill();
    ctx.closePath();

    // Mouth

    ctx.beginPath();
    ctx.save();
    ctx.rotate(Math.PI / 18);
    ctx.scale(1, 0.4);
    ctx.moveTo(130 + 25, 252 * 2.5);
    ctx.arc(130, 252 * 2.5, 25, 0, 2 * Math.PI);
    ctx.restore();
    ctx.stroke();
    ctx.closePath();

    // Hat bottom,

    ctx.beginPath();
    ctx.save();
    ctx.scale(1, 1 / 5);
    ctx.moveTo(95 + 90, 160 * 5);
    ctx.arc(95, 160 * 5, 90, 0, 2 * Math.PI);
    ctx.restore();
    ctx.fillStyle = "#396693";
    ctx.strokeStyle = "#262626";
    ctx.fill();
    ctx.stroke();
    ctx.closePath();

    // Hat top

    ctx.beginPath();
    ctx.save();
    ctx.scale(1, 1 / 3);
    ctx.moveTo(49, 130);
    ctx.lineTo(49, 144);
    ctx.arc(99, 142 * 3, 50, Math.PI, -1 / 60, true);
    ctx.arc(99, 43 * 3, 50,2 * Math.PI, 0, true);
    ctx.fill();
    ctx.stroke();
    ctx.restore();


    // Bike
    // Starting from left to right

    ctx.fillStyle = "#90CAD7";
    ctx.strokeStyle = "#388091";
    ctx.beginPath();
    ctx.moveTo(330 + 50, 230);
    ctx.arc(330, 230, 50, 0, 2 * Math.PI); // Wheel left
    ctx.moveTo(560 + 50, 230);
    ctx.arc(560, 230, 50, 0, 2 * Math.PI); // Wheell right
    ctx.fill();
    ctx.stroke();
    ctx.moveTo(330, 230);
    ctx.lineTo(430, 230);
    ctx.moveTo(430 + 15, 230);
    ctx.arc(430, 230, 15, 0, 2 * Math.PI); // Chain
    ctx.moveTo(430, 230);
    ctx.lineTo(530, 175);
    ctx.lineTo(560, 230);
    ctx.lineTo(510, 138);
    ctx.lineTo(540, 115);
    ctx.moveTo(510, 138);
    ctx.lineTo(478, 152);
    ctx.moveTo(530, 175);
    ctx.lineTo(420, 175);
    ctx.lineTo(330, 230);
    ctx.moveTo(430, 230); // seat
    ctx.lineTo(400, 150);
    ctx.lineTo(420, 150);
    ctx.lineTo(380, 150);
    ctx.moveTo(418, 222); // Pedals
    ctx.lineTo(412, 217);
    ctx.moveTo(441, 242);
    ctx.lineTo(447, 247);
    ctx.stroke();

}