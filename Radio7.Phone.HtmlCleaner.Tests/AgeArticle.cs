using HtmlAgilityPack;

namespace Radio7.Phone.HtmlCleaner.Tests
{
    public static class AgeArticle
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
<!--[if lte IE 7]> <html xmlns:fb=\'http://www.facebook.com/2008/fbml\' xmlns:og=\'http://opengraphprotocol.org/schema/\' class=\'ie7 lte8 lte9 \' lang=\'en-au\'> <![endif]-->
<!--[if IE 8]> <html xmlns:fb=\'http://www.facebook.com/2008/fbml\' xmlns:og=\'http://opengraphprotocol.org/schema/\' class=\'ie8 lte8 lte9 \' lang=\'en-au\'> <![endif]-->
<!--[if IE 9]> <html xmlns:fb=\'http://www.facebook.com/2008/fbml\' xmlns:og=\'http://opengraphprotocol.org/schema/\' class=\'ie9 lte9 \' lang=\'en-au\'> <![endif]-->
<!--[if gt IE 9]> --> <html lang=\'en-au\' class=\'\'> <!--<![endif]-->
<head>
        <script type=\'text/javascript\'>
        var mDomains = [\'smh.com.au\', \'theage.com.au\', \'watoday.com.au\', \'brisbanetimes.com.au\', \'canberratimes.com.au\',
            \'essentialkids.com.au\', \'essentialbaby.com.au\', \'dailylife.com.au\', \'businessday.com.au\',\'goodfood.com.au\']
        if (exists(mDomains, function(substring) {return contains(document.domain, substring)})
                && isSmartPhone(navigator.userAgent) && !contains(document.cookie, \'iphone_redirect=false\')) {
            var currentLocation = document.location.href;
            if (!contains(currentLocation, \'/lifestyle/cuisine\')) {
                if (contains(currentLocation, \'www.\')) {
                    currentLocation = currentLocation.replace(\'www.\', \'m.\');
                    window.location = currentLocation;
                }
                if (contains(currentLocation, \'media.\')) {
                    currentLocation = currentLocation.replace(\'media.\', \'m.media.\');
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
            var smartPhoneUserAgentRegularExpressions = [\'^Mozilla/5.0.*iPhone.*\', \'^Mozilla/5.0.*iPod.*\',
                \'^Mozilla/5.0.*Android [1-3].*\', \'^Mozilla/5.0.*SymbianOS/9.*\', \'^Mozilla/5.0.*Symbian/3.*\',
                \'^Mozilla/5.0.*Mobile Safari/.*5[2-3][0-9].*\', \'.*Dolfin/[1-2].[0-9].*\', \'^Mozilla/[4-5].0.*Windows Phone OS 7.[0-5].*\', \'^Opera/9.*Android; Opera Mini.*\'];
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
            var tableUserAgentRegularExpressions = [\'^Mozilla/5.0.*iPad.*\', \'^Mozilla/5.0.*GT-P1000.*\',
                \'^Mozilla/5.0.*GT-P7500.*\', \'^Mozilla/5.0.*MZ601.*\', \'^Mozilla/5.0.*Transformer TF101.*\'];
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

    <title>Girl, 17, dies in southeast Queensland crash</title>
    <meta http-equiv=\'X-UA-Compatible\' content=\'IE=edge,chrome=1\'>
<meta http-equiv=\'content-language\' content=\'en\' />
<meta http-equiv=\'imagetoolbar\' content=\'no\' />
    <link rel=\'canonical\' href=\'http://www.brisbanetimes.com.au/queensland/girl-17-dies-in-southeast-queensland-crash-20130629-2p3k3.html\'/>
<meta name=\'robots\' content=\'noarchive,noodp\' />
<meta name=\'robots\' content=\'ACAP allow-index\' />
<meta name=\'robots\' content=\'ACAP allow-follow\' />
<meta name=\'robots\' content=\'ACAP disallow-preserve\' />
<meta name=\'robots\' content=\'ACAP allow-present prohibited-modification=annotation\' />
<meta name=\'description\' content=\'\' />
<meta name=\'keywords\' content=\'\' />

<link rel=\'shortcut icon\' type=\'image/ico\' href=\'http://www.brisbanetimes.com.au/favicon.ico\' />
<meta name=\'application-name\' content=\'Brisbane Times\' />
<meta name=\'msapplication-tooltip\' content=\'Open Brisbane Times\' />
<meta name=\'msapplication-starturl\' content=\'http://www.brisbanetimes.com.au\' />

    <meta name=\'msapplication-task\' content=\'name=National;action-uri=http://www.brisbanetimes.com.au/national;icon-uri=http://www.brisbanetimes.com.au/favicon.ico;\' />
    <meta name=\'msapplication-task\' content=\'name=World;action-uri=http://www.brisbanetimes.com.au/world;icon-uri=http://www.brisbanetimes.com.au/favicon.ico;\' />
    <meta name=\'msapplication-task\' content=\'name=Sport;action-uri=http://www.brisbanetimes.com.au/sport;icon-uri=http://www.brisbanetimes.com.au/favicon.ico;\' />
    <meta name=\'msapplication-task\' content=\'name=Weather;action-uri=http://www.brisbanetimes.com.au/weather;icon-uri=http://www.brisbanetimes.com.au/favicon.ico;\' />

<meta name=\'cXenseParse:ffx-assetid\' content=\'4530243\'/>
<meta name=\'cXenseParse:ffx-assettype\' content=\'article\'/>





        <meta name=\'twitter:card\' content=\'summary\'>
    <meta name=\'twitter:site\' content=\'@brisbanetimes\'>

    <meta property=\'og:title\' content=\'Girl, 17, dies in southeast Queensland crash\'/>
<meta property=\'og:description\' content=\'A 17-year-old girl has died after the car she was driving crashed head-on into a four-wheel-drive carrying six people near Gympie in south-east Queensland.\'/>
<meta property=\'og:site_name\' content=\'Brisbane Times\'/>
<meta property=\'og:type\' content=\'article\'/> 
<meta property=\'og:url\' content=\'http://www.brisbanetimes.com.au/queensland/girl-17-dies-in-southeast-queensland-crash-20130629-2p3k3.html\'/>
<meta property=\'og:image\' content=\'http://images.brisbanetimes.com.au/2011/08/09/2545353/facebook-thumb-brisbanetimes.png\'/>
    <meta property=\'fb:app_id\' content=\'210857855632030\'/>

                <link rel=\'stylesheet\' type=\'text/css\' media=\'screen,print\' href=\'http://resources.brisbanetimes.com.au/common/media-common-1.0/css/output/7.24.6/common.skin.news_min.css\' />

                    <link rel=\'stylesheet\' type=\'text/css\' media=\'screen,print\' href=\'http://resources.brisbanetimes.com.au/common/media-common-1.0/css/output/7.24.6/common.skin.article_min.css\' />

                    <link rel=\'stylesheet\' type=\'text/css\' media=\'screen,print\' href=\'http://resources.brisbanetimes.com.au/common/media-common-1.0/css/output/7.24.6/common.skin.brisbanetimes_min.css\' />

                <link rel=\'stylesheet\' type=\'text/css\' media=\'screen,print\' href=\'http://resources.brisbanetimes.com.au/common/media-common-1.0/css/output/7.24.6/common.skin.queensland_min.css\' />

                <link rel=\'stylesheet\' type=\'text/css\' media=\'screen,print\' href=\'http://resources.brisbanetimes.com.au/common/media-common-1.0/css/output/7.24.6/skin.promotions_min.css\' />

                <link rel=\'stylesheet\' type=\'text/css\' media=\'screen,print\' href=\'http://resources.brisbanetimes.com.au/common/media-common-1.0/css/output/7.24.6/common.skin.mysite_min.css\' />


<!-- Initialise Google Analytics event queue -->
<script type=\'text/javascript\'>
    var _gaq = _gaq || [];
</script>
    
    <link rel=\'shortcut icon\' href=\'http://www.brisbanetimes.com.au/favicon.ico\'/>
</head>
<body class=\'brisbanetimes queensland\' >
<script type=\'text/javascript\'>
// <![CDATA[
	document.body.className += \' scriptable\';
// ]]>
</script>

<a class=\'skipLink\' href=\'#nav\'>Skip to navigation</a>
<a class=\'skipLink\' href=\'#content\'>Skip to content</a>
<a class=\'skipLink\' href=\'http://www.brisbanetimes.com.au/siteguide/accessibility\'>Help using this website - Accessibility statement</a>

        <esi:include src=\'/ugc/v2/dock.html\'/>
        <esi:remove><div class=\'mySite\' role=\'document\' aria-live=\'polite\' aria-relevant=\'additions removals\' aria-atomic=\'true\'>
    <div class=\'ms-toolbarWrap\'>
        <div class=\'ms-toolbar clearfix\'>
            <p class=\'hiddenWithJS alert\'><em>JavaScript disabled.</em> Please enable JavaScript to use My News, My Clippings, My Comments and user settings.</p>
<ul class=\'inactive\'>
    <li class=\'account login\'>
        <a href=\'https://brisbanetimes.myfairfax.com.au/members/session/new?channel_key=adsyxa3LYCxmhcrx-DmA7w&callback_uri=http%3A%2F%2Fwww.brisbanetimes.com.au%2Fugc%2Flogin.html\' title=\'My News\'><span class=\'icon news\'></span>My News </a>
    </li>
    <li class=\'account login\'>
        <a href=\'https://brisbanetimes.myfairfax.com.au/members/session/new?channel_key=adsyxa3LYCxmhcrx-DmA7w&callback_uri=http%3A%2F%2Fwww.brisbanetimes.com.au%2Fugc%2Flogin.html\' title=\'My Clippings\'><span class=\'icon clippings\'></span>My Clippings </a>
    </li>
    <li class=\'account login\'>
        <a href=\'https://brisbanetimes.myfairfax.com.au/members/session/new?channel_key=adsyxa3LYCxmhcrx-DmA7w&callback_uri=http%3A%2F%2Fwww.brisbanetimes.com.au%2Fugc%2Flogin.html\' title=\'My Comments\'><span class=\'icon comments\'></span>My Comments </a>
    </li>
    <li class=\'account login\'>
        <a href=\'https://brisbanetimes.myfairfax.com.au/members/session/new?channel_key=adsyxa3LYCxmhcrx-DmA7w&callback_uri=http%3A%2F%2Fwww.brisbanetimes.com.au%2Fugc%2Flogin.html\' title=\'My History\'><span class=\'icon history\'></span>My History </a>
    </li>
</ul>

<ul class=\'alt\'>
    <li class=\'account\'>
        <a class=\'btn alt gaTrackable\' href=\'https://brisbanetimes.myfairfax.com.au/members/members/signup?channel_key=adsyxa3LYCxmhcrx-DmA7w&callback_uri=http%3A%2F%2Fwww.brisbanetimes.com.au%2Fugc%2Flogin.html\' data-gaaction=\'Sign-up\' data-gacategory=\'MyMasthead\' data-galabel=\'Dock Bar\'>Sign-up</a>
    </li>
    <li class=\'account login\'>
        <a class=\'btn gaTrackable\' href=\'https://brisbanetimes.myfairfax.com.au/members/session/new?channel_key=adsyxa3LYCxmhcrx-DmA7w&callback_uri=http%3A%2F%2Fwww.brisbanetimes.com.au%2Fugc%2Flogin.html\' data-gaaction=\'Login\' data-gacategory=\'MyMasthead\' data-galabel=\'Dock Bar\'>Log in</a>
    </li>
        <li class=\'account last demo\'>
            <a class=\'btn\' href=\'http://www.brisbanetimes.com.au/static/mymastheads/\' target=\'_blank\' id=\'demo-btn\'>Learn More</a>
            <div class=\'demo-tooltip\'>
                <p>Personalise your news, save articles to read later and customise settings</p>
            </div>
        </li>
</ul>
<div id=\'ms-dialogLogin\' class=\'dialogWrap hiddenVisually\'>
    <div class=\'dialogContent main\' id=\'loginIframeContainer\' style=\'width: 625px; height: 425px\' data-dialogHref=\'https://brisbanetimes.myfairfax.com.au/members/session/dialog?channel_key=adsyxa3LYCxmhcrx-DmA7w&callback_uri=http%3A%2F%2Fwww.brisbanetimes.com.au%2Fugc%2Flogin.html\'>
        <p class=\'hiddenVisually\'>If you have trouble accessing our login form below, you can go to our <a href=\'https://brisbanetimes.myfairfax.com.au/members/session/new?channel_key=adsyxa3LYCxmhcrx-DmA7w&callback_uri=http%3A%2F%2Fwww.brisbanetimes.com.au%2Fugc%2Flogin.html\' title=\'This link will open in a new window\' target=\'_parent\'>login page</a>.</p>
    </div>
</div>    <div id=\'ms-dialogLoginPrompt\' class=\'dialogWrap hiddenVisually\'>
        <div class=\'dialogContent main\'>
            <p class=\'hiddenVisually\'>If you have trouble accessing our login form below, you can go to our <a href=\'https://brisbanetimes.myfairfax.com.au/members/session/new?channel_key=adsyxa3LYCxmhcrx-DmA7w&callback_uri=http%3A%2F%2Fwww.brisbanetimes.com.au%2Fugc%2Flogin.html\' title=\'This link will open in a new window\' target=\'_parent\'>login page</a>.</p>
            <iframe id=\'loginPromptIframe\' width=\'625\' height=\'425\' frameborder=\'0\' scrolling=\'no\' src=\'\' data-dialogHref=\'https://brisbanetimes.myfairfax.com.au/members/session/dialog?skin=prompt&channel_key=adsyxa3LYCxmhcrx-DmA7w&callback_uri=http%3A%2F%2Fwww.brisbanetimes.com.au%2Fugc%2Flogin.html\'></iframe>
        </div>
    </div>
        </div>
    </div>
</div></esi:remove>
    <div data-brandTimezone=\'Australia/Brisbane\'></div>



<div id=\'sponsorLink_cA-helmet\' class=\'cA-helmet\'>
    <div id=\'video-player-companion-ad-helmet\'></div><!-- id:video-player-companion-ad-helmet -->
</div><!-- id:sponsorLink_cA-helmet -->
<script type=\'text/javascript\' src=\'http://resources.brisbanetimes.com.au/common/media-common-1.0/js/html5shiv.js\'></script>
<div class=\'outerWrap\'>
    <div class=\'wrap cfix\'>
        

<!-- Header (class according to new HTML5 element 'header'; was 'masthead') (scope: network-wide) -->
<div class=\'header span-24\'>
            <div id=\'adspot-728x90,468x60-pos-1\' class=\'ad\'> <script type=\'text/javascript\'> function getAdCookie(name) { var regex = new RegExp('(?:^|; )' + name + '=([^;]*)'); var value = regex.exec(document.cookie); if (value && value.length > 1) { value = decodeURIComponent(value[1]); } else { value = \'\'; } return value; } function getFrameDocument(fr) { var doc = fr.contentWindow || fr.contentDocument; if (doc && doc.document) { doc = doc.document; } return doc; } function closeDoc(doc) { doc.close(); } function closeOpenDocuments(openDocs) { for (var i=0;i< openDocs.length; i++) { closeDoc(getFrameDocument(document.getElementById(openDocs[i]))); } } function isIE() { return /msie/i.test(navigator.userAgent) && !/opera/i.test(navigator.userAgent); } function setHash (element, hash) { if(element.hash) { element.hash = element.hash + \',\' + hash; } else { element.hash = hash; } } function renderIFAd(holderID, adID, srcUrl, width, height, hash, bodyAttributes) { setHash(document.getElementById(holderID), hash); document.dcdAdsR.push(adID); if (ie) { var sizePart = srcUrl.substring(srcUrl.indexOf(\'sz=\')+3); sizePart = sizePart.substring(0, sizePart.indexOf(\';\')); var multiSizes = sizePart.split(\',\'); var minSize = multiSizes[0]; if (multiSizes.length > 1) { for(var i=1; i< multiSizes.length; i++) { if (minSize > multiSizes[i]) { minSize = multiSizes[i]; } } var sizeParts = minSize.toLowerCase().split(\'x\'); width = sizeParts[0]; height = sizeParts[1]; srcUrl = srcUrl.replace(sizePart, minSize); } } document.write('<iframe id=\'' + adID + '\' src=\'' + srcUrl + '\' width=\'' + width + '\' height=\'' + height + '\' scrolling=\'no\' marginheight=\'0\' marginwidth=\'0\' allowtransparency=\'true\' frameborder=\'0\'><\/iframe>'); } function renderJIFAd(holderID, adID, srcUrl, width, height, hash, bodyAttributes) { setHash(document.getElementById(holderID), hash); document.dcdAdsR.push(adID); document.write('<iframe id=\'' + adID + '\' src=\'javascript: ;\' width=\'' + width + '\' height=\'' + height + '\' scrolling=\'no\' marginheight=\'0\' marginwidth=\'0\' allowtransparency=\'true\' frameborder=\'0\'><\/iframe>'); var body = '<html><head></head><body ' + bodyAttributes + '><scr' + 'ipt src=\'' + srcUrl + '\'></sc' + 'ript></body></html>'; var fr = document.getElementById(adID); setHash(fr, hash); fr.body = body; var doc = getFrameDocument(fr); doc.open(); doc.write(body); setTimeout(function() {closeDoc(getFrameDocument(document.getElementById(adID)))}, 2000); } function renderJIFAdWithInterim(holderID, adID, srcUrl, width, height, hash, bodyAttributes) { setHash(document.getElementById(holderID), hash); document.dcdAdsR.push(adID); document.write('<iframe id=\'' + adID + '\' src=\' '+ srcUrl +'\' width=\'' + width + '\' height=\'' + height + '\' scrolling=\'no\' marginheight=\'0\' marginwidth=\'0\' allowtransparency=\'true\' frameborder=\'0\'><\/iframe>'); } function renderIJAd(holderID, adID, srcUrl, hash) { document.dcdAdsAA.push(holderID); setHash(document.getElementById(holderID), hash); document.write('<scr' + 'ipt src=\'' + srcUrl + '\' id=\'' + adID + '\'></sc' + 'ript>'); } function renderJAd(holderID, adID, srcUrl, hash) { document.dcdAdsAA.push(holderID); setHash(document.getElementById(holderID), hash); document.dcdAdsH.push(holderID); document.dcdAdsI.push(adID); document.dcdAdsU.push(srcUrl); } function er_showAd() { var regex = new RegExp(\'externalReferrer=(.*?)(; |&|$)\', \'gi\'); var value = regex.exec(document.cookie); if (value && value.length == 3) { var externalReferrer = value[1]; return (!FD.isInternalReferrer() || ((externalReferrer) && (externalReferrer > 0))); } return false; } function isHome() { var loc = \'\' + window.location; loc = loc.replace(\'//\', \'\'); var tokens = loc.split(\'/\'); if (tokens.length == 1) { return true; } else if (tokens.length == 2) { if (tokens[1].trim().length == 0) { return true; } } return false; } function checkAds(checkStrings) { var cs = checkStrings.split(\',\'); for (var i=0;i< document.dcdAdsAA.length; i++) { var cAd = document.getElementById(document.dcdAdsAA[i]); document.dcdAdsAG.push(cAd.hash); for (var j=0; j<cs.length; j++) { var c = cs[j].trim(); if (c.length > 0 && cAd.innerHTML.indexOf(c)>0) { document.dcdAdsAI.push(cAd.hash); cAd.style.display ='none'; } } } if (!ie) { for (var i=0;i< document.dcdAdsR.length; i++) { var fr = document.getElementById(document.dcdAdsR[i]); if (fr) { document.dcdAdsAG.push(fr.hash); var doc = getFrameDocument(fr); for (var j=0; j<cs.length; j++) { var c = cs[j].trim(); if (c.length > 0 && doc.body.innerHTML.indexOf(c)>0) { document.dcdAdsAI.push(fr.hash); fr.style.display ='none'; } } } } } if (document.dcdAdsAI.length > 0 || document.dcdAdsAG.length > 0) { var pingServerParams = \'i=\'; var sep = \'\'; for (var i=0;i< document.dcdAdsAI.length; i++) { pingServerParams += sep + document.dcdAdsAI[i]; sep = \',\'; } } document.pingServerAdParams = pingServerParams; } function pingAdStatus() { if (isHome ()) { return; } if (document.pingServerAdParams && document.pingServerAdParams.length > 0) { var pingServerUrl = \'/action/pingServerAction?\' + document.pingServerAdParams; var xmlHttp = null; try { xmlHttp = new XMLHttpRequest(); } catch(e) { try { xmlHttp = new ActiveXObject(\'Microsoft.XMLHttp\'); } catch(e) { xmlHttp = null; } } if (xmlHttp != null) { xmlHttp.open( \'GET\', pingServerUrl, true); xmlHttp.send( null ); } } } function initAds(log) { for (var i=0;i< document.dcdAdsU.length; i++) { var shadowHolder = document.getElementById(\'adShD\' + i); var targetHolder = document.getElementById(document.dcdAdsH[i]); if (shadowHolder && targetHolder) { var adNodes = new Array(); for (var j=0; j<shadowHolder.childNodes.length; j++) { var child = shadowHolder.childNodes[j]; if (child.nodeName.toLowerCase() != \'script\') { adNodes.push(child); } } for (var j=0; j<adNodes.length; j++) { targetHolder.appendChild(shadowHolder.removeChild(adNodes[j])); } } } if (er_showAd()) { for (var i=0;i< document.dcdAdsE.length; i++) { var erAd = document.getElementById(document.dcdAdsEH[i]); erAd.className = document.dcdAdsEC[i]; erAd.appendChild(document.dcdAdsE[i]); } } if (log) { console.log(document.igCount + \'/\' + document.tCount); } } function isInterimEnable(frame){ var iFrame_src = frame.src; var interim = iFrame_src.indexOf(\'adinterim\'); if(interim < 0 ){ return false; }else{ return true; } } function getCurrentOrd(srcurl){ var currentOrg = \'\'; currentOrg = srcurl.split(\'ord=\')[1]; if(currentOrg.indexOf(\'?\') < 0){ return currentOrg }else{ return currentOrg.split(\'?\')[0]; } } document.refreshAds = function rAds(adID) { if (document.dcdAdsR) { document.dcdsAdsToClose = new Array(); for (var i=0;i< document.dcdAdsR.length; i++) { var fr = document.getElementById(document.dcdAdsR[i]); if (fr) { if (!ie && !isInterimEnable(fr)) { if (!adID || adID ==\'*\' || fr.parentNode.id==adID ) { var chNodes = new Array(); for (var j=0; j<fr.parentNode.childNodes.length; j++) { var child = fr.parentNode.childNodes[j]; if (!(child.nodeName.toLowerCase() == \'script\' || child.nodeName.toLowerCase() == \'iframe\') || child.nodeName.toLowerCase() == \'small\') { chNodes.push(child); } } for (var j=0; j<chNodes.length; j++) { if (!child.nodeName.toLowerCase() == \'small\') { chNodes[j].parentNode.removeChild(chNodes[j]); } } var doc = getFrameDocument(fr); while (doc.childNodes.length > 0) { doc.removeChild(doc.childNodes[0]); } doc.open(); var newBody = fr.body; if (getCurrentOrd(newBody) != \'\' ) { newBody = newBody.replace(\';ord=\'+getCurrentOrd(newBody), \';ord=\' + Math.floor(100000000*Math.random())); } else { newBody = newBody.replace(\';ord=\', \';ord=\' + Math.floor(100000000*Math.random())); } doc.write(newBody); document.dcdsAdsToClose.push(fr.id); } } else { var newSrc = fr.src; if (getCurrentOrd(newSrc) != \'\' ) { newSrc = newSrc.replace(\';ord=\'+getCurrentOrd(newSrc), \';ord=\' + Math.floor(100000000*Math.random())); } else { newSrc = newSrc.replace(\';ord=\', \';ord=\' + Math.floor(100000000*Math.random())); } fr.src = newSrc; } } } if (document.dcdsAdsToClose.length > 0) { setTimeout(function() {closeOpenDocuments(document.dcdsAdsToClose)}, 500); } } }; var ie = isIE(); if(ie && typeof String.prototype.trim !== 'function') { String.prototype.trim = function() { return this.replace(/^\s+|\s+$/g, ''); }; } document.dcdAdsH = new Array(); document.dcdAdsI = new Array(); document.dcdAdsU = new Array(); document.dcdAdsR = new Array(); document.dcdAdsEH = new Array(); document.dcdAdsE = new Array(); document.dcdAdsEC = new Array(); document.dcdAdsAA = new Array(); document.dcdAdsAI = new Array(); document.dcdAdsAG = new Array(); document.dcdAdsToClose = new Array(); document.igCount = 0; document.tCount = 0; var dcOrd = Math.floor(100000000*Math.random()); document.dcAdsCParams = \'\'; var savValue = getAdCookie(\'sav\'); if (savValue != null && savValue.length > 2) { document.dcAdsCParams = savValue + \';\'; } </script> <script> renderJAd(\'adspot-728x90,468x60-pos-1\', \'dcAd-1\', 'http://ad-apac.doubleclick.net/adj/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;pos=1;dcopt=ist;' + document.dcAdsCParams +'sz=728x90,468x60;tile=1;ord=' + dcOrd + '?', 1575876716); </script> <noscript> <a href='http://ad-apac.doubleclick.net/jump/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;pos=1;dcopt=ist;sz=728x90,468x60;tile=1;ord=6.029626E7?' target=\'_blank\'> <img src='http://ad-apac.doubleclick.net/ad/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;pos=1;dcopt=ist;sz=728x90,468x60;tile=1;ord=6.029626E7?' border=\'0\' alt=\'\'> </a> </noscript> </div>


    <p class=\'mh-logo\'><a href=\'http://www.brisbanetimes.com.au\' title=\'Brisbane Times\'>Brisbane Times</a></p>
            <h2><a href=\'http://www.brisbanetimes.com.au/queensland\' title=\'Queensland\'>Queensland</a></h2>
        <ul id=\'nav\' role=\'navigation\' >
        
                <li class=\'selected\'>
                    <a href=\'http://www.brisbanetimes.com.au/queensland\' title=\'Queensland\'>Queensland</a>
                </li>
                <li>
                    <a href=\'http://www.brisbanetimes.com.au/queensland/brisbane-live\' title=\'Brisbane Live\'>Brisbane Live</a>
                </li>
                <li>
                    <a href=\'http://www.brisbanetimes.com.au/queensland/places/brisbane\' title=\'Brisbane\'>Brisbane</a>
                </li>
                <li>
                    <a href=\'http://www.brisbanetimes.com.au/queensland/places/gold-coast\' title=\'Gold Coast\'>Gold Coast</a>
                </li>
                <li>
                    <a href=\'http://www.brisbanetimes.com.au/queensland/places/sunshine-coast\' title=\'Sunshine Coast\'>Sunshine Coast</a>
                </li>
                <li>
                    <a href=\'http://www.brisbanetimes.com.au/queensland/places/ipswich\' title=\'Ipswich\'>Ipswich</a>
                </li>
                <li>
                    <a href=\'http://www.brisbanetimes.com.au/queensland/places/Toowoomba\' title=\'Toowoomba\'>Toowoomba</a>
                </li>
                <li>
                    <a href=\'http://www.brisbanetimes.com.au/queensland/brisbane-traffic\' title=\'Brisbane Traffic\'>Brisbane Traffic</a>
                </li>
                <li>
                    <a href=\'http://www.brisbanetimes.com.au/entertainment/about-town\' title=\'About Town\'>About Town</a>
                </li>
                <li>
                    <a href=\'http://www.brisbanetimes.com.au/drive/\' title=\'Cars\'>Cars</a>
                </li>
                <li>
                    <a href=\'http://realestate.brisbanetimes.com.au/\' title=\'Real Estate\'>Real Estate</a>
                </li>
                <li>
                    <a href=\'http://www.rsvp.com.au/browse/AUSTRALIA/Queensland.jsp\' title=\'Dating\'>Dating</a>
                </li>
    </ul>

        <p class=\'breadcrumb\'>
        <span>You are here:</span>
            <a href=\'http://www.brisbanetimes.com.au\' >Home</a>
            <a href=\'http://www.brisbanetimes.com.au/queensland\' >Queensland</a>
            <a href=\'http://www.brisbanetimes.com.au/queensland/girl-17-dies-in-southeast-queensland-crash-20130629-2p3k3.html\' class=\'last\'>Article</a>
    </p>

        <div class=\'cN-searchBox cfix\'>
        <form action=\'http://www.brisbanetimes.com.au/execute_search.html\' method=\'get\'>
            <h2>Search brisbanetimes:</h2>
            <label for=\'search\'>
                <input type=\'text\' name=\'text\' id=\'search\' placeholder='Search here...' onfocus=\'this.value='';\' />
            </label>
            <h3>Search in:</h3>
            <ul id=\'ddown\' class=\'ddown\'>
                <li><a class=\'selected\' href=\'#\'>brisbanetimes.com.au</a>
                    <div class=\'srch-wrap\'>
                        <div></div>
                        <ul class=\'cfix\'>
                                <li class=\'first\'><a href=\'#\'>brisbanetimes.com.au</a></li>
                                <li><a href=\'#\'>Web</a></li>
                        </ul>
                    </div><!-- class:srch-wrap -->
                </li>
            </ul>
            <input type=\'hidden\' name=\'ss\' value=\'brisbanetimes.com.au\' />
            <input type=\'submit\' class=\'btnSubmit\' value=\'Search\' />
        </form>
    </div><!-- class:cN-searchBox cfix -->

</div>
<!-- End component: Header -->

        
        
        <div id=\'adspot-940x20-pos-1\' style='display:none;' class=\'ad ad adPageTop\'> </div>
        <div id=\'content\' class=\'span-16 article\'>
            <h1 class=\'cN-headingPage\'>Girl, 17, dies in southeast Queensland crash</h1>
<div class=\'meta hnews\'>
    <dl>
        <dt class=\'hiddenVisually\'>Date</dt>
        <dd class=\'updated dtstamp\'>
                <time datetime=\'June 29, 2013 - 12:18PM\'>June 29, 2013 - 12:18PM</time>
        </dd>
    </dl>
    <ul class=\'tools\'>
        <li class=\'reading\'><strong>42</strong> reading now</li>
    <li class=\'reading collectorHidden\' style=\'display:none\'>(41)</li>
        <li class=\'clipping\' data-assetId=\'d-2p3k3\' data-assetType=\'ARTICLE\' data-assetUrl=\'http://www.brisbanetimes.com.au/queensland/girl-17-dies-in-southeast-queensland-crash-20130629-2p3k3.html\'><button class=\'btnClipping btnFauxLink\' type=\'button\'>Read later</button></li>
</ul>
    
    
    
    <!--We need to call this as a dynamic component, to many variants meant i had to start hacking it for different sections -->
<ul class=\'social sponsored cfix\'>

        <li class=\'tweet\'>
            <a href=\'http://twitter.com/share\' class=\'twitter-share-button\' data-count=\'horizontal\' data-url=\'http://www.brisbanetimes.com.au/queensland/girl-17-dies-in-southeast-queensland-crash-20130629-2p3k3.html\' data-via=\'brisbanetimes\' data-text=\'Girl, 17, dies in southeast Queensland crash\'>Tweet</a>
        </li>
        <li class=\'fblike\'><fb:like href=\'http://www.brisbanetimes.com.au/queensland/girl-17-dies-in-southeast-queensland-crash-20130629-2p3k3.html\' send=\'false\' layout=\'button_count\' width=\'100\' show_faces=\'false\' action=\'recommend\' font=\'arial\'></fb:like></li>
        <li class=\'gplus\'><div class=\'g-plus\' data-action=\'share\' data-annotation=\'bubble\'></div></li>
        <li class=\'linkedin\'><script type=\'IN/Share\' data-url=\'http://www.brisbanetimes.com.au/queensland/girl-17-dies-in-southeast-queensland-crash-20130629-2p3k3.html\'></script></li>
        <li class=\'reddit\'><a href=\'http://www.reddit.com/submit?url=http://www.brisbanetimes.com.au/queensland/girl-17-dies-in-southeast-queensland-crash-20130629-2p3k3.html&title=Girl, 17, dies in southeast Queensland crash\'>submit to reddit</a></li>
    <li class=\'email\'><a href=\'/action/emailToFriend?id=4530243\' title=\'Email to a friend\' rel=\'nofollow\' data-emailSocialLink=\'true\' data-emailUrl=\'/action/emailToFriend?id=4530243\'>Email article</a></li>
    <li class=\'print\'>
            <a href=\'/action/printArticle?id=4530243\' title=\'Print this story\' rel=\'nofollow\' data-printSocialLink=\'true\' data-printUrl=\'/action/printArticle?id=4530243\'>Print</a>
    </li>
        <li class=\'socSponsor\'><div id=\'adspot-120x50\' class=\'ad\'> </div></li>
</ul>
</div><!-- class:meta hnews -->
<!--honey pot ad inserted via trickyness-->
<div class=\'ad adSpot-textBox\' id=\'googleAds\'>
</div>
<div class=\'articleBody\'>
            
        <p>A 17-year-old girl has died after the car she was driving crashed head-on into a four-wheel-drive carrying six people near Gympie in south-east Queensland.</p>

        <p>The four-wheel-drive occupants were taken to Gympie Hospital,  but none are believed to have been seriously physically injured.</p>

                    
        <p>According to police media, the car was travelling southbound on the Bruce Highway about 9pm and crossed onto the incorrect side of the road, colliding with the four-wheel-drive.<br /><br />The teenage driver, from Bundaberg, was pronounced dead at the scene.</p>

        <p><strong>AAP</strong></p>
            <div id=\'adspot-300x250-pos-3\' class=\'hidden\'> <small>Advertisement</small> <script type=\'text/javascript\'> var erA = document.createElement('iframe'); erA.setAttribute(\'id\', \'dcAd-1-4\'); erA.setAttribute(\'src\', \'http://ad-apac.doubleclick.net/adi/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;pos=3;\' + document.dcAdsCParams +\'sz=300x250;tile=4;ord=\' + dcOrd + \'?\'); erA.setAttribute(\'width\', \'300\'); erA.setAttribute(\'height\', \'250\'); erA.setAttribute(\'scrolling\', \'no\'); erA.setAttribute(\'marginheight\', \'0\'); erA.setAttribute(\'marginwidth\', \'0\'); erA.setAttribute(\'allowtransparency\', \'true\'); erA.setAttribute(\'frameborder\', \'0\'); erA.frameBorder = 0; document.dcdAdsE.push(erA); document.dcdAdsEH.push(\'adspot-300x250-pos-3\'); document.dcdAdsEC.push(\'ad adCentred\'); document.dcdAdsR.push(\'dcAd-1-4\'); </script> <noscript> <iframe id=\'dcAd-1-4\' src=\'http://ad-apac.doubleclick.net/adi/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;pos=3;sz=300x250;tile=4;ord=6.029626E7?\' width='300' height='250' scrolling=\'no\' marginheight=\'0\' marginwidth=\'0\' allowtransparency=\'true\' frameborder=\'0\'> </iframe> </noscript> </div>
        
</div><!-- class:articleBody -->








            
            <div id=\'moreGoogleAds\' class=\'ad adSpot-textBox\'></div><!-- id:moreGoogleAds -->
            <div id=\'jobs\' data-jobsBrand=\'bt\' data-jobsSkew=\'generic2\' data-jobsWidth=\'620\' data-jobsHeight=\'210\'></div><!-- id:jobs -->

                <div class=\'customSuggestions cfix hidden\' data-siteid=\'9222289450909507105\' data-brand=\'brisbanetimes.com.au\' data-section=\'Queensland\' data-clippable=\'true\'></div>

                <div class=\'OUTBRAIN\' data-src=\'http://www.brisbanetimes.com.au/queensland/girl-17-dies-in-southeast-queensland-crash-20130629-2p3k3.html\' data-widget-id=\'AR_1\' data-ob-template=\'Brisbane_Times_Fairfax\'></div>

            
            
            
            
            <div class=\'meta\'>
    <!--We need to call this as a dynamic component, to many variants meant i had to start hacking it for different sections -->
<ul class=\'social  cfix\'>

        <li class=\'tweet\'>
            <a href=\'http://twitter.com/share\' class=\'twitter-share-button\' data-count=\'horizontal\' data-url=\'http://www.brisbanetimes.com.au/queensland/girl-17-dies-in-southeast-queensland-crash-20130629-2p3k3.html\' data-via=\'brisbanetimes\' data-text=\'Girl, 17, dies in southeast Queensland crash\'>Tweet</a>
        </li>
        <li class=\'fblike\'><fb:like href=\'http://www.brisbanetimes.com.au/queensland/girl-17-dies-in-southeast-queensland-crash-20130629-2p3k3.html\' send=\'false\' layout=\'button_count\' width=\'100\' show_faces=\'false\' action=\'recommend\' font=\'arial\'></fb:like></li>
        <li class=\'gplus\'><div class=\'g-plus\' data-action=\'share\' data-annotation=\'bubble\'></div></li>
        <li class=\'linkedin\'><script type=\'IN/Share\' data-url=\'http://www.brisbanetimes.com.au/queensland/girl-17-dies-in-southeast-queensland-crash-20130629-2p3k3.html\'></script></li>
        <li class=\'reddit\'><a href=\'http://www.reddit.com/submit?url=http://www.brisbanetimes.com.au/queensland/girl-17-dies-in-southeast-queensland-crash-20130629-2p3k3.html&title=Girl, 17, dies in southeast Queensland crash\'>submit to reddit</a></li>
    <li class=\'email\'><a href=\'/action/emailToFriend?id=4530243\' title=\'Email to a friend\' rel=\'nofollow\' data-emailSocialLink=\'true\' data-emailUrl=\'/action/emailToFriend?id=4530243\'>Email article</a></li>
    <li class=\'print\'>
            <a href=\'/action/printArticle?id=4530243\' title=\'Print this story\' rel=\'nofollow\' data-printSocialLink=\'true\' data-printUrl=\'/action/printArticle?id=4530243\'>Print</a>
    </li>
</ul>
</div><!-- class:meta -->

            
            
        </div><!-- id:content -->
        <div class=\'aside span-8 last\' role=\'complementary\'>
            <div id=\'adspot-300x1515-pos-1\' class=\'ad\'> <script> renderIJAd(\'adspot-300x1515-pos-1\', \'dcAd-5\', 'http://ad-apac.doubleclick.net/adj/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;pos=1;' + document.dcAdsCParams +'sz=300x1515;tile=5;ord=' + dcOrd + '?', -1425093687); </script> <noscript> <a href='http://ad-apac.doubleclick.net/jump/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;pos=1;sz=300x1515;tile=5;ord=6.029626E7?' target=\'_blank\'> <img src='http://ad-apac.doubleclick.net/ad/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;pos=1;sz=300x1515;tile=5;ord=6.029626E7?' border=\'0\' alt=\'\'> </a> </noscript> </div>
            
            

                    <div id=\'adspot-300x600,300x250-pos-1\' class=\'ad\'> <small>Advertisement</small> <script> renderJAd(\'adspot-300x600,300x250-pos-1\', \'dcAd-6\', 'http://ad-apac.doubleclick.net/adj/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;pos=1;' + document.dcAdsCParams +'sz=300x600,300x250;tile=6;ord=' + dcOrd + '?', 1779724996); </script> <noscript> <a href='http://ad-apac.doubleclick.net/jump/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;pos=1;sz=300x600,300x250;tile=6;ord=6.029626E7?' target=\'_blank\'> <img src='http://ad-apac.doubleclick.net/ad/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;pos=1;sz=300x600,300x250;tile=6;ord=6.029626E7?' border=\'0\' alt=\'\'> </a> </noscript> </div>

                

            <script type=\'text/javascript\' src=\'http://secure-au.imrworldwide.com/cgi-bin/j?ci=rj0121-caltrate&amp;se=1&amp;te=0\'></script>
            <script type=\'text/javascript\' src=\'http://secure-au.imrworldwide.com/cgi-bin/j?ci=rj0124-samsung&amp;se=1&amp;te=0\'> </script>
<script type=\'text/javascript\' src=\'http://secure-au.imrworldwide.com/cgi-bin/j?ci=rj0126-sushi-train&amp;se=1&amp;te=0\'> </script>

                <ul id=\'cN-tabBox1\' class=\'cN-tabBox accessibleTab cS-latestArticlesVideos\'>
            <li class=\'tab1  selected\'>
                <h4><a href=\'javascript:;\'>Latest Video</a></h4><!--TODO change this from H4 as it conficts with video headline-->
                <div class=\'cfix\'>
        <div class=\'cS-latestVideo\'>
        <h3>Selections Video <a href=\'http://media.brisbanetimes.com.au/national/selections\'>More video</a></h3>
        <div class=\'media-video\' id=\'video-player-latest\'>
            <div id=\'video-player-latest-player\' class=\'videoWrap\'></div><!-- id:video-player-latest-player -->
            <div class=\'fdVideoWof accessibleWof\'>
                <h4>Sh*tsville Express: Review</h4>
                <p><i>Sh*tsville Express</i> host Joe Hildebrand presents four young idealists with issues confronting everyday Australians. Is it a doco or reality TV?</p>
            </div><!-- class:fdVideoWof accessibleWof -->
            <ul class=\'span-5\'>
                    <li>
                                <a class=\'play-video \' href=\'http://media.brisbanetimes.com.au/selections/snowden-to-return-to-the-us-4530190.html\' title=\'Snowden to return to the US?\'><img src=\'http://images.brisbanetimes.com.au/2013/06/29/4530107/vd-snowden-US-92x52.jpg\' width=\'92\' height=\'52\' alt=\'Snowden to return to the US? (Video Thumbnail)\' /><span class=\'size-sml\'>Click to play video</span></a>

                        <p><a href=\'http://media.brisbanetimes.com.au/selections/snowden-to-return-to-the-us-4530190.html\'>Snowden to return to the US?</a></p>
                    </li>
                    <li>
                                <a class=\'play-video \' href=\'http://media.brisbanetimes.com.au/selections/grave-dispute-for-mandela-family-4530181.html\' title=\'Grave dispute for Mandela family\'><img src=\'http://images.brisbanetimes.com.au/2013/06/29/4530095/vd-Makaziwe-92x52.jpg\' width=\'92\' height=\'52\' alt=\'Grave dispute for Mandela family (Video Thumbnail)\' /><span class=\'size-sml\'>Click to play video</span></a>

                        <p><a href=\'http://media.brisbanetimes.com.au/selections/grave-dispute-for-mandela-family-4530181.html\'>Grave dispute for Mandela family</a></p>
                    </li>
                    <li>
                                <a class=\'play-video \' href=\'http://media.brisbanetimes.com.au/selections/priest-arrested-over-vatican-bank-fraud-4530184.html\' title=\'Priest arrested over Vatican bank fraud\'><img src=\'http://images.brisbanetimes.com.au/2013/06/29/4530099/vd-vatican-92x52.jpg\' width=\'92\' height=\'52\' alt=\'Priest arrested over Vatican bank fraud (Video Thumbnail)\' /><span class=\'size-sml\'>Click to play video</span></a>

                        <p><a href=\'http://media.brisbanetimes.com.au/selections/priest-arrested-over-vatican-bank-fraud-4530184.html\'>Priest arrested over Vatican bank fraud</a></p>
                    </li>
            </ul>
        </div><!-- id:video-player-latest -->
    </div><!-- class:cS-latestVideo -->

</div><!-- class:cfix -->
            </li>
    </ul>



            
    <div id=\'adspot-149x170\' class=\'ad adSpot-twin cfix\'> <small>Featured advertisers</small> <script type=\'text/javascript\'> if (ie) { renderIFAd(\'adspot-149x170\', \'dcAd-1-7\', \'http://ad-apac.doubleclick.net/adi/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;\' + document.dcAdsCParams + \'pos=1;sz=149x170;tile=7;ord=\' + dcOrd + \'?\', 149, 170, 1389146077); } else { renderJIFAd(\'adspot-149x170\',\'dcAd-1-7\', \'http://ad-apac.doubleclick.net/adj/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;\' + document.dcAdsCParams + \'pos=1;sz=149x170;tile=7;ord=\' + dcOrd + \'?\', 149, 170, 1389146077, \'\'); } </script> <noscript> <iframe id=\'dcAd-1-7\' src=\'http://ad-apac.doubleclick.net/adi/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;pos=1;sz=149x170;tile=7;ord=6.029626E7?\' width='149' height='170' scrolling=\'no\' marginheight=\'0\' marginwidth=\'0\' allowtransparency=\'true\' frameborder=\'0\'> </iframe> </noscript> <script type=\'text/javascript\'> if (ie) { renderIFAd(\'adspot-149x170\', \'dcAd-2-8\', \'http://ad-apac.doubleclick.net/adi/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;\' + document.dcAdsCParams + \'pos=2;sz=149x170;tile=8;ord=\' + dcOrd + \'?\', 149, 170, 980321883); } else { renderJIFAd(\'adspot-149x170\',\'dcAd-2-8\', \'http://ad-apac.doubleclick.net/adj/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;\' + document.dcAdsCParams + \'pos=2;sz=149x170;tile=8;ord=\' + dcOrd + \'?\', 149, 170, 980321883, \'\'); } </script> <noscript> <iframe id=\'dcAd-2-8\' src=\'http://ad-apac.doubleclick.net/adi/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;pos=2;sz=149x170;tile=8;ord=6.029626E7?\' width='149' height='170' scrolling=\'no\' marginheight=\'0\' marginwidth=\'0\' allowtransparency=\'true\' frameborder=\'0\'> </iframe> </noscript> </div>



            <div id=\'adspot-295x60\' class=\'ad \'> <small>Sponsored links</small> <script type=\'text/javascript\'> if (ie) { renderIFAd(\'adspot-295x60\', \'dcAd-1-9\', \'http://ad-apac.doubleclick.net/adi/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;\' + document.dcAdsCParams + \'pos=1;sz=295x60;tile=9;ord=\' + dcOrd + \'?\', 295, 60, 1500882653); } else { renderJIFAd(\'adspot-295x60\',\'dcAd-1-9\', \'http://ad-apac.doubleclick.net/adj/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;\' + document.dcAdsCParams + \'pos=1;sz=295x60;tile=9;ord=\' + dcOrd + \'?\', 295, 60, 1500882653, \'\'); } </script> <noscript> <iframe id=\'dcAd-1-9\' src=\'http://ad-apac.doubleclick.net/adi/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;pos=1;sz=295x60;tile=9;ord=6.029626E7?\' width='295' height='60' scrolling=\'no\' marginheight=\'0\' marginwidth=\'0\' allowtransparency=\'true\' frameborder=\'0\'> </iframe> </noscript> </div>
<iframe src=\'http://assets.betterbills.com/widgets/BT-QLD.html\' width=\'320\' height=\'160\' class=\'iframeBBills\' scrolling=\'no\' frameborder=\'0\'>
    <!-- UI NOTE: Make iframed content accessible: -->
    <a href=\'http://assets.betterbills.com/widgets/BT-QLD.html\'>View these special offers by BetterBills.</a>
</iframe>


            
    <div id=\'adspot-1x4\' class=\'ad\'> <small>Advertisement</small> <script type=\'text/javascript\'> if (ie) { renderIFAd(\'adspot-1x4\', \'dcAd-1-12\', \'http://ad-apac.doubleclick.net/adi/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;\' + document.dcAdsCParams + \'sz=1x4;tile=12;ord=\' + dcOrd + \'?\', 300, 150, 2085185615); } else { renderJIFAd(\'adspot-1x4\',\'dcAd-1-12\', \'http://ad-apac.doubleclick.net/adj/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;\' + document.dcAdsCParams + \'sz=1x4;tile=12;ord=\' + dcOrd + \'?\', 300, 150, 2085185615, \'\'); } </script> <noscript> <iframe id=\'dcAd-1-12\' src=\'http://ad-apac.doubleclick.net/adi/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;sz=1x4;tile=12;ord=6.029626E7?\' width='300' height='150' scrolling=\'no\' marginheight=\'0\' marginwidth=\'0\' allowtransparency=\'true\' frameborder=\'0\'> </iframe> </noscript> </div>

            
            
                <div class=\'customSuggestions cfix hidden\' data-siteid=\'9222289450909507105\' data-brand=\'brisbanetimes.com.au\' data-section=\'Queensland\' data-clippable=\'true\'></div>

                <div class=\'OUTBRAIN\' data-src=\'http://www.brisbanetimes.com.au/queensland/girl-17-dies-in-southeast-queensland-crash-20130629-2p3k3.html\' data-widget-id=\'SB_1\' data-ob-template=\'Brisbane_Times_Fairfax\'></div>

                <div class=\'cfix\'></div>
                        <div id=\'adspot-300x250-pos-2\' class=\'ad\'> <small>Advertisement</small> <script type=\'text/javascript\'> if (ie) { renderIFAd(\'adspot-300x250-pos-2\', \'dcAd-1-13\', \'http://ad-apac.doubleclick.net/adi/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;pos=2;\' + document.dcAdsCParams + \'sz=300x250;tile=13;ord=\' + dcOrd + \'?\', 300, 250, 1546937857); } else { renderJIFAd(\'adspot-300x250-pos-2\',\'dcAd-1-13\', \'http://ad-apac.doubleclick.net/adj/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;pos=2;\' + document.dcAdsCParams + \'sz=300x250;tile=13;ord=\' + dcOrd + \'?\', 300, 250, 1546937857, \'\'); } </script> <noscript> <iframe id=\'dcAd-1-13\' src=\'http://ad-apac.doubleclick.net/adi/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;pos=2;sz=300x250;tile=13;ord=6.029626E7?\' width='300' height='250' scrolling=\'no\' marginheight=\'0\' marginwidth=\'0\' allowtransparency=\'true\' frameborder=\'0\'> </iframe> </noscript> </div>
        </div><!-- class:aside span-8 last -->
        <!-- Footer fN-footerNetwork (class according to new HTML5 element 'footer'; scope: network-wide) -->
<div class=\'footer span-24\' role=\'contentinfo\'>
    
    <div class=\'c5 classifieds cfix\'>
                            <div class=\'s1 cDomain\'>
                            <!-- Campaign ID: 1262078 -->
                            <h2><a title=\'Real Estate\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\' href=\'http://www.domain.com.au\'>Real Estate</a></h2>
                                        <div class=\'puff\'>
                                                <a href=\'http://news.domain.com.au/domain/blogs/talking-property/call-to-supersize-home-deposits-20130625-2ouba.html?utm_source=mastheads&utm_medium=rainbow&utm_campaign=blog250613\' rel=\'nofollow\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'  >
    <img src=\'http://images.brisbanetimes.com.au/2013/06/19/4502667/domainForSale_172x115.jpg-172x115.jpg\' width=\'172\' alt=\'Planning on buying a house soon?\'/></a>

                                            <h5><a href=\'http://news.domain.com.au/domain/blogs/talking-property/call-to-supersize-home-deposits-20130625-2ouba.html?utm_source=mastheads&utm_medium=rainbow&utm_campaign=blog250613\' rel=\'nofollow\' title=\'calltosuper-sizehomedeposits\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'>Call to super-size home deposits</a></h5>
                                        </div><!-- class:puff -->
                                        <ul><li class=\'lDomain\'><a href=\'http://www.domain.com.au\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'>Domain.com.au</a></li>
                                        <li><a href=\'http://www.domain.com.au?utm_source=mastheads&utm_medium=rainbow&utm_campaign=buy\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'>Buy real estate</a></li>
                                        <li><a href=\'http://www.homepriceguide.com.au/Products/Product.aspx?ProductID=7&utm_source=mastheads&utm_medium=rainbow&utm_campaign=APM-Property-Report\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'>How much is my house worth?</a></li>
                                        <li><a href=\'http://eyeon.com.au/about.asp?id=8&utm_source=EYEON&utm_medium=Domain&utm_content=rainbow&utm_campaign=report-offer\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'>Need an inspection report?</a></li>
                                </ul>
                        </div><!-- class:s1 cDomain -->
                        <div class=\'s2 cMycareer\'>
                            <!-- Campaign ID: 1262084 -->
                            <h2><a title=\'Jobs\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\' href=\'http://www.mycareer.com.au\'>Jobs</a></h2>
                                        <div class=\'puff\'>
                                                <a href=\'http://mycareer.com.au/search/?s=777\' rel=\'nofollow\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'  >
    <img src=\'http://images.brisbanetimes.com.au/2013/04/16/4196395/08-172x115.jpg\' width=\'172\' alt=\'Search for 1000's of jobs\'/></a>

                                            <h5><a href=\'http://mycareer.com.au/search/?s=777\' rel=\'nofollow\' title=\'searchfor1000sofjobsaroundaustralia\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'>Search for 1000s of jobs around Australia</a></h5>
                                        </div><!-- class:puff -->
                                        <ul><li class=\'lMycareer\'><a href=\'http://www.mycareer.com.au\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'>Mycareer.com.au</a></li>
                                        <li><a href=\'http://mycareer.com.au/tools/createJobAlert\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'>Set up an email job alert</a></li>
                                        <li><a href=\'http://mycareer.com.au/\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'>Search for a new job</a></li>
                                        <li><a href=\'http://content.mycareer.com.au/salary-centre\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'>What are you worth?</a></li>
                                </ul>
                        </div><!-- class:s2 cMycareer -->
                        <div class=\'s3 cTheVine\'>
                            <!-- Campaign ID: 1262087 -->
                            <h2><a title=\'TheVine\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\' href=\'http://www.thevine.com.au\'>TheVine</a></h2>
                                        <div class=\'puff\'>
                                                <a href=\'http://thevine.com.au/life/tech/amusing-google-suggestions/?utm_source=FD&utm_medium=rainbow&utm_campaign=googlegroupthing\' rel=\'nofollow\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'  >
    <img src=\'http://images.brisbanetimes.com.au/2013/06/25/4517884/google-weirdness-172x115.jpg\' width=\'172\' alt=\'Weird google\'/></a>

                                            <h5><a href=\'http://thevine.com.au/life/tech/amusing-google-suggestions/?utm_source=FD&utm_medium=rainbow&utm_campaign=googlegroupthing\' rel=\'nofollow\' title=\'googles55mostdisturbinggroup-thinksearches\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'>Google's 55 Most Disturbing Group-Think Searches</a></h5>
                                        </div><!-- class:puff -->
                                        <ul><li class=\'lTheVine\'><a href=\'http://www.thevine.com.au\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'>Thevine.com.au</a></li>
                                        <li><a href=\'http://www.thevine.com.au/entertainment/\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'>Entertainment & celebrity news</a></li>
                                        <li><a href=\'http://www.thevine.com.au/fashion/holiday-gift-ideas/\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'>Best gift ideas</a></li>
                                        <li><a href=\'http://www.thevine.com.au/music/?utm_source=FD&utm_medium=rainbow&utm_campaign=music\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'>Music news and reviews</a></li>
                                </ul>
                        </div><!-- class:s3 cTheVine -->
                        <div class=\'s4 cStayz\'>
                            <!-- Campaign ID: 1262088 -->
                            <h2><a title=\'Holidays\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\' href=\'http://www.stayz.com.au\'>Holidays</a></h2>
                                        <div class=\'puff\'>
                                                <a href=\'http://www.stayz.com.au/?utm_source=rainbow&utm_medium=ffx&utm_campaign=brisbanetimes\' rel=\'nofollow\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'  >
    <img src=\'http://images.brisbanetimes.com.au/2010/05/27/1516179/RB_BeachYoungFamily-172x115.jpg\' width=\'172\' alt=\'Noosa accommodation\'/></a>

                                            <h5><a href=\'http://www.stayz.com.au/?utm_source=rainbow&utm_medium=ffx&utm_campaign=brisbanetimes\' rel=\'nofollow\' title=\'it’snottoolatetoescapethiseaster\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'>It’s not too late to escape this Easter</a></h5>
                                        </div><!-- class:puff -->
                                        <ul><li class=\'lStayz\'><a href=\'http://www.stayz.com.au\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'>Stayz.com.au</a></li>
                                        <li><a href=\'http://www.stayz.com.au/accommodation/nsw/northern-rivers-byron-bay?utm_source=rainbow&utm_medium=ffx&utm_campaign=brisbanetimes\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'>Holiday in Byron Bay</a></li>
                                        <li><a href=\'http://www.stayz.com.au/accommodation/nsw/sydney?utm_source=rainbow&utm_medium=ffx&utm_campaign=brisbanetimes\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'>Holiday in Sydney</a></li>
                                        <li><a href=\'http://www.stayz.com.au/accommodation/vic/melbourne?utm_source=rainbow&utm_medium=ffx&utm_campaign=brisbanetimes\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'>Holiday in Melbourne</a></li>
                                </ul>
                        </div><!-- class:s4 cStayz -->
                        <div class=\'s5 cRsvp\'>
                            <!-- Campaign ID: 1262091 -->
                            <h2><a title=\'Dating\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\' href=\'http://www.rsvp.com.au\'>Dating</a></h2>
                                        <div class=\'puff\'>
                                                <a href=\'http://www.rsvp.com.au?s_rid=rainbowstrip:bt\' rel=\'nofollow\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'  >
    <img src=\'http://images.brisbanetimes.com.au/2010/12/03/2077688/RSVP_cpl_beefy-172x115.jpg\' width=\'172\' alt=\'Couple in a piggyback pose\'/></a>

                                            <h5><a href=\'http://www.rsvp.com.au?s_rid=rainbowstrip:bt\' rel=\'nofollow\' title=\'australiasfavouritedatingsite\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'>Australia's Favourite Dating Site</a></h5>
                                        </div><!-- class:puff -->
                                        <ul><li class=\'lRsvp\'><a href=\'http://www.rsvp.com.au\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'>Rsvp.com.au</a></li>
                                        <li><a href=\'http://www.rsvp.com.au/quick+find/meet+singles.jsp?s_rid=rainbowstrip:bt\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'>Meet Brisbane singles</a></li>
                                        <li><a href=\'http://www.rsvp.com.au/join-now/dating?s_rid=rainbowstrip:bt\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'>Get started for free!</a></li>
                                        <li><a href=\'http://www.rsvp.com.au/singles+events.jsp?s_rid=rainbowstrip:bt\' class=\'gaTrackable\' data-gaAction=\'RainbowStrip Click\' data-gaCategory=\'RainbowStrip\'>Singles events for all ages</a></li>
                                </ul>
                        </div><!-- class:s5 cRsvp -->
</div><!-- class:c5 classifieds cfix -->


    <div class='affiliateTabsInitParams' selectedTab='1' selectedTitle='' style='visibility:hidden'></div>
<div class=\'fN-affiliateStrip\'>
	<h2>Compare and Save</h2>
    <div class=\'cN-tabPages affiliateStrip cfix\'>
        <p class=\'access\'>Skip to:</p>
        <ul class=\'nav\' role=\'navigation\'>
            <li class=\'tab-1 selected\'><a id=\'link-tab-1\' href=\'#tab-1\'>Best Deals</a></li>
            <li class=\'tab-2\'><a id=\'link-tab-2\' data-remote=\'true\' data-remote-url=\'/action/displayComponent?name=au.com.fairfaxdigital.common.media.webapp.ui.StaticIncludeComponent&designVersionName=media-common-1.0&params=tab-cands-2.html\' href=\'#tab-2\'>Mobile</a></li>
            <li class=\'tab-3\'><a id=\'link-tab-3\' data-remote=\'true\' data-remote-url=\'/action/displayComponent?name=au.com.fairfaxdigital.common.media.webapp.ui.StaticIncludeComponent&designVersionName=media-common-1.0&params=tab-cands-3.html\' href=\'#tab-3\'>Broadband</a></li>
            <li class=\'tab-4\'><a id=\'link-tab-4\' data-remote=\'true\' data-remote-url=\'/action/displayComponent?name=au.com.fairfaxdigital.common.media.webapp.ui.StaticIncludeComponent&designVersionName=media-common-1.0&params=tab-cands-4.html\' href=\'#tab-4\'>Home Loans</a></li>
            <li class=\'tab-5\'><a id=\'link-tab-5\' data-remote=\'true\' data-remote-url=\'/action/displayComponent?name=au.com.fairfaxdigital.common.media.webapp.ui.StaticIncludeComponent&designVersionName=media-common-1.0&params=tab-cands-5.html\' href=\'#tab-5\'>Credit Cards</a></li>
            <li class=\'tab-6\'><a id=\'link-tab-6\' data-remote=\'true\' data-remote-url=\'/action/displayComponent?name=au.com.fairfaxdigital.common.media.webapp.ui.StaticIncludeComponent&designVersionName=media-common-1.0&params=tab-cands-6.html\' href=\'#tab-6\'>Low Rate Cards</a></li>
            <li class=\'tab-7\'><a id=\'link-tab-7\' data-remote=\'true\' data-remote-url=\'/action/displayComponent?name=au.com.fairfaxdigital.common.media.webapp.ui.StaticIncludeComponent&designVersionName=media-common-1.0&params=tab-cands-7.html\' href=\'#tab-7\'>Rewards Cards</a></li>
            <li class=\'tab-8\'><a id=\'link-tab-8\' data-remote=\'true\' data-remote-url=\'/action/displayComponent?name=au.com.fairfaxdigital.common.media.webapp.ui.StaticIncludeComponent&designVersionName=media-common-1.0&params=tab-cands-8.html\' href=\'#tab-8\'>Savings Accts</a></li>
            <li class=\'tab-9\'><a id=\'link-tab-9\' data-remote=\'true\' data-remote-url=\'/action/displayComponent?name=au.com.fairfaxdigital.common.media.webapp.ui.StaticIncludeComponent&designVersionName=media-common-1.0&params=tab-cands-9.html\' href=\'#tab-9\'>Term Deposits</a></li>
            <li class=\'tab-10 last\'><a id=\'link-tab-10\' data-remote=\'true\' data-remote-url=\'/action/displayComponent?name=au.com.fairfaxdigital.common.media.webapp.ui.StaticIncludeComponent&designVersionName=media-common-1.0&params=tab-cands-10.html\' href=\'#tab-10\'>Loans</a></li>
        </ul>

        <div id=\'tab-1\' class=\'tab selected cfix\' aria-live=\'polite\'>
            <h3>Check out today's best deals</h3>
            <div class=\'one\'>
                <h3><a href=\'http://compare.brisbanetimes.com.au/home-loans?utm_source=CS_front&utm_medium=CnS&utm_campaign=HL_fixedratesfall&mpp_tab=3\' class=\'gaTrackable\' data-gaAction=\'1\' data-gaCategory=\'CompareSave\' data-gaLabel=\'1\'>Fixed Rates Fall</a></h3>
                <a href=\'http://compare.brisbanetimes.com.au/home-loans?utm_source=CS_front&utm_medium=CnS&utm_campaign=HL_fixedratesfall&mpp_tab=3\' class=\'gaTrackable\' data-gaAction=\'1\' data-gaCategory=\'CompareSave\' data-gaLabel=\'1\'><img src=\'http://images.brisbanetimes.com.au/compareandsave/cs-houses-flying.jpg\' width=\'60\' height=\'50\' /></a>
                <p><a href=\'http://compare.brisbanetimes.com.au/home-loans?utm_source=CS_front&utm_medium=CnS&utm_campaign=HL_fixedratesfall&mpp_tab=3\' class=\'gaTrackable\' data-gaAction=\'1\' data-gaCategory=\'CompareSave\' data-gaLabel=\'1\'>Rates hit record low of 4.54% . Compare and save.</a></p>
                <span></span>
                <p class=\'links\'><a href=\'http://compare.brisbanetimes.com.au/home-loans?utm_source=CS_front&utm_medium=CnS&utm_campaign=HL_fixedratesfall&mpp_tab=3\' class=\'gaTrackable\' data-gaAction=\'1\' data-gaCategory=\'CompareSave\' data-gaLabel=\'1\'>Lowest Fixed Rates</a></p>
            </div>
            <div class=\'two\'>
                <h3><a href=\'http://compare.brisbanetimes.com.au/home-loans?utm_source=CS_front&utm_medium=CnS&utm_campaign=HL_ubank487\' class=\'gaTrackable\' data-gaAction=\'1\' data-gaCategory=\'CompareSave\' data-gaLabel=\'2\'>Refinance & Save</a></h3>
                <a href=\'http://compare.brisbanetimes.com.au/home-loans?utm_source=CS_front&utm_medium=CnS&utm_campaign=HL_ubank487\' class=\'gaTrackable\' data-gaAction=\'1\' data-gaCategory=\'CompareSave\' data-gaLabel=\'2\'><img src=\'http://images.brisbanetimes.com.au/compareandsave/cs-ubank-hl-487.png\' width=\'60\' height=\'50\' /></a>
                <p><a href=\'http://compare.brisbanetimes.com.au/home-loans?utm_source=CS_front&utm_medium=CnS&utm_campaign=HL_ubank487\' class=\'gaTrackable\' data-gaAction=\'1\' data-gaCategory=\'CompareSave\' data-gaLabel=\'2\'>Australia's cheapest refinance loan. Switch and save</a></p>
                <span></span>
                <p class=\'links\'><a href=\'http://compare.brisbanetimes.com.au/home-loans?utm_source=CS_front&utm_medium=CnS&utm_campaign=HL_ubank487\' class=\'gaTrackable\' data-gaAction=\'1\' data-gaCategory=\'CompareSave\' data-gaLabel=\'2\'>Top Refinance Loans</a></p>
            </div>
            <div class=\'three\'>
                <h3><a href=\'http://compare.brisbanetimes.com.au/credit-cards?utm_source=CS_front&utm_medium=CnS&utm_campaign=CC_BT&mpp_tab=3\' class=\'gaTrackable\' data-gaAction=\'1\' data-gaCategory=\'CompareSave\' data-gaLabel=\'3\'>0% Balance Transfer</a></h3>
                <a href=\'http://compare.brisbanetimes.com.au/credit-cards?utm_source=CS_front&utm_medium=CnS&utm_campaign=CC_BT&mpp_tab=3\' class=\'gaTrackable\' data-gaAction=\'1\' data-gaCategory=\'CompareSave\' data-gaLabel=\'3\'><img src=\'http://images.brisbanetimes.com.au/compareandsave/cs-post-it-note-0.png\' width=\'60\' height=\'50\' /></a>
                <p><a href=\'http://compare.brisbanetimes.com.au/credit-cards?utm_source=CS_front&utm_medium=CnS&utm_campaign=CC_BT&mpp_tab=3\' class=\'gaTrackable\' data-gaAction=\'1\' data-gaCategory=\'CompareSave\' data-gaLabel=\'3\'>Transfer credit card balances at 0% p.a. for 6 months</a></p>
                <span></span>
                <p class=\'links\'><a href=\'http://compare.brisbanetimes.com.au/credit-cards?utm_source=CS_front&utm_medium=CnS&utm_campaign=CC_BT&mpp_tab=3\' class=\'gaTrackable\' data-gaAction=\'1\' data-gaCategory=\'CompareSave\' data-gaLabel=\'3\'>Balance Transfer Cards</a></p>
            </div>
            <div class=\'four\'>
                <h3><a href=\'http://mobile-phones.brisbanetimes.com.au/MobilePhones?utm_source=Widget_Fairfax_SMH_CompareAndSave&utm_medium=referral&utm_campaign=Hot_Android_Deals\' class=\'gaTrackable\' data-gaAction=\'1\' data-gaCategory=\'CompareSave\' data-gaLabel=\'4\'>Hot Android Deals</a></h3>
                <a href=\'http://mobile-phones.brisbanetimes.com.au/MobilePhones?utm_source=Widget_Fairfax_SMH_CompareAndSave&utm_medium=referral&utm_campaign=Hot_Android_Deals\' class=\'gaTrackable\' data-gaAction=\'1\' data-gaCategory=\'CompareSave\' data-gaLabel=\'4\'><img src=\'http://images.brisbanetimes.com.au/compareandsave/mobile_160x70_0613_gs4_k.jpg\' width=\'60\' height=\'50\' /></a>
                <p><a href=\'http://mobile-phones.brisbanetimes.com.au/MobilePhones?utm_source=Widget_Fairfax_SMH_CompareAndSave&utm_medium=referral&utm_campaign=Hot_Android_Deals\' class=\'gaTrackable\' data-gaAction=\'1\' data-gaCategory=\'CompareSave\' data-gaLabel=\'4\'>Compare prices and deals on Android phones</a></p>
                <span></span>
                <p class=\'links\'><a href=\'http://mobile-phones.brisbanetimes.com.au/MobilePhones?utm_source=Widget_Fairfax_SMH_CompareAndSave&utm_medium=referral&utm_campaign=Hot_Android_Deals\' class=\'gaTrackable\' data-gaAction=\'1\' data-gaCategory=\'CompareSave\' data-gaLabel=\'4\'>Android Deals</a></p>
            </div>
            <div class=\'five\'>
                <h3><a href=\'http://mobile-phones.brisbanetimes.com.au/MobilePhones/SIM-Only-Mobile-Phone-Plans?utm_source=Widget_Fairfax_SMH_CompareAndSave&utm_medium=referral&utm_campaign=SIM_Only_from_%246%2fMth\' class=\'gaTrackable\' data-gaAction=\'1\' data-gaCategory=\'CompareSave\' data-gaLabel=\'5\'>SIM Only from $6/Mth</a></h3>
                <a href=\'http://mobile-phones.brisbanetimes.com.au/MobilePhones/SIM-Only-Mobile-Phone-Plans?utm_source=Widget_Fairfax_SMH_CompareAndSave&utm_medium=referral&utm_campaign=SIM_Only_from_%246%2fMth\' class=\'gaTrackable\' data-gaAction=\'1\' data-gaCategory=\'CompareSave\' data-gaLabel=\'5\'><img src=\'http://images.brisbanetimes.com.au/compareandsave/mobile_160x70_0613_simonly_4.jpg\' width=\'60\' height=\'50\' /></a>
                <p><a href=\'http://mobile-phones.brisbanetimes.com.au/MobilePhones/SIM-Only-Mobile-Phone-Plans?utm_source=Widget_Fairfax_SMH_CompareAndSave&utm_medium=referral&utm_campaign=SIM_Only_from_%246%2fMth\' class=\'gaTrackable\' data-gaAction=\'1\' data-gaCategory=\'CompareSave\' data-gaLabel=\'5\'>Compare SIM only plans starting at just $6/Month</a></p>
                <span></span>
                <p class=\'links\'><a href=\'http://mobile-phones.brisbanetimes.com.au/MobilePhones/SIM-Only-Mobile-Phone-Plans?utm_source=Widget_Fairfax_SMH_CompareAndSave&utm_medium=referral&utm_campaign=SIM_Only_from_%246%2fMth\' class=\'gaTrackable\' data-gaAction=\'1\' data-gaCategory=\'CompareSave\' data-gaLabel=\'5\'>Compare BYO phone plans</a></p>
            </div>
        </div>

        <div id=\'tab-2\' class=\'tab cfix\' aria-live=\'polite\'>
        </div>

        <div id=\'tab-3\' class=\'tab cfix\' aria-live=\'polite\'>
        </div>

        <div id=\'tab-4\' class=\'tab cfix\' aria-live=\'polite\'>
        </div>

        <div id=\'tab-5\' class=\'tab cfix\' aria-live=\'polite\'>
        </div>

        <div id=\'tab-6\' class=\'tab cfix\' aria-live=\'polite\'>
        </div>

        <div id=\'tab-7\' class=\'tab cfix\' aria-live=\'polite\'>
        </div>

        <div id=\'tab-8\' class=\'tab cfix\' aria-live=\'polite\'>
        </div>

        <div id=\'tab-9\' class=\'tab cfix\' aria-live=\'polite\'>
        </div>

        <div id=\'tab-10\' class=\'tab cfix\' aria-live=\'polite\'>
        </div>

    </div>
</div>
        
<!-- Reader's most viewed -->
<div class=\'c5 top5 cfix\'>
    <h2 class=\'cfix\'>Readers' most viewed</h2>

            <div class=\'s1 lSmh\'>
                <a href=\'http://www.smh.com.au\'>Most viewed articles on The Sydney Morning Herald</a>
                <h5>Top 5 <a href=\'http://www.smh.com.au/queensland\'>Queensland</a> articles</h5>
    <ol>
            <li><a href=\'http://www.smh.com.au/queensland/brisbane-live/brisbane-live-monday-july-1-20130628-2p2cx.html\' title=\'Brisbane Live: Monday July 1\' style=\'\'>Brisbane Live: Monday July 1</a></li>
            <li><a href=\'http://www.smh.com.au/queensland/gyrocopter-pilot-critical-after-queensland-crash-20130629-2p3k2.html\' title=\'Gyrocopter pilot critical after Queensland crash\' style=\'\'>Gyrocopter pilot critical after Queensland crash</a></li>
            <li><a href=\'http://www.smh.com.au/queensland/girl-17-dies-in-southeast-queensland-crash-20130629-2p3k3.html\' title=\'Girl, 17, dies in southeast Queensland crash\' style=\'\'>Girl, 17, dies in southeast Queensland crash</a></li>
            <li><a href=\'http://www.smh.com.au/queensland/irwin-slams-croc-culls-for-making-handbags-20130628-2p25y.html\' title=\'Irwin slams croc culls 'for making handbags'\' style=\'\'>Irwin slams croc culls 'for making handbags'</a></li>
            <li><a href=\'http://www.smh.com.au/queensland/exnrl-player-to-face-court-over-brawl-20130611-2o0x6.html\' title=\'Ex-NRL player to face court over brawl\' style=\'\'>Ex-NRL player to face court over brawl</a></li>
    </ol>

            </div>
            <div class=\'s2 lAge\'>
                <a href=\'http://www.theage.com.au\'>Most viewed articles on The Age</a>
                <h5>Top 5 <a href=\'http://www.theage.com.au/queensland\'>Queensland</a> articles</h5>
    <ol>
            <li><a href=\'http://www.theage.com.au/queensland/brisbane-live/brisbane-live-monday-july-1-20130628-2p2cx.html\' title=\'Brisbane Live: Monday July 1\' style=\'\'>Brisbane Live: Monday July 1</a></li>
            <li><a href=\'http://www.theage.com.au/queensland/girl-17-dies-in-southeast-queensland-crash-20130629-2p3k3.html\' title=\'Girl, 17, dies in southeast Queensland crash\' style=\'\'>Girl, 17, dies in southeast Queensland crash</a></li>
            <li><a href=\'http://www.theage.com.au/queensland/changed-habits-cut-queenslands-energy-use-20130628-2p1u2.html\' title=\'Changed habits cut Queensland's energy use\' style=\'\'>Changed habits cut Queensland's energy use</a></li>
            <li><a href=\'http://www.theage.com.au/queensland/gyrocopter-pilot-critical-after-queensland-crash-20130629-2p3k2.html\' title=\'Gyrocopter pilot critical after Queensland crash\' style=\'\'>Gyrocopter pilot critical after Queensland crash</a></li>
            <li><a href=\'http://www.theage.com.au/queensland/welsh-prop-should-have-been-jailed-victim-20130628-2p0qi.html\' title=\'Welsh prop should have been jailed: victim\' style=\'\'>Welsh prop should have been jailed: victim</a></li>
    </ol>

            </div>
            <div class=\'s3 lWAToday\'>
                <a href=\'http://www.watoday.com.au\'>Most viewed articles on WA Today</a>
                <h5>Top 5 <a href=\'http://www.watoday.com.au/queensland\'>Queensland</a> articles</h5>
    <ol>
            <li><a href=\'http://www.watoday.com.au/queensland/abducted-raped-bashed-and-left-for-dead-20130619-2oist.html\' title=\'Abducted, raped, bashed and left for dead\' style=\'\'>Abducted, raped, bashed and left for dead</a></li>
            <li><a href=\'http://www.watoday.com.au/queensland/brisbane-teen-denies-raping-murdering-joan-ryther-20130601-2ni3i.html\' title=\'Brisbane teen denies raping, murdering Joan Ryther\' style=\'\'>Brisbane teen denies raping, murdering Joan Ryther</a></li>
            <li><a href=\'http://www.watoday.com.au/queensland/bushwalker-shot-in-queensland-drug-crop-20130621-2oogq.html\' title=\'Bushwalker shot in Queensland drug crop\' style=\'\'>Bushwalker shot in Queensland drug crop</a></li>
            <li><a href=\'http://www.watoday.com.au/queensland/nurses-tied-to-a-tree-for-days-witness-20130410-2hloy.html\' title=\'Nurses tied to a tree for days: witness\' style=\'\'>Nurses tied to a tree for days: witness</a></li>
            <li><a href=\'http://www.watoday.com.au/queensland/the-real-challenges-facing-electricity-generation-20130624-2os0l.html\' title=\'The real challenges facing electricity generation\' style=\'\'>The real challenges facing electricity generation</a></li>
    </ol>

            </div>
            <div class=\'s4 lCanberratimes\'>
                <a href=\'http://www.canberratimes.com.au\'>Most viewed articles on Canberra Times</a>
                <h5>Top 5 <a href=\'http://www.canberratimes.com.au/queensland\'>Queensland</a> articles</h5>
    <ol>
            <li><a href=\'http://www.canberratimes.com.au/queensland/motorists-driving-too-far-to-cross-brisbane-river-experts-20130620-2oll9.html\' title=\'Motorists driving too far to cross Brisbane River: experts\' style=\'\'>Motorists driving too far to cross Brisbane River: experts</a></li>
            <li><a href=\'http://www.canberratimes.com.au/queensland/welsh-prop-should-have-been-jailed-victim-20130628-2p0qi.html\' title=\'Welsh prop should have been jailed: victim\' style=\'\'>Welsh prop should have been jailed: victim</a></li>
            <li><a href=\'http://www.canberratimes.com.au/queensland/construction-cracks-amid-investment-decline-20130627-2oyz8.html\' title=\'Construction cracks amid investment decline\' style=\'\'>Construction cracks amid investment decline</a></li>
    </ol>

            </div>
            <div class=\'s5 lBT\'>
                <a href=\'http://www.brisbanetimes.com.au\'>Most viewed articles on Brisbane Times</a>
                <h5>Top 5 <a href=\'http://www.brisbanetimes.com.au/queensland\'>Queensland</a> articles</h5>
    <ol>
            <li><a href=\'http://www.brisbanetimes.com.au/queensland/changed-habits-cut-queenslands-energy-use-20130628-2p1u2.html\' title=\'Changed habits cut Queensland's energy use\' style=\'\'>Changed habits cut Queensland's energy use</a></li>
            <li><a href=\'http://www.brisbanetimes.com.au/queensland/girl-17-dies-in-southeast-queensland-crash-20130629-2p3k3.html\' title=\'Girl, 17, dies in southeast Queensland crash\' style=\'\'>Girl, 17, dies in southeast Queensland crash</a></li>
            <li><a href=\'http://www.brisbanetimes.com.au/queensland/gyrocopter-pilot-critical-after-queensland-crash-20130629-2p3k2.html\' title=\'Gyrocopter pilot critical after Queensland crash\' style=\'\'>Gyrocopter pilot critical after Queensland crash</a></li>
            <li><a href=\'http://www.brisbanetimes.com.au/queensland/welsh-prop-should-have-been-jailed-victim-20130628-2p0qi.html\' title=\'Welsh prop should have been jailed: victim\' style=\'\'>Welsh prop should have been jailed: victim</a></li>
            <li><a href=\'http://www.brisbanetimes.com.au/queensland/nurses-likely-killed-by-putrid-pool-of-miscreants-20130628-2p1ni.html\' title=\'Nurses likely killed by 'putrid pool of miscreants'\' style=\'\'>Nurses likely killed by 'putrid pool of miscreants'</a></li>
    </ol>

            </div>
</div>
   
                <div id=\'adspot-728x90,468x60-pos-2\' class=\'ad\'> <script> renderJAd(\'adspot-728x90,468x60-pos-2\', \'dcAd-14\', 'http://ad-apac.doubleclick.net/adj/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;pos=2;' + document.dcAdsCParams +'sz=728x90,468x60;tile=14;ord=' + dcOrd + '?', 178500689); </script> <noscript> <a href='http://ad-apac.doubleclick.net/jump/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;pos=2;sz=728x90,468x60;tile=14;ord=6.029626E7?' target=\'_blank\'> <img src='http://ad-apac.doubleclick.net/ad/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;pos=2;sz=728x90,468x60;tile=14;ord=6.029626E7?' border=\'0\' alt=\'\'> </a> </noscript> </div>
        <ul class=\'fSectionLinks cfix\'>
            <li ><a href=\'http://www.brisbanetimes.com.au/\' title=\'Brisbane Times Home\'>Brisbane Times Home</a></li>
            <li ><a href=\'http://www.brisbanetimes.com.au/queensland\' title=\'Queensland\'>Queensland</a></li>
            <li ><a href=\'http://www.brisbanetimes.com.au/national\' title=\'National\'>National</a></li>
            <li ><a href=\'http://www.brisbanetimes.com.au/environment\' title=\'Environment\'>Environment</a></li>
            <li ><a href=\'http://www.brisbanetimes.com.au/opinion\' title=\'Opinion\'>Opinion</a></li>
            <li ><a href=\'http://www.brisbanetimes.com.au/business\' title=\'Business\'>Business</a></li>
            <li ><a href=\'http://www.brisbanetimes.com.au/technology\' title=\'Technology\'>Technology</a></li>
            <li ><a href=\'http://www.brisbanetimes.com.au/digital-life\' title=\'Digital Life\'>Digital Life</a></li>
            <li ><a href=\'http://www.brisbanetimes.com.au/entertainment1\' title=\'Entertainment\'>Entertainment</a></li>
            <li ><a href=\'http://www.brisbanetimes.com.au/lifestyle\' title=\'Life &amp; Style\'>Life &amp; Style</a></li>
            <li ><a href=\'http://www.brisbanetimes.com.au/travel\' title=\'Travel\'>Travel</a></li>
            <li ><a href=\'http://www.brisbanetimes.com.au/drive\' title=\'Cars\'>Cars</a></li>
            <li ><a href=\'http://www.brisbanetimes.com.au/sport\' title=\'Sport\'>Sport</a></li>
            <li class=\'last\'><a href=\'http://weather.brisbanetimes.com.au/local.jsp\' title=\'Weather\'>Weather</a></li>
    </ul>

    <!-- Footer masthead links and copyright -->
<div class=\'fMastheadLinks cfix\'>
        <ul class=\'span-4 cfix\'>
        <li class=\'first\'><h5>Brisbane Times</h5></li>
            <li><a href=\'http://www.brisbanetimes.com.au/siteguide/\' title=\'Sitemap\'>Sitemap</a></li>
            <li><a href=\'http://www.brisbanetimes.com.au/queensland/our-staff\' title=\'About Us\'>About Us</a></li>
            <li><a href=\'http://www.brisbanetimes.com.au/support/\' title=\'Contact Us\'>Contact Us</a></li>
            <li><a href=\'http://adcentre.com.au/brands/brisbane-times-2/\' title=\'Advertise With Us\'>Advertise With Us</a></li>
            <li><a href=\'http://www.brisbanetimes.com.au/am/\' title=\'AM Today\'>AM Today</a></li>
            <li><a href=\'http://www.brisbanetimes.com.au/text/\' title=\'Text Version\'>Text Version</a></li>
            <li><a href=\'http://www.brisbanetimes.com.au/siteguide/accessibility\' title=\'Site Accessibility Guide\'>Site Accessibility Guide</a></li>
    </ul>

        <ul class=\'span-4 cfix\'>
        <li class=\'first\'><h5>Connect</h5></li>
            <li><a href=\'http://m.brisbanetimes.com.au\' title=\'Mobile Site\'>Mobile Site</a></li>
            <li><a href=\'http://www.brisbanetimes.com.au/rssheadlines\' title=\'RSS\'>RSS</a></li>
            <li><a href=\'http://www.facebook.com/brisbanetimes\' title=\'Facebook\'>Facebook</a></li>
            <li><a href=\'http://twitter.com/brisbanetimes\' title=\'Twitter\'>Twitter</a></li>
            <li><a href=\'http://www.linkedin.com/today/brisbanetimes.com.au\' title=\'LinkedIn\'>LinkedIn</a></li>
    </ul>

        <ul class=\'span-4 cfix\'>
        <li class=\'first\'><h5>Products & Services</h5></li>
            <li><a href=\'http://www.goodguides.com.au/queensland/\' title=\'Good Food Guide\'>Good Food Guide</a></li>
            <li><a href=\'http://www.brisbanetimes.com.au/newsletters/subscription.html\' title=\'Newsletters\'>Newsletters</a></li>
            <li><a href=\'http://www.crackawines.com.au/\' title=\'Cracka Wines\'>Cracka Wines</a></li>
    </ul>

        <ul class=\'span-4 cfix\'>
        <li class=\'first\'><h5>Classifieds</h5></li>
            <li><a href=\'http://classifieds.fairfax.com.au/\' title=\'Classifieds & Notices\'>Classifieds & Notices</a></li>
            <li><a href=\'http://www.stayz.com.au/\' title=\'Accommodation\'>Accommodation</a></li>
            <li><a href=\'http://www.drive.com.au/\' title=\'Cars\'>Cars</a></li>
            <li><a href=\'http://www.rsvp.com.au/\' title=\'Dating\'>Dating</a></li>
            <li><a href=\'http://mycareer.com.au/\' title=\'Jobs\'>Jobs</a></li>
            <li><a href=\'http://apm.com.au/\' title=\'Property Price Data\'>Property Price Data</a></li>
            <li><a href=\'http://www.domain.com.au/\' title=\'Real Estate\'>Real Estate</a></li>
            <li><a href=\'http://www.buyandsell.com.au/?utm_source=BrisbaneTimes&utm_medium=HomeFooterLinks&utm_campaign=Buy%2Band%2BSell \' title=\'Buy and Sell\'>Buy and Sell</a></li>
    </ul>

        <ul class=\'span-4 cfix\'>
        <li class=\'first\'><h5>Fairfax Media</h5></li>
            <li><a href=\'https://membercentre.fairfax.com.au/\' title=\'Member Centre\'>Member Centre</a></li>
            <li><a href=\'http://www.fairfax.com.au/conditions\' title=\'Conditions of Use\'>Conditions of Use</a></li>
            <li><a href=\'http://www.fairfax.com.au/privacy\' title=\'Privacy Policy\'>Privacy Policy</a></li>
            <li><a href=\'http://newsstore.fairfax.com.au/apps/newsSearch.ac?sy=nstore\' title=\'News Store Archive\'>News Store Archive</a></li>
            <li><a href=\'http://www.fairfaxsyndication.com/\' title=\'Photo Sales\'>Photo Sales</a></li>
            <li><a href=\'http://consumer.fairfaxsyndication.com/C.aspx?VP3=ViewBox_VPage&ALID=2ITHRGMNCNCN&CT=Album\' title=\'Purchase Front Pages\'>Purchase Front Pages</a></li>
            <li><a href=\'http://www.fairfaxsyndication.com/\' title=\'Fairfax Syndication\'>Fairfax Syndication</a></li>
            <li><a href=\'http://www.fairfaxevents.com.au/\' title=\'Fairfax Events\'>Fairfax Events</a></li>
            <li><a href=\'http://careers.fairfax.com.au/home.asp\' title=\'Fairfax Careers\'>Fairfax Careers</a></li>
            <li><a href=\'http://www.presscouncil.org.au/what-we-do/\' title=\'Press Council\'>Press Council</a></li>
    </ul>

    
</div>
<!-- This comment fixes IE6's logo problem. Might be temporary until we've got content below this point -->
    <div class=\'nN-footerLinks\'>
	<a href=\'http://www.fairfaxdigital.com.au\' class=\'logo\'>Fairfax Media</a>
	<div>
        <h3>Our Sites</h3>
    <ul>
            <li class=\'first\'>
                <a title=\'The Sydney Morning Herald\' href=\'http://www.smh.com.au/\'>The Sydney Morning Herald</a>
            </li>
            <li>
                <a title=\'The Age\' href=\'http://www.theage.com.au/\'>The Age</a>
            </li>
            <li>
                <a title=\'MyCareer\' href=\'http://mycareer.com.au/\'>MyCareer</a>
            </li>
            <li>
                <a title=\'Domain\' href=\'http://www.domain.com.au/\'>Domain</a>
            </li>
            <li>
                <a title=\'Drive\' href=\'http://www.drive.com.au/\'>Drive</a>
            </li>
            <li>
                <a title=\'RSVP\' href=\'http://www.rsvp.com.au/\'>RSVP</a>
            </li>
            <li>
                <a title=\'Essential Baby\' href=\'http://www.essentialbaby.com.au/\'>Essential Baby</a>
            </li>
            <li>
                <a title=\'InvestSMART\' href=\'http://www.investsmart.com.au/\'>InvestSMART</a>
            </li>
            <li>
                <a title=\'APM\' href=\'http://apm.com.au/\'>APM</a>
            </li>
            <li>
                <a title=\'Stayz\' href=\'http://www.stayz.com.au/\'>Stayz</a>
            </li>
            <li>
                <a title=\'Weatherzone\' href=\'http://www.weatherzone.com.au/\'>Weatherzone</a>
            </li>
            <li>
                <a title=\'TheVine\' href=\'http://www.thevine.com.au/#utm_source=FD&utm_medium=mastheadpuff&utm_campaign=thevineheader\'>TheVine</a>
            </li>
    </ul>

        <h3>Our Partners</h3>
    <ul>
            <li class=\'first\'>
                <a title=\'Buy & Sell\' href=\'http://www.buyandsell.com.au/\'>Buy & Sell</a>
            </li>
            <li>
                <a title=\'Cruises\' href=\'http://www.cruises.com.au\'>Cruises</a>
            </li>
            <li>
                <a title=\'Lawyers\' href=\'http://www.lawyers.com.au/\'>Lawyers</a>
            </li>
            <li>
                <a title=\'Credit Cards\' href=\'http://www.creditcards.com.au/\'>Credit Cards</a>
            </li>
            <li>
                <a title=\'Business\' href=\'http://www.business.com.au/\'>Business</a>
            </li>
            <li>
                <a title=\'Mechanics\' href=\'http://www.mechanics.com.au/\'>Mechanics</a>
            </li>
            <li>
                <a title=\'Electricians\' href=\'http://www.electrician.com.au/\'>Electricians</a>
            </li>
            <li>
                <a title=\'Fitness\' href=\'http://www.fitness.com.au/\'>Fitness</a>
            </li>
            <li>
                <a title=\'Hair Salons\' href=\'http://www.hairsalon.com.au/\'>Hair Salons</a>
            </li>
            <li>
                <a title=\'Weddings\' href=\'http://www.wedding.com.au/\'>Weddings</a>
            </li>
            <li>
                <a title=\'Home Builder\' href=\'http://www.homebuilders.com.au/\'>Home Builder</a>
            </li>
            <li>
                <a title=\'Cracker\' href=\'http://cracker.com.au/\'>Cracker</a>
            </li>
    </ul>

    </div>
    <cite>Copyright &copy; 2013 Fairfax Media</cite>
</div>
        <div class=\'Kampyle\' data-kampyleFormId=\'43617\' data-kampyleSiteCode=\'2587051\'>
        <a id=\'kampylink\' class=\'k_static\' href=\'http://www.kampyle.com/feedback_form/ff-feedback-form.php?site_code=2587051&lang=en&form_id=43617\' target=\'kampyleWindow\'>
            <img src=\'http://resources.brisbanetimes.com.au/brisbanetimes/media-common-1.0/images/feedback-button.gif\' alt=\'Feedback Form\' style=\'border:0\'/>
        </a>
    </div><!-- class:Kampyle -->

</div>
  
<!-- End fN-footerNetwork -->
        <div id=\'adspot-1x1\' class=\'ad\'> <script> renderJAd(\'adspot-1x1\', \'dcAd-15\', 'http://ad-apac.doubleclick.net/adj/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;' + document.dcAdsCParams +'sz=1x1;tile=15;ord=' + dcOrd + '?', -1634491218); </script> <noscript> <a href='http://ad-apac.doubleclick.net/jump/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;sz=1x1;tile=15;ord=6.029626E7?' target=\'_blank\'> <img src='http://ad-apac.doubleclick.net/ad/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;sz=1x1;tile=15;ord=6.029626E7?' border=\'0\' alt=\'\'> </a> </noscript> </div>
        <div id=\'adspot-1x11\' class=\'ad\'> <script> renderJAd(\'adspot-1x11\', \'dcAd-16\', 'http://ad-apac.doubleclick.net/adj/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;' + document.dcAdsCParams +'sz=1x11;tile=16;ord=' + dcOrd + '?', -1947531258); </script> <noscript> <a href='http://ad-apac.doubleclick.net/jump/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;sz=1x11;tile=16;ord=6.029626E7?' target=\'_blank\'> <img src='http://ad-apac.doubleclick.net/ad/onl.bt.news/national/queensland;cat1=queensland;cat=national;ctype=article;sz=1x11;tile=16;ord=6.029626E7?' border=\'0\' alt=\'\'> </a> </noscript> </div>
    </div><!-- class:wrap cfix -->
</div><!-- class:outerWrap -->
<div id=\'network-strip\' class=\'network-strip-wrap\'>
    <div class=\'network-strip cf\'>
    <ul class=\'nav edition\' role=\'menu\'>
            <li role=\'menuitem\' id=\'whiteStrip-time\'><em>4:30PM</em> Saturday Jun 29, 2013</li>
        
    
    
<li role=\'menuitem\'>
    <span>Do you know more about a story?</span>
    <div class=\'dropdown-panel\'>
        <button class=\'dropdown-panel-toggle generic-selector\' aria-owns=\'box-contact\' aria-haspopup=\'true\' title=\'contact us\'><span class=\'icon ddown\'>contact us</span></button>

            <div id=\'box-contact\' class=\'dropdown-content dropdown-content-contact generic-selector\'>
                <button class=\'close generic-selector\' title=\'close\'>Close</button>
                <form method=\'GET\' action=\'mailto:scoop@brisbanetimes.com.au\'>
                    <label class=\'h4\'>Provide detailed information, including contact details (if relevant)</label>
                    <textarea name=\'body\'></textarea>
                    <input type=\'hidden\' name=\'subject\' value=\'Tip\'>
                    <input type=\'submit\' value=\'Post\' class=\'btn\'>
                </form>
            </div>
    </div>
</li>
</ul>

        <ul class=\'nav external\' role=\'menu\'>
<li><a href=\'http://www.domain.com.au/\' onclick=\'linktop(this);\'>Real Estate</a></li>
<li><a href=\'http://www.drive.com.au/\' onclick=\'linktop(this);\'>Cars</a></li>
<li><a href=\'http://mycareer.com.au/\' onclick=\'linktop(this);\'>Jobs</a></li>
<li><a href=\'http://www.rsvp.com.au/\' onclick=\'linktop(this);\'>Dating</a></li>
<li><a href=\'https://membercentre.fairfax.com.au/NewsletterSubscription.aspx\' onclick=\'linktop(this);\'>Newsletters</a></li>

    <li class=\'menuitem\'>
        <div class=\'dropdown-panel\'>
            <button class=\'dropdown-panel-toggle generic-selector\' aria-owns=\'box-network\' aria-haspopup=\'true\'>Fairfax Media Network<span class=\'icon ddown\'>More</span></button>

                <div id=\'box-network\' class=\'dropdown-content dropdown-content-logos\'>
                    <button class=\'close generic-selector\' title=\'close generic-selector\'>Close</button>
                    <div class=\'logos cf\'>
                        <div class=\'col\'>
                            <h4>News &amp; Weather</h4>
                            <ul role=\'navigation\'>
                                    <li class=\'smh\'><a href=\'http://www.smh.com.au\' title=\'The Sydney Morning Herald\'>smh.com.au</a></li>
                                    <li class=\'theage\'><a href=\'http://www.theage.com.au\' title=\'The Age\'>theage.com.au</a></li>
                                    <li class=\'brisbanetimes\'><a href=\'http://www.brisbanetimes.com.au\' title=\'Brisbane Times\'>brisbanetimes.com.au</a></li>
                                    <li class=\'canberratimes\'><a href=\'http://www.canberratimes.com.au\' title=\'Canberra Times\'>canberratimes.com.au</a></li>
                                    <li class=\'nationaltimes\'><a href=\'http://www.nationaltimes.com.au\' title=\'National Times\'>nationaltimes.com.au</a></li>
                                    <li class=\'watoday\'><a href=\'http://www.watoday.com.au\' title=\'WA Today\'>watoday.com.au</a></li>
                                    <li class=\'weatherzone\'><a href=\'http://www.weatherzone.com.au\' title=\'Weather Zone\'>weatherzone.com.au</a></li>
                            </ul>
                        </div>
                        <div class=\'col\'>
                            <h4>Business &amp; Finance</h4>
                            <ul role=\'navigation\'>
                                    <li class=\'businessday\'><a href=\'http://www.businessday.com.au\' title=\'Business Day\'>businessday.com.au</a></li>
                                    <li class=\'brw\'><a href=\'http://www.brw.com.au\' title=\'BRW\'>brw.com.au</a></li>
                                    <li class=\'afr\'><a href=\'http://www.afr.com\' title=\'AFR\'>afr.com</a></li>
                                    <li class=\'afrmagazine\'><a href=\'http://www.afrmagazine.com.au\' title=\'AFR Magzine\'>afrmagazine.com.au</a></li>
                                    <li class=\'smartinvestor\'><a href=\'http://www.smartinvestor.com.au\' title=\'SmartInvestor\'>smartinvestor.com.au</a></li>
                                    <li class=\'investsmart\'><a href=\'http://www.investsmart.com.au\' title=\'investSmart\'>investsmart.com.au</a></li>
                            </ul>
                        </div>
                        <div class=\'col\'>
                            <h4>Lifestyle</h4>
                            <ul role=\'navigation\'>
                                    <li class=\'lifestyle\'><a href=\'http://www.brisbanetimes.com.au/lifesyle\' title=\'LifeStyle\'>life &amp; style</a></li>
                                    <li class=\'dailylife\'><a href=\'http://www.dailylife.com.au\' title=\'Daily Life\'>dailylife.com.au</a></li>
                                    <li class=\'thevine\'><a href=\'http://www.thevine.com.au\' title=\'The Vine\'>thevine.com.au</a></li>
                                    <li class=\'essentialbaby\'><a href=\'http://www.essentialbaby.com.au\' title=\'Essential Baby\'>essentialbaby.com.au</a></li>
                                    <li class=\'essentialkids\'><a href=\'http://www.essentialkids.com.au\' title=\'Essential Kids\'>essentialkids.com.au</a></li>
                                    <li class=\'findababysitter\'><a href=\'http://www.findababysitter.com.au\' title=\'Find a Baby Sitter\'>findababysitter.com.au</a></li>
                                    <li class=\'goodfood\'><a href=\'http://www.goodfood.com.au\' title=\'Good Food\'>goodfood.com.au</a></li>
                            </ul>
                        </div>
                        <div class=\'col last\'>
                            <h4>Classifieds</h4>
                            <ul role=\'navigation\'>
                                    <li class=\'domain\'><a href=\'http://www.domain.com.au\' title=\'Domain\'>domain.com.au</a></li>
                                    <li class=\'drive\'><a href=\'http://www.drive.com.au\' title=\'Drive\'>drive.com.au</a></li>
                                    <li class=\'mycareer\'><a href=\'http://www.mycareer.com.au\' title=\'MyCareer\'>mycareer.com.au</a></li>
                                    <li class=\'rsvp\'><a href=\'http://www.rsvp.com.au\' title=\'RSVP\'>rsvp.com.au</a></li>
                                    <li class=\'stayz\'><a href=\'http://www.stayz.com.au\' title=\'Stayz\'>stayz.com.au</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=\'additional-links\'>
                        <ul class=\'nav\'>
                            <ul class=\'nav\'>
                                    <li><a href=\'http://adcentre.fairfaxdigital.com.au\' title=\'Advertise with us\'>Advertise with us</a></li>
                                    <li><a href=\'https://membercentre.fairfax.com.au/NewsletterSubscription.aspx\' title=\'Newsletters\'>Newsletters</a></li>
                                    <li><a href=\'http://www.fairfax.com.au/network-map.aspx\' title=\'Full list of sites\'>Full list of sites</a></li>
                                    <li><a href=\'http://fairfaxmedia.com.au\' title=\'About Fairfax Media\'>About Fairfax Media</a></li>
                                    <li><a href=\'http://www.fairfax.com.au/privacy\' title=\'Privacy\'>Privacy</a></li>
                                    <li><a href=\'http://www.fairfax.com.au/conditions\' title=\'Terms &amp; Conditions\'>Terms &amp; Conditions</a></li>
                            </ul>
                        </ul>
                    </div>
                </div>
        </div>
    </li>
</ul>

    </div>
</div><!-- class:network-strip-wrap -->


            <script type=\'text/javascript\'>

    var recommendOptions = {
        display: \'hidden\',
        pos: \'rhs\',
        size: {content: 5, rhs: 4},
        matchingMode: \'behavioral^50,contextual^25,trend^25\',
        maxResults: 30,
        siteOptions: {
            \'nationaltimes.com.au\': {display: \'off\'},
            \'businessday.com.au\': {display: \'off\'},
            \'moneymanager.com.au\': {display: \'off\'},
            \'goodfood.com.au\': {display: \'hidden\'},
            \'essentialbaby.com.au\': {display: \'hidden\'},
            \'essentialkids.com.au\': {display: \'hidden\'},
            \'dailylife.com.au\': {display: \'hidden\'},
            \'domain.com.au\': {display: \'hidden\'},
            \'drive.com.au\': {display: \'hidden\'}
        },
        sectionOptions: {
            \'Drive\': {display: \'off\'},
            \'Domain\': {size: {content: 5, rhs: 3}},
            \'Business\': {pos: \'content\'}
        }
    };

</script>


<div id=\'subscription-overlay\' class=\'subscription-overlay\'
     data-hagrid-channel-key=\'adsyxa3LYCxmhcrx-DmA7w\'
     data-hagrid-base-url=\'https://brisbanetimes.myfairfax.com.au\'
     data-hagrid-api-url=\'https://api.myfairfax.com.au\'
     data-hagrid-proxy-url=\'/originstatic/hagridproxy-0.9.22.html\'
     data-hagrid-iframe-container-id=\'loginIframeContainer\'
     data-drm-host=\'http://access.fairfaxapi.com.au\'
     data-hagrid-member-profile-provider-name=\'customMemberProfileProvider\'>
</div>

        <script type=\'text/javascript\' src=\'http://resources.brisbanetimes.com.au/common/media-common-1.0/js/fdjsf/output/7.24.6/fd_min.js\'></script>


        <script type=\'text/javascript\' src=\'http://resources.brisbanetimes.com.au/common/media-common-1.0/js/fdjsf/output/7.24.6/fd.google_min.js\'></script>

        <script type=\'text/javascript\' src=\'http://resources.brisbanetimes.com.au/common/media-common-1.0/js/fdjsf/output/7.24.6/fd.registrars_min.js\'></script>

    <script type=\'text/javascript\'>
    if (FD.JSSDK) {

    window.customMemberProfileProvider = (function() {
        var module = {};
        var env = \'\';
        var COOKIE_NAME = \'ffx_mm_token\' + (env ? '_' + env : '');
        var DAYS_TO_EXPIRE = 30;
        module.get = function() {
            var cookie = FD.getCookie(COOKIE_NAME);
            if (cookie && cookie != \'\') {
                return {member_token: cookie };
            }
            return null;
        }
        module.set = function(profile, expires) {
            if (!expires) {
                expires = Date.now() + DAYS_TO_EXPIRE * 24 * 60 * 60 * 1000;
            }
            FD.setCookie(COOKIE_NAME, profile.member_token, expires, '/', 'brisbanetimes.com.au');
        };
        module.clear = function() {
            FD.setCookie(COOKIE_NAME, null, null, '/', 'brisbanetimes.com.au');
        };
        return module;
    }(document));

    window.ffxReady = function() {
        FD.bind(\'FDHagridLogin\', function() {
            if (FFXHagrid.isLoggedIn()) {
                FD.trigger(\'FDMyMastheadCompleteLogin\', \'http://www.brisbanetimes.com.au\');
            }
            FFXHagrid.setDocumentDomain(document.domain);
            FFXHagrid.login({ui: 'iframe'});
        });
        FD.bind(\'FDHagridLogout\', function() {
            FFXHagrid.setDocumentDomain(document.domain);
            FFXHagrid.logout({ui: 'iframe'});
        });
        FFXHagrid.on('login', function() {
            if (FFXHagrid.isLoggedIn()) {
                FD.trigger(\'FDMyMastheadCompleteLogin\',  \'http://www.brisbanetimes.com.au\');
            }
        });
        FFXHagrid.on('logout', function() {
            window.location.href = \'http://www.brisbanetimes.com.au/ugc/logout.html\';
        });

        FD.bind(\'FDDrmSubscribe\', function() {
            FFXHagrid.subscribe({ui: 'fullpage'});
        });
        FD.bind(\'FDDrmActivate\', function() {
            FFXHagrid.activatePrintSubscription({ui: 'fullpage'});
        });
        var profileProvider = FFXDRM.DefaultUserProfileProvider(), drmclient = FFXDRM.DRMClient({ userProfileProvider: profileProvider });
        drmclient.on('accessdenied', function(reason, requiredPlans, limit) {
            FD.s_prop24=reason;
            FD.trigger(\'FDDrmInfo\', [reason, limit]);
        });
        drmclient.on('accessallowed', function() {
            FD.s_prop24='accessallowed';
        });
        drmclient.on('showmeter', function(count, limit) {
            FD.trigger(\'FDDrmMeter\', [count, limit]);
        });

        (function() {
            var asset = {
                id: '4530243',
                types: ['article'],
                sources: ['AAP'],
                categories: ['Queensland']
            };
            FD.trigger(\'FDDrmCheckPermissions\', [drmclient, 'brisbanetimes', asset, FFXHagrid.getUserPlansProvider()]);
        })();
    };

    (function(d) {
        var js = d.createElement('script'),
                ref = d.getElementsByTagName('script')[0];
        js.src = \'http://resources.fairfax.com.au/js/ffx-sdk/ffx-hagrid-drm-0.9.22.min.js\';
        js.async = true;
        js.id = 'ffx-script';
        js.setAttribute('data-hagrid-channel-key', 'adsyxa3LYCxmhcrx-DmA7w');
        js.setAttribute('data-hagrid-base-url', 'https://brisbanetimes.myfairfax.com.au');
        js.setAttribute('data-hagrid-api-url', 'https://api.myfairfax.com.au');
        js.setAttribute('data-hagrid-proxy-url', '/originstatic/hagridproxy-0.9.22.html');
        js.setAttribute('data-hagrid-iframe-container-id', 'loginIframeContainer');
        js.setAttribute('data-drm-host', 'http://access.fairfaxapi.com.au');
        js.setAttribute('data-hagrid-member-profile-provider-name', 'customMemberProfileProvider');
        ref.parentNode.insertBefore(js, ref);
    }(document));
}
</script>
<div data-brandName=\'brisbanetimes\'></div>
        <script type=\'text/javascript\' src=\'http://resources.brisbanetimes.com.au/common/media-common-1.0/js/fdjsf/output/7.24.6/fd.videoplayer_min.js\'></script>



            <script type=\'text/javascript\' src=\'http://resources.brisbanetimes.com.au/common/media-common-1.0/js/fdjsf/output/7.24.6/fd.registrars.mymasthead_min.js\'></script>

        <script type=\'text/javascript\' src=\'http://resources.brisbanetimes.com.au/common/media-common-1.0/js/fdjsf/output/7.24.6/fd.registrars.contentpagewide_min.js\'></script>

    <script type=\'text/javascript\'>
    (function() {
        new FD.UserHistoryRecommendations({
            \'assetId\': \'4530243\'
        })
     })();
    </script>

<script type=\'text/javascript\'>
    (function() {
            var jsonFragmentData0 = {\'stopRecommend\':true,\'name\':\'2f8rg\',\'listName\':\'Brisbane Times Homepage Recommend Fragment 1\',\'matchingModes\':{},\'defaultAssets\':[{\'pos\':0,\'rank\':0},{\'pos\':0,\'rank\':1},{\'pos\':0,\'rank\':2},{\'pos\':0,\'rank\':3},{\'pos\':0,\'rank\':4}],\'groups\':[],\'allDomains\':[],\'allTypes\':[]};
            if (!jsonFragmentData0.stopRecommend) {
                new FD.RecommendationsFragment({
                    \'baseUrl\': \'http://www.brisbanetimes.com.au\',
                    \'serviceUrl\': \'http://fairfax.cxsearch.cxense.com/api/recommendation\',
                    \'fragmentData\': jsonFragmentData0,
                    \'cookiePrefix\': \'ffx_home_rec_\',
                    \'maxGroups\': 5,
                    \'frequency\': 5,
                    \'debugMode\': false
                });
            }
    })();
</script>


<script type=\'text/javascript\'>
    function getGoogleAdChannel(showAboveArticle) {
        var googleAdChannel = \'Queensland\';
        if (showAboveArticle) {
            googleAdChannel += \' abovearticle\';
        }
        return googleAdChannel;
    }
    function google_ad_request_done(google_ads) {
        var googleAd = new FD.GoogleAd({
                adBlockTitle: \'Ads by Google\',
                maximumAdsInBlock: 3,
                checkExternalReferrer: true,
                split: 1,
            googleAds: google_ads,
            googleAdsId: \'googleAds\',
            moreGoogleAdsId: \'moreGoogleAds\'
        });
        googleAd.insertGoogleAds();
    }
    var google_ad_client = \'ca-fairfax-brisbanetimes_js\';
    var google_ad_channel = \'National\';
    var google_max_num_ads = \'4\';
        var externalReferrer = FD.getCookie(\'externalReferrer\');
        if (FD.showExternalReferrerAd(externalReferrer)) {
            google_ad_channel = getGoogleAdChannel(true);
        } else {
            google_max_num_ads = \'3\';
        }
    var google_ad_output = \'js\';
    var google_ad_type = \'text\';
    var google_encoding = \'utf8\';
    var google_safe = \'high\';
    var google_ad_section = \'default\';
</script>
<!-- The JavaScript returned from the following page uses the parameter values assigned above to populate an array of
ad objects. Once that array has been populated, the JavaScript will call the google_ad_request_done function to display
the ads. -->
<script type=\'text/javascript\' src=\'http://pagead2.googlesyndication.com/pagead/show_ads.js\'></script> 
<script type=\'text/javascript\'>
    (function() {
        
    })();
</script>
<script type=\'text/javascript\'>
    (function() {
                (function() {
        FD.addVideoPlayer(new FD.VideoPlayer({
            \'adServerUrl\': \'http://ad-apac.doubleclick.net/pfadx/vid.bt/entertainment/theguide;channel=entertainment;show=theguide;ctype=rhs;cat3=fdp;sz=4x1,4x2;dcmt=text/html;ord=589712\',
            \'assetId\': \'4528886\',
            \'divId\': \'video-player-latest\',
            \'playerId\': \'video-player-latest-player\',
            \'playerType\': \'Article_rhs\',
            \'postPlay\': \'\'
        }, {
            \'height\': 170,
            \'modes\': [{
                \'config\': {
                    \'playlist\': [
    {
                    \'levels\': [
                    {
                        \'bitrate\': \'779\',
                        \'file\': \'http://mediadownload.f2.com.au/flash/media/2013/06/28/4528886/4528886_high.mp4\'
                    },
                    {
                        \'bitrate\': \'536\',
                        \'file\': \'http://mediadownload.f2.com.au/flash/media/2013/06/28/4528886/4528886_ihigh.mp4\'
                    },
                    {
                        \'bitrate\': \'505\',
                        \'file\': \'http://mediadownload.f2.com.au/flash/media/2013/06/28/4528886/4528886_low.mp4\'
                    },
                    {
                        \'bitrate\': \'503\',
                        \'file\': \'http://mediadownload.f2.com.au/flash/media/2013/06/28/4528886/4528886_mid.mp4\'
                    },
                    {
                        \'bitrate\': \'360\',
                        \'file\': \'http://mediadownload.f2.com.au/flash/media/2013/06/28/4528886/4528886_imid.mp4\'
                    },
                    {
                        \'bitrate\': \'193\',
                        \'file\': \'http://mediadownload.f2.com.au/flash/media/2013/06/28/4528886/4528886_ilow.mp4\'
                    }
            ],
            \'image\': \'http://images.brisbanetimes.com.au/2013/06/28/4528986/1_vd-shitsville-express-190x107.jpg\',
        \'title\': \'Sh*tsville Express: Review\'
    }
]
                },
                \'src\': \'http://resources.brisbanetimes.com.au/common/media-common-1.0/swf/jwplayer/player.swf\',
                \'type\': \'flash\'
            }, {
                \'config\': {
                    \'playlist\': [
    {
                    \'levels\': [
                    {
                        \'bitrate\': \'779\',
                        \'file\': \'http://mediadownload.f2.com.au/flash/media/2013/06/28/4528886/4528886_high.mp4\'
                    },
                    {
                        \'bitrate\': \'536\',
                        \'file\': \'http://mediadownload.f2.com.au/flash/media/2013/06/28/4528886/4528886_ihigh.mp4\'
                    },
                    {
                        \'bitrate\': \'505\',
                        \'file\': \'http://mediadownload.f2.com.au/flash/media/2013/06/28/4528886/4528886_low.mp4\'
                    },
                    {
                        \'bitrate\': \'503\',
                        \'file\': \'http://mediadownload.f2.com.au/flash/media/2013/06/28/4528886/4528886_mid.mp4\'
                    },
                    {
                        \'bitrate\': \'360\',
                        \'file\': \'http://mediadownload.f2.com.au/flash/media/2013/06/28/4528886/4528886_imid.mp4\'
                    },
                    {
                        \'bitrate\': \'193\',
                        \'file\': \'http://mediadownload.f2.com.au/flash/media/2013/06/28/4528886/4528886_ilow.mp4\'
                    }
            ],
            \'image\': \'http://images.brisbanetimes.com.au/2013/06/28/4528986/1_vd-shitsville-express-190x107.jpg\',
        \'title\': \'Sh*tsville Express: Review\'
    }
]
                },
                \'type\':\'html5\'
            }],
            \'plugins\': {
    \'googima\': {
    \'ad\': {
                \'ad0\': {
            \'position\': \'pre\',
            \'tag\': \'http://ad-apac.doubleclick.net/pfadx/vid.bt/entertainment/theguide;channel=entertainment;show=theguide;ctype=rhs;cat3=fdp;sz=4x1,4x2;dcmt=text/html;ord=589712\',
            \'targets\': [\'video-player-companion-ad-mrec\', \'video-player-companion-ad-gutter\', \'video-player-companion-ad-helmet\'],
            \'type\': \'graphical_full_slot\'
        }

        }
    },
    \'timeslidertooltipplugin-2\': {}
},
            \'skin\': \'http://resources.brisbanetimes.com.au/common/media-common-1.0/swf/jwplayer/nacht.zip\',
            \'width\': 300
        }, {
            \'ga\': {
    \'channel\': \'Entertainment\',
    \'duration\': \'319\',
    \'headline\': \'Sh*tsville Express: Review\',
    \'referrer\': \'\',
    \'playerType\': \'Article_rhs\',
    \'showName\': \'The Guide\'
}
,
            \'nielsen\': {
    \'brand\': \'brisbanetimes\',
        \'cg\': \'fairfax-entertainment\',
        \'c6\': \'c14\',
    \'duration\': \'319\',
    \'ou\': \'video/entertainment/the-guide\',
    \'vc\': \'vc-bt-Video_Entertainment-Article_rhs-Video_The_Guide-SMH_Selections-Tessa_Stevens-4528886-Sh*tsville_Express:_Review-00:05:19\'
},
            \'cxense\': {
            \'acc\': \'9222289450909507104\',
        \'sid\': \'9222289450909507105\',
        \'contentId\': \'dcds_4528886\',
        \'loc\': \'http://media.brisbanetimes.com.au/selections/shtsville-express-review-4528886.html\'
},
            \'collector\': {
    \'system\': \'DCDS\',
    \'brand\': \'btimes\',
    \'section\': \'Video Entertainment\',
    \'assetId\': \'4528886\',
    \'title\': \'Sh*tsville Express: Review\',
    \'assetType\': \'Video\',
    \'assetUrl\': \'http://media.brisbanetimes.com.au/selections/shtsville-express-review-4528886.html\'
}
        }));
     })();


    })();
