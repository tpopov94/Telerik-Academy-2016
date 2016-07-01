/* globals console */

function ReplaceTags() {
    "use strict";

    var stringToReplace = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>',
        replacedString = stringToReplace.replace(/<a href="/g, "[URL=")
            .replace(/<\/a>/g, "[/URL]")
            .replace(/">/g, "]"); // Using regex to replace all tags not just the most left one

    console.log(replacedString);
}

ReplaceTags();