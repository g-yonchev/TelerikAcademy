/* globals $ */

/*

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

module.exports = function () {

  return function (element, contents) {
    if (typeof element === 'undefined' || typeof contents === 'undefined') {
      throw 'Any of the function params is missing';
    }

    if (typeof  element !== 'string' && !(element instanceof HTMLElement))
    {
      throw 'The provided first parameter is neither string or existing DOM element';
    }

    if (element === null) {
      throw 'The provided id does not select anything ';
    }

    if (typeof element === 'string') {
      element = document.getElementById(element);
    }

    var divElement = document.createElement('div'),
        itemsCount = contents.length,
        frag = document.createDocumentFragment();

    for (var i = 0; i < itemsCount; i += 1) {
      if (typeof contents[i] !== 'string' && typeof contents[i] !== 'number') {
        throw 'Any of the contents is neight `string` or `number`';
      }
      var currentDiv = divElement.cloneNode(true);
      currentDiv.innerHTML = contents[i];
      frag.appendChild(currentDiv);
    }

    element.innerHTML = '';

    element.appendChild(frag);
  };
};