/*jshint esversion: 6 */

function solve() {
    let itemUniqueId = 0,
        catalogId = 0,
        CONSTANTS = {
            NAME_MIN_LENGTH: 2,
            NAME_MAX_LENGTH: 40,
            ISBN_10SYMBOLS: 10,
            ISBN_13SYMBOLS: 13,
            GENRE_MIN_LENGTH: 2,
            GENRE_MAX_LENGTH: 20
        };

    class Validation {
        constructor() {
        }

        static valideteIfUndefined(value) {
            if (value === undefined) {
                throw new Error("Cannot be undefined");
            }
        }

        static validateDescription(value, name) {
            name = name || "Value";

            if (value.length === 0) {
                throw new Error(`${name} cannot be empty`);
            }
        }

        static  validateName(value, name) {
            name = name || "Value";

            if (value.length < CONSTANTS.NAME_MIN_LENGTH || value.length > CONSTANTS.NAME_MAX_LENGTH) {
                throw new Error(`${name} must be between 2 and 40 symbols`);
            }

        }

        static  validateIsbn(value, name) {
            name = name || "Value";
            let isValidIsbn = value.length === CONSTANTS.ISBN_10SYMBOLS || value.length === CONSTANTS.ISBN_13SYMBOLS;

            if (typeof +value !== "number") {
                throw new Error(`${name} must contain only digits`);
            }

            if (!isValidIsbn) {
                throw new Error(`${name} must contain exactly 10 or 13 digits`);
            }
        }

        static validateGenre(value, name) {
            name = name || "Value";

            if (value.length < CONSTANTS.GENRE_MIN_LENGTH || value.length > CONSTANTS.GENRE_MAX_LENGTH) {
                throw new Error(`${name} must contain between 2 or 20 symbols`);
            }
        }

        static validateMediaDuration(value, name) {
            name = name || "Value";

            if (typeof value !== "number") {
                throw new Error(`${name} must be a digit`);
            }

            if (value < 1) {
                throw new Error(`${name} must be longer than 0`);
            }
        }

        static validateMediaRating(value, name) {
            name = name || "Value";

            if (typeof value !== "number") {
                throw new Error(`${name} must be a digit`);
            }

            if (value < 1 || value > 5) {
                throw new Error(`${name} must be between 1 and 5`);
            }
        }
    }

    class Item {
        constructor(name, desdription) {
            this.name = name;
            this.description = desdription;
            this._id = ++itemUniqueId;
        }


        get id() {
            return this._id;
        }

        get name() {
            return this._name;
        }

        set name(val) {
            Validation.valideteIfUndefined(val);
            Validation.validateName(val, "Name");
            this._name = val;
        }

        get description() {
            return this._description;
        }

        set description(val) {
            Validation.valideteIfUndefined(val);
            Validation.validateDescription(val, "Description");
            this._description = val;
        }

        play() {
            return `${this.name}`;
        }
    }

    class Book extends Item {
        constructor(name, isbn, genre, description) {
            super(name, description);

            this.isbn = isbn;
            this.genre = genre;
        }

        get isbn() {
            return this._isbn;
        }

        set isbn(val) {
            Validation.valideteIfUndefined(val);
            Validation.validateIsbn(val, "ISBN");
            this._isbn = val;
        }

        get genre() {
            return this._genre;
        }

        set genre(val) {
            Validation.valideteIfUndefined(val);
            Validation.validateGenre(val, "Genre");
            this._genre = val;
        }
    }

    class Media extends Item {
        constructor(name, rating, duration, description) {
            super(name, description);

            this.rating = rating;
            this.duration = duration;
        }

        get rating() {
            return this._rating;
        }

        set rating(val) {
            Validation.valideteIfUndefined(val);
            Validation.validateMediaRating(val, "Rating");
            this._rating = val;
        }

        get duration() {
            return this._duration;
        }

        set duration(val) {
            Validation.valideteIfUndefined(val);
            Validation.validateMediaDuration(val, "Duration");
            this._duration = val;
        }
    }

    class Catalog {
        constructor(name) {
            this.name = name;
            this._items = [];
            this._id = ++catalogId;
        }
    }

    return {
        getBook: function (name, isbn, genre, description) {
            return new Book(name, isbn, genre, description);
        },
        getMedia: function (name, rating, duration, description) {
            return new Media(name, rating, duration, description);
        },
        getBookCatalog: function (name) {
            //return a book catalog instance
        },
        getMediaCatalog: function (name) {
            //return a media catalog instance
        },
    };
}

module.exports = solve;

/*var module = solve();

console.log(module.getBook("Harry Potter", "1234567890", "fantssy", "Garry"));
console.log(module.getMedia("Ceca", 3, 312, "Pile"));

*/