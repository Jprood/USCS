<?php
include_once("config.php");
$QL = "SELECT * FROM alunos ";
if(isset($_POST['o_nome'])){
	$QL .= "ORDER BY alu_first_nm";
}

if(isset($_POST['o_matr'])){
	$QL .= "ORDER BY alu_matr";
}

if(isset($_POST['o_cheg'])){
	$QL .= "ORDER BY alu_id";
}

if(isset($_POST['o_sobr'])){
	$QL .= "ORDER BY alu_last_nm";
}

$rs = mysqli_query($mysqli, $QL);
?>

<html>
<head>
	<meta charset="utf-8" />
	<title>Alunos</title>
</head>

<body>
<a href="add.html">Adicionar Aluno</a><br/><br/>

	<table width='80%' border=0>
	<tr bgcolor='#CCCCCC'>
<?php
	if(!isset($_POST['o_sobr'])){
		echo "<td>Primeiro Nome</td>";
	}
?>
		<td>sobrenome</td>
		<td>Idade</td>
		<td>Matrícula</td>
		<td>Comandos</td>
	</tr>
<?php 
	$qtd = 0;
	$soma = 0;
	$media = 0;
	while($reg = mysqli_fetch_array($rs)) { 
		$qtd++;
		$soma+=$reg['alu_age'];
		echo "<tr>";
		if(!isset($_POST['o_sobr'])){
			echo "<td>".$reg['alu_first_nm']."</td>";
		};
		echo "<td>".$reg['alu_last_nm']."</td>";
		echo "<td>".$reg['alu_age']."</td>";
		echo "<td>".$reg['alu_matr']."</td>";	
		echo "<td><a href=\"edit.php?id=$reg[alu_id]\">Editar</a> ";
		echo "| <a href=\"delete.php?id=$reg[alu_id]\" ";
		echo "onClick=\"return confirm('Tem certeza que quer deletar do banco de dados?')\">Deletar</a>";
		echo "</td>";
		echo "</tr>";
	};
		if($qtd!==0){
			$media = ($soma / $qtd);
	};
	?>
	</table>
	<p>Quantidade de alunos cadastrados: <?php echo $qtd;?> </p>
<?php
	if(isset($_POST['o_sobr'])){
		echo "<p>Média de idade: ".number_format($media,1)."</p>";
	};
?>
	<form method="post" action="index.php">
		<input type="submit" name="o_nome" value="Nome"/>
		<input type="submit" name="o_matr" value="Matrícula"/>
		<input type="submit" name="o_cheg" value="Chegada"/>
		<input type="submit" name="o_sobr" value="Sobrenome"/>
	</form>
</body>
</html>
