#pragma checksum "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32b059d124dd108d63f73ffea3d21d4a18135cf0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PhoneLineEmployees_Index), @"mvc.1.0.view", @"/Views/PhoneLineEmployees/Index.cshtml")]
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
#line 2 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
using MVCPhoneServiceWeb.Utils;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32b059d124dd108d63f73ffea3d21d4a18135cf0", @"/Views/PhoneLineEmployees/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"761e4d19a9ce39eeacb30215e660ca001e815f86", @"/Views/_ViewImports.cshtml")]
    public class Views_PhoneLineEmployees_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Data.Models.PhoneLineEmployee>>
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
#line 4 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"border backgroundWhite\">\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <h2 class=\"text-black\">\r\n                Phone Lines Employees\r\n            </h2>\r\n        </div>\r\n        <div class=\"col-6 text-right\">\r\n");
#nullable restore
#line 17 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
             if (User.IsInRole(SD.AdminUser))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32b059d124dd108d63f73ffea3d21d4a18135cf07997", async() => {
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
#line 25 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <br />\r\n    <br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32b059d124dd108d63f73ffea3d21d4a18135cf09669", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
          
            Tuple<bool, string>[] show = (Tuple<bool, string>[])ViewData["columns"];
        

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"hidden\" name=\"cpage\"");
                BeginWriteAttribute("value", " value=\"", 1009, "\"", 1034, 1);
#nullable restore
#line 34 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
WriteAttributeValue("", 1017, ViewData["page"], 1017, 17, false);

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
#line 39 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
             if (show[0].Item1)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li class=\"border-0 dropdown-item\"><input type=\"checkbox\" checked name=\"phoneNumberCheck\" />  ");
#nullable restore
#line 41 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                                                                                                         Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 42 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li class=\"border-0 dropdown-item\"><input type=\"checkbox\" name=\"phoneNumberCheck\" />  ");
#nullable restore
#line 45 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                                                                                                 Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 46 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
             if (show[1].Item1)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li class=\"border-0 dropdown-item\"><input type=\"checkbox\" checked name=\"employeeNameCheck\" />  ");
#nullable restore
#line 49 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                                                                                                          Write(Html.DisplayNameFor(model => model.Employee.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 50 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li class=\"border-0 dropdown-item\"><input type=\"checkbox\" name=\"employeeNameCheck\" />  ");
#nullable restore
#line 53 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                                                                                                  Write(Html.DisplayNameFor(model => model.Employee.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 54 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n        <input class=\"btn btn-outline-dark col-form-label\" type=\"submit\" value=\"filter\" />\r\n        <br />\r\n        <br />\r\n        <table class=\"table table-striped border text-center\">\r\n            <tr>\r\n");
#nullable restore
#line 61 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                 if (show[0].Item1)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <th>\r\n                        ");
#nullable restore
#line 64 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n");
#nullable restore
#line 66 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                 if (show[1].Item1)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <th>\r\n                        ");
#nullable restore
#line 70 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Employee.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n");
#nullable restore
#line 72 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                 if (show[0].Item1 || show[1].Item1)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <th></th>\r\n");
#nullable restore
#line 76 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tr>\r\n            <tr>\r\n");
#nullable restore
#line 79 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                 if (show[0].Item1)
                {
                    if (show[0].Item2 != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <th>\r\n                            <input class=\"border rounded form-control\"");
                BeginWriteAttribute("value", " value=\"", 3231, "\"", 3253, 1);
#nullable restore
#line 84 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
WriteAttributeValue("", 3239, show[0].Item2, 3239, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"PhoneNumber\" />\r\n                        </th>\r\n");
#nullable restore
#line 86 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <th>\r\n                        <input class=\"border rounded form-control\" name=\"PhoneNumber\" />\r\n                    </th>\r\n");
#nullable restore
#line 90 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                 if (show[1].Item1)
                {
                    if (show[1].Item2 != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <th>\r\n                            <input class=\"border rounded form-control\"");
                BeginWriteAttribute("value", " value=\"", 3721, "\"", 3743, 1);
#nullable restore
#line 96 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
WriteAttributeValue("", 3729, show[1].Item2, 3729, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"name\" />\r\n                        </th>\r\n");
#nullable restore
#line 98 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <th>\r\n                            <input class=\"border rounded form-control\" name=\"name\" />\r\n                        </th>\r\n");
#nullable restore
#line 104 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                 if (show[0].Item1 || show[1].Item1)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <th></th>\r\n");
#nullable restore
#line 109 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tr>\r\n");
#nullable restore
#line 111 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n");
#nullable restore
#line 114 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                     if (show[0].Item1)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td>\r\n                            ");
#nullable restore
#line 117 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 119 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                     if (show[1].Item1)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td>\r\n                            ");
#nullable restore
#line 123 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Employee.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 125 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 126 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                     if (User.IsInRole(SD.AdminUser) && (show[0].Item1 || show[1].Item1))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td style=\"width:150px\">\r\n                            <div class=\"btn-group\" role=\"group\">\r\n\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32b059d124dd108d63f73ffea3d21d4a18135cf023239", async() => {
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
#line 131 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                                                                                        WriteLiteral(item.PhoneNumber);

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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32b059d124dd108d63f73ffea3d21d4a18135cf025786", async() => {
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
#line 135 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                                                                                           WriteLiteral(item.PhoneNumber);

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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32b059d124dd108d63f73ffea3d21d4a18135cf028336", async() => {
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
#line 139 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                                                                                            WriteLiteral(item.PhoneNumber);

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
#line 144 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tr>\r\n");
#nullable restore
#line 146 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n        <div class=\"row\">\r\n            <nav aria-label=\"Page navigation example\">\r\n                Page ");
#nullable restore
#line 150 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                 Write((int)ViewData["page"] + 1);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <ul class=\"pagination\">\r\n                    <li class=\"page-item\">\r\n                        <input class=\"btn btn-outline-dark col-form-label\" type=\"submit\" value=\"Previous\" name=\"previous\" />\r\n                    </li>\r\n");
#nullable restore
#line 155 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
                     for (int i = (20 * (int)ViewData["mult"]) + 1; i <= ((int)ViewData["mult"] * 20 + (int)ViewData["top"]); i++)//(int)ViewData["count"]; i++)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"page-item\">\r\n                            <input class=\"btn btn-outline-dark col-form-label\" type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 6490, "\"", 6500, 1);
#nullable restore
#line 158 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
WriteAttributeValue("", 6498, i, 6498, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"page\" />\r\n                        </li>\r\n");
#nullable restore
#line 160 "C:\Users\Richard\source\repos\PhoneService\MVCPhoneServiceWeb\Views\PhoneLineEmployees\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Data.Models.PhoneLineEmployee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
