<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registerEmployee.aspx.cs" Inherits="WebApplication3.registerEmployee" %>

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
                <h2>Employee Update Form</h2>
                <div class="form-group-1">
                    <input type="number" name="id" id="id1" placeholder="ID" required runat ="server"/>
                    <input type="text" name="name" id="name" placeholder="Name" required runat ="server"/>
                    <input type="text" name="lastname" id="surname" placeholder="Lastname" required runat ="server"/>
                    <input type="number" name="salary" id="salary" placeholder="Salary" required runat ="server"/>
                   
                         <h3>Is Part Time ?</h3>
                        <select name="isPartTimee" id="select1" runat="server">
                            <option value="yes">Yes</option>
                            <option value="no">No</option>
                        </select>

                    <input type="number" name="phone_number" id="phone_number" placeholder="Phone number" required runat ="server"/>
                    <input type="mail" name="mail" id="mail_box" placeholder="Mail Address" required runat ="server"/>
                    <h3>Position</h3>
                    <select name="isPartTimee" id="select2" runat="server">
                        <option value="CEO">CEO</option>
                        <option value="worker">Worker</option>
                        <option value="director">Director</option>
                        </select>
                    <h3>Workday Type ?</h3>
                    <select name="isPartTimee" id="select3" runat="server">
                        <option value="type1">Monday - Wednesday - Friday</option>
                        <option value="type2">Tuesday - Thursday - Saturday</option>
                        <option value="type3">Saturday - Sunday - Monday</option>
                        </select>
                   
                    
                    <input type="number" name="ssn_number" id="ssn_number" placeholder="SSN Number" required runat ="server"/>
                
                    <h3>BirthDate</h3>
                    <input type="date" id="calendar" name="takvim" runat="server" />
                        <asp:Button runat="server" class="submit" onclick="UpdateEmployee"  Text ="Update"/> 

                    
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
