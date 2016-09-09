/*jshint esversion: 6 */

function solve() {
    let uniqueId = 0,
        playerId = 0,
        playlistId = 0;
    const CONSTANTS = {
        MIN_STRING_LENGTH: 3,
        MAX_STRING_LENGTH: 25
    };

    class Validation {

        static validateIfUndefined(val, name) {
            name = name || "Value";

            if (val === undefined) {
                throw new Error(`${name} cannot be undefined`);
            }
        }

        static validateString(val, name) {
            name = name || "Value";

            let isInValidText = CONSTANTS.MIN_STRING_LENGTH > val.length || CONSTANTS.MAX_STRING_LENGTH < val.length;
            if (isInValidText) {
                throw new Error(`${name} must be between 3 and 25`);
            }
        }

        static validatePositiveNumber(val) {
            if (val < 1) {
                throw new Error("Length must be a positive number");
            }
        }

        static validateImdbRating(val) {
            if (val < 1 || val > 5) {
                throw new Error("IMDB rating must be between 1 and 5");
            }
        }

        static  validateIfObject(val) {
            if (typeof val !== "object") {
                throw  new Error("You must add an object");
            }
        }
    }

    class Playable {
        constructor(title, author) {
            this._id = ++uniqueId;
            this.title = title;
            this.author = author;
        }

        get id() {
            return this._id;
        }

        get title() {
            return this._title;
        }

        set title(val) {
            Validation.validateIfUndefined(val, "Title");
            Validation.validateString(val, "Title");

            this._title = val;
        }

        get author() {
            return this._author;
        }

        set author(val) {
            Validation.validateIfUndefined(val, "Author");
            Validation.validateString(val, "Author");

            this._author = val;
        }

        play() {
            return `${this._id}. ${this._title} - ${this._author};`
        }
    }

    class Audio extends Playable {
        constructor(title, author, length) {
            super(title, author);

            this.length = length;
        }

        get length() {
            return this._length;
        }

        set length(val) {
            Validation.validateIfUndefined(val, "Length");
            Validation.validatePositiveNumber(val);

            this._length = val;
        }

        play() {
            return super.play() + ` - ${this._length}`;
        }
    }

    class Video extends Playable {
        constructor(title, author, imdbRating) {
            super(title, author);

            this.imdbRating = imdbRating;
        }

        get imdbRating() {
            return this._imdbRating;
        }

        set imdbRating(val) {
            Validation.validateImdbRating(val);
            this._imdbRating = val;
        }

        play() {
            return super.play() + ` - ${this._imdbRating}`;
        }
    }

    class Player {
        constructor(name) {
            this._id = ++playerId;
            this.name = name;
            this._playlists = [];
        }

        get id() {
            return this._id;
        }

        get name() {
            return this._name;
        }

        set name(val) {
            Validation.validateIfUndefined(val);
            Validation.validateString(val, "Name");

            this._name = val;
        }

        addPlaylist(playlistToAdd) {
            Validation.validateIfUndefined(playlistToAdd);
            Validation.validateIfObject(playlistToAdd);

            this._playlists.push(playlistToAdd);
        }

        getPlaylistById(id){
            for (let item of this._playlists){
                if(item.id === id){
                    return item;
                }
            }

            return null;
        }

        removePlaylist(id){
            let i,
                len = this._playlists.length,
                found = false;

            for (i =0; i < len; i+=1){
                if(this._playlists[i].id === id){
                    this._playlists.splice(i, 1);
                    found = true;
                    break;
                }
            }

            if(found){
                throw new Error("Id not found");
            }
        }

        listPlaylists(page, size){
            let maxSize = page * size,
                sortedPlaylist = [];

            return sortedPlaylist;
        }

        search(pattern){
            //TODO
        }
    }

    class PlayList {
        constructor(name) {
            this._id = ++playlistId;
            this._playables = [];
            this.name = name;
        }

        get playables(){
            return this._playables;
        }

        get id() {
            return this._id;
        }

        get name() {
            return this._name;
        }

        set name(val) {
            Validation.validateIfUndefined(val);
            Validation.validateString(val, "Name");

            this._name = val;
        }

        addPlayable(playable) {
            Validation.validateIfUndefined(playable);
            Validation.validateIfObject(playable);
            this._playables.push(playable);

            return this;
        }

        getPlayableById(id) {
            for (let item of this._playables){
                if(item._id === id){
                    return item;
                }
            }

            return null;
        }

        removePlayable(id) {

            let len = this._playables.length ,
                index = -1;

            for (let i = 0; i < len; i += 1){
                if(this._playables[i]._id === id){
                    index = i;
                    break;
                }
            }

            this._playables.splice(index, 1);
            return this;
        }

        listPlayables(page, size) {
            let sortedPlaylist = [];

            return sortedPlaylist;
        }
    }

    return {
        getPlayer: function (name) {
            return new Player(name);
        },
        getPlaylist: function (name) {
            return new PlayList(name);
        },
        getAudio: function (title, author, length) {
            return new Audio(title, author, length);
        },
        getVideo: function (title, author, imdbRating) {
            return new Video(title, author, imdbRating);
        },
        getPlayable: function (title, author) {
            return new Playable(title, author);

        }
    };
}

module.exports = solve;
/*
var module = solve();

var item = module.getPlayable("Titla", "azz");
var audio = module.getAudio("Ceca", "Pile", 123);
var video = module.getVideo("Count", "Monte Cristo", 4);
var player = module.getPlayer("Za masa");
var playlist = module.getPlaylist("Za masa");
 console.log(item.play());
 console.log(audio.play());
 console.log(video.play());
 console.log(player);
playlist.addPlayable(audio);
playlist.addPlayable(audio);
playlist.removePlayable(2);
console.log(playlist.playables);
*/