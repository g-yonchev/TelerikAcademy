/* globals $ */

function solve() {

  return function (selector) {
    var url = 'http://cdn.playbuzz.com/cdn/3170bee8-985c-47bc-bbb5-2bcb41e85fe9/d8aa4750-deef-44ac-83a1-f2b5e6ee029a.jpg';

    var template =
        '<div class="container">' +
          '<h1>Animals</h1>' +
          '<ul class="animals-list">' +
            '{{#animals}}' +
            '<li>' +
              '<a href="{{#if url}}url{{else}}http://cdn.playbuzz.com/cdn/3170bee8-985c-47bc-bbb5-2bcb41e85fe9/d8aa4750-deef-44ac-83a1-f2b5e6ee029a.jpg{{/if}}">{{#if url}}See a {{name}}{{else}}No link for {{name}}, here is Batman!{{/if}}</a>' +
            '</li>' +
            '{{/animals}}'
          '</ul>' +
        '</div>';

    $(selector).html(template);
  };
};

module.exports = solve;