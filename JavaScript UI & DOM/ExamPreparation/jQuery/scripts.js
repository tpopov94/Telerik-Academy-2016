/* globals $ */
$.fn.gallery = function (columnsPerRow) {
    "use strict";

    columnsPerRow = columnsPerRow || 4;

    // Current item
    var $gallery = this;
    var $selected = $gallery.children('.selected');
    var $imageContainer = $gallery.find('.image-container');
    var $galleryList = $gallery.children('.gallery-list');
    var $curentImage = $selected.find('#current-image');
    var $previousImage = $selected.find('#previous-image');
    var $nextImage = $selected.find('#next-image');

    // adding collumns
    $imageContainer.each(function (index, element) {
        if(index % columnsPerRow === 0){
            $(element).addClass('clearfix');
        }
    });

    $galleryList.on('click', 'img', function () {
        //selecting proper elements
        var $this = $(this);
        $galleryList.addClass('blurred');
        $('<div>').addClass('disabled-background').appendTo($gallery);
        var currentImageInfo = getImageInformation($this);

        setImageInformation($curentImage, currentImageInfo.src, currentImageInfo.index);

        var previousIndex = getPreviousIndex(currentImageInfo.index);
        var nextIndex = getNextIndex(currentImageInfo.index);

        var previousImage = getImageByIndex(previousIndex);
        var nextImage = getImageByIndex(nextIndex);

        var previousImageInfo = getImageInformation(previousImage);
        var nextImageInfo = getImageInformation(nextImage);
        setImageInformation($previousImage, previousImageInfo.src, previousImageInfo.index);
        setImageInformation($nextImage, nextImageInfo.src, nextImageInfo.index);

        $selected.show();
    });

    $curentImage.on('click', function () {
        $galleryList.removeClass('blurred');
        $gallery.children('.disabled-background').remove();
        $selected.hide();
    });

    $gallery.addClass('gallery');
    $selected.hide();

    $previousImage.on('click', function () {
        var $this = $(this);
        var currentImageInfo = getImageInformation($this);

        setImageInformation($curentImage, currentImageInfo.src, currentImageInfo.index);

        var previousIndex = getPreviousIndex(currentImageInfo.index);
        var nextIndex = getNextIndex(currentImageInfo.index);

        var previousImage = getImageByIndex(previousIndex);
        var nextImage = getImageByIndex(nextIndex);

        var previousImageInfo = getImageInformation(previousImage);
        var nextImageInfo = getImageInformation(nextImage);
        setImageInformation($previousImage, previousImageInfo.src, previousImageInfo.index);
        setImageInformation($nextImage, nextImageInfo.src, nextImageInfo.index);
    });

    $nextImage.on('click', function () {
        var $this = $(this);
        var currentImageInfo = getImageInformation($this);

        setImageInformation($curentImage, currentImageInfo.src, currentImageInfo.index);

        var previousIndex = getPreviousIndex(currentImageInfo.index);
        var nextIndex = getNextIndex(currentImageInfo.index);

        var previousImage = getImageByIndex(previousIndex);
        var nextImage = getImageByIndex(nextIndex);

        var previousImageInfo = getImageInformation(previousImage);
        var nextImageInfo = getImageInformation(nextImage);
        setImageInformation($previousImage, previousImageInfo.src, previousImageInfo.index);
        setImageInformation($nextImage, nextImageInfo.src, nextImageInfo.index);
    });

    function getImageByIndex(index) {
        return $gallery.find('img[data-info="' + index + '"]');
    }
    
    function getNextIndex(index) {
        index++;
        if (index > $imageContainer.length){
            index = 1;
        }

        return index;
    }

    function getPreviousIndex(index) {
        index--;
        if (index < 1 ){
            index = $imageContainer.length;
        }

        return index;
    }

    function setImageInformation($element, src, index) {
        $element.attr('src', src);
        $element.attr('data-info', index);
    }

    function getImageInformation($element) {
        return {
            src: $element.attr('src'),
            index: parseInt($element.attr('data-info'))
        };
    }

    return this;
};