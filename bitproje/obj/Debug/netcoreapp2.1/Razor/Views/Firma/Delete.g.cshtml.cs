#pragma checksum "C:\Users\asus\source\repos\bitproje\bitproje\Views\Firma\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f6f11e94f8f04b7845223665f7c9769e3eeb793"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Firma_Delete), @"mvc.1.0.view", @"/Views/Firma/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Firma/Delete.cshtml", typeof(AspNetCore.Views_Firma_Delete))]
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
#line 2 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Firma\Delete.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f6f11e94f8f04b7845223665f7c9769e3eeb793", @"/Views/Firma/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3e4c30b7a076a37a667ece1bf7a0e5261a0758c", @"/Views/_ViewImports.cshtml")]
    public class Views_Firma_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bitproje.Entitys.Firma>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Grupfirma", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Firmafirma", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "KulFirma", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Firma\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(155, 294, true);
            WriteLiteral(@"
<style>
    dt {
        height: 28px;
    }
</style>
<h3>Firma</h3>
<br />

<div>
    <h style=""color:red;"">BU FİRMAYI SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ ?</h>
    <hr />
    <dl class=""dl-horizontal"">

        <dt>
            FİRMA AD
        </dt>
        <dd>
            ");
            EndContext();
            BeginContext(450, 38, false);
#line 25 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Firma\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Funvan));

#line default
#line hidden
            EndContext();
            BeginContext(488, 99, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            İŞ VEREN KİŞİ\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(588, 44, false);
#line 31 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Firma\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Isvrnadsoyad));

#line default
#line hidden
            EndContext();
            BeginContext(632, 98, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            İŞ VEREN GSM\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(731, 40, false);
#line 37 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Firma\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Isvrngsm));

#line default
#line hidden
            EndContext();
            BeginContext(771, 99, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            FİRMA TELEFON\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(871, 41, false);
#line 43 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Firma\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Firmatlfn));

#line default
#line hidden
            EndContext();
            BeginContext(912, 90, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            FAKS\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1003, 36, false);
#line 49 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Firma\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Faks));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 96, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            FİRMA MAİL\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1136, 41, false);
#line 55 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Firma\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Firmamail));

#line default
#line hidden
            EndContext();
            BeginContext(1177, 88, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            İL\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1266, 34, false);
#line 61 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Firma\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Il));

#line default
#line hidden
            EndContext();
            BeginContext(1300, 90, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            İLÇE\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1391, 36, false);
#line 67 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Firma\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ilce));

#line default
#line hidden
            EndContext();
            BeginContext(1427, 91, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ADRES\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1519, 37, false);
#line 73 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Firma\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Adres));

#line default
#line hidden
            EndContext();
            BeginContext(1556, 100, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            FAALİYET ALANI\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1657, 44, false);
#line 79 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Firma\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Faaliyetalan));

#line default
#line hidden
            EndContext();
            BeginContext(1701, 95, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            SGK SİCİL\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1797, 40, false);
#line 85 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Firma\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Sgksicil));

#line default
#line hidden
            EndContext();
            BeginContext(1837, 100, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            TEHLİKE SINIFI\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1938, 44, false);
#line 91 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Firma\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Tehlikesinif));

#line default
#line hidden
            EndContext();
            BeginContext(1982, 99, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            GRUP ŞİRKET ?\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2082, 42, false);
#line 97 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Firma\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Grupsirket));

#line default
#line hidden
            EndContext();
            BeginContext(2124, 92, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            DURUMU\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2217, 37, false);
#line 103 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Firma\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Durum));

#line default
#line hidden
            EndContext();
            BeginContext(2254, 45, true);
            WriteLiteral("\r\n        </dd>\r\n       \r\n\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(2299, 1127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "254209d741ed4808ad837cdfa43eaa14", async() => {
                BeginContext(2325, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 110 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Firma\Delete.cshtml"
         if (@Context.Session.GetString("grubu") == "A")
        {

#line default
#line hidden
                BeginContext(2396, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(2408, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08d02973c1c8482eb7736e8fbc8c321d", async() => {
                    BeginContext(2434, 16, true);
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
                BeginContext(2454, 23, true);
                WriteLiteral(" <i>&emsp;|&emsp;</i>\r\n");
                EndContext();
#line 113 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Firma\Delete.cshtml"
        }
        else if (@Context.Session.GetString("grubu") == "B")
        {

#line default
#line hidden
                BeginContext(2561, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(2573, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "459a2ea57872463a9022c0f569f52334", async() => {
                    BeginContext(2600, 16, true);
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
                BeginContext(2620, 23, true);
                WriteLiteral(" <i>&emsp;|&emsp;</i>\r\n");
                EndContext();
#line 117 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Firma\Delete.cshtml"
        }
        else if (@Context.Session.GetString("grubu") == "C")
        {

#line default
#line hidden
                BeginContext(2727, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(2739, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01e43e83d8764bb19365d7329c2f4dbc", async() => {
                    BeginContext(2764, 16, true);
                    WriteLiteral("LİSTEYE GERİ DÖN");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2784, 23, true);
                WriteLiteral(" <i>&emsp;|&emsp;</i>\r\n");
                EndContext();
#line 121 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Firma\Delete.cshtml"
        }
        else if (@Context.Session.GetString("grubu") == "D")
        {

#line default
#line hidden
                BeginContext(2891, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(2903, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95788650669c4fe5811d1acaac6b02f7", async() => {
                    BeginContext(2928, 16, true);
                    WriteLiteral("LİSTEYE GERİ DÖN");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2948, 23, true);
                WriteLiteral(" <i>&emsp;|&emsp;</i>\r\n");
                EndContext();
#line 125 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Firma\Delete.cshtml"
        }

#line default
#line hidden
                BeginContext(2982, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(2990, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "17eadea53bbd4ce593b72a538571b49b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 126 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Firma\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Firmaid);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3031, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 127 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Firma\Delete.cshtml"
         if (Model.Durum.Equals("ANA FİRMA"))
        {

#line default
#line hidden
                BeginContext(3091, 133, true);
                WriteLiteral("            <a style=\"font-size:13px;font-weight:bold;height:27px;width:70px;\">ANA FİRMAYI SADECE VERİTABANINDAN SİLEBİLİRSİNİZ</a>\r\n");
                EndContext();
#line 130 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Firma\Delete.cshtml"
        }
        else
        {

#line default
#line hidden
                BeginContext(3260, 136, true);
                WriteLiteral("            <input type=\"submit\" style=\"font-size:13px;font-weight:bold;height:27px;width:70px;\" value=\"SİL\" class=\"btn btn-danger\" />\r\n");
                EndContext();
#line 134 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Firma\Delete.cshtml"
        }

#line default
#line hidden
                BeginContext(3407, 12, true);
                WriteLiteral("\r\n\r\n\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3426, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bitproje.Entitys.Firma> Html { get; private set; }
    }
}
#pragma warning restore 1591
