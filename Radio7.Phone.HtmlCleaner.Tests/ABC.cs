using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Radio7.Phone.HtmlCleaner.Tests
{
    public class ABC
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
  <!--[if lt IE 7]>      <html lang=""en-AU"" class=""lt-ie9 lt-ie8 lt-ie7""> <![endif]-->
  <!--[if IE 7]>         <html lang=""en-AU"" class=""lt-ie9 lt-ie8""> <![endif]-->
  <!--[if IE 8]>         <html lang=""en-AU"" class=""lt-ie9""> <![endif]-->
  <!--[if gt IE 8]><!--> <html lang=""en-AU""> <!--<![endif]-->
  <head>
    <title>Labor announces three new women in Labor Cabinet reshuffle - Rudd Returns - ABC News (Australian Broadcasting Corporation)</title>
  <meta http-equiv=""Content-Type"" content=""text/html;charset=UTF-8"" />
<link rel=""schema.DC"" href=""http://purl.org/dc/elements/1.1/"" />
<link rel=""schema.DCTERMS"" href=""http://purl.org/dc/terms/"" />
<link rel=""schema.iptc"" href=""urn:newsml:iptc.org:20031010:topicset.iptc-genre:8"" />
<link rel=""canonical"" href=""http://www.abc.net.au/news/2013-06-30/labor-announces-three-new-women-in-labor-cabinet-reshuffle/4790212"" />
<meta name=""title"" content=""Three women to join Labor&#039;s Cabinet""/>
          <meta name=""description"" content=""The Federal Government has revealed three new women will be sworn into Cabinet, but will not announce the full ministry until tomorrow. Deputy Prime Minister Anthony Albanese says Labor&#039;s new team has been finalised, but it will not be revealed today out of respect for the state memorial for Yothu Yindi&#039;s frontman. The announcement of Victorian Senator Jacinta Collins, as well as MPs Julie Collins and Catherine King to the Cabinet, will increase the number of women in the ministry from 9 to 11. More than a third of Cabinet resigned after last week&#039;s leadership ballot, forcing a major frontbench reshuffle just weeks out from an election.""/>
          <meta name=""keywords"" content=""Tasmania, frontbench, Labor, Kevin Rudd, Anthony Albanese, cabinet""/>
          <meta name=""ICBM"" content=""-26.000,134.500""/>
          <meta name=""geo.position"" content=""-26.000;134.500""/>
          <meta name=""ContentId"" content=""4790212""/>
          <meta name=""ABC.site"" content=""ABC News""/>
          <meta name=""ABC.editorialGenre"" content=""News &amp; Current Affairs""/>
          <meta name=""ABC.tags"" content=""federal-parliament;parliament;federal-government;elections;women""/>
          <meta name=""ABC_WCMS_sitesearch_include"" content=""true""/>
          <meta name=""DC.Publisher.CorporateName"" content=""Australian Broadcasting Corporation""/>
          <meta name=""DC.rights"" scheme=""DCTERMS.URI"" content=""http://www.abc.net.au/conditions.htm#UseOfContent""/>
        <meta name=""DC.rightsHolder"" content=""ABC""/>
          <meta name=""DC.type"" content=""Text""/>
          <meta name=""DC.type"" scheme=""iptc-genre"" content=""Current""/>
        <meta name=""DC.title"" content=""Three women to join Labor&#039;s Cabinet""/>
          <meta name=""DC.creator.CorporateName"" content=""Australian Broadcasting Corporation""/>
          <meta name=""DC.date"" scheme=""DCTERMS.W3CDTF"" content=""2013-06-30T14:54:26+1000""/>
        <meta name=""DC.format"" scheme=""DCTERMS.IMT"" content=""text/html""/>
        <meta name=""DC.identifier"" scheme=""DCTERMS.URI"" content=""http://www.abc.net.au/news/2013-06-30/labor-announces-three-new-women-in-labor-cabinet-reshuffle/4790212""/>
          <meta name=""DC.language"" scheme=""DCTERMS.RFC3066"" content=""en-AU""/>
        <meta name=""DC.subject"" scheme=""ABCTERMS.subject"" content=""Government and Politics:Parliament:Federal Parliament;Government and Politics:Parliament;Government and Politics:Federal Government;Government and Politics:Elections;Community and Society:Women""/>
        <meta name=""DCTERMS.issued"" scheme=""DCTERMS.W3CDTF"" content=""2013-06-30T14:54:26+1000""/>
        <meta name=""DCTERMS.modified"" scheme=""DCTERMS.W3CDTF"" content=""2013-06-30T15:04:38+1000""/>
        <meta name=""DCTERMS.spatial"" content=""Australia;TAS""/>
          <meta name=""DCTERMS.spatial"" scheme=""DCTERMS.DCMIPoint"" content=""east=134.500;north=-26.000""/>
        <link media=""all"" rel=""stylesheet"" type=""text/css""
                                                                              href=""http://www.abc.net.au/res/abc/styles/combined-min.css""/>
    <!--[if IE 8]><style type=""text/css"">@import url(http://www.abc.net.au/res/abc/styles/ie8.css);</style><![endif]-->
        <!--[if IE 7]><style type=""text/css"">@import url(http://www.abc.net.au/res/abc/styles/ie7.css);</style><![endif]-->
        <!--[if lte IE 6]><style type=""text/css"">@import url(http://www.abc.net.au/res/abc/styles/ie6.css);</style><![endif]-->
        <link rel=""stylesheet"" type=""text/css""
                                                                              href=""http://www.abc.net.au/res/sites/news/styles/min/abc.news.css?2013-06-12""/>
    <!--[if lte IE 7]>
            <link rel=""stylesheet"" type=""text/css"" href=""http://www.abc.net.au/res/sites/news/styles/yaml/core/slim_iehacks.css"" media=""screen, projection""/>
           <![endif]-->
         <link rel=""stylesheet"" type=""text/css""
                                                                              href=""/news/code/3576804/In+Depth+Styles.css""/>
    <link rel=""stylesheet"" type=""text/css""
                                                                              href=""/news/code/4781538/css.css""/>
    <link rel=""alternate"" type=""application/rss+xml"" title=""Just In"" href=""/news/feed/51120/rss.xml"">
  <link rel=""apple-touch-icon-precomposed"" sizes=""57x57"" href=""http://www.abc.net.au/news/contentblob/4355908/News+iOS+icon+57x57/data.png""/>
    <link rel=""apple-touch-icon-precomposed"" sizes=""72x72"" href=""http://www.abc.net.au/news/contentblob/4355924/News+iOS+icon+72x72/data.png""/>
    <link rel=""apple-touch-icon-precomposed"" sizes=""114x114"" href=""http://www.abc.net.au/news/contentblob/4355926/News+iOS+icon+114x114/data.png""/>
    <link rel=""apple-touch-icon-precomposed"" sizes=""144x144"" href=""http://www.abc.net.au/news/contentblob/4355930/News+iOS+icon+144x144/data.png""/>
    <script type=""text/javascript"" src=""/news/ajax/news/4583712/managed.js""></script>
<script type=""text/javascript"" src=""/news/code/4410056/news.js""></script>
    <script type=""text/javascript"" src=""http://www.abc.net.au/res/libraries/abcjs/abc-min.js""></script>
    <script type=""text/javascript"" src=""http://www.abc.net.au/res/libraries/jquery/jquery-1.8.2.min.js""></script>
    <script type=""text/javascript"" src=""http://www.abc.net.au/res/libraries/jquery/plugins/jquery.ba-hashchange.min.js""></script>
    <script type=""text/javascript"" src=""http://www.abc.net.au/res/libraries/jquery/plugins/jquery.viewport.mini.js""></script>
    <script type=""text/javascript"" src=""http://www.abc.net.au/res/libraries/jquery/plugins/jquery.cookie.min.js""></script>
    <script type=""text/javascript"" src=""http://www.abc.net.au/res/libraries/swfobject/swfobject-2.2.js""></script>
    <script type=""text/javascript"" src=""http://www.abc.net.au/res/libraries/cinerama2/scripts/cinerama2.js""></script>
    <script type=""text/javascript"" src=""http://www.abc.net.au/res/sites/news/scripts/min/abc.news.js?2013-06-28""></script>
    <script type=""text/javascript"" src=""/news/code/4723444/linked-heading-hack.js""></script>
    <script type=""text/javascript"" src=""/news/code/3577448/In+Depth+JavaScript.js""></script>
    </head>
  <body class=""news story_page"">
  <!--noindex-->
 <div id=""abcNav"">
  <div id=""abcNavWrapper"">
   <form id=""abcNavSearch"" method=""get"" action=""http://search.abc.net.au/search/search.cgi"">
    <input type=""hidden"" name=""form"" value=""simple"" />
    <input type=""hidden"" name=""num_ranks"" value=""20"" />
    <input type=""hidden"" name=""collection"" value=""abcall"" />
    <label for=""abcNavQuery"">Search:</label>
    <input type=""text"" id=""abcNavQuery"" name=""query"" value=""Keywords"" size=""20"" maxlength=""30"" />
    <input type=""submit"" id=""abcNavSubmit"" value="" ABC Search "" title=""ABC Search"" />
   </form>
   <ul id=""abcNavMenu"">
    <li id=""abcNavHome""><a href=""http://www.abc.net.au/"" title=""ABC Home""><img src=""http://www.abc.net.au/res/abc/logos/nav_logo.png"" alt=""ABC Home"" width=""61"" height=""16"" /></a></li>
    <li id=""abcNavRadio""><a href=""http://www.abc.net.au/radio/"">Radio</a></li>
    <li id=""abcNavTV""><a href=""http://www.abc.net.au/tv/"">TV</a></li>
    <li id=""abcNavShop""><a href=""http://shop.abc.net.au/"">Shop</a></li>
    <li id=""abcNavNews""><a href=""http://www.abc.net.au/news/"">News</a></li>
    <li id=""abcNavSport""><a href=""http://www.abc.net.au/news/sport/"">Sport</a></li>
    <li id=""abcNavLocal""><a href=""http://www.abc.net.au/local/"">Local</a></li>
    <li id=""abcNavKids""><a href=""http://www.abc.net.au/children/"">Children</a></li>
    <li id=""abcNavScience""><a href=""http://www.abc.net.au/science/"">Science</a></li>
    <li id=""abcNavEnvironment""><a href=""http://www.abc.net.au/environment/"">Environment</a></li>
    <li id=""abcNavTopics""><a href=""http://www.abc.net.au/topics.htm"">more&nbsp;Topics</a></li>
    <li id=""abcNavHelp""><a href=""http://www.abc.net.au/help/"">help</a></li>
   </ul>
  </div>
 </div>
<!--endnoindex-->
<!--noindex-->
  <div class=""page_margins"">
    <div id=""header"" class=""header"">
    <div class=""brand"">
        <a href=""/news/""><img class=""print"" src=""/news/linkableblob/49430/data.png"" alt=""ABC News"" width=""489"" height=""96"" />
                <img class=""noprint"" src=""/news/linkableblob/49440/data.png"" alt=""ABC News"" width=""242"" height=""80"" />
                </a></div>
      <a href=""/news/abcnews24/"" class=""abcnews24"">ABC News 24 Live Stream</a></div>
  <div id=""nav"" class=""nav"">
  <ul id=""primary-nav"">
        <li id=""n-news"" class=""""><a href=""/news/"">News Home</a></li><li id=""n-justin"" class=""""><a href=""/news/justin/"">Just In</a></li><li id=""n-australia"" class=""dropdown""><a href=""/news/australia/"">Australia</a><div class=""drop"">
    <ul>
 <li class=""first""><a href=""/news/national/"">National</a></li>
 <li><a href=""/news/act/"">Australian Capital Territory</a></li>
 <li><a href=""/news/nsw/"">New South Wales</a></li>
 <li><a href=""/news/nt/"">Northern Territory</a></li>
 <li><a href=""/news/qld/"">Queensland</a></li>
 <li><a href=""/news/sa/"">South Australia</a></li>
 <li><a href=""/news/tas/"">Tasmania</a></li>
 <li><a href=""/news/vic/"">Victoria</a></li>
 <li class=""last""><a href=""/news/wa/"">Western Australia</a></li>
 </ul></div>
  </li><li id=""n-world"" class=""""><a href=""/news/world/"">World</a></li><li id=""n-business"" class=""""><a href=""/news/business/"">Business</a></li><li id=""n-sport"" class=""""><a href=""/news/sport/"">Sport</a></li><li id=""n-thedrumdummy"" class=""""><a href=""/news/thedrum/"">Analysis &amp; Opinion</a></li><li id=""n-more"" class=""dropdown"">
  <a href=""#sitemap"">More</a><div class=""wide drop"">
        <div class=""subcolumns"">
          <div class=""c25l"">
              <div class=""section"">
                <ul>
 <li class=""first"">
    <a href=""http://www.abc.net.au/arts/read/""
    >
        <span>Arts</span>
  </a>
</li>
 <li>
    <a href=""http://www.abc.net.au/rampup""
    >
        <span>Disability - Ramp Up</span>
  </a>
</li>
 <li><a href=""/news/entertainment/"">Entertainment</a></li>
 <li><a href=""http://www.abc.net.au/environment/"">Environment</a></li>
 <li><a href=""http://www.abc.net.au/health/"">Health</a></li>
 <li class=""last"">
    <a href=""http://www.abc.net.au/indigenous/""
    >
        <span>Indigenous</span>
  </a>
</li>
 </ul></div>
            </div>
          <div class=""c25l"">
              <div class=""section"">
                <ul>
 <li class=""first"">
    <a href=""http://www.abc.net.au/local/""
    >
        <span>Local</span>
  </a>
</li>
 <li>
    <a href=""http://www.abc.net.au/religion/""
    >
        <span>Religion &amp; Ethics</span>
  </a>
</li>
 <li>
    <a href=""/news/rural/""
    >
        <span>Rural</span>
  </a>
</li>
 <li><a href=""http://www.abc.net.au/science/"">Science</a></li>
 <li>
    <a href=""http://www.abc.net.au/technology/""
    >
        <span>Technology &amp; Games</span>
  </a>
</li>
 <li class=""last""><a href=""/news/weather/"">Weather</a></li>
 </ul></div>
            </div>
          <div class=""c25l"">
              <div class=""section"">
                <ul>
 <li class=""first"">
    <a href=""http://blogs.abc.net.au/weatherman/""
    >
        <span>The Weather Man</span>
  </a>
</li>
 <li><a href=""http://www.abc.net.au/elections/"">Elections</a></li>
 <li>
    <a href=""http://blogs.abc.net.au/antonygreen/""
    >
        <span>Antony Green&#039;s Election Blog</span>
  </a>
</li>
 <li><a href=""/news/archive/"">Archive</a></li>
 <li>
    <a href=""/news/video/""
    >
        <span>Video</span>
  </a>
</li>
 <li class=""last""><a href=""/news/audio/"">Audio</a></li>
 </ul></div>
            </div>
          <div class=""c25r"">
              <div class=""section"">
                <ul>
 <li class=""first""><a href=""/news/photos/"">Photos</a></li>
 <li><a href=""/news/corrections/"">Corrections &amp; Clarifications</a></li>
 <li><a href=""/news/alerts/"">NewsMail</a></li>
 <li><a href=""/news/feeds/"">Podcasts</a></li>
 <li class=""last""><a href=""/news/contact/"">Contact Us</a></li>
 </ul></div>
            </div>
          </div>
      </div>
    </li></ul>
  <ul id=""additional-nav"">
        <li id=""n-in-depth-drop-down-channel-for-news-menu"" class=""dropdown""><a href=""/news/specials/"">In Depth</a><div class=""drop"">
    <ul>
 <li class=""first""><a href=""/news/elections/federal/2013/off-the-hustings/"">Election blog: Off The Hustings</a></li>
 <li><a href=""/news/specials/mama-asia/"">Mama Asia</a></li>
 <li><a href=""/news/elections/federal/2013/calculator/"">Antony Green&#039;s Election Calculator</a></li>
 <li><a href=""/news/specials/rudd-returns/"">Rudd Returns</a></li>
 <li><a href=""/news/specials/the-election-of-the-pope/"">The Election of the Pope</a></li>
 <li><a href=""/news/specials/2012-year-in-review/"">2012 year in review</a></li>
 <li><a href=""/news/specials/china-leadership-congress/"">China: The Transition</a></li>
 <li><a href=""/news/specials/us-election-2012/"">US election 2012</a></li>
 <li><a href=""/news/specials/hurricane-sandy-before-after-photos/"">Hurricane Sandy: Before &amp; After</a></li>
 <li><a href=""/news/specials/bali-remembered/"">Bali Remembered</a></li>
 <li><a href=""/news/specials/the-luckiest-refugees/"">The Luckiest Refugees</a></li>
 <li><a href=""/news/specials/japan-quake-one-year-on/"">Japan tsunami: One year on</a></li>
 <li><a href=""/news/specials/september-11-remembered/"">9/11 Remembered</a></li>
 <li><a href=""/news/specials/japan-quake-2011/"">Japan Tsunami: Before &amp; After</a></li>
 <li class=""last""><a href=""/news/specials/"">more...</a></li>
 </ul></div>
  </li><li id=""n-programs"" class=""dropdown"">
  <a href=""/news/programs/"">Programs</a><div class=""wide drop"">
        <div class=""subcolumns"">
          <div class=""c63l"">
              <div class=""section"">
                <h2>Television</h2>
              </div>
              <div class=""c30l"">
                  <div class=""section"">
                    <ul>
 <li class=""first""><a href=""http://www.abc.net.au/7.30/"">7.30</a></li>
 <li><a href=""http://australianetworknews.com/"">Australia Network News</a></li>
 <li><a href=""http://www.abc.net.au/austory/"">Australian Story</a></li>
 <li><a href=""http://abc.net.au/btn/"">Behind the News</a></li>
 <li><a href=""http://www.abc.net.au/tv/bigideas/"">Big Ideas</a></li>
 <li><a href=""/news/programs/the-business/"">The Business</a></li>
 <li><a href=""http://australianetwork.com/businesstoday/"">Business Today</a></li>
 <li>
    <a href=""/news/abcnews24/programs/capital-hill/""
    >
        <span>Capital Hill</span>
  </a>
</li>
 <li class=""last"">
    <a href=""/news/abcnews24/programs/the-drum/""
    >
        <span>The Drum</span>
  </a>
</li>
 </ul></div>
                </div>
              <div class=""c30l"">
                  <div class=""section"">
                    <ul>
 <li class=""first""><a href=""http://www.abc.net.au/foreign"">Foreign Correspondent</a></li>
 <li><a href=""/4corners"">Four Corners</a></li>
 <li><a href=""/news/abcnews24/programs/future-forum/"">Future Forum</a></li>
 <li><a href=""http://www.abc.net.au/insidebusiness/"">Inside Business</a></li>
 <li><a href=""/insiders"">Insiders</a></li>
 <li><a href=""http://www.abc.net.au/landline"">Landline</a></li>
 <li><a href=""http://www.abc.net.au/lateline"">Lateline</a></li>
 <li><a href=""/news/programs/national-press-club/"">National Press Club</a></li>
 <li class=""last""><a href=""/news/programs/news-exchange/"">News Exchange</a></li>
 </ul></div>
                </div>
              <div class=""c30l"">
                  <div class=""section"">
                    <ul>
 <li class=""first""><a href=""/news/australianetworknews/newsline/"">Newsline</a></li>
 <li><a href=""http://www.abc.net.au/abc3/news/"">News on 3</a></li>
 <li><a href=""/sport/offsiders"">Offsiders</a></li>
 <li>
    <a href=""/news/abcnews24/programs/one-plus-one/""
    >
        <span>One Plus One</span>
  </a>
</li>
 <li><a href=""/news/programs/planet-america/"">Planet America</a></li>
 <li><a href=""http://www.abc.net.au/tv/qanda/"">Q &amp; A</a></li>
 <li><a href=""/news/programs/retrospect/"">Retrospect</a></li>
 <li>
    <a href=""/news/abcnews24/programs/the-quarters/""
    >
        <span>The Quarters</span>
  </a>
</li>
 <li class=""last"">
    <a href=""/news/abcnews24/programs/tonic/""
    >
        <span>Tonic</span>
  </a>
</li>
 </ul></div>
                </div>
              </div>
          <div class=""c37r"">
              <div class=""section"">
                <h2>Radio</h2>
              </div>
              <div class=""c50l"">
                  <div class=""section"">
                    <ul>
 <li class=""first""><a href=""http://www.abc.net.au/am"">AM</a></li>
 <li><a href=""http://www.abc.net.au/correspondents/"">Correspondents Report</a></li>
 <li>
    <a href=""/news/programs/friday-late/""
    >
        <span>Friday Late</span>
  </a>
</li>
 <li class=""last""><a href=""http://www.abc.net.au/pm"">PM</a></li>
 </ul></div>
                </div>
              <div class=""c50r"">
                  <div class=""section"">
                    <ul>
 <li class=""first""><a href=""http://www.abc.net.au/worldtoday/"">The World Today</a></li>
 <li><a href=""http://www.radioaustralianews.net.au/"">Radio Australia News</a></li>
 <li class=""last""><a href=""http://www.abc.net.au/newsradio/"">NewsRadio</a></li>
 </ul></div>
                </div>
              </div>
          </div>
      </div>
    </li></ul>
  </div>
<div class=""header subheader banner"">
  <a href=""/news/specials/rudd-returns/""><img src=""/news/linkableblob/4781452/data.jpg"" alt=""Rudd Returns"" width=""1000"" height=""100""/>
</a></div><!-- A modules - start -->
  <!-- A modules - end -->
  <div class=""page section"">
    <div class=""subcolumns"">
    <div class=""c75l"">
      <!-- B modules - start -->
      <div class=""article section"">
<div class=""tools"">
  <a class=""button""
     href=""http://www2b.abc.net.au/EAF/View/MailToQuery.aspx?http://www.abc.net.au/news/2013-06-30/labor-announces-three-new-women-in-labor-cabinet-reshuffle/4790212""><span>Email</span></a>
</div><!--endnoindex-->
    <h1>Labor announces three new women in Labor Cabinet reshuffle</h1>
    <p class=""published"">
      Updated
    <span class=""timestamp"">
      June 30, 2013 15:04:38
    </span>
    </p>
<div class=""attached-content"">
      <div class=""inline-content photo left"">
    <a href=""/news/2013-06-30/kevin-rudd-and-anthony-albanese-at-press-conference/4790220"">
  <img src=""http://www.abc.net.au/news/image/4783932-3x2-340x227.jpg"" alt=""Kevin Rudd and Anthony Albanese at press conference after Mr Rudd won the Labor leadership."" title=""Rudd and Albanese"" width=""340"" height=""227""/>
</a><a href=""/news/2013-06-30/kevin-rudd-and-anthony-albanese-at-press-conference/4790220"" class=""inline-caption""><strong>
        Photo:</strong>
       Prime Minister Kevin Rudd will unveil his new Cabinet line-up - which includes three new women - on Monday. <span class=""source"">(AAP: Alan Porritt)</span>
      </a></div>
<div class=""inline-content story left"">
    <a href=""/news/2013-06-30/galaxy-poll-results-show-rudd-is-preferred-prime-minister/4789860""><strong>Related Story:</strong>
       Rudd leads Abbott as preferred PM: poll</a></div>
<div class=""inline-content story left"">
    <a href=""/news/2013-06-29/kevin-rudd-flags-taking-tony-abbott-to-g20-talks-in-russia/4789594""><strong>Related Story:</strong>
       Rudd considers taking Abbott to G20 in Russia</a></div>
<div class=""inline-content story left"">
    <a href=""/news/2013-06-29/greg-combet-quits-politics/4789542""><strong>Related Story:</strong>
       Greg Combet to retire from politics</a></div>
<div class=""inline-content map left"">
      <div class=""story-map""></div>
      <a class=""inline-caption"" href=""http://maps.google.com/?q=-26.000,134.500(Australia)&amp;z=5"">
        <strong>Map: </strong>
        Australia</a>
    </div>
  </div>
  <p>The Federal Government has revealed three women will be sworn into Cabinet, but will not announce the full ministry until tomorrow.</p><p>Deputy Prime Minister Anthony Albanese says the Government's new frontbench has been finalised, but it is not being announced today out of respect for the state memorial for Yothu Yindi front man Mr Yunupingu.</p><p>Prime Minister Kevin Rudd attended the <a href=""/news/2013-06-30/state-memorial-for-mr-yunupingu-held-at-gulkula-today/4789870"" target=""_self"" title="""">memorial this afternoon in north-east Arnhem Land</a>.</p><p>More than a third of Cabinet resigned after last week's leadership ballot, forcing a major frontbench reshuffle just weeks out from an election.</p><p><a href=""http://www.abc.net.au/news/2013-03-25/kevin-rudd-returns-winners-losers/4783676"" target=""_blank"" title=""""><strong>Take a look at who has stepped aside.</strong></a></p><p>The announcement of Victorian Senator Jacinta Collins, as well as MPs Julie Collins and Catherine King to the Cabinet, will increase the number of women in the ministry from 9 to 11.</p><p>Mr Albanese says the swearing-in ceremony will take place tomorrow afternoon.</p><p>""It's not appropriate on a day of a state funeral for other political announcements to be made,"" he said.</p><p>""So the full announcement of the ministry has been finalised, but it will be announced tomorrow morning by the Prime Minister.""</p><p>The announcement comes on the same day as a News Limited poll showing <a href=""/news/2013-06-30/galaxy-poll-results-show-rudd-is-preferred-prime-minister/4789860"" target=""_self"" title="""">a boost in the party's fortunes</a> in the wake of last week's leadership change.</p><p>The Galaxy poll published in News Limited newspapers shows that after preferences, the Coalition's lead over Labor has narrowed and now sits at 51 per cent to 49 per cent.</p><h2>Albanese touts 'fresh' Labor frontbench</h2><p>Mr Albanese says the reshuffle will be a chance to revitalise the Government.</p><p>""When people stand down, that brings an opportunity to get some fresh ideas in, to have a fresh look at what the Government's been doing,"" he told Sky News.</p><p>""I think it's been a very effective Government.""</p><p>Senator Collins will become the Minister for Mental Health, Ms King will be promoted to the Regional Australia portfolio and Ms Collins will enter Cabinet with the portfolio for Housing, Homeless and Status of Women.</p><p>West Australian MP Melissa Parke will have the international development and aid portfolio.</p><p>Mr Albanese has already congratulated Ms Collins on her promotion.</p><p>""We needed a Tasmanian in the Cabinet - sitting around the cabinet room,"" he said.</p><p>Ms Collins says she looks forward to the challenges ahead.</p><p>""I've been a minister for almost two years, I've also been a parliamentary secretary before that, I've been working for three years in the executive,"" she said.</p><p>""So I think I have the abilities and I've shown some great policy reform that I've done in these portfolios that I'm capable of doing this job.""</p>
<p class=""topics"">
	<strong>Topics:</strong>
	<a href=""/news/topic/federal-parliament"">federal-parliament</a>,
	<a href=""/news/topic/parliament"">parliament</a>,
	<a href=""/news/topic/federal-government"">federal-government</a>,
	<a href=""/news/topic/elections"">elections</a>,
	<a href=""/news/topic/women"">women</a>,
	<a href=""/news/topic/australia"">australia</a>,
	<a href=""/news/topic/tas"">tas</a>
</p>
  <p class=""published"">
    First posted
    <span class=""timestamp"">
      June 30, 2013 14:54:26
    </span>
  </p>
<!--noindex-->
  </div>
<!-- B modules - end -->
    </div>
    <div class=""c25r sidebar"">
    <div class=""section search-simple"">
        <div class=""inner"">
          <h2>Search ABC News</h2>
          <form action=""/news/search/"" method=""get"">
            <div>
              <input type=""text"" class=""text"" name=""query"" value="""" size=""15""/>
              <input type=""image"" class=""image"" src=""/news/contentblob/46178/search-button/data.png"" alt=""Search"" title=""Search""/>
            </div>
          </form>
        </div>
      </div>
    <!-- Sidebar modules - start -->
    <div id=""your-photos"" class=""section"">
  <div class=""inner"">
	<h2>Team Rudd: winners and losers</h2>
	<a href=""/news/2013-03-25/kevin-rudd-returns-winners-losers/4783676"">
  <img src=""http://www.abc.net.au/news/image/4516348-16x9-220x124.jpg"" alt=""Team Rudd: winners and losers"" title=""Team Rudd: winners and losers"" width=""220"" height=""124""/>
</a>
<a href=""/news/2013-03-25/kevin-rudd-returns-winners-losers/4783676"" class=""button"">
<span> See who&#039;s on the move</span></a>
</div></div><div id=""your-photos"" class=""section"">
  <div class=""inner"">
	<h2>MPs react to Rudd&#039;s return</h2>
	<a href=""/news/2013-06-27/reaction-to-kevin-rudd27s-return/4784660"">
  <img src=""http://www.abc.net.au/news/image/4784892-16x9-220x124.jpg"" alt=""MPs react to Rudd&#039;s return"" title=""MPs react to Rudd&#039;s return"" width=""220"" height=""124""/>
</a>
<a href=""/news/2013-06-27/reaction-to-kevin-rudd27s-return/4784660"" class=""button"">
<span> </span></a>
</div></div><div id=""your-photos"" class=""section"">
  <div class=""inner"">
	<h2>Kevin Rudd takes the reins</h2>
	<a href=""/news/2013-06-26/kevin-rudd-vows-to-defeat-negative-tony-abbott/4783936"">
  <img src=""http://www.abc.net.au/news/image/4783938-16x9-220x124.jpg"" alt=""Kevin Rudd takes the reins"" title=""Kevin Rudd takes the reins"" width=""220"" height=""124""/>
</a>
<a href=""/news/2013-06-26/kevin-rudd-vows-to-defeat-negative-tony-abbott/4783936"" class=""button"">
<span> Watch his speech</span></a>
</div></div><div id=""your-photos"" class=""section"">
  <div class=""inner"">
	<h2>Gillard proud of legacy</h2>
	<a href=""/news/2013-06-26/julia-gillard-speaks-about-defeat/4783950"">
  <img src=""http://www.abc.net.au/news/image/4783914-16x9-220x124.jpg"" alt=""Gillard proud of legacy"" title=""Gillard proud of legacy"" width=""220"" height=""124""/>
</a>
<a href=""/news/2013-06-26/julia-gillard-speaks-about-defeat/4783950"" class=""button"">
<span> Watch her speech</span></a>
</div></div><div id=""your-photos"" class=""section"">
  <div class=""inner"">
	<h2>Showdown in quotes</h2>
	<a href=""/news/2013-06-26/julia-gillard-in-quotes/4783170"">
  <img src=""http://www.abc.net.au/news/image/4739536-16x9-220x124.jpg"" alt=""Showdown in quotes"" title=""Showdown in quotes"" width=""220"" height=""124""/>
</a>
<a href=""/news/2013-06-26/julia-gillard-in-quotes/4783170"" class=""button"">
<span> Read what they said</span></a>
</div></div><div id=""your-photos"" class=""section"">
  <div class=""inner"">
	<h2>Kevin Rudd: spoiler or saviour?</h2>
	<a href=""/news/2013-06-26/rudd-profile/4782608"">
  <img src=""http://www.abc.net.au/news/image/4589434-16x9-220x124.jpg"" alt=""Kevin Rudd: spoiler or saviour?"" title=""Kevin Rudd: spoiler or saviour?"" width=""220"" height=""124""/>
</a>
<a href=""/news/2013-06-26/rudd-profile/4782608"" class=""button"">
<span> Read our profile</span></a>
</div></div><div id=""your-photos"" class=""section"">
  <div class=""inner"">
	<h2>Julia Gillard: a political life</h2>
	<a href=""/news/2013-03-21/gillard-leadership-timeline/4583700"">
  <img src=""http://www.abc.net.au/news/image/4539732-16x9-220x124.jpg"" alt=""Julia Gillard: a political life"" title=""Julia Gillard: a political life"" width=""220"" height=""124""/>
</a>
<a href=""/news/2013-03-21/gillard-leadership-timeline/4583700"" class=""button"">
<span> Look back at her career</span></a>
</div></div><div id=""your-photos"" class=""section"">
  <div class=""inner"">
	<h2>Photos: A tumultuous day</h2>
	<a href=""/news/2013-06-26/labor-leadership-vote/4783316"">
  <img src=""http://www.abc.net.au/news/image/4783326-16x9-220x124.jpg"" alt=""Photos: A tumultuous day"" title=""Photos: A tumultuous day"" width=""220"" height=""124""/>
</a>
<a href=""/news/2013-06-26/labor-leadership-vote/4783316"" class=""button"">
<span> View our gallery.</span></a>
</div></div><div class=""topics section"">
	<div class=""inner"">
    <h3>
	<a href=""https://twitter.com/abcnews/press-gallery?data-widget-id=312030298370080768"">Key tweets</a></h3>
<p class=""published"">Posted <span class=""timestamp"">March 14, 2013 13:43:45</span> | Updated <span class=""timestamp"">March 21, 2013 13:11:15</span>
</p></div>
</div>
<!-- Sidebar modules - end -->
  </div>
</div>
</div><!-- C modules - start -->
  <div class=""page section featured-scroller featured-scroller-4 dark"">
<div class=""section"">
  <h2>Editor&#039;s Picks</h2>
  </div>
<div class=""inner"">
  <ol class=""subcolumns"">
    <li class=""c25l"">
                  <div class=""section"">
		  <h2>
			 <a href=""/news/2013-06-30/tony-windsor-and-rob-oakeshott-talk-to-insiders/4790020"" class=""thumb"">
  <img src=""http://www.abc.net.au/news/image/3684662-16x9-220x124.jpg"" alt=""Rob Oakeshott (left) and Tony Windsor leave a press conference."" title=""Oakeshott and Windsor after commenting on tax"" width=""220"" height=""124""/>
<span class=""video""></span>
				<span class=""label"">
				  Independents look to future</span>
				<span class=""border""></span>
			  </a></h2>
		 <p>Tony Windsor and Rob Oakeshott reflect on their time in Parliament and who they're going to miss the most.</p>
	 </div>
    </li>
         <li class=""c25l"">
                  <div class=""section"">
		  <h2>
			 <a href=""/news/2013-06-29/phil-williams-idealism-and-apartheid/4789892"" class=""thumb"">
  <img src=""http://www.abc.net.au/news/image/407784-16x9-220x124.jpg"" alt=""Philip Williams"" title=""Philip Williams"" width=""220"" height=""124""/>
<span class=""audio""></span>
				<span class=""label"">
				  Taking a stand</span>
				<span class=""border""></span>
			  </a></h2>
		 <p>Philip Williams was just a boy during the Springboks' controversial tour in Canberra four decades ago.</p>
	 </div>
    </li>
         <li class=""c25l"">
                  <div class=""section"">
		  <h2>
			 <a href=""/news/2013-06-30/fans-get-satisfaction-from-rolling-stones-glastonbury-debut/4790056"" class=""thumb"">
  <img src=""http://www.abc.net.au/news/image/4790060-16x9-220x124.jpg"" alt=""Rolling Stones debut at Glastonbury"" title=""Rolling Stones debut at Glastonbury"" width=""220"" height=""124""/>
<span class=""story""></span>
				<span class=""label"">
				  Stones satisfy at Glastonbury</span>
				<span class=""border""></span>
			  </a></h2>
		 <p>Tens of thousands watch the Rolling Stones make an energetic debut at the Glastonbury festival.</p>
	 </div>
    </li>
         <li class=""c25r"">
                  <div class=""section"">
		  <h2>
			 <a href=""/news/2013-06-30/memory-implants-sometimes-therapeutic-sometimes-plain-daffy/4790026"" class=""thumb"">
  <img src=""http://www.abc.net.au/news/image/4790028-16x9-220x124.jpg"" alt=""Karl IV"" title=""Karl IV"" width=""220"" height=""124""/>
<span class=""video""></span>
				<span class=""label"">
				  Not so total recall</span>
				<span class=""border""></span>
			  </a></h2>
		 <p>Dr Karl explains how to create a memory for another person with the power of suggestion.</p>
	 </div>
    </li>
         </ol>
</div></div><div id=""footer-stories"" class=""page section"">
    <div class=""subcolumns"">
    <div class=""c25l"">
        <div class=""section"">
          <h2>Top Stories</h2>
  <ul class=""headlines"">
          <li>
    <a href=""/news/2013-06-30/labor-announces-three-new-women-in-labor-cabinet-reshuffle/4790212"">Three women to join Labor&#039;s Cabinet</a></li>
          <li>
    <a href=""/news/2013-06-30/state-memorial-for-mr-yunupingu-held-at-gulkula-today/4789870"">Mr Yunupingu honoured at memorial service</a></li>
          <li>
    <a href=""/news/2013-06-30/abortion-pill-ru486-and-three-cancer-drugs-added-to-the-pharmac/4790158"">Abortion pill added to PBS</a></li>
          <li>
    <a href=""/news/2013-06-30/sunbed-buyback/4790036"">Campaigners welcome tanning bed buy-back scheme</a></li>
          <li>
    <a href=""/news/2013-06-30/us-national-security-agency-spied-on-european-union2c-german-r/4790080"">US reportedly bugged EU offices, computer networks</a></li>
          <li>
    <a href=""/news/2013-06-30/essendon-deny-reports-players-were-27clinically-tested/4790064"">Essendon deny reports claiming players were &#039;used as human guinea pigs&#039; to test banned substance</a></li>
  </ul>
</div>
      </div>
    <div class=""c25l"">
        <div class=""section"">
          <h2>Just In</h2>
  <ul class=""headlines"">
          <li>
    <a href=""/news/2013-06-30/new-who-guidelines-recommend-earlier-treatment-with-aids-drugs/4790262"">New guidelines recommend earlier use of AIDS drugs</a></li>
          <li>
    <a href=""/news/2013-06-30/mcmanus-foursome-demolishes-sorry-titans/4790272"">McManus foursome demolishes sorry Titans</a></li>
          <li>
    <a href=""/news/2013-06-30/holder-for-sunday-metcash-interview/4788656"">Seasoned business leader calls for speedy election</a></li>
          <li>
    <a href=""/news/2013-06-30/fans-get-satisfaction-from-rolling-stones-glastonbury-debut/4790056"">Satisfaction at Rolling Stones Glastonbury debut</a></li>
          <li>
    <a href=""/news/2013-06-30/essendon-deny-reports-players-were-27clinically-tested/4790064"">Essendon deny reports players were &#039;used as guinea pigs&#039;</a></li>
          <li>
    <a href=""/news/2013-06-30/sydney-police-investigate-windsor-stabbing/4789946"">Police appeal for witnesses after Sydney stabbing</a></li>
          <li>
    <a href=""/news/2013-06-30/australia-win-first-match-under-new-coach-lehmann/4789984"">Australia win first match under new coach Lehmann</a></li>
          <li>
    <a href=""/news/2013-06-30/stosur27s-wimbledon-campaign-comes-to-an-end/4789964"">Stosur&#039;s Wimbledon campaign comes to an end</a></li>
          <li>
    <a href=""/news/2013-06-30/police-officer-dies-at-melbourne-police-station/4789940"">Police officer dies at Melbourne police station</a></li>
          <li>
    <a href=""/news/2013-06-30/heatwave-bears-down-on-california-and-arizona/4789920"">California facing heatwave temperature of 53C</a></li>
  </ul>
</div>
      </div>
    <div class=""c25l"">
        <div class=""section"">
          <h2>Most Popular</h2><ul class=""headlines"">
  <li>
    <a href=""/news/2013-06-30/galaxy-poll-results-show-rudd-is-preferred-prime-minister/4789860"">Rudd leads Abbott as preferred PM: poll</a>
</li>
<li>
    <a href=""/news/2013-06-29/kevin-rudd-flags-taking-tony-abbott-to-g20-talks-in-russia/4789594"">Rudd considers taking Abbott to G20 in Russia</a>
<span class=""media"">
    <span class=""video"" title=""Video"">(video)</span>
</span>
</li>
<li>
    <a href=""/news/2013-06-29/live-blog3a-wallabies-v-lions-second-test/4789574"">Wallabies v British and Irish Lions second Test: as it happened</a>
</li>
<li>
    <a href=""/news/2013-06-29/man-jailed-trafficking-adopted-son-paedophile-ring/4789730"">Man jailed for 40yrs after trafficking son to global paedophile ring</a>
</li>
<li>
    <a href=""/news/2013-06-29/greg-combet-quits-politics/4789542"">Greg Combet to retire from politics</a>
</li>
<li>
    <a href=""/news/2013-06-30/tomic-proves-too-strong-for-gasquet-at-wimbledon/4789868"">Tomic proves too strong for Gasquet at Wimbledon</a>
</li>
<li>
    <a href=""/news/2013-06-30/heatwave-bears-down-on-california-and-arizona/4789920"">California facing heatwave temperature of 53C</a>
</li>
<li>
    <a href=""/news/2013-06-29/ashley-cooper-try-nicks-win-for-wallabies/4789780"">Late Ashley-Cooper try snatches win for Wallabies</a>
</li>
<li>
    <a href=""/news/2013-06-30/police-officer-dies-at-melbourne-police-station/4789940"">Police officer dies at Melbourne police station</a>
</li>
<li>
    <a href=""/news/2013-06-30/labor-announces-three-new-women-in-labor-cabinet-reshuffle/4790212"">Three women to join Labor&#039;s Cabinet</a>
</li>
</ul></div>
      </div>
    <div class=""c25r"">
        <div class=""section"">
          <h2>ABC Analysis</h2>
  <ul class=""headlines"">
          <li>
    <a href=""/unleashed/4787544.html"">This is not Egypt&#039;s Second Revolution</a></li>
          <li>
    <a href=""/unleashed/4787922.html"">Could the UN be Gillard&#039;s next destination?</a></li>
          <li>
    <a href=""/unleashed/4787314.html"">Fast-tracked education bill a risk for new Labor leaders</a></li>
          <li>
    <a href=""/news/2013-06-28/brissenden-data-practice/4786782"">PRISM: the Australian connection</a></li>
          <li>
    <a href=""/news/2013-06-28/crabb-gillard-gender-politics/4786650"">Gender-blind politics: are we there yet?</a></li>
          <li>
    <a href=""/news/2013-06-28/cassidy-rudd-inside-and-out/4786598"">Election a referendum on Labor, and Rudd</a></li>
          <li>
    <a href=""/unleashed/4784666.html"">How to politicise Aussie youth? A job would be nice</a></li>
          <li>
    <a href=""/unleashed/4785038.html"">Can Kevin Rudd deliver a genuine contest of ideas?</a></li>
          <li>
    <a href=""/unleashed/4785276.html"">Who will &#039;stand with Wendy&#039; on Australian abortion rights?</a></li>
          <li>
    <a href=""/news/2013-06-27/stephens-rudd-resurrection/4784950"">The resurrection of Kevin Rudd: What will he do next?</a></li>
  </ul>
</div>
      </div>
    </div>
  </div>
<!-- C modules - end -->
<div id=""footer"" class=""page section"">
    <!-- program footer-->
  <div class=""programs""></div>
  <div class=""subcolumns"">
    <div id=""sitemap"" class=""c75l"">
        <div class=""section"">
          <h2>Site Map</h2>
        </div>
        <div class=""subcolumns"">
          <div class=""c16l"">
              <div class=""section"">
    <h3>Sections</h3><ul class=""nav"">
        <li><a href=""/news/"">News Home</a></li>
          <li><a href=""/news/justin/"">Just In</a></li>
          <li><a href=""/news/australia/"">Australia</a></li>
          <li><a href=""/news/world/"">World</a></li>
          <li><a href=""/news/business/"">Business</a></li>
          <li><a href=""/news/entertainment/"">Entertainment</a></li>
          <li><a href=""/news/sport/"">Sport</a></li>
          <li><a href=""/news/thedrum/"">Analysis &amp; Opinion</a></li>
          <li><a href=""/news/weather/"">Weather</a></li>
          <li><a href=""/news/blogs/"">Blogs</a></li>
          <li><a href=""/news/topics/"">Topics</a></li>
          <li><a href=""/news/archive/"">Archive</a></li>
          </ul>
    </div>
</div>
            <div class=""c16l"">
              <div class=""section"">
    <h3>Media</h3><ul class=""nav"">
        <li>
    <a href=""/news/video/""
    >
        <span>Video</span>
  </a>
</li>
          <li>
    <a href=""/news/audio/""
    >
        <span>Audio</span>
  </a>
</li>
          <li>
    <a href=""/news/photos/""
    >
        <span>Photos</span>
  </a>
</li>
          </ul>
    </div>
</div>
            <div class=""c16l"">
              <div class=""section"">
    <h3>Subscribe</h3><ul class=""nav"">
        <li>
    <a href=""/news/feeds/""
    >
        <span>Podcasts</span>
  </a>
</li>
          <li>
    <a href=""/news/feeds/rss/""
    >
        <span>RSS Feeds</span>
  </a>
</li>
          <li>
    <a href=""/news/alerts/""
    >
        <span>NewsMail</span>
  </a>
</li>
          </ul>
    </div>
</div>
            <div class=""c16l"">
              <div class=""section"">
    <h3>Connect</h3><ul class=""nav"">
        <li>
    <a href=""/news/engage/""
    >
        <span>Engage</span>
  </a>
</li>
          <li>
    <a href=""/news/upload/""
    >
        <span>Upload</span>
  </a>
</li>
          <li>
    <a href=""/news/contact/""
    >
        <span>Contact Us</span>
  </a>
</li>
          <li>
    <a href=""/news/upload/send/""
    >
        <span>Email/Mobile</span>
  </a>
</li>
          <li>
    <a href=""/news/2011-05-12/suggest/2461656""
    >
        <span>Suggest a Contributor</span>
  </a>
</li>
          </ul>
    </div>
</div>
            <div class=""c16l"">
              <div class=""section"">
    <h3>Feedback</h3><ul class=""nav"">
        <li>
    <a href=""/news/corrections/""
    >
        <span>Corrections &amp; Clarifications</span>
  </a>
</li>
          </ul>
    </div>
</div>
            <div class=""c16l"">
            </div>
          </div>
      </div>
    <!-- right section-->
    <div class=""c25r"">
      <div id=""fineprint"" class=""section"">
        <p>
          <small>This service may include material from Agence France-Presse (AFP), APTN, Reuters, AAP, CNN and the BBC World Service which is copyright and cannot be reproduced.</small>
        </p>
        <p>
          <small>AEST = Australian Eastern Standard Time which is 10 hours ahead of UTC (Greenwich Mean Time)</small>
        </p>
      </div>
    </div>
  </div>
  </div><!-- End footer --></div>
  <!-- Start Webtrends -->
  <div class=""hide"">
    </div>
  <!-- End Webtrends -->
  <!--endnoindex--><!--Global footer-->
  <!--noindex-->
 <div id=""abcFooter"">
  <div id=""abcFooterWrapper"">
   <a id=""abcFooterLogo"" href=""http://www.abc.net.au""><img src=""http://www.abc.net.au/res/abc/logos/footer_logo.png"" width=""112"" height=""34"" alt=""abc.net.au"" /></a>
   <ul id=""abcFooterLinks"">
    <li class=""abcFooterFirst""><a href=""http://www.abc.net.au/"">ABC Home</a></li>
    <li><a href=""http://about.abc.net.au"">About the ABC</a></li>
    <li><a href=""http://www.abc.net.au/careers/"">Careers</a></li>
    <li><a href=""http://www.abc.net.au/services/"">ABC Services</a></li>
    <li><a href=""http://about.abc.net.au/talk-to-the-abc/"">ABC Contacts</a></li>
   </ul>
   <ul id=""abcFooterLegal"">
    <li class=""abcFooterFirst""><a href=""http://www.abc.net.au/copyright.htm"">&#169; 2013 ABC</a></li>
    <li><a href=""http://www.abc.net.au/conditions.htm"">Conditions of Use</a></li>
    <li><a href=""http://www.abc.net.au/privacy.htm"">Privacy Policy</a></li>
   </ul>
  </div>
 </div>
 <script type=""text/javascript"" src=""http://www.abc.net.au/res/libraries/stats/abc.stats.core.js""></script>
 <noscript>
  <img alt=""dcsimg"" id=""dcsimg"" width=""1"" height=""1"" src=""//statse.webtrendslive.com/dcsg85fae000004n0vfjpj8oa_9m4q/njs.gif?dcsuri=/nojavascript&amp;WT.js=No&amp;WT.tv=10.2.10&amp;dcssip=www.abc.net.au"" />
 </noscript>
 <!-- START Nielsen Online SiteCensus V6.0 -->
 <!-- COPYRIGHT 2010 Nielsen Online -->
 <script type=""text/javascript"" src=""//secure-au.imrworldwide.com/v60.js""></script>
 <script type=""text/javascript"">
  var pvar = { cid: ""abc-aust"", content: ""0"", server: ""secure-au"" };
  var trac = nol_t(pvar);
  trac.record().post();
 </script>
 <noscript>
  <div>
   <img src=""//secure-au.imrworldwide.com/cgi-bin/m?ci=abc-aust&amp;cg=0&amp;cc=1&amp;ts=noscript"" width=""1"" height=""1"" alt="""" />
  </div>
 </noscript>
 <!-- END Nielsen Online SiteCensus V6.0 -->
<!--endnoindex-->
<!--end global footer-->
  </body>
  </html>
";
            }
        }
    }
}
