using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using BlazorECommerce.Client;
using BlazorECommerce.Client.Shared;
using BlazorECommerce.Shared;

namespace BlazorECommerce.Client.Shared
{
    public partial class ProductList
    {
        protected override async Task OnInitializedAsync()
        {
            await ProductService.GetProducts();
        }
    }
}