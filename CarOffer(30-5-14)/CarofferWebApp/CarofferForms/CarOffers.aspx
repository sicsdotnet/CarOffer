<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarOffers.aspx.cs" Inherits="CarofferWebApp.CarofferForms.CarOffers" %>

<%--<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>--%>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>



<!DOCTYPE html>

<%-- Aneesh --%>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- META TAGS -->
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width" />
    <!-- Title -->
    <title>The CAROFFER.COM | Dallars Car Buyers | No Hassle | No Fees | Sell Your Car </title>

    <!-- Style Sheet-->
    <link rel="shortcut icon" href="../images/Images/images%20(1).jpg" type="image/png" />

    <link href="../css/flexslider.css" rel="stylesheet" />
    <link href="../css/style.css" rel="stylesheet" />
    <link href="../css/responsive.css" rel="stylesheet" />
    <link href="../css/bootstrap.css" rel="stylesheet" />
    <link href="../css/style.css" rel="stylesheet" />
    <link href="../css/responsive.css" rel="stylesheet" />
    <link href="../css/flexslider.css" rel="stylesheet" />



    <style>
        #talkbubble
        {
            /*width: 120px;
   height: 80px;*/
            background: red;
            position: relative;
            -moz-border-radius: 10px;
            -webkit-border-radius: 10px;
            border-radius: 10px;
        }

            #talkbubble:before
            {
                content: "";
                position: absolute;
                right: 100%;
                top: 26px;
                width: 0;
                height: 0;
                border-top: 13px solid transparent;
                border-right: 26px solid red;
                border-bottom: 13px solid transparent;
            }

        .lbll
        {
            color: black;
            font-family: sans-serif;
        }

        .invisi
        {
            display: none;
        }

        .maindiv
        {
            border: solid;
            border-color: black;
            border-bottom-left-radius: 15px;
            border-bottom-right-radius: 15px;
            border-top-left-radius: 15px;
            border-top-right-radius: 15px;
        }



        a.tooltips
        {
            position: relative;
            display: inline;
        }

            a.tooltips span
            {
                position: absolute;
                /*//width:140px;*/
                color: black;
                background: white;
                border: ridge;
                /*height: 30px;*/
                line-height: 25px;
                text-align: start;
                visibility: hidden;
                border-radius: 3px;
                /*box-shadow: 5px 5px 5px #f87c7c;*/
            }

                a.tooltips span:after
                {
                    content: '';
                    position: absolute;
                    top: 50%;
                    right: 100%;
                    margin-top: -8px;
                    width: 0;
                    height: 0;
                    border-right: 8px solid #000000;
                    border-top: 8px solid transparent;
                    border-bottom: 8px solid transparent;
                }

        a:hover.tooltips span
        {
            visibility: visible;
            opacity: 2;
            left: 100%;
            top: 50%;
            margin-top: -15px;
            margin-left: 15px;
            z-index: 999;
            text-decoration: none;
        }

        .radiobuttonlist1
        {
            color: black;
            font-size: large;
        }
    </style>
    <script src="../js/jquery-1.7.1.min.js"></script>
    <%--<script type="text/javascript">
          $(document).ready(function () {
            
              //$("#VehiclSpecfctn_nextbtn").on("click", function (event) {
              //    $('#div100').css('display', 'none');
              //    $('#div101').css('display', 'block');
              //    $('#div102').css('display', 'none');
              //    $('#div103').css('display', 'none');
              //    $('#div104').css('display', 'none');                
              //});
           
              $("#img2").on("click", function (event) {
                  $('#div100').css('display', 'none');
                  $('#div101').css('display', 'none');
                  $('#div102').css('display', 'block');
                  $('#div103').css('display', 'none');
                  $('#div104').css('display', 'none');              
              });
              $("#img3").on("click", function (event) {
                  $('#div100').css('display', 'none');
                  $('#div101').css('display', 'none');
                  $('#div102').css('display', 'none');
                  $('#div103').css('display', 'block');
                  $('#div104').css('display', 'none');

              });
              $("#img4").on("click", function (event) {
                  $('#div100').css('display', 'none');
                  $('#div101').css('display', 'none');
                  $('#div102').css('display', 'none');
                  $('#div103').css('display', 'none');
                  $('#div104').css('display', 'block');

              });
          });
</script>--%>
</head>
<body>

    <form id="form1" runat="server">

        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
        <%-- <asp:scriptmanager ID="Scriptmanager1" runat="server"></asp:scriptmanager>--%>
        <!-- HEADER -->

        <div class="row headerxxaa" style="position: absolute;">
            <div class="header-wrapper">
                <div class="container">
                    <div class="row">

                        <!-- Logo -->
                        <div class="span4">
                            <div class="logo">
                                <a href="index.html">
                                    <img src="../images/logo.png" alt="Logo" /></a>
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
                                        <%--<ul class="clearfix">
                                                <li><a href="#">Home 2</a></li>
                                                <li><a href="#">Home 3 </a></li>
                                            </ul>--%>
                                    </li>
                                    <li><a href="AppraisalForm.aspx">Get Your Offer</a>
                                        <%--<ul class="clearfix">
                                                <li><a href="#">Travel Grid</a></li>
                                                <li><a href="#">Travel list</a></li>
                                                <li><a href="#">Travel Detail</a></li>
                                            </ul>--%>
                                    </li>
                                    <li><a href="#">Consignment</a></li>
                                    <li>
                                        <a href="#">Car Locator</a>
                                        <%--<ul class="clearfix">
                                                <li><a href="#">Financing</a></li>
                                                <li><a href="#">Notebook </a></li>
                                                <li><a href="#">Tablet </a> </li>
                                                <li><a href="#">Television </a> </li>
                                                <li><a href="#">Smart Phone </a> </li>
                                                <li><a href="#">Projection </a> </li>
                                            </ul>--%>
                                    </li>
                                    <li><a href="#">Shipping</a></li>
                                    <li><a href="#">Financing</a></li>
                                    <li><a href="#">Price Guarantee</a></li>
                                    <li><a href="#">Inventory</a></li>
                                    <li><a href="#">About Us</a></li>
                                    <%--<li><a href="booking.html">Booking</a>--%>
                                    <%--<ul class="clearfix">
                                                <li><a href="confirm.html">Confirmation</a></li>
                                            </ul>
                                        </li>
                                        <li  class="last"><a href="contact.html">Contact</a></li>--%>
                                </ul>
                            </nav>

                            <div class="responsive_nav">
                                <ul>
                                    <li class="open">
                                        <a href="#">HOME</a>
                                        <ul>
                                            <li><a href="#">Home </a></li>
                                            <li><a href="#">Hotels</a></li>
                                            <li><a href="#">Holidays</a></li>
                                            <li><a href="#">Flights</a> </li>
                                            <li><a href="#">Camera</a></li>
                                            <li><a href="#">Notebook </a></li>
                                            <li><a href="#">Tablet </a></li>
                                            <li><a href="#">Television </a></li>
                                            <li><a href="#">Smart Phone </a></li>
                                            <li><a href="#">Projection </a></li>
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
            </div>
        </div>
        <!-- Main Navigation -->
        <%--<asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server"></asp:View>
            <asp:View ID="View2" runat="server"></asp:View>
            <asp:View ID="View3" runat="server"></asp:View>
            <asp:View ID="View4" runat="server"></asp:View>

        </asp:MultiView>--%>

        <!-- Slider -->
        <!-- Slider -->

        <!-- Special Offer -->
        <div class="specialoffer-wrapper innercontantsree" style="background: rgb(232, 237, 241)">
            <div class="container">
                <div id="horizontalTab">

                    <!-- DIV 1 -->
                    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="3">
                        <asp:View ID="View1" runat="server">
                            <div class="container  maindiv " id="div100" style="display: block; background: white;">
                                <%--<img style="width:100%" src="" />--%>

                                <img src="../images/Images/24%20copy.png" style="padding-top: 10px; width: 100%" />
                                <div class="col-lg-12" style="margin-top: 3%">
                                    <p style="color: black; width: 85%; margin-left: 8%; text-align: justify;">
                                        We have queried our database and found your vehicle's year, make and model. Please review and confirm the detailed information below to continue. The vehicle stock photo shown is for illustration purposes only, and does not necessarily reflect your vehicles actual color, trim, features or options.
                                    </p>
                                </div>
                                <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                                    <ContentTemplate>
                                        <div class="col-lg-12" style="float: left; margin-top: 2%;">
                                            <div class="col-lg-6" style="margin-top: 1%; margin-left: 10%">
                                                <div class="col-lg-3">
                                                    <label id="vin_lb" runat="server">VIN</label>
                                                </div>

                                                <div class="col-lg-9">
                                                    <asp:Label ID="vin_txb" runat="server" CssClass="lbll"></asp:Label>
                                                    <%--<input type="text" id="vin_txb" class="form-control" runat="server" />--%>
                                                </div>
                                            </div>


                                            <div class="col-lg-6" style="margin-top: 1%; margin-left: 10%">
                                                <div class="col-lg-3">
                                                    <label for="inputEmail">Year</label>
                                                </div>

                                                <div class="col-lg-9">
                                                    <%--<input type="text" class="form-control" runat="server" id="Year_txt" onkeypress="return NumberOnly(event)" required />--%>
                                                    <asp:Label ID="Year_txt" runat="server" CssClass="lbll"></asp:Label>
                                                </div>

                                            </div>

                                            <div class="col-lg-6" style="margin-top: 1%; margin-left: 10%">
                                                <div class="col-lg-3">
                                                    <label for="inputEmail">Make</label>
                                                </div>

                                                <div class="col-lg-9">
                                                    <%--<input type="text" class="form-control" runat="server" id="Make_txt" required />--%>
                                                    <asp:Label ID="Make_txt" runat="server" CssClass="lbll"></asp:Label>
                                                </div>
                                            </div>


                                            <div class="col-lg-6" style="margin-top: 1%; margin-left: 10%">
                                                <div class="col-lg-3">
                                                    <label for="inputEmail">Model</label>
                                                </div>

                                                <div class="col-lg-9">
                                                    <%--<input type="text" class="form-control" runat="server" id="Model_txt" required />--%>
                                                    <asp:Label ID="Model_txt" runat="server" CssClass="lbll"></asp:Label>
                                                </div>
                                                <%--<img src="../images/Images/6%201copy.png" style="width: 5%; margin-top: 0%; margin-left: -3%;" />--%>
                                            </div>


                                            <div class="col-lg-6" style="margin-top: 1%; margin-left: 10%">
                                                <div class="col-lg-3">
                                                    <label for="inputEmail">Style</label>
                                                </div>

                                                <div class="col-lg-9">
                                                    
                                                    <%--<input type="text" class="form-control" runat="server" style="width: 75%;" id="Style_txt" required />--%>
                                                   <asp:Label ID="Style_txt" runat="server" CssClass="lbll"></asp:Label>
                                                </div>
                                                <%--<a href="#" class="tooltips" tabindex="1">
                                                    <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -19%;" />
                                                    <span style="width: 150px;">Please enter your Vehicle style.</span>
                                                </a>--%>
                                            </div>

                                             <div class="col-lg-6" style="margin-top: 1%; margin-left: 10%">
                                                <div class="col-lg-3">
                                                    <label for="inputEmail">Trim/Style</label>
                                                </div>

                                                <div class="col-lg-9">
                                                   <%-- <input id="Text4" type="text" Style="width: 75%;" CssClass="form-control" runat="server" required/>--%>
                                                    <asp:DropDownList ID="Drop_Trim_style" runat="server" Style="width: 100%;"
                                                         CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="Drop_Trim_style_SelectedIndexChanged">
                                                        </asp:DropDownList><asp:RequiredFieldValidator InitialValue="0" ID="Req_Dropdown" Display="Dynamic"
                                                        ValidationGroup="a1" runat="server" ControlToValidate="Drop_Trim_style"
                                                        ErrorMessage=" *Please Select Option"></asp:RequiredFieldValidator>
                                                </div>
                                               <%-- <img src="../images/Images/6%201copy.png" style="width: 5%; margin-top: 0%; margin-left: -3%;" />--%>
                                            </div>

                                            <div class="col-lg-6" style="margin-top: 1%; margin-left: 10%">
                                                <div class="col-lg-3">
                                                    <label for="inputEmail">Series</label>
                                                </div>

                                                <div class="col-lg-9">
                                                    
                                                    <asp:Label ID="Series_txt" runat="server" CssClass="lbll"></asp:Label>
                                                    <%--<input id="Series_txt" type="text" style="width: 75%;" class="form-control" runat="server" required />--%>
                                                </div>
                                                <%--<a href="#" class="tooltips" tabindex="1">
                                                    <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -19%;" />
                                                    <span style="width: 150px;">Please enter your Vehicle Series.</span>
                                                </a>--%>
                                            </div>


                                            <div class="col-lg-6" style="margin-top: 1%; margin-left: 10%">
                                                <div class="col-lg-3">
                                                    <label for="inputEmail">Transmission</label>
                                                </div>

                                                <div class="col-lg-9">
                                                    
                                                    <asp:Label ID="Transmsn_txt" runat="server" CssClass="lbll"></asp:Label>
                                                    <%--<input id="Transmsn_txt" type="text" style="width: 75%;" class="form-control" runat="server" required />--%>
                                                </div>
                                               <%-- <a href="#" class="tooltips" tabindex="1">
                                                    <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -19%;" />
                                                    <span style="width: 150px;">Please enter your Vehicle Transmission.</span></a>--%>
                                            </div>

                                            <div class="col-lg-6" style="margin-top: 1%; margin-left: 10%">
                                                <div class="col-lg-3">
                                                    <label for="inputEmail">Engine</label>
                                                </div>

                                                <div class="col-lg-9">
                                                   
                                                    <asp:Label ID="Engine_txt" runat="server" CssClass="lbll"></asp:Label>
                                                    <%--<input id="Engine_txt" type="text" style="width: 75%;" class="form-control" runat="server" required />--%>
                                                </div>
                                                <%--<a href="#" class="tooltips" tabindex="1">
                                                    <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -19%;" />
                                                    <span style="width: 150px;">Please enter your Vehicle Engine.</span></a>--%>
                                            </div>

                                            <div class="col-lg-4" style="margin-top: -21%; margin-left: 2%;">
                                                <asp:Image ID="Fullimage" runat="server" Style="width: 100%;" />
                                                <%--<img src="../images/car.jpg" width="100%" />--%>
                                            </div>

                                        </div>
                                    </ContentTemplate>
                                </asp:UpdatePanel>


                                <div class="col-lg-6" style="margin-top: 2%;">
                                    <div class="col-lg-3"></div>
                                    <div class="col-lg-8">
                                        <%--<asp:ImageButton ID="VehiclSpecfctn_resetbtn" runat="server" ImageUrl="../images/Images/4%20copy.png" style="width:45%" OnClick="VehiclSpecfctn_resetbtn_Click" />  --%>
                                        <a href="Index.aspx">
                                            <img style="width: 45%; margin-top: 11%; margin-left: -20%;" src="../images/Images/4%20copy.png" /></a>
                                    </div>
                                </div>

                                <div class="col-lg-6" style="margin-top: 2%;">
                                    <div class="col-lg-3">
                                    </div>
                                    <div class="col-lg-8">
                                        <%--<img style="float:right;width:45%;" src="../images/next.png" id="img1" /> --%>
                                        <asp:ImageButton ID="VehiclSpecfctn_nextbtn" runat="server" ImageUrl="../images/Images/5%20copy.png" Style="float: right; width: 45%; margin-bottom: 95px; margin-right: 0px; margin-top: 14%;" OnClick="VehiclSpecfctn_nextbtn_Click" ValidationGroup="a1" />
                                    </div>
                                </div>

                                <div class="container">
                                    <div class="span12">
                                    </div>
                                </div>

                            </div>
                        </asp:View>

                        <!-- DIV 1 -->

                        <!-- DIV 2-->
                        <asp:View ID="View2" runat="server">
                            <div class="container  maindiv" id="div101" style="display: block; background: white;">
                                <img style="padding-top: 10px; width: 100%" src="../images/Images/7%20copy.png" />
                                <div class="col-lg-12">
                                    <p style="color: black; width: 90%; text-align: justify; margin-left: 3%; margin-top: 1%;">Once we have appraised your vehicle you will receive a free no obligation offer via email. Our offer will be in writing and good for 7 days from today, allowing you plenty of time to think it over before accepting our offer and selling us your vehicle. Please complete the information below.</p>
                                </div>
                                <div class="col-lg-12" style="margin-top: 2%;">
                                    <h3 style="color: #161816; margin-left: 3%;">Owner Information</h3>
                                </div>
                                <div class="col-lg-12" style="margin-top: 3%;">
                                    <div class="col-lg-6" style="margin-top: 1%;">
                                        <div class="col-lg-3">
                                            <label for="inputEmail">First name</label>
                                        </div>
                                        <div class="col-lg-8">
                                            <input type="text" class="form-control" runat="server" id="FirstN_txt" placeholder="First Name" required />
                                        </div>
                                        <a href="#" class="tooltips" tabindex="1">
                                            <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -2%;" />
                                            <span style="width: 210px;">Please enter your first name.</span>
                                        </a>
                                    </div>


                                    <div class="col-lg-6" style="margin-top: 1%;">
                                        <div class="col-lg-3">
                                            <label for="inputEmail">Last name</label>
                                        </div>
                                        <div class="col-lg-8">
                                            <input type="text" class="form-control" id="LastN_txt" placeholder="Last name" runat="server" required />
                                        </div>
                                        <a href="#" class="tooltips" tabindex="1">
                                            <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -2%;" />
                                            <span style="width: 150px;">Please enter your last name.</span>
                                        </a>
                                        <br />

                                    </div>

                                    <div class="col-lg-6" style="margin-top: 1%;">
                                        <div class="col-lg-3">
                                            <label for="inputEmail">Your Email</label>
                                        </div>


                                        <div class="col-lg-8">
                                            <input type="text" class="form-control" id="Email_txt" placeholder="Email" runat="server" required /><asp:RegularExpressionValidator
                                                ID="RegularExpressionValidator2" runat="server" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="Email_txt" ErrorMessage=" Input valid email address !" />
                                        </div>
                                        <a href="#" class="tooltips" tabindex="1">
                                            <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -2%;" />
                                            <span style="width: 235px;">Please enter your email address.</span>
                                        </a>
                                    </div>

                                    <div class="col-lg-6" style="margin-top: 1%;">
                                        <div class="col-lg-3">
                                            <label for="inputEmail">Confirm Email</label>
                                        </div>

                                        <div class="col-lg-8">
                                            <input type="text" autocomplete="off" class="form-control" id="ConfirmE_txt" placeholder="Email" runat="server" required />
                                            <asp:CompareValidator runat="server" ID="CompareValidator1" ControlToValidate="ConfirmE_txt" ControlToCompare="Email_txt" ErrorMessage=" * Email doesnot Match !" />
                                        </div>
                                        <a href="#" class="tooltips" tabindex="1">
                                            <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -2%;" />
                                            <span style="width: 150px;">Please confirm your email address.</span>
                                        </a>
                                    </div>

                                    <div class="col-lg-6" style="margin-top: 1%;">
                                        <div class="col-lg-3">
                                            <label for="inputEmail" style="margin-top: -4%">Zip Code</label>
                                        </div>

                                        <div class="col-lg-8">
                                            <input type="text" class="form-control" id="Zipcode_txt" placeholder="Zip Code" style="margin-top: -3%;" runat="server" onkeypress="return NumberOnly(event)" required />
                                        </div>
                                        <a href="#" class="tooltips" tabindex="1">
                                            <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 0%; margin-left: -2%;" />
                                            <span style="width: 200px;">Please enter your Zip code.</span>
                                        </a>
                                    </div>

                                    <div class="col-lg-6" style="margin-top: 1%;">
                                        <div class="col-lg-3">
                                            <label for="inputEmail">Telephone</label>
                                        </div>

                                        <div class="col-lg-8">
                                            <input type="text" class="form-control" id="Telephn_txt" placeholder="Telephone" style="margin-top: -3%;" runat="server" onkeypress="return NumberOnly(event)" required />
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                                                ErrorMessage=" * Numbers Only" ForeColor="Red" ControlToValidate="Telephn_txt"
                                                ValidationExpression="^[0-9]*"></asp:RegularExpressionValidator>
                                        </div>
                                        <a href="#" class="tooltips" tabindex="1">
                                            <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 0%; margin-left: -2%;" />
                                            <span style="width: 140px;">Please enter your telephone number.</span>
                                        </a>
                                    </div>

                                </div>


                                <div style="width: 100%; margin-top: 16%;">
                                    <h3 style="color: #161816; margin-left: 4%;">Additional Information </h3>
                                </div>

                                <div class="col-lg-12" style="margin-top: 4%;">
                                    <div class="col-lg-6" style="margin-top: 1%;">
                                        <div class="col-lg-8">
                                            <label for="inputEmail">In what state is your vehicle registered?</label>
                                        </div>
                                    </div>


                                    <div class="col-lg-6" style="margin-top: 1%;">
                                        <div class="col-lg-3"></div>
                                        <div class="col-lg-8">
                                            <asp:DropDownList ID="Drop_state_registrtd" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" CssClass="form-control">
                                                <asp:ListItem Text=" Please Select" Value="-1" style="text-align: center"></asp:ListItem>
                                                <asp:ListItem Text=" Alaska " Value="1"></asp:ListItem>
                                                <asp:ListItem Text=" Arizona " Value="2"></asp:ListItem>
                                                <asp:ListItem Text=" Arkansas " Value="3"></asp:ListItem>
                                                <asp:ListItem Text=" Alabama " Value="4"></asp:ListItem>
                                                <asp:ListItem Text=" California " Value="5"></asp:ListItem>
                                                <asp:ListItem Text=" Colorado " Value="6"></asp:ListItem>
                                                <asp:ListItem Text=" Connecticut " Value="7"></asp:ListItem>
                                                <asp:ListItem Text=" Delaware " Value="8"></asp:ListItem>
                                                <asp:ListItem Text=" District of Columbia " Value="9"></asp:ListItem>
                                                <asp:ListItem Text=" Florida " Value="10"></asp:ListItem>
                                                <asp:ListItem Text=" Georgia " Value="11"></asp:ListItem>
                                                <asp:ListItem Text=" Hawaii " Value="12"></asp:ListItem>
                                                <asp:ListItem Text=" Idaho " Value="13"></asp:ListItem>
                                                <asp:ListItem Text=" Illinois " Value="14"></asp:ListItem>
                                                <asp:ListItem Text=" Indiana " Value="15"></asp:ListItem>
                                                <asp:ListItem Text=" Iowa " Value="16"></asp:ListItem>
                                                <asp:ListItem Text=" Kansas " Value="17"></asp:ListItem>
                                                <asp:ListItem Text=" Kentucky " Value="18"></asp:ListItem>
                                                <asp:ListItem Text=" Louisiana " Value="19"></asp:ListItem>
                                                <asp:ListItem Text=" Maine " Value="20"></asp:ListItem>
                                                <asp:ListItem Text=" Maryland " Value="21"></asp:ListItem>
                                                <asp:ListItem Text=" Massachusetts " Value="22"></asp:ListItem>
                                                <asp:ListItem Text=" Michigan " Value="23"></asp:ListItem>
                                                <asp:ListItem Text=" Minnesato " Value="24"></asp:ListItem>
                                                <asp:ListItem Text=" Mississippi " Value="25"></asp:ListItem>
                                                <asp:ListItem Text=" Missouri " Value="26"></asp:ListItem>
                                                <asp:ListItem Text=" Montana " Value="27"></asp:ListItem>
                                                <asp:ListItem Text=" Nebraska " Value="28"></asp:ListItem>
                                                <asp:ListItem Text=" Nevada " Value="29"></asp:ListItem>
                                                <asp:ListItem Text=" New Hampshire " Value="30"></asp:ListItem>
                                                <asp:ListItem Text=" New Jersey " Value="31"></asp:ListItem>
                                                <asp:ListItem Text=" New Mexico " Value="32"></asp:ListItem>
                                                <asp:ListItem Text=" New York " Value="33"></asp:ListItem>
                                                <asp:ListItem Text=" North California " Value="34"></asp:ListItem>
                                                <asp:ListItem Text=" North Dakota " Value="35"></asp:ListItem>
                                                <asp:ListItem Text=" Ohio " Value="36"></asp:ListItem>
                                                <asp:ListItem Text=" Oklahoma " Value="37"></asp:ListItem>
                                                <asp:ListItem Text=" Oregon " Value="38"></asp:ListItem>
                                                <asp:ListItem Text=" Palau " Value="39"></asp:ListItem>
                                                <asp:ListItem Text=" PenssyIvania " Value="40"></asp:ListItem>
                                                <asp:ListItem Text=" Rhode Island " Value="41"></asp:ListItem>
                                                <asp:ListItem Text=" South Carolina " Value="42"></asp:ListItem>
                                                <asp:ListItem Text=" South Dakota " Value="43"></asp:ListItem>
                                                <asp:ListItem Text=" Tennessee " Value="44"></asp:ListItem>
                                                <asp:ListItem Text=" Texas " Value="45"></asp:ListItem>
                                                <asp:ListItem Text=" Utah " Value="46"></asp:ListItem>
                                                <asp:ListItem Text=" Vermount " Value="47"></asp:ListItem>
                                                <asp:ListItem Text=" Virginia " Value="48"></asp:ListItem>
                                                <asp:ListItem Text=" Washington " Value="49"></asp:ListItem>
                                                <asp:ListItem Text=" West Virginia " Value="50"></asp:ListItem>
                                                <asp:ListItem Text=" Wisconsin " Value="51"></asp:ListItem>
                                                <asp:ListItem Text=" Wyoming " Value="52"></asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator InitialValue="-1" ID="Req_Dropdown2" Display="Dynamic" ValidationGroup="a" runat="server" ControlToValidate="Drop_state_registrtd" ErrorMessage=" *Please Select Option"></asp:RequiredFieldValidator>
                                        </div>
                                        <a href="#" class="tooltips" tabindex="1">
                                            <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -2%;" />
                                            <span style="width: 155px;">Select which state  your vehicle  is currently registered.</span>
                                        </a>
                                    </div>
                                    <%--<img src="../images/Images/6%201copy.png" style="width: 5%;margin-top: -2%;margin-left: -3%;" />--%>
                                </div>
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                                    <ContentTemplate>
                                        <div class="col-lg-12">
                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-10">
                                                    <label for="inputEmail">Are you currently leasing or financing this vehicle?</label>
                                                </div>
                                            </div>
                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-3"></div>
                                                <div class="col-lg-8">
                                                    <asp:DropDownList ID="Drop_Leasing_financing" CssClass="form-control" runat="server" AutoPostBack="true" OnSelectedIndexChanged="Drop_Leasing_financing_SelectedIndexChanged">
                                                        <asp:ListItem Text=" Please Select " Value="-1" style="text-align: center"></asp:ListItem>
                                                        <asp:ListItem Text=" Yes I'm Financing " Value="0"></asp:ListItem>
                                                        <asp:ListItem Text=" Yes I'm Leasing " Value="1"></asp:ListItem>
                                                        <asp:ListItem Text=" No my vehicle is paid off " Value="2"></asp:ListItem>
                                                    </asp:DropDownList>
                                                    <asp:RequiredFieldValidator InitialValue="-1" ID="Req_Dropdown3" Display="Dynamic" ValidationGroup="a" runat="server" ControlToValidate="Drop_Leasing_financing" ErrorMessage=" * Please Select Option"></asp:RequiredFieldValidator>
                                                </div>
                                                <a href="#" class="tooltips" tabindex="1">
                                                    <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -2%;" />
                                                    <span style="width: 155px;">Let us know you are currently financing ,leasing or if your vehicle is paid off and lien free.</span>
                                                </a>
                                            </div>
                                        </div>

                                        <br />
                                        <br />
                                        <%--<asp:UpdatePanel ID="updatePannel2" runat="server" UpdateMode="Conditional"><ContentTemplate>--%>

                                        <div class="col-lg-12" runat="server" id="div_hidden_Financing" visible="false">
                                            <div class="col-lg-12">
                                                <p style="border-width: 1px; color: black; border-style: solid; border-color: darkgray; width: 92%; text-align: justify; padding-left: 3px; padding-right: 3px; margin-top: 6%; margin-left: 2%; margin-bottom: 1%;">
                                                    The Caroffer.com will be glad to buy your vehicle with a lien outstanding; you will simply need to provide us with the lienholder information and estimated pay-off amount.
