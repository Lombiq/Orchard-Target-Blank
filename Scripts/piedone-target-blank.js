(function ($) {
    $(function () {
        $('a:not(.no-target-blank)').each(
            function () {
                var href = $(this).attr('href');

                if (!href) return;

                // Is outgoing link
                if (!href.match(/^mailto\:/) && (this.hostname != location.hostname)) {
                    $(this).click(
                        function () {
                            window.open(this.href);
                            return false;
                        });
                }
            });
    });
})(jQuery);