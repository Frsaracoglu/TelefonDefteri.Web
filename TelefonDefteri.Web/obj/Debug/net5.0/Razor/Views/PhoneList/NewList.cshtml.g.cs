#pragma checksum "C:\Users\Fatih\source\repos\TelefonDefteri.Web\TelefonDefteri.Web\Views\PhoneList\NewList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b577efaad85e40c99aa8ef16974968206b44ff7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PhoneList_NewList), @"mvc.1.0.view", @"/Views/PhoneList/NewList.cshtml")]
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
#line 1 "C:\Users\Fatih\source\repos\TelefonDefteri.Web\TelefonDefteri.Web\Views\_ViewImports.cshtml"
using TelefonDefteriEntity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b577efaad85e40c99aa8ef16974968206b44ff7", @"/Views/PhoneList/NewList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a140bfb2734fff764229f9167217e63ba204d3ce", @"/Views/_ViewImports.cshtml")]
    public class Views_PhoneList_NewList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PhoneList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"newListContainer col-md-6\">\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Fatih\source\repos\TelefonDefteri.Web\TelefonDefteri.Web\Views\PhoneList\NewList.cshtml"
     using (Html.BeginForm("NewList", "PhoneList", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"form-group col-md-6\">\r\n                <label for=\"inputAd\">Ad</label>\r\n                ");
#nullable restore
#line 10 "C:\Users\Fatih\source\repos\TelefonDefteri.Web\TelefonDefteri.Web\Views\PhoneList\NewList.cshtml"
           Write(Html.TextBoxFor(l => l.Name, new { @class = "form-control", id = "inputAd" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group col-md-6\">\r\n                <label for=\"inputLastName\">Soyad</label>\r\n                ");
#nullable restore
#line 14 "C:\Users\Fatih\source\repos\TelefonDefteri.Web\TelefonDefteri.Web\Views\PhoneList\NewList.cshtml"
           Write(Html.TextBoxFor(l => l.LastName, new { @class = "form-control", id = "inputLastName" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"inputEmail\">Email</label>\r\n            ");
#nullable restore
#line 19 "C:\Users\Fatih\source\repos\TelefonDefteri.Web\TelefonDefteri.Web\Views\PhoneList\NewList.cshtml"
       Write(Html.TextBoxFor(l => l.EMail, new { @class = "form-control", id = "inputEmail" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"inputAddress\">Adres</label>\r\n            ");
#nullable restore
#line 23 "C:\Users\Fatih\source\repos\TelefonDefteri.Web\TelefonDefteri.Web\Views\PhoneList\NewList.cshtml"
       Write(Html.TextBoxFor(l => l.Address, new { @class = "form-control", id = "inputAddress" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"form-group col-md-6\">\r\n                <label for=\"inputPhone\">Telefon</label>\r\n                ");
#nullable restore
#line 28 "C:\Users\Fatih\source\repos\TelefonDefteri.Web\TelefonDefteri.Web\Views\PhoneList\NewList.cshtml"
           Write(Html.TextBoxFor(l => l.Phone, new { @class = "form-control", id = "inputPhone" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group col-md-4\">\r\n                <label for=\"inputCity\">Şehir</label>\r\n                ");
#nullable restore
#line 32 "C:\Users\Fatih\source\repos\TelefonDefteri.Web\TelefonDefteri.Web\Views\PhoneList\NewList.cshtml"
           Write(Html.TextBoxFor(l => l.City, new { @class = "form-control", id = "inputCity" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group col-md-2\">\r\n                <label for=\"inputStatus\">Durum</label>\r\n                ");
#nullable restore
#line 36 "C:\Users\Fatih\source\repos\TelefonDefteri.Web\TelefonDefteri.Web\Views\PhoneList\NewList.cshtml"
           Write(Html.TextBoxFor(l => l.Status, new { @class = "form-control", id = "inputStatus", placeholder = "1 / 0" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Kaydet</button>\r\n            <button type=\"button\" style=\"float:right\" class=\"goBack btn btn-primary\">Geri Dön</button>\r\n        </div>\r\n");
#nullable restore
#line 43 "C:\Users\Fatih\source\repos\TelefonDefteri.Web\TelefonDefteri.Web\Views\PhoneList\NewList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PhoneList> Html { get; private set; }
    }
}
#pragma warning restore 1591