</script>
<script type=\'text/javascript\'>
if(document.location.protocol=='http:'){
 var Tynt=Tynt||[];Tynt.push('dzkkhEwwyr34jFadbiUt4I');
 (function(){var s=document.createElement('script');s.async=\'async\';s.type=\'text/javascript\';s.src='http://tcr.tynt.com/ti.js';var h=document.getElementsByTagName('script')[0];h.parentNode.insertBefore(s,h);})();
}
</script>

<script type=\'text/javascript\'>
    if (window[\'FD\']) {
        (function() {
            // Check that the user is at least logged in before attempting to say that they have read an article.
            if (FD.isLoggedIn()) {
                FD.trigger(\'FDArticleRead\');
            } else {
                FD.trigger(\'FDMyMastheadAccountLoginPrompt\');
            }
        })();
    }
</script>
<script type=\'text/javascript\'>
    if (document.googleMapConfiguration) {
        document.write(\'<script src='http://maps.googleapis.com/maps/api/js?client=gme-fairfax&sensor=false&channel=brisbanetimescomau' type='text/javascript'><\/script>\');
    }
</script>
        <script type=\'text/javascript\' src=\'http://resources.brisbanetimes.com.au/common/media-common-1.0/js/fdjsf/output/7.24.6/fd.registrars.googlemap_min.js\'></script>

<div class=\'hidden\' id=\'adShD0\'> <script type=\'text/javascript\'> if (0 < document.dcdAdsU.length) { document.write('<scr' + 'ipt type=\'text\/javascript\' id=\'' + document.dcdAdsI[0] + '\' src=\'' + document.dcdAdsU[0] + '\'><\/scr' + 'ipt>'); } </script> </div> <div class=\'hidden\' id=\'adShD1\'> <script type=\'text/javascript\'> if (1 < document.dcdAdsU.length) { document.write('<scr' + 'ipt type=\'text\/javascript\' id=\'' + document.dcdAdsI[1] + '\' src=\'' + document.dcdAdsU[1] + '\'><\/scr' + 'ipt>'); } </script> </div> <div class=\'hidden\' id=\'adShD2\'> <script type=\'text/javascript\'> if (2 < document.dcdAdsU.length) { document.write('<scr' + 'ipt type=\'text\/javascript\' id=\'' + document.dcdAdsI[2] + '\' src=\'' + document.dcdAdsU[2] + '\'><\/scr' + 'ipt>'); } </script> </div> <div class=\'hidden\' id=\'adShD3\'> <script type=\'text/javascript\'> if (3 < document.dcdAdsU.length) { document.write('<scr' + 'ipt type=\'text\/javascript\' id=\'' + document.dcdAdsI[3] + '\' src=\'' + document.dcdAdsU[3] + '\'><\/scr' + 'ipt>'); } </script> </div> <div class=\'hidden\' id=\'adShD4\'> <script type=\'text/javascript\'> if (4 < document.dcdAdsU.length) { document.write('<scr' + 'ipt type=\'text\/javascript\' id=\'' + document.dcdAdsI[4] + '\' src=\'' + document.dcdAdsU[4] + '\'><\/scr' + 'ipt>'); } </script> </div> <div class=\'hidden\' id=\'adShD5\'> <script type=\'text/javascript\'> if (5 < document.dcdAdsU.length) { document.write('<scr' + 'ipt type=\'text\/javascript\' id=\'' + document.dcdAdsI[5] + '\' src=\'' + document.dcdAdsU[5] + '\'><\/scr' + 'ipt>'); } </script> </div> <script type=\'text/javascript\'> initAds(false); checkAds(\'817-grey.gif\'); window.setTimeout('pingAdStatus()', 10000); </script>

