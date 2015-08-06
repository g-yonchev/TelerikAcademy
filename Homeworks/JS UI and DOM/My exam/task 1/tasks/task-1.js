function solve() {
  return function (selector, isCaseSensitive) {
    function hasClass(element, cls) {
      return (' ' + element.className + ' ').indexOf(' ' + cls + ' ') > -1;
    }

    var container = document.querySelector(selector);
    var frag = document.createDocumentFragment();

    container.className += 'items-control';


    // add
    var addingPart = document.createElement('div');
    addingPart.className += ' add-controls';

    var laberForAdding = document.createElement('label');
    var idAdding = 'id-input-add-shalqlqlq';
    laberForAdding.innerHTML = 'Enter text';
    laberForAdding.setAttribute('for', idAdding);
    addingPart.appendChild(laberForAdding);



    var inputForAdding = document.createElement('input');
    inputForAdding.setAttribute('type','text');
    inputForAdding.setAttribute('id', idAdding);

    addingPart.appendChild(inputForAdding);

    var buttonForAdding = document.createElement('button');
    buttonForAdding.className += 'button';
    buttonForAdding.innerHTML = 'Add';
    addingPart.appendChild(buttonForAdding);


    var currenchild = addingPart.firstChild;

    var controlbtn;
    while(currenchild) {
      if (hasClass(currenchild, 'button')) {
        controlbtn = currenchild;
      }
      currenchild = currenchild.nextElementSibling;
    }



    // search
    var searchingPart = document.createElement('div');
    searchingPart.className += ' search-controls';

    var idSearch = 'id-search-shalqlqlql';
    var labelSearch = document.createElement('label');
    labelSearch.innerHTML = 'Search';
    labelSearch.setAttribute('for', idSearch);

    var inputSearch = document.createElement('input');
    inputSearch.setAttribute('id', idSearch);

    searchingPart.appendChild(labelSearch);
    searchingPart.appendChild(inputSearch);




    // result
    var resultPart = document.createElement('div');
    resultPart.className += ' result-controls';


    var list = document.createElement('ul');
    var li = document.createElement('li');

    list.className += ' items-list';
    li.className += ' list-item';

    resultPart.appendChild(list);



    frag.appendChild(addingPart);
    frag.appendChild(searchingPart);
    frag.appendChild(resultPart);

    container.appendChild(frag);


    window.onload = function () {
      controlbtn.addEventListener('click', function () {
        var itemsList = document.getElementsByClassName('items-list')[0];
        var text = inputForAdding.value;

        var xBtn = document.createElement('button');
        xBtn.className += 'button';
        xBtn.innerHTML = 'X';
        var item = document.createElement('li');
        item.className += ' list-item';
        item.innerHTML = text;
        item.appendChild(xBtn);
        itemsList.appendChild(item);
      });

      inputSearch.addEventListener('input', function() {
        var value = this.value;
        var resultControl = document.getElementsByClassName('result-controls')[0];
        var listItems = resultControl.childNodes[0].childNodes;

        for (var i = 0; i < listItems.length; i++) {
          var current = listItems[0].innerHTML;
          var par;
          if (current.indexOf(value) < 0) {
            par = cur.parentNode;
            par.style.display = 'none';
          } else {
            par.style.display = 'initial';
          }
        }

      })

      list.addEventListener('click', function(ev){
        var target = ev.target;
        if (hasClass(target, 'button')) {
          var l = target.parentNode;
          l.parentNode.removeChild(l);
        }
      })
    }



  };
}

module.exports = solve;