
var elementToScrollTo = $('.active.td-sidebar-link');

if (elementToScrollTo.height() != null) {
    var elementHeight = elementToScrollTo.height();
    var k = 3;
    
    if(elementHeight > 60 ) {
        k = 1;
    } else if (elementHeight > 40 ) {
        k = 1.5;
    }
    
    $('#td-sidebar-menu').scrollTop(elementToScrollTo.offset().top - elementHeight * k);
}
