#pragma checksum "C:\Users\susma\Desktop\matrimonialProject\matrimonialProject\Views\Home\ReceivedMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "712fff46a6a59c07f6962c604a90b3d4457d2afe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ReceivedMessage), @"mvc.1.0.view", @"/Views/Home/ReceivedMessage.cshtml")]
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
#line 1 "C:\Users\susma\Desktop\matrimonialProject\matrimonialProject\Views\_ViewImports.cshtml"
using matrimonialProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\susma\Desktop\matrimonialProject\matrimonialProject\Views\_ViewImports.cshtml"
using matrimonialProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"712fff46a6a59c07f6962c604a90b3d4457d2afe", @"/Views/Home/ReceivedMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17fac2f7944fee324dab4ca71e63d73dc93cd819", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ReceivedMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<matrimonialProject.ViewModels.MessageViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\susma\Desktop\matrimonialProject\matrimonialProject\Views\Home\ReceivedMessage.cshtml"
  
    ViewData["Title"] = "ReceivedMessage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>ReceivedMessage</h1>\n<table>\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 11 "C:\Users\susma\Desktop\matrimonialProject\matrimonialProject\Views\Home\ReceivedMessage.cshtml"
           Write(Html.DisplayNameFor(model => model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 14 "C:\Users\susma\Desktop\matrimonialProject\matrimonialProject\Views\Home\ReceivedMessage.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 20 "C:\Users\susma\Desktop\matrimonialProject\matrimonialProject\Views\Home\ReceivedMessage.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 24 "C:\Users\susma\Desktop\matrimonialProject\matrimonialProject\Views\Home\ReceivedMessage.cshtml"
               Write(Html.DisplayNameFor(model => model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 27 "C:\Users\susma\Desktop\matrimonialProject\matrimonialProject\Views\Home\ReceivedMessage.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                </td>\n            </tr>\n");
#nullable restore
#line 31 "C:\Users\susma\Desktop\matrimonialProject\matrimonialProject\Views\Home\ReceivedMessage.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n    \n</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<matrimonialProject.ViewModels.MessageViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
