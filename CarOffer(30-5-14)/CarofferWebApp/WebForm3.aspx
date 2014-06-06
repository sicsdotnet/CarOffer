<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="CarofferWebApp.WebForm3" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <%--  <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>--%>
    <div>
    <%--<img src="../images/Images/16%20copy.png" style="width: 96%; margin-top: 1%; margin-left: 1%;" />

        <img src="../images/Images/24%20copy.png" style="width: 96%; margin-top: 1%; margin-left: 1%;" />--%>
        <ajax:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajax:ToolkitScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate>
        
        <div style="text-align:center;">    
           <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>

            <ajax:AutoCompleteExtender ID="AutoCompleteExtender2" runat="server" TargetControlID="txtCity" MinimumPrefixLength="1" EnableCaching="true" CompletionSetCount="1" CompletionInterval="1000" 
         ServiceMethod="GetCity"></ajax:AutoCompleteExtender>




            <%--<ajax:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="txtCity" MinimumPrefixLength="1" EnableCaching="true" CompletionSetCount="1" CompletionInterval="1000" 
         ServiceMethod="GetCity"></ajax:AutoCompleteExtender>--%>
           
<%--            <asp:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="txtCity" MinimumPrefixLength="1" EnableCaching="true" CompletionSetCount="1" CompletionInterval="1000" 
         ServiceMethod="GetCity"></asp:AutoCompleteExtender>--%>

            <%-- <asp:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="txtCity"
         MinimumPrefixLength="1" EnableCaching="true" CompletionSetCount="1" CompletionInterval="1000" 
         ServiceMethod="GetCity" >
    </asp:AutoCompleteExtender>--%>
    </div></ContentTemplate> </asp:UpdatePanel>

    </div>
    </form>
</body>
</html>