We will take care of the rest; we will pay off your lender and deduct that pay-off amount from the appraisal amount and pay you the remainder.
                                                </p>
                                            </div>


                                            <div class="col-lg-12">
                                                <div class="col-lg-6" style="margin-top: 1%;">
                                                    <div class="col-lg-1">
                                                        <img src="../images/Images/h.png" style="width: 100%;" />
                                                    </div>
                                                    <div class="col-lg-8">

                                                        <label for="inputEmail" style="margin-left: 2%;">Bank,Lienholder or Financing Company name: </label>
                                                    </div>
                                                </div>


                                                <div class="col-lg-6" style="margin-top: 1%;">
                                                    <div class="col-lg-3"></div>
                                                    <div class="col-lg-8">
                                                        <%--<img src="../images/Images/h.png" style="width:100%;"  /> --%>
                                                        <input name="text1" type="text" runat="server" style="margin-left: 1%; width: 104%;"
                                                            id="Financing_Company_HTxt" class="form-control" placeholder="Compny Name" required />
                                                    </div>
                                                    <a href="#" class="tooltips" tabindex="1">
                                                        <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: 1%;" />
                                                        <span style="width: 150px;">Please provide the name of the Bank,Credit Union,or Company Financing your vehicle.</span>
                                                    </a>
                                                </div>
                                            </div>

                                            <div class="col-lg-12">
                                                <div class="col-lg-6" style="margin-top: 1%;">
                                                    <div class="col-lg-1">
                                                        <img src="../images/Images/h.png" style="width: 100%;" />
                                                    </div>
                                                    <div class="col-lg-8">
                                                        <%--<img src="../images/Images/h.png" style="width:100%;"  /> --%>
                                                        <label for="inputEmail" style="margin-left: 2%;">What is the estimated lien-pay off amount or balance due ? </label>
                                                    </div>
                                                </div>


                                                <div class="col-lg-6" style="margin-top: 1%;">
                                                    <div class="col-lg-3"></div>
                                                    <div class="col-lg-8">
                                                        <input name="text1" type="text" runat="server" id="Estimated_Financing_HTxt"
                                                            class="form-control" style="margin-left: 1%; width: 104%;"
                                                            onkeypress="return NumberOnly(event)" onchange="toUSD(this);" required />
                                                    </div>
                                                    <a href="#" class="tooltips" tabindex="1">
                                                        <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: 1%;" />
                                                        <span style="width: 155px;">Please enter the lienholder pay-off amount or what you have to pay 
                                                            to satisfy a lien outstanding on the Vehicle.You can estimate if not exactly sure.</span>
                                                    </a>
                                                </div>
                                            </div>
                                        </div>


                                        <br />
                                        <br />
                                        <asp:UpdatePanel ID="updatePannel2" runat="server" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="col-lg-12" runat="server" id="Drop_Leasing_leasing" visible="false">

                                                    <div class="col-lg-12">


                                                        <p style="border-width: 1px; color: black; border-style: solid; border-color: darkgray; width: 92%; text-align: justify; padding-left: 6px; padding-right: 3px; margin-top: 3%; margin-left: 2%; margin-bottom: 1%;">
                                                            The CarOffer.com will be glad to buy your leased vehicle; you will simply need to provide us with the leasing company information and estimated pay-off amount. We will take care of the rest. We will pay off your leasing company and deduct that pay-off amount from the appraisal amount and pay you the remainder. Should there be negative equity, we will be happy to discuss your options after we have received your submission.
                                                        </p>

                                                    </div>



                                                    <div class="col-lg-12">

                                                        <div class="col-lg-6" style="margin-top: 1%;">
                                                            <div class="col-lg-1">
                                                                <img src="../images/Images/h.png" style="width: 100%;" />
                                                            </div>
                                                            <div class="col-lg-8">
                                                                <label for="inputEmail" style="margin-left: 2%;">Bank,Lienholder or Leasing Company name: </label>
                                                            </div>
                                                        </div>


                                                        <div class="col-lg-6" style="margin-top: 1%;">
                                                            <div class="col-lg-3"></div>
                                                            <div class="col-lg-8">
                                                                <%--style="margin-left: 1%"--%>
                                                                <input name="text1" type="text" runat="server" id="Leasing_CompnyName_Htxt" class="form-control" style="margin-left: 1%; width: 104%" placeholder="Compny Name" required />
                                                            </div>
                                                            <a href="#" class="tooltips" tabindex="1">
                                                                <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: 1%;" />
                                                                <span style="width: 155px;">Please provide the name of Leasing company</span>
                                                            </a>
                                                        </div>
                                                    </div>

                                                    <div class="col-lg-12">

                                                        <div class="col-lg-6" style="margin-top: 1%;">
                                                            <div class="col-lg-1">
                                                                <img src="../images/Images/h.png" style="width: 100%;" />
                                                            </div>
                                                            <div class="col-lg-8">
                                                                <label for="inputEmail" style="margin-left: 2%;">What is the estimated lien-pay off amount or balance due ? </label>
                                                            </div>
                                                        </div>


                                                        <div class="col-lg-6" style="margin-top: 1%;">
                                                            <div class="col-lg-3"></div>
                                                            <div class="col-lg-8">
                                                                <input name="text1" type="text" runat="server"
                                                                    id="Estimated_Payoff_Leased_Htxt" class="form-control"
                                                                    style="margin-left: 1%; width: 104%;"
                                                                    onkeypress="return NumberOnly(event)" onchange="toUSD(this);" required />
                                                            </div>
                                                            <a href="#" class="tooltips" tabindex="1">
                                                                <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: 1%;" />
                                                                <span style="width: 155px;">Please enter the lienholder pay-off amount or what you have
                                                                     to pay to satisfy a lien outstanding on the Vehicle.
                                                                    You can estimate if not exactly sure.</span>
                                                            </a>
                                                        </div>
                                                    </div>
                                                </div>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </ContentTemplate>
                                </asp:UpdatePanel>

                                <div class="col-lg-12">
                                    <div class="col-lg-6" style="margin-top: 1%;">
                                        <div class="col-lg-8">
                                            <label for="inputEmail">How did you hear about us?</label>
                                        </div>
                                    </div>
                                    <div class="col-lg-6" style="margin-top: 1%;">
                                        <div class="col-lg-3"></div>
                                        <div class="col-lg-8">
                                            <asp:DropDownList ID="Drop_HearAbout" CssClass="form-control" runat="server">
                                                <asp:ListItem Text=" Please Select " Value="-1" style="text-align: center"></asp:ListItem>
                                                <asp:ListItem Text=" Drive By " Value="0"></asp:ListItem>
                                                <asp:ListItem Text=" My Local Dealer " Value="1"></asp:ListItem>
                                                <asp:ListItem Text=" Magazine Ad " Value="2"></asp:ListItem>
                                                <asp:ListItem Text=" Newspaper " Value="3"></asp:ListItem>
                                                <asp:ListItem Text=" Website " Value="4"></asp:ListItem>
                                                <asp:ListItem Text=" Family or Friend " Value="5"></asp:ListItem>
                                                <asp:ListItem Text=" Google " Value="6"></asp:ListItem>
                                                <asp:ListItem Text=" Billboard " Value="7"></asp:ListItem>
                                                <asp:ListItem Text=" Radio " Value="8"></asp:ListItem>
                                                <asp:ListItem Text=" other " Value="9"></asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator InitialValue="-1" ID="RequiredFieldValidator1" Display="Dynamic" ValidationGroup="a" runat="server" ControlToValidate="Drop_HearAbout" ErrorMessage=" * Please Select Option"></asp:RequiredFieldValidator>
                                        </div>
                                        <a href="#" class="tooltips" tabindex="1">
                                            <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -2%;" />
                                            <span style="width: 170px;">Your selection helps keep The CarOffer.com successful by letting us know the best way to reach clients just like you!Please let us know how you originally heared about us.</span>
                                        </a>
                                    </div>

                                </div>

                                <div class="col-lg-12" style="margin-top: 15%;">
                                    <div class="col-lg-3"></div>
                                    <div class="col-lg-6">
                                        <label for="inputEmail">Is there an amount that you are expecting to get for this vehicle? </label>
                                        <br />
                                        <br />
                                        <div class="form-group">
                                            <div class="input-group">
                                                <span class="input-group-addon">$</span>
                                                <input type="text" style="width: 78%; height: 62px;" onchange="toUSD(this);" class="form-control" id="Amount_Expected_Txt" runat="server" onkeypress="return NumberOnly(event)" title="If there is an amount that you expect to get for this vehicle please  enter it here.There is not required information,feel free to skip thhis question" />
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <div class="col-lg-6">
                                    <div class="col-lg-3"></div>
                                    <div class="col-lg-8">
                                        <a href="Index.aspx" runat="server" id="vehicle_ownerBack_anchorbtn">
                                            <img style="width: 45%; margin-left: -35%; padding-bottom: 20px; margin-top: 15%;" src="../images/Images/4%20copy.png" /></a>                                 <%--<img style="width:45%" src="../images/restart.png" />--%>
                                    </div>

                                </div>

                                <div class="col-lg-6">
                                    <div class="col-lg-3">
                                    </div>
                                    <div class="col-lg-8">
                                        <%-- <img style="float:right;width:45%" src="../images/next.png" id="img2"/>--%>
                                        <asp:ImageButton ID="vehcl_Owner_next" Style="float: right; width: 45%; margin-top: 15%; margin-right: 7%; margin-bottom: 35%;" runat="server" ImageUrl="../images/Images/5%20copy.png" OnClick="vehcl_Owner_next_Click" ValidationGroup="a" />
                                        <asp:ImageButton ID="vehcl_Owner_Update_btn" runat="server" Style="float: right; width: 45%; margin-right: 7%; margin-top: 15%; margin-bottom: 35%;" ImageUrl="../images/Images/2.png" OnClick="vehcl_Owner_Update_btn_Click1" Visible="false" />
                                    </div>
                                </div>
                                <%--</div>--%>
                            </div>
                        </asp:View>
                        <!-- DIV 2-->

                        <!-- DIV 3-->
                        <asp:View ID="View3" runat="server">
                            <div class="container  maindiv " runat="server" id="div102" style="display: block; background: white;">
                                <img src="../images/Images/8%20copy.png" style="width: 100%; padding-top: 6px;" />
                                <%--<img style="width:100%" src="../images/bar1.png" />--%>

                                <div class="col-lg-12" style="margin-top: 3%">
                                    <p style="color: black; width: 78%; margin-left: 3%; text-align: justify;">Please tell us a little bit more about your vehicle and be as accurate as possible when filling in the required information below. This is critical to get the best and most accurate appraisal offer from us. </p>
                                    <br />
                                    <br />
                                </div>
                                <div class="col-lg-12">
                                    <div class="col-lg-6" style="margin-top: 1%;">
                                        <div class="col-lg-8">
                                            <label for="inputEmail">Current vehicle mileage (Miles)</label>
                                        </div>
                                    </div>
                                    <div class="col-lg-6" style="margin-top: 1%;">
                                        <div class="col-lg-8">
                                            <input type="text" class="form-control" id="Vehicle_Milage_txt" runat="server" onkeypress="return NumberOnly(event)" required />

                                        </div>
                                        <a href="#" class="tooltips" tabindex="2">
                                            <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -2%;" />
                                            <span style="width: 140px;">Please enter your vehicle current odometer reading.</span>
                                        </a>
                                    </div>


                                    <div class="col-lg-6" style="margin-top: 1%;">
                                        <div class="col-lg-10">
                                            <label for="inputEmail">Are the miles actual and accurate?</label>
                                        </div>
                                    </div>


                                    <div class="col-lg-6" style="margin-top: 1%;">
                                        <div class="col-lg-8">
                                            <asp:DropDownList ID="Miles_Actual_Acurate_DDL" runat="server" CssClass="form-control">
                                                <asp:ListItem Text=" Please Select " Value="-1"></asp:ListItem>
                                                <asp:ListItem Text="Yes" Value="0"></asp:ListItem>
                                                <asp:ListItem Text="No" Value="1"></asp:ListItem>
                                                <asp:ListItem Text="Not Sure" Value="2"></asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator InitialValue="-1" ID="RequiredFieldValidator3" Display="Dynamic" ValidationGroup="a" runat="server" ControlToValidate="Miles_Actual_Acurate_DDL" ErrorMessage=" * Please Select Option"></asp:RequiredFieldValidator>
                                        </div>
                                        <a href="#" class="tooltips" tabindex="2">
                                            <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -2%;" />
                                            <span style="width: 195px;">Please verify whether or not the mileage stated above is correct,actual & accurate.Yes-meaning the miles are actual and accurate.No-meaning the miles are not actual or accurate.Not sure-If you are not 100% sure.</span>
                                        </a>
                                    </div>
                                    <div class="col-lg-6" style="margin-top: 1%;">
                                        <div class="col-lg-10">
                                            <label for="inputEmail">Exterior color</label>
                                        </div>
                                    </div>


                                    <div class="col-lg-6" style="margin-top: 1%;">
                                        <div class="col-lg-8">
                                            <asp:DropDownList ID="ExteriorColor_DDL" runat="server" CssClass="form-control">
                                                <asp:ListItem Text=" Please Select " Value="-1"></asp:ListItem>
                                                <asp:ListItem Text="Autumn Red Mettallic/Pale Adobe Metallic" Value="0"></asp:ListItem>
                                                <asp:ListItem Text="Black/Pale Adobe Metallic" Value="1"></asp:ListItem>
                                                <asp:ListItem Text="Forest Green Metallic/Pale Adobe Mettalic" Value="2"></asp:ListItem>
                                                <asp:ListItem Text="Green Bronze Metallic/Pale Adobe Metallic" Value="3"></asp:ListItem>
                                                <asp:ListItem Text="Green Gem Metallic/Pale Adobe Metalic" Value="4"></asp:ListItem>
                                                <asp:ListItem Text="Oxform White/Pale Adobe Metalic" Value="5"></asp:ListItem>
                                                <asp:ListItem Text="White Platinum Metallic Tri Coat/Pale Adobe Metalic" Value="6"></asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator InitialValue="-1" ID="RequiredFieldValidator4" Display="Dynamic" ValidationGroup="a" runat="server" ControlToValidate="ExteriorColor_DDL" ErrorMessage=" * Please Select Option"></asp:RequiredFieldValidator>
                                        </div>
                                        <a href="#" class="tooltips" tabindex="2">
                                            <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -2%;" />
                                            <span style="width: 250px;">Please select the extrior color of your vehicle from the dropdown list.Use the color Key below as a guide<br />
                                                <caption style="text-align: end;">Color Key</caption>
                                                <table id="Table2" cellspacing="0" style="text-align: start;">
                                                    <tr style="width: 20px; height: 20px;">
                                                        <td style="background-color: #490d03; width: 10px; height: 10px;"></td>
                                                        <td>Autumn Red Metallic
                                                        </td>

                                                    </tr>
                                                    <tr>
                                                        <td style="background-color: #752106; width: 20px; height: 20px;"></td>
                                                        <td>Autumn Red Mettallic/Pale Adobe Metallic
                                                        </td>

                                                    </tr>
                                                    <tr>
                                                        <td style="background-color: black; width: 20px; height: 20px;"></td>
                                                        <td>Black
                                                        </td>

                                                    </tr>
                                                    <tr>
                                                        <td style="background-color: #100d0d; width: 20px; height: 20px;"></td>
                                                        <td>Black/Pale Adobe Metallic
                                                        </td>

                                                    </tr>
                                                    <tr>
                                                        <td style="background-color: #0d0909; width: 20px; height: 20px;"></td>
                                                        <td>Black/Sterling Grey
                                                        </td>

                                                    </tr>
                                                    <tr>
                                                        <td style="background-color: #263976; width: 20px; height: 20px;"></td>
                                                        <td>Dark Blue Pearl Metallic
                                                        </td>

                                                    </tr>
                                                    <tr>
                                                        <td style="background-color: #2a3698; width: 20px; height: 20px;"></td>
                                                        <td>Dark Blue Pearl Metallic/Sterling Grey
                                                        </td>

                                                    </tr>
                                                    <tr>
                                                        <td style="background-color: #184f38; width: 20px; height: 20px;"></td>
                                                        <td>Forest Green Metallic
                                                        </td>

                                                    </tr>
                                                    <tr>
                                                        <td style="background-color: #184f40; width: 20px; height: 20px;"></td>
                                                        <td>Forest Green Metallic/Pale Adobe Mettalic
                                                        </td>

                                                    </tr>
                                                    <tr>
                                                        <td style="background-color: #184f50; width: 20px; height: 20px;"></td>
                                                        <td>Forest Green Metallic/Sterling Grey
                                                        </td>

                                                    </tr>
                                                    <tr>
                                                        <td style="background-color: #753521; width: 20px; height: 20px;"></td>
                                                        <td>Golden Bronze Metallic
                                                        </td>

                                                    </tr>
                                                    <tr>
                                                        <td style="background-color: #522516; width: 20px; height: 20px;"></td>
                                                        <td>Golden Bronze Metallic/Pale Adobe Mettalic
                                                        </td>

                                                    </tr>
                                                    <tr>
                                                        <td style="background-color: #62705d; width: 20px; height: 20px;"></td>
                                                        <td>Green Gem Metallic
                                                        </td>

                                                    </tr>
                                                    <tr>
                                                        <td style="background-color: #5b6558; width: 20px; height: 20px;"></td>
                                                        <td>Green Gem Metallic/Pale Adobe Metalic
                                                        </td>

                                                    </tr>

                                                    <tr>
                                                        <td style="background-color: #3c6b5a; width: 75px; height: 5px;"></td>
                                                        <td>Green Gem Metallic/Sterling Grey
                                                        </td>

                                                    </tr>
                                                    <tr>
                                                        <td style="background-color: #c2c2c2; width: 75px; height: 5px;"></td>
                                                        <td>Ingot Silver Metallic
                                                        </td>

                                                    </tr>
                                                    <tr>
                                                        <td style="background-color: #a39c9c; width: 75px; height: 5px;"></td>
                                                        <td>Ingot Silver Metallic/Sterling Grey
                                                        </td>

                                                    </tr>
                                                    <tr>
                                                        <td style="background-color: #fff; width: 75px; height: 5px;"></td>
                                                        <td>Oxform White
                                                        </td>

                                                    </tr>
                                                    <tr>
                                                        <td style="background-color: #eee9e9; width: 75px; height: 5px;"></td>
                                                        <td>Oxform White/Pale Adobe Metalic
                                                        </td>

                                                    </tr>


                                                </table>
                                            </span>
                                        </a>
                                    </div>

                                    <div class="col-lg-6" style="margin-top: 1%;">
                                        <div class="col-lg-10">
                                            <label for="inputEmail">Interior color</label>
                                        </div>
                                    </div>


                                    <div class="col-lg-6" style="margin-top: 1%;">
                                        <div class="col-lg-8">
                                            <asp:DropDownList ID="InteriorColor_DDL" runat="server" CssClass="form-control">
                                                <asp:ListItem Text=" Please Select " Value="-1"></asp:ListItem>
                                                <asp:ListItem Text="Adobe" Value="0"></asp:ListItem>
                                                <asp:ListItem Text="Black" Value="1"></asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator InitialValue="-1" ID="RequiredFieldValidator5" Display="Dynamic" ValidationGroup="a" runat="server" ControlToValidate="InteriorColor_DDL" ErrorMessage=" * Please Select Option"></asp:RequiredFieldValidator>
                                        </div>
                                        <a href="#" class="tooltips" tabindex="2">
                                            <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -2%;" />
                                            <span style="width: 175px;">select the inteiror color of your vehicle from the dropdown list.<br />
                                                Use the color Key below as a guide.<br />
                                                <caption style="text-align: center;">Color Key</caption>
                                                <table id="Table1" cellspacing="0" style="width: 190px; height: 50px;">

                                                    <tr>
                                                        <td style="background-color: black; width: 20px; height: 20px;"></td>
                                                        <td>Black
                                                        </td>

                                                    </tr>
                                                    <tr>
                                                        <td style="background-color: #868D77; width: 20px; height: 20px;"></td>
                                                        <td>Adobe
                                                        </td>

                                                    </tr>
                                                </table>
                                            </span>
                                        </a>
                                    </div>

                                </div>
                                <asp:UpdatePanel ID="UpdatePanel3" UpdateMode="Conditional" runat="server">
                                    <ContentTemplate>
                                        <div class="col-lg-12">
                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-10">
                                                    <label for="inputEmail">Are you the original owner?</label>
                                                </div>
                                            </div>


                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-8">
                                                    <asp:DropDownList ID="OriginalOwner_DDL" runat="server" OnSelectedIndexChanged="OriginalOwner_DDL_SelectedIndexChanged" CssClass="form-control" AutoPostBack="true">
                                                        <asp:ListItem Text=" Please Select " Value="-1"></asp:ListItem>
                                                        <asp:ListItem Text="Yes" Value="0"></asp:ListItem>
                                                        <asp:ListItem Text="No" Value="1"></asp:ListItem>
                                                    </asp:DropDownList>
                                                    <asp:RequiredFieldValidator InitialValue="-1" ID="RequiredFieldValidator6" Display="Dynamic" ValidationGroup="a" runat="server" ControlToValidate="OriginalOwner_DDL" ErrorMessage=" * Please Select Option"></asp:RequiredFieldValidator>
                                                </div>
                                                <a href="#" class="tooltips" tabindex="2">
                                                    <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -2%;" />
                                                    <span style="width: 185px;">An original owner is the person that bought the vehicle new,not used.</span>
                                                </a>
                                            </div>

                                        </div>
                                        <%--//Hidden Owner--%>
                                        <div class="col-lg-12" runat="server" id="DivHidden_Owner" visible="false">
                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-10">
                                                    <img src="../images/Images/h.png" style="width: 14px; height: 14px; margin-left: 4%;" />
                                                    <label for="inputEmail" style="margin-left: 2%;">Have you owned the Vehicle in less that 90 days</label>
                                                </div>
                                            </div>
                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-8">
                                                    <asp:DropDownList ID="Owned_90_HiddenDDL" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="Owned_90_HiddenDDL_SelectedIndexChanged">
                                                        <asp:ListItem Text=" Please Select " Value="-1"></asp:ListItem>
                                                        <asp:ListItem Text="Yes" Value="0"></asp:ListItem>
                                                        <asp:ListItem Text="No" Value="1"></asp:ListItem>
                                                    </asp:DropDownList>
                                                    <asp:RequiredFieldValidator InitialValue="-1" ID="RequiredFieldValidator7" Display="Dynamic" ValidationGroup="a" runat="server" ControlToValidate="Owned_90_HiddenDDL" ErrorMessage=" * Please Select Option"></asp:RequiredFieldValidator>
                                                </div>
                                                <a href="#" class="tooltips" tabindex="2">
                                                    <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -2%;" />
                                                    <span style="width: 210px;">Let us know if you have purchased the vehicle in the last three months or less.</span>
                                                </a>
                                            </div>
                                        </div>

                                        <div class="col-lg-12" runat="server" id="div_Dealer_Hidden" visible="false">
                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-10">
                                                    <img src="../images/Images/h.png" style="width: 14px; height: 14px; margin-left: 4%;" />
                                                    <label for="inputEmail" style="margin-left: 2%;">Did you purchase from a dealer or individual ?</label>
                                                </div>
                                            </div>

                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-8">
                                                    <asp:DropDownList ID="Dealer_HiddenDDL" runat="server" CssClass="form-control">
                                                        <asp:ListItem Text=" Please Select " Value="-1"></asp:ListItem>
                                                        <asp:ListItem Text="Dealer" Value="0"></asp:ListItem>
                                                        <asp:ListItem Text="Individual" Value="1"></asp:ListItem>
                                                    </asp:DropDownList>
                                                    <asp:RequiredFieldValidator InitialValue="-1" ID="RequiredFieldValidator8" Display="Dynamic" ValidationGroup="a" runat="server" ControlToValidate="Dealer_HiddenDDL" ErrorMessage=" * Please Select Option"></asp:RequiredFieldValidator>
                                                </div>
                                                <a href="#" class="tooltips" tabindex="2">
                                                    <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -2%;" />
                                                    <span style="width: 200px;">Select whether you originally purchased the vehicle from an automobile dealer or individual.</span>
                                                </a>
                                            </div>
                                        </div>


                                        <%--</ContentTemplate></asp:UpdatePanel>--%>
                                        <%--//Hidden Owner--%>
                                        <%--<asp:UpdatePanel ID="UpdatePanel_service" UpdateMode="Conditional" runat="server"><ContentTemplate>--%>
                                        <div class="col-lg-12">
                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-10">
                                                    <label for="inputEmail">What service history records do you have?</label>
                                                </div>
                                            </div>


                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-8">
                                                    <asp:DropDownList ID="service_record_DDL" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="service_record_DDL_SelectedIndexChanged">
                                                        <asp:ListItem Text=" Please Select " Value="-1"></asp:ListItem>
                                                        <asp:ListItem Text="Full Records" Value="0"></asp:ListItem>
                                                        <asp:ListItem Text="Partial" Value="1"></asp:ListItem>
                                                        <asp:ListItem Text="No Records" Value="2"></asp:ListItem>
                                                    </asp:DropDownList>
                                                    <asp:RequiredFieldValidator InitialValue="-1" ID="RequiredFieldValidator9" Display="Dynamic" ValidationGroup="a" runat="server" ControlToValidate="service_record_DDL" ErrorMessage=" * Please Select Option"></asp:RequiredFieldValidator>
                                                </div>
                                                <a href="#" class="tooltips" tabindex="2">
                                                    <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -2%;" />
                                                    <span style="width: 175px;">we would like to know if you have any service records for your vehicle.</span>
                                                </a>
                                            </div>

                                        </div>
                                        <%--hidden records--%>
                                        <div class="col-lg-12" runat="server" id="div_Records_Hidden" visible="false">

                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-10">
                                                    <img src="../images/Images/h.png" style="width: 14px; height: 14px; margin-left: 4%;" />
                                                    <label for="inputEmail" style="margin-left: 2%;">When was the last major service ?</label>
                                                </div>
                                            </div>

                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-8">

                                                    <%--<input type="text" id="MajorService_Txt"  runat="server"/>--%>
                                                    <%--<asp:TextBox ID="MajorService_Txt" runat="server"></asp:TextBox>--%>
                                                    <asp:TextBox ID="MajorService_Txt1" runat="server" CssClass="form-control" />
                                                    <%--<asp:CalendarExtender ID="CalendarExtender1" TargetControlID="txtStartDate" runat="server" />--%>
                                                    <asp:CalendarExtender ID="CalendarExtender2" TargetControlID="MajorService_Txt1" runat="server" />
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" Display="Dynamic" ValidationGroup="a" runat="server" ControlToValidate="MajorService_Txt1" ErrorMessage=" * Please Select Option"></asp:RequiredFieldValidator>
                                                    <%--<input type="text" runat="server"  id="txtDate_of_valuation" name="txtDate_of_valuation" value="" />--%>
                                                </div>
                                                <a href="#" class="tooltips" tabindex="2">
                                                    <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -2%;" />
                                                    <span style="width: 185px;">What was the date of last service.You can estimate if not exactly sure.</span>
                                                </a>
                                            </div>
                                        </div>
                                        <%--hidden records--%>


                                        <div class="col-lg-12">
                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-10">
                                                    <label for="inputEmail">Has an insurance claim ever been filed on this vehicle?</label>
                                                </div>
                                            </div>


                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-8">
                                                    <asp:DropDownList ID="Insurance_claim_DDL" runat="server" CssClass="form-control" OnSelectedIndexChanged="Insurance_claim_DDL_SelectedIndexChanged" AutoPostBack="true">
                                                        <asp:ListItem Text=" Please Select " Value="-1"></asp:ListItem>
                                                        <asp:ListItem Text="Yes" Value="0"></asp:ListItem>
                                                        <asp:ListItem Text="No" Value="1"></asp:ListItem>
                                                        <asp:ListItem Text="Not Sure" Value="2"> </asp:ListItem>
                                                    </asp:DropDownList>
                                                    <asp:RequiredFieldValidator InitialValue="-1" ID="RequiredFieldValidator11" Display="Dynamic" ValidationGroup="a" runat="server" ControlToValidate="Insurance_claim_DDL" ErrorMessage=" * Please Select Option"></asp:RequiredFieldValidator>
                                                </div>
                                                <a href="#" class="tooltips" tabindex="2">
                                                    <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -2%;" />
                                                    <span style="width: 160px;">Please indicate if your vehicle has had any type of insurance damage claimed.</span>
                                                </a>
                                            </div>
                                        </div>
                                        <%-- hidden insurance details--%>
                                        <div class="col-lg-12" runat="server" id="Div_Insurance_ClaimDetails_Hidden" visible="false">
                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-10">
                                                    <img src="../images/Images/h.png" style="width: 14px; height: 14px; margin-left: 4%;" /><label for="inputEmail" style="margin-left: 2%;">What date was the last insurance claim ?</label>
                                                </div>
                                            </div>
                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-8">
                                                    <asp:TextBox ID="Insurance_Date_Hidden_Txt1" class="form-control" runat="server" />
                                                    <%--<input type="text" class="form-control" name="Insurance_Date_Hidden_Txt" id="Insurance_Date_Hidden_Txt" runat="server"/>--%>
                                                    <asp:CalendarExtender ID="CalendarExtender1" TargetControlID="Insurance_Date_Hidden_Txt1" runat="server" />
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator12" Display="Dynamic" ValidationGroup="a" runat="server" ControlToValidate="Insurance_Date_Hidden_Txt1" ErrorMessage=" * Please Select Option"></asp:RequiredFieldValidator>
                                                </div>
                                                <a href="#" class="tooltips" tabindex="2">
                                                    <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -2%;" />
                                                    <span style="width: 175px;">What was the date of accident or damage?you can estimate if not exactly sure.</span>
                                                </a>
                                            </div>

                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-10">
                                                    <img src="../images/Images/h.png" style="width: 14px; height: 14px; margin-left: 4%;" />
                                                    <label for="inputEmail" style="margin-left: 2%;">What was the amount of Insurance claim ?</label>
                                                </div>
                                            </div>

                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-8">
                                                    <input type="text" autocomplete="off" class="form-control" id="Insurance_Claim_Amount_HiddenTxt" runat="server" onchange="toUSD(this);" onkeypress="return NumberOnly(event)" onkeydown="return CommaFormatted1()" required />
                                                </div>
                                                <a href="#" class="tooltips" tabindex="2">
                                                    <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -2%;" />
                                                    <span style="width: 182px;">What was the dollar amount of the accident or damage claim? You can estimate if not exactly sure.</span>
                                                </a>
                                            </div>


                                        </div>

                                        <%--hidden insurance details--%>

                                        <div class="col-lg-12">
                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-10">
                                                    <label for="inputEmail">Has the vehicle been smoked in or does it have a bad odor?</label>
                                                </div>
                                            </div>
                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-8">
                                                    <asp:DropDownList ID="Smoked_Bad_Odor_DDL" runat="server" CssClass="form-control">
                                                        <asp:ListItem Text=" Please Select " Value="-1"></asp:ListItem>
                                                        <asp:ListItem Text="Yes" Value="0"></asp:ListItem>
                                                        <asp:ListItem Text="No" Value="1"></asp:ListItem>
                                                    </asp:DropDownList>
                                                    <asp:RequiredFieldValidator InitialValue="-1" ID="RequiredFieldValidator13" Display="Dynamic" ValidationGroup="a" runat="server" ControlToValidate="Smoked_Bad_Odor_DDL" ErrorMessage=" * Please Select Option"></asp:RequiredFieldValidator>
                                                </div>
                                                <a href="#" class="tooltips" tabindex="2">
                                                    <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -2%;" />
                                                    <span style="width: 229px;">Please indicate if the vehicle has ever been smoked in or has a strong odor of any kind.</span>
                                                </a>
                                            </div>

                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-10">
                                                    <label for="inputEmail">Are 2 sets of keys and alarm pads available? (if applicable)</label>
                                                </div>
                                            </div>

                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-8">
                                                    <asp:DropDownList ID="KeySets_Alarm_DDL" runat="server" CssClass="form-control">
                                                        <asp:ListItem Text=" Please Select " Value="-1"></asp:ListItem>
                                                        <asp:ListItem Text="Yes" Value="0"></asp:ListItem>
                                                        <asp:ListItem Text="No" Value="1"></asp:ListItem>
                                                    </asp:DropDownList>
                                                    <asp:RequiredFieldValidator InitialValue="-1" ID="RequiredFieldValidator14" Display="Dynamic" ValidationGroup="a" runat="server" ControlToValidate="KeySets_Alarm_DDL" ErrorMessage=" * Please Select Option"></asp:RequiredFieldValidator>
                                                </div>
                                                <a href="#" class="tooltips" tabindex="2">
                                                    <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -2%;" />
                                                    <span style="width: 165px;">Let us know if you have more than one key and alarm pad.</span>
                                                </a>
                                            </div>


                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-10">
                                                    <label for="inputEmail">Has this vehicle been used as a taxi or rental in the past?</label>
                                                </div>
                                            </div>


                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-8">
                                                    <asp:DropDownList ID="Taxi_rental_DLL" runat="server" CssClass="form-control">
                                                        <asp:ListItem Text=" Please Select " Value="-1"></asp:ListItem>
                                                        <asp:ListItem Text="Yes" Value="0"></asp:ListItem>
                                                        <asp:ListItem Text="No" Value="1"></asp:ListItem>
                                                        <asp:ListItem Text="Not Sure" Value="1"></asp:ListItem>
                                                    </asp:DropDownList>
                                                    <asp:RequiredFieldValidator InitialValue="-1" ID="RequiredFieldValidator15" Display="Dynamic" ValidationGroup="a" runat="server" ControlToValidate="Taxi_rental_DLL" ErrorMessage=" * Please Select Option"></asp:RequiredFieldValidator>
                                                </div>
                                                <a href="#" class="tooltips" tabindex="2">
                                                    <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -2%;" />
                                                    <span style="width: 245px;">Please indicate if your vehicle was ever used as taxi,rental car or delivery vehicle in the past.</span>
                                                </a>
                                            </div>


                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-10">
                                                    <label for="inputEmail">Does your vehicle have aftermarket equipment installed?</label>
                                                </div>
                                            </div>


                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-8">
                                                    <asp:DropDownList ID="After_Market_DDL" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="After_Market_DDL_SelectedIndexChanged">
                                                        <asp:ListItem Text=" Please Select " Value="-1"></asp:ListItem>
                                                        <asp:ListItem Text="Yes" Value="0"></asp:ListItem>
                                                        <asp:ListItem Text="No" Value="1"></asp:ListItem>
                                                        <asp:ListItem Text="Not Sure" Value="2"></asp:ListItem>
                                                    </asp:DropDownList>
                                                    <asp:RequiredFieldValidator InitialValue="-1" ID="RequiredFieldValidator16" Display="Dynamic" ValidationGroup="a" runat="server" ControlToValidate="After_Market_DDL" ErrorMessage=" * Please Select Option"></asp:RequiredFieldValidator>
                                                </div>
                                                <a href="#" class="tooltips" tabindex="2">
                                                    <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -2%;" />
                                                    <span style="width: 260px;">Let us know if your vehicle has any after market equipment or accessories installed.Please be as descriptive as possible in the text field below.</span>
                                                </a>
                                            </div>

                                            <div class="col-lg-11" style="margin-top: 1%">
                                                <div class="col-lg-10" runat="server" id="Equipment_Hidden_Div" visible="false">
                                                    <%--<asp:TextBox ID="TextBox1" runat="server"  TextMode="MultiLine" style="margin-bottom:1%;" CssClass="form-control" />--%>
                                                    <textarea class="form-control" rows="3" runat="server" style="width: 843px" id="Equipment_Hidden_TextArea1" placeholder="i.e. after market bluetooth. XM radio, 22' custom rims, Window, tint etc....." required></textarea>
                                                </div>
                                            </div>


                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-10">
                                                    <label for="inputEmail">Have performance modifications been made to this vehicle?</label>
                                                </div>
                                            </div>


                                            <div class="col-lg-6" style="margin-top: 1%;">
                                                <div class="col-lg-8" style="margin-top: -1%">
                                                    <asp:DropDownList ID="Performance_MOdification_DLL" runat="server" CssClass="form-control" OnSelectedIndexChanged="Performance_MOdification_DLL_SelectedIndexChanged" AutoPostBack="true">
                                                        <asp:ListItem Text=" Please Select " Value="-1"></asp:ListItem>
                                                        <asp:ListItem Text="Yes" Value="0"></asp:ListItem>
                                                        <asp:ListItem Text="No" Value="1"></asp:ListItem>
                                                        <asp:ListItem Text="Not Sure" Value="2"></asp:ListItem>
                                                    </asp:DropDownList>
                                                    <asp:RequiredFieldValidator InitialValue="-1" ID="RequiredFieldValidator17" Display="Dynamic" ValidationGroup="a" runat="server" ControlToValidate="Performance_MOdification_DLL" ErrorMessage=" * Please Select Option"></asp:RequiredFieldValidator>
                                                </div>
                                                <a href="#" class="tooltips" tabindex="2">
                                                    <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -2%;" />
                                                    <span style="width: 245px;">Let us know if your vehicle has had any performance modification.Please be as detailed as possible in the description field below.</span>
                                                </a>
                                            </div>

                                            <div class="col-lg-11" style="margin-top: 1%">
                                                <div class="col-lg-10" runat="server" id="PerformaneModified_Hidden_DIv" visible="false">
                                                    <textarea class="form-control" rows="3" runat="server" style="width: 843px; margin-left: 0%; margin-bottom: -4%" id="PerformaneModified_Hidden_TextArea" placeholder="i.e.    after market turbo charger add,suspension lowered, engine chip installed, etc....." required></textarea>
                                                </div>
                                            </div>
                                        </div>
                                        <%--hidden text area--%><br />
                                        <br />

                                        <%--<asp:TextBox ID="Equipment_Hidden_TextArea" runat="server" TextMode="MultiLine" style="margin-bottom:1%;" />--%>
                                        <%--hidden text area--%>

                                        <%--  <div class="col-lg-12">
                     <div class="col-lg-6" style="margin-top: 1%;">                  
                     <div class="col-lg-10">                  
                     <label for="inputEmail" >Have performance modifications been made to this vehicle?</label>    
                     </div>        
                     </div>


                     <div class="col-lg-6" style="margin-top: 1%;" >                                                
                     <div class="col-lg-8">                  
                       <asp:DropDownList ID="Performance_MOdification_DLL" runat="server" CssClass="form-control" OnSelectedIndexChanged="Performance_MOdification_DLL_SelectedIndexChanged" AutoPostBack="true">
                       <asp:ListItem Text="------Please Select--------" Value="-1" ></asp:ListItem>
                       <asp:ListItem Text="Yes" Value="0" ></asp:ListItem>
                       <asp:ListItem Text="No" Value="1" ></asp:ListItem>
                       <asp:ListItem Text="Not Sure" Value="2" ></asp:ListItem>
                   </asp:DropDownList>
                     </div>    
                     </div>
                     <div class="col-lg-12" runat="server" id="PerformaneModified_Hidden_DIv"  visible="false">
                 <textarea class="form-control" rows="3" runat="server" style="width:843px;margin-left: 3%; margin-bottom:17%" id="Textarea1" placeholder="i.e.    after market turbo charger add,suspension lowered, engine chip installed, etc....." ></textarea>    
                  </div>
             </div>--%>

                                        <%-- <div class="col-lg-12" runat="server" id="PerformaneModified_Hidden_DIv" style="height:0px;" visible="false">
                 <textarea class="form-control" rows="3" runat="server" style="width:843px;margin-left: 3%; margin-bottom:17%" id="PerformaneModified_Hidden_TextArea" placeholder="i.e.    after market turbo charger add,suspension lowered, engine chip installed, etc....." ></textarea>    
                  </div>--%>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                                <br />
                                <br />
                                <div class="col-lg-6" style="margin-top: 4%;">
                                    <div class="col-lg-3"></div>
                                    <div class="col-lg-8">
                                        <%--<img style="width:45%" src="../images/restart.png" />--%>
                                        <asp:ImageButton ID="Vehicle_Details_Back" runat="server" ImageUrl="../images/Images/11%20copy.png" Style="width: 45%; margin-left: -35%; margin-top: 20%; margin-bottom: 28%; padding-bottom: 20px" OnClick="Vehicle_Details_Back_Click" />
                                    </div>
                                </div>
                                <%--<img src="../images/Images/11%20copy.png" />--%>

                                <div class="col-lg-6" style="margin-top: 4%;">

                                    <div class="col-lg-8">
                                        <%--<img style="float:right;width:45%" src="../images/next.png" id="img3" />--%>
                                        <asp:ImageButton ID="Vehicle_Details_Nextbtn" runat="server" ImageUrl="../images/Images/5%20copy.png" Style="float: right; width: 45%; margin-bottom: 37px; margin-right: 4px; margin-top: 21%;" OnClick="Vehicle_Details_Nextbtn_Click"  ValidationGroup="a"/>
                                        <asp:ImageButton ID="VehicleDetails_Updatebtn" runat="server" Style="float: right; width: 45%; margin-bottom: 37px; margin-right: 4px; margin-top: 21%;" ImageUrl="../images/Images/2.png" OnClick="VehicleDetails_Updatebtn_Click" Visible="false" ValidationGroup="a" />
                                    </div>
                                </div>

                            </div>
                        </asp:View>
                        <!-- DIV 3-->

                        <!-- DIV 4-->
                        <asp:View ID="View4" runat="server">
                            <div class="container  maindiv" id="div103" style="display: block; background: white;" runat="server">
                                <img style="width: 100%; margin-top: 1%;" src="../images/Images/19%20copy.png" /><%--<img src="../images/Images/19%20copy.png" />--%>
                                <div class="col-lg-12">
                                    <p style="color: black; width: 90%; text-align: justify; margin-top: 2%;">To truly value any vehicle accurately it is important for us to know what options and equipment upgrades, if any, that specific vehicle has. The value can be thousands of dollars higher or lower based on this information alone. Please use the form below to indicate which options and manufacturer equipment upgrades are installed on your vehicle. You may also upload photos of your vehicle in this step. Photos are not required but highly recommended!</p>
                                    <br />
                                </div>
                                <%--<div class="col-lg-12" style="margin-top:1%">--%>
                                <div class="col-lg-8" style="margin-top: 1%; margin-left: 10%">
                                    <div class="col-lg-3">
                                        <a href="#" class="tooltips" tabindex="1">
                                            <img src="../images/Images/6%201copy.png" style="width: 10%; margin-top: 19%; margin-left: -35%;" />
                                            <span style="width: 255px;">This section lists all options available for this model vehicle.Please check
