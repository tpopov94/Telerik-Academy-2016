var eventsController = function () {

    function all(context) {
        let events;
        let category = context.params.category;
        if (category) {
            category = category.toLowerCase();
        }
        data.events.get()
            .then(function (resEvents) {
                events = resEvents.result;
                //console.log(events);
                return templates.get('events');
            })
            .then(function (template) {
                /* grouping => {category: [events]}*/
                let groups = _.chain(events)
                    .groupBy("category")
                    .map(function (events, categoryKey) {
                        return {
                            category: categoryKey,
                            events: events
                        };
                    })
                    .filter(function (group) {
                        return !category || group.category.toLowerCase() === category;
                    })
                    .value();

                context.$element().html(template(groups));
            });
    }

    function add(context) {
        templates.get("events-add")
            .then(function (template) {
                context.$element().html(template());

                $("#btn-add-event").on("click", function () {
                    let event = {
                        title: $("#tb-event-title").val(),
                        category: $("#tb-event-category").val(),
                        description: $("#tb-event-description").val(),
                        date: $("#tb-event-date").val() + " " + $("#tb-event-time").val()
                    };
                    data.events.add(event)
                        .then(function (event) {
                            event = event.result;
                            toastr.success(`event ${event.title} added`);
                            context.redirect("#/events");
                        });
                });
                // Autocomplete
                return data.categories.get();
            }).then(function (categories) {
            $("#tb-event-category").autocomplete({
                source: categories.result
            });

            // Time and date picker
            $("#tb-event-date").datepicker();
            $("#tb-event-time").timepicker({ "timeFormat": "H:i" });
        });
    }

    return {
        all: all,
        add: add
    };
}();