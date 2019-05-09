#pragma checksum "C:\Users\bitstudent\Desktop\Final Project\Northwind-master\Views\Report\CategoryBreakdown.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a348de66289508edd2748f321cf4b5d068bdbaed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Northwind.Views.Home.Report.Views_Report_CategoryBreakdown), @"mvc.1.0.view", @"/Views/Report/CategoryBreakdown.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Report/CategoryBreakdown.cshtml", typeof(Northwind.Views.Home.Report.Views_Report_CategoryBreakdown))]
namespace Northwind.Views.Home.Report
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\bitstudent\Desktop\Final Project\Northwind-master\Views\Report\CategoryBreakdown.cshtml"
using Northwind.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a348de66289508edd2748f321cf4b5d068bdbaed", @"/Views/Report/CategoryBreakdown.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc336443358a39bf31ac02f3d17194e98e1e1151", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_CategoryBreakdown : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 595, true);
            WriteLiteral(@"
<h1>Category Breakdown</h1>
<div class=""container"">

    <label for=""formControl"">Select Category</label>
    <select class=""form-control"" id=""formControl"">

    </select>

    <div class=""card"">
        <div class=""card-body"">
            <canvas id=""chDonut1""></canvas>
        </div>
    </div>
</div>
<script src=""https://cdn.jsdelivr.net/npm/chart.js@2.8.0/dist/Chart.min.js""></script>
<script src=""https://code.jquery.com/jquery-3.4.1.min.js""
        integrity=""sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo=""
        crossorigin=""anonymous"">
</script>
<script>
");
            EndContext();
#line 24 "C:\Users\bitstudent\Desktop\Final Project\Northwind-master\Views\Report\CategoryBreakdown.cshtml"
     foreach (Category c in Model)
    {
        

#line default
#line hidden
            BeginContext(707, 26, true);
            WriteLiteral("\r\n            console.log(");
            EndContext();
            BeginContext(734, 12, false);
#line 27 "C:\Users\bitstudent\Desktop\Final Project\Northwind-master\Views\Report\CategoryBreakdown.cshtml"
                   Write(c.CategoryId);

#line default
#line hidden
            EndContext();
            BeginContext(746, 12, true);
            WriteLiteral(");\r\n        ");
            EndContext();
#line 28 "C:\Users\bitstudent\Desktop\Final Project\Northwind-master\Views\Report\CategoryBreakdown.cshtml"
               
    }

#line default
#line hidden
            BeginContext(774, 1342, true);
            WriteLiteral(@"
    // Data -----------
    var labels = [['Item1', 'Item2', 'Item3'], ['Other1', 'other2', 'other3']]
    var dataSet = [[1, 2, 3], [4, 5, 6]]

    // chart colors
    var colors = ['#007bff', '#28a745', '#333333', '#c3e6cb', '#dc3545', '#6c757d'];

    // Chart options
    var donutOptions = {
        cutoutPercentage: 0,
        legend: { position: 'left', padding: 5, labels: { pointStyle: 'circle', usePointStyle: true } }
    };


    var myChart;
    $('#formControl').change(function () {
        var selected = $('#formControl option:selected').attr('name');
        selected = selected - 1;

        if (myChart) {
            myChart.destroy();
        }

        var newData = """";
        var chDonut1 = """";

        newData = {
            labels: labels[selected],
            datasets: [
                {
                    backgroundColor: colors,
                    borderWidth: 0,
                    data: dataSet [selected]
                }
            ]
      ");
            WriteLiteral(@"  };

        chDonut1 = $('#chDonut1');
        myChart = new Chart(chDonut1, {
                                type: 'pie',
                                data: newData,
                                options: donutOptions
                            });

        myChart.update();
    });


</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