the box next to the option you believe your vehicle is equipped with.</span>
                                        </a>
                                    </div>
                                    <div class="col-lg-8">
                                        <h4 style="margin-left: -46%; margin-top: 5%;">All options & equipment available for this model vehicle. </h4>
                                    </div>
                                </div>
                                <%--</div> --%>
                                <asp:UpdatePanel ID="UpdatePanel_grid" runat="server" UpdateMode="Conditional">
                                    <ContentTemplate>
                                        <div class="col-lg-11" style="overflow-y: scroll; width: 81%; height: 306px; margin-left: 8%; border: 1px solid;">
                                            <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
                                            </asp:CheckBoxList>
                                        </div>

                                        <div class="col-lg-8" style="margin-top: 1%; margin-left: 10%">
                                            <div class="col-lg-3">
                                                <a href="#" class="tooltips" tabindex="2">
                                                    <img src="../images/Images/6%201copy.png" style="width: 10%; margin-top: 19%; margin-left: -35%;" />
                                                    <span style="width: 225px;">This section lists the options currently installed on your vehicle.If you 
believe the option is not installed on your vehicle,click on the 'X' to remove form the 
list.</span>
                                                </a>
                                            </div>
                                            <div class="col-lg-8">
                                                <h4 style="margin-left: -46%; margin-top: 5%;">Your vehicles options and equipment. </h4>
                                            </div>
                                        </div>
                                        <%--<div class="col-lg-12">
              <br /><h4> Your vehicles options and equipment.</h4><br />

      </div>--%>
                                        <div class="col-lg-11" style="overflow-y: scroll; width: 81%; height: 306px; margin-left: 8%; border: 1px solid;">
                                            <asp:Label runat="server" ID="VehiclesOptionsText" Visible="false" ForeColor="Red">You have not selected any options.</asp:Label>
                                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" DataKeyNames="Check_id" OnRowDeleting="GridView1_RowDeleting">
                                                <Columns>
                                                    <asp:TemplateField HeaderText="Remove">
                                                        <ItemTemplate>
                                                            <asp:ImageButton ID="ImageButton_remove" runat="server" ImageUrl="../images/close%20copy.png" Style="width: 20%;" CommandName="Delete" CommandArgument='<%#Eval("Check_id")%>' />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:BoundField DataField="EquipmentInstalled" HeaderText="Equipment Installed" />
                                                    <%--<asp:BoundField DataField="id" HeaderText="id"  Visible="false"/>--%>
                                                </Columns>
                                            </asp:GridView>
                                        </div>


                                    </ContentTemplate>
                                </asp:UpdatePanel>

                                <div class="col-lg-8" style="margin-top: 1%; margin-left: 10%">
                                    <div class="col-lg-3">
                                        <a href="#" class="tooltips" tabindex="2">
                                            <img src="../images/Images/6%201copy.png" style="width: 10%; margin-top: 19%; margin-left: -35%;" />
                                            <span style="width: 230px;">You can upload photos of your vehicle here.Seeing photos of the vehicle
