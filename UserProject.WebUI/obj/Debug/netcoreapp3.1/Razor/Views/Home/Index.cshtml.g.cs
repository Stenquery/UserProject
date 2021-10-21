#pragma checksum "C:\UserProject\UserProject.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60940ae884819c1c130050329a51a82e18870593"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60940ae884819c1c130050329a51a82e18870593", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa5b232fb781bd6380ba4c52fd186d6f15e0b03b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WorkViewModel>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60940ae884819c1c130050329a51a82e188705933042", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
     <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"">
     <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
     
     
    <title>Home</title>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60940ae884819c1c130050329a51a82e188705934678", async() => {
                WriteLiteral("\r\n  ");
#nullable restore
#line 16 "C:\UserProject\UserProject.WebUI\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("_navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <header>
       <div class=""jumbotron"">
            <h1 class=""display-5"">Merhabalar!</h1>
            <p class=""lead"">Aşağıdaki listede günlük(G) , haftalık(H) ve aylık(A) olarak planlanan işleri görmektesiniz.</p>
            <hr class=""my-4"">
        </div>
    </header>
    <main>
      <table class=""table table-secondary"">
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
#line 40 "C:\UserProject\UserProject.WebUI\Views\Home\Index.cshtml"
       for (int i = 0; i < Model.works.Count; i++)
      {
        {int a = i;}

#line default
#line hidden
#nullable disable
                WriteLiteral("          <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 44 "C:\UserProject\UserProject.WebUI\Views\Home\Index.cshtml"
                            Write(i+1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 45 "C:\UserProject\UserProject.WebUI\Views\Home\Index.cshtml"
               Write(Model.works[i].subject);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 46 "C:\UserProject\UserProject.WebUI\Views\Home\Index.cshtml"
               Write(Model.works[i].DESCRIPTION);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 47 "C:\UserProject\UserProject.WebUI\Views\Home\Index.cshtml"
               Write(Model.works[i].emergency);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 48 "C:\UserProject\UserProject.WebUI\Views\Home\Index.cshtml"
               Write(Model.works[i].startDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 49 "C:\UserProject\UserProject.WebUI\Views\Home\Index.cshtml"
               Write(Model.works[i].endDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 50 "C:\UserProject\UserProject.WebUI\Views\Home\Index.cshtml"
               Write(Model.works[i].type);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 51 "C:\UserProject\UserProject.WebUI\Views\Home\Index.cshtml"
               Write(Model.works[i].note);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td><div class=\"button btn btn-secondary\"><i class=\"fa fa-close\"> Sil</i></div>  <div class=\"button btn btn-secondary\"><i class=\"fa fa-bars\"></i> Düzenle</div></td>\r\n            </tr>\r\n");
#nullable restore
#line 54 "C:\UserProject\UserProject.WebUI\Views\Home\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"  </tbody> 
      </table>

      <div class=""container"">
        <div class=""row"">
          <div class=""col-md-12"">
            <div class=""d-grid gap-2""> 
             <div class=""row"">
        <div class=""col-md-4""><div class=""d-grid gap-2 col-12 mx-auto""><div class=""button btn btn-secondary""><i class=""fa fa-bars""> Günlük İşleri Görüntüle </i></div></div></div>
        <div class=""col-md-4""><div class=""d-grid gap-2 col-12 mx-auto""><div class=""button btn btn-secondary""><i class=""fa fa-bars""> Haftalık İşleri Görüntüle </i></div></div></div>
        <div class=""col-md-4""><div class=""d-grid gap-2 col-12 mx-auto""><div class=""button btn btn-secondary""><i class=""fa fa-bars""> Aylık İşleri Görüntüle </i></div></div></div>
      </div>
      <div class=""row"">
        <div class=""col-md-4""><div class=""d-grid gap-2 col-12 mx-auto""></div></div>
        <div class=""col-md-4""><div class=""d-grid gap-2 col-12 mx-auto""><div class=""button btn btn-secondary""><i class=""fa fa-bars""> Yeni bir iş ekle </i></div></d");
                WriteLiteral("iv></div>\r\n        <div class=\"col-md-4\"><div class=\"d-grid gap-2 col-12 mx-auto\"></div></div>\r\n        </div>\r\n      </div>\r\n      \r\n      </div>\r\n      </div>\r\n      \r\n      \r\n    </main>\r\n    \r\n  ");
#nullable restore
#line 80 "C:\UserProject\UserProject.WebUI\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WorkViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591