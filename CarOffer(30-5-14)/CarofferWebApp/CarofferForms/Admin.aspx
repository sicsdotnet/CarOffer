<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="CarofferWebApp.CarofferForms.Admin" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<%--<head runat="server">
    <title></title>
</head>--%>

      <head id="Head1" runat="server">
				<!-- META TAGS -->
				<meta charset="UTF-8" />
				<meta name="viewport" content="width=device-width" />
				
				<!-- Title -->
				<title> The CAROFFER.COM | Dallars Car Buyers | No Hassle | No Fees | Sell Your Car </title>
				
				<!-- Style Sheet-->
               <link rel="shortcut icon" href="../images/Images/images%20(1).jpg" type="image/png" />
               <link href="../css/bootstrap.css" rel="stylesheet" />
              <%-- <link href="../css/bootstrapss.css" rel="stylesheet" />--%>
               <link href="../css/style.css" rel="stylesheet" />
              <link href="../css/responsive.css" rel="stylesheet" />
               <link href="../css/flexslider.css" rel="stylesheet" />

    <style>

       #talkbubble {
   /*width: 120px;
   height: 80px;*/
   background: red;
   position: relative;
   -moz-border-radius:    10px;
   -webkit-border-radius: 10px;
   border-radius:         10px;
}
#talkbubble:before {
   content:"";
   position: absolute;
   right: 100%;
   top: 26px;
   width: 0;
   height: 0;
   border-top: 13px solid transparent;
   border-right: 26px solid red;
   border-bottom: 13px solid transparent;
}
        .visi
        {
            display:block;
        }
        .invisi
        {
            display:none;
        }
        .maindiv
        {
         border:solid; 
         border-color:black;
         border-bottom-left-radius:15px;
         border-bottom-right-radius:15px;
         border-top-left-radius:15px;
         border-top-right-radius:15px;
        }
      
    </style>
