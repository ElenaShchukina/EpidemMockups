$(document).ready(function () {
    $('#fullpage').fullpage({
        css3: true,
        anchors: ['firstPage', 'secondPage', '3rdPage', '4thPage'],
        navigation: true,
        navigationPosition: 'right',
        navigationTooltips: ['Добро пожаловать!', 'Интерактивная карта', 'Опрос', 'Анализ'],
        responsiveWidth: 900,
        responsiveHeight: 600,
        afterResponsive: function (isResponsive) {
        }
    });
});