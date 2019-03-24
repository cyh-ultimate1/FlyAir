
$(function () {
    //========= variables
    var OriginCountryID = $("#OriginCountryID");
    var DestCountryID = $("#DestCountryID");
    var originCitySelect = $("#originCitySelect");
    var destCitySelect = $("#destCitySelect");

    //========= implementation

    //get city for origin country
    OriginCountryID.change(function () {
        getCityByCountryId($(this).val(), originCitySelect);
    });

    //get city for dest country
    DestCountryID.change(function () {
        getCityByCountryId($(this).val(), destCitySelect);
    });



    //========= functions
    function getCityByCountryId(countryId, selectItems) {
        $.ajax({
            url: "GetCityByCountryId",
            type: "GET",
            contentType: "application/json; charset=utf-8;",
            dataType: "json",
            data: {
                reqData: countryId
            },
            success: function (respData) {
                //var jsonObj = $.parseJSON(respData);
                selectItems.children().remove();
                $.each(respData, function (idx, obj) {
                    selectItems.append(
                        '<option value="' + obj.id + '">' + obj.city +
                        '</option >');
                });
            },
            error: function () {
                alert("error in getCityByCountryId");
            }
        });
    }
});