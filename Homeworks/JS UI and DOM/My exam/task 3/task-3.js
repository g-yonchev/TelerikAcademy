function solve() {
    return function (selector) {
        var template =
            '<div class="event-calendar">' +
                '<h2 class="header">Appointments for <span class="month">{{month}}</span> <span class="year">{{year}}</span></h2>' +
                    '{{#each days}}' +
                    '<div class="col-date">' +
                        '<div class="date">{{day}}</div>' +
                        '<div class="events">' +
                            '{{#each events}}' +
                            '<div class="event {{importance}}" {{#if title}}  title="duration: {{duration}}" {{/if}}>' +
                                '<div class="title">{{#if title}}{{title}}{{else}}Free slot{{/if}}</div>' +
                                '{{#if time}}' +
                                    '<span class="time">at: {{time}}</span>' +
                                '{{/if}}' +
                            '</div>' +
                            '{{/each}}' +
                        '</div>' +
                    '</div>' +
                    '{{/each}}' +
        '</div>';

        document.getElementById(selector).innerHTML = template;
    };
}

module.exports = solve;