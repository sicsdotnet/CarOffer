<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="CarofferWebApp.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="css/bootstrap.css" rel="stylesheet" />

    <link href="css/elastislide.css" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />
    <link href="css/responsive.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server" style="background-color:white;">
<asp:ScriptManager ID="scriptmng" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <div class="col-lg-12" style="float: left; margin-top: 2%; background-color:white;">
                    <div class="col-lg-6" style="margin-top: 1%; margin-left: 10%">
                        <div class="col-lg-3">
                            <label id="vin_lb" runat="server">VIN</label>
                        </div>

                        <div class="col-lg-8">
                            <input type="text" id="vin_txb" class="form-control" runat="server" />
                        </div>
                    </div>


                    <div class="col-lg-6" style="margin-top: 1%; margin-left: 10%">
                        <div class="col-lg-3">
                            <label for="inputEmail">Year</label>
                        </div>

                        <div class="col-lg-8">
                            <input type="text" class="form-control" runat="server" id="Year_txt" />
                        </div>

                    </div>

                    <div class="col-lg-6" style="margin-top: 1%; margin-left: 10%">
                        <div class="col-lg-3">
                            <label for="inputEmail">Make</label>
                        </div>

                        <div class="col-lg-8">
                            <input type="text" class="form-control" runat="server" id="Make_txt" />
                        </div>
                    </div>


                    <div class="col-lg-6" style="margin-top: 1%; margin-left: 10%">
                        <div class="col-lg-3">
                            <label for="inputEmail">Model</label>
                        </div>

                        <div class="col-lg-8">
                            <input type="text" class="form-control" runat="server" id="Model_txt"/>
                        </div>
                        <%--<img src="../images/Images/6%201copy.png" style="width: 5%; margin-top: 0%; margin-left: -3%;" />--%>
                    </div>


                    <div class="col-lg-6" style="margin-top: 1%; margin-left: 10%">
                        <div class="col-lg-3">
                            <label for="inputEmail">Style</label>
                        </div>

                        <div class="col-lg-8">
                            <input type="text" class="form-control" runat="server" id="Style_txt"  />
                        </div>
                        <%--<img src="../images/Images/6%201copy.png" style="width: 5%; margin-top: 0%; margin-left: -3%;" />--%>
                    </div>

                    <div class="col-lg-6" style="margin-top: 1%; margin-left: 10%">
                        <div class="col-lg-3">
                            <label for="inputEmail">Trim/Style</label>
                        </div>

                        <div class="col-lg-8">
                            <%--<asp:DropDownList ID="Drop_Trim_style" runat="server" Style="width: 100%;" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="Drop_Trim_style_SelectedIndexChanged"></asp:DropDownList><asp:RequiredFieldValidator InitialValue="-1" ID="Req_Dropdown" Display="Dynamic"
                                ValidationGroup="a1" runat="server" ControlToValidate="Drop_Trim_style"
                                ErrorMessage=" *Please Select Option"></asp:RequiredFieldValidator>--%>
                            <asp:Label ID="label2" runat="server"></asp:Label>
                        </div>
                        <%--<img src="../images/Images/6%201copy.png" style="width: 5%; margin-top: 0%; margin-left: -3%;" />--%>
                    </div>

                    <div class="col-lg-6" style="margin-top: 1%; margin-left: 10%">
                        <div class="col-lg-3">
                            <label for="inputEmail">Series</label>
                        </div>

                        <div class="col-lg-8">
                            <input type="text" class="form-control" runat="server" id="Series_txt"/>
                        </div>
                        <%--<img src="../images/Images/6%201copy.png" style="width: 5%; margin-top: 0%; margin-left: -3%;" />--%>
                    </div>

                 
                    <div class="col-lg-6" style="margin-top: 1%; margin-left: 10%">
                        <div class="col-lg-3">
                            <label for="inputEmail">Transmission</label>
                        </div>

                        <div class="col-lg-8">
                            <input type="text" class="form-control" runat="server" id="Transmsn_txt"/>
                        </div>
                        <%--<img src="../images/Images/6%201copy.png" style="width: 5%; margin-top: 0%; margin-left: -3%;" />--%>
                    </div>

                    <div class="col-lg-6" style="margin-top: 1%; margin-left: 10%">
                        <div class="col-lg-3">
                            <label for="inputEmail">Engine</label>
                        </div>

                        <div class="col-lg-8">
                            <input type="text" class="form-control" runat="server" id="Engine_txt" required />
                        </div>
                        <%--<img src="../images/Images/6%201copy.png" style="width: 5%; margin-top: 0%; margin-left: -3%;" />--%>
                    </div>

                     <div class="col-lg-4" style="margin-top: -23%; margin-left:2%;">
            <img src="../images/car.jpg" width="100%" />
        </div>



                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
       


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





    </form>
</body>
</html>
