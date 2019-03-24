
$(function () {
    /*===== variables =======*/
    var currSeatSelectDigit = null;
    var currSeatSelectLetter = null;
    var seatSelectedDigit = null;
    var seatSelectedLetter = null;
    var currGuestId = "";
    var currSeatSelectDigitR = null;
    var currSeatSelectLetterR = null;
    var seatSelectedDigitR = null;
    var seatSelectedLetterR = null;
    var currGuestIdR = "";
    var seatGoStr = "seatGo";
    var seatReturnStr = "seatReturn";
    
    var guestGoId = 0;
    var currRadioSelDigitVal = null;
    var currRadioSelLetterVal = null;
    var currRadioSelDigitValR = null;
    var currRadioSelLetterValR = null;

    var tempObj = {
        seatSelectedDigit: currRadioSelDigitVal,
        seatSelectedLetter: currRadioSelLetterVal
    };

    var guestGoRadio = $("input[name='guestGoRadio']");
    var guestReturnRadio = $("input[name='guestReturnRadio']");
    var guestGoRadioCheckedStr = "input[name='guestGoRadio']:checked";
    var guestRetRadioCheckedStr = "input[name='guestReturnRadio']:checked";

    //below is to set the first radio as checked.
    $("input:radio[name='guestGoRadio']:first").attr('checked', true);
    $("input:radio[name='guestReturnRadio']:first").attr('checked', true);


    /*====== implementation ============*/
    var previousRadioGoId = HighlightCurrentRadio(guestGoRadioCheckedStr, "red", true);
    var previousRadioRetId = HighlightCurrentRadio(guestRetRadioCheckedStr, "red", true);

    //first time default: GO
    //initialize 
    //get selected guest id
    guestGoId = $("input[name='guestGoRadio']:checked").val();
    seatSelectionProcess(guestGoId, seatSelectedDigit, seatSelectedLetter, tempObj, seatGoStr, "#hiddenSeatIdDigitGo", "#hiddenSeatIdLetterGo");
    //copy to variable for next round usage
    seatSelectedDigit = tempObj.seatSelectedDigit;
    seatSelectedLetter = tempObj.seatSelectedLetter;

    guestGoRadio.change(function () {
        ResetPreviousSelectedRadio(previousRadioGoId);
        previousRadioGoId = HighlightCurrentRadio(guestGoRadioCheckedStr, "red", true);
        //get selected guest id
        guestGoId = $(this).val();

        seatSelectionProcess(guestGoId, seatSelectedDigit, seatSelectedLetter, tempObj, seatGoStr, "#hiddenSeatIdDigitGo", "#hiddenSeatIdLetterGo");
        //copy to variable for next round usage
        seatSelectedDigit = tempObj.seatSelectedDigit;
        seatSelectedLetter = tempObj.seatSelectedLetter;
    });

    //first time default: REturn
    //get selected guest id
    guestGoId = $("input[name='guestReturnRadio']:checked").val();
    seatSelectionProcess(guestGoId, seatSelectedDigitR, seatSelectedLetterR, tempObj, seatReturnStr, "#hiddenSeatIdDigitReturn", "#hiddenSeatIdLetterReturn");
    //copy to variable for next round usage
    seatSelectedDigitR = tempObj.seatSelectedDigit;
    seatSelectedLetterR = tempObj.seatSelectedLetter;

    guestReturnRadio.change(function () {
        ResetPreviousSelectedRadio(previousRadioRetId);
        previousRadioRetId = HighlightCurrentRadio(guestRetRadioCheckedStr, "red", true);
        //get selected guest id
        guestGoId = $(this).val();
        seatSelectionProcess(guestGoId, seatSelectedDigitR, seatSelectedLetterR, tempObj, seatReturnStr, "#hiddenSeatIdDigitReturn", "#hiddenSeatIdLetterReturn");
        //copy to variable for next round usage
        seatSelectedDigitR = tempObj.seatSelectedDigit;
        seatSelectedLetterR = tempObj.seatSelectedLetter;
    });


    /*======== when selecting seats ================*/
    $("." + seatGoStr).click(function () {
        currSeatSelectDigit = $(this).attr("data-seatIdDigit");
        currSeatSelectLetter = $(this).attr("data-seatIdLetter");
        if (currSeatSelectDigit !== null && currSeatSelectLetter !== null) {
            if ((currSeatSelectDigit + currSeatSelectLetter) !== (seatSelectedDigit + seatSelectedLetter)) {
                //alert("aa: " + seatSelectedDigit + seatSelectedLetter);
                $("." + seatGoStr + "[data-seatIdDigit = '" + seatSelectedDigit + "'][data-seatIdLetter = '" + seatSelectedLetter + "']").removeClass("btn-warning").addClass("btn-success");
                $(this).addClass("btn-warning");
                seatSelectedDigit = currSeatSelectDigit;
                seatSelectedLetter = currSeatSelectLetter;
            } else {
                $(this).toggleClass("btn-warning");
                seatSelectedDigit = null;
                seatSelectedLetter = null;
            }
            currGuestId = $("input[name='guestGoRadio']:checked").val();
            $("#hiddenSeatIdDigitGo-" + currGuestId).val(seatSelectedDigit);
            $("#hiddenSeatIdLetterGo-" + currGuestId).val(seatSelectedLetter);
            if (seatSelectedDigit !== null && seatSelectedLetter !== null) {
                $("input[name='guestGoRadio']:checked~span").text(seatSelectedDigit + seatSelectedLetter);
                $("#" + currGuestId + "-goSeatValidation").text("");
            } else {
                $("input[name='guestGoRadio']:checked~span").text("Not Selected");
            }
            
        }
    });

    $("." + seatReturnStr).click(function () {
        currSeatSelectDigitR = $(this).attr("data-seatIdDigit");
        currSeatSelectLetterR = $(this).attr("data-seatIdLetter");
        if (currSeatSelectDigitR !== null && currSeatSelectLetterR !== null) {
            if ((currSeatSelectDigitR + currSeatSelectLetterR) !== (seatSelectedDigitR + seatSelectedLetterR)) {
                $("." + seatReturnStr + "[data-seatIdDigit = '" + seatSelectedDigitR + "'][data-seatIdLetter = '" + seatSelectedLetterR + "']").removeClass("btn-warning").addClass("btn-success");
                $(this).addClass("btn-warning");
                seatSelectedDigitR = currSeatSelectDigitR;
                seatSelectedLetterR = currSeatSelectLetterR;
            } else {
                $(this).toggleClass("btn-warning");
                seatSelectedDigitR = null;
                seatSelectedLetterR = null;
            }
            currGuestIdR = $("input[name='guestReturnRadio']:checked").val();
            $("#hiddenSeatIdDigitReturn-" + currGuestIdR).val(seatSelectedDigitR);
            $("#hiddenSeatIdLetterReturn-" + currGuestIdR).val(seatSelectedLetterR);

            if (seatSelectedDigitR !== null && seatSelectedLetterR !== null) {
                $("input[name='guestReturnRadio']:checked~span").text(seatSelectedDigitR + seatSelectedLetterR);
                $("#" + currGuestIdR + "-returnSeatValidation").text("");
            } else {
                $("input[name='guestReturnRadio']:checked~span").text("Not Selected");
            }
            
        }
    });

    /*===== functions ========*/
    function HighlightCurrentRadio(elName, bgColor, colorIsWhite) {
        if (!colorIsWhite) {
            $(elName).parent().parent().css("font-weight", "bold").css("background-color", bgColor);
        } else {
            $(elName).parent().parent().css("font-weight", "bold").css("background-color", bgColor).css("color", "white");
        }
        return $(elName).attr("id");
    }

    function ResetPreviousSelectedRadio(previousRadioId) {
        $("#" + previousRadioId).parent().parent().css("background-color", "inherit").css("color", "black").css("font-weight", "normal");
    }

    function seatSelectionProcess(guestGoId2,  seatSelectedDigit2, seatSelectedLetter2, tempObj, seatGoStr2, hiddenSeatIdDigitStr, hiddenSeatIdLetterStr) {
        //get currently selected seat digit and letter of currently selected guest
        currRadioSelDigitVal = $(hiddenSeatIdDigitStr + "-" + guestGoId2).val();
        currRadioSelLetterVal = $(hiddenSeatIdLetterStr + "-" + guestGoId2).val();
        //remove selected colour from previously selected seat and apply colour to currently selected seat
        $("." + seatGoStr2 + "[data-seatIdDigit = '" + seatSelectedDigit2 + "'][data-seatIdLetter = '" + seatSelectedLetter2 + "']").removeClass("btn-warning btn-success").attr("disabled", true);
        $("." + seatGoStr2 + "[data-seatIdDigit = '" + currRadioSelDigitVal + "'][data-seatIdLetter = '" + currRadioSelLetterVal + "']").removeAttr("disabled").addClass("btn-warning");

        //copy current selected seat to another variable to remember currently selected seat, for next round usage
        //seatSelectedDigit = currRadioSelDigitVal;
        //seatSelectedLetter = currRadioSelLetterVal;
        tempObj.seatSelectedDigit = currRadioSelDigitVal;
        tempObj.seatSelectedLetter = currRadioSelLetterVal;

    }
});

//====reference
//guestGoId = $(this).val();
//        //currRadioSelDigitValR = $("#hiddenSeatIdDigitReturn-" + guestGoId).val();
//        //currRadioSelLetterValR = $("#hiddenSeatIdLetterReturn-" + guestGoId).val();
//        //$("." + seatReturnStr + "[data-seatIdDigit = '" + seatSelectedDigitR + "'][data-seatIdLetter = '" + seatSelectedLetterR + "']").removeClass("btn-warning btn-success").attr("disabled", true);
//        //$("." + seatReturnStr + "[data-seatIdDigit = '" + currRadioSelDigitValR + "'][data-seatIdLetter = '" + currRadioSelLetterValR + "']").removeAttr("disabled").addClass("btn-warning");
//        //seatSelectedDigitR = currRadioSelDigitValR;
//        //seatSelectedLetterR = currRadioSelLetterValR;