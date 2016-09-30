

$(document).ready(function () {
   

    $('#testBtn').click(function () {
        var cnt = 4;
        var btn = $(this);
        btn.button('loading');
        setTimeout(function () {
            cnt++;
            btn.button('reset');
            btn.text('  ' + cnt);
        }, 1000);
    });

    $('#testBtnDown').click(function () {
        var cnt = 4;
        var btn = $(this);
        btn.button('loading');
        setTimeout(function () {
            if (cnt > 0) {
                cnt--;
            }
            btn.button('reset');
            btn.text('  ' + cnt);
        }, 1000);
    });

    $(".btn-post-submit")
        .click(function () {

            var newPost = $(".post-new").clone();
            newPost.removeClass("post-new");
            newPost.appendTo(".new-post-placeholder").fadeIn("slow");
            $(".new-post-content").html($(".input-textarea").val());
            $(".new-post-content", newPost).removeClass("new-post-content");
         
            return false;
        });


    //
    //
});

