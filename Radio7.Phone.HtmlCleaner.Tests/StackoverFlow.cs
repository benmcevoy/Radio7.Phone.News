using HtmlAgilityPack;

namespace Radio7.Phone.HtmlCleaner.Tests
{
    public class StackoverFlow
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
            get { return @"

<!DOCTYPE html>
<html>
<head>
        
    <title>c# - Adding number attribute to every HTML Tag - Stack Overflow</title>
    <link rel=""shortcut icon"" href=""http://cdn.sstatic.net/stackoverflow/img/favicon.ico"">
    <link rel=""apple-touch-icon image_src"" href=""http://cdn.sstatic.net/stackoverflow/img/apple-touch-icon.png"">
    <link rel=""search"" type=""application/opensearchdescription+xml"" title=""Stack Overflow"" href=""/opensearch.xml"">
    
    <script type=""text/javascript"" src=""//ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js""></script>
    <script type=""text/javascript"" src=""http://cdn.sstatic.net/js/stub.js?v=70876234eee5""></script>
    <link rel=""stylesheet"" type=""text/css"" href=""http://cdn.sstatic.net/stackoverflow/all.css?v=74bfa90e1b62"">
    
    <link rel=""canonical"" href=""http://stackoverflow.com/questions/6577570/adding-number-attribute-to-every-html-tag"">
    <link rel=""alternate"" type=""application/atom+xml"" title=""Feed for question 'Adding number attribute to every HTML Tag'"" href=""/feeds/question/6577570"">
    <script type=""text/javascript"">
        
        StackExchange.ready(function () {
            StackExchange.using(""postValidation"", function () {
                StackExchange.postValidation.initOnBlurAndSubmit($('#post-form'), 2, 'answer');
            });

            
            StackExchange.question.init({showAnswerHelp:true,totalCommentCount:3,shownCommentCount:3,highlightColor:'#F4A83D',backgroundColor:'#FFF',questionId:6577570});

            styleCode();

                StackExchange.realtime.subscribeToQuestion('1', '6577570');
            
                
        });
    </script>


    <script type=""text/javascript"">
        StackExchange.init({""stackAuthUrl"":""https://stackauth.com"",""serverTime"":1372577777,""styleCode"":true,""enableUserHovercards"":true,""site"":{""name"":""Stack Overflow"",""description"":""Q&A for professional and enthusiast programmers"",""isNoticesTabEnabled"":true,""recaptchaPublicKey"":""6LdchgIAAAAAAJwGpIzRQSOFaO0pU6s44Xt8aTwc"",""enableSocialMediaInSharePopup"":true},""user"":{""fkey"":""eb8de70d4e5fc9a3c1e2cd6cc3971115"",""isAnonymous"":true}});
        StackExchange.using.setCacheBreakers({""js/prettify-full.js"":""6c261bebf56a"",""js/moderator.js"":""82e0bdb93733"",""js/full-anon.js"":""761e0ff892e6"",""js/full.js"":""96302e0b9d3d"",""js/wmd.js"":""2f79c03846d5"",""js/third-party/jquery.autocomplete.min.js"":""e5f01e97f7c3"",""js/mobile.js"":""e8e23ad37820"",""js/help.js"":""6e6623243cf6"",""js/tageditor.js"":""450c9e8426fc"",""js/tageditornew.js"":""b6c68ad4c7dd"",""js/inline-tag-editing.js"":""8e84e8a137f7"",""js/revisions.js"":""7273bb714bba"",""js/review.js"":""aa4e9e92f60d"",""js/tagsuggestions.js"":""aa48ef6154df"",""js/post-validation.js"":""bb996020492a"",""js/explore-qlist.js"":""1c5bbd79b562""});
        
    </script>
    <script type=""text/javascript"">
        StackExchange.using(""gps"", function() {
             StackExchange.gps.init(true);
        });
    </script>
    
        <script type=""text/javascript"">
            StackExchange.ready(function () {
                $('#nav-tour').click(function () {
                    StackExchange.using(""gps"", function() {
                        StackExchange.gps.track(""aboutpage.click"", { aboutclick_location: ""headermain"" }, true);
                    });
                });
            });
        </script>
</head>
<body class=""question-page"">
    <noscript><div id=""noscript-padding""></div></noscript>
    <div id=""notify-container""></div>
    <div id=""overlay-header""></div>
    <div id=""custom-header""></div>

    <div class=""container"">
        <div id=""header"" class=headeranon>
            <div id=""portalLink"">
                <a class=""genu"" href=""http://stackexchange.com"" onclick=""StackExchange.ready(function(){genuwine.click();});return false;"">Stack Exchange</a>
            </div>
            <div id=""topbar"">
                <div id=""hlinks"">
                    
<span id=""hlinks-user""></span>
<span id=""hlinks-nav"">                        <a href=""/users/login?returnurl=%2fquestions%2f6577570%2fadding-number-attribute-to-every-html-tag"">sign up</a>

 <span class=""lsep"">|</span>
                    <a href=""/users/login?returnurl=%2fquestions%2f6577570%2fadding-number-attribute-to-every-html-tag"">log in</a>

 <span class=""lsep"">|</span>
                    <a href=""http://careers.stackoverflow.com"">careers 2.0</a>

 <span class=""lsep"">|</span>
</span>
<span id=""hlinks-custom""></span>
                </div>
                <div id=""hsearch"">
                    <form id=""search"" action=""/search"" method=""get"" autocomplete=""off"">
                        <div>
                            <input autocomplete=""off"" name=""q"" class=""textbox"" placeholder=""search"" tabindex=""1"" type=""text"" maxlength=""240"" size=""28"" value="""">
                        </div>
                    </form>
                </div>
            </div>
            <br class=""cbt"">
            <div id=""hlogo"">
                <a href=""/"" >
                    Stack Overflow
                </a>
            </div>
            <div id=""hmenus"">
                <div class=""nav mainnavs mainnavsanon"">
                    <ul>
                            <li class=""youarehere""><a id=""nav-questions"" href=""/questions"">Questions</a></li>
                            <li><a id=""nav-tags"" href=""/tags"">Tags</a></li>
                            <li><a id=""nav-tour"" href=""/about"">Tour</a></li>
                            <li><a id=""nav-users"" href=""/users"">Users</a></li>
                    </ul>
                </div>
                <div class=""nav askquestion"">
                    <ul>
                        <li>
                            <a id=""nav-askquestion""  href=""/questions/ask"">Ask Question</a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        



        <div id=""content"">
            

<div itemscope itemtype=""http://schema.org/Article"">
<link itemprop=""image"" href=""http://cdn.sstatic.net/stackoverflow/img/apple-touch-icon.png"">
<!--googleoff: snippet-->
<div id=""herobox-mini"">
    <div id=""hero-content"">
        <span id=""controls"">
            <a href=""/about"" id=""tell-me-more"" class=""button"">Tell me more</a>
            <span id=""close""><a title=""click to dismiss"">&times;</a></span>
        </span>
        <div id=""blurb"">
            <span id=""site-name"">Stack Overflow</span> is a question and answer site for 
            professional and enthusiast programmers. It's 100% free, no registration required.
        </div>        
    </div>
    <script>
        $('#tell-me-more').click(function () {
            var clickSource = $(""body"").attr(""class"") + '-mini';
            if ($(""body"").hasClass(""questions-page"")) {
                clickSource = 'questionpagemini';
            }
            if ($(""body"").hasClass(""home-page"")) {
                clickSource = 'homepagemini';
            }

            StackExchange.using(""gps"", function () {
                StackExchange.gps.track(""aboutpage.click"", { aboutclick_location: clickSource } , true);
            });
        });
        $('#herobox-mini #close').click(function () {
            StackExchange.using(""gps"", function () {
                StackExchange.gps.track(""hero.action"", { hero_action_type: ""close"" }, true);
            });
            $.cookie(""hero"", ""none"", { path: ""/"" });
            var $hero = $(""#herobox-mini"");
            $hero.slideUp('fast', function () { $hero.remove(); });
            return false;
        });
    </script>
</div>
<!--googleon: snippet-->
<div id=""question-header"">
    <h1 itemprop=""name""><a href=""/questions/6577570/adding-number-attribute-to-every-html-tag"" class=""question-hyperlink"">Adding number attribute to every HTML Tag</a></h1>
</div>
<div id=""mainbar"">



<div class=""question"" data-questionid=""6577570""  id=""question"">
    
            <div class=""everyonelovesstackoverflow"" id=""careers1"">
        </div>


    <table>
        <tr>
            <td class=""votecell"">
                

<div class=""vote"">
    <input type=""hidden"" value=""6577570"">
    <a class=""vote-up-off"" title=""This question shows research effort; it is useful and clear"">up vote</a>
    <span class=""vote-count-post "">1</span>
    <a class=""vote-down-off"" title=""This question does not show any research effort; it is unclear or not useful"">down vote</a>
    
    <a class=""star-off"" href=""#"" title=""This is a favorite question (click again to undo)"">favorite</a>
    <div class=""favoritecount""><b></b></div>   

</div>

            </td>
            
<td class=""postcell"">
<div>
    <div class=""post-text"" itemprop=""description"">
        <p>I need to add a custom attribute with incrementing number to every HTML tag in the document, similar to <a href=""http://stackoverflow.com/questions/3606622/adding-an-incrementing-value-attribute-to-every-tag-in-xml-using-script"">this question</a>, but only in HTML, not XML file.</p>

<p>I tried to accomplish it with HTML Agility Pack, here is my code:</p>

<pre><code>        HtmlDocument htmldoc = new HtmlDocument();
        htmldoc.LoadHtml(text);
        var num = 1;
        foreach (HtmlNode node in htmldoc.DocumentNode.DescendantNodes())
        {
            node.Attributes.Add(""gist_num"",(num++).ToString());
        }

        var numberedfilename = Path.GetDirectoryName(fname) + @""\"" + Path.GetFileNameWithoutExtension(fname) + ""-num.htm"";

        htmldoc.Save(numberedfilename);
</code></pre>

<p>But I get a stack overflow exception here in HTML Agility Pack HtmlTextNode class.
I tried several ways to correct this bug by changing the class, but at no avail.</p>

<p>What would you suggest here?</p>

<p>--- edit ---
So, the exception is just ""Stack Overflow"" written to the console.</p>

<p>""Process is terminated due to StackOverflowException.""</p>

<p>Since it is Stack Overflow there is no possibility to get any stack values.
Here is the code where VS shows this exception happening:</p>

<pre><code>    /// &lt;summary&gt;
    /// Gets or Sets the text of the node.
    /// &lt;/summary&gt;
    public string Text
    {
        get
        {
            if (_text == null)
            {
                return base.OuterHtml;
            }
            return _text;
        }
         set { _text = value; }
    }
</code></pre>

<p>So, any ideas?</p>

    </div>
    <div class=""post-taglist"">
        <a href=""/questions/tagged/c%23"" class=""post-tag"" title=""show questions tagged 'c#'"" rel=""tag"">c#</a> <a href=""/questions/tagged/html-agility-pack"" class=""post-tag"" title=""show questions tagged 'html-agility-pack'"" rel=""tag"">html-agility-pack</a> 
    </div>
    <table class=""fw"">
    <tr>
    <td class=""vt"">










<div class=""post-menu""><a href=""/q/6577570"" title=""short permalink to this question"" class=""short-link"" id=""link-post-6577570"">share</a><span class=""lsep"">|</span><a href=""/posts/6577570/edit"" class=""suggest-edit-post"" title="""">improve this question</a></div>        
    </td>
    <td align=""right"" class=""post-signature"">


    <div class=""user-info "">
        <div class=""user-action-time"">
                            <a href=""/posts/6577570/revisions"" title=""show all edits to this post"">edited <span title=""2011-07-05 21:03:06Z"" class=""relativetime"">Jul 5 '11 at 21:03</span></a>

        </div>
        <div class=""user-gravatar32"">
            
        </div>
        <div class=""user-details"">
            <br>
            
        </div>
    </div>
    </td>
    <td class=""post-signature owner"">
        

    <div class=""user-info user-hover"">
        <div class=""user-action-time"">
                                    asked <span title=""2011-07-05 02:43:40Z"" class=""relativetime"">Jul 5 '11 at 2:43</span>
        </div>
        <div class=""user-gravatar32"">
            <a href=""/users/376692/alexander-galkin""><div class=""""><img src=""https://www.gravatar.com/avatar/1059206e9cdfa0201e2f13d43181c730?s=32&d=identicon&r=PG"" alt="""" width=""32"" height=""32""></div></a>
        </div>
        <div class=""user-details"">
            <a href=""/users/376692/alexander-galkin"">Alexander Galkin</a><br>
            <span class=""reputation-score"" title=""reputation score"" dir=""ltr"">3,281</span><span title=""1 gold badge""><span class=""badge1""></span><span class=""badgecount"">1</span></span><span title=""9 silver badges""><span class=""badge2""></span><span class=""badgecount"">9</span></span><span title=""35 bronze badges""><span class=""badge3""></span><span class=""badgecount"">35</span></span>
        </div>
    </div>

    </td>
    </tr>
    </table>
</div>
</td>
        </tr>


<tr>
<td class=""votecell""></td>
<td>
    <div id=""comments-6577570"" class=""comments"">
        <table>
        <tbody>
                    
    <tr id=""comment-7756512"" class=""comment"">
        <td></td>
        <td class=""comment-text""><div><span class=""comment-copy"">Can you post the exception and stack trace?</span> &ndash;&nbsp;<a href=""/users/431359/richard-schneider"" title=""13222 reputation"" class=""comment-user"">Richard Schneider</a> <span class=""comment-date"" dir=""ltr""><span title=""2011-07-05 02:58:47Z"" class=""relativetime-clean"">Jul 5 '11 at 2:58</span></span></div></td>
    </tr>
            
    <tr id=""comment-7756712"" class=""comment"">
        <td></td>
        <td class=""comment-text""><div><span class=""comment-copy"">@Richard I will post it tomorrow from work, I am just back home and don&#39;t have the code at hand -- thank you for your suggestion!</span> &ndash;&nbsp;<a href=""/users/376692/alexander-galkin"" title=""3281 reputation"" class=""comment-user owner"">Alexander Galkin</a> <span class=""comment-date"" dir=""ltr""><span title=""2011-07-05 03:37:35Z"" class=""relativetime-clean"">Jul 5 '11 at 3:37</span></span></div></td>
    </tr>
            
    <tr id=""comment-7772095"" class=""comment"">
        <td></td>
        <td class=""comment-text""><div><span class=""comment-copy"">@Richard I added some info I could get.</span> &ndash;&nbsp;<a href=""/users/376692/alexander-galkin"" title=""3281 reputation"" class=""comment-user owner"">Alexander Galkin</a> <span class=""comment-date"" dir=""ltr""><span title=""2011-07-05 21:03:34Z"" class=""relativetime-clean"">Jul 5 '11 at 21:03</span></span></div></td>
    </tr>

        </tbody>
    
        </table>
    </div>
    
</td>
</tr>            </table>    
</div>


<div id=""answers"">

    <a name=""tab-top""></a>
    <div id=""answers-header"">
        <div class=""subheader answers-subheader"">
            <h2>
                    1 Answer
            </h2>
            <div id=""tabs"">
                <a href=""/questions/6577570/adding-number-attribute-to-every-html-tag?answertab=active#tab-top"" title=""Answers with the latest activity first"">active</a>
<a href=""/questions/6577570/adding-number-attribute-to-every-html-tag?answertab=oldest#tab-top"" title=""Answers in the order they were provided"">oldest</a>
<a class=""youarehere"" href=""/questions/6577570/adding-number-attribute-to-every-html-tag?answertab=votes#tab-top"" title=""Answers with the highest score first"">votes</a>

            </div>
        </div>    
    </div>    




  
<a name=""7782334""></a>
<div id=""answer-7782334"" class=""answer accepted-answer"" data-answerid=""7782334"" >
    <table>
        <tr>
            <td class=""votecell"">
                

<div class=""vote"">
    <input type=""hidden"" value=""7782334"">
    <a class=""vote-up-off"" title=""This answer is useful"">up vote</a>
    <span class=""vote-count-post "">0</span>
    <a class=""vote-down-off"" title=""This answer is not useful"">down vote</a>
    

            <span class=""vote-accepted-on load-accepted-answer-date"" title=""loading when this answer was accepted..."">accepted</span>
</div>

            </td>
            


<td class=""answercell"">
    <div class=""post-text""><p>You need to filter the nodes so you're only selecting the elements.  For some reason, going through the descendants in HTML Agility Pack includes other nodes like document and text nodes incorrectly.  Since you're blindly adding attributes to all nodes, it chokes serializing the non-element nodes.</p>

<pre><code>// note: Descendants() and DescendantNodes() is equivalent (unfortunately)
var query = htmldoc.DocumentNode.Descendants()
    .Where(node =&gt; node.NodeType == HtmlNodeType.Element);
</code></pre>
</div>
    <table class=""fw"">
    <tr>
    <td class=""vt"">










<div class=""post-menu""><a href=""/a/7782334"" title=""short permalink to this answer"" class=""short-link"" id=""link-post-7782334"">share</a><span class=""lsep"">|</span><a href=""/posts/7782334/edit"" class=""suggest-edit-post"" title="""">improve this answer</a></div>                    </td>
    <td align=""right"" class=""post-signature"">


    <div class=""user-info "">
        <div class=""user-action-time"">
                            <a href=""/posts/7782334/revisions"" title=""show all edits to this post"">edited <span title=""2011-10-17 09:03:55Z"" class=""relativetime"">Oct 17 '11 at 9:03</span></a>

        </div>
        <div class=""user-gravatar32"">
            
        </div>
        <div class=""user-details"">
            <br>
            
        </div>
    </div>
    </td>
            


    <td align=""right"" class=""post-signature"">   
       

    

    <div class=""user-info user-hover"">
        <div class=""user-action-time"">
                                        answered <span title=""2011-10-16 04:25:00Z"" class=""relativetime"">Oct 16 '11 at 4:25</span>
        </div>
        <div class=""user-gravatar32"">
            <a href=""/users/390278/jeff-mercado""><div class=""""><img src=""https://www.gravatar.com/avatar/84715fec547362389d02f5be0ed12814?s=32&d=identicon&r=PG"" alt="""" width=""32"" height=""32""></div></a>
        </div>
        <div class=""user-details"">
            <a href=""/users/390278/jeff-mercado"">Jeff Mercado</a><br>
            <span class=""reputation-score"" title=""reputation score 31305"" dir=""ltr"">31.3k</span><span title=""4 gold badges""><span class=""badge1""></span><span class=""badgecount"">4</span></span><span title=""35 silver badges""><span class=""badge2""></span><span class=""badgecount"">35</span></span><span title=""69 bronze badges""><span class=""badge3""></span><span class=""badgecount"">69</span></span>
        </div>
    </div>

    </td>
    </tr>
    </table>
</td>
        </tr>



<tr>
<td class=""votecell""></td>
<td>
    <div id=""comments-7782334"" class=""comments"">
        <table>
        <tbody>
                    
    <tr id=""comment-10048318"" class=""comment"">
        <td></td>
        <td class=""comment-text""><div><span class=""comment-copy"">I can&#39;t check it now, but thank you for an answer. I suggest it is the only answer, so I mark it as a correct one :)</span> &ndash;&nbsp;<a href=""/users/376692/alexander-galkin"" title=""3281 reputation"" class=""comment-user owner"">Alexander Galkin</a> <span class=""comment-date"" dir=""ltr""><span title=""2011-11-18 09:42:04Z"" class=""relativetime-clean"">Nov 18 '11 at 9:42</span></span></div></td>
    </tr>

        </tbody>
    
        </table>
    </div>
    
</td>
</tr>
    </table>
</div>
    <a name='new-answer'></a>
    <form id=""post-form"" action=""/questions/6577570/answer/submit"" method=""post""  class=""post-form"">
        <input type=""hidden"" id=""post-id"" value=""6577570"" />
        <h2 class=""space"">Your Answer</h2>



    
<script type=""text/javascript"">
    StackExchange.ready(function() {
        initTagRenderer("""".split("" ""), """".split("" ""));
         
        prepareEditor({
            heartbeatType: 'answer',
            bindNavPrevention: true,
            postfix: """",
            onDemand: true,
            discardSelector: "".discard-answer""
            ,immediatelyShowMarkdownHelp:true
        });
        

    });  
