var data = function () {
    const LOCAL_STORAGE_GET_KEY = "";

    /* Users*/
    function register(user) {
        var promise = new Promise(function (resolve, reject) {
            var url = "api/users";

            var reqUser = {
              username: user.username,
                passHash: CryptoJS.SHA1(user.password).toString()
            };

            $.ajax(url, {
                method: "POST",
                contentType: "application/json",
                data: JSON.stringify(reqUser),
                success: function (res) {
                    resolve(res);
                }
            });
        });

        return promise;
    }

    function login(user) {
        var promise = new Promise(function (resolve, reject) {
            var url = "api/users/auth";

            var reqUser = {
                username: user.username,
                passHash: CryptoJS.SHA1(user.password).toString()
            };

            $.ajax(url, {
                method: "PUT",
                contentType: "application/json",
                data: JSON.stringify(reqUser),
                success: function (res) {
                    localStorage.setItem(LOCAL_STORAGE_GET_KEY, res.result.authKey);
                    resolve(res);
                }
            });
        });

        return promise;
    }

    /* TODOS */
    function todosGet() {
        var promise = new Promise(function (resolve, reject) {
            let url = "api/todos";

            $.ajax(url, {
                method: "GET",
                contentType: "application/json",
                headers: {
                    "x-auth-key": localStorage.getItem(LOCAL_STORAGE_GET_KEY)
                },
                success: function (res) {
                    resolve(res);
                },
                error: function (err) {
                    reject(err);
                }
            });
        });
        
        return promise;
    }

    function todosAdd(todo) {
        var promise = new Promise(function (resolve, reject) {
            let url = "api/todos";

            $.ajax(url, {
                method: "POST",
                data: JSON.stringify(todo),
                contentType: "application/json",
                headers: {
                    "x-auth-key": localStorage.getItem(LOCAL_STORAGE_GET_KEY)
                },
                success: function (res) {
                    resolve(res);
                },
                error: function (err) {
                    reject(err);
                }
            });
        });

        return promise;
    }
    
    return {
        users: {
            register: register,
            login: login
        },
        todos: {
            get: todosGet,
            add: todosAdd
        }
    };
}();