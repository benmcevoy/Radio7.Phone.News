using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Radio7.Phone.HtmlCleaner.Tests
{
    class WSJ
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
<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">

<html xmlns=""http://www.w3.org/1999/xhtml"" xmlns:fb=""http://www.facebook.com/2008/fbml"" xmlns:og=""http://ogp.me/ns#"" xml:lang=""en"" lang=""en"">
  <head>
  <meta http-equiv=""content-type"" content=""text/html; charset=UTF-8"" />

  	<!--added for registration bypass2 October 3,2002-->
<!-- CDS hostname /secj2kentwap07/ -->
<title>Immigration Bill Faces Uphill Climb in the House - WSJ.com</title>
<link rel=""canonical"" href=""http://online.wsj.com/article/SB10001424127887324251504578577842451273534.html"" />
  <meta property=""og:url"" content=""http://online.wsj.com/article/SB10001424127887324251504578577842451273534.html"" />
    <meta name=""sitedomain"" content=""online.wsj.com"" />
<meta name=""primaryproduct"" content=""Online Journal"" />
<meta name=""ctype"" content=""article"" />
<meta name=""subsection"" content=""US"" />
<meta name=""author"" content=""Janet Hook"" />
<meta name=""language"" content=""en"" />
<meta name=""displayname"" content=""Politics and Policy"" />
<meta name=""pagename"" content=""Politics and Policy_SB10001424127887324251504578577842451273534"" />
<meta name=""keywords"" content=""Political/General News, Asylum/Immigration, Politics/International Relations, Domestic Politics, Government Bodies, Legislative Branch, Lower House, Elections, National/Presidential Elections"" />
<meta property=""og:title"" content=""Immigration Bill Faces Uphill Climb in the House"" />
<meta name=""news_keywords"" content=""Political/General News, Asylum/Immigration, Politics/International Relations, Domestic Politics, Government Bodies, Legislative Branch, Lower House, Elections, National/Presidential Elections"" />
<meta property=""og:description"" content=""Few House members of either party are feeling pressure to make any concessions on immigration, making it hard to see a path to a bill passing there."" />
<meta name=""csource"" content=""WSJ Online"" />
<meta name=""section"" content=""Article"" />
<meta name=""description"" content=""Few House members of either party are feeling pressure to make any concessions on immigration, making it hard to see a path to a bill passing there."" />
<meta property=""og:image"" content=""http://s.wsj.net/public/resources/images/NA-BX054_HOUSEI_D_20130630155140.jpg"" />
<meta content=""WSJ.com"" name=""application-name"" /><meta content=""app-id=364387007"" name=""apple-itunes-app"" /><meta content=""368513495882"" property=""fb:app_id"" /><meta content=""article"" property=""og:type"" /><meta name=""twitter:card"" value=""summary"" /><meta name=""twitter:site"" value=""@WSJ"" /><meta name=""twitter:url"" value=""http://online.wsj.com/article/SB10001424127887324251504578577842451273534.html"" /><meta content=""name=SmartMoney;action-uri=http://www.smartmoney.com/;icon-uri=http://www.smartmoney.com/favicon.ico"" name=""msapplication-task"" /><meta content=""8304333127"" property=""fb:page_id"" /><meta content=""telephone=no"" name=""format-detection"" /><meta itemprop=""dateModified"" value=""2013-06-30 19:30:00.0"" /><meta itemprop=""datePublished"" value=""2013-06-30 19:30:00.0"" /><meta name=""pdate"" value=""20130630073000"" /><meta name=""udate"" value=""20130630073000"" /><meta name='twitter:image' value='http://s.wsj.net/public/resources/images/NA-BX054_HOUSEI_D_20130630155140.jpg'/><link rel=""stylesheet"" href=""http://sc.wsj.net/djstyle/2/std/ASIA_WSJ/0_0_WA_0001-20130626020420.css"" type=""text/css"" /><link rel=""stylesheet"" href=""http://sc.wsj.net/djstyle/3/std/ASIA_WSJ/0_0_WA_0001-20130626020420.css"" type=""text/css"" /><link rel=""stylesheet"" href=""http://sc.wsj.net/djstyle/4/std/ASIA_WSJ/0_0_WA_0001-20130626020420.css"" type=""text/css"" /><!--[if lt IE 7]><link rel=""stylesheet"" href=""http://sc.wsj.net/djstyle/1/ie6/ASIA_WSJ/0_0_WA_0001-20130626020420.css"" type=""text/css"" /><link rel=""stylesheet"" href=""http://sc.wsj.net/css/ie6-wsjdashboard_flat.css"" type=""text/css"" /><![endif]-->
<!--[if IE 7]><link rel=""stylesheet"" href=""http://sc.wsj.net/djstyle/1/ie7/ASIA_WSJ/0_0_WA_0001-20130626020420.css"" type=""text/css"" /><link rel=""stylesheet"" href=""http://sc.wsj.net/css/ie7-wsjdashboard_flat.css"" type=""text/css"" /><![endif]-->
<!--[if IE 8]><link rel=""stylesheet"" href=""http://sc.wsj.net/djstyle/1/ie8/ASIA_WSJ/0_0_WA_0001-20130626020420.css"" type=""text/css"" /><link rel=""stylesheet"" href=""http://sc.wsj.net/css/ie8-wsjdashboard_flat.css"" type=""text/css"" /><![endif]-->
<script type=""text/javascript"" language=""javascript"" charset=""utf-8""><!--
var userName = '(none)';

var serverTime = new Date(""June 30, 2013 19:40:34"");
//--></script>
<script type=""text/javascript""><!--
var openHouseMode=""false"",pDateinSpanish=""domingo, 30 de junio, 2013, 19:30:00 EDT"",uP=""http://online.wsj.com"",mpsection=""US"",pDateinTurkish=""01 Temmuz 2013, Pazartesi, 02:30 TSİ"",isDenial=""false"",pDate=""Sunday,&nbsp;June&nbsp;30,&nbsp;2013&nbsp;As of&nbsp;7:30&nbsp;PM&nbsp;EDT"",_navText="""",gcLFU=""https://commerce.wsj.com/auth/submitlogin"",pID=""0_0_WA_0001"",cdnDomain=""http://s.wsj.net"",nSP="""",parentTabID=""HNTAB1"",gcDomain=""online.wsj.com"",isTrial=""true"",isFree=""true"",PSSG=""header0_0_WA_0001"",pDateinJapanese=""2013&#24180; 7月 01&#26085; (月曜日)"",pDateinGerman=""Montag, 1. Juli 2013, 01:30:00 MESZ"",gcHSP=""https://"",globalHeaderPageTitle=""Politics & Policy"",pDateinGMT=""Sunday,June 30, 2013 23:30:00 GMT"",PSS=""0_0_WA_0001"",pStl=""renovation"",gcPH=""/pj/PortfolioDisplay.cgi"",pDateinKorean=""월요일, 1. 7월 2013, 08:30:00 KST"",pDateinIndonesian=""Senin, 1. Juli 2013, 06:30:00 WIT"",pDateinPortuguese=""Domingo, 30 de Junho, 2013, 19:30:00 EDT"";
var AT_VARS={articlePage:'Politics and Policy',baseDocId:'SB10001424127887324251504578577842451273534',suppressClickUrl:false,suppressReprints:false,suppressEmailThis:false,suppressMostPopular:false,articleUrl:'http://online.wsj.com/article/SB10001424127887324251504578577842451273534.html',articleEmailUrl:'http://online.wsj.com/article_email/SB10001424127887324251504578577842451273534-lMyQjAxMTAzMDMwMDEzNDAyWj.html',clickTitle:'WSJ.com - Immigration Bill Faces Uphill Climb in House',articleHeadline:'Immigration Bill Faces Uphill Climb in House',bodyText:'Few+House+members+of+either+party+are+feeling+pressure+to+make+any+concessions+on+immigration%2C+making+it+hard+to+see+a+path+to+a+bill+passing+there.',seoDescription:'Immigration+Bill+Faces+Uphill+Climb+in+the+House',imgSizeA:'http://s.wsj.net/public/resources/images/NA-BX054_HOUSEI_A_20130630155140.jpg',publicationName:'wsj.com',publicationDate:'2013-06-30',baseDocExtension:'.djm',authors:'Janet+Hook%2C',djType:'true',articleType:'Politics+and+Policy'};
window.name = ""wndMain""

//--></script>
<script type=""text/javascript"" src=""http://s.wsj.net/javascript/j_top-static.js""></script>
<script type=""text/javascript"">
    /* <![CDATA[ */
    var jsexec = dj.util.JSExec(dj.context.jsexec);
 if (window.AT_VARS.articleType.indexOf('The+Mossberg+Solution')> -1) { globalPerfTesting = true;djPerf.init( { type: 'gomez', frequency: '10', acctId: '72D329', pgId:'ArticleType: The+Mossberg+Solution', grpId: 'Article Pages' } );} if (window.AT_VARS.articleType.indexOf('Business')> -1) { globalPerfTesting = true;djPerf.init( { type: 'gomez', frequency: '100', acctId: '72D329', pgId:'ArticleType: Business', grpId: 'Article Pages' } );};window._sf_startpt=(new Date()).getTime();
    /* ]]> */
    </script>
<link rel=""shortcut icon"" href=""/favicon.ico"" />
</head>
  <body >
    <a name=""top""></a><div class=""fullwide pagewide""><div class=""mainHeader""><!-- updated  -->

<script>
    var isReferrerArticleFree = false;
   
</script>
<div id=""fb-root""></div><div id=""fbscrim"" style=""display:none;"" class=""fullpageScrim""></div><div id=""fbscrim_content"" style=""display:none;"" class=""fullpageScrimContent""></div>
<script type=""text/javascript"">var openHouseMode='undefined';(function(){var topDjcs=function(){var _url={decode:function(str){var string="""";var i=0;var c=0;var c1=0;var c2=0;var utftext=null;if(!str){return null;}
utftext=unescape(str);while(i<utftext.length){c=utftext.charCodeAt(i);if(c<128){string+=String.fromCharCode(c);i++;}else if((c>191)&&(c<224)){c2=utftext.charCodeAt(i+1);string+=String.fromCharCode(((c&31)<<6)|(c2&63));i+=2;}else{c2=utftext.charCodeAt(i+1);c3=utftext.charCodeAt(i+2);string+=String.fromCharCode(((c&15)<<12)|((c2&63)<<6)|(c3&63));i+=3;}}
return string;}};var _base64={_keyStr:""ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/="",decode:function(input){var output="""";var chr1,chr2,chr3;var enc1,enc2,enc3,enc4;var i=0;input=input.replace(/[^A-Za-z0-9\+\/\=]/g,"""");while(i<input.length){enc1=_base64._keyStr.indexOf(input.charAt(i++));enc2=_base64._keyStr.indexOf(input.charAt(i++));enc3=_base64._keyStr.indexOf(input.charAt(i++));enc4=_base64._keyStr.indexOf(input.charAt(i++));chr1=(enc1<<2)|(enc2>>4);chr2=((enc2&15)<<4)|(enc3>>2);chr3=((enc3&3)<<6)|enc4;output=output+String.fromCharCode(chr1);if(enc3!=64){output=output+String.fromCharCode(chr2);}
if(enc4!=64){output=output+String.fromCharCode(chr3);}}
output=_url.decode(output);return output;}};var _private={runCount:1,canRun:function(){if(_private.runCount>0){_private.runCount--;if(_private.runCount>=0){return true;}}
return false;},products:{""WSJ-ACCOUNT"":3,""WSJ"":2,""BARRONS"":30,""NEWSREADER"":161,""FREEREG-BASE"":341,""HILTON"":381,""WSJ-TRANSIENT"":401,""EXP-LEXISNEXIS"":721,""EXP-GAYLORD"":761},hasRole:function(role,pArray){if(!pArray){return false;}
var rCode=_private.products[role];if(!rCode){return false;}
for(var x=0;x<pArray.length;x++){if(pArray[x]==rCode){return true;}}
return false;},getCookie:function(cName){if(document.cookie.length<=0){return null;}
var cStart=document.cookie.indexOf(cName+""="");if(cStart===-1){return null;}
cStart=cStart+cName.length+1;var cEnd=document.cookie.indexOf("";"",cStart);if(cEnd===-1){cEnd=document.cookie.length;}
var cValue=document.cookie.substring(cStart,cEnd);if(typeof cValue===""remove""||cValue===null){return null;}
return cValue;}};var _public={isOpenHouseUser:function(){var user=_private.getCookie(""djcs_loc"");var partner=_private.getCookie(""djcs_partner"");if(user||partner){return true;}
var region=_private.getCookie(""wsjregion"");var bolVal=region.indexOf('us')>-1||region.indexOf('uk')>-1;return false;},isLoggedIn:function(){if(!_private.canRun()){throw new Error('Only allowed to test djcs:isLoggedIn once');}
var cValue=_private.getCookie(""wsjlocal"");if(cValue){return true;}
return false;},hasRole:function(role){var cValue=_private.getCookie(""wsjlocal"");cValue=_url.decode(cValue);cValue=_url.decode(cValue);cValue=_base64.decode(cValue);var unpr=cValue.split("":"");if(unpr.constructor==Array&&unpr.length==3){if(unpr[0]==""V1""){var pr=unpr[2].split("","");if(pr.constructor==Array&&pr.length>0){return _private.hasRole(role,pr);}}}
return false;},isLoggedInHasRole:function(role){if(!_private.canRun()){throw new Error('Only allowed to test djcs:isLoggedInHasRole once');}
return _public.hasRole(role);}};return _public;}();var d=document,dl=d.location;var fw=d.getElementsByTagName(""div"")[0];openHouseMode=topDjcs.isOpenHouseUser();var fwDiv=d.getElementsByTagName(""div"")[0];var bcn=d.getElementsByTagName(""div"");for(var i=0,node;node=bcn[i++];){if(node.className&&node.className.indexOf(""fullwide"")>-1){fwDiv=node;break;}}
if(topDjcs.isLoggedIn()){var partners=[""HILTON"",""EXP-LEXISNEXIS"",""EXP-GAYLORD""];var sectionNoneClass="" sectionType-none"";var partnerClass="""";for(var i=0,numPartners=partners.length;i<numPartners;i++){var partner=partners[i];if(topDjcs.hasRole(partner)){var hat=d.createElement('div');partnerClass="" subType-partner partnerType-""+partner;sectionNoneClass="" sectionType-none sectionType-partner-none"";hat.id=""partnerHat"";hat.className=""wsj_partnerhat uberHatPartner-""+partner;fwfc=fw.firstChild;hat.innerHTML='<div class=""partnerhat_container""><div class=""partnerhat_content""></div></div>';if(fwfc){fw.insertBefore(hat,fwfc);}else{fw.appendChild(hat);}
break;}}
if(topDjcs.hasRole('WSJ')||topDjcs.hasRole('WSJ-TRANSIENT')){if((typeof globalHeaderPageTitle==='undefined')||(globalHeaderPageTitle==="""")){fwDiv.className=fwDiv.className+"" subType-subscribed""+sectionNoneClass+partnerClass;}else{fwDiv.className=fwDiv.className+"" subType-subscribed""+partnerClass;}}else{if(openHouseMode===true&&((typeof globalHeaderPageTitle==='undefined')||(globalHeaderPageTitle===""""))){fwDiv.className=fwDiv.className+"" fullwide subType-subscribed sectionType-none sectionType-partner-none subType-partner partnerType-OPENHOUSE userType-reg-OPENHOUSE"";}else if(openHouseMode===true){fwDiv.className=fwDiv.className+"" fullwide subType-subscribed subType-partner partnerType-OPENHOUSE userType-reg-OPENHOUSE"";}else if((typeof globalHeaderPageTitle==='undefined')||(globalHeaderPageTitle==="""")){fwDiv.className=fwDiv.className+"" subType-registered""+sectionNoneClass+"" sectionType-uregistered""+partnerClass;}else{fwDiv.className=fwDiv.className+"" subType-registered""+partnerClass;}}}else{if(openHouseMode!='undefined'&&openHouseMode===true&&((typeof globalHeaderPageTitle==='undefined')||(globalHeaderPageTitle===""""))){fwDiv.className=fwDiv.className+"" fullwide subType-subscribed sectionType-none sectionType-partner-none subType-partner partnerType-OPENHOUSE userType-unsub-OPENHOUSE"";}else if(openHouseMode!='undefined'&&openHouseMode===true&&globalHeaderPageTitle===""Blogs""){fwDiv.className=fwDiv.className+"" fullwide subType-subscribed subType-partner partnerType-OPENHOUSE userType-unsub-OPENHOUSE "";}else if(openHouseMode!='undefined'&&openHouseMode===true){fwDiv.className=fwDiv.className+"" fullwide subType-subscribed subType-partner partnerType-OPENHOUSE userType-unsub-OPENHOUSE "";}else if((typeof globalHeaderPageTitle==='undefined')||(globalHeaderPageTitle==="""")){fwDiv.className=fwDiv.className+"" subType-unsubscribed sectionType-none sectionType-unsub-none"";}else{fwDiv.className=fwDiv.className+"" subType-unsubscribed"";}}
if(dl.hash.indexOf(""printMode"")>-1){try{var head=d.getElementsByTagName('head')[0];var link=document.createElement('link');link.rel='stylesheet';link.href='/css/wsjprint.css';link.type='text/css';head.appendChild(link);}catch(e){d.write('<link rel=""stylesheet"" href=""/css/wsjprint.css"" type=""text/css""/>');}}}());</script>         <div class=""hatWSJ_c""><div id=""hat_div"" class=""hat_wsjdn"">

  <div class=""hat_logo""></div>
    
  <ul  id=""hattabs"" class=""hat_tabs"">
            <li class=""hat_tab current"" id=""hat_tab_wsj_asia"">
            <a class=""hat_site_title"" href=""http://asia.wsj.com"" rel=""nofollow"">WSJAsia</a>	    
              <ul>
	      <li><a class=""hat_site_link"" href=""http://asia.wsj.com"" rel=""nofollow"">WSJAsia</a></li>	      
							  <li class=""hat_social_tab""><a id=""hat_fb_button"" class=""hat_fb_link"" href=""#"" title=""Follow WSJAsia on Facebook"">Facebook</a></li>
							  <li class=""hat_social_tab""><a id=""hat_twt_button"" class=""hat_twitter_link"" href=""#"" title=""Follow WSJAsia on Twitter"">Twitter</a></li>
              </ul>  
                <div id=""fb_like_overlay"" class=""hat_overlay hat_overlay_fb hidden""></div>
                <div id=""twitter_overlay"" class=""hat_overlay hat_overlay_twitter hidden""></div>          
          </li>    
            <li class=""hat_tab"" id=""hat_tab_live"">
            <a class=""hat_site_title"" href=""http://live.wsj.com"" rel=""nofollow"">WSJ Live</a>	    
              <ul>
	      <li><a class=""hat_site_link"" href=""http://live.wsj.com"" rel=""nofollow"">WSJ Live</a></li>	      
              </ul>  
          </li>    
            <li class=""hat_tab"" id=""hat_tab_mw"">
            <a class=""hat_site_title"" href=""http://www.marketwatch.com"" rel=""nofollow"">MarketWatch</a>	    
              <ul>
	      <li><a class=""hat_site_link"" href=""http://www.marketwatch.com"" rel=""nofollow"">MarketWatch</a></li>	      
              </ul>  
          </li>    
            <li class=""hat_tab"" id=""hat_tab_bol"">
            <a class=""hat_site_title"" href=""http://online.barrons.com/home"" rel=""nofollow"">Barron's</a>	    
              <ul>
	      <li><a class=""hat_site_link"" href=""http://online.barrons.com/home"" rel=""nofollow"">Barron's</a></li>	      
              </ul>  
          </li>    
            <li class=""hat_tab"" id=""hat_tab_atd"">
            <a class=""hat_site_title"" href=""http://allthingsd.com"" rel=""nofollow"">AllThingsDigital</a>	    
              <ul>
	      <li><a class=""hat_site_link"" href=""http://allthingsd.com"" rel=""nofollow"">AllThingsDigital</a></li>	      
              </ul>  
          </li>    
            <li class=""hat_tab"" id=""hat_tab_productx"">
            <a class=""hat_site_title"" href=""http://dj.wsj.com/hub?mod=WSJAsia_Hat"" rel=""nofollow"">Product X</a>	    
              <ul>
	      <li><a class=""hat_site_link"" href=""http://dj.wsj.com/hub?mod=WSJAsia_Hat"" rel=""nofollow"">Product X</a></li>	      
              </ul>  
          </li>    
              <li id=""hat_tab_dropdown"" class=""hat_tab_dropdown"">      
              <a id=""partyhat_more_dropdown"" class=""moreTarget"" href=""#"">More</a>                             
              <ul class=""hat_dd_list"">  
            <li id=""hat_tab_port"" class=""hat_dd_item "">
            <a href=""https://portfolio.wsj.com"" rel=""nofollow""  >New Portfolio</a>
            </li>      
            <li id=""hat tab big charts"" class=""hat_dd_item "">
            <a href=""http://bigcharts.marketwatch.com/"" rel=""nofollow""  >BigCharts</a>
            </li>      
            <li id=""hat_tab_fn"" class=""hat_dd_item "">
            <a href=""http://www.efinancialnews.com/"" rel=""nofollow""  >Financial News</a>
            </li>      
            <li id=""hat_tab_Professor_Journal"" class=""hat_dd_item "">
            <a href=""http://professor.wsj.com/"" rel=""nofollow""  >Professor Journal</a>
            </li>      
            <li id=""hat_tab_SmartMoney"" class=""hat_dd_item "">
            <a href=""http://www.smartmoney.com/"" rel=""nofollow""  >SmartMoney</a>
            </li>      
            <li id=""hat_tab_Student_Journal"" class=""hat_dd_item "">
            <a href=""http://wsjstudent.com/"" rel=""nofollow""  >Student Journal</a>
            </li>      
            <li id=""hat tab Virtual Stock Exchange"" class=""hat_dd_item "">
            <a href=""http://www.marketwatch.com/Game/"" rel=""nofollow""  >Virtual Stock Exchange</a>
            </li>      
            <li id=""hat tab WSJ Classifieds"" class=""hat_dd_item "">
            <a href=""http://classifieds.wsj.com/search"" rel=""nofollow""  >WSJ Classifieds</a>
            </li>      
            <li id=""hat tab WSJ Classroom"" class=""hat_dd_item "">
            <a href=""http://classroom.wsj.com/"" rel=""nofollow""  >WSJ Classroom</a>
            </li>      
            <li id=""hat tab WSJ Radio"" class=""hat_dd_item "">
            <a href=""http://www.wsjradio.com/"" rel=""nofollow""  >WSJ Radio</a>
            </li>      
            <li id=""wsjwine"" class=""hat_dd_item "">
            <a href=""http://www.wsjwine.com/"" rel=""nofollow""  >WSJ Wine</a>
            </li>      
                </ul></li>
  </ul>
  
<div class=""hdrSearch  hidden"" id=""searchBlingBox"" >
	<div id=""searchInputEle"" class=""hdrSearchC"" >
		<div >
			<form onsubmit=""return false;"">
				<input type=""text"" value=""News, Quotes, Companies, Videos"" class=""hdrSearchInput unUsed"" id=""globalHeaderSearchInput"" autocomplete=""off"" size=""28"">
				<button class=""hdrSearchBtn"" type=""button"">SEARCH</button>
			</form>
		</div>
	</div>
	<div id=""globalHeaderAutoComplete"" class=""hdrSearchList hidden"">
		<div class=""autocompleteContent"" >
		</div>		
	</div>
		<!--  Autocomplete viewTemplate content - could be used on pages where autocomplete is not in header -->
<!-- Do not change id of textArea its referred in dj.widget.autocomplete.autoCompleteViewTemplate.js-->	
<textarea id=""wsj_autocomplete_template"" style=""display:none"">	
 
	<div>
			<div class=""acHeadline hidden""  >
			</div>
			<div class=""dropdownContainerClass"">
				<div class=""suggestionblock hidden"" templateType=""C1"">	
					<ul role=""listbox"" class="""">
						<li role=""menuitem"" class=""hdrSearchListName"">
							headline
						</li>
						<li role=""menuitem"" class=""lineItem"">
							<a class=""searchResult"" href=""javascript:void(0);"">
							   <span class=""searchTerm"">gold</span>man
							</a>
						</li>						
					</ul>
				</div>
				<div class=""suggestionblock hidden"" templateType=""C3"">	
					<ul role=""listbox"" class=""hdrSearchListComp"">
						<li role=""menuitem"" class=""hdrSearchListName"">
							Companies
						</li>
						<li role=""menuitem"" class=""lineItem"">
							<a class=""searchResult"" href=""javascript:void(0);"">
								<div class=""searchListCompTicker"">
									<span class=""searchTerm"">GOLD</span>
								</div>
								<div class=""searchListCompName"">
									Ran
									<span class=""searchTerm"">gold</span> Resources Ltd. ADS
								</div>
								<div class=""searchListCompMarkets"">
									U.S.
								</div>
							</a>
						</li>						
					</ul>									
				</div>
			</div>
			<div class=""acFooter hidden"">
				<ul role=""listbox"" class=""hdrSearchListSearch"">
					<li role=""menuitem"" class="""">
						<a class=""footer"" href=""#"">View All Search Results &raquo;</a>
					</li>
				</ul>
			</div>
			<div id=""SearchSponsorBox"" class=""sponsorBox""></div>
		</div>
</textarea>

</div>
</div></div><!-- no match! -->
	
<div id=""factivaHeader_placeHolder"" class=""hidden""></div>
<!-- Functions and Macros -->








<!--[if !IE]> *** End masthead, including logo, subscriber info *** <![endif]-->



  <!-- determines what the parent css classes need to be depending on login and nav status -->


<!-- EBR ASIA -->
<div class=""gHeader_c"">
  <div class=""globalHeader"">
    <a href=""http://asia.wsj.com/home-page"" class=""mainLogo""><img src=""http://s.wsj.net/img/b.gif"" alt=""The Wall Street Journal"" class=""mainLogo_img""></a>
    <div class=""subSection"">
        <div class=""subPromo"" id=""headerPromoContainer""></div>
        <ul class=""custNav hidden"">
          <li class=""cLi""><a href=""http://www.wsj-asia.com/subscribecpc.html"" class=""ln"">Subscribe</a></li>
							<li class=""cLi""><a href=""#"" class=""ln loginClass"" >Log In</a></li>
						
        </ul>
    </div>
    <div class=""lnColl"">
<!-- module popEdition -->
<div id=""editionDDTrigger"" class=""popC popEdition popClosed"" >
  <a id=""editionPopTrigger"" href=""#"" class=""popTrigger popT-ed"">ASIA Edition <span class=""sym""></span></a>
  <div class=""popBox pop-ed"">
    <ul class=""lnUl"">
      <li class=""lnLi"" id=""usEdition""><a href=""http://online.wsj.com/home-page?_wsjregion=na,us&_homepage=/home/us"" onclick=""dj.util.Region.setViewByRegion('na,us');dj.util.Cookie.setGroupCookie('DJCOOKIE', 'HOMEPAGE', '/home/us', 365);"" class=""ln"">U.S.</a></li>
      <li class=""lnLi"" id=""AsiaEdition""><a href=""http://asia.wsj.com/home-page?_wsjregion=asia&_homepage=/home/asia"" class=""ln"">Asia</a></li>
      <li class=""lnLi"" id=""europeEdition""><a href=""http://europe.wsj.com/home-page?_wsjregion=europe&_homepage=/home/europe"" class=""ln"">Europe</a></li>   
    </ul>
    <ul class=""lnUl"">
      <li class=""lnLi"" id=""spaEdition""><a href=""http://online.wsj.com/americas"" class=""ln"">Am&#233;rica Latina</a></li>
      <li class=""lnLi"" id=""porEdition""><a href=""http://online.wsj.com/portuguese"" class=""ln"">Brasil</a></li>
      <li class=""lnLi"" id=""simChiEdition""><a href=""http://cn.wsj.com/gb/index.asp"" class=""ln ln_ea ln_sc""><span class=""mnLbl"">&#20013;&#25991;-&#31616;&#20307;</span><span class=""diffLbl"">(China)</span></a></li>
      <li class=""lnLi"" id=""germanyEdition""><a href=""http://www.wallstreetjournal.de"" class=""ln"">Deutschland</a></li>
      <li class=""lnLi"" id=""indiaEdition""><a href=""http://india.wsj.com/home-page?_wsjregion=asia,india&_homepage=/home/india"" class=""ln"">India</a></li>
      <li class=""lnLi"" id=""indonesiaEdition""><a href=""http://indo.wsj.com/home-page?_wsjregion=asia,indo&_homepage=/home/indo"" class=""ln"">Indonesia</a></li>
      <li class=""lnLi"" id=""jpnEdition""><a href=""http://jp.wsj.com/home-page?_wsjregion=asia,jp&_homepage=/home/jp"" class=""ln ln_ea ln_jp""><span class=""mnLbl"">&#26085;&#26412;</span><span class=""diffLbl"">(Japan)</span></a></li>
      <li class=""lnLi"" id=""koreaEdition""><a href=""http://kr.wsj.com/home-page?_wsjregion=asia,kr&_homepage=/home/kr"" class=""ln ln_ea ln_kr""><span class=""mnLbl"">&#54620;&#44397;</span><span class=""diffLbl"">(Korea)</span></a></li>
      <li class=""lnLi"" id=""turkeyEdition""><a href=""http://www.wsj.com.tr/home-page?_wsjregion=europe,tr&_homepage=/home/tr"" class=""ln"">T&#252;rkiye</a></li>
    </ul>
  </div>
  <!--[if lte IE 9]><iframe class=""popFrame ifr-ed"" src=""/static_html_files/iframe.html"" marginwidth=""0"" marginheight=""0"" scrolling=""no"" frameborder=""0""></iframe><![endif]-->
</div>
<!-- end module popEdition -->
      
      <span class=""hdMeta meta_date"" id=""pageDatePlaceholder""></span>
    </div>
  </div>
</div>
<!-- Functions and Macros -->










<div  class=""hidden"" data-src-isArticle=""Article Context"" data-src-currentPageSize=""0"" data-src-pageSection=""0_0_WP_2007"" data-src-pageName=""0_0_WP_2007""   ></div>
<!-- pageSection is 0_0_WP_2007   -->

<!--  updated ftl -->

<!-- pageSection is 0_0_WP_2007   -->
  <!-- isPageNotFound  -->
  
 
 
 
		<!-- fallback to this page if not found -->


<!--  wsjMainNav ftl included -->
<div class=""wsjMainNav"">
  <ul class=""linklist mainnav_wsj"">
    
			<li id=""nav_home"" class=""linklist_plain linklist_item linklist_dropdown linklist_item_home linklist_first"">
	 
        <div id=""wsjmn_dropdown1-0"" class=""wsjmn_dropdownTree wsjmn_ddState-collapsed"">
		<div class=""wsjmn_dropdown_container"">
		<div class=""mn_dropdownTitlebar"">
		  <p class=""mndType-more"">

					<span class=""mnText"">
					  							<a href=""http://online.wsj.com/home-page"" class=""mnLabel"">Home</a>
					 </span>
              </p>
		</div>
	  </div>
        </div>
      </li>
    
			<li id=""nav_world"" class=""linklist_item linklist_dropdown linklist_item_world"">
	 
        <div id=""wsjmn_dropdown2-0"" data-panel-service-uri=""/public/page/0_0_WG_HeaderOne_Dropdown-asia-world.html?path=false&business=false"" class=""wsjmn_dropdownTree wsjmn_ddState-collapsed"">
		<div class=""wsjmn_dropdown_container"">
		<div class=""mn_dropdownTitlebar"">
		  <p class=""mndType-more"">

					<span class=""mnText"">
					  							<a href=""http://online.wsj.com/public/page/news-global-world.html"" class=""mnLabel"">World</a>
					 </span>
					<span class=""mnIndicator"">
					  <a href=""#"" data-dropdownIndex=""wsjmn_dropdown2-0"" class=""mnExpand _exp"" style=""opacity:1"">&raquo; More</a>
					</span>
              </p>
		</div>
	  </div>
          <div id=""wsjmn_dropdown2-0_content"" class=""wsjmn_dropdown-expansion"">          
			<div class=""wsjmn_dropdown_container"">			
              <div class=""mn_dropdownTitlebar"">
                <p class=""mndType-more"">
                  <span class=""mnText""><a href=""http://online.wsj.com/public/page/news-global-world.html?mod=WSJ_topnav_world_main"" class=""mnLabel"">World</a></span>
                  <span class=""mnIndicator""><a href=""#"" class=""mnExpand"">&raquo; More</a></span>
                </p>
              </div>
            </div>    
            <div class=""wsjmn_dropdownPanel"">
              <div class=""wsjmn_dropdownContent"">
                <div class=""pmLoadingIndicator"">
                  <span>Loading&hellip;</span>
                </div>
              </div>
            </div>
          </div>
        </div>
      </li>
    
			<li id=""nav_asia"" class=""linklist_item linklist_dropdown linklist_item_asia"">
	 
        <div id=""wsjmn_dropdown3-0"" data-panel-service-uri=""/public/page/0_0_WG_HeaderOne_Dropdown-asia-asia.html?path=false&business=false"" class=""wsjmn_dropdownTree wsjmn_ddState-collapsed"">
		<div class=""wsjmn_dropdown_container"">
		<div class=""mn_dropdownTitlebar"">
		  <p class=""mndType-more"">

					<span class=""mnText"">
					  							<a href=""http://online.wsj.com/public/page/news-asia-business.html"" class=""mnLabel"">Asia</a>
					 </span>
					<span class=""mnIndicator"">
					  <a href=""#"" data-dropdownIndex=""wsjmn_dropdown3-0"" class=""mnExpand _exp"" style=""opacity:1"">&raquo; More</a>
					</span>
              </p>
		</div>
	  </div>
          <div id=""wsjmn_dropdown3-0_content"" class=""wsjmn_dropdown-expansion"">          
			<div class=""wsjmn_dropdown_container"">			
              <div class=""mn_dropdownTitlebar"">
                <p class=""mndType-more"">
                  <span class=""mnText""><a href=""http://online.wsj.com/public/page/news-asia-business.html?mod=WSJ_topnav_asia_main"" class=""mnLabel"">Asia</a></span>
                  <span class=""mnIndicator""><a href=""#"" class=""mnExpand"">&raquo; More</a></span>
                </p>
              </div>
            </div>    
            <div class=""wsjmn_dropdownPanel"">
              <div class=""wsjmn_dropdownContent"">
                <div class=""pmLoadingIndicator"">
                  <span>Loading&hellip;</span>
                </div>
              </div>
            </div>
          </div>
        </div>
      </li>
    
			<li id=""nav_china"" class=""linklist_item linklist_dropdown linklist_item_china"">
	 
        <div id=""wsjmn_dropdown4-0"" data-panel-service-uri=""/public/page/0_0_WG_HeaderOne_Dropdown-asia-china.html?path=false&business=false"" class=""wsjmn_dropdownTree wsjmn_ddState-collapsed"">
		<div class=""wsjmn_dropdown_container"">
		<div class=""mn_dropdownTitlebar"">
		  <p class=""mndType-more"">

					<span class=""mnText"">
					  							<a href=""http://online.wsj.com/public/page/news-china.html"" class=""mnLabel"">China</a>
					 </span>
					<span class=""mnIndicator"">
					  <a href=""#"" data-dropdownIndex=""wsjmn_dropdown4-0"" class=""mnExpand _exp"" style=""opacity:1"">&raquo; More</a>
					</span>
              </p>
		</div>
	  </div>
          <div id=""wsjmn_dropdown4-0_content"" class=""wsjmn_dropdown-expansion"">          
			<div class=""wsjmn_dropdown_container"">			
              <div class=""mn_dropdownTitlebar"">
                <p class=""mndType-more"">
                  <span class=""mnText""><a href=""http://online.wsj.com/public/page/news-china.html?mod=WSJ_topnav_china_main"" class=""mnLabel"">China</a></span>
                  <span class=""mnIndicator""><a href=""#"" class=""mnExpand"">&raquo; More</a></span>
                </p>
              </div>
            </div>    
            <div class=""wsjmn_dropdownPanel"">
              <div class=""wsjmn_dropdownContent"">
                <div class=""pmLoadingIndicator"">
                  <span>Loading&hellip;</span>
                </div>
              </div>
            </div>
          </div>
        </div>
      </li>
    
			<li id=""nav_india"" class=""linklist_item linklist_dropdown linklist_item_india"">
	 
        <div id=""wsjmn_dropdown5-0"" data-panel-service-uri=""/public/page/0_0_WG_HeaderOne_Dropdown-asia-india.html?path=false&business=false"" class=""wsjmn_dropdownTree wsjmn_ddState-collapsed"">
		<div class=""wsjmn_dropdown_container"">
		<div class=""mn_dropdownTitlebar"">
		  <p class=""mndType-more"">

					<span class=""mnText"">
					  							<a href=""http://online.wsj.com/public/page/news-india.html"" class=""mnLabel"">India</a>
					 </span>
					<span class=""mnIndicator"">
					  <a href=""#"" data-dropdownIndex=""wsjmn_dropdown5-0"" class=""mnExpand _exp"" style=""opacity:1"">&raquo; More</a>
					</span>
              </p>
		</div>
	  </div>
          <div id=""wsjmn_dropdown5-0_content"" class=""wsjmn_dropdown-expansion"">          
			<div class=""wsjmn_dropdown_container"">			
              <div class=""mn_dropdownTitlebar"">
                <p class=""mndType-more"">
                  <span class=""mnText""><a href=""http://online.wsj.com/public/page/news-india.html?mod=WSJ_topnav_india_main"" class=""mnLabel"">India</a></span>
                  <span class=""mnIndicator""><a href=""#"" class=""mnExpand"">&raquo; More</a></span>
                </p>
              </div>
            </div>    
            <div class=""wsjmn_dropdownPanel"">
              <div class=""wsjmn_dropdownContent"">
                <div class=""pmLoadingIndicator"">
                  <span>Loading&hellip;</span>
                </div>
              </div>
            </div>
          </div>
        </div>
      </li>
    
			<li id=""nav_japan"" class=""linklist_item linklist_dropdown linklist_item_japan"">
	 
        <div id=""wsjmn_dropdown6-0"" data-panel-service-uri=""/public/page/0_0_WG_HeaderOne_Dropdown-asia-japan.html?path=false&business=false"" class=""wsjmn_dropdownTree wsjmn_ddState-collapsed"">
		<div class=""wsjmn_dropdown_container"">
		<div class=""mn_dropdownTitlebar"">
		  <p class=""mndType-more"">

					<span class=""mnText"">
					  							<a href=""http://online.wsj.com/public/page/news-japan.html"" class=""mnLabel"">Japan</a>
					 </span>
					<span class=""mnIndicator"">
					  <a href=""#"" data-dropdownIndex=""wsjmn_dropdown6-0"" class=""mnExpand _exp"" style=""opacity:1"">&raquo; More</a>
					</span>
              </p>
		</div>
	  </div>
          <div id=""wsjmn_dropdown6-0_content"" class=""wsjmn_dropdown-expansion"">          
			<div class=""wsjmn_dropdown_container"">			
              <div class=""mn_dropdownTitlebar"">
                <p class=""mndType-more"">
                  <span class=""mnText""><a href=""http://online.wsj.com/public/page/news-japan.html?mod=WSJ_topnav_japan_main"" class=""mnLabel"">Japan</a></span>
                  <span class=""mnIndicator""><a href=""#"" class=""mnExpand"">&raquo; More</a></span>
                </p>
              </div>
            </div>    
            <div class=""wsjmn_dropdownPanel"">
              <div class=""wsjmn_dropdownContent"">
                <div class=""pmLoadingIndicator"">
                  <span>Loading&hellip;</span>
                </div>
              </div>
            </div>
          </div>
        </div>
      </li>
    
			<li id=""nav_se_asia"" class=""linklist_item linklist_dropdown linklist_item_se_asia"">
	 
        <div id=""wsjmn_dropdown7-0"" data-panel-service-uri=""/public/page/0_0_WG_HeaderOne_Dropdown-asia-sea.html?path=false&business=false"" class=""wsjmn_dropdownTree wsjmn_ddState-collapsed"">
		<div class=""wsjmn_dropdown_container"">
		<div class=""mn_dropdownTitlebar"">
		  <p class=""mndType-more"">

					<span class=""mnText"">
					  							<a href=""http://online.wsj.com/public/page/sea.html"" class=""mnLabel"">SE Asia</a>
					 </span>
					<span class=""mnIndicator"">
					  <a href=""#"" data-dropdownIndex=""wsjmn_dropdown7-0"" class=""mnExpand _exp"" style=""opacity:1"">&raquo; More</a>
					</span>
              </p>
		</div>
	  </div>
          <div id=""wsjmn_dropdown7-0_content"" class=""wsjmn_dropdown-expansion"">          
			<div class=""wsjmn_dropdown_container"">			
              <div class=""mn_dropdownTitlebar"">
                <p class=""mndType-more"">
                  <span class=""mnText""><a href=""http://online.wsj.com/public/page/sea.html?mod=WSJ_topnav_seasia_main"" class=""mnLabel"">SE Asia</a></span>
                  <span class=""mnIndicator""><a href=""#"" class=""mnExpand"">&raquo; More</a></span>
                </p>
              </div>
            </div>    
            <div class=""wsjmn_dropdownPanel"">
              <div class=""wsjmn_dropdownContent"">
                <div class=""pmLoadingIndicator"">
                  <span>Loading&hellip;</span>
                </div>
              </div>
            </div>
          </div>
        </div>
      </li>
    
			<li id=""nav_business"" class=""linklist_item linklist_dropdown linklist_item_business"">
	 
        <div id=""wsjmn_dropdown8-0"" data-panel-service-uri=""/public/page/0_0_WG_HeaderOne_Dropdown-asia-business-main.html?path=false&business=false"" class=""wsjmn_dropdownTree wsjmn_ddState-collapsed"">
		<div class=""wsjmn_dropdown_container"">
		<div class=""mn_dropdownTitlebar"">
		  <p class=""mndType-more"">

					<span class=""mnText"">
					  							<a href=""http://online.wsj.com/public/page/news-business-us.html"" class=""mnLabel"">Business</a>
					 </span>
					<span class=""mnIndicator"">
					  <a href=""#"" data-dropdownIndex=""wsjmn_dropdown8-0"" class=""mnExpand _exp"" style=""opacity:1"">&raquo; More</a>
					</span>
              </p>
		</div>
	  </div>
          <div id=""wsjmn_dropdown8-0_content"" class=""wsjmn_dropdown-expansion"">          
			<div class=""wsjmn_dropdown_container"">			
              <div class=""mn_dropdownTitlebar"">
                <p class=""mndType-more"">
                  <span class=""mnText""><a href=""http://online.wsj.com/public/page/news-business-us.html?mod=WSJ_topnav_business_main"" class=""mnLabel"">Business</a></span>
                  <span class=""mnIndicator""><a href=""#"" class=""mnExpand"">&raquo; More</a></span>
                </p>
              </div>
            </div>    
            <div class=""wsjmn_dropdownPanel"">
              <div class=""wsjmn_dropdownContent"">
                <div class=""pmLoadingIndicator"">
                  <span>Loading&hellip;</span>
                </div>
              </div>
            </div>
          </div>
        </div>
      </li>
    
			<li id=""nav_markets"" class=""linklist_item linklist_dropdown linklist_item_markets"">
	 
        <div id=""wsjmn_dropdown9-0"" data-panel-service-uri=""/public/page/0_0_WG_HeaderOne_Dropdown-asia-markets.html?path=false&business=false"" class=""wsjmn_dropdownTree wsjmn_ddState-collapsed"">
		<div class=""wsjmn_dropdown_container"">
		<div class=""mn_dropdownTitlebar"">
		  <p class=""mndType-more"">

					<span class=""mnText"">
					  							<a href=""http://online.wsj.com/public/page/news-financial-markets-stock.html"" class=""mnLabel"">Markets</a>
					 </span>
					<span class=""mnIndicator"">
					  <a href=""#"" data-dropdownIndex=""wsjmn_dropdown9-0"" class=""mnExpand _exp"" style=""opacity:1"">&raquo; More</a>
					</span>
              </p>
		</div>
	  </div>
          <div id=""wsjmn_dropdown9-0_content"" class=""wsjmn_dropdown-expansion"">          
			<div class=""wsjmn_dropdown_container"">			
              <div class=""mn_dropdownTitlebar"">
                <p class=""mndType-more"">
                  <span class=""mnText""><a href=""http://online.wsj.com/public/page/news-financial-markets-stock.html?mod=WSJ_topnav_markets_main"" class=""mnLabel"">Markets</a></span>
                  <span class=""mnIndicator""><a href=""#"" class=""mnExpand"">&raquo; More</a></span>
                </p>
              </div>
            </div>    
            <div class=""wsjmn_dropdownPanel"">
              <div class=""wsjmn_dropdownContent"">
                <div class=""pmLoadingIndicator"">
                  <span>Loading&hellip;</span>
                </div>
              </div>
            </div>
          </div>
        </div>
      </li>
    
			<li id=""nav_tech"" class=""linklist_item linklist_dropdown linklist_item_tech"">
	 
        <div id=""wsjmn_dropdown10-0"" data-panel-service-uri=""/public/page/0_0_WG_HeaderOne_Dropdown-asia-tech.html?path=false&business=false"" class=""wsjmn_dropdownTree wsjmn_ddState-collapsed"">
		<div class=""wsjmn_dropdown_container"">
		<div class=""mn_dropdownTitlebar"">
		  <p class=""mndType-more"">

					<span class=""mnText"">
					  							<a href=""http://online.wsj.com/public/page/news-tech-technology.html"" class=""mnLabel"">Tech</a>
					 </span>
					<span class=""mnIndicator"">
					  <a href=""#"" data-dropdownIndex=""wsjmn_dropdown10-0"" class=""mnExpand _exp"" style=""opacity:1"">&raquo; More</a>
					</span>
              </p>
		</div>
	  </div>
          <div id=""wsjmn_dropdown10-0_content"" class=""wsjmn_dropdown-expansion"">          
			<div class=""wsjmn_dropdown_container"">			
              <div class=""mn_dropdownTitlebar"">
                <p class=""mndType-more"">
                  <span class=""mnText""><a href=""http://online.wsj.com/public/page/news-tech-technology.html?mod=WSJ_topnav_tech_main"" class=""mnLabel"">Tech</a></span>
                  <span class=""mnIndicator""><a href=""#"" class=""mnExpand"">&raquo; More</a></span>
                </p>
              </div>
            </div>    
            <div class=""wsjmn_dropdownPanel"">
              <div class=""wsjmn_dropdownContent"">
                <div class=""pmLoadingIndicator"">
                  <span>Loading&hellip;</span>
                </div>
              </div>
            </div>
          </div>
        </div>
      </li>
    
			<li id=""nav_life_style"" class=""linklist_item linklist_dropdown linklist_item_life_style"">
	 
        <div id=""wsjmn_dropdown11-0"" data-panel-service-uri=""/public/page/0_0_WG_HeaderOne_Dropdown-asia-lifeandstyle.html?path=false&business=false"" class=""wsjmn_dropdownTree wsjmn_ddState-collapsed"">
		<div class=""wsjmn_dropdown_container"">
		<div class=""mn_dropdownTitlebar"">
		  <p class=""mndType-more"">

					<span class=""mnText"">
					  							<a href=""http://online.wsj.com/public/page/news-asia-lifestyle-arts-entertainment.html"" class=""mnLabel"">Life &amp; Style</a>
					 </span>
					<span class=""mnIndicator"">
					  <a href=""#"" data-dropdownIndex=""wsjmn_dropdown11-0"" class=""mnExpand _exp"" style=""opacity:1"">&raquo; More</a>
					</span>
              </p>
		</div>
	  </div>
          <div id=""wsjmn_dropdown11-0_content"" class=""wsjmn_dropdown-expansion"">          
			<div class=""wsjmn_dropdown_container"">			
              <div class=""mn_dropdownTitlebar"">
                <p class=""mndType-more"">
                  <span class=""mnText""><a href=""http://online.wsj.com/public/page/news-asia-lifestyle-arts-entertainment.html?mod=WSJ_topnav_lifestyle_main"" class=""mnLabel"">Life &amp; Style</a></span>
                  <span class=""mnIndicator""><a href=""#"" class=""mnExpand"">&raquo; More</a></span>
                </p>
              </div>
            </div>    
            <div class=""wsjmn_dropdownPanel"">
              <div class=""wsjmn_dropdownContent"">
                <div class=""pmLoadingIndicator"">
                  <span>Loading&hellip;</span>
                </div>
              </div>
            </div>
          </div>
        </div>
      </li>
    
			<li id=""nav_real_estate"" class=""linklist_item linklist_dropdown linklist_item_real_estate"">
	 
        <div id=""wsjmn_dropdown12-0"" data-panel-service-uri=""/public/page/0_0_WG_HeaderOne_Dropdown-asia-realestate.html?path=false&business=false"" class=""wsjmn_dropdownTree wsjmn_ddState-collapsed"">
		<div class=""wsjmn_dropdown_container"">
		<div class=""mn_dropdownTitlebar"">
		  <p class=""mndType-more"">

					<span class=""mnText"">
					  							<a href=""http://online.wsj.com/public/page/news-real-estate-asia.html"" class=""mnLabel"">Real Estate</a>
					 </span>
					<span class=""mnIndicator"">
					  <a href=""#"" data-dropdownIndex=""wsjmn_dropdown12-0"" class=""mnExpand _exp"" style=""opacity:1"">&raquo; More</a>
					</span>
              </p>
		</div>
	  </div>
          <div id=""wsjmn_dropdown12-0_content"" class=""wsjmn_dropdown-expansion"">          
			<div class=""wsjmn_dropdown_container"">			
              <div class=""mn_dropdownTitlebar"">
                <p class=""mndType-more"">
                  <span class=""mnText""><a href=""http://online.wsj.com/public/page/news-real-estate-asia.html?mod=WSJ_topnav_realestate_main"" class=""mnLabel"">Real Estate</a></span>
                  <span class=""mnIndicator""><a href=""#"" class=""mnExpand"">&raquo; More</a></span>
                </p>
              </div>
            </div>    
            <div class=""wsjmn_dropdownPanel"">
              <div class=""wsjmn_dropdownContent"">
                <div class=""pmLoadingIndicator"">
                  <span>Loading&hellip;</span>
                </div>
              </div>
            </div>
          </div>
        </div>
      </li>
    
			<li id=""nav_management"" class=""linklist_item linklist_dropdown linklist_item_management"">
	 
        <div id=""wsjmn_dropdown13-0"" data-panel-service-uri=""/public/page/0_0_WG_HeaderOne_Dropdown-asia-jobs.html?path=false&business=false"" class=""wsjmn_dropdownTree wsjmn_ddState-collapsed"">
		<div class=""wsjmn_dropdown_container"">
		<div class=""mn_dropdownTitlebar"">
		  <p class=""mndType-more"">

					<span class=""mnText"">
					  							<a href=""http://online.wsj.com/public/page/management.html"" class=""mnLabel"">Management</a>
					 </span>
					<span class=""mnIndicator"">
					  <a href=""#"" data-dropdownIndex=""wsjmn_dropdown13-0"" class=""mnExpand _exp"" style=""opacity:1"">&raquo; More</a>
					</span>
              </p>
		</div>
	  </div>
          <div id=""wsjmn_dropdown13-0_content"" class=""wsjmn_dropdown-expansion"">          
			<div class=""wsjmn_dropdown_container"">			
              <div class=""mn_dropdownTitlebar"">
                <p class=""mndType-more"">
                  <span class=""mnText""><a href=""http://online.wsj.com/public/page/management.html?mod=WSJ_topnav_management_main"" class=""mnLabel"">Management</a></span>
                  <span class=""mnIndicator""><a href=""#"" class=""mnExpand"">&raquo; More</a></span>
                </p>
              </div>
            </div>    
            <div class=""wsjmn_dropdownPanel"">
              <div class=""wsjmn_dropdownContent"">
                <div class=""pmLoadingIndicator"">
                  <span>Loading&hellip;</span>
                </div>
              </div>
            </div>
          </div>
        </div>
      </li>
    
			<li id=""nav_opinion"" class=""linklist_item linklist_dropdown linklist_item_opinion"">
	 
        <div id=""wsjmn_dropdown14-0"" data-panel-service-uri=""/public/page/0_0_WG_HeaderOne_Dropdown-asia-opinion.html?path=false&business=false"" class=""wsjmn_dropdownTree wsjmn_ddState-collapsed"">
		<div class=""wsjmn_dropdown_container"">
		<div class=""mn_dropdownTitlebar"">
		  <p class=""mndType-more"">

					<span class=""mnText"">
					  							<a href=""http://online.wsj.com/public/page/opinionasia.html"" class=""mnLabel"">Opinion</a>
					 </span>
					<span class=""mnIndicator"">
					  <a href=""#"" data-dropdownIndex=""wsjmn_dropdown14-0"" class=""mnExpand _exp"" style=""opacity:1"">&raquo; More</a>
					</span>
              </p>
		</div>
	  </div>
          <div id=""wsjmn_dropdown14-0_content"" class=""wsjmn_dropdown-expansion"">          
			<div class=""wsjmn_dropdown_container"">			
              <div class=""mn_dropdownTitlebar"">
                <p class=""mndType-more"">
                  <span class=""mnText""><a href=""http://online.wsj.com/public/page/opinionasia.html?mod=WSJ_topnav_opinion_main"" class=""mnLabel"">Opinion</a></span>
                  <span class=""mnIndicator""><a href=""#"" class=""mnExpand"">&raquo; More</a></span>
                </p>
              </div>
            </div>    
            <div class=""wsjmn_dropdownPanel"">
              <div class=""wsjmn_dropdownContent"">
                <div class=""pmLoadingIndicator"">
                  <span>Loading&hellip;</span>
                </div>
              </div>
            </div>
          </div>
        </div>
      </li>
  </ul>
</div><div class=""hidden"">false</div>		

<div id=""emailThisScrim"" class=""scrimWSJ_overlay hidden"">
	<div class=""scrimWSJ_wrapper"">
		<div class=""scrimWSJ_inner"">
			<div class=""scrim_email_this scrimWSJ_module loginModule"">
			  	<div class=""headerStrap"">
		            <a  href=""#"" class=""closeBtn emailScrimCloseBtn"">close</a>
		        </div>
			    <h3>Email This</h3>
				<div id=""emailScrimTopAd"" class=""scrim-sponsor-bug"">		        	
			    </div>
				<form id=""emailForm"" name=""emailForm"">
					<fieldset>
						<div class=""login_row"">
							<span id=""emailThisAddressToError"" class=""emailError hidden""></span>
							<label class=""login_id"">
								Recipient's Email Address <span class=""smallNote"">(Separate multiple address with commas)</span>
							</label>
							<input name=""email"" id=""emailThisAddressTo"" value="""" type=""text"" class=""login_id"" tabindex=""1"">
						</div>
						<div class=""login_row"">
							<span id=""emailThisAddressFromError"" class=""emailError hidden""></span>
							<label class=""login_pw"">
								Your Email Address
							</label>
							<input value="""" name=""email"" id=""emailThisAddressFrom"" class=""login_pw"" type=""text"" tabindex=""2"">
						</div>
						<div class=""login_row"">
							<label class=""login_pw"">
								Message <span>(Optional)</span>
							</label>
							<textarea id=""emailThisMsg"" class=""message"" maxlength=""500"" tabindex=""3"" ></textarea>
						</div>
						<div class=""login_row"">
							<input id=""ccMeChkBox"" type=""checkbox"" checked=""checked"" class=""login_checkbox selected"" tabindex=""4"">
							<label class=""login_checkbox"">
								Send me a copy
							</label>
						</div>	
						<span id=""recaptchaError"" class=""emailError hidden""></span>						
						<div id=""recaptcha_div"" class=""captcha_row"">
						
						</div>
						<div class=""login_row"">
							<input type=""submit"" class=""login_submit emailScrimSubmit"" value=""Send"" tabindex=""5"" id=""emailScrimSubmit"" tabindex=""4"">
							<div class=""cancelLink"">or <a href=""#"" class=""emailScrimCloseBtn"" tabindex=""6"">Cancel</a></div>
						</div>
					</fieldset>				
				 </form> 				 			
			</div>
			
			
		</div>
	</div>
</div>
<div id=""emailConfScrim"" class=""scrimWSJ_overlay hidden"">
	<div class=""scrimWSJ_wrapper"">
		<div class=""scrimWSJ_inner"">
			<div class=""scrim_thank_you scrimWSJ_module loginModule"">
				<div class=""headerStrap"">
		            <a id=""emailConfScrimCloseBtn"" href=""#"" class=""closeBtn"">close</a>
		        </div>
			    <h3>Thank You</h3>
			  	<p>Your email has been sent.</p>
			</div>
		</div>
	</div>
</div>
<div id=""emailErrorScrim"" class=""scrimWSJ_overlay hidden"">
	<div class=""scrimWSJ_wrapper"">
		<div class=""scrimWSJ_inner"">
			<div class=""scrim_thank_you scrimWSJ_module loginModule scrim_error"">
				<div class=""headerStrap"">
		            <a id=""emailErrorScrimCloseBtn"" href=""#"" class=""closeBtn"">close</a>
		        </div>
			    <h3>Error.</h3>
			  	<p>An error has occured and your email has not been sent. <br />
			  	Please <a id=""reopenEmailScrimFromError"" href=""#"">try again</a>.
			  	</p>
			</div>
		</div>
	</div>
</div>


<div class=""hidden"">
<div id=""invalidEmailAddress"" class=""hidden"">&bull; Invalid email address.</div>
<div id=""tooManyEmailAddresses"" class=""hidden"">&bull; You can't enter more than 20 emails.</div>
<div id=""invalidDelimiter"" class=""hidden"">&bull; Seperate multiple addresses with Commas.</div>
<div id=""blankEmailAddress"" class=""hidden"">&bull; Must enter an email address.</div>
<div id=""emptyRecaptchaCd"" class=""hidden"">&bull; You must enter the verification code below to send.</div>
<div id=""invalidRecaptchaCd"" class=""hidden"">&bull; Invalid entry: Please type the verification code again.</div>
</div>

<!-- sectionNewsreelState=visible, 0_0_WP_2007 -->
<div id=""newsreeliframe"" class=""newsreelC"" data-newsReelPage=""0_0_WP_2002_NewsReel_inline""></div>
   </div><div class=""contentwide""><div class=""reallywide""><div id=""newsreel_mostpopular"" class=""newsreeliframeclass""><iframe width=""989"" height=""0"" frameborder=""0"" scrolling=""no"" marginheight=""0"" marginwidth=""0"" style=""display:none;"" id=""newsreeliframe_mostpopular""></iframe>
</div><div class=""col10wide wrap padding-left-big""><div id=""printModeAd""></div>

<div class=""printSummary pfHeader col6wide"">
<ul>
<li class=""listFirst"">
<p>
Dow Jones Reprints: This copy is for your personal, non-commercial use only. To order presentation-ready copies for distribution to your colleagues, clients or customers, use the Order Reprints tool at the bottom of any article or visit
<a class=""firstLink"" href=""http://www.djreprints.com"" target=""_blank"">www.djreprints.com</a>
</p>
<span>
<a href=""http://online.wsj.com/public/resources/documents/Reprint_Samples.pdf"" target=""_blank"">See a sample reprint in PDF format.</a>
<a href=""javascript:CopyrightPopUp();"">Order a reprint of this article now</a>
</span>
</li>
<li>
<span class=""module_sponsor"">
</span>
<img alt=""The Wall Street Journal"" src=""http://s.wsj.net/img/wsj_print.gif""/>
</li>
</ul>
</div>
<div class=""articleHeadlineBox headlineType-newswire""><ul class=""cMetadata metadataType-articleStamp"">
<li class=""articleSection first""><a href=""/public/page/news-politics-campaign.html"">POLITICS</a></li>
<li class=""dateStamp""> Updated June 30, 2013, 7:30 p.m. ET</li>
</ul>
<!--           ID: SB10001424127887324251504578577842451273534 -->
<!--         TYPE: Politics and Policy -->
<!-- DISPLAY-NAME: Politics -->
<!--  PUBLICATION: The Wall Street Journal Interactive Edition -->
<!--         DATE: 2013-06-30 19:30 -->
<!--    COPYRIGHT: Dow Jones &amp; Company, Inc. -->
<!--  ORIGINAL-ID:  -->
<!-- article start -->
<!--
CODE=AUTHOR SYMBOL=Janet Hook
CODE=DJII-PERSON SYMBOL=110608361
CODE=DJII-REGION SYMBOL=namz
CODE=DJII-REGION SYMBOL=usa
CODE=DJII-SUBJECT SYMBOL=gcat
CODE=DJII-SUBJECT SYMBOL=gimm
CODE=DJII-SUBJECT SYMBOL=gpir
CODE=DJII-SUBJECT SYMBOL=gpol
CODE=DJII-SUBJECT SYMBOL=gvbod
CODE=DJII-SUBJECT SYMBOL=gvcng
CODE=DJII-SUBJECT SYMBOL=gvlwh
CODE=DJII-SUBJECT SYMBOL=gvote
CODE=DJII-SUBJECT SYMBOL=gvote1
CODE=DJN SYMBOL=N/CDJ
CODE=DJN SYMBOL=N/ELX
CODE=DJN SYMBOL=N/INT
CODE=DJN SYMBOL=N/PLT
CODE=DJN SYMBOL=R/NME
CODE=DJN SYMBOL=R/US
CODE=PERSON SYMBOL=Goodlatte, Bob
CODE=PERSON SYMBOL=Israel, Steve
CODE=PERSON SYMBOL=King, Steve
CODE=PERSON SYMBOL=McCain, John
CODE=RELAY SYMBOL=SYND
CODE=STATISTIC SYMBOL=CODES_REVIEWED
CODE=SUBJECT SYMBOL=ONEW
CODE=SUBJECT SYMBOL=OPOL

                
                    pe
                    110608361
                    pe|110608361
                    
                        
                            lastname
                            McCain
                        
                        
                            visible
                            1
                        
                        
                            seoname
                            john-mccain
                        
                        
                            relevancerange
                            medium
                        
                        
                            extractedtext
                            John McCain
                        
                        
                            title
                            Senator
                        
                        
                            source
                            FACTIVA
                        
                        
                            name
                            John McCain
                        
                        
                            relevance
                            29
                        
                        
                            topicid
                            6226
                        
                        
                            onlinesignificance
                            passing-mention
                        
                        
                            displayname
                            McCain, John
                        
                        
                            fcode
                            110608361
                        
                        
                            firstname
                            John
                        
                        
                            why
                            occur
                        
                        
                            topicname
                            John McCain
                        
                    
                
                
                    pe
                    bob_goodlatte
                    pe|bob_goodlatte
                    
                        
                            lastname
                            Goodlatte
                        
                        
                            significance
                            passing
                        
                        
                            source
                            FACTIVA
                        
                        
                            status
                            modified
                        
                        
                            name
                            Bob Goodlatte
                        
                        
                            onlinesignificance
                            prominent
                        
                        
                            displayname
                            Goodlatte, Bob
                        
                        
                            firstname
                            Bob
                        
                        
                            extractedtext
                            Bob Goodlatte
                        
                    
                
                
                    pe
                    steve_israel
                    pe|steve_israel
                    
                        
                            lastname
                            Israel
                        
                        
                            visible
                            1
                        
                        
                            status
                            modified
                        
                        
                            seoname
                            steve-israel
                        
                        
                            extractedtext
                            Steve Israel
                        
                        
                            title
                            Congressman
                        
                        
                            significance
                            passing
                        
                        
                            source
                            FACTIVA
                        
                        
                            name
                            Steve Israel
                        
                        
                            topicid
                            7063
                        
                        
                            onlinesignificance
                            passing-mention
                        
                        
                            firstname
                            Steve
                        
                        
                            displayname
                            Israel, Steve
                        
                        
                            topicname
                            Steve Israel
                        
                    
                
                
                    pe
                    steve_king
                    pe|steve_king
                    
                        
                            lastname
                            King
                        
                        
                            significance
                            passing
                        
                        
                            source
                            FACTIVA
                        
                        
                            status
                            modified
                        
                        
                            name
                            Steve King
                        
                        
                            onlinesignificance
                            passing-mention
                        
                        
                            displayname
                            King, Steve
                        
                        
                            firstname
                            Steve
                        
                        
                            extractedtext
                            Steve King
                        
                    
                
                
                    author
                    Janet Hook
                    author|Janet Hook
                    
                        
                            id
                            janet_hook
                        
                        
                            name
                            Janet Hook
                        
                        
                            topicid
                            
                        
                        
                            rank
                            1
                        
                    
                
                
                    djn
                    n_cdj
                    djn|n_cdj
                    
                        
                            source
                            FACTIVA
                        
                        
                            name
                            N/CDJ
                        
                        
                            fcode
                            N/CDJ
                        
                        
                            why
                            lineage
                        
                    
                
                
                    djn
                    n_int
                    djn|n_int
                    
                        
                            source
                            FACTIVA
                        
                        
                            name
                            N/INT
                        
                        
                            fcode
                            N/INT
                        
                        
                            why
                            lineage
                        
                    
                
                
                    djn
                    n_plt
                    djn|n_plt
                    
                        
                            source
                            FACTIVA
                        
                        
                            name
                            N/PLT
                        
                        
                            fcode
                            N/PLT
                        
                        
                            why
                            lineage
                        
                    
                
                
                    djn
                    n_elx
                    djn|n_elx
                    
                        
                            source
                            FACTIVA
                        
                        
                            name
                            N/ELX
                        
                        
                            fcode
                            N/ELX
                        
                        
                            why
                            lineage
                        
                    
                
                
                    djn
                    r_us
                    djn|r_us
                    
                        
                            source
                            FACTIVA
                        
                        
                            name
                            R/US
                        
                        
                            fcode
                            R/US
                        
                        
                            why
                            about
                        
                    
                
                
                    djn
                    r_nme
                    djn|r_nme
                    
                        
                            source
                            FACTIVA
                        
                        
                            name
                            R/NME
                        
                        
                            fcode
                            R/NME
                        
                        
                            why
                            lineage
                        
                    
                
                
                    ns
                    gvlwh
                    ns|gvlwh
                    
                        
                            source
                            FACTIVA
                        
                        
                            name
                            Lower House
                        
                        
                            fcode
                            gvlwh
                        
                        
                            why
                            about
                        
                    
                
                
                    ns
                    gimm
                    ns|gimm
                    
                        
                            source
                            FACTIVA
                        
                        
                            name
                            Asylum/Immigration
                        
                        
                            fcode
                            gimm
                        
                        
                            why
                            about
                        
                    
                
                
                    ns
                    gpol
                    ns|gpol
                    
                        
                            source
                            FACTIVA
                        
                        
                            name
                            Domestic Politics
                        
                        
                            fcode
                            gpol
                        
                        
                            why
                            about
                        
                    
                
                
                    ns
                    gvcng
                    ns|gvcng
                    
                        
                            source
                            FACTIVA
                        
                        
                            name
                            Legislative Branch
                        
                        
                            fcode
                            gvcng
                        
                        
                            why
                            about
                        
                    
                
                
                    ns
                    gvote1
                    ns|gvote1
                    
                        
                            source
                            FACTIVA
                        
                        
                            name
                            National/Presidential Elections
                        
                        
                            fcode
                            gvote1
                        
                        
                            why
                            about
                        
                    
                
                
                    ns
                    gcat
                    ns|gcat
                    
                        
                            source
                            FACTIVA
                        
                        
                            name
                            Political/General News
                        
                        
                            fcode
                            gcat
                        
                        
                            why
                            lineage
                        
                    
                
                
                    ns
                    gpir
                    ns|gpir
                    
                        
                            source
                            FACTIVA
                        
                        
                            name
                            Politics/International Relations
                        
                        
                            fcode
                            gpir
                        
                        
                            why
                            lineage
                        
                    
                
                
                    ns
                    gvbod
                    ns|gvbod
                    
                        
                            source
                            FACTIVA
                        
                        
                            name
                            Government Bodies
                        
                        
                            fcode
                            gvbod
                        
                        
                            why
                            lineage
                        
                    
                
                
                    ns
                    gvote
                    ns|gvote
                    
                        
                            source
                            FACTIVA
                        
                        
                            name
                            Elections
                        
                        
                            fcode
                            gvote
                        
                        
                            why
                            lineage
                        
                    
                
                
                    re
                    usa
                    re|usa
                    
                        
                            source
                            FACTIVA
                        
                        
                            subcat
                            cntry
                        
                        
                            name
                            United States
                        
                        
                            fcode
                            usa
                        
                        
                            why
                            about
                        
                    
                
                
                    re
                    namz
                    re|namz
                    
                        
                            source
                            FACTIVA
                        
                        
                            subcat
                            snr
                        
                        
                            name
                            North America
                        
                        
                            fcode
                            namz
                        
                        
                            why
                            lineage
                        
                    
                
                
                    relay
                    synd
                    relay|synd
                    
                        
                            name
                            SYND
                        
                        
                            value
                            SYND
                        
                    
                
                
                    statistic
                    CODES_REVIEWED
                    statistic|CODES_REVIEWED
                    
                        
                            name
                            CODES_REVIEWED
                        
                        
                            value
                            CODES_REVIEWED
                        
                    
                
                
                    subject
                    onew
                    subject|onew
                    
                        
                            description
                            01|US|US News
                        
                        
                            name
                            ONEW
                        
                        
                            value
                            ONEW
                        
                        
                            comments
                            Keyword:DJII-REGION usa,namz
                        
                    
                
                
                    subject
                    opol
                    subject|opol
                    
                        
                            status
                            modified
                        
                        
                            name
                            Politics &amp; Policy
                        
                        
                            value
                            OPOL
                        
                    
                
                
                    djn
                    N/CDJ
                    djn|N/CDJ
                    
                        
                            seoname
                            N/CDJ
                        
                    
                
                
                    djn
                    N/ELX
                    djn|N/ELX
                    
                        
                            seoname
                            N/ELX
                        
                    
                
                
                    djn
                    N/INT
                    djn|N/INT
                    
                        
                            seoname
                            N/INT
                        
                    
                
                
                    djn
                    N/PLT
                    djn|N/PLT
                    
                        
                            seoname
                            N/PLT
                        
                    
                
                
                    djn
                    R/NME
                    djn|R/NME
                    
                        
                            seoname
                            R/NME
                        
                    
                
                
                    djn
                    R/US
                    djn|R/US
                    
                        
                            seoname
                            R/US
                        
                    
                
                
                    relay
                    SYND
                    relay|SYND
                    
                
                
                    statistic
                    CODES_REVIEWED
                    statistic|CODES_REVIEWED
                    
                
                
                    subject
                    ONEW
                    subject|ONEW
                    
                
                
                    subject
                    OPOL
                    subject|OPOL
                    
                
                
                    person
                    Goodlatte, Bob
                    person|Goodlatte, Bob
                    
                        
                            name
                            Bob Goodlatte
                        
                        
                            displayname
                            Goodlatte, Bob
                        
                        
                            significance
                            PASSING-MENTION
                        
                    
                
                
                    person
                    McCain, John
                    person|McCain, John
                    
                        
                            topicid
                            6226
                        
                        
                            name
                            John McCain
                        
                        
                            displayname
                            McCain, John
                        
                        
                            significance
                            PASSING-MENTION
                        
                        
                            seoname
                            John-McCain
                        
                    
                
                
                    person
                    Israel, Steve
                    person|Israel, Steve
                    
                        
                            topicid
                            7063
                        
                        
                            name
                            Steve Israel
                        
                        
                            displayname
                            Israel, Steve
                        
                        
                            significance
                            PASSING-MENTION
                        
                        
                            seoname
                            Steve-Israel
                        
                    
                
                
                    person
                    King, Steve
                    person|King, Steve
                    
                        
                            name
                            Steve King
                        
                        
                            displayname
                            King, Steve
                        
                        
                            significance
                            PASSING-MENTION
                        
                    
                
            -->
<h1>Immigration Bill Faces Uphill Climb in House
</h1></div></div><div class=""art_tabbed_nav""><ul id =""articleTabs"" class=""tab"">
   
<li id=""articleTabs_tab_article"" class=""selected""><a href=""#articleTabs=article"" class=""article"" onclick="""">Article</a>
</li><li id=""articleTabs_tab_interactive""><a href=""#articleTabs_interactive"" class=""interactive"" onclick="""">Graphics</a>
</li><li id=""articleTabs_tab_comments""><a href=""#articleTabs_comments"" class=""comments"" onclick="""">Comments</a>
</li></ul>

<div class=""more_in"">more in <a href=""/public/page/news-politics-campaign.html"">Politics & Policy</a>
<span class=""hidden"">| <a href=""$HREFFIND$"">Find New $LINKTEXTFIND$ </a></span> &raquo;</div></div><div id=""articleTabs_panel_article"" class=""mastertextCenter""><div class=""hidden"" id=""omnitureInitCall""></div>
<div class=""padding-left-big""><div id=""article_story"" class=""col6wide colOverflowTruncated""><div id=""adEmailCircAdE"" class=""adSummary ad-freePass""  data-cb-ad-id=""adEmailCircAdE"">
</div>


<div id=""articleBodyTools"" class=""sTools sTools-t clearFix"" style=""display:none"">         
            <ul class=""stList stList-sq"">
              <li class=""stList-i stI-smaller"">
                <a id=""atbody.at.tbs"" class=""stSq stLtr-smaller"" href=""#"">smaller</a>
              </li>
              <li class=""stList-i stI-larger"">
                <a id=""atbody.at.tbl"" class=""stSq stLtr-larger"" href=""#"">Larger</a>
              </li>
            </ul>
 </div>
<div id=""article_pagination_top"" class=""articlePagination"">   </div><!--
http://www.wallstreetjournal.de
http://online.wsj.com
-->



<div id=""article_story_body"" class=""article story""><div class=""articlePage""><ul class=""socialByline"">By <li>JANET HOOK</li>
            </ul><a name=""U9019508881573XB""></a><p>For all the battles in Congress over immigration, the issue isn't likely to be a decisive one in many individual campaigns for House seats in 2014, strategists for both parties say.</p>
<a name=""U901950888157QJC""></a><p>That is likely to affect the debate in the House as it weighs the sweeping immigration bill passed by the Senate last week.</p>
<div class=""insetContent insetCol3wide embedType-image imageFormat-D""><div class=""insetTree"">
                <div id=""articleThumbnail_1"" class=""insettipUnit insetZoomTarget""><div class=""insetZoomTargetBox""><div class=""insettipBox""><div class=""insettip""><p><a>Enlarge Image</a></p></div></div><a ><img src=""http://si.wsj.net/public/resources/images/NA-BX054_HOUSEI_D_20130630155140.jpg"" vspace=""0"" hspace=""0"" border=""0""  height=""174"" width=""262""  alt=""image""/></a><div id=""articleImage_1"" class=""insetFullBracket""><div class=""insetFullBox""><div class=""insetButton""><a class=""insetClose"">Close</a></div><img src=""http://si.wsj.net/public/resources/images/NA-BX054_HOUSEI_G_20130630155140.jpg"" vspace=""0"" hspace=""0"" border=""0""  height=""369"" width=""553""  alt=""image""/></div></div></div>
                
                
                
                
                
                <cite>Associated Press</cite>
                <p class=""targetCaption"">Rep. Bob Goodlatte says the House GOP has border-security concerns.</p>
            </div></div></div><a name=""U901950888157HB""></a><p>Most Republicans represent solidly conservative districts where they are unlikely to face a serious Democratic challenge. For them, the clear political incentive is to stand firmly in opposition to the Senate bill.</p>
<a name=""U901950888157KRH""></a><p>House Democrats generally represent reliably liberal districts, many with significant Hispanic populations. For them, supporting the immigration bill, with its path to citizenship, is also a clear choice politically.</p>
<a name=""U901950888157DDH""></a><p>With few House members of either party feeling pressure to make any concessions, the politics of the House go a long way toward explaining why the prospects for the legislation are uncertain as it moves to the House from the Senate.</p>
<a name=""U901950888157MNI""></a><p>Lawmakers said Sunday it would be tough for the House to pass an immigration plan, although backers held out hope for a final deal by the end of the year. </p>
<a name=""U901950888157RRG""></a><p>Rep. Bob Goodlatte (R., Va.), chairman of the House Judiciary Committee, said on CNN Sunday that many House Republicans oppose the Senate measure because they believe it would give legal status to unauthorized immigrants ""before it solves all the problems with securing the border.""</p>
<a name=""U901950888157P2F""></a><p>Sen.  <a href=""http://topics.wsj.com/person/M/John-McCain/6226"" class=""topicLink"">John McCain</a> (R., Ariz.), one of the lawmakers who drew up the Senate bill, predicted his party would find a way to move forward on the legislation. ""I think Republicans realize the implications for the future of the Republican Party in America if we don't get this issue behind us,"" Mr. McCain said on Fox News on Sunday.</p>
<div style=""width:278px"" class=""legacyInset""><div class=""insetContent"">
                <h3 class=""first"">Immigration Law in America</h3>
                <p>Review legislative milestones and key shifts in immigration policy.</p>

                <div class=""insetContent embedType-interactive""><div class=""insetTree""><div class=""insettipUnit insetTarget""><div class=""insetZoomTargetBox""><div class=""insettipBox""><div class=""insettip""><p><a href=""#"" onclick=""dj.module.interactivePlayer.tabplay('immigration2013','');return false;"">View Graphics</a></p></div></div>
                    <a href=""#"" onclick=""dj.module.interactivePlayer.tabplay('immigration2013','');return false;""><img src=""http://s.wsj.net/public/resources/images/OB-XQ205_immigp_D_20130528171447.jpg"" vspace=""0"" hspace=""0"" border=""0""  height=""174"" width=""262""  alt=""""/></a></div>

                </div></div></div>
                <p></p>

            </div></div><a name=""U901950888157I0D""></a><p>The immigration debate will feed into broader political themes the parties advance in their midterm battle for control of the House in 2014. For Democrats, the prospect of immigration legislation dying in the House feeds into one of their central campaign themes. </p>
<a name=""U901950888157AV""></a><p>""If House Republicans cannot pass the immigration bill it is further proof of their inability to achieve solutions and reach compromise. That will fortify the message,"" said Rep.  <a href=""http://topics.wsj.com/person/I/Steve-Israel/7063"" class=""topicLink"">Steve Israel</a> (D., N.Y.), chairman of the Democratic Congressional Campaign Committee.</p>
<a name=""U901950888157S9C""></a><p>Republicans say the Senate bill, at 1,200 pages, is fresh evidence for their party's argument that Democrats are prone to rule through overstuffed legislation that expands the reach of government.</p>
<a name=""U901950888157KED""></a><p>House Speaker John Boehner (R., Ohio) referred to President Barack Obama's health-care law last week in explaining why he wants a more incremental approach. ""All you have to do is look at Obamacare—rammed through the Congress with a bare minimum of votes, signed into law by the president, and the American people are in more opposition to it today than the day it was passed. That is not how we want to deal with immigration.""</p>
<a name=""U901950888157HWF""></a><p>District by district across the country, there are few House Republicans who have a strong political incentive to support the Senate bill. </p>
<a name=""U9019508881571PC""></a><p>An analysis by The Wall Street Journal showed that only 38 of the House's 234 Republicans, or 16%, represent districts in which Latinos account for 20% or more of the population. </p>
<a name=""U901950888157FJG""></a><p>In addition, only 28 Republican-held districts are considered even remotely at risk of being contested by a Democratic challenger, according to the nonpartisan Cook Political Report.</p>
<a name=""U901950888157MVH""></a><p>""You could count on one hand the House races where this is at the top of the issue matrix,"" said a House GOP campaign aide.</p>
<a name=""U9019508881573VE""></a><p>Still, Democrats will try to make it an issue in the handful of districts where Hispanics are numerous. </p>
<a name=""U901950888157KTE""></a><p>After the House recently passed an amendment designed to block the Obama administration's executive order granting legal status to certain young immigrants who were brought to the U.S. as children, Democrats ran Spanish-language radio ads in nine districts of House Republicans. Among the targets was Rep. Gary Miller (R., Calif.), whose constituency is roughly half Hispanic.</p>
<a name=""U901950888157RKF""></a><p>""The Republican Party insists that they have changed,"" the ad said, according to the DCCC's English translation. ""But once again, House Republicans like Gary Miller have betrayed our community."" A spokesman for Mr. Miller didn't respond to a request for comment.</p>
<a name=""U901950888157V0D""></a><p>Supporters of the amendment, sponsored by Rep. Steve King (R., Iowa), said it was a response to what they considered an unconstitutional use of presidential power to selectively enforce immigration law.</p>
<cite  class=""tagline"">&mdash;Jennifer Corbett Dooren contributed to this article.</cite><p>
                <strong>Write to </strong>                Janet Hook at <a class="""" href=""mailto:janet.hook@wsj.com"">janet.hook@wsj.com</a>
            </p>
<!-- article end -->
</div>   
</div><div id=""article_pagination_bottom"" class=""articlePagination"">   </div>   <div class=""col6wide"">
        <div id=""printModeFooterAd""></div>
	<div class=""printSummary pfFooter"">
		<p>Copyright 2012 Dow Jones & Company, Inc. All Rights Reserved</p>
		<p>This copy is for your personal, non-commercial use only. Distribution and use of this material are governed by our <a href=""http://online.wsj.com/public/page/subscriber_agreement.html"">Subscriber Agreement</a> and by copyright law. For non-personal use or to order multiple copies, please contact Dow Jones Reprints at 1-800-843-0008 or visit</p>

		<p><a href=""http://www.djreprints.com"">www.djreprints.com</a></p>
	</div>
	<!-- end tminclude -->
</div>
<div id=""morein"" class=""boxlinkBox"">
          <!-- module commentsAndMorein -->
      
            <a href=""http://online.wsj.com/article/SB10001424127887324251504578577842451273534.html"" class=""boxlink boxlink-bubble boxlink-first comments"">
              <span class=""lbl"">
                Join the discussion
              </span>
              <span id = ""comment_text"" class=""txt""></span>
            </a>
          
            <a href=""/public/page/news-politics-campaign.html?mod=WSJ_article_moreinsecfooter"" class=""boxlink boxlink-or"">
              <span class=""lbl"">
                More In
              </span>

              <span class=""txt"">Politics & Policy &raquo;</span>
            </a>
          <!-- end module commentsAndMorein -->
     
</div><div class=""gmHeadlines"" style=""display:none"">
      <div class=""gmHeadlinesMarketing"">
      <span class=""gmHeadlinesTitle""></span>
      <span class=""gmHeadlinesMarketingImg""></span>
      </div>
            <div class=""headlineSummary"">
              <ul class=""newsItem"">
                <li class=""listFirst firstList subPrev tipTree tooltipType-news"">
                       <img src=""http://s.wsj.net/public/resources/images/DE-AT260_kroati_A_20130630191642.jpg"" alt=""image"" />
                        <div class=""tipTargetBox"">
                          <div style=""display: block;"" class=""tooltipBox"">
                            <div class=""tooltip"">
                               <p><small>Subscriber Content</small> <em>Read Preview</em></p>
                            </div>
                          </div>
                          <h2><a href=""http://www.wallstreetjournal.de/article/SB10001424127887323936404578578181182734710.html?mod=rss_homepage_germany"">Kroaten jubeln über EU-Beitritt</a></h2>
                        </div>
                </li>
                <li>
                          <h2><a href=""http://www.wallstreetjournal.de/article/SB10001424127887323936404578577210433511822.html?mod=rss_homepage_germany"">Apples schwierige Scheidung von Samsung</a></h2>
                </li>
                <li>
                          <h2><a href=""http://www.wallstreetjournal.de/article/SB10001424127887323419604578575243167532704.html?mod=rss_homepage_germany"">Das Ende der großen Geldschwemme</a></h2>
                </li>
        </ul>
      </div>
</div>
<div id=""outbrainVideos"">
<div class=""OUTBRAIN"" 
	data-src=""http://online.wsj.com/article/SB10001424127887324251504578577842451273534.html"" data-widget-id=""AR_5"" data-ob-template=""wallstreetjournal"" 
	data-dj-widget=""onvisible.module"" data-dj-scroll-proximity=""150"" data-dj-module=""dj.module.outbrain"" data-dj-module-init=""init"" >
</div>
</div><div id=""outbrain""><div class=""OUTBRAIN"" data-src=""http://online.wsj.com/article/SB10001424127887324251504578577842451273534.html"" data-widget-id=""AR_1"" data-ob-template=""wallstreetjournal"" data-dj-widget=""onvisible.module"" data-dj-scroll-proximity=""150"" data-dj-module=""dj.module.outbrain"" data-dj-module-init=""init""></div>
<!-- <script  type=""text/javascript"">OB_MP_feed = ""http://online.wsj.com""</script> -->


</div><div id=""bottom_keyword_based"" class=""hidden"">   </div><div id=""leaveComment""  class=""leaveComment1 community funcBox""></div>
<div id=""bottomBigAd"" class=""adSummary""  data-cb-ad-id=""bottomBigAd"">
</div>


<iframe height=""0"" width=""0"" border=""0"" frameborder='0' name=""trackerFrame""></iframe>
<div id=""emailThisScrim"" class=""scrimWSJ_overlay hidden"">
	<div class=""scrimWSJ_wrapper"">
		<div class=""scrimWSJ_inner"">
			<div class=""scrim_email_this scrimWSJ_module loginModule"">
			  	<div class=""headerStrap"">
		            <a  href=""#"" class=""closeBtn emailScrimCloseBtn"">close</a>
		        </div>
			    <h3>Email This</h3>
				<div id=""emailScrimTopAd"" class=""scrim-sponsor-bug"">		        	
			    </div>
				<form id=""emailForm"" name=""emailForm"">
					<fieldset>
						<div class=""login_row"">
							<span id=""emailThisAddressToError"" class=""emailError hidden""></span>
							<label class=""login_id"">
								Recipient's Email Address <span class=""smallNote"">(Separate multiple address with commas)</span>
							</label>
							<input name=""email"" id=""emailThisAddressTo"" value="""" type=""text"" class=""login_id"" tabindex=""1"">
						</div>
						<div class=""login_row"">
							<span id=""emailThisAddressFromError"" class=""emailError hidden""></span>
							<label class=""login_pw"">
								Your Email Address
							</label>
							<input value="""" name=""email"" id=""emailThisAddressFrom"" class=""login_pw"" type=""text"" tabindex=""2"">
						</div>
						<div class=""login_row"">
							<label class=""login_pw"">
								Message <span>(Optional)</span>
							</label>
							<textarea id=""emailThisMsg"" class=""message"" maxlength=""500"" tabindex=""3"" ></textarea>
						</div>
						<div class=""login_row"">
							<input id=""ccMeChkBox"" type=""checkbox"" checked=""checked"" class=""login_checkbox selected"" tabindex=""4"">
							<label class=""login_checkbox"">
								Send me a copy
							</label>
						</div>	
						<span id=""recaptchaError"" class=""emailError hidden""></span>						
						<div id=""recaptcha_div"" class=""captcha_row"">
						
						</div>
						<div class=""login_row"">
							<input type=""submit"" class=""login_submit emailScrimSubmit"" value=""Send"" tabindex=""5"" id=""emailScrimSubmit"" tabindex=""4"">
							<div class=""cancelLink"">or <a href=""#"" class=""emailScrimCloseBtn"" tabindex=""6"">Cancel</a></div>
						</div>
					</fieldset>				
				 </form> 				 			
			</div>
			
			
		</div>
	</div>
</div>
<div id=""emailConfScrim"" class=""scrimWSJ_overlay hidden"">
	<div class=""scrimWSJ_wrapper"">
		<div class=""scrimWSJ_inner"">
			<div class=""scrim_thank_you scrimWSJ_module loginModule"">
				<div class=""headerStrap"">
		            <a id=""emailConfScrimCloseBtn"" href=""#"" class=""closeBtn"">close</a>
		        </div>
			    <h3>Thank You</h3>
			  	<p>Your email has been sent.</p>
			</div>
		</div>
	</div>
</div>
<div id=""emailErrorScrim"" class=""scrimWSJ_overlay hidden"">
	<div class=""scrimWSJ_wrapper"">
		<div class=""scrimWSJ_inner"">
			<div class=""scrim_thank_you scrimWSJ_module loginModule scrim_error"">
				<div class=""headerStrap"">
		            <a id=""emailErrorScrimCloseBtn"" href=""#"" class=""closeBtn"">close</a>
		        </div>
			    <h3>Error.</h3>
			  	<p>An error has occured and your email has not been sent. <br />
			  	Please <a id=""reopenEmailScrimFromError"" href=""#"">try again</a>.
			  	</p>
			</div>
		</div>
	</div>
</div>


<div class=""hidden"">
<div id=""invalidEmailAddress"" class=""hidden"">&bull; Invalid email address.</div>
<div id=""tooManyEmailAddresses"" class=""hidden"">&bull; You can't enter more than 20 emails.</div>
<div id=""invalidDelimiter"" class=""hidden"">&bull; Seperate multiple addresses with Commas.</div>
<div id=""blankEmailAddress"" class=""hidden"">&bull; Must enter an email address.</div>
<div id=""emptyRecaptchaCd"" class=""hidden"">&bull; You must enter the verification code below to send.</div>
<div id=""invalidRecaptchaCd"" class=""hidden"">&bull; Invalid entry: Please type the verification code again.</div>
</div>

</div><div id=""articles_right_rail"" class=""col4wide margin-left colOverflowTruncated""><div id=""yahooLinkback"" class=""headlineSummary linkBack col4wide hidden yahooLinkback""><ul class=""newsItem""> 	
	<li><h2><a rel=""nofollow"" class=""yahoo"" target=""_blank"" href=""http://finance.yahoo.com"" title=""[Back to Yahoo! Finance]"">Back To </a></h2></li>
</ul>
</div><div id=""valorLinkback"" class=""headlineSummary linkBack col4wide hidden valorLinkback""><div class=""headlineSummary linkBack""> 
	<ul class=""newsItem""> 	
		<li style=""float:right""><h2><a style=""font-weight:bold"" rel=""nofollow"" class=""valor"" href=""http://www.valor.com.br"" title=""Voltar ao Valor"">Voltar ao </a></h2></li> 
	</ul> 
</div>
</div><div id=""MVT_Ad8BTop""><div id=""ad0_0_WA_0001A"" class=""adSummary advertisement""  data-cb-ad-id=""ad0_0_WA_0001A"">
</div>
<!--  Scripts are added to the end --></div><div id=""snippet_hp_tbnl"" class=""hidden""><div id=""ArticleRRTest_MM"" class=""MVTTEST"">	<div id=""homePageBasedThumbnailModule"" class=""headlineSummary HSBRows"">
		<h3>Available to asia.WSJ.com subscribers</h3>
			<ul class=""newsItem"">

						

						
				<li class=""large subPrev tipTree tooltipType-news listFirst"">
					<div class=""tipTargetBox"">
						<div style=""display: none;"" class=""tooltipBox"">
							<div class=""tooltip"">
								<p><small>Subscriber Content</small> <em>Read Preview</em></p>
							</div>
						</div>
						<h2 class=""tipTarget""><a href=""http://online.wsj.com/article/SB10001424127887324539404578342311961968652.html?mod=rss_most_viewed_day_asia?mod=WSJAsia_article_forsub"">Beijing, U.S. Unveil New Korean Sanctions</a></h2>
					</div>
				</li>

						

						
				<li class=""large subPrev tipTree tooltipType-news listFirst"">
					<div class=""tipTargetBox"">
						<div style=""display: none;"" class=""tooltipBox"">
							<div class=""tooltip"">
								<p><small>Subscriber Content</small> <em>Read Preview</em></p>
							</div>
						</div>
						<h2 class=""tipTarget""><a href=""http://online.wsj.com/article/SB10001424127887324539404578342771985751896.html?mod=rss_most_viewed_day_asia?mod=WSJAsia_article_forsub"">Five Stocks Handled the Heavy Lifting</a></h2>
					</div>
				</li>

						

						
      		</ul>
      		
      		<ul class=""newsItem"">
				<li class=""large subPrev tipTree tooltipType-news listFirst"">
					<div class=""tipTargetBox"">
						<div style=""display: none;"" class=""tooltipBox"">
							<div class=""tooltip"">
								<p><small>Subscriber Content</small> <em>Read Preview</em></p>
							</div>
						</div>
						<h2 class=""tipTarget""><a href=""http://online.wsj.com/article/SB10001424127887324678604578343060817853792.html?mod=rss_most_viewed_day_asia?mod=WSJAsia_article_forsub"">Samsung in Talks to Invest in Sharp</a></h2>
					</div>
				</li>

						
				<li class=""subPrev tipTree tooltipType-news listFirst"">
					<div class=""newsImage newsImage-C"">
						<a href=""http://online.wsj.com/article/SB10001424127887324178904578341911094435252.html?mod=rss_most_viewed_day_asia?mod=WSJAsia_article_forsub""><img src=""http://si.wsj.net//public/resources/images/OB-WO610_vatiki_C_20130305120159.jpg"" class=""imageFormat-C""></a>
					</div>
					<div class=""tipTargetBox"">
					   	<div style=""display: none;"" class=""tooltipBox"">
							<div class=""tooltip"">
						    	<p><small>Subscriber Content</small> <em>Read Preview</em></p>
						    </div>
						</div>
	            		<h2 class=""tipTarget midSpace""><a href=""http://online.wsj.com/article/SB10001424127887324178904578341911094435252.html?mod=rss_most_viewed_day_asia?mod=WSJAsia_article_forsub"">Michael Vatikiotis: Malaysia the Moderate Peacemaker</a></h2>
					</div>
				</li>
		</ul>
		<div id=""magic_module"" class=""promo visibility-allExceptSub""></div>
	</div>


</div></div><div id=""outbrainVideos"">
<div class=""OUTBRAIN"" 
	data-src=""http://online.wsj.com/article/SB10001424127887324251504578577842451273534.html"" data-widget-id=""AR_3"" data-ob-template=""wallstreetjournal"" 
	data-dj-widget=""onvisible.module"" data-dj-scroll-proximity=""150"" data-dj-module=""dj.module.outbrain"" data-dj-module-init=""init"" >
</div>
</div><div id=""more_info_revised"" class=""hidden"">   </div><div id=""most_popular_orignal"" class=""hidden"">   </div><div id=""more_info_hp_hdln"" class=""hidden""><div class=""headlineSummary HSBMoreIn""><h3> <a id="""" class="""" href=""http://online.wsj.com/home-page"">From the HomePage</a></h3>
<ul class=""newsItem"">
<li >
	<h2 class=""tipTarget""><a href=""/article/SB10001424127887323936404578577053539567198.html?mod=WSJAsia_article_PoliticsHeadlines"">NSA Accused of Spying on the EU
</a></h2><p>The president of the European Parliament has demanded ""full clarification"" from the U.S. after it was alleged that the National Security Agency collected information on European institutions as part of its spying activities.</p></li>
	<li class="" subPrev tipTree tooltipType-news"">
		<div class=""tipTargetBox"">
			<div class=""tooltipBox"">
		      <div class=""tooltip"">
		      <p><small>Subscriber Content</small> <em>Read Preview</em></p></div>
			</div>
		</div>
	<h2 class=""tipTarget""><a href=""/article/SB10001424127887324251504578577631456952080.html?mod=WSJAsia_article_PoliticsHeadlines"">Asean, China Seek to Ease Dispute
</a></h2><p>The Association of Southeast Asian Nations and China on Sunday appeared to make tentative progress toward smoothing relations in a broad dispute over the South China Sea, as officials agreed to work on establishing a code of conduct for the contested waters.</p></li>
	<li >
	<div class=""newsImage newsImage-A""><a href=""http://online.wsj.com/article/SB10001424127887323936404578577211094578402.html?mod=WSJAsia_article_PoliticsHeadlines""><img src=""http://si.wsj.net/public/resources/images/OB-YA481_0630eg_A_20130630100845.jpg"" vspace=""0"" hspace=""0"" border=""0"" alt=""[image]"" height=""76"" width=""76"" class=""imageFormat-A""/></a></div><h2><a href=""/article/SB10001424127887323936404578577211094578402.html?mod=WSJAsia_article_PoliticsHeadlines"">Millions Protest in Egypt
</a></h2><p>Millions of Egyptians took to the streets on Sunday for nationwide protests against President Mohammed Morsi, presenting a massive popular opposition that rivaled the size of demonstrations that toppled President Hosni Mubarak more than two years ago.</p></li>
	</ul>
	
</div></div><div id=""ArticleRRTest_MostPopular"" class=""MVTTEST""><div class=""headlineSummary trendingNow"">
<h3>
Popular Now
<a href=""#"" class=""whatsThis"" id=""whatIsIt"">What's This?</a>
<div class=""detailsBox"" id=""details"">
<a href=""#"" class=""closeButton"" id=""close"">Close<span></span></a>
<p>Content engaging our readers now, with additional prominence accorded if the story is rapidly gaining attention. Our WSJ algorithm comprises 30% page views, 20% Facebook, 20% Twitter, 20% email shares and 10% comments.</p>
</div>
</h3>
<div>
<ul class=""newsItem"">
<li class=""listFirst "">
<span>1</span>
<a href=""http://online.wsj.com/article/SB10001424127887323936404578577211094578402.html?mod=trending_now_1"">
<img src=""http://si.wsj.net/public/resources/images/OB-YA481_0630eg_C_20130630100845.jpg"" class=""imageFormat-C"">
</a>
<h2><a href=""http://online.wsj.com/article/SB10001424127887323936404578577211094578402.html?mod=trending_now_1"">Millions Protest in Egypt</a></h2>
<ul class=""shareLinks"">
<li class=""first twitter"">
<a href=""#"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887323936404578577211094578402.html"" data-headline=""Millions Protest in Egypt"" data-via=""WSJ"" title=""Share on Twitter"" target=""_blank"">Twitter</a>
</li>
<li class=""facebook"">
<a href=""#"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887323936404578577211094578402.html"" data-headline=""Millions Protest in Egypt"" title=""Share on Facebook"" target=""_blank"">Facebook</a>
</li>
<li class=""email"">
<a href=""#"" id=""mostTrending.emailthis"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887323936404578577211094578402.html"" data-headline=""Millions Protest in Egypt"" title=""Email"" data-article-id=""SB10001424127887323936404578577211094578402"" target=""_blank"">Email</a>
</li>
<li class=""comments"">
<a href=""http://online.wsj.com/article/SB10001424127887323936404578577211094578402.html#articleTabs%3Dcomments"" title=""Article Comments"" target=""_blank"">Comments</a>
</li>
</ul>
</li>
<li class="""">
<span>2</span>
<a href=""http://online.wsj.com/article/SB10001424127887323873904578571472700348086.html?mod=trending_now_2"">
<img src=""http://si.wsj.net/public/resources/images/RV-AK933_REVOLU_C_20130628191048.jpg"" class=""imageFormat-C"">
</a>
<h2><a href=""http://online.wsj.com/article/SB10001424127887323873904578571472700348086.html?mod=trending_now_2"">The Middle-Class Revolution</a></h2>
<ul class=""shareLinks"">
<li class=""first twitter"">
<a href=""#"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887323873904578571472700348086.html"" data-headline=""The Middle-Class Revolution"" data-via=""WSJ"" title=""Share on Twitter"" target=""_blank"">Twitter</a>
</li>
<li class=""facebook"">
<a href=""#"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887323873904578571472700348086.html"" data-headline=""The Middle-Class Revolution"" title=""Share on Facebook"" target=""_blank"">Facebook</a>
</li>
<li class=""email"">
<a href=""#"" id=""mostTrending.emailthis"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887323873904578571472700348086.html"" data-headline=""The Middle-Class Revolution"" title=""Email"" data-article-id=""SB10001424127887323873904578571472700348086"" target=""_blank"">Email</a>
</li>
<li class=""comments"">
<a href=""http://online.wsj.com/article/SB10001424127887323873904578571472700348086.html#articleTabs%3Dcomments"" title=""Article Comments"" target=""_blank"">Comments</a>
</li>
</ul>
</li>
<li class="""">
<span>3</span>
<a href=""http://online.wsj.com/article/SB10001424127887323936404578577053539567198.html?mod=trending_now_3"">
</a>
<h2><a href=""http://online.wsj.com/article/SB10001424127887323936404578577053539567198.html?mod=trending_now_3"">NSA Accused of Spying on the EU</a></h2>
<ul class=""shareLinks"">
<li class=""first twitter"">
<a href=""#"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887323936404578577053539567198.html"" data-headline=""NSA Accused of Spying on the EU"" data-via=""WSJ"" title=""Share on Twitter"" target=""_blank"">Twitter</a>
</li>
<li class=""facebook"">
<a href=""#"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887323936404578577053539567198.html"" data-headline=""NSA Accused of Spying on the EU"" title=""Share on Facebook"" target=""_blank"">Facebook</a>
</li>
<li class=""email"">
<a href=""#"" id=""mostTrending.emailthis"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887323936404578577053539567198.html"" data-headline=""NSA Accused of Spying on the EU"" title=""Email"" data-article-id=""SB10001424127887323936404578577053539567198"" target=""_blank"">Email</a>
</li>
<li class=""comments"">
<a href=""http://online.wsj.com/article/SB10001424127887323936404578577053539567198.html#articleTabs%3Dcomments"" title=""Article Comments"" target=""_blank"">Comments</a>
</li>
</ul>
</li>
<li class="""">
<span>4</span>
<a href=""http://online.wsj.com/article/SB10001424127887324682204578513882349940500.html?mod=trending_now_4"">
<img src=""http://si.wsj.net/public/resources/images/OB-YA414_0628ip_C_20130628190447.jpg"" class=""imageFormat-C"">
</a>
<h2><a href=""http://online.wsj.com/article/SB10001424127887324682204578513882349940500.html?mod=trending_now_4"">Apple Works to Divorce Samsung</a></h2>
<ul class=""shareLinks"">
<li class=""first twitter"">
<a href=""#"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887324682204578513882349940500.html"" data-headline=""Apple Works to Divorce Samsung"" data-via=""WSJ"" title=""Share on Twitter"" target=""_blank"">Twitter</a>
</li>
<li class=""facebook"">
<a href=""#"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887324682204578513882349940500.html"" data-headline=""Apple Works to Divorce Samsung"" title=""Share on Facebook"" target=""_blank"">Facebook</a>
</li>
<li class=""email"">
<a href=""#"" id=""mostTrending.emailthis"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887324682204578513882349940500.html"" data-headline=""Apple Works to Divorce Samsung"" title=""Email"" data-article-id=""SB10001424127887324682204578513882349940500"" target=""_blank"">Email</a>
</li>
<li class=""comments"">
<a href=""http://online.wsj.com/article/SB10001424127887324682204578513882349940500.html#articleTabs%3Dcomments"" title=""Article Comments"" target=""_blank"">Comments</a>
</li>
</ul>
</li>
<li class="""">
<span>5</span>
<a href=""http://online.wsj.com/article/SB10001424127887323469804578523611076250442.html?mod=trending_now_5"">
<img src=""http://si.wsj.net/public/resources/images/OB-XV530_mag071_C_20130613131742.jpg"" class=""imageFormat-C"">
</a>
<h2><a href=""http://online.wsj.com/article/SB10001424127887323469804578523611076250442.html?mod=trending_now_5"">The World According to Woody Allen</a></h2>
<ul class=""shareLinks"">
<li class=""first twitter"">
<a href=""#"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887323469804578523611076250442.html"" data-headline=""The World According to Woody Allen"" data-via=""WSJ"" title=""Share on Twitter"" target=""_blank"">Twitter</a>
</li>
<li class=""facebook"">
<a href=""#"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887323469804578523611076250442.html"" data-headline=""The World According to Woody Allen"" title=""Share on Facebook"" target=""_blank"">Facebook</a>
</li>
<li class=""email"">
<a href=""#"" id=""mostTrending.emailthis"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887323469804578523611076250442.html"" data-headline=""The World According to Woody Allen"" title=""Email"" data-article-id=""SB10001424127887323469804578523611076250442"" target=""_blank"">Email</a>
</li>
<li class=""comments"">
<a href=""http://online.wsj.com/article/SB10001424127887323469804578523611076250442.html#articleTabs%3Dcomments"" title=""Article Comments"" target=""_blank"">Comments</a>
</li>
</ul>
<p class=""showTrigger showLess"" id=""slideTrigger""><a href=""#"">Show 5 More</a></p>
</li>
</ul>
</div>
<div class=""showLess"">
<ul class=""newsItem"" style=""display:none;"">
<li class="""">
<span>6</span>
<a href=""http://online.wsj.com/article/SB10001424127887323683504578565482315023780.html?mod=trending_now_6"">
<img src=""http://si.wsj.net/public/resources/images/OD-AX746_VACATI_C_20130627160455.jpg"" class=""imageFormat-C"">
</a>
<h2><a href=""http://online.wsj.com/article/SB10001424127887323683504578565482315023780.html?mod=trending_now_6"">Return of No-Stigma Extended Vacation</a></h2>
<ul class=""shareLinks"">
<li class=""first twitter"">
<a href=""#"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887323683504578565482315023780.html"" data-headline=""Return of No-Stigma Extended Vacation"" data-via=""WSJ"" title=""Share on Twitter"" target=""_blank"">Twitter</a>
</li>
<li class=""facebook"">
<a href=""#"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887323683504578565482315023780.html"" data-headline=""Return of No-Stigma Extended Vacation"" title=""Share on Facebook"" target=""_blank"">Facebook</a>
</li>
<li class=""email"">
<a href=""#"" id=""mostTrending.emailthis"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887323683504578565482315023780.html"" data-headline=""Return of No-Stigma Extended Vacation"" title=""Email"" data-article-id=""SB10001424127887323683504578565482315023780"" target=""_blank"">Email</a>
</li>
<li class=""comments"">
<a href=""http://online.wsj.com/article/SB10001424127887323683504578565482315023780.html#articleTabs%3Dcomments"" title=""Article Comments"" target=""_blank"">Comments</a>
</li>
</ul>
</li>
<li class="""">
<span>7</span>
<a href=""http://online.wsj.com/article/SB10001424127887323873904578573443195131124.html?mod=trending_now_7"">
<img src=""http://si.wsj.net/public/resources/images/OB-YA413_3obama_C_20130628185939.jpg"" class=""imageFormat-C"">
</a>
<h2><a href=""http://online.wsj.com/article/SB10001424127887323873904578573443195131124.html?mod=trending_now_7"">Opinion: The President and the 'Hacker'</a></h2>
<ul class=""shareLinks"">
<li class=""first twitter"">
<a href=""#"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887323873904578573443195131124.html"" data-headline=""Opinion: The President and the 'Hacker'"" data-via=""WSJ"" title=""Share on Twitter"" target=""_blank"">Twitter</a>
</li>
<li class=""facebook"">
<a href=""#"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887323873904578573443195131124.html"" data-headline=""Opinion: The President and the 'Hacker'"" title=""Share on Facebook"" target=""_blank"">Facebook</a>
</li>
<li class=""email"">
<a href=""#"" id=""mostTrending.emailthis"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887323873904578573443195131124.html"" data-headline=""Opinion: The President and the 'Hacker'"" title=""Email"" data-article-id=""SB10001424127887323873904578573443195131124"" target=""_blank"">Email</a>
</li>
<li class=""comments"">
<a href=""http://online.wsj.com/article/SB10001424127887323873904578573443195131124.html#articleTabs%3Dcomments"" title=""Article Comments"" target=""_blank"">Comments</a>
</li>
</ul>
</li>
<li class="""">
<span>8</span>
<a href=""http://online.wsj.com/article/SB10001424127887323689204578573980539126610.html?mod=trending_now_8"">
</a>
<h2><a href=""http://online.wsj.com/article/SB10001424127887323689204578573980539126610.html?mod=trending_now_8"">Markets Brace for Post-Fed World</a></h2>
<ul class=""shareLinks"">
<li class=""first twitter"">
<a href=""#"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887323689204578573980539126610.html"" data-headline=""Markets Brace for Post-Fed World"" data-via=""WSJ"" title=""Share on Twitter"" target=""_blank"">Twitter</a>
</li>
<li class=""facebook"">
<a href=""#"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887323689204578573980539126610.html"" data-headline=""Markets Brace for Post-Fed World"" title=""Share on Facebook"" target=""_blank"">Facebook</a>
</li>
<li class=""email"">
<a href=""#"" id=""mostTrending.emailthis"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887323689204578573980539126610.html"" data-headline=""Markets Brace for Post-Fed World"" title=""Email"" data-article-id=""SB10001424127887323689204578573980539126610"" target=""_blank"">Email</a>
</li>
<li class=""comments"">
<a href=""http://online.wsj.com/article/SB10001424127887323689204578573980539126610.html#articleTabs%3Dcomments"" title=""Article Comments"" target=""_blank"">Comments</a>
</li>
</ul>
</li>
<li class="""">
<span>9</span>
<a href=""http://online.wsj.com/article/SB10001424127887323419604578573834225336270.html?mod=trending_now_9"">
<img src=""http://si.wsj.net/public/resources/images/OB-YA377_0629re_C_20130628160555.jpg"" class=""imageFormat-C"">
</a>
<h2><a href=""http://online.wsj.com/article/SB10001424127887323419604578573834225336270.html?mod=trending_now_9"">Why Gezi Park Isn't Resonating in the Rest of Turkey</a></h2>
<ul class=""shareLinks"">
<li class=""first twitter"">
<a href=""#"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887323419604578573834225336270.html"" data-headline=""Why Gezi Park Isn't Resonating in the Rest of Turkey"" data-via=""WSJ"" title=""Share on Twitter"" target=""_blank"">Twitter</a>
</li>
<li class=""facebook"">
<a href=""#"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887323419604578573834225336270.html"" data-headline=""Why Gezi Park Isn't Resonating in the Rest of Turkey"" title=""Share on Facebook"" target=""_blank"">Facebook</a>
</li>
<li class=""email"">
<a href=""#"" id=""mostTrending.emailthis"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887323419604578573834225336270.html"" data-headline=""Why Gezi Park Isn't Resonating in the Rest of Turkey"" title=""Email"" data-article-id=""SB10001424127887323419604578573834225336270"" target=""_blank"">Email</a>
</li>
<li class=""comments"">
<a href=""http://online.wsj.com/article/SB10001424127887323419604578573834225336270.html#articleTabs%3Dcomments"" title=""Article Comments"" target=""_blank"">Comments</a>
</li>
</ul>
</li>
<li class="""">
<span>10</span>
<a href=""http://online.wsj.com/article/SB10001424127887323873904578573382649536100.html?mod=trending_now_10"">
<img src=""http://si.wsj.net/public/resources/images/OB-YA396_epstei_C_20130628165511.jpg"" class=""imageFormat-C"">
</a>
<h2><a href=""http://online.wsj.com/article/SB10001424127887323873904578573382649536100.html?mod=trending_now_10"">Opinion: Edward Epstein: Who Helped Snowden Steal State&hellip;</a></h2>
<ul class=""shareLinks"">
<li class=""first twitter"">
<a href=""#"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887323873904578573382649536100.html"" data-headline=""Opinion: Edward Epstein: Who Helped Snowden Steal State&hellip;"" data-via=""WSJ"" title=""Share on Twitter"" target=""_blank"">Twitter</a>
</li>
<li class=""facebook"">
<a href=""#"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887323873904578573382649536100.html"" data-headline=""Opinion: Edward Epstein: Who Helped Snowden Steal State&hellip;"" title=""Share on Facebook"" target=""_blank"">Facebook</a>
</li>
<li class=""email"">
<a href=""#"" id=""mostTrending.emailthis"" data-article-is-free=""true"" data-long-url=""http://online.wsj.com/article/SB10001424127887323873904578573382649536100.html"" data-headline=""Opinion: Edward Epstein: Who Helped Snowden Steal State&hellip;"" title=""Email"" data-article-id=""SB10001424127887323873904578573382649536100"" target=""_blank"">Email</a>
</li>
<li class=""comments"">
<a href=""http://online.wsj.com/article/SB10001424127887323873904578573382649536100.html#articleTabs%3Dcomments"" title=""Article Comments"" target=""_blank"">Comments</a>
</li>
</ul>
<p class=""showTrigger showMore"" id=""hideTrigger""><a href=""#"">Show Less</a>
</li>
</ul>
</div>
</div>
</div><div xmlns:content=""http://purl.org/rss/1.0/modules/content/"" class=""headlineSummary highlights polWashWire"">
<div class=""superDeco-special superDeco-polWashWire"">
<h3>
<a href=""http://blogs.wsj.com/washwire/"">Washington Wire</a>
</h3>
<span></span>
<p>Real-time Washington News and Insight</p>
</div>
<ul class=""newsItem"">
<li class=""listFirst"">
<a href=""http://blogs.wsj.com/washwire/2013/06/30/assange-more-revelations-coming/?mod=WSJBlog&mod=WSJ_Politics_Blog""><img border=""0"" vspace=""0"" hspace=""0"" src=""http://s.wsj.net/public/resources/images/DE-AS539_assang_A_20130617105030.jpg"" height=""76"" width=""76"" class=""imageFormat-A""></a>
<h2>
<a href=""http://blogs.wsj.com/washwire/2013/06/30/assange-more-revelations-coming/?mod=WSJBlog&mod=WSJ_Politics_Blog"">Assange: More Revelations Coming</a>
</h2>
<p>WikiLeaks leader<strong>Julian Assange</strong>said Sunday that revelations regarding U.S. surveillance programs would continue, regardless what befalls<strong>Edward Snowden</strong>, the former National Security Agency contractor who says he disclosed information about telephone and Internet monitoring to the news media.

&#8220;Look, there is no stopping the publishing process at this stage,&#8221; Mr. Assange, speaking from the Ecuadorean Embassy in London, said on the ABC News program &#8220;This Week.&#8221; &#8220;Great care has been taken to make sure that Mr. Snowden can't be pressured by any state to stop the publication process.&#8221;</p>
</li>
<li>
<h2>
<a href=""http://blogs.wsj.com/washwire/2013/06/30/tough-path-seen-for-immigration-bill-in-house/?mod=WSJBlog&mod=WSJ_Politics_Blog"">Tough Path Seen for Immigration Bill in House</a>
</h2>
</li>
<li>
<h2>
<a href=""http://blogs.wsj.com/washwire/2013/06/29/sunday-talk-preview-assange-nsa-gay-marriage/?mod=WSJBlog&mod=WSJ_Politics_Blog"">Sunday Talk Preview: Assange, NSA, Gay Marriage</a>
</h2>
</li>
<li>
<h2>
<a class=""listLast"" href=""http://blogs.wsj.com/washwire/?mod=WSJ_Politics_Blog"">See All</a>
</h2>
<h2>
<a target=""_blank"" class=""tools"" href=""http://blogs.wsj.com/washwire/feed?mod=WSJ_Politics_Blog"">RSS Feed</a>
</h2>
</li>
</ul>
</div>
<div id=""ad0_0_WA_0001G"" class=""adSummary advertisement""  data-cb-ad-id=""ad0_0_WA_0001G"">
</div>
<!--  Scripts are added to the end -->   <div id=""outbrainVideos"">
<div class=""OUTBRAIN"" 
	data-src=""http://online.wsj.com/article/SB10001424127887324251504578577842451273534.html"" data-widget-id=""AR_4"" data-ob-template=""wallstreetjournal"" 
	data-dj-widget=""onvisible.module"" data-dj-scroll-proximity=""150"" data-dj-module=""dj.module.outbrain"" data-dj-module-init=""init"" >
</div>
</div></div><div class=""col10wide colOverflowTruncated""><div id=""carouselHighlightsLeft"" class=""headlineSummary carousel editorPicksWide testClassNt"">
<h3>Editors' Picks</h3>
<ul class=""newsItem"">

	
 <!-- in some cases we get multiple categories -->
		<li class=""firstList"">
	
	
	<!-- check just to show the images in other env -->


		<a href=""http://online.wsj.com/article/SB10001424127887323873904578571472700348086.html?mod=WSJ_article_EditorsPicks"">
			<img width=""167"" vspace=""0"" hspace=""0"" height=""94"" border=""0"" class=""imageFormat-C"" src=""http://s.wsj.net/public/resources/images/RV-AK933_REVOLU_C_20130628191048.jpg"">
		</a>
		

		<h2><a class="""" href=""http://online.wsj.com/article/SB10001424127887323873904578571472700348086.html?mod=WSJ_article_EditorsPicks"">The Middle-Class Revolution</a></h2>
	</li>

	
 <!-- in some cases we get multiple categories -->
		<li class="""">
	
	
	<!-- check just to show the images in other env -->


		<a href=""http://online.wsj.com/article/SB10001424127887323683504578565482315023780.html?mod=WSJ_article_EditorsPicks"">
			<img width=""167"" vspace=""0"" hspace=""0"" height=""94"" border=""0"" class=""imageFormat-C"" src=""http://s.wsj.net/public/resources/images/OD-AX746_VACATI_C_20130627160455.jpg"">
		</a>
		

		<h2><a class="""" href=""http://online.wsj.com/article/SB10001424127887323683504578565482315023780.html?mod=WSJ_article_EditorsPicks"">Return of No-Stigma Extended Vacation</a></h2>
	</li>

	
 <!-- in some cases we get multiple categories -->
		<li class="" subPrev tipTree tooltipType-news"">
	
	
	<!-- check just to show the images in other env -->


		<a href=""http://online.wsj.com/article/SB10001424127887323689204578573761448937042.html?mod=WSJ_article_EditorsPicks"">
			<img width=""167"" vspace=""0"" hspace=""0"" height=""94"" border=""0"" class=""imageFormat-C"" src=""http://s.wsj.net/public/resources/images/BF-AF274_KCBT_C_20130628184606.jpg"">
		</a>
		

		<div class=""tipTargetBox"">
			<div class=""tooltipBox"" style=""display: none; "">
				<div class=""tooltip"">
					<p><small>Subscriber Content</small>
					<em>Read Preview</em></p>
				</div>
			</div>								
			<h2 class=""tipTarget""><a class="""" href=""http://online.wsj.com/article/SB10001424127887323689204578573761448937042.html?mod=WSJ_article_EditorsPicks"">Pits Go Dark in Kansas City as Storied Wheat Exchange Closes</a></h2>
		</div>
	</li>

	
 <!-- in some cases we get multiple categories -->
		<li class="""">
	
	
	<!-- check just to show the images in other env -->


		<a href=""http://online.wsj.com/article/SB10001424127887323393804578559431838390150.html?mod=WSJ_article_EditorsPicks"">
			<img width=""167"" vspace=""0"" hspace=""0"" height=""94"" border=""0"" class=""imageFormat-C"" src=""http://s.wsj.net/public/resources/images/OD-AX694_USA_TA_C_20130625170903.jpg"">
		</a>
		

		<h2><a class="""" href=""http://online.wsj.com/article/SB10001424127887323393804578559431838390150.html?mod=WSJ_article_EditorsPicks"">What Is the Taste of America?</a></h2>
	</li>

	
 <!-- in some cases we get multiple categories -->
		<li class="" subPrev tipTree tooltipType-news"">
	
	
	<!-- check just to show the images in other env -->


		<a href=""http://online.wsj.com/article/SB10001424127887323683504578565892955743404.html?mod=WSJ_article_EditorsPicks"">
			<img width=""167"" vspace=""0"" hspace=""0"" height=""94"" border=""0"" class=""imageFormat-C"" src=""http://s.wsj.net/public/resources/images/RV-AK931_WKCONF_C_20130628151712.jpg"">
		</a>
		

		<div class=""tipTargetBox"">
			<div class=""tooltipBox"" style=""display: none; "">
				<div class=""tooltip"">
					<p><small>Subscriber Content</small>
					<em>Read Preview</em></p>
				</div>
			</div>								
			<h2 class=""tipTarget""><a class="""" href=""http://online.wsj.com/article/SB10001424127887323683504578565892955743404.html?mod=WSJ_article_EditorsPicks"">Weekend Confidential: Olympia Snowe</a></h2>
		</div>
	</li>
</ul>

</div></div></div></div><div id=""articleTabs_panel_interactive"" class=""masterinteractiveCenter hidden""><div class=""padding-left-big""><div class=""article story"" id=""articleTabInteractive""></div>
   <div id=""ad0_0_WA_0001L_interactive"" class=""adSummary ad_728""  data-cb-ad-id=""ad0_0_WA_0001L_interactive"">
</div>
<!--  Scripts are added to the end --></div></div><div id=""articleTabs_panel_comments"" class=""mastertextCenter hidden""><div class=""padding-left-big""><div class=""col6wide colOverflowTruncated""><div id=""discussionThreadBox""  class=""$STYLE$""></div>
</div><div class=""col4wide margin-left colOverflowTruncated""><div id=""ad0_0_WA_0001A25597"" class=""adSummary articleAd""  data-cb-ad-id=""ad0_0_WA_0001A25597"">
</div>
<!--  Scripts are added to the end --><div id=""videoModule"" class=""headlineSummary sidebarlist video"">
<h3>
<a class=""more"" href=""/video-center/politics-campaign-news.html"">Video</a>
</h3>
<ul class=""nav-inline arrows hidden"">
<li class=""prev"">
<a href=""#prev"">
<span>previous</span>
</a>
</li>
<li class=""pagination"">
<span>&nbsp;</span>
</li>
<li class=""next enabledNext"">
<a href=""#next"">
<span>next</span>
</a>
</li>
</ul>
<ul class=""newsItem"">
<li class=""firstList"">
<a href=""http://live.wsj.com/video/pentagon-mulls-delay-in-f-35-production-and-more/0142B62D-EA45-4843-BFC9-0B8D3F50ACBA.html?mod=WSJ_Article_Videocarousel_1"" style=""background-image: url(http://m.wsj.net/video/20130628/062813wn20/062813wn20_115x65.jpg);"" class=""preview"">
<span>&nbsp;</span>
</a>
<h2>
<a href=""http://live.wsj.com/video/pentagon-mulls-delay-in-f-35-production-and-more/0142B62D-EA45-4843-BFC9-0B8D3F50ACBA.html?mod=WSJ_Article_Videocarousel_1"">Pentagon Mulls Delay in F-35 Production, and More</a>
</h2>
<small>1:40</small>
</li>
<li>
<a href=""http://live.wsj.com/video/seib--wessel-closer-look-at-gay-marriage-ruling/F86AB7AF-F113-46F3-BBB9-9639D8B3486E.html?mod=WSJ_Article_Videocarousel_2"" style=""background-image: url(http://m.wsj.net/video/20130628/062813seibwesselmip1/062813seibwesselmip1_115x65.jpg);"" class=""preview"">
<span>&nbsp;</span>
</a>
<h2>
<a href=""http://live.wsj.com/video/seib--wessel-closer-look-at-gay-marriage-ruling/F86AB7AF-F113-46F3-BBB9-9639D8B3486E.html?mod=WSJ_Article_Videocarousel_2"">Seib & Wessel: Closer Look at Gay-Marriage Ruling</a>
</h2>
<small>4:15</small>
</li>
<li>
<a href=""http://live.wsj.com/video/seib--wessel-why-the-fed-rattled-markets/FC74043D-A3E3-4FDE-ABE8-1030050CAC70.html?mod=WSJ_Article_Videocarousel_3"" style=""background-image: url(http://m.wsj.net/video/20130628/062813seibwesselmip2/062813seibwesselmip2_115x65.jpg);"" class=""preview"">
<span>&nbsp;</span>
</a>
<h2>
<a href=""http://live.wsj.com/video/seib--wessel-why-the-fed-rattled-markets/FC74043D-A3E3-4FDE-ABE8-1030050CAC70.html?mod=WSJ_Article_Videocarousel_3"">Seib & Wessel: Why the Fed Rattled Markets</a>
</h2>
<small>3:43</small>
</li>
</ul>
</div>
<div id=""mostRecommendations""><div id=""leaderboard"" class=""headlineSummary mostPopular commentLeaderboard"">
  <h3>Most Recommended</h3>
  <ul class=""tabBar"">
    <li class=""tab first selectedTab""><span class=""unLinked"">Comments</span><a class=""hidden"" href=""javascript://"" onclick=""dj.community.communityintegration.ToggleLeaderboard(1)"">Comments</a></li>
    <li class=""tab""><span class=""unLinked hidden"">Commenters</span><a href=""javascript://"" onclick=""dj.community.communityintegration.ToggleLeaderboard(2)"">Commenters</a></li>
  </ul>
  <ul class=""listItems"">
    <li class=""listFirst"">
      <span>1.</span>
      <h2><a href=""http://online.wsj.com/article/SB10001424127887324577904578557274272099196.html?mod=WSJ_comments_mostrecommended&mg=cmy-wsj&url=http://online.wsj.com/community/integration/leaderboard.html?mod=WSJ_comments_mostrecommended#articleTabs=comments&commentId=5983357"">&ldquo;The IRS scandal was directed by...;&rdquo;</a></h2>
      <div class=""leaderboardData"">
          <cite>- Jonathan Murray</cite>
          <small class=""recommendations"">317 Recommendations</small>
      </div>
    </li>
    <li >
      <span>2.</span>
      <h2><a href=""http://online.wsj.com/article/SB10001424127887323683504578567533647032380.html?mod=WSJ_comments_mostrecommended&mg=cmy-wsj&url=http://online.wsj.com/community/integration/leaderboard.html?mod=WSJ_comments_mostrecommended#articleTabs=comments&commentId=5992305"">&ldquo;It's just one more way to ship o...;&rdquo;</a></h2>
      <div class=""leaderboardData"">
          <cite>- Chip Bell</cite>
          <small class=""recommendations"">225 Recommendations</small>
      </div>
    </li>
    <li >
      <span>3.</span>
      <h2><a href=""http://online.wsj.com/article/SB10001424127887323683504578567533647032380.html?mod=WSJ_comments_mostrecommended&mg=cmy-wsj&url=http://online.wsj.com/community/integration/leaderboard.html?mod=WSJ_comments_mostrecommended#articleTabs=comments&commentId=5992380"">&ldquo;How does CO2 lead to a &quot;dir...;&rdquo;</a></h2>
      <div class=""leaderboardData"">
          <cite>- Eric Nelson</cite>
          <small class=""recommendations"">195 Recommendations</small>
      </div>
    </li>
    <li >
      <span>4.</span>
      <h2><a href=""http://online.wsj.com/article/SB10001424127887323683504578567533647032380.html?mod=WSJ_comments_mostrecommended&mg=cmy-wsj&url=http://online.wsj.com/community/integration/leaderboard.html?mod=WSJ_comments_mostrecommended#articleTabs=comments&commentId=5992370"">&ldquo;He's implementing the progressiv...;&rdquo;</a></h2>
      <div class=""leaderboardData"">
          <cite>- Eric Nelson</cite>
          <small class=""recommendations"">143 Recommendations</small>
      </div>
    </li>
    <li >
      <span>5.</span>
      <h2><a href=""http://online.wsj.com/article/SB10001424127887323469804578521363840962032.html?mod=WSJ_comments_mostrecommended&mg=cmy-wsj&url=http://online.wsj.com/community/integration/leaderboard.html?mod=WSJ_comments_mostrecommended#articleTabs=comments&commentId=5989418"">&ldquo;In a sane world, it would have...;&rdquo;</a></h2>
      <div class=""leaderboardData"">
          <cite>- Mike Wazowski</cite>
          <small class=""recommendations"">133 Recommendations</small>
      </div>
    </li>
  </ul>
  <ul class=""listItems commenters hidden"">
    <li class=""listFirst commenter"">
      <div class=""commenter-image-outer"">
		<a class=""commenter-pic"" href=""http://online.wsj.com/community/f96dda7f-cab3-45da-a488-1521f4e6c2ae?mod=WSJ_comments_mostrecommended&mg=cmy-wsj&url=http%3a%2f%2fonline.wsj.com%2fcommunity%2fintegration%2fleaderboard.html%3fmod%3dWSJ_comments_mostrecommended""><img src=""http://cs.wsj.net/community/content/images/misc/members/defaultuser.50x50.png"" alt=""""/></a>
	  </div>
	  <div class=""commenter-name-outer"">
	    <div class=""commenter-name-middle"">
		  <a class=""commenter-name"" href=""http://online.wsj.com/community/f96dda7f-cab3-45da-a488-1521f4e6c2ae?mod=WSJ_comments_mostrecommended&mg=cmy-wsj&url=http%3a%2f%2fonline.wsj.com%2fcommunity%2fintegration%2fleaderboard.html%3fmod%3dWSJ_comments_mostrecommended"">XAVIER L SIMON</a>
		</div>
	  </div>
	  <div class=""recommendations-outer"">
	    <div class=""recommendations-middle"">
          <small class=""recommendations"">1319 Recommendations</small>
		</div>
	  </div>
    </li>
    <li class="" commenter"">
      <div class=""commenter-image-outer"">
		<a class=""commenter-pic"" href=""http://online.wsj.com/community/aa77534e-4600-4382-acab-8df89d5545b9?mod=WSJ_comments_mostrecommended&mg=cmy-wsj&url=http%3a%2f%2fonline.wsj.com%2fcommunity%2fintegration%2fleaderboard.html%3fmod%3dWSJ_comments_mostrecommended""><img src=""http://cs.wsj.net/community/content/images/misc/members/defaultuser.50x50.png"" alt=""""/></a>
	  </div>
	  <div class=""commenter-name-outer"">
	    <div class=""commenter-name-middle"">
		  <a class=""commenter-name"" href=""http://online.wsj.com/community/aa77534e-4600-4382-acab-8df89d5545b9?mod=WSJ_comments_mostrecommended&mg=cmy-wsj&url=http%3a%2f%2fonline.wsj.com%2fcommunity%2fintegration%2fleaderboard.html%3fmod%3dWSJ_comments_mostrecommended"">Tom Boucher</a>
		</div>
	  </div>
	  <div class=""recommendations-outer"">
	    <div class=""recommendations-middle"">
          <small class=""recommendations"">1107 Recommendations</small>
		</div>
	  </div>
    </li>
    <li class="" commenter"">
      <div class=""commenter-image-outer"">
		<a class=""commenter-pic"" href=""http://online.wsj.com/community/bc9250e8-6435-4147-b05b-3204213c59a5?mod=WSJ_comments_mostrecommended&mg=cmy-wsj&url=http%3a%2f%2fonline.wsj.com%2fcommunity%2fintegration%2fleaderboard.html%3fmod%3dWSJ_comments_mostrecommended""><img src=""http://cs.wsj.net/community/content/images/misc/members/defaultuser.50x50.png"" alt=""""/></a>
	  </div>
	  <div class=""commenter-name-outer"">
	    <div class=""commenter-name-middle"">
		  <a class=""commenter-name"" href=""http://online.wsj.com/community/bc9250e8-6435-4147-b05b-3204213c59a5?mod=WSJ_comments_mostrecommended&mg=cmy-wsj&url=http%3a%2f%2fonline.wsj.com%2fcommunity%2fintegration%2fleaderboard.html%3fmod%3dWSJ_comments_mostrecommended"">James Doppelheuer</a>
		</div>
	  </div>
	  <div class=""recommendations-outer"">
	    <div class=""recommendations-middle"">
          <small class=""recommendations"">1044 Recommendations</small>
		</div>
	  </div>
    </li>
    <li class="" commenter"">
      <div class=""commenter-image-outer"">
		<a class=""commenter-pic"" href=""http://online.wsj.com/community/4f88c9f9-9abb-47be-adf1-cd665d59144a?mod=WSJ_comments_mostrecommended&mg=cmy-wsj&url=http%3a%2f%2fonline.wsj.com%2fcommunity%2fintegration%2fleaderboard.html%3fmod%3dWSJ_comments_mostrecommended""><img src=""http://cs.wsj.net/community/content/images/misc/members/defaultuser.50x50.png"" alt=""""/></a>
	  </div>
	  <div class=""commenter-name-outer"">
	    <div class=""commenter-name-middle"">
		  <a class=""commenter-name"" href=""http://online.wsj.com/community/4f88c9f9-9abb-47be-adf1-cd665d59144a?mod=WSJ_comments_mostrecommended&mg=cmy-wsj&url=http%3a%2f%2fonline.wsj.com%2fcommunity%2fintegration%2fleaderboard.html%3fmod%3dWSJ_comments_mostrecommended"">Maria Bonanno</a>
		</div>
	  </div>
	  <div class=""recommendations-outer"">
	    <div class=""recommendations-middle"">
          <small class=""recommendations"">1014 Recommendations</small>
		</div>
	  </div>
    </li>
    <li class="" commenter"">
      <div class=""commenter-image-outer"">
		<a class=""commenter-pic"" href=""http://online.wsj.com/community/a790ea22-3f29-49f0-b162-c39955ef53bd?mod=WSJ_comments_mostrecommended&mg=cmy-wsj&url=http%3a%2f%2fonline.wsj.com%2fcommunity%2fintegration%2fleaderboard.html%3fmod%3dWSJ_comments_mostrecommended""><img src=""http://synccontent.wsj.com/Imagestore/name/5d/e6/5de6547b-eb9e-4744-abaf-d7e0fe51a9c9.50x50.png"" alt=""""/></a>
	  </div>
	  <div class=""commenter-name-outer"">
	    <div class=""commenter-name-middle"">
		  <a class=""commenter-name"" href=""http://online.wsj.com/community/a790ea22-3f29-49f0-b162-c39955ef53bd?mod=WSJ_comments_mostrecommended&mg=cmy-wsj&url=http%3a%2f%2fonline.wsj.com%2fcommunity%2fintegration%2fleaderboard.html%3fmod%3dWSJ_comments_mostrecommended"">Peter Venetoklis</a>
		</div>
	  </div>
	  <div class=""recommendations-outer"">
	    <div class=""recommendations-middle"">
          <small class=""recommendations"">964 Recommendations</small>
		</div>
	  </div>
    </li>
  </ul>
</div>

</div><div id=""topDiscussions""><div class=""myGroupsBox boxType-featuredDiscussions boxType-comments comActivity"">
    <div class=""headerBox"">
        <h4>Most Active Discussions</h4>
                <ul class=""cMetadata metadataType-section"">
            <li><a href=""#"">Journal Community</a></li>
        </ul>
            </div>
    <ul class=""unitList"">
                <li class=""unit "">
            <div class=""multiboxCombo comboType-iconCaption"">
                <div class=""multiboxCol colType-icon"">
		            		            			        <img class=""icon"" alt="""" src=""http://synccontent.wsj.com/Imagestore/groups/name/re/li/religion-diversity-tolerance-governance.25x25.png"" />
                </div>
                <div class=""multiboxCol colType-caption"">
                    <h6>Religion & Ethics</h6>
                    <p>
                        <a href=""/community/groups/religion-diversity-tolerance-governance/topics/do-we-need-religion-have"">Do we need religion to have ethics? Is it possible that a world without religion can be, on the whole, a better place to live?</a>
                    </p>
                </div>
            </div>
        </li>
                <li class=""unit "">
            <div class=""multiboxCombo comboType-iconCaption"">
                <div class=""multiboxCol colType-icon"">
		            		            			        <img class=""icon"" alt="""" src=""http://synccontent.wsj.com/Imagestore/groups/name/ws/j-/wsj-reading-group.25x25.png"" />
                </div>
                <div class=""multiboxCol colType-caption"">
                    <h6>WSJ Reading Group</h6>
                    <p>
                        <a href=""/community/groups/wsj-reading-group/topics/you-reading"">What are you reading?</a>
                    </p>
                </div>
            </div>
        </li>
                <li class=""unit "">
            <div class=""multiboxCombo comboType-iconCaption"">
                <div class=""multiboxCol colType-icon"">
		            		            			        <img class=""icon"" alt="""" src=""http://cs.wsj.net/community/content/images/misc/groups/otherquestionmark.25x25.png"" />
                </div>
                <div class=""multiboxCol colType-caption"">
                    <h6>Question of the Day</h6>
                    <p>
                        <a href=""/community/groups/question-day-229/topics/should-federal-government-lower-corporate-tax"">Should the federal government lower corporate-tax rates?</a>
                    </p>
                </div>
            </div>
        </li>
                <li class=""unit "">
            <div class=""multiboxCombo comboType-iconCaption"">
                <div class=""multiboxCol colType-icon"">
		            		            			        <img class=""icon"" alt="""" src=""http://synccontent.wsj.com/Imagestore/groups/name/ha/ss/hass-associates-cyber-warning-tips-reviews-1865.25x25.png"" />
                </div>
                <div class=""multiboxCol colType-caption"">
                    <h6>Hass Associates Cyber Warning Tips and Reviews</h6>
                    <p>
                        <a href=""/community/groups/hass-associates-cyber-warning-tips-reviews-1865/topics/hass-associates-paypal-teams-et-searchers"">hass and associates-PayPal teams with ET searchers to create interplanetary payment system-knowhow</a>
                    </p>
                </div>
            </div>
        </li>
                <li class=""unit last"">
            <div class=""multiboxCombo comboType-iconCaption"">
                <div class=""multiboxCol colType-icon"">
		            		            			        <img class=""icon"" alt="""" src=""http://synccontent.wsj.com/Imagestore/groups/name/ko/ya/koyal-group-tokyo-japan-kg-1897.25x25.png"" />
                </div>
                <div class=""multiboxCol colType-caption"">
                    <h6>Koyal Group Tokyo Japan (KG)</h6>
                    <p>
                        <a href=""/community/groups/koyal-group-tokyo-japan-kg-1897/topics/koyal-group-host-student-equity"">Koyal Group To Host Student Equity Research Analyst Competition</a>
                    </p>
                </div>
            </div>
        </li>
            </ul>
    <ul class=""linkBar seeAll"">
        <li class=""listFirst""><a href=""/community/groups"">See all Discussion Groups</a></li>
    </ul>
</div>
</div><div id=""wsj_fb_fanbox"" data-dj-widget=""onvisible.template"" data-dj-scroll-proximity=""120"">
<textarea style=""display:none""><![CDATA[<fb:fan data-dj-widget=""onvisible.module"" data-dj-module=""dj.module.facebook.connect"" data-dj-scroll-proximity=""120"" profile_id=""8304333127"" stream=""0"" connections=""10"" width=""377""></fb:fan></div><div id=""ffb"" style=""font-size:8px; padding-left:10px"">]]></textarea>
</div>
<div class=""visibility-onlyUnSubNotReg adSummary""><!-- Modified - 25 June 2009 - Spanish changes -->
<div id=""emailSignUpNonSub"" class=""emailSignUpNonSub"">
<a href=""/email"">
  <img src=""/img/freereg_nonsub_promo.jpg"" alt=""Email Newsletters and alerts""/>
</a>
</div> 
</div><div class=""visibility-onlySub""><!-- Modified - 25 June 2009 - Spanish changes -->
<div id=""emailSignUp"" class=""emailSignUp subscribe newsletter opt4 hline strap"">
    <div class=""userEmail hidden"">
      null</div>
    <div class=""mainContent"">
  	  <h3>Email Newsletters and Alerts</h3>
<p>The latest news and analysis delivered to your in-box. Check the boxes below to sign up.</p>
<form action="""" method=""post"" accept-charset=""utf-8"">
			<fieldset style=""position:relative;"">
				<legend>WSJ.com Email Features</legend>
<div class=""ctl checkbox"">
					<label for=""checkbox1"">
<input type=""checkbox"" name=""checkbox1"" value=""0"" id=""checkbox1"" class=""check"" checked=""checked"" />
<a href=""http://online.wsj.com/static_html_files/email/email_sample_newsalert.html"" target=""_BLANK"">                      
                        News Alert</a>
<input type=""hidden"" name=""displayName0"" value=""News Alert""/>
</label>
				</div>
<div class=""ctl checkbox"">
					<label for=""checkbox2"">
<input type=""checkbox"" name=""checkbox2"" value=""82"" id=""checkbox2"" class=""check"" checked=""checked"" />
<a href=""http://online.wsj.com/internal/emails/email_morning_itp.htm"" target=""_BLANK"">                      
                        In Today's Paper</a>
<input type=""hidden"" name=""displayName82"" value=""In Today's Paper""/>
</label>
				</div>
<div class=""ctl checkbox"">
					<label for=""checkbox3"">
<input type=""checkbox"" name=""checkbox3"" value=""89"" id=""checkbox3"" class=""check"" checked=""checked"" />
<a href=""http://online.wsj.com/internal/emails/email_wkly_mpwsj.htm"" target=""_BLANK"">                      
                        This Week's Most Popular</a>
<input type=""hidden"" name=""displayName89"" value=""This Week's Most Popular""/>
</label>
				</div>
</fieldset>
			<fieldset>
				<legend>Submit</legend>
	            <!-- Error message  -->
	            <div class=""errorMessage hidden"">
				  	<p class=""error"">
						The email address <strong>null</strong> is already associated with another account. Please enter a different email address:
				  	</p>
					<div class=""ctl text"">
						<label for=""frmRTECtl01"">Enter Your Email</label>
						<input type=""text"" name=""txtEmail"" value=""null"" class=""text txtEmail"" />					
					</div>
				</div>

				<div class=""ctl submit"">
				    <br></br>
					<label for=""frmRTEsub"">Sign Up</label>
					<button name=""emailSignUpSubmit"" class=""signup emailSignUpSubmit"">SIGN UP</button>
				</div>
			</fieldset>
		</form>		
		<ul class=""tools"">
			<li class=""firstList""><strong>New! </strong>To sign up for Keyword or Symbol Alerts click <a href=""/ksemail"">here.</a></li>
	
			<li>To view or change all of your email settings, visit the <a href=""/email"">Email Setup Center</a>.</li>
		</ul>
    </div>
    
    <div class=""successMessage hidden"">
      <p>Thank you <strong><span class=""userLoginName""></span></strong>!<br />You will receive <span class=""displayNames""></span> in your inbox.</p>

      <ul class=""nav-inline"">
	    <li class=""firstList"">To view or change all of your email settings, visit the <a href=""/email"">Email Setup Center</a>.</li>
	  </ul>
    </div>
</div>
</div><div class=""visibility-onlyReg""><!-- Modified - 25 June 2009 - Spanish changes -->
<div id=""emailSignUp"" class=""emailSignUp subscribe newsletter opt4 hline strap"">
    <div class=""userEmail hidden"">
      null</div>
    <div class=""mainContent"">
  	  <h3>Email Newsletters and Alerts</h3>
<p>The latest news and analysis delivered to your in-box. Check the boxes below to sign up.</p>
<form action="""" method=""post"" accept-charset=""utf-8"">
			<fieldset style=""position:relative;"">
				<legend>WSJ.com Email Features</legend>
<div class=""ctl checkbox"">
					<label for=""checkbox1"">
<input type=""checkbox"" name=""checkbox1"" value=""89"" id=""checkbox1"" class=""check"" checked=""checked"" />
<a href=""http://online.wsj.com/internal/emails/email_wkly_mpwsj.htm"" target=""_BLANK"">                      
                        This Week's Most Popular</a>
<input type=""hidden"" name=""displayName89"" value=""This Week's Most Popular""/>
</label>
				</div>
<div class=""ctl checkbox"">
					<label for=""checkbox2"">
<input type=""checkbox"" name=""checkbox2"" value=""159"" id=""checkbox2"" class=""check"" checked=""checked"" />
<a href=""http://online.wsj.com/internal/emails/email_morning_otep.htm"" target=""_BLANK"">                      
                        On the Editorial Page</a>
<input type=""hidden"" name=""displayName159"" value=""On the Editorial Page""/>
</label>
				</div>
</fieldset>
			<fieldset>
				<legend>Submit</legend>
	            <!-- Error message  -->
	            <div class=""errorMessage hidden"">
				  	<p class=""error"">
						The email address <strong>null</strong> is already associated with another account. Please enter a different email address:
				  	</p>
					<div class=""ctl text"">
						<label for=""frmRTECtl01"">Enter Your Email</label>
						<input type=""text"" name=""txtEmail"" value=""null"" class=""text txtEmail"" />					
					</div>
				</div>

				<div class=""ctl submit"">
				    <br></br>
					<label for=""frmRTEsub"">Sign Up</label>
					<button name=""emailSignUpSubmit"" class=""signup emailSignUpSubmit"">SIGN UP</button>
				</div>
			</fieldset>
		</form>		
		<ul class=""tools"">
			<li class=""firstList""></li>
	
			<li><a href=""/email"">Manage Email Preferences</a></li>
		</ul>
    </div>
    
    <div class=""successMessage hidden"">
      <p>Thank you <strong><span class=""userLoginName""></span></strong>!<br />You will receive <span class=""displayNames""></span> in your inbox.</p>

      <ul class=""nav-inline"">
	    <li class=""firstList""><a href=""/email"">Manage Email Preferences</a></li>
	  </ul>
    </div>
</div>
</div><div id=""ad0_0_WA_0001L_comment"" class=""adSummary advertisement""  data-cb-ad-id=""ad0_0_WA_0001L_comment"">
</div>
<!--  Scripts are added to the end --></div><div class=""col10wide colOverflowTruncated""><div id=""carouselHighlightsLeft"" class=""headlineSummary carousel editorPicksWide testClassNt"">
<h3>Editors' Picks</h3>
<ul class=""newsItem"">

	
 <!-- in some cases we get multiple categories -->
		<li class=""firstList"">
	
	
	<!-- check just to show the images in other env -->


		<a href=""http://online.wsj.com/article/SB10001424127887323873904578571472700348086.html?mod=WSJ_article_EditorsPicks"">
			<img width=""167"" vspace=""0"" hspace=""0"" height=""94"" border=""0"" class=""imageFormat-C"" src=""http://s.wsj.net/public/resources/images/RV-AK933_REVOLU_C_20130628191048.jpg"">
		</a>
		

		<h2><a class="""" href=""http://online.wsj.com/article/SB10001424127887323873904578571472700348086.html?mod=WSJ_article_EditorsPicks"">The Middle-Class Revolution</a></h2>
	</li>

	
 <!-- in some cases we get multiple categories -->
		<li class="""">
	
	
	<!-- check just to show the images in other env -->


		<a href=""http://online.wsj.com/article/SB10001424127887323683504578565482315023780.html?mod=WSJ_article_EditorsPicks"">
			<img width=""167"" vspace=""0"" hspace=""0"" height=""94"" border=""0"" class=""imageFormat-C"" src=""http://s.wsj.net/public/resources/images/OD-AX746_VACATI_C_20130627160455.jpg"">
		</a>
		

		<h2><a class="""" href=""http://online.wsj.com/article/SB10001424127887323683504578565482315023780.html?mod=WSJ_article_EditorsPicks"">Return of No-Stigma Extended Vacation</a></h2>
	</li>

	
 <!-- in some cases we get multiple categories -->
		<li class="" subPrev tipTree tooltipType-news"">
	
	
	<!-- check just to show the images in other env -->


		<a href=""http://online.wsj.com/article/SB10001424127887323689204578573761448937042.html?mod=WSJ_article_EditorsPicks"">
			<img width=""167"" vspace=""0"" hspace=""0"" height=""94"" border=""0"" class=""imageFormat-C"" src=""http://s.wsj.net/public/resources/images/BF-AF274_KCBT_C_20130628184606.jpg"">
		</a>
		

		<div class=""tipTargetBox"">
			<div class=""tooltipBox"" style=""display: none; "">
				<div class=""tooltip"">
					<p><small>Subscriber Content</small>
					<em>Read Preview</em></p>
				</div>
			</div>								
			<h2 class=""tipTarget""><a class="""" href=""http://online.wsj.com/article/SB10001424127887323689204578573761448937042.html?mod=WSJ_article_EditorsPicks"">Pits Go Dark in Kansas City as Storied Wheat Exchange Closes</a></h2>
		</div>
	</li>

	
 <!-- in some cases we get multiple categories -->
		<li class="""">
	
	
	<!-- check just to show the images in other env -->


		<a href=""http://online.wsj.com/article/SB10001424127887323393804578559431838390150.html?mod=WSJ_article_EditorsPicks"">
			<img width=""167"" vspace=""0"" hspace=""0"" height=""94"" border=""0"" class=""imageFormat-C"" src=""http://s.wsj.net/public/resources/images/OD-AX694_USA_TA_C_20130625170903.jpg"">
		</a>
		

		<h2><a class="""" href=""http://online.wsj.com/article/SB10001424127887323393804578559431838390150.html?mod=WSJ_article_EditorsPicks"">What Is the Taste of America?</a></h2>
	</li>

	
 <!-- in some cases we get multiple categories -->
		<li class="" subPrev tipTree tooltipType-news"">
	
	
	<!-- check just to show the images in other env -->


		<a href=""http://online.wsj.com/article/SB10001424127887323683504578565892955743404.html?mod=WSJ_article_EditorsPicks"">
			<img width=""167"" vspace=""0"" hspace=""0"" height=""94"" border=""0"" class=""imageFormat-C"" src=""http://s.wsj.net/public/resources/images/RV-AK931_WKCONF_C_20130628151712.jpg"">
		</a>
		

		<div class=""tipTargetBox"">
			<div class=""tooltipBox"" style=""display: none; "">
				<div class=""tooltip"">
					<p><small>Subscriber Content</small>
					<em>Read Preview</em></p>
				</div>
			</div>								
			<h2 class=""tipTarget""><a class="""" href=""http://online.wsj.com/article/SB10001424127887323683504578565892955743404.html?mod=WSJ_article_EditorsPicks"">Weekend Confidential: Olympia Snowe</a></h2>
		</div>
	</li>
</ul>

</div></div>   </div></div>   </div></div><div class=""pagewide""><div class=""visibility-onlySub""><div class=""communityUserPopup popupBox community"" style=""visibility:hidden"">

    <div class=""popupTitle multiboxCombo comboType-headFunc"">
      <div class=""multiboxCol colType-head"">
        <h6>Journal Community</h6>
      </div>
      <div class=""multiboxCol colType-func"">
        <ul class=""linkBar linkType-windowFunc"">
          <li class=""first popupClose""><a href=""#"">close window</a></li>
        </ul>
      </div>
    </div>
    <div class=""commentBox unblockedUser"">
      <div class=""headerBox"">
        <h4>Hello<span class=""userFirstName""></span> <span class=""userLastName""></span></h4>
      </div>
      <div class=""contentBox"">
        <p><span class=""askQuestionText"">Your question to the Journal Community </span><span class=""commentsText"">Your comments on articles </span>will show your real name<span class=""userFirstName""></span> <span class=""userLastName""></span> and not a username.<a href=""#"" class=""whyLink"">Why?</a></p>

        <p class=""whyLinkPara expanded"" style=""display:none""><strong>Why use your real name?</strong> The Journal Community encourages thoughtful dialogue and meaningful connections between real people. We require the use of your full name to authenticate your identity. The quality of conversations can deteriorate when real identities are not provided.</p>
		
		<div class=""userNameInfoContainer"" style=""display:none"">
	        <div class=""alertMessage errorMessage"" style=""display:none"">Please enter your first and last name</div>
	        <div class=""multiboxCombo comboType-formForm"">
	          <div class=""multiboxCol colType-form firstCol"">
	            <div class=""formBlock"">
	              <label for=""firstname"">First name:</label> <input class=""inputType-text firstNameText"" name=""firstname"" type=""text"" size=""16"" />
	            </div>
	
	          </div>
	          <div class=""multiboxCol colType-form lastCol"">
	            <div class=""formBlock"">
	              <label for=""firstname"">Last name:</label> <input class=""inputType-text lastNameText"" name=""lastname"" type=""text"" size=""16"" />
	            </div>
	          </div>
	        </div>		
		</div>
				
        <div class=""multiboxCombo comboType-checkCaption"">
          <div class=""multiboxCol colType-check"">
            <fieldset>
              <div class=""formBlock"">
                <input type=""checkbox"" id=""chk1"" class=""chkBox""/>
              </div>

            </fieldset>
          </div>
          <div class=""multiboxCol colType-caption"">
            <p><strong>Create a <a href=""#"" class=""communityLink"">Journal Community</a> profile to avoid this message in the future.</strong> (As a member you agree to use your <b>real name</b> when participating in the Journal Community)</p>
          </div>
        </div>

        <div class=""metaBox"">
          <ul class=""buttonBar"">
            <li class=""button buttonStyle-bold first popupClose""><a href=""#"" class=""post"">Post</a></li>
            <li class=""button last popupClose""><a href=""#"">Cancel</a></li>
          </ul>
          <ul class=""linkBar linkType-footer"">
            <li class=""first""><a href=""#"" class=""privacyLink"">Privacy Policy</a></li>

            <li><a href=""#"" class=""termsLink"">Community Rules</a></li>
          </ul>
        </div>
      </div>
    </div>
	
	<div class=""commentBox blockedUser"">
      <div class=""headerBox"">
        <h4>Notice: <span class=""userFirstName""></span> <span class=""userLastName""></span></h4>
      </div>
      <div class=""contentBox"">
        <p>Your participation access with Journal Community has been disabled due to violation of <a href=""#"" class=""communityGuidelinesLink"">Journal Community Guidelines.</a></p>
		
		<p>If you feel you have reached this status change in error, please contact <a href=""#"">TBD@wsj.com</a></p>
        
      </div>
    </div>
		
  </div></div><div id=""footer""><div id=""slice"" class=""hslice"" style=""display:none;"">
	<div class=""entry-title"">WSJ Web Slice</div>
    <div class=""entry-content"">CONTENT</div>
    <a rel=""entry-content"" href=""http://ie8.smoothfusion.com/WallStreetJournal/view.aspx"">LINKS TO ACTUAL PAGE CONTAINING WEB SLICE FUNCTIONALITY.</a>
    <a rel=""bookmark""  target=""_blank"" href=""http://online.wsj.com"" ></a>
    <span class=""ttl"" style=""display: none;"">15</span>
</div>
<div id=""footerWrapper"" class=""newFooterWrap"">
  <div class=""newFooter"">
    <!--TOP BAR LINKS-->
    <ul class=""topLinks clearFix"">
      <li class=""wsjLogo""><a href=""http://asia.wsj.com/?mod=WSJDE_footer"">Wall Street Journal</a></li>
      <li class=""socialLogo""><a title=""Facebook"" href=""http://www.facebook.com/wsj"" class=""facebook"">Facebook</a></li>
      <li class=""socialLogo""><a title=""Twitter"" href=""http://twitter.com/WSJ"" class=""twitter"">Twitter</a></li>
      <li class=""socialLogo""><a title=""LinkedIn"" href=""http://www.linkedin.com/today/online.wsj.com"" class=""linkedin"">LinkedIn</a></li>
      <li class=""socialLogo""><a title=""FourSquare"" href=""https://foursquare.com/wsj"" class=""foursquare"">FourSquare</a></li>
      <li class=""socialLogo""><a title=""Google+"" href=""https://plus.google.com/117720626238470886461/posts"" class=""gplus"">Google+</a></li>
      <li class=""socialLogo""><a title=""YouTube"" href=""http://www.youtube.com/user/WSJDigitalNetwork"" class=""youtube"">YouTube</a></li>
      <li class=""socialLogo""><a title=""Podcasts"" href=""http://online.wsj.com/public/page/podcast.html?mod=WSJ_footer"" class=""podcast"">Podcasts</a></li>
      <li class=""socialLogo""><a title=""RSS"" href=""http://online.wsj.com/public/page/rss_news_and_feeds.html?mod=WSJ_footer"" class=""rssfeed"">RSS Feed</a></li>
      <li class=""socialLogo""><a title=""AppStore"" href=""http://itunes.apple.com/us/app/the-wall-street-journal./id364387007?mt=8"" class=""appstore"">AppStore</a></li>
      <li class=""login_sub"">
        <ul class=""clearFix"">
          <li class=""subscribe""><a href=""http://www.wsj-asia.com/subscribecpc.html"" rel=""nofollow"">Subscribe</a></li>
          <li class=""login loginClass""><span>/</span><a href=""https://id.wsj.com/auth/log-in"" class=""loginClass"">Login</a></li>
        </ul>
      </li>
      <li class=""backToTop""><a href=""#top"">Back to Top<span class=""rotate"">&laquo;</span></a></li>
    </ul>
    <!--MIDDLE COLUMN LINKS-->
    <ul class=""contentLinks clearFix"">
      <li class=""linksCol"">
        <h4>Customer Service</h4>
        <ul>
          <li><a href=""http://help.wsj.com/customer-service/?mod=WSJ_footer"">Customer Center</a></li>
          <!--<li><a href=""http://help.wsj.com/global/?mod=WSJ_footer"" rel=""nofollow"">Asia/Europe Support</a></li>-->
          <li><a href=""https://customercenter.wsj.com/view/contactus.html?mod=WSJ_footer"" rel=""nofollow"">Contact Us</a></li>
<li><a href=""http://www.subscribe.wsj.com/getweekendnow?mod=WSJ_footer"" rel=""nofollow"">WSJ Weekend</a></li>
<li><a href=""https://customercenter.wsj.com/view/ctdir/contactdirectory.html?mod=WSJ_footer"" rel=""nofollow"">Contact Directory</a></li>
          <li><a href=""http://online.wsj.com/article/Corrections.html?mod=WSJ_footer"" rel=""nofollow"">Corrections</a></li>
        </ul>
      </li>
      <li class=""linksCol"">
        <h4>Policy</h4>
        <ul>
          <li><a href=""http://online.wsj.com/public/page/privacy-policy.html?mod=WSJ_footer"" rel=""nofollow"">Privacy Policy</a></li>
          <li><a href=""http://online.wsj.com/public/page/data-policy.html?mod=WSJ_footer"" rel=""nofollow"">Data Policy</a></li>
          <li><a href=""http://online.wsj.com/public/page/copyright_policy.html?mod=WSJ_footer"" rel=""nofollow"">Copyright Policy</a></li>
          <li><a href=""http://online.wsj.com/public/page/subscriber_agreement.html?mod=WSJ_footer"" rel=""nofollow"">Updated: Subscriber Agreement<br>&amp; Terms of Use</a></li>
        </ul>
      </li>
      <li class=""linksCol"">
        <h4>Ads</h4>
        <ul>
          <li><a href=""http://online.wsj.com/public/page/privacy-policy.html?mod=WSJ_footer#ad_choices"" rel=""nofollow"">Your Ad Choices</a></li>
          <li><a href=""http://www.wsjdigital.com/?mod=WSJ_footer"" rel=""nofollow"">Advertise</a></li>
          <li><a href=""http://www.wsjlocal.com/?mod=WSJ_footer"" rel=""nofollow"">Advertise Locally</a></li>
          <li><a href=""http://classifieds.wsj.com/?mod=WSJ_footer"" rel=""nofollow"">Place a Classified Ad</a></li>
        </ul>
      </li>
      <li class=""linksCol"">
        <h4>Tools &amp; Features</h4>
        <ul>
          <li><a href=""http://online.wsj.com/public/page/designtech-mobAsiaHome.html?mod=WSJ_footer"">Apps</a></li>
          <li><a href=""http://online.wsj.com/public/page/email-setup.html?mod=WSJ_footer"" rel=""nofollow"">Newsletters and Alerts</a></li>
          <!--<li><a href=""http://online.wsj.com/ksemail?mod=WSJ_footer"" rel=""nofollow"">Alerts</a></li>-->
          <li><a href=""http://online.wsj.com/public/page/news-interactive-features-trends.html?mod=WSJ_footer"">Graphics &amp; Photos</a></li>
          <li><a href=""http://online.wsj.com/page/columnists.html?mod=WSJ_footer"">Columns</a></li>
          <li><a href=""http://topics.wsj.com/?mod=WSJ_footer"">Topics</a></li>
          <li><a href=""http://online.wsj.com/public/page/guides.html?mod=WSJ_footer"">Guides</a></li>
<li><a href=""http://portfolio.wsj.com?mod=wsj_port_foot"">Portfolio</a></li>
         <li><a href=""http://ds.wsj.com/wsjportfolio/portfolio?cmd=mainwindow&mod=wsj_portold_foot"">Old Portfolio</a></li>
        </ul>
      </li>
      <li class=""linksCol"">
        <h4>More</h4>
        <ul>
          <li><a href=""#"" class=""registerUserClass"" rel=""nofollow"">Register for Free</a></li>
          <li><a href=""http://www.djreprints.com/?mod=WSJ_footer"" rel=""nofollow"">Reprints</a></li>
          <li><a href=""http://wsj.iamplify.com"">E-books</a></li><!-- online.wsj.com/public/page/2_1150.html -->
          <li><a href=""http://wsj.com/partner/?mod=WSJ_footer"" rel=""nofollow"">Content Partnerships</a></li>
          <li><a href=""http://online.wsj.com/conferences?mod=WSJ_footer"">Conferences</a></li>
          <li><a href=""http://www.wsj-asia.com/APP?mod=WSJ_footer"">Academic Partnerships</a></li>
          <li><a href=""http://www.wsj-asia.com/flp/about.html?mod=WSJ_footer"">Leadership Program</a></li>
          <li><a href=""http://www.wsj-asia.com/partner?mod=WSJ_footer"">Events in Asia</a></li>
          <li><a href=""http://m.wsj.com"" id=""forceMobile"">Mobile Site</a></li>
<li class=""subOnly""><a href=""http://setup1.wsj.com/pznsetup/sub/pvemail/setup.html?mod=WSJ_footer"">Price & Volume</a></li>
 <li class=""subOnly""><a href=""http://setup1.wsj.com/pznsetup/sub/ksemail/setup.html?mod=WSJ_footer"">Keyword & Symbol</a></li>
<li><a href=""/public/page/archive.html?mod=WSJ_footer"">News Archive</a></li>
       </ul>
      </li>
    </ul>
    <!--FOOTNOTE LINKS-->
    <ul class=""footnoteLinks clearFix"">
       <!--<li><a href=""http://help.wsj.com/?mod=WSJ_footer"" target=""_blank"">Help</a></li>-->
       <!--<li><a href=""http://help.wsj.com/contact-us/?mod=WSJ_footer"" rel=""nofollow"">Contact Directory</a></li>-->
       <li><a href=""http://www.dowjones.com/careers.asp?mod=WSJ_footer"" rel=""nofollow"">Jobs at WSJ</a></li>
       <li class=""copyright"">Copyright &copy;2013 <a href="""">Dow Jones &amp; Company</a>, Inc. All Rights Reserved.</li>
    </ul>
  </div>
  <!-- end module newGlobalFooter2012 -->
</div>
</div>   


<div class=""scrimWSJ"">
<div class=""scrimWSJ_overlay APAC"" style=""display: none;"">
	<div class=""scrimWSJ_wrapper"">
    	<div class=""scrimWSJ_inner"">
        	<div class=""scrimWSJ_module scrimWSJNewCirc"">
            	<div class=""headerStrap"">
                	<a href="""" class=""closeBtn"">Close Button</a>
                </div>
                <a href=""https://secure.wsj-asia.com/subscription1/index.php?source=PHOXX2BZCGA"" class=""scrimWSJNewCircBtn"">Download Free App</a>
        	</div>
        </div>
    </div>
</div>
</div>   <div style=""position: absolute;"" class=""hidden"">
	<div class=""dropdown_container dropdownType-article expanded"" id=""mjsave_dropdown_block"">
		  <div class=""dropdownTitlebar ddState-saveTo"" id=""saveToTopBar"">
				<p class=""tbType-saveTo""><span class=""tbText""><a href=""#"" id=""widget.mjsave_quicksave"">Save to</a></span> <span class=""tbIndicator""><a href=""#"" id=""widget.mjsave_more"">&darr; More</a></span></p>
				<p class=""tbType-saveThis""><span class=""tbText""><a href=""#"" id=""widget.mjsave_quicksave_savethis"">Save</a></span> <span class=""tbIndicator""><a href=""#"" id=""widget.mjsave_more_savethis"">&darr; More</a></span></p>
				<p class=""tbType-saved""><span class=""tbText""><a href=""#"" id=""widget.mjsave_saved"">Saved</a></span> <span class=""tbIndicator""><a href=""#"" id=""widget.mjsave_more_saved"">&darr; More</a></span></p>
		  </div>
		  <div class=""dropdownPanel ddPanelState-MyCollections"" id=""saveToDropdownPanel"">

				<div class=""sectionBox sectionType-Error"">
				  <p id=""mjsave_error""></p>
				</div>

				<div class=""sectionBox sectionType-Login"">
					<p>Please log in or register for free to use Save This.</p>
					<div class=""ddOps"">
						<ul class=""buttonBar"">
							<li class=""button buttonType-login""><a class=""loginClass"" href=""#"">Log In</a>/li>
							<li class=""button buttonType-register""><a class=""registerUserClass"" href=""#"">Register</a></li>
							<li class=""button buttonType-login hidden""><a name=""logInButton"" id=""logInButton"" href=""http://commerce.wsj.com/auth/login?roles=FREEREG-BASE"">Log In</a></li>
							<li class=""button buttonType-register hidden""><a name=""regInButton"" id=""regInButton"" href=""http://commerce.wsj.com/auth/login?roles=FREEREG-BASE"">Register</a></li>
						</ul>
						<ul class=""funcList listType-MyCollections"">
						  <li><a href=""http://online.wsj.com/public/page/my-saved-intro.html"">What is Save This?</a></li>
						</ul>
					</div>
				</div>

				<div class=""sectionBox sectionType-MyCollections"">
					<h3>Save to</h3>
				    <ul class=""linkList listType-MyCollections"" id=""mjsave_mycoll_collection_list""></ul>
					<ul class=""funcList listType-MyCollections"">
						<li><a name=""mjsave_addcoll_link"" id=""mjsave_addcoll_link"" href=""#"">+ New Collection</a></li>
						<li><a href=""http://online.wsj.com/page/my-saved-main.html"">Go to Save & Share &raquo;</a></li>
					</ul>
				</div>

				<div class=""sectionBox sectionType-NewCollection"" id=""mjsave_new_col"">
					<p id=""mjsave_new_col_instruction"">Name your new Collection and click save.</p>
					<form accept-charset=""utf-8"" method=""post"" action=""#"">
						<input type=""text"" id=""new-collection"" value=""My New Collection""/>
						<div class=""ddOps"">
							<ul class=""buttonBar"">
								<li class=""button buttonType-save""><a name=""mjsaveNewCollSubmit"" id=""mjsaveNewCollSubmit"" href=""#"">Save</a></li>
								<li class=""nonbutton linkType-cancel""><a name=""mjsaveNewCollCancel"" id=""mjsaveNewCollCancel"" href=""#"">Cancel</a></li>
							</ul>
						</div>
					</form>
					<ul class=""funcList listType-MyCollections"">
						<li><a href=""http://online.wsj.com/page/my-saved-main.html"">Go to Save & Share &raquo;</a></li>
					</ul>
				</div>

				<div class=""sectionBox sectionType-SaveConfirmation"">
					<span id=""mjsave_articlesavedtext""></span>
					<ul class=""funcList listType-MyCollections"">
						<li><a href=""http://online.wsj.com/page/my-saved-main.html"">Go to Save & Share &raquo;</a></li>
					</ul>
				</div>

				<div id=""saveToSponsorBox"">
				</div>
		  </div>
	</div>
</div>
</div><div id=""socialContainer"" style=""display:none"">
<div id=""valetTools-top"" class=""vltTools horizontal"">

<div class=""sTools sTools-t"">            
            <ul class=""stList stList-sq"">
              <li class=""stList-i stI-smaller"">
                <a id=""att.at.tbs"" class=""stSq stLtr-smaller"" href=""#"">smaller</a>
              </li>
              <li class=""stList-i stI-larger"">
                <a id=""att.at.tbl"" class=""stSq stLtr-larger"" href=""#"">Larger</a>
              </li>
            </ul>
 </div>
          
<ul class=""vltSocialLinks"">
	<li class=""stList-s vltTool-fb""><a href=""javascript:void(0)""  class=""icn-fb vltanchor"">facebook</a><div class=""vlt_overlay""></div></li>
	<li class=""stList-s vltTool-tw""><a href=""javascript:void(0)""   class=""icn-tw vltanchor"">twitter</a><div class=""vlt_overlay""></div></li>
	<li class=""stList-s vltTool-li""><a href=""javascript:void(0)""  class=""icn-li vltanchor"">linked in</a><div class=""vlt_overlay""></div></li>
</ul>

<ul class=""vltShareTools"">
      <li class=""stList-i stI-email""><a href=""#"" id=""att.at.emailthis"" class=""icn-email"">Email</a></li>
      <li class=""stList-i stI-print""><a href=""#"" id=""att.at.print"" class=""icn-print"">Print</a></li>
	          <li class=""stList-i stI-save"">
                <!-- module saveToArtMini-collapsed -->
                <div class=""dropdownTree ddState-collapsed"" id=""att.mjsave_container"">
                  <div class=""dropdown_container dropdownType-article collapsed IE6ddArticleCollapsed"">
                    <div class=""dropdownTitlebar"">
                      <p class=""tbType-saveThis"">
                        <span class=""tbText""><a class=""mjQuickSave"" href=""#mjQuickSave"">Save</a></span>
                        <span class=""tbIndicator""><a class=""mjDropdown"" href=""#mjDropdown"">&darr; More</a></span>
                      </p>
                    </div>
                  </div>
                  <div class=""dropdownContainer-expansion""></div>
                </div>
          <!-- end module saveToArtMini-collapsed -->             
        </li>   
</ul>
</div>
<div id=""valetTools-left"" class=""vltTools compact"">
    <ul id =""placeholderContainer"" class=""vltSocialLinks"">
        <li class=""stList-s vltTool-fb"">
            <a href=""#"" class=""icn-fb"">facebook</a>            
        </li>
        <li class=""stList-s vltTool-tw"">
            <a href=""#"" class=""icn-tw"">twitter</a>           
        </li>
        <li class=""stList-s vltTool-li"">
            <a href=""#"" class=""icn-li"">linked in</a>
        </li>
    </ul>

    <ul id =""thirdPartyContainer"" class=""vltSocialLinks"" style=""display:none;"">
	</ul>    
   
    <ul id =""leftShareTools"" class=""vltShareTools"">
        <li class=""stList-i stI-email""><a id=""atl.at.emailthis"" href=""#"" class=""icn-email"">Email</a></li>
        <li class=""stList-i stI-print""><a id=""atl.at.print"" href=""#"" class=""icn-print"">Print</a></li> 
					<li class=""stList-i stI-save"">
					<div class=""dropdownTree ddState-collapsed"" id=""atl_mjsave_container"">
					  <div class=""dropdown_container dropdownType-article collapsed IE6ddArticleCollapsed"">
						<div class=""dropdownTitlebar"">
						  <p class=""tbType-saveThis"">
							<span class=""tbText""><a class=""mjQuickSave"" href=""#mjQuickSave"">Save</a></span>
							<span class=""tbIndicator""><a class=""mjDropdown"" href=""#mjDropdown"">&darr; More</a></span>
						  </p>
						</div>
					  </div>
					  <div class=""dropdownContainer-expansion""></div>
					</div>         
			</li> 
			<li class=""stList-i stI-reprints""><a id=""atl.at.reprint"" href=""#"" class=""icn-reprints"">Order Reprints</a></li>  
    </ul>
</div>
<div id=""valetTools-bottom"" class=""sTools sTools-b clearFix"">
   <div id=""valetTools"" class=""vltTools horizontal"">
    <ul class=""vltSocialLinks"">
        <li class=""stList-s vltTool-fb""><a href=""javascript:void(0)"" class=""icn-fb vltanchor"">facebook</a><div class=""vlt_overlay""></div></li>
        <li class=""stList-s vltTool-tw""><a href=""javascript:void(0)"" class=""icn-tw vltanchor"">twitter</a><div class=""vlt_overlay""></div></li>
			<li class=""stList-s vltTool-li""><a href=""javascript:void(0)"" class=""icn-li vltanchor"">linked in</a><div class=""vlt_overlay""></div></li>
    </ul>   
       
      <ul class=""vltShareTools"">
         <li class=""stList-i stI-email""><a href=""#"" id=""atb.at.emailthis"" class=""icn-email"">Email</a></li>
         <li class=""stList-i stI-print""><a href=""#"" id=""atb.at.print"" class=""icn-print"">Print</a></li>
		 			<li class=""stList-i stI-save"">
					<!-- module saveToArtMini-collapsed -->
					<div class=""dropdownTree ddState-collapsed"" id=""atb.mjsave_container"">
					  <div class=""dropdown_container dropdownType-article collapsed IE6ddArticleCollapsed"">
						<div class=""dropdownTitlebar"">
						  <p class=""tbType-saveThis"">
							<span class=""tbText""><a class=""mjQuickSave"" href=""#mjQuickSave"">Save</a></span>
							<span class=""tbIndicator""><a class=""mjDropdown"" href=""#mjDropdown"">&darr; More</a></span>
						  </p>
						</div>
					  </div>
					  <div class=""dropdownContainer-expansion""></div>
					</div>
			  <!-- end module saveToArtMini-collapsed -->             
			</li>        
			<li class=""stList-i stI-reprints""><a id=""atb.at.reprint"" href=""#"" class=""icn-reprints"">Order Reprints</a></li>  
      </ul>
   </div>
</div>
	<div class=""hidden"" id=""valetToolsTwitterShortURL"" data-shortURL=""http://on.wsj.com/15Wa4Kb""></div>


</div></div><script type=""text/javascript"" src=""http://s.wsj.net/javascript/j_global_slim-static.js?cb=1""></script>
<script type=""text/javascript"" src=""http://fonts.wsj.com/zap5igl.js""></script>
<script type=""text/javascript"" src=""http://sj.wsj.net/djscript/bucket/ASIA_WSJ/page/0_0_WA_0001/provided/j_global_slim/version/20130626020420.js""></script>
<script type=""text/javascript"">
/* <![CDATA[ */
	
var jsexec = dj.util.JSExec(dj.context.jsexec);
try { console.group(""DJ JSExec:""); console.info(""[ begin jsexec ]""); }
catch (e) { var _fnc = function(){}; console = {log: _fnc, info: _fnc, error: _fnc, dir: _fnc, group: _fnc, groupEnd: _fnc}; }
//------------------------------
jsexec(0,""dj.module.header2012.userDetails.showUserName"",function(){dj.module.header2012.userDetails.showUserName = function(){       dojo.removeClass(dojo.query("".uNav"")[0], ""hidden"");       dj.util.User.renderFirstName(""userName"");       var uNamePlaceholder = dojo.byId(""userName"").innerHTML;       if (uNamePlaceholder && uNamePlaceholder!=='' && uNamePlaceholder!=='undefined') {         uNamePlaceholder += ""'s Journal"";               } else {         dj.util.User.renderCallsign(""userName"");         var uNamePlaceholder = dojo.byId(""userName"").innerHTML;         uNamePlaceholder += ""'s Journal"";               }       dojo.byId(""userName"").innerHTML = uNamePlaceholder;       dojo.place(""<span class='sym'></span>"", dojo.byId(""userName""),""last""); }}); 
jsexec(1,""dojo.removeClass"",function(){dojo.removeClass(dojo.query("".custNav"")[0], ""hidden"");}); 
jsexec(2,""dj.module.header2012.editionSwitcher.init"",function(){dj.module.header2012.editionSwitcher.init();}); 
jsexec(3,""dj.module.newsreel"",function(){dj.module.newsreel=new dj.widget.newsreel.NewsReelLoader(0, ""0_0_WP_2007_NewsReel_inline"", ""1.57"", ""newsreeliframe"", {TTL:""5m"",isLoadCss:false,adRegisterKey:'newsReelAd'});dj.module.newsreel.load();}); 
jsexec(4,""dj.util.Tealium.init"",function(){dj.util.Tealium.init();dj.util.Omniture.init();dj.util.Tracking.omniture.init();var pDatePlaceholder = dojo.byId('pageDatePlaceholder'); var s = """";var i = pDateinGMT.indexOf("","");var gmtDate = new Date(pDateinGMT.substring(0, i + 1) + "" "" + pDateinGMT.substring(i + 1));if(typeof gmtDate !== 'undefined') {  s = dj.util.Date.simpleDateFormat.format(gmtDate,""EE, MMM d, yyyy"") + "" As of "" + dj.util.Date.simpleDateFormat.format(gmtDate,""h:mm a"");} else if(pDate && pDate !== 'undefined') {  s = pDate;}if(pDatePlaceholder && pID !== '0_0_WCR_0001' && s !== """") { pDatePlaceholder.innerHTML = s; };(function(){var edition=dj.util.Cookie.getCookie('wsjregion'); if(edition =='asia'){dj.context.videoCenter.host='video.asia.wsj.com';} else if(edition=='europe'){dj.context.videoCenter.host='video.europe.wsj.com'}})();dj.util.Cookie.deleteGroupCookie(""DJCOOKIE"", ""weatherJson"");}); 
jsexec(5,""dj.util.Tracking.omniture.delayFirePixel"",function(){dj.util.Tracking.omniture.delayFirePixel();}); 
jsexec(6,""dojo.query"",function(){dojo.query("".meta_date"")[0].innerHTML = pDate;}); 
jsexec(7,""if"",function(){if(window.location.pathname===""/public/page/factiva.html""){dojo.removeClass(dojo.byId(""factivaCustomerService""),""hidden"");}}); 
jsexec(8,""nielsenTracking.init"",function(){nielsenTracking.init();}); 
jsexec(9,""dj.context.videoCenter.height"",function(){dj.context.videoCenter.height=840; dj.context.videoCenter.width=418; dj.context.videoCenter.popUpPageURL = 'http://live.wsj.com/public/page/video-popup.html'; dj.util.VideoUtils.popUpPlayer = function(parameters) {      var popUpPageURL = ""/public/page/0_0_WP_3001.html"";      if(dj.context.videoCenter.popUpPageURL) {        popUpPageURL =dj.context.videoCenter.popUpPageURL;      }      if (dj.context.videoCenter.height){        var popUpWindow = window.open(popUpPageURL + '?currentPlayingLocation=' + parameters.playLocation + '&currentlyPlayingCollection=' + escape(parameters.collection) + '&currentlyPlayingVideoId=' + parameters.videoID, 'popUpPlayer', 'height='+dj.context.videoCenter.height+',width='+dj.context.videoCenter.width+',left=' + ((screen.width - Number(parameters.width)) / 2) + ',top=' + (screen.height - Number(parameters.height)) / 2 + ',resizable=no,scrollbars=no,toolbar=no,status=no');      }      else{        var popUpWindow = window.open(popUpPageURL + '?currentPlayingLocation=' + parameters.playLocation + '&currentlyPlayingCollection=' + escape(parameters.collection) + '&currentlyPlayingVideoId=' + parameters.videoID, 'popUpPlayer', 'height=690,width=510,left=' + ((screen.width - Number(parameters.width)) / 2) + ',top=' + (screen.height - Number(parameters.height)) / 2 + ',resizable=yes,scrollbars=no,toolbar=no,status=no');      }    };}); 
jsexec(10,""setMetaData"",function(){setMetaData('subsection','US');setMetaData('csource','WSJ Online');setMetaData('ctype','article_full');setMetaData('pagename','Politics and Policy_SB10001424127887324251504578577842451273534');setMetaData('abasedocid','SB10001424127887324251504578577842451273534');setMetaData('apublished','2013-06-30T19:30:00');setMetaData('section','Article');setMetaData('apage','US');setMetaData('author','Janet Hook');setMetaData('primaryproduct','Online Journal');setMetaData('atype','Politics and Policy');setMetaData('sitedomain','online.wsj.com');setMetaData('caccess','free');setMetaData('aheadline','Immigration Bill Faces Uphill Climb in the House');setMetaData('displayname','Default Article Layout');}); 
jsexec(11,""dj.util.User.isSubLoggedIn"",function(){dj.util.User.isSubLoggedIn( function(loggedIn) {if (!loggedIn) { new dj.widget.panel.Tooltip('.tipTree','.tipTargetBox','.tipTarget','.tooltipBox');}}); dj.widget.article.tools.PartnerButton.init(""a.btn_foursquare"",""onclick"",function(){window.open(this.href,""foursquare"",""toolbar=0,status=0,height=380,width=650,scrollbars=0,resizable=0"");});}); 
jsexec(12,""dj.module.facebook.connect.init"",function(){dj.module.facebook.connect.init();}); 
jsexec(13,""try"",function(){try{dojo.connect(dojo.byId(""forceMobile""),""onclick"",function(){dj.util.Cookie.setGroupCookie(""DJSESSION"",""mcookie"",""force-mobile"");});}catch(err){console.log(""Error: Not setting mobile cookie."")};}); 
jsexec(14,""dj.util.Tracking.omniture.firePixel"",function(){dj.util.Tracking.omniture.firePixel();}); 
jsexec(15,""dojo.getObject"",function(){dojo.getObject(""dj.context.autocomplete"",true).exclusionlist=""XBUE,XBAH,XCNQ,XTNX,XCYS,XCAI,XSTU,XBER,XHAN,XTAE,XAMM,XKAZ,XKUW,XCAS,XMUS,XKAR,XLIM,DSMD,XMIC,RTSX,XSAU,XBRA,XCOL,XADS,XDFM,XCAR,MISX""}); 
jsexec(16,""setTimeout"",function(){setTimeout(""if(dj.util.Cookie.getCookie('djmcn')==='true'){if(dojo.byId('hat_tab_secure')){dojo.removeClass(dojo.byId('hat_tab_secure'),'hidden');}if(dojo.byId('hat_tab_chat')){dojo.removeClass(dojo.byId('hat_tab_chat'),'hidden');}}"",2000);}); 
jsexec(17,""dj.module.articleTabs.init"",function(){dj.module.articleTabs.init(dj.module.articleTabs)}); 
jsexec(18,""dojo.getObject"",function(){dojo.getObject(""dj.context.autocomplete"",true).exclusionlist=""XBUE,XBAH,XCNQ,XTNX,XCYS,XCAI,XSTU,XBER,XHAN,XTAE,XAMM,XKAZ,XKUW,XCAS,XMUS,XKAR,XLIM,DSMD,XMIC,RTSX,XSAU,XBRA,XCOL,XADS,XDFM,XCAR,MISX""}); 
jsexec(19,""dj.context.article"",function(){dj.context.article=(dj.context.article||{});dj.context.article.videoTabPlayObserver=new dj.util.Observer(); dj.module.articleVisitHistory.init();dj.module.articlePagination.init();}); 
jsexec(20,""dj.context.userAgentString"",function(){dj.context.userAgentString=navigator.userAgent.toLowerCase(),isIphone=(dj.context.userAgentString.indexOf(""iphone"")>-1);}); 
jsexec(21,""dj.module.entitlements.googleClickTrack.init"",function(){dj.module.entitlements.googleClickTrack.init({expirationInterval: ""1d+""});}); 
jsexec(22,""dj.module.header2012.lifp.init"",function(){dj.module.header2012.lifp.init();}); 
jsexec(23,""dj.module.header2012.sectionMenu.init"",function(){dj.module.header2012.sectionMenu.init();}); 
jsexec(24,""if"",function(){if(window.location.pathname===""/public/page/rc-login.html"" || window.location.pathname===""/public/page/rc-login2.html""){dj.widget.networkHat.RCLogin.init();} }); 
jsexec(25,""if"",function(){if(dj.module.mst){dj.module.mst.preview.decorator.init();}}); 
jsexec(26,""dj.module.mostPopular.newsReel.init"",function(){dj.module.mostPopular.newsReel.init({'iframeDivId':'newsreeliframe_mostpopular'});}); 
jsexec(27,""dj.module.articleTextTab"",function(){dj.module.articleTextTab=new dj.widget.article.text.ArticleTabText(dj.module.articleTabs.panels,dj.context.article.videoTabPlayObserver);}); 
jsexec(28,""dj.module.articleFreeRegScrim.init"",function(){dj.module.articleFreeRegScrim.init();s.prop12 = 'article_full';}); 
jsexec(29,""dj.module.byline.authorConnect.init"",function(){dj.module.byline.authorConnect.init();}); 
jsexec(30,""dj.widget.panel.ModalPanel"",function(){
new dj.widget.panel.ModalPanel('articleThumbnail_1','articleImage_1',{openModalPanelEvent:""click"",closeModalPanelEvent:""click"",closeModalPanelButtonSelector:"".insetFullBox""});
}); 
jsexec(31,""dj.module.geotargeting.moduleShow.init"",function(){dj.module.geotargeting.moduleShow.init();}); 
jsexec(32,""dj.module.article.articleKeywordBased.init"",function(){dj.module.article.articleKeywordBased.init({'moduleType':'bottom_keyword_based','moduleURL':'/public/page/0_0_WP_APR_Bottom_Thumbnail_keywordSearch-'});}); 
jsexec(33,""dj.module.comments.showCommentsOnTabs"",function(){dj.module.comments.showCommentsOnTabs();}); 
jsexec(34,""if"",function(){if(document.referrer.indexOf('yahoo.com')>-1 || dj.util.Page.getQueryParam('mod').indexOf('yahoo') > -1){dojo.removeClass(dojo.byId('yahooLinkback'),'hidden');}}); 
jsexec(35,""if"",function(){if(document.referrer.indexOf('valor.com.br')>-1 || dj.util.Page.getQueryParam(""linkSource"") == ""valor""){dojo.removeClass(dojo.byId('valorLinkback'),'hidden');}}); 
jsexec(36,""dj.module.article.articleKeywordBased.init"",function(){dj.module.article.articleKeywordBased.init({'moduleType':'more_info_revised','moduleURL':'/public/page/0_0_WP_APR_keywordSearch_Thumbnail-'});}); 
jsexec(37,""dj.module.article.articleKeywordBased.init"",function(){dj.module.article.articleKeywordBased.init({'moduleType':'most_popular_orignal','moduleURL':'/public/page/0_0_WP_Articles_keyword_Based_Headline-'});}); 
jsexec(38,""dj.module.mostTrending.init"",function(){dj.module.mostTrending.init();}); 
jsexec(39,""try"",function(){try{Typekit.load();}catch(e){}}); 
jsexec(40,""dj.module.rssBlogTimes.init"",function(){dj.module.rssBlogTimes.init("".blog small"");}); 
jsexec(41,""dj.module.interactivePlayer"",function(){dj.module.interactivePlayer=new dj.widget.article.flash.ArticleFlashInteractive('articleTabInteractive', dj.module.articleTabs.panels)}); 
jsexec(42,""dj.module.interactivePlayer.register"",function(){
dj.module.interactivePlayer.register('immigration2013','');
}); 
jsexec(43,""dj.module.articleCommentsTab"",function(){dj.module.articleCommentsTab=new dj.widget.article.comments.ArticleComments(dj.module.articleTabs.panels);}); 
jsexec(44,""dj.module.emailSignUp.init"",function(){dj.module.emailSignUp.init();}); 
jsexec(45,""dj.module.emailSignUp.init"",function(){dj.module.emailSignUp.init();}); 
jsexec(46,""dj.module.article.tickerBasedArticleModule.init"",function(){dj.module.article.tickerBasedArticleModule.init({'moduleType':'ticker_chart_based_module','articleId':AT_VARS.baseDocId,'renderChart' : true,'chartDivId':'chartContainer'});}); 
jsexec(47,""dojo.query"",function(){dojo.query('div[data-cb-ad-id]').forEach(function(tag,i){if(tag.id.match(/^ad0_0.*[GA][\d]*$/) != null){ dojo.attr(tag.id, ""data-cb-ad-id"", ""adTop"")} else if(tag.id.match(/^ad0_0.*[C][\d]*$/) != null){ dojo.attr(tag.id, ""data-cb-ad-id"", ""adCirc"")} else if(tag.id.match(/^ad0_0.*[B]$/) != null){ dojo.attr(tag.id, ""data-cb-ad-id"", ""adBH"")} else if(tag.id.match(/^ad0_0.*[Z]$/) != null){ dojo.attr(tag.id, ""data-cb-ad-id"", ""adZ"")} else if(tag.id.match(/^adEmailCircAd.*[\d]*$/) != null){ dojo.attr(tag.id, ""data-cb-ad-id"", ""adEM"")};});}); 
jsexec(48,""dj.context.hummingbird2Enabled"",function(){dj.context.hummingbird2Enabled = (function(){ if (dj.module.hummingbird2) { return dj.lang.connect(window, ""onload"", dj.module.hummingbird2, ""onPageLoad""); } }());}); 
jsexec(49,""var"",function(){var c = dj.util.Cookie, g = dj.module.geotargeting.germanyScrim; if (""asia"" == c.getCookie(""wsjregion"") && navigator.userAgent.match(/iPad/i) && dj.util.Cookie.getCookie(""iPadScrimAPAC"") != ""true"") {dj.util.User.isSubLoggedIn(function(loggedIn){if(!loggedIn){  g.findLanguage = function() {  g.cfx.browserLanguage = 'de';   };dj.util.Cookie.setCookie(""iPadScrimAPAC"", ""true"", 0);   g.init({  countries:[ c.getGroupCookie(""DJSESSION"", ""country"") ]  }); } } ) }}); 
jsexec(50,""dj.module.saveToLazyLoad"",function(){dj.module.saveToLazyLoad = dj.util.io.lazyLoad("".dropdownTree"", ""mouseover"", ""djscript.j_dashboard"", function() {  dj.module.dashboard.DashboardSaveTo = new dj.widget.dashboard.DashboardSaveTo(""mjFolderList"",{mjSaveToWidgetInstance: ""MyJournalDetails"",""mjSiteWideDock"":""true""});});}); 
jsexec(51,""dojo.connect"",function(){dojo.connect(window, ""onload"", dj.module.vlttools.animations.init({articleResizeContainer:""#articleBodyTools"",leftSaveToContainer:""#atl_mjsave_container"",SaveToAnchors:"".mjQuickSave"",socialNetworksJS:[{'name' : 'twitter', 'jsurl' : '//platform.twitter.com/widgets.js', 'jsid' : 'twitter-wsj'},{'name' : 'linkedin', 'jsurl' : '//platform.linkedin.com/in.js', 'jsid' : 'linkedin-jssdk'}],topSocialTemplates:[{'template' : '<fb:like href=""{{url}}"" send=""false"" layout=""button_count"" width=""500"" show_faces=""false"" action=""recommend""></fb:like>'},{'template' : '<a href=""https://twitter.com/share"" data-text=""{{title}}"" data-counturl=""{{url}}"" data-url=""{{shortUrl}}"" class=""twitter-share-button"" data-via=""WSJ"" data-related=""WSJ"" data-lang=""en"">Tweet</a>'},{'template' : '<script type=""IN/Share"" data-url=""{{url}}"" data-counter=""right""><\/script>','templatetype':'IN/Share'}],bottomSocialTemplates:[{'template' : '<fb:like href=""{{url}}"" send=""false"" layout=""button_count"" width=""500"" show_faces=""false"" action=""recommend""></fb:like>'},{'template' : '<a href=""https://twitter.com/share"" data-text=""{{title}}"" data-counturl=""{{url}}"" data-url=""{{shortUrl}}"" class=""twitter-share-button"" data-via=""WSJ"" data-related=""WSJ"" data-lang=""en"">Tweet</a>'},{'template' : '<script type=""IN/Share"" data-url=""{{url}}"" data-counter=""right""><\/script>','templatetype':'IN/Share'}],leftSocialTemplates:[{'template' : '<fb:like href=""{{url}}"" send=""false"" layout=""button_count"" width=""500"" show_faces=""false"" action=""recommend""></fb:like>'},{'template' : '<a href=""https://twitter.com/share"" data-text=""{{title}}"" data-counturl=""{{url}}"" data-url=""{{shortUrl}}"" class=""twitter-share-button"" data-via=""WSJ"" data-related=""WSJ"" data-lang=""en"">Tweet</a>'},{'template' : '<script type=""IN/Share"" data-url=""{{url}}"" data-counter=""right""><\/script>','templatetype':'IN/Share'}]}));}); 
jsexec(52,""if"",function(){if (dojo.getObject(""dj.module.video.liveMicroPlayer"", true).init) { dj.module.video.liveMicroPlayer.init(); }}); 
jsexec(53,""var"",function(){var moreNode = dojo.byId(""MoreIndustries_Container"");if (moreNode) { dj.module.moreIndustries = new dj.widget.panel.SelectDropdownPanel(moreNode);}}); 
jsexec(54,""if"",function(){if (dojo.getObject(""dj.module.panels.liveSlideshow"", true).init) { dj.module.panels.liveSlideshow.init(); }}); 
jsexec(55,""dj.context.article.fullArticle"",function(){dj.context.article.fullArticle=true;dj.module.chartbeat.init();if(dojo.byId('articleTabs_tab_article')){dojo.connect(dojo.byId('articleTabs_tab_article'),'onclick',function(){blueKai.blueKai.bk_track(true);})}if(dojo.byId('articleTabs_tab_video')){dojo.connect(dojo.byId('articleTabs_tab_video'),'onclick',function(){blueKai.blueKai.bk_track(true);})}if(dojo.byId('articleTabs_tab_slideshow')){dojo.connect(dojo.byId('articleTabs_tab_slideshow'),'onclick',function(){blueKai.blueKai.bk_track(true);})}if(dojo.byId('articleTabs_tab_interactive')){dojo.connect(dojo.byId('articleTabs_tab_interactive'),'onclick',function(){blueKai.blueKai.bk_track(true);})}if(dojo.byId('articleTabs_tab_comments')){dojo.connect(dojo.byId('articleTabs_tab_comments'),'onclick',function(){blueKai.blueKai.bk_track(true);})}if(dojo.byId('articleTabs_tab_quotes')){dojo.connect(dojo.byId('articleTabs_tab_quotes'),'onclick',function(){blueKai.blueKai.bk_track(true);})}}); 
jsexec(56,""dj.module.header2012.autocomplete.searchExec"",function(){dj.module.header2012.autocomplete.searchExec();}); 
jsexec(57,""if"",function(){if (dojo.getObject(""dj.util.flash.template"", true).scan) { dj.util.flash.template.scan(); } if (dojo.getObject(""dj.util.onVisibleWidget"", true).scan) {dj.util.onVisibleWidget.scan();} if (dojo.getObject(""dj.util.onVisibleImg"", true).scan) {dj.util.onVisibleImg.scan(); }}); 
jsexec(58,""var"",function(){var leftvalettools=dojo.byId(""valetTools-left"");if (dj.module.articleTabs.panels.getActivePanel() == ""video"" || dj.module.articleTabs.panels.getActivePanel() == ""slideshow"") {dojo.style(leftvalettools,""display"",""none"");}dojo.query(""#articleTabs li"").forEach(function(a){dojo.connect(a,""onclick"",function(b){dojo.stopEvent(b);if(a.id==""articleTabs_tab_video""||a.id==""articleTabs_tab_slideshow""){dojo.style(leftvalettools,""display"",""none"");}else{dojo.style(leftvalettools,""display"",""block"");}})})}); 
jsexec(59,""dj.widget.ad.AdManager.createAd"",function(){dj.widget.ad.AdManager.createAd('headerPromoContainer','iframe' , {width: 377, height: 50,size:'377x50', site:'interactive.wsj.com', zone:'news_politicspolicy_story',adClass:'M', meta:'',metazone:'',category:'',frequency:'',cacheId:'',classEnabled:'true',classValue:'promo',styleValue:'',conditionType:'',conditionValue:'',conditionalString:''})}); 
jsexec(60,""dj.util.Ads"",function(){new dj.util.Ads().registerAd('printmode','printModeAd;iframe;?width=728;height=90;size=728x90;zone=printer;site=interactive.wsj.com;adclass=A;meta=;metazone=;category=;frequency=;cacheId=;classEnabled=true;classValue=adSummary ad_728 pfAdvertisement;styleValue=;conditionType=;conditionValue=;conditionalString=')}); 
jsexec(61,""dj.util.Ads"",function(){new dj.util.Ads().registerAd('email','adEmailCircAdE;iframe;?width=571;height=47;size=571x47;zone=default;site=interactive.wsj.com;adclass=A;meta=;metazone=;category=;frequency=;cacheId=;classEnabled=true;classValue=adSummary ad-freePass;styleValue=;conditionType=;conditionValue=;conditionalString=')}); 
jsexec(62,""dj.util.Ads"",function(){new dj.util.Ads().registerAd('article','bottomBigAd;iframe;?width=571;height=208;size=571x208;zone=snippet_free_pass;site=interactive.wsj.com;adclass=M;meta=;metazone=;category=;frequency=;cacheId=;classEnabled=true;classValue=adSummary;styleValue=;conditionType=;conditionValue=;conditionalString=')}); 
jsexec(63,""dj.util.Ads"",function(){new dj.util.Ads().registerAd('magicmodule','magic_module;iframe;?width=377;height=38;size=377x38;zone=magicmodule;site=interactive.wsj.com;adclass=A;meta=;metazone=;category=;frequency=;cacheId=;classEnabled=true;classValue=adSummary;styleValue=;conditionType=;conditionValue=;conditionalString=')}); 
jsexec(64,""dj.util.Ads"",function(){new dj.util.Ads().registerAd('article','editorsPicks_article;iframe;?width=180;height=150;size=180x150;zone=news_politicspolicy_story;site=interactive.wsj.com;adclass=A;meta=;metazone=;category=;frequency=;cacheId=;classEnabled=False;classValue=adSummary;styleValue=;conditionType=;conditionValue=;conditionalString=')}); 
jsexec(65,""dj.util.Ads"",function(){new dj.util.Ads().registerAd('interactive','ad0_0_WA_0001L_interactive;iframe;?width=728;height=90;size=728x90;zone=news_politicspolicy_story;site=interactive.wsj.com;adclass=A;meta=;metazone=;category=;frequency=;cacheId=;classEnabled=true;classValue=adSummary ad_728;styleValue=;conditionType=;conditionValue=;conditionalString=')}); 
jsexec(66,""dj.util.Ads"",function(){new dj.util.Ads().registerAd('comments','editorsPicks_comments;iframe;?width=180;height=150;size=180x150;zone=news_politicspolicy_story;site=interactive.wsj.com;adclass=A;meta=;metazone=;category=;frequency=;cacheId=;classEnabled=False;classValue=adSummary;styleValue=;conditionType=;conditionValue=;conditionalString=')}); 
jsexec(67,""dj.module.article.snippet.copyAndMove"",function(){dj.module.article.snippet.copyAndMove({articleAdSelector:""#bottomBigAd"", overThreshold: 1});}); 
jsexec(68,""dj.module.uberHat"",function(){dj.module.uberHat = new dj.widget.uberHat.UberHat({""divExists"":true}); dj.module.survey = new dj.widget.survey.SurveyPopup({""url"":""http://survey.confirmit.com/wix/p913069351.aspx"", ""width"":550, ""height"":525, ""cookieName"":""cambriaSurvey"", ""windowName"":""cambriaSurvey"", ""userHasRole"":""CAMBRIA"", ""enableInterval"":""60s+"", ""noRepeatInterval"":""90d+"",""frequencyPercent"":100});dj.module.survey = new dj.widget.survey.SurveyPopup({""url"":""http://survey.confirmit.com/wix1/p944166011.aspx"", ""width"":550, ""height"":525, ""cookieName"":""hyattSurvey"", ""windowName"":""hyattSurvey"", ""userHasRole"":""HYATT"", ""enableInterval"":""60s+"", ""noRepeatInterval"":""90d+"",""frequencyPercent"":100});}); 
jsexec(69,""djPerf.measure"",function(){djPerf.measure('JSEXEC: top-to-9');djPerf.measure('JSEXEC: 0-to-9');try{ var NR = dojo.byId('newsreeliframe'); var outerElem = dojo.query('.contentwide .reallywide'); if(outerElem) { dojo.destroy('newsreeliframe');var textValue = NR.innerHTML;if(dojo.query('.wsjSubnav').length == 0) {dojo.addClass(dojo.query('.mainHeader')[0], 'navLayout-mainOnly');}var newItem = dojo.create(""div"", {     ""class"" : ""newsreelC"",     ""style"" : ""height: 105px; min-height: inherit;"",""id"":""newsreeliframe"",innerHTML : textValue }, outerElem[0], ""first"");  }  }catch(exp){}}); 
jsexec(70,""blueKai.blueKai.bk_track"",function(){blueKai.blueKai.bk_track(true);}); 
jsexec(71,""if"",function(){if(dj.util.Cookie.getCookie(""djmcn"")===""true"" && djcs.UserInfo.getGroup()===""DJN"" && dojo.doc.URL.indexOf(""#printMode"")===-1){ dojo.create(""script"",{""src"":""https://chat.wsj.com/chatMinimizedPopoutLink.js"",type:""text/javascript""},dojo.query(""body"")[0]);}}); 
jsexec(72,""if"",function(){if(document.location.hash.indexOf(""printMode"") == 1){new dj.util.Ads().loadAds(""printmode"");}}); 
jsexec(73,""if"",function(){if(document.location.href.indexOf('article_email')>0){dj.util.User.isSubLoggedIn(function(subLoggedIn) {if (!subLoggedIn) {dj.widget.ad.AdManager.loadAds(""email"");}});}}); 
jsexec(74,""linksmart.init"",function(){linksmart.init();}); 
jsexec(75,""dojo.query"",function(){dojo.query('.boxlink.boxlink-bubble.boxlink-first')[0].href=dojo.query('.boxlink.boxlink-bubble.boxlink-first')[0].href + '?mod=WSJ_article_comments#articleTabs%3Dcomments';}); 
jsexec(76,""dj.util.Ads"",function(){new dj.util.Ads().registerAd('article','ad0_0_WA_0001A;JS;?width=300;height=600;size=336x280,300x250,336x850,300x600,300x1050;zone=news_politicspolicy_story;site=interactive.wsj.com;adclass=G;meta=;metazone=;category=;frequency=;cacheId=;classEnabled=true;classValue=adSummary advertisement;styleValue=;conditionType=;conditionValue=;conditionalString=')}); 
jsexec(77,""dj.util.User.isSubLoggedIn"",function(){dj.util.User.isSubLoggedIn( function(loggedIn) {if ((!loggedIn && typeof isReferrerArticleFree != ""undefined"" && isReferrerArticleFree) || (!loggedIn && typeof isReferrerArticleFree != ""undefined"" && !isReferrerArticleFree && typeof isTrial != ""undefined"" && isTrial.toLowerCase() == ""true"" && document.referrer)) { paidContent=dojo.byId(""snippet_hp_tbnl"");dojo.removeClass(paidContent,""hidden"");}});}); 
jsexec(78,""dj.util.Ads"",function(){new dj.util.Ads().loadAds('magicmodule',{ordrecalculate:1});}); 
jsexec(79,""dj.util.Ads"",function(){new dj.util.Ads().registerAd('article','ad0_0_WA_0001G;JS;?width=300;height=250;size=336x280,300x250;zone=news_politicspolicy_story;site=bottom.interactive.wsj.com;adclass=A;meta=;metazone=;category=;frequency=;cacheId=;classEnabled=true;classValue=adSummary advertisement;styleValue=;conditionType=;conditionValue=;conditionalString=')}); 
jsexec(80,""dj.widget.ad.AdManager.infocusAd"",function(){new dj.widget.ad.AdManager.infocusAd(""infocus"", ""ad0_0_WA_0001Z"", false);}); 
jsexec(81,""dj.module.articleTextTab.playbookmark"",function(){dj.module.articleTextTab.playbookmark();}); 
jsexec(82,""dj.module.interactivePlayer.playbookmark"",function(){dj.module.interactivePlayer.playbookmark();}); 
jsexec(83,""dj.util.Ads"",function(){new dj.util.Ads().registerAd('comments','ad0_0_WA_0001A25597;JS;?width=300;height=600;size=300x250,336x280,300x600,336x850;zone=news_politicspolicy_story;site=interactive.wsj.com;adclass=A;meta=;metazone=;category=;frequency=;cacheId=;classEnabled=true;classValue=adSummary articleAd;styleValue=;conditionType=;conditionValue=;conditionalString=')}); 
jsexec(84,""dj.util.Ads"",function(){new dj.util.Ads().registerAd('comments','ad0_0_WA_0001L_comment;JS;?width=300;height=250;size=336x280,300x250;zone=news_politicspolicy_story;site=bottom.interactive.wsj.com;adclass=A;meta=;metazone=;category=;frequency=;cacheId=;classEnabled=true;classValue=adSummary advertisement;styleValue=;conditionType=;conditionValue=;conditionalString=')}); 
jsexec(85,""dj.module.articleCommentsTab.playbookmark"",function(){dj.module.articleCommentsTab.playbookmark();}); 
jsexec(86,""var"",function(){var beg=(new Date).getTime(),itv=setInterval(function(){dj.util.User.isLoggedIn(function(a){if(a){var b=dojo.query(""a.md_index""),c,d;for(c=0,d=b.length;c<d;c++){if(b[c].href.indexOf(""/index/SP%20500%20Futures"")!==-1){b[c].href=""/mdc/public/page/2_3028.html?category=Index&subcategory=U.S.&contract=SP%2520500%2520-%2520Mini%2520-%2520cme&catandsubcat=Index%257CU.S.&contractset=SP%2520500%2520Mini%2520-%2520cme"";console.log(c);clearInterval(itv);break}}if((new Date).getTime()-beg>15e3){clearInterval(itv)}}else{clearInterval(itv)}})},1e3)}); 

//------------------------------
console.info(""[ end jsexec ]"");
console.groupEnd();

/* ]]> */
</script>
</body>
</html>
";
            }
        }
    }
}
