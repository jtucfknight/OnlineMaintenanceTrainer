<?php
	//Get values passed from form in login.php file
	$username = $_POST['user'];//jt
	$password = $_POST['pass'];//ab
	
	//Connect to the server and select database
	$db = mysqli_connect("198.71.225.57:3306", "JT85Plesk", "@2ag#3AG", "JT85Plesk_");
	
	//To prevent mysql injection
	$username = mysqli_real_escape_string($db, $username);
	$password = mysqli_real_escape_string($db, $password);

	//Query the database for all fields in the SecureLogin database
	$sql = ("SELECT * FROM SecureLogin");
	
	//Store db connection and query results to $query
	$query = mysqli_query($db, $sql) or die("Failed to query database ".mysql_error());
	$count=mysqli_num_rows($query);
	
	$test = 0;
	
	if($count !== 0)
	{
	//Loop through all fields in the database
		while ($row = mysqli_fetch_assoc($query))
		{
			if($row['username'] == $username and $row['password'] == $password)
			{
				$test = 1;
				break;
			}
			else
			{
				$test = 0;
			}

		}
	}
	else
	{
		echo ("Username or Password does not exist.  Please hit back in your browser and register.<br>");
	}
	
	if($test == 1)
	{
		echo"<hr>";
		echo ("Query Username: ".$row['username']."<br>");
		echo ("Query Password: ".$row['password']."<br>");
		echo"<hr>";
		echo ("Username and Password match: ".$row['username']."<br>");
		echo "Login success!!! Welcome ".$row['username']."<br>";
		$test = $row['username'];
		
		session_start();
		$_SESSION['user_session'] = $username;
		echo ("Works! ".$test);
		header("Location: game_v03/index.php");
	}
	else
	{
		echo"<hr>";
		echo ("Username or Password is incorrect.  Please hit back in your browser and register.<br>");
		//header("Location:login.php");
		header("Location:register.php");
		echo"<hr>";
	}
?>