<!-- START Google Analytics Tracking -->
<script type=\'text/javascript\'>
    var _gaq = _gaq || [];
    _gaq.push(['_setAccount', 'UA-22700242-3']);
    _gaq.push(['_setDomainName', '.brisbanetimes.com.au']);
    _gaq.push(['_addIgnoredRef', 'brisbanetimes.com.au']);
    _gaq.push(['_setAllowAnchor', true]);
    _gaq.push(['_setCustomVar', 1, 'Section', 'Queensland', 3]);
    _gaq.push(['_setCustomVar', 2, 'Sub-Section', '', 3]);
    _gaq.push(['_setCustomVar', 3, 'Byline', '', 3]);
    _gaq.push(['_setCustomVar', 4, 'Page Type', 'Article', 3]);
    _gaq.push(['_setAllowAnchor', true]);
    _gaq.push(['_setCampaignCookieTimeout', 1209600000]);
    // Check whether the user is logged in.
    var loggedIn = false;
    if (window[\'FD\']) {
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
<script type=\'text/javascript\' src=\'//secure-au.imrworldwide.com/v60.js\'></script>
<script type=\'text/javascript\'>
    var pvar = {cid:\'f2\', content:\'BrisbaneTimes-queensland-story-online\', server:\'secure-au\'};
    var trac = nol_t(pvar);
    trac.record().post();
    window.s_pageName = \'brisbanetimes:article:queensland:girl, 17, dies in southeast queensland crash\';
</script>
<noscript>
    <div>
        <img src=\'//secure-au.imrworldwide.com/cgi-bin/m?ci=f2&amp;cg=0&amp;cc=1&amp;ts=noscript\' width=\'1\' height=\'1\' alt=\'\'/>
    </div>
</noscript>
    <!--end of if !suppressNielsen -->
<!-- END Nielsen Online SiteCensus V6.0 -->
    <script type=\'text/javascript\'>
	if (window[\'FD\']) {
		/**
		 * Initiates the client side asset view tracking component (self executing).
		 */
		(function() {
			FD.pingServerWithSuccessCallback(\'4530243\', \'Article\', \'Queensland\', FD.updateWhiteStrip);
		})();
	}
</script>

<!-- FFX analytics stuff -->
<script>
    var _fmaq = _fmaq || [];
        _fmaq.push([\'_trackEvent\', [
            [\'event\', \'view\'],
            [\'system\', \'DCDS\'],
            [\'site\', \'btimes\'],
            [\'assetCategory\', \'Queensland\'],
            [\'asset\', \'4530243\'],
            [\'title\', \'Girl, 17, dies in southeast Queensland crash\'],
            [\'assetType\', \'Article\']
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
    <script type=\'text/javascript\'>
        var cX_ffx_customParameters = cX_ffx_customParameters || {};
        cX_ffx_customParameters.ffx_contentid = 'dcds_4530243';
    </script>
    <div id=\'cX-root\' style=\'display:none\'></div>
    <script type=\'text/javascript\'>
        var cX = cX || {}; cX.callQueue = cX.callQueue || [];
        cX.callQueue.push(['setAccountId', '9222289450909507104']);
        cX.callQueue.push(['setSiteId', '9222289450909507105']);
        if (cX_ffx_customParameters) {
            cX.callQueue.push(['setCustomParameters', cX_ffx_customParameters]);
        }
        cX.callQueue.push(['sendPageViewEvent']);
    </script>
    <script type=\'text/javascript\'>
        (function() { try { var scriptEl = document.createElement('script'); scriptEl.type = 'text/javascript'; scriptEl.async = 'async';
            scriptEl.src = ('https:' == document.location.protocol) ? 'https://scdn.cxense.com/cx.js' : 'http://cdn.cxense.com/cx.js';
            var targetEl = document.getElementsByTagName('script')[0]; targetEl.parentNode.insertBefore(scriptEl, targetEl); } catch (e) {};} ());
    </script>


<!-- Adobe Marketing Cloud Tag Management code
Copyright 1996-2012 Adobe, Inc. All Rights Reserved
More info available at http://www.adobe.com -->
<script type=\'text/javascript\' src=\'http://resources.brisbanetimes.com.au/common/media-common-1.0/js/s_code.js\'></script>
<script type=\'text/javascript\'>
if(s && !(window[\'FD\'] && FD.isRefreshedHomepage())){
    s.pageName = \'btimes:Queensland:::Girl, 17, dies in southeast Queensland crash:4530243\'
    s.prop1 = \'btimes\'
    s.prop2 = \'Queensland\'
    s.prop7 = \'Article\'
    s.prop8 = \'4530243 + Girl, 17, dies in southeast Queensland crash\'
    s.prop31 = \'\'
    s.prop32 = \'2013-06-29\'
    if (window[\'FD\']) {
        if (typeof FD.s_prop24 !== \'undefined\') {
            s.prop24 = FD.s_prop24
        }
    }
    s.t()
}
</script>
<!-- End Adobe Marketing Cloud Tag Management code -->


<!-- Google Code for Remarketing tag -->
<!-- Remarketing tags may not be associated with personally identifiable information or placed on pages related to sensitive categories. For instructions on adding this tag and more information on the above requirements, read the setup guide: google.com/ads/remarketingsetup -->
<script type=\'text/javascript\'>
/* <![CDATA[ */
var google_conversion_id = '1066375035';
var google_conversion_label = 'xs3OCPm5kQUQ-66-_AM';
var google_custom_params = window.google_tag_params;
var google_remarketing_only = true;
/* ]]> */
</script>
<script type=\'text/javascript\' src=\'http://www.googleadservices.com/pagead/conversion.js\'>
</script>
<noscript>
<div style=\'display:inline;\'>
<img height=\'1\' width=\'1\' style=\'border-style:none;\' alt=\'\' src=\'http://googleads.g.doubleclick.net/pagead/viewthroughconversion/1066375035/?value=0&label=xs3OCPm5kQUQ-66-_AM&guid=ON&script=0\'/>
</div>
</noscript>
<!-- End Google Code for Remarketing tag -->
<script type=\'text/javascript\'>
if (window[\'FD\']) {
    FD.trigger(\'FDTrackReady\');
}
</script>
    <script type=\'text/javascript\' src=\'http://widgets.outbrain.com/outbrain.js\'></script>

        <div id=\'fb-root\'></div><!-- id:fb-root -->
        <script src=\'http://connect.facebook.net/en_US/all.js\' type=\'text/javascript\'></script>
        <script type=\'text/javascript\'>
            window.fbAsyncInit = function() {
                FB.init({
                        appId: \'210857855632030\',
                    cookie: true,
                    status: true,
                    xfbml: true
                });
                FD.register(function() {
                    new FD.Facebook({});
                });
            };
        </script>
        <script src=\'https://apis.google.com/js/plusone.js\' type=\'text/javascript\'></script>
        <script src=\'http://platform.linkedin.com/in.js\' type=\'text/javascript\'>
                api_key: qottgxmkkl6f
            authorize: true
        </script>
        <script src=\'http://platform.twitter.com/widgets.js\' type=\'text/javascript\'></script>
        <script src=\'http://widgets.twimg.com/j/2/widget.js\' type=\'text/javascript\'></script>
    <div data-boomerangSegment=\'132487\'></div>
        <script type=\'text/javascript\' src=\'http://resources.brisbanetimes.com.au/common/media-common-1.0/js/fdjsf/output/7.24.6/fd.registrars.social_min.js\'></script>



 

        <script type=\'text/javascript\' src=\'http://resources.brisbanetimes.com.au/common/media-common-1.0/js/fdjsf/output/7.24.6/fd.registrars.images.httppipelining_min.js\'></script>

</body>
</html>";
            }
        }
    }
}