<script src="../js/jquery-1.7.1.min.js"></script>

		</head>
		<body>
            <form id="form1" runat="server">
                <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
                <style>
                @media (max-width:968px)
                        {
                         .headerxxaa
                             {
                                position: absolute;
                             }
                         }
            </style>

             <%--<-----Header------->--%>

                <div class="row headerxxaa" style="position:absolute;">
                <div class="header-wrapper">
                	<div class="container">
                    	<div class="row">
                        
                        	<!-- Logo -->
                            <div class="span4">
                            	<div class="logo">
                                	<a href="../CarOfferForms/index.aspx"><img id="Img1" src="../images/logo.png" alt="Logo" runat="server"/></a>
                                </div>
                            </div>
                        	<!-- Logo -->
                            
                            <!--top Menu -->
                            <div class="span8">
                            	<div class="top-menu">
                                	
                                </div>
                            </div>
                            <!--top Menu -->
                        
                        </div>
                    </div>
                </div>
                <!-- HEADER -->

                <!-- Main Navigation -->
                <div class="nav-wrapper">
                	<div class="container">
                    	<div class="row">
                        	<div class="span12">
                            
                            	<nav>
                                   
                                    <ul>
                                        <li><a href="Index.aspx">Home </a>                                      
                                        </li>
                                        <li><a href="#">Get Your Offer</a>
                                        	<ul class="clearfix">
                                               <%-- <li><a href="travel_grid.html">Travel Grid</a></li>
                                                <li><a href="travel_list.html">Travel list</a></li>
                                                <li><a href="travel_detail.html">Travel Detail</a></li>--%>
                                            </ul>
                                        </li>
                                        <li><a href="#">Consignment</a></li>
                                        <li>
                                            <a href="#">Car Locator</a>
                                            <ul class="clearfix">
                                              <%--  <li><a href="#">Camera</a></li>
                                                <li><a href="#">Notebook </a></li>
                                                <li><a href="#">Tablet </a> </li>
                                                <li><a href="#">Television </a> </li>
                                                <li><a href="#">Smart Phone </a> </li>
                                                <li><a href="#">Projection </a> </li>--%>
                                            </ul>
                                        </li>
                                        <li><a href="#">Shipping</a></li>
                                        <li><a href="#">Financing</a></li>
                                        <li><a href="#">Price Guarantee</a></li>
                                        <li><a href="#">Inventory</a></li>
                                        <li><a href="#">About Us</a>                                        	
                                        </li>                                       
                                    </ul>
                                </nav>

                                <div class="responsive_nav">
                                    <ul>
                                        <li class="open">
                                            <a href="#">HOME</a>
                                            <ul>
                                                <li><a href="Index.aspx">Home </a></li>
                                                <li><a href="#">Hotels</a></li>
                                                <li><a href="#">Holidays</a></li>
                                                <li><a href="#">Flights</a> </li>
                                                <li><a href="#">Camera</a></li>
                                                <li><a href="#">Notebook </a></li>
                                                <li><a href="#">Tablet </a> </li>
                                                <li><a href="#">Television </a> </li>
                                                <li><a href="#">Smart Phone </a> </li>
                                                <li><a href="#">Projection </a> </li>
                                                <li><a href="#">Cars</a></li>
                                                <li><a href="#">Vacations</a></li>
                                                <li><a href="#">Guide Book</a></li>
                                                <li><a href="#">Hot Deal</a></li>
                                                <li><a href="#">Cruise</a></li>
                                                <li class="last"><a href="#">Promotion</a></li>
                                            </ul>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div></div>
           


             <%--<-----Header------->--%>

   <div class="specialoffer-wrapper innercontantsree" style="background: rgb(232, 237, 241)">
       <div class="container">
          <div class="container  maindiv " id="Adminform_div" style="display:block; " >
             <asp:UpdatePanel ID="updatepanel_admin" runat="server">
                 <ContentTemplate>
            <div class="col-lg-12" style="margin-top:3%">

              <div class="col-lg-6" runat="server" id="div_Serviced" style="margin-top:1%;">
                  <asp:Button ID="serviced_btn" runat="server" Text="Click Here to View Serviced Vin" CssClass="form-control" style="width:50%;margin-left:15%; font-size:15px;font-family:'Times New Roman'" OnClick="serviced_btn_Click" /> 

            </div>

                <div class="col-lg-6" runat="server" id="div_tobeServiced" style="margin-top:1%;">
                    <asp:Button ID="TobServicedBtn" runat="server" Text="Click Here to View Vin to be Serviced" CssClass="form-control" style="width:50%;margin-left:-33%; font-size:15px;font-family:'Times New Roman'" OnClick="TobServicedBtn_Click"/>
                </div>

                <div class="col-lg-6" runat="server" id="textdivAutoExtender" style="margin-bottom:1%;margin-top:1%;">

                     <asp:TextBox ID="txtVin" runat="server" CssClass="form-control" placeholder="Enter Vin here to Search" style="margin-left:15%;width:50%;"></asp:TextBox>

                    <asp:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="txtVin" MinimumPrefixLength="1" EnableCaching="true" CompletionSetCount="1" CompletionInterval="1000" 
         ServiceMethod="GetVin"></asp:AutoCompleteExtender>

                    <%--<asp:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="txtVin" MinimumPrefixLength="1" EnableCaching="true" CompletionSetCount="1" CompletionInterval="1000" 
         ServiceMethod="GetVin">
                   </asp:AutoCompleteExtender>--%>

              </div>
                <div class="col-lg-6" id="searchBtnDIv" runat="server" style="margin-bottom:1%;margin-top:1%;">
                    <asp:Button ID="SearchVIn" runat="server" Text="Click to Search" CssClass="form-control" style="width:50%;margin-left:-33%; font-size:15px;font-family:'Times New Roman'" OnClick="SearchVIn_Click"/>

                </div>

                <centre>
              <div class="col-lg-10" style="margin-top:1%;margin-left:7%;" runat="server">
                  
                <asp:GridView ID="AdminGridview" runat="server" AutoGenerateColumns="False" DataKeyNames="VIN" OnRowCommand="AdminGridview_RowCommand" CssClass="table-bordered table" AllowPaging="True" OnPageIndexChanging="AdminGridview_PageIndexChanging" BorderColor="Black" BorderStyle="Double">
                  <Columns>
                      <asp:BoundField DataField="VIN" HeaderText="VIN" >
                          <HeaderStyle BackColor="Black" Font-Bold="True" Font-Names="Times New Roman" ForeColor="White" HorizontalAlign="Center" />
                          <ItemStyle BorderColor="Black" BorderStyle="Solid" />
                      </asp:BoundField>
                      <asp:BoundField DataField="YEAR" HeaderText="YEAR">
                          <HeaderStyle BackColor="Black" Font-Bold="True" Font-Names="Times New Roman" ForeColor="White" HorizontalAlign="Center" />
                          <ItemStyle BorderColor="Black" BorderStyle="Solid" />
                       </asp:BoundField>
                      <asp:BoundField DataField="MAKE" HeaderText="MAKE">
                          <HeaderStyle BackColor="Black" Font-Bold="True" Font-Names="Times New Roman" ForeColor="White" HorizontalAlign="Center" />
                          <ItemStyle BorderColor="Black" BorderStyle="Solid" />
                       </asp:BoundField>
                      <asp:BoundField DataField="MODEL" HeaderText="MODEL">
                          <HeaderStyle BackColor="Black" Font-Bold="True" Font-Names="Times New Roman" ForeColor="White" HorizontalAlign="Center" />
                          <ItemStyle BorderColor="Black" BorderStyle="Solid" />
                       </asp:BoundField>
                      <asp:BoundField DataField="STYLE" HeaderText="STYLE">
                          <HeaderStyle BackColor="Black" Font-Bold="True" Font-Names="Times New Roman" ForeColor="White" HorizontalAlign="Center" />
                          <ItemStyle BorderColor="Black" BorderStyle="Solid" />
                       </asp:BoundField>
                      <asp:BoundField DataField="SERIES" HeaderText="SERIES">
                          <HeaderStyle BackColor="Black" Font-Bold="True" Font-Names="Times New Roman" ForeColor="White" HorizontalAlign="Center" />
                          <ItemStyle BorderColor="Black" BorderStyle="Solid" />
                       </asp:BoundField>
                      <asp:BoundField DataField="TRANSMISSION" HeaderText="TRANSMISSION">
                          <HeaderStyle BackColor="Black" Font-Bold="True" Font-Names="Times New Roman" ForeColor="White" HorizontalAlign="Center" />
                          <ItemStyle BorderColor="Black" BorderStyle="Solid" />
                       </asp:BoundField>
                      <asp:BoundField DataField="ENGINE" HeaderText="ENGINE">
                          <HeaderStyle BackColor="Black" Font-Bold="True" Font-Names="Times New Roman" ForeColor="White" HorizontalAlign="Center" />
                          <ItemStyle BorderColor="Black" BorderStyle="Solid" />
                       </asp:BoundField>
                      
                      <asp:TemplateField HeaderText="Click to View">
                          <ItemTemplate>
                              <asp:LinkButton ID="Viewbtn" runat="server" CommandName="view" style="color:red;" CommandArgument='<%#Eval("VIN_ID")%>'>VIEW</asp:LinkButton>
                              <%--<asp:Button ID="Viewbtn" runat="server" Text="View" CommandName="view" CommandArgument='<%#Eval("VIN_ID")%>' />--%>
                          </ItemTemplate>
                          <HeaderStyle BackColor="Black" Font-Bold="True" Font-Names="Times New Roman" ForeColor="White" />
                          <ItemStyle Font-Bold="True" Font-Names="Times New Roman" ForeColor="#FF3300" HorizontalAlign="Center" Width="100" BorderColor="Black" BorderStyle="Solid" />
                      </asp:TemplateField>
                      
               </Columns>

           </asp:GridView>

                  </div>
                  
                </centre>
              </div>
          </ContentTemplate>

     </asp:UpdatePanel>
         </div>  
                                         
        </div>

   </div>




                <!-- Footer widget -->
                <div class="footer-widget-wrapper" style="margin-top:3%;">
                	<div class="container">
                    	<div class="row">
                        	<div class="col-md-3">
                            <div class="span3 f-widget copy-right">
                            	<a href="#" class="f-logo"><img src="../Images/logo.png" style="width:200px; margin-top:3%;" /></a>
                            	<p>© 2014 THE CAROFFER.COM </p>
                                <p> All rights reserved</p>
                            	<p>Designed by THE CAROFFER.COM </p>
                          </div></div>
                            <div class="col-md-3">
                            <div class="span3 f-widget" style="margin-top:9%;">
                            	<h4 style="margin-top:-4%;">Company Infomation</h4>
                                <ul>
                                	<li><a href="#">About US</a></li>
                                	<li><a href="#">Terms</a></li>
                                	<li><a href="#">Booking Tips</a></li>
                                	<li><a href="#">Payment Option</a></li>
                                	<li class="last"><a href="#">Infomation</a></li>
                                </ul>
                            </div></div> <div class="col-md-3">
                            <div class="span3 f-widget ">
                            	<h4 style="margin-top:5%;">Services</h4>
                                <ul>
                                	<li><a href="#">Get Your Offer</a></li>
                                	<li><a href="#">Consignment</a></li>
                                	<li><a href="#">Car Locator</a></li>
                                	<li><a href="#">Shipping</a></li>
                                    <li><a href="#">Financing</a></li>
                                    <li><a href="#">Price Guarantee</a></li>
                                    <li class="last"><a href="#">Inventory</a></li>
                                </ul>
                            </div></div>
                             <div class="col-md-3">
                            <div class="span3 f-widget">
                            	<div class="cc">
                            		<h4 style="margin-top:5%;">Customer Support</h4>
                            		<h2>1-669-559-4378</h2>
                            		<span class="pull-right">Support 24x7</span>
                            	</div>
                            	<div class="f-widget n-letter">
                                	<h4>Newsletter</h4>

                                    <%--<form>--%>
                                        <input type="text" name="newlatter" value="Enter your email..."/>
                                        <input type="submit" name="submite-newslatter" value="Send"/>
                                    <%--</form>--%>
                                </div>
                            </div></div>
                            
                        </div>
                    </div>
                </div>
                <!-- Footer widget -->
                
                <!-- Footer -->
                <div class="footer-wrapper">
                	<div class="container">
                    	<div class="row">
                        	<div class="span12">                            
                            	<footer>
                                	<div class="footer-nav">
                                    	<ul>
                                    		<li><a href="#">About US</a></li>
                                    		<li><a href="#">News</a></li>
                                    		<li><a href="#">Service</a></li>
                                    		<li><a href="#">Recruitment </a></li>
                                    		<li><a href="#">Media</a></li>
                                    		<li><a href="#">Support</a></li>
                                    	</ul>
                                    </div>
                                 <a href="#page-top" class="gotop"  id="scroll-top"></a>
                                </footer>
                                
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Footer -->
                
                <div class="login-popup-wrapper">
                    <div id="login-popup">
                    	<h2>login Panel</h2>
                        <%--<form method="get" action="#">--%>
                            <input type="text" value="" id="username" placeholder="kavinhieu@gmail.com" />
                            <input type="text" value="" id="password" placeholder="Password" />
                            
                            <input type="submit" value="sıgn ın" id="login-button"/>
                        <%--</form>--%>
                        <a href="#" class="close">Close</a>
                    </div>
                </div>



                <!-- Scripts -->
				<%--<script src="js/jquery-1.7.1.min.js"></script>
				<script src="js/jquery.flexslider.js"></script>
                <script src="js/jquery.flexslider-min.js"></script>
                <script src="js/jquery.elastislide.js"></script>
                <script src="js/jquery.carouFredSel-6.0.4-packed.js"></script>
                <script src="js/jcarousellite_1.0.1.js"></script>
                <script src="js/jquery.zweatherfeed.js"></script>
                <script src="js/jquery.simpleWeather-2.3.min.js"></script>
                <script src="js/jquery.cycle.all.js"></script>
                <script src="js/jquery-ui.js"></script>
                <script src="js/bootstrap.min.js"></script>
                <script src="js/jquery.isotope.min.js"></script>
                <script src="js/jquery.tinyscrollbar.min.js"></script>--%>

                <script src="../js/jquery-1.7.1.min.js"></script>
                <script src="../js/jquery.simpleWeather-2.3.min.js"></script>
                <script src="../js/jquery.cycle.all.js"></script>
                <script src="../js/jquery-ui.js"></script>
                <script src="../js/bootstrap.min.js"></script>

                <script src="../js/script_for_this_demo.js"></script>
                <script src="../js/jquery.flexslider-min.js"></script>
                <script src="../js/jquery.zweatherfeed.js"></script>
                <script src="../js/jquery.flexslider.js"></script>
                <script src="../js/jquery.carouFredSel-6.0.4-packed.js"></script>
                <script src="../js/jcarousellite_1.0.1.js"></script>
                <script src="../js/jquery.isotope.min.js"></script>
                <script src="../js/jquery.tinyscrollbar.min.js"></script>

                <script src="../js/jquery.elastislide.js"></script>

                <script type="text/javascript">
                    function goToByScroll(id) {
                        $ = jQuery;
                        $('html,body').animate({ scrollTop: $("#" + id).offset().top }, 3000);
                    }

               </script>
            </form>

		</body>

</html>

