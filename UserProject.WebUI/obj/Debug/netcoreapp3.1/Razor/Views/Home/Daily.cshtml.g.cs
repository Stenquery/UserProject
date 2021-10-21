#pragma checksum "C:\UserProject\UserProject.WebUI\Views\Home\Daily.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f99bf19142a399c885834577678d5482b085a9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Daily), @"mvc.1.0.view", @"/Views/Home/Daily.cshtml")]
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
#line 2 "C:\UserProject\UserProject.WebUI\Views\_ViewImports.cshtml"
using UserProject.WebUI.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f99bf19142a399c885834577678d5482b085a9c", @"/Views/Home/Daily.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa5b232fb781bd6380ba4c52fd186d6f15e0b03b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Daily : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f99bf19142a399c885834577678d5482b085a9c3036", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
    <title>Document</title>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f99bf19142a399c885834577678d5482b085a9c4436", async() => {
                WriteLiteral("\r\n  ");
#nullable restore
#line 12 "C:\UserProject\UserProject.WebUI\Views\Home\Daily.cshtml"
Write(await Html.PartialAsync("_navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
  <header>
       <div class=""jumbotron"">
            <h1 class=""display-5"">Merhabalar!</h1>
            <p class=""lead"">Aşağıdaki listede günlük(G) olarak planlanan işleri görmektesiniz.</p>
            <hr class=""my-4"">
        </div>
    </header>
    <table class=""table table-dark"">
        <thead>
            <tr>
            <th scope=""col""></th>
            <th scope=""col"">Konu</th>
            <th scope=""col"">Açıklama</th>
            <th scope=""col"">Aciliyet</th>
            <th scope=""col"">Başlangıç</th>
            <th scope=""col"">Bitiş</th>
            <th scope=""col"">Tipi</th>
            <th scope=""col"">Not</th>
            <th scope=""col""></th>
    </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 35 "C:\UserProject\UserProject.WebUI\Views\Home\Daily.cshtml"
       for (int i = 0; i < Model.works.Count; i++)
      {
        {int a = i;}

#line default
#line hidden
#nullable disable
                WriteLiteral("          <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 39 "C:\UserProject\UserProject.WebUI\Views\Home\Daily.cshtml"
                            Write(i+1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 40 "C:\UserProject\UserProject.WebUI\Views\Home\Daily.cshtml"
               Write(Model.works[i].subject);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "C:\UserProject\UserProject.WebUI\Views\Home\Daily.cshtml"
               Write(Model.works[i].DESCRIPTION);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "C:\UserProject\UserProject.WebUI\Views\Home\Daily.cshtml"
               Write(Model.works[i].emergency);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 43 "C:\UserProject\UserProject.WebUI\Views\Home\Daily.cshtml"
               Write(Model.works[i].startDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 44 "C:\UserProject\UserProject.WebUI\Views\Home\Daily.cshtml"
               Write(Model.works[i].endDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 45 "C:\UserProject\UserProject.WebUI\Views\Home\Daily.cshtml"
               Write(Model.works[i].type);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 46 "C:\UserProject\UserProject.WebUI\Views\Home\Daily.cshtml"
               Write(Model.works[i].note);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td><div class=\"button btn btn-secondary\"><i class=\"fa fa-close\"> Sil</i></div>  <div class=\"button btn btn-secondary\"><i class=\"fa fa-bars\"></i> Düzenle</div></td>\r\n            </tr>\r\n");
#nullable restore
#line 49 "C:\UserProject\UserProject.WebUI\Views\Home\Daily.cshtml"
      }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    
  </tbody>
    </table>
  <div class=""row"">
    <div class=""col-md-3""><div class=""d-grid gap-2 col-12 mx-auto""></div></div>
        <div class=""col-md-3""><div class=""d-grid gap-2 col-12 mx-auto""></div></div>
        <div class=""col-md-3""><div class=""d-grid gap-2 col-12 mx-auto""></div></div>
        <div class=""col-md-3""><div class=""d-grid gap col-12 mx-auto""><div class=""button btn btn-secondary""><i class=""fa fa-bars""> Yeni bir iş ekle </i></div></div></div>
      </div>


    ");
#nullable restore
#line 61 "C:\UserProject\UserProject.WebUI\Views\Home\Daily.cshtml"
Write(await Html.PartialAsync("_footer"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
