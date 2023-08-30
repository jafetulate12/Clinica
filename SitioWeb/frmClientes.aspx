<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="frmClientes.aspx.cs" Inherits="SitioWeb.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoHead" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="Titulo">Pacientes</h1>

    <div>
        <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
        <asp:Button ID="btnAgregar" runat="server" Text="Nuevo Cliente" OnClick="btnAgregar_Click" />
    </div>
    <asp:GridView ID="grdPacientes" runat="server" AutoGenerateColumns="False" EmptyDataText="No hay Registros" CellPadding="4" Width="1119px" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkSeleccionar" runat="server" CommandArgument='<%# Eval("ID_PACIENTE").ToString() %>' CommandName="Seleccionar" OnCommand="LinkSeleccionar_Command" >Seleccionar</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkModificar" runat="server" CommandArgument='<%# Eval("ID_PACIENTE").ToString() %>' CommandName="Modificar" OnCommand="LinkModificar_Command">Modificar</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="LnkEliminar" runat="server" CommandArgument='<%# Eval("ID_PACIENTE").ToString() %>' CommandName="Eliminar" OnCommand="LnkEliminar_Command">Eliminar</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="ID_PACIENTE" HeaderText=" ID">
                <HeaderStyle HorizontalAlign="Justify" />
            </asp:BoundField>
            <asp:BoundField DataField="CEDULA_PACIENTE" HeaderText="CEDULA">
                <HeaderStyle HorizontalAlign="Justify" />
            </asp:BoundField>
            <asp:BoundField DataField="NOMBRE_COMPLETO_PACIENTE" HeaderText="NOMBRE">
                <FooterStyle HorizontalAlign="Justify" />
                <HeaderStyle HorizontalAlign="Justify" />
            </asp:BoundField>
            <asp:BoundField DataField="TELEFONO_PACIENTE" HeaderText="TELEFONO">
                <HeaderStyle HorizontalAlign="Justify" />
            </asp:BoundField>
            <asp:BoundField DataField="CORREO_PACIENTE" HeaderText="CORREO">
                <HeaderStyle HorizontalAlign="Justify" />
            </asp:BoundField>
            <asp:BoundField DataField="DIRECCION_PACIENTE" HeaderText="DIRECCION">
                <HeaderStyle HorizontalAlign="Justify" />
            </asp:BoundField>
        </Columns>
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
        <RowStyle BackColor="White" ForeColor="#003399" />
        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <SortedAscendingCellStyle BackColor="#EDF6F6" />
        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
        <SortedDescendingCellStyle BackColor="#D6DFDF" />
        <SortedDescendingHeaderStyle BackColor="#002876" />
    </asp:GridView>

    <asp:Button ID="btnRegresar" runat="server" Text="Regresar" OnClick="btnRegresar_Click" />



</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoFooter" runat="server">
        <p> Clinica el Buen Vivir</p>
        <p> Estamos para Servirle</p>
</asp:Content>
