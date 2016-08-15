function createImagesPreviewer(selector, items) {
    var root = document.querySelector(selector),
        fragment = document.createDocumentFragment();

    var imagePreviewer = document.createElement('div'),
        aside = document.createElement('div');

    //styles
    imagePreviewer.style.display = 'inline-block';
    imagePreviewer.style.width = "70%";
    imagePreviewer.style.float = "left";

    aside.style.display = 'inline-block';
    aside.style.width = "30%";
    //imagePreviewer.style.float = "left";

    var selectedParent = document.createElement('div');
    selectedParent.classList.add('image-preview');
    var selectedImageHeader = document.createElement('h3');
    selectedImageHeader.innerText = items[0].title;
    var selectedImage = document.createElement('img');
    selectedImage.style.width = "85%";
    selectedImage.src = items[0].url;

    selectedParent.appendChild(selectedImageHeader);
    selectedParent.appendChild(selectedImage);
    imagePreviewer.appendChild(selectedParent);

    var input = document.createElement("input");
    var inputHeader = document.createElement('h3');
    inputHeader.innerText = 'Filter';
    input.addEventListener('keyup', function (ev) {
        var text = ev.target.value;
        var liChildren = listOfItems.getElementsByTagName('li');
        for(var i = 0, len = liChildren.length; i < len; i+=1){
            var curLi = liChildren[i];
            var header = curLi.firstElementChild.innerText;
            if(header.toLowerCase().indexOf(text.toLowerCase()) >= 0) {
                curLi.style.display = 'block';
            }
            else {
                curLi.style.display = 'none';
            }
        }
    }, false);

    var listOfItems = document.createElement('ul');
    listOfItems.style.listStyleType = 'none';
    listOfItems.style.height = "800px";
    listOfItems.style.overflowY = "scroll";
    listOfItems.addEventListener('click', function (ev) {
        var target = ev.target;
        if (target.tagName === 'IMG') {
            var header = target.previousElementSibling.innerText;
            var src = target.src;
            selectedImageHeader.innerText = header;
            selectedImage.src = src;
        }
    }, false);

    listOfItems.addEventListener('mouseover', function (ev) {
        var target = ev.target;
        if (target.tagName === 'IMG') {
           target.parentElement.style.background = 'gray';
        }
    }, false);

    listOfItems.addEventListener('mouseout', function (ev) {
        var target = ev.target;
        if (target.tagName === 'IMG') {
            target.parentElement.style.background = 'white';
        }
    }, false);

    var li = document.createElement('li');
    // Adding class
    li.classList.add('image-container');
    var imageHeader = document.createElement('h3');
    var image = document.createElement('img');
    image.style.width = '100%';

    for (var i = 0, len = items.length; i < len; i += 1) {
        var currentItem = items[i],
            currentLi = li.cloneNode(true),
            currentImageHeader = imageHeader.cloneNode(true),
            currImage = image.cloneNode(true);
        currentImageHeader.innerText = currentItem.title;
        currImage.src = currentItem.url;

        currentLi.appendChild(currentImageHeader);
        currentLi.appendChild(currImage);

        listOfItems.appendChild(currentLi);
    }

    aside.appendChild(inputHeader);
    aside.appendChild(input);
    aside.appendChild(listOfItems);

    fragment.appendChild(imagePreviewer);
    fragment.appendChild(aside);

    root.appendChild(fragment);
}