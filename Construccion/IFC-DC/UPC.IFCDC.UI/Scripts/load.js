$(document).ready(function () {
    $.ajaxSetup({ cache: false });
    width = 0;

    $("#ModalFormJquery").dialog({
        autoOpen: false,
        modal: true,
        resizable: false,
        draggable: false,
        closeText: 'hide',
        width: 420
    });

    $('ul#dropdownmenu li').each(function () {
        var tamanio = $(this).width();
        width += parseInt(tamanio);
    });

    $('#dropdownmenu').width(width);

    $('.numerico').live('keypress', function (e) {
        var c = document.all ? c = e.keyCode : c = e.which;
        return ((c > 47 && c < 58) || c == 13 || c == 8);
    });

    $('.alfaNumerico').live('keypress', function (e) {
        var c = document.all ? c = e.keyCode : c = e.which;
        return ((c > 47 && c < 58) || (c > 96 && c < 123) || (c > 64 && c < 91) || c == 13 || c == 8);
    });

    $('.alfaNumerico-guion-punto-subGuion').live('keypress', function (e) {
        if ($(this).val().length == 1) {
            var val = $(this).val();
            $(this).val(val.charAt(0).toUpperCase() + val.substring(1, val.length));
        }
        var c = document.all ? c = e.keyCode : c = e.which;
        return (c != 39); /*((c > 47 && c < 58) //1-9
        || (c > 96 && c < 123) //a-z
        || c == 209 //ñ
        || c == 225 //á
        || c == 233 //é
        || c == 237 //í
        || c == 243 //ó
        || c == 250 //ú
        || (c > 64 && c < 91) //A-Z
        || c == 241 //Ñ
        || c == 193 //Á
        || c == 201 //É
        || c == 205 //Í
        || c == 211 //Ó
        || c == 218 //Ó
        || c == 45 //-
        || c == 46 //.
        || c == 95 //_
        || c == 32 //espacio
        || c == 13 //inicio
        || c == 8 //backspace
        || c == 40 // (
        || c == 41 // )
        || c == 47 // /
        || c == 44 // ,
        || c == 58 // :
        || c == 59)// ;*/
    });

    $('.alfaNumerico-guion-punto-subGuion').live('keyup', function (e) {
        var c = document.all ? c = e.keyCode : c = e.which;
        if (c == 8 || c == 16 || c == 17 || c == 35 || c == 36 || c == 37 || c == 39 || c == 46) {
            return false;
        }
        else if ($(this).val().length == 1) {
            var val = $(this).val();
            $(this).val(val.charAt(0).toUpperCase() + val.substring(1, val.length));
        }
    });

    $('.alfaNumerico-guion-punto-arroba-subGuion').live('keypress', function (e) {
        var c = document.all ? c = e.keyCode : c = e.which;
        return ((c > 47 && c < 58) //1-9
        || (c > 96 && c < 123) //a-z
        || (c > 64 && c < 91) //A-Z
        || c == 45 //-
        || c == 46 //.
        || c == 64 //@
        || c == 95 //_
        || c == 32 //espacio
        || c == 13 //inicio
        || c == 8); //backspace
    });
});

(function ($) {
    $.fn.setCursorPosition = function (pos) {
        if ($(this).get(0).setSelectionRange) {
            $(this).get(0).setSelectionRange(pos, pos);
        } else if ($(this).get(0).createTextRange) {
            var range = $(this).get(0).createTextRange();
            range.collapse(true);
            range.moveEnd('character', pos);
            range.moveStart('character', pos);
            range.select();
        }
    }
} (jQuery));


jQuery(function ($) {
    $.datepicker.regional['es'] = {
        closeText: 'Cerrar',
        prevText: 'Anterior',
        nextText: 'Siguiente',
        currentText: 'Hoy',
        monthNames: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
        monthNamesShort: ['Ene', 'Feb', 'Mar', 'Abr', 'May', 'Jun', 'Jul', 'Ago', 'Sep', 'Oct', 'Nov', 'Dic'],
        dayNames: ['Domingo', 'Lunes', 'Martes', 'Miércoles', 'Jueves', 'Viernes', 'Sábado'],
        dayNamesShort: ['Dom', 'Lun', 'Mar', 'Mié', 'Juv', 'Vie', 'Sáb'],
        dayNamesMin: ['Do', 'Lu', 'Ma', 'Mi', 'Ju', 'Vi', 'Sá'],
        weekHeader: 'Sm',
        dateFormat: 'dd/mm/yy',
        firstDay: 1,
        isRTL: false,
        showMonthAfterYear: false,
        yearSuffix: ''
    };
    $.datepicker.setDefaults($.datepicker.regional['es']);
});

function validarFecha(valor) {
    re = /^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((19|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((19|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((19|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$/
    if (!re.exec(valor)) {
        return false;
    } else {
        return true;
    }
}

function setCaretPosition(ctrl, pos) {
    if (ctrl.setSelectionRange) {
        ctrl.focus();
        ctrl.setSelectionRange(pos, pos);
    }
    else if (ctrl.createTextRange) {
        var range = ctrl.createTextRange();
        range.collapse(true);
        range.moveEnd('character', pos);
        range.moveStart('character', pos);
        range.select();
    }
}

function getInputSelection(el) {
    var start = 0, end = 0, normalizedValue, range,
        textInputRange, len, endRange;

    if (typeof el.selectionStart == "number" && typeof el.selectionEnd == "number") {
        start = el.selectionStart;
        end = el.selectionEnd;
    } else {
        range = document.selection.createRange();

        if (range && range.parentElement() == el) {
            len = el.value.length;
            normalizedValue = el.value.replace(/\r\n/g, "\n");

            // Create a working TextRange that lives only in the input
            textInputRange = el.createTextRange();
            textInputRange.moveToBookmark(range.getBookmark());

            // Check if the start and end of the selection are at the very end
            // of the input, since moveStart/moveEnd doesn't return what we want
            // in those cases
            endRange = el.createTextRange();
            endRange.collapse(false);

            if (textInputRange.compareEndPoints("StartToEnd", endRange) > -1) {
                start = end = len;
            } else {
                start = -textInputRange.moveStart("character", -len);
                start += normalizedValue.slice(0, start).split("\n").length - 1;

                if (textInputRange.compareEndPoints("EndToEnd", endRange) > -1) {
                    end = len;
                } else {
                    end = -textInputRange.moveEnd("character", -len);
                    end += normalizedValue.slice(0, end).split("\n").length - 1;
                }
            }
        }
    }
    return {
        start: start,
        end: end
    };
}

