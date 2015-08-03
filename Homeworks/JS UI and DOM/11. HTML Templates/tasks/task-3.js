function solve(){
  return function(){
    $.fn.listview = function(data){
      var attr = this.attr('data-template');
      var template = $('#' + attr).html();

      var compiledTemplate = handlebars.compile(template);

      for (var i = 0, len = data.length; i < len; i += 1) {
        this.append(compiledTemplate(data[i]));
      }

      return this;
    };
  };
}

module.exports = solve;