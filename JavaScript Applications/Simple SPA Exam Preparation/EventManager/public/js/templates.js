var templates = (function () {
    var handlebars = window.handlebars || window.Handlebars;

    function get(name) {
        var promise = new Promise(function (resolve, reject) {
            let url = `./templates/${name}.handlebars`;
            $.get(url, function (html) {
                var template = handlebars.compile(html);
                resolve(template);
            });
        });

        return promise;
    }
    
    return {
        get: get
    }
}());