can make a big difference and help us appraise it.To upload photos:Click the BROWSE
button,in the pop-up window,locate the photo on your computer,then click "OPEN".Next
Click the "Upload Now" button to complete the photo upload.</span>
                                        </a>
                                    </div>
                                    <div class="col-lg-8">
                                        <h4 style="margin-left: -46%; margin-top: 5%;">Upload photos of your vehicle here. </h4>
                                    </div>
                                </div>



                                <%--<div class="col-lg-12" style="margin-top:1%;">
                 <h4> Upload photos of your vehicle here. </h4>
       </div>--%>
                                <div class="col-lg-4" style="margin-top: 1%; height: 213px;">

                                    <img src="../images/cameranewone.jpg" style="width: 58%; height: 72%; margin-left: 22%;" />
                                    <%--<img src="../images/Images/Canon-XH-A1.png" style="width:100%;height:100%"/>--%>
                                </div>
                                <%--<asp:UpdatePanel ID="UpdatePanel2" runat="server"><ContentTemplate>--%>

                                <div class="col-lg-6" style="height: 185px; margin-left: -3%; margin-top: 3%;" id="DIv_File ">
                                    <asp:Label runat="server" ID="Label1">Start uploading photos here.</asp:Label>
                                    <%--<asp:AjaxFileUpload ID="AjaxFileUpload1" runat="server" AllowedFileTypes="jpeg,jpeg,png,gif,jpg" MaximumNumberOfFiles="10" Width="500px" Height="102px" OnUploadComplete="AjaxFileUpload1_UploadComplete1"/>--%>
                                    <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" Width="50%" Text="Choose File"/>
                                    <asp:Button ID="FileUpload_normal" runat="server" Text="Upload Now.." OnClick="FileUpload_normal_Click" CssClass="form-control" Style="width: 50%;" />
                                    <%--<asp:Label runat="server"  Visible="false" ForeColor="Red" ID="uploadlabel"></asp:Label>--%>
                                    <%--<ajaxToolkit:AjaxFileUpload ID="AjaxFileUpload1" runat="server" AllowedFileTypes="jpeg,jpeg,png,gif,jpg" MaximumNumberOfFiles="10" Width="500px" Height="102px" OnUploadComplete="AjaxFileUpload1_UploadComplete" />--%>
                                    <%--<asp:Label ID="Label1" runat="server" Font-Size="Larger"></asp:Label>--%>
                                    <%--<asp:CustomValidator ID="CustomValidator1" runat="server"
                                        ClientValidationFunction="ValidateFileUpload" ErrorMessage="Please Select atleast one file"></asp:CustomValidator>--%>
                                    <%--<script type="text/javascript">
                                        function FileUpload_normal_Click() {
                                            var fuData = document.getElementById('<%= FileUpload1.ClientID %>');
                                            var FileUploadPath = fuData.value;

                                            if (FileUploadPath == '') {
                                                // There is no file selected
                                                alert('Select atleast one file');
                                                args.IsValid = false;
                                            }
                                            else {
                                                alert('Success');
                                            }


                                        }
                                    </script>--%>


                                    <%--<asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" Visible="false"/>--%>
                                </div>


                                <%--</ContentTemplate></asp:UpdatePanel>--%>
                                <asp:UpdatePanel ID="up_panel" runat="server">
                                    <ContentTemplate>
                                        <div class="col-lg-7" style="width: 81%; margin-left: 8%; border: 1px solid; margin-top: -1%; padding-bottom: 3%; padding-top: 3%;">
                                            <asp:Label runat="server" ID="NoImageUploadedText" Visible="false" ForeColor="Red">No image uploaded yet.</asp:Label>
                                            <asp:Label runat="server" ID="ImageCountText" Visible="false" Font-Bold="true" ForeColor="Tomato"></asp:Label>
                                            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" HeaderStyle-HorizontalAlign="Justify" HeaderStyle-VerticalAlign="Middle" ToolTip="ImageGrid" Width="100%" Height="100px" OnRowCommand="GridView2_RowCommand" OnRowDeleting="GridView2_RowDeleting" BorderStyle="Outset">
                                                <Columns>
                                                    <asp:TemplateField HeaderText="S.No" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" HeaderStyle-CssClass="text-center">
                                                        <ItemTemplate>
                                                            <%# ((GridViewRow)Container).RowIndex + 1%>
                                                        </ItemTemplate>
                                                        <ItemStyle Width="8%" HorizontalAlign="Center" BorderStyle="Solid" BorderWidth="1px" />
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Remove" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" HeaderStyle-CssClass="text-center">
                                                        <ItemTemplate>
                                                            <asp:ImageButton ID="ImageButton1" runat="server" CommandName="Delete" ImageUrl="../images/close%20copy.png" Style="width: 24%;" />
                                                        </ItemTemplate>
                                                        <%--<HeaderStyle BorderStyle="None" />--%>
                                                        <HeaderStyle HorizontalAlign="Center" />
                                                        <ItemStyle Width="8%" HorizontalAlign="Center" BorderStyle="Solid" BorderWidth="1px" />
                                                    </asp:TemplateField>
                                                    <asp:BoundField DataField="Filename" HeaderText="Image Name" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" HeaderStyle-CssClass="text-center">
                                                        <ItemStyle Width="70%" HorizontalAlign="Center" BorderStyle="Solid" BorderWidth="1px" Font-Names="Times New Roman" Font-Size="18px" />
                                                        <HeaderStyle HorizontalAlign="Center" />
                                                    </asp:BoundField>
                                                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderText="Preview" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" HeaderStyle-CssClass="text-center">
                                                        <ItemTemplate>
                                                            <%--<asp:LinkButton ID="linkbtn1" runat="server" CausesValidation="false">--%>
                                                            <asp:Image ID="Image1" runat="server" ImageUrl='<%# Bind("url") %>' Style="width: 31%; padding-top: 4%;" />
                                                            <%--<%# Container.DataItem %>--%>
                                                            <%--</asp:LinkButton>--%>
                                                        </ItemTemplate>
                                                        <HeaderStyle HorizontalAlign="Center" />
                                                        <ItemStyle Width="18%" HorizontalAlign="Center" BorderStyle="Solid" BorderWidth="1px" VerticalAlign="Middle" />
                                                    </asp:TemplateField>
                                                </Columns>

                                            </asp:GridView>



                                        </div>

                                    </ContentTemplate>
                                </asp:UpdatePanel>

                                <%--</ContentTemplate>
                    
                </asp:UpdatePanel>--%>
                                <%-- <asp:Button ID="Button1" runat="server" Text="Upload" style="margin-left:10%" OnClick="Button1_Click" />--%>


                                <div class="col-lg-6">
                                    <div class="col-lg-3"></div>
                                    <div class="col-lg-8">
                                        <%--<img style="width:45%" src="../images/restart.png" />--%>
                                        <asp:ImageButton ID="Vehicle_optionFeatures_Back" runat="server" ImageUrl="../images/Images/11%20copy.png" Style="width: 45%; margin-left: -23%; padding-bottom: 20px; margin-top: 25%;" OnClick="Vehicle_optionFeatures_Back_Click" />
                                    </div>
                                </div>

                                <div class="col-lg-6">
                                    <div class="col-lg-3">
                                    </div>
                                    <div class="col-lg-8">
                                        <%--<img style="float:right;width:45%" src="../images/next.png" id="img4" />--%>
                                        <%--<asp:ImageButton ID="Vehicle_OptionsFeatures_Nextbtn" runat="server" ImageUrl="../images/Images/5%20copy.png" style="float:right;width:45%; margin-bottom:50px;margin-right:50px;margin-top: 25%;" OnClick="Vehicle_OptionFeatures_Click"/>--%>
                                        <asp:ImageButton ID="Vehicle_OptionsFeatures_Nextbtn" runat="server" ImageUrl="../images/Images/5%20copy.png" Style="float: right; width: 45%; margin-bottom: 90px; margin-right: 50px; margin-top: 25%;" OnClick="Vehicle_OptionFeatures_Click" />
                                        <asp:ImageButton ID="Vehicle_optionsFeatures_Updatebtn" runat="server" Style="float: right; width: 45%; margin-bottom: 95px; margin-right: 40px; margin-top: 33%;" ImageUrl="../images/Images/2.png" OnClick="Vehicle_optionsFeatures_Updatebtn_Click" Visible="false" />
                                    </div>
                                </div>
                            </div>
                        </asp:View>
                        <!-- DIV 4-->
                        <!-- DIV 5-->
                        <asp:View ID="View5" runat="server">
                            <div class="container  maindiv" id="div104" style="display: block; background: white;" runat="server">
                                <img src="../images/Images/15%20copy.png" style="width: 100%; margin-top: 1%; margin-bottom: 1%;" />
                                <%--<asp:UpdatePanel ID="up_panel_imagemap" runat="server">
                                    <ContentTemplate>--%>
                                <div class="col-lg-12" style="margin-bottom: 9%;">
                                    <p style="color: black; width: 90%; text-align: justify; margin-left: 3%; margin-top: 1%; margin-bottom: 1%;">
                                        Last step! Please use this step to describe the condition of your vehicle's exterior, interior and powertrain as best as possible. The exterior condition tool should be used to point out any areas of damage. We understand that most vehicles have light blemishes but it's important that you declare any damage or major blemishes to your vehicle exterior; as failure to do so would possibly result in an adjusted appraisal should you choose to sell. Finally, please rate the overall interior and mechanical condition of your vehicle from poor to excellent.
                                    </p>

                                    <div class="col-lg-8" style="margin-left: 2%">
                                        <a href="#" class="tooltips" tabindex="1">
                                            <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -2%;" />
                                            <span style="width: 250px; height: 150px; padding: 2%;">Use the Sample Vehicle image below as the guide.Click on any part of the image to select the area of damage,then using the adjacent list to the right to describe the type of damage or blemish indicated.</span>
                                        </a><span style="margin-left: 0px;">Exterior Condition</span>

                                    </div>

                                    <%--</div>--%>
                                    <%--<asp:UpdatePanel ID="up_panel_imagemap" runat="server">
                                    <ContentTemplate>--%>
                                    <%--<div class="col-lg-12" style="margin-top:2%;margin-left:42%;">--%>

                                    <asp:UpdatePanel ID="up_panel_imagemap" runat="server">
                                        <ContentTemplate>
                                            <div class="col-lg-6" style="margin-left: -63%; margin-top: 8%;">

                                                <asp:ImageMap ID="ImageMap1" runat="server" ImageUrl="../images/Images/condmap_front.jpg" OnClick="ChooseOne" Width="580" Height="272" Style="margin-left: 1%;">
                                                    <%-- 1.Front Bumper --%>
                                                    <asp:PolygonHotSpot AlternateText="Front Bumper" Coordinates="97,110,101,114,103,117
                        ,107,122,111,123,113,113,115,98,127,102,140,108,146,113,152,117,
                        161,118,170,114,177,115,187,118,200,119,205,119,210,120,214,120,220,120,229,
                        120,226,122,219,128,209,137,204,146,217,146,233,146,254,147,266,146,276,143,284,
                        141,298,136,299,142,303,147,306,156,318,156,313,166,303,190,299,205,255,210,210,207,
                        200,205,185,201,165,195,144,187,129,182,101,
                        172,93,168,93,159,91,143,88,137,92,123,95,114"
                                                        HotSpotMode="PostBack" PostBackValue="Front Bumper" />
                                                    <%-- 2.Hood --%>
                                                    <asp:PolygonHotSpot AlternateText="Hood" Coordinates="216,119,206,118,194,115,180,113,167,112,160,117,
