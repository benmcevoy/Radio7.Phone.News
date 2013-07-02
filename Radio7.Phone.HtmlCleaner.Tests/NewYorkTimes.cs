using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Radio7.Phone.HtmlCleaner.Tests
{
    class NewYorkTimes
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
<!DOCTYPE html>
<html lang=""en"" itemscope itemtype=""http://schema.org/NewsArticle"" itemid=""http://www.nytimes.com/2013/06/30/world/americas/ecuador-leader-says-biden-called-him-about-snowden.html"" xmlns:og=""http://opengraphprotocol.org/schema/"" xmlns:fb=""http://www.facebook.com/2008/fbml"">
<head>
<title>Ecuador Leader Says Biden Called About Asylum Request - NYTimes.com</title>
<meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"">
<meta itemprop=""inLanguage"" content=""en-US"">
<meta itemprop=""description"" name=""description"" content=""The president of Ecuador said that Vice President Joseph R. Biden Jr. had asked him not to grant asylum to Edward J. Snowden, the fugitive former security contractor wanted in the United States."">
<meta name=""keywords"" content=""United States International Relations,Asylum  Right of,Snowden  Edward J,Biden  Joseph R Jr,Correa  Rafael,Ecuador"">
<meta name=""news_keywords"" content=""US Foreign Policy,Right of asylum"">
<meta name=""ROBOTS"" content=""NOARCHIVE"">
<meta name=""DISPLAYDATE"" content=""June 29, 2013"">
<meta itemprop=""dateModified"" content=""2013-06-29"">
<meta itemprop=""datePublished"" content=""2013-06-29"">
<meta name=""hdl"" content=""Ecuador Leader Says Biden Called About Asylum Request"">
<meta itemprop=""alternativeHeadline"" name=""hdl_p"" content=""Ecuador Leader Says Biden Called Him About Snowden"">
<meta name=""byl"" content=""By WILLIAM NEUMAN"">
<meta name=""lp"" content=""The president of Ecuador said that Vice President Joseph R. Biden Jr. had asked him not to grant asylum to Edward J. Snowden, the fugitive former security contractor wanted in the United States."">
<meta itemprop=""usageTerms"" content=""http://www.nytimes.com/content/help/rights/sale/terms-of-sale.html"">
<meta name=""cre"" content=""The New York Times"">
<meta name=""edt"" content=""NewYork"">
<meta name=""pdate"" content=""20130629"">
<meta name=""ttl"" content="""">
<meta name=""des"" content=""United States International Relations;Asylum, Right of"">
<meta name=""per"" content=""Snowden, Edward J;Biden, Joseph R Jr;Correa, Rafael"">
<meta name=""geo"" content=""Ecuador"">
<meta name=""ticker"" content=""South China Morning Post Limited|SCHPY|other-OTC"">
<meta name=""slug"" content=""30ecuador"">
<meta name=""utime"" content=""20130630082331"">
<meta name=""ptime"" content=""20130629201832"">
<meta name=""author"" content=""WILLIAM NEUMAN"">
<meta name=""dat"" content=""June 29, 2013"">
<meta itemprop=""genre"" name=""tom"" content=""News"">
<meta name=""cat"" content="""">
<meta name=""col"" content="""">
<meta itemprop=""articleSection"" name=""dsk"" content=""World / Americas"">
<meta itemprop=""identifier"" name=""articleid"" content=""100000002310821"">
<meta name=""ARTICLE_TEMPLATE_VERSION"" CONTENT=""700"">
<meta name=""hdr_img"" content=""/images/article/header/sect_world.gif"">
<meta itemprop=""thumbnailUrl"" name=""thumbnail"" content=""http://www.nytimes.com/images/2013/06/30/world/ecuador/ecuador-thumbStandard.jpg"">
<meta name=""thumbnail_height"" content=""75"">
<meta name=""thumbnail_width"" content=""75"">
<meta name=""thumbnail_150"" content=""http://www.nytimes.com/images/2013/06/30/world/ecuador/ecuador-thumbLarge.jpg"">
<meta name=""thumbnail_150_height"" content=""150"">
<meta name=""thumbnail_150_width"" content=""150"">
<meta name=""sectionfront_jsonp"" content=""http://json8.nytimes.com/pages/world/americas/index.jsonp"">
<meta name=""CG"" content=""world"">
<meta name=""SCG"" content=""americas"">
<meta name=""PT"" content=""Article"">
<meta name=""PST"" content=""News"">
<meta name=""msapplication-starturl"" content=""http://www.nytimes.com/"">
<link rel=""canonical"" href=""http://www.nytimes.com/2013/06/30/world/americas/ecuador-leader-says-biden-called-him-about-snowden.html"">
<meta property=""og:url"" content=""http://www.nytimes.com/2013/06/30/world/americas/ecuador-leader-says-biden-called-him-about-snowden.html""/>
<meta property=""og:type"" content=""article""/>
<meta property=""og:title"" content=""Ecuador Leader Says Biden Called About Asylum Request""/>
<meta property=""og:description"" content=""The president of Ecuador said that Vice President Joseph R. Biden Jr. had asked him not to grant asylum to Edward J. Snowden, the fugitive former security contractor wanted in the United States."">
<meta property=""og:image"" content=""http://graphics8.nytimes.com/images/2013/06/30/world/ecuador/ecuador-superJumbo.jpg""/>
<meta property=""fb:app_id"" content=""9869919170""/>
<meta name=""twitter:card"" value=""summary"">
<meta name=""twitter:site"" value=""@nytimes"">
<meta name=""twitter:creator"" value=""@willieneuman""/>
<meta name=""twitter:url"" content=""http://www.nytimes.com/2013/06/30/world/americas/ecuador-leader-says-biden-called-him-about-snowden.html""/>
<meta name=""twitter:title"" content=""Ecuador Leader Says Biden Called About Asylum Request""/>
<meta name=""twitter:description"" content=""The president of Ecuador said that Vice President Joseph R. Biden Jr. had asked him not to grant asylum to Edward J. Snowden, the fugitive former security contractor wanted in the United States.""/>
<meta name=""twitter:image"" content=""http://graphics8.nytimes.com/images/2013/06/30/world/ecuador/ecuador-thumbLarge.jpg""/>
<link rel=""alternate"" href=""http://mobile.nytimes.com/2013/06/30/world/americas/ecuador-leader-says-biden-called-him-about-snowden.html""/>


<link rel=""stylesheet"" type=""text/css"" href=""http://graphics8.nytimes.com/css/0.1/screen/build/article/2.0/styles.css?v=20121001""><!--[if IE]>
    <style type=""text/css"">
        @import url(http://graphics8.nytimes.com/css/0.1/screen/common/ie.css);
    </style>
<![endif]-->
<!--[if IE 6]>
    <style type=""text/css"">
        @import url(http://graphics8.nytimes.com/css/0.1/screen/common/ie6.css);
    </style>
<![endif]-->
<!--[if lt IE 9]>
        <script src=""http://graphics8.nytimes.com/js/html5shiv.js""></script>
<![endif]-->
<script type=""text/javascript"" src=""http://graphics8.nytimes.com/js/common.js""></script>
<script type=""text/javascript"" src=""http://graphics8.nytimes.com/js/common/screen/DropDown.js""></script>
<script type=""text/javascript"" src=""http://graphics8.nytimes.com/js/util/tooltip.js""></script>
<script type=""text/javascript"" src=""http://graphics8.nytimes.com/js/app/article/upNext.js""></script>
<script language=""JavaScript"" type=""text/javascript"">
                    NYTD.require('http://graphics8.nytimes.com/js/common/sharetools/2.0/shareTools.js');
                    NYTD.require('http://graphics8.nytimes.com/js/app/save/crossPlatformSave.js');
            </script>
</head>

    

<body >

<!-- ADXINFO classification=""blank-but-count-imps"" campaign=""KRUX_DIGITAL_CONTROL_SCRIPT_LIVE2"" priority=""9100"" width=""1"" height=""1"" --><!-- BEGIN Krux Controltag -->
<script class=""kxct"" data-id=""HrUwtkcl"" data-version=""async:1.7"" type=""text/javascript"">
  window.Krux||((Krux=function(){Krux.q.push(arguments)}).q=[]);
  (function(){
    var k=document.createElement('script');k.type='text/javascript';k.async=true;var m,src=(m=location.href.match(/\bkxsrc=([^&]+)\b/))&&decodeURIComponent(m[1]);
    k.src=src||(location.protocol==='https:'?'https:':'http:')+'//cdn.krxd.net/controltag?confid=HrUwtkcl';
    var s=document.getElementsByTagName('script')[0];s.parentNode.insertBefore(k,s);
  })();
</script>
<!-- END Krux Controltag -->

<a name=""top""></a>
<div id=""shell"">
<ul id=""memberTools"">

<!-- ADXINFO classification=""Text_Link"" campaign=""nyt2013_bar1_ros_digi_3JHWX"" priority=""1002"" width=""0"" height=""0"" --><!-- start text link -->
<li class=""cColumn-TextAdsHeader"">
<a href=""http://www.nytimes.com/adx/bin/adx_click.html?type=goto&opzn&page=www.nytimes.com/yr/mo/day/world/americas&pos=Bar1&sn2=4ef0d1ab/8565ba30&sn1=94059724/4f159582&camp=nyt2013_bar1_ros_digi_3JHWX&ad=bar1_ros_hp_digi_3JHWX&goto=http%3A%2F%2Fwww%2Enytimes%2Ecom%2Fsubscriptions%2FMultiproduct%2Flp3HLK8%2Ehtml%3FcampaignId%3D3JHWX%26adxc%3D217590%26adxa%3D339586%26page%3Dwww.nytimes.com/yr/mo/day/world/americas/ecuador-leader-says-biden-called-him-about-snowden.html%26pos%3DBar1%26campaignId%3D3JHWX"" target=""_blank"">
Try a Digital Subscription</a>

<!-- end text link -->

<span class=""adxInfo"" style=""display:none;"">campaign: nyt2013_bar1_ros_digi_3JHWX -- 217590, creative: bar1_ros_hp_digi_3JHWX -- 339586, page: www.nytimes.com/yr/mo/day/world/americas/ecuador-leader-says-biden-called-him-about-snowden.html, targetedPage: www.nytimes.com/yr/mo/day/world/americas, position: Bar1</span>

 
                        <li><a id=""memberToolsLogin"" href=""https://myaccount.nytimes.com/auth/login"">Log In</a></li>
            <li><a href=""https://myaccount.nytimes.com/gst/regi.html"" onClick=""dcsMultiTrack('WT.z_ract', 'Regnow', 'WT.z_rprod', 'Masthead','WT.z_dcsm','1');"">Register Now</a></li>
                            

<li><a href=""http://www.nytimes.com/membercenter/sitehelp.html"">Help</a></li>
</ul>
<div class=""mainTabsContainer tabsContainer"">
<ul id=""mainTabs"" class=""mainTabs tabs"">
<li class=""first mainTabHome""><a href=""http://www.nytimes.com"">Home Page</a></li>
<li class=""mainTabTodaysPaper""><a href=""http://www.nytimes.com/pages/todayspaper/index.html"">Today's Paper</a></li>
<li class=""mainTabVideo""><a href=""http://www.nytimes.com/video"">Video</a></li>
<li class=""mainTabMostPopular""><a href=""http://www.nytimes.com/mostpopular"">Most Popular</a></li>
</ul>
</div>
<div id=""editionToggle"" class=""editionToggle"">
Edition: <span id=""editionToggleUS""><a href=""http://www.nytimes.com"" onmousedown=""dcsMultiTrack('DCS.dcssip','www.nytimes.com','DCS.dcsuri','/toggleIHTtoNYT.html','WT.ti','toggleIHTtoNYT','WT.z_dcsm','1');"" onclick=""NYTD.EditionPref.setUS();"">U.S.</a></span> / <span id=""editionToggleGlobal""><a href=""http://global.nytimes.com"" onmousedown=""dcsMultiTrack('DCS.dcssip','www.nytimes.com','DCS.dcsuri','/toggleNYTtoIHT.html','WT.ti','toggleNYTtoIHT','WT.z_dcsm','1');"" onclick=""NYTD.EditionPref.setGlobal();"">Global</a></span>
</div><!--close editionToggle -->
<script type=""text/javascript"">
        NYTD.loadEditionToggle();

        window.setTimeout(function() {
          var login = document.getElementById('memberToolsLogin');
          if (login) {
            login.href += ""?URI="" + window.location.href;
          }
        }, 0)
        </script>
<div id=""page"" class=""tabContent active"">
<div id=""masthead"" class=""wrap"">

<div id=""searchWidget"">
<div class=""inlineSearchControl"">
<form enctype=""application/x-www-form-urlencoded"" action=""http://query.nytimes.com/search/sitesearch"" method=""get"" name=""searchForm"" id=""searchForm"">
<input type=""hidden"" value=""full"" name=""date_select""/>
<label for=""searchQuery"">Search All NYTimes.com</label>
<input type=""text"" class=""text"" value="""" size="""" name=""query"" id=""searchQuery""/>
<input type=""hidden"" id=""searchAll"" name=""type"" value=""nyt""/>
<input id=""searchSubmit"" title=""Search"" width=""22"" height=""19"" alt=""Search"" type=""image"" src=""http://graphics8.nytimes.com/images/global/buttons/go.gif"">
</form>
</div>
</div>
<div id=""branding"" >
<a href=""http://www.nytimes.com""><span id=""nytIhtMastheadLogo"">
<a href=""http://www.nytimes.com""><img src=""http://graphics8.nytimes.com/images/misc/nytlogo152x23.gif"" alt=""New York Times"" id=""NYTLogo""/></a>
</span></a>
</div>

<h2>

<a href=""http://www.nytimes.com/pages/world/americas/index.html"">Americas</a>
</h2>

</div>
<div class=""navigation tabsContainer"">
<ul class=""tabs"">
<li id=""navWorld"" class=""first selected"">
<a href=""http://www.nytimes.com/pages/world/index.html"">World</a>
<ul class=""subNavigation""><li id=""subNav_africa""><a href=""/pages/world/africa/index.html"">Africa</a></li><li id=""subNav_americas"" class=""selected nochildren"" ><a href=""/pages/world/americas/index.html"">Americas</a></li><li id=""subNav_asia""><a href=""/pages/world/asia/index.html"">Asia Pacific</a></li><li id=""subNav_europe""><a href=""/pages/world/europe/index.html"">Europe</a></li><li id=""subNav_middleeast""><a href=""/pages/world/middleeast/index.html"">Middle East</a></li></ul></li>	<li id=""navUs"" >
<a href=""http://www.nytimes.com/pages/national/index.html"">U.S.</a>
</li>	<li id=""navNyregion"" >
<a href=""http://www.nytimes.com/pages/nyregion/index.html"">N.Y. / Region</a>
</li>	<li id=""navBusiness"" >
<a href=""http://www.nytimes.com/pages/business/index.html"">Business</a>
</li>	<li id=""navTechnology"" >
<a href=""http://www.nytimes.com/pages/technology/index.html"">Technology</a>
</li>	<li id=""navScience"" >
<a href=""http://www.nytimes.com/pages/science/index.html"">Science</a>
</li>	<li id=""navHealth"" >
<a href=""http://www.nytimes.com/pages/health/index.html"">Health</a>
</li>	<li id=""navSports"" >
<a href=""http://www.nytimes.com/pages/sports/index.html"">Sports</a>
</li>	<li id=""navOpinion"" >
<a href=""http://www.nytimes.com/pages/opinion/index.html"">Opinion</a>
</li>	<li id=""navArts"" >
<a href=""http://www.nytimes.com/pages/arts/index.html"">Arts</a>
</li>	<li id=""navStyle"" >
<a href=""http://www.nytimes.com/pages/style/index.html"">Style</a>
</li>	<li id=""navTravel"" >
<a href=""http://www.nytimes.com/pages/travel/index.html"">Travel</a>
</li>	<li id=""navJobs"" >
<a href=""http://www.nytimes.com/pages/jobs/index.html"">Jobs</a>
</li>	<li id=""navRealestate"" >
<a href=""http://www.nytimes.com/pages/realestate/index.html"">Real Estate</a>
</li>	<li id=""navAutomobiles"" >
<a href=""http://www.nytimes.com/pages/automobiles/index.html"">Autos</a>
</li></ul>
</div>



<div class=""singleAd"" id=""TopAd"">
<!-- ADXINFO classification=""Leaderboard_-_Standard"" campaign=""GoogleAdSense_ROS_INT_LB"" priority=""1340"" width=""728"" height=""90"" --><div class=""clearfix"">
<script type=""text/javascript"" language=""JavaScript"">
<!-- 
function getMetaValue(name) {
  var els = document.getElementsByName(name);
  if (els && els[0]) { return els[0].content; }
  return """";
}

