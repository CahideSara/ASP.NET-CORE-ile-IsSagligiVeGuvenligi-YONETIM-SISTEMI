#pragma checksum "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "811e898c293807f6e40c17e9b93cc5728ac94423"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Egitimler_Index), @"mvc.1.0.view", @"/Views/Egitimler/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Egitimler/Index.cshtml", typeof(AspNetCore.Views_Egitimler_Index))]
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
#line 2 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"811e898c293807f6e40c17e9b93cc5728ac94423", @"/Views/Egitimler/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3e4c30b7a076a37a667ece1bf7a0e5261a0758c", @"/Views/_ViewImports.cshtml")]
    public class Views_Egitimler_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<bitproje.Entitys.Egitimler>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Katilimcilar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(124, 23, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\n<p>\r\n");
            EndContext();
#line 10 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Index.cshtml"
     if (@Context.Session.GetString("grubu") == "A")
    {

#line default
#line hidden
            BeginContext(208, 21, true);
            WriteLiteral("        <i>&emsp;</i>");
            EndContext();
            BeginContext(229, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd9dad1ba84a40c1bcbb52d814e884c5", async() => {
                BeginContext(252, 102, true);
                WriteLiteral("<i style=\"font-size:20px;\" class=\"fas fa-plus-circle\" title=\"egitim ekle\"></i> &nbsp; YENİ EĞİTİM EKLE");
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
            BeginContext(358, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Index.cshtml"
    }
    else if (@Context.Session.GetString("grubu") == "D")
    {

#line default
#line hidden
            BeginContext(432, 21, true);
            WriteLiteral("        <i>&emsp;</i>");
            EndContext();
            BeginContext(453, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e493de3ca6ad400399f6b37a77d52203", async() => {
                BeginContext(476, 102, true);
                WriteLiteral("<i style=\"font-size:20px;\" class=\"fas fa-plus-circle\" title=\"egitim ekle\"></i> &nbsp; YENİ EĞİTİM EKLE");
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
            BeginContext(582, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 17 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(591, 16, true);
            WriteLiteral("\r\n</p>\r\n<br />\r\n");
            EndContext();
#line 21 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(640, 203, true);
            WriteLiteral("    <div>\r\n        <div class=\"col-md-8\">\r\n            <dl class=\"dl-horizontal\">\r\n\r\n\r\n                <dt>\r\n                    EGİTMEN\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(844, 52, false);
#line 32 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.kullanici.Sicilno));

#line default
#line hidden
            EndContext();
            BeginContext(896, 4, true);
            WriteLiteral("  / ");
            EndContext();
            BeginContext(901, 47, false);
#line 32 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Index.cshtml"
                                                                        Write(Html.DisplayFor(modelItem => item.kullanici.Ad));

#line default
#line hidden
            EndContext();
            BeginContext(948, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(951, 50, false);
#line 32 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Index.cshtml"
                                                                                                                          Write(Html.DisplayFor(modelItem => item.kullanici.Soyad));

#line default
#line hidden
            EndContext();
            BeginContext(1001, 3, true);
            WriteLiteral(" / ");
            EndContext();
            BeginContext(1005, 55, false);
#line 32 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Index.cshtml"
                                                                                                                                                                                Write(Html.DisplayFor(modelItem => item.kullanici.Gorevtanim));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 147, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    EGİTİM TARİHİ\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1208, 44, false);
#line 38 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Egitimtrh));

#line default
#line hidden
            EndContext();
            BeginContext(1252, 149, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    EGİTİM KONULARI\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1402, 49, false);
#line 44 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Egitimkonulari));

#line default
#line hidden
            EndContext();
            BeginContext(1451, 145, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    TOPLAM SÜRE\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1597, 45, false);
#line 50 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Toplamsure));

#line default
#line hidden
            EndContext();
            BeginContext(1642, 146, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    EGİTİM ALANI\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1789, 46, false);
#line 56 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Egitimalani));

#line default
#line hidden
            EndContext();
            BeginContext(1835, 142, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    AÇIKLAMA\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1978, 43, false);
#line 62 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Aciklama));

#line default
#line hidden
            EndContext();
            BeginContext(2021, 136, true);
            WriteLiteral("\r\n                </dd>\r\n\r\n            </dl>\r\n        </div>\r\n\r\n        <div class=\"col-md-4\" style=\"font-size:20px;\">\r\n\r\n\r\n            ");
            EndContext();
            BeginContext(2157, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96dde91c2fc34e04a7525221af3a0857", async() => {
                BeginContext(2239, 49, true);
                WriteLiteral("<i class=\"fas fa-users\" title=\"KATILIMCILAR\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Index.cshtml"
                                                                  WriteLiteral(item.Egitimid);

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
            BeginContext(2292, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
#line 72 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Index.cshtml"
             if (@Context.Session.GetString("grubu") == "A")
            {

#line default
#line hidden
            BeginContext(2377, 30, true);
            WriteLiteral("                <i> &nbsp;</i>");
            EndContext();
            BeginContext(2407, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30d23aa2b5e545a996a481c37670d2fd", async() => {
                BeginContext(2458, 44, true);
                WriteLiteral("<i class=\"fas fa-edit\" title=\"GÜNCELLE\"></i>");
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
#line 74 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Index.cshtml"
                                                     WriteLiteral(item.Egitimid);

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
            BeginContext(2506, 39, true);
            WriteLiteral(" <br />\r\n                <i> &nbsp;</i>");
            EndContext();
            BeginContext(2545, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8971c4f1aa61493c85f1f1659793a638", async() => {
                BeginContext(2598, 52, true);
                WriteLiteral("<i class=\"fas fa-trash-alt\" title=\"EGİTİMİ SİL\"></i>");
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
#line 75 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Index.cshtml"
                                                       WriteLiteral(item.Egitimid);

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
            BeginContext(2654, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 76 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Index.cshtml"
            }
            else if (@Context.Session.GetString("grubu") == "D")
            {

#line default
#line hidden
            BeginContext(2752, 30, true);
            WriteLiteral("                <i> &nbsp;</i>");
            EndContext();
            BeginContext(2782, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9d244c7f70143eda8609c14ff534fdb", async() => {
                BeginContext(2833, 44, true);
                WriteLiteral("<i class=\"fas fa-edit\" title=\"GÜNCELLE\"></i>");
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
#line 79 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Index.cshtml"
                                                     WriteLiteral(item.Egitimid);

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
            BeginContext(2881, 39, true);
            WriteLiteral(" <br />\r\n                <i> &nbsp;</i>");
            EndContext();
            BeginContext(2920, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09792595cef245b681b9b44ee1b1eed2", async() => {
                BeginContext(2973, 52, true);
                WriteLiteral("<i class=\"fas fa-trash-alt\" title=\"EGİTİMİ SİL\"></i>");
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
#line 80 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Index.cshtml"
                                                       WriteLiteral(item.Egitimid);

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
            BeginContext(3029, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 81 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3046, 28, true);
            WriteLiteral("        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(3076, 24, true);
            WriteLiteral("    <br />\r\n    <br />\r\n");
            EndContext();
#line 87 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Egitimler\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3103, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<bitproje.Entitys.Egitimler>> Html { get; private set; }
    }
}
#pragma warning restore 1591