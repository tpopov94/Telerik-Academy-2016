let todosController = function () {

    function all(context) {
        let todos;
        let category = context.params.category;
        if(category){
            category = category.toLowerCase();
        }
        data.todos.get()
            .then(function (responseTodos) {
                todos = responseTodos.result;
                //console.log(todos);
                return templates.get('todos');
            })
            .then(function (template) {
                /* grouping => {category: [todos]}*/
                let groups = _.chain(todos)
                    .groupBy("category")
                    .map(function (todos, categoryKey) {
                        return {
                            category: categoryKey,
                            todos: todos
                        };
                    })
                    .filter(function (group) {
                        return !category || group.category.toLowerCase() === category;
                    })
                    .value();

                context.$element().html(template(groups));
                // making todos state to change when clicking chekbox
                $(".todo-state").on("change", function () {
                    let id = $(this).parents(".checkbox").attr("data-item");
                    let state = !!$(this).prop("checked");
                    data.todos.update(id, state)
                        .then(function () {
                            toastr.success("State changed");
                        });
                });
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
                            todo = todo.result;
                            toastr.success(`TODO ${todo.text} added`);
                            context.redirect("#/todos");
                        });
                });
                // Autocomplete
               return data.categories.get();
            }).then(function (categories) {
                $("#tb-todo-category").autocomplete({
                    source: categories.result
                });
        });
    }

    return {
        all: all,
        add: add
    };
}();