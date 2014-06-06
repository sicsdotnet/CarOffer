<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CarofferWebApp.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="js/bootstrap-datepicker.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/jquery.qtip.js"></script>
    <script src="js/jquery-1.6.3.min.js"></script>
    <script src="js/jquery-1.7.1.min.js"></script>
    <script src="js/jquery-1.9.1.min.js"></script>

   <%-- <link href="css/bootstrapss.css" rel="stylesheet" />--%>

    <link href="css/bootstrap.css" rel="stylesheet" />



    <link href="css/jquery.qtip.css" rel="stylesheet" />
    <title></title>
    <style>
        .tooltip
        {width:200px;
         height: 40px;
         border:solid;
         border-color:blue;
            
        }
        </style>

    <script type="text/javascript">
        jQuery(function () {
            jQuery('input[name=text1]').datepicker({ changeYear: true, changeMonth: true, yearRange: "1940:2025" });

        })

        $(function () {
            $('input[title]').qtip();
        });
 </script>
</head>
<body>
    <form id="form1" runat="server">
   <%-- <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">  
</asp:ToolkitScriptManager>--%>
             <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>

         
        <asp:MultiView ID="MultiView1" runat="server">

            <asp:View ID="View1" runat="server">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />     
               </asp:View>
            <asp:View ID="View2" runat="server">2</asp:View>
            <asp:View ID="View3" runat="server">3</asp:View>
            <asp:View ID="View4" runat="server">4</asp:View>           
           
        </asp:MultiView>  
        <asp:DropDownList ID="ddt1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddt1_SelectedIndexChanged">
            <asp:ListItem Value="1" Text="financing" />
            <asp:ListItem Value="2" Text="leasing" />
            </asp:DropDownList>
         <div id="div1" runat="server" visible="false" >
       label name  <asp:TextBox Id="txt1" Text="submit" runat="server" ></asp:TextBox>      

    </div>
        <div id="div2" runat="server" visible="false">
            My name is aneesh
        </div>
        <div style="border:solid;border-color:black" runat="server"   id="check_div" >
            <asp:CheckBoxList ID="CheckBoxList1"  runat="server" AutoPostBack="true" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged1">
               <asp:ListItem Text="state1" Value="0" />
                 <asp:ListItem Text="state2" Value="1" />
                 <asp:ListItem Text="state3" Value="2" />
                 <asp:ListItem Text="state4" Value="3" />
                 <asp:ListItem Text="state5" Value="4" />

            </asp:CheckBoxList>
        </div>
        <div style="border:solid;border-color:black" runat="server" id="Div3" >
            <asp:ListBox ID="list1" runat="server">
                <asp:ListItem Text="state1" Value="0" Enabled="false"  />
                 <asp:ListItem Text="state2" Value="1" Enabled="false"/>
                 <asp:ListItem Text="state3" Value="2" Enabled="false"/>
                 <asp:ListItem Text="state4" Value="3" Enabled="false"/>
                 <asp:ListItem Text="state5" Value="4" Enabled="false"/>
            </asp:ListBox>
                    <%--<input type="text" id="name1" runat="server" /><%--<img src="images/Images/close%20copy.png" title="Enter name" style="border:#558844 1px solid ;width:200px;height: 40px;" />--%><img src="images/Images/close%20copy.png" data-toggle="tooltip" data-original-title="Explanation" title="Enter name" />--%>


             

            <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>


            <asp:CalendarExtender ID="CalendarExtender1" TargetControlID="txtStartDate"  runat="server" />

<br />

          <%--<div class="accordion-heading" style="background-color: rgb(245,245,245)">
                    <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion26" href="#collapsesix">Custom info
                    </a>
                </div>


                <div id="collapsesix" class="collapse">
                    <div class="accordion-inner">
                        <div id="divTab6" style="margin-left: 5px; margin-top: 20px; margin-right: 200px">
                                Hai
                            <br />
                           <p> hai 2 </p>
                        </div>
                    </div>
                </div>--%>
            


            <div class="panel-group" id="accordion">
      <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title">
        <a data-toggle="collapse" data-parent="#accordion" href="#collapseOne">
          Collapsible Group Item #1
        </a>
      </h4>
    </div>
    <div id="collapseOne" class="panel-collapse collapse in">
      <div class="panel-body">
        Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
      </div>
    </div>
  </div>


              
            
            
         <br /> <br /> <br /> <br /> <br /> <br />   
            
              </div>
           
            
<br /> <br /> <br /> <br /> <br /> <br />


        <%--<script src="js/responsive-accordion.js"></script>--%>
        <%--<script src="js/backbone.js"></script>--%>
        <script src="js/bootstrap.js"></script>


       <%-- <script src="js/responsive-accordion.min.js"></script>--%>
    
        
    </form>
</body>
</html>
