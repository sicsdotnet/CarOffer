<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Summary.aspx.cs" Inherits="CarofferWebApp.CarofferForms.Summary" %>

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
          <title>The CAROFFER.COM | Dallars Car Buyers | No Hassle | No Fees | Sell Your Car </title>


	<link rel="shortcut icon" href="../images/Images/images%20(1).jpg" type="image/png" />

    <link href="../css/flexslider.css" rel="stylesheet" />
    <link href="../css/style.css" rel="stylesheet" />
    <link href="../css/responsive.css" rel="stylesheet" />
    <link href="../css/bootstrap.css" rel="stylesheet" />
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

        .lbll
        {
            color: black;
            font-family: sans-serif;
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
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
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
            <div class="col-lg-12" style="margin-top:1%;margin-bottom:1%;">
                 <img src="../images/Images/16%20copy.png" style="width: 96%; margin-top: 1%; margin-left: 1%;" />
                 <img src="../images/Images/24%20copy.png" style="width: 96%; margin-top: 1%; margin-left: 1%;" />
              
                 <%--vehiclespecification--%>

                <div class="col-lg-6" style="margin-top: 1%;">
                                        <img src="../images/car.jpg" style="margin-top: 1%; width: 39%; margin-left: 22%" />
                                    </div>
                                    <div class="col-lg-6" style="margin-top: 3%; margin-left: -11%">
                                        <center>
                                        <table id="table_vehicle_specification" runat="server">
                                            <tr style="border-bottom: solid 1px; width: 100%;">
                                                <td style="width: 20px;">Vin: </td>
                                                <td style="width: 80px;"> </td>
                                                <td style="width: 500px;">
                                                    <asp:Label ID="Vin_valueFil_lb" runat="server" CssClass="lbll"/></td>
                                            </tr>



                                            <tr style="border-bottom: solid 1px; width: 100%;">
                                                <td style="width: 20px;">Year:</td>
                                                <td style="width: 80px;"></td>
                                                <td style="width: 500px;">
                                                    <asp:Label ID="Year_valueFil_lb" runat="server" CssClass="lbll"/></td>
                                            </tr>




                                            <tr style="border-bottom: solid 1px; width: 100%;">
                                                <td style="width: 20px;">Make:</td>
                                                <td style="width: 80px;"></td>
                                                <td style="width: 500px;">
                                                    <asp:Label ID="Make_valueFil_lb" runat="server" CssClass="lbll"></asp:Label>

                                                </td>
                                            </tr>


                                            <tr style="border-bottom: solid 1px; width: 100%;">
                                                <td style="width: 20px;">Model:</td>
                                                <td style="width: 80px;"></td>
                                                <td style="width: 500px;">
                                                    <asp:Label ID="Model_valueFil_lb" runat="server" CssClass="lbll"/></td>
                                            </tr>


                                            <tr style="border-bottom: solid 1px; width: 100%;">
                                                <td style="width: 20px;">Style:</td>
                                                <td style="width: 80px;"></td>
                                                <td style="width: 500px;">
                                                    <asp:Label ID="Style_valueFil_lb" runat="server" CssClass="lbll"/></td>
                                            </tr>



                                            <tr style="border-bottom: solid 1px; width: 100%;">
                                                <td style="width: 20px;">Transmission:</td>
                                                <td style="width: 80px;"></td>
                                                <td style="width: 500px;">
                                                    <asp:Label ID="Transmission_valueFil_lb" runat="server" CssClass="lbll"/></td>
                                            </tr>

                                            <tr style="border-bottom: solid 1px; width: 100%;">
                                                <td style="width: 20px;">Engine:</td>
                                                <td style="width: 80px;"></td>
                                                <td style="width: 500px;">
                                                    <asp:Label ID="Engine_valueFil_lb" runat="server" CssClass="lbll"/></td>
                                            </tr>


                                        </table></center>
                                    </div>

                                    <img src="../images/Images/25%20copy.png" style="width: 98%; margin-top: 1%" />

                                    <div class="col-lg-12" style="margin-top: 2%;">
                                        <center>
                                        <table id="Table_vehicle_owner" runat="server" style="width:80%;">
                                            <tr style="border-bottom: solid 1px; width: 100%;">
                                                <td style="width: 174px;">First Name:</td>
                                                <td style="width: 80px;"></td>
                                                <td style="width: 526px;">
                                                    <asp:Label ID="First_name_value_lbl" runat="server" CssClass="lbll"/></td>
                                            </tr>



                                            <tr style="border-bottom: solid 1px; width: 100%;">
                                                <td style="width: 174px;">Last Name:</td>
                                                <td style="width: 80px;"></td>
                                                <td style="width: 526px;">
                                                    <asp:Label ID="Lastname_value_lbl" runat="server" CssClass="lbll"/></td>
                                            </tr>




                                            <tr style="border-bottom: solid 1px; width: 100%;">
                                                <td style="width: 174px;">Email:</td>
                                                <td style="width: 80px;"></td>
                                                <td style="width: 526px;">
                                                    <asp:Label ID="Email_value_lbl" runat="server" CssClass="lbll" /></td>
                                            </tr>


                                            <tr style="border-bottom: solid 1px; width: 100%;">
                                                <td style="width: 174px;">Zip Code:</td>
                                                <td style="width: 80px;"></td>
                                                <td style="width: 526px;">
                                                    <asp:Label ID="Zip_code_value_lbl" runat="server" CssClass="lbll"/></td>
                                            </tr>


                                            <tr style="border-bottom: solid 1px; width: 100%;">
                                                <td style="width: 174px;">Telephone:</td>
                                                <td style="width: 80px;"></td>
                                                <td style="width: 526px;">
                                                    <asp:Label ID="Telephone_value_Filllbl" runat="server" CssClass="lbll"/></td>
                                            </tr>



                                            <tr style="border-bottom: solid 1px; width: 100%;">
                                                <td style="width: 174px;">Financing or Leasing:</td>
                                                <td style="width: 80px;"></td>
                                                <td style="width: 526px;">
                                                    <asp:Label ID="Financing_Leasing_Filllbl" runat="server" CssClass="lbll"/></td>
                                            </tr>

                                           <tr style="border-bottom: solid 1px; width: 100%;" runat="server" visible="false" id="tr_financecompname_financing">
                                                <td style="width: 174px;">Finance Company Name:</td>
                                                <td style="width: 80px;"></td>
                                                <td style="width: 526px;">
                                                    <asp:Label ID="FinanceCompany_name_Fill_lbl" runat="server" CssClass="lbll"/></td>
                                            </tr>
                                            
                                            <tr id="tr_financeAmount_financing" style="border-bottom: solid 1px; width: 100%;" runat="server" visible="false">
                                                <td style="width: 174px;">Financed Amount:</td>
                                                <td style="width: 80px;"></td>
                                                <td style="width: 526px;">
                                                    <asp:Label ID="Finance_Amount_Fill_lbl" runat="server" CssClass="lbll"/></td>
                                            </tr>

                                            <tr style="border-bottom: solid 1px; width: 100%;" runat="server" visible="false" id="tr_leasingCompanyName">
                                                <td style="width: 174px;">Leasing Company Name:</td>
                                                <td style="width: 80px;"></td>
                                                <td style="width: 526px;">
                                                    <asp:Label ID="LeasingCompName_fill_Lbl" runat="server" CssClass="lbll"/></td>
                                            </tr>

                                            <tr id="tr_LeasedAmount" style="border-bottom: solid 1px; width: 100%;" runat="server" visible="false">
                                                <td style="width: 174px;">Leased Amount:</td>
                                                <td style="width: 80px;"></td>
                                                <td style="width: 526px;">
                                                    <asp:Label ID="Leased_Amount_fill_lbl" runat="server" CssClass="lbll"/></td>
                                            </tr>

                                            
                                             <tr style="border-bottom: solid 1px; width: 100%;">
                                                <td style="width: 174px;">How did you hear about us:</td>
                                                <td style="width: 80px;"></td>
                                                <td style="width: 526px;">
                                                    <asp:Label ID="Hear_about_value_lbl" runat="server" CssClass="lbll"/></td>
                                            </tr>

                                            <tr style="border-bottom: solid 1px; width: 100%;" runat="server" id="tr_Expected_Amount" visible="false">
                                                <td style="width: 174px;">Expected Amount:</td>
                                                <td style="width: 80px;"></td>
                                                <td style="width: 526px;">
                                                    <asp:Label ID="Expctd_Amount_value_lbl" runat="server" CssClass="lbll"/></td>
                                            </tr>

                                            <tr style="border-bottom: solid 1px; width: 100%;">
                                                <td style="width: 174px;">Vehicle Registered State:</td>
                                                <td style="width: 80px;"></td>
                                                <td style="width: 526px;">
                                                    <asp:Label ID="Vehicle_registrd_value_lbl" runat="server" CssClass="lbll"/></td>
                                            </tr>

                                        </table></center>
                                        <%--<img src="../images/Images/17%20copy.png" style="float:right;width: 9%; margin-bottom:50px;margin-right: 266px;margin-top: 3%;"/>--%><br />
                                       <%-- <asp:ImageButton runat="server" ID="Edit_btn_Appriaslform" ImageUrl="../images/Images/17%20copy.png" Style="float: right; width: 9%; margin-bottom: 50px; margin-right: 241px; margin-top: 3%;" OnClick="Edit_btn_OwnerInformation_Click" />--%>
                                    </div>





                <%--vehiclespecification--%>


                <div class="col c1" style="margin-top: 1%; margin-bottom: 1%; width: 99%; margin-left: 1%;">
                                    <h2></h2>
                                    <div id="default-example" data-collapse>
                                        <h3>
                                            <img src="../images/Images/28%20copy.png" style="width: 97%; margin-top: -16%" /></h3>
                                        <div>
                                            <center>
            <table style="margin-top:1%;width:80%;">
                <tr style="border-bottom: solid 1px; width: 100%;">
                       <td style="width: 250px;">Current mileage:</td>
                        <td style="width: 80px;"></td>
                        <td style="width: 500px;">
                          <asp:Label ID="Current_Milg_Fill_lbl" runat="server" CssClass="lbll"></asp:Label>    
                       <%--<asp:Label ID="Current_Milg_Fill_lbl" runat="server" CssClass="lbll"></asp:Label>--%>

                        </td>
                    
                 </tr>

                <tr style="border-bottom: solid 1px; width: 100%;">
                       <td style="width: 250px;">Actual and Accurate Mileage:</td>
                        <td style="width: 80px;"></td>
                        <td style="width: 500px;">
                       <asp:Label ID="Actual_Accurate_Milege_fill_lbl" runat="server" CssClass="lbll"/></td>
                 </tr>


                <tr style="border-bottom: solid 1px; width: 100%;">
                       <td style="width: 250px;">Exterior Color:</td>
                        <td style="width: 80px;"></td>
                        <td style="width: 500px;">
                       <asp:Label ID="Exterior_color_Fill_lbl" runat="server" CssClass="lbll"/></td>
                 </tr>
                
                <tr style="border-bottom: solid 1px; width: 100%;">
                       <td style="width: 250px;">Interior Color:</td>
                        <td style="width: 80px;"></td>
                        <td style="width: 500px;">
                       <asp:Label ID="Interior_color_Fil_lbl" runat="server" CssClass="lbll"/></td>
                 </tr>



                <tr style="border-bottom: solid 1px; width: 100%;">
                       <td style="width: 250px;">Original Owner:</td>
                        <td style="width: 80px;"></td>
                        <td style="width: 500px;">
                       <asp:Label ID="Original_Owner_Fill_lbl" runat="server" CssClass="lbll"/></td>
                 </tr>

                <%--<tr style="border-bottom: solid 1px; width: 100%;">
                       <td style="width: 250px;">Vehicle Owned Less than 90 Days:</td>
                        <td style="width: 80px;"></td>
                        <td style="width: 500px;">
                       <asp:Label ID="Vehicl_90_days_fill_lbl" runat="server" CssClass="lbll"/></td>
                 </tr>--%>

                 <tr style="border-bottom: solid 1px; width: 100%;" runat="server" visible="false" id="tr_Purchased_from">
                       <td style="width: 250px;">Purchased From:</td>
                        <td style="width: 80px;"></td>
                        <td style="width: 500px;">
                       <asp:Label ID="Purchased_from_Fill_lbl" runat="server" CssClass="lbll"/></td>
                 </tr>

                 <tr style="border-bottom: solid 1px; width: 100%;">
                       <td style="width: 250px;">Smoked or Bad Odor in the Vehicle:</td>
                        <td style="width: 80px;"></td>
                        <td style="width: 500px;">
                       <asp:Label ID="Smoked_Bad_odor_fil_lbl" runat="server" CssClass="lbll"/></td>
                 </tr>
    
                <tr style="border-bottom: solid 1px; width: 100%;">
                       <td style="width: 250px;">Service History:</td>
                        <td style="width: 80px;"></td>
                        <td style="width: 500px;">
                       <asp:Label ID="Servic_histry_fill_lbl" runat="server" CssClass="lbll"/></td>
                 </tr>


                <tr style="border-bottom: solid 1px; width: 100%;">
                       <td style="width: 250px;">2-Sets of Keypads:</td>
                        <td style="width: 80px;"></td>
                        <td style="width: 500px;">
                       <asp:Label ID="Set_2_keys_fill_lbl" runat="server" CssClass="lbll"/></td>
                 </tr>

                <tr style="border-bottom: solid 1px; width: 100%;">
                       <td style="width: 250px;">Used as a taxi or rental Vehicle:</td>
                        <td style="width: 80px;"></td>
                        <td style="width: 500px;">
                       <asp:Label ID="Taxi_rental_fill_lbl" runat="server" CssClass="lbll"/></td>
                 </tr>


                <tr style="border-bottom: solid 1px; width: 100%;">
                       <td style="width: 250px;">Insurance Claimed:</td>
                        <td style="width: 80px;"></td>
                        <td style="width: 500px;">
                       <asp:Label ID="Insurance_claimed_fill_lbl" runat="server" CssClass="lbll"/></td>
                 </tr>
               
                <tr style="border-bottom: solid 1px; width: 100%;" runat="server" id="tr_insurance_Claimed_date" visible="false">
                       <td style="width: 250px;">Insurance Claimed Date:</td>
                        <td style="width: 80px;"></td>
                        <td style="width: 500px;">
                       <asp:Label ID="Insurance_claim_date_fill_lbl" runat="server" CssClass="lbll"/></td>
                 </tr>



                <tr style="border-bottom: solid 1px; width: 100%;" runat="server" id="tr_insurance_claimed_Amount" visible="false">
                       <td style="width: 250px;">Insurance Claimed Amount:</td>
                        <td style="width: 80px;"></td>
                        <td style="width: 500px;">
                       <asp:Label ID="Insurance_Claim_amount_fill_lbl" runat="server" CssClass="lbll"/></td>
                 </tr>
                
                
                
                
                 <tr style="border-bottom: solid 1px; width: 100%;">
                       <td style="width: 250px;">Performance Modification:</td>
                        <td style="width: 80px;"></td>
                        <td style="width: 500px;">
                       <asp:Label ID="Performance_Modificaion_fill_lbl" runat="server" CssClass="lbll"/></td>
                 </tr>

                <tr style="border-bottom: solid 1px; width: 100%;" runat="server" id="tr_Performance_description" visible="false">
                       <td style="width: 250px;">Performance Description:</td>
                        <td style="width: 80px;"></td>
                        <td style="width: 500px;">
                       <asp:Label ID="Performance_description_fill_lbl" runat="server" CssClass="lbll"/></td>
                 </tr>

                <tr style="border-bottom: solid 1px; width: 100%;">
                       <td style="width: 250px;">After Market Equipment Installed:</td>
                        <td style="width: 80px;"></td>
                        <td style="width: 500px;">
                       <asp:Label ID="After_Equipmnt_installed_fil_lbl" runat="server" CssClass="lbll"/></td>
                 </tr>

                <tr style="border-bottom: solid 1px; width: 100%;" runat="server" id="tr_Equipment_description" visible="false">
                       <td style="width: 250px;">After Market Equipment Description:</td>
                        <td style="width: 80px;"></td>
                        <td style="width: 500px;">
                       <asp:Label ID="Equipment_description_fill_lbl" runat="server" CssClass="lbll"/></td>
                 </tr>

                
            </table></center>

                                          <%--  <asp:ImageButton runat="server" ID="VehicleDetails_editbtn" ImageUrl="../images/Images/17%20copy.png" Style="float: right; width: 9%; margin-bottom: 50px; margin-right: 266px; margin-top: 3%;" OnClick="VehicleDetails_editbtn_Click" />--%>
                                        </div>

                                    </div>

                                    <script>
                                        new jQueryCollapse($("#custom-show-hide-example"), {
                                            open: function () {
                                                this.slideDown(300);
                                            },
                                            close: function () {
                                                this.slideUp(300);
                                            }
                                        });
                                    </script>
                                </div>

                <%--vehiclespecification--%>


                <%--Vehicleoptions and features--%>

                 <div class="col c1" style="margin-top: 3%; margin-bottom: 3%; width: 99%; margin-left: 1%;">
                                    <h2></h2>
                                    <div id="Div2" data-collapse>
                                        <%-- <img src="../images/Images/12%20copy.png" />--%>
                                        <h3>
                                            <img src="../images/Images/19%20copy.png" style="width: 97%; margin-top: -16%" /></h3>
                                        <div>
                                            <center>
        <div runat="server" id="maindiv_tale">
           
            
        
        </div>
                </center>
                                           <%-- <asp:ImageButton runat="server" ID="Vehicle_options_Features_Editbtn" ImageUrl="../images/Images/17%20copy.png" Style="float: right; width: 9%; margin-bottom: 50px; margin-right: 266px; margin-top: 3%;" OnClick="Vehicle_options_Features_Editbtn_Click" />--%>
                                        </div>
                                    </div>

                                    <script>
                                        new jQueryCollapse($("#custom-show-hide-example"), {
                                            open: function () {
                                                this.slideDown(300);
                                            },
                                            close: function () {
                                                this.slideUp(300);
                                            }
                                        });
                                    </script>
                                </div>



                <%--Vehicleoptions and features--%>

                <%--VehicleConditionDetails--%>


                                <div class="col c1" style="margin-top: 1%; margin-bottom: 0%; width: 99%; margin-left: 1%;">
                                    <h2></h2>
                                    <div id="Div6" data-collapse>

                                        <h3>
                                            <img src="../images/Images/condition.png" style="width: 97%; margin-top: -16%" /></h3>
                                        <div class="col-lg-12" runat="server" id="outerdiv_Vehiclecondition" style="margin-bottom: 10%;">
                                            <center>
          <table> <tr style="border-bottom: solid 1px; width: 100%;">
                  <td style="width: 250px;">Overall exterior condition:</td>
                        <td style="width: 50px;"></td>
                        <td style="width: 400px;">Following exterior blemishes or damages indicated.</td>
               </tr></table>

         <div id="Fb_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                          <asp:GridView ID="Gvd_FrontBumper" runat="server" AutoGenerateColumns="False" BorderStyle="None">
                                  <Columns>
                                 <asp:BoundField DataField="FRONTBUMPER_DATA" HeaderText="Front Bumper">

                              <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                            <ItemStyle BorderStyle="None" BorderWidth="10px" />
                        </asp:BoundField>

                     </Columns>
                     </asp:GridView>
          </div>

         <div id="Hood_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                   <asp:GridView ID="Gvd_Hood" runat="server" AutoGenerateColumns="False" BorderStyle="None" >
                          <Columns>
                             <asp:BoundField DataField="HOOD_DATA" HeaderText="Hood">
                                 <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />
                                   <ItemStyle BorderStyle="None" BorderWidth="10px" />
                             </asp:BoundField>
                              </Columns>
                          </asp:GridView>
             </div>


         <div id="Roof_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                   <asp:GridView ID="Gvd_Rooof" runat="server" AutoGenerateColumns="False" BorderStyle="None" >
                          <Columns>
                             <asp:BoundField DataField="ROOF_DATA" HeaderText="Roof">
                                 <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />
                                   <ItemStyle BorderStyle="None" BorderWidth="10px" />
                             </asp:BoundField>
                              </Columns>
                          </asp:GridView>
             </div>

         <div id="Front_Left_fender_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                   <asp:GridView ID="Gvd_Front_left_Fender" runat="server" AutoGenerateColumns="False" BorderStyle="None" >
                          <Columns>
                             <asp:BoundField DataField="FRONTLEFTFENDER_DATA" HeaderText="Front Left Fender">
                                 <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />
                                   <ItemStyle BorderStyle="None" BorderWidth="10px" />
                             </asp:BoundField>
                              </Columns>
                          </asp:GridView>
             </div>


         <div id="Front_Left_Door_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                    <asp:GridView ID="Gvd_FrontLeftDoor" runat="server" AutoGenerateColumns="False" BorderStyle="None">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="FRONTLEFTDOOR_DATA" HeaderText="Front Left Door">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            </div>


        <div id="RearLeftDoor_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                    <asp:GridView ID="Gvd_Rear_Left_door" runat="server" AutoGenerateColumns="False" BorderStyle="None">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="REARLEFTDOOR_DATA" HeaderText="Rear Left Door">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            </div>


        <div id="RearLeftQuarterPanel_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                    <asp:GridView ID="Gvd_RearLeftQuarterPanel" runat="server" AutoGenerateColumns="False" BorderStyle="None">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="REARLEFTQUARTERPANEL_DATA" HeaderText="Rear Left Quarter Panel">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            </div>


        <div id="FrontLeftWindow_Div_summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                    <asp:GridView ID="Gvd_FrontLeftWindow" runat="server" AutoGenerateColumns="False" BorderStyle="None">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="FRONTLEFTWINDOW_DATA" HeaderText="Front Left Window">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            </div>


        <div id="RearLeftWindow_Div_summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                    <asp:GridView ID="Gvd_RearLeftWindow" runat="server" AutoGenerateColumns="False" BorderStyle="None">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="REARLEFTWINDOW_DATA" HeaderText="Rear Left Window">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            </div>


       <div id="FrontWindshield_Div_summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                    <asp:GridView ID="Gvd_FrontWindshield" runat="server" AutoGenerateColumns="False" BorderStyle="None">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="FRONTWINDSHIELD_DATA" HeaderText="Front Windshield">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            </div>


       <div id="FrontLeftWheelTire_Div_summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                    <asp:GridView ID="Gvd_FrontLeftWheelTire" runat="server" AutoGenerateColumns="False" BorderStyle="None">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="FRONTLEFTWHEELTIRE_DATA" HeaderText="Front Left Wheel & Tire">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            </div>


       <div id="RearLeftWheelTire_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                    <asp:GridView ID="Gvd_RearLeftWheelTire" runat="server" AutoGenerateColumns="False" BorderStyle="None">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="REARLEFTWHEELTIRE_DATA" HeaderText="Rear Left Wheel & Tire">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            </div>



       <div id="FrontLeftHeadligh_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                    <asp:GridView ID="Gvd_FrontLeftHeadligh" runat="server" AutoGenerateColumns="False" BorderStyle="None">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="FRONTLEFTHEADLIGHT_DATA" HeaderText="Front Left Headlight">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            </div>


      <div id="FrontRighttHeadligh_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                    <asp:GridView ID="Gvd_FrontrightHeadlight" runat="server" AutoGenerateColumns="False" BorderStyle="None">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="FRONTRIGHTHEADLIGHT_DATA" HeaderText="Front Right Headlight">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            </div>


     <div id="LeftMirror_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                    <asp:GridView ID="Gvd_LeftMirror" runat="server" AutoGenerateColumns="False" BorderStyle="None">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="LEFTMIRROR_DATA" HeaderText="Left Mirror">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            </div>


     <div id="Trunk_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                    <asp:GridView ID="Gvd_Trunk" runat="server" AutoGenerateColumns="False" BorderStyle="None">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="Content" HeaderText="Trunk">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            </div>


    <div id="RearBumper_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                    <asp:GridView ID="Gvd_RearBumper" runat="server" AutoGenerateColumns="False" BorderStyle="None">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="REARBUMPER_DATA" HeaderText="Rear Bumper">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            </div>

    <div id="RearRightQuarterPanel_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                    <asp:GridView ID="Gvd_RearRightQuarterPanel" runat="server" AutoGenerateColumns="False" BorderStyle="None">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="REARRIGHTQUARTERPANEL_DATA" HeaderText="Rear Right Quarter Panel">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            </div>



    <div id="FrontRightFender_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                    <asp:GridView ID="Gvd_FrontRightFender" runat="server" AutoGenerateColumns="False" BorderStyle="None">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="FRONTRIGHTFENDER_DATA" HeaderText="Front Right Fender">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            </div>



     <div id="FrontRightDoor_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                    <asp:GridView ID="Gvd_FrontRightDoor" runat="server" AutoGenerateColumns="False" BorderStyle="None">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="FRONTRIGHTDOOR_DATA" HeaderText="Front Right Door">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            </div>

      <div id="RearRightDoor_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                    <asp:GridView ID="Gvd_RearRightDoor" runat="server" AutoGenerateColumns="False" BorderStyle="None">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="REARRIGHTDOOR_DATA" HeaderText="Rear Right Door">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            </div>

     <div id="FrontRightWindow_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                    <asp:GridView ID="Gvd_FrontRightWindow" runat="server" AutoGenerateColumns="False" BorderStyle="None">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="FRONTRIGHTWINDOW_DATA" HeaderText="Front Right Window">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            </div>


     <div id="RearRightWindow_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                    <asp:GridView ID="Gvd_RearRightWindow" runat="server" AutoGenerateColumns="False" BorderStyle="None">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="REARRIGHTWINDOW_DATA" HeaderText="Rear Right Window">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            </div>


    <div id="RearWindshield_Div_summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                    <asp:GridView ID="Gvd_RearWindshield" runat="server" AutoGenerateColumns="False" BorderStyle="None">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="REARWINDSHIELDCHECK_DATA" HeaderText="Rear Windshield">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            </div>


    <div id="FrontRightWheelTire_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                    <asp:GridView ID="Gvd_FrontRightWheelTire" runat="server" AutoGenerateColumns="False" BorderStyle="None">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="FRONTRIGHTWHEELTIRE_DATA" HeaderText="Front Right Wheel & Tire">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            </div>


  <div id="RearRightWheelTire_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                    <asp:GridView ID="Gvd_RearRightWheelTire" runat="server" AutoGenerateColumns="False" BorderStyle="None">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="REARRIGHTWHEELTIRE_DATA" HeaderText="Rear Right Wheel & Tire">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            </div>


   <div id="RightTailLight_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                    <asp:GridView ID="Gvd_RightTailLight" runat="server" AutoGenerateColumns="False" BorderStyle="None">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="RIGHTTAILLIGHT_DATA" HeaderText="Right Tail Light">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            </div>


   <div id="LeftTailLight_Div_summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                    <asp:GridView ID="Gvd_LeftTailLight" runat="server" AutoGenerateColumns="False" BorderStyle="None">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="LEFTTAILLIGHT_DATA" HeaderText="Left Tail Light(driver side)">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            </div>

   <div id="RightMirror_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">
                    <asp:GridView ID="Gvd_RightMirror" runat="server" AutoGenerateColumns="False" BorderStyle="None">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="RIGHTMIRRORDATA" HeaderText="Right Mirror">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            </div>

   </center>
                                            

                                        </div>
                                        <%--<asp:ImageButton runat="server" ID="Vehicle_photos_Editbtn" ImageUrl="../images/Images/17%20copy.png" Style="float: right; width: 9%; margin-bottom: 50px; margin-right: 266px; margin-top: 3%;" OnClick="Vehicle_photos_Editbtn_Click" />--%>
                                    </div>

                                    <script>
                                        new jQueryCollapse($("#custom-show-hide-example"), {
                                            open: function () {
                                                this.slideDown(300);
                                            },
                                            close: function () {
                                                this.slideUp(300);
                                            }
                                        });
                                    </script>
                                </div>



                <%--VehicleConditionDetails--%>

                <%--image uploaded--%>
                <img src="../images/Images/upload.png" style="width: 96%; margin-top: 1%;margin-left:1%" />

                                    <div class="col-lg-10" runat="server" style="margin-top: 1%;" id="imagediv">


                                    </div>



                <%--image uploaded--%>


           
                
                
                
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

                <script src="../js/jquery.collapse.js"></script>

        <script src="../js/jquery.collapse_cookie_storage.js"></script>
        <script src="../js/jquery.collapse_storage.js"></script>


                <script type="text/javascript">
                    function goToByScroll(id) {
                        $ = jQuery;
                        $('html,body').animate({ scrollTop: $("#" + id).offset().top }, 3000);
                    }

               </script>
            </form>

		</body>

</html>


