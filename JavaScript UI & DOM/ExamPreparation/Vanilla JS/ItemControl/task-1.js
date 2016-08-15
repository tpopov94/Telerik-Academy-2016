function solve() {
    return function (selector, isCaseSensitive) {

        var root = document.querySelector(selector);
        var fragment = document.createDocumentFragment();
        var caseSensitive = isCaseSensitive;

        if (typeof root === "string") {
            root = document.querySelector(root);
        }

        //1. Adding Elements
        var addElements = document.createElement('div');
        addElements.className = "add-controls";
        var labelElement = document.createElement('label');
        labelElement.innerText = "Enter text";
        var inputForm = document.createElement('input');

        labelElement.appendChild(inputForm);
        var btn = document.createElement('a');
        btn.className = "button";
        btn.innerText = "Add";
        btn.addEventListener('click', function (ev) {
            var value = inputForm.value;
            inputForm.value = "";

            textListItem.innerText = value;

            resultsList.appendChild(listTemplate.cloneNode(true));
        }, false);
        btn.style.display = "inline-block";

        addElements.appendChild(labelElement);
        addElements.appendChild(btn);

       // 2.Search
        var searchElements = document.createElement('div');
        searchElements.className = "search-controls";
        var searchLabel = document.createElement('label');
        searchLabel.innerText = "Search:";
        var searchForm = document.createElement('input');
        searchForm.addEventListener("input", function () {
            var i,
                len,
                text,
                pattern = inputForm.value;
            if (!isCaseSensitive) {
                pattern = pattern.toLowerCase();
            }

            for (i = 0, len = listItems.length; i < len; i += 1) {
                text = listItems[i].getElementsByTagName("strong")[0].innerHTML;
                if (!isCaseSensitive) {
                    text = text.toLowerCase();
                }

                if (text.indexOf(pattern) < 0) {
                    listItems[i].style.display = "none";
                } else {
                    listItems[i].style.display = "";
                }
            }
        }, false);
        searchLabel.appendChild(searchForm);

        searchElements.appendChild(searchLabel);

        // 3.Result
        var resultsElements = document.createElement('div');
        resultsElements.className = "result-controls";
        var resultsList = document.createElement('ul');
        resultsList.className = "items-list";
        var listTemplate = document.createElement('li');
        listTemplate.className = "list-item";
        var textListItem = document.createElement("strong");
        var resultButton = document.createElement('a');
        resultButton.className = "button button-delete";
        resultButton.innerText = "X";
        resultButton.addEventListener("click", function (ev) {
            var btn = ev.target,
                parent;
            if (btn.className.indexOf("button-delete") < 0) {
                return;
            }

            parent = btn;
            while (parent && parent.className.indexOf("list-item") < 0) {
                window.console.log(parent.nodeName);
                parent = parent.parentNode;
            }

            if (!parent) {
                return;
            }

            resultsList.removeChild(parent);

        }, false);

        listTemplate.appendChild(resultButton);
        listTemplate.appendChild(textListItem);
       // resultsList.appendChild(listTemplate);
        resultsElements.appendChild(resultsList);
        var listItems = root.getElementsByClassName("list-item");

        // Adding to fragment
        fragment.appendChild(addElements);
        fragment.appendChild(searchElements);
        fragment.appendChild(resultsElements);

        root.appendChild(fragment);
        root.className = "items-control";
    };
}

module.exports = solve;