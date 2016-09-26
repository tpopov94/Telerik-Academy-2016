/* jshint esversion:6 */
/* globals console */

var data = (function () {
    const USERNAME_STORAGE_KEY = 'username-key';

    var serviceURL = "http://localhost:1509/api/threads";

    // start users
    function userLogin(user) {
        localStorage.setItem(USERNAME_STORAGE_KEY, user);
        return Promise.resolve(user);
    }

    function userLogout() {
        localStorage.removeItem(USERNAME_STORAGE_KEY)
        return Promise.resolve();
    }

    function userGetCurrent() {
        return Promise.resolve(localStorage.getItem(USERNAME_STORAGE_KEY));
    }

    // end users

    // start threads
    function threadsGet() {
        return new Promise((resolve, reject) => {
            $.getJSON("api/threads")
                .done(resolve)
                .fail(reject);
        });
    }

    function threadsAdd(title) {
        return new Promise((resolve, reject) => {
            let username = userGetCurrent(),
                data = {title, username};

            $.ajax({
                url: "api/threads",
                method: "POST",
                contentType: "application/json",
                data: JSON.stringify(data),
                success: function (data) {
                    resolve(data);
                },
                error: function (err) {
                    reject({
                        err: JSON.parse(err.status).err
                    });
                }
            });
        });
    }
       /* var promise = new Promise(function (resolve, reject) {
            $.ajax({
                url: serviceURL,
                method: "GET",
                "contentType": "application/json",
                data: JSON.stringify(data),
                success: function (data) {
                    resolve(data);
                },
                error: function (err) {
                    reject({
                        err: JSON.parse(err.status);
                });
                }
            });

        return promise;*/


    function threadById(id) {

    }

    function threadsAddMessage(threadId, content) {

    }

    // end threads

    // start gallery
    function galleryGet() {
        const REDDIT_URL = `https://www.reddit.com/r/aww.json?jsonp=?`;

    }

    // end gallery

    return {
        users: {
            login: userLogin,
            logout: userLogout,
            current: userGetCurrent
        },
        threads: {
            get: threadsGet,
            add: threadsAdd,
            getById: threadById,
            addMessage: threadsAddMessage
        },
        gallery: {
            get: galleryGet,
        }
    }
})();