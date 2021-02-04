var collabsableMenuIsOpen = false;
$("#mobile-button").click( function () {
    if(!collabsableMenuIsOpen) {
        
        $("div.topheader").addClass("topbutton");
    } else {
        $("div.topheader").removeClass("topbutton");
    }
    collabsableMenuIsOpen = !collabsableMenuIsOpen;
});

$(".mobileanchorIcon").click( function () {
    if(!$(this).hasClass("mobileMenuListOpen")) {
        $(".mobileanchorIcon").removeClass("mobileMenuListOpen");
        $(".mobileMenuItem").removeClass("openmenu");
        $(this).parent().addClass("openmenu");
        $(this).addClass("mobileMenuListOpen");
    } else {
        $(this).parent().removeClass("openmenu");
        $(this).removeClass("mobileMenuListOpen");
    }
});