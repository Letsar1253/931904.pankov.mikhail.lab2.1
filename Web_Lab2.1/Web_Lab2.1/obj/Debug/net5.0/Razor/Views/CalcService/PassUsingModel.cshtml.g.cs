#pragma checksum "C:\Users\User\source\repos\Web_Lab2.1\Web_Lab2.1\Views\CalcService\PassUsingModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "523f80815a1e2d5715a8c9db5bef2cb44de5c2be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CalcService_PassUsingModel), @"mvc.1.0.view", @"/Views/CalcService/PassUsingModel.cshtml")]
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
#line 1 "C:\Users\User\source\repos\Web_Lab2.1\Web_Lab2.1\Views\_ViewImports.cshtml"
using Web_Lab2._1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\Web_Lab2.1\Web_Lab2.1\Views\_ViewImports.cshtml"
using Web_Lab2._1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"523f80815a1e2d5715a8c9db5bef2cb44de5c2be", @"/Views/CalcService/PassUsingModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06fe98cb5e11b8990aa4c0073de05f467f69570e", @"/Views/_ViewImports.cshtml")]
    public class Views_CalcService_PassUsingModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebLab2._1.Models.CalcValues>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>PassUsingModel</h1>\r\n<div>\r\n    <b>Rand Value First :</b>");
#nullable restore
#line 5 "C:\Users\User\source\repos\Web_Lab2.1\Web_Lab2.1\Views\CalcService\PassUsingModel.cshtml"
                        Write(Model.FirstRandValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n    <b>Rand Value Second :</b> ");
#nullable restore
#line 6 "C:\Users\User\source\repos\Web_Lab2.1\Web_Lab2.1\Views\CalcService\PassUsingModel.cshtml"
                          Write(Model.SecondRandValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n    <b>Add :</b><br>\r\n    ");
#nullable restore
#line 8 "C:\Users\User\source\repos\Web_Lab2.1\Web_Lab2.1\Views\CalcService\PassUsingModel.cshtml"
Write(Model.Sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n    <b>Sub :</b><br>\r\n    ");
#nullable restore
#line 10 "C:\Users\User\source\repos\Web_Lab2.1\Web_Lab2.1\Views\CalcService\PassUsingModel.cshtml"
Write(Model.Difference);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n    <b>Mult :</b> <br>\r\n    ");
#nullable restore
#line 12 "C:\Users\User\source\repos\Web_Lab2.1\Web_Lab2.1\Views\CalcService\PassUsingModel.cshtml"
Write(Model.Multiplication);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n    <b>Div :</b> <br>\r\n    ");
#nullable restore
#line 14 "C:\Users\User\source\repos\Web_Lab2.1\Web_Lab2.1\Views\CalcService\PassUsingModel.cshtml"
Write(Model.Division != null ? Model.Division : "Error");

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebLab2._1.Models.CalcValues> Html { get; private set; }
    }
}
#pragma warning restore 1591