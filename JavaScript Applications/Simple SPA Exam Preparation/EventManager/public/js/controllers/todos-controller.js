let todosController = function () {

    function all(context) {
        let todos;
        data.todos.get()
            .then(function (responseTodos) {
                todos = responseTodos.result;
                console.log(todos);
                return templates.get('todos');
            })
            .then(function (template) {
                context.$element().html(template(todos));
            });
    }

    function add(context) {
        templates.get("todos-add")
            .then(function (template) {
                context.$element().html(template());
                $("#btn-add-todo").on("click", function () {
                    let todo = {
                        text: $("#tb-todo-text").val(),
                        category: $("#tb-todo-category").val()
                    };

                    data.todos.add(todo)
                        .then(function (todo) {
                            toastr.success(`TODO ${todo.text} added`);
                            context.redirect("#/todos");
                        });
                });
            });
    }

    return {
        all: all,
        add: add
    };
}();