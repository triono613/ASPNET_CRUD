function fnInsert() {

    var nmBarang = $('nmBarang').val();
    var qtyBarang = $('qtyBarang').val();



    $.ajax({

        type: "post",
        url: "/Home/insertBarang/",
        dataType: "json",
        contentType: "application/json: charset-utf-8",
        data: JSON.stringify({
                nmBarang: nmBarang, qtyBarang: qtyBarang
            }),
        success: function (json) {
            console.log(json);
        },
        failure: function (errMsg) {
            alert(errMsg);
        }

    })



}