#pragma checksum "C:\Users\YKunnummal\source\Dapper\MovieDatabase\Views\Movie\Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "349415ffcfc9deeccded1a993945c44932bc498b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Registration), @"mvc.1.0.view", @"/Views/Movie/Registration.cshtml")]
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
#line 1 "C:\Users\YKunnummal\source\Dapper\MovieDatabase\Views\_ViewImports.cshtml"
using MovieDatabase;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\YKunnummal\source\Dapper\MovieDatabase\Views\_ViewImports.cshtml"
using MovieDatabase.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"349415ffcfc9deeccded1a993945c44932bc498b", @"/Views/Movie/Registration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b64e345199f309f4f0b3b1e8798dd9fd6a0b6fb7", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\YKunnummal\source\Dapper\MovieDatabase\Views\Movie\Registration.cshtml"
 using (Html.BeginForm("Registration", "Movie", FormMethod.Post))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Movie Registration Form</h2>\r\n");
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 9 "C:\Users\YKunnummal\source\Dapper\MovieDatabase\Views\Movie\Registration.cshtml"
   Write(Html.LabelFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 10 "C:\Users\YKunnummal\source\Dapper\MovieDatabase\Views\Movie\Registration.cshtml"
   Write(Html.TextBoxFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n       </div>\r\n");
            WriteLiteral("            <div>\r\n                ");
#nullable restore
#line 14 "C:\Users\YKunnummal\source\Dapper\MovieDatabase\Views\Movie\Registration.cshtml"
           Write(Html.LabelFor(m => m.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 15 "C:\Users\YKunnummal\source\Dapper\MovieDatabase\Views\Movie\Registration.cshtml"
           Write(Html.TextBoxFor(m => m.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <div>\r\n                ");
#nullable restore
#line 19 "C:\Users\YKunnummal\source\Dapper\MovieDatabase\Views\Movie\Registration.cshtml"
           Write(Html.LabelFor(m => m.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 20 "C:\Users\YKunnummal\source\Dapper\MovieDatabase\Views\Movie\Registration.cshtml"
           Write(Html.DropDownListFor(m => m.Genre, new SelectList(Enum.GetValues(typeof(Genre)))));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
#nullable restore
#line 23 "C:\Users\YKunnummal\source\Dapper\MovieDatabase\Views\Movie\Registration.cshtml"
           Write(Html.LabelFor(m => m.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 24 "C:\Users\YKunnummal\source\Dapper\MovieDatabase\Views\Movie\Registration.cshtml"
           Write(Html.TextBoxFor(m => m.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
#nullable restore
#line 27 "C:\Users\YKunnummal\source\Dapper\MovieDatabase\Views\Movie\Registration.cshtml"
           Write(Html.LabelFor(m => m.Runtime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 28 "C:\Users\YKunnummal\source\Dapper\MovieDatabase\Views\Movie\Registration.cshtml"
           Write(Html.TextBoxFor(m => m.Runtime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <input type=\"submit\" value=\"Submit\" />\r\n");
#nullable restore
#line 32 "C:\Users\YKunnummal\source\Dapper\MovieDatabase\Views\Movie\Registration.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591