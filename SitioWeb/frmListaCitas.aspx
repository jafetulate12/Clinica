<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="frmListaCitas.aspx.cs" Inherits="SitioWeb.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Titulo">
        Lista de Citas Agendadas
    </div>
    <asp:Label ID="Label1" runat="server" Text="Ingrese el Nombre del paciente que desea consultar:"></asp:Label>
            <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
    <div>
            <asp:GridView ID="grdListCitas" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" EmptyDataText="No hay Registros" Width="1119px">
        <Columns>
<asp:BoundField DataField="ID_CITA_WEB" HeaderText="Id Cita" />
<asp:BoundField DataField="ID_ESPECIALISTA" HeaderText="Id Especialista" />
<asp:BoundField DataField="NOMBRE_COMPLETO" HeaderText="Nombre Especialista" />
<asp:BoundField DataField="ID_PACIENTE" HeaderText="Id Paciente" />
<asp:BoundField DataField="NOMBRE_COMPLETO_PACIENTE" HeaderText="Nombre Paciente" />
<asp:BoundField DataField="HORA_INICIO" HeaderText="Hora de la Cita" />
<asp:BoundField DataField="FECHA" HeaderText="Fecha de la Cita"  DataFormatString="{0:dd/MM/yyyy}" />
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
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoFooter" runat="server">
        <p> Clinica el Buen Vivir</p>
        <p> Estamos para Servirle</p>
</asp:Content>
