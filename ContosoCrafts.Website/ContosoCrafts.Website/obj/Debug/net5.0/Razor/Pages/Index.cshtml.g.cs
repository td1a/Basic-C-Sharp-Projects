#pragma checksum "D:\repos\ContosoCrafts.Website\ContosoCrafts.Website\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bbecee6eb0e1602d3543e1e44934ef989f07a9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ContosoCrafts.Website.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ContosoCrafts.Website.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\repos\ContosoCrafts.Website\ContosoCrafts.Website\Pages\_ViewImports.cshtml"
using ContosoCrafts.Website;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bbecee6eb0e1602d3543e1e44934ef989f07a9b", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db118a47d3e250874f275a02edb59e72b8b81e7e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\repos\ContosoCrafts.Website\ContosoCrafts.Website\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Michael Jackson</h1>

    <h2 id=""animation"">Thriller</h2>
    <div class=""videoframe"" style=""margin-top: 50px;"">
    <!-- video window -->
    <iframe width=""560"" height=""315"" src=""https://www.youtube.com/embed/4V90AmXnguw?si=i8yjCWkBJGZ7Lkbw"" title=""YouTube video player"" frameborder=""0""
            allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share"" referrerpolicy=""strict-origin-when-cross-origin"" allowfullscreen></iframe>
    </div>
</div>

<script>
    // Target text element
    const text = document.getElementById(""animation"");

    // Starting opacity
    let opacity = 1;

    // Fade function
    function fade() {
        // Reduce opacity
        opacity -= 0.01;

        // Apply new opacity 
        text.style.opacity = opacity;

        // Reset opacity  
        if (opacity <= 0) {
            opacity = 1;
        }
    }

    // Call fade every 50ms
    se");
            WriteLiteral("tInterval(fade, 50);\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591