</script>


<div id=""post-editor"" class=""post-editor"">

    <div style=""position: relative;"">     
        <div class=""wmd-container"">
            <div id=""wmd-button-bar"" class=""wmd-button-bar""></div>
            <textarea id=""wmd-input"" class=""wmd-input"" name=""post-text"" cols=""92"" rows=""15"" tabindex=""101"" data-min-length=""""></textarea>
        </div>
    </div>

    <div class=""fl"" style=""margin-top: 8px; height:24px;"">&nbsp;</div>
    <div id=""draft-saved"" class=""draft-saved community-option fl"" style=""margin-top: 8px; height:24px; display:none;"">draft saved</div>

    <div id=""draft-discarded"" class=""draft-discarded community-option fl"" style=""margin-top: 8px; height:24px; display:none;"">draft discarded</div>



    <div id=""wmd-preview"" class=""wmd-preview""></div>
    <div></div>
    <div class=""edit-block"">
        <input id=""fkey"" name=""fkey"" type=""hidden"" value=""eb8de70d4e5fc9a3c1e2cd6cc3971115"">
        <input id=""author"" name=""author"" type=""text"">
    </div>
</div>
        <div style=""position: relative;""> 
            <div class=""form-item dno new-post-login"">
        
                <div class=""new-login-form"">
                    <div class=""new-login-left"">
                        <h3>Sign up or <a id=""login-link"" href=""/users/login?returnurl=%2fquestions%2f6577570%2fadding-number-attribute-to-every-html-tag%23new-answer"">log in</a></h3>
                        <script type=""text/javascript"">
                            StackExchange.ready(function () {
                                StackExchange.helpers.onClickDraftSave('#login-link');
                            });
                        </script>
                        <div class=""preferred-login google-login"">
                            <p><span class=""icon""></span><span>Sign up using Google</span></p>
                        </div>
                        <div class=""preferred-login facebook-login"">
                            <p><span class=""icon""></span><span>Sign up using Facebook</span></p>
                        </div>
                        <div class=""preferred-login stackexchange-login"">
                            <p><span class=""icon""></span><span>Sign up using Stack Exchange</span></p>
                        </div>
                    </div>
                    <input type=""hidden"" name=""manual-openid"" class=""manual-openid"" />
                    <input type=""hidden"" name=""use-facebook"" class=""use-facebook"" value=""false"" />
                    <input type=""button"" class=""submit-openid"" value=""Submit"" style=""display:none"" />
                    <div class=""new-login-right"">
                                <h3>Post as a guest</h3>
    <div class=""form-item"">
        <table>
        <tr>
                    <script type=""text/javascript"">
                StackExchange.ready(function () {
                    StackExchange.helpers.bindHelpOverlayEvents($('.vm input'));
                });
            </script>
            <td class=""vm"">
                <div>
                    <label for=""display-name"">Name</label>
                    <input id=""display-name"" name=""display-name"" type=""text"" size=""30"" maxlength=""30"" value="""" tabindex=""105"">
                </div>
                <div>
                    <label for=""m-address"">Email</label>
                    <input id=""m-address"" name=""m-address"" type=""text"" size=""30"" maxlength=""100"" value="""" tabindex=""106"">
                    <span class=""edit-field-overlay"">required, but not shown</span>
                </div>
            </td>
        </tr>
        </table>
    </div>

                    </div>
                </div>
            </div>
            <script type=""text/javascript"">
                StackExchange.ready(
                    function () {
                        StackExchange.openid.initPostLogin('.new-post-login', '%2fquestions%2f6577570%2fadding-number-attribute-to-every-html-tag%23new-answer');
                    }
                );
            </script>
            <noscript>
                        <h3>Post as a guest</h3>
    <div class=""form-item"">
        <table>
        <tr>
                    <script type=""text/javascript"">
                StackExchange.ready(function () {
                    StackExchange.helpers.bindHelpOverlayEvents($('.vm input'));
                });
            </script>
            <td class=""vm"">
                <div>
                    <label for=""display-name"">Name</label>
                    <input id=""display-name"" name=""display-name"" type=""text"" size=""30"" maxlength=""30"" value="""" tabindex=""105"">
                </div>
                <div>
                    <label for=""m-address"">Email</label>
                    <input id=""m-address"" name=""m-address"" type=""text"" size=""30"" maxlength=""100"" value="""" tabindex=""106"">
                    <span class=""edit-field-overlay"">required, but not shown</span>
                </div>
            </td>
        </tr>
        </table>
    </div>

            </noscript>
        </div>
           
            <div class=""form-submit cbt"">
            <input id=""submit-button"" type=""submit"" value=""Post Your Answer"" tabindex=""110"">
            <a href=""#"" class=""discard-answer dno"">discard</a>
    <p class=""privacy-policy-agreement"">
        By posting your answer, you agree to the 
        <a href=""http://stackexchange.com/legal/privacy-policy"" target=""_blank"">privacy policy</a> and 
        <a href=""http://stackexchange.com/legal/terms-of-service"" target=""_blank"">terms of service</a>.
    </p>
    <input type=""hidden"" name=""legalLinksShown"" value=""1"" />
        </div>
    </form>



        <h2 class=""bottom-notice"">
                Not the answer you're looking for? 
            Browse other questions tagged <a href=""/questions/tagged/c%23"" class=""post-tag"" title=""show questions tagged 'c#'"" rel=""tag"">c#</a> <a href=""/questions/tagged/html-agility-pack"" class=""post-tag"" title=""show questions tagged 'html-agility-pack'"" rel=""tag"">html-agility-pack</a> 
                or <a href=""/questions/ask"">ask your own question</a>.
        </h2>
</div>
</div>
<div id=""sidebar"" class=""show-votes"">
        <div class=""module question-stats"">
        <p class=""label-key"">tagged</p>
        <div class=""tagged""><a href=""/questions/tagged/c%23"" class=""post-tag"" title=""show questions tagged 'c#'"" rel=""tag"">c#</a>&nbsp;<span class=""item-multiplier""><span class=""item-multiplier-x"">&times;</span>&nbsp;<span class=""item-multiplier-count"">479426</span></span><br>
<a href=""/questions/tagged/html-agility-pack"" class=""post-tag"" title=""show questions tagged 'html-agility-pack'"" rel=""tag"">html-agility-pack</a>&nbsp;<span class=""item-multiplier""><span class=""item-multiplier-x"">&times;</span>&nbsp;<span class=""item-multiplier-count"">1190</span></span><br>
</div>
        <table id=""qinfo"">
            <tr>
                <td><p class=""label-key"">asked</p></td>
                <td style=""padding-left:10px""><p class=""label-key"" title=""2011-07-05 02:43:40Z""><b>1 year ago</b></p></td>
            </tr>
            <tr>
                <td><p class=""label-key"">viewed</p></td>

                <td style=""padding-left:10px"">
                    <p class=""label-key"">
                        <b>215 times</b>
                    </p>
                </td>
            </tr>
            <tr>
                <td><p class=""label-key"">active</p></td>
                <td style=""padding-left:10px""><p class=""label-key""><b><a href=""?lastactivity"" class=""lastactivity-link"" title=""2011-10-17 09:03:55Z"">1 year ago</a></b></p></td>
            </tr>
        </table>
    </div>
        
            <div class=""everyonelovesstackoverflow"" id=""careers2"">
        </div>
    <div id=""hireme"">
        <script type=""text/javascript"">
window.careers_adurl=""http://careers.stackoverflow.com/ad/companyjs"",window.careers_cssurl=""//cdn-careers.sstatic.net/careers/gethired/company.min.css?v=ec3c2143b0e3"",window.careers_cssurl2=""//cdn-careers.sstatic.net/careers/gethired/sidebar.min.css?v=17be6ca0db4b"",window.careers_adselector=""#hireme"",StackExchange.ready(function(){$.ajax({url:""//cdn-careers.sstatic.net/careers/gethired/company-loader.min.js?v=e1da9303f450"",dataType:""script"",cache:!1})})        </script>
    </div>



      
    
    <div class=""module sidebar-linked"">
        <h4 id=""h-linked"">Linked</h4>
        <div class=""linked"" data-tracker=""lq=1"">
            <div class=""spacer"">
<a href=""/q/3606622"" title=""Vote score (upvotes - downvotes)"">
        <div class=""answer-votes answered-accepted default"">0</div>
</a>
<a href=""/questions/3606622/adding-an-incrementing-value-attribute-to-every-tag-in-xml-using-script"" class=""question-hyperlink"">Adding an incrementing value attribute to every tag in xml using script</a>
</div>

        </div>
    </div>
    <div class=""module sidebar-related"">
        <h4 id=""h-related"">Related</h4>
        <div class=""related"" data-tracker=""rq=1"">
            <div class=""spacer"">
<a href=""/q/846994"" title=""Vote score (upvotes - downvotes)"">
        <div class=""answer-votes large"">226</div>
</a>
<a href=""/questions/846994/how-to-use-html-agility-pack"" class=""question-hyperlink"">How to use HTML Agility pack</a>
</div>
<div class=""spacer"">
<a href=""/q/2944107"" title=""Vote score (upvotes - downvotes)"">
        <div class=""answer-votes answered-accepted default"">2</div>
</a>
<a href=""/questions/2944107/htmlagilitypack-giving-problems-with-malformed-html"" class=""question-hyperlink"">HtmlAgilityPack giving problems with malformed html</a>
</div>
<div class=""spacer"">
<a href=""/q/5801828"" title=""Vote score (upvotes - downvotes)"">
        <div class=""answer-votes answered-accepted default"">2</div>
</a>
<a href=""/questions/5801828/html-agility-pack-null-reference"" class=""question-hyperlink"">HTML Agility Pack Null Reference</a>
</div>
<div class=""spacer"">
<a href=""/q/6567484"" title=""Vote score (upvotes - downvotes)"">
        <div class=""answer-votes answered-accepted default"">2</div>
</a>
<a href=""/questions/6567484/how-to-strip-comments-from-html-using-agility-pack-without-losing-doctype"" class=""question-hyperlink"">How to strip comments from HTML using Agility Pack without losing DOCTYPE</a>
</div>
<div class=""spacer"">
<a href=""/q/6852165"" title=""Vote score (upvotes - downvotes)"">
        <div class=""answer-votes default"">2</div>
</a>
<a href=""/questions/6852165/extracting-inner-text-from-html-body-node-with-html-agility-pack"" class=""question-hyperlink"">Extracting Inner text from HTML BODY node with Html Agility Pack</a>
</div>
<div class=""spacer"">
<a href=""/q/8301396"" title=""Vote score (upvotes - downvotes)"">
        <div class=""answer-votes answered-accepted default"">0</div>
</a>
<a href=""/questions/8301396/parsing-html-using-htmlagilitypack"" class=""question-hyperlink"">Parsing HTML using HTMLAgilityPack</a>
</div>
<div class=""spacer"">
<a href=""/q/9093792"" title=""Vote score (upvotes - downvotes)"">
        <div class=""answer-votes answered-accepted default"">1</div>
</a>
<a href=""/questions/9093792/replacing-a-html-div-innertext-tag-using-html-agility-pack"" class=""question-hyperlink"">Replacing a HTML div InnerText tag using HTML Agility Pack</a>
</div>
<div class=""spacer"">
<a href=""/q/13520346"" title=""Vote score (upvotes - downvotes)"">
        <div class=""answer-votes answered-accepted default"">1</div>
</a>
<a href=""/questions/13520346/html-agility-pack-object-reference-not-set-to-an-instance-of-an-object"" class=""question-hyperlink"">html agility pack Object reference not set to an instance of an object</a>
</div>
<div class=""spacer"">
<a href=""/q/14159028"" title=""Vote score (upvotes - downvotes)"">
        <div class=""answer-votes answered-accepted default"">0</div>
</a>
<a href=""/questions/14159028/html-agility-pack-conversion-to-xml-script-corruption"" class=""question-hyperlink"">HTML Agility Pack Conversion to XML &lt;script&gt; corruption</a>
</div>
<div class=""spacer"">
<a href=""/q/14987878"" title=""Vote score (upvotes - downvotes)"">
        <div class=""answer-votes default"">0</div>
</a>
<a href=""/questions/14987878/html-agility-pack-parse-table"" class=""question-hyperlink"">html agility pack parse table</a>
</div>

        </div>
    </div>
</div>

<div id=""feed-link"">
    <div id=""feed-link-text""><a href=""/feeds/question/6577570"" title=""feed of this question and its answers""><span class=""feed-icon""></span>question feed</a></div>
</div>
<script type=""text/javascript"">
StackExchange.ready(function(){$.get('/posts/6577570/ivc/ddc7');});
</script>
<noscript>
    <div><img src=""/posts/6577570/ivc/ddc7"" class=""dno"" alt="""" width=""0"" height=""0""></div>
