#pragma checksum "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\Pages\EmployeeDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cb5f4a47d151cdaf9b289cf250275e01a2e8284"
// <auto-generated/>
#pragma warning disable 1591
namespace SmitsPieShopHRM.server.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\_Imports.razor"
using SmitsPieShopHRM.server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\_Imports.razor"
using SmitsPieShopHRM.server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\_Imports.razor"
using SmitsPieShopHRM.ComponentsLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\_Imports.razor"
using SmitsPieShopHRM.ComponentsLibrary.Map;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetail/{EmployeeId}")]
    public partial class EmployeeDetail : EmployeeDetailBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "employee-detail");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "h1");
            __builder.AddAttribute(4, "class", "page-title");
            __builder.AddContent(5, "Details for ");
            __builder.AddContent(6, 
#nullable restore
#line 5 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\Pages\EmployeeDetail.razor"
                                        Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(7, " ");
            __builder.AddContent(8, 
#nullable restore
#line 5 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\Pages\EmployeeDetail.razor"
                                                            Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-12 row");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-2");
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 8 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\Pages\EmployeeDetail.razor"
             if (!string.IsNullOrEmpty(Employee.FileName))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                ");
            __builder.OpenElement(17, "img");
            __builder.AddAttribute(18, "src", "EmployeePhotos/" + (
#nullable restore
#line 10 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\Pages\EmployeeDetail.razor"
                                          Employee.FileName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "class", "img-responsive rounded-circle employee-detail-img");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 11 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\Pages\EmployeeDetail.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(21, "                <img src=\"images/illustration-plus-sign-on-camera.png\" class=\"rounded-circle employee-overview-img\">\r\n");
#nullable restore
#line 15 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\Pages\EmployeeDetail.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col-10 row");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-xs-12 col-sm-8");
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "form-group row");
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.AddMarkupContent(33, "<label class=\"col-sm-4 col-form-label\">Employee ID</label>\r\n                    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-sm-8");
            __builder.AddMarkupContent(36, "\r\n                        ");
            __builder.OpenElement(37, "label");
            __builder.AddAttribute(38, "type", "text");
            __builder.AddAttribute(39, "class", "form-control-plaintext");
            __builder.AddContent(40, 
#nullable restore
#line 22 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\Pages\EmployeeDetail.razor"
                                                                           Employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "form-group row");
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.AddMarkupContent(47, "<label class=\"col-sm-4 col-form-label\">First name</label>\r\n                    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col-sm-8");
            __builder.AddMarkupContent(50, "\r\n                        ");
            __builder.OpenElement(51, "label");
            __builder.AddAttribute(52, "type", "text");
            __builder.AddAttribute(53, "readonly", true);
            __builder.AddAttribute(54, "class", "form-control-plaintext");
            __builder.AddContent(55, 
#nullable restore
#line 28 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\Pages\EmployeeDetail.razor"
                                                                                    Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n\r\n                ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "form-group row");
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.AddMarkupContent(62, "<label class=\"col-sm-4 col-form-label\">Last name</label>\r\n                    ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "col-sm-8");
            __builder.AddMarkupContent(65, "\r\n                        ");
            __builder.OpenElement(66, "label");
            __builder.AddAttribute(67, "type", "text");
            __builder.AddAttribute(68, "readonly", true);
            __builder.AddAttribute(69, "class", "form-control-plaintext");
            __builder.AddContent(70, 
#nullable restore
#line 35 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\Pages\EmployeeDetail.razor"
                                                                                    Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n\r\n                ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "form-group row");
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.AddMarkupContent(77, "<label class=\"col-sm-4 col-form-label\">Birthdate</label>\r\n                    ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "col-sm-8");
            __builder.AddMarkupContent(80, "\r\n                        ");
            __builder.OpenElement(81, "label");
            __builder.AddAttribute(82, "type", "text");
            __builder.AddAttribute(83, "readonly", true);
            __builder.AddAttribute(84, "class", "form-control-plaintext");
            __builder.AddContent(85, 
#nullable restore
#line 42 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\Pages\EmployeeDetail.razor"
                                                                                    Employee.BirthDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n\r\n                ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "form-group row");
            __builder.AddMarkupContent(91, "\r\n                    ");
            __builder.AddMarkupContent(92, "<label class=\"col-sm-4 col-form-label\">Email</label>\r\n                    ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "col-sm-8");
            __builder.AddMarkupContent(95, "\r\n                        ");
            __builder.OpenElement(96, "label");
            __builder.AddAttribute(97, "type", "text");
            __builder.AddAttribute(98, "readonly", true);
            __builder.AddAttribute(99, "class", "form-control-plaintext");
            __builder.AddContent(100, 
#nullable restore
#line 49 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\Pages\EmployeeDetail.razor"
                                                                                    Employee.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n\r\n                ");
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "class", "form-group row");
            __builder.AddMarkupContent(106, "\r\n                    ");
            __builder.AddMarkupContent(107, "<label class=\"col-sm-4 col-form-label\">Street</label>\r\n                    ");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "col-sm-8");
            __builder.AddMarkupContent(110, "\r\n                        ");
            __builder.OpenElement(111, "label");
            __builder.AddAttribute(112, "type", "text");
            __builder.AddAttribute(113, "readonly", true);
            __builder.AddAttribute(114, "class", "form-control-plaintext");
            __builder.AddContent(115, 
#nullable restore
#line 56 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\Pages\EmployeeDetail.razor"
                                                                                    Employee.Street

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n\r\n                ");
            __builder.OpenElement(119, "div");
            __builder.AddAttribute(120, "class", "form-group row");
            __builder.AddMarkupContent(121, "\r\n                    ");
            __builder.AddMarkupContent(122, "<label class=\"col-sm-4 col-form-label\">Zip</label>\r\n                    ");
            __builder.OpenElement(123, "div");
            __builder.AddAttribute(124, "class", "col-sm-8");
            __builder.AddMarkupContent(125, "\r\n                        ");
            __builder.OpenElement(126, "label");
            __builder.AddAttribute(127, "type", "text");
            __builder.AddAttribute(128, "readonly", true);
            __builder.AddAttribute(129, "class", "form-control-plaintext");
            __builder.AddContent(130, 
#nullable restore
#line 63 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\Pages\EmployeeDetail.razor"
                                                                                    Employee.Zip

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n\r\n                ");
            __builder.OpenElement(134, "div");
            __builder.AddAttribute(135, "class", "form-group row");
            __builder.AddMarkupContent(136, "\r\n                    ");
            __builder.AddMarkupContent(137, "<label class=\"col-sm-4 col-form-label\">City</label>\r\n                    ");
            __builder.OpenElement(138, "div");
            __builder.AddAttribute(139, "class", "col-sm-8");
            __builder.AddMarkupContent(140, "\r\n                        ");
            __builder.OpenElement(141, "label");
            __builder.AddAttribute(142, "type", "text");
            __builder.AddAttribute(143, "readonly", true);
            __builder.AddAttribute(144, "class", "form-control-plaintext");
            __builder.AddContent(145, 
#nullable restore
#line 70 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\Pages\EmployeeDetail.razor"
                                                                                    Employee.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n\r\n                ");
            __builder.OpenElement(149, "div");
            __builder.AddAttribute(150, "class", "form-group row");
            __builder.AddMarkupContent(151, "\r\n                    ");
            __builder.AddMarkupContent(152, "<label class=\"col-sm-4 col-form-label\">Phone number</label>\r\n                    ");
            __builder.OpenElement(153, "div");
            __builder.AddAttribute(154, "class", "col-sm-8");
            __builder.AddMarkupContent(155, "\r\n                        ");
            __builder.OpenElement(156, "label");
            __builder.AddAttribute(157, "type", "text");
            __builder.AddAttribute(158, "readonly", true);
            __builder.AddAttribute(159, "class", "form-control-plaintext");
            __builder.AddContent(160, 
#nullable restore
#line 77 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\Pages\EmployeeDetail.razor"
                                                                                    Employee.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\r\n\r\n                ");
            __builder.OpenElement(164, "div");
            __builder.AddAttribute(165, "class", "form-group row");
            __builder.AddMarkupContent(166, "\r\n                    ");
            __builder.AddMarkupContent(167, "<label class=\"col-sm-4 col-form-label\">Gender</label>\r\n                    ");
            __builder.OpenElement(168, "div");
            __builder.AddAttribute(169, "class", "col-sm-8");
            __builder.AddMarkupContent(170, "\r\n                        ");
            __builder.OpenElement(171, "label");
            __builder.AddAttribute(172, "type", "text");
            __builder.AddAttribute(173, "readonly", true);
            __builder.AddAttribute(174, "class", "form-control-plaintext");
            __builder.AddContent(175, 
#nullable restore
#line 84 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\Pages\EmployeeDetail.razor"
                                                                                    Employee.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(176, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(177, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(178, "\r\n\r\n                ");
            __builder.OpenElement(179, "div");
            __builder.AddAttribute(180, "class", "form-group row");
            __builder.AddMarkupContent(181, "\r\n                    ");
            __builder.AddMarkupContent(182, "<label class=\"col-sm-4 col-form-label\">Smoker</label>\r\n                    ");
            __builder.OpenElement(183, "div");
            __builder.AddAttribute(184, "class", "col-sm-8");
            __builder.AddMarkupContent(185, "\r\n");
#nullable restore
#line 91 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\Pages\EmployeeDetail.razor"
                         if (Employee.Smoker)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(186, "                        ");
            __builder.AddMarkupContent(187, "<label type=\"text\" readonly class=\"form-control-plaintext\">Yes</label>\r\n");
#nullable restore
#line 94 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\Pages\EmployeeDetail.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(188, "                        ");
            __builder.AddMarkupContent(189, "<label type=\"text\" readonly class=\"form-control-plaintext\">No</label>\r\n");
#nullable restore
#line 98 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\Pages\EmployeeDetail.razor"

                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(190, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(191, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(192, "\r\n\r\n                ");
            __builder.OpenElement(193, "div");
            __builder.AddAttribute(194, "class", "form-group row");
            __builder.AddMarkupContent(195, "\r\n                    ");
            __builder.AddMarkupContent(196, "<label class=\"col-sm-4 col-form-label\">Joined us</label>\r\n                    ");
            __builder.OpenElement(197, "div");
            __builder.AddAttribute(198, "class", "col-sm-8");
            __builder.AddMarkupContent(199, "\r\n                        ");
            __builder.OpenElement(200, "label");
            __builder.AddAttribute(201, "type", "text");
            __builder.AddAttribute(202, "readonly", true);
            __builder.AddAttribute(203, "class", "form-control-plaintext");
            __builder.AddContent(204, 
#nullable restore
#line 106 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\Pages\EmployeeDetail.razor"
                                                                                    Employee.JoinedDate?.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(205, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(206, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(207, "\r\n\r\n                ");
            __builder.OpenElement(208, "div");
            __builder.AddAttribute(209, "class", "form-group row");
            __builder.AddMarkupContent(210, "\r\n                    ");
            __builder.AddMarkupContent(211, "<label class=\"col-sm-4 col-form-label\">Left us</label>\r\n                    ");
            __builder.OpenElement(212, "div");
            __builder.AddAttribute(213, "class", "col-sm-8");
            __builder.AddMarkupContent(214, "\r\n                        ");
            __builder.OpenElement(215, "label");
            __builder.AddAttribute(216, "type", "text");
            __builder.AddAttribute(217, "readonly", true);
            __builder.AddAttribute(218, "class", "form-control-plaintext");
            __builder.AddContent(219, 
#nullable restore
#line 113 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\Pages\EmployeeDetail.razor"
                                                                                    Employee.ExitDate?.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(220, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(221, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(222, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(223, "\r\n            ");
            __builder.OpenElement(224, "div");
            __builder.AddAttribute(225, "class", "col-xs-12 col-sm-4");
            __builder.AddMarkupContent(226, "\r\n                ");
            __builder.OpenElement(227, "div");
            __builder.AddAttribute(228, "class", "track-order-map");
            __builder.AddMarkupContent(229, "\r\n                    ");
            __builder.OpenComponent<SmitsPieShopHRM.ComponentsLibrary.Map.Map>(230);
            __builder.AddAttribute(231, "Zoom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 119 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\Pages\EmployeeDetail.razor"
                               10

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(232, "Markers", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<SmitsPieShopHRM.ComponentsLibrary.Map.Marker>>(
#nullable restore
#line 119 "C:\Users\smit.patel\source\repos\SmitsPieShopHRM.server\SmitsPieShopHRM.server\Pages\EmployeeDetail.razor"
                                            MapMarkers

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(233, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(234, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(235, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(236, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(237, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
