using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmailSentimentAnalysisWebsite.Domain.Models;

namespace EmailSentimentAnalysisWebsite.Domain
{
    public class EmailQueryService : IEmailQueryService
    {
        public EmailQueryService()
        {
        }

        public Task<IEnumerable<EmailSentimentModel>> GetLatestEmailSentimentAsync()
        {
            #region DummyData
            var dummyList = new List<EmailSentimentModel>();
            dummyList.Add(new EmailSentimentModel {
                FromAddresses = "paul.glavich@readify.net<Paul Glavich>",
                AnalysedTimestampUtc = DateTime.UtcNow,
                SentimentCssClass="test",

                OrignalBody = "<html xmlns:v=\"urn:schemas-microsoft-com:vml\" xmlns:o=\"urn:schemas-microsoft-com:office:office\" xmlns:w=\"urn:schemas-microsoft-com:office:word\" xmlns:m=\"http://schemas.microsoft.com/office/2004/12/omml\" xmlns=\"http://www.w3.org/TR/REC-html40\">\r\n<head>\r\n<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">\r\n<meta name=\"Generator\" content=\"Microsoft Word 15 (filtered medium)\">\r\n<!--[if !mso]><style>v\\:* {behavior:url(#default#VML);}\r\no\\:* {behavior:url(#default#VML);}\r\nw\\:* {behavior:url(#default#VML);}\r\n.shape {behavior:url(#default#VML);}\r\n</style><![endif]--><style><!--\r\n/* Font Definitions */\r\n@font-face\r\n\t{font-family:Wingdings;\r\n\tpanose-1:5 0 0 0 0 0 0 0 0 0;}\r\n@font-face\r\n\t{font-family:\"Cambria Math\";\r\n\tpanose-1:2 4 5 3 5 4 6 3 2 4;}\r\n@font-face\r\n\t{font-family:Calibri;\r\n\tpanose-1:2 15 5 2 2 2 4 3 2 4;}\r\n/* Style Definitions */\r\np.MsoNormal, li.MsoNormal, div.MsoNormal\r\n\t{margin:0cm;\r\n\tmargin-bottom:.0001pt;\r\n\tfont-size:11.0pt;\r\n\tfont-family:\"Calibri\",sans-serif;}\r\nh3\r\n\t{mso-style-priority:9;\r\n\tmso-style-link:\"Heading 3 Char\";\r\n\tmso-margin-top-alt:auto;\r\n\tmargin-right:0cm;\r\n\tmso-margin-bottom-alt:auto;\r\n\tmargin-left:0cm;\r\n\tfont-size:13.5pt;\r\n\tfont-family:\"Calibri\",sans-serif;\r\n\tfont-weight:bold;}\r\na:link, span.MsoHyperlink\r\n\t{mso-style-priority:99;\r\n\tcolor:blue;\r\n\ttext-decoration:underline;}\r\na:visited, span.MsoHyperlinkFollowed\r\n\t{mso-style-priority:99;\r\n\tcolor:purple;\r\n\ttext-decoration:underline;}\r\ncode\r\n\t{mso-style-priority:99;\r\n\tfont-family:\"Calibri\",sans-serif;\r\n\tcolor:#C7254E;\r\n\tbackground:#F9F2F4;}\r\np.msonormal0, li.msonormal0, div.msonormal0\r\n\t{mso-style-name:msonormal;\r\n\tmso-margin-top-alt:auto;\r\n\tmargin-right:0cm;\r\n\tmso-margin-bottom-alt:auto;\r\n\tmargin-left:0cm;\r\n\tfont-size:11.0pt;\r\n\tfont-family:\"Calibri\",sans-serif;}\r\nspan.Heading3Char\r\n\t{mso-style-name:\"Heading 3 Char\";\r\n\tmso-style-priority:9;\r\n\tmso-style-link:\"Heading 3\";\r\n\tfont-family:\"Calibri Light\",sans-serif;\r\n\tcolor:#1F3763;}\r\nspan.EmailStyle21\r\n\t{mso-style-type:personal-reply;\r\n\tfont-family:\"Calibri\",sans-serif;}\r\n.MsoChpDefault\r\n\t{mso-style-type:export-only;\r\n\tfont-size:10.0pt;}\r\n@page WordSection1\r\n\t{size:612.0pt 792.0pt;\r\n\tmargin:72.0pt 72.0pt 72.0pt 72.0pt;}\r\ndiv.WordSection1\r\n\t{page:WordSection1;}\r\n/* List Definitions */\r\n@list l0\r\n\t{mso-list-id:17587163;\r\n\tmso-list-template-ids:1880514492;}\r\n@list l0:level1\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:36.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Symbol;}\r\n@list l0:level2\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:o;\r\n\tmso-level-tab-stop:72.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:\"Courier New\";\r\n\tmso-bidi-font-family:\"Times New Roman\";}\r\n@list l0:level3\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:108.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l0:level4\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:144.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l0:level5\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:180.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l0:level6\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:216.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l0:level7\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:252.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l0:level8\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:288.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l0:level9\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:324.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l1\r\n\t{mso-list-id:864752426;\r\n\tmso-list-template-ids:-405908206;}\r\n@list l1:level1\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:36.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Symbol;}\r\n@list l1:level2\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:o;\r\n\tmso-level-tab-stop:72.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:\"Courier New\";\r\n\tmso-bidi-font-family:\"Times New Roman\";}\r\n@list l1:level3\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:108.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l1:level4\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:144.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l1:level5\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:180.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l1:level6\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:216.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l1:level7\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:252.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l1:level8\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:288.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l1:level9\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:324.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l2\r\n\t{mso-list-id:1355038917;\r\n\tmso-list-template-ids:-72479602;}\r\n@list l2:level1\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:36.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Symbol;}\r\n@list l2:level2\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:o;\r\n\tmso-level-tab-stop:72.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:\"Courier New\";\r\n\tmso-bidi-font-family:\"Times New Roman\";}\r\n@list l2:level3\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:108.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l2:level4\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:144.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l2:level5\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:180.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l2:level6\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:216.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l2:level7\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:252.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l2:level8\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:288.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l2:level9\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:324.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l3\r\n\t{mso-list-id:1992709543;\r\n\tmso-list-template-ids:2099831332;}\r\n@list l3:level1\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:36.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Symbol;}\r\n@list l3:level2\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:o;\r\n\tmso-level-tab-stop:72.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:\"Courier New\";\r\n\tmso-bidi-font-family:\"Times New Roman\";}\r\n@list l3:level3\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:108.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l3:level4\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:144.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l3:level5\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:180.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l3:level6\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:216.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l3:level7\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:252.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l3:level8\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:288.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l3:level9\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:324.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l4\r\n\t{mso-list-id:2111507262;\r\n\tmso-list-template-ids:-65241488;}\r\n@list l4:level1\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:36.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Symbol;}\r\n@list l4:level2\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:o;\r\n\tmso-level-tab-stop:72.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:\"Courier New\";\r\n\tmso-bidi-font-family:\"Times New Roman\";}\r\n@list l4:level3\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:108.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l4:level4\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:144.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l4:level5\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:180.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l4:level6\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:216.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l4:level7\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:252.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l4:level8\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:288.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\n@list l4:level9\r\n\t{mso-level-number-format:bullet;\r\n\tmso-level-text:;\r\n\tmso-level-tab-stop:324.0pt;\r\n\tmso-level-number-position:left;\r\n\ttext-indent:-18.0pt;\r\n\tmso-ansi-font-size:10.0pt;\r\n\tfont-family:Wingdings;}\r\nol\r\n\t{margin-bottom:0cm;}\r\nul\r\n\t{margin-bottom:0cm;}\r\n--></style><!--[if gte mso 9]><xml>\r\n<o:shapedefaults v:ext=\"edit\" spidmax=\"1026\" />\r\n</xml><![endif]--><!--[if gte mso 9]><xml>\r\n<o:shapelayout v:ext=\"edit\">\r\n<o:idmap v:ext=\"edit\" data=\"1\" />\r\n</o:shapelayout></xml><![endif]-->\r\n</head>\r\n<body lang=\"EN-AU\" link=\"blue\" vlink=\"purple\">\r\n<div class=\"WordSection1\">\r\n<p class=\"MsoNormal\"><span style=\"mso-fareast-language:EN-US\"><o:p>&nbsp;</o:p></span></p>\r\n<p class=\"MsoNormal\"><span style=\"mso-fareast-language:EN-US\"><o:p>&nbsp;</o:p></span></p>\r\n<div>\r\n<p class=\"MsoNormal\"><b><span lang=\"EN-GB\" style=\"color:black\">Paul Glavich</span></b><span lang=\"EN-GB\" style=\"color:black\">&nbsp;</span><span style=\"color:black\">|&nbsp;</span><b><span lang=\"EN-GB\" style=\"color:black\">Readify&nbsp;</span></b><span lang=\"EN-GB\" style=\"color:black\">Principal\r\n Consultant, NSW&nbsp;</span><span style=\"color:black\">|&nbsp;<b>m&nbsp;</b>&#43;61 413 0413 61|<o:p></o:p></span></p>\r\n<p class=\"MsoNormal\"><b><span style=\"font-size:11.5pt;color:black\">e</span></b><b><span style=\"color:black\">&nbsp;</span></b><a href=\"mailto:paul.glavich@readify.net\"><span lang=\"EN-GB\" style=\"color:#0563C1\">paul.glavich@readify.net</span></a><b><span lang=\"EN-GB\" style=\"color:black\">&nbsp;</span></b><span lang=\"EN-GB\" style=\"color:black\">|&nbsp;<b>w&nbsp;</b></span><a href=\"http://www.readify.net/links/readify\"><span style=\"color:#0563C1\">readify.net</span></a><span style=\"font-size:10.5pt;color:black\"><o:p></o:p></span></p>\r\n</div>\r\n<p class=\"MsoNormal\"><span style=\"mso-fareast-language:EN-US\"><o:p>&nbsp;</o:p></span></p>\r\n<div>\r\n<div style=\"border:none;border-top:solid #E1E1E1 1.0pt;padding:3.0pt 0cm 0cm 0cm\">\r\n<p class=\"MsoNormal\"><b><span lang=\"EN-US\">From:</span></b><span lang=\"EN-US\"> updates@readify.net &lt;updates@readify.net&gt;\r\n<b>On Behalf Of </b>Erhan Cakirman<br>\r\n<b>Sent:</b> Monday, 26 November 2018 9:26 AM<br>\r\n<b>Subject:</b> [Weekly Update] Woolworths - WooliesX - Search as a Service (WE 23/11/18)<o:p></o:p></span></p>\r\n</div>\r\n</div>\r\n<p class=\"MsoNormal\"><o:p>&nbsp;</o:p></p>\r\n<div>\r\n<p class=\"MsoNormal\"><span style=\"font-size:1.0pt\"><img border=\"0\" width=\"1\" height=\"1\" style=\"width:.0104in;height:.0104in\" id=\"_x0000_i1025\" src=\"https://mailtrack.readify.net/q/zKbrApzsf2v3Il6jL8sDmA~~/AACpWwA~/RgRd3FT3PVcDc3BjQgoAAHch-1vT7N8lUhhwYXVsLmdsYXZpY2hAcmVhZGlmeS5uZXRYBAAAAAU~\"><o:p></o:p></span></p>\r\n</div>\r\n<h3>Issues<o:p></o:p></h3>\r\n<div id=\"issues\">\r\n<ul type=\"disc\">\r\n<li class=\"MsoNormal\" style=\"mso-margin-top-alt:auto;mso-margin-bottom-alt:auto;mso-list:l2 level1 lfo1\">\r\n<code><span style=\"font-size:10.0pt\">[Current]</span></code> <code><span style=\"font-size:10.0pt\">[Medium]</span></code>\r\n<code><span style=\"font-size:10.0pt\">[19/10/18]</span></code> Architecture is partially defined and not implemented\r\n<o:p></o:p></li></ul>\r\n<ul type=\"disc\">\r\n<ul type=\"circle\">\r\n<li class=\"MsoNormal\" style=\"color:black;mso-margin-top-alt:auto;mso-margin-bottom-alt:auto;mso-list:l2 level2 lfo1\">\r\n<code><span style=\"font-size:10.0pt\">[19/10/18]</span></code> The data ingestion will work on top of a message bus, but this is barely documented and no one has a clear vision on how to migrate the current scheduled tasks to that. This can slow us down as is\r\n expected from our team to have a &quot;real-time&quot; ingestion system.<o:p></o:p></li></ul>\r\n</ul>\r\n</div>\r\n<h3>Opportunities<o:p></o:p></h3>\r\n<div id=\"opportunities\">\r\n<ul type=\"disc\">\r\n<li class=\"MsoNormal\" style=\"mso-margin-top-alt:auto;mso-margin-bottom-alt:auto;mso-list:l1 level1 lfo2\">\r\n<code><b><span style=\"font-size:10.0pt\">[Long shot]</span></b></code><b> </b><code><b><span style=\"font-size:10.0pt\">[15/10/18]</span></b></code><b> Data Science practice\r\n<o:p></o:p></b></li></ul>\r\n<ul type=\"disc\">\r\n<ul type=\"circle\">\r\n<li class=\"MsoNormal\" style=\"color:black;mso-margin-top-alt:auto;mso-margin-bottom-alt:auto;mso-list:l1 level2 lfo2\">\r\n<code><b><span style=\"font-size:10.0pt\">[26/11/18]</span></b></code><b> A new woolies member joined the team to replace the current data scientist. A lot of knowledge sharing is in progress right now<o:p></o:p></b></li><li class=\"MsoNormal\" style=\"color:black;mso-margin-top-alt:auto;mso-margin-bottom-alt:auto;mso-list:l1 level2 lfo2\">\r\n<code><span style=\"font-size:10.0pt\">[19/11/18]</span></code> Data scientist resigned, might be an opportunity there to help woolies in this area<o:p></o:p></li><li class=\"MsoNormal\" style=\"color:#404040;mso-margin-top-alt:auto;mso-margin-bottom-alt:auto;mso-list:l1 level2 lfo2\">\r\n<code><span style=\"font-size:10.0pt\">[19/10/18]</span></code> This week we found that WooliesX have only one data scientist and the whole company send requests directly to him, the guy is always overwhelmed with work<o:p></o:p></li><li class=\"MsoNormal\" style=\"color:#404040;mso-margin-top-alt:auto;mso-margin-bottom-alt:auto;mso-list:l1 level2 lfo2\">\r\n<code><span style=\"font-size:10.0pt\">[15/10/18]</span></code> Readify D&amp;A can help woolies with the user personalisation work<o:p></o:p></li></ul>\r\n</ul>\r\n</div>\r\n<h3>This Week<o:p></o:p></h3>\r\n<ul type=\"disc\">\r\n<li class=\"MsoNormal\" style=\"mso-margin-top-alt:auto;mso-margin-bottom-alt:auto;mso-list:l3 level1 lfo3\">\r\nLuiz started working on suggestion ingestions<o:p></o:p></li><li class=\"MsoNormal\" style=\"mso-margin-top-alt:auto;mso-margin-bottom-alt:auto;mso-list:l3 level1 lfo3\">\r\nThe new suggestions revealed a bug(ish) behaviour on the site, team is discussing how to approach this<o:p></o:p></li><li class=\"MsoNormal\" style=\"mso-margin-top-alt:auto;mso-margin-bottom-alt:auto;mso-list:l3 level1 lfo3\">\r\nErhan started to integrate recommendation engine to current search<o:p></o:p></li><li class=\"MsoNormal\" style=\"mso-margin-top-alt:auto;mso-margin-bottom-alt:auto;mso-list:l3 level1 lfo3\">\r\nHad a meeting with stakeholders and talked about the current search, our approach/plan and what we are trying to deliver<o:p></o:p></li></ul>\r\n<h3>Next Week<o:p></o:p></h3>\r\n<ul type=\"disc\">\r\n<li class=\"MsoNormal\" style=\"mso-margin-top-alt:auto;mso-margin-bottom-alt:auto;mso-list:l4 level1 lfo4\">\r\nLuiz will continue working on suggestion ingestion<o:p></o:p></li><li class=\"MsoNormal\" style=\"mso-margin-top-alt:auto;mso-margin-bottom-alt:auto;mso-list:l4 level1 lfo4\">\r\nErhan will continuw working on recommendation engine integration<o:p></o:p></li></ul>\r\n<div id=\"clientName\">\r\n<h3><a href=\"https://mailtrack.readify.net/f/a/kL9BYGq38fOC9BltWW8rQw~~/AACpWwA~/RgRd3FT3P0QYaHR0cDovL3dvb2x3b3J0aHMuY29tLmF1VwNzcGNCCgAAdyH7W9Ps3yVSGHBhdWwuZ2xhdmljaEByZWFkaWZ5Lm5ldFgEAAAABQ~~\" target=\"_blank\">Woolworths (Retail)</a><o:p></o:p></h3>\r\n</div>\r\n<div id=\"clientLogo\">\r\n<p class=\"MsoNormal\"><img border=\"0\" id=\"_x0000_i1026\" src=\"https://logo-core.clearbit.com/woolworths.com.au\"><o:p></o:p></p>\r\n</div>\r\n<div id=\"clientDescription\">\r\n<p>From CIO Summit VIC 2015 Lead Import<o:p></o:p></p>\r\n</div>\r\n<h3>Project Background<o:p></o:p></h3>\r\n<p>Search as a Service initiative aims to improve the stability and performance of Woolworths Online Search. It sets up the foundations for a scalable, personalised and relevant search experience.<o:p></o:p></p>\r\n<p>The first phase of the SaaS separates the Search function from Trader to provide a channel agnostic API service that will give the customer a seamless experience across all touch points and migrate the batch ingestion process to a real-time platform. The\r\n real-time mechanism scales the ingestion process to expand the number of products in the search like that required for In-store search (from 20k SKUs to 70k SKUs).\r\n<o:p></o:p></p>\r\n<p>The next phase leverages the platform to build personalised and relevant search.<o:p></o:p></p>\r\n<p>Woolworths Online needs a dedicated team to deliver on Phase 1 and 2. The aim is to create a small team which will deliver quickly without the overhead of administrative functions.\r\n<o:p></o:p></p>\r\n<h3>Team<o:p></o:p></h3>\r\n<ul type=\"disc\">\r\n<li class=\"MsoNormal\" style=\"mso-margin-top-alt:auto;mso-margin-bottom-alt:auto;mso-list:l0 level1 lfo5\">\r\nErhan Cakirman<o:p></o:p></li><li class=\"MsoNormal\" style=\"mso-margin-top-alt:auto;mso-margin-bottom-alt:auto;mso-list:l0 level1 lfo5\">\r\nLuiz Bon<o:p></o:p></li></ul>\r\n<p>&nbsp;<o:p></o:p></p>\r\n<p><code><span style=\"font-size:7.0pt\">Powered by <a href=\"https://mailtrack.readify.net/f/a/ecTrqpslMBBzW_blKO84_w~~/AACpWwA~/RgRd3FT3P0QhaHR0cHM6Ly91cGRhdGVzLnJlYWRpZnljbG91ZC5jb20vVwNzcGNCCgAAdyH7W9Ps3yVSGHBhdWwuZ2xhdmljaEByZWFkaWZ5Lm5ldFgEAAAABQ~~\">\r\nReadiUpdates</a> (<a href=\"https://mailtrack.readify.net/f/a/YUGbuKVaufxUNoNrXlhqKg~~/AACpWwA~/RgRd3FT3P0RAaHR0cHM6Ly91cGRhdGVzLnJlYWRpZnljbG91ZC5jb20vTWFuYWdlV2Vla2x5VXBkYXRlU3Vic2NyaXB0aW9uc1cDc3BjQgoAAHch-1vT7N8lUhhwYXVsLmdsYXZpY2hAcmVhZGlmeS5uZXRYBAAAAAU~\">change\r\n your subscription settings</a>)</span></code><o:p></o:p></p>\r\n<p class=\"MsoNormal\"><img border=\"0\" width=\"1\" height=\"1\" style=\"width:.0104in;height:.0104in\" id=\"_x0000_i1027\" src=\"https://mailtrack.readify.net/q/pKExROIOSZ8FghioY7HKNQ~~/AACpWwA~/RgRd3FT3PlcDc3BjQgoAAHch-1vT7N8lUhhwYXVsLmdsYXZpY2hAcmVhZGlmeS5uZXRYBAAAAAU~\"><o:p></o:p></p>\r\n</div>\r\n</body>\r\n</html>\r\n",
                SanitisedBody = "\r\n\r\n&nbsp;\r\n&nbsp;\r\n\r\nPaul Glavich&nbsp;|&nbsp;Readify&nbsp;Principal\r\n Consultant, NSW&nbsp;|&nbsp;m&nbsp;&#43;61 413 0413 61|\r\ne&nbsp;paul.glavich@readify.net&nbsp;|&nbsp;w&nbsp;readify.net\r\n\r\n&nbsp;\r\n\r\n\r\nFrom: updates@readify.net &lt;updates@readify.net&gt;\r\nOn Behalf Of Erhan Cakirman\r\nSent: Monday, 26 November 2018 9:26 AM\r\nSubject: [Weekly Update] Woolworths - WooliesX - Search as a Service (WE 23/11/18)\r\n\r\n\r\n&nbsp;\r\n\r\n\r\n\r\nIssues\r\n\r\n\r\n\r\n[Current] [Medium]\r\n[19/10/18] Architecture is partially defined and not implemented\r\n\r\n\r\n\r\n\r\n[19/10/18] The data ingestion will work on top of a message bus, but this is barely documented and no one has a clear vision on how to migrate the current scheduled tasks to that. This can slow us down as is\r\n expected from our team to have a &quot;real-time&quot; ingestion system.\r\n\r\n\r\nOpportunities\r\n\r\n\r\n\r\n[Long shot] [15/10/18] Data Science practice\r\n\r\n\r\n\r\n\r\n[26/11/18] A new woolies member joined the team to replace the current data scientist. A lot of knowledge sharing is in progress right now\r\n[19/11/18] Data scientist resigned, might be an opportunity there to help woolies in this area\r\n[19/10/18] This week we found that WooliesX have only one data scientist and the whole company send requests directly to him, the guy is always overwhelmed with work\r\n[15/10/18] Readify D&amp;A can help woolies with the user personalisation work\r\n\r\n\r\nThis Week\r\n\r\n\r\nLuiz started working on suggestion ingestions\r\nThe new suggestions revealed a bug(ish) behaviour on the site, team is discussing how to approach this\r\nErhan started to integrate recommendation engine to current search\r\nHad a meeting with stakeholders and talked about the current search, our approach/plan and what we are trying to deliver\r\nNext Week\r\n\r\n\r\nLuiz will continue working on suggestion ingestion\r\nErhan will continuw working on recommendation engine integration\r\n\r\nWoolworths (Retail)\r\n\r\n\r\n\r\n\r\n\r\nFrom CIO Summit VIC 2015 Lead Import\r\n\r\nProject Background\r\nSearch as a Service initiative aims to improve the stability and performance of Woolworths Online Search. It sets up the foundations for a scalable, personalised and relevant search experience.\r\nThe first phase of the SaaS separates the Search function from Trader to provide a channel agnostic API service that will give the customer a seamless experience across all touch points and migrate the batch ingestion process to a real-time platform. The\r\n real-time mechanism scales the ingestion process to expand the number of products in the search like that required for In-store search (from 20k SKUs to 70k SKUs).\r\n\r\nThe next phase leverages the platform to build personalised and relevant search.\r\nWoolworths Online needs a dedicated team to deliver on Phase 1 and 2. The aim is to create a small team which will deliver quickly without the overhead of administrative functions.\r\n\r\nTeam\r\n\r\n\r\nErhan Cakirman\r\nLuiz Bon\r\n&nbsp;\r\nPowered by \r\nReadiUpdates (change\r\n your subscription settings)\r\n\r\n\r\n",
                SentimentClassification = 0.5,
                SentimentKeyPhrases = "nbsp,current search,Search function,store search,data ingestion,relevant search experience,current data scientist,performance of Woolworths Online Search,dedicated team,small team,ingestion system,Woolworths - WooliesX,phase,batch ingestion process,real-time platform,current scheduled tasks,Behalf Of Erhan Cakirman,Data Science practice,quot,real-time mechanism,new woolies member,Service initiative,Luiz Bon,SKUs,approach,recommendation engine integration,user personalisation work,seamless experience,channel agnostic API service,new suggestions,Readify D,suggestion ingestions,Trader,touch points,stability,customer,CIO Summit VIC,Weekly Update,Lead Import,bug,behaviour,continuw,SaaS,number of products,lot of knowledge sharing,progress,requests,Retail,Subject,site,amp,company,stakeholders,plan,NSW,Paul Glavich,Principal,overhead of administrative functions,foundations,guy,aim,Consultant,opportunity,clear vision,gt,message bus,Long shot,Project Background,ReadiUpdates,change,subscription settings,meeting,area,Issues,Architecture,Opportunities",
                Subject = "FW: [Weekly Update] Woolworths - WooliesX - Search as a Service (WE 23/11/18)",
                ToAddresses = "emailsentiment@theglavs.com<emailsentiment@theglavs.com>"
            });
            dummyList.Add(new EmailSentimentModel {
                FromAddresses = "glav@theglavs.com",
                AnalysedTimestampUtc = DateTime.UtcNow.AddHours(-1),
                OrignalBody = "<html xmlns:v=\"urn:schemas-microsoft-com:vml\" xmlns:o=\"urn:schemas-microsoft-com:office:office\" xmlns:w=\"urn:schemas-microsoft-com:office:word\" xmlns:m=\"http://schemas.microsoft.com/office/2004/12/omml\" xmlns=\"http://www.w3.org/TR/REC-html40\"><head><META HTTP-EQUIV=\"Content-Type\" CONTENT=\"text/html; charset=us-ascii\"><meta name=Generator content=\"Microsoft Word 15 (filtered medium)\"><style><!--\r\n/* Font Definitions */\r\n@font-face\r\n\t{font-family:\"Cambria Math\";\r\n\tpanose-1:2 4 5 3 5 4 6 3 2 4;}\r\n@font-face\r\n\t{font-family:Calibri;\r\n\tpanose-1:2 15 5 2 2 2 4 3 2 4;}\r\n/* Style Definitions */\r\np.MsoNormal, li.MsoNormal, div.MsoNormal\r\n\t{margin:0cm;\r\n\tmargin-bottom:.0001pt;\r\n\tfont-size:11.0pt;\r\n\tfont-family:\"Calibri\",sans-serif;\r\n\tmso-fareast-language:EN-US;}\r\na:link, span.MsoHyperlink\r\n\t{mso-style-priority:99;\r\n\tcolor:#0563C1;\r\n\ttext-decoration:underline;}\r\na:visited, span.MsoHyperlinkFollowed\r\n\t{mso-style-priority:99;\r\n\tcolor:#954F72;\r\n\ttext-decoration:underline;}\r\nspan.EmailStyle17\r\n\t{mso-style-type:personal-compose;\r\n\tfont-family:\"Calibri\",sans-serif;}\r\n.MsoChpDefault\r\n\t{mso-style-type:export-only;\r\n\tfont-family:\"Calibri\",sans-serif;\r\n\tmso-fareast-language:EN-US;}\r\n@page WordSection1\r\n\t{size:612.0pt 792.0pt;\r\n\tmargin:72.0pt 72.0pt 72.0pt 72.0pt;}\r\ndiv.WordSection1\r\n\t{page:WordSection1;}\r\n--></style><!--[if gte mso 9]><xml>\r\n<o:shapedefaults v:ext=\"edit\" spidmax=\"1026\" />\r\n</xml><![endif]--><!--[if gte mso 9]><xml>\r\n<o:shapelayout v:ext=\"edit\">\r\n<o:idmap v:ext=\"edit\" data=\"1\" />\r\n</o:shapelayout></xml><![endif]--></head><body lang=EN-AU link=\"#0563C1\" vlink=\"#954F72\"><div class=WordSection1><p class=MsoNormal>Here we go<o:p></o:p></p></div></body></html>",
                SanitisedBody = "Here we go",
                SentimentClassification = 0.708633720874786,
                SentimentKeyPhrases = "",
                Subject = "Ok, again1",
                ToAddresses = "emailsentiment@theglavs.com"
            });
            dummyList.Add(new EmailSentimentModel {
                FromAddresses = "glav@theglavs.com",
                AnalysedTimestampUtc = DateTime.UtcNow.AddHours(-2),
                OrignalBody = "",
                SanitisedBody = "This is suckiness",
                SentimentClassification = 0.41,
                SentimentKeyPhrases = "",
                Subject = "Blah, blah",
                ToAddresses = "emailsentiment@theglavs.com"
            });
            dummyList.Add(new EmailSentimentModel {
                FromAddresses = "glav@theglavs.com",
                AnalysedTimestampUtc = DateTime.UtcNow.AddHours(-2),
                OrignalBody = "",
                SanitisedBody = "This is awesome!",
                SentimentClassification = 0.86,
                SentimentKeyPhrases = "",
                Subject = "Woot!",
                ToAddresses = "emailsentiment@theglavs.com"
            });
            #endregion

            dummyList.ForEach(m => {
                m.SentimentCssClass = m.SentimentClassification.ToSentimentStyle();
            });

            return Task.FromResult<IEnumerable<EmailSentimentModel>>(dummyList);
        }
    }
}