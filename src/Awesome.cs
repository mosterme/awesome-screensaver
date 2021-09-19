using System.Collections.Generic;
using System.Linq;
using System;
namespace awesomescr
{
    public class Awesome
    {
        private static Random random = new Random();
        public static string version = "Font Awesome v4.7";
        public static string next() {
            int i = data.ElementAt(random.Next(data.Count)).Key;
            return Char.ConvertFromUtf32(i);
        }
        public static string info(String key) {
            int i = Char.ConvertToUtf32(key,0);
            return version + " : " + data[i];
        }
        private static Dictionary<int, string> data = new Dictionary<int, string>() {
        {0xf000,"fa-glass"},
        {0xf001,"fa-music"},
        {0xf002,"fa-search"},
        {0xf003,"fa-envelope-o"},
        {0xf004,"fa-heart"},
        {0xf005,"fa-star"},
        {0xf006,"fa-star-o"},
        {0xf007,"fa-user"},
        {0xf008,"fa-film"},
        {0xf009,"Text Editor Icons : fa-th-large"},
        {0xf00a,"Text Editor Icons : fa-th"},
        {0xf00b,"Text Editor Icons : fa-th-list"},
        {0xf00c,"fa-check"},
        {0xf00d,"fa-times"},
        {0xf00e,"fa-search-plus"},
        {0xf010,"fa-search-minus"},
        {0xf011,"fa-power-off"},
        {0xf012,"fa-signal"},
        {0xf013,"Spinner Icons : fa-cog"},
        {0xf014,"fa-trash-o"},
        {0xf015,"fa-home"},
        {0xf016,"File Type Icons : fa-file-o"},
        {0xf017,"fa-clock-o"},
        {0xf018,"fa-road"},
        {0xf019,"fa-download"},
        {0xf01a,"Directional Icons : fa-arrow-circle-o-down"},
        {0xf01b,"Directional Icons : fa-arrow-circle-o-up"},
        {0xf01c,"fa-inbox"},
        {0xf01d,"Video Player Icons : fa-play-circle-o"},
        {0xf01e,"Text Editor Icons : fa-repeat"},
        {0xf021,"Spinner Icons : fa-refresh"},
        {0xf022,"Text Editor Icons : fa-list-alt"},
        {0xf023,"fa-lock"},
        {0xf024,"fa-flag"},
        {0xf025,"fa-headphones"},
        {0xf026,"fa-volume-off"},
        {0xf027,"fa-volume-down"},
        {0xf028,"fa-volume-up"},
        {0xf029,"fa-qrcode"},
        {0xf02a,"fa-barcode"},
        {0xf02b,"fa-tag"},
        {0xf02c,"fa-tags"},
        {0xf02d,"fa-book"},
        {0xf02e,"fa-bookmark"},
        {0xf02f,"fa-print"},
        {0xf030,"fa-camera"},
        {0xf031,"Text Editor Icons : fa-font"},
        {0xf032,"Text Editor Icons : fa-bold"},
        {0xf033,"Text Editor Icons : fa-italic"},
        {0xf034,"Text Editor Icons : fa-text-height"},
        {0xf035,"Text Editor Icons : fa-text-width"},
        {0xf036,"Text Editor Icons : fa-align-left"},
        {0xf037,"Text Editor Icons : fa-align-center"},
        {0xf038,"Text Editor Icons : fa-align-right"},
        {0xf039,"Text Editor Icons : fa-align-justify"},
        {0xf03a,"Text Editor Icons : fa-list"},
        {0xf03b,"Text Editor Icons : fa-outdent"},
        {0xf03c,"Text Editor Icons : fa-indent"},
        {0xf03d,"fa-video-camera"},
        {0xf03e,"fa-picture-o"},
        {0xf040,"fa-pencil"},
        {0xf041,"fa-map-marker"},
        {0xf042,"fa-adjust"},
        {0xf043,"fa-tint"},
        {0xf044,"fa-pencil-square-o"},
        {0xf045,"fa-share-square-o"},
        {0xf046,"Form Control Icons : fa-check-square-o"},
        {0xf047,"Directional Icons : fa-arrows"},
        {0xf048,"Video Player Icons : fa-step-backward"},
        {0xf049,"Video Player Icons : fa-fast-backward"},
        {0xf04a,"Video Player Icons : fa-backward"},
        {0xf04b,"Video Player Icons : fa-play"},
        {0xf04c,"Video Player Icons : fa-pause"},
        {0xf04d,"Video Player Icons : fa-stop"},
        {0xf04e,"Video Player Icons : fa-forward"},
        {0xf050,"Video Player Icons : fa-fast-forward"},
        {0xf051,"Video Player Icons : fa-step-forward"},
        {0xf052,"Video Player Icons : fa-eject"},
        {0xf053,"Directional Icons : fa-chevron-left"},
        {0xf054,"Directional Icons : fa-chevron-right"},
        {0xf055,"fa-plus-circle"},
        {0xf056,"fa-minus-circle"},
        {0xf057,"fa-times-circle"},
        {0xf058,"fa-check-circle"},
        {0xf059,"fa-question-circle"},
        {0xf05a,"fa-info-circle"},
        {0xf05b,"fa-crosshairs"},
        {0xf05c,"fa-times-circle-o"},
        {0xf05d,"fa-check-circle-o"},
        {0xf05e,"fa-ban"},
        {0xf060,"Directional Icons : fa-arrow-left"},
        {0xf061,"Directional Icons : fa-arrow-right"},
        {0xf062,"Directional Icons : fa-arrow-up"},
        {0xf063,"Directional Icons : fa-arrow-down"},
        {0xf064,"fa-share"},
        {0xf065,"Video Player Icons : fa-expand"},
        {0xf066,"Video Player Icons : fa-compress"},
        {0xf067,"fa-plus"},
        {0xf068,"fa-minus"},
        {0xf069,"fa-asterisk"},
        {0xf06a,"fa-exclamation-circle"},
        {0xf06b,"fa-gift"},
        {0xf06c,"fa-leaf"},
        {0xf06d,"fa-fire"},
        {0xf06e,"fa-eye"},
        {0xf070,"fa-eye-slash"},
        {0xf071,"fa-exclamation-triangle"},
        {0xf072,"Transportation Icons : fa-plane"},
        {0xf073,"fa-calendar"},
        {0xf074,"Video Player Icons : fa-random"},
        {0xf075,"fa-comment"},
        {0xf076,"fa-magnet"},
        {0xf077,"Directional Icons : fa-chevron-up"},
        {0xf078,"Directional Icons : fa-chevron-down"},
        {0xf079,"fa-retweet"},
        {0xf07a,"fa-shopping-cart"},
        {0xf07b,"fa-folder"},
        {0xf07c,"fa-folder-open"},
        {0xf07d,"Directional Icons : fa-arrows-v"},
        {0xf07e,"Directional Icons : fa-arrows-h"},
        {0xf080,"Chart Icons : fa-bar-chart"},
        {0xf081,"Brand Icons : fa-twitter-square"},
        {0xf082,"Brand Icons : fa-facebook-square"},
        {0xf083,"fa-camera-retro"},
        {0xf084,"fa-key"},
        {0xf085,"fa-cogs"},
        {0xf086,"fa-comments"},
        {0xf087,"Hand Icons : fa-thumbs-o-up"},
        {0xf088,"Hand Icons : fa-thumbs-o-down"},
        {0xf089,"fa-star-half"},
        {0xf08a,"fa-heart-o"},
        {0xf08b,"fa-sign-out"},
        {0xf08c,"Brand Icons : fa-linkedin-square"},
        {0xf08d,"fa-thumb-tack"},
        {0xf08e,"fa-external-link"},
        {0xf090,"fa-sign-in"},
        {0xf091,"fa-trophy"},
        {0xf092,"Brand Icons : fa-github-square"},
        {0xf093,"fa-upload"},
        {0xf094,"fa-lemon-o"},
        {0xf095,"fa-phone"},
        {0xf096,"Form Control Icons : fa-square-o"},
        {0xf097,"fa-bookmark-o"},
        {0xf098,"fa-phone-square"},
        {0xf099,"Brand Icons : fa-twitter"},
        {0xf09a,"Brand Icons : fa-facebook"},
        {0xf09b,"Brand Icons : fa-github"},
        {0xf09c,"fa-unlock"},
        {0xf09d,"Payment Icons : fa-credit-card"},
        {0xf09e,"fa-rss"},
        {0xf0a0,"fa-hdd-o"},
        {0xf0a1,"fa-bullhorn"},
        {0xf0a2,"fa-bell-o"},
        {0xf0a3,"fa-certificate"},
        {0xf0a4,"Hand Icons : fa-hand-o-right"},
        {0xf0a5,"Hand Icons : fa-hand-o-left"},
        {0xf0a6,"Hand Icons : fa-hand-o-up"},
        {0xf0a7,"Hand Icons : fa-hand-o-down"},
        {0xf0a8,"Directional Icons : fa-arrow-circle-left"},
        {0xf0a9,"Directional Icons : fa-arrow-circle-right"},
        {0xf0aa,"Directional Icons : fa-arrow-circle-up"},
        {0xf0ab,"Directional Icons : fa-arrow-circle-down"},
        {0xf0ac,"fa-globe"},
        {0xf0ad,"fa-wrench"},
        {0xf0ae,"fa-tasks"},
        {0xf0b0,"fa-filter"},
        {0xf0b1,"fa-briefcase"},
        {0xf0b2,"Video Player Icons : fa-arrows-alt"},
        {0xf0c0,"fa-users"},
        {0xf0c1,"fa-link"},
        {0xf0c2,"fa-cloud"},
        {0xf0c3,"fa-flask"},
        {0xf0c4,"Text Editor Icons : fa-scissors"},
        {0xf0c5,"Text Editor Icons : fa-files-o"},
        {0xf0c6,"Text Editor Icons : fa-paperclip"},
        {0xf0c7,"Text Editor Icons : fa-floppy-o"},
        {0xf0c8,"Form Control Icons : fa-square"},
        {0xf0c9,"fa-bars"},
        {0xf0ca,"Text Editor Icons : fa-list-ul"},
        {0xf0cb,"Text Editor Icons : fa-list-ol"},
        {0xf0cc,"Text Editor Icons : fa-strikethrough"},
        {0xf0cd,"Text Editor Icons : fa-underline"},
        {0xf0ce,"Text Editor Icons : fa-table"},
        {0xf0d0,"fa-magic"},
        {0xf0d1,"Transportation Icons : fa-truck"},
        {0xf0d2,"Brand Icons : fa-pinterest"},
        {0xf0d3,"Brand Icons : fa-pinterest-square"},
        {0xf0d4,"Brand Icons : fa-google-plus-square"},
        {0xf0d5,"Brand Icons : fa-google-plus"},
        {0xf0d6,"Currency Icons : fa-money"},
        {0xf0d7,"Directional Icons : fa-caret-down"},
        {0xf0d8,"Directional Icons : fa-caret-up"},
        {0xf0d9,"Directional Icons : fa-caret-left"},
        {0xf0da,"Directional Icons : fa-caret-right"},
        {0xf0db,"Text Editor Icons : fa-columns"},
        {0xf0dc,"fa-sort"},
        {0xf0dd,"fa-sort-desc"},
        {0xf0de,"fa-sort-asc"},
        {0xf0e0,"fa-envelope"},
        {0xf0e1,"fa-linkedin"},
        {0xf0e2,"Text Editor Icons : fa-undo"},
        {0xf0e3,"fa-gavel"},
        {0xf0e4,"fa-tachometer"},
        {0xf0e5,"fa-comment-o"},
        {0xf0e6,"fa-comments-o"},
        {0xf0e7,"fa-bolt"},
        {0xf0e8,"fa-sitemap"},
        {0xf0e9,"fa-umbrella"},
        {0xf0ea,"Text Editor Icons : fa-clipboard"},
        {0xf0eb,"fa-lightbulb-o"},
        {0xf0ec,"fa-exchange"},
        {0xf0ed,"fa-cloud-download"},
        {0xf0ee,"fa-cloud-upload"},
        {0xf0f0,"fa-user-md"},
        {0xf0f1,"fa-stethoscope"},
        {0xf0f2,"fa-suitcase"},
        {0xf0f3,"fa-bell"},
        {0xf0f4,"fa-coffee"},
        {0xf0f5,"fa-cutlery"},
        {0xf0f6,"File Type Icons : fa-file-text-o"},
        {0xf0f7,"fa-building-o"},
        {0xf0f8,"fa-hospital-o"},
        {0xf0f9,"Transportation Icons : fa-ambulance"},
        {0xf0fa,"fa-medkit"},
        {0xf0fb,"Transportation Icons : fa-fighter-jet"},
        {0xf0fc,"fa-beer"},
        {0xf0fd,"fa-h-square"},
        {0xf0fe,"Form Control Icons : fa-plus-square"},
        {0xf100,"Directional Icons : fa-angle-double-left"},
        {0xf101,"Directional Icons : fa-angle-double-right"},
        {0xf102,"Directional Icons : fa-angle-double-up"},
        {0xf103,"Directional Icons : fa-angle-double-down"},
        {0xf104,"Directional Icons : fa-angle-left"},
        {0xf105,"Directional Icons : fa-angle-right"},
        {0xf106,"Directional Icons : fa-angle-up"},
        {0xf107,"Directional Icons : fa-angle-down"},
        {0xf108,"fa-desktop"},
        {0xf109,"fa-laptop"},
        {0xf10a,"fa-tablet"},
        {0xf10b,"fa-mobile"},
        {0xf10c,"Form Control Icons : fa-circle-o"},
        {0xf10d,"fa-quote-left"},
        {0xf10e,"fa-quote-right"},
        {0xf110,"Spinner Icons : fa-spinner"},
        {0xf111,"Form Control Icons : fa-circle"},
        {0xf112,"fa-reply"},
        {0xf113,"Brand Icons : fa-github-alt"},
        {0xf114,"fa-folder-o"},
        {0xf115,"fa-folder-open-o"},
        {0xf118,"fa-smile-o"},
        {0xf119,"fa-frown-o"},
        {0xf11a,"fa-meh-o"},
        {0xf11b,"fa-gamepad"},
        {0xf11c,"fa-keyboard-o"},
        {0xf11d,"fa-flag-o"},
        {0xf11e,"fa-flag-checkered"},
        {0xf120,"fa-terminal"},
        {0xf121,"fa-code"},
        {0xf122,"fa-reply-all"},
        {0xf123,"fa-star-half-o"},
        {0xf124,"fa-location-arrow"},
        {0xf125,"fa-crop"},
        {0xf126,"fa-code-fork"},
        {0xf127,"Text Editor Icons : fa-chain-broken"},
        {0xf128,"fa-question"},
        {0xf129,"fa-info"},
        {0xf12a,"fa-exclamation"},
        {0xf12b,"Text Editor Icons : fa-superscript"},
        {0xf12c,"Text Editor Icons : fa-subscript"},
        {0xf12d,"Text Editor Icons : fa-eraser"},
        {0xf12e,"fa-puzzle-piece"},
        {0xf130,"fa-microphone"},
        {0xf131,"fa-microphone-slash"},
        {0xf132,"fa-shield"},
        {0xf133,"fa-calendar-o"},
        {0xf134,"fa-fire-extinguisher"},
        {0xf135,"Transportation Icons : fa-rocket"},
        {0xf136,"Brand Icons : fa-maxcdn"},
        {0xf137,"Directional Icons : fa-chevron-circle-left"},
        {0xf138,"Directional Icons : fa-chevron-circle-right"},
        {0xf139,"Directional Icons : fa-chevron-circle-up"},
        {0xf13a,"Directional Icons : fa-chevron-circle-down"},
        {0xf13b,"Brand Icons : fa-html5"},
        {0xf13c,"Brand Icons : fa-css3"},
        {0xf13d,"fa-anchor"},
        {0xf13e,"fa-unlock-alt"},
        {0xf140,"fa-bullseye"},
        {0xf141,"fa-ellipsis-h"},
        {0xf142,"fa-ellipsis-v"},
        {0xf143,"fa-rss-square"},
        {0xf144,"Video Player Icons : fa-play-circle"},
        {0xf145,"fa-ticket"},
        {0xf146,"Form Control Icons : fa-minus-square"},
        {0xf147,"Form Control Icons : fa-minus-square-o"},
        {0xf148,"fa-level-up"},
        {0xf149,"fa-level-down"},
        {0xf14a,"Form Control Icons : fa-check-square"},
        {0xf14b,"fa-pencil-square"},
        {0xf14c,"fa-external-link-square"},
        {0xf14d,"fa-share-square"},
        {0xf14e,"fa-compass"},
        {0xf150,"Directional Icons : fa-caret-square-o-down"},
        {0xf151,"Directional Icons : fa-caret-square-o-up"},
        {0xf152,"Directional Icons : fa-caret-square-o-right"},
        {0xf153,"Currency Icons : fa-eur"},
        {0xf154,"Currency Icons : fa-gbp"},
        {0xf155,"Currency Icons : fa-usd"},
        {0xf156,"Currency Icons : fa-inr"},
        {0xf157,"Currency Icons : fa-jpy"},
        {0xf158,"Currency Icons : fa-rub"},
        {0xf159,"Currency Icons : fa-krw"},
        {0xf15a,"Currency Icons : fa-btc"},
        {0xf15b,"File Type Icons : fa-file"},
        {0xf15c,"File Type Icons : fa-file-text"},
        {0xf15d,"fa-sort-alpha-asc"},
        {0xf15e,"fa-sort-alpha-desc"},
        {0xf160,"fa-sort-amount-asc"},
        {0xf161,"fa-sort-amount-desc"},
        {0xf162,"fa-sort-numeric-asc"},
        {0xf163,"fa-sort-numeric-desc"},
        {0xf164,"Hand Icons : fa-thumbs-up"},
        {0xf165,"Hand Icons : fa-thumbs-down"},
        {0xf166,"Brand Icons : fa-youtube-square"},
        {0xf167,"Brand Icons : fa-youtube"},
        {0xf168,"Brand Icons : fa-xing"},
        {0xf169,"Brand Icons : fa-xing-square"},
        {0xf16a,"Brand Icons : fa-youtube-play"},
        {0xf16b,"Brand Icons : fa-dropbox"},
        {0xf16c,"Brand Icons : fa-stack-overflow"},
        {0xf16d,"Brand Icons : fa-instagram"},
        {0xf16e,"Brand Icons : fa-flickr"},
        {0xf170,"Brand Icons : fa-adn"},
        {0xf171,"Brand Icons : fa-bitbucket"},
        {0xf172,"Brand Icons : fa-bitbucket-square"},
        {0xf173,"Brand Icons : fa-tumblr"},
        {0xf174,"Brand Icons : fa-tumblr-square"},
        {0xf175,"Directional Icons : fa-long-arrow-down"},
        {0xf176,"Directional Icons : fa-long-arrow-up"},
        {0xf177,"Directional Icons : fa-long-arrow-left"},
        {0xf178,"Directional Icons : fa-long-arrow-right"},
        {0xf179,"Brand Icons : fa-apple"},
        {0xf17a,"Brand Icons : fa-windows"},
        {0xf17b,"Brand Icons : fa-android"},
        {0xf17c,"Brand Icons : fa-linux"},
        {0xf17d,"Brand Icons : fa-dribbble"},
        {0xf17e,"Brand Icons : fa-skype"},
        {0xf180,"Brand Icons : fa-foursquare"},
        {0xf181,"Brand Icons : fa-trello"},
        {0xf182,"fa-female"},
        {0xf183,"fa-male"},
        {0xf184,"fa-gratipay"},
        {0xf185,"fa-sun-o"},
        {0xf186,"fa-moon-o"},
        {0xf187,"fa-archive"},
        {0xf188,"fa-bug"},
        {0xf189,"Brand Icons : fa-vk"},
        {0xf18a,"Brand Icons : fa-weibo"},
        {0xf18b,"Brand Icons : fa-renren"},
        {0xf18c,"Brand Icons : fa-pagelines"},
        {0xf18d,"Brand Icons : fa-stack-exchange"},
        {0xf18e,"Directional Icons : fa-arrow-circle-o-right"},
        {0xf190,"Directional Icons : fa-arrow-circle-o-left"},
        {0xf191,"Directional Icons : fa-caret-square-o-left"},
        {0xf192,"Form Control Icons : fa-dot-circle-o"},
        {0xf193,"Accessibility Icons : fa-wheelchair"},
        {0xf194,"Brand Icons : fa-vimeo-square"},
        {0xf195,"Currency Icons : fa-try"},
        {0xf196,"Form Control Icons : fa-plus-square-o"},
        {0xf197,"Transportation Icons : fa-space-shuttle"},
        {0xf198,"Brand Icons : fa-slack"},
        {0xf199,"fa-envelope-square"},
        {0xf19a,"Brand Icons : fa-wordpress"},
        {0xf19b,"Brand Icons : fa-openid"},
        {0xf19c,"fa-university"},
        {0xf19d,"fa-graduation-cap"},
        {0xf19e,"Brand Icons : fa-yahoo"},
        {0xf1a0,"Brand Icons : fa-google"},
        {0xf1a1,"Brand Icons : fa-reddit"},
        {0xf1a2,"Brand Icons : fa-reddit-square"},
        {0xf1a3,"Brand Icons : fa-stumbleupon-circle"},
        {0xf1a4,"Brand Icons : fa-stumbleupon"},
        {0xf1a5,"Brand Icons : fa-delicious"},
        {0xf1a6,"Brand Icons : fa-digg"},
        {0xf1a7,"Brand Icons : fa-pied-piper-pp"},
        {0xf1a8,"Brand Icons : fa-pied-piper-alt"},
        {0xf1a9,"Brand Icons : fa-drupal"},
        {0xf1aa,"Brand Icons : fa-joomla"},
        {0xf1ab,"fa-language"},
        {0xf1ac,"fa-fax"},
        {0xf1ad,"fa-building"},
        {0xf1ae,"fa-child"},
        {0xf1b0,"fa-paw"},
        {0xf1b1,"fa-spoon"},
        {0xf1b2,"fa-cube"},
        {0xf1b3,"fa-cubes"},
        {0xf1b4,"Brand Icons : fa-behance"},
        {0xf1b5,"Brand Icons : fa-behance-square"},
        {0xf1b6,"Brand Icons : fa-steam"},
        {0xf1b7,"Brand Icons : fa-steam-square"},
        {0xf1b8,"fa-recycle"},
        {0xf1b9,"Transportation Icons : fa-car"},
        {0xf1ba,"Transportation Icons : fa-taxi"},
        {0xf1bb,"fa-tree"},
        {0xf1bc,"Brand Icons : fa-spotify"},
        {0xf1bd,"Brand Icons : fa-deviantart"},
        {0xf1be,"Brand Icons : fa-soundcloud"},
        {0xf1c0,"fa-database"},
        {0xf1c1,"File Type Icons : fa-file-pdf-o"},
        {0xf1c2,"File Type Icons : fa-file-word-o"},
        {0xf1c3,"File Type Icons : fa-file-excel-o"},
        {0xf1c4,"File Type Icons : fa-file-powerpoint-o"},
        {0xf1c5,"File Type Icons : fa-file-image-o"},
        {0xf1c6,"File Type Icons : fa-file-archive-o"},
        {0xf1c7,"File Type Icons : fa-file-audio-o"},
        {0xf1c8,"File Type Icons : fa-file-video-o"},
        {0xf1c9,"File Type Icons : fa-file-code-o"},
        {0xf1ca,"Brand Icons : fa-vine"},
        {0xf1cb,"Brand Icons : fa-codepen"},
        {0xf1cc,"Brand Icons : fa-jsfiddle"},
        {0xf1cd,"fa-life-ring"},
        {0xf1ce,"Spinner Icons : fa-circle-o-notch"},
        {0xf1d0,"Brand Icons : fa-rebel"},
        {0xf1d1,"Brand Icons : fa-empire"},
        {0xf1d2,"Brand Icons : fa-git-square"},
        {0xf1d3,"Brand Icons : fa-git"},
        {0xf1d4,"Brand Icons : fa-hacker-news"},
        {0xf1d5,"Brand Icons : fa-tencent-weibo"},
        {0xf1d6,"Brand Icons : fa-qq"},
        {0xf1d7,"Brand Icons : fa-weixin"},
        {0xf1d8,"fa-paper-plane"},
        {0xf1d9,"fa-paper-plane-o"},
        {0xf1da,"fa-history"},
        {0xf1db,"fa-circle-thin"},
        {0xf1dc,"Text Editor Icons : fa-header"},
        {0xf1dd,"Text Editor Icons : fa-paragraph"},
        {0xf1de,"fa-sliders"},
        {0xf1e0,"fa-share-alt"},
        {0xf1e1,"fa-share-alt-square"},
        {0xf1e2,"fa-bomb"},
        {0xf1e3,"fa-futbol-o"},
        {0xf1e4,"Accessibility Icons : fa-tty"},
        {0xf1e5,"fa-binoculars"},
        {0xf1e6,"fa-plug"},
        {0xf1e7,"Brand Icons : fa-slideshare"},
        {0xf1e8,"Brand Icons : fa-twitch"},
        {0xf1e9,"Brand Icons : fa-yelp"},
        {0xf1ea,"fa-newspaper-o"},
        {0xf1eb,"fa-wifi"},
        {0xf1ec,"fa-calculator"},
        {0xf1ed,"Payment Icons : fa-paypal"},
        {0xf1ee,"Payment Icons : fa-google-wallet"},
        {0xf1f0,"Payment Icons : fa-cc-visa"},
        {0xf1f1,"Payment Icons : fa-cc-mastercard"},
        {0xf1f2,"Payment Icons : fa-cc-discover"},
        {0xf1f3,"Payment Icons : fa-cc-amex"},
        {0xf1f4,"Payment Icons : fa-cc-paypal"},
        {0xf1f5,"Payment Icons : fa-cc-stripe"},
        {0xf1f6,"fa-bell-slash"},
        {0xf1f7,"fa-bell-slash-o"},
        {0xf1f8,"fa-trash"},
        {0xf1f9,"fa-copyright"},
        {0xf1fa,"fa-at"},
        {0xf1fb,"fa-eyedropper"},
        {0xf1fc,"fa-paint-brush"},
        {0xf1fd,"fa-birthday-cake"},
        {0xf1fe,"Chart Icons : fa-area-chart"},
        {0xf200,"Chart Icons : fa-pie-chart"},
        {0xf201,"Chart Icons : fa-line-chart"},
        {0xf202,"Brand Icons : fa-lastfm"},
        {0xf203,"Brand Icons : fa-lastfm-square"},
        {0xf204,"fa-toggle-off"},
        {0xf205,"fa-toggle-on"},
        {0xf206,"Transportation Icons : fa-bicycle"},
        {0xf207,"Transportation Icons : fa-bus"},
        {0xf208,"Brand Icons : fa-ioxhost"},
        {0xf209,"Brand Icons : fa-angellist"},
        {0xf20a,"Accessibility Icons : fa-cc"},
        {0xf20b,"Currency Icons : fa-ils"},
        {0xf20c,"Brand Icons : fa-meanpath"},
        {0xf20d,"Brand Icons : fa-buysellads"},
        {0xf20e,"Brand Icons : fa-connectdevelop"},
        {0xf210,"Brand Icons : fa-dashcube"},
        {0xf211,"Brand Icons : fa-forumbee"},
        {0xf212,"Brand Icons : fa-leanpub"},
        {0xf213,"Brand Icons : fa-sellsy"},
        {0xf214,"Brand Icons : fa-shirtsinbulk"},
        {0xf215,"Brand Icons : fa-simplybuilt"},
        {0xf216,"Brand Icons : fa-skyatlas"},
        {0xf217,"fa-cart-plus"},
        {0xf218,"fa-cart-arrow-down"},
        {0xf219,"fa-diamond"},
        {0xf21a,"Transportation Icons : fa-ship"},
        {0xf21b,"fa-user-secret"},
        {0xf21c,"Transportation Icons : fa-motorcycle"},
        {0xf21d,"fa-street-view"},
        {0xf21e,"fa-heartbeat"},
        {0xf221,"Gender Icons : fa-venus"},
        {0xf222,"Gender Icons : fa-mars"},
        {0xf223,"Gender Icons : fa-mercury"},
        {0xf224,"Gender Icons : fa-transgender"},
        {0xf225,"Gender Icons : fa-transgender-alt"},
        {0xf226,"Gender Icons : fa-venus-double"},
        {0xf227,"Gender Icons : fa-mars-double"},
        {0xf228,"Gender Icons : fa-venus-mars"},
        {0xf229,"Gender Icons : fa-mars-stroke"},
        {0xf22a,"Gender Icons : fa-mars-stroke-v"},
        {0xf22b,"Gender Icons : fa-mars-stroke-h"},
        {0xf22c,"Gender Icons : fa-neuter"},
        {0xf22d,"Gender Icons : fa-genderless"},
        {0xf230,"Brand Icons : fa-facebook-official"},
        {0xf231,"Brand Icons : fa-pinterest-p"},
        {0xf232,"Brand Icons : fa-whatsapp"},
        {0xf233,"fa-server"},
        {0xf234,"fa-user-plus"},
        {0xf235,"fa-user-times"},
        {0xf236,"fa-bed"},
        {0xf237,"Currency Icons : fa-viacoin"},
        {0xf238,"Transportation Icons : fa-train"},
        {0xf239,"Transportation Icons : fa-subway"},
        {0xf23a,"Brand Icons : fa-medium"},
        {0xf23b,"Brand Icons : fa-y-combinator"},
        {0xf23c,"Brand Icons : fa-optin-monster"},
        {0xf23d,"Brand Icons : fa-opencart"},
        {0xf23e,"Brand Icons : fa-expeditedssl"},
        {0xf240,"fa-battery-full"},
        {0xf241,"fa-battery-three-quarters"},
        {0xf242,"fa-battery-half"},
        {0xf243,"fa-battery-quarter"},
        {0xf244,"fa-battery-empty"},
        {0xf245,"fa-mouse-pointer"},
        {0xf246,"fa-i-cursor"},
        {0xf247,"fa-object-group"},
        {0xf248,"fa-object-ungroup"},
        {0xf249,"fa-sticky-note"},
        {0xf24a,"fa-sticky-note-o"},
        {0xf24b,"Payment Icons : fa-cc-jcb"},
        {0xf24c,"Payment Icons : fa-cc-diners-club"},
        {0xf24d,"fa-clone"},
        {0xf24e,"fa-balance-scale"},
        {0xf250,"fa-hourglass-o"},
        {0xf251,"fa-hourglass-start"},
        {0xf252,"fa-hourglass-half"},
        {0xf253,"fa-hourglass-end"},
        {0xf254,"fa-hourglass"},
        {0xf255,"Hand Icons : fa-hand-rock-o"},
        {0xf256,"Hand Icons : fa-hand-paper-o"},
        {0xf257,"Hand Icons : fa-hand-scissors-o"},
        {0xf258,"Hand Icons : fa-hand-lizard-o"},
        {0xf259,"Hand Icons : fa-hand-spock-o"},
        {0xf25a,"Hand Icons : fa-hand-pointer-o"},
        {0xf25b,"Hand Icons : fa-hand-peace-o"},
        {0xf25c,"fa-trademark"},
        {0xf25d,"fa-registered"},
        {0xf25e,"fa-creative-commons"},
        {0xf260,"Currency Icons : fa-gg"},
        {0xf261,"Currency Icons : fa-gg-circle"},
        {0xf262,"Brand Icons : fa-tripadvisor"},
        {0xf263,"Brand Icons : fa-odnoklassniki"},
        {0xf264,"Brand Icons : fa-odnoklassniki-square"},
        {0xf265,"Brand Icons : fa-get-pocket"},
        {0xf266,"Brand Icons : fa-wikipedia-w"},
        {0xf267,"Brand Icons : fa-safari"},
        {0xf268,"Brand Icons : fa-chrome"},
        {0xf269,"Brand Icons : fa-firefox"},
        {0xf26a,"Brand Icons : fa-opera"},
        {0xf26b,"Brand Icons : fa-internet-explorer"},
        {0xf26c,"fa-television"},
        {0xf26d,"Brand Icons : fa-contao"},
        {0xf26e,"Brand Icons : fa-500px"},
        {0xf270,"Brand Icons : fa-amazon"},
        {0xf271,"fa-calendar-plus-o"},
        {0xf272,"fa-calendar-minus-o"},
        {0xf273,"fa-calendar-times-o"},
        {0xf274,"fa-calendar-check-o"},
        {0xf275,"fa-industry"},
        {0xf276,"fa-map-pin"},
        {0xf277,"fa-map-signs"},
        {0xf278,"fa-map-o"},
        {0xf279,"fa-map"},
        {0xf27a,"fa-commenting"},
        {0xf27b,"fa-commenting-o"},
        {0xf27c,"Brand Icons : fa-houzz"},
        {0xf27d,"Brand Icons : fa-vimeo"},
        {0xf27e,"Brand Icons : fa-black-tie"},
        {0xf280,"Brand Icons : fa-fonticons"},
        {0xf281,"Brand Icons : fa-reddit-alien"},
        {0xf282,"Brand Icons : fa-edge"},
        {0xf283,"Payment Icons : fa-credit-card-alt"},
        {0xf284,"Brand Icons : fa-codiepie"},
        {0xf285,"Brand Icons : fa-modx"},
        {0xf286,"Brand Icons : fa-fort-awesome"},
        {0xf287,"Brand Icons : fa-usb"},
        {0xf288,"Brand Icons : fa-product-hunt"},
        {0xf289,"Brand Icons : fa-mixcloud"},
        {0xf28a,"Brand Icons : fa-scribd"},
        {0xf28b,"Video Player Icons : fa-pause-circle"},
        {0xf28c,"Video Player Icons : fa-pause-circle-o"},
        {0xf28d,"Video Player Icons : fa-stop-circle"},
        {0xf28e,"Video Player Icons : fa-stop-circle-o"},
        {0xf290,"fa-shopping-bag"},
        {0xf291,"fa-shopping-basket"},
        {0xf292,"fa-hashtag"},
        {0xf293,"Brand Icons : fa-bluetooth"},
        {0xf294,"Brand Icons : fa-bluetooth-b"},
        {0xf295,"fa-percent"},
        {0xf296,"Brand Icons : fa-gitlab"},
        {0xf297,"Brand Icons : fa-wpbeginner"},
        {0xf298,"Brand Icons : fa-wpforms"},
        {0xf299,"Brand Icons : fa-envira"},
        {0xf29a,"Accessibility Icons : fa-universal-access"},
        {0xf29b,"Accessibility Icons : fa-wheelchair-alt"},
        {0xf29c,"Accessibility Icons : fa-question-circle-o"},
        {0xf29d,"Accessibility Icons : fa-blind"},
        {0xf29e,"Accessibility Icons : fa-audio-description"},
        {0xf2a0,"Accessibility Icons : fa-volume-control-phone"},
        {0xf2a1,"Accessibility Icons : fa-braille"},
        {0xf2a2,"Accessibility Icons : fa-assistive-listening-systems"},
        {0xf2a3,"Accessibility Icons : fa-american-sign-language-interpreting"},
        {0xf2a4,"Accessibility Icons : fa-deaf"},
        {0xf2a5,"fa-glide"},
        {0xf2a6,"fa-glide-g"},
        {0xf2a7,"Accessibility Icons : fa-sign-language"},
        {0xf2a8,"Accessibility Icons : fa-low-vision"},
        {0xf2a9,"Brand Icons : fa-viadeo"},
        {0xf2aa,"Brand Icons : fa-viadeo-square"},
        {0xf2ab,"Brand Icons : fa-snapchat"},
        {0xf2ac,"Brand Icons : fa-snapchat-ghost"},
        {0xf2ad,"Brand Icons : fa-snapchat-square"},
        {0xf2ae,"Brand Icons : fa-pied-piper"},
        {0xf2b0,"Brand Icons : fa-first-order"},
        {0xf2b1,"Brand Icons : fa-yoast"},
        {0xf2b2,"Brand Icons : fa-themeisle"},
        {0xf2b3,"Brand Icons : fa-google-plus-official"},
        {0xf2b4,"Brand Icons : fa-font-awesome"},
        {0xf2b5,"fa-handshake-o"},
        {0xf2b6,"fa-envelope-open"},
        {0xf2b7,"fa-envelope-open-o"},
        {0xf2b8,"Brand Icons : fa-linode"},
        {0xf2b9,"fa-address-book"},
        {0xf2ba,"fa-address-book-o"},
        {0xf2bb,"fa-address-card"},
        {0xf2bc,"fa-address-card-o"},
        {0xf2bd,"fa-user-circle"},
        {0xf2be,"fa-user-circle-o"},
        {0xf2c0,"fa-user-o"},
        {0xf2c1,"fa-id-badge"},
        {0xf2c2,"fa-id-card"},
        {0xf2c3,"fa-id-card-o"},
        {0xf2c4,"Brand Icons : fa-quora"},
        {0xf2c5,"Brand Icons : fa-free-code-camp"},
        {0xf2c6,"Brand Icons : fa-telegram"},
        {0xf2c7,"fa-thermometer-full"},
        {0xf2c8,"fa-thermometer-three-quarters"},
        {0xf2c9,"fa-thermometer-half"},
        {0xf2ca,"fa-thermometer-quarter"},
        {0xf2cb,"fa-thermometer-empty"},
        {0xf2cc,"fa-shower"},
        {0xf2cd,"fa-bath"},
        {0xf2ce,"fa-podcast"},
        {0xf2d0,"fa-window-maximize"},
        {0xf2d1,"fa-window-minimize"},
        {0xf2d2,"fa-window-restore"},
        {0xf2d3,"fa-window-close"},
        {0xf2d4,"fa-window-close-o"},
        {0xf2d5,"Brand Icons : fa-bandcamp"},
        {0xf2d6,"Brand Icons : fa-grav"},
        {0xf2d7,"Brand Icons : fa-etsy"},
        {0xf2d8,"Brand Icons : fa-imdb"},
        {0xf2d9,"Brand Icons : fa-ravelry"},
        {0xf2da,"Brand Icons : fa-eercast"},
        {0xf2db,"fa-microchip"},
        {0xf2dc,"fa-snowflake-o"},
        {0xf2dd,"Brand Icons : fa-superpowers"},
        {0xf2de,"Brand Icons : fa-wpexplorer"},
        {0xf2e0,"Brand Icons : fa-meetup"}
        };
    }
}