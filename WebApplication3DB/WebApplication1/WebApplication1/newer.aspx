<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="newer.aspx.cs" Inherits="WebApplication1.newer" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <script src="crystalreportviewers/js/crviewer/crv.js" type="text/javascript"></script>

       <link href="Styles/main.css" rel="stylesheet" type="text/css" />
</head>
<body>
  
    <form id="form1" runat="server">
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark static-top">
  
      <a class="navbar-brand" href="#">Vacanza</a>
      <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="collapse navbar-collapse" id="navbarResponsive">
        <ul class="navbar-nav ml-auto">
          <li class="nav-item active">
            <a class="nav-link" href="Home.aspx">Home
              <span class="sr-only">(current)</span>
            </a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="About.aspx">About</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="LogIn.aspx">
                <asp:Label ID="Label4" runat="server" Text="Log in"></asp:Label></a>
          </li>
             <li class="nav-item">
            <a class="nav-link" href="SignUP.aspx">
                <asp:Label ID="Label5" runat="server" Text="Sign Up"></asp:Label></a>
                 </li>
          <li class="nav-item">
            <a class="nav-link" href="Contact.aspx">Contact</a>
          </li>
            <li class="nav-item">
            <a class="nav-link" href="#">
                <asp:Button ID="Button2" runat="server" Text="Menu" BackColor="#343A40" BorderStyle="None" ForeColor="White" OnClick="Button2_Click1" /></a>
                 </li>
<li class="nav-item">
            <a class="nav-link" href="#">
                <asp:Button ID="Button3" runat="server" Visible="false" BackColor="#343A40" Text="" BorderStyle="None" ForeColor="White" OnClick="Button3_Click"  /></a>
          </li>
         
        </ul>
      </div>
  
  </nav>
          <!-- Page Content -->
  <div class="container">
    <div class="row">
        

  </div>
   </div>   
    </form>



     <div class="container">
            <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="True" GroupTreeImagesFolderUrl="newer.aspx" Height="1202px" ReportSourceID="CrystalReportSource1" ToolbarImagesFolderUrl="newer.aspx" ToolPanelWidth="200px" Width="104px" />
            <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
                <Report FileName="CrystalReport1.rpt">
                </Report>
            </CR:CrystalReportSource>
        </div>
</body>
</html>