</noscript><div style=""display:none"" id=""prettify-lang"">lang-cs</div></div>


        </div>
    </div>
    <div id=""footer"" class=""categories"">
        <div class=""footerwrap"">
            <div id=""footer-menu"">
                <div class=""top-footer-links"">
                        <a href=""/about"">about</a>
                    <a href=""/help"">help</a>
                        <a href=""/help/badges"">badges</a>
                    <a href=""http://blog.stackexchange.com?blb=1"">blog</a>
                        <a href=""http://chat.stackoverflow.com"">chat</a>
                    <a href=""http://data.stackexchange.com"">data</a>
                    <a href=""http://stackexchange.com/legal"">legal</a>
                    <a href=""http://stackexchange.com/legal/privacy-policy"">privacy policy</a>
                    <a href=""http://stackexchange.com/about/hiring"">jobs</a>
                    <a href=""http://engine.adzerk.net/redirect/0/2776/2751/0/4de3c60f719c4dfcb1a57531c7050090/0"">advertising info</a>

                    <a onclick='StackExchange.switchMobile(""on"", ""/questions/6577570/adding-number-attribute-to-every-html-tag"")'>mobile</a>
                    <b><a href=""/contact"">contact us</a></b>
                        <b><a href=""http://meta.stackoverflow.com"">feedback</a></b>
                </div>
                <div id=""footer-sites"">
                <table>
    <tr>
            <th colspan=3>
                Technology
            </th>
            <th >
                Life / Arts
            </th>
            <th >
                Culture / Recreation
            </th>
            <th >
                Science
            </th>
            <th >
                Other
            </th>
    </tr>
    <tr>
            <td>
                <ol>
                        <li><a href=""http://stackoverflow.com"" title=""professional and enthusiast programmers"">Stack Overflow</a></li>
                        <li><a href=""http://serverfault.com"" title=""professional system and network administrators"">Server Fault</a></li>
                        <li><a href=""http://superuser.com"" title=""computer enthusiasts and power users"">Super User</a></li>
                        <li><a href=""http://webapps.stackexchange.com"" title=""power users of web applications"">Web Applications</a></li>
                        <li><a href=""http://askubuntu.com"" title=""Ubuntu users and developers"">Ask Ubuntu</a></li>
                        <li><a href=""http://webmasters.stackexchange.com"" title=""pro webmasters"">Webmasters</a></li>
                        <li><a href=""http://gamedev.stackexchange.com"" title=""professional and independent game developers"">Game Development</a></li>
                        <li><a href=""http://tex.stackexchange.com"" title=""users of TeX, LaTeX, ConTeXt, and related typesetting systems"">TeX - LaTeX</a></li>
                            </ol></td><td><ol>
                        <li><a href=""http://programmers.stackexchange.com"" title=""professional programmers interested in conceptual questions about software development"">Programmers</a></li>
                        <li><a href=""http://unix.stackexchange.com"" title=""users of Linux, FreeBSD and other Un*x-like operating systems."">Unix &amp; Linux</a></li>
                        <li><a href=""http://apple.stackexchange.com"" title=""power users of Apple hardware and software"">Ask Different (Apple)</a></li>
                        <li><a href=""http://wordpress.stackexchange.com"" title=""WordPress developers and administrators"">WordPress Answers</a></li>
                        <li><a href=""http://gis.stackexchange.com"" title=""cartographers, geographers and GIS professionals"">Geographic Information Systems</a></li>
                        <li><a href=""http://electronics.stackexchange.com"" title=""electronics and electrical engineering professionals, students, and enthusiasts"">Electrical Engineering</a></li>
                        <li><a href=""http://android.stackexchange.com"" title=""enthusiasts and power users of the Android operating system"">Android Enthusiasts</a></li>
                        <li><a href=""http://security.stackexchange.com"" title=""IT security professionals"">IT Security</a></li>
                            </ol></td><td><ol>
                        <li><a href=""http://dba.stackexchange.com"" title=""database professionals who wish to improve their database skills and learn from others in the community"">Database Administrators</a></li>
                        <li><a href=""http://drupal.stackexchange.com"" title=""Drupal developers and administrators"">Drupal Answers</a></li>
                        <li><a href=""http://sharepoint.stackexchange.com"" title=""SharePoint enthusiasts"">SharePoint</a></li>
                        <li><a href=""http://ux.stackexchange.com"" title=""user experience researchers and experts"">User Experience</a></li>
                        <li><a href=""http://mathematica.stackexchange.com"" title=""users of Mathematica"">Mathematica</a></li>
                    
                        <li>
                            <a href=""http://stackexchange.com/sites#technology"" class=""more"">
                                more (13)
                            </a>
                        </li>
                </ol>
            </td>
            <td>
                <ol>
                        <li><a href=""http://photo.stackexchange.com"" title=""professional, enthusiast and amateur photographers"">Photography</a></li>
                        <li><a href=""http://scifi.stackexchange.com"" title=""science fiction and fantasy enthusiasts"">Science Fiction &amp; Fantasy</a></li>
                        <li><a href=""http://cooking.stackexchange.com"" title=""professional and amateur chefs"">Seasoned Advice (cooking)</a></li>
                        <li><a href=""http://diy.stackexchange.com"" title=""contractors and serious DIYers"">Home Improvement</a></li>
                    
                        <li>
                            <a href=""http://stackexchange.com/sites#lifearts"" class=""more"">
                                more (13)
                            </a>
                        </li>
                </ol>
            </td>
            <td>
                <ol>
                        <li><a href=""http://english.stackexchange.com"" title=""linguists, etymologists, and serious English language enthusiasts"">English Language &amp; Usage</a></li>
                        <li><a href=""http://skeptics.stackexchange.com"" title=""scientific skepticism"">Skeptics</a></li>
                        <li><a href=""http://judaism.stackexchange.com"" title=""those who base their lives on Jewish law and tradition and anyone interested in learning more"">Mi Yodeya (Judaism)</a></li>
                        <li><a href=""http://travel.stackexchange.com"" title=""road warriors and seasoned travelers"">Travel</a></li>
                        <li><a href=""http://christianity.stackexchange.com"" title=""committed Christians, experts in Christianity and those interested in learning more"">Christianity</a></li>
                        <li><a href=""http://gaming.stackexchange.com"" title=""passionate videogamers on all platforms"">Arqade (gaming)</a></li>
                        <li><a href=""http://bicycles.stackexchange.com"" title=""people who build and repair bicycles, people who train cycling, or commute on bicycles"">Bicycles</a></li>
                        <li><a href=""http://rpg.stackexchange.com"" title=""gamemasters and players of tabletop, paper-and-pencil role-playing games"">Role-playing Games</a></li>
                    
                        <li>
                            <a href=""http://stackexchange.com/sites#culturerecreation"" class=""more"">
                                more (21)
                            </a>
                        </li>
                </ol>
            </td>
            <td>
                <ol>
                        <li><a href=""http://mathoverflow.net"" title=""mathematicians"">MathOverflow</a></li>
                        <li><a href=""http://math.stackexchange.com"" title=""people studying math at any level and professionals in related fields"">Mathematics</a></li>
                        <li><a href=""http://stats.stackexchange.com"" title=""statisticians, data analysts, data miners and data visualization experts"">Cross Validated (stats)</a></li>
                        <li><a href=""http://cstheory.stackexchange.com"" title=""theoretical computer scientists and researchers in related fields"">Theoretical Computer Science</a></li>
                        <li><a href=""http://physics.stackexchange.com"" title=""active researchers, academics and students of physics"">Physics</a></li>
                    
                        <li>
                            <a href=""http://stackexchange.com/sites#science"" class=""more"">
                                more (7)
                            </a>
                        </li>
                </ol>
            </td>
            <td>
                <ol>
                        <li><a href=""http://stackapps.com"" title=""apps, scripts, and development with the Stack Exchange API"">Stack Apps</a></li>
                        <li><a href=""http://meta.stackoverflow.com"" title=""meta-discussion of the Stack Exchange family of Q&amp;A websites"">Meta Stack Overflow</a></li>
                        <li><a href=""http://area51.stackexchange.com"" title=""proposing new sites in the Stack Exchange network"">Area 51</a></li>
                        <li><a href=""http://careers.stackoverflow.com"">Stack Overflow Careers</a></li>
                    
                </ol>
            </td>
    </tr>
