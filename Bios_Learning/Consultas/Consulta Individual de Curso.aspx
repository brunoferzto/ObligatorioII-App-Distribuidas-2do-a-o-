<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Consulta Individual de Curso.aspx.cs" Inherits="Consulta_Individual_de_Curso" MasterPageFile="" %>

<%@ Register assembly="CompositeControl" namespace="CompositeControl" tagprefix="cc1" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-decoration: underline;
            margin-left: 80px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <p class="auto-style1">
            <strong>&nbsp;Consulta Individual de Cursos :</strong></p>
    
    </div>
        <cc1:Composite ID="Composite1" runat="server" />
        <p>
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Consulta_de_Cursos.aspx">Volver</asp:LinkButton>
        </p>
    </form>
</body>
</html>

