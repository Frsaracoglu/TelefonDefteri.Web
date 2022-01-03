(function ($) {

    "use strict";

    var fullHeight = function () {

        $('.js-fullheight').css('height', $(window).height());
        $(window).resize(function () {
            $('.js-fullheight').css('height', $(window).height());
        });

    };
    fullHeight();

    $('#sidebarCollapse').on('click', function () {
        $('#sidebar').toggleClass('active');
    });


    /*kişi listesi silme*/
    $(".deleteRecord").on("click", function () {
        var ListId = $(this).data("model-id");
        var url = "/phoneList/ListDelete/" + ListId;
        $.ajax({
            url: url,
            type: "POST",
            success: function (gelenveri) {
                Swal.fire({
                    title: gelenveri,
                    icon: 'success'
                }).then(function (neyeBasildi) {
                    location.reload()
                })
            },
            error: function (error) {
                console.log(error.status)
            }
        })
    });


    ///*Kullanıcı kişi listesi güncelleme*/
    $(".updateRecord").on("click", function () {
        var $form = $("#updatePhoneList")
        var name = $form.find("#Name").val()
        var lastName = $form.find("#LastName").val()
        var eMail = $form.find("#EMail").val()
        var status = $form.find("#Status").val()
        var listId = $form.find("#ListId").val()

        var url = "/phoneList/UpdatePhoneList/" + ListId;
        $.ajax({
            url: url,
            type: "POST",
            data: { name: name, lastName: lastName, eMail: eMail, status: status, listId: listId },
            success: function (gelenveri) {
                Swal.fire({
                    title: gelenveri,
                    icon: 'success'
                }).then(function (neyeBasildi) {
                    window.location = "/phoneList/index/";
                })
            },
            error: function (error) {
                Swal.fire({
                    title: error,
                    icon: 'error'
                })
            }
        })
    });


    /*Kullanıcı güncelleme*/
    $(".updateUserRecord").on("click", function () {
        var $form = $("#updateUser")
        var name = $form.find("#Name").val()
        var lastName = $form.find("#LastName").val()
        var eMail = $form.find("#Email").val()
        var password = $form.find("#Password").val()
        var userId = $form.find("#UserId").val()
        var url = "/settings/UpdateUser/" + UserId;
        $.ajax({
            url: url,
            type: "POST",
            data: { name: name, lastName: lastName, eMail: eMail, password: password, userId: userId },
            success: function (gelenveri) {
                Swal.fire({
                    title: gelenveri,
                    icon: 'success'
                })
            },
            error: function (error) {
                Swal.fire({
                    title: error,
                    icon: 'error'
                })
            }
        })
    });

    /* Arama kayıtları detay tablosunu açmak*/
    $(document).ready(function () {
        $(".open").on("click", function (e) {
            if ($(this).closest("tr").next().css("display") == "none") {
                $(this).closest("tr").next().css("display", "table-row");
                $(this).find("i").addClass("fa-minus").removeClass("fa-plus")
                var listId = $(this).closest("tr").attr("data-id");
                var url = "/CallLog/GetCallListDetail/";
                $.ajax({
                    url: url,
                    type: "POST",
                    data: { listId: listId },
                    success: function (gelenveri) {
                        var newRowContent = "";
                        for (var i = 0; i < gelenveri.length; i++) {
                            newRowContent += "<tr role='row'><td>" + gelenveri[i].callDate + "</td><td>" + gelenveri[i].callResult+ "</td></tr >";
                        }
                        $("#table-detail tbody").append(newRowContent);

                    },
                    error: function (error) {
                        Swal.fire({
                            title: error,
                            icon: 'error'
                        })
                    }
                })
            } else {
                $(this).closest("tr").next().css("display", "none");
                $(this).find("i").addClass("fa-plus").removeClass("fa-minus");
                $("#table-detail tbody tr").remove();
            }

            //$(".clTableDetail").slideToggle();
        });
    });

    /*Geri dön*/
    $(".goBack").on("click", function (e) {
        e.preventDefault();
        window.history.back();
    });

})(jQuery);
