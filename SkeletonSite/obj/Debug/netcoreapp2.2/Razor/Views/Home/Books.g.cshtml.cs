#pragma checksum "C:\Users\Student\Desktop\Dane Woods\MySite\SkeletonSite\Views\Home\Books.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "501c47bfd43ee3bcec3a152574f4c1f6d3fc581b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Books), @"mvc.1.0.view", @"/Views/Home/Books.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Books.cshtml", typeof(AspNetCore.Views_Home_Books))]
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
#line 1 "C:\Users\Student\Desktop\Dane Woods\MySite\SkeletonSite\Views\_ViewImports.cshtml"
using SkeletonSite;

#line default
#line hidden
#line 2 "C:\Users\Student\Desktop\Dane Woods\MySite\SkeletonSite\Views\_ViewImports.cshtml"
using SkeletonSite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"501c47bfd43ee3bcec3a152574f4c1f6d3fc581b", @"/Views/Home/Books.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31c7969e56a20dbfada830226a8aceacc115ca50", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Books : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SkeletonSite.Models.BookDetails>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Student\Desktop\Dane Woods\MySite\SkeletonSite\Views\Home\Books.cshtml"
  
    Layout = "_TableLayout";
    ViewBag.Title = "Books";
    ViewBag.Heading = "Books and print media within the table";
    ViewBag.Header = "Books from: ";

#line default
#line hidden
#line 8 "C:\Users\Student\Desktop\Dane Woods\MySite\SkeletonSite\Views\Home\Books.cshtml"
 foreach (SkeletonSite.Models.BookDetails b in Model)
{

#line default
#line hidden
            BeginContext(281, 44, true);
            WriteLiteral("    <tr>\r\n        <td>\r\n            Author: ");
            EndContext();
            BeginContext(327, 25, false);
#line 12 "C:\Users\Student\Desktop\Dane Woods\MySite\SkeletonSite\Views\Home\Books.cshtml"
                Write(ViewBag.Author = b.Author);

#line default
#line hidden
            EndContext();
            BeginContext(353, 27, true);
            WriteLiteral("<br />\r\n            Title: ");
            EndContext();
            BeginContext(381, 7, false);
#line 13 "C:\Users\Student\Desktop\Dane Woods\MySite\SkeletonSite\Views\Home\Books.cshtml"
              Write(b.Title);

#line default
#line hidden
            EndContext();
            BeginContext(388, 28, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 16 "C:\Users\Student\Desktop\Dane Woods\MySite\SkeletonSite\Views\Home\Books.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SkeletonSite.Models.BookDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591