146,110,146,105,140,104,132,102,116,95,124,86,134,83,146,76,154,74,165,70,
171,68,175,66,179,65,185,61,196,59,196,60,199,62,201,62,204,62,211,65,220,
66,226,66,231,66,243,69,254,71,264,73,268,73,278,75,288,75,294,78,310,79,
325,83,344,84,320,88,310,90,303,91,293,94,290,95,286,96,284,98,280,99,271,
102,261,105,245,110,229,119"
                                                        HotSpotMode="PostBack" PostBackValue="Hood" />
                                                    <%-- 3.Roof --%>
                                                    <asp:PolygonHotSpot AlternateText="Roof " Coordinates="258,25,328,31,375,40,390,
                 31,414,31,338,20,293,18"
                                                        HotSpotMode="PostBack" PostBackValue="Roof" />
                                                    <%-- 4.Front Left Fender --%>
                                                    <asp:PolygonHotSpot AlternateText="Front Left Fender " Coordinates="303,120,300,134,309,154,319,153,335,133,348,130,
355,133,363,146,363,183,365,181,370,102,364,85,352,84,331,89,301,95,278,102,231,120,
280,123"
                                                        HotSpotMode="PostBack" PostBackValue="Front Left Fender" />
                                                    <%-- 5.Front Left Door --%>
                                                    <asp:PolygonHotSpot AlternateText="Front Left Door" Coordinates="367,181,369,157,370,148,370,142,372,137,372,128,372,
118,372,105,370,96,368,91,375,91,382,93,387,93,392,93,395,93,404,95,413,93,412,83,
419,84,418,86,420,95,420,103,420,112,420,118,420,122,420,128,418,134,417,144,412,167"
                                                        HotSpotMode="PostBack" PostBackValue="Front Left Door" />
                                                    <%-- 6.Rear Left Door --%>
                                                    <asp:PolygonHotSpot AlternateText="Rear Left Door" Coordinates="427,156,412,166,418,148,420,133,422,124,423,110,
423,102,422,91,418,80,424,79,433,76,438,74,444,73,448,73,453,76,454,83,454,85,454,89,453,
91,454,96,453,102,453,110,452,114,447,124,443,136,438,149"
                                                        HotSpotMode="PostBack" PostBackValue="Rear Left Door" />
                                                    <%-- 7.Rear Left Quarter Panel --%>
                                                    <asp:PolygonHotSpot AlternateText="Rear Left Quarter Panel" Coordinates="440,54,419,35,435,42,460,69,472,80,472,118,466,137,
463,108,454,112,457,79,448,70,447,62"
                                                        HotSpotMode="PostBack" PostBackValue="Rear Left Quarter Panel" />
                                                    <%-- 8.Front Left Window --%>
                                                    <asp:PolygonHotSpot AlternateText="Front Left Window" Coordinates="369,79,373,70,377,62,379,56,383,50,385,46,392,42,395,
41,403,41,402,41,402,44,405,50,408,59,409,66,410,71,410,75,405,73,399,73,394,71,389,
71,384,70,378,73,377,75"
                                                        HotSpotMode="PostBack" PostBackValue="Front Left Window" />
                                                    <%-- 9.Rear Left Window --%>
                                                    <asp:PolygonHotSpot AlternateText="Rear Left Window" Coordinates="415,79,413,62,410,54,408,47,405,40,409,40,415,41,422,42,428,
46,427,45,425,45,433,49,440,56,444,62,447,69"
                                                        HotSpotMode="PostBack" PostBackValue="Rear Left Window" />
                                                    <%-- 10.Front Windshield --%>
                                                    <asp:PolygonHotSpot AlternateText="Front Windshield" Coordinates="204,60,300,75,316,79,331,83,352,80,360,70,373,41,311,
31,289,28,274,27,268,27,258,26"
                                                        HotSpotMode="PostBack" PostBackValue="Front Windshield" />
                                                    <%-- 11.Front Left Wheel & Tire --%>
                                                    <asp:PolygonHotSpot AlternateText="Front Left Wheel & Tire" Coordinates="300,204,306,187,309,180,310,175,313,171,315,166,316,163,319,159,321,156,324,152,
328,148,331,143,335,139,339,139,344,139,348,141,352,143,355,149,358,156,360,166,360,172,360,180,360,185,357,
204,350,214,340,225,325,232,314,235,299,230,286,220,296,215,299,210"
                                                        HotSpotMode="PostBack" PostBackValue="Front Left Wheel & Tire" />
                                                    <%-- 12.Rear Left Wheel & Tire --%>
                                                    <asp:PolygonHotSpot AlternateText="Rear Left Wheel & Tire" Coordinates="428,162,440,152,444,137,448,124,453,114,459,109,464,118,
466,125,463,139,454,172,433,175"
                                                        HotSpotMode="PostBack" PostBackValue="Rear Left Wheel & Tire" />
                                                    <%-- 13.Front Left Headlight --%>
                                                    <asp:PolygonHotSpot AlternateText="Front Left Headlight"
                                                        Coordinates="207,143,229,124,281,124,300,123,298,133,278,141,235,146"
                                                        HotSpotMode="PostBack" PostBackValue="Front Left Headlight" />
                                                    <%-- 14.Front Right Headlight --%>
                                                    <asp:PolygonHotSpot AlternateText="Front Right Headlight"
                                                        Coordinates="108,118,98,107,105,93,112,96"
                                                        HotSpotMode="PostBack" PostBackValue="Front Right Headlight" />
                                                    <%-- 15.Left Mirror --%>
                                                    <asp:PolygonHotSpot AlternateText="Left Mirror" Coordinates="367,89,369,81,379,76,383,73,398,73,404,75,410,78,410,
89,405,91,398,90,392,89,383,89,377,88"
                                                        HotSpotMode="PostBack" PostBackValue="Left Mirror" />
                                                    <%-- Rotate View Back Image --%>
                                                    <asp:PolygonHotSpot AlternateText="Rotate View Back Image"
                                                        Coordinates="34,14,48,19,54,32,52,43,
                                34,57,17,48,14,36,16,24,23,18"
                                                        HotSpotMode="PostBack" PostBackValue="Rotate View Back Image" />
                                                </asp:ImageMap>


                                                <asp:ImageMap ID="ImageMap2" runat="server" ImageUrl="../images/Images/condmap_back.jpg" Width="580" Height="272" OnClick="ChooseOne" Style="margin-left: 3%;">
                                                    <%-- 16.Roof --%>
                                                    <asp:PolygonHotSpot AlternateText="Roof " Coordinates="264, 32, 230,
 42, 249, 50, 264, 59, 284, 66, 313, 75, 339, 61, 360, 55, 377, 
