(function () {
    var sammy = Sammy("#content", function () {
        // creating routes with sammy

        this.get("#/", function () {
           this.redirect("#/home");
        });

        this.get("#/home", homeController.all);

        this.get("#/login", userController.login);

        this.get("#/register", userController.register);

        this.get("#/todos", todosController.all);

        this.get("#/todos/add", todosController.add);

        //this.get("#/events", eventsController.all);
    });


    $(function () {
        sammy.run("#/");
    });
}());