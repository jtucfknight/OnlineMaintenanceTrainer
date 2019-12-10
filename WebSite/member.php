
<?php
session_start();
if(!isset($_SESSION["user_session"]))
{
	header("location:login.php?msg=failed");
}
else
{
?>
<!doctype html>
	<html>
		<head>
			<title>Welcome Page</title>
			<link rel="stylesheet" href="default.css" />
		</head>
		<body>
			<div id="main">
				<h2>Welcome, <?=$_SESSION['user_session'];?>! <a href="logout.php"><br>Logout</a></h2>
				<p>
					This is the screen that will hold all training material.
				</p>
			</div>

		</body>
	</html>
<?php
}
?>


