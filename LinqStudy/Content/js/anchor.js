$(function () {
    $("#toTop").scrollToTop(100);
});
function goTo(m) {
    var mao = $("#" + m); //获得锚点  
    if (mao.length > 0) {//判断对象是否存在  
        var pos = mao.offset().top;
        var poshigh = mao.height();
        $("html,body").animate({ scrollTop: pos - poshigh -80 }, 100);
    }
}