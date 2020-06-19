<%@ Page Language="C#" AutoEventWireup="true"   MasterPageFile="~/Site.Master"  CodeFile="HotelOrder.aspx.cs" Inherits="HotelOrder" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">



    <asp:button  runat="server" ID="orderstar" OnClick="orderstar_Click"  Text="orderstar" OnPreRender="orderstar_Click"/>

    <asp:GridView ID="GridView1" runat="server" Width="278px" OnLoad="orderstar_Click">
    </asp:GridView>





    <asp:Chart ID="Chart1" runat="server" DataSourceID="Hotel_Rate">
        <series>
            <asp:Series Name="Series1" XValueMember="Hotel_id" YValueMembers="SUM_PRICE">
            </asp:Series>
        </series>
        <chartareas>
            <asp:ChartArea Name="ChartArea1">
                  <AxisX Title="Hotel_ID">
                        </AxisX>
                        <AxisY Title="Total_Booking_Price">
                        </AxisY>
            </asp:ChartArea>
        </chartareas>
</asp:Chart>
    <asp:Chart ID="Chart2" runat="server" DataSourceID="Hotel_City">
        <series>
            <asp:Series ChartType="Line" Name="Series1" XValueMember="City_name" YValueMembers="City_Counter">
            </asp:Series>
        </series>
        <chartareas>
            <asp:ChartArea Name="ChartArea1">
        <AxisX Title="City_name">
                        </AxisX>
                        <AxisY Title="City_Counter">
                        </AxisY>

            </asp:ChartArea>
        </chartareas>
    </asp:Chart>
    <asp:Chart ID="Chart3" runat="server" DataSourceID="Counter_Hotel">
        <series>
            <asp:Series ChartType="Pie" Name="Series1" XValueMember="Country_name" YValueMembers="Country_Count">
            </asp:Series>
        </series>
        <chartareas>
            <asp:ChartArea Name="ChartArea1">
<AxisX Title="Country_name">
                        </AxisX>
                        <AxisY Title="Country_Count">
                        </AxisY>

            </asp:ChartArea>
        </chartareas>
    </asp:Chart>
    <asp:SqlDataSource ID="RateVSHotel" runat="server" ConnectionString="<%$ ConnectionStrings:VACANZAWEBSITE3ConnectionString %>" SelectCommand="SELECT * FROM [Hotel]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="Counter_Hotel" runat="server" ConnectionString="<%$ ConnectionStrings:VACANZAWEBSITE3ConnectionString %>" SelectCommand="select COUNT(*) as Country_Count,CU.Country_name
 from Hotel H,city C ,Country CU
 where C.city_id=H.city_id  and C.Country_id=CU.Country_id
 GROUP BY CU.Country_name
"></asp:SqlDataSource>
    <asp:SqlDataSource ID="Hotel_City" runat="server" ConnectionString="<%$ ConnectionStrings:VACANZAWEBSITE3ConnectionString %>" SelectCommand="select COUNT(*) as City_Counter,C.City_name 
  from Hotel H,City C 
  where C.City_id=H.City_id
  GROUP BY C.City_name"></asp:SqlDataSource>
    <asp:SqlDataSource ID="Hotel_Rate" runat="server" ConnectionString="<%$ ConnectionStrings:VACANZAWEBSITE3ConnectionString %>" SelectCommand="select B1.Hotel_id,sum(B2.totalBookingPrice) AS SUM_PRICE
 from Booking B2,Booked_room B1 
 where B2.Booking_id=B1.Booking_id and B2.Hotel_id=B1.Hotel_id
 GROUP BY B1.Hotel_id"></asp:SqlDataSource>





    </asp:Content>