51, 390, 51, 399, 51, 403, 49, 393, 45, 382, 41, 365, 35, 355, 32, 341, 
31, 323, 27, 311, 26, 293, 28, 279, 30"
                                                        HotSpotMode="PostBack" PostBackValue="Roof" />
                                                    <%-- 17.Trunk --%>
                                                    <asp:PolygonHotSpot AlternateText="Trunk" Coordinates="199, 102, 259, 122, 234, 129, 225, 136, 212, 153, 202, 173, 184, 170, 167, 162, 159, 
156, 146, 148, 135, 139, 129, 132, 130, 123, 126, 119, 132, 
104, 136, 86, 164, 79, 182, 94"
                                                        HotSpotMode="PostBack" PostBackValue="Trunk" />
                                                    <%-- 18.Rear Bumper --%>
                                                    <asp:PolygonHotSpot AlternateText="Rear Bumper" Coordinates="122, 118, 127, 127, 126, 133, 140, 148, 
167, 166, 201, 176, 209, 171, 
214, 175, 236, 173, 245, 166, 274, 180, 306, 175, 291, 204, 281, 209, 283, 221, 227, 227, 204, 224, 179, 212, 164, 204, 154, 198,
 145, 192, 135, 183, 126, 176, 120, 168, 117, 162, 112,
 152, 113, 147, 113, 141, 116, 130"
                                                        HotSpotMode="PostBack" PostBackValue="Rear Bumper" />
                                                    <%-- 19.Rear Right Quarter Panel --%>
                                                    <asp:PolygonHotSpot AlternateText="Rear Right Quarter Panel" Coordinates="244, 129, 266, 120, 285, 100, 300, 88,
 320, 73, 328, 81, 320, 93, 324, 112, 
335, 128, 348, 157, 354, 183, 348, 185, 345, 163, 326, 158, 308, 173, 274, 178, 244, 166, 254, 147, 254, 136"
                                                        HotSpotMode="PostBack" PostBackValue="Rear Right Quarter Panel" />
                                                    <%-- 20.Front Right Fender --%>
                                                    <asp:PolygonHotSpot AlternateText="Front Right Fender " Coordinates="457, 96, 459, 88, 452, 79, 477, 79, 484, 81, 489, 94, 489, 109, 486, 120, 482, 
100, 467, 108, 459, 122, 449, 146, 447, 147, 457, 110"
                                                        HotSpotMode="PostBack" PostBackValue="Front Right Fender" />
                                                    <%-- 21.Front Right Door --%>
                                                    <asp:PolygonHotSpot AlternateText="Front Right Door" Coordinates="399, 164, 399, 154, 402, 151, 402, 147, 404, 143, 405, 136,
 405, 128, 405, 119, 405, 110, 404, 105, 399, 99, 407, 98, 417, 96, 425, 93, 437, 90, 440, 90, 443, 95, 450, 96, 455, 96, 
454, 102, 455, 109, 454, 115, 453, 118, 450, 123, 450, 129, 448, 137, 447, 147, 399, 168"
                                                        HotSpotMode="PostBack" PostBackValue="Front Right Door" />
                                                    <%-- 22.Rear Right Door --%>
                                                    <asp:PolygonHotSpot AlternateText="Rear Right Door" Coordinates="357, 183, 352, 156, 348, 144, 345, 137, 341, 130, 339, 124, 330, 114, 328, 109, 328,
 108, 334, 105, 344, 105, 349, 105, 358, 104, 367, 103, 374, 102, 380, 100, 387, 99, 399, 99, 402, 103, 404, 109, 405, 
112, 404, 117, 404, 123, 403, 130, 403, 136, 402, 141, 402, 147, 399, 152, 398, 158, 397, 168"
                                                        HotSpotMode="PostBack" PostBackValue="Rear Right Door" />
                                                    <%-- 23.Front Right Window --%>
                                                    <asp:PolygonHotSpot AlternateText="Front Right Window" Coordinates="398, 96, 397, 90, 394, 81, 390, 70,
 388, 61, 397, 60, 404, 61, 413, 61, 422, 65,
 428, 69, 434, 71, 442, 78, 440, 88, 438, 88, 424, 90"
                                                        HotSpotMode="PostBack" PostBackValue="Front Right Window" />
                                                    <%-- 24.Rear Right Window --%>
                                                    <asp:PolygonHotSpot AlternateText="Rear Right Window" Coordinates="368, 102, 348, 104, 329, 104, 328,
 91, 334, 83, 339, 79, 345, 75, 352, 71, 357, 69, 363, 66, 365,
 64, 372, 62, 377, 61, 385, 62, 385, 70, 388, 81, 390, 88, 393,
 96"
                                                        HotSpotMode="PostBack" PostBackValue="Rear Right Window" />
                                                    <%-- 25.Rear Windshield --%>
                                                    <asp:PolygonHotSpot AlternateText="Rear Windshield" Coordinates="279, 104, 261, 120, 226, 112, 192,
 95, 174, 85, 167, 78, 187, 68, 204, 56, 216, 49, 227, 45, 236,
 49, 248, 54, 263, 60, 275, 64, 283, 68, 296, 70, 311, 75"
                                                        HotSpotMode="PostBack" PostBackValue="Rear Windshield" />
                                                    <%-- 26.Front Right Wheel & Tire --%>
                                                    <asp:PolygonHotSpot AlternateText="Front Right Wheel & Tire" Coordinates="444, 149, 444, 153, 447, 157, 452, 158, 459, 158, 463, 157, 467, 156, 
471, 152, 473, 147, 476, 143, 478, 136, 482, 130, 483, 123, 483, 113, 482, 105, 473, 108, 468, 109, 
464, 114, 460, 120, 458, 127, 455, 132, 453, 138, 453, 143, 450, 144, 448, 147, 447, 148"
                                                        HotSpotMode="PostBack" PostBackValue="Front Right Wheel & Tire" />
                                                    <%-- 27.Rear Right Wheel & Tire --%>
                                                    <asp:PolygonHotSpot AlternateText="Rear Right Wheel & Tire" Coordinates="284, 216, 284, 224, 291, 229, 300, 231, 309, 234, 315, 232, 318, 230, 323, 227, 
328, 224, 331, 221, 335, 216, 339, 210, 343, 206, 345, 195, 346, 186, 344, 177, 341, 171, 335, 167, 330, 164, 326, 166, 321, 167, 315, 171,
 308, 176, 304, 185, 300, 191, 298, 200, 294, 205, 291, 207, 289, 209"
                                                        HotSpotMode="PostBack" PostBackValue="Rear Right Wheel & Tire" />
                                                    <%-- 28.Right Tail Light --%>
                                                    <asp:PolygonHotSpot AlternateText="Right Tail Light"
                                                        Coordinates="216, 152, 212, 157, 212, 163, 210, 170, 224, 171, 234, 171, 239, 166, 246, 158, 249, 147, 251, 144, 
