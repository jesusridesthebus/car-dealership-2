#pragma checksum "/Users/Guest/Desktop/CarDealership.Solution/CarDealership/Views/Car/PageOfCars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "318e4ac48f2ea651bf2d07f3cfeb32db6f0353b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_PageOfCars), @"mvc.1.0.view", @"/Views/Car/PageOfCars.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Car/PageOfCars.cshtml", typeof(AspNetCore.Views_Car_PageOfCars))]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/Guest/Desktop/CarDealership.Solution/CarDealership/Views/Car/PageOfCars.cshtml"
using System;

#line default
#line hidden
#line 2 "/Users/Guest/Desktop/CarDealership.Solution/CarDealership/Views/Car/PageOfCars.cshtml"
using CarDealership.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"318e4ac48f2ea651bf2d07f3cfeb32db6f0353b4", @"/Views/Car/PageOfCars.cshtml")]
    public class Views_Car_PageOfCars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 45, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\" dir=\"ltr\">\n  ");
            EndContext();
            BeginContext(89, 183, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "318e4ac48f2ea651bf2d07f3cfeb32db6f0353b43517", async() => {
                BeginContext(95, 170, true);
                WriteLiteral("\n    <meta charset=\"utf-8\">\n    <link rel=\'stylesheet\' href=\'https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css\'>\n    <title>Carz 2 Purchase</title>\n  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(272, 3, true);
            WriteLiteral("\n  ");
            EndContext();
            BeginContext(275, 593, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "318e4ac48f2ea651bf2d07f3cfeb32db6f0353b44855", async() => {
                BeginContext(299, 160, true);
                WriteLiteral("\n    <h1><em><strong>Here are our cars</em></strong></h1>\n    <h1><em><strong>BUY THEM...!!!!</em></strong></h1>\n    <h1 class=\"jumbotron\">CARZ!</h1>\n\n    <ul>\n");
                EndContext();
#line 16 "/Users/Guest/Desktop/CarDealership.Solution/CarDealership/Views/Car/PageOfCars.cshtml"
     if (Model.Count == 0)
    {

#line default
#line hidden
                BeginContext(492, 41, true);
                WriteLiteral("      <p>There are no cars for sale!</p>\n");
                EndContext();
#line 19 "/Users/Guest/Desktop/CarDealership.Solution/CarDealership/Views/Car/PageOfCars.cshtml"
    }

#line default
#line hidden
                BeginContext(539, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 20 "/Users/Guest/Desktop/CarDealership.Solution/CarDealership/Views/Car/PageOfCars.cshtml"
     if(Model.Count != 0)
    {
      

#line default
#line hidden
#line 22 "/Users/Guest/Desktop/CarDealership.Solution/CarDealership/Views/Car/PageOfCars.cshtml"
       foreach (Car car in Model)
      {

#line default
#line hidden
                BeginContext(613, 12, true);
                WriteLiteral("        <li>");
                EndContext();
                BeginContext(626, 18, false);
#line 24 "/Users/Guest/Desktop/CarDealership.Solution/CarDealership/Views/Car/PageOfCars.cshtml"
       Write(car.GetMakeModel());

#line default
#line hidden
                EndContext();
                BeginContext(644, 18, true);
                WriteLiteral("</li>\n        <li>");
                EndContext();
                BeginContext(663, 14, false);
#line 25 "/Users/Guest/Desktop/CarDealership.Solution/CarDealership/Views/Car/PageOfCars.cshtml"
       Write(car.GetPrice());

#line default
#line hidden
                EndContext();
                BeginContext(677, 18, true);
                WriteLiteral("</li>\n        <li>");
                EndContext();
                BeginContext(696, 14, false);
#line 26 "/Users/Guest/Desktop/CarDealership.Solution/CarDealership/Views/Car/PageOfCars.cshtml"
       Write(car.GetMiles());

#line default
#line hidden
                EndContext();
                BeginContext(710, 18, true);
                WriteLiteral("</li>\n        <li>");
                EndContext();
                BeginContext(729, 16, false);
#line 27 "/Users/Guest/Desktop/CarDealership.Solution/CarDealership/Views/Car/PageOfCars.cshtml"
       Write(car.GetMessage());

#line default
#line hidden
                EndContext();
                BeginContext(745, 41, true);
                WriteLiteral("</li>\n        <p>\"-----------------\"</p>\n");
                EndContext();
#line 29 "/Users/Guest/Desktop/CarDealership.Solution/CarDealership/Views/Car/PageOfCars.cshtml"
      }

#line default
#line hidden
#line 29 "/Users/Guest/Desktop/CarDealership.Solution/CarDealership/Views/Car/PageOfCars.cshtml"
       
    }

#line default
#line hidden
                BeginContext(800, 61, true);
                WriteLiteral("  </ul>\n  <a  href=\"/admin\">Admin only: add a new car.</a>\n  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(868, 9, true);
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
