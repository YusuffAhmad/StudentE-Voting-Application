#pragma checksum "C:\Users\OLALEKAN\Desktop\MyFiles\Projects\STUDENTEVOTINGAPP\STUDENTEVOTINGAPP\Views\Vote\GetVotesByCandidateIdView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b17df71dcfe47142663a63f07988ef9674dbf57e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vote_GetVotesByCandidateIdView), @"mvc.1.0.view", @"/Views/Vote/GetVotesByCandidateIdView.cshtml")]
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
#line 1 "C:\Users\OLALEKAN\Desktop\MyFiles\Projects\STUDENTEVOTINGAPP\STUDENTEVOTINGAPP\Views\_ViewImports.cshtml"
using STUDENTEVOTINGAPP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OLALEKAN\Desktop\MyFiles\Projects\STUDENTEVOTINGAPP\STUDENTEVOTINGAPP\Views\_ViewImports.cshtml"
using STUDENTEVOTINGAPP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b17df71dcfe47142663a63f07988ef9674dbf57e", @"/Views/Vote/GetVotesByCandidateIdView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46e6ba9502abc26ba9e5031e9817a21651fa418d", @"/Views/_ViewImports.cshtml")]
    public class Views_Vote_GetVotesByCandidateIdView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<STUDENTEVOTINGAPP.DTOs.VoteDto.VoteDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div>
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    ID
                </th>
                <th>
                    Election Name
                </th>
                <th>
                    Position Name
                </th>
                <th>
                    Contestant Name
                </th>
                <th>
                    Contestant MatricNumber
                </th>
                <th>
                    Votes
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 27 "C:\Users\OLALEKAN\Desktop\MyFiles\Projects\STUDENTEVOTINGAPP\STUDENTEVOTINGAPP\Views\Vote\GetVotesByCandidateIdView.cshtml"
             foreach (var vote in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 31 "C:\Users\OLALEKAN\Desktop\MyFiles\Projects\STUDENTEVOTINGAPP\STUDENTEVOTINGAPP\Views\Vote\GetVotesByCandidateIdView.cshtml"
                   Write(vote.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 34 "C:\Users\OLALEKAN\Desktop\MyFiles\Projects\STUDENTEVOTINGAPP\STUDENTEVOTINGAPP\Views\Vote\GetVotesByCandidateIdView.cshtml"
                   Write(vote.ElectionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 37 "C:\Users\OLALEKAN\Desktop\MyFiles\Projects\STUDENTEVOTINGAPP\STUDENTEVOTINGAPP\Views\Vote\GetVotesByCandidateIdView.cshtml"
                   Write(vote.PositionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 40 "C:\Users\OLALEKAN\Desktop\MyFiles\Projects\STUDENTEVOTINGAPP\STUDENTEVOTINGAPP\Views\Vote\GetVotesByCandidateIdView.cshtml"
                   Write(vote.CandidateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 43 "C:\Users\OLALEKAN\Desktop\MyFiles\Projects\STUDENTEVOTINGAPP\STUDENTEVOTINGAPP\Views\Vote\GetVotesByCandidateIdView.cshtml"
                   Write(vote.MatricNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 46 "C:\Users\OLALEKAN\Desktop\MyFiles\Projects\STUDENTEVOTINGAPP\STUDENTEVOTINGAPP\Views\Vote\GetVotesByCandidateIdView.cshtml"
                   Write(vote.VoteCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n");
#nullable restore
#line 49 "C:\Users\OLALEKAN\Desktop\MyFiles\Projects\STUDENTEVOTINGAPP\STUDENTEVOTINGAPP\Views\Vote\GetVotesByCandidateIdView.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<STUDENTEVOTINGAPP.DTOs.VoteDto.VoteDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
