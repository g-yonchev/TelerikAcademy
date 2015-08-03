var pictures = [{
    url: 'imgs/1.jpg',
    data: 1
    }, {
    url: 'imgs/2.jpg',
    data: 2
}, {
    url: 'imgs/3.jpg',
    data: 3
}, {
    url: 'imgs/4.jpg',
    data: 4
}, {
    url: 'imgs/5.jpg',
    data: 5
}, {
    url: 'imgs/6.jpg',
    data: 6
}, {
    url: 'imgs/7.jpg',
    data: 7
}, {
    url: 'imgs/8.jpg',
    data: 8
}, {
    url: 'imgs/9.jpg',
    data: 9
}, {
    url: 'imgs/10.jpg',
    data: 10
}, {
    url: 'imgs/11.jpg',
    data: 11
}, {
    url: 'imgs/12.jpg',
    data: 12
}];

var ListContainer = document.getElementById('root');

var ListTemplate = Handlebars.compile((document.getElementById('pictures-template')).innerHTML);

// empty the container
while (ListContainer.firstChild) {
    ListContainer.removeChild(ListContainer.firstChild);
}

ListContainer.innerHTML = ListTemplate({
    pictures: pictures
});
