$(document).ready(function () {

    $("#btnJsTestPost").click(function () {

        let nowIso = (new Date()).toISOString();

        let telegram = {
            ID: "id" + nowIso,
            //Posted: nowIso,
            Msg: "Halloooooo"
        }

        $.ajax({
            method: "POST",
            //dataType: "json",
            url: "/api/SimpleTelegram",
            data: telegram,
            cache: false
        }).done(function (Data, status, req) {

            alert(Data.RandomValue.toString());

        }).fail(function (jqXHR, textStatus, errorThrown) {

            // Leider ein Fehler
            console.log(jqXHR.status.toString());
            alert(jqXHR.status.toString());
        });
    });



    function RefreshLogTab() {
        $.ajaxSetup({ cache: false });
        $("#LogTab").load("/Home/LogTab", setTimeout(RefreshLogTab, 1000));
    }

    RefreshLogTab();
    
});