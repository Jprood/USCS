<!DOCTYPE html>
<html><head><title>Adicionar Dados</title></head>
<body>
<?php
include_once("config.php");

if(isset($_POST['Submit'])) {	
	$fst_nm = mysqli_real_escape_string($mysqli, $_POST['fst_nm']);
	$lst_nm = mysqli_real_escape_string($mysqli, $_POST['lst_nm']);
	$age = mysqli_real_escape_string($mysqli, $_POST['age']);
	$matr = mysqli_real_escape_string($mysqli, $_POST['matr']);
		
	if(empty($fst_nm) || empty($lst_nm) || empty($age) || empty($matr)) {
				
		if(empty($fst_nm)) {
			echo "<font color='red'>Campo Nome está vazio!</font><br/>";
		}
		
		if(empty($lst_nm)) {
			echo "<font color='red'>Campo Sobrenome está vazio!</font><br/>";
		}
		
		if(empty($age_nm)) {
			echo "<font color='red'>Campo Idade está vazio!</font><br/>";
		}

		if(empty($matr)) {
			echo "<font color='red'>Campo Matrícula está vazio!</font><br/>";
		}

		echo "<br/><a href='javascript:self.history.back();'>Voltar</a>";
	} else { 

		$QL = "INSERT INTO ";
		$QL .= "alunos(alu_first_nm,alu_last_nm,alu_age,alu_matr)";
		$QL .= "VALUES ('$fst_nm', '$lst_nm', $age, '$matr')";
		
		$rs = mysqli_query($mysqli, $QL);

		echo "<font color='green'>Registro adicionado com sucesso!</font>";
		echo "<br/><a href='index.php'>Ver resultado</a>";
	}
}
?>
</body>
</html>