<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Administrativo.aspx.cs" Inherits="UPC.IFCDC.UI.WebForm4" %>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
<ul class="tabs">
    <li onclick="change_view2('#informesFinCiclo');" >Informes de Fin de Ciclo</li><li onclick="change_view2('#hallazgos_ad');" >Hallazgos</li><li onclick="change_view2('#accionesMejora_ad');" >Acciones de Mejora</li>
 </ul>

 <div id="informesFinCiclo" class="box-central">
   <p>Curso: <asp:DropDownList ID="combo_Curso" runat ="server" ></asp:DropDownList></p>
   <p>Ciclo: <asp:DropDownList ID="combo_Ciclo"  runat ="server"></asp:DropDownList></p>
   <p>Estado: <asp:DropDownList ID="combo_Estado" runat="server" ></asp:DropDownList></p>
   <asp:Button CssClass="btn-buscar" ID="btnBuscar" runat="server"/>
  <table class="TablaNested">
    <tbody>
        <tr>
        <td colspan="2" align="center" >
            <asp:GridView ID="grdInformes" runat="server" Width="100%"
             CellPadding="4" CellSpacing="1" Border="0" AutoGenerateColumns="false"> 
                <RowStyle CssClass="grdFilas"/>
                <HeaderStyle CssClass="grdCabecera"/>
                <AlternatingRowStyle CssClass="grdFilasAlternas"/>
             
                <Columns>                    
                    <asp:BoundField HeaderText="Codigo" DataField="Codigo" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="10%"/>
                    <asp:BoundField HeaderText="Curso" DataField="Curso" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Left" ItemStyle-Width="25%"/> 
                    <asp:BoundField HeaderText="Profesor" DataField="Profesor" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="25%"/>
                    <asp:BoundField HeaderText="Ultima Actualizacion" DataField="Actualizacion" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Left" ItemStyle-Width="20%"/>
                    <asp:BoundField HeaderText="Estado" DataField="Estado" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="20%"/>
                    <asp:BoundField HeaderText="Exportar" DataField="Exportar" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Left" ItemStyle-Width="10%"/>  
                </Columns>
             
            </asp:GridView>
        </td>
    </tr>
    </tbody>
    </table>
 </div>
 
 <div id="hallazgos_ad" class="box-central">
 <p>Curso: <asp:DropDownList ID="hallazgo_curso" runat ="server" ></asp:DropDownList></p>
   <p>Año: <asp:DropDownList ID="hallazgo_anio"  runat ="server"></asp:DropDownList></p>
   <p>Ciclo: <asp:DropDownList ID="hallazgo_ciclo" runat="server" ></asp:DropDownList></p>
   <asp:Button CssClass="btn-buscar" ID="Button1" runat="server"/>
  <table class="TablaNested">
    <tbody>
        <tr>
        <td colspan="2" align="center" >
            <asp:GridView ID="grdHallazgos" runat="server" Width="100%"
             CellPadding="4" CellSpacing="1" Border="0" AutoGenerateColumns="false"> 
                <RowStyle CssClass="grdFilas"/>
                <HeaderStyle CssClass="grdCabecera"/>
                <AlternatingRowStyle CssClass="grdFilasAlternas"/>
             
                <Columns>                    
                    <asp:BoundField HeaderText="Codigo" DataField="Codigo" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="25%"/>
                    <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Left" ItemStyle-Width="50%"/> 
                    <asp:BoundField HeaderText="Curso" DataField="Curso" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="25%"/>
                </Columns>
             
            </asp:GridView>
        </td>
    </tr>
    </tbody>
    </table>
    <asp:Button CssClass="btn-exporta-excel"  runat="server" ID="btnExportaHallazgo"/>
 </div>
 
 <div id="accionesMejora_ad" class="box-central">
 <p>Curso: <asp:DropDownList ID="mejora_curso" runat ="server" ></asp:DropDownList></p>
   <p>Año: <asp:DropDownList ID="mejora_anio"  runat ="server"></asp:DropDownList></p>
   <p>Ciclo: <asp:DropDownList ID="mejora_ciclo" runat="server" ></asp:DropDownList></p>
   <p>Estado: <asp:DropDownList ID="mejora_estado" runat="server" ></asp:DropDownList></p>
   <asp:Button CssClass="btn-buscar" ID="Button2" runat="server"/>
  <table class="TablaNested">
    <tbody>
        <tr>
        <td colspan="2" align="center" >
            <asp:GridView ID="grdAccionesMejora" runat="server" Width="100%"
             CellPadding="4" CellSpacing="1" Border="0" AutoGenerateColumns="false"> 
                <RowStyle CssClass="grdFilas"/>
                <HeaderStyle CssClass="grdCabecera"/>
                <AlternatingRowStyle CssClass="grdFilasAlternas"/>
             
                <Columns>                    
                    <asp:BoundField HeaderText="Codigo" DataField="Codigo" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="25%"/>
                    <asp:BoundField HeaderText="Hallazgo" DataField="Hallazgo" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Left" ItemStyle-Width="50%"/> 
                    <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="25%"/>
                    <asp:BoundField HeaderText="Estado" DataField="Estado" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="25%"/>
                </Columns>
             
            </asp:GridView>
        </td>
    </tr>
    </tbody>
    </table>
    <asp:Button CssClass="btn-exporta-excel"  runat="server" ID="btnExportaAcciones"/>
 </div>
 
</asp:Content>
