var nowPage = 1;

$(function () {
    $('.pageGroup').click(function () {
        let index = $(this).html();
        if (index == nowPage) { return; }
        PageActive(index);
    })
})

function PageActive(this_e) {
    $('.pageGroup').removeClass('pageActive');
    let pgroup = $('.pageGroup');
    nowPage = this_e;

    if ((parseInt(this_e - 2) > 0) && (parseInt(this_e) + 2) <= total) {
        let first = parseInt(this_e - 2);
        for (var i = 0; i < pgroup.length; i++) {
            pgroup[i].innerText = first + i;
        }
        $(pgroup[2]).addClass('pageActive');
    } else if (this_e < 3) {
        for (var i = 0; i < pgroup.length; i++) {
            pgroup[i].innerText = i + 1;
        }
        $(pgroup[this_e - 1]).addClass('pageActive');
    } else if (this_e == (total - 1)) {
        let f = total - (pgroup.length - 1);
        for (var i = 0; i < pgroup.length; i++) {
            pgroup[i].innerText = f + i;
        }
        $(pgroup[pgroup.length - 2]).addClass('pageActive');
    } else {
        $(pgroup[pgroup.length - 1]).addClass('pageActive');
    }

    if (m_url != '') {
        $.ajax({
            url: m_url,
            type: 'post',
            data: {
                index: nowPage - 1
            },
            success: function (data) {
                $('#deplist').html(data);
            }
        });
    }
}

function btnPage(name) {
    if (name == 'Up') {
        if (nowPage > 1) { nowPage--; } else { return; }
    } else if (name == 'Down') {
        if (parseInt(nowPage) < total) {
            nowPage++;
        } else {
            return;
        }
    }
    PageActive(nowPage);
}