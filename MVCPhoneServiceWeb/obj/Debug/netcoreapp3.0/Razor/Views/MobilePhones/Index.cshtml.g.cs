#pragma checksum "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "461b4282d234755e7e60aa9e3299b146fb1b4167"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MobilePhones_Index), @"mvc.1.0.view", @"/Views/MobilePhones/Index.cshtml")]
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
#line 1 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\_ViewImports.cshtml"
using MVCPhoneServiceWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
using MVCPhoneServiceWeb.Utils;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"461b4282d234755e7e60aa9e3299b146fb1b4167", @"/Views/MobilePhones/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"761e4d19a9ce39eeacb30215e660ca001e815f86", @"/Views/_ViewImports.cshtml")]
    public class Views_MobilePhones_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Data.Models.MobilePhone>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" btn btn-info text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" btn btn-dark text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" btn btn-danger text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"border backgroundWhite\">\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <h2 class=\"text-black\">\r\n                Mobile Phones\r\n            </h2>\r\n        </div>\r\n        <div class=\"col-6 text-right\">\r\n");
#nullable restore
#line 17 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
             if (User.IsInRole(SD.AdminUser))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "461b4282d234755e7e60aa9e3299b146fb1b41677935", async() => {
                WriteLiteral("\r\n                        <i class=\"fa fa-plus\"></i>\r\n                        &nbsp; Create New\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </p>\r\n");
#nullable restore
#line 25 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <br />\r\n    <br />\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "461b4282d234755e7e60aa9e3299b146fb1b41679605", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
          
            Tuple<bool, string>[] show = (Tuple<bool, string>[])ViewData["columns"];
        

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"hidden\" name=\"cpage\"");
                BeginWriteAttribute("value", " value=\"", 997, "\"", 1022, 1);
#nullable restore
#line 35 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
WriteAttributeValue("", 1005, ViewData["page"], 1005, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
        <a class=""btn btn-outline-dark dropdown-toggle"" href=""#"" id=""navbarDropDownMenuLink2"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            Columns
        </a>
        <div id=""checklist"" class=""dropdown-menu"" aria-labelledby=""navbarDropDownMenuLink"">
");
#nullable restore
#line 40 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
             if (show[0].Item1)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li class=\"border-0 dropdown-item\"><input type=\"checkbox\" checked name=\"iMEICheck\" />  ");
#nullable restore
#line 42 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                                                                                                  Write(Html.DisplayNameFor(model => model.IMEI));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 43 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li class=\"border-0 dropdown-item\"><input type=\"checkbox\" name=\"iMEICheck\" />  ");
#nullable restore
#line 46 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                                                                                          Write(Html.DisplayNameFor(model => model.IMEI));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 47 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
             if (show[1].Item1)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li class=\"border-0 dropdown-item\"><input type=\"checkbox\" checked name=\"modelCheck\" />  ");