</table>
                </div>
            </div>

            <div id=""copyright"">
                site design / logo &copy; 2013 stack exchange inc; 
                user contributions licensed under <a href=""http://creativecommons.org/licenses/by-sa/3.0/"" rel=""license"">cc-wiki</a> 
                with <a href=""http://blog.stackoverflow.com/2009/06/attribution-required/"" rel=""license"">attribution required</a>
            </div>
            <div id=""footer-flair"">
                <a href=""http://creativecommons.org/licenses/by-sa/3.0/"" class=""cc-wiki-link""></a>
            </div>
            <div id=""svnrev"">
                rev 2013.6.28.789
            </div>
            
        </div>
    </div>
    <noscript>
        <div id=""noscript-warning"">Stack Overflow works best with JavaScript enabled<img src=""http://pixel.quantserve.com/pixel/p-c1rF4kxgLUzNc.gif"" alt="""" class=""dno""></div>
    </noscript>
    <script type=""text/javascript"">var _gaq=_gaq||[];_gaq.push(['_setAccount','UA-5620270-1']);
        _gaq.push(['_setCustomVar', 1, 'tags', '|c#|html-agility-pack|']); 
_gaq.push(['_trackPageview']);
    var _qevents = _qevents || [];
    (function(){
        var s=document.getElementsByTagName('script')[0];
        var ga=document.createElement('script');
        ga.type='text/javascript';
        ga.async=true;
        ga.src='http://www.google-analytics.com/ga.js';
        s.parentNode.insertBefore(ga,s);
        var sc=document.createElement('script');
        sc.type='text/javascript';
        sc.async=true;
        sc.src='http://edge.quantserve.com/quant.js'; 
        s.parentNode.insertBefore(sc,s);
    })();
    </script>
    <script type=""text/javascript"">
        _qevents.push({ qacct: ""p-c1rF4kxgLUzNc"" });
    </script>        
    
</body>
</html>"; }
        }
    }
}
