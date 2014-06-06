<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CarofferWebApp.CarofferForms.Index" %>

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
				<title>The car Offer </title>
				
				<!-- Style Sheet-->
               <link href="../css/bootstrap.css" rel="stylesheet" />
              <%-- <link href="../css/bootstrapss.css" rel="stylesheet" />--%>
               <link href="../css/style.css" rel="stylesheet" />
              <link href="../css/responsive.css" rel="stylesheet" />
               <link href="../css/flexslider.css" rel="stylesheet" />

                <%--<link rel="stylesheet" href="css/bootstrap.css">
				<link rel="stylesheet" href="css/style.css">
				<link rel="stylesheet" href="css/responsive.css">
                <link rel="stylesheet" href="css/flexslider.css">
                --%>
				
               <!-- favicon -->
				
				
				<!--[if lt IE 9]>
						<script src="js/html5shiv.js"></script>
						<link rel="stylesheet" href="css/ie.css">
				<![endif]-->
		</head>
		<body>
            <form id="form1" runat="server">
    				
				
            <style>
                @media (max-width:968px)
                        {
                         .headerxxaa
                             {
                                position: absolute;
                             }
                         }
            </style>

		<!-- HEADER -->
                <div class="row headerxxaa">
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
                <div class="nav-wrapper topadjust">
                	<div class="container">
                    	<div class="row">
                        	<div class="span12">
                            
                            	<nav>
                                   
                                    <ul>
                                        <li><a href="index.html">Home </a>
                                        	<ul class="clearfix">
                                                <li><a href="index2.html">Home 2</a></li>
                                                <li><a href="index3.html">Home 3 </a></li>
                                            </ul>
                                        </li>
                                        <li><a href="travel_grid.html">Get Your Offer</a>
                                        	<ul class="clearfix">
                                                <li><a href="travel_grid.html">Travel Grid</a></li>
                                                <li><a href="travel_list.html">Travel list</a></li>
                                                <li><a href="travel_detail.html">Travel Detail</a></li>
                                            </ul>
                                        </li>
                                        <li><a href="#">Consignment</a></li>
                                        <li>
                                            <a href="#">Car Locator</a>
                                            <ul class="clearfix">
                                                <li><a href="#">Camera</a></li>
                                                <li><a href="#">Notebook </a></li>
                                                <li><a href="#">Tablet </a> </li>
                                                <li><a href="#">Television </a> </li>
                                                <li><a href="#">Smart Phone </a> </li>
                                                <li><a href="#">Projection </a> </li>
                                            </ul>
                                        </li>
                                        <li><a href="#">Shipping</a></li>
                                        <li><a href="#">Financing</a></li>
                                        <li><a href="#">Price Guarantee</a></li>
                                        <li><a href="#">Inventory</a></li>
                                        <li><a href="booking.html">About Us</a>
                                        	<!--<ul class="clearfix">
                                                <li><a href="confirm.html">Confirmation</a></li>
                                            </ul>-->
                                        </li>
                                        <!--<li  class="last"><a href="contact.html">Contact</a></li>-->
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
                <!-- Main Navigation -->

                <!-- Slider -->
				<div class="flexslider">
                	<ul class="slides">
                        <li>
                          <img id="Img2" src="../Images/Images/1.jpg" alt="Slider Image" runat="server"/>
                          <div class="detail-one">
                            <h3>USA</h3>
                            <h2>Chicago Night street</h2>
                           	<span>$ 2.400</span>
                          	<a href="#"></a> 	
                          </div>
                        </li>
                        <li>
                          <img id="Img3" src="../Images/Images/2.jpg"  alt="Slider Image" runat="server"/>
                          <div class="detail-one">
                            <h3>Brazil</h3>
                            <h2>Brazil Night City Beach</h2>
                           	<span>$ 1.400</span>
                          	<a href="#"></a> 	
                          </div>
                        </li>
                        <li>
                          <img id="Img4" src="../Images/Images/3.jpg"  alt="Slider Image" runat="server"/>
                          <div class="detail-one">
                            <h3>Brazil</h3>
                            <h2>Brazil Night City Beach</h2>
                           	<span>$ 1.400</span>
                          	<a href="#"></a> 	
                          </div>
                        </li>
                        <li>
                          <img id="Img5" src="../Images/Images/4.jpg"  alt="Slider Image" runat="server"/>
                          <div class="detail-one">
                            <h3>Brazil</h3>
                            <h2>Brazil Night City Beach</h2>
                           	<span>$ 1.400</span>
                          	<a href="#"></a> 	
                          </div>
                        </li>
                    </ul>
                    
                    
                    <!-- Reservation box -->
                    
                  <!-- Reservation box -->
                    
                </div>
                <!-- Slider -->

                <!-- Special Offer -->
               	<div class="specialoffer-wrapper">
                       <div class="container" style="padding:0px; ">
               	  <div class="col-md-3 arowxsd" ><ul class="ca-menu"><div class="number"><img src="../Images/1.png" style="width:66px ;height:66px"/></div>
               	      <li >
                        <a href="#">
                            <span class="ca-icon">Submit Vehicle Identification Number</span>
                       
                        </a>                   
                    </li>
                   
    </ul></div><div class="col-md-3 arowxsd" ><ul class="ca-menu"><div class="number"><img id="Img6" src="../Images/2.png" style="width:66px ;height:66px" runat="server"/></div>
               	      <li>
                        <a href="#">
                            <span class="ca-icon"> Enter Car Details</span>
                            <div class="ca-content"></div>
                        </a>                   
                    </li>
                   
    </ul></div><div class="col-md-3 arowxsd "><ul class="ca-menu"><div class="number"><img src="../Images/3.png" style="width:66px ;height:66px"/></div>
               	      <li>
                        <a href="#">
                            <span class="ca-icon">  Receive TheCarOffer Within 48 Hours</span>
                            <div class="ca-content"></div>
                        </a>                   
                    </li>
                   
    </ul></div><div class="col-md-3 arowxsd2"><ul class="ca-menu"><div class="number"><img src="../Images/4.png" style="width:66px ;height:66px"/></div>
               	      <li>
                        <a href="#">
                            <span class="ca-icon">Sell Us Your Car!</span>
                            <div class="ca-content"></div>
                        </a>                   
                    </li>
                   
    </ul></div>
       	</div>
	</div>
                <div class="row searhareaoffercar"><div class="container"><div class="col-sm-6"><input id="Text1" placeholder="Enter VIN here" type="text" style="font-size:26px" class="carossersearchfield" runat="server"/></div><div class="col-sm-1"></div><div class="col-sm-3" style="text-align:center;"><img src="../Images/get.png" style="width:300px"/></div></div></div>
               	<%--<div class="specialoffer-wrapper"><div class="container" style="padding:0px; ">
               	  <div class="col-md-3 arowxsd" ><ul class="ca-menu"><div class="number"><img src="../Images/1.png" style="width:66px ;height:66px"/></div>
               	      <li >
                        <a href="#">
                            <span class="ca-icon">Submit Vehicle Identification Number</span>
                       
                        </a>                   
                    </li>
                   
    </ul></div><div class="col-md-3 arowxsd" ><ul class="ca-menu"><div class="number"><img src="../Images/2.png" style="width:66px ;height:66px" runat="server"/></div>
               	      <li>
                        <a href="#">
                            <span class="ca-icon"> Enter Car Details</span>
                            <div class="ca-content"></div>
                        </a>                   
                    </li>
                   
    </ul></div><div class="col-md-3 arowxsd "><ul class="ca-menu"><div class="number"><img src="../Images/3.png" style="width:66px ;height:66px"/></div>
               	      <li>
                        <a href="#">
                            <span class="ca-icon">  Receive TheCarOffer Within 48 Hours</span>
                            <div class="ca-content"></div>
                        </a>                   
                    </li>
                   
    </ul></div><div class="col-md-3 arowxsd2"><ul class="ca-menu"><div class="number"><img src="../Images/4.png" style="width:66px ;height:66px"/></div>
               	      <li>
                        <a href="#">
                            <span class="ca-icon">Sell Us Your Car!</span>
                            <div class="ca-content"></div>
                        </a>                   
                    </li>
                   
    </ul></div>--%>
       	<%--</div></div>--%><div class="row caroffreadd"><div class=" container headeronexx"><h1>Sell us your Car </h1></div><table style="width:100%; border:0px;word-spacing:0px;  padding:0px">
  <tr>
    <td style="height:120px;vertical-align:bottom;" class=" container headeronexx"><h2>&nbsp;</h2>
      <h2>&nbsp;</h2>
      <h2>Our best cars. Your best offer. </h2>
      <p style="text-align:center;">Thousands of new cars, trucks and crossovers. All with amazing deals.</p></td>
      
  </tr>
