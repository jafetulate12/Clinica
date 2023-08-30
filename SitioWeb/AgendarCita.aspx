<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="AgendarCita.aspx.cs" Inherits="SitioWeb.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoHead" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h1 class="Titulo">Agregar Paciente</h1>
    <br />

    <asp:Button ID="btnBuscarPa" runat="server" Text="Buscar" CssClass="auto-style4 btn btn-primary m-2" Width="135px" OnClick="btnBuscarPa_Click1" Height="46px" />

<asp:Panel ID="pnlPacientes" runat="server">
  <div class="container">
    <div class="row">
      <div class="col-md-6">
        <div class="form-group">
          <label for="txtId">ID:</label>
          <asp:TextBox ID="txtId" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="El ID es requerido" ControlToValidate="txtId" ValidationGroup="VAL" CssClass="text-danger">*</asp:RequiredFieldValidator>
        </div>
      </div>
      <div class="col-md-6">
        <div class="form-group">
          <label for="txtCedula">Cedula:</label>
          <asp:TextBox ID="txtCedula" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="La Cedula es requerida" ControlToValidate="txtCedula" ValidationGroup="VAL" CssClass="text-danger">*</asp:RequiredFieldValidator>
        </div>
      </div>
    </div>
    <div class="row">
      <div class="col-md-6">
        <div class="form-group">
          <label for="txtNombre">Nombre:</label>
          <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Debe ingresar un Nombre" ControlToValidate="txtNombre" ValidationGroup="VAL" CssClass="text-danger">*</asp:RequiredFieldValidator>
        </div>
      </div>
      <div class="col-md-6">
        <div class="form-group">
          <label for="txtTelefono">Telefono:</label>
          <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="El Telefono es requerido" ControlToValidate="txtTelefono" ValidationGroup="VAL" CssClass="text-danger">*</asp:RequiredFieldValidator>
        </div>
      </div>
    </div>
    <div class="row">
      <div class="col-md-6">
        <div class="form-group">
          <label for="txtCorreo">Correo:</label>
          <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="El correo es requerido" ControlToValidate="txtCorreo" ValidationGroup="VAL" CssClass="text-danger">*</asp:RequiredFieldValidator>
        </div>
      </div>
      <div class="col-md-6">
        <div class="form-group">
          <label for="txtDireccion">Direccion:</label>
          <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="La Direccion es requerida" ControlToValidate="txtDireccion" ValidationGroup="VAL" CssClass="text-danger">*</asp:RequiredFieldValidator>
        </div>
      </div>
    </div>
    <div class="row">
      <div class="col-md-6">
        <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" CssClass="btn btn-primary m-2" Width="132px" OnClick="btnLimpiar_Click" Height="46px" />
      </div>
      <div class="col-md-6">
        <asp:Button ID="btnCerrarPanel0" runat="server" OnClick="btnCerrarPanel_Click" Text="Cerrar" Width="195px" CssClass="btn btn-primary" />
      </div>
    </div>
    <div class="row">
      <div class="col-md-12">
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="VAL" class="text-danger" />
      </div>
    </div>
  </div>
</asp:Panel>

    <!--------------------------------------------------------------------------------->
    <h2 class="Titulo">Selecionar Cita</h2>
    <asp:Label ID="Label1" runat="server" Text="Seleccione la especialidad"></asp:Label>

    <asp:DropDownList ID="ddlEspecialidades" runat="server" class="btn btn-danger dropdown-toggle">
        <asp:ListItem Text="ODONOTOLOGIA" Value="ODONOTOLOGIA" Selected="True"></asp:ListItem>
        <asp:ListItem Text="OFTALMOFLOGIA" Value="OFTALMOFLOGIA"></asp:ListItem>
        <asp:ListItem Text="GEDIATRIA" Value="GEDIATRIA"></asp:ListItem>
        <asp:ListItem Text="GINECOLOGIA" Value="GINECOLOGIA"></asp:ListItem>
        <asp:ListItem Text="PODOLOGIA" Value="PODOLOGIA"></asp:ListItem>
        <asp:ListItem Text="UROLOGIA" Value="UROLOGIA"></asp:ListItem>
    </asp:DropDownList>
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click"  CssClass="btn btn-primary" />
    <br />
    <br />

    <asp:GridView ID="grdHorariosWeb" runat="server" AutoGenerateColumns="False" EmptyDataText="No hay datos" Width="1119px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnSelectedIndexChanged="grdHorariosWeb_SelectedIndexChanged" AutoGenerateSelectButton="True" DataKeyNames="ID_ESPECIALISTA">
        <Columns>
            <asp:BoundField DataField="ID_ESPECIALISTA" HeaderText="ID">
                <HeaderStyle HorizontalAlign="Justify" Width="8%" />
            </asp:BoundField>
            <asp:BoundField DataField="NOMBRE_COMPLETO" HeaderText="Nombre ">
                <HeaderStyle HorizontalAlign="Justify" />
            </asp:BoundField>
            <asp:BoundField DataField="ESPECIALIDAD" HeaderText="Especialidad">
                <HeaderStyle HorizontalAlign="Justify" />
            </asp:BoundField>
            <asp:BoundField DataField="HORA_INICIO" HeaderText="Hora de Inicio">
                <HeaderStyle HorizontalAlign="Justify" />
            </asp:BoundField>
            <asp:BoundField DataField="HORA_FINAL" HeaderText="Hora Final">
                <HeaderStyle HorizontalAlign="Justify" />
            </asp:BoundField>
            <asp:BoundField DataField="FECHA" HeaderText="Fecha de Horario" DataFormatString="{0:dd/MM/yyyy}">
                <HeaderStyle HorizontalAlign="Justify" />
            </asp:BoundField>
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#007DBB" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#00547E" />
    </asp:GridView>



    <!-- -------------------------------------------------------------------------------->


