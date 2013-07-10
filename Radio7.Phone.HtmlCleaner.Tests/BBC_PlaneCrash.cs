﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Radio7.Phone.HtmlCleaner.Tests
{
    internal class BBC_PlaneCrash
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
                return @"<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML+RDFa 1.0//EN"" ""http://www.w3.org/MarkUp/DTD/xhtml-rdfa-1.dtd"">


<html xmlns=""http://www.w3.org/1999/xhtml"" xmlns:og=""http://opengraphprotocol.org/schema/"" xmlns:rnews=""http://iptc.org/std/rNews/2011-10-07#"" xml:lang=""en-GB"">
        
    
    
    
	
    
    
    
    
    
    
    
	
    
	
    
	
	
	
	
    
	
    
        
    
<!-- THIS FILE CONFIGURES SHARED HIGHWEB STATIC ASSETS -->





<!-- mapping_news.inc -->
<!-- THIS FILE CONFIGURES NEWS STATIC ASSETS  -->




<!-- THIS FILE CONFIGURES VOTE 2012 STATIC ASSETS  -->





    <!-- hi/shared/head_initial.inc -->



	


	        <head profile=""http://dublincore.org/documents/dcq-html/"" resource=""http://www.bbc.co.uk/news/world-us-canada-23214513"" typeof=""rnews:NewsItem"">
        <meta http-equiv=""X-UA-Compatible"" content=""IE=8"" />
        <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" />
        <title>BBC News - Boeing 777 plane crash-lands at San Francisco airport</title>
        <meta name=""Description"" content=""A Boeing 777 aircraft has crash-landed at San Francisco international airport, bursting into flames and killing at least two people.""/>
        <meta property=""rnews:description"" content=""A Boeing 777 aircraft has crash-landed at San Francisco international airport, bursting into flames and killing at least two people.""/>
                <meta name=""OriginalPublicationDate"" content=""2013/07/07 10:38:43""/>
        <meta property=""rnews:datePublished"" content=""2013/07/07 10:38:43""/>
        <meta name=""UKFS_URL"" content=""/news/world-us-canada-23214513""/>
                <meta name=""THUMBNAIL_URL"" content=""http://news.bbcimg.co.uk/media/images/68588000/jpg/_68588789_plane.jpg""/>
        <meta property=""rnews:thumbnailUrl"" content=""http://news.bbcimg.co.uk/media/images/68588000/jpg/_68588789_plane.jpg""/>
                <meta name=""Headline"" content=""Jet crash-lands at San Francisco""/>
        <meta property=""rnews:headline"" content=""Jet crash-lands at San Francisco""/>
        <meta name=""IFS_URL"" content=""/news/world-us-canada-23214513""/>
        <meta name=""Section"" content=""US &amp; Canada""/>
        <meta name=""contentFlavor"" content=""STORY""/>
		                        <meta name=""CPS_ID"" content=""23214513"" />
        <meta name=""CPS_SITE_NAME"" content=""BBC News"" />
        <meta name=""CPS_SECTION_PATH"" content=""World/US and Canada"" />
        <meta name=""CPS_ASSET_TYPE"" content=""STY"" />
        <meta name=""CPS_PLATFORM"" content=""HighWeb"" />
        <meta name=""CPS_AUDIENCE"" content=""International"" />
        <meta property=""rnews:creator"" content=""http://www.bbc.co.uk#org""/>        
        
            		<meta property=""og:title"" content=""Jet crash-lands at San Francisco""/>
    		<meta property=""og:type"" content=""article""/>
    		<meta property=""og:url"" content=""http://www.bbc.co.uk/news/world-us-canada-23214513""/>
    		<meta property=""og:site_name"" content=""BBC News""/>
            			<meta property=""og:image"" content=""http://newsimg.bbc.co.uk/media/images/67373000/jpg/_67373987_09f1654a-e583-4b5f-bfc4-f05850c6d3ce.jpg""/>
											        
				<meta name=""bbcsearch_noindex"" content=""atom""/>
		
        <link rel=""canonical"" href=""http://www.bbc.co.uk/news/world-us-canada-23214513"" />
       	        		        
        
        
        
        <!-- hi/news/head_first.inc -->
<meta name=""application-name"" content=""BBC News"" />
<meta name=""msapplication-TileImage"" content=""/img/1_0_2/cream/hi/news/bbc-news-pin.png"" />
<meta name=""msapplication-TileColor"" content=""#CC0101"" />
<meta name=""twitter:card"" value=""summary"" />
 
        
<!-- PULSE_ENABLED:yes -->
























	
	
	
		
		
	








	
			
		
	
	
	
	
	
	
	
	
	
	
	
	
	
	
		
	
		





	
		

    
   <meta http-equiv=""X-UA-Compatible"" content=""IE=8"" />  
  <link rel=""schema.dcterms"" href=""http://purl.org/dc/terms/"" />  <link rel=""index"" href=""http://www.bbc.co.uk/a-z/"" title=""A to Z"" /> <link rel=""copyright"" href=""http://www.bbc.co.uk/terms/"" title=""Terms of Use"" /> <link rel=""icon"" href=""http://www.bbc.co.uk/favicon.ico"" type=""image/x-icon"" />  <meta name=""viewport"" content=""width = 996"" /> 

 <link rel=""stylesheet"" type=""text/css"" href=""http://static.bbci.co.uk/frameworks/barlesque/2.48.3/desktop/3.5/style/main.css""  />  <script type=""text/javascript"">/*<![CDATA[*/ if (typeof bbccookies_flag === 'undefined') { bbccookies_flag = 'ON'; } showCTA_flag = false; cta_enabled = (showCTA_flag && (bbccookies_flag === 'ON') ); (function(){var e=""ckns_policy"",m=""Thu, 01 Jan 1970 00:00:00 GMT"",k={ads:true,personalisation:true,performance:true,necessary:true};function f(p){if(f.cache[p]){return f.cache[p]}var o=p.split(""/""),q=[""""];do{q.unshift((o.join(""/"")||""/""));o.pop()}while(q[0]!==""/"");f.cache[p]=q;return q}f.cache={};function a(p){if(a.cache[p]){return a.cache[p]}var q=p.split("".""),o=[];while(q.length&&""|co.uk|com|"".indexOf(""|""+q.join(""."")+""|"")===-1){if(q.length){o.push(q.join("".""))}q.shift()}f.cache[p]=o;return o}a.cache={};function i(o,t,p){var z=[""""].concat(a(window.location.hostname)),w=f(window.location.pathname),y="""",r,x;for(var s=0,v=z.length;s<v;s++){r=z[s];for(var q=0,u=w.length;q<u;q++){x=w[q];y=o+""=""+t+"";""+(r?""domain=""+r+"";"":"""")+(x?""path=""+x+"";"":"""")+(p?""expires=""+p+"";"":"""");bbccookies.set(y,true)}}}window.bbccookies={_setEverywhere:i,cookiesEnabled:function(){var o=""ckns_testcookie""+Math.floor(Math.random()*100000);this.set(o+""=1"");if(this.get().indexOf(o)>-1){g(o);return true}return false},set:function(o){return document.cookie=o},get:function(){return document.cookie},_setPolicy:function(o){return h.apply(this,arguments)},readPolicy:function(o){return b.apply(this,arguments)},_deletePolicy:function(){i(e,"""",m)},isAllowed:function(){return true},_isConfirmed:function(){return c()!==null},_acceptsAll:function(){var o=b();return o&&!(j(o).indexOf(""0"")>-1)},_getCookieName:function(){return d.apply(this,arguments)},_showPrompt:function(){return(!this._isConfirmed()&&window.cta_enabled&&this.cookiesEnabled()&&!window.bbccookies_disable)}};bbccookies._getPolicy=bbccookies.readPolicy;function d(p){var o=(""""+p).match(/^([^=]+)(?==)/);return(o&&o.length?o[0]:"""")}function j(o){return""""+(o.ads?1:0)+(o.personalisation?1:0)+(o.performance?1:0)}function h(r){if(typeof r===""undefined""){r=k}if(typeof arguments[0]===""string""){var o=arguments[0],q=arguments[1];if(o===""necessary""){q=true}r=b();r[o]=q}else{if(typeof arguments[0]===""object""){r.necessary=true}}var p=new Date();p.setYear(p.getFullYear()+1);p=p.toUTCString();bbccookies.set(e+""=""+j(r)+"";domain=bbc.co.uk;path=/;expires=""+p+"";"");bbccookies.set(e+""=""+j(r)+"";domain=bbc.com;path=/;expires=""+p+"";"");return r}function l(o){if(o===null){return null}var p=o.split("""");return{ads:!!+p[0],personalisation:!!+p[1],performance:!!+p[2],necessary:true}}function c(){var o=new RegExp(""(?:^|; ?)""+e+""=(\\d\\d\\d)($|;)""),p=document.cookie.match(o);if(!p){return null}return p[1]}function b(o){var p=l(c());if(!p){p=k}if(o){return p[o]}else{return p}}function g(o){return document.cookie=o+""=;expires=""+m+"";""}function n(){var o='<script type=""text/javascript"" src=""http://static.bbci.co.uk/frameworks/bbccookies/0.5.9/script/bbccookies.js""><\/script>';if(window.bbccookies_flag===""ON""&&!bbccookies._acceptsAll()&&!window.bbccookies_disable){document.write(o)}}n()})(); /*]]>*/</script>      <script type=""text/javascript""> if (! window.gloader) { window.gloader = [ ""glow"", {map: ""http://node1.bbcimg.co.uk/glow/glow/map.1.7.7.js""}]; } </script>  <script type=""text/javascript"" src=""http://node1.bbcimg.co.uk/glow/gloader.0.1.6.js""></script>   <script type=""text/javascript"" src=""http://static.bbci.co.uk/frameworks/requirejs/0.13.0/sharedmodules/require.js""></script> <script type=""text/javascript"">  bbcRequireMap = {""jquery-1"":""http://static.bbci.co.uk/frameworks/jquery/0.3.0/sharedmodules/jquery-1.7.2"", ""jquery-1.4"":""http://static.bbci.co.uk/frameworks/jquery/0.3.0/sharedmodules/jquery-1.4"", ""jquery-1.9"":""http://static.bbci.co.uk/frameworks/jquery/0.3.0/sharedmodules/jquery-1.9.1"", ""swfobject-2"":""http://static.bbci.co.uk/frameworks/swfobject/0.1.10/sharedmodules/swfobject-2"", ""demi-1"":""http://static.bbci.co.uk/frameworks/demi/0.9.8/sharedmodules/demi-1"", ""gelui-1"":""http://static.bbci.co.uk/frameworks/gelui/0.9.12/sharedmodules/gelui-1"", ""cssp!gelui-1/overlay"":""http://static.bbci.co.uk/frameworks/gelui/0.9.12/sharedmodules/gelui-1/overlay.css"", ""istats-1"":""http://static.bbci.co.uk/frameworks/istats/0.16.1/modules/istats-1"", ""relay-1"":""http://static.bbci.co.uk/frameworks/relay/0.2.4/sharedmodules/relay-1"", ""clock-1"":""http://static.bbci.co.uk/frameworks/clock/0.1.9/sharedmodules/clock-1"", ""canvas-clock-1"":""http://static.bbci.co.uk/frameworks/clock/0.1.9/sharedmodules/canvas-clock-1"", ""cssp!clock-1"":""http://static.bbci.co.uk/frameworks/clock/0.1.9/sharedmodules/clock-1.css"", ""jssignals-1"":""http://static.bbci.co.uk/frameworks/jssignals/0.3.6/modules/jssignals-1"", ""jcarousel-1"":""http://static.bbci.co.uk/frameworks/jcarousel/0.1.10/modules/jcarousel-1""}; require({ baseUrl: 'http://static.bbci.co.uk/', paths: bbcRequireMap, waitSeconds: 30 }); </script>      <script type=""text/javascript"" src=""http://static.bbci.co.uk/frameworks/barlesque/2.48.3/desktop/3.5/script/barlesque.js""></script>
  
<!--[if IE 6]>
        <script type=""text/javascript"">
        try {
            document.execCommand(""BackgroundImageCache"",false,true);
        } catch(e) {}
    </script>
        <style type=""text/css"">
        /* Use filters for IE6 */
        #blq-blocks a {
            background-image: none;
            filter: progid:DXImageTransform.Microsoft.AlphaImageLoader(src='http://static.bbci.co.uk/frameworks/barlesque/2.48.3/desktop/3.5//img/blq-blocks_white_alpha.png', sizingMethod='image');
        }
        .blq-masthead-focus #blq-blocks a,
        .blq-mast-text-dark #blq-blocks a {
            background-image: none;
            filter: progid:DXImageTransform.Microsoft.AlphaImageLoader(src='http://static.bbci.co.uk/frameworks/barlesque/2.48.3/desktop/3.5//img/blq-blocks_grey_alpha.png', sizingMethod='image');
        }
        #blq-nav-search button span {
            background-image: none;
            filter: progid:DXImageTransform.Microsoft.AlphaImageLoader(src='http://static.bbci.co.uk/frameworks/barlesque/2.48.3/desktop/3.5//img/blq-search_grey_alpha.png', sizingMethod='image');
        }
        #blq-nav-search button img {
            position: absolute;
            left: -999em;    
        }
    </style>