#nullable restore
#line 50 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                                                                                                   Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 51 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li class=\"border-0 dropdown-item\"><input type=\"checkbox\" name=\"modelCheck\" />  ");
#nullable restore
#line 54 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                                                                                           Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 55 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n        <input class=\"btn btn-outline-dark col-form-label\" type=\"submit\" value=\"filter\" />\r\n        <br />\r\n        <br />\r\n        <table class=\"table table-striped border text-center\">\r\n            <tr>\r\n");
#nullable restore
#line 62 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                 if (show[0].Item1)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <th>\r\n                        ");
#nullable restore
#line 65 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.IMEI));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n");
#nullable restore
#line 67 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                 if (show[1].Item1)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <th>\r\n                        ");
#nullable restore
#line 71 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n");
#nullable restore
#line 73 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                 if (show[0].Item1 || show[1].Item1)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <th></th>\r\n");
#nullable restore
#line 77 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tr>\r\n            <tr>\r\n");
#nullable restore
#line 80 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                 if (show[0].Item1)
                {
                    if (show[0].Item2 != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <th>\r\n                            <input class=\"border rounded form-control\"");
                BeginWriteAttribute("value", " value=\"", 3146, "\"", 3168, 1);
#nullable restore
#line 85 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
WriteAttributeValue("", 3154, show[0].Item2, 3154, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"iMEI\" />\r\n                        </th>\r\n");
#nullable restore
#line 87 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <th>\r\n                            <input class=\"border rounded form-control\" name=\"iMEI\" />\r\n                        </th>\r\n");
#nullable restore
#line 93 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                 if (show[1].Item1)
                {
                    if (show[1].Item2 != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <th>\r\n                            <input class=\"border rounded form-control\"");
                BeginWriteAttribute("value", " value=\"", 3706, "\"", 3728, 1);
#nullable restore
#line 100 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
WriteAttributeValue("", 3714, show[1].Item2, 3714, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"model\" />\r\n                        </th>\r\n");
#nullable restore
#line 102 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <th>\r\n                            <input class=\"border rounded form-control\" name=\"model\" />\r\n                        </th>\r\n");
#nullable restore
#line 108 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                 if (show[0].Item1 || show[1].Item1)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <th></th>\r\n");
#nullable restore
#line 113 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tr>\r\n");
#nullable restore
#line 115 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
             foreach (var item in Model)
            {



#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n");
#nullable restore
#line 120 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                     if (show[0].Item1)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td>\r\n                            ");
#nullable restore
#line 123 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.IMEI));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 125 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 126 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                     if (show[1].Item1)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td>\r\n                            ");
#nullable restore
#line 129 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Model));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 131 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                     if (User.IsInRole(SD.AdminUser) && (show[0].Item1 || show[1].Item1))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td style=\"width:150px\">\r\n                            <div class=\"btn-group\" role=\"group\">\r\n\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "461b4282d234755e7e60aa9e3299b146fb1b416722908", async() => {
                    WriteLiteral("\r\n                                    <i class=\"fas fa-edit\"></i>\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 137 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                                                                                        WriteLiteral(item.IMEI);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "461b4282d234755e7e60aa9e3299b146fb1b416725442", async() => {
                    WriteLiteral("\r\n                                    <i class=\"fas fa-list\"></i>\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 141 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                                                                                           WriteLiteral(item.IMEI);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "461b4282d234755e7e60aa9e3299b146fb1b416727979", async() => {
                    WriteLiteral("\r\n                                    <i class=\"fas fa-trash-alt\"></i>\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 145 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                                                                                            WriteLiteral(item.IMEI);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n");
#nullable restore
#line 150 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tr>\r\n");
#nullable restore
#line 152 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n        <div class=\"row\">\r\n            <nav aria-label=\"Page navigation example\">\r\n                Page ");
#nullable restore
#line 156 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                 Write((int)ViewData["page"] + 1);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <ul class=\"pagination\">\r\n                    <li class=\"page-item\">\r\n                        <input class=\"btn btn-outline-dark col-form-label\" type=\"submit\" value=\"Previous\" name=\"previous\" />\r\n                    </li>\r\n");
#nullable restore
#line 161 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                     for (int i = (20 * (int)ViewData["mult"]) + 1; i <= ((int)ViewData["mult"] * 20 + (int)ViewData["top"]); i++)//(int)ViewData["count"]; i++)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"page-item\">\r\n                            <input class=\"btn btn-outline-dark col-form-label\" type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 6445, "\"", 6455, 1);
#nullable restore
#line 164 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
WriteAttributeValue("", 6453, i, 6453, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"page\" />\r\n                        </li>\r\n");
#nullable restore
#line 166 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\MobilePhones\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <li class=""page-item"">
                        <input class=""btn btn-outline-dark col-form-label"" type=""submit"" value=""Next"" name=""next"" />
                    </li>
                </ul>
            </nav>
        </div>
        <div class=""row"">
            <div class=""col-12 text-right"">
                <a class="" btn btn-success text-white"">
                    <i class=""fas fa-trash-""></i>
                    Export
                </a>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Data.Models.MobilePhone>> Html { get; private set; }
    }
}
#pragma warning restore 1591
