#pragma checksum "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3909c3497cf87af4423523ef123282f2eb9b6ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kullanici_Details), @"mvc.1.0.view", @"/Views/Kullanici/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Kullanici/Details.cshtml", typeof(AspNetCore.Views_Kullanici_Details))]
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
#line 1 "C:\Users\asus\source\repos\bitproje\bitproje\Views\_ViewImports.cshtml"
using bitproje;

#line default
#line hidden
#line 2 "C:\Users\asus\source\repos\bitproje\bitproje\Views\_ViewImports.cshtml"
using bitproje.Models;

#line default
#line hidden
#line 3 "C:\Users\asus\source\repos\bitproje\bitproje\Views\_ViewImports.cshtml"
using bitproje.Controllers;

#line default
#line hidden
#line 4 "C:\Users\asus\source\repos\bitproje\bitproje\Views\_ViewImports.cshtml"
using bitproje.Entitys;

#line default
#line hidden
#line 5 "C:\Users\asus\source\repos\bitproje\bitproje\Views\_ViewImports.cshtml"
using bitproje.Data;

#line default
#line hidden
#line 2 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3909c3497cf87af4423523ef123282f2eb9b6ba", @"/Views/Kullanici/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3e4c30b7a076a37a667ece1bf7a0e5261a0758c", @"/Views/_ViewImports.cshtml")]
    public class Views_Kullanici_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<bitproje.Entitys.Kullanici, IEnumerable<bitproje.Entitys.KullaniciFirma>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Grupkullanici", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Firmakullanici", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FirmaCikar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FirmaEkle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(123, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(215, 273, true);
            WriteLiteral(@"
<style>
    dt {
        height: 28px;
    }
</style>
<div>
    <h4>KULLANICI</h4>
    <hr />
    <div class=""col-md-6"">

        <dl class=""dl-horizontal"">
            <dt>
                SİCİL NUMARASI
            </dt>
            <dd>
                ");
            EndContext();
            BeginContext(489, 45, false);
#line 24 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
           Write(Html.DisplayFor(model => model.Item1.Sicilno));

#line default
#line hidden
            EndContext();
            BeginContext(534, 112, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                TC\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(647, 40, false);
#line 30 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
           Write(Html.DisplayFor(model => model.Item1.Tc));

#line default
#line hidden
            EndContext();
            BeginContext(687, 123, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                KULLANICI ADI\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(811, 40, false);
#line 36 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
           Write(Html.DisplayFor(model => model.Item1.Ad));

#line default
#line hidden
            EndContext();
            BeginContext(851, 126, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                KULLANICI SOYADI\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(978, 43, false);
#line 42 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
           Write(Html.DisplayFor(model => model.Item1.Soyad));

#line default
#line hidden
            EndContext();
            BeginContext(1021, 122, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                GÖREV TANIMI\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1144, 48, false);
#line 48 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
           Write(Html.DisplayFor(model => model.Item1.Gorevtanim));

#line default
#line hidden
            EndContext();
            BeginContext(1192, 114, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                BOYU\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1307, 41, false);
#line 54 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
           Write(Html.DisplayFor(model => model.Item1.Boy));

#line default
#line hidden
            EndContext();
            BeginContext(1348, 116, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                KİLOSU\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1465, 42, false);
#line 60 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
           Write(Html.DisplayFor(model => model.Item1.Kilo));

#line default
#line hidden
            EndContext();
            BeginContext(1507, 119, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                KAN GRUBU\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1627, 45, false);
#line 66 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
           Write(Html.DisplayFor(model => model.Item1.Kangrup));

#line default
#line hidden
            EndContext();
            BeginContext(1672, 118, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                CİNSİYET\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1791, 46, false);
#line 72 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
           Write(Html.DisplayFor(model => model.Item1.Cinsiyet));

#line default
#line hidden
            EndContext();
            BeginContext(1837, 120, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                DOĞUM YERİ\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1958, 46, false);
#line 78 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
           Write(Html.DisplayFor(model => model.Item1.Dogumyer));

#line default
#line hidden
            EndContext();
            BeginContext(2004, 122, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                DOĞUM TARİHİ\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2127, 48, false);
#line 84 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
           Write(Html.DisplayFor(model => model.Item1.Dogumtarih));

#line default
#line hidden
            EndContext();
            BeginContext(2175, 124, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ÖĞRENİM DURUMU\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2300, 50, false);
#line 90 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
           Write(Html.DisplayFor(model => model.Item1.Ogrenimdurum));

#line default
#line hidden
            EndContext();
            BeginContext(2350, 115, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                STATÜ\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2466, 43, false);
#line 96 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
           Write(Html.DisplayFor(model => model.Item1.Statü));

#line default
#line hidden
            EndContext();
            BeginContext(2509, 126, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                İSG KURUL GÖREVİ\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2636, 51, false);
#line 102 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
           Write(Html.DisplayFor(model => model.Item1.Isgkurulgorev));

#line default
#line hidden
            EndContext();
            BeginContext(2687, 130, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                İŞE BAŞLANGIÇ TARİHİ\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2818, 55, false);
#line 108 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
           Write(Html.DisplayFor(model => model.Item1.Isebaslangictarih));

#line default
#line hidden
            EndContext();
            BeginContext(2873, 116, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                UNVANI\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2990, 43, false);
#line 114 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
           Write(Html.DisplayFor(model => model.Item1.Unvan));

#line default
#line hidden
            EndContext();
            BeginContext(3033, 116, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                DURUMU\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(3150, 43, false);
#line 120 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
           Write(Html.DisplayFor(model => model.Item1.Durum));

#line default
#line hidden
            EndContext();
            BeginContext(3193, 53, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n\r\n        <div>\r\n");
            EndContext();
#line 125 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
             if (@Context.Session.GetString("grubu") == "A")
            {

#line default
#line hidden
            BeginContext(3321, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c9f8e206dd845db80412f5e856f9172", async() => {
                BeginContext(3351, 16, true);
                WriteLiteral("LİSTEYE GERİ DÖN");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3371, 21, true);
            WriteLiteral("<i> &emsp;|&emsp;</i>");
            EndContext();
#line 126 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
                                                                                    }
            else if (@Context.Session.GetString("grubu") == "B")
            {

#line default
#line hidden
            BeginContext(3474, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8c2166af79341c29bb1e8cc1a7f1c40", async() => {
                BeginContext(3505, 16, true);
                WriteLiteral("LİSTEYE GERİ DÖN");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3525, 21, true);
            WriteLiteral("<i> &emsp;|&emsp;</i>");
            EndContext();
#line 128 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
                                                                                     }

#line default
#line hidden
            BeginContext(3549, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(3561, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39925d40490d4b56a368f32949a62f72", async() => {
                BeginContext(3618, 44, true);
                WriteLiteral("<i class=\"fas fa-edit\" title=\"GÜNCELLE\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 129 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
                                   WriteLiteral(Model.Item1.Sicilno);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3666, 551, true);
            WriteLiteral(@"

        </div>
    </div>
    <div class=""col-md-6 "">

        <header style=""font-family:Impact, 'Arial Narrow Bold'"">KULLANICININ FİRMALARI&nbsp;:</header>
        <br />
        <table class=""table"" style=""font-size:x-small"">
            <thead>
                <tr>
                    <th scope=""col"">FİRMA ID </th>
                    <th scope=""col"">FİRMA AD</th>
                    <th scope=""col"">İŞ VEREN KİŞİ</th>
                    <th scope=""col""></th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 147 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
                 foreach (var f in Model.Item2)
                {

#line default
#line hidden
            BeginContext(4285, 55, true);
            WriteLiteral("                    <tr>\r\n                        <td> ");
            EndContext();
            BeginContext(4341, 15, false);
#line 150 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
                        Write(f.Firma.Firmaid);

#line default
#line hidden
            EndContext();
            BeginContext(4356, 36, true);
            WriteLiteral("</td>\r\n                        <td> ");
            EndContext();
            BeginContext(4393, 14, false);
#line 151 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
                        Write(f.Firma.Funvan);

#line default
#line hidden
            EndContext();
            BeginContext(4407, 36, true);
            WriteLiteral("</td>\r\n                        <td> ");
            EndContext();
            BeginContext(4444, 20, false);
#line 152 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
                        Write(f.Firma.Isvrnadsoyad);

#line default
#line hidden
            EndContext();
            BeginContext(4464, 89, true);
            WriteLiteral("</td>\r\n                        <td style=\"font-size:14px;\">\r\n                            ");
            EndContext();
            BeginContext(4553, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "233b666a612546f98377367d82c097a3", async() => {
                BeginContext(4601, 55, true);
                WriteLiteral("<i class=\"fas fa-minus-circle\" title=\"FİRMAYI SİL\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 154 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
                                                         WriteLiteral(f.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4660, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 157 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(4739, 72, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <p>\r\n            &emsp; ");
            EndContext();
            BeginContext(4811, 161, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b7d5be10dfb4519a8d2f8fe849fc20a", async() => {
                BeginContext(4873, 95, true);
                WriteLiteral("<i style=\"font-size:20px;\" class=\"fas fa-plus-circle\" title=\"firma ekle\"></i> &nbsp; FİRMA EKLE");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 161 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanici\Details.cshtml"
                                               WriteLiteral(Model.Item1.Sicilno);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4972, 40, true);
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<bitproje.Entitys.Kullanici, IEnumerable<bitproje.Entitys.KullaniciFirma>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
