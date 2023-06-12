<?php
include_once("config.php");

if(isset($_POST['update']))
{	
	$id = mysqli_real_escape_string($mysqli, $_POST['id']);
	$fst_nm = mysqli_real_escape_string($mysqli, $_POST['fst_nm']);
	$lst_nm = mysqli_real_escape_string($mysqli, $_POST['lst_nm']);
	$age = mysqli_real_escape_string($mysqli, $_POST['age']);
	$matr = mysqli_real_escape_string($mysqli, $_POST['matr']);	
	
	if(empty($fst_nm) || empty($lst_nm) || empty($age) || empty($matr)) {	
			
		if(empty($fst_nm)) {
			echo "<font color='red'>Campo nome está vazio!</font><br/>";
		}

		if(empty($lst_nm)) {
			echo "<font color='red'>Campo sobrenome está vazio!</font><br/>";
		}

		if(empty($age)) {
			echo "<font color='red'>Campo idade está vazio!</font><br/>";
		}	

		if(empty($matr)) {
			echo "<font color='red'>Campo matrícula está vazio!</font><br/>";
		}	
	} else {	
		
		$QL = "UPDATE alunos SET";
		$QL .= "alu_first_nm = '$fst_nm', "; 
		$QL .= "alu_last_nm = '$lst_nm', ";
		$QL .= "alu_age=$age, ";
		$QL .= "alu_matr='$matr' ";
		$QL .= "WHERE id=$id";
		
		
		$rs = mysqli_query($mysqli, $QL);
		header("Location: index.php");
	}
}
?>
<?php
$id = $_GET['id'];

$QL = "SELECT * FROM alunos WHERE id=$id";

$rs = mysqli_query ($mysqli, $QL);

while($reg = mysqli_fetch_array($rs))
{
	$fst_nm = $reg['alu_first_nm'];
	$lst_nm = $reg['alu_last_nm'];
	$age = $reg['alu_age'];
	$matr = $reg['alu_matr'];
}
?>
<html>
<head>	
	<meta charset="utf-8" />
	<title>Editar Aluno</title>
</head>
<body>
	<a href="index.php">Home</a>
	<br/><br/>	
	<form name="form1" method="post" action="edit.php">
		<table border="0">
			<tr> 
				<td>Nome</td>
				<td><input type="text" name="fst_nm" value="<?php echo $fst_nm;?>"></td>
			</tr>
			<tr> 
				<td>Sobrenome</td>
				<td><input type="text" name="lst_nm" value="<?php echo $lst_nm;?>"></td>
			</tr>
			<tr> 
				<td>Idade</td>
				<td><input type="text" name="age" value="<?php echo $age;?>"></td>
			</tr>
			<tr> 
				<td>Matrícula</td>
				<td><input type="text" name="matr" value="<?php echo $matr;?>"></td>
			</tr>
			<tr>
				<td><input type="hidden" name="id" value="<?php echo $id;?>"></td>
				<td><input type="submit" name="update" value="Salvar"></td>
			</tr>
		</table>
	</form>
</body>
</html>