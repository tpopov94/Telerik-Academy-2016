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

        static validateIfArray(value) {
            /*if(!Array.isArray(value)) {
                throw new Error("You must add an array");
            }
*/
            if(value.length === 0) {
                throw new Error("Array cannot be empty");
            }
        }

        static  validateIsbn(value, name) {
            name = name || "Value";
            let isValidIsbn = value.length === CONSTANTS.ISBN_10SYMBOLS || value.length === CONSTANTS.ISBN_13SYMBOLS;

            if (Number.isNaN(+value)) {
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

        get id() {
            return this._id;
        }

        get name() {
            return this._name;
        }

        set name(val) {
            Validation.valideteIfUndefined(val);
            Validation.validateName(val, "Catalog name");
            this._name = val;
        }

        get items() {
            return this._items;
        }

        add(...items){
            Validation.valideteIfUndefined(items);
            Validation.validateIfArray(...items);

            if(Array.isArray(items[0])) {
                items = items[0];
            }

            this.items.push(...items);

            return this;
        }

        find(x) {
            if(typeof x === "number") {
                for(let item of this.items) {
                    if(item.id === x) {
                        return item;
                    }
                }

                // If no id is found;
                return null;
            }

            if(x !== null && typeof x === "object") {
                return this.items.filter(function(item) {
                    return Object.keys(x).every(function(prop) {
                        return x[prop] === item[prop];
                    });
                });
            }

            // If no valid search parameters are passed
            throw new Error(`${x} is not a valid search parameter`);
        }

        search(pattern) {
            let filteredCatalog = [];

            pattern = pattern.toUpperCase();

            for (let item of this.items) {
                let containsInName = item.name.contains(pattern),
                    containsInDescription = item.description.contains(pattern);

                if(containsInDescription || containsInName) {
                    filteredCatalog.push(item);
                }
            }

            return filteredCatalog;
        }
    }

    class BookCatalog extends Catalog {
        constructor(name){
            super(name);
        }

        add(...books) {
            if(Array.isArray(books[0])) {
                books = books[0];
            }

            books.forEach(function(x) {
                if(!(x instanceof BookCatalog)) {
                    throw new Error("Must add only books!");
                }
            });

            return super.add(...books);
        }

        getGenres() {
            let genres = new Set();

            for(var item of this.items){
                genres.add(item.genre.toLowerCase());
            }

            return genres;
        }

        find(x){
            return super.find(x);
        }
    }

    class MediaCatalog extends Catalog {
        constructor(name) {
            super(name);
        }

        add(...media) {
            if(Array.isArray(media[0])) {
                media = media[0];
            }

            media.forEach(function(x) {
                if(!(x instanceof Media)) {
                    throw "Must add only media";
                }
            });

            return super.add(...media);
        }

        getTop(count) {
            if(typeof count !== "number") {
                throw "Count should be a number";
            }
            if(count < 1) {
                throw "Count must be more than 1";
            }

            return this.items
                .sort((a, b) => a.rating < b.rating)
                .filter((_, ind) => ind < count)
                .map(x => ({id: x.id, name: x.name}));
        }

        getSortedByDuration() {
            return this.items
                .sort((a, b) => {
                    if(a.duration === b.duration) {
                        return a.id < b.id;
                    }

                    return a.duration > b.duration;
                });
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
            return new BookCatalog(name);
        },
        getMediaCatalog: function (name) {
            return new MediaCatalog(name);
        },
    };
}

module.exports = solve;

/*var module = solve();

console.log(module.getBook("Harry Potter", "1234567890", "fantssy", "Garry"));
console.log(module.getMedia("Hisarskiq Pop", 3, 312, "Dai si surceto"));
*/
