#pragma checksum "C:\Users\asus\source\repos\bitproje\bitproje\Views\Home\Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6f2384aa0048582e76450e1c2b40328a05454a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Header), @"mvc.1.0.view", @"/Views/Home/Header.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Header.cshtml", typeof(AspNetCore.Views_Home_Header))]
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
#line 3 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Home\Header.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6f2384aa0048582e76450e1c2b40328a05454a8", @"/Views/Home/Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3e4c30b7a076a37a667ece1bf7a0e5261a0758c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bitproje.Entitys.Users>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:65px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/den.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(68, 601, true);
            WriteLiteral(@"<header>
    <div class=""container-fluid"">

        <nav class=""navbar navbar-inverse navbar-fixed-top"">
            <div class=""navbar-header navbar-form"">
                <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".navbar-collapse"">
                    <span class=""sr-only"">Toggle navigation</span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>

                </button>

                ");
            EndContext();
            BeginContext(669, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7c525fec25c442ab94928db0aa70b4d5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(720, 311, true);
            WriteLiteral(@"
            </div>

            <div class=""col-md-8 navbar-collapse collapse"">
                <br />                <br />
                <i> ekleme yapılacak </i>

            </div>
            <div class=""col-md-4 pull-right"">

                <ul class=""nav navbar-nav pull-right"">





");
            EndContext();
#line 34 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Home\Header.cshtml"
                     if (@Context.Session.GetString("grubu") == "A")
                    {

#line default
#line hidden
            BeginContext(1124, 1418, true);
            WriteLiteral(@"                        <li class=""dropdown dropdown-user dropdown-dark"">
                            <a href=""javascript:;"" class=""dropdown-toggle"" data-toggle=""dropdown"" data-hover=""dropdown"" data-close-others=""true"">

                                <span>

                                    <label style=""font-size:15px;""> cahide sara</label>
                                    <i class=""fas fa-user-cog"" style=""font-size:35px;""></i><br />&nbsp;
                                    <span class=""firmname"" style=""font-size:15px;"">
                                        ADMİN
                                        SAYFASI
                                    </span>
                                </span>



                            </a>
                            <ul class=""dropdown-menu dropdown-menu-default"">
                                <li>
                                    <a href=""/Profile/Index"">
                                        <i class=""fas fa-user""></i> Profil
  ");
            WriteLiteral(@"                                  </a>
                                </li>

                                <li>
                                    <a>
                                        <i class=""fas fa-sign-out-alt""></i> Çıkış yap
                                    </a>
                                </li>
                            </ul>
                        </li>
");
            EndContext();
#line 66 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Home\Header.cshtml"
                    }
                    else if (@Context.Session.GetString("grubu") == "B")
                    {

#line default
#line hidden
            BeginContext(2662, 334, true);
            WriteLiteral(@"                        <li class=""dropdown dropdown-user dropdown-dark"">
                            <a href=""javascript:;"" class=""dropdown-toggle"" data-toggle=""dropdown"" data-hover=""dropdown"" data-close-others=""true"">

                                <span>

                                    <label style=""font-size:15px;""> ");
            EndContext();
            BeginContext(2997, 50, false);
#line 74 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Home\Header.cshtml"
                                                               Write(Html.DisplayFor(model => model.firma.Isvrnadsoyad));

#line default
#line hidden
            EndContext();
            BeginContext(3047, 239, true);
            WriteLiteral("</label>\r\n                                    <i class=\"fas fa-user-cog\" style=\"font-size:35px;\"></i><br />&nbsp;\r\n                                     <span class=\"firmname\" style=\"font-size:15px;\">\r\n                                      ");
            EndContext();
            BeginContext(3287, 44, false);
#line 77 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Home\Header.cshtml"
                                 Write(Html.DisplayFor(model => model.firma.Funvan));

#line default
#line hidden
            EndContext();
            BeginContext(3331, 37, true);
            WriteLiteral("\r\n                                  (");
            EndContext();
            BeginContext(3369, 43, false);
#line 78 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Home\Header.cshtml"
                              Write(Html.DisplayFor(model => model.firma.Durum));

#line default
#line hidden
            EndContext();
            BeginContext(3412, 1026, true);
            WriteLiteral(@")
                                   </span>
                                </span>



                            </a>
                            <ul class=""dropdown-menu dropdown-menu-default"">
                                <li>
                                    <a href=""/Profile/Index"">
                                        <i class=""fas fa-user""></i> Profil
                                    </a>
                                </li>
                                <li>
                                    <a>

                                        <i class=""fas fa-retweet""></i> Firma Değiştir
                                    </a>
                                </li>
                                <li>
                                    <a>
                                        <i class=""fas fa-sign-out-alt""></i> Çıkış yap
                                    </a>
                                </li>
                            </ul>
                        </li>");
            WriteLiteral("\r\n");
            EndContext();
#line 104 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Home\Header.cshtml"
                    }
                    else if (@Context.Session.GetString("grubu") == "C")
                    {

#line default
#line hidden
            BeginContext(4558, 1669, true);
            WriteLiteral(@"                        <li class=""dropdown dropdown-user dropdown-dark"">
                            <a href=""javascript:;"" class=""dropdown-toggle"" data-toggle=""dropdown"" data-hover=""dropdown"" data-close-others=""true"">

                                <span>

                                    <label style=""font-size:15px;""> cahide sara</label>
                                    <i class=""fas fa-user-cog"" style=""font-size:35px;""></i><br />&nbsp;
                                    <span class=""firmname"" style=""font-size:15px;"">
                                        hayat
                                        (Ana Firma)
                                    </span>
                                </span>



                            </a>
                            <ul class=""dropdown-menu dropdown-menu-default"">
                                <li>
                                    <a href=""/Profile/Index"">
                                        <i class=""fas fa-user""></i> Profil");
            WriteLiteral(@"
                                    </a>
                                </li>
                                <li>
                                    <a>

                                        <i class=""fas fa-retweet""></i> Firma Değiştir
                                    </a>
                                </li>
                                <li>
                                    <a>
                                        <i class=""fas fa-sign-out-alt""></i> Çıkış yap
                                    </a>
                                </li>
                            </ul>
                        </li>
");
            EndContext();
#line 142 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Home\Header.cshtml"
                    }
                    else if (@Context.Session.GetString("grubu") == "D")
                    {

#line default
#line hidden
            BeginContext(6347, 1669, true);
            WriteLiteral(@"                        <li class=""dropdown dropdown-user dropdown-dark"">
                            <a href=""javascript:;"" class=""dropdown-toggle"" data-toggle=""dropdown"" data-hover=""dropdown"" data-close-others=""true"">

                                <span>

                                    <label style=""font-size:15px;""> cahide sara</label>
                                    <i class=""fas fa-user-cog"" style=""font-size:35px;""></i><br />&nbsp;
                                    <span class=""firmname"" style=""font-size:15px;"">
                                        hayat
                                        (Ana Firma)
                                    </span>
                                </span>



                            </a>
                            <ul class=""dropdown-menu dropdown-menu-default"">
                                <li>
                                    <a href=""/Profile/Index"">
                                        <i class=""fas fa-user""></i> Profil");
            WriteLiteral(@"
                                    </a>
                                </li>
                                <li>
                                    <a>

                                        <i class=""fas fa-retweet""></i> Firma Değiştir
                                    </a>
                                </li>
                                <li>
                                    <a>
                                        <i class=""fas fa-sign-out-alt""></i> Çıkış yap
                                    </a>
                                </li>
                            </ul>
                        </li>
");
            EndContext();
#line 180 "C:\Users\asus\source\repos\bitproje\bitproje\Views\Home\Header.cshtml"

                    }

#line default
#line hidden
            BeginContext(8041, 98, true);
            WriteLiteral("\r\n\r\n                </ul>\r\n            </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n        </nav>\r\n    </div>\r\n\r\n</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bitproje.Entitys.Users> Html { get; private set; }
    }
}
#pragma warning restore 1591
