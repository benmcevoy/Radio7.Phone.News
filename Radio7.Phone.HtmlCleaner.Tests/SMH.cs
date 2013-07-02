using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Radio7.Phone.HtmlCleaner.Tests
{
    class SMH
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
<!--[if lte IE 7]> <html xmlns:fb=""http://www.facebook.com/2008/fbml"" xmlns:og=""http://opengraphprotocol.org/schema/"" class=""ie7 lte8 lte9 "" lang=""en-au""> <![endif]-->
<!--[if IE 8]> <html xmlns:fb=""http://www.facebook.com/2008/fbml"" xmlns:og=""http://opengraphprotocol.org/schema/"" class=""ie8 lte8 lte9 "" lang=""en-au""> <![endif]-->
<!--[if IE 9]> <html xmlns:fb=""http://www.facebook.com/2008/fbml"" xmlns:og=""http://opengraphprotocol.org/schema/"" class=""ie9 lte9 "" lang=""en-au""> <![endif]-->
<!--[if gt IE 9]> --> <html lang=""en-au"" class=""""> <!--<![endif]-->
<head>
        <script type=""text/javascript"">
        var mDomains = [""smh.com.au"", ""theage.com.au"", ""watoday.com.au"", ""brisbanetimes.com.au"", ""canberratimes.com.au"",
            ""essentialkids.com.au"", ""essentialbaby.com.au"", ""dailylife.com.au"", ""businessday.com.au"",""goodfood.com.au""]
        if (exists(mDomains, function(substring) {return contains(document.domain, substring)})
                && isSmartPhone(navigator.userAgent) && !contains(document.cookie, ""iphone_redirect=false"")) {
            var currentLocation = document.location.href;
            if (!contains(currentLocation, ""/lifestyle/cuisine"")) {
                if (contains(currentLocation, ""www."")) {
                    currentLocation = currentLocation.replace(""www."", ""m."");
                    window.location = currentLocation;
                }
                if (contains(currentLocation, ""media."")) {
                    currentLocation = currentLocation.replace(""media."", ""m.media."");
                    window.location = currentLocation;
                }
            }
        }

        /**
         * Returns a <code>Boolean</code> indicating whether or not the user agent represents a smart phone.
         *
         * @param userAgent User agent to test.
         * @return True if the user agent represents a smart phone; otherwise false.
         */
        function isSmartPhone(userAgent) {
            return ((matchesSmartPhoneUserAgentRegularExpressions(userAgent)) &&
                    (!matchesTabletUserAgentRegularExpressions(userAgent)));
        }

        /**
         * Returns a <code>Boolean</code> indicating whether or not the specified user agent represents a smart phone.
         * If any of the regular expressions are updated then they should be updated in
         * <code>SmartPhoneHelper.java</code>.
         *
         * @param userAgent User agent to test.
         * @return True if the user agent represents a smart phone; otherwise false.
         */
        function matchesSmartPhoneUserAgentRegularExpressions(userAgent) {
            var smartPhoneUserAgentRegularExpressions = [""^Mozilla/5.0.*iPhone.*"", ""^Mozilla/5.0.*iPod.*"",
                ""^Mozilla/5.0.*Android [1-3].*"", ""^Mozilla/5.0.*SymbianOS/9.*"", ""^Mozilla/5.0.*Symbian/3.*"",
                ""^Mozilla/5.0.*Mobile Safari/.*5[2-3][0-9].*"", "".*Dolfin/[1-2].[0-9].*"", ""^Mozilla/[4-5].0.*Windows Phone OS 7.[0-5].*"", ""^Opera/9.*Android; Opera Mini.*""];
            return userAgentMatchesAnyOf(userAgent, smartPhoneUserAgentRegularExpressions);
        }

        /**
         * Returns a <code>Boolean</code> indicating whether or not the specified user agent represents a tablet. If any
         * of the regular expressions are updated then they should be updated in <code>SmartPhoneHelper.java</code>.
         *
         * @param userAgent User agent to test.
         * @return True if the user agent represents a tablet; otherwise false.
         */
        function matchesTabletUserAgentRegularExpressions(userAgent) {
            var tableUserAgentRegularExpressions = [""^Mozilla/5.0.*iPad.*"", ""^Mozilla/5.0.*GT-P1000.*"",
                ""^Mozilla/5.0.*GT-P7500.*"", ""^Mozilla/5.0.*MZ601.*"", ""^Mozilla/5.0.*Transformer TF101.*""];
            return userAgentMatchesAnyOf(userAgent, tableUserAgentRegularExpressions);
        }

        /**
         * Determines whether any of the elements match the predicate
         *
         * @param elements a collection of elements to check
         * @param predicate function taking a single element and returning true when that element matches, false otherwise
         * @return {Boolean}
         */
        function exists(elements, predicate) {
            var index = 0;
            for (; index < elements.length; index++) {
                if (predicate(elements[index])) {
                    return true;
                }
            }

            return false;
        }

        /**
         * Determines whether {string} contains {substring}
         *
         * @param string
         * @param substring
         * @return {Boolean}
         */
        function contains(string, substring) {
            return string.indexOf(substring) != -1
        }

        /**
         * Determines whether the user agent matches any of the expressions defined by {patterns}
         *
         * @param userAgent the User Agent value of the browser
         * @param patterns the expression patterns to match against
         * @return {Boolean}
         */
        function userAgentMatchesAnyOf(userAgent, patterns) {
            if ((userAgent) && (userAgent.length > 0)) {
                return exists(patterns, function(pattern) {return userAgent.match(pattern)})
            }
            return false;
        }
    </script>

    <title>Egypt on edge as Mursi, critics face off</title>
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
<meta http-equiv=""content-language"" content=""en"" />
<meta http-equiv=""imagetoolbar"" content=""no"" />
    <link rel=""canonical"" href=""http://www.smh.com.au/world/egypt-on-edge-as-mursi-critics-face-off-20130630-2p58x.html""/>
<meta name=""robots"" content=""noarchive,noodp"" />
<meta name=""robots"" content=""ACAP allow-index"" />
<meta name=""robots"" content=""ACAP allow-follow"" />
<meta name=""robots"" content=""ACAP disallow-preserve"" />
<meta name=""robots"" content=""ACAP allow-present prohibited-modification=annotation"" />
<meta name=""description"" content="""" />
<meta name=""keywords"" content="""" />

<link rel=""shortcut icon"" type=""image/ico"" href=""http://www.smh.com.au/favicon.ico"" />
<meta name=""application-name"" content=""The Sydney Morning Herald"" />
<meta name=""msapplication-tooltip"" content=""Open The Sydney Morning Herald"" />
<meta name=""msapplication-starturl"" content=""http://www.smh.com.au"" />

    <meta name=""msapplication-task"" content=""name=National;action-uri=http://www.smh.com.au/national;icon-uri=http://www.smh.com.au/favicon.ico;"" />
    <meta name=""msapplication-task"" content=""name=World;action-uri=http://www.smh.com.au/world;icon-uri=http://www.smh.com.au/favicon.ico;"" />
    <meta name=""msapplication-task"" content=""name=Sport;action-uri=http://www.smh.com.au/sport;icon-uri=http://www.smh.com.au/favicon.ico;"" />
    <meta name=""msapplication-task"" content=""name=Weather;action-uri=http://www.smh.com.au/weather;icon-uri=http://www.smh.com.au/favicon.ico;"" />

<meta name=""cXenseParse:ffx-assetid"" content=""4532433""/>
<meta name=""cXenseParse:ffx-assettype"" content=""article""/>





        <meta name=""twitter:card"" content=""summary"">
    <meta name=""twitter:site"" content=""@smh"">

    <meta property=""og:title"" content=""Egypt on edge as Mursi, critics face off""/>
<meta property=""og:description"" content=""Egypt is braced for mass protests with President Mohammed Mursi's opponents determined to oust him.""/>
<meta property=""og:site_name"" content=""The Sydney Morning Herald""/>
<meta property=""og:type"" content=""article""/> 
<meta property=""og:url"" content=""http://www.smh.com.au/world/egypt-on-edge-as-mursi-critics-face-off-20130630-2p58x.html""/>
<meta property=""og:image"" content=""http://images.smh.com.au/2013/06/30/4532897/nw-th-egypt-20130630213119819533.jpg""/>
    <meta property=""fb:app_id"" content=""193677504039845""/>

                <link rel=""stylesheet"" type=""text/css"" media=""screen,print"" href=""http://resources.smh.com.au/common/media-common-1.0/css/output/7.24.6/common.skin.news_min.css"" />

                    <link rel=""stylesheet"" type=""text/css"" media=""screen,print"" href=""http://resources.smh.com.au/common/media-common-1.0/css/output/7.24.6/common.skin.article_min.css"" />

                    <link rel=""stylesheet"" type=""text/css"" media=""screen,print"" href=""http://resources.smh.com.au/common/media-common-1.0/css/output/7.24.6/common.skin.smh_min.css"" />

                <link rel=""stylesheet"" type=""text/css"" media=""screen,print"" href=""http://resources.smh.com.au/common/media-common-1.0/css/output/7.24.6/common.skin.world_min.css"" />

                <link rel=""stylesheet"" type=""text/css"" media=""screen,print"" href=""http://resources.smh.com.au/common/media-common-1.0/css/output/7.24.6/skin.promotions_min.css"" />

                <link rel=""stylesheet"" type=""text/css"" media=""screen,print"" href=""http://resources.smh.com.au/common/media-common-1.0/css/output/7.24.6/common.skin.mysite_min.css"" />


<!-- Initialise Google Analytics event queue -->
<script type=""text/javascript"">
    var _gaq = _gaq || [];
</script>
    
    <link rel=""shortcut icon"" href=""http://www.smh.com.au/favicon.ico""/>
</head>
<body class=""smh world"" >
<script type=""text/javascript"">
// <![CDATA[
	document.body.className += "" scriptable"";
// ]]>
</script>

<a class=""skipLink"" href=""#nav"">Skip to navigation</a>
<a class=""skipLink"" href=""#content"">Skip to content</a>
<a class=""skipLink"" href=""http://www.smh.com.au/siteguide/accessibility"">Help using this website - Accessibility statement</a>

        <esi:include src=""/ugc/v2/dock.html""/>
        <esi:remove><div class=""mySite"" role=""document"" aria-live=""polite"" aria-relevant=""additions removals"" aria-atomic=""true"">
    <div class=""ms-toolbarWrap"">
        <div class=""ms-toolbar clearfix"">
            <p class=""hiddenWithJS alert""><em>JavaScript disabled.</em> Please enable JavaScript to use My News, My Clippings, My Comments and user settings.</p>
<ul class=""inactive"">
    <li class=""account login"">
        <a href=""https://smh.myfairfax.com.au/members/session/new?channel_key=Dks89-tJMqw6zsOGPU5c5Q&callback_uri=http%3A%2F%2Fwww.smh.com.au%2Fugc%2Flogin.html"" title=""My News""><span class=""icon news""></span>My News </a>
    </li>
    <li class=""account login"">
        <a href=""https://smh.myfairfax.com.au/members/session/new?channel_key=Dks89-tJMqw6zsOGPU5c5Q&callback_uri=http%3A%2F%2Fwww.smh.com.au%2Fugc%2Flogin.html"" title=""My Clippings""><span class=""icon clippings""></span>My Clippings </a>
    </li>
    <li class=""account login"">
        <a href=""https://smh.myfairfax.com.au/members/session/new?channel_key=Dks89-tJMqw6zsOGPU5c5Q&callback_uri=http%3A%2F%2Fwww.smh.com.au%2Fugc%2Flogin.html"" title=""My Comments""><span class=""icon comments""></span>My Comments </a>
    </li>
    <li class=""account login"">
        <a href=""https://smh.myfairfax.com.au/members/session/new?channel_key=Dks89-tJMqw6zsOGPU5c5Q&callback_uri=http%3A%2F%2Fwww.smh.com.au%2Fugc%2Flogin.html"" title=""My History""><span class=""icon history""></span>My History </a>
    </li>
        <li class=""account login"">
            <a href=""https://smh.myfairfax.com.au/members/session/new?channel_key=Dks89-tJMqw6zsOGPU5c5Q&callback_uri=http%3A%2F%2Fwww.smh.com.au%2Fugc%2Flogin.html"" title=""My Benefits""><span class=""icon benefits""></span>My Benefits </a>
        </li>
</ul>

<ul class=""alt"">
    <li class=""account"">
        <a class=""btn alt gaTrackable"" href=""https://smh.myfairfax.com.au/members/members/signup?channel_key=Dks89-tJMqw6zsOGPU5c5Q&callback_uri=http%3A%2F%2Fwww.smh.com.au%2Fugc%2Flogin.html"" data-gaaction=""Sign-up"" data-gacategory=""MyMasthead"" data-galabel=""Dock Bar"">Sign-up</a>
    </li>
    <li class=""account login"">
        <a class=""btn gaTrackable"" href=""https://smh.myfairfax.com.au/members/session/new?channel_key=Dks89-tJMqw6zsOGPU5c5Q&callback_uri=http%3A%2F%2Fwww.smh.com.au%2Fugc%2Flogin.html"" data-gaaction=""Login"" data-gacategory=""MyMasthead"" data-galabel=""Dock Bar"">Log in</a>
    </li>
        <li class=""account last demo"">
            <a class=""btn"" href=""http://www.smh.com.au/static/mymastheads/"" target=""_blank"" id=""demo-btn"">Learn More</a>
            <div class=""demo-tooltip"">
                <p>Personalise your news, save articles to read later and customise settings</p>
            </div>
        </li>
</ul>
<div id=""ms-dialogLogin"" class=""dialogWrap hiddenVisually"">
    <div class=""dialogContent main"" id=""loginIframeContainer"" style=""width: 625px; height: 425px"" data-dialogHref=""https://smh.myfairfax.com.au/members/session/dialog?channel_key=Dks89-tJMqw6zsOGPU5c5Q&callback_uri=http%3A%2F%2Fwww.smh.com.au%2Fugc%2Flogin.html"">
        <p class=""hiddenVisually"">If you have trouble accessing our login form below, you can go to our <a href=""https://smh.myfairfax.com.au/members/session/new?channel_key=Dks89-tJMqw6zsOGPU5c5Q&callback_uri=http%3A%2F%2Fwww.smh.com.au%2Fugc%2Flogin.html"" title=""This link will open in a new window"" target=""_parent"">login page</a>.</p>
    </div>
</div>    <div id=""ms-dialogLoginPrompt"" class=""dialogWrap hiddenVisually"">
        <div class=""dialogContent main"">
            <p class=""hiddenVisually"">If you have trouble accessing our login form below, you can go to our <a href=""https://smh.myfairfax.com.au/members/session/new?channel_key=Dks89-tJMqw6zsOGPU5c5Q&callback_uri=http%3A%2F%2Fwww.smh.com.au%2Fugc%2Flogin.html"" title=""This link will open in a new window"" target=""_parent"">login page</a>.</p>
            <iframe id=""loginPromptIframe"" width=""625"" height=""425"" frameborder=""0"" scrolling=""no"" src="""" data-dialogHref=""https://smh.myfairfax.com.au/members/session/dialog?skin=prompt&channel_key=Dks89-tJMqw6zsOGPU5c5Q&callback_uri=http%3A%2F%2Fwww.smh.com.au%2Fugc%2Flogin.html""></iframe>
        </div>
    </div>
        </div>
    </div>
</div></esi:remove>
    <div data-brandTimezone=""Australia/Sydney""></div>



<div id=""sponsorLink_cA-helmet"" class=""cA-helmet"">
    <div id=""video-player-companion-ad-helmet""></div><!-- id:video-player-companion-ad-helmet -->
</div><!-- id:sponsorLink_cA-helmet -->
<script type=""text/javascript"" src=""http://resources.smh.com.au/common/media-common-1.0/js/html5shiv.js""></script>
<div class=""outerWrap"">
    <div class=""wrap cfix"">
        

<!-- Header (class according to new HTML5 element 'header'; was 'masthead') (scope: network-wide) -->
<div class=""header span-24"">
            <div id=""adspot-728x90,468x60-pos-1"" class=""ad""> <script type=""text/javascript""> function getAdCookie(name) { var regex = new RegExp('(?:^|; )' + name + '=([^;]*)'); var value = regex.exec(document.cookie); if (value && value.length > 1) { value = decodeURIComponent(value[1]); } else { value = """"; } return value; } function getFrameDocument(fr) { var doc = fr.contentWindow || fr.contentDocument; if (doc && doc.document) { doc = doc.document; } return doc; } function closeDoc(doc) { doc.close(); } function closeOpenDocuments(openDocs) { for (var i=0;i< openDocs.length; i++) { closeDoc(getFrameDocument(document.getElementById(openDocs[i]))); } } function isIE() { return /msie/i.test(navigator.userAgent) && !/opera/i.test(navigator.userAgent); } function setHash (element, hash) { if(element.hash) { element.hash = element.hash + "","" + hash; } else { element.hash = hash; } } function renderIFAd(holderID, adID, srcUrl, width, height, hash, bodyAttributes) { setHash(document.getElementById(holderID), hash); document.dcdAdsR.push(adID); if (ie) { var sizePart = srcUrl.substring(srcUrl.indexOf(""sz="")+3); sizePart = sizePart.substring(0, sizePart.indexOf("";"")); var multiSizes = sizePart.split("",""); var minSize = multiSizes[0]; if (multiSizes.length > 1) { for(var i=1; i< multiSizes.length; i++) { if (minSize > multiSizes[i]) { minSize = multiSizes[i]; } } var sizeParts = minSize.toLowerCase().split(""x""); width = sizeParts[0]; height = sizeParts[1]; srcUrl = srcUrl.replace(sizePart, minSize); } } document.write('<iframe id=""' + adID + '"" src=""' + srcUrl + '"" width=""' + width + '"" height=""' + height + '"" scrolling=""no"" marginheight=""0"" marginwidth=""0"" allowtransparency=""true"" frameborder=""0""><\/iframe>'); } function renderJIFAd(holderID, adID, srcUrl, width, height, hash, bodyAttributes) { setHash(document.getElementById(holderID), hash); document.dcdAdsR.push(adID); document.write('<iframe id=""' + adID + '"" src=""javascript: ;"" width=""' + width + '"" height=""' + height + '"" scrolling=""no"" marginheight=""0"" marginwidth=""0"" allowtransparency=""true"" frameborder=""0""><\/iframe>'); var body = '<html><head></head><body ' + bodyAttributes + '><scr' + 'ipt src=""' + srcUrl + '""></sc' + 'ript></body></html>'; var fr = document.getElementById(adID); setHash(fr, hash); fr.body = body; var doc = getFrameDocument(fr); doc.open(); doc.write(body); setTimeout(function() {closeDoc(getFrameDocument(document.getElementById(adID)))}, 2000); } function renderJIFAdWithInterim(holderID, adID, srcUrl, width, height, hash, bodyAttributes) { setHash(document.getElementById(holderID), hash); document.dcdAdsR.push(adID); document.write('<iframe id=""' + adID + '"" src="" '+ srcUrl +'"" width=""' + width + '"" height=""' + height + '"" scrolling=""no"" marginheight=""0"" marginwidth=""0"" allowtransparency=""true"" frameborder=""0""><\/iframe>'); } function renderIJAd(holderID, adID, srcUrl, hash) { document.dcdAdsAA.push(holderID); setHash(document.getElementById(holderID), hash); document.write('<scr' + 'ipt src=""' + srcUrl + '"" id=""' + adID + '""></sc' + 'ript>'); } function renderJAd(holderID, adID, srcUrl, hash) { document.dcdAdsAA.push(holderID); setHash(document.getElementById(holderID), hash); document.dcdAdsH.push(holderID); document.dcdAdsI.push(adID); document.dcdAdsU.push(srcUrl); } function er_showAd() { var regex = new RegExp(""externalReferrer=(.*?)(; |&|$)"", ""gi""); var value = regex.exec(document.cookie); if (value && value.length == 3) { var externalReferrer = value[1]; return (!FD.isInternalReferrer() || ((externalReferrer) && (externalReferrer > 0))); } return false; } function isHome() { var loc = """" + window.location; loc = loc.replace(""//"", """"); var tokens = loc.split(""/""); if (tokens.length == 1) { return true; } else if (tokens.length == 2) { if (tokens[1].trim().length == 0) { return true; } } return false; } function checkAds(checkStrings) { var cs = checkStrings.split("",""); for (var i=0;i< document.dcdAdsAA.length; i++) { var cAd = document.getElementById(document.dcdAdsAA[i]); document.dcdAdsAG.push(cAd.hash); for (var j=0; j<cs.length; j++) { var c = cs[j].trim(); if (c.length > 0 && cAd.innerHTML.indexOf(c)>0) { document.dcdAdsAI.push(cAd.hash); cAd.style.display ='none'; } } } if (!ie) { for (var i=0;i< document.dcdAdsR.length; i++) { var fr = document.getElementById(document.dcdAdsR[i]); if (fr) { document.dcdAdsAG.push(fr.hash); var doc = getFrameDocument(fr); for (var j=0; j<cs.length; j++) { var c = cs[j].trim(); if (c.length > 0 && doc.body.innerHTML.indexOf(c)>0) { document.dcdAdsAI.push(fr.hash); fr.style.display ='none'; } } } } } if (document.dcdAdsAI.length > 0 || document.dcdAdsAG.length > 0) { var pingServerParams = ""i=""; var sep = """"; for (var i=0;i< document.dcdAdsAI.length; i++) { pingServerParams += sep + document.dcdAdsAI[i]; sep = "",""; } } document.pingServerAdParams = pingServerParams; } function pingAdStatus() { if (isHome ()) { return; } if (document.pingServerAdParams && document.pingServerAdParams.length > 0) { var pingServerUrl = ""/action/pingServerAction?"" + document.pingServerAdParams; var xmlHttp = null; try { xmlHttp = new XMLHttpRequest(); } catch(e) { try { xmlHttp = new ActiveXObject(""Microsoft.XMLHttp""); } catch(e) { xmlHttp = null; } } if (xmlHttp != null) { xmlHttp.open( ""GET"", pingServerUrl, true); xmlHttp.send( null ); } } } function initAds(log) { for (var i=0;i< document.dcdAdsU.length; i++) { var shadowHolder = document.getElementById(""adShD"" + i); var targetHolder = document.getElementById(document.dcdAdsH[i]); if (shadowHolder && targetHolder) { var adNodes = new Array(); for (var j=0; j<shadowHolder.childNodes.length; j++) { var child = shadowHolder.childNodes[j]; if (child.nodeName.toLowerCase() != ""script"") { adNodes.push(child); } } for (var j=0; j<adNodes.length; j++) { targetHolder.appendChild(shadowHolder.removeChild(adNodes[j])); } } } if (er_showAd()) { for (var i=0;i< document.dcdAdsE.length; i++) { var erAd = document.getElementById(document.dcdAdsEH[i]); erAd.className = document.dcdAdsEC[i]; erAd.appendChild(document.dcdAdsE[i]); } } if (log) { console.log(document.igCount + ""/"" + document.tCount); } } function isInterimEnable(frame){ var iFrame_src = frame.src; var interim = iFrame_src.indexOf(""adinterim""); if(interim < 0 ){ return false; }else{ return true; } } function getCurrentOrd(srcurl){ var currentOrg = """"; currentOrg = srcurl.split(""ord="")[1]; if(currentOrg.indexOf(""?"") < 0){ return currentOrg }else{ return currentOrg.split(""?"")[0]; } } document.refreshAds = function rAds(adID) { if (document.dcdAdsR) { document.dcdsAdsToClose = new Array(); for (var i=0;i< document.dcdAdsR.length; i++) { var fr = document.getElementById(document.dcdAdsR[i]); if (fr) { if (!ie && !isInterimEnable(fr)) { if (!adID || adID ==""*"" || fr.parentNode.id==adID ) { var chNodes = new Array(); for (var j=0; j<fr.parentNode.childNodes.length; j++) { var child = fr.parentNode.childNodes[j]; if (!(child.nodeName.toLowerCase() == ""script"" || child.nodeName.toLowerCase() == ""iframe"") || child.nodeName.toLowerCase() == ""small"") { chNodes.push(child); } } for (var j=0; j<chNodes.length; j++) { if (!child.nodeName.toLowerCase() == ""small"") { chNodes[j].parentNode.removeChild(chNodes[j]); } } var doc = getFrameDocument(fr); while (doc.childNodes.length > 0) { doc.removeChild(doc.childNodes[0]); } doc.open(); var newBody = fr.body; if (getCurrentOrd(newBody) != """" ) { newBody = newBody.replace("";ord=""+getCurrentOrd(newBody), "";ord="" + Math.floor(100000000*Math.random())); } else { newBody = newBody.replace("";ord="", "";ord="" + Math.floor(100000000*Math.random())); } doc.write(newBody); document.dcdsAdsToClose.push(fr.id); } } else { var newSrc = fr.src; if (getCurrentOrd(newSrc) != """" ) { newSrc = newSrc.replace("";ord=""+getCurrentOrd(newSrc), "";ord="" + Math.floor(100000000*Math.random())); } else { newSrc = newSrc.replace("";ord="", "";ord="" + Math.floor(100000000*Math.random())); } fr.src = newSrc; } } } if (document.dcdsAdsToClose.length > 0) { setTimeout(function() {closeOpenDocuments(document.dcdsAdsToClose)}, 500); } } }; var ie = isIE(); if(ie && typeof String.prototype.trim !== 'function') { String.prototype.trim = function() { return this.replace(/^\s+|\s+$/g, ''); }; } document.dcdAdsH = new Array(); document.dcdAdsI = new Array(); document.dcdAdsU = new Array(); document.dcdAdsR = new Array(); document.dcdAdsEH = new Array(); document.dcdAdsE = new Array(); document.dcdAdsEC = new Array(); document.dcdAdsAA = new Array(); document.dcdAdsAI = new Array(); document.dcdAdsAG = new Array(); document.dcdAdsToClose = new Array(); document.igCount = 0; document.tCount = 0; var dcOrd = Math.floor(100000000*Math.random()); document.dcAdsCParams = """"; var savValue = getAdCookie(""sav""); if (savValue != null && savValue.length > 2) { document.dcAdsCParams = savValue + "";""; } </script> <script> renderJAd(""adspot-728x90,468x60-pos-1"", ""dcAd-1"", 'http://ad-apac.doubleclick.net/adj/onl.smh.news/world;cat=world;ctype=article;pos=1;dcopt=ist;' + document.dcAdsCParams +'sz=728x90,468x60;tile=1;ord=' + dcOrd + '?', -1615662418); </script> <noscript> <a href='http://ad-apac.doubleclick.net/jump/onl.smh.news/world;cat=world;ctype=article;pos=1;dcopt=ist;sz=728x90,468x60;tile=1;ord=2.7293425E7?' target=""_blank""> <img src='http://ad-apac.doubleclick.net/ad/onl.smh.news/world;cat=world;ctype=article;pos=1;dcopt=ist;sz=728x90,468x60;tile=1;ord=2.7293425E7?' border=""0"" alt=""""> </a> </noscript> </div>


    <p class=""mh-logo""><a href=""http://www.smh.com.au"" title=""The Sydney Morning Herald"">The Sydney Morning Herald</a></p>
            <h2><a href=""http://www.smh.com.au/world"" title=""World"">World</a></h2>
        <ul id=""nav"" role=""navigation"" >
        
                <li>
                    <a href=""http://www.smh.com.au/environment"" title=""Environment"">Environment</a>
                </li>
                <li>
                    <a href=""http://www.smh.com.au/world/strange"" title=""Strange but True"">Strange but True</a>
                </li>
                <li>
                    <a href=""http://www.smh.com.au/blogs"" title=""Blog Central"">Blog Central</a>
                </li>
    </ul>

        <p class=""breadcrumb"">
        <span>You are here:</span>
            <a href=""http://www.smh.com.au"" >Home</a>
            <a href=""http://www.smh.com.au/world"" >World</a>
            <a href=""http://www.smh.com.au/world/egypt-on-edge-as-mursi-critics-face-off-20130630-2p58x.html"" class=""last"">Article</a>
    </p>

        <div class=""cN-searchBox cfix"">
        <form action=""http://www.smh.com.au/execute_search.html"" method=""get"">
            <h2>Search smh:</h2>
            <label for=""search"">
                <input type=""text"" name=""text"" id=""search"" placeholder='Search here...' onfocus=""this.value='';"" />
            </label>
            <h3>Search in:</h3>
            <ul id=""ddown"" class=""ddown"">
                <li><a class=""selected"" href=""#"">smh.com.au</a>
                    <div class=""srch-wrap"">
                        <div></div>
                        <ul class=""cfix"">
                                <li class=""first""><a href=""#"">smh.com.au</a></li>
                                <li><a href=""#"">Web</a></li>
                        </ul>
                    </div><!-- class:srch-wrap -->
                </li>
            </ul>
            <input type=""hidden"" name=""ss"" value=""smh.com.au"" />
            <input type=""submit"" class=""btnSubmit"" value=""Search"" />
        </form>
    </div><!-- class:cN-searchBox cfix -->

</div>
<!-- End component: Header -->

        
        
        <div id=""adspot-940x20-pos-1"" style='display:none;' class=""ad ad adPageTop""> </div>
        <div id=""content"" class=""span-16 article"">
            <h1 class=""cN-headingPage"">Egypt on edge as Mursi, critics face off</h1>
<div class=""meta hnews"">
    <dl>
        <dt class=""hiddenVisually"">Date</dt>
        <dd class=""updated dtstamp"">
                <time datetime=""July 1, 2013"">July 1, 2013</time>
        </dd>
    </dl>
    <ul class=""tools"">
        <li class=""reading""><strong>12</strong> reading now</li>
    <li class=""reading collectorHidden"" style=""display:none"">(11)</li>
        <li class=""clipping"" data-assetId=""d-2p58x"" data-assetType=""ARTICLE"" data-assetUrl=""http://www.smh.com.au/world/egypt-on-edge-as-mursi-critics-face-off-20130630-2p58x.html""><button class=""btnClipping btnFauxLink"" type=""button"">Read later</button></li>
</ul>
    
            <div class=""author optionA"">
            <div class=""cT-headshot"">
                <h3 class=""authorName"">Jailan Zayan</h3>
            </div>
        </div>

    
<div class=""zoom hiddenVisually"">
    <!-- remove isPublishedAfter from the conditions if one day the keywords of all articles in DCDS are synched with FP -->
    <!-- self here refers to TimelineEntityLinksComponent.java -->
        <p>See more stories on:</p>
        <ul class=""cfix"">
            <li><a href=""http://www.smh.com.au/zoom/Egypt""> Egypt </a></li>
            <li><a href=""http://www.smh.com.au/zoom/Cairo""> Cairo </a></li>
            <li><a href=""http://www.smh.com.au/zoom/Islamist""> Islamist </a></li>
            <li><a href=""http://www.smh.com.au/zoom/Muslim_Brotherhood""> Muslim Brotherhood </a></li>
        </ul>
</div>


    <!--We need to call this as a dynamic component, to many variants meant i had to start hacking it for different sections -->
<ul class=""social sponsored cfix"">

        <li class=""tweet"">
            <a href=""http://twitter.com/share"" class=""twitter-share-button"" data-count=""horizontal"" data-url=""http://www.smh.com.au/world/egypt-on-edge-as-mursi-critics-face-off-20130630-2p58x.html"" data-via=""smh"" data-text=""Egypt on edge as Mursi, critics face off"">Tweet</a>
        </li>
        <li class=""fblike""><fb:like href=""http://www.smh.com.au/world/egypt-on-edge-as-mursi-critics-face-off-20130630-2p58x.html"" send=""false"" layout=""button_count"" width=""100"" show_faces=""false"" action=""recommend"" font=""arial""></fb:like></li>
        <li class=""gplus""><div class=""g-plus"" data-action=""share"" data-annotation=""bubble""></div></li>
        <li class=""linkedin""><script type=""IN/Share"" data-url=""http://www.smh.com.au/world/egypt-on-edge-as-mursi-critics-face-off-20130630-2p58x.html""></script></li>
        <li class=""pinterest""><a href=""http://pinterest.com/pin/create/button/?url=http://www.smh.com.au/world/egypt-on-edge-as-mursi-critics-face-off-20130630-2p58x.html&media=http://images.smh.com.au/2013/06/30/4532908/nw-wd-egypt-20130630212913675519.jpg&description=Bracing for trouble: Opponents of Egypt's Islamist President Mohammed Mursi gather for in Tahrir Square on Sunday."" class=""pin-it-button pinterest"" count-layout=""horizontal"">Pin It</a></li>
        <li class=""reddit""><a href=""http://www.reddit.com/submit?url=http://www.smh.com.au/world/egypt-on-edge-as-mursi-critics-face-off-20130630-2p58x.html&title=Egypt on edge as Mursi, critics face off"">submit to reddit</a></li>
    <li class=""email""><a href=""/action/emailToFriend?id=4532433"" title=""Email to a friend"" rel=""nofollow"" data-emailSocialLink=""true"" data-emailUrl=""/action/emailToFriend?id=4532433"">Email article</a></li>
    <li class=""print"">
            <a href=""/action/printArticle?id=4532433"" title=""Print this story"" rel=""nofollow"" data-printSocialLink=""true"" data-printUrl=""/action/printArticle?id=4532433"">Print</a>
    </li>
        <li class=""socSponsor""><div id=""adspot-120x50"" class=""ad""> </div></li>
</ul>
</div><!-- class:meta hnews -->
<!--honey pot ad inserted via trickyness-->
<div class=""ad adSpot-textBox"" id=""googleAds"">
</div>
<div class=""articleBody"">
                            <div id=""video-player-content"" class=""cT-imageMultimedia"">
    <div id=""video-player-content-player"" class=""videoWrap"">
        
                <a href=""http://media.smh.com.au/national/selections/egypt-braces-for-mass-protests-4531877.html"" class=""play-video"" title=""Egypt braces for mass protests"">
        <img src=""http://images.smh.com.au/2013/06/30/4531880/vd-Egypt-408x264.jpg"" width=""620"" height=""349"" alt=""Egypt braces for mass protests (Video Thumbnail)""/>
            <span class=""size-lrg"">
                    Click to play video
            </span>
        </a>

    </div><!-- id:video-player-content-player -->
    <div class=""overlay overlayAd""></div><!-- class:overlay overlayAd -->
    <div class=""overlay overlayAutoPlay"">
    <a class=""previous close"" href=""javascript:;"">Return to video</a>
    <h3>Video settings</h3>
    <p>Please <a href=""javascript:;"" class=""overlayLogIn"" title=""Log in"">Log in</a> to update your video settings</p>
</div><!-- class:overlay overlayAutoPlay -->

    <div class=""overlay overlayPlayCountdown overlayPrePlay"">
    <p>Video will begin in <span class=""playCountdownCounter"">5</span> seconds.</p>
    <ul>
        <li><a class=""playCountdownStop"" href=""javascript:;"">Don't play</a></li>
        <li class=""last""><a class=""playCountdownPlayNow"" href=""javascript:;"">Play now</a></li>
    </ul>
</div><!-- class:overlay overlayPlayCountdown -->

    <div class=""overlay overlayPostPlay sticky"">
    <a class=""previous"" href=""http://media.smh.com.au/"">More video</a>
    <h3>Recommended</h3>
    <div class=""cS-videoGalleryLinks"">
        <ul class=""cfix"">
                    <li>
                                <a class=""play-video "" href=""http://media.smh.com.au/national/selections/egypt-braces-for-mass-protests-4531877.html"" title=""Egypt braces for mass protests""><img src=""http://images.smh.com.au/2013/06/30/4531880/vd-Egypt-96x54.jpg"" width=""96"" height=""54"" alt=""Egypt braces for mass protests (Video Thumbnail)"" /><span class=""size-sml"">Click to play video</span></a>

                        <p><a href=""http://media.smh.com.au/national/selections/egypt-braces-for-mass-protests-4531877.html"">Egypt braces for mass protests</a></p>
                    </li>
                    <li>
                                <a class=""play-video "" href=""http://media.smh.com.au/news/world-news/assad-launches-offensive-on-homs-4531958.html"" title=""Assad launches offensive on Homs""><img src=""http://images.smh.com.au/2013/06/30/4531960/vd-Homs-96x54.jpg"" width=""96"" height=""54"" alt=""Assad launches offensive on Homs (Video Thumbnail)"" /><span class=""size-sml"">Click to play video</span></a>

                        <p><a href=""http://media.smh.com.au/news/world-news/assad-launches-offensive-on-homs-4531958.html"">Assad launches offensive on Homs</a></p>
                    </li>
                    <li>
                                <a class=""play-video "" href=""http://media.smh.com.au/national/selections/obama-meets-with-mandela-family-4531724.html"" title=""Obama meets with Mandela family""><img src=""http://images.smh.com.au/2013/06/30/4531747/vd-obamandela-96x54.jpg"" width=""96"" height=""54"" alt=""Obama visits Mandela family (Video Thumbnail)"" /><span class=""size-sml"">Click to play video</span></a>

                        <p><a href=""http://media.smh.com.au/national/selections/obama-meets-with-mandela-family-4531724.html"">Obama meets with Mandela family</a></p>
                    </li>
                    <li>
                                <a class=""play-video "" href=""http://media.smh.com.au/national/selections/grave-dispute-for-mandela-family-4530181.html"" title=""Grave dispute for Mandela family""><img src=""http://images.smh.com.au/2013/06/29/4530095/vd-Makaziwe-96x54.jpg"" width=""96"" height=""54"" alt=""Grave dispute for Mandela family (Video Thumbnail)"" /><span class=""size-sml"">Click to play video</span></a>

                        <p><a href=""http://media.smh.com.au/national/selections/grave-dispute-for-mandela-family-4530181.html"">Grave dispute for Mandela family</a></p>
                    </li>
                    <li>
                                <a class=""play-video "" href=""http://media.smh.com.au/news/world-news/egypts-rival-groups-clash-as-cleric-warns-of-civil-war-4531105.html"" title=""Egypt's rival groups clash, as cleric warns of 'civil war'""><img src=""http://images.smh.com.au/2013/06/29/4531095/art-747829370-96x54.jpg"" width=""96"" height=""54"" alt=""Egyptian protesters shout anti-Muslim Brotherhood slogans as they hold posters depicting U.S. Ambassador to Egypt Anne Patterson and President Mohammed Morsi during a protest in Tahrir Square, the focal point of Egyptian uprising, in Cairo, Egypt, Friday, June 28, 2013. Arabic on the poster at center reads, ""shave your beard show your shame, you will look like Mubarak."" Egypt's opposition plans to bring out massive crowds on Sunday in protests nationwide, vowing to force President Mohammed Morsi to step down. Across the city from a pro-Morsi rally Friday, thousands massed in Cairo?s central Tahrir Square, shouting for the president to ?leave, leave,?(AP Photo/Amr Nabil)"" /><span class=""size-sml"">Click to play video</span></a>

                        <p><a href=""http://media.smh.com.au/news/world-news/egypts-rival-groups-clash-as-cleric-warns-of-civil-war-4531105.html"">Egypt's rival groups clash, as cleric warns of 'civil war'</a></p>
                    </li>
        </ul>
    </div><!-- class:cS-videoGalleryLinks -->
    <a class=""replay"" href=""javascript:;"">Replay video</a>
</div><!-- class:overlay overlayPostPlay sticky -->

        <div class=""overlay overlaySettings"">
        <a class=""previous close"" href=""javascript:;"">Return to video</a>
        <h3>Video settings</h3>
        <p>Please <a href=""javascript:;"" class=""overlayLogIn"" title=""Log in"">Log in</a> to update your video settings</p>
    </div><!-- class:overlay overlaySettings -->

    <div class=""fdVideoWof"">
        <h4>Egypt braces for mass protests</h4>
        <p>As political deadlock in Egypt deepens, supporters and opponents of President Mohamed Mursi plan to hold rallies in Cairo on Sunday.</p>
        <ul>
            <li class=""autoplay"">Autoplay <strong>On</strong><a href=""javascript:;"" data-autoPlayOverlay=""true"">Off</a></li>
            <li><a href=""javascript:;"" data-kampyleFeedback=""true"">Video feedback</a></li>
            <li class=""last""><a href=""javascript:;"" data-settingsOverlay=""true"">Video settings</a></li>
        </ul>
	</div><!-- class:fdVideoWof -->
</div><!-- id:video-player-content -->

            
        <p>Egypt is braced for mass protests  with President Mohammed  Mursi's opponents determined to oust him.</p>

        <p>His Islamist supporters vowed to defend his legitimacy to the end, on the anniversary of his turbulent first year in office.</p>

                    
        <p>The grassroots movement Tamarod - Arabic for rebellion - is behind the campaign that claims to have collected millions of signatures pushing for Mursi's departure and new elections.</p>

                                    <!-- cT-imageLandscape -->
        <div class=""cT-imageLandscape"">

            <img src=""http://images.smh.com.au/2013/06/30/4532908/nw-wd-egypt-20130630212913675519-620x349.jpg"" alt=""Bracing for trouble: Opponents of Egypt's Islamist President Mohammed Mursi gather for in Tahrir Square on Sunday."" />
                <p>Bracing for trouble: Opponents of Egypt's Islamist President Mohammed Mursi gather for in Tahrir Square on Sunday. <em>Photo: AP</em></p>
        </div>



        <p>Posters calling on people to join the protests against his rule have sprung up around Cairo, plastered on walls and stuck on car windows along with ''June 30'' graffiti daubed along streets.</p>

            <div id=""adspot-300x250-pos-3"" class=""hidden""> <small>Advertisement</small> <script type=""text/javascript""> var erA = document.createElement('iframe'); erA.setAttribute(""id"", ""dcAd-1-4""); erA.setAttribute(""src"", ""http://ad-apac.doubleclick.net/adi/onl.smh.news/world;cat=world;ctype=article;pos=3;"" + document.dcAdsCParams +""sz=300x250;tile=4;ord="" + dcOrd + ""?""); erA.setAttribute(""width"", ""300""); erA.setAttribute(""height"", ""250""); erA.setAttribute(""scrolling"", ""no""); erA.setAttribute(""marginheight"", ""0""); erA.setAttribute(""marginwidth"", ""0""); erA.setAttribute(""allowtransparency"", ""true""); erA.setAttribute(""frameborder"", ""0""); erA.frameBorder = 0; document.dcdAdsE.push(erA); document.dcdAdsEH.push(""adspot-300x250-pos-3""); document.dcdAdsEC.push(""ad adCentred""); document.dcdAdsR.push(""dcAd-1-4""); </script> <noscript> <iframe id=""dcAd-1-4"" src=""http://ad-apac.doubleclick.net/adi/onl.smh.news/world;cat=world;ctype=article;pos=3;sz=300x250;tile=4;ord=2.7293425E7?"" width='300' height='250' scrolling=""no"" marginheight=""0"" marginwidth=""0"" allowtransparency=""true"" frameborder=""0""> </iframe> </noscript> </div>
        <p>The week leading up to the showdown has already seen eight people killed, including an American, and scores more injured as protesters from both sides took to the streets.</p>

        <p>Mursi, a senior Muslim Brotherhood leader, is Egypt's first president elected in a free vote, catapulted to power by the 2011 Arab Spring uprising that ended three decades of dictatorial rule.</p>

        <p>His opponents, who have been massing outside the presidential palace and in Cairo's Tahrir Square, accuse Dr Mursi of betraying the revolution by concentrating power in Islamist hands.</p>

        <p>In the run-up to the anti-Mursi rallies, thousands of his supporters gathered in Cairo's Nasr City neighbourhood to listen to fiery speeches urging them to defend the President's legitimacy.</p>

        <p>Mursi's Freedom and Justice Party, political arm of the Muslim Brotherhood, called for a ''general mobilisation'' in support of the President who has said he wants to stay the course until the end of his term in June 2016.</p>

        <p>But leading opposition figure Nobel laureate Mohamed ElBaradei has urged the President ''to listen to the people'' and step aside. The army, which led a tumultuous transition after the revolt that ousted dictator Hosni Mubarak,  warned it would intervene if there was major unrest.</p>

        <p>Since taking office, Mursi has battled with the judiciary, the media and the police. The economy has taken a tumble, investment has dried up, inflation soared and the vital tourism industry has been battered.</p>

        <p>Egyptians were stocking up on food and withdrawing cash in anticipation of Sunday's rallies and, adding to the tension, fuel shortages have caused very long queues outside petrol stations, bringing some parts of the capital to a standstill.</p>

        <p>On Saturday at least eight deputies resigned from the Islamist-dominated Shura Council in support of the people, in a boost for Tamarod which says it now has 22 million signatures on a petition demanding a snap election and Mursi's departure. The figure cannot be verified.</p>

        <p>Mursi's camp says it is determined to defend his legitimacy.</p>

        <p><strong>AFP with Bloomberg</strong></p>
        
</div><!-- class:articleBody -->








            
            <div id=""moreGoogleAds"" class=""ad adSpot-textBox""></div><!-- id:moreGoogleAds -->
            <div id=""jobs"" data-jobsBrand=""smh"" data-jobsSkew=""generic2"" data-jobsWidth=""620"" data-jobsHeight=""210""></div><!-- id:jobs -->

                <div class=""customSuggestions cfix hidden"" data-siteid=""9222289450909506993"" data-brand=""smh.com.au"" data-section=""World"" data-clippable=""true""></div>

                <div class=""OUTBRAIN"" data-src=""http://www.smh.com.au/world/egypt-on-edge-as-mursi-critics-face-off-20130630-2p58x.html"" data-widget-id=""AR_1"" data-ob-template=""The_Sydney_Morning_Herald_Fairfax""></div>

            
            
            
            
            <div class=""meta"">
    <!--We need to call this as a dynamic component, to many variants meant i had to start hacking it for different sections -->
<ul class=""social  cfix"">

        <li class=""tweet"">
            <a href=""http://twitter.com/share"" class=""twitter-share-button"" data-count=""horizontal"" data-url=""http://www.smh.com.au/world/egypt-on-edge-as-mursi-critics-face-off-20130630-2p58x.html"" data-via=""smh"" data-text=""Egypt on edge as Mursi, critics face off"">Tweet</a>
        </li>
        <li class=""fblike""><fb:like href=""http://www.smh.com.au/world/egypt-on-edge-as-mursi-critics-face-off-20130630-2p58x.html"" send=""false"" layout=""button_count"" width=""100"" show_faces=""false"" action=""recommend"" font=""arial""></fb:like></li>
        <li class=""gplus""><div class=""g-plus"" data-action=""share"" data-annotation=""bubble""></div></li>
        <li class=""linkedin""><script type=""IN/Share"" data-url=""http://www.smh.com.au/world/egypt-on-edge-as-mursi-critics-face-off-20130630-2p58x.html""></script></li>
        <li class=""pinterest""><a href=""http://pinterest.com/pin/create/button/?url=http://www.smh.com.au/world/egypt-on-edge-as-mursi-critics-face-off-20130630-2p58x.html&media=http://images.smh.com.au/2013/06/30/4532908/nw-wd-egypt-20130630212913675519.jpg&description=Bracing for trouble: Opponents of Egypt's Islamist President Mohammed Mursi gather for in Tahrir Square on Sunday."" class=""pin-it-button pinterest"" count-layout=""horizontal"">Pin It</a></li>
        <li class=""reddit""><a href=""http://www.reddit.com/submit?url=http://www.smh.com.au/world/egypt-on-edge-as-mursi-critics-face-off-20130630-2p58x.html&title=Egypt on edge as Mursi, critics face off"">submit to reddit</a></li>
    <li class=""email""><a href=""/action/emailToFriend?id=4532433"" title=""Email to a friend"" rel=""nofollow"" data-emailSocialLink=""true"" data-emailUrl=""/action/emailToFriend?id=4532433"">Email article</a></li>
    <li class=""print"">
            <a href=""/action/printArticle?id=4532433"" title=""Print this story"" rel=""nofollow"" data-printSocialLink=""true"" data-printUrl=""/action/printArticle?id=4532433"">Print</a>
    </li>
</ul>
</div><!-- class:meta -->
    <div class=""cT-relatedCoverageContentPage"">
        <h3>Related Coverage</h3>
        <div id=""moreRelatedCoverage"" class=""cN-relatedCoverage cfix"">

                    <!-- cN-story -->
<div class=""cN-story cfix last"">
                    <a class=""play-video "" href=""http://media.smh.com.au/national/selections/egypt-braces-for-mass-protests-4531877.html"" title=""Egypt braces for mass protests""><img src=""http://images.smh.com.au/2013/06/30/4531881/th-Egypt-90x60.jpg"" width=""90"" height=""60"" alt=""Egypt braces for mass protests (Thumbnail)"" /><span class=""size-sml"">Click to play video</span></a>

    <div class=""wof"">
            <h4>Video</h4>
        <h3>
                <a href=""http://media.smh.com.au/national/selections/egypt-braces-for-mass-protests-4531877.html"" title=""Egypt braces for mass protests"">Egypt braces for mass protests</a>
        </h3>
                <p>As political deadlock in Egypt deepens, supporters and opponents of President Mohamed Mursi plan to hold rallies in Cairo on Sunday.</p>
            
    </div>
</div>

        </div><!-- id:moreRelatedCoverage -->
    </div><!-- class:cT-relatedCoverageContentPage -->

            
            
        </div><!-- id:content -->
        <div class=""aside span-8 last"" role=""complementary"">
            <div id=""adspot-300x1515-pos-1"" style='display:none;' class=""ad""> </div>
            
            

                    <div id=""adspot-300x600,300x250-pos-1"" class=""ad""> <small>Advertisement</small> <script> renderJAd(""adspot-300x600,300x250-pos-1"", ""dcAd-6"", 'http://ad-apac.doubleclick.net/adj/onl.smh.news/world;cat=world;ctype=article;pos=1;' + document.dcAdsCParams +'sz=300x600,300x250;tile=6;ord=' + dcOrd + '?', -699347194); </script> <noscript> <a href='http://ad-apac.doubleclick.net/jump/onl.smh.news/world;cat=world;ctype=article;pos=1;sz=300x600,300x250;tile=6;ord=2.7293425E7?' target=""_blank""> <img src='http://ad-apac.doubleclick.net/ad/onl.smh.news/world;cat=world;ctype=article;pos=1;sz=300x600,300x250;tile=6;ord=2.7293425E7?' border=""0"" alt=""""> </a> </noscript> </div>

                

            <script type=""text/javascript"" src=""http://secure-au.imrworldwide.com/cgi-bin/j?ci=rj0121-caltrate&amp;se=1&amp;te=0""></script>
            <script type=""text/javascript"" src=""http://secure-au.imrworldwide.com/cgi-bin/j?ci=rj0124-samsung&amp;se=1&amp;te=0""> </script>
<script type=""text/javascript"" src=""http://secure-au.imrworldwide.com/cgi-bin/j?ci=rj0126-sushi-train&amp;se=1&amp;te=0""> </script>

                <ul id=""cN-tabBox1"" class=""cN-tabBox accessibleTab cS-latestArticlesVideos"">
            <li class=""tab1  selected"">
                <h4><a href=""javascript:;"">Latest Video</a></h4><!--TODO change this from H4 as it conficts with video headline-->
                <div class=""cfix"">
        <div class=""cS-latestVideo"">
        <h3>World News Video <a href=""http://media.smh.com.au/video-world-news/world-news"">More video</a></h3>
        <div class=""media-video"" id=""video-player-latest"">
            <div id=""video-player-latest-player"" class=""videoWrap""></div><!-- id:video-player-latest-player -->
            <div class=""fdVideoWof accessibleWof"">
                <h4>Turkish police shooting sparks protests</h4>
                <p>Protests in Ankara and Istanbul erupt after the shooting of Kurdish demonstrators in the south-east. </p>
            </div><!-- class:fdVideoWof accessibleWof -->
            <ul class=""span-5"">
                    <li>
                                <a class=""play-video "" href=""http://media.smh.com.au/national/selections/egypt-braces-for-mass-protests-4531877.html"" title=""Egypt braces for mass protests""><img src=""http://images.smh.com.au/2013/06/30/4531880/vd-Egypt-92x52.jpg"" width=""92"" height=""52"" alt=""Egypt braces for mass protests (Video Thumbnail)"" /><span class=""size-sml"">Click to play video</span></a>

                        <p><a href=""http://media.smh.com.au/national/selections/egypt-braces-for-mass-protests-4531877.html"">Egypt braces for mass protests</a></p>
                    </li>
                    <li>
                                <a class=""play-video "" href=""http://media.smh.com.au/news/world-news/assad-launches-offensive-on-homs-4531958.html"" title=""Assad launches offensive on Homs""><img src=""http://images.smh.com.au/2013/06/30/4531960/vd-Homs-92x52.jpg"" width=""92"" height=""52"" alt=""Assad launches offensive on Homs (Video Thumbnail)"" /><span class=""size-sml"">Click to play video</span></a>

                        <p><a href=""http://media.smh.com.au/news/world-news/assad-launches-offensive-on-homs-4531958.html"">Assad launches offensive on Homs</a></p>
                    </li>
                    <li>
                                <a class=""play-video "" href=""http://media.smh.com.au/national/selections/obama-meets-with-mandela-family-4531724.html"" title=""Obama meets with Mandela family""><img src=""http://images.smh.com.au/2013/06/30/4531747/vd-obamandela-92x52.jpg"" width=""92"" height=""52"" alt=""Obama visits Mandela family (Video Thumbnail)"" /><span class=""size-sml"">Click to play video</span></a>

                        <p><a href=""http://media.smh.com.au/national/selections/obama-meets-with-mandela-family-4531724.html"">Obama meets with Mandela family</a></p>
                    </li>
            </ul>
        </div><!-- id:video-player-latest -->
    </div><!-- class:cS-latestVideo -->

</div><!-- class:cfix -->
            </li>
    </ul>



            
    <div id=""adspot-149x170"" class=""ad adSpot-twin cfix""> <small>Featured advertisers</small> <script type=""text/javascript""> if (ie) { renderIFAd(""adspot-149x170"", ""dcAd-1-7"", ""http://ad-apac.doubleclick.net/adi/onl.smh.news/world;cat=world;ctype=article;"" + document.dcAdsCParams + ""pos=1;sz=149x170;tile=7;ord="" + dcOrd + ""?"", 149, 170, 666642975); } else { renderJIFAd(""adspot-149x170"",""dcAd-1-7"", ""http://ad-apac.doubleclick.net/adj/onl.smh.news/world;cat=world;ctype=article;"" + document.dcAdsCParams + ""pos=1;sz=149x170;tile=7;ord="" + dcOrd + ""?"", 149, 170, 666642975, """"); } </script> <noscript> <iframe id=""dcAd-1-7"" src=""http://ad-apac.doubleclick.net/adi/onl.smh.news/world;cat=world;ctype=article;pos=1;sz=149x170;tile=7;ord=2.7293425E7?"" width='149' height='170' scrolling=""no"" marginheight=""0"" marginwidth=""0"" allowtransparency=""true"" frameborder=""0""> </iframe> </noscript> <script type=""text/javascript""> if (ie) { renderIFAd(""adspot-149x170"", ""dcAd-2-8"", ""http://ad-apac.doubleclick.net/adi/onl.smh.news/world;cat=world;ctype=article;"" + document.dcAdsCParams + ""pos=2;sz=149x170;tile=8;ord="" + dcOrd + ""?"", 149, 170, 257818781); } else { renderJIFAd(""adspot-149x170"",""dcAd-2-8"", ""http://ad-apac.doubleclick.net/adj/onl.smh.news/world;cat=world;ctype=article;"" + document.dcAdsCParams + ""pos=2;sz=149x170;tile=8;ord="" + dcOrd + ""?"", 149, 170, 257818781, """"); } </script> <noscript> <iframe id=""dcAd-2-8"" src=""http://ad-apac.doubleclick.net/adi/onl.smh.news/world;cat=world;ctype=article;pos=2;sz=149x170;tile=8;ord=2.7293425E7?"" width='149' height='170' scrolling=""no"" marginheight=""0"" marginwidth=""0"" allowtransparency=""true"" frameborder=""0""> </iframe> </noscript> </div>



            <div id=""adspot-295x60"" class=""ad ""> <small>Sponsored links</small> <script type=""text/javascript""> if (ie) { renderIFAd(""adspot-295x60"", ""dcAd-1-9"", ""http://ad-apac.doubleclick.net/adi/onl.smh.news/world;cat=world;ctype=article;"" + document.dcAdsCParams + ""pos=1;sz=295x60;tile=9;ord="" + dcOrd + ""?"", 295, 60, -1016275877); } else { renderJIFAd(""adspot-295x60"",""dcAd-1-9"", ""http://ad-apac.doubleclick.net/adj/onl.smh.news/world;cat=world;ctype=article;"" + document.dcAdsCParams + ""pos=1;sz=295x60;tile=9;ord="" + dcOrd + ""?"", 295, 60, -1016275877, """"); } </script> <noscript> <iframe id=""dcAd-1-9"" src=""http://ad-apac.doubleclick.net/adi/onl.smh.news/world;cat=world;ctype=article;pos=1;sz=295x60;tile=9;ord=2.7293425E7?"" width='295' height='60' scrolling=""no"" marginheight=""0"" marginwidth=""0"" allowtransparency=""true"" frameborder=""0""> </iframe> </noscript> </div>
<iframe src=""http://assets.betterbills.com/widgets/SMH-NSW.html"" width=""320"" height=""160"" class=""iframeBBills"" scrolling=""no"" frameborder=""0"">
    <!-- UI NOTE: Make iframed content accessible: -->
    <a href=""http://assets.betterbills.com/widgets/SMH-NSW.html"">View these special offers by BetterBills.</a>
</iframe>


            
    <div id=""adspot-1x4"" class=""ad""> <small>Advertisement</small> <script type=""text/javascript""> if (ie) { renderIFAd(""adspot-1x4"", ""dcAd-1-12"", ""http://ad-apac.doubleclick.net/adi/onl.smh.news/world;cat=world;ctype=article;"" + document.dcAdsCParams + ""sz=1x4;tile=12;ord="" + dcOrd + ""?"", 300, 150, 1540684749); } else { renderJIFAd(""adspot-1x4"",""dcAd-1-12"", ""http://ad-apac.doubleclick.net/adj/onl.smh.news/world;cat=world;ctype=article;"" + document.dcAdsCParams + ""sz=1x4;tile=12;ord="" + dcOrd + ""?"", 300, 150, 1540684749, """"); } </script> <noscript> <iframe id=""dcAd-1-12"" src=""http://ad-apac.doubleclick.net/adi/onl.smh.news/world;cat=world;ctype=article;sz=1x4;tile=12;ord=2.7293425E7?"" width='300' height='150' scrolling=""no"" marginheight=""0"" marginwidth=""0"" allowtransparency=""true"" frameborder=""0""> </iframe> </noscript> </div>

            
            
                <div class=""customSuggestions cfix hidden"" data-siteid=""9222289450909506993"" data-brand=""smh.com.au"" data-section=""World"" data-clippable=""true""></div>

                <div class=""OUTBRAIN"" data-src=""http://www.smh.com.au/world/egypt-on-edge-as-mursi-critics-face-off-20130630-2p58x.html"" data-widget-id=""SB_1"" data-ob-template=""The_Sydney_Morning_Herald_Fairfax""></div>

                <div class=""cfix""></div>
                        <div id=""adspot-300x250-pos-2"" class=""ad""> <small>Advertisement</small> <script type=""text/javascript""> if (ie) { renderIFAd(""adspot-300x250-pos-2"", ""dcAd-1-13"", ""http://ad-apac.doubleclick.net/adi/onl.smh.news/world;cat=world;ctype=article;pos=2;"" + document.dcAdsCParams + ""sz=300x250;tile=13;ord="" + dcOrd + ""?"", 300, 250, 624178175); } else { renderJIFAd(""adspot-300x250-pos-2"",""dcAd-1-13"", ""http://ad-apac.doubleclick.net/adj/onl.smh.news/world;cat=world;ctype=article;pos=2;"" + document.dcAdsCParams + ""sz=300x250;tile=13;ord="" + dcOrd + ""?"", 300, 250, 624178175, """"); } </script> <noscript> <iframe id=""dcAd-1-13"" src=""http://ad-apac.doubleclick.net/adi/onl.smh.news/world;cat=world;ctype=article;pos=2;sz=300x250;tile=13;ord=2.7293425E7?"" width='300' height='250' scrolling=""no"" marginheight=""0"" marginwidth=""0"" allowtransparency=""true"" frameborder=""0""> </iframe> </noscript> </div>
        </div><!-- class:aside span-8 last -->
        <!-- Footer fN-footerNetwork (class according to new HTML5 element 'footer'; scope: network-wide) -->
<div class=""footer span-24"" role=""contentinfo"">
    
    <div class=""c5 classifieds cfix"">
                            <div class=""s1 cDomain"">
                            <!-- Campaign ID: 1262043 -->
                            <h2><a title=""Real Estate"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"" href=""http://www.domain.com.au"">Real Estate</a></h2>
                                        <div class=""puff"">
                                                <a href=""http://news.domain.com.au/domain/blogs/talking-property/call-to-supersize-home-deposits-20130625-2ouba.html?utm_source=mastheads&utm_medium=rainbow&utm_campaign=blog250613"" rel=""nofollow"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip""  >
    <img src=""http://images.smh.com.au/2013/06/19/4502667/domainForSale_172x115.jpg-172x115.jpg"" width=""172"" alt=""Planning on buying a house soon?""/></a>

                                            <h5><a href=""http://news.domain.com.au/domain/blogs/talking-property/call-to-supersize-home-deposits-20130625-2ouba.html?utm_source=mastheads&utm_medium=rainbow&utm_campaign=blog250613"" rel=""nofollow"" title=""calltosuper-sizehomedeposits"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"">Call to super-size home deposits</a></h5>
                                        </div><!-- class:puff -->
                                        <ul><li class=""lDomain""><a href=""http://www.domain.com.au"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"">Domain.com.au</a></li>
                                        <li><a href=""http://www.domain.com.au?utm_source=mastheads&utm_medium=rainbow&utm_campaign=buy"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"">Buy real estate</a></li>
                                        <li><a href=""http://www.homepriceguide.com.au/Products/Product.aspx?ProductID=7&utm_source=mastheads&utm_medium=rainbow&utm_campaign=APM-Property-Report"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"">How much is my house worth?</a></li>
                                        <li><a href=""http://eyeon.com.au/about.asp?id=8&utm_source=EYEON&utm_medium=Domain&utm_content=rainbow&utm_campaign=report-offer"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"">Need an inspection report?</a></li>
                                </ul>
                        </div><!-- class:s1 cDomain -->
                        <div class=""s2 cDrive"">
                            <!-- Campaign ID: 1262045 -->
                            <h2><a title=""Motoring"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"" href=""http://www.drive.com.au"">Motoring</a></h2>
                                        <div class=""puff"">
                                                <a href=""http://smh.fairfaxbenefits.com.au/shortbooks/drive-good-car-guide"" rel=""nofollow"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip""  >
    <img src=""http://images.smh.com.au/2013/06/24/4515578/GoodCarGuide-300dpi-print-1-172x115.gif"" width=""172"" alt=""GoodCarGuide-300dpi-print-1""/></a>

                                            <h5><a href=""http://smh.fairfaxbenefits.com.au/shortbooks/drive-good-car-guide"" rel=""nofollow"" title=""drivesultimateguide-freeforashorttimeonly"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"">Drive's ultimate guide - free for a short time only</a></h5>
                                        </div><!-- class:puff -->
                                        <ul><li class=""lDrive""><a href=""http://www.drive.com.au"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"">Drive.com.au</a></li>
                                        <li><a href=""http://news.drive.com.au/drive/motor-news/taxtime-bargains-20130622-2oouu.html"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"">Tax-time auto bargains</a></li>
                                        <li><a href=""http://news.drive.com.au/motor-reviews?utm_source=rainbowstrip&utm_medium=mastheads&utm_campaign=500carreviews"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"">Over 500 car reviews a year</a></li>
                                        <li><a href=""http://www.drive.com.au/buy-used-cars?utm_source=rainbowstrip&utm_medium=mastheads&utm_campaign=carsforsale"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"">Cars for sale on Drive.com.au</a></li>
                                </ul>
                        </div><!-- class:s2 cDrive -->
                        <div class=""s3 cEssentialKids"">
                            <!-- Campaign ID: 1343365 -->
                            <h2><a title=""Essential Kids"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"" href=""http://www.essentialkids.com.au"">Essential Kids</a></h2>
                                        <div class=""puff"">
                                                <a href=""http://www.essentialkids.com.au/photogallery/entertaining-kids/play/weirdest-toys-ever-invented-20130612-2o31d.html#utm_source=FD&utm_medium=rainbow&utm_campaign=weirdesttoys"" rel=""nofollow"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip""  >
    <img src=""http://images.smh.com.au/2013/06/17/4496002/weirdtoys172x115-172x115.jpg"" width=""172"" alt=""weird toys""/></a>

                                            <h5><a href=""http://www.essentialkids.com.au/photogallery/entertaining-kids/play/weirdest-toys-ever-invented-20130612-2o31d.html#utm_source=FD&utm_medium=rainbow&utm_campaign=weirdesttoys"" rel=""nofollow"" title=""weirdestchildrenstoyseverinvented"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"">Weirdest children's toys ever invented</a></h5>
                                        </div><!-- class:puff -->
                                        <ul><li class=""lEssentialKids""><a href=""http://www.essentialkids.com.au"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"">Essentialkids.com.au</a></li>
                                        <li><a href=""http://www.essentialkids.com.au/recipes/lunchbox#utm_source=FD&utm_medium=rainbow&utm_campaign=lunchbox"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"">Lunchbox ideas & recipes</a></li>
                                        <li><a href=""http://www.essentialkids.com.au/activities-and-worksheets#utm_source=FD&utm_medium=rainbow&utm_campaign=activities"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"">Free kids' activities and worksheets</a></li>
                                        <li><a href=""http://www.essentialkids.com.au/recipes#utm_source=FD&utm_medium=rainbow&utm_campaign=recipes"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"">Family recipe finder</a></li>
                                </ul>
                        </div><!-- class:s3 cEssentialKids -->
                        <div class=""s4 cStayz"">
                            <!-- Campaign ID: 1262056 -->
                            <h2><a title=""Holidays"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"" href=""http://www.stayz.com.au"">Holidays</a></h2>
                                        <div class=""puff"">
                                                <a href=""http://www.stayz.com.au/?utm_source=rainbow&utm_medium=ffx&utm_campaign=smh"" rel=""nofollow"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip""  >
    <img src=""http://images.smh.com.au/2011/09/07/2608523/Stayz_93521_PalmBeach-172x115.jpg"" width=""172"" alt=""Stayz_93521_PalmBeach""/></a>

                                            <h5><a href=""http://www.stayz.com.au/?utm_source=rainbow&utm_medium=ffx&utm_campaign=smh"" rel=""nofollow"" title=""bookyouridealescapetoday"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"">Book your ideal escape today</a></h5>
                                        </div><!-- class:puff -->
                                        <ul><li class=""lStayz""><a href=""http://www.stayz.com.au"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"">Stayz.com.au</a></li>
                                        <li><a href=""http://www.stayz.com.au/accommodation/nsw/northern-rivers-byron-bay/byron-bay?utm_source=rainbow&utm_medium=ffx&utm_campaign=smh"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"">Escape to Byron Bay</a></li>
                                        <li><a href=""http://www.stayz.com.au/accommodation/vic/melbourne?utm_source=rainbow&utm_medium=ffx&utm_campaign=smh"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"">Escape to Melbourne</a></li>
                                        <li><a href=""http://www.stayz.com.au/accommodation/nsw/south-coast?utm_source=rainbow&utm_medium=ffx&utm_campaign=smh"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"">Escape to the South Coast</a></li>
                                </ul>
                        </div><!-- class:s4 cStayz -->
                        <div class=""s5 cInvestSmart"">
                            <!-- Campaign ID: 1262058 -->
                            <h2><a title=""Managed Funds"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"" href=""http://www.investsmart.com.au"">Managed Funds</a></h2>
                                        <div class=""puff"">
                                                <a href=""http://cash.investsmart.com.au/term-deposits?s_rid=rainbowstrip:termdepositsbl"" rel=""nofollow"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip""  >
    <img src=""http://images.smh.com.au/2011/03/03/2212792/growth_graph_greenlight-172x115.gif"" width=""172"" alt=""InvestSMART best performing investments 2011""/></a>

                                            <h5><a href=""http://cash.investsmart.com.au/term-deposits?s_rid=rainbowstrip:termdepositsbl"" rel=""nofollow"" title=""4.7%termdeposit!"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"">4.7% Term Deposit!</a></h5>
                                        </div><!-- class:puff -->
                                        <ul><li class=""lInvestSmart""><a href=""http://www.investsmart.com.au"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"">Investsmart.com.au</a></li>
                                        <li><a href=""http://cash.investsmart.com.au/home-loans?s_rid=rainbowstrip:besthomeloans"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"">Best Home loan Rates!</a></li>
                                        <li><a href=""http://cash.investsmart.com.au/savings-accounts?s_rid=rainbowstrip:savingsaccbl"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"">4.75% On Savings Accounts!</a></li>
                                        <li><a href=""http://www.investsmart.com.au/managed-funds/top-managed-funds.asp?s_rid=rainbowstrip:30%returnfunds"" class=""gaTrackable"" data-gaAction=""RainbowStrip Click"" data-gaCategory=""RainbowStrip"">Top Performing Investments!</a></li>
                                </ul>
                        </div><!-- class:s5 cInvestSmart -->
</div><!-- class:c5 classifieds cfix -->


    <div class='affiliateTabsInitParams' selectedTab='1' selectedTitle='' style='visibility:hidden'></div>
<div class=""fN-affiliateStrip"">
	<h2>Compare and Save</h2>
    <div class=""cN-tabPages affiliateStrip cfix"">
        <p class=""access"">Skip to:</p>
        <ul class=""nav"" role=""navigation"">
            <li class=""tab-1 selected""><a id=""link-tab-1"" href=""#tab-1"">Best Deals</a></li>
            <li class=""tab-2""><a id=""link-tab-2"" data-remote=""true"" data-remote-url=""/action/displayComponent?name=au.com.fairfaxdigital.common.media.webapp.ui.StaticIncludeComponent&designVersionName=media-common-1.0&params=tab-cands-2.html"" href=""#tab-2"">Mobile</a></li>
            <li class=""tab-3""><a id=""link-tab-3"" data-remote=""true"" data-remote-url=""/action/displayComponent?name=au.com.fairfaxdigital.common.media.webapp.ui.StaticIncludeComponent&designVersionName=media-common-1.0&params=tab-cands-3.html"" href=""#tab-3"">Broadband</a></li>
            <li class=""tab-4""><a id=""link-tab-4"" data-remote=""true"" data-remote-url=""/action/displayComponent?name=au.com.fairfaxdigital.common.media.webapp.ui.StaticIncludeComponent&designVersionName=media-common-1.0&params=tab-cands-4.html"" href=""#tab-4"">Home Loans</a></li>
            <li class=""tab-5""><a id=""link-tab-5"" data-remote=""true"" data-remote-url=""/action/displayComponent?name=au.com.fairfaxdigital.common.media.webapp.ui.StaticIncludeComponent&designVersionName=media-common-1.0&params=tab-cands-5.html"" href=""#tab-5"">Credit Cards</a></li>
            <li class=""tab-6""><a id=""link-tab-6"" data-remote=""true"" data-remote-url=""/action/displayComponent?name=au.com.fairfaxdigital.common.media.webapp.ui.StaticIncludeComponent&designVersionName=media-common-1.0&params=tab-cands-6.html"" href=""#tab-6"">Low Rate Cards</a></li>
            <li class=""tab-7""><a id=""link-tab-7"" data-remote=""true"" data-remote-url=""/action/displayComponent?name=au.com.fairfaxdigital.common.media.webapp.ui.StaticIncludeComponent&designVersionName=media-common-1.0&params=tab-cands-7.html"" href=""#tab-7"">Rewards Cards</a></li>
            <li class=""tab-8""><a id=""link-tab-8"" data-remote=""true"" data-remote-url=""/action/displayComponent?name=au.com.fairfaxdigital.common.media.webapp.ui.StaticIncludeComponent&designVersionName=media-common-1.0&params=tab-cands-8.html"" href=""#tab-8"">Savings Accts</a></li>
            <li class=""tab-9""><a id=""link-tab-9"" data-remote=""true"" data-remote-url=""/action/displayComponent?name=au.com.fairfaxdigital.common.media.webapp.ui.StaticIncludeComponent&designVersionName=media-common-1.0&params=tab-cands-9.html"" href=""#tab-9"">Term Deposits</a></li>
            <li class=""tab-10 last""><a id=""link-tab-10"" data-remote=""true"" data-remote-url=""/action/displayComponent?name=au.com.fairfaxdigital.common.media.webapp.ui.StaticIncludeComponent&designVersionName=media-common-1.0&params=tab-cands-10.html"" href=""#tab-10"">Loans</a></li>
        </ul>

        <div id=""tab-1"" class=""tab selected cfix"" aria-live=""polite"">
            <h3>Check out today's best deals</h3>
            <div class=""one"">
                <h3><a href=""http://compare.smh.com.au/home-loans?utm_source=CS_front&utm_medium=CnS&utm_campaign=HL_fixedratesfall&mpp_tab=3"" class=""gaTrackable"" data-gaAction=""1"" data-gaCategory=""CompareSave"" data-gaLabel=""1"">Fixed Rates Fall</a></h3>
                <a href=""http://compare.smh.com.au/home-loans?utm_source=CS_front&utm_medium=CnS&utm_campaign=HL_fixedratesfall&mpp_tab=3"" class=""gaTrackable"" data-gaAction=""1"" data-gaCategory=""CompareSave"" data-gaLabel=""1""><img src=""http://images.smh.com.au/compareandsave/cs-houses-flying.jpg"" width=""60"" height=""50"" /></a>
                <p><a href=""http://compare.smh.com.au/home-loans?utm_source=CS_front&utm_medium=CnS&utm_campaign=HL_fixedratesfall&mpp_tab=3"" class=""gaTrackable"" data-gaAction=""1"" data-gaCategory=""CompareSave"" data-gaLabel=""1"">Rates hit record low of 4.54% . Compare and save.</a></p>
                <span></span>
                <p class=""links""><a href=""http://compare.smh.com.au/home-loans?utm_source=CS_front&utm_medium=CnS&utm_campaign=HL_fixedratesfall&mpp_tab=3"" class=""gaTrackable"" data-gaAction=""1"" data-gaCategory=""CompareSave"" data-gaLabel=""1"">Lowest Fixed Rates</a></p>
            </div>
            <div class=""two"">
                <h3><a href=""http://compare.smh.com.au/home-loans?utm_source=CS_front&utm_medium=CnS&utm_campaign=HL_ubank487"" class=""gaTrackable"" data-gaAction=""1"" data-gaCategory=""CompareSave"" data-gaLabel=""2"">Refinance & Save</a></h3>
                <a href=""http://compare.smh.com.au/home-loans?utm_source=CS_front&utm_medium=CnS&utm_campaign=HL_ubank487"" class=""gaTrackable"" data-gaAction=""1"" data-gaCategory=""CompareSave"" data-gaLabel=""2""><img src=""http://images.smh.com.au/compareandsave/cs-ubank-hl-487.png"" width=""60"" height=""50"" /></a>
                <p><a href=""http://compare.smh.com.au/home-loans?utm_source=CS_front&utm_medium=CnS&utm_campaign=HL_ubank487"" class=""gaTrackable"" data-gaAction=""1"" data-gaCategory=""CompareSave"" data-gaLabel=""2"">Australia's cheapest refinance loan. Switch and save</a></p>
                <span></span>
                <p class=""links""><a href=""http://compare.smh.com.au/home-loans?utm_source=CS_front&utm_medium=CnS&utm_campaign=HL_ubank487"" class=""gaTrackable"" data-gaAction=""1"" data-gaCategory=""CompareSave"" data-gaLabel=""2"">Top Refinance Loans</a></p>
            </div>
            <div class=""three"">
                <h3><a href=""http://compare.smh.com.au/credit-cards?utm_source=CS_front&utm_medium=CnS&utm_campaign=CC_BT&mpp_tab=3"" class=""gaTrackable"" data-gaAction=""1"" data-gaCategory=""CompareSave"" data-gaLabel=""3"">0% Balance Transfer</a></h3>
                <a href=""http://compare.smh.com.au/credit-cards?utm_source=CS_front&utm_medium=CnS&utm_campaign=CC_BT&mpp_tab=3"" class=""gaTrackable"" data-gaAction=""1"" data-gaCategory=""CompareSave"" data-gaLabel=""3""><img src=""http://images.smh.com.au/compareandsave/cs-post-it-note-0.png"" width=""60"" height=""50"" /></a>
                <p><a href=""http://compare.smh.com.au/credit-cards?utm_source=CS_front&utm_medium=CnS&utm_campaign=CC_BT&mpp_tab=3"" class=""gaTrackable"" data-gaAction=""1"" data-gaCategory=""CompareSave"" data-gaLabel=""3"">Transfer credit card balances at 0% p.a. for 6 months</a></p>
                <span></span>
                <p class=""links""><a href=""http://compare.smh.com.au/credit-cards?utm_source=CS_front&utm_medium=CnS&utm_campaign=CC_BT&mpp_tab=3"" class=""gaTrackable"" data-gaAction=""1"" data-gaCategory=""CompareSave"" data-gaLabel=""3"">Balance Transfer Cards</a></p>
            </div>
            <div class=""four"">
                <h3><a href=""http://mobile-phones.smh.com.au/MobilePhones?utm_source=Widget_Fairfax_SMH_CompareAndSave&utm_medium=referral&utm_campaign=Hot_Android_Deals"" class=""gaTrackable"" data-gaAction=""1"" data-gaCategory=""CompareSave"" data-gaLabel=""4"">Hot Android Deals</a></h3>
                <a href=""http://mobile-phones.smh.com.au/MobilePhones?utm_source=Widget_Fairfax_SMH_CompareAndSave&utm_medium=referral&utm_campaign=Hot_Android_Deals"" class=""gaTrackable"" data-gaAction=""1"" data-gaCategory=""CompareSave"" data-gaLabel=""4""><img src=""http://images.smh.com.au/compareandsave/mobile_160x70_0613_gs4_k.jpg"" width=""60"" height=""50"" /></a>
                <p><a href=""http://mobile-phones.smh.com.au/MobilePhones?utm_source=Widget_Fairfax_SMH_CompareAndSave&utm_medium=referral&utm_campaign=Hot_Android_Deals"" class=""gaTrackable"" data-gaAction=""1"" data-gaCategory=""CompareSave"" data-gaLabel=""4"">Compare prices and deals on Android phones</a></p>
                <span></span>
                <p class=""links""><a href=""http://mobile-phones.smh.com.au/MobilePhones?utm_source=Widget_Fairfax_SMH_CompareAndSave&utm_medium=referral&utm_campaign=Hot_Android_Deals"" class=""gaTrackable"" data-gaAction=""1"" data-gaCategory=""CompareSave"" data-gaLabel=""4"">Android Deals</a></p>
            </div>
            <div class=""five"">
                <h3><a href=""http://mobile-phones.smh.com.au/MobilePhones/SIM-Only-Mobile-Phone-Plans?utm_source=Widget_Fairfax_SMH_CompareAndSave&utm_medium=referral&utm_campaign=SIM_Only_from_%246%2fMth"" class=""gaTrackable"" data-gaAction=""1"" data-gaCategory=""CompareSave"" data-gaLabel=""5"">SIM Only from $6/Mth</a></h3>
                <a href=""http://mobile-phones.smh.com.au/MobilePhones/SIM-Only-Mobile-Phone-Plans?utm_source=Widget_Fairfax_SMH_CompareAndSave&utm_medium=referral&utm_campaign=SIM_Only_from_%246%2fMth"" class=""gaTrackable"" data-gaAction=""1"" data-gaCategory=""CompareSave"" data-gaLabel=""5""><img src=""http://images.smh.com.au/compareandsave/mobile_160x70_0613_simonly_4.jpg"" width=""60"" height=""50"" /></a>
                <p><a href=""http://mobile-phones.smh.com.au/MobilePhones/SIM-Only-Mobile-Phone-Plans?utm_source=Widget_Fairfax_SMH_CompareAndSave&utm_medium=referral&utm_campaign=SIM_Only_from_%246%2fMth"" class=""gaTrackable"" data-gaAction=""1"" data-gaCategory=""CompareSave"" data-gaLabel=""5"">Compare SIM only plans starting at just $6/Month</a></p>
                <span></span>
                <p class=""links""><a href=""http://mobile-phones.smh.com.au/MobilePhones/SIM-Only-Mobile-Phone-Plans?utm_source=Widget_Fairfax_SMH_CompareAndSave&utm_medium=referral&utm_campaign=SIM_Only_from_%246%2fMth"" class=""gaTrackable"" data-gaAction=""1"" data-gaCategory=""CompareSave"" data-gaLabel=""5"">Compare BYO phone plans</a></p>
            </div>
        </div>

        <div id=""tab-2"" class=""tab cfix"" aria-live=""polite"">
        </div>

        <div id=""tab-3"" class=""tab cfix"" aria-live=""polite"">
        </div>

        <div id=""tab-4"" class=""tab cfix"" aria-live=""polite"">
        </div>

        <div id=""tab-5"" class=""tab cfix"" aria-live=""polite"">
        </div>

        <div id=""tab-6"" class=""tab cfix"" aria-live=""polite"">
        </div>

        <div id=""tab-7"" class=""tab cfix"" aria-live=""polite"">
        </div>

        <div id=""tab-8"" class=""tab cfix"" aria-live=""polite"">
        </div>

        <div id=""tab-9"" class=""tab cfix"" aria-live=""polite"">
        </div>

        <div id=""tab-10"" class=""tab cfix"" aria-live=""polite"">
        </div>

    </div>
</div>
        
<!-- Reader's most viewed -->
<div class=""c5 top5 cfix"">
    <h2 class=""cfix"">Readers' most viewed</h2>

            <div class=""s1 lBT"">
                <a href=""http://www.brisbanetimes.com.au"">Most viewed articles on Brisbane Times</a>
                <h5>Top 5 <a href=""http://www.brisbanetimes.com.au/world"">World</a> articles</h5>
    <ol>
            <li><a href=""http://www.brisbanetimes.com.au/world/from-the-sweet-life-to-a-squalid-jail-cell-20130629-2p3tf.html"" title=""From the sweet life to a squalid jail cell"" style="""">From the sweet life to a squalid jail cell</a></li>
            <li><a href=""http://www.brisbanetimes.com.au/world/syrian-army-launches-homs-offensive-20130630-2p4to.html"" title=""Syrian army launches Homs offensive"" style="""">Syrian army launches Homs offensive</a></li>
            <li><a href=""http://www.brisbanetimes.com.au/world/middleclass-rage-sparks-global-protests-20130630-2p4vx.html"" title=""Middle-class rage sparks global protests"" style="""">Middle-class rage sparks global protests</a></li>
            <li><a href=""http://www.brisbanetimes.com.au/world/un-to-test-flatpack-shelters-by-ikea-20130629-2p3vo.html"" title=""UN to test flat-pack shelters by IKEA"" style="""">UN to test flat-pack shelters by IKEA</a></li>
            <li><a href=""http://www.brisbanetimes.com.au/world/snowdens-father-seeks-deal-with-us-govt-20130630-2p4oo.html"" title=""Snowden's father seeks deal with US govt"" style="""">Snowden's father seeks deal with US govt</a></li>
    </ol>

            </div>
            <div class=""s2 lWAToday"">
                <a href=""http://www.watoday.com.au"">Most viewed articles on WA Today</a>
                <h5>Top 5 <a href=""http://www.watoday.com.au/world"">World</a> articles</h5>
    <ol>
            <li><a href=""http://www.watoday.com.au/world/un-to-test-flatpack-shelters-by-ikea-20130629-2p3vo.html"" title=""UN to test flat-pack shelters by IKEA"" style="""">UN to test flat-pack shelters by IKEA</a></li>
            <li><a href=""http://www.watoday.com.au/world/syrian-army-launches-homs-offensive-20130630-2p4to.html"" title=""Syrian army launches Homs offensive"" style="""">Syrian army launches Homs offensive</a></li>
            <li><a href=""http://www.watoday.com.au/world/middleclass-rage-sparks-global-protests-20130630-2p4vx.html"" title=""Middle-class rage sparks global protests"" style="""">Middle-class rage sparks global protests</a></li>
            <li><a href=""http://www.watoday.com.au/world/mandela-asks-to-be-buried-at-ancestral-home-20130629-2p3ts.html"" title=""Mandela asks to be buried at ancestral home"" style="""">Mandela asks to be buried at ancestral home</a></li>
            <li><a href=""http://www.watoday.com.au/world/biden-asks-ecuador-to-reject-snowden-asylum-bid-20130630-2p4vr.html"" title=""Biden asks Ecuador to reject Snowden asylum bid"" style="""">Biden asks Ecuador to reject Snowden asylum bid</a></li>
    </ol>

            </div>
            <div class=""s3 lAge"">
                <a href=""http://www.theage.com.au"">Most viewed articles on The Age</a>
                <h5>Top 5 <a href=""http://www.theage.com.au/world"">World</a> articles</h5>
    <ol>
            <li><a href=""http://www.theage.com.au/world/syrian-army-launches-homs-offensive-20130630-2p4to.html"" title=""Syrian army launches Homs offensive"" style="""">Syrian army launches Homs offensive</a></li>
            <li><a href=""http://www.theage.com.au/world/middleclass-rage-sparks-global-protests-20130630-2p4vx.html"" title=""Middle-class rage sparks global protests"" style="""">Middle-class rage sparks global protests</a></li>
            <li><a href=""http://www.theage.com.au/world/un-to-test-flatpack-shelters-by-ikea-20130629-2p3vo.html"" title=""UN to test flat-pack shelters by IKEA"" style="""">UN to test flat-pack shelters by IKEA</a></li>
            <li><a href=""http://www.theage.com.au/world/biden-asks-ecuador-to-reject-snowden-asylum-bid-20130630-2p4vr.html"" title=""Biden asks Ecuador to reject Snowden asylum bid"" style="""">Biden asks Ecuador to reject Snowden asylum bid</a></li>
            <li><a href=""http://www.theage.com.au/world/mandela-asks-to-be-buried-at-ancestral-home-20130629-2p3ts.html"" title=""Mandela asks to be buried at ancestral home"" style="""">Mandela asks to be buried at ancestral home</a></li>
    </ol>

            </div>
            <div class=""s4 lCanberratimes"">
                <a href=""http://www.canberratimes.com.au"">Most viewed articles on Canberra Times</a>
                <h5>Top 5 <a href=""http://www.canberratimes.com.au/world"">World</a> articles</h5>
    <ol>
            <li><a href=""http://www.canberratimes.com.au/world/middleclass-rage-sparks-global-protests-20130630-2p4vx.html"" title=""Middle-class rage sparks global protests"" style="""">Middle-class rage sparks global protests</a></li>
            <li><a href=""http://www.canberratimes.com.au/world/syrian-army-launches-homs-offensive-20130630-2p4to.html"" title=""Syrian army launches Homs offensive"" style="""">Syrian army launches Homs offensive</a></li>
            <li><a href=""http://www.canberratimes.com.au/world/un-to-test-flatpack-shelters-by-ikea-20130629-2p3vo.html"" title=""UN to test flat-pack shelters by IKEA"" style="""">UN to test flat-pack shelters by IKEA</a></li>
            <li><a href=""http://www.canberratimes.com.au/world/mandela-asks-to-be-buried-at-ancestral-home-20130629-2p3ts.html"" title=""Mandela asks to be buried at ancestral home"" style="""">Mandela asks to be buried at ancestral home</a></li>
            <li><a href=""http://www.canberratimes.com.au/world/putting-the-byte-into-fashion-20130629-2p3th.html"" title=""Putting the byte into fashion"" style="""">Putting the byte into fashion</a></li>
    </ol>

            </div>
            <div class=""s5 lSmh"">
                <a href=""http://www.smh.com.au"">Most viewed articles on The Sydney Morning Herald</a>
                <h5>Top 5 <a href=""http://www.smh.com.au/world"">World</a> articles</h5>
    <ol>
            <li><a href=""http://www.smh.com.au/world/from-the-sweet-life-to-a-squalid-jail-cell-20130629-2p3tf.html"" title=""From the sweet life to a squalid jail cell"" style="""">From the sweet life to a squalid jail cell</a></li>
            <li><a href=""http://www.smh.com.au/world/un-to-test-flatpack-shelters-by-ikea-20130629-2p3vo.html"" title=""UN to test flat-pack shelters by IKEA"" style="""">UN to test flat-pack shelters by IKEA</a></li>
            <li><a href=""http://www.smh.com.au/world/syrian-army-launches-homs-offensive-20130630-2p4to.html"" title=""Syrian army launches Homs offensive"" style="""">Syrian army launches Homs offensive</a></li>
            <li><a href=""http://www.smh.com.au/world/middleclass-rage-sparks-global-protests-20130630-2p4vx.html"" title=""Middle-class rage sparks global protests"" style="""">Middle-class rage sparks global protests</a></li>
            <li><a href=""http://www.smh.com.au/world/eu-officials-targeted-in-us-spying-report-20130630-2p4w0.html"" title=""EU officials targeted in US spying: report"" style="""">EU officials targeted in US spying: report</a></li>
    </ol>

            </div>
</div>
   
                <div id=""adspot-728x90,468x60-pos-2"" class=""ad""> <script> renderJAd(""adspot-728x90,468x60-pos-2"", ""dcAd-14"", 'http://ad-apac.doubleclick.net/adj/onl.smh.news/world;cat=world;ctype=article;pos=2;' + document.dcAdsCParams +'sz=728x90,468x60;tile=14;ord=' + dcOrd + '?', 791267279); </script> <noscript> <a href='http://ad-apac.doubleclick.net/jump/onl.smh.news/world;cat=world;ctype=article;pos=2;sz=728x90,468x60;tile=14;ord=2.7293425E7?' target=""_blank""> <img src='http://ad-apac.doubleclick.net/ad/onl.smh.news/world;cat=world;ctype=article;pos=2;sz=728x90,468x60;tile=14;ord=2.7293425E7?' border=""0"" alt=""""> </a> </noscript> </div>
        <ul class=""fSectionLinks cfix"">
            <li ><a href=""http://www.smh.com.au/"" title=""SMH Home"">SMH Home</a></li>
            <li ><a href=""http://www.smh.com.au/nsw"" title=""NSW"">NSW</a></li>
            <li ><a href=""http://www.smh.com.au/opinion"" title=""Politics"">Politics</a></li>
            <li ><a href=""http://www.smh.com.au/world"" title=""World"">World</a></li>
            <li ><a href=""http://www.smh.com.au/national"" title=""National"">National</a></li>
            <li ><a href=""http://www.smh.com.au/environment"" title=""Environment"">Environment</a></li>
            <li ><a href=""http://www.smh.com.au/business"" title=""Business"">Business</a></li>
            <li ><a href=""http://www.smh.com.au/digital-life"" title=""Digital Life"">Digital Life</a></li>
            <li ><a href=""http://www.smh.com.au/entertainment/"" title=""Entertainment"">Entertainment</a></li>
            <li ><a href=""http://www.smh.com.au/lifestyle"" title=""Life &amp; Style"">Life &amp; Style</a></li>
            <li ><a href=""http://www.smh.com.au/travel"" title=""Travel"">Travel</a></li>
            <li ><a href=""http://www.smh.com.au/drive"" title=""Cars"">Cars</a></li>
            <li ><a href=""http://www.smh.com.au/executive-style"" title=""Exec Style"">Exec Style</a></li>
            <li ><a href=""http://www.smh.com.au/sport"" title=""Sport"">Sport</a></li>
            <li class=""last""><a href=""http://weather.smh.com.au/local.jsp"" title=""Weather"">Weather</a></li>
    </ul>

    <!-- Footer masthead links and copyright -->
<div class=""fMastheadLinks cfix"">
        <ul class=""span-4 cfix"">
        <li class=""first""><h5>Sydney Morning Herald</h5></li>
            <li><a href=""http://www.smh.com.au/siteguide/"" title=""Sitemap"">Sitemap</a></li>
            <li><a href=""http://www.smh.com.au/aboutsmh/index.html"" title=""About Us"">About Us</a></li>
            <li><a href=""http://www.smh.com.au/support/"" title=""Contact Us"">Contact Us</a></li>
            <li><a href=""http://adcentre.com.au/brands/the-sydney-morning-herald/"" title=""Advertise with Us"">Advertise with Us</a></li>
            <li><a href=""http://www.smh.com.au/am/"" title=""AM Today"">AM Today</a></li>
            <li><a href=""http://www.smh.com.au/newsstore/index.html"" title=""Last 8 days"">Last 8 days</a></li>
            <li><a href=""http://www.smh.com.au/text/"" title=""Text Version"">Text Version</a></li>
            <li><a href=""http://www.smh.com.au/siteguide/accessibility"" title=""Site Accessibility Guide"">Site Accessibility Guide</a></li>
    </ul>

        <ul class=""span-4 cfix"">
        <li class=""first""><h5>Connect</h5></li>
            <li><a href=""http://m.smh.com.au"" title=""Mobile Site"">Mobile Site</a></li>
            <li><a href=""http://www.smh.com.au/interactive/ipad-app-landing/"" title=""SMH for iPad"">SMH for iPad</a></li>
            <li><a href=""http://www.smh.com.au/digitaledition "" title=""Digital Edition"">Digital Edition</a></li>
            <li><a href=""http://www.smh.com.au/rssheadlines"" title=""RSS"">RSS</a></li>
            <li><a href=""http://www.facebook.com/sydneymorningherald"" title=""Facebook"">Facebook</a></li>
            <li><a href=""https://twitter.com/#!/smh"" title=""Twitter"">Twitter</a></li>
            <li><a href=""http://www.linkedin.com/today/smh.com.au"" title=""LinkedIn"">LinkedIn</a></li>
    </ul>

        <ul class=""span-4 cfix"">
        <li class=""first""><h5>Products & Services</h5></li>
            <li><a href=""https://subscriptions.fairfax.com.au/Campaigns/Campaign.aspx?cid=55&src=INTERNET&s_cid=default&pub=SMH&subsrc="" title=""Subscribe"">Subscribe</a></li>
            <li><a href=""https://subscriptions.fairfax.com.au/landing/SMH/smh_subscriptions.aspx"" title=""Manage My Subscription"">Manage My Subscription</a></li>
            <li><a href=""http://smh.fairfaxbenefits.com.au/"" title=""My Benefits"">My Benefits</a></li>
            <li><a href=""http://www.goodguides.com.au/sydney/"" title=""Good Food Guide"">Good Food Guide</a></li>
            <li><a href=""http://www.smhshop.com.au/"" title=""SMH Shop"">SMH Shop</a></li>
            <li><a href=""https://membercentre.fairfax.com.au/NewsletterSubscription.aspx"" title=""Newsletters"">Newsletters</a></li>
            <li><a href=""http://www.crackawines.com.au/"" title=""Cracka Wines"">Cracka Wines</a></li>
    </ul>

        <ul class=""span-4 cfix"">
        <li class=""first""><h5>Classifieds</h5></li>
            <li><a href=""http://www.advertisers.com.au"" title=""Place an Ad"">Place an Ad</a></li>
            <li><a href=""http://www.stayz.com.au/"" title=""Accommodation"">Accommodation</a></li>
            <li><a href=""http://www.drive.com.au/"" title=""Cars"">Cars</a></li>
            <li><a href=""http://www.rsvp.com.au/"" title=""Dating"">Dating</a></li>
            <li><a href=""http://mycareer.com.au/"" title=""Jobs"">Jobs</a></li>
            <li><a href=""http://apm.com.au/"" title=""Property Price Data"">Property Price Data</a></li>
            <li><a href=""http://www.domain.com.au/"" title=""Real Estate"">Real Estate</a></li>
            <li><a href=""http://www.buyandsell.com.au/?utm_source=SMH&utm_medium=HomeFooterLink&utm_campaign=Buy%2Band%2BSell "" title=""Buy and Sell"">Buy and Sell</a></li>
            <li><a href=""http://tributes.smh.com.au/obituaries/smh-au/?utm_source=SMH&utm_medium=Homefooterlink&utm_campaign=SMH%2BTributes "" title=""Tributes"">Tributes</a></li>
            <li><a href=""http://celebrations.smh.com.au/celebration/smh-au/?utm_source=SMH&utm_medium=HomeFooter&utm_campaign=SMH%2BCelebrations "" title=""Celebrations"">Celebrations</a></li>
            <li><a href=""http://www.smhfeatures.com.au"" title=""Special Reports"">Special Reports</a></li>
    </ul>

        <ul class=""span-4 cfix"">
        <li class=""first""><h5>Fairfax Media</h5></li>
            <li><a href=""https://membercentre.fairfax.com.au/"" title=""Member Centre"">Member Centre</a></li>
            <li><a href=""http://www.fairfax.com.au/conditions"" title=""Conditions of Use"">Conditions of Use</a></li>
            <li><a href=""http://www.fairfax.com.au/privacy"" title=""Privacy Policy"">Privacy Policy</a></li>
            <li><a href=""http://newsstore.fairfax.com.au/apps/newsSearch.ac?sy=nstore"" title=""News Store Archive"">News Store Archive</a></li>
            <li><a href=""http://www.fairfaxsyndication.com/"" title=""Photo Sales"">Photo Sales</a></li>
            <li><a href=""http://consumer.fairfaxsyndication.com/C.aspx?VP3=ViewBox_VPage&ALID=2ITHRGMNCNCN&CT=Album"" title=""Purchase Front Pages"">Purchase Front Pages</a></li>
            <li><a href=""http://www.fairfaxsyndication.com/"" title=""Fairfax Syndication"">Fairfax Syndication</a></li>
            <li><a href=""http://www.fairfaxevents.com.au/"" title=""Fairfax Events"">Fairfax Events</a></li>
            <li><a href=""http://careers.fairfax.com.au/home.asp"" title=""Fairfax Careers"">Fairfax Careers</a></li>
            <li><a href=""http://www.presscouncil.org.au/what-we-do/"" title=""Press Council"">Press Council</a></li>
    </ul>

    
</div>
<!-- This comment fixes IE6's logo problem. Might be temporary until we've got content below this point -->
    <div class=""nN-footerLinks"">
	<a href=""http://www.fairfaxdigital.com.au"" class=""logo"">Fairfax Media</a>
	<div>
        <h3>Our Sites</h3>
    <ul>
            <li class=""first"">
                <a title=""The Sydney Morning Herald"" href=""http://www.smh.com.au/"">The Sydney Morning Herald</a>
            </li>
            <li>
                <a title=""The Age"" href=""http://www.theage.com.au/"">The Age</a>
            </li>
            <li>
                <a title=""MyCareer"" href=""http://mycareer.com.au/"">MyCareer</a>
            </li>
            <li>
                <a title=""Domain"" href=""http://www.domain.com.au/"">Domain</a>
            </li>
            <li>
                <a title=""Drive"" href=""http://www.drive.com.au/"">Drive</a>
            </li>
            <li>
                <a title=""RSVP"" href=""http://www.rsvp.com.au/"">RSVP</a>
            </li>
            <li>
                <a title=""Essential Baby"" href=""http://www.essentialbaby.com.au/"">Essential Baby</a>
            </li>
            <li>
                <a title=""InvestSMART"" href=""http://www.investsmart.com.au/"">InvestSMART</a>
            </li>
            <li>
                <a title=""APM"" href=""http://apm.com.au/"">APM</a>
            </li>
            <li>
                <a title=""Stayz"" href=""http://www.stayz.com.au/"">Stayz</a>
            </li>
            <li>
                <a title=""Weatherzone"" href=""http://www.weatherzone.com.au/"">Weatherzone</a>
            </li>
            <li>
                <a title=""TheVine"" href=""http://www.thevine.com.au/#utm_source=FD&utm_medium=mastheadpuff&utm_campaign=thevineheader"">TheVine</a>
            </li>
    </ul>

        <h3>Our Partners</h3>
    <ul>
            <li class=""first"">
                <a title=""Buy & Sell"" href=""http://www.buyandsell.com.au/"">Buy & Sell</a>
            </li>
            <li>
                <a title=""Cruises"" href=""http://www.cruises.com.au"">Cruises</a>
            </li>
            <li>
                <a title=""Lawyers"" href=""http://www.lawyers.com.au/"">Lawyers</a>
            </li>
            <li>
                <a title=""Credit Cards"" href=""http://www.creditcards.com.au/"">Credit Cards</a>
            </li>
            <li>
                <a title=""Business"" href=""http://www.business.com.au/"">Business</a>
            </li>
            <li>
                <a title=""Mechanics"" href=""http://www.mechanics.com.au/"">Mechanics</a>
            </li>
            <li>
                <a title=""Electricians"" href=""http://www.electrician.com.au/"">Electricians</a>
            </li>
            <li>
                <a title=""Fitness"" href=""http://www.fitness.com.au/"">Fitness</a>
            </li>
            <li>
                <a title=""Hair Salons"" href=""http://www.hairsalon.com.au/"">Hair Salons</a>
            </li>
            <li>
                <a title=""Weddings"" href=""http://www.wedding.com.au/"">Weddings</a>
            </li>
            <li>
                <a title=""Home Builder"" href=""http://www.homebuilders.com.au/"">Home Builder</a>
            </li>
            <li>
                <a title=""Cracker"" href=""http://cracker.com.au/"">Cracker</a>
            </li>
    </ul>

    </div>
    <cite>Copyright &copy; 2013 Fairfax Media</cite>
</div>
        <div class=""Kampyle"" data-kampyleFormId=""43595"" data-kampyleSiteCode=""9067101"">
        <a id=""kampylink"" class=""k_static"" href=""http://www.kampyle.com/feedback_form/ff-feedback-form.php?site_code=9067101&lang=en&form_id=43595"" target=""kampyleWindow"">
            <img src=""http://resources.smh.com.au/smh/media-common-1.0/images/feedback-button.gif"" alt=""Feedback Form"" style=""border:0""/>
        </a>
    </div><!-- class:Kampyle -->

</div>
  
<!-- End fN-footerNetwork -->
        <div id=""adspot-1x1"" style='display:none;' class=""ad""> </div>
        <div id=""adspot-1x11"" style='display:none;' class=""ad""> </div>
    </div><!-- class:wrap cfix -->
</div><!-- class:outerWrap -->
<div id=""network-strip"" class=""network-strip-wrap"">
    <div class=""network-strip cf"">
    <ul class=""nav edition"" role=""menu"">
            <li role=""menuitem"" id=""whiteStrip-time""><em>12:53AM</em> Monday Jul 01, 2013</li>
            <li role=""menuitem"" id=""whiteStrip-users"" class=""online"">9,178 online now</li>

    
    
<li role=""menuitem"">
    <span>Do you know more about a story?</span>
    <div class=""dropdown-panel"">
        <button class=""dropdown-panel-toggle generic-selector"" aria-owns=""box-contact"" aria-haspopup=""true"" title=""contact us""><span class=""icon ddown"">contact us</span></button>

            <div id=""box-contact"" class=""dropdown-content dropdown-content-contact generic-selector"">
                <button class=""close generic-selector"" title=""close"">Close</button>
                <form method=""GET"" action=""mailto:scoop@smh.com.au"">
                    <label class=""h4"">Provide detailed information, including contact details (if relevant)</label>
                    <textarea name=""body""></textarea>
                    <input type=""hidden"" name=""subject"" value=""Tip"">
                    <input type=""submit"" value=""Post"" class=""btn"">
                </form>
            </div>
    </div>
</li>
</ul>

        <ul class=""nav external"" role=""menu"">
<li><a href=""http://www.domain.com.au/"" onclick=""linktop(this);"">Real Estate</a></li>
<li><a href=""http://www.drive.com.au/"" onclick=""linktop(this);"">Cars</a></li>
<li><a href=""http://mycareer.com.au/"" onclick=""linktop(this);"">Jobs</a></li>
<li><a href=""http://www.rsvp.com.au/"" onclick=""linktop(this);"">Dating</a></li>
<li><a href=""https://membercentre.fairfax.com.au/NewsletterSubscription.aspx"" onclick=""linktop(this);"">Newsletters</a></li>

    <li class=""menuitem"">
        <div class=""dropdown-panel"">
            <button class=""dropdown-panel-toggle generic-selector"" aria-owns=""box-network"" aria-haspopup=""true"">Fairfax Media Network<span class=""icon ddown"">More</span></button>

                <div id=""box-network"" class=""dropdown-content dropdown-content-logos"">
                    <button class=""close generic-selector"" title=""close generic-selector"">Close</button>
                    <div class=""logos cf"">
                        <div class=""col"">
                            <h4>News &amp; Weather</h4>
                            <ul role=""navigation"">
                                    <li class=""smh""><a href=""http://www.smh.com.au"" title=""The Sydney Morning Herald"">smh.com.au</a></li>
                                    <li class=""theage""><a href=""http://www.theage.com.au"" title=""The Age"">theage.com.au</a></li>
                                    <li class=""brisbanetimes""><a href=""http://www.brisbanetimes.com.au"" title=""Brisbane Times"">brisbanetimes.com.au</a></li>
                                    <li class=""canberratimes""><a href=""http://www.canberratimes.com.au"" title=""Canberra Times"">canberratimes.com.au</a></li>
                                    <li class=""nationaltimes""><a href=""http://www.nationaltimes.com.au"" title=""National Times"">nationaltimes.com.au</a></li>
                                    <li class=""watoday""><a href=""http://www.watoday.com.au"" title=""WA Today"">watoday.com.au</a></li>
                                    <li class=""weatherzone""><a href=""http://www.weatherzone.com.au"" title=""Weather Zone"">weatherzone.com.au</a></li>
                            </ul>
                        </div>
                        <div class=""col"">
                            <h4>Business &amp; Finance</h4>
                            <ul role=""navigation"">
                                    <li class=""businessday""><a href=""http://www.businessday.com.au"" title=""Business Day"">businessday.com.au</a></li>
                                    <li class=""brw""><a href=""http://www.brw.com.au"" title=""BRW"">brw.com.au</a></li>
                                    <li class=""afr""><a href=""http://www.afr.com"" title=""AFR"">afr.com</a></li>
                                    <li class=""afrmagazine""><a href=""http://www.afrmagazine.com.au"" title=""AFR Magzine"">afrmagazine.com.au</a></li>
                                    <li class=""smartinvestor""><a href=""http://www.smartinvestor.com.au"" title=""SmartInvestor"">smartinvestor.com.au</a></li>
                                    <li class=""investsmart""><a href=""http://www.investsmart.com.au"" title=""investSmart"">investsmart.com.au</a></li>
                            </ul>
                        </div>
                        <div class=""col"">
                            <h4>Lifestyle</h4>
                            <ul role=""navigation"">
                                    <li class=""lifestyle""><a href=""http://www.smh.com.au/lifesyle"" title=""LifeStyle"">life &amp; style</a></li>
                                    <li class=""dailylife""><a href=""http://www.dailylife.com.au"" title=""Daily Life"">dailylife.com.au</a></li>
                                    <li class=""thevine""><a href=""http://www.thevine.com.au"" title=""The Vine"">thevine.com.au</a></li>
                                    <li class=""essentialbaby""><a href=""http://www.essentialbaby.com.au"" title=""Essential Baby"">essentialbaby.com.au</a></li>
                                    <li class=""essentialkids""><a href=""http://www.essentialkids.com.au"" title=""Essential Kids"">essentialkids.com.au</a></li>
                                    <li class=""findababysitter""><a href=""http://www.findababysitter.com.au"" title=""Find a Baby Sitter"">findababysitter.com.au</a></li>
                                    <li class=""goodfood""><a href=""http://www.goodfood.com.au"" title=""Good Food"">goodfood.com.au</a></li>
                            </ul>
                        </div>
                        <div class=""col last"">
                            <h4>Classifieds</h4>
                            <ul role=""navigation"">
                                    <li class=""domain""><a href=""http://www.domain.com.au"" title=""Domain"">domain.com.au</a></li>
                                    <li class=""drive""><a href=""http://www.drive.com.au"" title=""Drive"">drive.com.au</a></li>
                                    <li class=""mycareer""><a href=""http://www.mycareer.com.au"" title=""MyCareer"">mycareer.com.au</a></li>
                                    <li class=""rsvp""><a href=""http://www.rsvp.com.au"" title=""RSVP"">rsvp.com.au</a></li>
                                    <li class=""stayz""><a href=""http://www.stayz.com.au"" title=""Stayz"">stayz.com.au</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""additional-links"">
                        <ul class=""nav"">
                            <ul class=""nav"">
                                        <li><a href=""http://smh.com.au/mybenefits"" title=""Member benefits"">Member benefits</a></li>
                                    <li><a href=""http://adcentre.fairfaxdigital.com.au"" title=""Advertise with us"">Advertise with us</a></li>
                                    <li><a href=""https://membercentre.fairfax.com.au/NewsletterSubscription.aspx"" title=""Newsletters"">Newsletters</a></li>
                                    <li><a href=""http://www.fairfax.com.au/network-map.aspx"" title=""Full list of sites"">Full list of sites</a></li>
                                    <li><a href=""http://fairfaxmedia.com.au"" title=""About Fairfax Media"">About Fairfax Media</a></li>
                                    <li><a href=""http://www.fairfax.com.au/privacy"" title=""Privacy"">Privacy</a></li>
                                    <li><a href=""http://www.fairfax.com.au/conditions"" title=""Terms &amp; Conditions"">Terms &amp; Conditions</a></li>
                            </ul>
                        </ul>
                    </div>
                </div>
        </div>
    </li>
</ul>

    </div>
</div><!-- class:network-strip-wrap -->


            <script type=""text/javascript"">

    var recommendOptions = {
        display: ""hidden"",
        pos: ""rhs"",
        size: {content: 5, rhs: 4},
        matchingMode: ""behavioral^50,contextual^25,trend^25"",
        maxResults: 30,
        siteOptions: {
            ""nationaltimes.com.au"": {display: ""off""},
            ""businessday.com.au"": {display: ""off""},
            ""moneymanager.com.au"": {display: ""off""},
            ""goodfood.com.au"": {display: ""hidden""},
            ""essentialbaby.com.au"": {display: ""hidden""},
            ""essentialkids.com.au"": {display: ""hidden""},
            ""dailylife.com.au"": {display: ""hidden""},
            ""domain.com.au"": {display: ""hidden""},
            ""drive.com.au"": {display: ""hidden""}
        },
        sectionOptions: {
            ""Drive"": {display: ""off""},
            ""Domain"": {size: {content: 5, rhs: 3}},
            ""Business"": {pos: ""content""}
        }
    };

</script>


<div id=""subscription-overlay"" class=""subscription-overlay""
     data-hagrid-channel-key=""Dks89-tJMqw6zsOGPU5c5Q""
     data-hagrid-base-url=""https://smh.myfairfax.com.au""
     data-hagrid-api-url=""https://api.myfairfax.com.au""
     data-hagrid-proxy-url=""/originstatic/hagridproxy-0.9.22.html""
     data-hagrid-iframe-container-id=""loginIframeContainer""
     data-drm-host=""http://access.fairfaxapi.com.au""
     data-hagrid-member-profile-provider-name=""customMemberProfileProvider"">
</div>

        <script type=""text/javascript"" src=""http://resources.smh.com.au/common/media-common-1.0/js/fdjsf/output/7.24.6/fd_min.js""></script>


        <script type=""text/javascript"" src=""http://resources.smh.com.au/common/media-common-1.0/js/fdjsf/output/7.24.6/fd.google_min.js""></script>

        <script type=""text/javascript"" src=""http://resources.smh.com.au/common/media-common-1.0/js/fdjsf/output/7.24.6/fd.registrars_min.js""></script>

    <script type=""text/javascript"">
    if (FD.JSSDK) {

    window.customMemberProfileProvider = (function() {
        var module = {};
        var env = """";
        var COOKIE_NAME = ""ffx_mm_token"" + (env ? '_' + env : '');
        var DAYS_TO_EXPIRE = 30;
        module.get = function() {
            var cookie = FD.getCookie(COOKIE_NAME);
            if (cookie && cookie != """") {
                return {member_token: cookie };
            }
            return null;
        }
        module.set = function(profile, expires) {
            if (!expires) {
                expires = Date.now() + DAYS_TO_EXPIRE * 24 * 60 * 60 * 1000;
            }
            FD.setCookie(COOKIE_NAME, profile.member_token, expires, '/', 'smh.com.au');
        };
        module.clear = function() {
            FD.setCookie(COOKIE_NAME, null, null, '/', 'smh.com.au');
        };
        return module;
    }(document));

    window.ffxReady = function() {
        FD.bind(""FDHagridLogin"", function() {
            if (FFXHagrid.isLoggedIn()) {
                FD.trigger(""FDMyMastheadCompleteLogin"", ""http://www.smh.com.au"");
            }
            FFXHagrid.setDocumentDomain(document.domain);
            FFXHagrid.login({ui: 'iframe'});
        });
        FD.bind(""FDHagridLogout"", function() {
            FFXHagrid.setDocumentDomain(document.domain);
            FFXHagrid.logout({ui: 'iframe'});
        });
        FFXHagrid.on('login', function() {
            if (FFXHagrid.isLoggedIn()) {
                FD.trigger(""FDMyMastheadCompleteLogin"",  ""http://www.smh.com.au"");
            }
        });
        FFXHagrid.on('logout', function() {
            window.location.href = ""http://www.smh.com.au/ugc/logout.html"";
        });

        FD.bind(""FDDrmSubscribe"", function() {
            FFXHagrid.subscribe({ui: 'fullpage'});
        });
        FD.bind(""FDDrmActivate"", function() {
            FFXHagrid.activatePrintSubscription({ui: 'fullpage'});
        });
        var profileProvider = FFXDRM.DefaultUserProfileProvider(), drmclient = FFXDRM.DRMClient({ userProfileProvider: profileProvider });
        drmclient.on('accessdenied', function(reason, requiredPlans, limit) {
            FD.s_prop24=reason;
            FD.trigger(""FDDrmInfo"", [reason, limit]);
        });
        drmclient.on('accessallowed', function() {
            FD.s_prop24='accessallowed';
        });
        drmclient.on('showmeter', function(count, limit) {
            FD.trigger(""FDDrmMeter"", [count, limit]);
        });

        (function() {
            var asset = {
                id: '4532433',
                types: ['article'],
                sources: ['AAP'],
                categories: ['World']
            };
            FD.trigger(""FDDrmCheckPermissions"", [drmclient, 'smh', asset, FFXHagrid.getUserPlansProvider()]);
        })();
    };

    (function(d) {
        var js = d.createElement('script'),
                ref = d.getElementsByTagName('script')[0];
        js.src = ""http://resources.fairfax.com.au/js/ffx-sdk/ffx-hagrid-drm-0.9.22.min.js"";
        js.async = true;
        js.id = 'ffx-script';
        js.setAttribute('data-hagrid-channel-key', 'Dks89-tJMqw6zsOGPU5c5Q');
        js.setAttribute('data-hagrid-base-url', 'https://smh.myfairfax.com.au');
        js.setAttribute('data-hagrid-api-url', 'https://api.myfairfax.com.au');
        js.setAttribute('data-hagrid-proxy-url', '/originstatic/hagridproxy-0.9.22.html');
        js.setAttribute('data-hagrid-iframe-container-id', 'loginIframeContainer');
        js.setAttribute('data-drm-host', 'http://access.fairfaxapi.com.au');
        js.setAttribute('data-hagrid-member-profile-provider-name', 'customMemberProfileProvider');
        ref.parentNode.insertBefore(js, ref);
    }(document));
}
</script>
<div data-brandName=""smh""></div>
        <script type=""text/javascript"" src=""http://resources.smh.com.au/common/media-common-1.0/js/fdjsf/output/7.24.6/fd.videoplayer_min.js""></script>



            <script type=""text/javascript"" src=""http://resources.smh.com.au/common/media-common-1.0/js/fdjsf/output/7.24.6/fd.registrars.mymasthead_min.js""></script>

        <script type=""text/javascript"" src=""http://resources.smh.com.au/common/media-common-1.0/js/fdjsf/output/7.24.6/fd.registrars.contentpagewide_min.js""></script>

    <script type=""text/javascript"">
    (function() {
        new FD.UserHistoryRecommendations({
            ""assetId"": ""4532433""
        })
     })();
    </script>

<script type=""text/javascript"">
    (function() {
            var jsonFragmentData0 = {""stopRecommend"":true,""name"":""2f8rk"",""listName"":""SMH Homepage Recommend Fragment 1"",""matchingModes"":{},""defaultAssets"":[{""pos"":0,""rank"":0},{""pos"":0,""rank"":1},{""pos"":0,""rank"":2},{""pos"":0,""rank"":3},{""pos"":0,""rank"":4}],""groups"":[],""allDomains"":[],""allTypes"":[]};
            if (!jsonFragmentData0.stopRecommend) {
                new FD.RecommendationsFragment({
                    ""baseUrl"": ""http://www.smh.com.au"",
                    ""serviceUrl"": ""http://fairfax.cxsearch.cxense.com/api/recommendation"",
                    ""fragmentData"": jsonFragmentData0,
                    ""cookiePrefix"": ""ffx_home_rec_"",
                    ""maxGroups"": 5,
                    ""frequency"": 5,
                    ""debugMode"": false
                });
            }
    })();
</script>


<script type=""text/javascript"">
    function getGoogleAdChannel(showAboveArticle) {
        var googleAdChannel = ""World"";
        if (showAboveArticle) {
            googleAdChannel += "" abovearticle"";
        }
        return googleAdChannel;
    }
    function google_ad_request_done(google_ads) {
        var googleAd = new FD.GoogleAd({
                adBlockTitle: ""Ads by Google"",
                maximumAdsInBlock: 3,
                checkExternalReferrer: true,
                split: 1,
            googleAds: google_ads,
            googleAdsId: ""googleAds"",
            moreGoogleAdsId: ""moreGoogleAds""
        });
        googleAd.insertGoogleAds();
    }
    var google_ad_client = ""ca-fairfax-smh_js"";
    var google_ad_channel = ""National"";
    var google_max_num_ads = ""4"";
        var externalReferrer = FD.getCookie(""externalReferrer"");
        if (FD.showExternalReferrerAd(externalReferrer)) {
            google_ad_channel = getGoogleAdChannel(true);
        } else {
            google_max_num_ads = ""3"";
        }
    var google_ad_output = ""js"";
    var google_ad_type = ""text"";
    var google_encoding = ""utf8"";
    var google_safe = ""high"";
    var google_ad_section = ""default"";
</script>
<!-- The JavaScript returned from the following page uses the parameter values assigned above to populate an array of
ad objects. Once that array has been populated, the JavaScript will call the google_ad_request_done function to display
the ads. -->
<script type=""text/javascript"" src=""http://pagead2.googlesyndication.com/pagead/show_ads.js""></script> 
<script type=""text/javascript"">
    (function() {
                (function() {
        FD.addVideoPlayer(new FD.VideoPlayer({
            ""adServerUrl"": ""http://ad-apac.doubleclick.net/pfadx/vid.smh/news/worldnews;channel=news;show=worldnews;ctype=article;cat3=reuters;device=android;sz=4x1,4x2;dcmt=text/html;ord=439831"",
            ""assetId"": ""4531877"",
            ""divId"": ""video-player-content"",
                ""isPlayCountdown"": true,
            ""playerId"": ""video-player-content-player"",
            ""playerType"": ""Article"",
            ""postPlay"": ""Links""
        }, {
            ""height"": 349,
            ""modes"": [{
                ""config"": {
                    ""playlist"": [
    {
                    ""levels"": [
                    {
                        ""bitrate"": ""866"",
                        ""file"": ""http://mediadownload.f2.com.au/flash/media/2013/06/30/4531877/4531877_high.mp4""
                    },
                    {
                        ""bitrate"": ""594"",
                        ""file"": ""http://mediadownload.f2.com.au/flash/media/2013/06/30/4531877/4531877_ihigh.mp4""
                    },
                    {
                        ""bitrate"": ""565"",
                        ""file"": ""http://mediadownload.f2.com.au/flash/media/2013/06/30/4531877/4531877_mid.mp4""
                    },
                    {
                        ""bitrate"": ""564"",
                        ""file"": ""http://mediadownload.f2.com.au/flash/media/2013/06/30/4531877/4531877_low.mp4""
                    },
                    {
                        ""bitrate"": ""400"",
                        ""file"": ""http://mediadownload.f2.com.au/flash/media/2013/06/30/4531877/4531877_imid.mp4""
                    },
                    {
                        ""bitrate"": ""210"",
                        ""file"": ""http://mediadownload.f2.com.au/flash/media/2013/06/30/4531877/4531877_ilow.mp4""
                    }
            ],
            ""image"": ""http://images.smh.com.au/2013/06/30/4531880/vd-Egypt-620x349.jpg"",
        ""title"": ""Egypt braces for mass protests""
    }
]
                },
                ""src"": ""http://resources.smh.com.au/common/media-common-1.0/swf/jwplayer/player.swf"",
                ""type"": ""flash""
            }, {
                ""config"": {
                    ""playlist"": [
    {
                    ""levels"": [
                    {
                        ""bitrate"": ""866"",
                        ""file"": ""http://mediadownload.f2.com.au/flash/media/2013/06/30/4531877/4531877_high.mp4""
                    },
                    {
                        ""bitrate"": ""594"",
                        ""file"": ""http://mediadownload.f2.com.au/flash/media/2013/06/30/4531877/4531877_ihigh.mp4""
                    },
                    {
                        ""bitrate"": ""565"",
                        ""file"": ""http://mediadownload.f2.com.au/flash/media/2013/06/30/4531877/4531877_mid.mp4""
                    },
                    {
                        ""bitrate"": ""564"",
                        ""file"": ""http://mediadownload.f2.com.au/flash/media/2013/06/30/4531877/4531877_low.mp4""
                    },
                    {
                        ""bitrate"": ""400"",
                        ""file"": ""http://mediadownload.f2.com.au/flash/media/2013/06/30/4531877/4531877_imid.mp4""
                    },
                    {
                        ""bitrate"": ""210"",
                        ""file"": ""http://mediadownload.f2.com.au/flash/media/2013/06/30/4531877/4531877_ilow.mp4""
                    }
            ],
            ""image"": ""http://images.smh.com.au/2013/06/30/4531880/vd-Egypt-620x349.jpg"",
        ""title"": ""Egypt braces for mass protests""
    }
]
                },
                ""type"":""html5""
            }],
            ""plugins"": {
    ""googima"": {
    ""ad"": {
                ""ad0"": {
            ""position"": ""pre"",
            ""tag"": ""http://ad-apac.doubleclick.net/pfadx/vid.smh/news/worldnews;channel=news;show=worldnews;ctype=article;cat3=reuters;device=android;sz=4x1,4x2;dcmt=text/html;ord=439831"",
            ""targets"": [""video-player-companion-ad-mrec"", ""video-player-companion-ad-gutter"", ""video-player-companion-ad-helmet""],
            ""type"": ""graphical_full_slot""
        }

        }
    },
    ""timeslidertooltipplugin-2"": {}
},
            ""skin"": ""http://resources.smh.com.au/common/media-common-1.0/swf/jwplayer/nacht.zip"",
            ""width"": 620
        }, {
            ""ga"": {
    ""channel"": ""News"",
    ""duration"": ""091"",
    ""headline"": ""Egypt braces for mass protests"",
    ""referrer"": """",
    ""playerType"": ""Article"",
    ""showName"": ""World News""
}
,
            ""nielsen"": {
    ""brand"": ""smh"",
        ""c6"": ""b17"",
    ""duration"": ""091"",
    ""ou"": ""video/news/world-news"",
    ""vc"": ""vc-smh-Video_News-Article-Video_World_News-The_Age_Selections-Reuters,_Tessa_Stevens-4531877-Egypt_braces_for_mass_protests-00:01:31""
},
            ""cxense"": {
            ""acc"": ""9222289450909506992"",
        ""sid"": ""9222289450909506993"",
        ""contentId"": ""dcds_4531877"",
        ""loc"": ""http://media.smh.com.au/national/selections/egypt-braces-for-mass-protests-4531877.html""
},
            ""collector"": {
    ""system"": ""DCDS"",
    ""brand"": ""smh"",
    ""section"": ""Video News"",
    ""assetId"": ""4531877"",
    ""title"": ""Egypt braces for mass protests"",
    ""assetType"": ""Video"",
    ""assetUrl"": ""http://media.smh.com.au/national/selections/egypt-braces-for-mass-protests-4531877.html""
}
        }));
     })();


    })();
</script>
<script type=""text/javascript"">
    (function() {
                (function() {
        FD.addVideoPlayer(new FD.VideoPlayer({
            ""adServerUrl"": ""http://ad-apac.doubleclick.net/pfadx/vid.smh/news/worldnews;channel=news;show=worldnews;ctype=rhs;cat3=reuters;sz=4x1,4x2;dcmt=text/html;ord=678712"",
            ""assetId"": ""4532073"",
            ""divId"": ""video-player-latest"",
            ""playerId"": ""video-player-latest-player"",
            ""playerType"": ""Article_rhs"",
            ""postPlay"": """"
        }, {
            ""height"": 170,
            ""modes"": [{
                ""config"": {
                    ""playlist"": [
    {
                    ""levels"": [
                    {
                        ""bitrate"": ""827"",
                        ""file"": ""http://mediadownload.f2.com.au/flash/media/2013/06/30/4532073/4532073_high.mp4""
                    },
                    {
                        ""bitrate"": ""571"",
                        ""file"": ""http://mediadownload.f2.com.au/flash/media/2013/06/30/4532073/4532073_ihigh.mp4""
                    },
                    {
                        ""bitrate"": ""542"",
                        ""file"": ""http://mediadownload.f2.com.au/flash/media/2013/06/30/4532073/4532073_mid.mp4""
                    },
                    {
                        ""bitrate"": ""535"",
                        ""file"": ""http://mediadownload.f2.com.au/flash/media/2013/06/30/4532073/4532073_low.mp4""
                    },
                    {
                        ""bitrate"": ""383"",
                        ""file"": ""http://mediadownload.f2.com.au/flash/media/2013/06/30/4532073/4532073_imid.mp4""
                    },
                    {
                        ""bitrate"": ""204"",
                        ""file"": ""http://mediadownload.f2.com.au/flash/media/2013/06/30/4532073/4532073_ilow.mp4""
                    }
            ],
            ""image"": ""http://images.smh.com.au/2013/06/30/4532074/vd-Istanbul-190x107.jpg"",
        ""title"": ""Turkish police shooting sparks protests""
    }
]
                },
                ""src"": ""http://resources.smh.com.au/common/media-common-1.0/swf/jwplayer/player.swf"",
                ""type"": ""flash""
            }, {
                ""config"": {
                    ""playlist"": [
    {
                    ""levels"": [
                    {
                        ""bitrate"": ""827"",
                        ""file"": ""http://mediadownload.f2.com.au/flash/media/2013/06/30/4532073/4532073_high.mp4""
                    },
                    {
                        ""bitrate"": ""571"",
                        ""file"": ""http://mediadownload.f2.com.au/flash/media/2013/06/30/4532073/4532073_ihigh.mp4""
                    },
                    {
                        ""bitrate"": ""542"",
                        ""file"": ""http://mediadownload.f2.com.au/flash/media/2013/06/30/4532073/4532073_mid.mp4""
                    },
                    {
                        ""bitrate"": ""535"",
                        ""file"": ""http://mediadownload.f2.com.au/flash/media/2013/06/30/4532073/4532073_low.mp4""
                    },
                    {
                        ""bitrate"": ""383"",
                        ""file"": ""http://mediadownload.f2.com.au/flash/media/2013/06/30/4532073/4532073_imid.mp4""
                    },
                    {
                        ""bitrate"": ""204"",
                        ""file"": ""http://mediadownload.f2.com.au/flash/media/2013/06/30/4532073/4532073_ilow.mp4""
                    }
            ],
            ""image"": ""http://images.smh.com.au/2013/06/30/4532074/vd-Istanbul-190x107.jpg"",
        ""title"": ""Turkish police shooting sparks protests""
    }
]
                },
                ""type"":""html5""
            }],
            ""plugins"": {
    ""googima"": {
    ""ad"": {
                ""ad0"": {
            ""position"": ""pre"",
            ""tag"": ""http://ad-apac.doubleclick.net/pfadx/vid.smh/news/worldnews;channel=news;show=worldnews;ctype=rhs;cat3=reuters;sz=4x1,4x2;dcmt=text/html;ord=678712"",
            ""targets"": [""video-player-companion-ad-mrec"", ""video-player-companion-ad-gutter"", ""video-player-companion-ad-helmet""],
            ""type"": ""graphical_full_slot""
        }

        }
    },
    ""timeslidertooltipplugin-2"": {}
},
            ""skin"": ""http://resources.smh.com.au/common/media-common-1.0/swf/jwplayer/nacht.zip"",
            ""width"": 300
        }, {
            ""ga"": {
    ""channel"": ""News"",
    ""duration"": ""039"",
    ""headline"": ""Turkish police shooting sparks protests"",
    ""referrer"": """",
    ""playerType"": ""Article_rhs"",
    ""showName"": ""World News""
}
,
            ""nielsen"": {
    ""brand"": ""smh"",
        ""c6"": ""b17"",
    ""duration"": ""039"",
    ""ou"": ""video/news/world-news"",
    ""vc"": ""vc-smh-Video_News-Article_rhs-Video_World_News-Unknown-Reuters,_Tessa_Stevens-4532073-Turkish_police_shooting_sparks_protests-00:00:39""
},
            ""cxense"": {
            ""acc"": ""9222289450909506992"",
        ""sid"": ""9222289450909506993"",
        ""contentId"": ""dcds_4532073"",
        ""loc"": ""http://media.smh.com.au/news/world-news/turkish-police-shooting-sparks-protests-4532073.html""
},
            ""collector"": {
    ""system"": ""DCDS"",
    ""brand"": ""smh"",
    ""section"": ""Video News"",
    ""assetId"": ""4532073"",
    ""title"": ""Turkish police shooting sparks protests"",
    ""assetType"": ""Video"",
    ""assetUrl"": ""http://media.smh.com.au/news/world-news/turkish-police-shooting-sparks-protests-4532073.html""
}
        }));
     })();


    })();
</script>
<script type=""text/javascript"">
if(document.location.protocol=='http:'){
 var Tynt=Tynt||[];Tynt.push('aBfWCmwwCr37XTadbiUzgI');
 (function(){var s=document.createElement('script');s.async=""async"";s.type=""text/javascript"";s.src='http://tcr.tynt.com/ti.js';var h=document.getElementsByTagName('script')[0];h.parentNode.insertBefore(s,h);})();
}
</script>

<script type=""text/javascript"">
    if (window[""FD""]) {
        (function() {
            // Check that the user is at least logged in before attempting to say that they have read an article.
            if (FD.isLoggedIn()) {
                FD.trigger(""FDArticleRead"");
            } else {
                FD.trigger(""FDMyMastheadAccountLoginPrompt"");
            }
        })();
    }
</script>
<script type=""text/javascript"">
    if (document.googleMapConfiguration) {
        document.write(""<script src='http://maps.googleapis.com/maps/api/js?client=gme-fairfax&sensor=false&channel=smhcomau' type='text/javascript'><\/script>"");
    }
</script>
        <script type=""text/javascript"" src=""http://resources.smh.com.au/common/media-common-1.0/js/fdjsf/output/7.24.6/fd.registrars.googlemap_min.js""></script>

<div class=""hidden"" id=""adShD0""> <script type=""text/javascript""> if (0 < document.dcdAdsU.length) { document.write('<scr' + 'ipt type=""text\/javascript"" id=""' + document.dcdAdsI[0] + '"" src=""' + document.dcdAdsU[0] + '""><\/scr' + 'ipt>'); } </script> </div> <div class=""hidden"" id=""adShD1""> <script type=""text/javascript""> if (1 < document.dcdAdsU.length) { document.write('<scr' + 'ipt type=""text\/javascript"" id=""' + document.dcdAdsI[1] + '"" src=""' + document.dcdAdsU[1] + '""><\/scr' + 'ipt>'); } </script> </div> <div class=""hidden"" id=""adShD2""> <script type=""text/javascript""> if (2 < document.dcdAdsU.length) { document.write('<scr' + 'ipt type=""text\/javascript"" id=""' + document.dcdAdsI[2] + '"" src=""' + document.dcdAdsU[2] + '""><\/scr' + 'ipt>'); } </script> </div> <div class=""hidden"" id=""adShD3""> <script type=""text/javascript""> if (3 < document.dcdAdsU.length) { document.write('<scr' + 'ipt type=""text\/javascript"" id=""' + document.dcdAdsI[3] + '"" src=""' + document.dcdAdsU[3] + '""><\/scr' + 'ipt>'); } </script> </div> <div class=""hidden"" id=""adShD4""> <script type=""text/javascript""> if (4 < document.dcdAdsU.length) { document.write('<scr' + 'ipt type=""text\/javascript"" id=""' + document.dcdAdsI[4] + '"" src=""' + document.dcdAdsU[4] + '""><\/scr' + 'ipt>'); } </script> </div> <div class=""hidden"" id=""adShD5""> <script type=""text/javascript""> if (5 < document.dcdAdsU.length) { document.write('<scr' + 'ipt type=""text\/javascript"" id=""' + document.dcdAdsI[5] + '"" src=""' + document.dcdAdsU[5] + '""><\/scr' + 'ipt>'); } </script> </div> <script type=""text/javascript""> initAds(false); checkAds(""817-grey.gif""); window.setTimeout('pingAdStatus()', 10000); </script>

<!-- START Google Analytics Tracking -->
<script type=""text/javascript"">
    var _gaq = _gaq || [];
    _gaq.push(['_setAccount', 'UA-22700242-1']);
    _gaq.push(['_setDomainName', '.smh.com.au']);
    _gaq.push(['_addIgnoredRef', 'smh.com.au']);
    _gaq.push(['_setAllowAnchor', true]);
    _gaq.push(['_setCustomVar', 1, 'Section', 'World', 3]);
    _gaq.push(['_setCustomVar', 2, 'Sub-Section', '', 3]);
    _gaq.push(['_setCustomVar', 3, 'Byline', 'Jailan Zayan', 3]);
    _gaq.push(['_setCustomVar', 4, 'Page Type', 'Article', 3]);
    _gaq.push(['_setAllowAnchor', true]);
    _gaq.push(['_setCampaignCookieTimeout', 1209600000]);
    // Check whether the user is logged in.
    var loggedIn = false;
    if (window[""FD""]) {
        loggedIn = FD.isLoggedIn();
    }
    if (loggedIn) {
        _gaq.push(['_setCustomVar', 5, 'Login Status', 'Logged In', 2]);
    } else {
        _gaq.push(['_setCustomVar', 5, 'Login Status', ' ', 2]);
    }
    _gaq.push(['_trackPageview']);
    (function() {
        var ga = document.createElement('script');
        ga.type = 'text/javascript';
        ga.async = true;
        ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
        var s = document.getElementsByTagName('script')[0];
        s.parentNode.insertBefore(ga, s);
    })();
</script>
<!-- END Google Analytics Tracking -->

<!-- START Nielsen Online SiteCensus V6.0 -->
<!-- COPYRIGHT 2009 Nielsen Online -->
<script type=""text/javascript"" src=""//secure-au.imrworldwide.com/v60.js""></script>
<script type=""text/javascript"">
    var pvar = {cid:""f2"", content:""SMH-world-story-print"", server:""secure-au""};
    var trac = nol_t(pvar);
    trac.record().post();
    window.s_pageName = ""smh:article:world:egypt on edge as mursi, critics face off"";
</script>
<noscript>
    <div>
        <img src=""//secure-au.imrworldwide.com/cgi-bin/m?ci=f2&amp;cg=0&amp;cc=1&amp;ts=noscript"" width=""1"" height=""1"" alt=""""/>
    </div>
</noscript>
    <!--end of if !suppressNielsen -->
<!-- END Nielsen Online SiteCensus V6.0 -->
    <script type=""text/javascript"">
	if (window[""FD""]) {
		/**
		 * Initiates the client side asset view tracking component (self executing).
		 */
		(function() {
			FD.pingServerWithSuccessCallback(""4532433"", ""Article"", ""World"", FD.updateWhiteStrip);
		})();
	}
</script>

<!-- FFX analytics stuff -->
<script>
    var _fmaq = _fmaq || [];
        _fmaq.push([""_trackEvent"", [
            [""event"", ""view""],
            [""system"", ""DCDS""],
            [""site"", ""smh""],
            [""assetCategory"", ""World""],
            [""asset"", ""4532433""],
            [""title"", ""Egypt on edge as Mursi, critics face off""],
            [""assetType"", ""Article""]
        ]]);

    var _fma_options = {};

    (function () {
        var fma_script = document.createElement('script');
        fma_script.src = 'http://resources.fairfax.com.au/js/track/1.0/track.min.js';
        fma_script.setAttribute('async', 'true');
        var s = document.getElementsByTagName('script')[0];
        s.parentNode.insertBefore(fma_script, s);
    })();
</script>
    <script type=""text/javascript"">
        var cX_ffx_customParameters = cX_ffx_customParameters || {};
        cX_ffx_customParameters.ffx_contentid = 'dcds_4532433';
    </script>
    <div id=""cX-root"" style=""display:none""></div>
    <script type=""text/javascript"">
        var cX = cX || {}; cX.callQueue = cX.callQueue || [];
        cX.callQueue.push(['setAccountId', '9222289450909506992']);
        cX.callQueue.push(['setSiteId', '9222289450909506993']);
        if (cX_ffx_customParameters) {
            cX.callQueue.push(['setCustomParameters', cX_ffx_customParameters]);
        }
        cX.callQueue.push(['sendPageViewEvent']);
    </script>
    <script type=""text/javascript"">
        (function() { try { var scriptEl = document.createElement('script'); scriptEl.type = 'text/javascript'; scriptEl.async = 'async';
            scriptEl.src = ('https:' == document.location.protocol) ? 'https://scdn.cxense.com/cx.js' : 'http://cdn.cxense.com/cx.js';
            var targetEl = document.getElementsByTagName('script')[0]; targetEl.parentNode.insertBefore(scriptEl, targetEl); } catch (e) {};} ());
    </script>


<!-- Adobe Marketing Cloud Tag Management code
Copyright 1996-2012 Adobe, Inc. All Rights Reserved
More info available at http://www.adobe.com -->
<script type=""text/javascript"" src=""http://resources.smh.com.au/common/media-common-1.0/js/s_code.js""></script>
<script type=""text/javascript"">
if(s && !(window[""FD""] && FD.isRefreshedHomepage())){
    s.pageName = ""smh:World:::Egypt on edge as Mursi, critics face off:4532433""
    s.prop1 = ""smh""
    s.prop2 = ""World""
    s.prop7 = ""Article""
    s.prop8 = ""4532433 + Egypt on edge as Mursi, critics face off""
    s.prop31 = ""Jailan Zayan""
    s.prop32 = ""2013-07-01""
    if (window[""FD""]) {
        if (typeof FD.s_prop24 !== ""undefined"") {
            s.prop24 = FD.s_prop24
        }
    }
    s.t()
}
</script>
<!-- End Adobe Marketing Cloud Tag Management code -->


<!-- Google Code for Remarketing tag -->
<!-- Remarketing tags may not be associated with personally identifiable information or placed on pages related to sensitive categories. For instructions on adding this tag and more information on the above requirements, read the setup guide: google.com/ads/remarketingsetup -->
<script type=""text/javascript"">
/* <![CDATA[ */
var google_conversion_id = '1024966411';
var google_conversion_label = '8BTjCLXqgAQQi_7e6AM';
var google_custom_params = window.google_tag_params;
var google_remarketing_only = true;
/* ]]> */
</script>
<script type=""text/javascript"" src=""http://www.googleadservices.com/pagead/conversion.js"">
</script>
<noscript>
<div style=""display:inline;"">
<img height=""1"" width=""1"" style=""border-style:none;"" alt="""" src=""http://googleads.g.doubleclick.net/pagead/viewthroughconversion/1024966411/?value=0&label=8BTjCLXqgAQQi_7e6AM&guid=ON&script=0""/>
</div>
</noscript>
<!-- End Google Code for Remarketing tag -->
<script type=""text/javascript"">
if (window[""FD""]) {
    FD.trigger(""FDTrackReady"");
}
</script>
    <script type=""text/javascript"" src=""http://widgets.outbrain.com/outbrain.js""></script>

        <div id=""fb-root""></div><!-- id:fb-root -->
        <script src=""http://connect.facebook.net/en_US/all.js"" type=""text/javascript""></script>
        <script type=""text/javascript"">
            window.fbAsyncInit = function() {
                FB.init({
                        appId: ""193677504039845"",
                    cookie: true,
                    status: true,
                    xfbml: true
                });
                FD.register(function() {
                    new FD.Facebook({});
                });
            };
        </script>
        <script src=""https://apis.google.com/js/plusone.js"" type=""text/javascript""></script>
        <script src=""http://platform.linkedin.com/in.js"" type=""text/javascript"">
                api_key: 9av1epdechow
            authorize: true
        </script>
        <script src=""http://platform.twitter.com/widgets.js"" type=""text/javascript""></script>
        <script src=""http://widgets.twimg.com/j/2/widget.js"" type=""text/javascript""></script>
    <div data-boomerangSegment=""132487""></div>
        <script type=""text/javascript"" src=""http://resources.smh.com.au/common/media-common-1.0/js/fdjsf/output/7.24.6/fd.registrars.social_min.js""></script>



 

        <script type=""text/javascript"" src=""http://resources.smh.com.au/common/media-common-1.0/js/fdjsf/output/7.24.6/fd.registrars.images.httppipelining_min.js""></script>

</body>
</html>";
            }
        }
    }
}
