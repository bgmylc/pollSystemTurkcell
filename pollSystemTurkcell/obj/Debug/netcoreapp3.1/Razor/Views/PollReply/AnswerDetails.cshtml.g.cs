#pragma checksum "C:\Users\LENOVO\source\repos\turkcellGelecegiYazanlarNET\Proje\pollSystemTurkcell\pollSystemTurkcell\Views\PollReply\AnswerDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ba7c72941e626861c64467b5ac3d8f3e8d2f9e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PollReply_AnswerDetails), @"mvc.1.0.view", @"/Views/PollReply/AnswerDetails.cshtml")]
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
#line 1 "C:\Users\LENOVO\source\repos\turkcellGelecegiYazanlarNET\Proje\pollSystemTurkcell\pollSystemTurkcell\Views\_ViewImports.cshtml"
using pollSystemTurkcell;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\source\repos\turkcellGelecegiYazanlarNET\Proje\pollSystemTurkcell\pollSystemTurkcell\Views\_ViewImports.cshtml"
using pollSystemTurkcell.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ba7c72941e626861c64467b5ac3d8f3e8d2f9e8", @"/Views/PollReply/AnswerDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59fbb37ec286f1ae59b6308962cc19192ba45424", @"/Views/_ViewImports.cshtml")]
    public class Views_PollReply_AnswerDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<pollSystemTurkcell.Models.PollResponse>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Polls", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DownloadList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\LENOVO\source\repos\turkcellGelecegiYazanlarNET\Proje\pollSystemTurkcell\pollSystemTurkcell\Views\PollReply\AnswerDetails.cshtml"
  
    ViewData["Title"] = "AnswerDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\LENOVO\source\repos\turkcellGelecegiYazanlarNET\Proje\pollSystemTurkcell\pollSystemTurkcell\Views\PollReply\AnswerDetails.cshtml"
Write(ViewBag.PollName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Anketi</h1>\r\n<h3>Ankete Verilen Cevap Detayları </h3>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\LENOVO\source\repos\turkcellGelecegiYazanlarNET\Proje\pollSystemTurkcell\pollSystemTurkcell\Views\PollReply\AnswerDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Respondent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\LENOVO\source\repos\turkcellGelecegiYazanlarNET\Proje\pollSystemTurkcell\pollSystemTurkcell\Views\PollReply\AnswerDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Question));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\LENOVO\source\repos\turkcellGelecegiYazanlarNET\Proje\pollSystemTurkcell\pollSystemTurkcell\Views\PollReply\AnswerDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Answer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\LENOVO\source\repos\turkcellGelecegiYazanlarNET\Proje\pollSystemTurkcell\pollSystemTurkcell\Views\PollReply\AnswerDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "C:\Users\LENOVO\source\repos\turkcellGelecegiYazanlarNET\Proje\pollSystemTurkcell\pollSystemTurkcell\Views\PollReply\AnswerDetails.cshtml"
 foreach (var item in ViewBag.PollUsers) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n               ");
#nullable restore
#line 32 "C:\Users\LENOVO\source\repos\turkcellGelecegiYazanlarNET\Proje\pollSystemTurkcell\pollSystemTurkcell\Views\PollReply\AnswerDetails.cshtml"
          Write(item.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 35 "C:\Users\LENOVO\source\repos\turkcellGelecegiYazanlarNET\Proje\pollSystemTurkcell\pollSystemTurkcell\Views\PollReply\AnswerDetails.cshtml"
                foreach (var question in ViewBag.Questions)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <p>");
#nullable restore
#line 37 "C:\Users\LENOVO\source\repos\turkcellGelecegiYazanlarNET\Proje\pollSystemTurkcell\pollSystemTurkcell\Views\PollReply\AnswerDetails.cshtml"
                 Write(question.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 38 "C:\Users\LENOVO\source\repos\turkcellGelecegiYazanlarNET\Proje\pollSystemTurkcell\pollSystemTurkcell\Views\PollReply\AnswerDetails.cshtml"
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 41 "C:\Users\LENOVO\source\repos\turkcellGelecegiYazanlarNET\Proje\pollSystemTurkcell\pollSystemTurkcell\Views\PollReply\AnswerDetails.cshtml"
                 foreach (var answer in ViewBag.Answers)
                {
                    if (answer.Respondent.ID == item.UserID)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\LENOVO\source\repos\turkcellGelecegiYazanlarNET\Proje\pollSystemTurkcell\pollSystemTurkcell\Views\PollReply\AnswerDetails.cshtml"
                         if (answer.Answer == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge bg-success\">Evet</span>\r\n");
#nullable restore
#line 48 "C:\Users\LENOVO\source\repos\turkcellGelecegiYazanlarNET\Proje\pollSystemTurkcell\pollSystemTurkcell\Views\PollReply\AnswerDetails.cshtml"
                        }
                        else if (answer.Answer == false)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge bg-danger\">Hayır</span>\r\n");
#nullable restore
#line 52 "C:\Users\LENOVO\source\repos\turkcellGelecegiYazanlarNET\Proje\pollSystemTurkcell\pollSystemTurkcell\Views\PollReply\AnswerDetails.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\LENOVO\source\repos\turkcellGelecegiYazanlarNET\Proje\pollSystemTurkcell\pollSystemTurkcell\Views\PollReply\AnswerDetails.cshtml"
                         
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 57 "C:\Users\LENOVO\source\repos\turkcellGelecegiYazanlarNET\Proje\pollSystemTurkcell\pollSystemTurkcell\Views\PollReply\AnswerDetails.cshtml"
                 foreach (var answer in ViewBag.Answers)
                {
                    if (answer.Respondent.ID == item.UserID)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                       <p>");
#nullable restore
#line 62 "C:\Users\LENOVO\source\repos\turkcellGelecegiYazanlarNET\Proje\pollSystemTurkcell\pollSystemTurkcell\Views\PollReply\AnswerDetails.cshtml"
                     Write(answer.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 63 "C:\Users\LENOVO\source\repos\turkcellGelecegiYazanlarNET\Proje\pollSystemTurkcell\pollSystemTurkcell\Views\PollReply\AnswerDetails.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 67 "C:\Users\LENOVO\source\repos\turkcellGelecegiYazanlarNET\Proje\pollSystemTurkcell\pollSystemTurkcell\Views\PollReply\AnswerDetails.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ba7c72941e626861c64467b5ac3d8f3e8d2f9e812440", async() => {
                WriteLiteral(" Ankete Dön ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pollID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Users\LENOVO\source\repos\turkcellGelecegiYazanlarNET\Proje\pollSystemTurkcell\pollSystemTurkcell\Views\PollReply\AnswerDetails.cshtml"
                                                                                                       WriteLiteral(ViewBag.PollID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pollID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pollID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pollID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ba7c72941e626861c64467b5ac3d8f3e8d2f9e815117", async() => {
                WriteLiteral(" Cevapları İndir ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pollID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\LENOVO\source\repos\turkcellGelecegiYazanlarNET\Proje\pollSystemTurkcell\pollSystemTurkcell\Views\PollReply\AnswerDetails.cshtml"
                                                                                                         WriteLiteral(ViewBag.PollID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pollID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pollID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pollID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<pollSystemTurkcell.Models.PollResponse>> Html { get; private set; }
    }
}
#pragma warning restore 1591