251, 139, 251, 136, 250, 134, 246, 132, 243, 130, 236, 132,
234, 132, 230, 134, 226, 137, 220, 146"
                                                        HotSpotMode="PostBack" PostBackValue="Right Tail Light" />
                                                    <%-- 29.Left Tail Light(driver side) --%>
                                                    <asp:PolygonHotSpot AlternateText="Left Tail Light(driver side)"
                                                        Coordinates="124, 118, 124, 109, 125, 104, 125,
 100, 125, 96, 126, 93, 129, 89, 131, 86, 134, 88, 132, 93, 130,
 98, 127, 113"
                                                        HotSpotMode="PostBack" PostBackValue="Left Tail Light(driver side)" />
                                                    <%-- 30.Right Mirror --%>
                                                    <asp:PolygonHotSpot AlternateText="Right Mirror" Coordinates="442, 90, 442, 85, 442, 81, 444, 79, 448, 79, 450, 80, 455, 85, 455, 90, 455,
 93, 453, 94, 447, 93, 444, 93"
                                                        HotSpotMode="PostBack" PostBackValue="Right Mirror" />
                                                    <%-- Rotate View Front Image --%>
                                                    <asp:PolygonHotSpot AlternateText="Rotate View Front Image"
                                                        Coordinates="34,14,48,19,54,32,52,
                                43,34,57,17,48,14,36,16,24,23,18"
                                                        HotSpotMode="PostBack" PostBackValue="Rotate View Front Image" />
                                                </asp:ImageMap>




                                            </div>
                                            <div class="col-lg-4" style="width: 238px; border-width: 1px; border-style: solid; border-color: black; height: 270px; float: right; margin-right: 152px; margin-top: 5%;">

                                                <asp:Label ID="Partname" runat="server" ForeColor="#33CC33"></asp:Label>

                                                <%-- Front Image --%>
                                                <%-- 1.Front Bumper --%>
                                                <asp:CheckBoxList runat="server" ID="cbl_FrontBumper" Height="51px" Width="257px" OnSelectedIndexChanged="FrontBumper_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%-- 2.Hood --%>
                                                <asp:CheckBoxList runat="server" ID="cbl_Hood" Height="51px" Width="257px" OnSelectedIndexChanged="Hood_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%-- 3.Roof --%>
                                                <asp:CheckBoxList runat="server" ID="cbl_Roof" Height="51px" Width="257px" OnSelectedIndexChanged="Roof_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%-- 4.Front Left Fender --%>
                                                <asp:CheckBoxList runat="server" ID="cbl_FrontLeftFender" Height="51px" Width="257px" OnSelectedIndexChanged="FrontLeftFender_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%-- 5.Front Left Door --%>
                                                <asp:CheckBoxList runat="server" ID="cbl_FrontLeftDoor" Height="51px" Width="257px" OnSelectedIndexChanged="FrontLeftDoor_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%--6.Rear Left Door--%>
                                                <asp:CheckBoxList runat="server" ID="cbl_RearLeftDoor" Height="51px" Width="257px" OnSelectedIndexChanged="RearLeftDoor_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%-- 7.Rear Left Quarter Panel --%>
                                                <asp:CheckBoxList runat="server" ID="cbl_RearLeftQuarterPanel" Height="51px" Width="257px" OnSelectedIndexChanged="RearLeftQuarterPanel_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%-- 8.Front Left Window --%>
                                                <asp:CheckBoxList runat="server" ID="cbl_FrontLeftWindow" Height="51px" Width="257px" OnSelectedIndexChanged="FrontLeftWindow_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%-- 9.Rear Left Window --%>
                                                <asp:CheckBoxList runat="server" ID="cbl_RearLeftWindow" Height="51px" Width="257px" OnSelectedIndexChanged="RearLeftWindow_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%-- 10.Front Windshield --%>
                                                <asp:CheckBoxList runat="server" ID="cbl_FrontWindshield" Height="51px" Width="257px" OnSelectedIndexChanged="FrontWindshield_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%-- 11.Front Left Wheel & Tire --%>
                                                <asp:CheckBoxList runat="server" ID="cbl_FrontLeftWheelTire" Height="51px" Width="257px" OnSelectedIndexChanged="FrontLeftWheelTire_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%-- 12.Rear Left Wheel & Tire --%>
                                                <asp:CheckBoxList runat="server" ID="cbl_RearLeftWheelTire" Height="51px" Width="257px" OnSelectedIndexChanged="RearLeftWheelTire_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%-- 13.Front Left Headlight --%>
                                                <asp:CheckBoxList runat="server" ID="cbl_FrontLeftHeadlight" Height="51px" Width="257px" OnSelectedIndexChanged="FrontLeftHeadlight_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%-- 14.Front Right Headlight --%>
                                                <asp:CheckBoxList runat="server" ID="cbl_FrontRightHeadlight" Height="51px" Width="257px" OnSelectedIndexChanged="FrontRightHeadlight_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%-- 15.Left Mirror --%>
                                                <asp:CheckBoxList runat="server" ID="cbl_LeftMirror" Height="51px" Width="257px" OnSelectedIndexChanged="LeftMirror_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>

                                                <%--Back Image--%>
                                                <%--16.Roof1--%>
                                                <asp:CheckBoxList runat="server" ID="cbl_Roof1" Height="51px" Width="257px" OnSelectedIndexChanged="Roof_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%--17.Trunk--%>
                                                <asp:CheckBoxList runat="server" ID="cbl_Trunk" Height="51px" Width="257px" OnSelectedIndexChanged="Trunk_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%--18.Rear Bumper--%>
                                                <asp:CheckBoxList runat="server" ID="cbl_RearBumper" Height="51px" Width="257px" OnSelectedIndexChanged="RearBumper_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%--19.Rear Right Quarter Panel--%>
                                                <asp:CheckBoxList runat="server" ID="cbl_RearRightQuarterPanel" Height="51px" Width="257px" OnSelectedIndexChanged="RearRightQuarterPanel_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%--20.Front Right Fender--%>
                                                <asp:CheckBoxList runat="server" ID="cbl_FrontRightFender" Height="51px" Width="257px" OnSelectedIndexChanged="FrontRightFender_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%--21.Front Right Door--%>
                                                <asp:CheckBoxList runat="server" ID="cbl_FrontRightDoor" Height="51px" Width="257px" OnSelectedIndexChanged="FrontRightDoor_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%--22.Rear Right Door--%>
                                                <asp:CheckBoxList runat="server" ID="cbl_RearRightDoor" Height="51px" Width="257px" OnSelectedIndexChanged="RearRightDoor_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%--23.Front Right Window--%>
                                                <asp:CheckBoxList runat="server" ID="cbl_FrontRightWindow" Height="51px" Width="257px" OnSelectedIndexChanged="FrontRightWindow_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%--24.Rear Right Window--%>
                                                <asp:CheckBoxList runat="server" ID="cbl_RearRightWindow" Height="51px" Width="257px" OnSelectedIndexChanged="RearRightWindow_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%--25.Rear Windshield--%>
                                                <asp:CheckBoxList runat="server" ID="cbl_RearWindshield" Height="51px" Width="257px" OnSelectedIndexChanged="RearWindshield_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%--26.Front Right Wheel & Tire--%>
                                                <asp:CheckBoxList runat="server" ID="cbl_FrontRightWheelTire" Height="51px" Width="257px" OnSelectedIndexChanged="FrontRightWheelTire_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%--27.Rear Right Wheel & Tire--%>
                                                <asp:CheckBoxList runat="server" ID="cbl_RearRightWheelTire" Height="51px" Width="257px" OnSelectedIndexChanged="RearRightWheelTire_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%--28.Right Tail Light--%>
                                                <asp:CheckBoxList runat="server" ID="cbl_RightTailLight" Height="51px" Width="257px" OnSelectedIndexChanged="RightTailLight_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%--29.Left Tail Light(driver side)--%>
                                                <asp:CheckBoxList runat="server" ID="cbl_LeftTailLightdriverside" Height="51px" Width="257px" OnSelectedIndexChanged="LeftTailLightdriverside_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>
                                                <%--30.Right Mirror--%>
                                                <asp:CheckBoxList runat="server" ID="cbl_RightMirror" Height="51px" Width="257px" OnSelectedIndexChanged="RightMirror_SelectedItems" AutoPostBack="true"></asp:CheckBoxList>


                                            </div>

                                            <div class="col-lg-8" style="margin-top: 1%">
                                                <span style="font-family: Verdana; text-align: center; margin-top: 50px; width: 832px; height: 16px; margin-left: 52%;">Exterior condition summary
                                                </span>


                                            </div>
                                            <div class="col-lg-12" style="border: 1px solid; width: 832px; height: 252px; float: right; margin-right: 150px; margin-top: 31px; padding-top: 1%; overflow-y: scroll;">
                                                <%--<div id="FrontBumper_Div" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                   
                                                <%--</div>--%>
                                                <%--<div id="gv_Hood_Div" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    <asp:GridView ID="gv_Hood" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_Hood_RowCommand" OnRowDeleting="gv_Hood_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Hood">

                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>

                                                        </Columns>
                                                    </asp:GridView>
                                               <%-- </div>--%>
                                                <%--<div id="gv_Roof_div" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    <asp:GridView ID="gv_Roof" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_Roof_RowCommand" OnRowDeleting="gv_Roof_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Roof">

                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>

                                                        </Columns>
                                                    </asp:GridView>
                                                <%--</div>--%>
                                                <%--<div id="gv_FrontLeftFender_Div" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    <asp:GridView ID="gv_FrontLeftFender" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_FrontLeftFender_RowCommand" OnRowDeleting="gv_FrontLeftFender_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Front Left Fender">

                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>

                                                        </Columns>
                                                    </asp:GridView>
                                                <%--</div>--%>
                                                <%--<div id="gv_FrontLeftDoor_Div" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    <asp:GridView ID="gv_FrontLeftDoor" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_FrontLeftDoor_RowCommand" OnRowDeleting="gv_FrontLeftDoor_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Front Left Door">

                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>

                                                        </Columns>
                                                    </asp:GridView>
                                                <%--</div>--%>
                                                <%--<div id="gv_RearLeftDoor_Div" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    <asp:GridView ID="gv_RearLeftDoor" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_RearLeftDoor_RowCommand" OnRowDeleting="gv_RearLeftDoor_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Rear Left Door">

                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>

                                                        </Columns>
                                                    </asp:GridView>
                                                <%--</div>--%>
                                                <%--<div id="gv_RearLeftQuarterPanelDiv10" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    <asp:GridView ID="gv_RearLeftQuarterPanel" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_RearLeftQuarterPanel_RowCommand" OnRowDeleting="gv_RearLeftQuarterPanel_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Rear Left Quarter Panel">
                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />
                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>
                                                        </Columns>
                                                    </asp:GridView>
                                                <%--</div>--%>
                                               <%-- <div id="gv_FrontLeftWindowDiv11" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    <asp:GridView ID="gv_FrontLeftWindow" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_FrontLeftWindow_RowCommand" OnRowDeleting="gv_FrontLeftWindow_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Front Left Window">
                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />
                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>
                                                        </Columns>
                                                    </asp:GridView>
                                                <%--</div>--%>
                                                <%--<div id="gv_RearLeftWindowDiv12" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    <asp:GridView ID="gv_RearLeftWindow" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_RearLeftWindow_RowCommand" OnRowDeleting="gv_RearLeftWindow_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Rear Left Window">
                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />
                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>
                                                        </Columns>
                                                    </asp:GridView>
                                                <%--</div>--%>
                                                <%--<div id="gv_FrontWindshieldDiv13" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    <asp:GridView ID="gv_FrontWindshield" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_FrontWindshield_RowCommand" OnRowDeleting="gv_FrontWindshield_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Front Windshield">
                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />
                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>
                                                        </Columns>
                                                    </asp:GridView>
                                                <%--</div>--%>
                                               <%-- <div id="gv_FrontLeftWheelTireDiv14" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    
                                                <%--</div>--%>
                                               <%-- <div id="gv_RearLeftWheelTireDiv15" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    <asp:GridView ID="gv_RearLeftWheelTire" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_RearLeftWheelTire_RowCommand" OnRowDeleting="gv_RearLeftWheelTire_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Rear Left Wheel & Tire">
                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />
                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>
                                                        </Columns>
                                                    </asp:GridView>
                                                <%--</div>--%>
                                                <%--<div id="gv_FrontLeftHeadlightDiv16" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    <asp:GridView ID="gv_FrontLeftHeadlight" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_FrontLeftHeadlight_RowCommand" OnRowDeleting="gv_FrontLeftHeadlight_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Front Left Headlight">
                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />
                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>
                                                        </Columns>
                                                    </asp:GridView>
                                                <%--</div>--%>
                                                <%--<div id="gv_FrontRightHeadlightDiv17" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    <asp:GridView ID="gv_FrontRightHeadlight" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_FrontRightHeadlight_RowCommand" OnRowDeleting="gv_FrontRightHeadlight_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Front Right Headlight">
                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />
                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>
                                                        </Columns>
                                                    </asp:GridView>
                                                <%--</div>--%>
                                               <%-- <div id="gv_LeftMirrorDiv18" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    <asp:GridView ID="gv_LeftMirror" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_LeftMirror_RowCommand" OnRowDeleting="gv_LeftMirror_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Left Mirror">
                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />
                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>
                                                        </Columns>
                                                    </asp:GridView>
                                                <%--</div>--%>
                                                <%--<div id="gv_TrunkDiv19" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    <asp:GridView ID="gv_Trunk" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_Trunk_RowCommand" OnRowDeleting="gv_Trunk_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Trunk">
                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />
                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>
                                                        </Columns>
                                                    </asp:GridView>
                                                <%--</div>--%>
                                               <%-- <div id="gv_RearBumperDiv20" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    <asp:GridView ID="gv_RearBumper" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_RearBumper_RowCommand" OnRowDeleting="gv_RearBumper_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Rear Bumper">
                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />
                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>
                                                        </Columns>
                                                    </asp:GridView>
                                                <%--</div>--%>
                                               <%-- <div id="gv_RearRightQuarterPanelDiv21" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    <asp:GridView ID="gv_RearRightQuarterPanel" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_RearRightQuarterPanel_RowCommand" OnRowDeleting="gv_RearRightQuarterPanel_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Rear Right Quarter Panel">
                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />
                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>
                                                        </Columns>
                                                    </asp:GridView>
                                                <%--</div>--%>
                                               <%-- <div id="gv_FrontRightFenderDiv22" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    <asp:GridView ID="gv_FrontRightFender" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_FrontRightFender_RowCommand" OnRowDeleting="gv_FrontRightFender_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Front Right Fender">
                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />
                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>
                                                        </Columns>
                                                    </asp:GridView>
                                                <%--</div>--%>
                                               <%-- <div id="gv_FrontRightDoorDiv23" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    <asp:GridView ID="gv_FrontRightDoor" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_FrontRightDoor_RowCommand" OnRowDeleting="gv_FrontRightDoor_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Front Right Door">
                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />
                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>
                                                        </Columns>
                                                    </asp:GridView>
                                                <%--</div>--%>
                                                <%--<div id="gv_RearRightDoorDiv24" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    <asp:GridView ID="gv_RearRightDoor" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_RearRightDoor_RowCommand" OnRowDeleting="gv_RearRightDoor_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Rear Right Door">
                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />
                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>
                                                        </Columns>
                                                    </asp:GridView>
                                                <%--</div>--%>
                                               <%-- <div id="gv_FrontRightWindowDiv25" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    <asp:GridView ID="gv_FrontRightWindow" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_FrontRightWindow_RowCommand" OnRowDeleting="gv_FrontRightWindow_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Front Right Window">
                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />
                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>
                                                        </Columns>
                                                    </asp:GridView>
                                                <%--</div>--%>
                                               <%-- <div id="gv_RearRightWindowDiv26" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    <asp:GridView ID="gv_RearRightWindow" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_RearRightWindow_RowCommand" OnRowDeleting="gv_RearRightWindow_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Rear Right Window">
                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />
                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>
                                                        </Columns>
                                                    </asp:GridView>
                                               <%-- </div>--%>
                                                <%--<div id="gv_RearWindshieldDiv27" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    <asp:GridView ID="gv_RearWindshield" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_RearWindshield_RowCommand" OnRowDeleting="gv_RearWindshield_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Rear Windshield">
                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />
                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>
                                                        </Columns>
                                                    </asp:GridView>
                                                <%--</div>--%>
                                               <%-- <div id="gv_FrontRightWheelTireDiv28" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    <asp:GridView ID="gv_FrontRightWheelTire" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_FrontRightWheelTire_RowCommand" OnRowDeleting="gv_FrontRightWheelTire_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Front Right Wheel & Tire">
                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />
                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>
                                                        </Columns>
                                                    </asp:GridView>
                                                <%--</div>--%>
                                                <%--<div id="gv_RearRightWheelTireDiv29" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    <asp:GridView ID="gv_RearRightWheelTire" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_RearRightWheelTire_RowCommand" OnRowDeleting="gv_RearRightWheelTire_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Rear Right Wheel & Tire">
                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />
                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>
                                                        </Columns>
                                                    </asp:GridView>
                                               <%-- </div>--%>
                                               <%-- <div id="gv_RightTailLightDiv30" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    <asp:GridView ID="gv_RightTailLight" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_RightTailLight_RowCommand" OnRowDeleting="gv_RightTailLight_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Right Tail Light">
                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />
                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>
                                                        </Columns>
                                                    </asp:GridView>
                                               <%-- </div>--%>
                                               <%-- <div id="gv_LeftTailLightdriversideDiv31" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    <asp:GridView ID="gv_LeftTailLightdriverside" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_LeftTailLightdriverside_RowCommand" OnRowDeleting="gv_LeftTailLightdriverside_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Left Tail Light(driver side)">
                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />
                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>
                                                        </Columns>
                                                    </asp:GridView>


                                                <asp:GridView ID="gv_FrontLeftWheelTire" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_FrontLeftWheelTire_RowCommand" OnRowDeleting="gv_FrontLeftWheelTire_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Front Left Wheel & Tire">
                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />
                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>
                                                        </Columns>
                                                    </asp:GridView>



                                                <%--</div>--%>
                                               <%-- <div id="gv_RightMirrorDiv32" class="col-lg-6" style="margin-top: 1%;" runat="server" visible="false">--%>
                                                    <asp:GridView ID="gv_RightMirror" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_RightMirror_RowCommand" OnRowDeleting="gv_RightMirror_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Right Mirror">
                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />
                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>
                                                        </Columns>
                                                    </asp:GridView>
                                                <%--</div>--%>

                                                 <asp:GridView ID="gv_FrontBumper" runat="server" AutoGenerateColumns="False" BorderStyle="None" OnRowCommand="gv_FrontBumper_RowCommand" OnRowDeleting="gv_FrontBumper_RowDeleting" CssClass="col-lg-6" style="margin-top:1%;">
                                                        <Columns>
                                                            <asp:TemplateField ItemStyle-Width="30px">

                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="IMG" runat="server" ImageUrl="../images/Images/close%20copy.png" Width="15px" Height="15px" CommandName="Delete" CommandArgument='<%#Eval("id")%>' />
                                                                </ItemTemplate>
                                                                <HeaderStyle BorderStyle="None" />
                                                                <ItemStyle BorderStyle="None" />
                                                            </asp:TemplateField>
                                                            <asp:BoundField DataField="Content" HeaderText="Front Bumper">

                                                                <HeaderStyle BorderStyle="None" ForeColor="#33CC33" />

                                                                <ItemStyle BorderStyle="None" BorderWidth="10px" />
                                                            </asp:BoundField>

                                                        </Columns>
                                                    </asp:GridView>



                                                <%--</div>--%>
                                           </div>



                                            <div class="col-lg-8" style="margin-top: 2%; margin-left: 4%;">
                                                <a href="#" class="tooltips" tabindex="1">
                                                    <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -2%;" />
                                                    <span style="width: 250px; height: 100px; padding: 2%;">Please rate the overall Interior condition of your vehicle.Excellent being like new condition.</span>
                                                </a>Interior condition.

                                            </div>
                                            <div class="col-lg-6" style="margin-top: 2%; margin-left: 4%;">
                                                <img src="../images/Images/interior.png" style="width: 63%; margin-left: 4%;" />
                                            </div>
                                            <div class="col-lg-6" style="margin-top: -8%; margin-left: 42%;">
                                                <asp:RadioButtonList ID="Interior_COndition_RadiobtnLst" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow" ValidationGroup="rd" CellSpacing="100" CellPadding="100" ForeColor="Black">
                                                    <asp:ListItem Text="Excellent" Value="Excellent" class="radiobuttonlist1"></asp:ListItem>
                                                    <asp:ListItem Text="Good" Value="Good" class="radiobuttonlist1"></asp:ListItem>
                                                    <asp:ListItem Text="Average" Value="Average" class="radiobuttonlist1"></asp:ListItem>
                                                    <asp:ListItem Text="Poor" Value="Poor" class="radiobuttonlist1"></asp:ListItem>

                                                </asp:RadioButtonList>
                                                <asp:RequiredFieldValidator runat="server" ID="Reqrdfieldval1" ControlToValidate="Interior_COndition_RadiobtnLst" Text="Required" ValidationGroup="rd">
                                                </asp:RequiredFieldValidator>

                                            </div>


                                            <div class="col-lg-8" style="margin-top: 2%; margin-left: 4%;">
                                                <a href="#" class="tooltips" tabindex="1">
                                                    <img src="../images/Images/6%201copy.png" style="width: 3%; margin-top: 2%; margin-left: -2%;" />
                                                    <span style="width: 250px; height: 100px; padding: 2%;">Please rate the overall Mechanical condition of your vehicle.Excellent being like new condition.</span>
                                                </a>Mechanical condition.

                                            </div>


                                            <div class="col-lg-6" style="margin-top: 5%; margin-left: 4%;">
                                                <img src="../images/Images/Mechanic.png" style="width: 63%; margin-left: 4%;" />
                                            </div>
                                            <div class="col-lg-6" style="margin-top: 11%; margin-left: -12%;">
                                                <asp:RadioButtonList ID="Mechanical_COndition_radiobtn" runat="server" RepeatDirection="Horizontal" ValidationGroup="rd" Style="margin-left: 1%;" RepeatLayout="Flow" CellSpacing="200" CellPadding="20" ForeColor="Black">
                                                    <asp:ListItem Text="Excellent" Value="Excellent" class="radiobuttonlist1"></asp:ListItem>
                                                    <asp:ListItem Text="Good" Value="Good" class="radiobuttonlist1"></asp:ListItem>
                                                    <asp:ListItem Text="Average" Value="Average" class="radiobuttonlist1"></asp:ListItem>
                                                    <asp:ListItem Text="Poor" Value="Poor" class="radiobuttonlist1"></asp:ListItem>

                                                </asp:RadioButtonList><asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator2" ControlToValidate="Mechanical_COndition_radiobtn" Text="Required" ValidationGroup="rd"></asp:RequiredFieldValidator>

                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>

                                </div>



                                <div class="col-lg-11" style="margin-top: 1%;">

                                    <asp:ImageButton ID="Vehicle_condition_detail_Backbtn" runat="server" ImageUrl="../images/Images/11%20copy.png" Style="width: 14%; margin-left: 5%; padding-bottom: 20px; margin-top: 14%; margin-bottom: 10%;" OnClick="Vehicle_condition_detail_Backbtn_Click" />
                                    <asp:ImageButton ID="Vehicle_condition_detail_nextbtn" runat="server" ImageUrl="../images/Images/5%20copy.png" Style="float: right; width: 14%; margin-bottom: 16px; margin-right: 1px; margin-top: 14%;" OnClick="Vehicle_condition_detail_nextbtn_Click" ValidationGroup="rd" />

                                    <asp:ImageButton ID="Vehicle_condition_details_updateBtn" runat="server" ImageUrl="../images/Images/2.png" Style="float: right; width: 14%; margin-bottom: 16px; margin-right: 1px; margin-top: 14%;"
                                        OnClick="Vehicle_condition_details_updateBtn_Click" Visible="false" />
                                </div>

                            </div>
                        </asp:View>
                        <!-- DIV 5-->
                        <%-- DIv 6--%>
                        <asp:View ID="view6" runat="server">
                            <div class="container  maindiv" id="div1" style="display: block; background: white;" runat="server">
                                <img src="../images/Images/16%20copy.png" style="width: 96%; margin-top: 1%; margin-left: 1%;" />

                                <p>
                                    Please review the information below to ensure accuracy. Then click the submit button at the bottom of the page to complete.
         <img src="../images/Images/24%20copy.png" style="width: 96%; margin-top: 1%; margin-left: 1%;" />
                                </p>

                                <div class="col-lg-12">
                                    <div class="col-lg-6" style="margin-top: 1%;">
                                      <%--<asp:Image ID="summary_image" runat="server" style="margin-top: 1%; width: 39%; margin-left: 22%"; />--%>
                                        <asp:Image ID="Image2" runat="server" style="margin-top: 1%; width: 39%; margin-left: 22%" />
                                        <%--<asp:Image ID="sumimage" runat="server" style="margin-top: 1%; width: 39%; margin-left: 22%"; />--%>
                                        <%--<img src="../images/car.jpg" style="margin-top: 1%; width: 39%; margin-left: 22%" />--%>
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
                                        <asp:ImageButton runat="server" ID="Edit_btn_Appriaslform" ImageUrl="../images/Images/17%20copy.png" Style="float: right; width: 9%; margin-bottom: 50px; margin-right: 241px; margin-top: 3%;" OnClick="Edit_btn_OwnerInformation_Click" />
                                    </div>
                                </div>

                                <%--Accordion bootstrap--%>
                                <%--<div class="col-lg-12" style="margin-top:1%">--%>
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

                
            </table>

                                            </center>

                                            <asp:ImageButton runat="server" ID="VehicleDetails_editbtn" ImageUrl="../images/Images/17%20copy.png" Style="float: right; width: 9%; margin-bottom: 50px; margin-right: 266px; margin-top: 3%;" OnClick="VehicleDetails_editbtn_Click" />
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


                                <%--second accordion--%><%--<img src="../images/Images/19%20copy.png" />--%>


                                <div class="col c1" style="margin-top: 3%; margin-bottom: 3%; width: 99%; margin-left: 1%;">
                                    <h2></h2>
                                    <div id="Div2" data-collapse>
                                        <%-- <img src="../images/Images/12%20copy.png" />--%>
                                        <h3>
                                            <img src="../images/Images/19%20copy.png" style="width: 97%; margin-top: -16%" /></h3>
                                        <div>
                                            <center>
        <div runat="server" id="maindiv_tale">
           <asp:Label ID="VehicleOptFeaturesNoSelectionText" runat="server" Text="Label" Visible="false">
               <b>You have have not selected any options.</b><br />
