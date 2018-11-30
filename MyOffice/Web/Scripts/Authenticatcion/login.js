$(function () {
    $("body").keydown(function () {
        if (event.keyCode == "13") {//keyCode=13是回车键
            $('.btnLogin').click();
        }
    });

    $('.btnLogin').click(function () {
        $.ajax({
            url: '/Authentication/CheckUser',
            type: 'post',
            data: $('#login_form').serialize(),
            success: function (data) {
                if (eval(data.state)) {
                    document.location.href = '/Home/Index';
                } else if (data.state == '0') {
                    $('#msg').html(data.message);
                    $('#msg').show().delay(1000).fadeOut();
                }
            }
        })
    });
});