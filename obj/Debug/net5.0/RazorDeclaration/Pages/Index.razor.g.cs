// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorWebAssembly_Tarefas.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\_Imports.razor"
using BlazorWebAssembly_Tarefas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\_Imports.razor"
using BlazorWebAssembly_Tarefas.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\Pages\Index.razor"
      
    protected override async Task OnInitializedAsync()
    {
        Tarefas = await htttp.GetFromJsonAsync<List<Tarefa>>("Data/Tarefas.json");
    }
    private string Menssagem = "";
    public class Tarefa
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public bool Concluida { get; set; }
        public DateTime DataCriacao { get; set; }
    }

    private string NovaTarefa = "";

    public void AdicionarNovaTarefa()
    {
        Tarefa tarefas = new Tarefa();
        tarefas.Descricao = NovaTarefa;
        tarefas.DataCriacao = DateTime.Now;
        tarefas.Id = Guid.NewGuid();

        if (!string.IsNullOrWhiteSpace(NovaTarefa))
        {
            Tarefas.Add(tarefas);
        }
        else
        {
            Menssagem = "Tarefa Vazia";
        }

        NovaTarefa = "";

    }

    public void RemoverTarefa(Guid id)
    {
        Tarefa tarefa = Tarefas.FirstOrDefault(a => a.Id == id);

        Tarefas.Remove(tarefa);
    }
    private List<Tarefa> Tarefas = new List<Tarefa>();

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient htttp { get; set; }
    }
}
#pragma warning restore 1591
