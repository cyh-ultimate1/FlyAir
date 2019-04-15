
$(function () {
    //================ variables
    var previousCheckedGo = $(this), previousCheckedRet = $(this);  //just dummy assignment to prevent error. This var used to save previously checked item
    var tblRowHighlightStr = "tblRowHighlight";
    var tblRowGoStr = "tblRowGo", tblRowRetStr = "tblRowRet";
    var submitBtn = $("#submitBtn");
    var oneIdSelGoRadio = $("input[name='oneIdSelGo']");
    var oneIdSelRetRadio = $("input[name='oneIdSelRet']");
    var goFlightErr = $("#goFlightErr");
    var retFlightErr = $("#retFlightErr");
    var success = true;
    var goSlider = $('.goSlider'), retSlider = $('.retSlider');
    var goFlightResults = $("#goFlightResults");
    var retFlightResults = $("#retFlightResults");
    

    //============== implementation

    //start signalR connection to hub
    var connection = new signalR.HubConnectionBuilder().withUrl("/bookingHub").build();
    connection.start().then(e => {
        //alert("connection started");
    });

    //whenever a new booking is made and added to DB, a notification will be triggered.
    connection.on("subsNewAdd", function (respData) {
        document.getElementById("myPopup").classList.toggle("show");
        var counter = 10;
        setInterval(function () {
            counter--;
            if (counter < 0) {
                $("#myPopup").hide();
            } else {
                //countDown.text(counter.toString());
            }
        }, 1000); 
    });

    //initialize slick for goFlight and return Flight
    initSlick(goSlider);
    initSlick(retSlider);

    goFlightResults.on("change", ".oneIdSelGo", function () {
        //check if checkbox is checked.
        if ($(this).is(':checked')) {
            previousCheckedGo = HighlightSelection(previousCheckedGo, "." + tblRowGoStr, $(this));
        }
    });

    retFlightResults.on("change", ".oneIdSelRet", function () {
        //check if checkbox is checked.
        if ($(this).is(':checked')) {
            previousCheckedRet = HighlightSelection(previousCheckedRet, "." + tblRowRetStr, $(this));
        }
    });

    submitBtn.click(function (e) {
        e.preventDefault();
        success = true;
        //check if go Flight is not selected. Display error if not selected. Else, error text remain blank
        if (!$("input[name='oneIdSelGo']:checked").val()) {
            goFlightErr.text("");
            goFlightErr.append("Please select a flight");
            success = false;
        } else {
            goFlightErr.text("");
        }

        //check if return Flight is not selected if return Flight exists. Display error if not selected. Else, error text remain blank.
        if (oneIdSelRetRadio.length && !$("input[name='oneIdSelRet']:checked").val()) {
            retFlightErr.text("");
            $("#retFlightErr").append("Please select a flight");
            success = false;
        } else {
            retFlightErr.text("");
        }

        //if condiftions fulfilled, submit form.
        if (success) {
            $("#formPost").submit();
        }
    });

    

    //============== functions
    // to highlight the table row selected.
    function HighlightSelection(previousChecked, tblRow, thisSelector) {
        //remove previously checked item.
        previousChecked.removeClass(tblRowHighlightStr);
        previousChecked = thisSelector.parentsUntil(tblRow).parent();
        //highlight the current selected item.
        previousChecked.addClass(tblRowHighlightStr);

        return previousChecked;
    }

    function initSlick(el) {
        el.slick({
            infinite: false,
            //dots: true,
            arrows: true,
            slidesToShow: 5,
            slidesToScroll: 5,
            initialSlide: 7,
            centerMode: true,
            //asNavFor: '.modalSlider',
            responsive: [
                {
                    breakpoint: 1024,
                    settings: {
                        slidesToShow: 3,
                        slidesToScroll: 3,
                        infinite: true
                    }
                },
                {
                    breakpoint: 600,
                    settings: {
                        slidesToShow: 2,
                        slidesToScroll: 2
                    }
                },
                {
                    breakpoint: 480,
                    settings: {
                        slidesToShow: 1,
                        slidesToScroll: 1
                    }
                }
                // You can unslick at a given breakpoint now by adding:
                // settings: "unslick"
                // instead of a settings object
            ]
        });
    }


});