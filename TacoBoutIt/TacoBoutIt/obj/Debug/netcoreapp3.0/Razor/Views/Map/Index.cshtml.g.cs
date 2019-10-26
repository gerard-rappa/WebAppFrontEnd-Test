#pragma checksum "C:\Users\WWStudent\Source\Repos\gerard-rappa\MSSA-Project\TacoBoutIt\TacoBoutIt\Views\Map\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b560ced38580f49aee811873e7eb591a06485f8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Map_Index), @"mvc.1.0.view", @"/Views/Map/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b560ced38580f49aee811873e7eb591a06485f8d", @"/Views/Map/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b680dde1517f0cf5fa9c8a850d7b2f8f65e1fa88", @"/Views/_ViewImports.cshtml")]
    public class Views_Map_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Meme>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/markerclusterer.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""px-3 pb-3"" id=""map""></div>
<script>
    var map;
    function initMap() {        
        map = new google.maps.Map(document.getElementById('map'), {
            zoom: 10,
            streetViewControl: false,
            fullscreenControl: false,
            maxZoom: 10,
            minZoom: 5,
            restriction: {
                latLngBounds: {
                    north: 85,
                    south: -85,
                    west: -180,
                    east: 180
                }
            }
        });
        //sets map to bermuda triangle if location is blocked, or while waiting for approval
        map.setCenter({ lat: 25, lng: -71 });      
        
        //else grabs location
        if (navigator.geolocation) {
            navigator.geolocation.getCurrentPosition(function (position) {
                var pos = {
                    lat: position.coords.latitude,
                    lng: position.coords.longitude
                };
           ");
            WriteLiteral("     map.setCenter(pos);\r\n            });\r\n        }\r\n               \r\n        var latArray = [];\r\n        var lonArray = [];\r\n        var imgPath = [];\r\n        var markers = [];\r\n              \r\n");
#nullable restore
#line 41 "C:\Users\WWStudent\Source\Repos\gerard-rappa\MSSA-Project\TacoBoutIt\TacoBoutIt\Views\Map\Index.cshtml"
         foreach(var taco in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("latArray.push(");
#nullable restore
#line 43 "C:\Users\WWStudent\Source\Repos\gerard-rappa\MSSA-Project\TacoBoutIt\TacoBoutIt\Views\Map\Index.cshtml"
                       Write(taco.Latitude);

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n            ");
            WriteLiteral("lonArray.push(");
#nullable restore
#line 44 "C:\Users\WWStudent\Source\Repos\gerard-rappa\MSSA-Project\TacoBoutIt\TacoBoutIt\Views\Map\Index.cshtml"
                       Write(taco.Longitude);

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n            ");
            WriteLiteral("imgPath.push(\"");
#nullable restore
#line 45 "C:\Users\WWStudent\Source\Repos\gerard-rappa\MSSA-Project\TacoBoutIt\TacoBoutIt\Views\Map\Index.cshtml"
                       Write(taco.ImgUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n");
#nullable restore
#line 46 "C:\Users\WWStudent\Source\Repos\gerard-rappa\MSSA-Project\TacoBoutIt\TacoBoutIt\Views\Map\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
       

        for (var i = 0; i < latArray.length; i++) {
            addMarker({
                coords: { lat: latArray[i], lng: lonArray[i] },
                content: '<img style=""max-width:100px; width:100%"" src=https://litmemes.blob.core.windows.net/images/'+imgPath[i]+' /img>'
            }, markers);

            
            
        }

         // Add a marker clusterer to manage the markers.
        var markerCluster = new MarkerClusterer(map, markers,            
            {imagePath: 'https://localhost:44392/ClusterImages/m'});

    }
    


    function addMarker(props, markers) {
        var marker = new google.maps.Marker({
            position: props.coords,            
            map: map
        });
        var window = new google.maps.InfoWindow({
            content: props.content
        });
        marker.addListener('click', function () {
            window.open(map, marker);
        });
        markers.push(marker);
    }


    //Adds markers");
            WriteLiteral(@" to map on click
    //google.maps.event.addListener(map, 'click', function(event) {
    //         placeMarker(event.latLng);
    //    });
    //function placeMarker(location) {
    //    var marker = new google.maps.Marker({
    //        position: location,
    //        map: map
    //    });
    //}
</script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b560ced38580f49aee811873e7eb591a06485f8d7670", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script async defer\r\n        src=\"https://maps.googleapis.com/maps/api/js?key=AIzaSyDBBSbNYenx3aUVJNQDujBpzACQcnJHfSg&callback=initMap\">\r\n</script>");
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
