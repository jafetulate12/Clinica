<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="frmBuscarPaciente.aspx.cs" Inherits="SitioWeb.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoHead" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="lblId" runat="server" Text="ID" BorderStyle="Groove"></asp:Label>
            <asp:TextBox ID="txtId" runat="server" CssClass="auto-style1"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="El ID es Requerido" ControlToValidate="txtId" ValidationGroup="VAL">*</asp:RequiredFieldValidator>
            <br />
            <br />
    <asp:Label ID="lblCedula" runat="server" Text="  Cedula:"></asp:Label>
            <asp:TextBox ID="txtCedula" runat="server" CssClass="auto-style2"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="La Cedula es Requerida" ControlToValidate="txtCedula" ValidationGroup="VAL">*</asp:RequiredFieldValidator>
            <br />
            Nombre:
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Debe Ingresar un Nombre" ControlToValidate="txtNombre" ValidationGroup="VAL">*</asp:RequiredFieldValidator>
            <br />
            Telefono:
            <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="El Telefono es requerido" ControlToValidate="txtTelefono" ValidationGroup="VAL">*</asp:RequiredFieldValidator>
            <br />
    <asp:RegularExpressionValidator ID="regexValidador" runat="server"
    ControlToValidate="txtTelefono"
    ValidationExpression="^\d{8,10}$"
    ErrorMessage="Número inválido. Debe tener entre 8 y 10 dígitos numéricos."
    Display="Dynamic" ValidationGroup="VAL" >*</asp:RegularExpressionValidator>

    
            Correo:
            <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="El correo es requerido" ControlToValidate="txtCorreo" ValidationGroup="VAL">*</asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
    ControlToValidate="txtCorreo"
    ValidationExpression="^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$"
    ErrorMessage="Correo inválido."
    Display="Dynamic" ValidationGroup="VAL" >*</asp:RegularExpressionValidator>
            <br />
           Direccion:
            <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="La Direcion es requerida" ControlToValidate="txtDireccion" ValidationGroup="VAL">*</asp:RequiredFieldValidator>
            <br />
       
        <div>   
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="auto-style4" OnClick="btnGuardar_Click" Width="135px" class="btn btn-primary m-2" ValidationGroup="VAL"  />

            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="auto-style3" OnClick="btnCancelar_Click" Width="132px" />
        </div>

        <div>   
               <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="VAL"   class="text-danger" />
        </div>
     

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoFooter" runat="server">
        <p> Clinica el Buen Vivir</p>
        <p> Estamos para Servirle</p>
</asp:Content>
