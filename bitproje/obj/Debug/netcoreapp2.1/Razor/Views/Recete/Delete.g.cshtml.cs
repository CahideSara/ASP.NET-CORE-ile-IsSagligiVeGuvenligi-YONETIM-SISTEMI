#pragma checksum "C:\Users\asus\source\repos\bitproje\bitproje\Views\Recete\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "598e19b98e6e01496279e9572d20dec68a5f30dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recete_Delete), @"mvc.1.0.view", @"/Views/Recete/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recete/Delete.cshtml", typeof(AspNetCore.Views_Recete_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"598e19b98e6e01496279e9572d20dec68a5f30dc", @"/Views/Recete/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3e4c30b7a076a37a667ece1bf7a0e5261a0758c", @"/Views/_ViewImports.cshtml")]
    public class Views_Recete_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bitproje.Entitys.Recete>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Recete\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(74, 245, true);
            WriteLiteral("\r\n<h3>REÇETE </h3>\r\n<br />\r\n\r\n\r\n<div>\r\n    <h style=\"color:red;\">BU REÇETEYİ SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ ?</h>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n\r\n        <dt>\r\n            REÇETE TARİHİ\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(320, 39, false);
#line 19 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Recete\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Rtarihi));

#line default
#line hidden
            EndContext();
            BeginContext(359, 99, true);
            WriteLiteral("  \r\n        </dd>\r\n        <dt>\r\n            REÇETE TİPİ\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(459, 37, false);
#line 25 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Recete\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Rtipi));

#line default
#line hidden
            EndContext();
            BeginContext(496, 103, true);
            WriteLiteral("  \r\n        </dd>\r\n        <dt>\r\n            REÇETE ALT TİPİ\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(600, 40, false);
#line 31 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Recete\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ralttipi));

#line default
#line hidden
            EndContext();
            BeginContext(640, 102, true);
            WriteLiteral("  \r\n        </dd>\r\n        <dt>\r\n            PROVİZYON TİPİ\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(743, 45, false);
#line 37 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Recete\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Provizyontipi));

#line default
#line hidden
            EndContext();
            BeginContext(788, 95, true);
            WriteLiteral("  \r\n        </dd>\r\n        <dt>\r\n            SERİ NO\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(884, 38, false);
#line 43 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Recete\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Serino));

#line default
#line hidden
            EndContext();
            BeginContext(922, 34, true);
            WriteLiteral("  \r\n        </dd>\r\n    </dl>\r\n    ");
            EndContext();
            BeginContext(956, 302, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8cd2290d15c45df889351e8d637abfb", async() => {
                BeginContext(982, 12, true);
                WriteLiteral("\r\n        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 994, "\"", 1028, 2);
                WriteAttributeValue("", 1001, "/Muayene/Details/", 1001, 17, true);
#line 47 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Recete\Delete.cshtml"
WriteAttributeValue("", 1018, Model.Mid, 1018, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1029, 45, true);
                WriteLiteral(">LİSTEYE GERİ DÖN</a> &emsp;|&emsp;\r\n        ");
                EndContext();
                BeginContext(1074, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "08699bd6f35348f88eaa53234f78e0bb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 48 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Recete\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Rid);

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
                BeginContext(1111, 140, true);
                WriteLiteral("\r\n        <input type=\"submit\" style=\"font-size:13px;font-weight:bold;height:27px;width:70px;\" value=\"SİL\" class=\"btn btn-danger\" />\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1258, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bitproje.Entitys.Recete> Html { get; private set; }
    }
}
#pragma warning restore 1591
