#pragma checksum "C:\Users\thapaliyapr\Desktop\pradeep\DotNet\NINDS IRMB APP\NINDS IRMB APP\Views\Home\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bae9b8cf7f1d33073b149a57865afafee7e8bed6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Profile), @"mvc.1.0.view", @"/Views/Home/Profile.cshtml")]
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
#nullable restore
#line 1 "C:\Users\thapaliyapr\Desktop\pradeep\DotNet\NINDS IRMB APP\NINDS IRMB APP\Views\_ViewImports.cshtml"
using NINDS_IRMB_APP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thapaliyapr\Desktop\pradeep\DotNet\NINDS IRMB APP\NINDS IRMB APP\Views\_ViewImports.cshtml"
using NINDS_IRMB_APP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thapaliyapr\Desktop\pradeep\DotNet\NINDS IRMB APP\NINDS IRMB APP\Views\Home\Profile.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bae9b8cf7f1d33073b149a57865afafee7e8bed6", @"/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ae19afa6b12252059e6eb4b11d74d71749506b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NINDS_IRMB_APP.Models.UserProfile>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\thapaliyapr\Desktop\pradeep\DotNet\NINDS IRMB APP\NINDS IRMB APP\Views\Home\Profile.cshtml"
  
    ViewData["Title"] = "User Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 8 "C:\Users\thapaliyapr\Desktop\pradeep\DotNet\NINDS IRMB APP\NINDS IRMB APP\Views\Home\Profile.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h3>Id: ");
#nullable restore
#line 9 "C:\Users\thapaliyapr\Desktop\pradeep\DotNet\NINDS IRMB APP\NINDS IRMB APP\Views\Home\Profile.cshtml"
   Write(Model.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Display Name: ");
#nullable restore
#line 10 "C:\Users\thapaliyapr\Desktop\pradeep\DotNet\NINDS IRMB APP\NINDS IRMB APP\Views\Home\Profile.cshtml"
             Write(Model.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>UserName: ");
#nullable restore
#line 11 "C:\Users\thapaliyapr\Desktop\pradeep\DotNet\NINDS IRMB APP\NINDS IRMB APP\Views\Home\Profile.cshtml"
         Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<div>\r\n    <pre>\r\n    <code class=\"json\">\r\n        ");
#nullable restore
#line 16 "C:\Users\thapaliyapr\Desktop\pradeep\DotNet\NINDS IRMB APP\NINDS IRMB APP\Views\Home\Profile.cshtml"
   Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model, Newtonsoft.Json.Formatting.Indented)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </code> \r\n</pre>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NINDS_IRMB_APP.Models.UserProfile> Html { get; private set; }
    }
}
#pragma warning restore 1591
