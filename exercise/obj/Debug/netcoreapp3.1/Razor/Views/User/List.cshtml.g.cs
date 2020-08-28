#pragma checksum "D:\module3\exercise\exercise\Views\User\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1272587e2e3b0220cb0b117134042430a25b118e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(exercise.Pages.User.Views_User_List), @"mvc.1.0.view", @"/Views/User/List.cshtml")]
namespace exercise.Pages.User
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
#line 1 "D:\module3\exercise\exercise\Views\_ViewImports.cshtml"
using exercise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\module3\exercise\exercise\Views\_ViewImports.cshtml"
using exercise.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\module3\exercise\exercise\Views\_ViewImports.cshtml"
using exercise.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1272587e2e3b0220cb0b117134042430a25b118e", @"/Views/User/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bc4e5dfc211291586c00fade3068e4727d9f991", @"/Views/_ViewImports.cshtml")]
    public class Views_User_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\module3\exercise\exercise\Views\User\List.cshtml"
  
    ViewBag.Title = "Show list customer";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered table-hover mt-2\" id=\"demotable\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n");
            WriteLiteral("                ");
#nullable restore
#line 10 "D:\module3\exercise\exercise\Views\User\List.cshtml"
           Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>");
#nullable restore
#line 12 "D:\module3\exercise\exercise\Views\User\List.cshtml"
           Write(Html.DisplayNameFor(model => model.numberPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 13 "D:\module3\exercise\exercise\Views\User\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 14 "D:\module3\exercise\exercise\Views\User\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 15 "D:\module3\exercise\exercise\Views\User\List.cshtml"
           Write(Html.DisplayNameFor(model => model.idProvince));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 16 "D:\module3\exercise\exercise\Views\User\List.cshtml"
           Write(Html.DisplayNameFor(model => model.idDistrict));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 17 "D:\module3\exercise\exercise\Views\User\List.cshtml"
           Write(Html.DisplayNameFor(model => model.idWard));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 21 "D:\module3\exercise\exercise\Views\User\List.cshtml"
         if (Model != null && Model.Any())
        {
            foreach (var row in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 26 "D:\module3\exercise\exercise\Views\User\List.cshtml"
                   Write(row.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "D:\module3\exercise\exercise\Views\User\List.cshtml"
                   Write(row.numberPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "D:\module3\exercise\exercise\Views\User\List.cshtml"
                   Write(row.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "D:\module3\exercise\exercise\Views\User\List.cshtml"
                   Write(row.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "D:\module3\exercise\exercise\Views\User\List.cshtml"
                   Write(row.Province._name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "D:\module3\exercise\exercise\Views\User\List.cshtml"
                   Write(row.District._name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "D:\module3\exercise\exercise\Views\User\List.cshtml"
                   Write(row.Ward._name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 34 "D:\module3\exercise\exercise\Views\User\List.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<link href=\"https://cdn.datatables.net/1.10.21/css/jquery.dataTables.min.css\" rel=\"stylesheet\"></link>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@" 
<script src=""https://cdn.datatables.net/1.10.21/js/jquery.dataTables.min.js""></script>


<script>
    $(document).ready(function () {

        $('#demotable').DataTable(
            //{
            //    ""ajax"": {
            //        ""url"": ""/User/GetList"",
            //        ""type"": ""GET"",
            //        ""datatype"": ""json""
            //    },
            //    ""columns"":[
            //        { ""data"": ""FullName"" },
            //        { ""data"": ""numberPhone"" },
            //        { ""data"": ""Email"" },
            //        { ""data"": ""Address"" },
            //        { ""data"": ""Province"" },
            //        { ""data"": ""District"" },
            //        {""data"": ""Ward"" }
            //    ]
            //}
        );
    });
</script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
