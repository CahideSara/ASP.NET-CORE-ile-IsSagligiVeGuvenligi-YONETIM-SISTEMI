#pragma checksum "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04077ccef3bc1cd3b55e8224b3022a8d7c22b93c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Egitimler_Delete), @"mvc.1.0.view", @"/Views/Egitimler/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Egitimler/Delete.cshtml", typeof(AspNetCore.Views_Egitimler_Delete))]
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
#line 2 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Delete.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04077ccef3bc1cd3b55e8224b3022a8d7c22b93c", @"/Views/Egitimler/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3e4c30b7a076a37a667ece1bf7a0e5261a0758c", @"/Views/_ViewImports.cshtml")]
    public class Views_Egitimler_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bitproje.Entitys.Egitimler>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Grupegitim", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "kulFirmaegitim", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(112, 290, true);
            WriteLiteral(@"<style>
    dt {
        height: 28px;
    }
</style>
<h3>EGİTİM</h3>
<br />

<div>
    <h style=""color:red;"">BU EĞİTİMİ SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ ?</h>
    <hr />
    <dl class=""dl-horizontal"">
        <dt>
            EGİTMEN
        </dt>
        <dd>
            ");
            EndContext();
            BeginContext(403, 49, false);
#line 22 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Delete.cshtml"
       Write(Html.DisplayFor(model => model.kullanici.Sicilno));

#line default
#line hidden
            EndContext();
            BeginContext(452, 4, true);
            WriteLiteral("  / ");
            EndContext();
            BeginContext(457, 44, false);
#line 22 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Delete.cshtml"
                                                             Write(Html.DisplayFor(model => model.kullanici.Ad));

#line default
#line hidden
            EndContext();
            BeginContext(501, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(504, 47, false);
#line 22 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Delete.cshtml"
                                                                                                            Write(Html.DisplayFor(model => model.kullanici.Soyad));

#line default
#line hidden
            EndContext();
            BeginContext(551, 3, true);
            WriteLiteral(" / ");
            EndContext();
            BeginContext(555, 52, false);
#line 22 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Delete.cshtml"
                                                                                                                                                               Write(Html.DisplayFor(model => model.kullanici.Gorevtanim));

#line default
#line hidden
            EndContext();
            BeginContext(607, 99, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            EGİTİM TARİHİ\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(707, 41, false);
#line 28 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Egitimtrh));

#line default
#line hidden
            EndContext();
            BeginContext(748, 101, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            EGİTİM KONULARI\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(850, 46, false);
#line 34 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Egitimkonulari));

#line default
#line hidden
            EndContext();
            BeginContext(896, 97, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            TOPLAM SÜRE\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(994, 42, false);
#line 40 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Toplamsure));

#line default
#line hidden
            EndContext();
            BeginContext(1036, 98, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            EGİTİM ALANI\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1135, 43, false);
#line 46 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Egitimalani));

#line default
#line hidden
            EndContext();
            BeginContext(1178, 94, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            AÇIKLAMA\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1273, 40, false);
#line 52 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Aciklama));

#line default
#line hidden
            EndContext();
            BeginContext(1313, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(1347, 741, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee6d804fffc44e01bb00d7f137a66369", async() => {
                BeginContext(1373, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 57 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Delete.cshtml"
         if (@Context.Session.GetString("grubu") == "A")
        {

#line default
#line hidden
                BeginContext(1444, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(1456, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a2f756dd65a4afba21af04ea711d448", async() => {
                    BeginContext(1483, 16, true);
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
                BeginContext(1503, 36, true);
                WriteLiteral("<i> &emsp;| &emsp;</i>\r\n            ");
                EndContext();
                BeginContext(1539, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "260b65b8744d4a6997ed76fe13db1ee1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 60 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Egitimid);

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
                BeginContext(1581, 138, true);
                WriteLiteral("\r\n            <input type=\"submit\" style=\"font-size:13px;font-weight:bold;height:27px;width:70px;\" value=\"SİL\" class=\"btn btn-danger\" />\r\n");
                EndContext();
#line 62 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Delete.cshtml"
        }

#line default
#line hidden
                BeginContext(1730, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 63 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Delete.cshtml"
         if (@Context.Session.GetString("grubu") == "A")
        {

#line default
#line hidden
                BeginContext(1797, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd915875bb054e58b1daaad6860b6ae2", async() => {
                    BeginContext(1828, 16, true);
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
                BeginContext(1848, 36, true);
                WriteLiteral("<i> &emsp;| &emsp;</i>\r\n            ");
                EndContext();
                BeginContext(1884, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "832cd8fdfa7c43f0ab65c6f94043ea2b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 65 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Egitimid);

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
                BeginContext(1926, 138, true);
                WriteLiteral("\r\n            <input type=\"submit\" style=\"font-size:13px;font-weight:bold;height:27px;width:70px;\" value=\"SİL\" class=\"btn btn-danger\" />\r\n");
                EndContext();
#line 67 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Delete.cshtml"
        }

#line default
#line hidden
                BeginContext(2075, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2088, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bitproje.Entitys.Egitimler> Html { get; private set; }
    }
}
#pragma warning restore 1591
