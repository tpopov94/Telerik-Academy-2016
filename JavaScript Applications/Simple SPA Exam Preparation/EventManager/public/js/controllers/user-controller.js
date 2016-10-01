let userController = function () {

    function login(context) {
        templates.get("home")
            .then(function (template) {
                context.$element().html(template());
            });
    }

    function register(context) {
        templates.get("register")
            .then(function (template) {
                context.$element().html(template());

                $("#btn-register").on("click", function () {
                    var user = {
                        username: $("#tb-username").val(),
                        password: $("#tb-password").val()
                    };
                    data.users.register(user)
                        .then(function () {
                            console.log("User register");
                        });
                });

                $("#btn-login").on("click", function () {
                    var user = {
                        username: $("#tb-username").val(),
                        password: $("#tb-password").val()
                    };
                    data.users.login(user)
                        .then(function () {
                            // redirect to home page when login successful
                            toastr.success("User logged in");
                           context.redirect("#/");
                        });
                });
            });
    }

    return {
        register: register,
        login: login
    };
}();