#pragma checksum "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaf7df8faf5dbb45eea39515799396ccf445ae50"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAdmin.Pages.CatalogItemPage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using BlazorAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using BlazorAdmin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using BlazorAdmin.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using BlazorAdmin.JavaScript;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using BlazorShared.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using BlazorShared.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using BlazorShared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
           [Authorize(Roles = BlazorShared.Authorization.Constants.Roles.ADMINISTRATORS)]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class List : BlazorAdmin.Helpers.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Manage Product Catalog</h1>\n\n");
#nullable restore
#line 8 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
 if (catalogItems == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<BlazorAdmin.Shared.Spinner>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n");
#nullable restore
#line 11 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "p");
            __builder.AddAttribute(6, "class", "esh-link-wrapper");
            __builder.AddMarkupContent(7, "\n        ");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "class", "btn btn-primary");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                                                    CreateClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(11, "\n            Create New\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n");
            __builder.AddContent(14, "    ");
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "class", "table table-striped table-hover");
            __builder.AddMarkupContent(17, "\n        ");
            __builder.OpenElement(18, "thead");
            __builder.AddMarkupContent(19, "\n            ");
            __builder.OpenElement(20, "tr");
            __builder.AddMarkupContent(21, "\n                <th></th>\n                ");
            __builder.AddMarkupContent(22, "<th>Item Type</th>\n                ");
            __builder.AddMarkupContent(23, "<th>Brand</th>\n                ");
            __builder.AddMarkupContent(24, "<th>Id</th>\n                ");
            __builder.AddMarkupContent(25, "<th>Name</th>\n                ");
            __builder.OpenElement(26, "th");
            __builder.AddContent(27, 
#nullable restore
#line 29 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                     nameof(CatalogItem.Description)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n                ");
            __builder.OpenElement(29, "th");
            __builder.AddContent(30, 
#nullable restore
#line 30 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                     nameof(CatalogItem.Price)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n                ");
            __builder.AddMarkupContent(32, "<th>Actions</th>\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n        ");
            __builder.OpenElement(35, "tbody");
            __builder.AddAttribute(36, "class", "cursor-pointer");
            __builder.AddMarkupContent(37, "\n");
#nullable restore
#line 35 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
             foreach (var item in catalogItems)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "                ");
            __builder.OpenElement(39, "tr");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                                () => DetailsClick(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(41, "\n                    ");
            __builder.OpenElement(42, "td");
            __builder.AddMarkupContent(43, "\n                        ");
            __builder.OpenElement(44, "img");
            __builder.AddAttribute(45, "class", "img-thumbnail");
            __builder.AddAttribute(46, "src", 
#nullable restore
#line 39 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                                                          $"{item.PictureUri}"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n                    ");
            __builder.OpenElement(49, "td");
            __builder.AddContent(50, 
#nullable restore
#line 41 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                         item.CatalogType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n                    ");
            __builder.OpenElement(52, "td");
            __builder.AddContent(53, 
#nullable restore
#line 42 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                         item.CatalogBrand

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n                    ");
            __builder.OpenElement(55, "td");
            __builder.AddContent(56, 
#nullable restore
#line 43 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                         item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n                    ");
            __builder.OpenElement(58, "td");
            __builder.AddContent(59, 
#nullable restore
#line 44 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                         item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n                    ");
            __builder.OpenElement(61, "td");
            __builder.AddContent(62, 
#nullable restore
#line 45 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                         item.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\n                    ");
            __builder.OpenElement(64, "td");
            __builder.AddContent(65, 
#nullable restore
#line 46 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                         item.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\n                    ");
            __builder.OpenElement(67, "td");
            __builder.AddMarkupContent(68, "\n                        ");
            __builder.OpenElement(69, "button");
            __builder.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                                            () => EditClick(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventStopPropagationAttribute(71, "onclick", 
#nullable restore
#line 48 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                                                                                                 true

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(72, "class", "btn btn-primary");
            __builder.AddMarkupContent(73, "\n                            Edit\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\n\n                        ");
            __builder.OpenElement(75, "button");
            __builder.AddAttribute(76, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                                            () => DeleteClick(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventStopPropagationAttribute(77, "onclick", 
#nullable restore
#line 52 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                                                                                                   true

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(78, "class", "btn btn-danger");
            __builder.AddMarkupContent(79, "\n                            Delete\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\n");
#nullable restore
#line 57 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(83, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\n");
            __builder.AddContent(86, "    ");
            __builder.OpenComponent<BlazorAdmin.Pages.CatalogItemPage.Details>(87);
            __builder.AddAttribute(88, "Brands", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<BlazorShared.Models.CatalogBrand>>(
#nullable restore
#line 61 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                      catalogBrands

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(89, "Types", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<BlazorShared.Models.CatalogType>>(
#nullable restore
#line 61 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                                             catalogTypes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "OnEditClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 61 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                                                                        EditClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(91, (__value) => {
#nullable restore
#line 61 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                                                                                         DetailsComponent = (BlazorAdmin.Pages.CatalogItemPage.Details)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(92, "\n    ");
            __builder.OpenComponent<BlazorAdmin.Pages.CatalogItemPage.Edit>(93);
            __builder.AddAttribute(94, "Brands", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<BlazorShared.Models.CatalogBrand>>(
#nullable restore
#line 62 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                   catalogBrands

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(95, "Types", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<BlazorShared.Models.CatalogType>>(
#nullable restore
#line 62 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                                          catalogTypes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(96, "OnSaveClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 62 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                                                                     ReloadCatalogItems

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(97, (__value) => {
#nullable restore
#line 62 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                                                                                               EditComponent = (BlazorAdmin.Pages.CatalogItemPage.Edit)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(98, "\n    ");
            __builder.OpenComponent<BlazorAdmin.Pages.CatalogItemPage.Create>(99);
            __builder.AddAttribute(100, "Brands", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<BlazorShared.Models.CatalogBrand>>(
#nullable restore
#line 63 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                     catalogBrands

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(101, "Types", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<BlazorShared.Models.CatalogType>>(
#nullable restore
#line 63 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                                            catalogTypes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "OnSaveClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 63 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                                                                       ReloadCatalogItems

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(103, (__value) => {
#nullable restore
#line 63 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                                                                                                 CreateComponent = (BlazorAdmin.Pages.CatalogItemPage.Create)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(104, "\n    ");
            __builder.OpenComponent<BlazorAdmin.Pages.CatalogItemPage.Delete>(105);
            __builder.AddAttribute(106, "Brands", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<BlazorShared.Models.CatalogBrand>>(
#nullable restore
#line 64 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                     catalogBrands

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(107, "Types", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<BlazorShared.Models.CatalogType>>(
#nullable restore
#line 64 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                                            catalogTypes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(108, "OnSaveClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 64 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                                                                       ReloadCatalogItems

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(109, (__value) => {
#nullable restore
#line 64 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
                                                                                                 DeleteComponent = (BlazorAdmin.Pages.CatalogItemPage.Delete)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(110, "\n");
#nullable restore
#line 65 "C:\Users\mitan\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\List.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591