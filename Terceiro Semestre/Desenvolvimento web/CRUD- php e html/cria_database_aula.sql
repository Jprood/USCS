/*
	C:\xampp\xampp_start.exe 

	http://localhost/phpmyadmin/

*/

create database trab;
use trab;

CREATE TABLE `alunos` (
  `alu_id` int(11) NOT NULL auto_increment,
  `alu_first_nm` varchar(100) NOT NULL,
  `alu_last_nm` varchar(100) NOT NULL,
  `alu_age` int(3) NOT NULL,
  `alu_matr` varchar(100) NOT NULL,
  PRIMARY KEY  (`alu_id`)
);