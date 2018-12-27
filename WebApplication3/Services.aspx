<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Services.aspx.cs" Inherits="WebApplication3.Services" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <head>
		<title>Car Repair A Auto Mobile Category Flat Bootstarp Resposive Website Template | Services :: w3layouts</title>
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<meta name="keywords" content="Car Repair Responsive web template, Bootstrap Web Templates, Flat Web Templates, Andriod Compatible web template, Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyErricsson, Motorola web design" />
		<script type="application/x-javascript"> addEventListener("load", function() {setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
		<!meta charset utf="8">
		<link rel="stylesheet" href="intro/css/flexslider.css" type="text/css" media="screen" />
		<!--bootstrap-->
			<link href="intro/css/bootstrap.min.css" rel="stylesheet" type="text/css">
		<!--coustom css-->
			<link href="/intro/css/style.css" rel="stylesheet" type="text/css"/>
		<!--default-js-->
			<script src="intro/js/jquery-2.1.4.min.js"></script>
		<!--bootstrap-js-->
			<script src="intro/js/bootstrap.min.js"></script>
</head>
</head>
<body>
    <form id="form1" runat="server">
        
		
			<div class="header_nav" id="home">
				<nav class="navbar navbar-default chn-gd">
					
					<!-- Brand and toggle get grouped for better mobile display -->
					<div class="navbar-header">
					<button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
					<span class="sr-only">Toggle navigation</span>
					<span class="icon-bar"></span>
					<span class="icon-bar"></span>
					<span class="icon-bar"></span>
					</button>
					
					</div>
					<!-- Collect the nav links, forms, and other content for toggling -->
					<div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
					<ul class="nav navbar-nav navbar-right">
						<li class="col-md-2">
						<a href="index.html" class="blue">
						<span class="glyphicon glyphicon-home " aria-hidden="true"></span>
						Home
						</a>
						</li>
						<!---->
						<li class="col-md-2">
						<a href="Services.aspx" class="pink">
						<span class="glyphicon glyphicon-cog " aria-hidden="true"></span>
						Services
						</a>
						</li>
						</li>
                        <li class="col-md-2">
						<a href="about.html" class="orang">
						<span class="glyphicon glyphicon-user " aria-hidden="true"></span>
						About
						</a>
						<!---->
						<li class="col-md-2">
						<a href="news.html" class="gray">
						<span class="glyphicon glyphicon-thumbs-up " aria-hidden="true"></span>
						News
						</a>
						</li>
						<!---->
						
						<li class="col-md-2">	
						<a href="Admin_Panel.aspx" class="green">
						<span class="glyphicon glyphicon-picture " aria-hidden="true"></span>
						Admin Panel
						</a>
						</li>
                            </li>
						<li class="col-md-2">
						<a href="contact.html" class="sky">
						<span class="glyphicon glyphicon-envelope" aria-hidden="true"></span>
						Contact
						</a>
						</li>
						<div class="clearfix">
						<!--script-->
						<script type="text/javascript">
						jQuery(document).ready(function($) {
						$(".scroll").click(function(event){		
						event.preventDefault();
						$('html,body').animate({scrollTop:$(this.hash).offset().top},900);
						});
						});
						</script>
						<!--script-->
					</ul>
					</div><!-- /.navbar-collapse -->
					<div class="clearfix"></div>
					<!-- /.container-fluid -->
				</nav>
			</div>
			<div class="container">
				<div class="logo">
						<h1><a href="index.html">CAR REPAIR</a></h1>
				</div>
				<div class="ad-ph">
					<p>Call Us : <span>(800)</span>1444 000 4040</p>
				</div>
					<div class="clearfix"></div>
			</div>
		<!-- banner -->
		<div class="banner-1">
			<div class="container">
				<h2>Services</h2>
                <asp:GridView ID="grid524" runat="server"></asp:GridView>
			</div>	
		</div>	
		<!-- /banner -->
		<!-- services -->
		
		<!-- services -->
		<!-- footer -->
		<div class="footer">
	<div class="container">
		<div class="col-md-3 footer-left">
			<h3>Telephone</h3>
			<p>1 800 603 6035</p>
		</div>
		<div class="col-md-3 footer-left">
			<h3>E-Mail Us</h3>
			<p>Email : <a href="mailto:info@example.com">info@mycompany.com</a></p>
		</div>
		<div class="col-md-3 footer-left">
			<h3>Follow Us</h3>
			<ul>
				<li><a href="#"><i class="facebok"> </i></a></li>
				<li><a href="#"><i class="twiter"> </i></a></li>
				<li><a href="#"><i class="goog"> </i></a></li>
				<li><a href="#"><i class="inst"> </i></a></li>
					<div class="clearfix"></div>	
			</ul>
		</div>
		<div class="col-md-3 footer-left">
			<h3>Address</h3>
			<p>8058 St Perth Place,
Australia, DC 55 Fr 88.</p>
		</div>
			<div class="clearfix"></div>
			
	</div>
</div>
		<!-- footer -->
    </form>
</body>
</html>
