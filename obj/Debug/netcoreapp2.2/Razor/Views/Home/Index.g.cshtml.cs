#pragma checksum "/Users/lynneasmoyer/Documents/CodingDojo/C#/ChefsNDishes/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6baa072aab02d9956570d8432afe372b509b3ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/lynneasmoyer/Documents/CodingDojo/C#/ChefsNDishes/Views/_ViewImports.cshtml"
using ChefsNDishes;

#line default
#line hidden
#line 2 "/Users/lynneasmoyer/Documents/CodingDojo/C#/ChefsNDishes/Views/_ViewImports.cshtml"
using ChefsNDishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6baa072aab02d9956570d8432afe372b509b3ee", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3683dbd783bea45b88d0b0d3ee52e8ec1e5d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Chef>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddChef", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/lynneasmoyer/Documents/CodingDojo/C#/ChefsNDishes/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(66, 115, true);
            WriteLiteral("\r\n\r\n\r\n\r\n<h1><a href=\"chefs\">Chefs</a> & <a href=\"dishes\">Dishes</a></h1>\r\n<h2>Check out our roster of chefs!</h2>\r\n");
            EndContext();
            BeginContext(181, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6baa072aab02d9956570d8432afe372b509b3ee4120", async() => {
                BeginContext(227, 10, true);
                WriteLiteral("Add a Chef");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(241, 234, true);
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">Chef</th>\r\n            <th scope=\"col\">Age</th>\r\n            <th scope=\"col\">Number of Dishes</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n        \r\n");
            EndContext();
#line 24 "/Users/lynneasmoyer/Documents/CodingDojo/C#/ChefsNDishes/Views/Home/Index.cshtml"
             foreach(Chef c in Model)
            {

#line default
#line hidden
            BeginContext(529, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(568, 11, false);
#line 27 "/Users/lynneasmoyer/Documents/CodingDojo/C#/ChefsNDishes/Views/Home/Index.cshtml"
               Write(c.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(579, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(581, 10, false);
#line 27 "/Users/lynneasmoyer/Documents/CodingDojo/C#/ChefsNDishes/Views/Home/Index.cshtml"
                            Write(c.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(591, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
#line 28 "/Users/lynneasmoyer/Documents/CodingDojo/C#/ChefsNDishes/Views/Home/Index.cshtml"
                      
                    int age = @DateTime.Now.Year - @c.Birthday.Year;
                    if(@c.Birthday.Date > DateTime.Now.AddYears(-age)) age--;
                    

#line default
#line hidden
            BeginContext(794, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(815, 3, false);
#line 32 "/Users/lynneasmoyer/Documents/CodingDojo/C#/ChefsNDishes/Views/Home/Index.cshtml"
               Write(age);

#line default
#line hidden
            EndContext();
            BeginContext(818, 46, true);
            WriteLiteral(" \r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(865, 21, false);
#line 34 "/Users/lynneasmoyer/Documents/CodingDojo/C#/ChefsNDishes/Views/Home/Index.cshtml"
               Write(c.CreatedDishes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(886, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 36 "/Users/lynneasmoyer/Documents/CodingDojo/C#/ChefsNDishes/Views/Home/Index.cshtml"
            }

#line default
#line hidden
            BeginContext(927, 24, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Chef>> Html { get; private set; }
    }
}
#pragma warning restore 1591