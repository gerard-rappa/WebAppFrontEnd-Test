#pragma checksum "C:\Users\WWStudent\Source\Repos\gerard-rappa\MSSA-Project\TacoBoutIt\TacoBoutIt\Views\Meme\LocalList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a964badfb1386bd598480677739a3e0edc3683f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Meme_LocalList), @"mvc.1.0.view", @"/Views/Meme/LocalList.cshtml")]
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
#line 1 "C:\Users\WWStudent\Source\Repos\gerard-rappa\MSSA-Project\TacoBoutIt\TacoBoutIt\Views\_ViewImports.cshtml"
using TacoBoutIt.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\WWStudent\Source\Repos\gerard-rappa\MSSA-Project\TacoBoutIt\TacoBoutIt\Views\_ViewImports.cshtml"
using TacoBoutIt.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a964badfb1386bd598480677739a3e0edc3683f", @"/Views/Meme/LocalList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b680dde1517f0cf5fa9c8a850d7b2f8f65e1fa88", @"/Views/_ViewImports.cshtml")]
    public class Views_Meme_LocalList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Meme>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\WWStudent\Source\Repos\gerard-rappa\MSSA-Project\TacoBoutIt\TacoBoutIt\Views\Meme\LocalList.cshtml"
 foreach (var r in Model)
{
    if (r.ImgUrl.Contains(".webm"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"flex-fill px-4\" style=\"text-align:center; width:100%\">\r\n            <video controls class=\"img-fluid\" type=\"video/webm\" style=\"max-width:650px; width:100%\"");
            BeginWriteAttribute("src", " src=\"", 277, "\"", 338, 2);
            WriteAttributeValue("", 283, "https://litmemes.blob.core.windows.net/images/", 283, 46, true);
#nullable restore
#line 8 "C:\Users\WWStudent\Source\Repos\gerard-rappa\MSSA-Project\TacoBoutIt\TacoBoutIt\Views\Meme\LocalList.cshtml"
WriteAttributeValue("", 329, r.ImgUrl, 329, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></video>\r\n            <p class=\"container-fluid font-weight-light\">Latitude: ");
#nullable restore
#line 9 "C:\Users\WWStudent\Source\Repos\gerard-rappa\MSSA-Project\TacoBoutIt\TacoBoutIt\Views\Meme\LocalList.cshtml"
                                                              Write(r.Latitude);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>Longitude: ");
#nullable restore
#line 9 "C:\Users\WWStudent\Source\Repos\gerard-rappa\MSSA-Project\TacoBoutIt\TacoBoutIt\Views\Meme\LocalList.cshtml"
                                                                                         Write(r.Longitude);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <br />\r\n        </div>\r\n");
#nullable restore
#line 12 "C:\Users\WWStudent\Source\Repos\gerard-rappa\MSSA-Project\TacoBoutIt\TacoBoutIt\Views\Meme\LocalList.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"flex-fill px-4\" style=\"text-align:center; width:100%\">\r\n            <img class=\"img-fluid rounded\" style=\"max-width:650px; width:100%\"");
            BeginWriteAttribute("src", " src=\"", 676, "\"", 737, 2);
            WriteAttributeValue("", 682, "https://litmemes.blob.core.windows.net/images/", 682, 46, true);
#nullable restore
#line 16 "C:\Users\WWStudent\Source\Repos\gerard-rappa\MSSA-Project\TacoBoutIt\TacoBoutIt\Views\Meme\LocalList.cshtml"
WriteAttributeValue("", 728, r.ImgUrl, 728, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <p class=\"container-fluid font-weight-light\">Latitude: ");
#nullable restore
#line 17 "C:\Users\WWStudent\Source\Repos\gerard-rappa\MSSA-Project\TacoBoutIt\TacoBoutIt\Views\Meme\LocalList.cshtml"
                                                              Write(r.Latitude);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>Longitude: ");
#nullable restore
#line 17 "C:\Users\WWStudent\Source\Repos\gerard-rappa\MSSA-Project\TacoBoutIt\TacoBoutIt\Views\Meme\LocalList.cshtml"
                                                                                         Write(r.Longitude);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <br />\r\n        </div>\r\n");
#nullable restore
#line 20 "C:\Users\WWStudent\Source\Repos\gerard-rappa\MSSA-Project\TacoBoutIt\TacoBoutIt\Views\Meme\LocalList.cshtml"
    }
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Meme>> Html { get; private set; }
    }
}
#pragma warning restore 1591
