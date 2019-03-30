
$(function () {

    var addOneToListBtnPilot = $("#addOneToListBtnPilot");
    var addAllToListBtnPilot = $("#addAllToListBtnPilot");
    var remOneFromListBtnPilot = $("#remOneFromListBtnPilot");
    var remAllFromListBtnPilot = $("#remAllFromListBtnPilot");
    var pilotsAvailable = $("#pilotsAvailable");
    var pilotsAvailableSelected = $("#pilotsAvailableSelected");
    var pilotsAvailableSelectedOption = $("#pilotsAvailableSelected > option");
    var addOneToListBtnSteward = $("#addOneToListBtnSteward");
    var addAllToListBtnSteward = $("#addAllToListBtnSteward");
    var remOneFromListBtnSteward = $("#remOneFromListBtnSteward");
    var remAllFromListBtnSteward = $("#remAllFromListBtnSteward");
    var stewardsAvailable = $("#stewardsAvailable");
    var stewardsAvailableSelected = $("#stewardsAvailableSelected");
    var submitBtn = $("#submitBtn");
    var addForm = $("#addForm");

    addOneToListBtnPilot.click(function () {
        appendToDest("pilotsAvailable", pilotsAvailableSelected, false);
        //return !$("#pilotsAvailable option:selected").remove().appendTo(pilotsAvailableSelected);
    });

    addAllToListBtnPilot.click(function () {
        appendToDest("pilotsAvailable", pilotsAvailableSelected, true);
    });

    remOneFromListBtnPilot.click(function () {
        appendToDest("pilotsAvailableSelected", pilotsAvailable, false);
        //return !$("#pilotsAvailableSelected option:selected").remove().appendTo(pilotsAvailable);
    });

    remAllFromListBtnPilot.click(function () {
        appendToDest("pilotsAvailableSelected", pilotsAvailable, true);
        //return !$("#pilotsAvailableSelected option").remove().appendTo(pilotsAvailable);
    });

    addOneToListBtnSteward.click(function () {
        appendToDest("stewardsAvailable", stewardsAvailableSelected, false);
        //return !$("#stewardsAvailable option:selected").remove().appendTo(stewardsAvailableSelected);
    });

    addAllToListBtnSteward.click(function () {
        appendToDest("stewardsAvailable", stewardsAvailableSelected, true);
        //return !$("#stewardsAvailable option").remove().appendTo(stewardsAvailableSelected);
    });

    remOneFromListBtnSteward.click(function () {
        appendToDest("stewardsAvailableSelected", stewardsAvailable, false);
        //return !$("#stewardsAvailableSelected option:selected").remove().appendTo(stewardsAvailable);
    });

    remAllFromListBtnSteward.click(function () {
        appendToDest("stewardsAvailableSelected", stewardsAvailable, true);
        //return !$("#stewardsAvailableSelected option").remove().appendTo(stewardsAvailable);
    });

    //highlight all items before submit so that all items are sent to controller.
    submitBtn.click(function (e) {
        e.preventDefault();
        $("#pilotsAvailableSelected option").prop("selected", true);
        $("#stewardsAvailableSelected option").prop("selected", true);
        addForm.submit();
    });


    //functions
    //function to append to destination. isAll=true if need to append all.
    function appendToDest(oriSectionStr, appendDest, isAll) {
        if (isAll) {
            return !$("#" + oriSectionStr + " option").remove().appendTo(appendDest);
        } else {
            return !$("#" + oriSectionStr + " option:selected").remove().appendTo(appendDest);
        }
        
    }
});