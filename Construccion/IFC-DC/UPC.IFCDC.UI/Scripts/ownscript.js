var actual = "#logros";
function change_view(show) {
    if (show !== actual) {
        $(actual).hide();
        $(show).fadeIn(300);    
        actual = show;
    }
}