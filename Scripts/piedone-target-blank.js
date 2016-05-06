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
                            var newWindow = window.open(this.href);

                            // Preventing that a malicious target site could change the opening window's URL, see:
                            // https://mathiasbynens.github.io/rel-noopener/
                            newWindow.opener = null;

                            return false;
                        });
                }
            });
    });
})(jQuery);