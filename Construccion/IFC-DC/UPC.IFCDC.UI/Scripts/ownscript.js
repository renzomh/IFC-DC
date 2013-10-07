var actual = "#logros";
var actual2 = "#informesFinCiclo";
//--------------------------
function change_view(show) {
    if (show !== actual) {
        $(actual).hide();
        $(show).fadeIn(300);    
        actual = show;
    }
}
//--------------------------
function change_view2(show) {
    if (show !== actual2) {
        $(actual2).hide();
        $(show).fadeIn(300);
        actual2 = show;
    }
}
//--------------------------
function popup(idpopup) {
    $(".dark-side").show();
    $(idpopup).show(500);
}
//--------------------------
function close_popup(idpopup) {
    $(idpopup).fadeOut(500);
    $(".dark-side").fadeOut(500);

}
