var data = (function () {
  const USERNAME_STORAGE_KEY = 'username-key';

  // start users
  function userLogin(user) {
    localStorage.setItem(USERNAME_STORAGE_KEY, user);
    return Promise.resolve(user);
  }

  function userLogout() {
    localStorage.removeItem(USERNAME_STORAGE_KEY)
    return Promise.resolve();
  }

  function userGetCurrent() {
    return Promise.resolve(localStorage.getItem(USERNAME_STORAGE_KEY));
  }
  // end users

  // start threads
  function threadsGet() {
    return new Promise((resolve, reject) => {
      $.getJSON('api/threads')
        .done(resolve)
        .fail(reject);
    });
  }

  function threadsAdd(title) {
    return new Promise(function (resolve, reject) {
      let username = userGetCurrent().then(function (username) {
        body = {
          title: title,
          username: username
        };

        $.ajax({
          url: 'api/threads',
          type: 'POST',
          contentType: 'application/json',
          data: JSON.stringify(body)
        }).done((data) => resolve(data))
          .fail((err) => reject(err));
      });
    });
  }

  function threadById(id) {
    return new Promise(function (resolve, reject) {
      let url = `api/threads/${id}`;
      $.ajax({
        url: url,
        type: 'GET',
        contentType: 'application/json',
        data: JSON.stringify({ id: id })
      }).done((data) => resolve(data))
        .fail((err) => reject(err));
    });
  }

  function threadsAddMessage(threadId, content) {
    return new Promise((resolve, reject) => {
      userGetCurrent()
        .then((username) => {
          let body = { content, username };

          $.ajax({
            type: 'POST',
            url: `api/threads/${threadId}/messages`,
            data: JSON.stringify(body),
            contentType: 'application/json'
          }).done(resolve)
            .fail(reject);
        });
    });
  }
  // end threads

  // start gallery
  function galleryGet() {
    const REDDIT_URL = `https://www.reddit.com/r/aww.json?jsonp=?`;
    return new Promise((resolve, reject) => {
      $.ajax({
        url: REDDIT_URL,
        jsonp: "callback",
        dataType: "jsonp",
        success: function (response) {
          resolve(response);
        },
        fail: function (err) {
          reject(err);
        }
      });
    });
  }
  // end gallery

  return {
    users: {
      login: userLogin,
      logout: userLogout,
      current: userGetCurrent
    },
    threads: {
      get: threadsGet,
      add: threadsAdd,
      getById: threadById,
      addMessage: threadsAddMessage
    },
    gallery: {
      get: galleryGet,
    }
  }
})();