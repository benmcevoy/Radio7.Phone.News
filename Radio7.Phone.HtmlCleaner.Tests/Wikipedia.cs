using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Radio7.Phone.HtmlCleaner.Tests
{
    class Wikipedia
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
<html lang=""en"" dir=""ltr"" class=""client-nojs"">
<head>
<meta charset=""UTF-8"" /><title>T.R. Baskin - Wikipedia, the free encyclopedia</title>
<meta name=""generator"" content=""MediaWiki 1.22wmf7"" />
<link rel=""alternate"" type=""application/x-wiki"" title=""Edit this page"" href=""/w/index.php?title=T.R._Baskin&amp;action=edit"" />
<link rel=""edit"" title=""Edit this page"" href=""/w/index.php?title=T.R._Baskin&amp;action=edit"" />
<link rel=""shortcut icon"" href=""//bits.wikimedia.org/favicon/wikipedia.ico"" />
<link rel=""search"" type=""application/opensearchdescription+xml"" href=""/w/opensearch_desc.php"" title=""Wikipedia (en)"" />
<link rel=""EditURI"" type=""application/rsd+xml"" href=""//en.wikipedia.org/w/api.php?action=rsd"" />
<link rel=""copyright"" href=""//creativecommons.org/licenses/by-sa/3.0/"" />
<link rel=""alternate"" type=""application/atom+xml"" title=""Wikipedia Atom feed"" href=""/w/index.php?title=Special:RecentChanges&amp;feed=atom"" />
<link rel=""stylesheet"" href=""//bits.wikimedia.org/en.wikipedia.org/load.php?debug=false&amp;lang=en&amp;modules=ext.gadget.DRN-wizard%2CReferenceTooltips%2Ccharinsert%2Cteahouse%7Cext.rtlcite%2Cwikihiero%7Cmediawiki.legacy.commonPrint%2Cshared%7Cmw.PopUpMediaTransform%7Cskins.vector&amp;only=styles&amp;skin=vector&amp;*"" />
<meta name=""ResourceLoaderDynamicStyles"" content="""" />
<link rel=""stylesheet"" href=""//bits.wikimedia.org/en.wikipedia.org/load.php?debug=false&amp;lang=en&amp;modules=site&amp;only=styles&amp;skin=vector&amp;*"" />
<style>a:lang(ar),a:lang(ckb),a:lang(fa),a:lang(kk-arab),a:lang(mzn),a:lang(ps),a:lang(ur){text-decoration:none}
/* cache key: enwiki:resourceloader:filter:minify-css:7:d11e4771671c2d6cdedf7c90d8131cd5 */</style>

<script src=""//bits.wikimedia.org/en.wikipedia.org/load.php?debug=false&amp;lang=en&amp;modules=startup&amp;only=scripts&amp;skin=vector&amp;*""></script>
<script>if(window.mw){
mw.config.set({""wgCanonicalNamespace"":"""",""wgCanonicalSpecialPageName"":false,""wgNamespaceNumber"":0,""wgPageName"":""T.R._Baskin"",""wgTitle"":""T.R. Baskin"",""wgCurRevisionId"":448055576,""wgArticleId"":22526132,""wgIsArticle"":true,""wgAction"":""view"",""wgUserName"":null,""wgUserGroups"":[""*""],""wgCategories"":[""English-language films"",""1971 films"",""American romantic drama films"",""1970s drama films"",""Films set in Chicago, Illinois"",""Films shot in Chicago, Illinois"",""Films directed by Herbert Ross"",""Paramount Pictures films""],""wgBreakFrames"":false,""wgPageContentLanguage"":""en"",""wgPageContentModel"":""wikitext"",""wgSeparatorTransformTable"":["""",""""],""wgDigitTransformTable"":["""",""""],""wgDefaultDateFormat"":""dmy"",""wgMonthNames"":["""",""January"",""February"",""March"",""April"",""May"",""June"",""July"",""August"",""September"",""October"",""November"",""December""],""wgMonthNamesShort"":["""",""Jan"",""Feb"",""Mar"",""Apr"",""May"",""Jun"",""Jul"",""Aug"",""Sep"",""Oct"",""Nov"",""Dec""],""wgRelevantPageName"":""T.R._Baskin"",""wgRestrictionEdit"":[],""wgRestrictionMove"":[],""wgVectorEnabledModules"":{""collapsiblenav"":true,""collapsibletabs"":true,""expandablesearch"":false,""footercleanup"":true,""sectioneditlinks"":false,""experiments"":true},""wgWikiEditorEnabledModules"":{""toolbar"":true,""dialogs"":true,""hidesig"":true,""templateEditor"":false,""templates"":false,""preview"":false,""previewDialog"":false,""publish"":false,""toc"":false},""wgArticleFeedbackv5Permissions"":{""aft-reader"":true,""aft-member"":false,""aft-editor"":false,""aft-monitor"":false,""aft-administrator"":false,""aft-oversighter"":false,""aft-noone"":false},""wgVisualEditor"":{""isPageWatched"":false,""pageLanguageCode"":""en"",""pageLanguageDir"":""ltr"",""magnifyClipIconURL"":""//bits.wikimedia.org/static-1.22wmf7/skins/common/images/magnify-clip.png""},""wikilove-recipient"":"""",""wikilove-anon"":0,""wgGuidedTourHelpGuiderUrl"":""Help:Guided tours/guider"",""wgFlaggedRevsParams"":{""tags"":{""status"":{""levels"":1,""quality"":2,""pristine"":3}}},""wgStableRevisionId"":null,""wgCategoryTreePageCategoryOptions"":""{\""mode\"":0,\""hideprefix\"":20,\""showcount\"":true,\""namespaces\"":false}"",""Geo"":{""city"":"""",""country"":""""},""wgNoticeProject"":""wikipedia"",""aftv5Article"":{""id"":22526132,""title"":""T.R. Baskin"",""namespace"":0,""categories"":[""1970s drama films"",""1971 films"",""American romantic drama films"",""English-language films"",""Films directed by Herbert Ross"",""Films set in Chicago, Illinois"",""Films shot in Chicago, Illinois"",""Paramount Pictures films""],""permissionLevel"":false}});
}</script><script>if(window.mw){
mw.loader.implement(""user.options"",function(){mw.user.options.set({""ccmeonemails"":0,""cols"":80,""date"":""default"",""diffonly"":0,""disablemail"":0,""disablesuggest"":0,""editfont"":""default"",""editondblclick"":0,""editsection"":1,""editsectiononrightclick"":0,""enotifminoredits"":0,""enotifrevealaddr"":0,""enotifusertalkpages"":1,""enotifwatchlistpages"":0,""extendwatchlist"":0,""fancysig"":0,""forceeditsummary"":0,""gender"":""unknown"",""hideminor"":0,""hidepatrolled"":0,""imagesize"":2,""justify"":0,""math"":0,""minordefault"":0,""newpageshidepatrolled"":0,""nocache"":0,""noconvertlink"":0,""norollbackdiff"":0,""numberheadings"":0,""previewonfirst"":0,""previewontop"":1,""rcdays"":7,""rclimit"":50,""rememberpassword"":0,""rows"":25,""searchlimit"":20,""showhiddencats"":false,""showjumplinks"":1,""shownumberswatching"":1,""showtoc"":1,""showtoolbar"":1,""skin"":""vector"",""stubthreshold"":0,""thumbsize"":4,""underline"":2,""uselivepreview"":0,""usenewrc"":0,""watchcreations"":1,""watchdefault"":0,""watchdeletion"":0,""watchlistdays"":3,""watchlisthideanons"":0,""watchlisthidebots"":0,
""watchlisthideliu"":0,""watchlisthideminor"":0,""watchlisthideown"":0,""watchlisthidepatrolled"":0,""watchmoves"":0,""wllimit"":250,""useeditwarning"":1,""flaggedrevssimpleui"":1,""flaggedrevsstable"":0,""flaggedrevseditdiffs"":true,""flaggedrevsviewdiffs"":false,""vector-simplesearch"":1,""vector-collapsiblenav"":1,""usebetatoolbar"":1,""usebetatoolbar-cgd"":1,""aftv5-last-filter"":null,""wikilove-enabled"":1,""echo-subscriptions-web-page-review"":true,""echo-subscriptions-email-page-review"":false,""ep_showtoplink"":false,""ep_bulkdelorgs"":false,""ep_bulkdelcourses"":true,""ep_showdyk"":true,""echo-notify-show-link"":true,""echo-show-alert"":true,""echo-email-frequency"":0,""echo-subscriptions-email-system"":true,""echo-subscriptions-web-system"":true,""echo-subscriptions-email-other"":false,""echo-subscriptions-web-other"":true,""echo-subscriptions-email-edit-user-talk"":false,""echo-subscriptions-web-edit-user-talk"":true,""echo-subscriptions-email-reverted"":false,""echo-subscriptions-web-reverted"":true,""echo-subscriptions-email-article-linked""
:false,""echo-subscriptions-web-article-linked"":false,""echo-subscriptions-email-mention"":false,""echo-subscriptions-web-mention"":true,""echo-subscriptions-web-edit-thank"":true,""echo-subscriptions-email-edit-thank"":false,""gettingstarted-task-toolbar-show-intro"":true,""variant"":""en"",""language"":""en"",""searchNs0"":true,""searchNs1"":false,""searchNs2"":false,""searchNs3"":false,""searchNs4"":false,""searchNs5"":false,""searchNs6"":false,""searchNs7"":false,""searchNs8"":false,""searchNs9"":false,""searchNs10"":false,""searchNs11"":false,""searchNs12"":false,""searchNs13"":false,""searchNs14"":false,""searchNs15"":false,""searchNs100"":false,""searchNs101"":false,""searchNs108"":false,""searchNs109"":false,""searchNs446"":false,""searchNs447"":false,""searchNs710"":false,""searchNs711"":false,""searchNs828"":false,""searchNs829"":false,""gadget-teahouse"":1,""gadget-ReferenceTooltips"":1,""gadget-HotCat"":1,""gadget-DRN-wizard"":1,""gadget-charinsert"":1,""gadget-mySandbox"":1});},{},{});mw.loader.implement(""user.tokens"",function(){mw.user.tokens.set({
""editToken"":""+\\"",""patrolToken"":false,""watchToken"":false});},{},{});
/* cache key: enwiki:resourceloader:filter:minify-js:7:dfcc81ff84c4acc2d38da93d9c33871c */
}</script>
<script>if(window.mw){
mw.loader.load([""mediawiki.page.startup"",""mediawiki.legacy.wikibits"",""mediawiki.legacy.ajax"",""ext.vector.footerCleanup"",""ext.wikimediaShopLink.core"",""wikibase.client.init"",""wikibase.client.nolanglinks"",""ext.centralNotice.bannerController""]);
}</script>
<script src=""//bits.wikimedia.org/geoiplookup""></script><link rel=""dns-prefetch"" href=""//meta.wikimedia.org"" /><!--[if lt IE 7]><style type=""text/css"">body{behavior:url(""/w/static-1.22wmf7/skins/vector/csshover.min.htc"")}</style><![endif]--></head>
<body class=""mediawiki ltr sitedir-ltr ns-0 ns-subject page-T_R_Baskin skin-vector action-view vector-animateLayout"">
		<div id=""mw-page-base"" class=""noprint""></div>
		<div id=""mw-head-base"" class=""noprint""></div>
		<div id=""content"" class=""mw-body"" role=""main"">
			<a id=""top""></a>
			<div id=""mw-js-message"" style=""display:none;""></div>
						<div id=""siteNotice""><!-- CentralNotice --></div>
						<h1 id=""firstHeading"" class=""firstHeading"" lang=""en""><span dir=""auto""><i>T.R. Baskin</i></span></h1>
			<div id=""bodyContent"">
								<div id=""siteSub"">From Wikipedia, the free encyclopedia</div>
								<div id=""contentSub""></div>
																<div id=""jump-to-nav"" class=""mw-jump"">
					Jump to:					<a href=""#mw-navigation"">navigation</a>, 					<a href=""#p-search"">search</a>
				</div>
								<div id=""mw-content-text"" lang=""en"" dir=""ltr"" class=""mw-content-ltr""><table class=""infobox vevent"" cellspacing=""3"" style=""border-spacing:3px;width:22em;font-size: 90%;;"">
<tr>
<th colspan=""2"" class=""summary"" style=""text-align:center;font-size:125%;font-weight:bold;font-size: 110%; font-style: italic;"">T.R. Baskin</th>
</tr>
<tr>
<td colspan=""2"" style=""text-align:center;""><a href=""/wiki/File:BaskinPoster.JPG"" class=""image""><img alt=""BaskinPoster.JPG"" src=""//upload.wikimedia.org/wikipedia/en/thumb/b/b6/BaskinPoster.JPG/220px-BaskinPoster.JPG"" width=""220"" height=""329"" srcset=""//upload.wikimedia.org/wikipedia/en/b/b6/BaskinPoster.JPG 1.5x, //upload.wikimedia.org/wikipedia/en/b/b6/BaskinPoster.JPG 2x"" /></a><br />
<span style=""font-size: 95%; line-height: 1.5em;"">Original poster</span></td>
</tr>
<tr>
<th scope=""row"" style=""text-align:left;white-space: nowrap;;"">Directed by</th>
<td><a href=""/wiki/Herbert_Ross"" title=""Herbert Ross"">Herbert Ross</a></td>
</tr>
<tr>
<th scope=""row"" style=""text-align:left;white-space: nowrap;;"">Produced by</th>
<td><a href=""/wiki/Peter_Hyams"" title=""Peter Hyams"">Peter Hyams</a></td>
</tr>
<tr>
<th scope=""row"" style=""text-align:left;white-space: nowrap;;"">Written by</th>
<td>Peter Hyams</td>
</tr>
<tr>
<th scope=""row"" style=""text-align:left;white-space: nowrap;;"">Starring</th>
<td><a href=""/wiki/Candice_Bergen"" title=""Candice Bergen"">Candice Bergen</a><br />
<a href=""/wiki/Peter_Boyle"" title=""Peter Boyle"">Peter Boyle</a><br />
<a href=""/wiki/James_Caan_(actor)"" title=""James Caan (actor)"" class=""mw-redirect"">James Caan</a></td>
</tr>
<tr>
<th scope=""row"" style=""text-align:left;white-space: nowrap;;"">Music by</th>
<td><a href=""/wiki/Jack_Elliott_(composer)"" title=""Jack Elliott (composer)"">Jack Elliott</a></td>
</tr>
<tr>
<th scope=""row"" style=""text-align:left;white-space: nowrap;;"">Cinematography</th>
<td>Gerald Hirschfeld</td>
</tr>
<tr>
<th scope=""row"" style=""text-align:left;white-space: nowrap;;"">Editing by</th>
<td>Maury Winetrobe</td>
</tr>
<tr>
<th scope=""row"" style=""text-align:left;white-space: nowrap;;"">Distributed by</th>
<td><a href=""/wiki/Paramount_Pictures"" title=""Paramount Pictures"">Paramount Pictures</a></td>
</tr>
<tr>
<th scope=""row"" style=""text-align:left;white-space: nowrap;;"">Release date(s)</th>
<td>October 20, 1971</td>
</tr>
<tr>
<th scope=""row"" style=""text-align:left;white-space: nowrap;;"">Running time</th>
<td>90 minutes</td>
</tr>
<tr>
<th scope=""row"" style=""text-align:left;white-space: nowrap;;"">Country</th>
<td>United States</td>
</tr>
<tr>
<th scope=""row"" style=""text-align:left;white-space: nowrap;;"">Language</th>
<td>English</td>
</tr>
</table>
<p><i><b>T.R. Baskin</b></i> is a <a href=""/wiki/1971_in_film"" title=""1971 in film"">1971</a> <a href=""/wiki/Cinema_of_the_United_States"" title=""Cinema of the United States"">American</a> <a href=""/wiki/Drama_film"" title=""Drama film"">drama film</a> directed by <a href=""/wiki/Herbert_Ross"" title=""Herbert Ross"">Herbert Ross</a>. It stars <a href=""/wiki/Candice_Bergen"" title=""Candice Bergen"">Candice Bergen</a>, <a href=""/wiki/Peter_Boyle"" title=""Peter Boyle"">Peter Boyle</a>, <a href=""/wiki/Marcia_Rodd"" title=""Marcia Rodd"">Marcia Rodd</a> and <a href=""/wiki/James_Caan"" title=""James Caan"">James Caan</a>.</p>
<p>The screenplay by <a href=""/wiki/Peter_Hyams"" title=""Peter Hyams"">Peter Hyams</a> focuses on a naïve young woman who moves to <a href=""/wiki/Chicago"" title=""Chicago"">Chicago</a> with the hope of finding romance and a fulfilling career.</p>
<p>The film was released as <i>A Date with a Lonely Girl</i> in the <a href=""/wiki/United_Kingdom"" title=""United Kingdom"">United Kingdom</a>.</p>
<table id=""toc"" class=""toc"">
<tr>
<td>
<div id=""toctitle"">
<h2>Contents</h2>
</div>
<ul>
<li class=""toclevel-1 tocsection-1""><a href=""#Plot""><span class=""tocnumber"">1</span> <span class=""toctext"">Plot</span></a></li>
<li class=""toclevel-1 tocsection-2""><a href=""#Production""><span class=""tocnumber"">2</span> <span class=""toctext"">Production</span></a></li>
<li class=""toclevel-1 tocsection-3""><a href=""#Cast""><span class=""tocnumber"">3</span> <span class=""toctext"">Cast</span></a></li>
<li class=""toclevel-1 tocsection-4""><a href=""#Critical_response""><span class=""tocnumber"">4</span> <span class=""toctext"">Critical response</span></a></li>
<li class=""toclevel-1 tocsection-5""><a href=""#References""><span class=""tocnumber"">5</span> <span class=""toctext"">References</span></a></li>
<li class=""toclevel-1 tocsection-6""><a href=""#External_links""><span class=""tocnumber"">6</span> <span class=""toctext"">External links</span></a></li>
</ul>
</td>
</tr>
</table>
<h2><span class=""mw-headline"" id=""Plot"">Plot</span><span class=""mw-editsection"">[<a href=""/w/index.php?title=T.R._Baskin&amp;action=edit&amp;section=1"" title=""Edit section: Plot"">edit</a>]</span></h2>
<p>When Jack Mitchell, a lonely, middle-aged salesman from <a href=""/wiki/Utica,_New_York"" title=""Utica, New York"">Utica, New York</a>, meets his old <a href=""/wiki/Fraternity"" title=""Fraternity"">fraternity</a> brother Larry Moore while on business in <a href=""/wiki/Chicago"" title=""Chicago"">Chicago</a>, he asks him to introduce him to a nice woman. Larry gives him T.R. Baskin's phone number, and Jack invites her to visit him at his hotel. Following an awkward silence, the two end up in bed, where T.R. begins to tell Jack about her past, a story that unfolds via <a href=""/wiki/Flashback_(narrative)"" title=""Flashback (narrative)"">flashback</a>.</p>
<p>After moving to Chicago from a small town in <a href=""/wiki/Ohio"" title=""Ohio"">Ohio</a>, T.R. is forced to rent a studio apartment in a dilapidated building in a run-down area of the city. She finds employment as a typist in a large corporation where she meets Dayle Wigoda, who arranges a blind date with her boyfriend's wealthy friend Arthur, who proves to be an obnoxious <a href=""/wiki/Bigotry"" title=""Bigotry"">bigot</a> and <a href=""/wiki/Misogyny"" title=""Misogyny"">misogynist</a>. T.R. realizes she'd rather be alone than spend time with such a callous individual.</p>
<p>One night, after leaving a noisy bar, T.R. sees Larry reading a book at the window of a café. She joins him at his table and learns he edits and publishes <a href=""/wiki/Textbook"" title=""Textbook"">textbooks</a>. The two go to his apartment and discuss their individual disappointments. Larry misses spending time with his children, while T.R. confesses she always has felt like an outsider. The two make love, and the following morning T.R. feels she finally has taken the first step towards an intimate relationship, only to discover Larry has put a $20 bill in her coat pocket. Feeling betrayed and humiliated, she rushes out. At home, T.R. calls her parents for consolation but instead receives a lecture about her decision to move to Chicago.</p>
<p>Back in the present once again, T.R. and Jack agree they're glad they met each other, and T.R. leaves the hotel, optimistically believing better days are in her future.</p>
<h2><span class=""mw-headline"" id=""Production"">Production</span><span class=""mw-editsection"">[<a href=""/w/index.php?title=T.R._Baskin&amp;action=edit&amp;section=2"" title=""Edit section: Production"">edit</a>]</span></h2>
<p>The film was shot at various Chicago locations, including the <a href=""/wiki/Carson_Pirie_Scott"" title=""Carson Pirie Scott"" class=""mw-redirect"">Carson Pirie Scott</a> department store, the Sherman House Hotel, the First National Bank Building, and O'Connell's Coffee Shop on <a href=""/wiki/Rush_Street_(Chicago)"" title=""Rush Street (Chicago)"">Rush Street</a>. <sup id=""cite_ref-1"" class=""reference""><a href=""#cite_note-1""><span>[</span>1<span>]</span></a></sup></p>
<h2><span class=""mw-headline"" id=""Cast"">Cast</span><span class=""mw-editsection"">[<a href=""/w/index.php?title=T.R._Baskin&amp;action=edit&amp;section=3"" title=""Edit section: Cast"">edit</a>]</span></h2>
<ul>
<li><a href=""/wiki/Candice_Bergen"" title=""Candice Bergen"">Candice Bergen</a> ..... T.R. Baskin</li>
<li><a href=""/wiki/Peter_Boyle"" title=""Peter Boyle"">Peter Boyle</a> ..... Jack Mitchell</li>
<li><a href=""/wiki/James_Caan_(actor)"" title=""James Caan (actor)"" class=""mw-redirect"">James Caan</a> ..... Larry Moore</li>
<li><a href=""/wiki/Marcia_Rodd"" title=""Marcia Rodd"">Marcia Rodd</a> ..... Dayle Wigoda</li>
<li><a href=""/wiki/Howard_Platt"" title=""Howard Platt"">Howard Platt</a> ..... Arthur</li>
</ul>
<h2><span class=""mw-headline"" id=""Critical_response"">Critical response</span><span class=""mw-editsection"">[<a href=""/w/index.php?title=T.R._Baskin&amp;action=edit&amp;section=4"" title=""Edit section: Critical response"">edit</a>]</span></h2>
<p><a href=""/wiki/Vincent_Canby"" title=""Vincent Canby"">Vincent Canby</a> of the <i><a href=""/wiki/New_York_Times"" title=""New York Times"" class=""mw-redirect"">New York Times</a></i> noted the title character ""is never at a loss for words, most of which sound as if they had come straight from the notebook of a writer who spent most of time jotting down funny lines without ever worrying much about character. It thus falls to Candice Bergen, a beautiful actress who projects intelligence, humor, vulnerability and self-reliance — all more or less simultaneously — to make something credible of the mouthpiece character written for her by Peter Hyams. . . . Somewhere deep inside <i>T.R. Baskin</i>, there is, I suspect, a real, touching film crying to get out with something more than a wise-crack, but neither Hyams, nor Herbert Ross, the director, have been able to find it."" <sup id=""cite_ref-2"" class=""reference""><a href=""#cite_note-2""><span>[</span>2<span>]</span></a></sup></p>
<p><a href=""/wiki/Roger_Ebert"" title=""Roger Ebert"">Roger Ebert</a> of the <i><a href=""/wiki/Chicago_Sun-Times"" title=""Chicago Sun-Times"">Chicago Sun-Times</a></i> said the film ""gets in trouble right off the bat with a flashback style that neatly drains away all of our interest in half of the story"" and added, ""The problem is that everyone in the movie acts so stupidly. Real people of average intelligence would have cut through this plot in about three minutes, and the movie would have been over. It lasts two hours only because people are at such pains not to catch on."" <sup id=""cite_ref-3"" class=""reference""><a href=""#cite_note-3""><span>[</span>3<span>]</span></a></sup></p>
<p><i><a href=""/wiki/Time_(magazine)"" title=""Time (magazine)"">Time</a></i> stated, ""Peter Boyle . . . and James Caan . . . do the best they can, which is extremely well indeed, but the movie's clumsy feints at sophistication and its grotesque sentimentality prevail."" <sup id=""cite_ref-4"" class=""reference""><a href=""#cite_note-4""><span>[</span>4<span>]</span></a></sup></p>
<p><i><a href=""/wiki/Variety_(magazine)"" title=""Variety (magazine)"">Variety</a></i> said the film ""makes a few good comedy-comments on modern urban existence, but these are bits of rare jewelry lost on a vast beach of strung-out, erratic storytelling . . . Peter Hyams' debut production is handsomely mounted, but his screenplay is sterile, superficial and inconsistent . . . Bergen's screen presence is too sophisticated for the role, and both her acting, direction and dialog result in confusion."" <sup id=""cite_ref-5"" class=""reference""><a href=""#cite_note-5""><span>[</span>5<span>]</span></a></sup></p>
<p><i><a href=""/wiki/TV_Guide"" title=""TV Guide"">TV Guide</a></i> rated the film 1½ stars and commented, ""Although she raises some interesting questions, Bergen's character evokes neither the sympathy nor the interest intended."" <sup id=""cite_ref-6"" class=""reference""><a href=""#cite_note-6""><span>[</span>6<span>]</span></a></sup></p>
<h2><span class=""mw-headline"" id=""References"">References</span><span class=""mw-editsection"">[<a href=""/w/index.php?title=T.R._Baskin&amp;action=edit&amp;section=5"" title=""Edit section: References"">edit</a>]</span></h2>
<div class=""reflist"" style=""list-style-type: decimal;"">
<ol class=""references"">
<li id=""cite_note-1""><span class=""mw-cite-backlink""><b><a href=""#cite_ref-1"">^</a></b></span> <span class=""reference-text""><a rel=""nofollow"" class=""external text"" href=""http://www.tcm.com/tcmdb/title.jsp?stid=92208&amp;category=Notes""><i>T.R. Baskin</i> at Turner Classic Movies</a></span></li>
<li id=""cite_note-2""><span class=""mw-cite-backlink""><b><a href=""#cite_ref-2"">^</a></b></span> <span class=""reference-text""><a rel=""nofollow"" class=""external text"" href=""http://movies.nytimes.com/movie/review?res=9E0DE5DF1038EF34BC4951DFB667838A669EDE""><i>New York Times</i> review</a></span></li>
<li id=""cite_note-3""><span class=""mw-cite-backlink""><b><a href=""#cite_ref-3"">^</a></b></span> <span class=""reference-text""><a rel=""nofollow"" class=""external text"" href=""http://rogerebert.suntimes.com/apps/pbcs.dll/article?AID=/19711029/REVIEWS/110290301/1023""><i>Chicago Sun-Times</i> review</a></span></li>
<li id=""cite_note-4""><span class=""mw-cite-backlink""><b><a href=""#cite_ref-4"">^</a></b></span> <span class=""reference-text""><a rel=""nofollow"" class=""external text"" href=""http://www.time.com/time/magazine/article/0,9171,905510,00.html""><i>Time</i> review</a></span></li>
<li id=""cite_note-5""><span class=""mw-cite-backlink""><b><a href=""#cite_ref-5"">^</a></b></span> <span class=""reference-text""><a rel=""nofollow"" class=""external text"" href=""http://www.variety.com/review/VE1117795863.html?categoryid=31&amp;cs=1&amp;p=0""><i>Variety</i> review</a></span></li>
<li id=""cite_note-6""><span class=""mw-cite-backlink""><b><a href=""#cite_ref-6"">^</a></b></span> <span class=""reference-text""><a rel=""nofollow"" class=""external text"" href=""http://movies.tvguide.com/tr-baskin/review/119680""><i>TV Guide</i> review</a></span></li>
</ol>
</div>
<h2><span class=""mw-headline"" id=""External_links"">External links</span><span class=""mw-editsection"">[<a href=""/w/index.php?title=T.R._Baskin&amp;action=edit&amp;section=6"" title=""Edit section: External links"">edit</a>]</span></h2>
<p><a rel=""nofollow"" class=""external text"" href=""http://www.imdb.com/title/tt0067817/""><i>T.R. Baskin</i></a> at the <a href=""/wiki/Internet_Movie_Database"" title=""Internet Movie Database"">Internet Movie Database</a></p>
<table cellspacing=""0"" class=""navbox"" style=""border-spacing:0;"">
<tr>
<td style=""padding:2px;"">
<table cellspacing=""0"" class=""nowraplinks collapsible autocollapse navbox-inner"" style=""border-spacing:0;background:transparent;color:inherit;"">
<tr>
<th scope=""col"" class=""navbox-title"" colspan=""2"">
<div class=""noprint plainlinks hlist navbar mini"">
<ul>
<li class=""nv-view""><a href=""/wiki/Template:Herbert_Ross"" title=""Template:Herbert Ross""><span title=""View this template"" style="";;background:none transparent;border:none;;"">v</span></a></li>
<li class=""nv-talk""><a href=""/wiki/Template_talk:Herbert_Ross"" title=""Template talk:Herbert Ross""><span title=""Discuss this template"" style="";;background:none transparent;border:none;;"">t</span></a></li>
<li class=""nv-edit""><a class=""external text"" href=""//en.wikipedia.org/w/index.php?title=Template:Herbert_Ross&amp;action=edit""><span title=""Edit this template"" style="";;background:none transparent;border:none;;"">e</span></a></li>
</ul>
</div>
<div style=""font-size:110%;"">Films directed by <a href=""/wiki/Herbert_Ross"" title=""Herbert Ross"">Herbert Ross</a></div>
</th>
</tr>
<tr style=""height:2px;"">
<td></td>
</tr>
<tr>
<th scope=""row"" class=""navbox-group"">1960s</th>
<td class=""navbox-list navbox-odd hlist"" style=""text-align:left;border-left-width:2px;border-left-style:solid;width:100%;padding:0px;"">
<div style=""padding:0em 0.25em;"">
<ul>
<li><i><a href=""/wiki/Goodbye,_Mr._Chips_(1969_film)"" title=""Goodbye, Mr. Chips (1969 film)"">Goodbye, Mr. Chips</a></i> (1969)</li>
</ul>
</div>
</td>
</tr>
<tr style=""height:2px;"">
<td></td>
</tr>
<tr>
<th scope=""row"" class=""navbox-group"">1970s</th>
<td class=""navbox-list navbox-even hlist"" style=""text-align:left;border-left-width:2px;border-left-style:solid;width:100%;padding:0px;"">
<div style=""padding:0em 0.25em;"">
<ul>
<li><i><a href=""/wiki/The_Owl_and_the_Pussycat_(film)"" title=""The Owl and the Pussycat (film)"">The Owl and the Pussycat</a></i> (1970)</li>
<li><i><strong class=""selflink"">T.R. Baskin</strong></i> (1971)</li>
<li><i><a href=""/wiki/Play_It_Again,_Sam_(1972_film)"" title=""Play It Again, Sam (1972 film)"">Play It Again, Sam</a></i> (1972)</li>
<li><i><a href=""/wiki/The_Last_of_Sheila"" title=""The Last of Sheila"">The Last of Sheila</a></i> (1973)</li>
<li><i><a href=""/wiki/Funny_Lady"" title=""Funny Lady"">Funny Lady</a></i> (1975)</li>
<li><i><a href=""/wiki/The_Sunshine_Boys_(film)"" title=""The Sunshine Boys (film)"">The Sunshine Boys</a></i> (1975)</li>
<li><i><a href=""/wiki/The_Seven-Per-Cent_Solution_(film)"" title=""The Seven-Per-Cent Solution (film)"">The Seven-Per-Cent Solution</a></i> (1976)</li>
<li><i><a href=""/wiki/The_Turning_Point_(1977_film)"" title=""The Turning Point (1977 film)"">The Turning Point</a></i> (1977)</li>
<li><i><a href=""/wiki/The_Goodbye_Girl"" title=""The Goodbye Girl"">The Goodbye Girl</a></i> (1977)</li>
<li><i><a href=""/wiki/California_Suite_(film)"" title=""California Suite (film)"">California Suite</a></i> (1978)</li>
</ul>
</div>
</td>
</tr>
<tr style=""height:2px;"">
<td></td>
</tr>
<tr>
<th scope=""row"" class=""navbox-group"">1980s</th>
<td class=""navbox-list navbox-odd hlist"" style=""text-align:left;border-left-width:2px;border-left-style:solid;width:100%;padding:0px;"">
<div style=""padding:0em 0.25em;"">
<ul>
<li><i><a href=""/wiki/Nijinsky_(film)"" title=""Nijinsky (film)"">Nijinsky</a></i> (1980)</li>
<li><i><a href=""/wiki/Pennies_from_Heaven_(1981_film)"" title=""Pennies from Heaven (1981 film)"">Pennies from Heaven</a></i> (1981)</li>
<li><i><a href=""/wiki/I_Ought_to_Be_in_Pictures_(film)"" title=""I Ought to Be in Pictures (film)"" class=""mw-redirect"">I Ought to Be in Pictures</a></i> (1982)</li>
<li><i><a href=""/wiki/Max_Dugan_Returns"" title=""Max Dugan Returns"">Max Dugan Returns</a></i> (1983)</li>
<li><i><a href=""/wiki/Footloose_(1984_film)"" title=""Footloose (1984 film)"">Footloose</a></i> (1984)</li>
<li><i><a href=""/wiki/Protocol_(film)"" title=""Protocol (film)"">Protocol</a></i> (1984)</li>
<li><i><a href=""/wiki/The_Secret_of_My_Success_(1987_film)"" title=""The Secret of My Success (1987 film)"">The Secret of My Success</a></i> (1987)</li>
<li><i><a href=""/wiki/Dancers_(film)"" title=""Dancers (film)"">Dancers</a></i> (1987)</li>
<li><i><a href=""/wiki/Steel_Magnolias"" title=""Steel Magnolias"">Steel Magnolias</a></i> (1989)</li>
</ul>
</div>
</td>
</tr>
<tr style=""height:2px;"">
<td></td>
</tr>
<tr>
<th scope=""row"" class=""navbox-group"">1990s</th>
<td class=""navbox-list navbox-even hlist"" style=""text-align:left;border-left-width:2px;border-left-style:solid;width:100%;padding:0px;"">
<div style=""padding:0em 0.25em;"">
<ul>
<li><i><a href=""/wiki/My_Blue_Heaven_(1990_film)"" title=""My Blue Heaven (1990 film)"">My Blue Heaven</a></i> (1990)</li>
<li><i><a href=""/wiki/True_Colors_(1991_film)"" title=""True Colors (1991 film)"">True Colors</a></i> (1991)</li>
<li><i><a href=""/wiki/Undercover_Blues"" title=""Undercover Blues"">Undercover Blues</a></i> (1993)</li>
<li><i><a href=""/wiki/Boys_on_the_Side"" title=""Boys on the Side"">Boys on the Side</a></i> (1995)</li>
</ul>
</div>
</td>
</tr>
</table>
</td>
</tr>
</table>


<!-- 
NewPP limit report
Preprocessor visited node count: 513/1000000
Preprocessor generated node count: 2608/1500000
Post‐expand include size: 15973/2048000 bytes
Template argument size: 352/2048000 bytes
Highest expansion depth: 7/40
Expensive parser function count: 2/500
Lua time usage: 0.034s
Lua memory usage: 814 KB
-->

<!-- Saved in parser cache with key enwiki:pcache:idhash:22526132-0!*!0!!en!4!* and timestamp 20130625094225 -->
</div>								<div class=""printfooter"">
				Retrieved from ""<a href=""http://en.wikipedia.org/w/index.php?title=T.R._Baskin&amp;oldid=448055576"">http://en.wikipedia.org/w/index.php?title=T.R._Baskin&amp;oldid=448055576</a>""				</div>
												<div id='catlinks' class='catlinks'><div id=""mw-normal-catlinks"" class=""mw-normal-catlinks""><a href=""/wiki/Help:Categories"" title=""Help:Categories"">Categories</a>: <ul><li><a href=""/wiki/Category:English-language_films"" title=""Category:English-language films"">English-language films</a></li><li><a href=""/wiki/Category:1971_films"" title=""Category:1971 films"">1971 films</a></li><li><a href=""/wiki/Category:American_romantic_drama_films"" title=""Category:American romantic drama films"">American romantic drama films</a></li><li><a href=""/wiki/Category:1970s_drama_films"" title=""Category:1970s drama films"">1970s drama films</a></li><li><a href=""/wiki/Category:Films_set_in_Chicago,_Illinois"" title=""Category:Films set in Chicago, Illinois"">Films set in Chicago, Illinois</a></li><li><a href=""/wiki/Category:Films_shot_in_Chicago,_Illinois"" title=""Category:Films shot in Chicago, Illinois"">Films shot in Chicago, Illinois</a></li><li><a href=""/wiki/Category:Films_directed_by_Herbert_Ross"" title=""Category:Films directed by Herbert Ross"">Films directed by Herbert Ross</a></li><li><a href=""/wiki/Category:Paramount_Pictures_films"" title=""Category:Paramount Pictures films"">Paramount Pictures films</a></li></ul></div></div>												<div class=""visualClear""></div>
							</div>
		</div>
		<div id=""mw-navigation"">
			<h2>Navigation menu</h2>
			<div id=""mw-head"">
				<div id=""p-personal"" role=""navigation"" class="""">
	<h3>Personal tools</h3>
	<ul>
<li id=""pt-createaccount""><a href=""/w/index.php?title=Special:UserLogin&amp;returnto=T.R.+Baskin&amp;type=signup"">Create account</a></li><li id=""pt-login""><a href=""/w/index.php?title=Special:UserLogin&amp;returnto=T.R.+Baskin"" title=""You are encouraged to log in; however, it is not mandatory. [o]"" accesskey=""o"">Log in</a></li>	</ul>
</div>
				<div id=""left-navigation"">
					<div id=""p-namespaces"" role=""navigation"" class=""vectorTabs"">
	<h3>Namespaces</h3>
	<ul>
					<li  id=""ca-nstab-main"" class=""selected""><span><a href=""/wiki/T.R._Baskin""  title=""View the content page [c]"" accesskey=""c"">Article</a></span></li>
					<li  id=""ca-talk""><span><a href=""/wiki/Talk:T.R._Baskin""  title=""Discussion about the content page [t]"" accesskey=""t"">Talk</a></span></li>
			</ul>
</div>
<div id=""p-variants"" role=""navigation"" class=""vectorMenu emptyPortlet"">
	<h3 id=""mw-vector-current-variant"">
		</h3>
	<h3><span>Variants</span><a href=""#""></a></h3>
	<div class=""menu"">
		<ul>
					</ul>
	</div>
</div>
				</div>
				<div id=""right-navigation"">
					<div id=""p-views"" role=""navigation"" class=""vectorTabs"">
	<h3>Views</h3>
	<ul>
					<li id=""ca-view"" class=""selected""><span><a href=""/wiki/T.R._Baskin"" >Read</a></span></li>
					<li id=""ca-edit""><span><a href=""/w/index.php?title=T.R._Baskin&amp;action=edit""  title=""You can edit this page. &#10;Please use the preview button before saving. [e]"" accesskey=""e"">Edit</a></span></li>
					<li id=""ca-history"" class=""collapsible""><span><a href=""/w/index.php?title=T.R._Baskin&amp;action=history""  title=""Past versions of this page [h]"" accesskey=""h"">View history</a></span></li>
			</ul>
</div>
<div id=""p-cactions"" role=""navigation"" class=""vectorMenu emptyPortlet"">
	<h3><span>Actions</span><a href=""#""></a></h3>
	<div class=""menu"">
		<ul>
					</ul>
	</div>
</div>
<div id=""p-search"" role=""search"">
	<h3><label for=""searchInput"">Search</label></h3>
	<form action=""/w/index.php"" id=""searchform"">
				<div id=""simpleSearch"">
						<input name=""search"" placeholder=""Search"" title=""Search Wikipedia [f]"" accesskey=""f"" id=""searchInput"" />						<button type=""submit"" name=""button"" title=""Search Wikipedia for this text"" id=""searchButton""><img src=""//bits.wikimedia.org/static-1.22wmf7/skins/vector/images/search-ltr.png?303-4"" alt=""Search"" width=""12"" height=""13"" /></button>								<input type='hidden' name=""title"" value=""Special:Search""/>
		</div>
	</form>
</div>
				</div>
			</div>
			<div id=""mw-panel"">
					<div id=""p-logo"" role=""banner""><a style=""background-image: url(//upload.wikimedia.org/wikipedia/en/b/bc/Wiki.png);"" href=""/wiki/Main_Page""  title=""Visit the main page""></a></div>
				<div class=""portal"" role=""navigation"" id='p-navigation'>
	<h3>Navigation</h3>
	<div class=""body"">
		<ul>
			<li id=""n-mainpage-description""><a href=""/wiki/Main_Page"" title=""Visit the main page [z]"" accesskey=""z"">Main page</a></li>
			<li id=""n-contents""><a href=""/wiki/Portal:Contents"" title=""Guides to browsing Wikipedia"">Contents</a></li>
			<li id=""n-featuredcontent""><a href=""/wiki/Portal:Featured_content"" title=""Featured content – the best of Wikipedia"">Featured content</a></li>
			<li id=""n-currentevents""><a href=""/wiki/Portal:Current_events"" title=""Find background information on current events"">Current events</a></li>
			<li id=""n-randompage""><a href=""/wiki/Special:Random"" title=""Load a random article [x]"" accesskey=""x"">Random article</a></li>
			<li id=""n-sitesupport""><a href=""//donate.wikimedia.org/wiki/Special:FundraiserRedirector?utm_source=donate&amp;utm_medium=sidebar&amp;utm_campaign=C13_en.wikipedia.org&amp;uselang=en"" title=""Support us"">Donate to Wikipedia</a></li>
		</ul>
	</div>
</div>
<div class=""portal"" role=""navigation"" id='p-interaction'>
	<h3>Interaction</h3>
	<div class=""body"">
		<ul>
			<li id=""n-help""><a href=""/wiki/Help:Contents"" title=""Guidance on how to use and edit Wikipedia"">Help</a></li>
			<li id=""n-aboutsite""><a href=""/wiki/Wikipedia:About"" title=""Find out about Wikipedia"">About Wikipedia</a></li>
			<li id=""n-portal""><a href=""/wiki/Wikipedia:Community_portal"" title=""About the project, what you can do, where to find things"">Community portal</a></li>
			<li id=""n-recentchanges""><a href=""/wiki/Special:RecentChanges"" title=""A list of recent changes in the wiki [r]"" accesskey=""r"">Recent changes</a></li>
			<li id=""n-contact""><a href=""//en.wikipedia.org/wiki/Wikipedia:Contact_us"" title=""How to contact Wikipedia"">Contact Wikipedia</a></li>
		</ul>
	</div>
</div>
<div class=""portal"" role=""navigation"" id='p-tb'>
	<h3>Toolbox</h3>
	<div class=""body"">
		<ul>
			<li id=""t-whatlinkshere""><a href=""/wiki/Special:WhatLinksHere/T.R._Baskin"" title=""List of all English Wikipedia pages containing links to this page [j]"" accesskey=""j"">What links here</a></li>
			<li id=""t-recentchangeslinked""><a href=""/wiki/Special:RecentChangesLinked/T.R._Baskin"" title=""Recent changes in pages linked from this page [k]"" accesskey=""k"">Related changes</a></li>
			<li id=""t-upload""><a href=""/wiki/Wikipedia:File_Upload_Wizard"" title=""Upload files [u]"" accesskey=""u"">Upload file</a></li>
			<li id=""t-specialpages""><a href=""/wiki/Special:SpecialPages"" title=""A list of all special pages [q]"" accesskey=""q"">Special pages</a></li>
			<li id=""t-permalink""><a href=""/w/index.php?title=T.R._Baskin&amp;oldid=448055576"" title=""Permanent link to this revision of the page"">Permanent link</a></li>
			<li id=""t-info""><a href=""/w/index.php?title=T.R._Baskin&amp;action=info"">Page information</a></li>
<li id=""t-cite""><a href=""/w/index.php?title=Special:Cite&amp;page=T.R._Baskin&amp;id=448055576"" title=""Information on how to cite this page"">Cite this page</a></li>		</ul>
	</div>
</div>
<div class=""portal"" role=""navigation"" id='p-coll-print_export'>
	<h3>Print/export</h3>
	<div class=""body"">
		<ul>
			<li id=""coll-create_a_book""><a href=""/w/index.php?title=Special:Book&amp;bookcmd=book_creator&amp;referer=T.R.+Baskin"">Create a book</a></li>
			<li id=""coll-download-as-rl""><a href=""/w/index.php?title=Special:Book&amp;bookcmd=render_article&amp;arttitle=T.R.+Baskin&amp;oldid=448055576&amp;writer=rl"">Download as PDF</a></li>
			<li id=""t-print""><a href=""/w/index.php?title=T.R._Baskin&amp;printable=yes"" title=""Printable version of this page [p]"" accesskey=""p"">Printable version</a></li>
		</ul>
	</div>
</div>
<div class=""portal"" role=""navigation"" id='p-lang'>
	<h3>Languages</h3>
	<div class=""body"">
		<ul>
			<li class=""wbc-editpage""><a href=""//www.wikidata.org/wiki/Q12128678#sitelinks"" title=""Edit interlanguage links"">Edit links</a></li>
		</ul>
	</div>
</div>
			</div>
		</div>
		<div id=""footer"" role=""contentinfo"">
							<ul id=""footer-info"">
											<li id=""footer-info-lastmod""> This page was last modified on 2 September 2011 at 15:32.<br /></li>
											<li id=""footer-info-copyright"">Text is available under the <a rel=""license"" href=""//en.wikipedia.org/wiki/Wikipedia:Text_of_Creative_Commons_Attribution-ShareAlike_3.0_Unported_License"">Creative Commons Attribution-ShareAlike License</a><a rel=""license"" href=""//creativecommons.org/licenses/by-sa/3.0/"" style=""display:none;""></a>;
additional terms may apply.  By using this site, you agree to the <a href=""//wikimediafoundation.org/wiki/Terms_of_Use"">Terms of Use</a> and <a href=""//wikimediafoundation.org/wiki/Privacy_policy"">Privacy Policy.</a> <br/>
Wikipedia® is a registered trademark of the <a href=""//www.wikimediafoundation.org/"">Wikimedia Foundation, Inc.</a>, a non-profit organization.</li>
									</ul>
							<ul id=""footer-places"">
											<li id=""footer-places-privacy""><a href=""//wikimediafoundation.org/wiki/Privacy_policy"" title=""wikimedia:Privacy policy"">Privacy policy</a></li>
											<li id=""footer-places-about""><a href=""/wiki/Wikipedia:About"" title=""Wikipedia:About"">About Wikipedia</a></li>
											<li id=""footer-places-disclaimer""><a href=""/wiki/Wikipedia:General_disclaimer"" title=""Wikipedia:General disclaimer"">Disclaimers</a></li>
											<li id=""footer-places-contact""><a href=""//en.wikipedia.org/wiki/Wikipedia:Contact_us"">Contact Wikipedia</a></li>
											<li id=""footer-places-mobileview""><a href=""//en.m.wikipedia.org/wiki/T.R._Baskin"" class=""noprint stopMobileRedirectToggle"">Mobile view</a></li>
									</ul>
										<ul id=""footer-icons"" class=""noprint"">
					<li id=""footer-copyrightico"">
						<a href=""//wikimediafoundation.org/""><img src=""//bits.wikimedia.org/images/wikimedia-button.png"" width=""88"" height=""31"" alt=""Wikimedia Foundation""/></a>
					</li>
					<li id=""footer-poweredbyico"">
						<a href=""//www.mediawiki.org/""><img src=""//bits.wikimedia.org/static-1.22wmf7/skins/common/images/poweredby_mediawiki_88x31.png"" alt=""Powered by MediaWiki"" width=""88"" height=""31"" /></a>
					</li>
				</ul>
						<div style=""clear:both""></div>
		</div>
		<script>/*<![CDATA[*/window.jQuery && jQuery.ready();/*]]>*/</script><script>if(window.mw){
mw.loader.state({""site"":""loading"",""user"":""ready"",""user.groups"":""ready""});
}</script>
<script>if(window.mw){
mw.loader.load([""mobile.desktop"",""mediawiki.action.view.postEdit"",""mediawiki.user"",""mediawiki.hidpi"",""mediawiki.page.ready"",""mediawiki.searchSuggest"",""ext.gadget.teahouse"",""ext.gadget.ReferenceTooltips"",""ext.gadget.DRN-wizard"",""ext.gadget.charinsert"",""mw.MwEmbedSupport.style"",""ext.vector.collapsibleNav"",""ext.vector.collapsibleTabs"",""ext.articleFeedbackv5.startup"",""schema.Edit"",""ext.visualEditor.splitTest"",""ext.markAsHelpful"",""ext.gettingstarted.logging"",""ext.gettingstarted.openTask"",""ext.navigationTiming"",""mw.PopUpMediaTransform"",""skins.vector.js""],null,true);
}</script>
<script src=""/w/index.php?title=MediaWiki:Gadget-ReferenceTooltips.js&amp;action=raw&amp;ctype=text/javascript&amp;508635914""></script>
<script src=""//bits.wikimedia.org/en.wikipedia.org/load.php?debug=false&amp;lang=en&amp;modules=site&amp;only=scripts&amp;skin=vector&amp;*""></script>
<!-- Served by mw1058 in 0.607 secs. -->
	</body>
</html>";
            }
        
        }
    }
}
