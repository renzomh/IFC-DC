<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CursosxCoordinador.aspx.cs" Inherits="UPC.IFCDC.UI.WebForm3" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <br />
<div class="box-central">
    <h1>CURSOS</h1>
    <p>Ciclo: <asp:Label ID="texto_PeriodoActual" runat ="server" Text="TextoCiclo"></asp:Label></p>
    <p>Fecha Límite: <asp:Label ID="texto_FechaLimite" Text="FechaLímite" runat ="server"></asp:Label></p>

<table class="TablaNested">
    <tbody>
        <tr>
        <td colspan="2" align="center" >
            <asp:GridView ID="grdCursos" OnRowCommand="grdCursos_RowCommand" runat="server" Width="100%"
             CellPadding="4" CellSpacing="1" Border="0" AutoGenerateColumns="false" onselectedindexchanged="grdCursos_SelectedIndexChanged" 
                >
             
                <RowStyle CssClass="grdFilas"/>
                <HeaderStyle CssClass="grdCabecera"/>
                <AlternatingRowStyle CssClass="grdFilasAlternas"/>
             
                <Columns>                    
                    <asp:BoundField HeaderText="Código del curso" DataField="Codigo" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="15%"/>
                    <asp:BoundField HeaderText="Nombre del curso" DataField="Nombre" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Left" ItemStyle-Width="70%"/>
                    
                    <asp:TemplateField HeaderText="Informe" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="15%">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkInforme" runat="server" CommandName="cmdIniciar" CommandArgument='<%#Eval("CursoId")%>'>
                                <img src="Imagenes/icono/icono-editar.png" width="16" height="16" alt="iniciar" border="0"/>
                            </asp:LinkButton>                        
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                </Columns>
             
            </asp:GridView>
        </td>
    </tr>
    </tbody>
    </table>
</div>
</asp:Content>
