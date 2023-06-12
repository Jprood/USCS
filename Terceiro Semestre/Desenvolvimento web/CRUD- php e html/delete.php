<?php
include("config.php");

	$id = $_GET['id'];
	
	$QL = "DELETE FROM alunos WHERE alu_id=$id";

	$result = mysqli_query($mysqli, $QL);

	header("Location:index.php");
?>