<![endif]-->

<!--[if (IE 7])|(IE 8)>
    <style type=""text/css"">
        .blq-clearfix {
            display: inline-block;
        }
    </style>
<![endif]-->

<script type=""text/javascript"">
     blq.setEnvironment('live');  if (blq.setLabel) blq.setLabel('searchSuggestion', ""Search"");  if (! /bbc\.co\.uk$/i.test(window.location.hostname) ) { document.documentElement.className += ' blq-not-bbc-co-uk'; } </script>

    <script type=""text/javascript""> if (! window.gloader) { window.gloader = [ ""glow"", {map: ""http://node1.bbcimg.co.uk/glow/glow/map.1.7.7.js""}]; } </script>
    <!-- BBCDOTCOM template:server-side journalismVariant: true ipIsAdvertiseCombined: true adsEnabled: false showDotcom: true flagpole: ON -->
                         
	

        
		<!-- shared/head -->
<meta http-equiv=""imagetoolbar"" content=""no"" />
<!--[if !(lt IE 6)]>
   	<link rel=""stylesheet"" type=""text/css"" href=""http://news.bbcimg.co.uk/view/3_0_16/cream/hi/shared/type.css"" />


		<link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""http://news.bbcimg.co.uk/view/3_0_16/cream/hi/shared/global.css"" />


	<link rel=""stylesheet"" type=""text/css"" media=""print"" href=""http://news.bbcimg.co.uk/view/3_0_16/cream/hi/shared/print.css"" />

	<link rel=""stylesheet"" type=""text/css"" media=""screen and (max-device-width: 976px)"" href=""http://news.bbcimg.co.uk/view/3_0_16/cream/hi/shared/mobile.css"" />
	



<link rel=""stylesheet"" type=""text/css"" href=""http://news.bbcimg.co.uk/view/3_0_16/cream/hi/shared/components/components.css"" />

<![endif]-->
<!--[if !IE]>-->
   	<link rel=""stylesheet"" type=""text/css"" href=""http://news.bbcimg.co.uk/view/3_0_16/cream/hi/shared/type.css"" />


		<link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""http://news.bbcimg.co.uk/view/3_0_16/cream/hi/shared/global.css"" />


	<link rel=""stylesheet"" type=""text/css"" media=""print"" href=""http://news.bbcimg.co.uk/view/3_0_16/cream/hi/shared/print.css"" />

	<link rel=""stylesheet"" type=""text/css"" media=""screen and (max-device-width: 976px)"" href=""http://news.bbcimg.co.uk/view/3_0_16/cream/hi/shared/mobile.css"" />
	



<link rel=""stylesheet"" type=""text/css"" href=""http://news.bbcimg.co.uk/view/3_0_16/cream/hi/shared/components/components.css"" />

<!--<![endif]-->
<script type=""text/javascript"">
/*<![CDATA[*/
gloader.load([""glow"",""1"",""glow.dom""],{onLoad:function(glow){glow.dom.get(""html"").addClass(""blq-js"")}});
gloader.load([""glow"",""1"",""glow.dom""],{onLoad:function(glow){glow.ready(function(){if (glow.env.gecko){var gv = glow.env.version.split(""."");for (var i=gv.length;i<4;i++){gv[i]=0;}if((gv[0]==1 && gv[1]==9 && gv[2]==0)||(gv[0]==1 && gv[1]<9)||(gv[0]<1)){glow.dom.get(""body"").addClass(""firefox-older-than-3-5"");}}});}});

window.disableFacebookSDK=true;
if (window.location.pathname.indexOf('+')>=0){window.disableFacebookSDK=true;}

/*]]>*/
</script>
<script type=""text/javascript"" src=""http://news.bbcimg.co.uk/js/locationservices/locator/v4_0/locator.js""></script>

<script type=""text/javascript"" src=""http://news.bbcimg.co.uk/js/core/3_3_1/bbc_fmtj.js""></script>

<script type=""text/javascript"">
<!--
	bbc.fmtj.page = {
		serverTime: 1373206995000,
		editionToServe: 'international',
		queryString: null,
		referrer: null,
		section: 'us-and-canada',
		sectionPath: '/World/US and Canada',
		siteName: 'BBC News',
		siteToServe: 'news',
		siteVersion: 'cream',
		storyId: '23214513',
		assetType: 'story',
		uri: '/news/world-us-canada-23214513',
		country: 'au',
		masthead: false,
		adKeyword: null,
		templateVersion: 'v1_0'
	}
-->
</script>
<script type=""text/javascript"" src=""http://news.bbcimg.co.uk/js/common/3_2_1/bbc_fmtj_common.js""></script>


<script type=""text/javascript"">$useMap({map:""http://news.bbcimg.co.uk/js/map/map_0_0_33.js""});</script>
<script type=""text/javascript"">$loadView(""0.0"",[""bbc.fmtj.view""]);</script>
<script type=""text/javascript"">$render(""livestats-heatmap"");</script>


<script type=""text/javascript"" src=""http://news.bbcimg.co.uk/js/config/apps/4_7_2/bbc_fmtj_config.js""></script>




<script type=""text/javascript"">
    //<![CDATA[
        require(['jquery-1'], function($){
            
            // set up EMP once it's loaded
            var setUp = function(){
                // use our own pop out page
        	    embeddedMedia.setPopoutUrl('/player/emp/2_0_55/popout/pop.stm');

        	    // store EMP's notifyParent function
        	    var oldNotifyParent = embeddedMedia.console.notifyParent;
        	    // use our own to add livestats to popout
        	    embeddedMedia.console.notifyParent = function(childWin){
        	        oldNotifyParent(childWin);
        	        // create new live stats url
                    var liveStatsUrl = bbc.fmtj.av.emp.liveStatsForPopout($('#livestats').attr('src'));
                    var webBug = $('<img />', {
                                     id:  'livestats',
                                     src: liveStatsUrl
                                 });
                    // append it to popout
                    $(childWin.document).find('body').append(webBug);
                }
            }
                
            // check if console is available to manipulate
            if(window.embeddedMedia && window.embeddedMedia.console){
                setUp();
            }
            // otherwise emp is still loading, so add event listener
            else{
                $(document).bind('empReady', function(){
                    setUp();
                });
            }
        });
    //]]>
</script>


		
	<!-- get BUMP from cdn -->
    <script type=""text/javascript"" src=""http://emp.bbci.co.uk/emp/bump?emp=worldwide&amp;enableClear=1""></script>

<!-- load glow and required modules -->
<script type=""text/javascript"">
    //<![CDATA[
        gloader.load(['glow', '1', 'glow.dom']);
    //]]>
</script>



	<!-- pull in our emp code -->
	<script type=""text/javascript"" src=""http://news.bbcimg.co.uk/js/app/av/emp/2_0_55/emp.js""></script>
	<!-- pull in compatibility.js -->
	<script type=""text/javascript"" src=""http://news.bbcimg.co.uk/js/app/av/emp/2_0_55/compatibility.js""></script>


<script type=""text/javascript"">
	//<![CDATA[
	    
	
	    
	        
	    
	
	    
	        
	    
	
	    // set site specific config
	    
	        bbc.fmtj.av.emp.configs.push('news');
	    
	    
	    // when page loaded, write all created emps
	    glow.ready(function(){
			if(typeof bbcdotcom !== 'undefined' && bbcdotcom.av && bbcdotcom.av.emp){
				bbcdotcom.av.emp.configureAll();
			}
			embeddedMedia.each(function(emp){
				emp.set('enable3G', true);
				emp.setMediator('href', '{protocol}://{host}/mediaselector/5/select/version/2.0/mediaset/{mediaset}/vpid/{id}');						
			});
			embeddedMedia.writeAll();
	        // mark the emps as loaded
	        bbc.fmtj.av.emp.loaded = true;
			
			
	    });
	//]]>
</script>
<!-- Check for advertising testing -->

<meta name=""viewport"" content=""width = 996"" />



        <!-- shared/head_story -->
<!-- THESE STYLESHEETS VARY ACCORDING TO PAGE CONTENT -->															  

<link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""http://news.bbcimg.co.uk/view/3_0_16/cream/hi/shared/layout/story.css"" />
<link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""http://news.bbcimg.co.uk/view/3_0_16/cream/hi/shared/story.css"" />


<!-- js story view -->
<script type=""text/javascript"">$loadView(""0.0"",[""bbc.fmtj.view.news.story""]);</script>

<!-- EMP -->
<script type=""text/javascript"" src=""http://news.bbc.co.uk/js/app/av/emp/compatibility.js""></script>
<!-- /EMP -->

        
        <!-- #CREAM hi news international include head.inc -->  
                		<!-- hi/news/head_last.inc -->

<link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""http://news.bbcimg.co.uk/view/1_4_38/cream/hi/news/skin.css"" />




<link rel=""apple-touch-icon"" href=""http://news.bbcimg.co.uk/img/1_0_2/cream/hi/news/iphone.png""/>
<script type=""text/javascript"">
    bbcRequireMap['module/weather'] = '/inc/specials/cream/hi/news/personalisation/weather';
    bbcRequireMap['module/local'] = '/inc/specials/cream/hi/news/personalisation';
    require({ baseUrl: 'http://static.int.bbci.co.uk/', paths: bbcRequireMap, waitSeconds: 30 });
</script>
<script type=""text/javascript"">
require([""jquery-1"", ""istats-1""], function ($, istats) {
    $(function() {
        istats.track('external', {region: $('.story-body'), linkLocation : 'story-body'});
        istats.track('external', {region: $('.story-related .related-links'), linkLocation : 'related-links'});
        istats.track('external', {region: $('.story-related .newstracker-list'), linkLocation : 'newstracker'});
    });
});
</script>





	
    		
		
	
    	
   

<!-- CPS COMMENT STATUS: false -->


	   <!--Rendered by 2036006 -->
	   <link rel=""schema.dcterms"" href=""http://purl.org/dc/terms/"" />
	   <meta name=""DCTERMS.created"" content=""2013-07-06T19:07:32+00:00"" />
	   <meta name=""DCTERMS.modified"" content=""2013-07-07T10:38:43+00:00"" />
    </head>

        	    <!--[if lte IE 6]><body class=""news ie disable-wide-advert""><![endif]-->
    <!--[if IE 7]><body class=""news ie7 disable-wide-advert""><![endif]-->
    <!--[if IE 8]><body class=""news ie8 disable-wide-advert""><![endif]-->
    <!--[if !IE]>--><body class=""news disable-wide-advert""><!--<![endif]-->
	<div class=""livestats-web-bug""><img alt="""" id=""livestats"" src=""http://stats.bbc.co.uk/o.gif?~RS~s~RS~News~RS~t~RS~HighWeb_Story~RS~i~RS~23214513~RS~p~RS~99127~RS~a~RS~International~RS~u~RS~/news/world-us-canada-23214513~RS~r~RS~(none)~RS~q~RS~~RS~z~RS~15~RS~""/></div>
        
	
	
	

       <!-- BBCDOTCOM body first spectrum -->
     <!-- ISTATS -->



    






 <script type=""text/javascript"">/*<![CDATA[*/ bbcFlagpoles_istats = 'ON'; istatsTrackingUrl = '//sa.bbc.co.uk/bbc/bbc/s?name=news.world.us_and_canada.story.23214513.page&cps_asset_id=23214513&page_type=story&section=us-and-canada&app_version=6.2.144-RC4&first_pub=2013-07-06T19:07:32+00:00&last_editorial_update=2013-07-07T10:38:43+00:00&title=Jet+crash-lands+at+San+Francisco&comments_box=false&cps_media_type=&cps_media_state=&by_nation=&app_type=web&ml_name=SSI&ml_version=0.16.1&language=en-GB'; if (window.istats_countername) { istatsTrackingUrl = istatsTrackingUrl.replace(/([?&]name=)[^&]+/ig, '$1' + istats_countername); } (function() { if ( /\bIDENTITY=/.test(document.cookie) ) { istatsTrackingUrl += '&bbc_identity=1'; } var c = (document.cookie.match(/\bckns_policy=(\d\d\d)/)||[]).pop() || ''; istatsTrackingUrl += '&bbc_mc=' + (c? 'ad'+c.charAt(0)+'ps'+c.charAt(1)+'pf'+c.charAt(2) : 'not_set'); if ( /\bckns_policy=\d\d0/.test(document.cookie) ) { istatsTrackingUrl += '&ns_nc=1'; } var screenWidthAndHeight = 'unavailable'; if (window.screen && screen.width && screen.height) { screenWidthAndHeight = screen.width + 'x' + screen.height; } istatsTrackingUrl += ('&screen_resolution=' + screenWidthAndHeight); istatsTrackingUrl += '&blq_s=3.5&blq_r=3.5&blq_v=journalism-worldwide'; })(); /*]]>*/</script>  <!-- Begin iStats 20100118 (UX-CMC 1.1009.3) --> <script type=""text/javascript"">/*<![CDATA[*/ (function() { window.istats || (istats = {}); var cookieDisabled = (document.cookie.indexOf('NO-SA=') != -1), hasCookieLabels = (document.cookie.indexOf('sa_labels=') != -1), hasClickThrough = /^#sa-(.*?)(?:-sa(.*))?$/.test(document.location.hash), runSitestat = !cookieDisabled && !hasCookieLabels && !hasClickThrough && !istats._linkTracked; if (runSitestat && bbcFlagpoles_istats === 'ON') { sitestat(istatsTrackingUrl); } else { window.ns_pixelUrl = istatsTrackingUrl; /* used by Flash library to track */ } function sitestat(n){var j=document,f=j.location,b="""";if(j.cookie.indexOf(""st_ux="")!=-1){var k=j.cookie.split("";"");var e=""st_ux"",h=document.domain,a=""/"";if(typeof ns_!=""undefined""&&typeof ns_.ux!=""undefined""){e=ns_.ux.cName||e;h=ns_.ux.cDomain||h;a=ns_.ux.cPath||a}for(var g=0,f=k.length;g<f;g++){var m=k[g].indexOf(""st_ux="");if(m!=-1){b=""&""+unescape(k[g].substring(m+6))}}document.cookie=e+""=; expires=""+new Date(new Date().getTime()-60).toGMTString()+""; path=""+a+""; domain=""+h}ns_pixelUrl=n;n=ns_pixelUrl+""&ns__t=""+(new Date().getTime())+""&ns_c=""+((j.characterSet)?j.characterSet:j.defaultCharset)+""&ns_ti=""+escape(j.title)+b+""&ns_jspageurl=""+escape(f&&f.href?f.href:j.URL)+""&ns_referrer=""+escape(j.referrer);if(n.length>2000&&n.lastIndexOf(""&"")){n=n.substring(0,n.lastIndexOf(""&"")+1)+""ns_cut=""+n.substring(n.lastIndexOf(""&"")+1,n.lastIndexOf(""="")).substring(0,40)}(j.images)?new Image().src=n:j.write('<p><i'+'mg src=""'+n+'"" height=""1"" width=""1"" alt="""" /></p>')}; })(); /*]]>*/</script> <noscript><p style=""position: absolute; top: -999em;""><img src=""//sa.bbc.co.uk/bbc/bbc/s?name=news.world.us_and_canada.story.23214513.page&amp;cps_asset_id=23214513&amp;page_type=story&amp;section=us-and-canada&amp;app_version=6.2.144-RC4&amp;first_pub=2013-07-06T19:07:32+00:00&amp;last_editorial_update=2013-07-07T10:38:43+00:00&amp;title=Jet+crash-lands+at+San+Francisco&amp;comments_box=false&amp;cps_media_type=&amp;cps_media_state=&amp;by_nation=&amp;app_type=web&amp;ml_name=SSI&amp;ml_version=0.16.1&amp;language=en-GB&amp;blq_s=3.5&amp;blq_r=3.5&amp;blq_v=journalism-worldwide"" height=""1"" width=""1"" alt="""" /></p></noscript> <!-- End iStats (UX-CMC) -->   <div id=""blq-global""> <div id=""blq-pre-mast"" xml:lang=""en-GB""> <!-- Pre mast --> 
<!-- BBCDOTCOM leaderboard template:server-side journalismVariant: true ipIsAdvertiseCombined: true adsEnabled: false showDotcom: true flagpole: ON showAdAboveBlq: true blqLeaderboardAd: true -->
 </div> </div>  <script type=""text/html"" id=""blq-bbccookies-tmpl""><![CDATA[ <div id=""bbccookies-prompt""> <h2> Cookies on the BBC website </h2> <p> We use cookies to ensure that we give you the best experience on our website. We also use cookies to ensure we show you advertising that is relevant to you. If you continue without changing your settings, we'll assume that you are happy to receive all cookies on the BBC website. However, if you would like to, you can <a href=""/privacy/cookies/managing/cookie-settings.html"">change your cookie settings</a> at any time. </p> <ul> <li id=""bbccookies-continue""> <button type=""button"" id=""bbccookies-continue-button"">Continue</button> </li> <li id=""bbccookies-more""><a href=""/privacy/cookies/bbc"">Find out more</a></li></ul> </div> ]]></script> <script type=""text/javascript"">/*<![CDATA[*/ (function(){if(bbccookies._showPrompt()){var i=document,b=i.getElementById(""blq-pre-mast""),f=i.getElementById(""blq-global""),h=i.getElementById(""blq-container""),c=i.getElementById(""blq-bbccookies-tmpl""),a,g,e;if(b&&i.createElement){a=i.createElement(""div"");a.id=""bbccookies"";e=c.innerHTML;e=e.replace(""<""+""![CDATA["","""").replace(""]]""+"">"","""");a.innerHTML=e;if(f){f.insertBefore(a,b)}else{h.insertBefore(a,b)}g=i.getElementById(""bbccookies-continue-button"");g.onclick=function(){a.parentNode.removeChild(a);return false};bbccookies._setPolicy()}}})(); /*]]>*/</script>  <div id=""blq-masthead"" class=""blq-clearfix blq-mast-bg-transparent-light blq-lang-en-GB blq-ltr""> <span id=""blq-mast-background""><span></span></span>  <div id=""blq-mast"" class=""blq-rst"">  <div id=""blq-mast-bar"" class=""blq-masthead-container blq-journalism-worldwide""> <div id=""blq-blocks""> <a href=""http://www.bbc.co.uk/"" hreflang=""en-GB""> <abbr title=""British Broadcasting Corporation"" class=""blq-home""> <img src=""http://static.bbci.co.uk/frameworks/barlesque/2.48.3/desktop/3.5/img/blq-blocks_grey_alpha.png"" alt=""BBC"" width=""84"" height=""24"" /> </abbr> </a> </div> <div id=""blq-acc-links""> <h2 id=""page-top"">Accessibility links</h2> <ul>  <li><a href=""#main-content"">Skip to content</a></li>  <li><a href=""#blq-local-nav"">Skip to local navigation</a></li>  <li><a href=""http://www.bbc.co.uk/accessibility/"">Accessibility Help</a></li> </ul> </div> <div id=""blq-sign-in"" class=""blq-gel"">  </div> <div id=""blq-nav""> <h2>bbc.co.uk navigation</h2>     <ul id=""blq-nav-main"">   <li id=""blq-nav-news""> <a href=""http://www.bbc.com/news/"">News</a> </li>    <li id=""blq-nav-sport""> <a href=""http://www.bbc.co.uk/sport/"">Sport</a> </li>    <li id=""blq-nav-weather""> <a href=""http://www.bbc.co.uk/weather/"">Weather</a> </li>    <li id=""blq-nav-capital""> <a href=""http://www.bbc.com/capital/"">Capital</a> </li>    <li id=""blq-nav-culture""> <a href=""http://www.bbc.com/culture/"">Culture</a> </li>    <li id=""blq-nav-autos""> <a href=""http://www.bbc.com/autos/"">Autos</a> </li>    <li id=""blq-nav-tv""> <a href=""http://www.bbc.co.uk/tv/"">TV</a> </li>    <li id=""blq-nav-radio""> <a href=""http://www.bbc.co.uk/radio/"">Radio</a> </li>    <li id=""blq-nav-more""> <a href=""http://www.bbc.co.uk/a-z/"">More&hellip;</a> </li>      </ul>   <div id=""blq-nav-search""> <form method=""get"" action=""http://search.bbc.co.uk/search"" accept-charset=""utf-8"" id=""blq-search-form""> <div>  <input type=""hidden"" name=""go"" value=""toolbar"" />  <input type=""hidden"" value=""http://www.bbc.co.uk/news/world-us-canada-23214513"" name=""uri"" />    <input type=""hidden"" name=""scope"" value=""news"" />  <label for=""blq-search-q"" class=""blq-hide"">Search term:</label> <input id=""blq-search-q"" type=""text"" name=""q"" value="""" maxlength=""128"" /> <button id=""blq-search-btn"" type=""submit""><span><img src=""http://static.bbci.co.uk/frameworks/barlesque/2.48.3/desktop/3.5/img/blq-search_grey_alpha.png"" width=""13"" height=""13"" alt=""Search""/></span></button> </div> </form> </div>  </div> </div> </div> </div> <div id=""blq-container-outer"" class=""blq-journalism-worldwide blq-ltr"" >  <div id=""blq-container"" class=""blq-lang-en-GB blq-dotcom""> <div id=""blq-container-inner"" xml:lang=""en-GB"">   <div id=""blq-main"" class=""blq-clearfix"">   
	

                        		    	
		<div class=""us-and-canada  has-no-ticker "">
			<div id=""header-wrapper"">

			  
    		      			      				  <h2 id=""header"">
    			      	            <a rel=""index"" href=""http://www.bbc.co.uk/news/""><img alt=""BBC News"" src=""http://news.bbcimg.co.uk/img/1_0_2/cream/hi/news/news-blocks.gif"" /></a>
    	                	            	    	            		<span class=""section-title"">US &amp; Canada</span>
    	            	    	            		   		      				  </h2>
    			  			  
			  
		        

			  	            <div id=""blq-local-nav"">
 	            <ul id=""nav"" class=""nav"">
                	
        	        		                	
        	            	<li class=""first-child ""><a href=""/news/"">Home</a></li>
                            	
        	        	        	
        	            	<li><a href=""/news/uk/"">UK</a></li>
                            	
        	        	        	
        	            	<li><a href=""/news/world/africa/"">Africa</a></li>
                            	
        	        	        	
        	            	<li><a href=""/news/world/asia/"">Asia</a></li>
                            	
        	        	        	
        	            	<li><a href=""/news/world/europe/"">Europe</a></li>
                            	
        	        	        	
        	            	<li><a href=""/news/world/latin_america/"">Latin America</a></li>
                            	
        	        	        	
        	            	<li><a href=""/news/world/middle_east/"">Mid-East</a></li>
                            	
        	        	        	
        	        		<li class=""selected""><a href=""/news/world/us_and_canada/"">US &amp; Canada</a></li>
        		        		                            	
        	        	        	
        	            	<li><a href=""/news/business/"">Business</a></li>
                            	
        	        	        	
        	            	<li><a href=""/news/health/"">Health</a></li>
                            	
        	        	        	
        	            	<li><a href=""/news/science_and_environment/"">Sci/Environment</a></li>
                            	
        	        	        	
        	            	<li><a href=""/news/technology/"">Tech</a></li>
                            	
        	        	        	
        	            	<li><a href=""/news/entertainment_and_arts/"">Entertainment</a></li>
                            	
        	        	        	
        	            	<li><a href=""/news/10462520"">Video</a></li>
                            </ul> 
        
	    	</div>

			  
	        </div>
	        <!-- START CPS_SITE CLASS: international -->
	        <div id=""content-wrapper"" class=""international"">

					<div class=""advert"">
											</div>
                    
	            <!-- START CPS_SITE CLASS: story -->
	            <div id=""main-content"" class=""story blq-clearfix"">
			<!-- No EWA -->






<div class=""layout-block-a"">
    <div class=""story-body"">    	
    		  <span class=""story-date"">
    <span class=""date"">7 July 2013</span>
<span class=""time-text"">Last updated at </span><span class=""time"">10:38 GMT</span>
	  
</span>

	<div id=""page-bookmark-links-head"" class=""share-help"">
  <h3>Share this page</h3>
  <ul>  	
    <li class=""delicious"">
      <a title=""Post this story to Delicious"" href=""http://del.icio.us/post?url=http://www.bbc.co.uk/news/world-us-canada-23214513&amp;title=BBC+News+-+Boeing+777+plane+crash-lands+at+San+Francisco+airport"">Delicious</a>
    </li>
    <li class=""digg"">
      <a title=""Post this story to Digg"" href=""http://digg.com/submit?url=http://www.bbc.co.uk/news/world-us-canada-23214513&amp;title=BBC+News+-+Boeing+777+plane+crash-lands+at+San+Francisco+airport"">Digg</a>
    </li>
    <li class=""facebook"">
      <a title=""Post this story to Facebook"" href=""http://www.facebook.com/sharer.php?u=http://www.bbc.co.uk/news/world-us-canada-23214513&amp;t=BBC+News+-+Boeing+777+plane+crash-lands+at+San+Francisco+airport"">Facebook</a>
    </li>
    <li class=""reddit"">
      <a title=""Post this story to reddit"" href=""http://reddit.com/submit?url=http://www.bbc.co.uk/news/world-us-canada-23214513&amp;title=BBC+News+-+Boeing+777+plane+crash-lands+at+San+Francisco+airport"">reddit</a>
    </li>
    <li class=""stumbleupon"">
      <a title=""Post this story to StumbleUpon"" href=""http://www.stumbleupon.com/submit?url=http://www.bbc.co.uk/news/world-us-canada-23214513&amp;title=BBC+News+-+Boeing+777+plane+crash-lands+at+San+Francisco+airport"">StumbleUpon</a>
    </li>
    <li class=""twitter"">
      <a title=""Post this story to Twitter"" href=""http://twitter.com/home?status=BBC+News+-+Boeing+777+plane+crash-lands+at+San+Francisco+airport+http://www.bbc.co.uk/news/world-us-canada-23214513"">Twitter</a>
    </li>
    <li class=""email"">
      <a title=""Email this story"" href=""http://newsvote.bbc.co.uk/mpapps/pagetools/email/www.bbc.co.uk/news/world-us-canada-23214513"">Email</a>
    </li>
    <li class=""print"">
      <a title=""Print this story"" href=""?print=true"">Print</a>
    </li>
  </ul>
<!--  Social media icons by Paul Annet | http://nicepaul.com/icons  -->
</div>
<script type=""text/javascript""> 
<!--
$render(""page-bookmark-links"",""page-bookmark-links-head"",{
    useForgeShareTools:""true"",
    position:""top"",
    site:'News', 
    headline:'BBC News - Boeing 777 plane crash-lands at San Francisco airport', 
    storyId:'23214513', 
    sectionId:'99127', 
    url:'http://www.bbc.co.uk/news/world-us-canada-23214513', 
    edition:'International'
}); 
-->
</script>





	<h1 class=""story-header"">Boeing 777 plane crash-lands at San Francisco airport</h1>

     
         
 
        
    		
		        
        <!--  Embedding the video player -->
<!--  This is the embedded player component -->

 



<!-- wwrights check -->
<!-- Empty country is used on test environment -->



<div class=""videoInStoryB"">
    <div id=""emp-23215909-736"" class=""emp"">
                    
		
        <noscript>
            <div class=""warning"">
                                <img class=""holding"" src=""http://news.bbcimg.co.uk/media/images/68591000/jpg/_68591122_68591121.jpg"" alt=""Plane crash"" />
                                <p><strong>Please turn on JavaScript.</strong> Media requires JavaScript to play.</p>
            </div>
        </noscript>
        <object width=""0"" height=""0"">
            <param name=""id"" value=""embeddedPlayer_23215909"" />
                    <param name=""width"" value=""448"" />
            <param name=""height"" value=""252"" />    
                    <param name=""size"" value=""Large"" />
					<param name=""holdingImage"" value=""http://news.bbcimg.co.uk/media/images/68591000/jpg/_68591122_68591121.jpg"" />
							<param name=""externalIdentifier"" value=""p01cfcjj"" />
		            <param name=""playlist"" value=""http://playlists.bbc.co.uk/news/world-us-canada-23215909A/playlist.sxml"" />
            <param name=""config_settings_autoPlay"" value=""false"" />
            <param name=""config_settings_showPopoutButton"" value=""false"" />
            <param name=""config_plugin_fmtjLiveStats_pageType"" value=""eav2"" />
            <param name=""config_plugin_fmtjLiveStats_edition"" value=""International"" />
			
		            <param name=""fmtjDocURI"" value=""/news/world-us-canada-23214513""/>
                    <param name=""config_settings_suppressItemKind"" value=""advert, ident""/>
                    <param name=""config_settings_showShareButton"" value=""true"" />
            <param name=""config_settings_showUpdatedInFooter"" value=""true"" />
        </object>
        <!-- embedding script -->
        
        <script type=""text/javascript"">
    //<![CDATA[
        (function(){
            // create a new player, but don't write it yet
            var emp = new bbc.fmtj.av.emp.Player('emp-23215909-736');
            // if the emps have already been loaded, we need to call the write method manually
            if(bbc.fmtj.av.emp.loaded){
                emp.setMediator('href', '{protocol}://{host}/mediaselector/5/select/version/2.0/mediaset/{mediaset}/vpid/{id}');
                emp.write();
            }
        })();
    //]]>
</script>
            </div>
    	
        		<!-- caption -->
		<p class=""caption"">Passenger Ben Levy: &quot;It happened in a flash, nobody was worried about anything&quot;</p>
		<!-- END - caption -->
    
		

</div>
<!-- end of the embedded player component -->

<!-- Player embedded -->	<div class=""story-feature related narrow"">
		<a class=""hidden"" href=""#story_continues_1"">Continue reading the main story</a>		<h2>Related Stories</h2>
		<ul class=""related-links-list"">
						




		


	




<li class=""has-icon-boxedwatch "">
	<a class=""story"" rel=""published-1373144587009"" href=""/news/world-us-canada-23214500"">Eyewitness: &#039;Plane out of control&#039;<span class=""gvl3-icon gvl3-icon-boxedwatch""> Watch</span></a>

		</li>


											




		


	




<li class=""has-icon-boxedwatch "">
	<a class=""story"" rel=""published-1373145766744"" href=""/news/world-us-canada-23214501"">Crash plane &#039;has good reputation&#039;<span class=""gvl3-icon gvl3-icon-boxedwatch""> Watch</span></a>

		</li>


											




	


	




<li>
	<a class=""story"" rel=""published-1373141425214"" href=""/news/world-us-canada-23214748"">In pictures: San Francisco crash</a>

		</li>


								</ul>
	</div>
                      <p class=""introduction"" id=""story_continues_1"">A Boeing 777 aircraft has crash-landed at San Francisco international airport, killing two people and injuring dozens more, officials say.</p>
        <p>More than 300 people were on Asiana Airlines Flight 214, from South Korea&#039;s capital, Seoul. Passengers and crew escaped down emergency slides as the plane burst into flames.</p>
        <p>Asiana has confirmed two female Chinese teenagers have died in the crash.</p>
        <p>The airline said mechanical problems did not cause the crash.</p>
        <p>The two Chinese teenagers who died had been seated at the back of the aircraft, said Asiana, South Korea&#039;s second largest carrier.</p>
        <p>They are believed to be the first-ever fatalities in a Boeing 777 crash.</p>
        <p>&quot;Currently we understand that there were no engine or mechanical problems,&quot; Asiana chief executive Yoon Young-Doo told a news conference in Seoul.</p>
  <!--  Embedding the video player -->
<!--  This is the embedded player component -->

 



<!-- wwrights check -->
<!-- Empty country is used on test environment -->



<div class=""videoInStoryB"">
    <div id=""emp-23214500-737"" class=""emp"">
                    
		
        <noscript>
            <div class=""warning"">
                                <img class=""holding"" src=""http://news.bbcimg.co.uk/media/images/68588000/jpg/_68588962_68588960.jpg"" alt=""Wreckage of plane"" />
                                <p><strong>Please turn on JavaScript.</strong> Media requires JavaScript to play.</p>
            </div>
        </noscript>
        <object width=""0"" height=""0"">
            <param name=""id"" value=""embeddedPlayer_23214500"" />
                    <param name=""width"" value=""448"" />
            <param name=""height"" value=""252"" />    
                    <param name=""size"" value=""Large"" />
					<param name=""holdingImage"" value=""http://news.bbcimg.co.uk/media/images/68588000/jpg/_68588962_68588960.jpg"" />
							<param name=""externalIdentifier"" value=""p01cf0d3"" />
		            <param name=""playlist"" value=""http://playlists.bbc.co.uk/news/world-us-canada-23214500A/playlist.sxml"" />
            <param name=""config_settings_autoPlay"" value=""false"" />
            <param name=""config_settings_showPopoutButton"" value=""false"" />
            <param name=""config_plugin_fmtjLiveStats_pageType"" value=""eav2"" />
            <param name=""config_plugin_fmtjLiveStats_edition"" value=""International"" />
			
		            <param name=""fmtjDocURI"" value=""/news/world-us-canada-23214513""/>
                    <param name=""config_settings_suppressItemKind"" value=""advert, ident""/>
                    <param name=""config_settings_showShareButton"" value=""true"" />
            <param name=""config_settings_showUpdatedInFooter"" value=""true"" />
        </object>
        <!-- embedding script -->
        
        <script type=""text/javascript"">
    //<![CDATA[
        (function(){
            // create a new player, but don't write it yet
            var emp = new bbc.fmtj.av.emp.Player('emp-23214500-737');
            // if the emps have already been loaded, we need to call the write method manually
            if(bbc.fmtj.av.emp.loaded){
                emp.setMediator('href', '{protocol}://{host}/mediaselector/5/select/version/2.0/mediaset/{mediaset}/vpid/{id}');
                emp.write();
            }
        })();
    //]]>
</script>
            </div>
    	
        		<!-- caption -->
		<p class=""caption"">Eyewitness Ki Siadatan: &quot;[The plane] seemed like it was out of control&quot;</p>
		<!-- END - caption -->
    
		

</div>
<!-- end of the embedded player component -->

<!-- Player embedded -->      <p>Boeing said <a href=""http://boeing.mediaroom.com/index.php?s=43&amp;item=2735"" title=""Boeing statement"" >in a statement</a> it would provide technical assistance to the investigation.</p>
        <p>Early indications suggest the plane came in too short and hit the seawall at the airport. </p>
        <p>Eight adults and two children who suffered critical injuries are being treated at San Francisco General Hospital, hospital spokesperson Rachael Kagan said. </p>
        <p>Altogether 181 people were taken to hospital, mostly with minor injuries.</p>
  <a class=""hidden"" href=""#story_continues_2"">Continue reading the main story</a><!-- NEWSSPEC-3154 [start] -->
<link href=""/news/special/shared/slideshow/css/slideshow.css?cachebuster=cb000000006"" rel=""stylesheet"" type=""text/css"" />
<script type=""text/javascript"" src=""/news/special/shared/slideshow/js/slideshow.js?cachebuster=cb000000007""></script>
<div id=""slideshow_container"" class=""storybody-halfwide-include"">
	<div id=""ss_slides""><div class=""caption full-width"">
  <img src=""http://news.bbcimg.co.uk/media/images/68590000/jpg/_68590587_hi018577363.jpg"" width=""624"" height=""351"" alt=""Asiana Airlines plane on fire (7 July 2013)"" />

    <span style=""width:624px;"">Smoke billows from the burning plane after it crash-landed on San Francisco International Airport&#039;s Runway 28L</span>
  </div>
<div class=""caption full-width"">
  <img src=""http://news.bbcimg.co.uk/media/images/68590000/jpg/_68590591_hi018577735.jpg"" width=""624"" height=""351"" alt=""Plane wreckage on the runway (7 July 2013)"" />

    <span style=""width:624px;"">More than 300 people were on Asiana Airlines Flight 214, which had taken off from South Korea&#039;s capital, Seoul</span>
  </div>
<div class=""caption full-width"">
  <img src=""http://news.bbcimg.co.uk/media/images/68590000/jpg/_68590589_hi018577666.jpg"" width=""624"" height=""351"" alt=""Search and rescue teams at the scene of the crash (7 July 2013)"" />

    <span style=""width:624px;"">Firefighters and rescue teams are at the scene</span>
  </div>
<div class=""caption full-width"">
  <img src=""http://news.bbcimg.co.uk/media/images/68591000/jpg/_68591909_hi018576589.jpg"" width=""624"" height=""351"" alt=""Wreckage of plane at San Francisco airport (7 July 2013)"" />

    <span style=""width:624px;"">The two Chinese teenagers who died had been seated at the back of the aircraft</span>
  </div>
<div class=""caption full-width"">
  <img src=""http://news.bbcimg.co.uk/media/images/68588000/jpg/_68588920_03cb62c9-ab5f-4e26-b9b3-fab79ff249c7.jpg"" width=""624"" height=""351"" alt=""The tail of Asiana Flight 214 is seen, right, after it crashed at San Francisco International Airport in San Francisco, 6 July 2013"" />

    <span style=""width:624px;"">The tail fin broke off during the crash and could be seen lying on its side apart from the main wreckage</span>
  </div>
<div class=""caption full-width"">
  <img src=""http://news.bbcimg.co.uk/media/images/68587000/jpg/_68587089_55c671e8-dd52-4783-aa87-670d4906f8e6.jpg"" width=""624"" height=""351"" alt=""A fire engine sprays water on Asiana Flight 214 after it crashed at San Francisco International Airport on 6 July 2013"" />

    <span style=""width:624px;"">Fire engines could be seen spraying a white fire retardant into gaping holes in the wrecked plane&#039;s roof</span>
  </div>
<a class=""hidden"" href=""#story_continues_2"">Continue reading the main story</a>	</div>
	<div class=""ss_controls"">
		<a href='#prev' class=""ss_prev ss_button ss_button_disabled""><span>previous slide</span></a>
		<a href='#next' class=""ss_next ss_button ss_button_disabled""><span>next slide</span></a>
		<span class=""ss_locator""></span>
	</div>
</div>
<!-- NEWSSPEC-3154 [end] -->      <p id=""story_continues_2"">There were 291 passengers and 16 crew on board, Asiana said. </p>
        <p>Nationalities on board included 141 Chinese, 77 South Koreans and 61 US citizens, the airline said.</p>
        <p>Rescue teams initially took 49 people deemed to be in a serious condition to nearby hospitals, officials said.</p>
  <div class=""story-feature wide "">
	<a class=""hidden"" href=""#story_continues_3"">Continue reading the main story</a>		<h2>Boeing 777 fact sheet</h2>
		<!-- pullout-items-->
	
	<!-- pullout-body-->
	<ul>
    <li> Twin-engine jet launched in June 1995</li>
    <li> One of the world&#039;s most popular long-distance planes</li>
    <li> Seats between 300 and 380 passengers</li>
    <li> Has flown around five million flights </li>
    <li> Often used for nonstop flights of 16 hours or more</li>
    <li> Prior to Asiana crash, only one fatal accident when a crew member died during a re-fuelling fire at Denver International Airport  in September 2001 </li>
  </ul>
	<!-- pullout-links-->
	</div>      <p id=""story_continues_3"">Some 190 people walked to safety from the plane, many of whom were later treated for minor injuries.</p>
        <p>All of the passengers have now been accounted for.</p>
        <p>While the sequence of events remains unclear, it appeared the plane landed and then crashed on San Francisco International Airport&#039;s Runway 28L, said Federal Aviation Administration spokeswoman Laura Brown.</p>
        <p>Footage of the scene showed debris strewn on the runway and smoke pouring from the jet, as fire crews sprayed a white fire retardant into gaping holes in the craft&#039;s roof.</p>
        <p>One engine and the tail fin appeared to have broken away from the main wreckage.</p>
  <span class=""cross-head"">'Out of control'</span>
	      <p>Passenger Ben Levy said there had been no warning of problems before the crash. &quot;It happened in a flash, nobody was worried about anything,&quot; he said. </p>
        <p>But once the aircraft crashed, &quot;there was chaos, disbelief, screaming&quot;.</p>
        <p>&quot;My seat had been pushed to the floor, it was a mess everywhere,&quot; Mr Levy recalled.</p>
        <p>Nevertheless, people &quot;calmed down pretty quickly&quot; and evacuated the plane without pushing or stepping on each other. </p>
        <p>Meanwhile another passenger, David Eun, <a href=""https://twitter.com/Eunner/status/353592664526028801"" >tweeted a picture of people evacuating down the plane&#039;s emergency inflatable slides</a> and wrote: &quot;I just crash landed at SFO. Tail ripped off. Most everyone seems fine. I&#039;m ok. Surreal...&quot;</p>
  <!--  Embedding the video player -->
<!--  This is the embedded player component -->

 



<!-- wwrights check -->
<!-- Empty country is used on test environment -->



<div class=""videoInStoryC"">
    <div id=""emp-23215291-738"" class=""emp"">
                    
		
        <noscript>
            <div class=""warning"">
                                <img class=""holding"" src=""http://news.bbcimg.co.uk/media/images/68589000/jpg/_68589751_68589750.jpg"" alt="" A Boeing 777 airplane lies burned on the runway after it crash landed at San Francisco International Airport "" />
                                <p><strong>Please turn on JavaScript.</strong> Media requires JavaScript to play.</p>
            </div>
        </noscript>
        <object width=""0"" height=""0"">
            <param name=""id"" value=""embeddedPlayer_23215291"" />
                    <param name=""width"" value=""320"" />
            <param name=""height"" value=""180"" />    
                    <param name=""size"" value=""Small"" />
					<param name=""holdingImage"" value=""http://news.bbcimg.co.uk/media/images/68589000/jpg/_68589751_68589750.jpg"" />
							<param name=""externalIdentifier"" value=""p01cf430"" />
		            <param name=""playlist"" value=""http://playlists.bbc.co.uk/news/world-us-canada-23215291A/playlist.sxml"" />
            <param name=""config_settings_autoPlay"" value=""false"" />
            <param name=""config_settings_showPopoutButton"" value=""false"" />
            <param name=""config_plugin_fmtjLiveStats_pageType"" value=""eav2"" />
            <param name=""config_plugin_fmtjLiveStats_edition"" value=""International"" />
			
		            <param name=""fmtjDocURI"" value=""/news/world-us-canada-23214513""/>
                    <param name=""config_settings_suppressItemKind"" value=""advert, ident""/>
                    <param name=""config_settings_showShareButton"" value=""true"" />
            <param name=""config_settings_showUpdatedInFooter"" value=""true"" />
        </object>
        <!-- embedding script -->
        
        <script type=""text/javascript"">
    //<![CDATA[
        (function(){
            // create a new player, but don't write it yet
            var emp = new bbc.fmtj.av.emp.Player('emp-23215291-738');
            // if the emps have already been loaded, we need to call the write method manually
            if(bbc.fmtj.av.emp.loaded){
                emp.setMediator('href', '{protocol}://{host}/mediaselector/5/select/version/2.0/mediaset/{mediaset}/vpid/{id}');
                emp.write();
            }
        })();
    //]]>
</script>
            </div>
    	
        		<!-- caption -->
		<p class=""caption"">City Mayor Ed Lee: &quot;This is still a fluid and active scene&quot;</p>
		<!-- END - caption -->
    
		

</div>
<!-- end of the embedded player component -->

<!-- Player embedded -->      <p>Mr Eun, who describes himself as a &quot;digital media guy&quot; and &quot;frequent flier&quot;, added: &quot;Fire and rescue people all over the place. They&#039;re evacuating the injured. Haven&#039;t felt this way since 9/11.&quot;</p>
        <p>A witness to the crash, Ki Siadatan, said the plane &quot;looked out of control&quot; as it descended over San Francisco Bay to land just before 11:30 (18:30 GMT).</p>
        <p>&quot;We heard a &#039;boom&#039; and saw the plane disappear into a cloud of dust and smoke,&quot; he told the BBC. &quot;There was then a second explosion.&quot;</p>
        <p>He saw events unfold from the balcony of his home in the Millbrae area of San Francisco, which overlooks the airport.</p>
        <p>Weather conditions were fine and there was little wind, he added.</p>
        <p>Arrivals and departures at the airport have been suspended since the incident.</p>
        <p>The twin-engine Boeing 777 has a good safety record as a long-haul aircraft and is used by many major carriers.</p>
  <div class=""comment-introduction"">
                        <p class=""introduction"">Are you in the area? Have you been affected? Send us your comments using the form below.</p>
  
</div>
	

<p><i>Send your pictures and videos to <b>yourpics@bbc.co.uk</b>  or text them to <b>61124</b> (UK) or <b>+44 7624 800 100</b> (International). If you have a large file you can</i> <a class=""inlineText"" href=""http://bbcnewsupload.streamuk.com/"">upload here</a><i>.</i></p>
<p><a href=""http://news.bbc.co.uk/1/hi/talking_point/2780295.stm#yourpics"">Read the terms and conditions</a></p>

	
    
      <form id=""comment-form"" action=""http://www.bbc.co.uk/cgi-bin/cgiemail/email/newsv6/form.txt"">
    
    <div><input type=""hidden"" value=""San Francisco plane crash 23214513"" name=""email_subject""/></div>
    <div><input type=""hidden"" value=""talkingpoint"" name=""mailto""/></div>
    <div><input type=""hidden"" value=""http://www.bbc.co.uk/news/10631033"" name=""success""/></div>
    <fieldset class=""contact_details"">
      <label class=""required"" for=""email_name"">
        <span class=""required"">(Required) </span><span class=""email_name-prompt""> Name</span>
        <span class=""email_name-msgContainer error""></span>
        <input type=""text"" size=""30"" id=""email_name"" name=""email_name"" />
      </label>
      <label class=""required"" for=""email_from"">
        <span class=""required"">(Required) </span><span class=""email_from-prompt""> Your E-mail address</span>
        <span class=""email_from-msgContainer error""></span>
        <input type=""text"" size=""30"" id=""email_from"" name=""email_from"" />
      </label>
      <label class=""required"" for=""email_country"">
        <span class=""required"">(Required) </span><span class=""email_country-prompt""> Town &amp; Country</span>
        <span class=""email_country-msgContainer error""></span>
        <input type=""text"" size=""30"" id=""email_country"" name=""email_country"" />
      </label>
      <label class=""required"" for=""email_telephone"">
        <span class=""required"">(Required) </span><span class=""email_telephone-prompt""> Your telephone number</span>
        <span class=""email_telephone-msgContainer error""></span>
        <input type=""text"" size=""30"" id=""email_telephone"" name=""email_telephone"" />
      </label>
    </fieldset>
    <fieldset class=""message"">
      <label class=""required"" for=""email_comments"">
        <span class=""required"">(Required) </span> <span class=""email_comments-prompt"">Comments</span>
        <span class=""email_comments-msgContainer error""></span>
        <textarea rows=""8"" cols=""30"" id=""email_comments"" name=""email_comments""></textarea>
      </label>
    </fieldset>
	    <fieldset class=""submit"">
      <p class=""disclaimer"">If you are happy to be contacted by a BBC journalist please leave a telephone number that we can contact you on. In some cases a selection of your comments will be published, displaying your name as you provide it and location, unless you state otherwise. Your contact details will never be published. When sending us pictures, video or eyewitness accounts at no time should you endanger yourself or others, take any unnecessary risks or infringe any laws. Please ensure you have read the terms and conditions.</p>
      <p class=""terms""><a href=""http://www.bbc.co.uk/terms/#4"">Terms and conditions</a></p>
      <button type=""submit""><span>Send</span></button>
      <button type=""reset"" class=""not-submit""><span>Clear</span></button>
    </fieldset>
  </form>
           
	
	</div><!-- / story-body -->
  
  <div>
 	<!--Related hypers and stories -->
	<div class=""story-related"">
	<h2>More on This Story</h2>
	  
	
<style>
.related-links-list li {
position: relative;
}
.related-links-list .gvl3-icon {
position: absolute;
top: 0;
left: 0;
}
</style>

<div class=""see-also"">
    <h3>Related Stories</h3>
    <ul class=""related-links-list"">
				
        			        		<li class="" first"">
                        




		


	




<div class=""has-icon-boxedwatch "">
	<a class=""story"" rel=""published-1373144587009"" href=""/news/world-us-canada-23214500"">Eyewitness: &#039;Plane out of control&#039;<span class=""gvl3-icon gvl3-icon-boxedwatch""> Watch</span></a>

		</div>

                        
                                                <span class=""timestamp"">06 JULY 2013</span>,                                                
                                                <span class=""section"">US & CANADA</span>
                                        </li>
							        			        		<li class="""">
                        




		


	




<div class=""has-icon-boxedwatch "">
	<a class=""story"" rel=""published-1373145766744"" href=""/news/world-us-canada-23214501"">Crash plane &#039;has good reputation&#039;<span class=""gvl3-icon gvl3-icon-boxedwatch""> Watch</span></a>

		</div>

                        
                                                <span class=""timestamp"">06 JULY 2013</span>,                                                
                                                <span class=""section"">US & CANADA</span>
                                        </li>
							        			        		<li class="""">
                        




	


	




<div>
	<a class=""story"" rel=""published-1373141425214"" href=""/news/world-us-canada-23214748"">In pictures: San Francisco crash</a>

		</div>

                        
                                                <span class=""timestamp"">07 JULY 2013</span>,                                                
                                                <span class=""section"">US & CANADA</span>
                                        </li>
							            </ul>
</div>
<script type=""text/javascript"">$render(""page-see-also"",""ID"");</script> 

	<script type=""text/javascript"">$render(""page-newstracker"",""ID"");</script> 

	</div>
<script type=""text/javascript"">$render(""page-related-items"",""ID"");</script>

  </div>

      
  <div class=""share-body-bottom"">
	<div id=""page-bookmark-links-foot"" class=""share-help"">
  <h3>Share this page</h3>
  <ul>  	
    <li class=""delicious"">
      <a title=""Post this story to Delicious"" href=""http://del.icio.us/post?url=http://www.bbc.co.uk/news/world-us-canada-23214513&amp;title=BBC+News+-+Boeing+777+plane+crash-lands+at+San+Francisco+airport"">Delicious</a>
    </li>
    <li class=""digg"">
      <a title=""Post this story to Digg"" href=""http://digg.com/submit?url=http://www.bbc.co.uk/news/world-us-canada-23214513&amp;title=BBC+News+-+Boeing+777+plane+crash-lands+at+San+Francisco+airport"">Digg</a>
    </li>
    <li class=""facebook"">
      <a title=""Post this story to Facebook"" href=""http://www.facebook.com/sharer.php?u=http://www.bbc.co.uk/news/world-us-canada-23214513&amp;t=BBC+News+-+Boeing+777+plane+crash-lands+at+San+Francisco+airport"">Facebook</a>
    </li>
    <li class=""reddit"">
      <a title=""Post this story to reddit"" href=""http://reddit.com/submit?url=http://www.bbc.co.uk/news/world-us-canada-23214513&amp;title=BBC+News+-+Boeing+777+plane+crash-lands+at+San+Francisco+airport"">reddit</a>
    </li>
    <li class=""stumbleupon"">
      <a title=""Post this story to StumbleUpon"" href=""http://www.stumbleupon.com/submit?url=http://www.bbc.co.uk/news/world-us-canada-23214513&amp;title=BBC+News+-+Boeing+777+plane+crash-lands+at+San+Francisco+airport"">StumbleUpon</a>
    </li>
    <li class=""twitter"">
      <a title=""Post this story to Twitter"" href=""http://twitter.com/home?status=BBC+News+-+Boeing+777+plane+crash-lands+at+San+Francisco+airport+http://www.bbc.co.uk/news/world-us-canada-23214513"">Twitter</a>
    </li>
    <li class=""email"">
      <a title=""Email this story"" href=""http://newsvote.bbc.co.uk/mpapps/pagetools/email/www.bbc.co.uk/news/world-us-canada-23214513"">Email</a>
    </li>
    <li class=""print"">
      <a title=""Print this story"" href=""?print=true"">Print</a>
    </li>
  </ul>
<!--  Social media icons by Paul Annet | http://nicepaul.com/icons  -->
  
</div>
<script type=""text/javascript""> 
<!--
$render(""page-bookmark-links"",""page-bookmark-links-foot"",{
    useForgeShareTools:""true"",
    position:""bottom"",
    site:'News', 
    headline:'BBC News - Boeing 777 plane crash-lands at San Francisco airport', 
    storyId:'23214513', 
    sectionId:'99127', 
    url:'http://www.bbc.co.uk/news/world-us-canada-23214513', 
    edition:'International'
}); 
-->
</script>

 </div>
 
   
	
        <!-- other stories from this section include -->
        

<div class=""top-index-stories"">
	<h2 class=""top-index-stories-header""><a href=""/news/world/us_and_canada/"">More US &amp; Canada stories</a></h2>
        <a href=""http://feeds.bbci.co.uk/news/world/us_and_canada/rss.xml"" class=""rss"">RSS</a>	
		

	
						
			<!-- Non specific version -->
			
	<ul>
		
						
												
		<li class=""first-child medium-image"">
			




	


		




<h3>
	<a class=""story"" rel=""published-1373195466637"" href=""/news/world-us-canada-23216587""><img src=""http://news.bbcimg.co.uk/media/images/68592000/jpg/_68592846_68590069.jpg"" alt=""Emergency slides can be seen at the exists of the Asiana plane after it crash landed"" />US air crash: &#039;No mechanical cause&#039;</a>

		</h3>

															
							<p>A Boeing 777 aircraft that crash-landed at San Francisco airport killing two people did not have mechanical problems, an airline official says.</p>
					</li>
		
		
						
						
		<li class=""column-1"">
			




	


	




<h3>
	<a class=""story"" rel=""published-1373203164209"" href=""/news/world-us-canada-23218614"">Canada runaway train death toll rises</a>

		</h3>

															
					</li>
		
		
						
						
		<li class=""column-2"">
			




	


	




<h3>
	<a class=""story"" rel=""published-1373102310906"" href=""/news/science-environment-23195087"">Trans-US solar plane finishes flight</a>

		</h3>

															
					</li>
		
		</ul>

	 

</div>

 
</div><!-- / layout-block-a -->

<div class=""layout-block-b"">	
			




		     <div class=""hyperpuff"">
	       	         
	       	         



<div id=""range-top-stories"" class=""top-stories-range-module"">

			<h2 class=""top-stories-range-module-header"">Top Stories</h2>
		
		
									
				<!-- Non specific version -->
				
	<ul>
					  				  								
				




	


		




<li class="" first-child medium-image"">
	<a class=""story"" rel=""published-1373195466637"" href=""/news/world-us-canada-23216587""><img src=""http://news.bbcimg.co.uk/media/images/68592000/jpg/_68592846_68590069.jpg"" alt=""Emergency slides can be seen at the exists of the Asiana plane after it crash landed"" />US air crash: &#039;No mechanical cause&#039;</a>

		</li>

									 			




	


	




<li>
	<a class=""story"" rel=""published-1373127944153"" href=""/news/uk-23213740"">Abu Qatada deported from Britain</a>

		</li>

  									 			




	


	




<li>
	<a class=""story"" rel=""published-1373203164209"" href=""/news/world-us-canada-23218614"">Canada runaway train death toll rises</a>

		</li>

  									 			




	


	




<li>
	<a class=""story"" rel=""published-1373197847451"" href=""/news/world-asia-india-23216592"">Blasts at Indian Buddhist complex</a>

		</li>

  									 			




	


	




<li>
	<a class=""story"" rel=""published-1373199039881"" href=""/news/world-asia-23217460"">Rare tigers trap Indonesians up tree</a>

		</li>

  						</ul>

		 
	
</div>
<script type=""text/javascript"">$render(""range-top-stories"",""range-top-stories"");</script>
      	

	       	         
	       	         

	<div id=""features"" class=""feature-generic"">

			<h2 class=""features-header"">Features &amp; Analysis</h2>
		
	<ul class=""feature-main"">

		
	
						
			<!-- Non specific version -->
			
			
							
		<li class=""medium-image"">

			




	


		




<h3 class="" feature-header"">
	<a class=""story"" rel=""published-1373156235629"" href=""/news/magazine-23199377""><img src=""http://news.bbcimg.co.uk/media/images/68579000/jpg/_68579540_morsi_beach624getty.jpg"" alt=""Morsi sand sculpture"" />Shifting sands</a>

		</h3>

			
							<p>Egypt&#039;s presidential democracy without a president 	
				  <span id=""dna-comment-count___CPS__23199377"" class=""gvl3-icon gvl3-icon-comment comment-count""></span></p>
			
							<hr />
					</li>
			
							
		<li class=""medium-image"">

			




	


		




<h3 class="" feature-header"">
	<a class=""story"" rel=""published-1373155763877"" href=""/news/magazine-23179125""><img src=""http://news.bbcimg.co.uk/media/images/68555000/jpg/_68555083_320_big-tackle.jpg"" alt=""One NFL player forcefully tackles another"" />The offensive line</a>

		</h3>

			
							<p>Does American football have a crime problem? 	
				  <span id=""dna-comment-count___CPS__23179125"" class=""gvl3-icon gvl3-icon-comment comment-count""></span></p>
			
							<hr />
					</li>
			
							
		<li class=""medium-image"">

			




	


		




<h3 class="" feature-header"">
	<a class=""story"" rel=""published-1373041146719"" href=""/news/magazine-23197698""><img src=""http://news.bbcimg.co.uk/media/images/68575000/jpg/_68575430_womanbooks.jpg"" alt=""Woman looking at books"" />Viva Virago</a>

		</h3>

			
							<p>The publisher that took neglected writers to its heart 	
				  <span id=""dna-comment-count___CPS__23197698"" class=""gvl3-icon gvl3-icon-comment comment-count""></span></p>
			
							<hr />
					</li>
			
							
		<li class=""medium-image"">

			




	


		




<h3 class="" feature-header"">
	<a class=""story"" rel=""published-1373128337338"" href=""/news/uk-23197677""><img src=""http://news.bbcimg.co.uk/media/images/68572000/jpg/_68572014_sunset.jpg"" alt=""Sunset over Amman"" />Abu Qatada</a>

		</h3>

			
							<p>The security problem Jordan doesn&#039;t need?  	
				  <span id=""dna-comment-count___CPS__23197677"" class=""gvl3-icon gvl3-icon-comment comment-count""></span></p>
			
							<hr />
					</li>
	
	 
	
	
	</ul>
	</div>
	<script type=""text/javascript"">$render(""feature-generic"",""features"");</script> 


	       	         
<div id=""most-popular"" class=""livestats livestats-tabbed tabbed range-most-popular"">
	
			<h2 class=""livestats-header"">Most Popular</h2>
	
					
					<h3 class=""tab ""><a href=""#"">Shared</a></h3>
		
		<div class=""panel "">
      		<ol>
	      		<li
  class=""first-child ol1"">
  <a
    href=""http://www.bbc.co.uk/news/uk-23213740""
    class=""story"">
    <span
      class=""livestats-icon livestats-1"">1: </span>Abu Qatada deported from Britain</a>
</li>
<li
  class=""ol2"">
  <a
    href=""http://www.bbc.co.uk/news/world-latin-america-23215676""
    class=""story"">
    <span
      class=""livestats-icon livestats-2"">2: </span>Referee killed after stabbing player</a>
</li>
<li
  class=""ol3"">
  <a
    href=""http://www.bbc.co.uk/news/uk-23214821""
    class=""story"">
    <span
      class=""livestats-icon livestats-3"">3: </span>Inverdale sorry for Bartoli remark</a>
</li>
<li
  class=""ol4"">
  <a
    href=""http://www.bbc.co.uk/news/entertainment-arts-23216575""
    class=""story"">
    <span
      class=""livestats-icon livestats-4"">4: </span>Saatchi and Nigella to divorce</a>
</li>
<li
  class=""ol5"">
  <a
    href=""http://www.bbc.co.uk/news/world-us-canada-23214513""
    class=""story"">
    <span
      class=""livestats-icon livestats-5"">5: </span>Jet crash-lands at San Francisco</a>
</li>
      		</ol>
      	</div>
							
					<h3 class=""tab open""><a href=""#"">Read</a></h3>
		
		<div class=""panel open"">
      		<ol>
	      		<li
  class=""first-child ol1"">
  <a
    href=""http://www.bbc.co.uk/news/world-us-canada-23216587""
    class=""story"">
    <span
      class=""livestats-icon livestats-1"">1: </span>US air crash: 'No mechanical cause'</a>
</li>
<li
  class=""ol2"">
  <a
    href=""http://www.bbc.co.uk/news/entertainment-arts-23216575""
    class=""story"">
    <span
      class=""livestats-icon livestats-2"">2: </span>Saatchi and Nigella to divorce</a>
</li>
<li
  class=""ol3"">
  <a
    href=""http://www.bbc.co.uk/news/world-latin-america-23215676""
    class=""story"">
    <span
      class=""livestats-icon livestats-3"">3: </span>Referee killed after stabbing player</a>
</li>
<li
  class=""ol4"">
  <a
    href=""http://www.bbc.co.uk/news/world-asia-23217460""
    class=""story"">
    <span
      class=""livestats-icon livestats-4"">4: </span>Rare tigers trap Indonesians up tree</a>
</li>
<li
  class=""ol5"">
  <a
    href=""http://www.bbc.co.uk/news/uk-england-23214468""
    class=""story"">
    <span
      class=""livestats-icon livestats-5"">5: </span>Footballers held over 'sex attack'</a>
</li>
<li
  class=""ol6"">
  <a
    href=""http://www.bbc.co.uk/news/world-us-canada-23218614""
    class=""story"">
    <span
      class=""livestats-icon livestats-6"">6: </span>Canada runaway train death toll rises</a>
</li>
<li
  class=""ol7"">
  <a
    href=""http://www.bbc.co.uk/news/uk-23213740""
    class=""story"">
    <span
      class=""livestats-icon livestats-7"">7: </span>Abu Qatada deported from Britain</a>
</li>
<li
  class=""ol8"">
  <a
    href=""http://www.bbc.co.uk/news/uk-23214821""
    class=""story"">
    <span
      class=""livestats-icon livestats-8"">8: </span>Inverdale sorry for Bartoli remark</a>
</li>
<li
  class=""ol9"">
  <a
    href=""http://www.bbc.co.uk/news/world-asia-india-23216592""
    class=""story"">
    <span
      class=""livestats-icon livestats-9"">9: </span>Blasts at Indian Buddhist complex</a>
</li>
<li
  class=""ol10"">
  <a
    href=""http://www.bbc.co.uk/news/magazine-23199377""
    class=""story"">
    <span
      class=""livestats-icon livestats-10"">10: </span>A presidential democracy without a president</a>
</li>
      		</ol>
      	</div>
					
					<h3 class=""tab ""><a href=""#"">Video/Audio</a></h3>
		
		<div class=""panel "">
      		<ol>
	      		<li
  class=""first-child has-icon-watch ol1"">
  <a
    href=""http://www.bbc.co.uk/news/world-us-canada-23215909""
    class=""story"">
    <span
      class=""livestats-icon livestats-1"">1: </span>Plane crash 'happened in a flash'<span
      class=""gvl3-icon gvl3-icon-watch""> Watch</span></a>
</li>
<li
  class=""has-icon-watch ol2"">
  <a
    href=""http://www.bbc.co.uk/news/video_and_audio/""
    class=""story"">
    <span
      class=""livestats-icon livestats-2"">2: </span>One-minute World News<span
      class=""gvl3-icon gvl3-icon-watch""> Watch</span></a>
</li>
<li
  class=""has-icon-watch ol3"">
  <a
    href=""http://www.bbc.co.uk/news/world-asia-23218704""
    class=""story"">
    <span
      class=""livestats-icon livestats-3"">3: </span>'I just remember this magnificent whale'<span
      class=""gvl3-icon gvl3-icon-watch""> Watch</span></a>
</li>
<li
  class=""has-icon-watch ol4"">
  <a
    href=""http://www.bbc.co.uk/news/world-us-canada-21477586""
    class=""story"">
    <span
      class=""livestats-icon livestats-4"">4: </span>Killer whale calf's birth caught on camera<span
      class=""gvl3-icon gvl3-icon-watch""> Watch</span></a>
</li>
<li
  class=""has-icon-watch ol5"">
  <a
    href=""http://www.bbc.co.uk/news/world-asia-23219228""
    class=""story"">
    <span
      class=""livestats-icon livestats-5"">5: </span>Surfer knocked unconscious by whale<span
      class=""gvl3-icon gvl3-icon-watch""> Watch</span></a>
</li>
<li
  class=""has-icon-watch ol6"">
  <a
    href=""http://www.bbc.co.uk/news/world-us-canada-23214500""
    class=""story"">
    <span
      class=""livestats-icon livestats-6"">6: </span>Eyewitness: 'Plane was out of control'<span
      class=""gvl3-icon gvl3-icon-watch""> Watch</span></a>
</li>
<li
  class=""has-icon-watch ol7"">
  <a
    href=""http://www.bbc.co.uk/news/world-us-canada-23214496""
    class=""story"">
    <span
      class=""livestats-icon livestats-7"">7: </span>'Everyone knows someone missing'<span
      class=""gvl3-icon gvl3-icon-watch""> Watch</span></a>
</li>
<li
  class=""has-icon-watch ol8"">
  <a
    href=""http://www.bbc.co.uk/news/world-us-canada-23152464""
    class=""story"">
    <span
      class=""livestats-icon livestats-8"">8: </span>Children living with constant and incurable pain<span
      class=""gvl3-icon gvl3-icon-watch""> Watch</span></a>
</li>
<li
  class=""has-icon-watch ol9"">
  <a
    href=""http://www.bbc.co.uk/news/world-us-canada-23174535""
    class=""story"">
    <span
      class=""livestats-icon livestats-9"">9: </span>Death Valley: Hot enough to fry an egg?<span
      class=""gvl3-icon gvl3-icon-watch""> Watch</span></a>
</li>
<li
  class=""has-icon-watch ol10"">
  <a
    href=""http://www.bbc.co.uk/news/world-asia-23207205""
    class=""story"">
    <span
      class=""livestats-icon livestats-10"">10: </span>Pinki, 11, to toss Wimbledon final coin<span
      class=""gvl3-icon gvl3-icon-watch""> Watch</span></a>
</li>
      		</ol>
      	</div>
		
</div>

<script type=""text/javascript"">$render(""most-popular"",""most-popular"");</script>

	       	     </div>
	
		
	
			




		     <div class=""hyperpuff"">
	       	         <div id=""promotional-content"" class=""hyper-promotional-content"">
	
			<h2>Elsewhere on BBC News</h2>
	
	<ul>
							
						
															
										<li class=""large-image first-child"">
				




		


		




<h3>
	<a class=""story is-live"" rel=""published-1373032896602"" href=""http://www.bbc.co.uk/sport/0/formula1/23198683""><img src=""http://news.bbcimg.co.uk/media/images/68573000/jpg/_68573210_172831047.jpg"" alt=""F1 Grand prix"" />F1: German Grand Prix <span class=""gvl3-icon-wrapper""><span class=""gvl3-icon gvl3-icon-invert-live""> Live</span></span></a>

		</h3>

									<p>Follow all the action with live video and text updates from BBC Sport </p>
							</li>
			</ul>
	 
</div>
<script type=""text/javascript"">$render(""hyper-promotional-content"",""promotional-content"");</script>


	       	     </div>
	
		
		
			




		     <div class=""hyperpuff"">
	       	             		  		    	
    		    		  

<div id=""container-programme-promotion"" class=""container-programme-promotion"">
			<h2 class=""programmes-header"">Programmes</h2>
		
	

						
<ul class=""programme-breakout"">
	
	
			
	<li class=""first-child large-image"">		
		




		


		




<h3 class="" programme-header"">
	<a class=""story"" rel=""published-1373031455192"" href=""http://www.bbc.co.uk/programmes/p01c6zrr""><img src=""http://news.bbcimg.co.uk/media/images/68571000/jpg/_68571925_massage_640robot.jpg"" alt=""A massaging robot"" />Fast Track<span class=""gvl3-icon-wrapper""><span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span></span></a>

		</h3>

		<p>The must-have travel gadgets for a trouble-free journey including a robot to give you a massage</p>
		
		 
	</li>
</ul>		
	</div>
<script type=""text/javascript"">$render(""container-programmes-promotion"",""container-programme-promotion"");</script>
	
	       	     </div>
	
		
		
</div>

	<!-- END #MAIN-CONTENT & CPS_ASSET_TYPE CLASS: story -->
	</div>
<!-- END CPS_AUDIENCE CLASS: international -->
	
</div> 
<div id=""related-services"" class=""footer"">
   <div id=""news-services"">
      <h2>Services</h2>
      <ul>
         <li id=""service-mobile"" class=""first-child""><a href=""http://www.bbc.co.uk/news/10628994""><span class=""gvl3-mobile-icon-large services-icon"">&nbsp;</span>Mobile</a></li>
         <li id=""service-feeds""><a href=""/news/help-17655000""><span class=""gvl3-connected-tv-icon-large services-icon"">&nbsp;</span>Connected TV</a></li>
         <li id=""service-podcast""><a href=""http://www.bbc.co.uk/news/10628494""><span class=""gvl3-feeds-icon-large services-icon"">&nbsp;</span>News feeds</a></li>
         <li id=""service-alerts""><a href=""http://www.bbc.co.uk/news/10628323""><span class=""gvl3-alerts-icon-large services-icon"">&nbsp;</span>Alerts</a></li>
         <li id=""service-email-news""><a href=""http://www.bbc.co.uk/news/help/16617948""><span class=""gvl3-email-icon-large services-icon"">&nbsp;</span>E-mail news</a></li>
      </ul>	 
   </div>
   <div id=""news-related-sites"">
      <h2><a href=""http://www.bbc.co.uk/news/19888761"">About BBC News</a></h2>
      <ul>
         <li class=""column-1""><a href=""http://www.bbc.co.uk/news/blogs/the_editors/"">Editors' blog</a></li>
         <li class=""column-1""><a href=""http://www.bbc.co.uk/journalism/"">BBC College of Journalism</a></li>
         <li class=""column-1""><a href=""http://www.bbc.co.uk/news/10621655"">News sources</a></li>
         <li class=""column-1""><a href=""http://www.bbc.co.uk/mediaaction/"">Media Action</a></li>
         <li class=""column-1""><a href=""http://www.bbc.co.uk/editorialguidelines/"">Editorial Guidelines</a></li>
      </ul>
   </div>
</div>
</div><!-- close us-and-canada -->



	
	

   </div>   <!--[if IE 6]> <div id=""blq-ie6-upgrade""> <p> <span>You're using the Internet Explorer 6 browser to view the BBC website. Our site will work much better if you change to a more modern browser. It's free, quick and easy.</span> <a href=""http://www.browserchoice.eu/"">Find out more <span>about upgrading your browser</span> here&hellip;</a> </p> </div> <![endif]-->  <div id=""blq-foot"" xml:lang=""en-GB"" class=""blq-rst blq-clearfix blq-foot-transparent blq-foot-text-dark""> <div id=""blq-footlinks""> <h2 class=""blq-hide"">BBC links</h2>       <ul>                    <li class=""blq-footlinks-row""> <ul class=""blq-footlinks-row-list""> <li><a href=""/news/mobile/"" id=""blq-footer-mobile"">Mobile site</a></li><li><a href=""http://www.bbc.co.uk/terms/"">Terms of Use</a></li><li><a href=""http://www.bbc.co.uk/aboutthebbc/"">About the BBC</a></li> </ul> </li>                     <li class=""blq-footlinks-row""> <ul class=""blq-footlinks-row-list""> <li><a href=""http://advertising.bbcworldwide.com"">Advertise With Us</a></li><li><a href=""http://www.bbc.co.uk/privacy/"">Privacy</a></li><li><a href=""http://www.bbc.co.uk/accessibility/"">Accessibility Help</a></li> </ul> </li>                     <li class=""blq-footlinks-row""> <ul class=""blq-footlinks-row-list""> <li><a href=""http://www.bbc.co.uk/bbc.com/ad-choices/"">Ad Choices</a></li><li><a href=""http://www.bbc.co.uk/privacy/bbc-cookies-policy.shtml"">Cookies</a></li><li><a href=""http://www.bbc.co.uk/news/21323537"">Contact the BBC</a></li> </ul> </li>           <li class=""blq-footlinks-row""> <ul class=""blq-footlinks-row-list""> <li><a href=""http://www.bbc.co.uk/guidance/"">Parental Guidance</a></li> </ul> </li>             </ul> <script type=""text/javascript"">/*<![CDATA[*/ (function() { var mLink = document.getElementById('blq-footer-mobile'), stick = function() { var d = new Date (); d.setYear(d.getFullYear() + 1); d = d.toUTCString(); window.bbccookies.set('ckps_d=m;domain=.bbc.co.uk;path=/;expires=' + d ); window.bbccookies.set('ckps_d=m;domain=.bbc.com;path=/;expires=' + d ); }; if (mLink) {  if (mLink.addEventListener) { mLink.addEventListener('click', stick, false); } else if (mLink.attachEvent) { mLink.attachEvent('onclick', stick); } } })(); /*]]>*/</script>  </div>  <div id=""blq-foot-blocks"" class=""blq-footer-image-dark""><img src=""http://static.bbci.co.uk/frameworks/barlesque/2.48.3/desktop/3.5/img/blocks/dark.png"" width=""84"" height=""24"" alt=""BBC"" /></div>  <p id=""blq-disclaim""><span id=""blq-copy"">BBC &copy; 2013</span> <a href=""http://www.bbc.co.uk/help/web/links/"">The BBC is not responsible for the content of external sites. Read more.</a></p> <div id=""blq-obit""><p><strong>This page is best viewed in an up-to-date web browser with style sheets (CSS) enabled. While you will be able to view the content of this page in your current browser, you will not be able to get the full visual experience. Please consider upgrading your browser software or enabling style sheets (CSS) if you are able to do so.</strong></p></div> </div> </div> 
<!-- BBCDOTCOM analytics template:server-side journalismVariant: true ipIsAdvertiseCombined: true adsEnabled: false showDotcom: true flagpole: ON -->
            
    <!-- BBCCOM analytics server-side -->
<div id=""bbccomWebBug"" class=""bbccomWebBug""></div>

<script type=""text/javascript"">
    /*<![CDATA[*/
    if('undefined' != typeof(bbcdotcom) && 'undefined' != typeof(bbcdotcom.stats)) {
        bbcdotcom.stats.adEnabled = ""(none)"";
        bbcdotcom.stats.contentType = ""HTML"";
    }
    /*]]>*/
</script>



    <!-- Start Audience Science -->
    <script type=""text/javascript"" src=""http://js.revsci.net/gateway/gw.js?csid=J08781""></script>
    <script type=""text/javascript"">
        /*<![CDATA[*/
        var adKeyword = document.getElementsByName('ad_keyword');
        if('/news/uk-11767495' == window.location.pathname) {
            J08781.DM_addEncToLoc(""Section"",""Royal Wedding"");
        } else if (undefined != adKeyword[0]) {
            J08781.DM_addEncToLoc(""Section"",adKeyword[0].content);
        } else if (""undefined"" != typeof bbc &&
            ""undefined"" != typeof bbc.fmtj &&
            ""undefined"" != typeof bbc.fmtj.page &&
            ""undefined"" != typeof bbc.fmtj.page.section) {
                J08781.DM_addEncToLoc(""Section"", bbc.fmtj.page.section);
        }
        J08781.DM_tag();
        /*]]>*/
    </script>
    <!-- End Audience Science -->

    <!-- SiteCatalyst code version: H.21.
    Copyright 1996-2010 Adobe, Inc. All Rights Reserved
    More info available at http://www.omniture.com -->
    
        <script type=""text/javascript"">
            var s_account = ""bbcwglobalprod"";
        </script>
    
    
        <script type=""text/javascript"" src=""http://news.bbcimg.co.uk/js/app/bbccom/0.3.189/s_code.js""></script>
    
    <script type=""text/javascript""><!--
        /************* DO NOT ALTER ANYTHING BELOW THIS LINE ! **************/
        var s_code=scw.t();if(s_code)document.write(s_code)//--></script>
        <script type=""text/javascript""><!--
        if(navigator.appVersion.indexOf('MSIE')>=0)document.write(unescape('%3C')+'\!-'+'-')
        //--></script><noscript><div><a href=""http://www.omniture.com"" title=""Web Analytics""><img
        src=""http://sa.bbc.com/b/ss/bbcwglobalprod/1/H.21--NS/0""
        height=""1"" width=""1"" alt="""" /></a></div></noscript><!--/DO NOT REMOVE/-->
    <!-- End SiteCatalyst code version: H.21. -->


    <!-- Begin comScore Tag -->
    <script type=""text/javascript"">
        document.write(unescape(""%3Cscript src='"" + (document.location.protocol == ""https:"" ? ""https://sb"" : ""http://b"") + "".scorecardresearch.com/beacon.js' %3E%3C/script%3E""));</script>
    <script type=""text/javascript"">
        COMSCORE.beacon({
            c1:2,
            c2:""6035051"",
            c3:"""",
            c4:""www.bbc.co.uk/news/world-us-canada-23214513"",
            c5:"""",
            c6:"""",
            c15:""""
        });
    </script>
    <noscript>
        <div>
            <img src=""http://b.scorecardresearch.com/b?c1=2&amp;c2=6035051&amp;c3=&amp;c4=www.bbc.co.uk/news/world-us-canada-23214513&amp;c5=&amp;c6=&amp;c15=&amp;cv=1.3&amp;cj=1"" style=""display:none"" width=""0"" height=""0"" alt="""" />
        </div>
    </noscript>
    <!-- End comScore Tag -->








    <!-- START Nielsen Online SiteCensus V6.0 -->
    <!-- COPYRIGHT 2009 Nielsen Online -->
    <script type=""text/javascript"" src=""http://secure-au.imrworldwide.com/v60.js"">
    </script>
    <script type=""text/javascript"">
        nol_t({cid:""au-bbc"",content:""0"",server:""secure-au""}).record().post();
    </script>
    <noscript>
        <div>
            <img src=""http://secure-au.imrworldwide.com/cgi-bin/m?ci=au-bbc&amp;cg=0&amp;cc=1&amp;ts=noscript"" alt="""" />
        </div>
    </noscript>
    <!-- END Nielsen Online SiteCensus V6.0 -->













    <!-- Effective Measure BBCCOM-1195 -->
    <script type=""text/javascript"">
      (function() {
        var em = document.createElement('script'); em.type = 'text/javascript'; em.async = true;
        em.src = ('https:' == document.location.protocol ? 'https://me-ssl' : 'http://me-cdn') + '.effectivemeasure.net/em.js';
        var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(em, s);
      })();
    </script>
    <noscript>
        <div>
            <img src=""http://me.effectivemeasure.net/em_image"" alt="""" style=""position:absolute; left:-5px;"" />
        </div>
    </noscript>
    <!-- End Effective Measure -->






     </div> </div>  <script type=""text/javascript""> if (typeof require !== 'undefined') { require(['istats-1'], function(istats){ istats.track('external', { region: document.getElementById('blq-main') }); istats.track('download', { region: document.getElementById('blq-main') }); }); } </script>  <script type=""text/html"" id=""blq-panel-template-promo""><![CDATA[ <div id=""blq-panel-promo"" class=""blq-masthead-container""></div> ]]></script> <script type=""text/html"" id=""blq-panel-template-more""><![CDATA[ <div id=""blq-panel-more"" class=""blq-masthead-container  blq-clearfix"" xml:lang=""en-GB"" dir=""ltr""> <div class=""blq-panel-container panel-paneltype-more""> <div class=""panel-header""> <h2> <a href=""http://www.bbc.co.uk/a-z/"">  More&hellip;  </a> </h2>  <a href=""http://www.bbc.co.uk/a-z/"" class=""panel-header-links panel-header-link"">Full A-Z<span class=""blq-hide""> of BBC sites</span></a>  </div> <div class=""panel-component panel-links"">       <ul>   <li> <a href=""http://www.bbc.co.uk/cbbc/""  >CBBC</a> </li>    <li> <a href=""http://www.bbc.co.uk/cbeebies/""  >CBeebies</a> </li>    <li> <a href=""http://www.bbc.co.uk/comedy/""  >Comedy</a> </li>   </ul>  <ul>   <li> <a href=""http://www.bbc.co.uk/food/""  >Food</a> </li>    <li> <a href=""http://www.bbc.co.uk/history/""  >History</a> </li>    <li> <a href=""http://www.bbc.co.uk/learning/""  >Learning</a> </li>   </ul>  <ul>   <li> <a href=""http://www.bbc.co.uk/music/""  >Music</a> </li>    <li> <a href=""http://www.bbc.co.uk/science/""  >Science</a> </li>    <li> <a href=""http://www.bbc.co.uk/nature/""  >Nature</a> </li>   </ul>  <ul>   <li> <a href=""http://www.bbc.co.uk/local/""  >Local</a> </li>    <li> <a href=""http://www.bbc.co.uk/travelnews/""  >Travel News</a> </li>   </ul>   </div> </div> ]]></script>            
	

<!-- shared/foot -->
<script type=""text/javascript"">
	bbc.fmtj.common.removeNoScript({});
	bbc.fmtj.common.tabs.createTabs({});
</script>
<!-- hi/news/foot.inc -->
<!-- shared/foot_story -->
<!-- #CREAM hi news international foot.inc -->

 

</body>
</html>


";
            }
        }
    }
}

