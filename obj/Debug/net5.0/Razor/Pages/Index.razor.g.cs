#pragma checksum "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1e7431cc47b662dd7775097027df2145b0a7269"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "h6");
            __builder.AddAttribute(1, "style", "color:red;");
            __builder.AddContent(2, 
#nullable restore
#line 4 "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\Pages\Index.razor"
                        Menssagem

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 5 "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\Pages\Index.razor"
 if (Tarefas == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<p>Carregando</p>");
#nullable restore
#line 8 "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\Pages\Index.razor"
}
else if (!Tarefas.Any())
{



#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<p>Ainda Não existem Tarefas</p>");
#nullable restore
#line 14 "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\Pages\Index.razor"
}
else
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\Pages\Index.razor"
     if (Tarefas != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "form-group");
            __builder.AddMarkupContent(7, "<label>Tarefa</label>\r\n            ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "placeholder", "informe a Tarefa");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\Pages\Index.razor"
                                                                     NovaTarefa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NovaTarefa = __value, NovaTarefa));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "btn btn-primary");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\Pages\Index.razor"
                                                      AdicionarNovaTarefa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Adicionar Tarefa");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "table");
            __builder.AddAttribute(19, "class", "table");
            __builder.AddMarkupContent(20, "<thead><tr><th>Data</th>\r\n                <th>Descrição</th>\r\n                <th>Concluida</th>\r\n                <th>Ação</th></tr></thead>\r\n        ");
            __builder.OpenElement(21, "tbody");
#nullable restore
#line 37 "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\Pages\Index.razor"
             foreach (var item in Tarefas)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "tr");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 40 "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\Pages\Index.razor"
                         item.Descricao

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 41 "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\Pages\Index.razor"
                         item.DataCriacao

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    \r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "checkbox");
            __builder.AddAttribute(32, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\Pages\Index.razor"
                                                      item.Concluida

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => item.Concluida = __value, item.Concluida));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddContent(34, 
#nullable restore
#line 43 "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\Pages\Index.razor"
                                                                         item.Concluida

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "td");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\Pages\Index.razor"
                                            ()=> RemoverTarefa(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Excluir");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "D:\_DESENVOLVIMENTO\CODIGO FONTE\BlazorWebAssembly_Tarefas\BlazorWebAssembly_Tarefas\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
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
