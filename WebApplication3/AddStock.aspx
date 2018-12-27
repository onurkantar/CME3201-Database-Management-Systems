<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStock.aspx.cs" Inherits="WebApplication3.AddStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Sign Up Form by Colorlib</title>

    <!-- Font Icon -->
    <link rel="stylesheet" href="fonts/material-icon/css/material-design-iconic-font.min.css">

    <!-- Main css -->
    <link rel="stylesheet" href="Content/style.css">
</head>
<body>



    
    <div class="main">

        <div class="container">
            <form method="POST" class="appointment-form" id="appointmentform" runat="server">
                <h2>Stock Add Form</h2>
                <div class="form-group-1">

                    <h3>Stock Adding Date</h3>
                    <input type="date" id="calendar" name="takvim" runat="server" />
                    <input type="number" name="name" id="quantity" placeholder="Quantity" required runat ="server"/>
                    <input type="number" name="lastname" id="price" placeholder="Price" required runat ="server"/>
                    <input type="text" name="salary" id="fromwhere" placeholder="From Where ?" required runat ="server"/>
                   

                    <input type="text" name="phone_number" id="sto_name" placeholder="Stock Name" required runat ="server"/>
                    
                    <asp:Button runat="server" class="submit" onclick="insertStock"  Text ="Add Stock"/> 

                    
                    <!-- 

                </div>
                <div class="form-group-2">
                    <h3>How would you like to bo located ?</h3>
                    <div class="select-list">
                        <select name="confirm_type" id="confirm_type">
                            <option seleected value="">By phone</option>
                            <option value="by_email">By email</option>
                        </select>
                    </div>
                    <div class="select-list">
                        <select name="hour_appointment" id="hour_appointment">
                            <option seleected value="">Hours : 8am 10pm</option>
                            <option value="9h-11h">Hours : 9am 11pm</option>
                        </select>
                    </div>
                </div>
                <div class="form-check">
                    <input type="checkbox" name="agree-term" id="agree-term" class="agree-term" />
                    <label for="agree-term" class="label-agree-term"><span><span></span></span>I agree to the  <a href="#" class="term-service">Terms and Conditions</a></label>
                </div>
                <div class="form-submit">
                    <input type="submit" name="submit" id="submit" class="submit" value="Request an appointment" />
                </div>
-->
            </form>
        </div>

    </div>
                    
    <!-- JS -->
    <script src="vendor/jquery/jquery.min.js"></script>
    <script src="js/main.js"></script>


</body>
</html>
