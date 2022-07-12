#pragma checksum "C:\Users\Nikola Nushev\source\repos\CinemaTicketingAdminApp\CinemaTicketingAdminApp\Views\Order\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb935007c2e83f6222365b78db58365a09a9472b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Details), @"mvc.1.0.view", @"/Views/Order/Details.cshtml")]
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
#line 1 "C:\Users\Nikola Nushev\source\repos\CinemaTicketingAdminApp\CinemaTicketingAdminApp\Views\_ViewImports.cshtml"
using CinemaTicketingAdminApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nikola Nushev\source\repos\CinemaTicketingAdminApp\CinemaTicketingAdminApp\Views\_ViewImports.cshtml"
using CinemaTicketingAdminApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb935007c2e83f6222365b78db58365a09a9472b", @"/Views/Order/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c730906033df278a147c2e8678fb5b4b96a57ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CinemaTicketingAdminApp.Models.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"m-3\">\r\n        <h2>Order For: ");
#nullable restore
#line 11 "C:\Users\Nikola Nushev\source\repos\CinemaTicketingAdminApp\CinemaTicketingAdminApp\Views\Order\Details.cshtml"
                  Write(Model.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    </div>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Nikola Nushev\source\repos\CinemaTicketingAdminApp\CinemaTicketingAdminApp\Views\Order\Details.cshtml"
     for (int i = 0; i < Model.MovieTickets.Count; i++)
    {
        var item = Model.MovieTickets.ElementAt(i).SelectedMovieTicket;

        if (i % 3 == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 21 "C:\Users\Nikola Nushev\source\repos\CinemaTicketingAdminApp\CinemaTicketingAdminApp\Views\Order\Details.cshtml"
            }


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\" style=\"width: 20rem; margin:10px;\">\r\n                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 624, "\"", 652, 1);
#nullable restore
#line 24 "C:\Users\Nikola Nushev\source\repos\CinemaTicketingAdminApp\CinemaTicketingAdminApp\Views\Order\Details.cshtml"
WriteAttributeValue("", 630, item.Movie.MovieImage, 630, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" style=\"height:90%; width:100%\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 26 "C:\Users\Nikola Nushev\source\repos\CinemaTicketingAdminApp\CinemaTicketingAdminApp\Views\Order\Details.cshtml"
                                      Write(item.Movie.MovieName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p><small>Genre: ");
#nullable restore
#line 27 "C:\Users\Nikola Nushev\source\repos\CinemaTicketingAdminApp\CinemaTicketingAdminApp\Views\Order\Details.cshtml"
                                Write(item.Movie.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n                    <p class=\"card-text\">Ticket Number: ");
#nullable restore
#line 28 "C:\Users\Nikola Nushev\source\repos\CinemaTicketingAdminApp\CinemaTicketingAdminApp\Views\Order\Details.cshtml"
                                                   Write(item.Ticket.TicketNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"card-text\">Row: ");
#nullable restore
#line 29 "C:\Users\Nikola Nushev\source\repos\CinemaTicketingAdminApp\CinemaTicketingAdminApp\Views\Order\Details.cshtml"
                                         Write(item.Ticket.Row);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"card-text\">Seat Number: ");
#nullable restore
#line 30 "C:\Users\Nikola Nushev\source\repos\CinemaTicketingAdminApp\CinemaTicketingAdminApp\Views\Order\Details.cshtml"
                                                 Write(item.Ticket.SeatNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <div class=\"card-footer\">\r\n                        <p style=\"text-align:center\">Price: ");
#nullable restore
#line 32 "C:\Users\Nikola Nushev\source\repos\CinemaTicketingAdminApp\CinemaTicketingAdminApp\Views\Order\Details.cshtml"
                                                       Write(item.Movie.MoviePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" MKD</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 36 "C:\Users\Nikola Nushev\source\repos\CinemaTicketingAdminApp\CinemaTicketingAdminApp\Views\Order\Details.cshtml"

            if (i % 3 == 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 40 "C:\Users\Nikola Nushev\source\repos\CinemaTicketingAdminApp\CinemaTicketingAdminApp\Views\Order\Details.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CinemaTicketingAdminApp.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591