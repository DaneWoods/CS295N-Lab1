#pragma checksum "C:\Users\Administrator\Desktop\CS295N\Lab4 Dane Woods\SkeletonSite\Views\Home\Links.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e098820dbf8b61fe235622b4a9a73bc788742750"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Links), @"mvc.1.0.view", @"/Views/Home/Links.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Links.cshtml", typeof(AspNetCore.Views_Home_Links))]
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
#line 1 "C:\Users\Administrator\Desktop\CS295N\Lab4 Dane Woods\SkeletonSite\Views\_ViewImports.cshtml"
using SkeletonSite;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Desktop\CS295N\Lab4 Dane Woods\SkeletonSite\Views\_ViewImports.cshtml"
using SkeletonSite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e098820dbf8b61fe235622b4a9a73bc788742750", @"/Views/Home/Links.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31c7969e56a20dbfada830226a8aceacc115ca50", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Links : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SkeletonSite.Models.Link>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Administrator\Desktop\CS295N\Lab4 Dane Woods\SkeletonSite\Views\Home\Links.cshtml"
  
    Layout = "_TableLayout";

#line default
#line hidden
            BeginContext(83, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e098820dbf8b61fe235622b4a9a73bc7887427503313", async() => {
                BeginContext(89, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 6 "C:\Users\Administrator\Desktop\CS295N\Lab4 Dane Woods\SkeletonSite\Views\Home\Links.cshtml"
     foreach (SkeletonSite.Models.Link l in Model)
    {

#line default
#line hidden
                BeginContext(150, 55, true);
                WriteLiteral("        <tr>\r\n            <td>\r\n                URL: <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 205, "\"", 218, 1);
#line 10 "C:\Users\Administrator\Desktop\CS295N\Lab4 Dane Woods\SkeletonSite\Views\Home\Links.cshtml"
WriteAttributeValue("", 212, l.Url, 212, 6, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(219, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(222, 20, false);
#line 10 "C:\Users\Administrator\Desktop\CS295N\Lab4 Dane Woods\SkeletonSite\Views\Home\Links.cshtml"
                                  Write(ViewBag.Info = l.Url);

#line default
#line hidden
                EndContext();
                BeginContext(243, 40, true);
                WriteLiteral("</a>\r\n            </td>\r\n        </tr>\r\n");
                EndContext();
#line 13 "C:\Users\Administrator\Desktop\CS295N\Lab4 Dane Woods\SkeletonSite\Views\Home\Links.cshtml"
    }

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(297, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SkeletonSite.Models.Link>> Html { get; private set; }
    }
}
#pragma warning restore 1591
