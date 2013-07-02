using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Radio7.Phone.HtmlCleaner.Tests
{
    class RLeague
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
      <html lang=""en"">
      <head>
      <script type=""text/javascript"">var NREUMQ=NREUMQ||[];NREUMQ.push([""mark"",""firstbyte"",new Date().getTime()]);</script>
<title>Waerea-Hargreaves fired up for NRL return</title>
      <meta name=""description"" content=""The Sydney Roosters will be looking for controlled aggression from feisty prop Jared Waerea-Hargreaves as he makes his NRL return from suspension on Monday against the Manly outfit he crossed the line against last outing.""/>
      <meta name=""keywords"" content= ""horse racing news, news, latest news, racing updates, racing blog""/>
      <meta http-equiv=""Content-Type"" content=""text/html; charset=iso-8859-1""/>
      <meta property=""og:title"" content=""Waerea-Hargreaves fired up for NRL return"" />
      <meta property=""og:site_name"" content=""rleague"" />
      <meta http-equiv=""X-UA-Compatible"" content=""IE=EmulateIE9"" />
      <meta property=""fb:admins"" value=""512930199"" />

<meta name=""twitter:domain"" content=""rleague.com"">
      <meta name=""twitter:card"" content=""summary"">
      <meta name=""twitter:site"" content=""@rleaguecom"">
        <meta name=""twitter:creator"" content=""@rleaguecom"">      <meta name=""twitter:url"" content=""/news/Waerea-Hargreaves-fired-up-for-NRL-return_121261/"">
      <meta name=""twitter:title"" content=""Waerea-Hargreaves fired up for NRL return"">
      <meta name=""twitter:description"" content=""The Sydney Roosters will be looking for controlled aggression from feisty prop Jared Waerea-Hargreaves as he makes his NRL return from suspension on Monday against the Manly outfit he crossed the line against last outing."">
      <meta property=""og:title"" content=""Waerea-Hargreaves fired up for NRL return"" /> <meta property=""og:site_name"" content=""rleague"" />          <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
       
       <link rel=""image_src"" href=""http://c1.puntersparadise.net/theme_rleague/sharelogo.jpg"" /><link rel=""shortcut icon"" href=""http://images.puntersparadise.com.au/theme_rleague/favicon.ico"" /><!--[if lt IE 9]><script src=""http://html5shiv.googlecode.com/svn/trunk/html5.js""></script><![endif]--><link rel=""stylesheet"" type=""text/css"" href=""/min/?f=/css/jquery.ppgallery.css,/css/forum.css,/css/oddscomparison.css&amp;v=225"" />
      <script type='text/javascript'>
      var googletag = googletag || {};
      googletag.cmd = googletag.cmd || [];
      (function() {
      var gads = document.createElement('script');
      gads.async = true;
      gads.type = 'text/javascript';
      var useSSL = 'https:' == document.location.protocol;
      gads.src = (useSSL ? 'https:' : 'http:') + 
      '//www.googletagservices.com/tag/js/gpt.js';
      var node = document.getElementsByTagName('script')[0];
      node.parentNode.insertBefore(gads, node);
      })();
      </script>
      <link rel=""stylesheet"" href=""/css/print.css?v=225"" media=""print"" /><link rel=""stylesheet"" type=""text/css"" href=""/css/theme_rleague.min.css?v=225""/><script type=""text/javascript"" src=""//ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js""></script><script src=""/min/?f=/javascripts/default.js,/javascripts/bootstrap.js,/javascripts/PeePeeControls.js,/javascripts/date.js,/javascripts/highcharts.js,/javascripts/jquery.mustache.js,/javascripts/jquery.livequery.js,/javascripts/jquery.timestamp.js,/javascripts/jquery.forms.js,/javascripts/jquery.facebox.js,/javascripts/jquery.hint.js,/javascripts/jquery.autocomplete.js,/javascripts/bootstrap-datepicker.js,/javascripts/jquery.autogrow.js,/javascripts/jquery.touchSwipe.min.js,/javascripts/rleague.js,/javascripts/puntersparadise.js,/kingtipping/Forum.js,/javascripts/jquery.pikachoose.4.js,/OddsComparison.js&amp;v=225"" type=""text/javascript""></script></head><body>

<input type=""checkbox"" name=""handler-right"" class=""noShowDesktop handler noShowTablet noShowPhone"" id=""handler-right"" onclick=""null"" />
<input type=""checkbox"" name=""handler-left"" class=""noShowDesktop handler noShowTablet noShowPhone"" id=""handler-left"" onclick=""null"" />

  

      <div id=""mobile-menu"" class=""noShowDesktop noShowTablet"">

          <div class=""collapse-inner"">

            <div class=""navbar navbar-inverse mobile-header"">
              <div class=""navbar-inner"">
                rleague.com
              </div>
            </div>

                        <!-- end navbar account -->

            <ul class=""nav nav-tabs nav-stacked"">

              <li class=""navheader"">FAVOURITES</li>
              <li class=""mobicon ""><a class=""mhome"" href=""/"">Home</a></li>
              <li class=""mobicon ""><a class=""mnews"" href=""/news/"">News</a></li>
              <li class=""mobicon ""><a class=""mforums"" href=""/forum/"">Forums</a></li>
              <li class=""mobicon ""><a class=""mfixtures"" href=""/fixtures/"">Fixtures</a></li>
              <li class=""mobicon ""><a class=""mlive-scores"" href=""/live-scores/"">Live Scores</a></li>
              <li class=""mobicon ""><a class=""mbetting"" href=""/betting/"">Betting</a></li>

              <li class=""navheader"">TIPPING</li>

              <li class=""mobicon ""><a class=""mladderboard"" href=""/tips/"">Ladderboard</a></li>
              <li class=""mobicon ""><a class=""menter-tips"" href=""/tips/enter-tips/"">Enter Tips</a></li>
              <li class=""mobicon ""><a class=""mpurchased-tips"" href=""/tips/puchased/"">Purchased Tips</a></li>
              
              <li class=""navheader"">OTHER STUFF</li>
              
              <li class=""mobicon""><a class=""mfull-website"" href=""/?fullsite=true"">Full Website</a></li>
              <li class=""mobicon ""><a class=""mprivacy"" href=""/terms/"">Privacy & Terms</a></li>
              <li class=""mobicon ""><a class=""mcontacte"" href=""/contact-us/"">Contact Us</a></li>

              <li class=""mobicon search"">
                <form method=""post"" action=""/search/"" class=""siteSearch"" id=""search"">
                  <input type=""text"" class=""searchText"" id=""txtSearchoff"" name=""searchfor"" size=""24"" title="""" value=""Search"" autocomplete=""off"" onblur=""if (this.value == '') this.value = 'Search'"" onfocus=""if (this.value=='Search') this.value = ''"" />
                  <input type=""submit"" class=""button"" value=""Search"" />
                </form>
              </li>

            </ul>
            <!-- end nav -->

          </div>
          <!-- end collapse inner -->

        </div>
        <!-- end menu -->


<div id=""wrap"">
  <div id=""main"">
    
    <header id=""overview"">
      <div class=""header1""></div>
      <div class=""header2""></div>
      <div class=""container"">        <div class=""signup-area clearfix hidden-phone"">
          <div class=""login"">
            <a href=""/login/?ReturnUrl=/news/Waerea-Hargreaves-fired-up-for-NRL-return_121261/"" rel=""facebox.noFooter""><i class=""sprite-normal sprite-normal-login""></i></a>
          </div>
          <div class=""register"">
            <a href=""/register/""><i class=""sprite-normal sprite-normal-register""></i></a>
          </div>
        </div>
        <div class=""signup-area-mobile clearfix visible-phone"">
          <div class=""login"">
            <a href=""/login/?ReturnUrl=/news/Waerea-Hargreaves-fired-up-for-NRL-return_121261/"" rel=""facebox.noFooter"" class=""button"">Login</a>
          </div>
          <div class=""register"">
            <a href=""/register/"" class=""button blue"">Signup, it's free!</a>
          </div>
        </div>        <div class=""brand""><a class=""ap"" title=""rleague.com - The World of Rugby League"" href=""http://www.rleague.com/""><i class=""sprite-normal sprite-normal-header-logo""></i></a></div>        <span class=""slogan"">The world of rugby league</span>        <div class=""navbar"">
          <div class=""navbar-inner"">
            <div class=""container"">
              
              <label for=""handler-left"" id=""mob-left"" href=""#"" class=""button btn btn-navbar mob mvnavbtn"" onclick>
                <span class=""icon-bar""></span>
                <span class=""icon-bar""></span>
                <span class=""icon-bar""></span>
              </label>

              <div class=""nav-collapse collapse"">
                <ul class=""nav"">
                  <li class="""">
                      <a href=""/"">Home</a>
                  </li>
                  <li class="""">
                    <a href=""/news/"">News</a>
                  </li>
                  <li class="""">
                    <a href=""/video/"">Video</a>
                  </li>
                  <li class="""">
                    <a href=""/forum/"">Forums</a>
                  </li>
                  <li class="""">
                    <a href=""/fixtures/"">Fixtures</a>
                  </li>
                  <li class="""">
                    <a href=""/live-scores/"">Live Scores</a>
                  </li>
                  <li class="""">
                    <a href=""/betting/"">Betting</a>
                  </li>
                  <li class=""dropdown "">
                    <a class=""clearfix"" href=""/tips/"">Tips <b class=""caret""></b></a>
                    <ul class=""dropdown-menu"">
                      <li><a href=""/tips/rugby-league/"">Ladderboard</a></li>
                      <li><a href=""/tips/enter-tips/"">Enter Tips</a></li>
                      <li><a href=""/tips/purchased/"">Purchased Tips</a></li>
                    </ul>                    
                  </li>                  
                  <li class="""">
                    <a href=""/results/"">Results</a>
                  </li>
                  <li class="""">
                    <a href=""/contact-us/"">Contact Us</a>
                  </li>
                </ul>
                <div class=""teamSelect""><a href=""javascript:void(-1);"" onclick=""showTeamEdit();"" title=""Change your team"">Select your team</a></div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </header>
    <div class=""wrapperfade"">
      <div class=""container"">
        <section id=""global""><div id=""teamSelection"" class=""noShow""><div class=""clearfix teamSelect"" style=""font-size: 11px;""><label><input type=""radio"" class=""team5"" name=""team"" style=""display: inline;"" value=""5""> <img title=""Brisbane Broncos"" src=""http://c1.puntersparadise.net/teams/nrl/BrisbaneBroncos.gif""/> Brisbane Broncos</input></label></div><div class=""clearfix teamSelect"" style=""font-size: 11px;""><label><input type=""radio"" class=""team6"" name=""team"" style=""display: inline;"" value=""6""> <img title=""Canberra Raiders"" src=""http://c1.puntersparadise.net/teams/nrl/CanberraRaiders.gif""/> Canberra Raiders</input></label></div><div class=""clearfix teamSelect"" style=""font-size: 11px;""><label><input type=""radio"" class=""team7"" name=""team"" style=""display: inline;"" value=""7""> <img title=""Canterbury Bulldogs"" src=""http://c1.puntersparadise.net/teams/nrl/CanterburyBulldogs.gif""/> Canterbury Bulldogs</input></label></div><div class=""clearfix teamSelect"" style=""font-size: 11px;""><label><input type=""radio"" class=""team8"" name=""team"" style=""display: inline;"" value=""8""> <img title=""Cronulla Sharks"" src=""http://c1.puntersparadise.net/teams/nrl/CronullaSharks.gif""/> Cronulla Sharks</input></label></div><div class=""clearfix teamSelect"" style=""font-size: 11px;""><label><input type=""radio"" class=""team9"" name=""team"" style=""display: inline;"" value=""9""> <img title=""Manly Sea Eagles"" src=""http://c1.puntersparadise.net/teams/nrl/ManlySeaEagles.gif""/> Manly Sea Eagles</input></label></div><div class=""clearfix teamSelect"" style=""font-size: 11px;""><label><input type=""radio"" class=""team10"" name=""team"" style=""display: inline;"" value=""10""> <img title=""Melbourne Storm"" src=""http://c1.puntersparadise.net/teams/nrl/MelbourneStorm.gif""/> Melbourne Storm</input></label></div><div class=""clearfix teamSelect"" style=""font-size: 11px;""><label><input type=""radio"" class=""team11"" name=""team"" style=""display: inline;"" value=""11""> <img title=""Newcastle Knights"" src=""http://c1.puntersparadise.net/teams/nrl/NewcastleKnights.gif""/> Newcastle Knights</input></label></div><div class=""clearfix teamSelect"" style=""font-size: 11px;""><label><input type=""radio"" class=""team12"" name=""team"" style=""display: inline;"" value=""12""> <img title=""South Sydney Rabbitohs"" src=""http://c1.puntersparadise.net/teams/nrl/SouthSydneyRabbitohs.gif""/> South Sydney Rabbitohs</input></label></div><div class=""clearfix teamSelect"" style=""font-size: 11px;""><label><input type=""radio"" class=""team13"" name=""team"" style=""display: inline;"" value=""13""> <img title=""Wests Tigers"" src=""http://c1.puntersparadise.net/teams/nrl/WestsTigers.gif""/> Wests Tigers</input></label></div><div class=""clearfix teamSelect"" style=""font-size: 11px;""><label><input type=""radio"" class=""team14"" name=""team"" style=""display: inline;"" value=""14""> <img title=""St George Illawarra Dragons"" src=""http://c1.puntersparadise.net/teams/nrl/StGeorgeIllawarraDragons.gif""/> St George Illawarra Dragons</input></label></div><div class=""clearfix teamSelect"" style=""font-size: 11px;""><label><input type=""radio"" class=""team15"" name=""team"" style=""display: inline;"" value=""15""> <img title=""Sydney Roosters"" src=""http://c1.puntersparadise.net/teams/nrl/SydneyRoosters.gif""/> Sydney Roosters</input></label></div><div class=""clearfix teamSelect"" style=""font-size: 11px;""><label><input type=""radio"" class=""team16"" name=""team"" style=""display: inline;"" value=""16""> <img title=""Parramatta Eels"" src=""http://c1.puntersparadise.net/teams/nrl/ParramattaEels.gif""/> Parramatta Eels</input></label></div><div class=""clearfix teamSelect"" style=""font-size: 11px;""><label><input type=""radio"" class=""team17"" name=""team"" style=""display: inline;"" value=""17""> <img title=""Penrith Panthers"" src=""http://c1.puntersparadise.net/teams/nrl/PenrithPanthers.gif""/> Penrith Panthers</input></label></div><div class=""clearfix teamSelect"" style=""font-size: 11px;""><label><input type=""radio"" class=""team18"" name=""team"" style=""display: inline;"" value=""18""> <img title=""New Zealand Warriors"" src=""http://c1.puntersparadise.net/teams/nrl/NewZealandWarriors.gif""/> New Zealand Warriors</input></label></div><div class=""clearfix teamSelect"" style=""font-size: 11px;""><label><input type=""radio"" class=""team19"" name=""team"" style=""display: inline;"" value=""19""> <img title=""North Queensland Cowboys"" src=""http://c1.puntersparadise.net/teams/nrl/NorthQueenslandCowboys.gif""/> North Queensland Cowboys</input></label></div><div class=""clearfix teamSelect"" style=""font-size: 11px;""><label><input type=""radio"" class=""team22"" name=""team"" style=""display: inline;"" value=""22""> <img title=""Gold Coast Titans"" src=""http://c1.puntersparadise.net/teams/nrl/GoldCoastTitans.gif""/> Gold Coast Titans</input></label></div></div><div class=""social-bar group""><ul><li class=""fb""><div id=""fb-root"" class="" fb_reset""><div style=""position: absolute; top: -10000px; height: 0pt; width: 0pt;""></div></div><div data-font=""arial"" data-show-faces=""false"" data-width=""50"" data-layout=""box_count"" data-send=""false"" data-href=""/news/Waerea-Hargreaves-fired-up-for-NRL-return_121261/"" class=""fb-like fb_edge_widget_with_comment fb_iframe_widget"" id=""fblike""><span><iframe src=""http://www.facebook.com/plugins/like.php?href=http://rleague.com%2Fnews%2FWaerea-Hargreaves-fired-up-for-NRL-return_121261%2F&amp;send=false&amp;layout=box_count&amp;width=69&amp;show_faces=true&amp;action=like&amp;colorscheme=light&amp;font=tahoma&amp;height=90&amp;appId=171587896263114"" scrolling=""no"" frameborder=""0"" style=""border:none; overflow:hidden; width:69px; height:90px;"" allowTransparency=""true"" title=""Like this on Facebook""></iframe></span></div></li><li class=""twitter""><a href=""https://twitter.com/share"" class=""twitter-share-button"" data-via=""puntersparadise"" data-count=""vertical"">Tweet</a><script>!function(d,s,id){var js,fjs=d.getElementsByTagName(s)[0];if(!d.getElementById(id)){js=d.createElement(s);js.id=id;js.src=""//platform.twitter.com/widgets.js"";fjs.parentNode.insertBefore(js,fjs);}}(document,""script"",""twitter-wjs"");</script></li> <li class=""googleplus""><g:plusone size=""tall""></g:plusone><script type=""text/javascript"">
    (function() {
      var po = document.createElement('script'); po.type = 'text/javascript'; po.async = true;
      po.src = 'https://apis.google.com/js/plusone.js';
      var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(po, s);
    })();
   </script></li></ul>
   <a href=""http://visual.ly/if-premiership-teams-were-countries"" class=""ig-next-rank ig-rank noShowTablet noShowPhone""></a>
   <a title=""NYC Collated/Standings Rd 16"" href=""/news/NYC-CollatedStandings-Rd-16_121268/"" class=""ig-prev-rank ig-rank noShowTablet noShowPhone""></a><a title=""Roosters winger profiting from AFL help"" href=""/news/Roosters-winger-profiting-from-AFL-help_121260/"" class=""ig-next-rank ig-rank noShowTablet noShowPhone""></a>   </div><style>
     .ig-rank {
        background: url(""http://visual.ly/sites/all/themes/visually2/images/next_prev_arrows.png"") no-repeat scroll 0 0 transparent;
        height: 63px;
        position: absolute;
        width: 63px;
        z-index: 99;
      }
      .ig-prev-rank {
          top: 450px; 
          display: inline; 
          position: fixed;
      }
      .ig-next-rank {
          background-position: -63px 0;
          margin-left: 1086px; 
          top: 450px; 
          display: inline; 
          position: fixed;
      }
      .ig-next-rank:hover {
          background-position: -63px -63px;
      }
      .ig-prev-rank:hover {
          background-position: 0 -63px;
      }
  </style>

  <div class=""row""><div id=""contentMain"" class=""span8"" itemscope itemtype=""http://schema.org/Article""><div class=""dontPrintMe rotatingBanner""><script src=""/Banner.php?g=homeMainFeed""></script></div><br/>
  <h1 itemprop=""name"">Waerea-Hargreaves fired up for NRL return</h1>
  <div class=""breadcrumbs""><a href=""/"">Home</a> &rsaquo; <a href=""/news/"">News</a> &rsaquo; Waerea-Hargreaves fired up for NRL return</div>  <div class=""noShow"" itemprop=""description"">The Sydney Roosters will be looking for controlled aggression from feisty prop Jared Waerea-Hargreaves as he makes his NRL return from suspension on Monday against the Manly outfit he crossed the line against last outing.</div>
  <abbr class=""timestamp"" data-utime=""1372573740""></abbr> by <a href=""/profiles/AAP/"">AAP</a><br/><br/>

  By Adrian Warren and Darren Walton<br/><br/> SYDNEY, June 30 AAP - The Sydney Roosters will be looking for controlled aggression from feisty prop Jared Waerea-Hargreaves as he makes his NRL return from suspension on Monday against the Manly outfit he crossed the line against last outing.<br/><br/> Waerea-Hargreaves was sent off and banned for five weeks for hitting Sea Eagles prop George Rose with a high shot in the Roosters' 16-4 win at Brookvale last month.<br/><br/> He makes his return in a high-stakes clash at Allianz Stadium between the third and fourth-placed teams.<br/><br/> The Roosters will climb above Melbourne into second if they win, while a Manly victory will move the Sea Eagles to within one point of the Roosters.<br/><br/> Roosters captain and fullback Anthony Minichiello said Waerea-Hargreaves was excited about playing again, but was also aware of the potential for the Kiwi international to get too pumped up.<br/><br/> ""You've got to speak to Jared about that because he likes to play the game tough and aggressive on a weekly basis and when he's been out for five weeks that can all build up,"" Minichiello said.<br/><br/> ""We need some controlled aggression from him tomorrow night.""<br/><br/> Manly coach Geoff Toovey admitted the Roosters were a more formidable proposition with Waerea-Hargreaves in their line-up.<br/><br/> ""He's a great leader of their forwards and I think they've missed him a little bit and he'll add something to their pack,"" Toovey said.<br/><br/> Toovey insisted there'd be no retribution eked out by his side, saying the Eagles were more intent on breaking down the Roosters' league-best defence than seeking payback against Waerea-Hargreaves.<br/><br/> ""To crack the opposition defence you need to come up with something special or pray on their mistakes,"" he said.<br/><br/> ""They did that better than us last time and hopefully we can return the favour.""<br/><br/> ""It's a very close competition in the middle of the pack so we need to start stringing a few games together, a few wins, and hopefully clear ourselves away from that pack.""<br/><br/> Toovey received a boost on Sunday, with tryscoring ace Brett Stewart completing Manly captain's run to be in line for his first start since round eight.<br/><br/> The former Test fullback suffered a chipped bone in his back after copping a knee during Manly's six-point win over St George Illawarra and the Sea Eagles have won one of their past five games in his absence.<br/><br/> Stewart is no certainty to play, with Toovey waiting to see how he pulls up on Monday and the coach said Manly fans shouldn't expect miracles if he does start.<br/><br/> ""If he's fit, he'll definitely add some experience.<br/><br/> ""But he's been out for a long time. It's one of those injuries where he hasn't been able to participate in team activities.<br/><br/> ""So it will take a little time for him to find his feet but there's still half a comp to go.""<br/><br/> With NSW five-eighth James Maloney injured in last week's State of Origin clash, Daniel Mortimer will retain a starting spot for the Roosters after an excellent display against the Bulldogs.<br/><br/><h3>Your thoughts?</h3><div class=""ForumPostLoginRequired""><center><br/>You need to <a href=""/login/?ReturnUrl=%2Fnews%2FWaerea-Hargreaves-fired-up-for-NRL-return_121261%2F"" rel=""facebox"">login</a> or <a href=""/register/"">register</a> to contribute here<br/><br/></center></div><div id=""forumPosts""><div class=""boundslats"" data-source=""ForumPosts/load"" data-params=""News,121261,1,500"" data-template=""forum.post"" data-idfield=""_postID"" data-polling=""true""></div></div><br/><br/></div><div id=""contentRight"" class=""span4""><form method=""post"" action=""/search/"" class=""siteSearch"" id=""siteSearch"">
  <div>
    <input type=""hidden"" id=""hidSearchValue"" name=""search_value"">
    <input type=""submit"" class=""sprite-normal sprite-normal-search-button siteSearchButton"" value="""">
    <input type=""text"" size=""24"" name=""searchfor"" id=""txtSearch"" class=""searchText hint"" autocomplete=""off"" title=""Find a team, player, game, discussion or user"">
  </div>
</form>
<div style=""margin-top:0px;"">
  <div class=""search_response"" style=""display:none;"" id=""input_search_all_response""></div>
</div><div class=""Module""><h3>Follow rleague.com on Facebook</h3><div class=""indent""><iframe src=""//www.facebook.com/plugins/like.php?href=http%3A%2F%2Fwww.facebook.com%2Frleague.com&amp;send=false&amp;layout=standard&amp;width=290&amp;show_faces=true&amp;font=tahoma&amp;colorscheme=light&amp;action=like&amp;height=65&amp;appId=309075782537110"" scrolling=""no"" frameborder=""0"" style=""border:none; overflow:hidden; width:290px; height:65px;"" allowTransparency=""true""></iframe></div></div><div class=""Module""><h3>Related Profiles</h3><div><div class=""moduleItem zeb"">View profile pages including statistics, results, news, photos and more on all of the following...</div></div></div><div class=""Module""><h3>Popular News Stories</h3><div><div class=""moduleItem zeb""><div class=""clearfix""><div><b><a title=""Qld panicking with cheat claim: Daley"" href=""/news/Qld-panicking-with-cheat-claim%3A-Daley_120943/"">Qld panicking with cheat claim: Daley</a></b></div></div></div><div class=""moduleItem zeb""><div class=""clearfix""><div><b><a title=""Canberra hit by backline injuries"" href=""/news/Canberra-hit-by-backline-injuries_121203/"">Canberra hit by backline injuries</a></b></div></div></div><div class=""moduleItem zeb""><div class=""clearfix""><div><b><a title=""NRL stands by tough stance on fighting"" href=""/news/NRL-stands-by-tough-stance-on-fighting_121131/"">NRL stands by tough stance on fighting</a></b></div></div></div><div class=""moduleItem zeb""><div class=""clearfix""><div><b><a title=""Waerea-Hargreaves fired up for NRL return"" href=""/news/Waerea-Hargreaves-fired-up-for-NRL-return_121261/"">Waerea-Hargreaves fired up for NRL return</a></b></div></div></div><div class=""moduleItem zeb""><div class=""clearfix""><div><b><a title=""Masoe released by Panthers"" href=""/news/Masoe-released-by-Panthers_121050/"">Masoe released by Panthers</a></b></div></div></div><div class=""moduleItem zeb""><div class=""clearfix""><div><b><a title=""Farah pumped for his Wests Tigers comeback"" href=""/news/Farah-pumped-for-his-Wests-Tigers-comeback_121153/"">Farah pumped for his Wests Tigers comeback</a></b></div></div></div><div class=""moduleItem zeb""><div class=""clearfix""><div><b><a title=""NSW State of Origin player ratings"" href=""/news/NSW-State-of-Origin-player-ratings_121091/"">NSW State of Origin player ratings</a></b></div></div></div><div class=""moduleItem zeb""><div class=""clearfix""><div><b><a title=""Bird wants apology for Origin sin-binning"" href=""/news/Bird-wants-apology-for-Origin-sin-binning_121097/"">Bird wants apology for Origin sin-binning</a></b></div></div></div><div class=""moduleItem zeb""><div class=""clearfix""><div><b><a title=""Origin rivals fuming over cheap shots"" href=""/news/Origin-rivals-fuming-over-cheap-shots_121124/"">Origin rivals fuming over cheap shots</a></b></div></div></div><div class=""moduleItem zeb""><div class=""clearfix""><div><b><a title=""Storm's Widdop suffers horrific injury"" href=""/news/Storms-Widdop-suffers-horrific-injury_120971/"">Storm's Widdop suffers horrific injury</a></b></div></div></div></div></div></div></div>        </section>
      </div>
    </div>
  </div>
</div>
    <footer>
      <div class=""footerinside"">
        <div class=""container"">
          <div class=""footercontent row"">
            <div class=""span8 clearfix"">
              <div class=""row footermenu"">
                <div class=""span12"">
                  <a href=""/about/"">About</a>&nbsp;&nbsp; | &nbsp;&nbsp;
                  <a href=""/contact-us/"">Contact</a>&nbsp;&nbsp; | &nbsp;&nbsp;
                  <a href=""/faq/"">Help/FAQ</a>&nbsp;&nbsp; | &nbsp;&nbsp;
                  <a href=""http://www.puntersparadise.com.au/developers/"" target=""_blank"">Odds API</a>&nbsp;&nbsp; | &nbsp;&nbsp;
                  <a href=""/terms/"">Terms</a>&nbsp;&nbsp; | &nbsp;&nbsp;
                  <a href=""/nrl-grand-final/"">NRL Grand Final</a>
                </div>
              </div>  
              <div class=""footersplit1""></div>
              <div class=""footersplit2""></div>
              <div class=""row footersections noShowPhone"">
                <div class=""follow span3 split clearfix"">Follow Us<br/><br/>
                <div class=""connect""><a target=""_blank"" href=""http://www.facebook.com/rleaguecom""><i class=""sprite-normal sprite-normal-facebook-large""></i></a><a target=""_blank"" href=""http://twitter.com/rleaguecom""><i class=""sprite-normal sprite-normal-twitter-large""></i></a><a href=""//plus.google.com/117288818326556178488?prsrc=3"" rel=""publisher"" style=""text-decoration:none;"" target=""_blank""><i class=""sprite-normal sprite-normal-gplus-large""></i></a></div></div>
                <div class=""sites span4 clearfix"">Our Other Sites<br/><br/>
                  <a href=""http://www.puntersparadise.com.au/"" title=""Punters Paradise - Horse Racing""><i class=""sprite-normal sprite-normal-puntersparadise""></i></a>

                  <a href=""http://www.bestodds.com.au/"" title=""Best Odds - Betting Odds Comparison""><i class=""sprite-normal sprite-normal-bestodds noShow""></i></a>
                </div>
              </div>
            </div>
          </div>
          <div class=""row copywrite"">
            <div class=""span3"">&copy; 2013 rleague.com</div>
          </div>
        </div>
      </div>
    </footer>
    <script type=""text/javascript"">
      var _gaq = _gaq || [];
      _gaq.push(['_setAccount', 'UA-3558814-1']);
      _gaq.push(['_trackPageview']);

      (function() {
        var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
        ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
        var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
      })();
    </script><script type=""text/javascript"">if(!NREUMQ.f){NREUMQ.f=function(){NREUMQ.push([""load"",new Date().getTime()]);var e=document.createElement(""script"");e.type=""text/javascript"";e.src=((""http:""===document.location.protocol)?""http:"":""https:"")+""//""+""rpm-images.newrelic.com/42/eum/rum.js"";document.body.appendChild(e);if(NREUMQ.a)NREUMQ.a();};NREUMQ.a=window.onload;window.onload=NREUMQ.f;};NREUMQ.push([""nrfj"",""beacon-1.newrelic.com"",""e90b235f39"",""403705"",""NlNUMEAAC0sFVRJaWw8ZYxZbTitdE0VIQ1wR"",0,396,new Date().getTime(),"""","""","""","""",""""]);</script>
</body>
</html>";
            }
        }
    }
}
