/*jshint esversion: 6 */

function solve() {
    "use strict";

    var module = (function () {
        var playable,
            validator,
            audio,
            video,
            playlist;

        validator = {
            validateString: function (val, name) {
                name = name || "value";

                if (val === undefined) {
                    throw name + "String cannot be undefined";
                }

                if (typeof val !== "string") {
                    throw new Error(name + " must be a string");
                }

                if (val.length < 3 || val.length > 25) {
                    throw new Error(name + " must be between ");
                }
            },
            validatePositiveNumber: function (val, name) {
                name = name || "value";

                if (val === undefined) {
                    throw name + " cannot be undefined";
                }

                if (typeof val !== "number") {
                    throw new Error(name + " must be a number");
                }

                if (val <= 0) {
                    throw name + " cannot be negative";
                }
            },
            validateImdbRating: function (val, name) {
                name = name || "value";

                if (val === undefined) {
                    throw name + " cannot be undefined";
                }

                if (typeof val !== "number") {
                    throw new Error(name + " must be a number");
                }

                if (val < 1 || val > 5) {
                    throw name + " must be between 1 and 5";
                }
            },
            validateIfObject: function (val, name) {
                name = name || "Value";

                if(typeof val !== "object") {
                    throw new Error(name + " must be an object");
                }
            }
        };

        playlist = (function () {
            var playlist = Object.create({}),
                currentPlaylistId = 0;

            Object.defineProperty(playlist, "init", {
                value: function (name) {
                    this.name = name;
                    this._id = ++currentPlaylistId;
                    return this;
                }
            });

            Object.defineProperty(playlist, "name", {
                get: function () {
                    return this._name;
                },
                set: function (name) {
                    validator.validateString(val);
                    this._name = val;
                }
            });

            Object.defineProperty(playlist, "addPlayable", {
                value: function (playable) {
                    validator.validateIfObject(playable);
                }
            });

            return playlist;
        }());

        playable = (function () {
            var playable = Object.create({}),
                currentPlayableId = 0;

            //Old style constructor
            Object.defineProperty(playable, "init", {
                value: function (title, author) {
                    this.title = title;
                    this.author = author;
                    this._id = ++currentPlayableId;
                    return this;
                }
            });

            Object.defineProperty(playable, "id", {
                get: function () {
                    return this._id;
                }
            });

            Object.defineProperty(playable, "title", {
                get: function () {
                    return this._title;
                },
                set: function (val) {
                    validator.validateString(val, "Title");
                    this._title = val;
                }
            });

            Object.defineProperty(playable, "author", {
                get: function () {
                    return this._author;
                },
                set: function (val) {
                    validator.validateString(val, "Author");
                    this._author = val;
                }
            });

            Object.defineProperty(playable, "play", {
                value: function () {
                    return `${this.id}. ${this.title} - ${this.author};`
                }
            });

            return playable;
        }());

        audio = (function (parent) {
            var audio = Object.create(parent);

            Object.defineProperty(audio, "init", {
                value: function (title, author, length) {
                    parent.init.call(this, title, author);
                    this.length = length;
                    return this;
                }
            });


            Object.defineProperty(audio, "length", {
                get: function () {
                    return this._length;
                },
                set: function (val) {
                    validator.validatePositiveNumber(val);
                    this._length = val;
                }
            });

            Object.defineProperty(audio, "play", {
                value: function () {
                    return parent.play.call(this) + ` - ${this.length}`;
                }
            });
            return audio;
        }(playable));

        video = (function (parent) {
            var video = Object.create(parent);

            Object.defineProperty(video, "init", {
                value: function (title, author, imdbRating) {
                    parent.init.call(this, title, author);
                    this.imdbRating = imdbRating;
                    return this;
                }
            });

            Object.defineProperty(video, "imdbRating", {
                get: function () {
                    return this._imdbRating;
                },
                set: function (val) {
                    validator.validateImdbRating(val);
                    this._imdbRating = val;
                }
            });

            Object.defineProperty(video, "play", {
                value: function () {
                    return parent.play.call(this) + ` - ${this.imdbRating}`;
                }
            });
            return video;
        }(playable));

        return {
            getPlayer: function (name) {
                // returns a new player instance with the provided name
            },
            getPlaylist: function (name) {
                //returns a new playlist instance with the provided name
            },
            getAudio: function (title, author, length) {
                return Object.create(audio).init(title, author, length);
            },
            getVideo: function (title, author, imdbRating) {
                return Object.create(video).init(title, author, imdbRating);
            }
        };
    }());

    return module;
}

var module = solve();
var audio = module.getAudio("Audio", "Mitko", 342);
var audio2 = module.getVideo("Video", "Qze", 2);

console.log(audio.play());
console.log(audio2.play());