Our appraisal could be thousands of dollars higher or lower based on this information alone.<br />
Click the “edit” button if you would like to go back and correct step #4.
           </asp:Label>
        
       </div>
                </center>
                                            <asp:ImageButton runat="server" ID="Vehicle_options_Features_Editbtn" ImageUrl="../images/Images/17%20copy.png" Style="float: right; width: 9%; margin-bottom: 50px; margin-right: 266px; margin-top: 3%;" OnClick="Vehicle_options_Features_Editbtn_Click" />
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
                                
                                <%--second accordion--%>

                                <div class="col c1" style="margin-top: 1%; margin-bottom: 0%; width: 99%; margin-left: 1%;">
                                    <h2></h2>
                                    <div id="Div6" data-collapse>

                                        <h3>
                                            <img src="../images/Images/condition.png" style="width: 97%; margin-top: -16%" /></h3>
                                        
                                        <div class="col-lg-12" runat="server" id="outerdiv_Vehiclecondition" style="margin-bottom: 10%; margin-left:9%;">
                                            
          <table style="margin-left:0%;"> 
              <tr style="border-bottom: solid 1px; width: 100%;">
                  <td style="width: 250px;">Overall exterior condition:</td>
                        <td style="width: 50px;"></td>
                        <td id="hadselection" style="width: 400px;" runat="server" visible="false">Following exterior blemishes or damages indicated.</td>
              <td id="noselection" style="width: 400px;" runat="server" visible="false"><asp:Label Text="Excellent" ForeColor="Black" Font-Bold="true" runat="server"></asp:Label> (No exterior blemishes or damages indicated).</td>
                  </tr>

          </table>


         <%--<div id="Fb_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                         
         <%-- </div>--%>

          <%-- <div id="Hood_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                   <asp:GridView ID="Gvd_Hood" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-bottom:1%;margin-top:1%;">
                          <Columns>
                             <asp:BoundField DataField="Content" HeaderText="Hood">
                                 <HeaderStyle BorderStyle="None" ForeColor="#33CC33" HorizontalAlign="Left" />
                                   <ItemStyle BorderStyle="None" BorderWidth="10px" HorizontalAlign="Left" />
                             </asp:BoundField>
                              </Columns>
                          </asp:GridView>
             <%--</div>--%>

           <%--<div id="Roof_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                   <asp:GridView ID="Gvd_Rooof" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-bottom:1%;margin-top:1%;">
                          <Columns>
                             <asp:BoundField DataField="Content" HeaderText="Roof">
                                 <HeaderStyle BorderStyle="None" ForeColor="#33CC33" HorizontalAlign="Left" />
                                   <ItemStyle BorderStyle="None" BorderWidth="10px" HorizontalAlign="Left" />
                             </asp:BoundField>
                              </Columns>
                          </asp:GridView>
             <%--</div>--%>

           <%-- <div id="Front_Left_fender_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                   <asp:GridView ID="Gvd_Front_left_Fender" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-bottom:1%;margin-top:1%;">
                          <Columns>
                             <asp:BoundField DataField="Content" HeaderText="Front Left Fender">
                                 <HeaderStyle BorderStyle="None" ForeColor="#33CC33"  HorizontalAlign="Left"/>
                                   <ItemStyle BorderStyle="None" BorderWidth="10px" HorizontalAlign="Left" />
                             </asp:BoundField>
                              </Columns>
                          </asp:GridView>
           <%--  </div>--%>

           <%--<div id="Front_Left_Door_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                    <asp:GridView ID="Gvd_FrontLeftDoor" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-bottom:1%;margin-top:1%;">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="Content" HeaderText="Front Left Door">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" HorizontalAlign="Left" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" HorizontalAlign="Left"/>
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            <%--</div>--%>

          <%-- <div id="RearLeftDoor_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                    <asp:GridView ID="Gvd_Rear_Left_door" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-bottom:1%;margin-top:1%;">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="Content" HeaderText="Rear Left Door">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" HorizontalAlign="Left" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" HorizontalAlign="Left" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
           <%-- </div>--%>

           <%-- <div id="RearLeftQuarterPanel_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                    <asp:GridView ID="Gvd_RearLeftQuarterPanel" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-bottom:1%;margin-top:1%;">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="Content" HeaderText="Rear Left Quarter Panel">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" HorizontalAlign="Left" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" HorizontalAlign="Left" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            <%--</div>--%>

            <%--<div id="FrontLeftWindow_Div_summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                    <asp:GridView ID="Gvd_FrontLeftWindow" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-bottom:1%;margin-top:1%;">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="Content" HeaderText="Front Left Window">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33"  HorizontalAlign="Left"/>

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" HorizontalAlign="Left" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
           <%-- </div>--%>

            <%--<div id="RearLeftWindow_Div_summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                    <asp:GridView ID="Gvd_RearLeftWindow" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-bottom:1%;margin-top:1%;">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="Content" HeaderText="Rear Left Window">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" HorizontalAlign="Left" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" HorizontalAlign="Left" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
           <%-- </div>--%>

            <%--<div id="FrontWindshield_Div_summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                    <asp:GridView ID="Gvd_FrontWindshield" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-bottom:1%;margin-top:1%;">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="Content" HeaderText="Front Windshield">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" HorizontalAlign="Left" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" HorizontalAlign="Left" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
           <%-- </div>--%>

            <%--<div id="FrontLeftWheelTire_Div_summary" class="col-lg-5" style="margin-top:0%;margin-bottom:1%; margin-left:2%;" runat="server" visible="false">--%>
                    <asp:GridView ID="Gvd_FrontLeftWheelTire" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-bottom:1%;margin-top:1%;">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="Content" HeaderText="Front Left Wheel & Tire">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" HorizontalAlign="Left" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px"  HorizontalAlign="Left"/>
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            <%--</div>--%>

            <%--<div id="RearLeftWheelTire_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                    
           <%-- </div>--%>

            <%--<div id="FrontLeftHeadligh_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                    <asp:GridView ID="Gvd_FrontLeftHeadligh" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-bottom:1%;margin-top:1%;">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="Content" HeaderText="Front Left Headlight">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" HorizontalAlign="Left" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" HorizontalAlign="Left" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            <%--</div>--%>

            <%--<div id="FrontRighttHeadligh_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                    <asp:GridView ID="Gvd_FrontrightHeadlight" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-bottom:1%;margin-top:1%;">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="Content" HeaderText="Front Right Headlight">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" HorizontalAlign="Left" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" HorizontalAlign="Left" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
         <%--   </div>--%>

   

                                           

            <%--<div id="LeftMirror_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                    <asp:GridView ID="Gvd_LeftMirror" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-bottom:1%;margin-top:1%;">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="Content" HeaderText="Left Mirror">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" HorizontalAlign="Left" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" HorizontalAlign="Left" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
           <%-- </div>--%>

           <%-- <div id="Trunk_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                    <asp:GridView ID="Gvd_Trunk" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-bottom:1%;margin-top:1%;">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="Content" HeaderText="Trunk">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" HorizontalAlign="Left" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" HorizontalAlign="Left" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
           <%-- </div>--%>

            <%--<div id="RearBumper_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                    <asp:GridView ID="Gvd_RearBumper" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-bottom:1%;margin-top:1%;">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="Content" HeaderText="Rear Bumper">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" HorizontalAlign="Left" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px"  HorizontalAlign="Left"/>
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
           <%-- </div>--%>

           <%-- <div id="RearRightQuarterPanel_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                    <asp:GridView ID="Gvd_RearRightQuarterPanel" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-bottom:1%;margin-top:1%;">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="Content" HeaderText="Rear Right Quarter Panel">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" HorizontalAlign="Left" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px"  HorizontalAlign="Left"/>
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            <%--</div>--%>

          <%-- <div id="FrontRightFender_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                    <asp:GridView ID="Gvd_FrontRightFender" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-bottom:1%;margin-top:1%;">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="Content" HeaderText="Front Right Fender">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" HorizontalAlign="Left" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" HorizontalAlign="Left" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            <%--</div>--%>

            <%--<div id="FrontRightDoor_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                    <asp:GridView ID="Gvd_FrontRightDoor" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-bottom:1%;margin-top:1%;">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="Content" HeaderText="Front Right Door">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" HorizontalAlign="Left" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" HorizontalAlign="Left" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            <%--</div>--%>

           <%--<div id="RearRightDoor_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                    <asp:GridView ID="Gvd_RearRightDoor" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-bottom:1%;margin-top:1%;">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="Content" HeaderText="Rear Right Door">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" HorizontalAlign="Left" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px"  HorizontalAlign="Left"/>
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
           <%-- </div>--%>

            <%--<div id="FrontRightWindow_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                    <asp:GridView ID="Gvd_FrontRightWindow" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-bottom:1%;margin-top:1%;">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="Content" HeaderText="Front Right Window">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" HorizontalAlign="Left" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" HorizontalAlign="Left" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
           <%-- </div>--%>

           <%--<div id="RearRightWindow_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                    <asp:GridView ID="Gvd_RearRightWindow" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-bottom:1%;margin-top:1%;">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="Content" HeaderText="Rear Right Window">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" HorizontalAlign="Left" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" HorizontalAlign="Left" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
          <%--  </div>--%>

            <%--<div id="RearWindshield_Div_summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                    <asp:GridView ID="Gvd_RearWindshield" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-bottom:1%;margin-top:1%;">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="Content" HeaderText="Rear Windshield">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" HorizontalAlign="Left" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" HorizontalAlign="Left" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
           <%-- </div>--%>

           <%--<div id="FrontRightWheelTire_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                    <asp:GridView ID="Gvd_FrontRightWheelTire" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-bottom:1%;margin-top:1%;">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="Content" HeaderText="Front Right Wheel & Tire">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" HorizontalAlign="Left" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" HorizontalAlign="Left" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            <%--</div>--%>

            <%--<div id="RearRightWheelTire_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                    <asp:GridView ID="Gvd_RearRightWheelTire" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-bottom:1%;margin-top:1%;">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="Content" HeaderText="Rear Right Wheel & Tire">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" HorizontalAlign="Left" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" HorizontalAlign="Left" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
           <%-- </div>--%>

            <%--<div id="RightTailLight_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                    <asp:GridView ID="Gvd_RightTailLight" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-bottom:1%;margin-top:1%;">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="Content" HeaderText="Right Tail Light">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" HorizontalAlign="Left" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" HorizontalAlign="Left" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            <%--</div>--%>

            <%--<div id="LeftTailLight_Div_summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                    <asp:GridView ID="Gvd_LeftTailLight" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-bottom:1%;margin-top:1%;">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="Content" HeaderText="Left Tail Light(driver side)">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" HorizontalAlign="Left" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" HorizontalAlign="Left" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            <%--</div>--%>

           <%-- <div id="RightMirror_Div_Summary" class="col-lg-5" style="margin-top: 1%;margin-bottom:1%;" runat="server" visible="false">--%>
                    <asp:GridView ID="Gvd_RightMirror" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="Content" HeaderText="Right Mirror">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" HorizontalAlign="Left" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px"  HorizontalAlign="Left"/>
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>
            <%--</div>--%>
                                            <asp:GridView ID="Gvd_RearLeftWheelTire" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-bottom:1%;margin-top:1%;">
                                     <Columns>
                                                                    
                                     <asp:BoundField DataField="Content" HeaderText="Rear Left Wheel & Tire">

                                        <HeaderStyle BorderStyle="None" ForeColor="#33CC33" HorizontalAlign="Left" />

                                  <ItemStyle BorderStyle="None" BorderWidth="10px" HorizontalAlign="Left" />
                                   </asp:BoundField>

                            </Columns>
                     </asp:GridView>

                         <asp:GridView ID="Gvd_FrontBumper" runat="server" AutoGenerateColumns="False" BorderStyle="None" HorizontalAlign="Left" CssClass="col-lg-5" style="margin-top:1%;margin-bottom:1%;">
                                  <Columns>
                                 <asp:BoundField DataField="Content" HeaderText="Front Bumper">

                              <HeaderStyle BorderStyle="None" ForeColor="#33CC33" HorizontalAlign="Left" />

                            <ItemStyle BorderStyle="None" BorderWidth="10px" HorizontalAlign="Left" />
                        </asp:BoundField>

                     </Columns>
                     </asp:GridView>
        <br /><br />
          <div class="col-lg-11" id="Interior_Mechanical" style="margin-bottom:1%;">       
           <table style="margin-top:1%; margin-bottom:1%;margin-left:-2%;"> 
              <tr style="border-bottom: solid 1px; width: 100%;">
                  <td style="width: 250px;">Overall interior condition:</td>
                        <td style="width: 51px;"></td>
                     <td id="interiorcondition_td" style="width: 400px;" runat="server"> 
                  <asp:Label runat="server" ID="OverallinteriorconditionText" ForeColor="Black" Font-Bold="true"></asp:Label></td>
             </tr>
                     <tr style="border-bottom: solid 1px; width: 100%;">
                        <td style="width: 250px;">Overall mechanical condition:</td>
                        <td style="width: 51px;"></td>
                         <td id="mechanicalcondition_td" style="width: 400px;" runat="server"> 
                        <asp:Label runat="server" ID="OverallmechanicalconditionText" ForeColor="Black" Font-Bold="true"></asp:Label></td>
                        
                  </tr>
          </table>
         </div>

                                            <div class="col-lg-10" id="for_editbtn">
                                                <asp:ImageButton runat="server" ID="Vehicle_Condition_Details_EditBtn" ImageUrl="../images/Images/17%20copy.png" Style="float: right; width: 12%; margin-bottom: 20px; margin-right: 65px; margin-top: 3%;" OnClick="Vehicle_Condition_Details_EditBtn_Click" />
                                            </div>

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


                                <%-- <div class="col-lg-12" style="margin-top: 0%; margin-bottom: 3%;">--%>
                                <img src="../images/Images/upload.png" style="width: 98%; margin-top: 1%" />

                                <div class="col-lg-10" runat="server" style="margin-top: 1%;" id="imagediv">

<%--<asp:Label runat="server" ID="NoImageTagText" Visible="false">You have not uploaded photos yet. Uploading photos could make a difference in the value of your vehicle.</asp:Label>--%>
                               
                                     </div>
                                <asp:ImageButton runat="server" ID="Vehicle_photos_Editbtn" ImageUrl="../images/Images/17%20copy.png" Style="float: right; width: 9%; margin-bottom: 50px; margin-right: 280px; margin-top: 2%;" OnClick="Vehicle_photos_Editbtn_Click" />

                                <img src="../images/Images/yourcomments.png" style="width: 98%; margin-top: 1%; margin-bottom: 2%;" />
                                <p style="color: black; width: 90%; text-align: justify; margin-left: 3%; margin-top: 1%;">
                                    Anything more you would like to share with us? Please feel free to use this section to tell us anything else you think we should know about your vehicle i.e. title status, CPO warranty, special instructions, etc.
                                </p>
                                <textarea class="form-control" rows="3" runat="server" style="width: 980px; margin-top: 2%; margin-bottom: 2%; margin-left: 3%" id="Notes_comments_textarea"></textarea>

                                <asp:ImageButton ID="submit_btn" runat="server" ImageUrl="../images/Images/submit.png" Style="float: right; width: 13%; margin-bottom: 100px; margin-right: 22px; margin-top: 6%;" OnClick="submit_btn_Click" />

                                <%--</div>--%>



                                <%-- third accodion --%>
                            </div>
                        </asp:View>

                        <%--Div 6--%>
                    </asp:MultiView>
                    <%-- <div style="display:none;" runat="server">
                 <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click"></asp:LinkButton>
             </div>--%>
                </div>
            </div>
        </div>

        <br />
        <br />
        <!-- Footer widget -->
        <div class="footer-widget-wrapper">
            <div class="container">
                <div class="row">
                    <div class="col-md-3">
                        <div class="span3 f-widget copy-right" style="margin-top: 5%;">
                            <a href="#" class="f-logo">
                                <img src="../Images/logo.png" width="200px"></a>
                            <p>© 2014 THE CAROFFER.COM</p>
                            <p>All rights reserved</p>
                            <p>Designed by THECAROFFER.COM</p>
                        </div>
                    </div>
                    <div class="col-md-3">
                        <div class="span3 f-widget" style="margin-top: 9%; margin-left: 25%;">
                            <h4>Company Information</h4>
                            <ul>
                                <li><a href="#">About US</a></li>
                                <li><a href="#">Terms</a></li>
                                <li><a href="#">Booking Tips</a></li>
                                <li><a href="#">Payment Option</a></li>
                                <li class="last"><a href="#">Information</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class="col-md-3">
                        <div class="span3 f-widget" style="margin-top: 9%; margin-left: 25%;">
                            <h4>Services</h4>
                            <ul>
                                <li><a href="#">Get Your Offer</a></li>
                                <li><a href="#">Consignment</a></li>
                                <li><a href="#">Car Locator</a></li>
                                <li><a href="#">Shipping</a></li>
                                <li><a href="#">Financing</a></li>
                                <li><a href="#">Price Guarantee</a></li>
                                <li class="last"><a href="#">Inventory</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class="col-md-3">
                        <div class="span3 f-widget" style="margin-top: 9%;">
                            <div class="cc">
                                <h4>Customer Support</h4>
                                <h2>1-669-559-4378</h2>
                                <span class="pull-right">Support 24x7</span>
                            </div>
                            <div class="f-widget n-letter">
                                <h4>Newsletter</h4>

                                <form>
                                    <input type="text" name="newlatter" value="Enter your email...">
                                    <input type="submit" name="submite-newslatter" value="Send">
                                </form>
                            </div>
                        </div>
                    </div>

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
                            <%--<a href="javascript:void(0)" onClick="goToByScroll('top')" class="gotop"></a>--%>
                            <a href="#page-top" class="gotop" id="scroll-top"></a>
                        </footer>

                    </div>
                </div>
            </div>
        </div>
        <!-- Footer -->

        <div class="login-popup-wrapper">
            <div id="login-popup">
                <h2>login Panel</h2>
                <form method="get" action="#">
                    <input type="text" value="" id="username" placeholder="kavinhieu@gmail.com" />
                    <input type="text" value="" id="password" placeholder="Password" />

                    <input type="submit" value="sıgn ın" id="login-button" />
                </form>
                <a href="#" class="close">Close</a>
            </div>
        </div>



        <!-- Scripts -->

        <%--<script src="../js/bootstrap-datepicker.js"></script>--%>
        <script src="../js/jquery.flexslider.js"></script>
        <script src="../js/smoothscroll.js"></script>
        <script src="../js/jquery.flexslider-min.js"></script>
        <script src="../js/jquery.elastislide.js"></script>
        <script src="../js/jquery.carouFredSel-6.0.4-packed.js"></script>
        <script src="../js/jcarousellite_1.0.1.js"></script>
        <script src="../js/jquery.zweatherfeed.js"></script>
        <script src="../js/daterangepicker.js"></script>
        <script src="../js/jquery.simpleWeather-2.3.min.js"></script>
        <script src="../js/jquery.cycle.all.js"></script>
        <script src="../js/jquery-ui.js"></script>
        <script src="../js/bootstrap.min.js"></script>
        <script src="../js/jquery.isotope.min.js"></script>
        <script src="../js/jquery.tinyscrollbar.min.js"></script>
        <script src="../js/custom.js"></script>
        <script src="../js/script_for_this_demo.js"></script>
        <%--<script src="../js/bootstrap-datepicker.js"></script>--%>

        <%-- js to achhive collapse--%>

        <script src="../js/jquery.collapse.js"></script>

        <script src="../js/jquery.collapse_cookie_storage.js"></script>
        <script src="../js/jquery.collapse_storage.js"></script>
        <%-- for formatting currency --%>
        <script src="../js/jquery.formatCurrency-1.4.0.js"></script>

        <script type="text/javascript">
            function NumberOnly(event) {
                if (event.which == 8 || event.which == 0) {
                    return true;
                }
                if (event.which < 46 || event.which > 59) {
                    return false;
                    //event.preventDefault();
                } // prevent if not number/dot

                if (event.which == 46 && $(this).val().indexOf('.') != -1) {
                    return false;
                }
            }
            //Currency Format//

            function toUSD(objctrl) {
                var findme = '$';
                //Get the Entered Value
                var number = objctrl.value.toString();
                number = number.replace(/[$@]/g, "");
                number = number.replace(/[,@]/g, "");
                number = number.replace(/^0+/, "");
                //Split the number between dollars and cents
                var dollars = number.split('.')[0];

                var cents = (number.split('.')[1] || '') + '00';

                dollars = dollars.split('').reverse().join('').replace(/(\d{3}(?!$))/g, '$1,').split('').reverse().join('');
                //Concatenate the number with currecny symbol
                objctrl.value = '$' + dollars + '.' + cents.slice(0, 2);
            }
        </script>

        <%--<script type="text/javascript">
            document.getElementById("Drop_Leasing_financing").onchange() = function () {
                var val = this.options[this.selectedIndex].value;
                var val = this.Selection.toString();
                document.getElementById("div_hidden").style.display = (val == "Yes Iam Financing") ? "block" : "none";
                //document.getElementById("div_hidden").style.display = (val == 0) ? "block" : "none";

            };
        </script>--%>

        <script type="text/javascript">
            function Confirmationbox() {
                var result = confirm('Are you sure you want to delete selected User(s)?');
                if (result) {
                    return true;
                }
                else {
                    return false;
                }
            }

        </script>


        <%--<script type="text/javascript">
            //do a post back
            if ("<%=IsPostBack%>" == 'False') {

                document.getElementById("LinkButton1").click();
            }
        </script>--%>



        <%-- <script type="text/javascript">
            jQuery(function () {

                jQuery('input[name=MajorService_Txt]').datepicker({ changeYear: true, changeMonth: true, yearRange: "1940:2025" });
             
                jQuery('input[name=Insurance_Date_Hidden_Txt]').datepicker({ changeYear: true, changeMonth: true, yearRange: "1940:2025" });


                
                    jQuery('input[name=calender2]').datepicker({ changeYear: true, changeMonth: true, yearRange: "1940:2025" });

                })
            
	</script>--%>
    </form>
</body>
</html>