<asp:Panel ID="plnEspec" runat="server">
  <div class="container">
    <div class="row">
      <div class="col-md-6">
        <div class="form-group">
          <label for="txtId_Especialidad" class="form-label">ID_Especialidad</label>
          <asp:TextBox ID="txtId_Especialidad" runat="server" class="form-control" Width="100%" ReadOnly="True"></asp:TextBox>
        </div>
        <div class="form-group">
          <label for="txtNombreEspe" class="form-label">Nombre</label>
          <asp:TextBox ID="txtNombreEspe" runat="server" class="form-control" Width="100%" ReadOnly="True"></asp:TextBox>
        </div>
      </div>
      <div class="col-md-6">
        <div class="form-group">
          <label for="txtEspecialidad" class="form-label">Especialidad</label>
          <asp:TextBox ID="txtEspecialidad" runat="server" class="form-control" Width="100%" ReadOnly="True"></asp:TextBox>
        </div>
        <div class="form-group">
          <label for="txtHorarioInicio" class="form-label">Hora Inicio</label>
          <asp:TextBox ID="txtHorarioInicio" runat="server" class="form-control" Width="100%" ReadOnly="True"></asp:TextBox>
        </div>
      </div>
    </div>

    <div class="row">
      <div class="col-md-6">
        <div class="form-group">
          <label for="txtHoraFinal" class="form-label">Hora Final</label>
          <asp:TextBox ID="txtHoraFinal" runat="server" class="form-control" Width="100%" ReadOnly="True"></asp:TextBox>
        </div>
      </div>
      <div class="col-md-6">
        <div class="form-group">
          <label for="txtFecha" class="form-label">Fecha Del Horario</label>
          <asp:TextBox ID="txtFecha" runat="server" class="form-control" Width="100%" ReadOnly="True"></asp:TextBox>
        </div>
      </div>
    </div>

    <div class="row">
      <div class="col-md-6">
        <div class="text-center">
          <div class="form-group">
            <asp:Label ID="Label8" runat="server" Text="Hora de la cita Deseada" BorderStyle="Groove" class="Titulo" ></asp:Label>
          </div>
          <div class="form-group">
            <asp:TextBox ID="txtHoraCita" runat="server" class="form-control" Width="100%" type="time" step="1800"></asp:TextBox>
          </div>
        </div>
      </div>
    </div>

    <div class="row justify-content-center">
      <div class="col-md-6">
        <div class="text-center">
          <div class="form-group">
          <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-box-arrow-up" viewBox="0 0 16 16">
  <path fill-rule="evenodd" d="M3.5 6a.5.5 0 0 0-.5.5v8a.5.5 0 0 0 .5.5h9a.5.5 0 0 0 .5-.5v-8a.5.5 0 0 0-.5-.5h-2a.5.5 0 0 1 0-1h2A1.5 1.5 0 0 1 14 6.5v8a1.5 1.5 0 0 1-1.5 1.5h-9A1.5 1.5 0 0 1 2 14.5v-8A1.5 1.5 0 0 1 3.5 5h2a.5.5 0 0 1 0 1h-2z"/>
  <path fill-rule="evenodd" d="M7.646.146a.5.5 0 0 1 .708 0l3 3a.5.5 0 0 1-.708.708L8.5 1.707V10.5a.5.5 0 0 1-1 0V1.707L5.354 3.854a.5.5 0 1 1-.708-.708l3-3z"/>
</svg>
            <asp:Button ID="btnCrearEspacio" runat="server" Text="Crear Cita" class="btn btn-primary m-2" Width="100%" OnClick="btnCrearEspacio_Click" />
            <asp:Button ID="btnCerrar" runat="server" Text="Cerrar" class="btn btn-primary m-2" Width="50%" OnClick="btnCerrar_Click" />
          </div>
        </div>
      </div>
    </div>
  </div>
</asp:Panel>



</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoFooter" runat="server">
    <p>Clinica el Buen Vivir</p>
    <p>Estamos para Servirle</p>
</asp:Content>
