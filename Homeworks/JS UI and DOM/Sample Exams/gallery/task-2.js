function solve() {
  return function () {
    /* globals $ */
    $.fn.gallery = function (cols) {
      cols = cols || 4;
      var $galery = $(this);
      $galery.addClass('gallery');
      var $selected = $galery.children('.selected').hide();
      var $galleryList = $galery.children('.gallery-list');
      var $allImages = $galleryList.children('.image-container');
      var imagesCount = $allImages.size();

      for (var i = 0; i < imagesCount; i += 1) {
        if (i % cols === 0) {
          $($allImages[i]).addClass('clearfix');
        }
      }

      function fun() {
        $galleryList.addClass('blurred');
        var clickedImgSrc = $(this).attr('src');
        $selected.find('#current-image').attr('src', clickedImgSrc);
        var dataInfo = $(this).data('info');
        var prevDataInfo = dataInfo - 1;

        var prevImgSrc;
        if (prevDataInfo === 0) {
           prevDataInfo = imagesCount;
           prevImgSrc = $(this).parent().parent().children().last().children('img').attr('src');
        } else {
           prevImgSrc = $(this).parent().prev().children('img').attr('src');
        }
        var nextImgSrc;
        var nextDataInfo = dataInfo + 1;
        if (nextDataInfo === imagesCount + 1) {
          nextDataInfo = 1;
          nextImgSrc = $(this).parent().parent().children().first().children('img').attr('src');
        } else {
          nextImgSrc = $(this).parent().next().children('img').attr('src');
        }
        $selected.find('#previous-image').attr('src', prevImgSrc).attr('data-info', prevDataInfo);
        $selected.find('#current-image').attr('src', clickedImgSrc).attr('data-info', dataInfo);
        $selected.find('#next-image').attr('src', nextImgSrc).attr('data-info', nextDataInfo);
        $selected.show();
        $galleryList.off('click', 'img', fun);
      }

      $galleryList.on('click', 'img', fun);

      $selected.on('click', '#current-image', function() {
        $galleryList.on('click', 'img', fun);
        $galleryList.removeClass('blurred');
        $selected.hide();
      })

      function leftClick () {
        var num = +$(this).attr('data-info');
        var prevSrc = $galleryList.find('img[data-info="' + (num === 1? imagesCount : num - 1) + '"]').attr('src');
        var currImgSrc = $(this).attr('src');
        var nextSrc = $(this).parent().next().children('img').attr('src');
        $selected.find('#previous-image').attr('src', prevSrc).attr('data-info', num === 1? imagesCount : num - 1);
        $selected.find('#current-image').attr('src', currImgSrc).attr('data-info', num);
        $selected.find('#next-image').attr('src', nextSrc).attr('data-info', num + 1);
      }

      $selected.on('click', '#previous-image', leftClick);

      $selected.on('click', '#next-image', function() {
        var num = +$(this).attr('data-info');
        var currImgSrc = $(this).attr('src');
        var prevSrc = $(this).parent().prev().children('img').attr('src');
        var nextSrc = $galleryList.find('img[data-info="' + (num === imagesCount? 1 : num + 1) + '"]').attr('src');
        $selected.find('#previous-image').attr('src', prevSrc).attr('data-info', num - 1);
        $selected.find('#current-image').attr('src', currImgSrc).attr('data-info', num);
        $selected.find('#next-image').attr('src', nextSrc).attr('data-info', num === imagesCount? 1 : num + 1);
      })

      return $galery;
    };
  };
}