</table>
</div></div>
                <!-- Special Offer -->
                
                <!-- Testimonial -->
               	<div class="testimonial-wrapper">
                	<div class="container">
                    	<div class="row">
                        	<div class="span12 test">
                            
                            	<div class="testimonial">
                                	<div>
                                		<span class="comas"></span>
                                		<p>Quis inceptos lorem fusce feugiat hendrerit felis eu aliquet fames neque amet aliquet ornare, augue amet facilisis suspendisse quisque ligula fusce et conubia quisque fames ullamcorper leo integer etiam leo dapibus arcu etiam.</p>
                                		<figure>
                                			<img src="../images/testimonial-pic.png" alt="PIc"/> 
                                		</figure>
                                		<p class="client">Kavin</p>
                                		<span>Graphic Designer</span>
                                	</div>
                                    <div>
                                		<span class="comas"></span>
                                		<p>Quis inceptos lorem fusce feugiat hendrerit felis eu aliquet fames neque amet aliquet ornare, augue amet facilisis suspendisse quisque ligula fusce et conubia quisque fames ullamcorper leo integer etiam leo dapibus arcu etiam.</p>
                                		<figure>
                                			<img src="../images/testimonial-pic.png" alt="PIc"/> 
                                		</figure>
                                		<p class="client">Junaid Chaudary</p>
                                		<span>Web Developer</span>
                                	</div>
                                </div>
                                <div class="test-button">
                                	<a href="#" id="test-prev"></a>
                                	<a href="#" id="test-next"></a>
                                </div>
                            	
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Testimonial -->

                <!-- Footer widget -->
                <div class="footer-widget-wrapper">
                	<div class="container">
                    	<div class="row">
                        	<div class="col-md-3">
                            <div class="span3 f-widget copy-right">
                            	<a href="#" class="f-logo"><img src="../Images/logo.png" style="width:200px"/></a>
                            	<p>© 2014 <a href="#">carofferl</a>. All rights reserved</p>
                            	<p>Designed by Srishtis.com</p>
                          </div></div>
                            <div class="col-md-3">
                            <div class="span3 f-widget">
                            	<h4>Company Infomation</h4>
                                <ul>
                                	<li><a href="#">About US</a></li>
                                	<li><a href="#">Tearms</a></li>
                                	<li><a href="#">Booking Tips</a></li>
                                	<li><a href="#">Payment Option</a></li>
                                	<li class="last"><a href="#">Infomation</a></li>
                                </ul>
                            </div></div> <div class="col-md-3">
                            <div class="span3 f-widget">
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
                            </div></div>
                             <div class="col-md-3">
                            <div class="span3 f-widget">
                            	<div class="cc">
                            		<h4>Customer Support</h4>
                            		<h2>1-669-559-4378</h2>
                            		<span class="pull-right">Support 24/24</span>
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
                                    		<li><a href="#">Recrutment </a></li>
                                    		<li><a href="#">Media</a></li>
                                    		<li><a href="#">Support</a></li>
                                    	</ul>
                                    </div>
                                    <a href="javascript:void(0)" onClick="goToByScroll('top')" class="gotop"></a>
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
                <script type="text/javascript">
                    $(document).ready(function () {
                        $('.scrollbar1').tinyscrollbar();
                    });
                </script>
                <%--<script src="js/custom.js"></script>--%>
                <script src="../js/custom.js"></script>>
            
            </form>		
		</body>
<%--<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>--%>
</html>

