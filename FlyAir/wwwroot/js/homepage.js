
$(function () {
    /*=== variables ===*/
    var originId = $("input[name='OriginID']");
    var destId = $("input[name='DestID']");
    var originInput = $("#originInput");
    var destInput = $("#destInput");
    var WaySelection = $("input[name='WaySelection']");
    var returnDateGrp = $("#returnDateGrp");
    var searchForm = $("#searchForm");
    var submitBtn = $("#submitBtn");
    var AdultNum = $("input[name='AdultNum']");
    var GoDate = $("#DepartDate");
    var ReturnDate = $("#ReturnDate");


    

    /*=== implementation ===*/
    //set a default date for inpue type date
    $("input[type=date]").datepicker({
        minDate: new Date(),
        dateFormat: "dd/mm/yy"
    });
    $('input[type="date"]').attr('type', 'text');

    
    //this function to prevent 'Enter' key, so that the form does not submit invalid input
    $(window).keydown(function (event) {
        if (event.keyCode === 13) {
            event.preventDefault();
            return false;
        }
    });

    //makes sure the return date is always same or later than Go date
    GoDate.change(function () {
        ReturnDate.val(GoDate.val());
        ReturnDate.datepicker("option", "minDate", GoDate.val());
    });
    
    //set autocomplete for the location inputs
    getSearchLoc(originInput, originId);
    getSearchLoc(destInput, destId);

    //to determine whether to hide return date if one way is selected
    WaySelection.change(function () {
        if ($(this).val() === '1') {
            returnDateGrp.hide();
        } else {
            returnDateGrp.show();
        }
    });

    //when SUBMIT button is clicked, validate all inputs before submit.
    submitBtn.click(function (e) {
        e.preventDefault();
        $("input").css("border-color", "rgb(183, 205, 229)");
        var success = true;
        //check individual input
        if (originInput.val() === "") {
            validationBorderRed(originInput);
            success = false;
        }
        if (destInput.val() === "") {
            validationBorderRed(destInput);
            success = false;
        }
        if (AdultNum.val() <= 0) {
            validationBorderRed(AdultNum);
            success = false;
        }

        //if not two way, nullify return date input.
        if ($("input[name='WaySelection']:checked").val() === '1') {
            ReturnDate.val(null);
        }

        //check conclusion
        if (success) {
            searchForm.submit();
        } 
    });


    /*=== functions ===*/
    //autocomplete JQuery UI 
    function getSearchLoc (elSel, hiddenInputSel) {
        elSel.autocomplete({
            source: function (request, response) {
                $.ajax({
                    url: "Country/GetSearchLocation",
                    type: "GET",
                    //contentType: "application/json; charset=utf-8;",
                    data: {
                        reqData: request.term
                    },
                    dataType: "json",
                    success: function (respData) {
                        //alert(respData);
                        response($.map(respData, function (item) {
                            return {
                                label: item.city + ', ' + item.countryName,
                                value: item.id
                            };
                        }));
                    },
                    error: function () {
                        alert("error in search!");
                    }
                });
            },
            select: function (event, ui) {
                event.preventDefault();
                elSel.val(ui.item.label);
                hiddenInputSel.val(ui.item.value);
                //alert(hiddenInputSel.val());
            },
            autoFocus: true,
            change: function (event, ui) {
                if (!ui.item || ui.item === null) {
                    //http://api.jqueryui.com/autocomplete/#event-change -
                    // The item selected from the menu, if any. Otherwise the property is null
                    //so clear the item for force selection
                    originInput.val("");
                    destInput.val("");
                }
            }
        });
    }

    //input validation => border colour red
    function validationBorderRed(el) {
        el.css("border-color", "red");
    }

    //new method for Date to convert to Datepicker format
    Date.prototype.convertDatepickerFormat = function () {
        var yyyy = this.getFullYear().toString();
        var mm = (this.getMonth() + 1).toString(); // getMonth() is zero-based
        var dd = this.getDate().toString();
        return yyyy + "-" + (mm[1] ? mm : "0" + mm[0]) + "-" + (dd[1] ? dd : "0" + dd[0]); // padding
    };
    //var goDatepicker = new Date();
    //var returnDatepicker = new Date();
    ////returnDatepicker.setDate(goDatepicker.getDate() + 1);

    //GoDate.attr("min", goDatepicker.convertDatepickerFormat());
    //ReturnDate.attr("min", returnDatepicker.convertDatepickerFormat());
    
});

/*------- Swiper Slider -------*/
var loopVar = false;
var swiper = new Swiper('.swiper-container', {
    pagination: {
        el: '.swiper-pagination',
        type: 'bullets',
        clickable: true
    },
    paginationClickable: true,
    centeredSlides: true,
    autoplay: {
        delay: 3000
    },
    speed: 1500,
    //disable loop if play video only
    loop: loopVar,
    autoplayDisableOnInteraction: false,
    navigation: {
        nextEl: '.swiper-button-next',
        prevEl: '.swiper-button-prev'
    }
});