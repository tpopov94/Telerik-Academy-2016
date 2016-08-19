function checkIfMozilla(event, arguments) {
    var myWindow = window,
        browser = myWindow.navigator.appCodeName,
        isMozilla = (browser === "Mozilla");

    if (isMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}