(function ($) {
    $("#input-text").on("keyup", function () {
        $("#input-text").on("keyup", function () {
            var value = $(this).val().toLowerCase();
            value=value.trim();
            $("h5").filter(function () {
                $(this).parents(".card").toggle($(this).text().toLowerCase().indexOf(value) > -1);
            });
        });
    });
})(jQuery);