function isEmpty( el ){
    return !$.trim(el.html())
}
if (!isEmpty($('#collapseToC'))) {
    $("#toc-right-side-bar").removeClass("hide-toc");
}

$("#hideToCHref").click(function() {
    var isCollapsed = $("#collapseToC").hasClass("show");
    $(this).text(function() {
        if(!$("#collapseToC").hasClass("show")) {
            return "Hide";
        }
        else {
            return "Show";
        }
        
    });
});
