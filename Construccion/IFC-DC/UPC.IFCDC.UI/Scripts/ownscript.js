var actual = "#logros";
function change_view(show) {
    if (show !== actual) {
        $(actual).hide();
        $(show).fadeIn(300);    
        actual = show;
    }
}
function popup(idpopup) {
    $(".dark-side").show();
    $(idpopup).show(500);
}
function close_popup(idpopup) {
    $(idpopup).fadeOut(500);
    $(".dark-side").fadeOut(500);
    
}