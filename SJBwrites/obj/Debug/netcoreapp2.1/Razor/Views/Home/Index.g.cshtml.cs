#pragma checksum "C:\Users\steph\source\repos\SJBwrites\SJBwrites\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58ba888a6d609dbc715ce7dced03978a7d0eac81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\steph\source\repos\SJBwrites\SJBwrites\Views\_ViewImports.cshtml"
using SJBwrites;

#line default
#line hidden
#line 2 "C:\Users\steph\source\repos\SJBwrites\SJBwrites\Views\_ViewImports.cshtml"
using SJBwrites.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58ba888a6d609dbc715ce7dced03978a7d0eac81", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5729c21cbe4827c2c154355e59ef66d7e42b6803", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<Review>, List<Preview>, List<Feature>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\steph\source\repos\SJBwrites\SJBwrites\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(103, 53, true);
            WriteLiteral("<div class=\"portfolio\">\r\n    <div class=\"features\">\r\n");
            EndContext();
#line 7 "C:\Users\steph\source\repos\SJBwrites\SJBwrites\Views\Home\Index.cshtml"
         foreach (Feature feature in @Model.Item3)
        {
            

#line default
#line hidden
            BeginContext(233, 63, true);
            WriteLiteral("        <div class=\"feature\">\r\n            \r\n            <h1><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 296, "\"", 315, 1);
#line 12 "C:\Users\steph\source\repos\SJBwrites\SJBwrites\Views\Home\Index.cshtml"
WriteAttributeValue("", 303, feature.Url, 303, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(316, 17, true);
            WriteLiteral(" target=\"_blank\">");
            EndContext();
            BeginContext(334, 12, false);
#line 12 "C:\Users\steph\source\repos\SJBwrites\SJBwrites\Views\Home\Index.cshtml"
                                                  Write(feature.Head);

#line default
#line hidden
            EndContext();
            BeginContext(346, 28, true);
            WriteLiteral("</a></h1>\r\n            <div>");
            EndContext();
            BeginContext(375, 12, false);
#line 13 "C:\Users\steph\source\repos\SJBwrites\SJBwrites\Views\Home\Index.cshtml"
            Write(feature.Deck);

#line default
#line hidden
            EndContext();
            BeginContext(387, 43, true);
            WriteLiteral("</div>\r\n            <div class=\"body-text\">");
            EndContext();
            BeginContext(431, 17, false);
#line 14 "C:\Users\steph\source\repos\SJBwrites\SJBwrites\Views\Home\Index.cshtml"
                              Write(feature.StoryBody);

#line default
#line hidden
            EndContext();
            BeginContext(448, 78, true);
            WriteLiteral("</div>\r\n            <div class=\"story-type\">Feature Story</div><div>Published ");
            EndContext();
            BeginContext(527, 39, false);
#line 15 "C:\Users\steph\source\repos\SJBwrites\SJBwrites\Views\Home\Index.cshtml"
                                                                 Write(feature.PublishDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(566, 48, true);
            WriteLiteral("</div>\r\n        </div>\r\n                <hr />\r\n");
            EndContext();
#line 18 "C:\Users\steph\source\repos\SJBwrites\SJBwrites\Views\Home\Index.cshtml"
            
        }

#line default
#line hidden
            BeginContext(639, 40, true);
            WriteLiteral("    </div>\r\n    <div class=\"previews\">\r\n");
            EndContext();
#line 22 "C:\Users\steph\source\repos\SJBwrites\SJBwrites\Views\Home\Index.cshtml"
         foreach (Preview preview in @Model.Item2)
        {
            

#line default
#line hidden
            BeginContext(756, 49, true);
            WriteLiteral("        <div class=\"preview\">\r\n            <h1><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 805, "\"", 824, 1);
#line 26 "C:\Users\steph\source\repos\SJBwrites\SJBwrites\Views\Home\Index.cshtml"
WriteAttributeValue("", 812, preview.Url, 812, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(825, 17, true);
            WriteLiteral(" target=\"_blank\">");
            EndContext();
            BeginContext(843, 18, false);
#line 26 "C:\Users\steph\source\repos\SJBwrites\SJBwrites\Views\Home\Index.cshtml"
                                                  Write(preview.ArtistName);

#line default
#line hidden
            EndContext();
            BeginContext(861, 46, true);
            WriteLiteral("</a></h1>\r\n            <div class=\"body-text\">");
            EndContext();
            BeginContext(908, 17, false);
#line 27 "C:\Users\steph\source\repos\SJBwrites\SJBwrites\Views\Home\Index.cshtml"
                              Write(preview.StoryBody);

#line default
#line hidden
            EndContext();
            BeginContext(925, 103, true);
            WriteLiteral("</div>\r\n            <div class=\"story-type\">Concert Preview</div><div class=\"published-date\">Published ");
            EndContext();
            BeginContext(1029, 39, false);
#line 28 "C:\Users\steph\source\repos\SJBwrites\SJBwrites\Views\Home\Index.cshtml"
                                                                                          Write(preview.PublishDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1068, 48, true);
            WriteLiteral("</div>\r\n        </div>\r\n                <hr />\r\n");
            EndContext();
#line 31 "C:\Users\steph\source\repos\SJBwrites\SJBwrites\Views\Home\Index.cshtml"
            
        }

#line default
#line hidden
            BeginContext(1141, 39, true);
            WriteLiteral("    </div>\r\n    <div class=\"reviews\">\r\n");
            EndContext();
#line 35 "C:\Users\steph\source\repos\SJBwrites\SJBwrites\Views\Home\Index.cshtml"
         foreach (Review review in @Model.Item1)
        {
            

#line default
#line hidden
            BeginContext(1255, 48, true);
            WriteLiteral("        <div class=\"review\">\r\n            <h1><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1303, "\"", 1321, 1);
#line 39 "C:\Users\steph\source\repos\SJBwrites\SJBwrites\Views\Home\Index.cshtml"
WriteAttributeValue("", 1310, review.Url, 1310, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1322, 17, true);
            WriteLiteral(" target=\"_blank\">");
            EndContext();
            BeginContext(1340, 17, false);
#line 39 "C:\Users\steph\source\repos\SJBwrites\SJBwrites\Views\Home\Index.cshtml"
                                                 Write(review.ArtistName);

#line default
#line hidden
            EndContext();
            BeginContext(1357, 28, true);
            WriteLiteral("</a></h1>\r\n            <div>");
            EndContext();
            BeginContext(1386, 12, false);
#line 40 "C:\Users\steph\source\repos\SJBwrites\SJBwrites\Views\Home\Index.cshtml"
            Write(review.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1398, 25, true);
            WriteLiteral("</div>\r\n            <div>");
            EndContext();
            BeginContext(1424, 12, false);
#line 41 "C:\Users\steph\source\repos\SJBwrites\SJBwrites\Views\Home\Index.cshtml"
            Write(review.Label);

#line default
#line hidden
            EndContext();
            BeginContext(1436, 43, true);
            WriteLiteral("</div>\r\n            <div class=\"body-text\">");
            EndContext();
            BeginContext(1480, 16, false);
#line 42 "C:\Users\steph\source\repos\SJBwrites\SJBwrites\Views\Home\Index.cshtml"
                              Write(review.StoryBody);

#line default
#line hidden
            EndContext();
            BeginContext(1496, 103, true);
            WriteLiteral("</div>\r\n            <div class=\"story-type\">Concert Preview</div><div class=\"published-date\">Published ");
            EndContext();
            BeginContext(1600, 38, false);
#line 43 "C:\Users\steph\source\repos\SJBwrites\SJBwrites\Views\Home\Index.cshtml"
                                                                                          Write(review.PublishDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1638, 48, true);
            WriteLiteral("</div>\r\n        </div>\r\n                <hr />\r\n");
            EndContext();
#line 46 "C:\Users\steph\source\repos\SJBwrites\SJBwrites\Views\Home\Index.cshtml"
            
        }

#line default
#line hidden
            BeginContext(1711, 24, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<Review>, List<Preview>, List<Feature>>> Html { get; private set; }
    }
}
#pragma warning restore 1591