if (!window.nyt_google_count) { var nyt_google_count = 0; }
if ((!window.nyt_google_ad_channel) && (window.google_ad_channel)) { var nyt_google_ad_channel = google_ad_channel; }
if ((!window.nyt_google_hints) && (window.google_hints)) { var nyt_google_hints = google_hints; }
if ((!window.nyt_google_contents) && (window.google_contents)) { var nyt_google_contents = google_contents; }
function ss(w,id) {window.status = w;return true;}function cs(){window.status='';}function ha(a){  pha=document.getElementById(a); nhi=pha.href.indexOf(""&nh="");if(nhi < 1) {phb=pha.href+""&nh=1"";} pha.href=phb;}function ca(a) {  pha=document.getElementById(a); nci=pha.href.indexOf(""&nc="");if(nci < 1) {phb=pha.href+""&nc=1"";} pha.href=phb;window.open(document.getElementById(a).href);}function ga(o,e) {if (document.getElementById) {a=o.id.substring(1);p = """";r = """";g = e.target;if (g) {t = g.id;f = g.parentNode;if (f) {p = f.id;h = f.parentNode;if (h)r = h.id;}} else {h = e.srcElement;f = h.parentNode;if (f)p = f.id;t = h.id;}if (t==a || p==a || r==a)return true;pha=document.getElementById(a); nbi=pha.href.indexOf(""&nb="");if(nbi < 1) {phb=pha.href+""&nb=1"";} pha.href=phb;window.open(document.getElementById(a).href);}}
 
function google_ad_request_done(ads) {
    var s = '';
    var i;
 
    if (ads.length == 0) {
        return;
    }
 
    if (ads[0].type == ""image"") {
        s += '<a href=""' + ads[0].url +
        '"" target=""_blank"" title=""go to ' + ads[0].visible_url +
        '""><img border=""0"" src=""' + ads[0].image_url +
        '""width=""' + ads[0].image_width +
        '""height=""' + ads[0].image_height + '""></a>';
    } else if (ads[0].type == ""flash"") {
        s += '<object classid=""clsid:D27CDB6E-AE6D-11cf-96B8-444553540000""' +
        ' codebase=""http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,0,0""' +
        ' WIDTH=""' + google_ad.image_width +
        '"" HEIGHT=""' + google_ad.image_height + '"">' +
        '<PARAM NAME=""movie"" VALUE=""' + google_ad.image_url + '"">' +
        '<PARAM NAME=""quality"" VALUE=""high"">' +
        '<PARAM NAME=""AllowScriptAccess"" VALUE=""never"">' +
        '<EMBED src=""' + google_ad.image_url +
        '"" WIDTH=""' + google_ad.image_width +
        '"" HEIGHT=""' + google_ad.image_height +
        '"" TYPE=""application/x-shockwave-flash""' +
        ' AllowScriptAccess=""never"" ' +
        ' PLUGINSPAGE=""http://www.macromedia.com/go/getflashplayer""></EMBED></OBJECT>';
    
    } else if (google_ads[0].type == ""html"") {
       s += google_ads[0].snippet;
    }    document.write(s);
    return;
}

	google_ad_client = 'ca-nytimes_display_html';
	google_alternate_ad_url = 'http://www.nytimes.com/ads/remnant/networkredirect-leaderboard.html';
	google_ad_width = 728; 
	google_ad_height = 90;
	google_ad_type = 'image,flash,html';
	google_encoding = 'utf8'; 
	google_safe = 'high';
	google_targeting = 'site_content';
	google_ad_channel = 'ROS_leaderboard';
        google_hints = getMetaValue('keywords');
// -->
</script>
<script type=""text/javascript"" language=""JavaScript"" src=""http://pagead2.googlesyndication.com/pagead/show_ads.js""></script>
<noscript>
	<img height=""1"" width=""1"" border=""0"" src=""http://pagead2.googlesyndication.com/pagead/imp.gif?client=ca-nytimes_display_html&event=noscript"" /> 
</noscript>
<div style=""font-family: Arial; font-size: 10px; color:#004276; float: right; margin-right: 125px;""><a href=""http://www.nytimes.whsites.net/mediakit/"">Advertise on NYTimes.com</a></div></div>
</div>


<div id=""main"">
<div class=""spanAB wrap closing"">
<div id=""abColumn"" class=""abColumn""><!--open abColumn -->
<div id=""article"">
<!--cur: prev:-->
<div class=""columnGroup first"">				
<h1 itemprop=""headline""  class=""articleHeadline""><NYT_HEADLINE  version=""1.0"" type="" "">Ecuador Leader Says Biden Called About Asylum Request</NYT_HEADLINE></h1><NYT_BYLINE >
<h6 class=""byline"">By 
<span itemprop=""author creator"" itemscope itemtype=""http://schema.org/Person"" itemid=""http://topics.nytimes.com/top/reference/timestopics/people/n/william_neuman/index.html"">
<a href=""http://topics.nytimes.com/top/reference/timestopics/people/n/william_neuman/index.html"" rel=""author"" title=""More Articles by WILLIAM NEUMAN""><span itemprop=""name"">WILLIAM NEUMAN</span></a></span></h6>
</NYT_BYLINE>
<h6 class=""dateline"">Published: June 29, 2013    </h6>
<div class=""shareTools shareToolsThemeClassic articleShareToolsTop""
	data-shares=""facebook,twitter,google,save,email,showall|Share,print,singlepage,reprints,ad"" 
	data-title=""Ecuador Leader Says Biden Called About Asylum Request"" 
	data-url=""http://www.nytimes.com/2013/06/30/world/americas/ecuador-leader-says-biden-called-him-about-snowden.html"" 
	data-description=""The president of Ecuador said that Vice President Joseph R. Biden Jr. had asked him not to grant asylum to Edward J. Snowden, the fugitive former security contractor wanted in the United States.""></div>
<meta name=""emailThisHash"" content=""RpEJStR6/pxUaBfLCsYlsQ"">
<div class=""articleBody"">
<span itemprop=""copyrightHolder provider sourceOrganization"" itemscope itemtype=""http://schema.org/Organization"" itemid=""http://www.nytimes.com"">
<meta itemprop=""name"" content=""The New York Times Company""/>
<meta itemprop=""url"" content=""http://www.nytco.com/""/>
<meta itemprop=""tickerSymbol"" content=""NYSE NYT""/>
</span>
<meta itemprop=""copyrightYear"" content=""2013""/>





<NYT_TEXT >

<NYT_CORRECTION_TOP>
</NYT_CORRECTION_TOP>
    <p itemprop=""articleBody"">
QUITO, Ecuador — President <a href=""http://topics.nytimes.com/top/reference/timestopics/people/c/rafael_correa/index.html?inline=nyt-per"" title=""More articles about Rafael Correa."" class=""meta-per"">Rafael Correa</a> of <a href=""http://topics.nytimes.com/top/news/international/countriesandterritories/ecuador/index.html?inline=nyt-geo"" title=""More news and information about Ecuador."" class=""meta-loc"">Ecuador</a> said Saturday that Vice President <a href=""http://topics.nytimes.com/top/reference/timestopics/people/b/joseph_r_jr_biden/index.html?inline=nyt-per"" title=""More articles about Joseph R. Biden Jr."" class=""meta-per"">Joseph R. Biden Jr.</a> had asked him in a telephone call not to grant asylum to Edward J. Snowden, the fugitive former security contractor wanted in the United States.        </p> 
</div>
<div class=""articleInline runaroundLeft"">
  
<!--forceinline-->   
<div class=""inlineImage module"">
<div class=""image"">
<div class=""icon enlargeThis""><a href=""javascript:pop_me_up2('http://www.nytimes.com/imagepages/2013/06/30/world/ecuador.html','ecuador_html','width=676,height=630,scrollbars=yes,toolbars=no,resizable=yes')"">Enlarge This Image</a></div>
<a href=""javascript:pop_me_up2('http://www.nytimes.com/imagepages/2013/06/30/world/ecuador.html','ecuador_html','width=676,height=630,scrollbars=yes,toolbars=no,resizable=yes')"">
<span itemprop=""associatedMedia"" itemscope itemid=""http://graphics8.nytimes.com/images/2013/06/30/world/ecuador/ecuador-articleInline.jpg"" itemtype=""http://schema.org/ImageObject"">
<img itemprop=""url"" src=""http://graphics8.nytimes.com/images/2013/06/30/world/ecuador/ecuador-articleInline.jpg"" width=""190"" height=""157"" alt="""">
<meta itemprop=""identifier"" content=""http://graphics8.nytimes.com/images/2013/06/30/world/ecuador/ecuador-articleInline.jpg"" />
<meta itemprop=""height"" content=""190"" />
<meta itemprop=""width"" content=""157"" />
<meta itemprop=""copyrightHolder"" content=""Rodrigo Buendia/Agence France-Presse — Getty Images"" />
</span>
</a>
</div>
<h6 class=""credit"">Rodrigo Buendia/Agence France-Presse — Getty Images</h6>
<p class=""caption"">President Rafael Correa of Ecuador, center, before an image of Edward J. Snowden in a television studio on Saturday.                            </p>
</div>
  
<div class=""columnGroup doubleRule"">     
<h3 class=""sectionHeader"">Related in Opinion</h3>
<ul class=""headlinesOnly multiline flush"">
<li>
<h6><a href=""http://www.nytimes.com/roomfordebate/2013/06/25/where-should-a-fugitive-like-edward-snowden-hide/?ref=americas"">
Room for Debate: Where Can a Fugitive Hide?</a>
(June 25, 2013)
</h6>
</li>
</ul>
</div>
<div class=""doubleRule""><div class=""story"">

<div class=""runaroundRight""><a href=""http://twitter.com/#!/nytimesworld""><img src=""http://graphics8.nytimes.com/images/2012/04/26/world/nytimesworld-twitter-icon/nytimesworld-twitter-icon-thumbStandard.jpg"" height=""75"" width=""75"" alt=""World Twitter Logo."" /></a></div>
  <h4><a href=""http://twitter.com/#!/nytimesworld"">Connect With Us on Twitter</a></h4>
  <p class=""summary"">Follow <a href=""http://twitter.com/#!/nytimesworld"">@nytimesworld</a> for international breaking news and headlines.</p>

<p class=""summary""><a href=""https://twitter.com/nytimesworld/nyt-foreign-journalists""> Twitter List: Reporters and Editors</a></p>

</div></div>   
</div>
<div class=""articleBody"">
 <p itemprop=""articleBody"">
Mr. Correa, speaking on his weekly television broadcast, said that the two had a “cordial” conversation on Friday initiated by Mr. Biden, but said he could not decide on Mr. Snowden’s request until he entered Ecuador.        </p><p itemprop=""articleBody"">
The fallout from Mr. Snowden’s disclosures widened Saturday, as the German magazine Der Spiegel reported that the United States had eavesdropped on European Union offices in Washington, Brussels and at the United Nations in New York. Mr. Snowden, a former National Security Agency contractor who revealed details about American surveillance programs, fled to Hong Kong last month and then left there in a bid to find a haven to escape charges of violating espionage laws in the United States. He arrived in Moscow last Sunday, where he has remained out of sight, apparently cloistered in a transit area of the airport there.        </p><p itemprop=""articleBody"">
Ecuadorean officials have said that Mr. Snowden asked them for asylum. But after initially signaling that his government was studying the request, Mr. Correa said Thursday that under his country’s laws, the request could not be processed unless Mr. Snowden was in Ecuador or one of its embassies.        </p><p itemprop=""articleBody"">
In Washington, Bernadette Meehan, a National Security Council spokeswoman, called the discussion between Mr. Correa and Mr. Biden “a broad conversation regarding the bilateral relationship.”        </p><p itemprop=""articleBody"">
“They did discuss Mr. Snowden, but we are not going to provide details on their discussion,” she said in an e-mail.        </p><p itemprop=""articleBody"">
Still, Mr. Biden’s call to Mr. Correa, the highest-level contact between an American official and the Ecuadorean president since revelations about Mr. Snowden’s role in releasing classified N.S.A. documents, raised new questions about whether Ecuador is having qualms about granting asylum to Mr. Snowden.        </p><p itemprop=""articleBody"">
White House officials have said in recent days that in their contacts with foreign governments about Mr. Snowden, they have warned those governments about the felony charges that Mr. Snowden faced in the United States and urged that they not further aid his international flight.        </p><p itemprop=""articleBody"">
Mr. Correa regularly denounces the United States, calling it an imperialist power that tries to bully small countries like Ecuador. But he said he told Mr. Biden that Ecuador would take the opinion of the United States into account if it eventually had to make a decision in the case.        </p><p itemprop=""articleBody"">
He contrasted Mr. Biden’s courteous attitude with what he has characterized as the bad manners of some members of Congress who have threatened to end trade benefits for Ecuador’s exports to the United States if the country decides to give refuge to Mr. Snowden.        </p><p itemprop=""articleBody"">
The Ecuadorean president also said last week that Ecuadorean officials had had little contact with Mr. Snowden since his arrival in Moscow.        </p><p itemprop=""articleBody"">
Mr. Correa said Thursday in a news conference: “The only contact that there has been given Mr. Snowden’s asylum request, which the foreign minister made public, is that the ambassador went to see him in the Moscow airport. He wasn’t able to see him the first day, according to what the ambassador informed me, but he saw him the second day. He saw that he was in good health. He repeated his desire that Ecuador grant him asylum. Since then we really haven’t had any further contact.”        </p><p itemprop=""articleBody"">
It is not clear how Mr. Snowden could get to Ecuador or one of its embassies. The United States has revoked his passport, and Mr. Correa denied reports that Ecuador gave him papers permitting him to travel internationally.        </p><p itemprop=""articleBody"">
Last year, Ecuador granted asylum to Julian Assange, the founder of WikiLeaks, who has been stuck in the country’s embassy in London ever since.        </p><p itemprop=""articleBody"">
On Saturday, Der Speigel reported that it was able to review “top secret” N.S.A. documents in Mr. Snowden’s possession dated September 2010 that showed that the agency had infiltrated European Union computers in two locations to monitor telephone conversations, e-mails and other documents.        </p><p itemprop=""articleBody"">
The magazine said that surveillance devices were installed in the European Union’s offices in Washington and that the organization’s computer networks in Brussels had been infiltrated.        </p><p itemprop=""articleBody"">
The lead writer of the article was Laura Poitras, 49, a documentary filmmaker who emerged as the pivotal connection between Mr. Snowden and writers for The Guardian and The Washington Post who published his leaked documents about government surveillance. She has shared bylines with reporters of those publications in their coverage of the N.S.A. leaks.        </p><p itemprop=""articleBody"">
If Mr. Snowden, through Ms. Poitras, showed parts of his trove to Der Spiegel, it would mark an expansion of his journalistic collaborations, which so far have included The Guardian, The Post and The South China Morning Post of Hong Kong. The Morning Post reported this month that Mr. Snowden had provided detailed data showing the dates and Internet protocol addresses of specific computers in mainland China and Hong Kong that the N.S.A. penetrated over the last four years.        </p>
         <noscript>
             <img src=""http://meter-svc.nytimes.com/meter.gif""/>
         </noscript>
      <NYT_AUTHOR_ID>	<div class=""authorIdentification"">
<p>Maggy Ayala contributed reporting from Quito, and Eric Schmitt from Washington.</p>	</div>
</NYT_AUTHOR_ID><NYT_CORRECTION_BOTTOM>	<div class=""articleCorrection"">
</div>
</NYT_CORRECTION_BOTTOM><NYT_UPDATE_BOTTOM>
</NYT_UPDATE_BOTTOM>
</NYT_TEXT>
</div>
</div>
<!--cur: prev:-->
<div class=""columnGroup "">				
<div class=""articleFooter"">
<div class=""articleMeta"">
<div class=""opposingFloatControl wrap"">
<div class=""element1"">
<h6 class=""metaFootnote"">A version of this article appeared in print on June 30, 2013, on page <span itemprop=""printSection"">A</span><span itemprop=""printPage"">8</span> of the <span itemprop=""printEdition"">New York edition</span> with the headline: Ecuador Leader Says Biden Called Him About Snowden.</h6>
</div>
</div>
</div>

<img itemprop=""newsUsageTag"" src=""http://analytics.apnewsregistry.com/analytics/v2/image.svc/TheNewYorkTimes/RWS/nytimes.com/CAI/100000002310821/E/prod/PC/Basic/AT/A"" alt="""" width=""1"" height=""1"" style=""display:none;"" />

</div>	</div>
<!--cur: prev:-->
<div class=""columnGroup "">				
<div class=""shareTools shareToolsThemeClassic shareToolsThemeClassicHorizontal articleShareToolsBottom""
	data-shares=""facebook|,twitter|,google|,save,email,showall|Share"" 
	data-title=""Ecuador Leader Says Biden Called About Asylum Request"" 
	data-url=""http://www.nytimes.com/2013/06/30/world/americas/ecuador-leader-says-biden-called-him-about-snowden.html"" 
	data-description=""The president of Ecuador said that Vice President Joseph R. Biden Jr. had asked him not to grant asylum to Edward J. Snowden, the fugitive former security contractor wanted in the United States.""></div>
<meta name=""emailThisHash"" content=""RpEJStR6/pxUaBfLCsYlsQ"">
</div>
<!--cur: prev:-->
<div class=""columnGroup "">				

<div class=""singleAd"" id=""Bottom1"">
<!-- ADXINFO classification=""Text_Link"" campaign=""nyt2013_footer_digi_hp_ros_3JL63_ANON"" priority=""1001"" width=""0"" height=""0"" --><table width=""100%"" border=""0"">
<tr>
<td width=""300""><a href=""http://www.nytimes.com/adx/bin/adx_click.html?type=goto&opzn&page=www.nytimes.com/yr/mo/day/world/americas&pos=Bottom1&sn2=8105e6cb/d18c2c22&sn1=7c3c7d4/3eeb42e0&camp=nyt2013_footer_digi_hp_ros_3JL63_ANON&ad=footer_digi_hp_ros_3JL63_ANON&goto=http%3A%2F%2Fwww%2Enytimes%2Ecom%2Fsubscriptions%2FMultiproduct%2Flp5558%2Ehtml%3Fadxc%3D212428%26adxa%3D332971%26page%3Dwww.nytimes.com/yr/mo/day/world/americas/ecuador-leader-says-biden-called-him-about-snowden.html%26pos%3DBottom1%26campaignId%3D3JL63""><img src=""http://graphics8.nytimes.com/adx/images/ADS/33/29/ad.332971/12-0999-Footer_Icon.jpg"" height=""27"" width=""40"" style=""float: left; margin-right: 5px;"" alt=""Get Home Delivery"" align=""middle"" border=""0""/>Try unlimited access to NYTimes.com for just 99&cent;.&nbsp; SEE OPTIONS &raquo;</a>

</td>
</tr>
</table>
</div>

</div>
<!--cur: prev:-->
<div class=""columnGroup "">				
</div>
<!--cur: prev:-->
<div class=""columnGroup "">				
<div class=""singleRuleDivider""></div>
<div class=""articleBottomExtra"">
<div class=""column lastColumn"">
<div class=""emailAlertModule module"">
<h5 class=""sectionHeaderSm"">Get Free E-mail Alerts on These Topics</h5>
<form action=""https://myaccount.nytimes.com/mem/tnt.html"" method=""GET"" enctype=""application/x-www-form-urlencoded"">
<input type=""hidden"" name=""retA"" value=""http://www.nytimes.com//2013/06/30/world/americas/ecuador-leader-says-biden-called-him-about-snowden.html"" >
<input type=""hidden"" name=""retT"" value=""Ecuador Leader Says Biden Called About Asylum Request"">
<input type=""hidden"" name=""module"" value=""call"">
<input type=""hidden"" name=""alert_context"" value=""1"">
<table>
<tbody>
<tr>
<td class = ""column"">
<input type=""hidden"" name=""topic1"" value=""Snowden%2C+Edward+J"">
<input type=""hidden"" name=""topic_field1"" value=""per"">
<a class=""inTextReferEmail"" href=""https://myaccount.nytimes.com/mem/tnt.html?module=call&alert_context=1&topic1=Snowden%2C+Edward+J&topic_field1=per&topic1_check=y&retA=&retT=&cskey="" onClick=""javascript:s_code_linktrack('Article-RelatedTopics'); dcsMultiTrack('DCS.dcssip','www.nytimes.com','DCS.dcsuri','/newstracker/add.html','WT.ti','Newstracker Add','WT.z_nta','Add','WT.pers','Per','WT.z_dcsm','1');"" onmousedown=""NYTD.relatedSearches.clickHandler(event);""  >
<span itemprop=""about"" itemscope itemtype=""http://schema.org/Person""><span itemprop=""name"">Snowden, Edward J</span></span>
</a>
</td>
<td class = ""lastColumn"">
<input type=""hidden"" name=""topic1"" value=""Biden%2C+Joseph+R+Jr"">
<input type=""hidden"" name=""topic_field1"" value=""per"">
<a class=""inTextReferEmail"" href=""https://myaccount.nytimes.com/mem/tnt.html?module=call&alert_context=1&topic1=Biden%2C+Joseph+R+Jr&topic_field1=per&topic1_check=y&retA=&retT=&cskey="" onClick=""javascript:s_code_linktrack('Article-RelatedTopics'); dcsMultiTrack('DCS.dcssip','www.nytimes.com','DCS.dcsuri','/newstracker/add.html','WT.ti','Newstracker Add','WT.z_nta','Add','WT.pers','Per','WT.z_dcsm','1');"" onmousedown=""NYTD.relatedSearches.clickHandler(event);""  >
<span itemprop=""about"" itemscope itemtype=""http://schema.org/Person""><span itemprop=""name"">Biden, Joseph R Jr</span></span>
</a>
</td>
</tr>
<tr>
<td class = ""column singleRule"">
<input type=""hidden"" name=""topic1"" value=""Correa%2C+Rafael"">
<input type=""hidden"" name=""topic_field1"" value=""per"">
<a class=""inTextReferEmail"" href=""https://myaccount.nytimes.com/mem/tnt.html?module=call&alert_context=1&topic1=Correa%2C+Rafael&topic_field1=per&topic1_check=y&retA=&retT=&cskey="" onClick=""javascript:s_code_linktrack('Article-RelatedTopics'); dcsMultiTrack('DCS.dcssip','www.nytimes.com','DCS.dcsuri','/newstracker/add.html','WT.ti','Newstracker Add','WT.z_nta','Add','WT.pers','Per','WT.z_dcsm','1');"" onmousedown=""NYTD.relatedSearches.clickHandler(event);""  >
<span itemprop=""about"" itemscope itemtype=""http://schema.org/Person""><span itemprop=""name"">Correa, Rafael</span></span>
</a>
</td>
<td class = ""lastColumn singleRule"">
<input type=""hidden"" name=""topic1"" value=""United+States+International+Relations"">
<input type=""hidden"" name=""topic_field1"" value=""des"">
<a class=""inTextReferEmail"" href=""https://myaccount.nytimes.com/mem/tnt.html?module=call&alert_context=1&topic1=United+States+International+Relations&topic_field1=des&topic1_check=y&retA=&retT=&cskey="" onClick=""javascript:s_code_linktrack('Article-RelatedTopics'); dcsMultiTrack('DCS.dcssip','www.nytimes.com','DCS.dcsuri','/newstracker/add.html','WT.ti','Newstracker Add','WT.z_nta','Add','WT.pers','Per','WT.z_dcsm','1');"" onmousedown=""NYTD.relatedSearches.clickHandler(event);""  >
<span itemprop=""about"" itemscope itemtype=""http://schema.org/Thing""><span itemprop=""name"">United States International Relations</span></span>
</a>
</td>
</tr>
</tbody>
</table>
</form>
</div>
</div>
</div>	</div>
<!--cur: prev:-->
<div class=""columnGroup last"">				

<div class=""columnGroup"" id=""adxSponLink""></div>
<script language=""JavaScript"">
        google_hints=""Ecuador Leader Says Biden Called About Asylum Request"";google_ad_channel=""archive, archive_world, archive_World"";
</script>
<!-- ADXINFO classification=""Email_Text_Ad_Version"" campaign=""GoogleAdSense_ARTICLE_SPONLINK"" priority=""1002"" width=""0"" height=""0"" --><script language=""JavaScript"" type=""text/javascript"">
 // Sponlink_short 

function getMetaValue(name) {
  var els = document.getElementsByName(name);
  if (els && els[0]) { return els[0].content; }
  return """";
}

    NYTD.GoogleAds.paramObj = {google_ad_client:'nytimes_article_var', google_ad_channel:'left', ad_target_list:'sponLink' };
    NYTD.GoogleAds.paramObj.google_hints = getMetaValue('keywords');
    NYTD.GoogleAds.getGoogleAds(""AFC"", NYTD.GoogleAds.paramObj);
 </script>

</div>
</div>
</div><!--close abColumn -->
<div id=""cColumn"" class=""cColumn"">

<div class=""columnGroup"">

</div>
<!---->                    <div class=""columnGroup first"">

</div>
<!---->                    <div class=""columnGroup "">

<div class=""singleAd"" id=""MiddleRight"">
<!-- ADXINFO classification=""Big_Ad_-_Standard"" campaign=""GoogleAdSense_ROS_INT_BA"" priority=""1340"" width=""300"" height=""250"" --><div class=""clearfix"">
<script language=""JavaScript"">
<!--
if (!window.nyt_google_count) { var nyt_google_count = 0; }
if ((!window.nyt_google_ad_channel) && (window.google_ad_channel)) { var nyt_google_ad_channel = google_ad_channel; }
if ((!window.nyt_google_hints) && (window.google_hints)) { var nyt_google_hints = google_hints; }
if ((!window.nyt_google_contents) && (window.google_contents)) { var nyt_google_contents = google_contents; }
function ss(w,id) {window.status = w;return true;}function cs(){window.status='';}function ha(a){  pha=document.getElementById(a); nhi=pha.href.indexOf(""&nh="");if(nhi < 1) {phb=pha.href+""&nh=1"";} pha.href=phb;}function ca(a) {  pha=document.getElementById(a); nci=pha.href.indexOf(""&nc="");if(nci < 1) {phb=pha.href+""&nc=1"";} pha.href=phb;window.open(document.getElementById(a).href);}function ga(o,e) {if (document.getElementById) {a=o.id.substring(1);p = """";r = """";g = e.target;if (g) {t = g.id;f = g.parentNode;if (f) {p = f.id;h = f.parentNode;if (h)r = h.id;}} else {h = e.srcElement;f = h.parentNode;if (f)p = f.id;t = h.id;}if (t==a || p==a || r==a)return true;pha=document.getElementById(a); nbi=pha.href.indexOf(""&nb="");if(nbi < 1) {phb=pha.href+""&nb=1"";} pha.href=phb;window.open(document.getElementById(a).href);}}
 
function google_ad_request_done(ads) {
    var s = '';
    var i;
 
    if (ads.length == 0) {
        return;
    }
 
    if (ads[0].type == ""image"") {
        s += '<a href=""' + ads[0].url +
        '"" target=""_blank"" title=""go to ' + ads[0].visible_url +
        '""><img border=""0"" src=""' + ads[0].image_url +
        '""width=""' + ads[0].image_width +
        '""height=""' + ads[0].image_height + '""></a>';
    } else if (ads[0].type == ""flash"") {
        s += '<object classid=""clsid:D27CDB6E-AE6D-11cf-96B8-444553540000""' +
        ' codebase=""http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,0,0""' +
        ' WIDTH=""' + google_ad.image_width +
        '"" HEIGHT=""' + google_ad.image_height + '"">' +
        '<PARAM NAME=""movie"" VALUE=""' + google_ad.image_url + '"">' +
        '<PARAM NAME=""quality"" VALUE=""high"">' +
        '<PARAM NAME=""AllowScriptAccess"" VALUE=""never"">' +
        '<EMBED src=""' + google_ad.image_url +
        '"" WIDTH=""' + google_ad.image_width +
        '"" HEIGHT=""' + google_ad.image_height +
        '"" TYPE=""application/x-shockwave-flash""' +
        ' AllowScriptAccess=""never"" ' +
        ' PLUGINSPAGE=""http://www.macromedia.com/go/getflashplayer""></EMBED></OBJECT>';
    } else if (google_ads[0].type == ""html"") {
       s += google_ads[0].snippet;
    } else if (ads[0].type == ""text"") {
        nyt_google_count += ads.length;
        google_ad_section_line_height = ""14px"";
        google_ad_section_padding_left = ""7px"";
        google_title_link_font_size = ""12px"";
        google_ad_text_font_size = ""11px"";
        google_visible_url_font_size = ""10px"";
 
        s += '<table width=""100%"" height="""" border=""0"" cellspacing=""0"" cellpadding=""0"" style=""text-align:left; width:100%; border-style: solid; border-width: 1px; border-color: #9da3ad"" >\n<tr>\n<td style=""font-family:Arial,Helvetica,sans-serif; font-size:12px; color:#333333;"" valign=""top""><table width=""100%"" height=""100%"" cellspacing=""0"" cellpadding=""0"" border=""0"" style=""width:100%; height:100%;"">\n<tr>\n <td style=""background-color:#9da3ad; width:70%; height:20px; padding-top:2px; padding-left:11px; padding-bottom:2px; font-family:Arial,Helvetica,sans-serif; font-size:12px; color:#333333;"" width=""70%"" height=""20"" bgcolor=""#9da3ad"" ><span style=""font-size: 12px; font-weight: normal; color:#ffffff;"" >Ads by Google</span></td>\n<td style=""padding-top:2px; padding-bottom:2px; width:30%; height:20px; align:right; background-color:#9da3ad; font-family:Arial,Helvetica,sans-serif; font-size:12px; color:#333333;"" width=""30%"" height=""20"" align=""right"" bgcolor=""#9da3ad"" ><span><a style=""font-family:Arial,Helvetica,sans-serif; color: white; font-size:12px; padding-right:7px;"" href=""http://www.nytimes.com/ref/membercenter/faq/linkingqa16.html"" onclick=""window.open(\'\',\'popupad\',\'left=100,top=100,width=390,height=390,resizable,scrollbars=no\')"" target=""popupad"">what\'s this?</a></span></td>\n</tr>\n</table>\n</td>\n</tr>\n<tr>\n<td style=""height:110px; font-family:Arial,Helvetica,sans-serif; font-size:12px; color:#333333;"" valign=""top"" height=""110""><table height=""100%"" width=""100%"" cellpadding=""4"" cellspacing=""0"" border=""0"" bgcolor=""#f8f8f9"" style=""height:100%; width:100%; padding:4px; background-color:#f8f8f9;"">\n';
        for (i = 0; i < ads.length; ++i) {
            s += '<tr>\n<td style=""cursor:pointer; cursor:hand; font-family:Arial,Helvetica,sans-serif; font-size:12px; color:#333333; background-color:#f8f8f9;"" id=""taw' + i + '"" valign=""middle"" onFocus=""ss(\'go to ' + ads[i].visible_url + '\',\'aw' + i + '\')"" onMouseOver=""ss(\'go to ' + ads[i].visible_url + '\',\'aw' + i + '\')""  onMouseOut=""cs()"" onClick=""ga(this,event)""><div style=""line-height:' + google_ad_section_line_height + '; padding-left:' + google_ad_section_padding_left + '; padding-bottom:5px;"" ><a id=""aw' + i + '"" href=""' + ads[i].url + '"" target=""_blank"" style=""font-size:' + google_title_link_font_size + '; color:#000066; font-weight:bold; text-decoration:underline;"" onFocus=""ss(\'go to ' + ads[i].visible_url + '\',\'aw' + i + '\')"" onClick=""ha(\'aw' + i + '\')"" onMouseOver=""return ss(\'go to ' + ads[i].visible_url + '\',\'aw' + i + '\')""  onMouseOut=""cs()"">' + ads[i].line1 + '</a><br>\n<a href=""' + ads[i].url + '"" target=""_blank"" style=""font-family:Arial,Helvetica,sans-serif; font-size:' + google_ad_text_font_size + ';color:#333333;text-decoration:none;"">' + ads[i].line2 + ' ' + ads[i].line3 + '</a><br>\n<a href=""' + ads[i].url + '"" target=""_blank"" style=""font-size:' + google_visible_url_font_size + '; color:#000066; font-weight:normal; text-decoration:none;"">' + ads[i].visible_url + '</a></div>\n</td>\n</tr>\n';
        }
        s += '</table>\n</td>\n</tr>\n</table>';
    }
    document.write(s);
    return;
}
google_ad_client = 'ca-nytimes_display_html';
google_ad_channel = 'ROS_big_ad';
google_ad_output = 'js';
google_max_num_ads = '6';
google_ad_type = 'text,image,flash,html';
google_image_size = '300x250';
google_safe = 'high';
google_targeting = 'site_content';
if (window.nyt_google_contents) { google_contents = nyt_google_contents; }
else if (window.nyt_google_hints) { google_hints = nyt_google_hints; }
// -->
</script>
<script language=""JavaScript"" src=""http://pagead2.googlesyndication.com/pagead/show_ads.js""></script>

<div style=""font-family: Arial; font-size: 10px; color:#004276; float: right; margin-right: 9px;""><a href=""http://www.nytimes.whsites.net/mediakit/"">Advertise on NYTimes.com</a></div></div>
</div>

</div>
<!---->                    <div class=""columnGroup "">

</div>
<!---->                    <div class=""columnGroup "">

</div>
<!---->                    <div class=""columnGroup "">
<div id=""mostPopWidget"" class=""doubleRule nocontent""></div>
<script src=""http://graphics8.nytimes.com/js/app/recommendations/recommendationsModule.js"" type=""text/javascript"" charset=""utf-8""></script>
</div>
<!---->                    <div class=""columnGroup "">

</div>
<!---->                    <div class=""columnGroup "">

<div class=""bigAd"" id=""Box1"">
<!-- ADXINFO classification=""Marketing_Module"" campaign=""IHT2013-Mktg-336x280-US_ROS-Intl-Mktg_Module"" priority=""1002"" width=""336"" height=""280"" --><div style=""border:solid #999;border-width:1px;font-family:Arial,sans-serif;text-align:left; width:334px;background:#fff;"" class=""clearfix wrap"">
  <a href=""http://www.nytimes.com/adx/bin/adx_click.html?type=goto&opzn&page=www.nytimes.com/yr/mo/day/world/americas&pos=Box1&sn2=77b68c03/f65ba073&sn1=204ccd6a/d8cfd978&camp=IHT2013-Mktg-336x280-US_ROS-Intl-Mktg_Module&ad=21Jun13_Sports_360x280&goto=http://www.nytimes.com/2013/06/22/sports/tennis/22iht-srwitennis22.html?ref=global"" target=""_blank""><img src=""http://graphics8.nytimes.com/ads/marketing/mm13/sports/1371827330512_global.jpg"" alt="""" border=""0"" height=""154"" width=""334""></a> 
  <div style=""padding:7px 9px 0;background:#fff"">
    <h2 style=""font-size:22px;line-height:24px; margin:0;padding:0 0 4px;""><a style=""color:#4b8208;"" target=""_blank"" href=""http://www.nytimes.com/adx/bin/adx_click.html?type=goto&opzn&page=www.nytimes.com/yr/mo/day/world/americas&pos=Box1&sn2=77b68c03/f65ba073&sn1=204ccd6a/d8cfd978&camp=IHT2013-Mktg-336x280-US_ROS-Intl-Mktg_Module&ad=21Jun13_Sports_360x280&goto=http://www.nytimes.com/2013/06/22/sports/tennis/22iht-srwitennis22.html?ref=global"">The One-Handed Backhand's Vanishing Act</a></h2>
    <p style=""margin:0 0 3px; padding:0;font-size: 11px;"">
      <a href=""http://www.nytimes.com/adx/bin/adx_click.html?type=goto&opzn&page=www.nytimes.com/yr/mo/day/world/americas&pos=Box1&sn2=77b68c03/f65ba073&sn1=44fa7aaa/4b340681&camp=IHT2013-Mktg-336x280-US_ROS-Intl-Mktg_Module&ad=21Jun13_Sports_360x280&goto=http://global.nytimes.com/pages/sports/index.html"" target=""_blank"" style=""font-size:11px;margin:3px 0;padding:0;font-family:Arial,sans-serif;  color:#000; text-transform:uppercase;"">
      Also in Global Sports &raquo;
      </a>
    </p>
    <ul style=""font-size:12px;margin:0; padding-bottom: 10px; border-bottom: none;"" class=""refer"">
      <li style=""font-size:12px""><a target=""_blank"" href=""http://www.nytimes.com/adx/bin/adx_click.html?type=goto&opzn&page=www.nytimes.com/yr/mo/day/world/americas&pos=Box1&sn2=77b68c03/f65ba073&sn1=204ccd6a/d8cfd978&camp=IHT2013-Mktg-336x280-US_ROS-Intl-Mktg_Module&ad=21Jun13_Sports_360x280&goto=http://www.nytimes.com/2013/06/22/sports/tennis/22iht-srwinet22.html?ref=global"" style=""color: #004276"">As Rivals Come and Go, Tommy Haas Is Still Holding Court</a></li>
      <li style=""font-size:12px""><a target=""_blank"" href=""http://www.nytimes.com/adx/bin/adx_click.html?type=goto&opzn&page=www.nytimes.com/yr/mo/day/world/americas&pos=Box1&sn2=77b68c03/f65ba073&sn1=204ccd6a/d8cfd978&camp=IHT2013-Mktg-336x280-US_ROS-Intl-Mktg_Module&ad=21Jun13_Sports_360x280&goto=http://www.nytimes.com/2013/06/22/sports/tennis/22iht-srwimbledon22.html?ref=global"" style=""color: #004276"">A Clear Women's Favorite and Flux at the Top for Men</a></li>
    </ul>
  </div>
  
  <div style=""padding:0; float:left; width:316px; background:#faf9dc""><a href=""http://www.nytimes.com/adx/bin/adx_click.html?type=goto&opzn&page=www.nytimes.com/yr/mo/day/world/americas&pos=Box1&sn2=77b68c03/f65ba073&sn1=44fa7aaa/4b340681&camp=IHT2013-Mktg-336x280-US_ROS-Intl-Mktg_Module&ad=21Jun13_Sports_360x280&goto=http://global.nytimes.com/"" target=""_blank""><img src=""http://graphics8.nytimes.com/ads/marketing/mm09/verticalst/global_nytimes_iht.gif"" alt=""The New York Times | International Herald Tribune"" border=""0"" height=""29"" width=""334""></a></div>
  
  
  <br clear=""all"">
</div>
</div>

</div>
<!---->                    <div class=""columnGroup "">
<!--[TwoColumnAdLeft - Begin] -->
<!--[TwoColumnAdLeft - End] -->
</div>
<!---->                    <div class=""columnGroup "">

<div class=""singleAd"" id=""Middle5"">
<!-- ADXINFO classification=""Featured_Product_Image"" campaign=""nyt2013_300x79_ros_3JHWL_var_intGGB"" priority=""1001"" width=""120"" height=""90"" --><a href=""http://www.nytimes.com/adx/bin/adx_click.html?type=goto&opzn&page=www.nytimes.com/yr/mo/day/world/americas&pos=Middle5&sn2=3aa70832/a5b4d112&sn1=21929476/3b0924a8&camp=nyt2013_300x79_ros_3JHWL_var_intGGB&ad=300x79_3JHWL_var_intGGB&goto=http%3A%2F%2Fwww%2Enytimes%2Ecom%2Fsubscriptions%2FMultiproduct%2Flp3HLK8%2Ehtml%3Fadxc%3D211201%26adxa%3D331428%26page%3Dwww.nytimes.com/yr/mo/day/world/americas/ecuador-leader-says-biden-called-him-about-snowden.html%26pos%3DMiddle5%26campaignId%3D3JHWL"" target=""_blank"">
<img src=""http://graphics8.nytimes.com/adx/images/ADS/33/14/ad.331428/13-0869_GlobalEdition_Phase2_300x79_AD4.jpg"" width=""300"" height=""79"" border=""0"">
</a>

<span class=""adxInfo"" style=""display:none;"">campaign: nyt2013_300x79_ros_3JHWL_var_intGGB -- 211201, creative: 300x79_3JHWL_var_intGGB -- 331428, page: www.nytimes.com/yr/mo/day/world/americas/ecuador-leader-says-biden-called-him-about-snowden.html, targetedPage: www.nytimes.com/yr/mo/day/world/americas, position: Middle5</span>
</div>

</div>
<!---->                    <div class=""columnGroup last"">

</div>
<div class=""columnGroup"">

<div  id=""adxSponLinkA""></div>
<!-- ADXINFO classification=""Email_Text_Ad_Version"" campaign=""GoogleAdSense_ARTICLE_GOOGLE_SPONLINK_A"" priority=""1002"" width=""0"" height=""0"" --><script language=""JavaScript"" type=""text/javascript"">
    // Sponlink_A_Short

     if (document.getElementById(""MiddleRight"")) { google_targeting = 'content'; }
     NYTD.GoogleAds.getGoogleAds(""AFC"", { 
        google_ad_client:'nytimes_article_var',
        ad_target_list:'sponLinkA'
     });

</script>

</div>






<div class=""columnGroup"">
</div>
</div>
</div><!--close spanAB -->

  <!-- start MOTH -->
  	<div id=""insideNYTimes"" class=""doubleRule nocontent"">
            <script type=""text/javascript"" src=""http://js.nyt.com/js/app/moth/moth.js""></script>
        <div id=""insideNYTimesHeader"">
                    <div class=""navigation""><span id=""leftArrow""><img id=""mothReverse"" src=""http://i1.nyt.com/images/global/buttons/moth_reverse.gif"" /></span>&nbsp;<span id=""rightArrow""><img id=""mothForward"" src=""http://i1.nyt.com/images/global/buttons/moth_forward.gif"" /></span></div>
                <h4>
            Inside NYTimes.com        </h4>
    </div>
    
        
    <div id=""insideNYTimesScrollWrapper"">
        <table id=""insideNYTimesBrowser"" cellspacing=""0"">
            <tbody>
                <tr>
                                                <td class=""first"">
        <div class=""story"">
            <h6 class=""kicker"">
                                    <a href=""http://movies.nytimes.com/pages/movies/index.html"">Movies &raquo;</a>
                            </h6>
            <div class=""mothImage"">
                <a href=""http://www.nytimes.com/interactive/2013/06/28/movies/BLOCKBUSTER.html""><img src=""http://i1.nyt.com/images/2013/06/30/movies/30MOTH_BLOCKBUSTER/30MOTH_BLOCKBUSTER-moth.jpg"" alt=""Save My Summer Blockbuster!"" width=""151"" height=""151"" /></a>
            </div>
            <h6 class=""headline""><a href=""http://www.nytimes.com/interactive/2013/06/28/movies/BLOCKBUSTER.html"">Save My Summer Blockbuster!</a></h6>
        </div>
    </td>
                                                <td>
        <div class=""story"">
            <h6 class=""kicker"">
                                    <a href=""http://www.nytimes.com/pages/books/index.html"">Books &raquo;</a>
                            </h6>
            <div class=""mothImage"">
                <a href=""http://www.nytimes.com/2013/06/30/books/review/the-billionaires-apprentice-by-anita-raghavan.html""><img src=""http://i1.nyt.com/images/2013/06/30/books/30MOTH_Books_Partnoy/30MOTH_Books_Partnoy-moth.jpg"" alt=""The Rise and Fall of the Inside Men"" width=""151"" height=""151"" /></a>
            </div>
            <h6 class=""headline""><a href=""http://www.nytimes.com/2013/06/30/books/review/the-billionaires-apprentice-by-anita-raghavan.html"">The Rise and Fall of the Inside Men</a></h6>
        </div>
    </td>
                                                <td>
        <div class=""story"">
            <h6 class=""kicker"">
                                    <a href=""http://www.nytimes.com/pages/magazine/index.html"">Magazine &raquo;</a>
                            </h6>
            <div class=""mothImage"">
                <a href=""http://www.nytimes.com/2013/06/30/magazine/jimmy-wales-is-not-an-internet-billionaire.html?ref=magazine""><img src=""http://i1.nyt.com/images/2013/06/30/magazine/30moth_cover/30moth_cover-moth.png"" alt=""Jimmy Wales Is Not an Internet Billionaire"" width=""151"" height=""151"" /></a>
            </div>
            <h6 class=""headline""><a href=""http://www.nytimes.com/2013/06/30/magazine/jimmy-wales-is-not-an-internet-billionaire.html?ref=magazine"">Jimmy Wales Is Not an Internet Billionaire</a></h6>
        </div>
    </td>
                                                    <td>
            <div class=""story"">
                <h6 class=""kicker""><a href=""http://www.nytimes.com/pages/opinion/index.html"">Sunday Review &raquo;</a></h6>
                <h3><a href=""http://www.nytimes.com/2013/06/30/opinion/sunday/the-best-hope-for-frances-young-get-out.html"">Opinion: France&rsquo;s Young Should Get Out</a></h3>
                <p class=""summary"">Ambitious people should leave this overcentralized gerontocracy and go see the world.</p>
            </div>
        </td>
                                                <td>
        <div class=""story"">
            <h6 class=""kicker"">
                                    <a href=""http://www.nytimes.com/pages/fashion/index.html"">Fashion & Style &raquo;</a>                            </h6>
            <div class=""mothImage"">
                <a href=""http://www.nytimes.com/pages/fashion/weddings/index.html""><img src=""http://i1.nyt.com/images/2013/06/30/fashion/weddings/30MOTH_VOWS/30MOTH_VOWS-moth-v2.png"" alt=""Weddings and Celebrations"" width=""151"" height=""151"" /></a>
            </div>
            <h6 class=""headline""><a href=""http://www.nytimes.com/pages/fashion/weddings/index.html"">Weddings and Celebrations</a></h6>
        </div>
    </td>
                                                <td>
        <div class=""story"">
            <h6 class=""kicker"">
                                    <a href=""http://www.nytimes.com/pages/opinion/index.html"">Sunday Review &raquo;</a>                            </h6>
            <div class=""mothImage"">
                <a href=""http://www.nytimes.com/2013/06/30/opinion/sunday/i-love-la.html""><img src=""http://i1.nyt.com/images/2013/06/30/sunday-review/30MOTH_Exposures/30MOTH_Exposures-moth.jpg"" alt=""Exposures: I Love L.A."" width=""151"" height=""151"" /></a>
            </div>
            <h6 class=""headline""><a href=""http://www.nytimes.com/2013/06/30/opinion/sunday/i-love-la.html"">Exposures: I Love L.A.</a></h6>
        </div>
    </td>
                                                <td class=""hidden"">
        <div class=""story"">
            <h6 class=""kicker"">
                                    <a href=""http://theater.nytimes.com/pages/theater/index.html"">Theater &raquo;</a>
                            </h6>
            <div class=""mothImage"">
                <a href=""http://theater.nytimes.com/2013/06/30/theater/off-broadway-borrows-from-reality-televsion.html""><span class=""img"" src=""http://i1.nyt.com/images/2013/06/30/theater/30MOTH_REALITY/30MOTH_REALITY-moth.jpg"" alt=""Some Playwrights Get &lsquo;Real&rsquo;"" width=""151"" height=""151"" /></a>
            </div>
            <h6 class=""headline""><a href=""http://theater.nytimes.com/2013/06/30/theater/off-broadway-borrows-from-reality-televsion.html"">Some Playwrights Get &lsquo;Real&rsquo;</a></h6>
        </div>
    </td>
                                                <td class=""hidden"">
        <div class=""story"">
            <h6 class=""kicker"">
                                    <a href=""http://www.nytimes.com/pages/nyregion/index.html"">N.Y. / Region &raquo;</a>
                            </h6>
            <div class=""mothImage"">
                <a href=""http://www.nytimes.com/interactive/2013/06/30/nyregion/album-disappearing-in-place.html""><span class=""img"" src=""http://i1.nyt.com/images/2013/06/30/nyregion/30MOTH_ALBUM/30MOTH_ALBUM-moth.jpg"" alt=""Disappearing in Place"" width=""151"" height=""151"" /></a>
            </div>
            <h6 class=""headline""><a href=""http://www.nytimes.com/interactive/2013/06/30/nyregion/album-disappearing-in-place.html"">Disappearing in Place</a></h6>
        </div>
    </td>
                                                    <td class=""hidden"">
            <div class=""story"">
                <h6 class=""kicker""><a href=""http://www.nytimes.com/pages/opinion/index.html"">Sunday Review &raquo;</a></h6>
                <h3><a href=""http://www.nytimes.com/2013/06/30/opinion/sunday/the-talented-justice-kagan.html"">Notebook: The Talented Justice Kagan</a></h3>
                <p class=""summary"">Elena Kagen offers penetrating legal analysis, but with a down-to-earth writing style.</p>
            </div>
        </td>
                                                <td class=""hidden"">
        <div class=""story"">
            <h6 class=""kicker"">
                                    <a href=""http://www.nytimes.com/pages/travel/index.html"">Travel &raquo;</a>
                            </h6>
            <div class=""mothImage"">
                <a href=""http://travel.nytimes.com/2013/06/30/travel/getting-your-feet-wet-at-water-parks.html""><span class=""img"" src=""http://i1.nyt.com/images/2013/06/30/travel/30MOTH_WATERPARK/30MOTH_WATERPARK-moth.jpg"" alt=""Getting Your Feet Wet at Water Parks"" width=""151"" height=""151"" /></a>
            </div>
            <h6 class=""headline""><a href=""http://travel.nytimes.com/2013/06/30/travel/getting-your-feet-wet-at-water-parks.html"">Getting Your Feet Wet at Water Parks</a></h6>
        </div>
    </td>
                                                <td class=""hidden"">
        <div class=""story"">
            <h6 class=""kicker"">
                                    <a href=""http://www.nytimes.com/pages/opinion/index.html"">Sunday Review &raquo;</a>                            </h6>
            <div class=""mothImage"">
                <a href=""http://www.nytimes.com/thestrip""><span class=""img"" src=""http://i1.nyt.com/images/2013/06/30/sunday-review/30MOTH_Strip/30MOTH_Strip-moth.jpg"" alt=""The Strip: Cutting Carbon the Healthy Way"" width=""151"" height=""151"" /></a>
            </div>
            <h6 class=""headline""><a href=""http://www.nytimes.com/thestrip"">The Strip: Cutting Carbon the Healthy Way</a></h6>
        </div>
    </td>
                                                <td class=""hidden"">
        <div class=""story"">
            <h6 class=""kicker"">
                                    <a href=""http://www.nytimes.com/pages/arts/design/index.html"">Art & Design &raquo;</a>                            </h6>
            <div class=""mothImage"">
                <a href=""http://www.nytimes.com/2013/06/30/arts/design/thomas-hirschhorn-picks-bronx-development-as-art-site.html""><span class=""img"" src=""http://i1.nyt.com/images/2013/06/30/nyregion/30MOTH_HIrsch/30MOTH_HIrsch-moth.png"" alt=""Bringing Art and Change to the Bronx"" width=""151"" height=""151"" /></a>
            </div>
            <h6 class=""headline""><a href=""http://www.nytimes.com/2013/06/30/arts/design/thomas-hirschhorn-picks-bronx-development-as-art-site.html"">Bringing Art and Change to the Bronx</a></h6>
        </div>
    </td>
                                    </tr>
            </tbody>
        </table>
    </div>
    
    </div><!-- end #insideNYTimes -->

            </div><!--close main -->
<footer class=""pageFooter"">
<div class=""inset"">
<nav class=""pageFooterNav"">
<ul class=""pageFooterNavList wrap"">
<li class=""firstItem""><a href=""http://www.nytco.com/"">&copy; 2013 The New York Times Company</a></li>
<li><a href=""http://spiderbites.nytimes.com/"">Site Map</a></li>
<li><a href=""http://www.nytimes.com/privacy"">Privacy</a></li>
<li><a href=""http://www.nytimes.com/ref/membercenter/help/privacy.html#pp"">Your Ad Choices</a></li>
<li><a href=""http://www.nytimes.whsites.net/mediakit/"">Advertise</a></li>
<li><a href=""http://www.nytimes.com/content/help/rights/sale/terms-of-sale.html "">Terms of Sale</a></li>
<li><a href=""http://www.nytimes.com/ref/membercenter/help/agree.html"">Terms of Service</a></li>
<li><a href=""http://www.nytco.com/careers"">Work With Us</a></li>
<li><a href=""http://www.nytimes.com/rss"">RSS</a></li>
<li><a href=""http://www.nytimes.com/membercenter/sitehelp.html"">Help</a></li>
<li><a href=""http://www.nytimes.com/ref/membercenter/help/infoservdirectory.html"">Contact Us</a></li>
<li class=""lastItem""><a href=""https://myaccount.nytimes.com/membercenter/feedback.html"">Site Feedback</a></li>
</ul>
</nav>
</div><!--close inset -->
</footer><!--close pageFooter -->
</div><!--close page -->
</div><!--close shell -->
<IMG CLASS=""hidden"" SRC=""/adx/bin/clientside/2df43d09Q2FPPP(Q7CUQ3Be5UQ7DPe(UBnT,kQ7DQ2AUQ26mkLJ(Q26Q27ty3-Q7C-Q22(Q27Q7DLQ22Q7C"" height=""1"" width=""3"">
   


</body>


			
		<!-- Start UPT call -->
		<img height=""1"" width=""3"" border=0 src=""http://up.nytimes.com/?d=0//15&t=6&s=0&ui=0&r=http%3a%2f%2fnews%2egoogle%2ecom%2f&u=www%2enytimes%2ecom%2f2013%2f06%2f30%2fworld%2famericas%2fecuador%2dleader%2dsays%2dbiden%2dcalled%2dhim%2dabout%2dsnowden%2ehtml%3f%5fr%3d0"">
		<!-- End UPT call -->
	
		
        <script language=""JavaScript""><!--
          var dcsvid=""0"";
          var regstatus=""non-registered"";
        //--></script>
        <script src=""http://graphics8.nytimes.com/js/app/analytics/trackingTags_v1.1.js"" type=""text/javascript""></script>
        <noscript>
          <div><img alt=""DCSIMG"" id=""DCSIMG"" width=""1"" height=""1"" src=""http://wt.o.nytimes.com/dcsym57yw10000s1s8g0boozt_9t1x/njs.gif?dcsuri=/nojavascript&amp;WT.js=No&amp;WT.tv=1.0.7""/></div>
        </noscript>
   


</html>

<script>
NYTD.jQuery(window).on('load', function () {

    function getMetaValue(name) {
        var els = document.getElementsByName(name);
        if (els && els[0]) { return els[0].content; }
        return """";
    }

    var kurl = document.location.pathname;
    var kgeoref = getMetaValue(""geo"");
    var ksection = getMetaValue(""CG"");
    var ksubsection = getMetaValue(""SCG"");
    var kauthor = getMetaValue(""author"");
    var kfacebstring = ""AUTHOR="" + kauthor + ""&GEO_REF="" + kgeoref + ""&SECTION="" + ksection + ""&SUBSECTION="" + ksubsection + ""&URL=www.nytimes.com"" + kurl;

    NYTD.jQuery("".shareToolsItemFacebook"").on('click', function () {
        var scriptTag = document.createElement(""script"");
        scriptTag.src = 'http://beacon.krxd.net/event.gif?event_id=HudKM7Cc&event_type=clk&pub_id=79816aa8-435a-471a-be83-4b3e0946daf2&' + kfacebstring; 
        var firstScript = document.getElementsByTagName(""script"")[0];
        firstScript.parentNode.insertBefore(scriptTag, firstScript);
    });    
});
</script>




";
            }
        }
    }
}
