#pragma checksum "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanicifirma\Detayi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a0ac0a45120ec788494ec8eee2ec2b1ab7c07c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kullanicifirma_Detayi), @"mvc.1.0.view", @"/Views/Kullanicifirma/Detayi.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Kullanicifirma/Detayi.cshtml", typeof(AspNetCore.Views_Kullanicifirma_Detayi))]
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
#line 2 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanicifirma\Detayi.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a0ac0a45120ec788494ec8eee2ec2b1ab7c07c5", @"/Views/Kullanicifirma/Detayi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3e4c30b7a076a37a667ece1bf7a0e5261a0758c", @"/Views/_ViewImports.cshtml")]
    public class Views_Kullanicifirma_Detayi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bitproje.Entitys.Firma>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "kullaniciFirmapersonel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("oku"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Personel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "kullaniciFirmabirim", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Birim", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanicifirma\Detayi.cshtml"
  
    ViewData["Title"] = "Detayi";

#line default
#line hidden
            BeginContext(108, 4322, true);
            WriteLiteral(@"
<style>

    ul.aa {
        list-style: none;
        display: block;
    }

    #mn a {
        position: relative;
        display: inline;
        margin: 10px;
        text-align: center;
        width: 150px;
        background-color: black;
        border-radius: 20px;
    }

    #menu a {
        width: 150px;
        height: 150px;
        display: inline-block;
        margin: 15px;
        padding: 15px;
        background-color: #222222;
        text-decoration: none;
        border-radius: 20px;
        text-align: center;
        color: white;
        font-size: 80px;
    }

    .flip-content {
        transition: 0.6s;
        transform-style: preserve-3d;
        position: relative
    }

    .flip-content, .front, .back {
        width: 300px;
        height: 300px
    }

    .front, .back {
        position: absolute;
        top: 0;
        left: 0;
        backface-visibility: hidden;
        background-color: #eee
    }

    .front {
  ");
            WriteLiteral(@"      z-index: 1
    }


    .back {
        transform: rotateX(180deg)
    }

    .flipper:hover .flip-content {
        transform: rotateX(-180deg)
    }

    .flipper {
        perspective: 1000px
    }
</style>

<style>


    .download,
    ul.features > li:before {
        background-color: #80A060;
    }

    a.download {
        position: absolute;
        top: 1em;
        left: -1.5em;
        width: 7em;
        height: 7em;
        padding: 1.2em 0;
        background-image: linear-gradient(transparent, rgba(0,0,0,.3));
        color: white;
        line-height: 1;
        font-size: 120%;
        font-weight: normal;
        text-align: center;
        text-decoration: none;
        text-shadow: .08em .08em .2em rgba(0,0,0,.6);
        border-radius: 50%;
        box-shadow: .1em .2em .4em -.2em black;
        box-sizing: border-box;
        transform: rotate(15deg);
        animation: 3s colorcycle infinite alternate;
    }

        a.download:hover ");
            WriteLiteral(@"{
            transform: rotate(375deg);
            transition: 1s transform;
        }

        a.download > strong {
            display: block;
            margin: .1em 0;
            font-size: 180%;
            white-space: nowrap;
        }




    .panelp {
        width: 300px;
        height: 80px;
        top: 20%;
        border-radius: 5px;
        -moz-box-shadow: 0 20px 30px rgba(0, 0, 0, 0.6);
        -webkit-box-shadow: 0 20px 30px rgba(0, 0, 0, 0.6);
        box-shadow: 0 10px 5px 5px 5px rgba(0, 0, 0, 0.6);
        border: 1px solid rgba(255, 255, 255, 0.3);
        padding: 20px;
        text-align: center;
        text-shadow: 0 1px 1px rgba(0, 0, 0, 0.4);
        display: flex;
        background-color: white;
    }



    .panelb {
        width: 400px;
        height: 500px;
        top: 20%;
        background-color: white;
        border-radius: 5px;
        -moz-box-shadow: 0 20px 30px rgba(0, 0, 0, 0.6);
        -webkit-box-shadow: 0 20px 30p");
            WriteLiteral(@"x rgba(0, 0, 0, 0.6);
        box-shadow: 0 10px 20px rgba(0, 0, 0, 0.6);
        border: 1px solid rgba(255, 255, 255, 0.3);
        padding: 20px;
        text-align: center;
        text-shadow: 0 1px 1px rgba(0, 0, 0, 0.4);
        display: flex;
    }

    dt {
        height: 19px;
    }

    a.oku {
        font-weight: bold;
        color: maroon;
        font-style: oblique;
        font-family: Arial, Helvetica, sans-serif;
        text-decoration: none;
        vertical-align: baseline;
    }

        a.oku:hover {
            font-weight: bold;
            color: maroon;
            font-style: oblique;
            font-family: Arial, Helvetica, sans-serif;
            text-decoration: none;
            vertical-align: baseline;
        }

    dt {
        height: 26px;
    }
</style>
<br />
<div class=""col-md-1  "">

</div>
<div class=""col-md-6 container-fluid "">

    <div class=""panelb"">
        <div>
            <div>
                <h5 style=""color:#");
            WriteLiteral("90adad;\">FİRMA</h5>\r\n                <hr />\r\n                <dl class=\"dl-horizontal\">\r\n                    <dt>\r\n                        FİRMA İD\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(4431, 39, false);
#line 196 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanicifirma\Detayi.cshtml"
                   Write(Html.DisplayFor(model => model.Firmaid));

#line default
#line hidden
            EndContext();
            BeginContext(4470, 166, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        FİRMA AD\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(4637, 38, false);
#line 202 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanicifirma\Detayi.cshtml"
                   Write(Html.DisplayFor(model => model.Funvan));

#line default
#line hidden
            EndContext();
            BeginContext(4675, 173, true);
            WriteLiteral("\r\n\r\n                    </dd>\r\n                    <dt>\r\n                        İŞ VEREN KİŞİ\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(4849, 44, false);
#line 209 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanicifirma\Detayi.cshtml"
                   Write(Html.DisplayFor(model => model.Isvrnadsoyad));

#line default
#line hidden
            EndContext();
            BeginContext(4893, 170, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        İŞ VEREN GSM\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(5064, 40, false);
#line 215 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanicifirma\Detayi.cshtml"
                   Write(Html.DisplayFor(model => model.Isvrngsm));

#line default
#line hidden
            EndContext();
            BeginContext(5104, 171, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        FİRMA TELEFON\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(5276, 41, false);
#line 221 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanicifirma\Detayi.cshtml"
                   Write(Html.DisplayFor(model => model.Firmatlfn));

#line default
#line hidden
            EndContext();
            BeginContext(5317, 162, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        FAKS\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(5480, 36, false);
#line 227 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanicifirma\Detayi.cshtml"
                   Write(Html.DisplayFor(model => model.Faks));

#line default
#line hidden
            EndContext();
            BeginContext(5516, 168, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        FİRMA MAİL\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(5685, 41, false);
#line 233 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanicifirma\Detayi.cshtml"
                   Write(Html.DisplayFor(model => model.Firmamail));

#line default
#line hidden
            EndContext();
            BeginContext(5726, 160, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        İL\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(5887, 34, false);
#line 239 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanicifirma\Detayi.cshtml"
                   Write(Html.DisplayFor(model => model.Il));

#line default
#line hidden
            EndContext();
            BeginContext(5921, 162, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        İLÇE\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(6084, 36, false);
#line 245 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanicifirma\Detayi.cshtml"
                   Write(Html.DisplayFor(model => model.Ilce));

#line default
#line hidden
            EndContext();
            BeginContext(6120, 163, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ADRES\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(6284, 37, false);
#line 251 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanicifirma\Detayi.cshtml"
                   Write(Html.DisplayFor(model => model.Adres));

#line default
#line hidden
            EndContext();
            BeginContext(6321, 172, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        FAALİYET ALANI\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(6494, 44, false);
#line 257 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanicifirma\Detayi.cshtml"
                   Write(Html.DisplayFor(model => model.Faaliyetalan));

#line default
#line hidden
            EndContext();
            BeginContext(6538, 167, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        SGK SİCİL\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(6706, 40, false);
#line 263 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanicifirma\Detayi.cshtml"
                   Write(Html.DisplayFor(model => model.Sgksicil));

#line default
#line hidden
            EndContext();
            BeginContext(6746, 172, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        TEHLİKE SINIFI\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(6919, 44, false);
#line 269 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanicifirma\Detayi.cshtml"
                   Write(Html.DisplayFor(model => model.Tehlikesinif));

#line default
#line hidden
            EndContext();
            BeginContext(6963, 171, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        GRUP ŞİRKET ?\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(7135, 42, false);
#line 275 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanicifirma\Detayi.cshtml"
                   Write(Html.DisplayFor(model => model.Grupsirket));

#line default
#line hidden
            EndContext();
            BeginContext(7177, 166, true);
            WriteLiteral("\r\n                    </dd>\r\n\r\n                    <dt>\r\n                        DURUMU\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(7344, 37, false);
#line 282 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanicifirma\Detayi.cshtml"
                   Write(Html.DisplayFor(model => model.Durum));

#line default
#line hidden
            EndContext();
            BeginContext(7381, 157, true);
            WriteLiteral("\r\n                    </dd>\r\n\r\n\r\n                </dl>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"col-md-5  \">\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(7538, 539, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d125b15731114f01a2ed7477828ed351", async() => {
                BeginContext(7645, 324, true);
                WriteLiteral(@"
            <div class=""panelp "">
                <p>
                    <div class=""col-md-6 container-fluid""><i style=""font-size:40px;color:#90adad;"" class=""fas fa-users""></i></div>
                    <div class=""col-md-6""><i style=""font-size:10px;font-weight: bold;color:#90adad;"">&emsp;<i style=""font-size:15px;"">");
                EndContext();
                BeginContext(7970, 16, false);
#line 297 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanicifirma\Detayi.cshtml"
                                                                                                                                 Write(ViewBag.percount);

#line default
#line hidden
                EndContext();
                BeginContext(7986, 87, true);
                WriteLiteral("</i>  <br />PERSONELLERİ </i></div>\r\n                </p>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 293 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanicifirma\Detayi.cshtml"
                                                                                       WriteLiteral(Model.Firmaid);

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
            BeginContext(8077, 45, true);
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(8122, 553, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60f0fc77588745a5925ce3a503e17ae2", async() => {
                BeginContext(8223, 345, true);
                WriteLiteral(@"
            <div class=""panelp "">
                <p>
                    <div class=""col-md-6 container-fluid""><i style=""font-size:40px; color:#90adad;"" class=""fas fa-align-justify""></i></div>
                    <div class=""col-md-6""><i style=""font-size:10px;font-weight: bold;color:#90adad;"">&emsp;&emsp;&emsp;<i style=""font-size:15px;"">");
                EndContext();
                BeginContext(8569, 18, false);
#line 308 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanicifirma\Detayi.cshtml"
                                                                                                                                             Write(ViewBag.birimcount);

#line default
#line hidden
                EndContext();
                BeginContext(8587, 84, true);
                WriteLiteral(" </i>  <br />BİRİMLERİ</i></div>\r\n                </p>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 304 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Kullanicifirma\Detayi.cshtml"
                                                                                 WriteLiteral(Model.Firmaid);

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
            BeginContext(8675, 40, true);
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n\r\n</div>\r\n\r\n\r\n");
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
