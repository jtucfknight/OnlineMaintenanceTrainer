<!DOCTYPE html>
<html>
	<head>
		<meta charset="UTF-8">
		<link rel="stylesheet" href="registerstyle.css" />
	</head>
	<body>
		<div id="main">
		<header id="the_header">

		</header>
			<section id="the_section">
				<form id="the_form" method="POST">
					<div id="info">
						
						Username: <input type="text" name="user">
						Password: <input type="password" name="pass">
						Email: <input type="email" name="email"><br/>
						<input type="submit" value="Register" name="submit"/>
					</div>
				</form>
			</section>
		</div>
	</body>
	<?php
		if(isset($_POST["submit"]))
		{
			$user=$_POST['user'];
			$pass=$_POST['pass'];
			$email=$_POST['email'];
			
			$db = mysqli_connect("198.71.225.57:3306", "JT85Plesk", "@2ag#3AG", "JT85Plesk_");
			if($db)
			{
				echo "Connected Sucessfully";
			}
			
			$sql="INSERT INTO SecureLogin (email,username,password) VALUES ('$email','$user','$pass')";
			if(!mysqli_query($db,$sql))
			{
				echo 'Not Inserted';
				header("Location:login.php?msg=failed");
			}
			else
			{
				echo 'Inserted';
				session_start();
				//$_SESSION['user_session'] = $username;
				header("Location: login.php");//This is the file name to change for the Unity file.
				echo "Login success!!! Welcome ".$row['username']."<br>";
			}
		}
	?>
</html>

