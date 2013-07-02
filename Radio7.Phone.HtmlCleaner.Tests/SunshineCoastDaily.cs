using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Radio7.Phone.HtmlCleaner.Tests
{
    internal class SunshineCoastDaily
    {
        public static HtmlDocument HtmlDocument
        {
            get
            {
                var htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(Html);
                return htmlDocument;
            }
        }

        public static string Html
        {
            get
            {
                return @"
<!DOCTYPE html> <!--[if lt IE 7]> <html  class=""sunshinecoastdaily rnn-au no-js non-staff-user non-authenticated-user no-facebook-api ie6 oldie"" lang=""en""> <![endif]--> <!--[if IE 7]> <html  class=""sunshinecoastdaily rnn-au no-js non-staff-user non-authenticated-user no-facebook-api ie7 oldie"" lang=""en""> <![endif]--> <!--[if IE 8]> <html  class=""sunshinecoastdaily rnn-au no-js non-staff-user non-authenticated-user no-facebook-api ie8 oldie"" lang=""en""> <![endif]--> <!--[if IE 9 ]> <html  class=""sunshinecoastdaily rnn-au no-js non-staff-user non-authenticated-user no-facebook-api ie9"" lang=""en""> <![endif]--> <!--[if (gt IE 9)|!(IE)]><!--> <html class=""sunshinecoastdaily rnn-au no-js non-staff-user non-authenticated-user no-facebook-api"" lang=""en""> <!--<![endif]--> <head> <title>Legionella scare in Sunshine Coast Private Hospital | Sunshine Coast Daily</title> <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1""> <meta charset=""utf-8""> <meta name=""description"" content=""WATER from a tap in the critical care unit at Sunshine Coast Private Hospital has tested positive for the potentially deadly legionella bacteria."" /> <meta name=""author"" content=""""> <meta property=""fb:app_id"" content=""143329145682245""/> <meta property=""og:site_name"" content=""Sunshine Coast Daily""/> <meta property=""og:title"" content=""Legionella scare in Sunshine Coast Private Hospital"" /> <meta property=""og:type"" content=""article"" /> <meta property=""og:url"" content=""http://www.sunshinecoastdaily.com.au/news/Legionella-scare-in-Sunshine-Coast-Private-Hospita/1926607/"" /> <meta property=""og:image"" content=""http://media2.apnonline.com.au/img/media/images/2013/01/14/25-2007916-scn181212nambourgeneralhospital10.jpg"" /> <link rel=""image_src"" href=""http://media2.apnonline.com.au/img/media/images/2013/01/14/25-2007916-scn181212nambourgeneralhospital10.jpg"" /> <meta property=""og:description"" content=""WATER from a tap in the critical care unit at Sunshine Coast Private Hospital has tested positive for the potentially deadly legionella bacteria."" /> <link rel=""EditURI"" type=""application/rsd+xml"" title=""RSD"" href=""/xml-rpc/rsd/"" /> <meta http-equiv=""imagetoolbar"" content=""no""> <meta http-equiv=""imagetoolbar"" content=""false""> <meta name=""viewport"" content=""width=1020""> <link rel=""stylesheet"" href=""http://media2.apnonline.com.au/90.1/img/cache/90.1/css/9bedc5d98c7a.css"" type=""text/css"" media=""all"" charset=""utf-8""> <link rel=""stylesheet"" href=""http://media2.apnonline.com.au/90.1/img/cache/90.1/css/76d11632687d.css"" type=""text/css"" media=""all"" charset=""utf-8""> <style>

.tabbed-section-map-and-add-notice-form:first-child {
margin-top: -40px;
}

/* Styling for Profile/Our Team pages.     */

div.GlobalProfileWrapper img{width:60px; height: auto; float:left; padding-right:10px; padding-bottom:10px;}


/* Styling for Group Sites */
#grouplinks .Ireland, #grouplinks .NorthernIreland, #grouplinks .SouthAfrica, #grouplinks .Community.category, #grouplinks .Classifieds.category {display:none}
#groupWebsites h1{border-bottom:1px dotted #CBCABF; padding-bottom:5px;margin-bottom:20px}
#grouplinks h2{padding:0 0 15px;color:#AC360A}
#grouplinks h3{padding:0 0 8px;font-size:115%}
#grouplinks .country{clear:both;margin:0 0 20px;border-bottom:1px dotted #CBCABF}
#grouplinks .category{margin:0 0 10px 10px}
#grouplinks .category li{margin:0 0 0 10px}


/* Classifieds 6cm ads not showing */
.classifieds-search-result .result-image-link {
max-height: 268px;
}
.classifieds-search-result .result-image-link .fade-to-white {
margin-top: 280px;
}


/* Featured Topics Style Hacks */

.featuredTopics h3 {
color: #8A8A8A;
float: left;
margin-right: 10px;
line-height: 38px;
font-size: 14px;
}

.featuredTopics ul.piped {
padding-top: 10px;
}

/* Latest Bar style overrides */

.latest-bar .latest-bar-column h2 {
font-size: 12px;
padding: 2px 0px 4px;
font-weight: bold;
}

.latest-bar .latest-bar-column h3 {
font-size: 10px;
}

.latest-bar .latest-bar-column {
width: 160px;
min-width: 160px;
max-width: 160px;
padding:0px 6px;
}

.latest-bar .latest-bar-column .thumbnail {
width: 152px;
}

.latest-bar .latest-bar-column .thumbnail img {
height: 64px;
}

.latest-bar .latest-bar-column .horoscopesWidget h2 {
font-size: 22px;
}

/* Skin ad clickable areas are adding horizontal scroll bars on smaller displays */
@media (max-width: 1200px) {
    #body-ct-pl, #body-ct-pr{display:none;}
}


div.row div.ugcContainer div.iconBanner{background-image:none;}


.twoItem .itemCarousel.fancy.flat article img, 
.twoItem .itemCarousel.fancy.flat article div { 
    width: auto; 
    height: auto; 
}

div.sitelogo img#logo{max-width:230px; height:auto;}





div.recurring-inline-normal #flash_object{
max-width:100% !important;
}
div.featuredTopics img{max-width:460px; height:auto;}
   section .flatpage li { list-style: inherit; }

  /* Hack to remove extra bottom border form teh footer fragment on story detail pages */
  .footerFragment section {
     border-bottom: none;
  }

[data-overlay-marker*=""Latest Bar - Horoscopes: Latest Bar - Horoscopes""] h2{font-size:21px !important;}


div.headlineFragment img{max-width:100%}

 




body{
text-rendering: optimizeLegibility;
}
h3, .h3 {
font-size: 18px;
line-height: 24px;
margin-bottom: 10px;
}

h1, .h1 {
font-size: 30px;
line-height: 32px;
}

.well-stuckOnGhost h1 {
margin-top: -4px;
margin-bottom: 12px;
}

section .sideBar li {
line-height: 17px;
margin-bottom: 8px;
}

section {
padding: 0 0 10px;
}

section .sideBar .arrowList li a::before {
content: ""» "";
}
.btn-primary {
	background: -webkit-linear-gradient(top, #78D526, #54AE04);
	border: 1px solid #478D08;
}
.btn-primary:hover,.btn-primary:active,.btn-primary.active,.btn-primary.disabled,.btn-primary[disabled] {
	background: #54AE04;
	border: 1px solid #478D08;	
}
.mostPopularTopicItem .followHeadline h3 {
line-height: 20px;
font-size: 16px;
}

.topic-header .topic-meta {
width: 630px;
padding-right: 0px;
}





a.mozoImage img{max-width:140px;}
p.mozoHeader{height:36px;}
p.mozoCaption a{color:#8A8A8A}
p.mozoCaption a:hover{text-decoration: none;}
div.FullWidthMozo a.mozoImage img {max-width:130px;}
div.FullWidthMozo p.mozoCaption{height:65px;}


div.businessesApp section.findMore{clear:both;}


.rnn_page_banner_classifieds {
    background-image: url(""http://media2.apnonline.com.au/90.1/tc/base/img/page_banners/classifieds.png"");
    background-repeat: no-repeat;
}
.rnn_page_banner_classifieds h2 {
    visibility: hidden;
}
.rnn_page_banner_classifieds .placead-link {
    display: block;
    width: 100%;
    height: 76px;
}



ul.piped{list-style:none;margin:0 0 9px;font-size:12px}ul.piped li{display:inline;*padding-right:9px}ul.piped li:after{color:#8a8a8a;content:"" | ""}ul.piped li:last-child:after{content:""""}ul.comma-separated{list-style:none;margin:0 0 9px;font-size:12px}ul.comma-separated li{display:inline;*padding-right:9px}ul.comma-separated li:after{color:#8a8a8a;content:"",""}ul.comma-separated li:last-child:after{content:""""}ul.block-bold{list-style:none;margin:0}ul.block-bold.smaller{font-size:0.9em}ul.block-bold li{font-weight:bold;margin:0}ul.block-bold li a{font-weight:bold}ul.inline-bold{list-style:none;margin:0}ul.inline-bold.smaller{font-size:0.9em}ul.inline-bold li{font-weight:bold;display:inline;margin:0 10px 0 0}ul.inline-bold li:last-child{margin-right:0}ul.inline-bold li a{font-weight:bold;white-space:nowrap}ul.meta{height:24px;margin:0 0 4px}ul.meta li{display:inline;height:24px;line-height:24px;margin-right:5px;color:#8a8a8a}ul.meta li [class^=""icon""]{vertical-align:top}.laquo:before{content:""\00AB\00A0""}.raquo{font-weight:bold}.raquo:before{content:""\00BB\00A0""}.ellipsis:after{content:""\2026""}.grey-bubble{padding:10px 8px;-webkit-border-radius:16px;-moz-border-radius:16px;border-radius:16px;background-color:#CCC;color:#ffffff;text-transform:uppercase}.non-authenticated-user .only-authenticated-user{display:none !important}.authenticated-user .only-non-authenticated-user{display:none !important}.non-staff-user .only-staff-user{display:none !important}.staff-user .only-non-staff-user{display:none !important}.no-facebook-api .only-facebook-api{display:none !important}.scrollbar-path-vertical,.scrollbar-path-horizontal{position:absolute;background-color:#eee;background-color:rgba(220,220,220,0.5);z-index:100}.scrollbar-path-horizontal{bottom:5px;left:0;width:100%;height:10px}.scrollbar-path-vertical{right:5px;top:0;height:100%;width:10px}.scrollbar-path-vertical{box-shadow:inset 1px 0px 1 rgba(0,0,0,0.1);-moz-box-shadow:inset 1px 0px 1 rgba(0,0,0,0.1);-webkit-box-shadow:inset 1px 0px 0 rgba(0,0,0,0.1)}.scrollbar-path-horizontal{box-shadow:inset 0px 1px 1 rgba(0,0,0,0.1);-moz-box-shadow:inset 0px 1px 1 rgba(0,0,0,0.1);-webkit-box-shadow:inset 0px 1px 0 rgba(0,0,0,0.1)}.scrollbar-handle{position:relative;top:0;left:0;background-color:#58eebc}.scrollbar-path-vertical .scrollbar-handle{height:20%;width:100%}.scrollbar-path-horizontal .scrollbar-handle{width:20%;height:100%}.scrollbar-path-vertical,.scrollbar-path-horizontal,.scrollbar-handle{-moz-border-radius:5px;-webkit-border-radius:5px;border-radius:5px}.scrollbar-content{padding:0 20px 0 0}



</style> <link href=""http://fonts.googleapis.com/css?family=Open+Sans%7COpen+Sans+Condensed:700"" rel=""stylesheet""/> <script src=""http://media2.apnonline.com.au/90.1/tc/base/js/modernizr-custom.min.js""></script> <script src=""http://media2.apnonline.com.au/90.1/tc/base/js/modules/advertising_nzShim.js""></script> <script>
(function(w,d,u){w.readyQ=[];w.bindReadyQ=[];function p(x,y){if(x==""ready""){w.bindReadyQ.push(y);}else{w.readyQ.push(x);}};var a={ready:p,bind:p};w.$=w.jQuery=function(f){if(f===d||f===u){return a}else{p(f)}}})(window,document)
</script> <script type=""text/javascript"" src=""http://admin.brightcove.com/js/BrightcoveExperiences.js""></script> <script id=""rnn_google_analytics"" type=""text/javascript"">
    var _gaq = _gaq || [];
    _gaq.push(['_setAccount', 'UA-2800415-24']);
    _gaq.push(['_setDomainName', 'none']);
    _gaq.push(['_setAllowLinker', true]);
    _gaq.push(['_setAllowHash', false]);
    _gaq.push(['_setCustomVar', 1, 'Category',  (window.location.pathname === '/' ? 'Homepage' : 'News'), 3]);
    
    
    _gaq.push(['_setCustomVar', 3, 'Local', 'local', 3]);
    
    _gaq.push(['_trackPageview']);
    
    (function() {
        var ga = document.createElement('script');
        ga.type = 'text/javascript';
        ga.async = true;
        ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
        var s = document.getElementsByTagName('script')[0];
        s.parentNode.insertBefore(ga, s);
    })();
</script> <script id=""rnn_nielsen"" type='text/javascript'>
var crtg_nid=""1301"";
var crtg_cookiename=""apn_crta"";
var crtg_varname=""crtg_content"";
function crtg_getCookie(c_name){ var i,x,y,ARRCookies=document.cookie.split("";"");for(i=0;i<ARRCookies.length;i++){x=ARRCookies[i].substr(0,ARRCookies[i].indexOf(""=""));y=ARRCookies[i].substr(ARRCookies[i].indexOf(""="")+1);x=x.replace(/^\s+|\s+$/g,"""");if(x==c_name){return unescape(y);}}return'';}
var crtg_content = crtg_getCookie(crtg_cookiename);var crtg_rnd=Math.floor(Math.random()*99999999999);
var crtg_url=location.protocol+'//rtax.criteo.com/delivery/rta/rta.js?netId='+escape(crtg_nid);crtg_url+='&cookieName='+escape(crtg_cookiename);crtg_url+='&rnd='+crtg_rnd;crtg_url+='&varName=' + escape(crtg_varname);
var crtg_script=document.createElement('script');crtg_script.type='text/javascript';crtg_script.src=crtg_url;crtg_script.async=true;
if(document.getElementsByTagName(""head"").length>0)document.getElementsByTagName(""head"")[0].appendChild(crtg_script);else if(document.getElementsByTagName(""body"").length>0)document.getElementsByTagName(""body"")[0].appendChild(crtg_script);</script> </head> <body class=""newsEntryBody""> <ul id=""accessibilityLinks"" class=""offscreen""> <li><a href=""#ft_2"" accesskey=""0"">Skip to site map</a></li> </ul> <div class=""hat""> <div class=""navbar""> <div class=""navbar-inner""> <div class=""container""> <ul class=""nav""> <li class=""dropdown"" id=""hat_moreNews""> <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#hat_moreNews"">
                            More News
                            <b class=""caret""></b> </a> <ul class=""dropdown-menu""> <li class=""dropdown-submenu""> <a tabindex=""-1"" href=""#"">Daily Newspapers</a> <ul class=""dropdown-menu dropdown-menu-3col""> <li><a title=""Bundaberg News"" href=""http://www.news-mail.com.au"">Bundaberg News-Mail</a></li> <li><a title=""Coffs Coast News"" href=""http://www.coffscoastadvocate.com.au"">Coffs Coast Advocate</a></li> <li><a title=""Fraser Coast News"" href=""http://www.frasercoastchronicle.com.au"">Fraser Coast Chronicle</a></li> <li><a title=""Gladstone News"" href=""http://www.gladstoneobserver.com.au"">Gladstone Observer</a></li> <li><a title=""Grafton News"" href=""http://www.dailyexaminer.com.au"">Grafton Daily Examiner</a></li> <li><a title=""Gympie News"" href=""http://www.gympietimes.com.au"">Gympie Times</a></li> <li><a title=""Ipswich News"" href=""http://www.qt.com.au"">Ipswich Queensland Times</a></li> <li><a title=""Lismore News"" href=""http://www.northernstar.com.au"">Lismore Northern Star</a></li> <li><a title=""Mackay News"" href=""http://www.dailymercury.com.au"">Mackay Daily Mercury</a></li> <li><a title=""Rockhampton News"" href=""http://www.themorningbulletin.com.au"">Rockhampton Morning Bulletin</a></li> <li><a title=""Sunshine Coast News"" href=""http://www.sunshinecoastdaily.com.au"">Sunshine Coast Daily</a></li> <li><a title=""Toowoomba News"" href=""http://www.thechronicle.com.au"">Toowoomba Chronicle</a></li> <li><a title=""My Daily News"" href=""http://www.mydailynews.com.au"">My Daily News</a></li> <li><a title=""Warwick News"" href=""http://www.warwickdailynews.com.au"">Warwick Daily News</a></li> </ul> </li> <li class=""dropdown-submenu""> <a tabindex=""-1"" href=""#"">Community Newspapers</a> <ul class=""dropdown-menu dropdown-menu-3col""> <li><a title=""Big Rigs"" href=""http://www.bigrigs.com.au"">Big Rigs</a></li> <li><a title=""Ballina News"" href=""http://www.ballinaadvocate.com.au"">Ballina Shire Advocate</a></li> <li><a title=""Biloela News"" href=""http://www.centraltelegraph.com.au"">Biloela Central Telegraph</a></li> <li><a title=""Byron News"" href=""http://www.byronnews.com.au"">Byron Shire News</a></li> <li><a title=""Caboolture News"" href=""http://www.caboolturenews.com.au"">Caboolture News</a></li> <li><a title=""Coolum and North Shore News"" href=""http://www.coolum-news.com.au"">Coolum &amp; North Shore News</a></li> <li><a title=""East Ipswich News"" href=""http://www.thesatellite.com.au"">East-Ipswich Satellite</a></li> <li><a title=""Emerald News"" href=""http://www.cqnews.com.au"">Emerald Central Queensland News</a></li> <li><a title=""Gatton News"" href=""http://www.gattonstar.com.au"">Gatton Star</a></li> <li><a title=""Ipswich News"" href=""http://www.ipswichadvertiser.com.au"">Ipswich Advertiser</a></li> <li><a title=""Logan News"" href=""http://www.thereporter.com.au"">Logan Reporter</a></li> <li><a title=""Noosa News"" href=""http://www.noosanews.com.au"">Noosa News</a></li> <li><a title=""Northern Rivers News"" href=""http://www.echonews.com.au"">The Northern Rivers Echo</a></li> <li><a title=""Range News"" href=""http://www.rangenews.com.au"">Range News</a></li> <li><a title=""Rural Weekly"" href=""http://www.ruralweekly.com.au"">Rural Weekly</a></li> <li><a title=""South Burnett Times"" href=""http://www.southburnetttimes.com.au"">South Burnett Times</a></li> <li><a title=""Stanthorpe Border Post"" href=""http://www.stanthorpeborderpost.com.au"">Stanthorpe Border Post</a></li> <li><a title=""SuratBasin.com.au"" href=""http://www.suratbasin.com.au"">SuratBasin.com.au</a></li> <li><a title=""Whitsunday News"" href=""http://www.whitsundaytimes.com.au"">Whitsunday Times</a></li> </ul> </li> </ul> </li> <li class=""divider-vertical""></li> <li class=""dropdown only-authenticated-user"" id=""hat_user""> <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#hat_user"">
                            Welcome back <span data-user-property=""display_name""></span> <b class=""caret""></b> </a> <ul class=""dropdown-menu""> <li><a href=""/my-account/"">My Activity</a></li> <li><a href=""/my-account/list-events/"">My Events</a></li> <li><a href=""/my-account/edit/"">Edit Profile</a></li> <li class=""divider""></li> <li class=""only-staff-user""><a href=""/admin/"">Admin Site</a></li> <li><a href=""/my-account/logout/?next=/news/Legionella-scare-in-Sunshine-Coast-Private-Hospita/1926607/"">Logout</a></li> </ul> </li> <li class=""only-non-authenticated-user""><a href=""/my-account/register/?next=/news/Legionella-scare-in-Sunshine-Coast-Private-Hospita/1926607/"">Register</a></li> <li class=""only-non-authenticated-user divider-vertical""></li> <li class=""only-non-authenticated-user""><a href=""/my-account/login/?next=/news/Legionella-scare-in-Sunshine-Coast-Private-Hospita/1926607/"">Login</a></li> </ul> <ul class=""nav pull-right""  data-overlay-marker='{""edit_url"": ""/admin/fragments/fragment/2401/"", ""content_type"": ""fragment"", ""label"": ""tc_hat_0""}'> <li class=""divider-vertical""></li> <li><a href=""http://www.drive.com.au/"" target=""_blank"" class=""track"" data-category=""MainNavBarLinks"" data-action=""Click Outbound"" data-label=""FairfaxDrive""><img src=""http://media2.apnonline.com.au/90.1/img/media/images/2010/09/03/drive.png"" title=""Cars, Bikes & Scooters 24/7"" /></a></li> <li class=""divider-vertical""></li> <li><a href=""http://www.domain.com.au/Search/buy/State/QLD/Area/Sunshine-Coast/Region/South-East/Suburb/Sunshine-Coast/?ssubs=1&searchterm=Sunshine+coast"" target=""_blank"" class=""track"" data-category=""MainNavBarLinks"" data-action=""Click Outbound"" data-label=""FairfaxDomain""><img src=""http://media2.apnonline.com.au/90.1/img/media/images/2010/09/10/domain.png"" title=""Property Online"" /></a></li> <li class=""divider-vertical""></li> <li><a href=""/nie/""><img src=""http://media2.apnonline.com.au/90.1/img/media/images/2011/07/01/nie_menu_logo.png"" /></a></li> </ul> <form action=""/search/"" method=""get"" class=""hat-search pull-right generalSearchForm"" autocomplete=""off"" data-typeahead-urls='{""tags"": ""/search/tags.json""}' target=""_top""> <input type=""text"" name=""keywords"" class=""input-medium"" placeholder=""Search"" maxlength=""50""/> <button type=""submit"" class=""btn""><i class=""icon-search icon-white""></i></button> </form> </div> </div> </div> </div> <div class=""wrapper""> <div id=""hd"" class=""clearfix""> <div class=""sitebanner""> <div id=""leaderboardAd"" class=""leaderboard""> <div id=""adSpace0"" class=""adSpace""></div> </div> </div> <header class=""siteheader""> <div class=""sitelogo""> <a href=""/""> <img id=""logo"" src=""http://media2.apnonline.com.au/img/site/logo/sunshinecoastdaily.png"" alt=""Sunshine Coast Daily"" /> </a> </div> </header> </div> <nav class=""sitenav""> <div class=""primaryNav""> <ul class=""nav nav-pills""> <li> <a href=""/"" > <span class=""home-link""></span>News
</a> <div class=""secondaryNav""> <ul class=""nav nav-pills""> <li> <a href=""/news/"" >
    Local
</a> <div class=""pageBanner pageBannerWithTertiaryNav rnn_page_banner_local""> <div class=""container""> <div class=""row""> <div class=""span8""> <h2>Local</h2> </div> <div class=""span4""> </div> </div> <ul class=""nav nav-tabs""> <li> <a href=""/news/maleny/"" >
    Maleny
</a> </li> <li> <a href=""/news/noosa/"" >
    Noosa
</a> </li> <li> <a href=""/news/coolum/"" >
    Coolum
</a> </li> <li> <a href=""/panel/"" >
    Audience Panel
</a> </li> </ul> </div> </div> </li> <li> <a href=""/just-in/"" >
    Just In
</a> </li> <li> <a href=""/news/qld/"" >
    Queensland
</a> </li> <li> <a href=""/news/national/"" >
    National
</a> </li> <li> <a href=""/news/offbeat/"" >
    Offbeat
</a> </li> <li> <a href=""/sport/"" >
    Sport
</a> <div class=""pageBanner pageBannerWithTertiaryNav rnn_page_banner_sport""> <div class=""container""> <div class=""row""> <div class=""span8""> <h2>Sport</h2> </div> <div class=""span4""> <div  data-overlay-marker='{""edit_url"": ""/admin/fragments/fragment/2618/"", ""content_type"": ""fragment"", ""label"": ""rnn_page_banner_sport""}'> <style>
.rnn_page_banner_sport{
background:url(http://media2.apnonline.com.au/img/media/images/2012/09/18/Sport.png);
}
/* [CG] Sponsor logos should only be 40px high. The Bunnings sponsor is 75px high, so we compensate by negating the bottom margin by 35px */
.rnn_page_banner_sport .span4 {
margin-bottom: -35px;
}
</style> <script type=""text/javascript"" language=""JavaScript""> <!-- Hide from old browsers
    // Modify to reflect site specifics
    adserver = ""http://data.apn.com.au/apnau"";
    target = ""/site=REGTHEDAILY/area=REGTHEDAILY.SPORT.HME/SIZE=BTYB-2/POS=POS1"";
     
    // Cache-busting and viewid values
    random = Math.round(Math.random() * 100000000);
    if (!pageNum) var pageNum = Math.round(Math.random() * 100000000);
     
    document.write('<iframe src=""'+adserver+'/hserver/random='+random + target + '/viewid=' + pageNum + '""');
    document.write(' noresize scrolling=no hspace=0 vspace=0 frameborder=0 marginheight=0 marginwidth=0 width =145 height=50 allowTransparency=""true"">');
    document.write('</iframe>');
     
    // End Hide --> </script> </div> </div> </div> <ul class=""nav nav-tabs""> <li> <a href=""/sport/nrl/"" >
    Rugby League
</a> </li> <li> <a href=""/sport/rugby-union/"" >
    Union
</a> </li> <li> <a href=""/sport/afl/"" >
    AFL
</a> </li> <li> <a href=""/sport/cricket/"" >
    Cricket
</a> </li> <li> <a href=""/sport/soccer/"" >
    Soccer
</a> </li> <li> <a href=""/topic/multisport/"" >
    Multisport
</a> </li> <li> <a href=""/sport/more/"" >
    All Sport
</a> </li> <li> <a href=""/footytipping/"" >
    Footy Tipping
</a> </li> </ul> </div> </div> </li> <li> <a href=""/lifestyle/"" >
    Lifestyle
</a> <div class=""pageBanner pageBannerWithTertiaryNav rnn_page_banner_lifestyle""> <div class=""container""> <div class=""row""> <div class=""span8""> <h2>Lifestyle</h2> </div> <div class=""span4""> <div  data-overlay-marker='{""edit_url"": ""/admin/fragments/fragment/2619/"", ""content_type"": ""fragment"", ""label"": ""rnn_page_banner_lifestyle""}'> <style>
.rnn_page_banner_lifestyle{
background:url(http://media2.apnonline.com.au/img/media/images/2012/09/18/Lifestyle.png);
}
/* [CG] Sponsor logos should only be 40px high. The Bunnings sponsor is 75px high, so we compensate by negating the bottom margin by 35px */
.rnn_page_banner_lifestyle .span4 {
margin-bottom: -35px;
}
</style> <script type=""text/javascript"" language=""JavaScript""> <!-- Hide from old browsers
    // Modify to reflect site specifics
    adserver = ""http://data.apn.com.au/apnau"";
    target = ""/site=REGTHEDAILY/area=REGTHEDAILY.LIFESTYLE.HME/SIZE=BTYB/POS=POS1"";
     
    // Cache-busting and viewid values
    random = Math.round(Math.random() * 100000000);
    if (!pageNum) var pageNum = Math.round(Math.random() * 100000000);
     
    document.write('<iframe src=""'+adserver+'/hserver/random='+random + target + '/viewid=' + pageNum + '""');
    document.write(' noresize scrolling=no hspace=0 vspace=0 frameborder=0 marginheight=0 marginwidth=0 width =200 height=75 allowTransparency=""true"">');
    document.write('</iframe>');
     
    // End Hide --> </script> </div> </div> </div> <ul class=""nav nav-tabs""> <li> <a href=""/lifestyle/smarter-shopping/"" >
    Smarter Shopping
</a> </li> <li> <a href=""/lifestyle/easy-eating/"" >
    Easy Eating
</a> </li> <li> <a href=""/lifestyle/explore/"" >
    Explore (Travel)
</a> </li> <li> <a href=""/digital-edition/coast-life/"" >
    Coast Life
</a> </li> <li> <a href=""/digital-edition/bride/"" >
    Coast Bride
</a> </li> <li> <a href=""/digital-edition/hinterland-guide/"" >
    Hinterland Guide
</a> </li> </ul> </div> </div> </li> <li> <a href=""/business/"" >
    Business
</a> <div class=""pageBanner rnn_page_banner_business""> <div class=""container""> <div class=""row""> <div class=""span8""> <h2>Business</h2> </div> <div class=""span4""> <div  data-overlay-marker='{""edit_url"": ""/admin/fragments/fragment/2620/"", ""content_type"": ""fragment"", ""label"": ""rnn_page_banner_business""}'> <style>
.rnn_page_banner_business{
background:url(http://media2.apnonline.com.au/img/media/images/2012/09/18/Business.png);
}
</style> </div> </div> </div> </div> </div> </li> <li> <a href=""http://www.ruralweekly.com.au/"" target=""_blank"">
    Rural Weekly
</a> </li> </ul> </div> </li> <li> <a href=""/local-life/"" >
    Local Life
</a> <div class=""secondaryNav""> <ul class=""nav nav-pills""> <li> <a href=""/noticeboard/"" >
    Noticeboard
</a> </li> <li> <a href=""/your-story/"" >
    Your Story
</a> </li> <li> <a href=""/local-life/blogs/"" >
    Blogs
</a> </li> <li> <a href=""/photos/"" >
    Photos
</a> </li> <li> <a href=""/photos/buy/"" >
    Buy Photos
</a> </li> <li> <a href=""/videos/"" >
    Video
</a> </li> <li> <a href=""/our-team/"" >
    Our Team
</a> </li> <li> <a href=""/local-life/cams/"" >
    Traffic Cams
</a> </li> <li> <a href=""/council/sunshine-coast/"" >
    Sunshine Coast Council
</a> </li> </ul> </div> </li> <li> <a href=""/find-your-local/"" >
    Find your local
</a> <div class=""secondaryNav""> <ul class=""nav nav-pills""> <li> <a href=""/businesses/locations/"" >
    Search by location
</a> </li> <li> <a href=""/businesses/categories/"" >
    Search by category
</a> </li> <li> <a href=""/find-your-local/check/"" >
    Add Your Business
</a> </li> </ul> </div> </li> <li> <a href=""/things-to-do/"" >
    Things to do
</a> <div class=""secondaryNav""> <ul class=""nav nav-pills""> <li> <a href=""/entertainment/"" >
    Entertainment
</a> <div class=""pageBanner rnn_page_banner_entertainment""> <div class=""container""> <div class=""row""> <div class=""span8""> <h2>Entertainment</h2> </div> <div class=""span4""> <div  data-overlay-marker='{""edit_url"": ""/admin/fragments/fragment/2260/"", ""content_type"": ""fragment"", ""label"": ""rnn_page_banner_entertainment""}'> <style>
.rnn_page_banner_entertainment{
background:url(http://media2.apnonline.com.au/img/media/images/2012/09/18/Entertainment.png);
}
/* [CG] Sponsor logos should only be 40px high. The Bunnings sponsor is 75px high, so we compensate by negating the bottom margin by 35px */
.rnn_page_banner_entertainment .span4 {
margin-bottom: -35px;
}
</style> <script type=""text/javascript"" language=""JavaScript""> <!-- Hide from old browsers
    // Modify to reflect site specifics
    adserver = ""http://data.apn.com.au/apnau"";
    target = ""/site=REGTHEDAILY/area=REGTHEDAILY.ENTERTAINMENT.HME/SIZE=BTYB-2/POS=POS1"";
     
    // Cache-busting and viewid values
    random = Math.round(Math.random() * 100000000);
    if (!pageNum) var pageNum = Math.round(Math.random() * 100000000);
     
    document.write('<iframe src=""'+adserver+'/hserver/random='+random + target + '/viewid=' + pageNum + '""');
    document.write(' noresize scrolling=no hspace=0 vspace=0 frameborder=0 marginheight=0 marginwidth=0 width =145 height=50 allowTransparency=""true"">');
    document.write('</iframe>');
     
    // End Hide --> </script> </div> </div> </div> </div> </div> </li> <li> <a href=""/things-to-do/local/"" >
    Events
</a> </li> <li> <a href=""/things-to-do/add/"" >
    Place an Event
</a> </li> <li> <a href=""http://www.sunshinecoastdaily.com.au/things-to-do/maroochydore/festivals-concerts-musicals-gigs/?maxdist=50"" >
    Gigs
</a> </li> <li> <a href=""/entertainment/tv-guide/"" >
    TV Guide
</a> </li> <li> <a href=""/things-to-do/movies/"" >
    Movies
</a> </li> </ul> </div> </li> <li> <a href=""/jobs/"" >
    Jobs
</a> <div class=""secondaryNav""> <ul class=""nav nav-pills""> <li> <a href=""/employment/"" >
    News
</a> </li> <li> <a href=""/jobs/special-reports/"" >
    Special Reports
</a> </li> <li> <a href=""http://content.mycareer.com.au/salary-centre"" target=""_blank"">
    Salary Centre
</a> </li> </ul> </div> </li> <li> <a href=""/cars/"" >
    Cars
</a> <div class=""secondaryNav""> <ul class=""nav nav-pills""> <li> <a href=""/cars/"" >
    News
</a> </li> <li> <a href=""/digital-edition/drive/"" >
    Drive Digital Edition
</a> </li> </ul> </div> </li> <li> <a href=""/real-estate/"" >
    Real Estate
</a> <div class=""secondaryNav""> <ul class=""nav nav-pills""> <li> <a href=""/real-estate/for-sale"" >
    For Sale
</a> </li> <li> <a href=""/real-estate/for-rent"" >
    For Rent
</a> </li> <li> <a href=""/business/tools/"" >
    Tools &amp; Calculators
</a> </li> <li> <a href=""http://home-loan.sunshinecoastdaily.com.au"" >
    Home Loans
</a> </li> <li> <a href=""/property-guide/"" >
    Property Guide
</a> </li> </ul> </div> </li> <li> <a href=""/classifieds/"" >
    Classifieds
</a> <div class=""secondaryNav""> <ul class=""nav nav-pills""> <li> <a href=""/classifieds/jobs/"" >
    Jobs
</a> </li> <li> <a href=""/classifieds/real-estate/"" >
    Property
</a> </li> <li> <a href=""/classifieds/motoring/"" >
    Cars
</a> </li> <li> <a href=""/classifieds/notices/"" >
    Notices
</a> </li> <li> <a href=""http://tributes.sunshinecoastdaily.com.au/obituaries/sunshinecoastdaily-au"" >
    Tributes
</a> </li> <li> <a href=""/classifieds/personals/"" >
    Personals
</a> </li> <li> <a href=""/classifieds/buy-sell"" >
    Buy &amp; Sell
</a> </li> <li> <a href=""/classifieds/trades-services/"" >
    Trades
</a> </li> <li> <a href=""http://sunshinecoastdaily.adperfect.com/"" >
    Place an ad
</a> </li> </ul> </div> </li> </ul> </div> <div class=""navBasedPageBanner""></div> <div class=""contribute""></div> <div class=""alertWrapper""></div> </nav> <div class=""container""> <div id=""newsflash""></div> <div class=""row""> <div class=""span8""> <section> <article class=""newsEntry""  data-overlay-marker='{""is_primary"": true, ""edit_url"": ""/admin/news/newsentry/1926607/"", ""content_type"": ""newsentry"", ""label"": ""Legionella scare in Sunshine Coast Private Hospital""}' data-record-hit=""/record/hit/28/1926607/"" data-content-context='{""contentTypeId"": 28, ""objectId"": 1926607}'> <header> <p class=""tags""> <span class=""label label-success"">Topics:</span>&nbsp;
    
        <a href=""/topic/sunshine-coast-private-hospital/"">sunshine coast private hospital</a> </p> <h1 class=""storyHeadline"">Legionella scare in Sunshine Coast Private Hospital</h1> <div class=""byLine clearfix""> <span class=""byline""> <a href=""#comments"" class=""showComments"">
                            
                                Comments (5)
                            
                            »
                        </a> </span> <span class=""byline""> <ul class=""piped""> <li><i class=""icon-grey icon-user""></i> <a rel=""author"" href=""/profile/kclifford/"">Kate Clifford</a></li> <li><i class=""icon-grey icon-time""></i> 29th Jun 2013 5:25 AM</li> </ul> </span> </div> </header> <aside class=""span2 pull-right ugcContainer""> <div class=""sideBar""> <h3>Story Tools</h3> <div class=""shareTools""> <a href=""#email"" title=""Email"" class=""addthis_button_email""><span class=""icon20x20-envelope""> </span></a> <a href=""#print"" title=""Print""><span class=""icon20x20-printer-invert""> </span></a> <a href=""#share"" title=""Share"" class=""addthis_button""><span class=""icon20x20-share-invert""> </span></a> </div> <div class=""shareTools""> <!--[if IE 6]> <script type=""text/javascript"">
    var addthis_config = {
        services_compact: 'favorites, email, facebook, twitter, buzz',
        services_exclude: 'print'
    }
</script> <![endif]--> <div class=""socialMedia"" data-overlay-marker='{""edit_url"": ""/admin/fragments/fragment/1016/"", ""content_type"": ""fragment"", ""label"": ""social_media_icons""}'> <ul class=""tools""> <!--[if IE 6]><noscript><![endif]--> <li class=""emailfoot""><a class=""addthis_button_email at300b"" title=""Email"" href=""#""><img src=""http://media2.apnonline.com.au/90.1/apncore/images/emailicon.png""></a></li> <li class=""twfoot""><a data-url=""http://www.sunshinecoastdaily.com.au/news/Legionella-scare-in-Sunshine-Coast-Private-Hospita/1926607/"" class=""twitter-share-button"" data-count=""horizontal"">Tweet</a></li> <li class=""gafoot""><div class=""g-plusone"" data-href=""http://www.sunshinecoastdaily.com.au/news/Legionella-scare-in-Sunshine-Coast-Private-Hospita/1926607/"" data-size=""medium"" data-callback=""googlePlusOneAction""></div></li> <li class=""fbfoot""><div class=""fb-like"" data-href=""http://www.sunshinecoastdaily.com.au/news/Legionella-scare-in-Sunshine-Coast-Private-Hospita/1926607/"" data-send=""false"" data-layout=""button_count"" data-width=""67"" data-show-faces=""false""></div></li> <script>
(function(w, d, s) {
  function go() {
    var js,
        fjs = d.getElementsByTagName(s)[0],
        tracker = function (id) {
          return function () {
            if (typeof APNCore !== ""undefined"") {
              APNCore.GA.track_social(id);
            }
            if (id == ""tweetjs"") {
              w.twttr.events.bind('tweet', function (event) {
                var key = ""shared:"";
                if (Activity != null && event.target != null) {
                  if (event.target.baseURI.indexOf('://') > -1) {
                    var path = event.target.baseURI.split('#')[0];
                    key = key + ""/"" + path.split(""/"").slice(3).join(""/"");
                  } else {
                    key = key + event.target.baseURI;
                  }
                  Activity.record(key);
                }
              });
            }
          }
        },
        load = function (url, id) {
          if (d.getElementById(id)) { return; }
          js = d.createElement(s);
          js.src = url;
          js.id = id;
          js.onload = tracker(id);
          fjs.parentNode.insertBefore(js, fjs);
        };
    load('//platform.twitter.com/widgets.js', 'tweetjs');
    load('https://apis.google.com/js/plusone.js', 'gplus1js');
    load('//connect.facebook.net/en_US/all.js#appId=272697932759946&xfbml=1', 'fbjssdk');
  }
  if (w.addEventListener) {
    w.addEventListener(""load"", go, false);
  } else if (w.attachEvent) {
    w.attachEvent(""onload"", go);
  }
  w.googlePlusOneAction = function (response) {
    var key = ""shared:"";
    if (Activity != null && response.state === ""on"") {
      if (response.href.indexOf('://') > -1) {
        var path = response.href.split('#')[0];
        key = key + ""/"" + path.split(""/"").slice(3).join(""/"");
      } else {
        key = key + response.href;
      }
      Activity.record(key);
    }
  }
}(window, document, 'script'));
</script> <!--[if IE 6]></noscript><li><a class=""ie6addthis"" href=""http://www.addthis.com/bookmark.php"" onmouseover=""return addthis_open(this, '', '[URL]', '[TITLE]');"" onmouseout=""addthis_close();"" onclick=""return addthis_sendto();"" style=""float:right;""><img src=""http://s7.addthis.com/static/btn/sm-share-en.gif"" width=""83"" height=""16"" alt=""Bookmark and Share"" style=""border:0""/></a><script type=""text/javascript"" src=""http://s7.addthis.com/js/152/addthis_widget.js#pub=Finda""></script></li><![endif]--> </ul> </div> <!--[if IE 6]><noscript><![endif]--> <script src=""http://s7.addthis.com/js/250/addthis_widget.js#pub=Finda""></script> <script>
    addthis.addEventListener('addthis.menu.share', function (event) {
        var activity = rnn.modules.activity;
        if (activity && event.data.service == ""email"") {
            activity.record(activity.keyFromURL('shared', event.data.url));
        }
    });
</script> <!--[if IE 6]></noscript><![endif]--> <div data-activity-action='{""key"": ""liked:/news/Legionella-scare-in-Sunshine-Coast-Private-Hospita/1926607/"", ""options"": {""url"": ""/record/liked/28/1926607/adf247e267221264cc1d928fcc7dc73e741fb22405fa25eaa510412c70867d03/""}}'></div> <div data-activity-action='{""key"": ""shared:/news/Legionella-scare-in-Sunshine-Coast-Private-Hospita/1926607/"", ""options"": {""url"": ""/record/shared/28/1926607/8783f6c8a04fa98abf51e4f3e2933b0a115ec87d0453906780ad96cdabeca722/""}}'></div> </div> <div class=""margin-top-15""  data-overlay-marker='{""edit_url"": ""/admin/fragments/fragment/2563/"", ""content_type"": ""fragment"", ""label"": ""storytools_story_tools""}'> <center><a href=""http://rightsportal.copyright.com.au/Pages/RepublicationPage.aspx?PublicationType=News"" target=""_blank"">Use this content</a></center> </div> <hr /> </div> </aside> <p>
	WATER from a tap in the critical care unit at Sunshine Coast Private Hospital has tested positive for the potentially deadly legionella bacteria.
</p> <p>
	Hot water systems in 77 public and private hospitals were tested earlier this month.
</p> <p>
	The results were released yesterday.
</p> <p>
	Health Minister Lawrence Springborg ordered the tests after 66-year-old cancer patient John Pearson died after contracting legionnaire's disease during a stay at the Wesley Hospital.
</p> <p>
	Sunshine Coast Private Hospital general manager Terence Seymour said a low volume of a type of legionella bacteria was present in the tap at the time of the test.
</p> <p>
	""The positive test result came from the initial flush of the tap and was not found following a second flush of the tap,"" Mr Seymour said. ""It was not a tap patients could access.""
</p> <p>
	Queensland Health acting chief health officer Stephen Lambert said the detection of the bacteria did not give cause for concern.
</p> <p>
	""Of more than 1300 tests (throughout the state), only 10% have returned a positive result, and only 4% indicated the presence of legionella pneumophilia,"" Mr Lambert said.
</p> <p>
	Mr Seymour said the private hospital's water system was flushed with hot water and disinfected.
</p> <p>
	""A re-test of the outlet was undertaken and tested negative,"" he said.
</p> <p>
	""The hospital took the matter seriously and notified doctors and patients concerned. All patients opted to remain in the ward.""
</p> <p>
	More than 300 hospitals are yet to be tested.
</p> <aside> </aside> <div class=""clearfix margin-top margin-bottom""> <div class=""pull-right margin-left""> <div class=""align-right-text margin-top margin-bottom""><a href=""http://www.sunshinecoastdaily.com.au/""><img alt=""The Sunshine Coast Daily"" title=""The Sunshine Coast Daily"" src=""http://media2.apnonline.com.au/img/source/sunshinecoastdaily_small__.gif"" /> </a></div> </div> <div class=""margin-top""> <p class=""tags""> <span class=""label label-success"">Topics:</span>&nbsp;
    
        <a href=""/topic/sunshine-coast-private-hospital/"">sunshine coast private hospital</a> </p> </div> </div> <hr /> <div class=""inStoryPanes clearfix""> </div> <div class=""margin-top-15 noPrint""  data-overlay-marker='{""edit_url"": ""/admin/fragments/fragment/2929/"", ""content_type"": ""fragment"", ""label"": ""default_after_story""}'> <script type=""text/javascript""><!--

google_ad_client = ""ca-pub-3822779977807264"";

/* Google-Contextual-Article */

google_ad_slot = ""5534806885"";

google_override_format = true;

google_ad_width = 620;

google_ad_height = 60;

//--> </script> <script type=""text/javascript"" src=""http://pagead2.googlesyndication.com/pagead/show_ads.js""> </script> <hr> <div> <div class=""OUTBRAIN""  data-widget-id=""AR_1"" data-ob-template=""Sunshine_Coast_Daily"" async=""async""> </div> <script type=""text/javascript"" src=""http://widgets.outbrain.com/outbrain.js""></script> <script>
$(document).ready(function() {
$('div.OUTBRAIN div.ob-text-content a').addClass('track').attr('data-category', 'OutBrain').attr('data-action', 'Recommended').attr('data-label','Headline');
$('div.OUTBRAIN div.ob-rec-link-img a').addClass('track').attr('data-category', 'OutBrain').attr('data-action', 'Recommended').attr('data-label','Image');
$('div.OUTBRAIN div.ob_dual_right a').addClass('track').attr('data-category', 'OutBrain').attr('data-action', 'Around the web').attr('data-label','Headline');
});
</script> </div> <hr /> <section  data-overlay-marker='{""edit_url"": ""/admin/containers/pane/1362/"", ""content_type"": ""pane"", ""label"": ""inline-story-realEstate""}'> <div class=""row""> <div class=""span2""> <header> <div class=""sectionBanner""> <h2 class=""shrunk"">inline-story-realEstate</h2> </div> </header> </div> <div class=""span8""  data-overlay-marker='{""is_supplemental"": true, ""content_type"": ""pane_zone"", ""label"": ""Main Column""}'> <div  data-content-edit-url=""/admin/containers/container/4489/"" data-content-model=""container"" data-content-name=""inline-story-realEstate""  > <div class=""recurring-inline-normal""  data-overlay-marker='{""edit_url"": ""/admin/inlines/recurringinline/3307/"", ""content_type"": ""recurringinline"", ""label"": ""inline-story-realEstate""}'> <style>

.bbc li {
        padding-left:20px;
}

.bbc li.bedrooms {
	background: url(/real-estate/_assets/2063/images/../../1893/images/Bedrooms.png) no-repeat left;
}
.bbc li.bathrooms {
	background: url(/real-estate/_assets/2063/images/../../1893/images/Bathrooms.png) no-repeat left;
}
.bbc li.carspaces {
	background: url(/real-estate/_assets/2063/images/../../1893/images/Carspaces.png) no-repeat left;
}
div.inline-story-realEstate h3{
	margin-bottom: 0;
}
div.inline-story-realEstate h4{
	color:#54ae04;
        font-weight:bold;
        font-size:16px;
}
div.inline-story-realEstate h5{
	color:#8a8a8a;
        font-weight:normal;
}
p.realestateHeader{height:40px; overflow:hidden;}
div.inline-story-realEstate hr {
        border-top: 1px solid #e7e7e7;
        margin: 7px 0px;
}
div.inline-story-realEstate img{
	width:130px;
        height:auto;
}
div.inline-story-realEstate article{
	max-width:200px;
	float:left;
        padding-right: 10px;
}
div.inline-story-realEstate article:last-child{
        padding-right: 0px;
}
div.inline-story-realEstate p.realestateHeader, div.inline-story-realEstate p.realestateHeader a{
	max-width:200px;
        font-weight:bold;
        color:#666;
}
div.inline-story-realEstate a.thumbnail {
        width: 130px;
        height: 97px;
        float: left;
        margin-right: 9px;
}
[data-overlay-marker*=""inline-story-realEstate""] div.span2 {
display: none;
}
</style> <div class=""inline-story-realEstate row""></div> <script>
	$(document).ready(function() {
		RealEstateFullWidthFinalHtml = '';
		var dataRequest = $.ajax({
			url : 'http://www.sunshinecoastdaily.com.au/real-estate/api/apn/search?bedmin=3&pricemin=500000&apikey=apn_SDFDSITERPKGKDSQJOEJFJSVZMKd&limit=10&offset=2&subscriptionLevel=1&bedroomsMinimum=1',
			success : function(ajaxData) {
				var newData = ajaxData.Listings;
				var randomNewData = newData.sort(function(){ return Math.random()-0.5; });   
				RealEstateFullWidthFinalHtml += '<div class=""span8""><a data-category=""Real Estate In-line Widget"" data-action=""More Link"" href=""/real-estate/"" class=""raquo track"" style=""float: right;"">view more</a><h3>Real Estate</h3><hr>';
				for (var i = 0; (i < randomNewData.length) && (i < 3); i++) {
					RealEstateFullWidthFinalHtml += '<article class=""propertyUnitWrapper""><div class=""overlayable"">';
					var item = newData[i];
					RealEstateFullWidthFinalHtml += '<p class=""realestateHeader""><a class=""track"" data-category=""Real Estate In-line Widget"" data-action=""Heading"" href=""' + item.propertyLink + '"">' + item.heading + '</a></p><div class=""clearfix""><a class=""track"" data-category=""Real Estate In-line Widget"" data-action=""Image"" href=""' + item.propertyLink + '"" class=""imgLink realestateImage thumbnail""><img style=""float:left; padding-right:5px;"" src=""' + item.thumbnail.url + '"" /></a><ul class=""bbc unstyled"" style=""float:left;""><li class=""bedrooms"">' + item.bedrooms + '</li><li class=""bathrooms"">' + item.bathrooms +'</li><li class=""carspaces"">' + item.garages + '</li></ul></div><div class=""meta""><h4>' + item.address.suburb+ '</h4><h5>' + item.price + '</h5></div></div></article>';
				}
				RealEstateFullWidthFinalHtml += '</div>';
				$('div.inline-story-realEstate').html(RealEstateFullWidthFinalHtml);
			}
		});
	}); 
</script> </div> </div> </div> </div> </section> </div> <hr /> <div id=""comments"" class=""comments"" data-comments-url=""/comments/json/news/newsentry/1926607/""></div> <style type=""text/css"">

    /* IMPORTANT TO KEEP */

    .comments-frozen .btn.reply {
        display: none;
    }
    
</style> <div class=""footerFragment""  data-overlay-marker='{""edit_url"": ""/admin/fragments/fragment/2466/"", ""content_type"": ""fragment"", ""label"": ""story_detail_footer""}'> <section  data-overlay-marker='{""edit_url"": ""/admin/containers/pane/1007/"", ""content_type"": ""pane"", ""label"": ""Around the Network""}'> <div class=""row""> <div class=""span2""> <header> <div class=""sectionBanner""> <h2 class=""shrunk"">Around the Network</h2> </div> </header> </div> <div class=""span8""  data-overlay-marker='{""is_supplemental"": true, ""content_type"": ""pane_zone"", ""label"": ""Main Column""}'> <div  data-overlay-marker='{""edit_url"": ""/admin/containers/container/4119/"", ""content_type"": ""container"", ""label"": ""Latest news from the dailies""}' data-tab-name="" ""> <h3> </h3> <ul class=""arrowList""> <li  data-overlay-marker='{""edit_url"": ""/admin/external_rss/rssdata/336500/"", ""content_type"": ""rssdata"", ""label"": ""RssData object""}'> <a href=""http://www.northernstar.com.au/news/reports-of-serious-accident-between-b-double-and-c/1921045/"">Reports of serious accident between B-double and car</a> </li> <li  data-overlay-marker='{""edit_url"": ""/admin/external_rss/rssdata/336501/"", ""content_type"": ""rssdata"", ""label"": ""RssData object""}'> <a href=""http://www.northernstar.com.au/news/some-surprises-in-regions-competitiveness-ranking/1921017/"">Some surprises in region’s competitiveness ranking</a> </li> <li  data-overlay-marker='{""edit_url"": ""/admin/external_rss/rssdata/336502/"", ""content_type"": ""rssdata"", ""label"": ""RssData object""}'> <a href=""http://www.dailyexaminer.com.au/news/council-gallery-fills-for-rates-debate/1920961/"">Council gallery fills for rates debate</a> </li> <li  data-overlay-marker='{""edit_url"": ""/admin/external_rss/rssdata/336486/"", ""content_type"": ""rssdata"", ""label"": ""RssData object""}'> <a href=""http://www.northernstar.com.au/news/reports-serious-accident-between-b-double-and-car/1920966/"">Reports of serious accident between B-double and car</a> </li> <li  data-overlay-marker='{""edit_url"": ""/admin/external_rss/rssdata/336487/"", ""content_type"": ""rssdata"", ""label"": ""RssData object""}'> <a href=""http://www.warwickdailynews.com.au/news/family-and-farm-fulfil-beryl/1918935/"">Family and farm offer a fulfilling life</a> </li> <li  data-overlay-marker='{""edit_url"": ""/admin/external_rss/rssdata/336470/"", ""content_type"": ""rssdata"", ""label"": ""RssData object""}'> <a href=""http://www.frasercoastchronicle.com.au/news/bay-police-allegedly-discover-drug-lab-equipment-c/1920817/"">Bay police allegedly discover drug lab equipment in car</a> </li> </ul> <div class=""pull-left""> <a class=""raquo moreNewsLink"" href="" ""> </a> </div> </div> <div  data-overlay-marker='{""edit_url"": ""/admin/containers/container/4120/"", ""content_type"": ""container"", ""label"": ""More news from the communities""}' data-tab-name="" ""> <h3> </h3> <ul class=""arrowList""> <li  data-overlay-marker='{""edit_url"": ""/admin/external_rss/rssdata/336508/"", ""content_type"": ""rssdata"", ""label"": ""RssData object""}'> <a href=""http://www.stanthorpeborderpost.com.au/news/snow-falls-eukey/1921144/"">Snow falls at Eukey</a> </li> <li  data-overlay-marker='{""edit_url"": ""/admin/external_rss/rssdata/336499/"", ""content_type"": ""rssdata"", ""label"": ""RssData object""}'> <a href=""http://www.suratbasin.com.au/news/roma-hospital-be-tested-legionella/1920969/"">Roma hospital to be tested for legionella</a> </li> <li  data-overlay-marker='{""edit_url"": ""/admin/external_rss/rssdata/336468/"", ""content_type"": ""rssdata"", ""label"": ""RssData object""}'> <a href=""http://www.suratbasin.com.au/news/saxon-energy-confirms-worker-has-died-fairview/1920803/"">Saxon energy confirms a worker has died at Fairview</a> </li> <li  data-overlay-marker='{""edit_url"": ""/admin/external_rss/rssdata/336453/"", ""content_type"": ""rssdata"", ""label"": ""RssData object""}'> <a href=""http://www.whitsundaytimes.com.au/news/bodybuilder-takes-out-top-title-for-second-year/1913418/"">Bodybuilder takes out top title for second year</a> </li> <li  data-overlay-marker='{""edit_url"": ""/admin/external_rss/rssdata/336469/"", ""content_type"": ""rssdata"", ""label"": ""RssData object""}'> <a href=""http://www.southburnetttimes.com.au/news/legionella-bacteria-found-south-burnett-hospitals/1920801/"">Legionella bacteria found at South Burnett hospitals</a> </li> <li  data-overlay-marker='{""edit_url"": ""/admin/external_rss/rssdata/336429/"", ""content_type"": ""rssdata"", ""label"": ""RssData object""}'> <a href=""http://www.thesatellite.com.au/news/journey-of-pure-power/1918883/"">Journey of pure power</a> </li> </ul> <div class=""pull-left""> <a class=""raquo moreNewsLink"" href="" ""> </a> </div> </div> <div  data-content-edit-url=""/admin/containers/container/4173/"" data-content-model=""container"" data-content-name=""Fixes: Fixes for Around the Network""  > <div class=""recurring-inline-normal""  data-overlay-marker='{""edit_url"": ""/admin/inlines/recurringinline/2836/"", ""content_type"": ""recurringinline"", ""label"": ""Around the Network - fixes""}'> <style>
[data-overlay-marker*=""Around the Network""] h2{
font-size:14px !important;
}
[data-overlay-marker*=""Around the Network""] a.raquo.moreNewsLink{display:none !important;}

[data-overlay-marker*=""Around the Network""] div.row article p{display:none;}

</style> <script>
$(function(){
$('[data-overlay-marker*=""Around the Network""] div.row article h4 a').attr('target', '_blank');
});

</script> </div> </div> </div> </div> </section> </div> </article> </section> </div> <div class=""span4""> <div  data-overlay-marker='{""edit_url"": ""/admin/containers/pane/914/"", ""content_type"": ""pane"", ""label"": ""Sidebar AU (with real-estate)""}'> <div  data-content-edit-url=""/admin/containers/container/3059/"" data-content-model=""container"" data-content-name=""Local Partners""  > <div class=""recurring-inline-normal""  data-overlay-marker='{""edit_url"": ""/admin/inlines/recurringinline/2538/"", ""content_type"": ""recurringinline"", ""label"": ""Sales Carousel""}'> <div class=""aside adGroup""> <h2 class=""asideHeader"">Local Partners</h2> <div class=""horizontal-promotions""> <div class=""itemCarousel adCarousel"" data-autorotate=""4000""> <div class=""items asideItemList""> <div class=""item asideItem adSpace"" id=""localCarouselAd0""></div> <div class=""item asideItem adSpace"" id=""localCarouselAd1""></div> <div class=""item asideItem adSpace"" id=""localCarouselAd2""></div> <div class=""item asideItem adSpace"" id=""localCarouselAd3""></div> <div class=""item asideItem adSpace"" id=""localCarouselAd4""></div> <div class=""item asideItem adSpace"" id=""localCarouselAd5""></div> <div class=""item asideItem adSpace"" id=""localCarouselAd6""></div> <div class=""item asideItem adSpace"" id=""localCarouselAd7""></div> <div class=""item asideItem adSpace"" id=""localCarouselAd8""></div> <div class=""item asideItem adSpace"" id=""localCarouselAd9""></div> <div class=""item asideItem adSpace"" id=""localCarouselAd10""></div> <div class=""item asideItem adSpace"" id=""localCarouselAd11""></div> <div class=""item asideItem adSpace"" id=""localCarouselAd12""></div> <div class=""item asideItem adSpace"" id=""localCarouselAd13""></div> <div class=""item asideItem adSpace"" id=""localCarouselAd14""></div> <div class=""item asideItem adSpace"" id=""localCarouselAd15""></div> <div class=""item asideItem adSpace"" id=""localCarouselAd16""></div> <div class=""item asideItem adSpace"" id=""localCarouselAd17""></div> <div class=""item asideItem adSpace"" id=""localCarouselAd18""></div> <div class=""item asideItem adSpace"" id=""localCarouselAd19""></div> <div class=""item asideItem adSpace"" id=""localCarouselAd20""></div> </div> <button type=""button"" class=""carouselControls prev""><span class=""icon14x14-circled-arrow-left""></span></button> <button type=""button"" class=""carouselControls next""><span class=""icon14x14-circled-arrow-right""></span></button> </div> </div> </div> </div> </div> <div  data-content-edit-url=""/admin/containers/container/3057/"" data-content-model=""container"" data-content-name=""MREC #1""  > <div class=""recurring-inline-normal""  data-overlay-marker='{""edit_url"": ""/admin/inlines/recurringinline/2144/"", ""content_type"": ""recurringinline"", ""label"": ""MREC #1""}'> <div class=""adGroup adGroupLabel margin-bottom-15"" style=""font-size: 10px; text-transform: uppercase; margin-top:15px;""> <div id=""adSpace1"" class=""adSpace""></div> </div> </div> </div> <div class=""aside""> <h2 class=""asideHeader"">Promotions</h2> <div class=""horizontal-promotions""  data-overlay-marker='{""edit_url"": ""/admin/containers/container/4343/"", ""content_type"": ""container"", ""label"": ""Promotions""}' data-tab-name=""Promotions""> <div class=""itemCarousel"" data-autorotate=""4000""> <div class=""items""> <div class=""item""  data-overlay-marker='{""edit_url"": ""/admin/advertising/advertisement/760/"", ""content_type"": ""advertisement"", ""label"": ""Australia Zoo Facebook Promo""}'> <div class=""asideItem""> <a href=""https://www.facebook.com/thesunshinecoastdaily/"" class=""thumbnail"" target=""_blank""><img src=""http://media2.apnonline.com.au/img/media/images/2013/06/21/CR86325AB_ct114x86.jpg"" width=""114"" height=""86"" alt="""" title="""" /></a> <p> <strong>Win a Rhino Encounter from Australia Zoo</strong> </p> <p>
	Like the Sunshine Coast Daily Facebook page
</p> <p> <strong><a href=""https://www.facebook.com/thesunshinecoastdaily/""><u>Click Here</u></a></strong> </p> </div> </div> <div class=""item""  data-overlay-marker='{""edit_url"": ""/admin/advertising/advertisement/757/"", ""content_type"": ""advertisement"", ""label"": ""Coast Life ""}'> <div class=""asideItem""> <a href=""http://www.sunshinecoastdaily.com.au/digital-edition/coast-life/"" class=""thumbnail"" target=""_blank""><img src=""http://media2.apnonline.com.au/img/media/images/2013/06/14/SCN_14-06-2013_EGN_01_Coast%20Winter%20Cover%202013_ct114x86.jpg"" width=""114"" height=""86"" alt="""" title="""" /></a> <p> <strong>Coast Life</strong> </p> <p>
	Featuring&nbsp;all the&nbsp;best attractions the Sunshine Coast has to offer
</p> <p> <a href=""http://www.sunshinecoastdaily.com.au/digital-edition/coast-life/""><u><strong>Click Here</strong></u></a> </p> </div> </div> <div class=""item selected""  data-overlay-marker='{""edit_url"": ""/admin/advertising/advertisement/756/"", ""content_type"": ""advertisement"", ""label"": ""Dusty promo""}'> <div class=""asideItem""> <a href=""/news/dusty-dexter-pi-paris-case-novel-part-one/1908826/"" class=""thumbnail""><img src=""http://media2.apnonline.com.au/img/media/images/2013/06/15/Screen_Shot_2013-06-15_at_6.22.06_AM_1_ct114x86.jpg"" width=""114"" height=""86"" alt="""" title="""" /></a> <p> <strong>DUSTY DEXTER PI</strong> </p> <p> <strong>The Paris Case</strong> </p> <p>
	Our sexy private investigator is back on the case in Paris.
</p> <p> <a href=""/news/dusty-dexter-pi-paris-case-novel-part-one/1908826/"">Find out more here</a> </p> </div> </div> <div class=""item""  data-overlay-marker='{""edit_url"": ""/admin/advertising/advertisement/719/"", ""content_type"": ""advertisement"", ""label"": ""Buy Photos""}'> <div class=""asideItem""> <a href=""/photos/buy/"" class=""thumbnail""><img src=""http://media2.apnonline.com.au/img/media/images/2013/06/04/buyphotos_ct114x86.JPG"" width=""114"" height=""86"" alt="""" title="""" /></a> <p> <strong>BUY A PHOTO</strong> </p> <p>
	Local photos, taken by our staff, are available to buy.
</p> <p> <a href=""/photos/buy/"">Check out the latest photos here</a> </p> </div> </div> <div class=""item""  data-overlay-marker='{""edit_url"": ""/admin/advertising/advertisement/680/"", ""content_type"": ""advertisement"", ""label"": ""ePaper promotional spot - SCD""}'> <div class=""asideItem""> <a href=""http://sunshinecoastdaily.newspaperdirect.com/epaper/viewer.aspx"" class=""thumbnail""><img src=""http://media2.apnonline.com.au/img/media/images/2013/05/15/Promotions_SunnyCoast_ct114x86.png"" width=""114"" height=""86"" alt="""" title="""" /></a> <p> <strong>Free 6-day VIP access </strong>to The Sunshine Coast Daily&#39;s new ePaper
</p> <p>
	Get your exclusive digital access today!
</p> <p> <strong>Click <a href=""http://www.sunshinecoastdaily.com.au/epaper"">here</a></strong> </p> </div> </div> </div> <button type=""button"" class=""carouselControls prev""><i class=""icon14x14-circled-arrow-left""></i></button> <button type=""button"" class=""carouselControls next""><i class=""icon14x14-circled-arrow-right""></i></button> </div> </div> </div> <div class=""loginModal modal hide fade"" tabindex=""-1"" role=""dialog"" aria-labelledby=""loginModalLabel"" aria-hidden=""true""> <div class=""modal-header""> <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">x</button> <h3>Log in to follow this topic:</h3> </div> <div class=""modal-body""></div> </div> <div class=""aside""> <ul class=""nav nav-tabs""> <li class=""active""><a href=""#mostPopAsideStories"" data-toggle=""tab"">Stories</a></li> <li><a href=""#mostPopAsideTopics"" data-toggle=""tab"">Topics</a></li> <li><a href=""#mostPopAsideComments"" data-toggle=""tab"">Comments</a></li> </ul> <div class=""tab-content""> <div class=""tab-pane active"" id=""mostPopAsideStories""> <div class=""mostPopularTopicItem""  data-overlay-marker='{""edit_url"": ""/admin/news/newsentry/1926577/"", ""content_type"": ""newsentry"", ""label"": ""Attack victim haunted by fear""}'> <div class=""meta""> <div class=""position"">
                        1
                    </div> </div> <div class=""followHeadline""> <h3> <a href=""/news/attack-victim-haunted-by-fear/1926577/"">
                            Attack victim haunted by&nbsp;fear
                        </a> </h3> </div> </div> <div class=""mostPopularTopicItem""  data-overlay-marker='{""edit_url"": ""/admin/news/newsentry/1926702/"", ""content_type"": ""newsentry"", ""label"": ""Property hotspots from central Queensland to northern NSW""}'> <div class=""meta""> <div class=""position"">
                        2
                    </div> </div> <div class=""followHeadline""> <h3> <a href=""/news/property-hotspots-central-queensland-northern-nsw/1926702/"">
                            Property hotspots from central Queensland to northern&nbsp;NSW
                        </a> </h3> </div> </div> <div class=""mostPopularTopicItem""  data-overlay-marker='{""edit_url"": ""/admin/news/newsentry/1926607/"", ""content_type"": ""newsentry"", ""label"": ""Legionella scare in Sunshine Coast Private Hospital""}'> <div class=""meta""> <div class=""position"">
                        3
                    </div> </div> <div class=""followHeadline""> <h3> <a href=""/news/Legionella-scare-in-Sunshine-Coast-Private-Hospita/1926607/"">
                            Legionella scare in Sunshine Coast Private&nbsp;Hospital
                        </a> </h3> </div> </div> <div class=""mostPopularTopicItem""  data-overlay-marker='{""edit_url"": ""/admin/news/newsentry/1926782/"", ""content_type"": ""newsentry"", ""label"": ""Buddina attack wont stop defiant women from running""}'> <div class=""meta""> <div class=""position"">
                        4
                    </div> </div> <div class=""followHeadline""> <h3> <a href=""/news/defiant-women-to-keep-on-running/1926782/"">
                            Buddina attack won't stop defiant women from&nbsp;running
                        </a> </h3> </div> </div> <div class=""mostPopularTopicItem last""  data-overlay-marker='{""edit_url"": ""/admin/news/newsentry/1926674/"", ""content_type"": ""newsentry"", ""label"": ""The fillies will be the ones to watch at Caloundra""}'> <div class=""meta""> <div class=""position"">
                        5
                    </div> </div> <div class=""followHeadline""> <h3> <a href=""/news/the-fillies-will-be-the-ones-to-watch/1926674/"">
                            The fillies will be the ones to watch at&nbsp;Caloundra
                        </a> </h3> </div> </div> </div> <div class=""tab-pane"" id=""mostPopAsideTopics""> <div class=""follow-meta mostPopularTopicItem""> <div class=""follower-button""> <button
    name=""follow""
    value=""Follow""
    class=""btn btn-primary btn-mini follow-lookup""
    data-follow-key=""ZQnFSzWMf-kemm7QOtLUVYOh9a_BJBfdAd1KMJokpj5LV4mYy_rg2OakcbbKEa79AQgbqq9tkumljbH0OB8KAPkise2Dd_V8WX8WKYLeZvV8_Mx91Nxgbyh8HLoGXBibcPuVXiU_KvJmB1CN3QCBe_uHwXRdGC_SGQ_IPhE4F4J7pkW9PlqYohSR3I51MbyKw8qqrZEOjN78QPOlrwA5SRUstLLDkC4gUVo4_29ox3voGfSk10sI_2Wy5FLxxXyt""
    data-follow-text=""Follow""
    data-unfollow-text=""Unfollow""
    data-loading-text=""Loading...""
    data-title=""Login to follow"">
    Follow
</button> </div> <div class=""meta""> <div class=""position"">1</div> </div> <div class=""followHeadline""> <h3 class=""capitals""> <a href=""/topic/lost-and-found/"">
                                Lost and&nbsp;found
                            </a> <span class=""followers-count""> <span class=""num"">4</span> <span class=""text"">Followers</span> </span> </h3> </div> </div> <div class=""follow-meta mostPopularTopicItem""> <div class=""follower-button""> <button
    name=""follow""
    value=""Follow""
    class=""btn btn-primary btn-mini follow-lookup""
    data-follow-key=""ZQnFSzWMf-kemm7QOtLUVQmWZba1_get_ofydK8r42Qlwee3yg9WZgvRXMeyw4SeyFvoqXxL3x2KXQoHLZuDFWQg8cZQHLmNo74Yrmgn-a2FMjzrqKjS_4cRCcddIDOctiJqGgmtkBsJhL4KHkRTUiaNdJhecO-9sNnaBAfhv7zaQlvRRWFxlmvbAIJa7UrcRgZx9GGUSjuSX3vkMhkoXgcVliu5bbErgcwxQSP5sM8lCi5dAGI72bAGzzhtmUQ9""
    data-follow-text=""Follow""
    data-unfollow-text=""Unfollow""
    data-loading-text=""Loading...""
    data-title=""Login to follow"">
    Follow
</button> </div> <div class=""meta""> <div class=""position"">2</div> </div> <div class=""followHeadline""> <h3 class=""capitals""> <a href=""/topic/employment/"">
                                Employment
                            </a> <span class=""followers-count""> <span class=""num"">1</span> <span class=""text"">Follower</span> </span> </h3> </div> </div> <div class=""follow-meta mostPopularTopicItem""> <div class=""follower-button""> <button
    name=""follow""
    value=""Follow""
    class=""btn btn-primary btn-mini follow-lookup""
    data-follow-key=""ZQnFSzWMf-kemm7QOtLUVTd4VQM2xJhXob_3vny37Mw0qL5FjxBCqWmw3VfaMZF3HhZ1SH0H3SoUzp-flgGZHR_8R-bedRp5EtTYLF0OqVc1_64D7mRdrHx9A4kuEvRWATqdvSvcZ0jYepMTuPiLelEuc7R3j0EO-w2ppTefsq13aVG8DUAZlnPio6-l1RX5ng3f3aEhkhYs4yMs93Bs9_ab61o0L964a6kP9vcJr_Hr80wavZ-vbb9y3tTNAlaT""
    data-follow-text=""Follow""
    data-unfollow-text=""Unfollow""
    data-loading-text=""Loading...""
    data-title=""Login to follow"">
    Follow
</button> </div> <div class=""meta""> <div class=""position"">3</div> </div> <div class=""followHeadline""> <h3 class=""capitals""> <a href=""/topic/jobs/"">
                                Jobs
                            </a> <span class=""followers-count""> <span class=""num"">1</span> <span class=""text"">Follower</span> </span> </h3> </div> </div> <div class=""follow-meta mostPopularTopicItem""> <div class=""follower-button""> <button
    name=""follow""
    value=""Follow""
    class=""btn btn-primary btn-mini follow-lookup""
    data-follow-key=""ZQnFSzWMf-kemm7QOtLUVaZcqdNqP-aIU98rpV5yx7xsHga7-PqBgrvaVQRoQdpTGZq93hqn5gfUq1rO2dwzhpH5PboA8-0Nd3rVXJfyR3lEz4tMsCEhccy_dtrc_kP3c92OCC58GCPrekWSQ9Im0l4vvdkZb29ekC7ACDPeSxQkFE1jGo-dpVFfhJJwAI9c49vsjMm95c-DrfoYmJaW-yjBH3ixfsTJYaH2aY4kv2jeEJmna6I2shUiQJWVi1L4""
    data-follow-text=""Follow""
    data-unfollow-text=""Unfollow""
    data-loading-text=""Loading...""
    data-title=""Login to follow"">
    Follow
</button> </div> <div class=""meta""> <div class=""position"">4</div> </div> <div class=""followHeadline""> <h3 class=""capitals""> <a href=""/topic/federal-election-2013/"">
                                Federal election&nbsp;2013
                            </a> <span class=""followers-count""> <span class=""num"">1</span> <span class=""text"">Follower</span> </span> </h3> </div> </div> <div class=""follow-meta mostPopularTopicItem last""> <div class=""follower-button""> <button
    name=""follow""
    value=""Follow""
    class=""btn btn-primary btn-mini follow-lookup""
    data-follow-key=""ZQnFSzWMf-kemm7QOtLUVV8FoExEAv5R4Irw0dNduuoLysy_G8yQU2iZuwnc2MOheolLzaKaPT4NbKhdTuzU6dKeisqexPH_lK9pYevzlHDR2VpXUniNxD7NJmQGhHeWED22NhzO_ZdYIzfmn98CwabnOXe3w3gyUbE2r6W17gf0qV9Xd6ek6_-oqWe-xForEi_yv4p9i-QM-ONNBzr_Lr0iGQilh0lS4UVmmKtOE39XE9ZfNvzjpoO8R5MvlZrt""
    data-follow-text=""Follow""
    data-unfollow-text=""Unfollow""
    data-loading-text=""Loading...""
    data-title=""Login to follow"">
    Follow
</button> </div> <div class=""meta""> <div class=""position"">5</div> </div> <div class=""followHeadline""> <h3 class=""capitals""> <a href=""/topic/john-stokes/"">
                                John&nbsp;stokes
                            </a> <span class=""followers-count""> <span class=""num"">1</span> <span class=""text"">Follower</span> </span> </h3> </div> </div> </div> <div class=""tab-pane"" id=""mostPopAsideComments""> <div class=""mostPopularTopicItem""> <span class=""pull-right commentBubbleAside""> <a href=""/news/independents-party-would-aim-to-reduce-penalty-rat/1918307/#comments""> <span class=""badge badge-comment"">
                                118
                            </span> </a> </span> <div class=""meta""> <div class=""position"">1</div> </div> <div class=""followHeadline""> <h3> <a href=""/news/independents-party-would-aim-to-reduce-penalty-rat/1918307/"">
                                Independents say it's time to take axe to weekend&nbsp;penalties
                            </a> </h3> </div> </div> <div class=""mostPopularTopicItem""> <span class=""pull-right commentBubbleAside""> <a href=""/news/rudd-challenges-tony-abbott-debate-debt-and-defici/1925522/#comments""> <span class=""badge badge-comment"">
                                89
                            </span> </a> </span> <div class=""meta""> <div class=""position"">2</div> </div> <div class=""followHeadline""> <h3> <a href=""/news/rudd-challenges-tony-abbott-debate-debt-and-defici/1925522/"">
                                Rudd challenges Tony Abbott for open vote on gay&nbsp;marriage
                            </a> </h3> </div> </div> <div class=""mostPopularTopicItem""> <span class=""pull-right commentBubbleAside""> <a href=""/news/kevins-facing-hell-says-brother/1923608/#comments""> <span class=""badge badge-comment"">
                                59
                            </span> </a> </span> <div class=""meta""> <div class=""position"">3</div> </div> <div class=""followHeadline""> <h3> <a href=""/news/kevins-facing-hell-says-brother/1923608/"">
                                Kevin Rudd's brother warns of hellish ride into&nbsp;election
                            </a> </h3> </div> </div> <div class=""mostPopularTopicItem""> <span class=""pull-right commentBubbleAside""> <a href=""/news/peter-slipper-sexual-harassment-case-speech/1924498/#comments""> <span class=""badge badge-comment"">
                                50
                            </span> </a> </span> <div class=""meta""> <div class=""position"">4</div> </div> <div class=""followHeadline""> <h3> <a href=""/news/peter-slipper-sexual-harassment-case-speech/1924498/"">
                                Slipper makes claims against Mal Brough, Joe&nbsp;Hockey
                            </a> </h3> </div> </div> <div class=""mostPopularTopicItem last""> <span class=""pull-right commentBubbleAside""> <a href=""/news/our-choking-point-no-relief-as-coast-rails-no-prio/1925239/#comments""> <span class=""badge badge-comment"">
                                41
                            </span> </a> </span> <div class=""meta""> <div class=""position"">5</div> </div> <div class=""followHeadline""> <h3> <a href=""/news/our-choking-point-no-relief-as-coast-rails-no-prio/1925239/"">
                                Second class: Travel to Brisbane may be locked up for&nbsp;decades
                            </a> </h3> </div> </div> </div> </div> </div> <div  data-content-edit-url=""/admin/containers/container/4291/"" data-content-model=""container"" data-content-name=""UGC Widget: generic UGC widget for call to actions""  > <div class=""recurring-inline-normal""  data-overlay-marker='{""edit_url"": ""/admin/inlines/recurringinline/3006/"", ""content_type"": ""recurringinline"", ""label"": ""UGC Widget""}'> <style>
	div.globalWrapper div div a{
		width:96px;
	}
	div.globalWrapper div div{
		height:34px;
		padding-bottom: 20px;
	}
	div.globalWrapper div div.floating{float:left;}
		div.globalWrapper div div.right{padding-left:20px;}

</style> <div class=""aside""> <h2 class=""asideHeader"">Share Your...</h2> <p style=""padding-bottom: 20px;"">Help make the news! Share your photos, stories, events or just post a general notice to the community. </p> <div class=""clearfix""></div> <div class=""globalWrapper""> <div> <div class=""left floating""> <a href=""/your-story/"" class=""btn btn-primary btn-maxi"" style=""font-size:14px;padding:7px 15px;margin-top:-8px;"">Story</a> </div> <div class=""right floating""> <a href=""/share-your-photo/"" class=""btn btn-primary btn-maxi"" style=""font-size:14px;padding:7px 15px;margin-top:-8px;"">Photos</a> </div> </div> <div class=""clearfix""></div> <div class=""bottomRow""> <div class=""left floating""> <a href=""/things-to-do/add/"" class=""btn btn-primary btn-maxi"" style=""font-size:14px;padding:7px 15px;margin-top:-8px;"">Event</a> </div> <div class=""right floating""> <a href=""/noticeboard/"" class=""btn btn-primary btn-maxi"" style=""font-size:14px;padding:7px 15px;margin-top:-8px;"">Notice</a> </div> </div> <div class=""clearfix""></div> </div> </div> </div> </div> <div class=""aside""> <h2 class=""asideHeader"">Stay Connected</h2> <div class=""only-non-authenticated-user""> <form action=""http://sunshinecoastdaily.us4.list-manage2.com/subscribe/post?u=1466bf8f48388da3c4ca73494&amp;amp;id=97bb8d5d97"" method=""post"" target=""_blank"" class=""form-inline""> <div class=""margin-bottom""> <p>Get the news as it happens, in your inbox</p> </div> <fieldset> <label class=""control-label""><strong>Subscribe to:</strong></label> <label class=""checkbox inline""> <input checked=""checked"" type=""checkbox"" value=""1"" name=""group[813][1]"">
                        AM
                    </label> <label class=""checkbox inline""> <input checked=""checked"" type=""checkbox"" value=""2"" name=""group[813][2]"">
                        PM
                    </label> <label class=""checkbox inline""> <input checked=""checked"" type=""checkbox"" value=""4"" name=""group[813][4]"">
                        NIE
                    </label> </fieldset> <input type=""email"" name=""EMAIL"" class=""input-medium input-tall"" placeholder=""Your email address"" /> <button type=""submit"" class=""btn btn-large""><i class=""icon14x14-circled-arrow-right""></i> Submit</button> </form> </div> <div class=""only-authenticated-user""> <h3 class=""asideSubHeading"">You can change the newsletters you are subscribed to when you edit your profile</h3> <p class=""center-text""> <a href=""/my-account/edit/#subscriptions"" class=""btn btn-large""><i class=""icon14x14-circled-arrow-right""></i> Edit Profile</a> </p> </div> <hr /> <div  data-overlay-marker='{""edit_url"": ""/admin/fragments/fragment/2365/"", ""content_type"": ""fragment"", ""label"": ""sidebar_widget_bottom_stay_connected""}'> <p class=""center-text""> <a href=""/homedelivery/"" class=""btn btn-large""><i class=""icon14x14-circled-arrow-right""></i> Subscribe to our paper</a> <p> <hr> <div class=""display-table""> <span class=""cell center-text""><a href=""/twitter/""><i class=""icon32x34-twitter""></i></a></span> <span class=""cell center-text""><a href=""/facebook/""><i class=""icon32x34-facebook""></i></a></span> <span class=""cell center-text""><a href=""/connect/rss/""><i class=""icon32x34-rss""></i></a></span> </div> </div> </div> <div  data-content-edit-url=""/admin/containers/container/3846/"" data-content-model=""container"" data-content-name=""Local Faces""  > <div class=""recurring-inline-normal""  data-overlay-marker='{""edit_url"": ""/admin/inlines/recurringinline/2539/"", ""content_type"": ""recurringinline"", ""label"": ""Local Faces""}'> <div class=""aside adGroup""> <h2 class=""asideHeader"">Local Profile</h2> <div class=""itemCarousel adCarousel"" data-autorotate=""4000""> <div class=""items""> <div class=""item adSpace"" id=""profileAd0""></div> <div class=""item adSpace"" id=""profileAd1""></div> <div class=""item adSpace"" id=""profileAd2""></div> <div class=""item adSpace"" id=""profileAd3""></div> <div class=""item adSpace"" id=""profileAd4""></div> <div class=""item adSpace"" id=""profileAd5""></div> <div class=""item adSpace"" id=""profileAd6""></div> <div class=""item adSpace"" id=""profileAd7""></div> <div class=""item adSpace"" id=""profileAd8""></div> <div class=""item adSpace"" id=""profileAd9""></div> <div class=""item adSpace"" id=""profileAd10""></div> <div class=""item adSpace"" id=""profileAd11""></div> <div class=""item adSpace"" id=""profileAd12""></div> <div class=""item adSpace"" id=""profileAd13""></div> <div class=""item adSpace"" id=""profileAd14""></div> <div class=""item adSpace"" id=""profileAd15""></div> <div class=""item adSpace"" id=""profileAd16""></div> <div class=""item adSpace"" id=""profileAd17""></div> <div class=""item adSpace"" id=""profileAd18""></div> <div class=""item adSpace"" id=""profileAd19""></div> <div class=""item adSpace"" id=""profileAd20""></div> </div> <div class=""center-text margin-top""> <button type=""button"" class=""carouselControls prev""><span class=""icon14x14-circled-arrow-left""></span></button> <button type=""button"" class=""carouselControls next""><span class=""icon14x14-circled-arrow-right""></span></button> </div> </div> </div> </div> </div> <div  data-content-edit-url=""/admin/containers/container/4295/"" data-content-model=""container"" data-content-name=""Special Offers""  > <div class=""recurring-inline-normal""  data-overlay-marker='{""edit_url"": ""/admin/inlines/recurringinline/3022/"", ""content_type"": ""recurringinline"", ""label"": ""Special Offers""}'> <div class=""aside adGroup""> <h2 class=""asideHeader"">Special Offers</h2> <div class=""asideItem adSpace"" id=""sOffer0""></div> </div> </div> </div> <div  data-content-edit-url=""/admin/containers/container/3996/"" data-content-model=""container"" data-content-name=""Deals & Coupons: Deals & Coupons for TC""  > <div class=""recurring-inline-normal""  data-overlay-marker='{""edit_url"": ""/admin/inlines/recurringinline/2641/"", ""content_type"": ""recurringinline"", ""label"": ""Coupons""}'> <div class=""aside adGroup""> <h2 class=""asideHeader"">Latest deals and offers</h2> <div class=""asideItem adSpace"" id=""couponAd0""></div> <div class=""asideItem adSpace"" id=""couponAd1""></div> <div class=""asideItem adSpace"" id=""couponAd2""></div> <div class=""asideItem adSpace"" id=""couponAd3""></div> <div class=""asideItem adSpace"" id=""couponAd4""></div> <div class=""asideItem adSpace"" id=""couponAd5""></div> <div class=""asideItem adSpace"" id=""couponAd6""></div> <div class=""asideItem adSpace"" id=""couponAd7""></div> <div class=""asideItem adSpace"" id=""couponAd8""></div> <div class=""asideItem adSpace"" id=""couponAd9""></div> <div class=""asideItem adSpace"" id=""couponAd10""></div> <div class=""asideItem adSpace"" id=""couponAd11""></div> <div class=""asideItem adSpace"" id=""couponAd12""></div> <div class=""asideItem adSpace"" id=""couponAd13""></div> <div class=""asideItem adSpace"" id=""couponAd14""></div> <div class=""asideItem adSpace"" id=""couponAd15""></div> <div class=""asideItem adSpace"" id=""couponAd16""></div> <div class=""asideItem adSpace"" id=""couponAd17""></div> <div class=""asideItem adSpace"" id=""couponAd18""></div> <div class=""asideItem adSpace"" id=""couponAd19""></div> </div> </div> </div> <div  data-content-edit-url=""/admin/containers/container/4011/"" data-content-model=""container"" data-content-name=""Featured properties - small: Featured properties  - small""  > <div class=""recurring-inline-normal""  data-overlay-marker='{""edit_url"": ""/admin/inlines/recurringinline/2646/"", ""content_type"": ""recurringinline"", ""label"": ""Featured properties - small""}'> <iframe seamless=""seamless""  style=""border:none"" id=""renet"" width=""305"" height=""440"" scrolling=""no"" src=""/real-estate/featured-property?lb=true&position=side""></iframe> </div> </div> <div  data-content-edit-url=""/admin/containers/container/3081/"" data-content-model=""container"" data-content-name=""MREC #2""  > <div class=""recurring-inline-normal""  data-overlay-marker='{""edit_url"": ""/admin/inlines/recurringinline/2155/"", ""content_type"": ""recurringinline"", ""label"": ""MREC #2""}'> <div class=""adGroup adGroupLabel margin-bottom-15""> <div id=""adSpace5"" class=""adSpace""></div> </div> </div> </div> <div class=""aside""> <h2 class=""asideHeader"">Horoscopes</h2> <div class=""asideItem hososcopesItem""> <div class=""zodiac zodiac-cancer""></div> <h4><a href=""/horoscopes/#cancer"">Cancer</a></h4> <p>The planets activate love and happiness.&nbsp; You&rsquo;ll feel lucky at the moment, so enjoy the day and share your experiences with others.</p> <p><strong><a class=""ellipsis"" href=""/horoscopes/"">more</a></strong></p> </div> <div class=""asideItem""> <div class=""btn-group""> <button class=""btn btn-large btn-full-width dropdown-toggle"" data-toggle=""dropdown"">
                Select your star sign <span class=""caret""></span> </button> <ul class=""dropdown-menu""> <li><a href=""/horoscopes/#aries"">Aries</a></li> <li><a href=""/horoscopes/#taurus"">Taurus</a></li> <li><a href=""/horoscopes/#gemini"">Gemini</a></li> <li><a href=""/horoscopes/#cancer"">Cancer</a></li> <li><a href=""/horoscopes/#leo"">Leo</a></li> <li><a href=""/horoscopes/#virgo"">Virgo</a></li> <li><a href=""/horoscopes/#libra"">Libra</a></li> <li><a href=""/horoscopes/#scorpio"">Scorpio</a></li> <li><a href=""/horoscopes/#sagittarius"">Sagittarius</a></li> <li><a href=""/horoscopes/#capricorn"">Capricorn</a></li> <li><a href=""/horoscopes/#aquarius"">Aquarius</a></li> <li><a href=""/horoscopes/#pisces"">Pisces</a></li> </ul> </div> </div> </div> <div  data-content-edit-url=""/admin/containers/container/4109/"" data-content-model=""container"" data-content-name=""CMS Skins""  > <div class=""recurring-inline-normal""  data-overlay-marker='{""edit_url"": ""/admin/inlines/recurringinline/2770/"", ""content_type"": ""recurringinline"", ""label"": ""AU Skins""}'> </div> </div> </div> <br> </div> </div> <div class=""row""> <div class=""span12""> <div  data-overlay-marker='{""edit_url"": ""/admin/containers/pane/1376/"", ""content_type"": ""pane"", ""label"": ""Bottom default pane""}'> <div  data-content-edit-url=""/admin/containers/container/4503/"" data-content-model=""container"" data-content-name=""marketplace container container""  > <div class=""recurring-inline-normal""  data-overlay-marker='{""edit_url"": ""/admin/inlines/recurringinline/3418/"", ""content_type"": ""recurringinline"", ""label"": ""Marketplace placeholder""}'> <section  data-overlay-marker='{""edit_url"": ""/admin/containers/pane/1140/"", ""content_type"": ""pane"", ""label"": ""Marketplace""}'> <div class=""row""> <div class=""span2""> <header> <div class=""sectionBanner""> <h2>Marketplace</h2> </div> </header> </div> <div class=""span10""> <div class=""clearfix""> <div class=""subnav pull-right""> <ul class=""nav nav-pills nav-tabs""> <li class="" active""><a href=""#pane-bottom_default_marketplace-tab1"" data-toggle=""tab"">Marketplace</a></li> <li class=""""><a href=""#pane-bottom_default_marketplace-tab2"" data-toggle=""tab"">Restaurants</a></li> </ul> </div> </div> </div> <div class=""span12""> <div class=""tab-content""> <div class=""tab-pane active"" id=""pane-bottom_default_marketplace-tab1""> <div  data-content-edit-url=""/admin/containers/container/3960/"" data-content-model=""container"" data-content-name=""Marketplace: Marketplace Tab 1""  > <div class=""recurring-inline-normal""  data-overlay-marker='{""edit_url"": ""/admin/inlines/recurringinline/2623/"", ""content_type"": ""recurringinline"", ""label"": ""marketplace-tab1""}'> <div class=""row adGroup""> <div class=""span2""> <p>Special Offers & Promotions</p> </div> <div class=""span2 adSpace"" id=""marketplace1Ad0""></div> <div class=""span2 adSpace"" id=""marketplace1Ad1""></div> <div class=""span2 adSpace"" id=""marketplace1Ad2""></div> <div class=""span2 adSpace"" id=""marketplace1Ad3""></div> <div class=""span2 adSpace"" id=""marketplace1Ad4""></div> </div> </div> </div> </div> <div class=""tab-pane"" id=""pane-bottom_default_marketplace-tab2""> <div  data-content-edit-url=""/admin/containers/container/4263/"" data-content-model=""container"" data-content-name=""Restaurants: Marketplace Tab 2""  > <div class=""recurring-inline-normal""  data-overlay-marker='{""edit_url"": ""/admin/inlines/recurringinline/2906/"", ""content_type"": ""recurringinline"", ""label"": ""marketplace-tab2""}'> <div class=""row adGroup""> <div class=""span2""> <p>Special Offers & Messages from our National and Local Partners</p> </div> <div class=""span2 adSpace"" id=""marketplace2Ad0""></div> <div class=""span2 adSpace"" id=""marketplace2Ad1""></div> <div class=""span2 adSpace"" id=""marketplace2Ad2""></div> <div class=""span2 adSpace"" id=""marketplace2Ad3""></div> <div class=""span2 adSpace"" id=""marketplace2Ad4""></div> </div> </div> </div> </div> </div> </div> </div> </section> </div> </div> <div  data-content-edit-url=""/admin/containers/container/4504/"" data-content-model=""container"" data-content-name=""compare and container container""  > <div class=""recurring-inline-normal""  data-overlay-marker='{""edit_url"": ""/admin/inlines/recurringinline/3419/"", ""content_type"": ""recurringinline"", ""label"": ""Compare and Save placeholder""}'> <section  data-overlay-marker='{""edit_url"": ""/admin/containers/pane/1314/"", ""content_type"": ""pane"", ""label"": ""Compare & Save""}'> <div class=""row""> <div class=""span2""> <header> <div class=""sectionBanner""> <h2>Compare &amp; Save</h2> </div> </header> <div class=""sideBar""  data-overlay-marker='{""is_supplemental"": true, ""content_type"": ""pane_zone"", ""label"": ""Sidebar Column""}'> <div  data-content-edit-url=""/admin/containers/container/4442/"" data-content-model=""container"" data-content-name=""Todays best sidebar""  > <div class=""recurring-inline-normal""  data-overlay-marker='{""edit_url"": ""/admin/inlines/recurringinline/3280/"", ""content_type"": ""recurringinline"", ""label"": ""Todays best Sidebar""}'> <div align=""center""> <p><small>Brought to you by</small></p> <a target=""_blank"" href=""http://mozo.com.au""><img src=""http://media2.apnonline.com.au/img/media/images/2013/03/25/mozo-logo-146x46.png"" style=""width:146px; height:auto;"" /></a> </div> </div> </div> </div> </div> <div class=""span10""> <div  data-overlay-marker='{""is_supplemental"": true, ""content_type"": ""pane_zone"", ""label"": ""Main Column""}'> <div  data-content-edit-url=""/admin/containers/container/4443/"" data-content-model=""container"" data-content-name=""Compare and Save""  > <div class=""recurring-inline-normal""  data-overlay-marker='{""edit_url"": ""/admin/inlines/recurringinline/3282/"", ""content_type"": ""recurringinline"", ""label"": ""Compare and Save""}'> <div class=""FullWidthMozo""></div> <script>
	$(document).ready(function() {
		compareAndSaveFullWidthFinalHtml = '';
		var dataRequest = $.ajax({
			url : '/feeds/external/mozo-2/',
			success : function(data) {
				compareAndSaveFullWidthFinalHtml += '<div class=""span10 thirds"">';
				for (var i = 0; (i < data.length) && (i < 6); i++) {
					compareAndSaveFullWidthFinalHtml += '<article class=""mozoUnitWrapper""><div class=""overlayable"">';

					var item = data[i].block;
					compareAndSaveFullWidthFinalHtml += '<p class=""mozoHeader""><strong>' + item.heading + '</strong></p>';
					compareAndSaveFullWidthFinalHtml += '<a target=""_blank"" href=""' + item.link_url + '"" class=""imgLink mozoImage""><img src=""' + item.image_url + '"" /></a></div><p class=""mozoCaption""><a href=""' + item.link_url + '"">' + item.text + '</a></p><p><a target=""_blank"" href=""' + item.button_url + '"" class=""btn btn-small btn-grey"" style=""font-size:14px;padding:7px 15px;margin-top:-8px;"">' + item.button_text + '</a></p></article>';
				}
				compareAndSaveFullWidthFinalHtml += '</div>';
				$('div.FullWidthMozo').html(compareAndSaveFullWidthFinalHtml);
			}
		});
	}); 
</script> </div> </div> </div> </div> </div> </section> </div> </div> </div> </div> </div> </div> <div id=""trailerboardAd"" class=""leaderboard""> <div id=""adSpace6"" class=""adSpace""></div> </div> <footer class=""sitefooter""> <div class=""container""> <div class=""row""> <aside class=""span2""> <div id=""ft_1_0"" class=""footerRow""  data-overlay-marker='{""edit_url"": ""/admin/fragments/fragment/2291/"", ""content_type"": ""fragment"", ""label"": ""tc_footer_1_0""}'> <img src=""http://media2.apnonline.com.au/90.1/img/media/images/2010/11/02/arm-rnn-logo-footer.png"" alt=""APN Australia Regional Media"" width=""89"" height=""112"" /> <p>© Sunshine Coast Newspaper Company Pty Ltd 2013. Unauthorised reproduction is prohibited under the laws of Australia and by international treaty. </p><ul class=""piped""> <li><a href=""http://www.apn.com.au"" target=""_blank"">APN</a></li> <li><a href=""/group_sites/"">APN Group Websites</a></li> </ul> </div> <div id=""ft_1_1"" class=""footerRow""  data-overlay-marker='{""edit_url"": ""/admin/fragments/fragment/2325/"", ""content_type"": ""fragment"", ""label"": ""tc_footer_1_1""}'> <h5>Need Help?</h5> <p>Refer to our helpful <a href=""/contact/"" class=""track"" data-category=""Footer"">FAQ section</a> for any problems you might be experiencing.</p> </div> </aside> <div id=""ft_2"" class=""span10""> <div id=""ft_2_1""  data-overlay-marker='{""edit_url"": ""/admin/fragments/fragment/2341/"", ""content_type"": ""fragment"", ""label"": ""tc_footer_2_1""}'> <div id=""ft_2_1_1"" class=""footerRow""> <h5>Sunshine Coast Daily</h5> <ul class=""piped""> <li><a href=""/news/"" title=""Sunshine Coast Local News"" class=""blue-link track"" data-category=""Footer"">Sunshine Coast News</a></li> <li><a href=""/news/national/"" title=""Australian News"" rel=""nofollow"" class=""blue-link track"" data-category=""Footer"">National News</a></li> <li><a href=""/news/world/"" title=""World and International News"" rel=""nofollow"" class=""blue-link track"" data-category=""Footer"">World News</a></li> <li><a href=""/sport/"" title=""Sunshine Coast Local Sport News"" rel=""nofollow"" class=""blue-link track"" data-category=""Footer"">Sunshine Coast Sport</a></li> <li><a href=""/entertainment/"" title=""Entertainment News"" rel=""nofollow"" class=""blue-link track"" data-category=""Footer"">Entertainment</a></li> <li><a href=""/entertainment/movies/"" title=""Movie Session Times and Movie News"" rel=""nofollow"" class=""blue-link track"" data-category=""Footer"">Movie News</a></li> <li><a href=""/entertainment/tv/"" title=""TV Industry News"" rel=""nofollow"" class=""blue-link track"" data-category=""Footer"">TV News</a></li> <li><a href=""/lifestyle/"" title=""Lifestyle News"" rel=""nofollow"" class=""blue-link track"" data-category=""Footer"">Lifestyle</a></li> <li><a href=""/lifestyle/explore/"" title=""Travel News"" rel=""nofollow"" class=""blue-link track"" data-category=""Footer"">Travel</a></li> <li><a href=""http://shopping.sunshinecoastdaily.com.au/catalogues.html"" title=""Shopping"" rel=""nofollow"" class=""blue-link track"" data-category=""Footer"">Shopping</a></li> <li><a href=""/business/"" title=""Business News"" rel=""nofollow"" class=""blue-link track"" data-category=""Footer"">Business</a></li> <li><a href=""/real-estate/"" title=""Property News"" rel=""nofollow"" class=""blue-link track"" data-category=""Footer"">Real Estate</a></li> <li><a href=""http://home-loan.sunshinecoastdaily.com.au/"" title=""Sunshine Coast Daily Home Loans"" rel=""nofollow"" class=""blue-link track"" data-category=""Footer"">Home Loans</a></li> <li><a href=""/horoscopes/"" title=""Your Daily Horoscope"" rel=""nofollow"" class=""blue-link track"" data-category=""Footer"">Horoscopes</a></li> <li><a href=""/weather"" title=""Maroochydore Local Weather Forecast"" class=""blue-link track"" data-category=""Footer"">Maroochydore Weather</a></li> <li><a href=""/NiE/"" title=""Newspapers in Education"" class=""blue-link track"" data-category=""Footer"">Newspapers in Education</a></li> </ul> </div> <hr><div class=""extraWrapper""> <div id=""ft_2_1_2"" class=""footerRow""> <h5>What's on</h5> <ul class=""piped""> <li><a href=""/whats-on/tv/guide/now-next/10/"" title=""TV Guide and TV Channel Information"" rel=""nofollow"" class=""blue-link track"" data-category=""Footer"">TV Guide - Now/Next</a></li> </ul> <ul class=""piped""> <li><a href=""/whats-on/movies/"" title=""Movie Reviews, Movie News and Movie Session Times"" rel=""nofollow"" class=""blue-link track"" data-category=""Footer"">Movies</a></li> <li><a href=""/whats-on/movies/reviews/"" title=""Latest Movie Reviews"" rel=""nofollow"" class=""blue-link track"" data-category=""Footer"">Movie Reviews</a></li> </ul> </div> <hr> <div id=""ft_2_1_3"" class=""footerRow""> <h5>Sunshine Coast Classifieds</h5> <ul class=""piped""> <li class=""first""><a href=""http://www.mycareer.com.au"" title=""Find Jobs on the Sunshine Coast"" rel=""nofollow"" class=""blue-link track"" data-category=""Footer"" target=""_blank"" >Jobs</a></li> <li><a href=""http://www.localclassifieds.com.au/sunshine-coast/motoring/"" title=""Find Cars For Sale in Sunshine Coast"" rel=""nofollow"" class=""blue-link track"" data-category=""Footer"">Cars for Sale in Sunshine Coast</a></li> <li><a target=""_blank"" href=""http://www.localclassifieds.com.au/sunshine-coast/real-estate/"" title=""Find a Property in Maroochydore"" rel=""nofollow"" class=""blue-link track"" data-category=""Footer"">Property listings in Sunshine Coast</a></li> <li><a target=""_blank"" href=""http://www.localclassifieds.com.au/sunshine-coast/"" rel=""nofollow"" class=""blue-link track"" data-category=""Footer"">Bargains for Sale in Sunshine Coast</a></li> <li><a href=""/classifieds/notices/funeral-notices/"" title=""Obituaries for Sunshine Coast"" rel=""nofollow"" class=""blue-link track"" data-category=""Footer"">Obituaries in Sunshine Coast</a></li> <li><a href=""/classifieds/personals/"" title=""Personals for Sunshine Coast"" rel=""nofollow"" class=""blue-link track"" data-category=""Footer"">Personals in Sunshine Coast</a></li> <li><a href=""/classifieds/notices/"" title=""Notices for Sunshine Coast"" rel=""nofollow"" class=""blue-link track"" data-category=""Footer"">Notices in Sunshine Coast</a></li> </ul> </div></div> <hr> <div id=""ft_2_1_4"" class=""footerRow""> <h5>About Sunshine Coast Daily</h5> <ul class=""piped""> <li><a href=""/panel/"" title=""Audience Panel"" rel=""nofollow"" class=""blue-link track"" data-category=""Footer"">Audience Panel</a></li> <li><a href=""/contact/"" title=""Contact Sunshine Coast Daily"" class=""blue-link track"" data-category=""Footer"">Contact Us</a></li> <li><a href=""/Use-Our-Content/"" class=""blue-link track"" data-category=""Footer"" title=""Use our Content"">Use our Content</a></li> <li><a href=""/homedelivery/"" class=""blue-link track"" data-category=""Footer"" title=""Subscribe to Sunshine Coast Daily Newspaper"">Home Delivery</a></li> <li><a href=""/buy-photos/"" class=""blue-link track"" data-category=""Footer"" title=""Buy Photos from the Sunshine Coast Dailye"">Photo Sales</a></li> <li><a href=""/contact/feedback/"" class=""blue-link track"" data-category=""Footer"" title=""Write to the Sunshine Coast Daily"">Letters to the Editor</a></li> <li><a href=""/competitionterms/"" title=""Read the Competition Terms and Conditions"" rel=""nofollow"" class=""blue-link track"" data-category=""Footer"">Competition Terms</a></li> </ul> </div> </div> <hr> <div id=""ft_2_2"" class=""footerRow""  data-overlay-marker='{""edit_url"": ""/admin/fragments/fragment/2296/"", ""content_type"": ""fragment"", ""label"": ""tc_footer_2_2""}'> <h5>APN News &amp; Media</h5> <ul class=""piped""> <li><a href=""http://www.apndigital.com.au/"" target=""_blank"" class=""blue-link track"" data-category=""Footer"">Digital Advertising</a></li> <li><a href=""/group_sites/"" class=""blue-link track"" data-category=""Footer"">Group Sites</a></li> <li><a href=""/privacy/"" class=""blue-link track"" data-category=""Footer"">Privacy Policy</a></li> <li><a href=""/terms/"" class=""blue-link track"" data-category=""Footer"">Terms of Use</a></li> </ul> </div> </div> </div> </div> </footer> <div id=""adSpace2"" class=""adSpace""></div> <div id=""adSpace4"" class=""adSpace""></div> </div> <script src=""http://ajax.googleapis.com/ajax/libs/jquery/1.8.2/jquery.min.js""></script> <script>window.jQuery && window.jQuery.each || document.write('<script src=""http://media2.apnonline.com.au/90.1/tc/base/js/jquery-1.8.2.min.js""><\/script>')</script> <script src=""http://cdnjs.cloudflare.com/ajax/libs/underscore.js/1.3.3/underscore-min.js""></script> <script>window._ || document.write('<script src=""http://media2.apnonline.com.au/90.1/tc/base/js/underscore-1.3.3.min.js""><\/script>')</script> <script src=""http://maps.google.com/maps/api/js?sensor=true""></script> <script type=""text/javascript"" src=""http://media2.apnonline.com.au/90.1/img/cache/90.1/js/af26bcb9132b.js"" charset=""utf-8""></script> <script>
(function($,d){$.each(readyQ,function(i,f){$(f)});$.each(bindReadyQ,function(i,f){$(d).bind(""ready"",f)})})(jQuery,document)
</script> <script id=""rnn_init"">





;(function (rnn) {

    var userAccountURL = '/my-account/',
        siteConfig = {
            id: '19',
            name: 'Sunshine Coast Daily',
            domain: 'www.sunshinecoastdaily.com.au',
            shortdomain: 'sunshinecoastdaily',
            network: {
                name: 'RNN'
            },
            showSubscriptionModal: false,
            isDesktop: true,
            primaryRegion:{
                id: '5',
                name: 'Sunshine Coast'
            },
            mediaURL: 'http://media2.apnonline.com.au/90.1/',
            tagsURL: '/tags/typeahead.json',
            getSubmissionTagsUrlPrefix: '/contentupload/submissions/tags/', 
            termsUrl: '/submissions/terms-and-conditions/',
            notice:{
                postURL: '/noticeboard/add/ajax/',
                noticeboardURL: '/noticeboard/',
                types: { ""44"": ""Club Updates"",""48"": ""Pothole Alerts"",""11"": ""Local Bargains"",""4"": ""Lost pets"",""50"": ""Road Closures"",""8"": ""General Hazard"",""45"": ""Damaged Footpaths"",""47"": ""Overgrown Paths/Park"",""49"": ""Power Outage"",""51"": ""Roadwork Alerts"",""46"": ""Magpie Zones"",""7"": ""Event Updates"",""9"": ""Traffic Updates"",""10"": ""Other alerts"",""6"": ""Damaged Roads"",""54"": ""Traffic Hazards"",""53"": ""School Event Updates"",""52"": ""Club Training Update"" }
            },
            defaultContributeForms: ['story','image','notice','event'],
            userAccountURL: userAccountURL,
            userDataURL: userAccountURL + 'userstatus/',
            loginURL: userAccountURL + 'login/',
            logoutURL: userAccountURL + 'logout/',
            accountEditURL: userAccountURL + 'edit/',
            accountConfirmURL: userAccountURL + 'confirm/',
            profileURL: '/profile/',
            registerURL: userAccountURL + 'register/',
            commentFlagURL: '/flag/55/',
            ugcURL: '/contentupload/upload_form/',
            serverCode: 'm',
            isDebug: false,
            facebook: {
                appID: '143329145682245',
                loginURL: '/facebook/login/'
            },
            typeaheadURL: '/location/typeahead.json',
            follow: {
                statusURL: '/follow/status/',
                createURL: '/follow/create/',
                removeURL: '/follow/remove/'
            },
            defaultLocation: {
                ""latitude"": -26.625363,
                ""longitude"": 153.293610
            },
            addEventURL: '/things-to-do/add/',
            notificationWrapperClass: 'nav.sitenav .alertWrapper',
            newsFlashURL: '/newsflash/newsflash/',
            ajaxMovieRegionsURL: '/things-to-do/movies/ajax/regions/',

            // Classifieds
            shortlistUrl: '/classifieds/shortlist/',
            currentTimeURL: '/json/datetime/',
	    timeZoneOffset: +10,
	    restrictions: {}
        },

        options = {};

    rnn != null && rnn.init(siteConfig, options);

})(window.rnn);
</script> <script id=""rnn_advertising"">

// Advertising
;(function (advertising) {
    
    if (typeof advertising !== ""undefined"") {
        
        
        
        //We've discovered that the length of any bserver http call cannot be longer than 2048 characters in length. Marketplace and localcarousel and featbusiness have been renamed to mp1 mp2, carousel, and fb to save on characters in big calls like on the homepage.

    // Standard Ad Spaces
    advertising.au.define('adSpace', [
        'B1/SIZE=LBRD/POS=POS1',         // 728x90
        'B2/SIZE=MREC/POS=POS1',                // 300x250
        'B3/SIZE=SKIN/POS=POS1',                // -
        'B4/SIZE=BANNER/POS=POS1',                       // 728x90
        'B5/SIZE=OTP/POS=POS1',                          // 300x40
        'B6/SIZE=MREC/POS=POS2',                // 300x250
        'B7/SIZE=TBRD/POS=POS1',                 // 728x90
        'B8/SIZE=PULLTHROUGH/POS=POS1'                   // 620x40
    ]);

    // Featured businesses
    advertising.au.define('featBusAd', [
        'B9/SIZE=FB/POS=POS1', // 130x98
        'B10/SIZE=FB/POS=POS2', // 130x98
        'B11/SIZE=FB/POS=POS3', // 130x98
        'B12/SIZE=FB/POS=POS4' // 130x98
    ]);
  
    // Local Carousel (shuffled)
    advertising.au.define('localCarouselAd', [
        'B27/SIZE=CAROUSEL/POS=POS1',      // 130x98
        'B28/SIZE=CAROUSEL/POS=POS2',      // 130x98
        'B29/SIZE=CAROUSEL/POS=POS3',      // 130x98
        'B30/SIZE=CAROUSEL/POS=POS4',      // 130x98
        'B31/SIZE=CAROUSEL/POS=POS5',      // 130x98
        'B32/SIZE=CAROUSEL/POS=POS6',      // 130x98
        'B33/SIZE=CAROUSEL/POS=POS7',      // 130x98
        'B34/SIZE=CAROUSEL/POS=POS8',      // 130x98
        'B35/SIZE=CAROUSEL/POS=POS9',      // 130x98
        'B36/SIZE=CAROUSEL/POS=POS10',     // 130x98
        'B37/SIZE=CAROUSEL/POS=POS11',     // 130x98
        'B38/SIZE=CAROUSEL/POS=POS12',     // 130x98
        'B39/SIZE=CAROUSEL/POS=POS13',     // 130x98
        'B40/SIZE=CAROUSEL/POS=POS14',     // 130x98
        'B41/SIZE=CAROUSEL/POS=POS15',     // 130x98
        'B42/SIZE=CAROUSEL/POS=POS16',     // 130x98
        'B43/SIZE=CAROUSEL/POS=POS17',     // 130x98
        'B44/SIZE=CAROUSEL/POS=POS18',     // 130x98
        'B45/SIZE=CAROUSEL/POS=POS19',     // 130x98
        'B46/SIZE=CAROUSEL/POS=POS20'     // 130x98
    ], true);

    // Coupons
    advertising.au.define('couponAd', [
        'B47/SIZE=COUPON/POS=POS1',            // 130x98
        'B48/SIZE=COUPON/POS=POS2',            // 130x98
        'B49/SIZE=COUPON/POS=POS3',            // 130x98
        'B50/SIZE=COUPON/POS=POS4',            // 130x98
        'B51/SIZE=COUPON/POS=POS5'            // 130x98

        /*,
        'B52/SIZE=COUPON/POS=POS6',            // 130x98
        'B53/SIZE=COUPON/POS=POS7',            // 130x98
        'B54/SIZE=COUPON/POS=POS8',            // 130x98
        'B55/SIZE=COUPON/POS=POS9',            // 130x98
        'B56/SIZE=COUPON/POS=POS10',           // 130x98
        'B57/SIZE=COUPON/POS=POS11',           // 130x98
        'B58/SIZE=COUPON/POS=POS12',           // 130x98
        'B59/SIZE=COUPON/POS=POS13',           // 130x98
        'B60/SIZE=COUPON/POS=POS14',           // 130x98
        'B61/SIZE=COUPON/POS=POS15',           // 130x98
        'B62/SIZE=COUPON/POS=POS16',           // 130x98
        'B63/SIZE=COUPON/POS=POS17',           // 130x98
        'B64/SIZE=COUPON/POS=POS18',           // 130x98
        'B65/SIZE=COUPON/POS=POS19',           // 130x98
        'B66/SIZE=COUPON/POS=POS20'            // 130x98
        */
    ]);
    // Profiles (shuffled)
    advertising.au.define('profileAd', [
        'B67/SIZE=PROFILE/POS=POS1',            // 130x98
        'B68/SIZE=PROFILE/POS=POS2',            // 130x98
        'B69/SIZE=PROFILE/POS=POS3',            // 130x98
        'B70/SIZE=PROFILE/POS=POS4',            // 130x98
        'B71/SIZE=PROFILE/POS=POS5'            // 130x98

        /*,
        'B72/SIZE=PROFILE/POS=POS6',            // 130x98
        'B73/SIZE=PROFILE/POS=POS7',            // 130x98
        'B74/SIZE=PROFILE/POS=POS8',            // 130x98
        'B75/SIZE=PROFILE/POS=POS9',            // 130x98
        'B76/SIZE=PROFILE/POS=POS10',           // 130x98
        'B77/SIZE=PROFILE/POS=POS11',           // 130x98
        'B78/SIZE=PROFILE/POS=POS12',           // 130x98
        'B79/SIZE=PROFILE/POS=POS13',           // 130x98
        'B80/SIZE=PROFILE/POS=POS14',           // 130x98
        'B81/SIZE=PROFILE/POS=POS15',           // 130x98
        'B82/SIZE=PROFILE/POS=POS16',           // 130x98
        'B83/SIZE=PROFILE/POS=POS17',           // 130x98
        'B84/SIZE=PROFILE/POS=POS18',           // 130x98
        'B85/SIZE=PROFILE/POS=POS19',           // 130x98
        'B86/SIZE=PROFILE/POS=POS20'            // 130x98
        */
    ], true);

    // Marketplace
    advertising.au.define('marketplace1Ad', [
        'B87/SIZE=MP1/POS=POS1',            // 130x98
        'B88/SIZE=MP1/POS=POS2',            // 130x98
        'B89/SIZE=MP1/POS=POS3',            // 130x98
        'B90/SIZE=MP1/POS=POS4',            // 130x98
        'B91/SIZE=MP1/POS=POS5'             // 130x98
    ]);
    advertising.au.define('marketplace2Ad', [
        'B92/SIZE=MP2/POS=POS1',            // 130x98
        'B93/SIZE=MP2/POS=POS2',            // 130x98
        'B94/SIZE=MP2/POS=POS3',            // 130x98
        'B95/SIZE=MP2/POS=POS4',            // 130x98
        'B96/SIZE=MP2/POS=POS5'             // 130x98
    ]);

    // Christmas Profiles (shuffled)
    advertising.au.define('cpAd', [
        'B97/SIZE=CPAD/POS=POS1',            // 130x98
        'B98/SIZE=CPAD/POS=POS2',            // 130x98
        'B99/SIZE=CPAD/POS=POS3',            // 130x98
        'B100/SIZE=CPAD/POS=POS4',            // 130x98
        'B101/SIZE=CPAD/POS=POS5'            // 130x98
    ], true);


    //Single ad for a single widget that is being used once and never again
    advertising.au.define('sOffer', [
        'B102/SIZE=SOFFERAD/POS=POS1'          // 130x98
    ]);

    advertising.au.define('billboardAd', [
        'B103/SIZE=BBRD/POS=POS1'            //  970x250
    ]);

    advertising.au.define('tickerAd', [
        'B104/SIZE=TICKER/POS=POS1'            //  620x40
    ]);

advertising.au.define('BigSalesCarousel', [
        'B105/SIZE=BIGCAROUSEL/POS=POS1',      
        'B106/SIZE=BIGCAROUSEL/POS=POS2',      
        'B107/SIZE=BIGCAROUSEL/POS=POS3',      
        'B108/SIZE=BIGCAROUSEL/POS=POS4',      
        'B109/SIZE=BIGCAROUSEL/POS=POS5',      
        'B110/SIZE=BIGCAROUSEL/POS=POS6',      
        'B111/SIZE=BIGCAROUSEL/POS=POS7',      
        'B112/SIZE=BIGCAROUSEL/POS=POS8',      
        'B113/SIZE=BIGCAROUSEL/POS=POS9',      
        'B114/SIZE=BIGCAROUSEL/POS=POS10'    
    ], true);


// GenericProfiles (shuffled)
    advertising.au.define('gpAd', [
        'B115/SIZE=GPAD/POS=POS1',            // 130x98
        'B116/SIZE=GPAD/POS=POS2',            // 130x98
        'B117/SIZE=GPAD/POS=POS3',            // 130x98
        'B118/SIZE=GPAD/POS=POS4',            // 130x98
        'B119/SIZE=GPAD/POS=POS5',            // 130x98
        'B120/SIZE=GPAD/POS=POS6',            // 130x98
        'B121/SIZE=GPAD/POS=POS7',            // 130x98
        'B122/SIZE=GPAD/POS=POS8',            // 130x98
        'B123/SIZE=GPAD/POS=POS9',          // 130x98
        'B124/SIZE=GPAD/POS=POS10',            // 130x98
        'B125/SIZE=GPAD/POS=POS11',           // 130x98
        'B126/SIZE=GPAD/POS=POS12',            // 130x98
        'B127/SIZE=GPAD/POS=POS13',            // 130x98
        'B128/SIZE=GPAD/POS=POS14',            // 130x98
        'B129/SIZE=GPAD/POS=POS15',            // 130x98
        'B130/SIZE=GPAD/POS=POS16',            // 130x98
        'B131/SIZE=GPAD/POS=POS17',            // 130x98
        'B132/SIZE=GPAD/POS=POS18',            // 130x98
        'B133/SIZE=GPAD/POS=POS19',            // 130x98
        'B134/SIZE=GPAD/POS=POS20'            // 130x98

    ], true);
        
        advertising.automate({
            site: 'REGTHEDAILY',
            area: 'REGTHEDAILY.NEWS.STORY.HME',
            keyword: '',
            adGroupLabel: '<div class=""advertiseText""><span><a href=""http://www.apndigital.com.au/advertise_with_us/"" title=""Advertise With Us"" target=""_blank"">Advertisement</a></span></div>'
        });
        
    }
})(window.rnn.modules.advertising);
</script> <script id=""rnn_nielsen"" type=""text/javascript"">
//<![CDATA[
    var _rsCI=""apn-au"";
    var _rsCG=""0"";
    var _rsDN=""//secure-au.imrworldwide.com/"";
    
        var _rsUT=""1"";
    
    


var _rsC0=""category,news"";
var _rsC1=""subcategory,0"";
var _rsC2=""subsubcategory,local"";



//]]> </script> <script type=""text/javascript"" src=""http://media2.apnonline.com.au/90.1/apncore/js/neilson.js""></script> <noscript> <div><img src=""//secure-au.imrworldwide.com/cgi-bin/m?ci=apn-au&amp;cg=0&amp;cc=1"" alt=""""/></div> </noscript> <!--Copyright 1996-2011 Adobe, Inc. All Rights Reserved --> <!--More info available at http://www.omniture.com --> <script language=""JavaScript"" type=""text/javascript"">
(function (isBeta) {
    if (isBeta) {
        window.s_account = ""apnarmmaindev"";
    } else {
        window.s_account = ""apnapnarmmain"";
    }
    window.s_linkInternalFilters=""javascript:,ballinaadvocate.com.au,bigrigs.com.au,byronnews.com.au,caboolturenews.com.au,centraltelegraph.com.au,coffscoastadvocate.com.au,coolum-news.com.au,cqnews.com.au,creative.apndigital.com.au,dailyexaminer.com.au,dailymercury.com.au,echonews.com.au,frasercoastchronicle.com.au,gattonstar.com.au,gladstoneobserver.com.au,goldcoastmail.com.au,gympietimes.com.au,ipswichadvertiser.com.au,mydailynews.com.au,news-mail.com.au,noosanews.com.au,northernstar.com.au,qt.com.au,queenslandtimes.com.au,rangenews.com.au,ruralweekly.com.au,southburnetttimes.com.au,stanthorpeborderpost.com.au,sunshinecoastdaily.com.au,suratbasin.com.au,thechronicle.com.au,theminer.com.au,themorningbulletin.com.au,thereporter.com.au,thesatellite.com.au,warwickdailynews.com.au,whitsundaytimes.com.au"";
})(window.location.hostname.indexOf('beta.') > -1);
</script> <script language=""JavaScript"" type=""text/javascript"" src=""http://media2.apnonline.com.au/90.1/apncore/js/s_code.js""></script> <script language=""JavaScript"" type=""text/javascript""> <!--
/* You may give each page an identifying name, server, and channel on
the next lines. */
s.channel = window.location.pathname === ""/"" ? ""home"" : ""news"";
s.pageName = ""scd:"" + (window.location.pathname === ""/"" ? ""home"" : ""article:legionellascareinsunshinecoastprivatehospital:1926607"");
s.hier1 = ""scd:"" + (window.location.pathname === ""/"" ? ""home:default"" : ""news"");
if (s.hier1.split("":"").length < 3) { s.hier1 += "":default""; };
s.prop1 = window.location.pathname === ""/"" ? ""home"" : ""article"";
s.prop2 = ""sunshine-coast-private-hospital"";
s.prop3 = ""scd"";
s.prop4 = ""sunday"";
s.prop5 = ""17:00"";
s.prop6 = ""1926607"";
s.prop7 = ""kateclifford"";
s.prop8 = """";
s.prop9 = """";
s.prop10 = ""scn"";
s.prop11 = ""29jun2013"";
s.prop12 = ($.cookie(""apn_account_id"") || """");
s.prop13 = window.location.pathname === ""/"" ? document.referrer == window.location ? ""y"" : ""n"" : """";
s.prop14 = """";
s.prop15 = """";
s.prop16 = """";
s.prop17 = """";
s.prop18 = """";
s.prop20 = """";
s.prop21 = """";
s.prop22 = """";
s.prop23 = """";
s.prop24 = ""local"";
// s.prop25 = """";
s.prop26 = """";
s.prop27 = ""yes"";
s.prop28 = ""yes"";

/* Conversion Variables */
s.campaign=""""
s.state=""""
s.zip=""""
s.events=""""
s.products=""""
s.purchaseID=""""
s.eVar1=""""
s.eVar2=""""
s.eVar3=""""
s.eVar4=""""
s.eVar5=""""

/************* DO NOT ALTER ANYTHING BELOW THIS LINE ! **************/
var s_code=s.t();
if(s_code)document.write(s_code)//--> </script> <script language=""JavaScript"" type=""text/javascript""> <!--
if(navigator.appVersion.indexOf('MSIE')>=0)document.write(unescape('%3C')+'\!-'+'-')
//--></script> <noscript> <img src=""http://apnonline.112.2o7.net/b/ss/apnapnarmmain/1/H.22.1--NS/0?[AQB]&cdp=3&[AQE]""
height=""1"" width=""1"" border=""0"" alt="""" /></noscript><!--/DO NOT REMOVE/--> <!-- End SiteCatalyst code version: H.22.1. --> <script>


$(document).ready(function() {
    function initVideo() {
        if (window.location.pathname.substring(0, 7) == ""/videos"" && !rnn.site.isDebug) {
            $(""div[data-position='1']"").remove();
        }
    }
    initVideo();
});



$(document).ready(function(){
		$('div.search-result.listing span[itemprop=""streetAddress""]:contains(XXXXXXXXXXXXXXX)').parent().parent().hide();
});




$(document).ready(function(){
  $('article.newsEntry span[style*=12px]').removeAttr('style');
});



$(document).ready(function(){
    var sites = ['www.sunshinecoastdaily.com.au', 'www.gympietimes.com.au', 'www.qt.com.au'],
        image = $.el.img({style:'padding-top:10px;', src:'http://media2.apnonline.com.au/img/media/images/2012/11/09/Energex_logo_black.png'}),
        link = $.el.a({href:'http://ad.au.doubleclick.net/clk;264568613;90257879;b'}, image);

    if($.inArray(window.document.domain, sites)) { 
      $('#weatherForecast').append(link);
    } 
});




  


</script> <!-- SERVER:m ID:19--> </body> </html>";
            }
        }
    }
}
