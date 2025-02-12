#pragma checksum "C:\Users\Osman\source\repos\Abc\Asp.Northwind.MvcWebUI\Views\Product\KendoGridCrud.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0da65d718f091cea3193f1b04042940dc708e3b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_KendoGridCrud), @"mvc.1.0.view", @"/Views/Product/KendoGridCrud.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0da65d718f091cea3193f1b04042940dc708e3b9", @"/Views/Product/KendoGridCrud.cshtml")]
    public class Views_Product_KendoGridCrud : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Osman\source\repos\Abc\Asp.Northwind.MvcWebUI\Views\Product\KendoGridCrud.cshtml"
  
    ViewData["Title"] = "KendoGridCrud";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>KendoGridCrud</h1>

<div class=""container"">
    <div class=""container"">
        <h3>Northwind Database Product List</h3>
        <!-- gridimizi olusturacagimiz div e id verdik (id=""grid"") -->
        <div id=""grid""></div>
    </div>

    <div data-bind=""text: person.name""></div>
    <div id=""view"">
        <input data-bind=""value: name"" />
        <button data-bind=""click: displayGreeting"">Display Greeting</button>
    </div>
    <script>
        var viewModel2 = kendo.observable({
            person: {
                name: ""John Doe""
            }
        });
        kendo.bind($(""div""), viewModel);

        var viewModel = kendo.observable({
            name: ""John Doe"",
            displayGreeting: function () {
                var name = this.get(""name"");
                alert(""Hello, "" + name + ""!!!"");
            }
        });
        kendo.bind($(""#view""), viewModel);
    </script>

    <script>
        $(document).ready(function () {
            // webapi min b");
            WriteLiteral(@"ase url i : ""http://localhost:60966/api/""
            var myApiBaseUrl = ""http://localhost:60966/api/"",

                // Grid imiz icin yeni bir dataSource olusturuyoruz
                dataSource = new kendo.data.DataSource({
                    transport: {
                        // read ile product listemizi cekiyoruz
                        read: {
                            url: myApiBaseUrl + ""product"", // ""http://localhost:60966/api/product"" adresinden product listesini istedik
                            type: ""get"",
                            contentType: ""application/json"",
                            dataType: ""json"" // json formatinda istiyoruz
                        },
                        //create: {
                        //    url: myApiBaseUrl + ""product"",
                        //    type: ""post"",
                        //    contentType: ""application/json"",
                        //    dataType: ""json""
                        //},
                        cre");
            WriteLiteral(@"ate: function (options) {
                            $.ajax({
                                url: myApiBaseUrl + ""product"",
                                dataType: ""json"",
                                contentType: ""application/json"",
                                type: ""post"", // ""jsonp"" is required for cross-domain requests; use ""json"" for same-domain requests
                                // send the created data items as the ""models"" service parameter encoded in JSON                            ,
                                data: kendo.stringify(options),
                                success: function (result) {
                                    // notify the data source that the request succeeded
                                    options.success(result);
                                },
                                error: function (result) {
                                    // notify the data source that the request failed
                                    opti");
            WriteLiteral(@"ons.error(result);
                                }
                            });
                        },
                        destroy: {
                            url: myApiBaseUrl + ""product"",
                            type: ""delete"",
                            contentType: ""application/json"",
                            dataType: ""json""
                        },
                        //parameterMap: function (options, operation) {
                        //    if (operation !== ""read"" && options) {
                        //        return kendo.stringify(options);
                        //    }
                        //}
                    },
                    batch: true,
                    pageSize: 20, // grid icinde listelenecek eleman sayisi
                    schema: {
                        model: {
                            id: ""productId"",
                            fields: {
                                productId: { type: ""number"", editable: fa");
            WriteLiteral(@"lse, nullable: true },
                                productName: { type: ""string"", validation: { required: true } },
                                categoryId: { type: ""number"", validation: { required: true } },
                                unitPrice: { type: ""number"", validation: { required: true, min: 1 } },
                                unitsInStock: { type: ""number"", validation: { required: true, min: 0 } },
                            }
                        }
                    }
                });

            // id=""grid"" olan div imizin icine bir kendo grid olusturuyoruz
            $(""#grid"").kendoGrid({
                dataSource: dataSource, // grid imizin datasource u
                pageable: true, // sayfalanabilir olsun mu (evet)
                height: 550, // grid imizin yuksekligi
                toolbar: [""create""], // Add New button u
                columns: [
                    { field: ""productName"", title: ""Product Name"", width: ""180px"" },
             ");
            WriteLiteral(@"       { field: ""categoryId"", title: ""Category Id"", width: ""120px"" },
                    { field: ""unitPrice"", title: ""Unit Price"", format: ""{0:c}"", width: ""120px"" },
                    { field: ""unitsInStock"", title: ""Units In Stock"", width: ""120px"" },
                    { command: [""edit"", ""destroy""], title: ""Settings"", width: ""120px"" }
                ],
                editable: ""popup"" // ekleme veya guncelleme yapacagimiz zaman karsimiza popup acilir
            });
        });

    </script>

</div>

");
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
