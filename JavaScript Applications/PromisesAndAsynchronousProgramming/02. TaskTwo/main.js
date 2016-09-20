/*jshint esversion: 6 */
(function () {
    "use strict";
    let redirectPromise = new Promise((resolve, reject) => {
        resolve($("#MainWindow").html("<div>Some text to popup you will be redirected in 2 second to scary website</div>"));
        alert("Click OK and you will see magic");
    });

    function redirectionPromise() {
        let redirectUrl = "http://www.lolcats.com/";

        return new Promise((resolve, reject) => {
            setTimeout(function () {
                resolve(window.location = redirectUrl);
            }, 2000);
        });
    }

    redirectPromise
        .then(redirectionPromise);
}());