<!DOCTYPE html>
<html>
	<head>
		<meta charset="UTF-8">
		<title>Login Page</title>
		<link rel="stylesheet" href="loginstyle.css" />
	</head>
	<body>
		<div id="main">
			<header id="the_header">

				<img src="logo.png" alt="logo" height="70" width="960">
			</header>
			
			<section id="the_section">
				<form id="the_form" action="process.php" method="POST">
					<div id="info">
						<label>Username:</label>
						<input type="text" id="user" name="user" placeholder="Username" required>
						<label>Password:</label>
						<input type="password" id="pass" name="pass" placeholder="Password" required>
						
						<a href="register.php">Register</a>
						<div id="invalid">
							<?php
								if (isset($_GET["msg"]) && $_GET["msg"] == 'failed') 
								{
									echo "<b><font color='red'>Invalid</font></b>";
								}
							?>
						</div>
						<input type="submit" id="btn" value="Submit" />
					</div>
				</form>
			</section>
		</div>
	</body>
</html>