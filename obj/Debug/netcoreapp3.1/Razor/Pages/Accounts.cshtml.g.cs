#pragma checksum "C:\Users\acer\source\repos\MyFirstProject\Pages\Accounts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05e6547fc9248bedb71f3eba828d779d5b6937cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyFirstProject.Pages.Pages_Accounts), @"mvc.1.0.razor-page", @"/Pages/Accounts.cshtml")]
namespace MyFirstProject.Pages
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
#line 1 "C:\Users\acer\source\repos\MyFirstProject\Pages\_ViewImports.cshtml"
using MyFirstProject;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05e6547fc9248bedb71f3eba828d779d5b6937cc", @"/Pages/Accounts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48265038771f2dc70cd398bc348589450407462c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Accounts : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\acer\source\repos\MyFirstProject\Pages\Accounts.cshtml"
  
    ViewData["Title"] = "Accounts";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>");
#nullable restore
#line 6 "C:\Users\acer\source\repos\MyFirstProject\Pages\Accounts.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>You can send donations here for covid-19 patients.</p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccountsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccountsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccountsModel>)PageContext?.ViewData;
        public AccountsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
