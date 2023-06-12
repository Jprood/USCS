create table APLICACAO (
  chaplicacao int identity (1,1),
  nome varchar(50),
  inicioOperacao datetime,
  ativo int )

create table APLIPERFIL (
   chPerfil int identity (1,1),
   descricao varchar(50))  

create table APLIFUNCAO (
   chfuncao int identity (1,1),
   descricao varchar(50))  

create table APLIPERFILFUNCAO (
   chapliperfilFUNCAO  int identity (1,1),  
   chperfil int,
   chfuncao int ,
   datadesativa datetime,
   dataativa  datetime )

create table USUARIO (
   chusuario int identity(1,1),
   nome varchar(50),
   login varchar(50),  
   senha varchar(50),  
   esqueceusenha datetime,
   inicio datetime,
   desativacao datetime)

create table USUAPERFIL
(chUsuaPerfil int identity(1,1),
chusuario     int,
chperfil      int,
datadesativa  datetime,
dataativa     datetime)

-- ---------------------------------------------------
-- INSERTS
-- ---------------------------------------------------

INSERT INTO aplicacao (nome, iniciooperacao,ativo) values ('APP do PIM', getdate(),1)
INSERT INTO apliPerfil (descricao) values ('Cliente') , ('Gestor') , ('Usuario')

INSERT INTO USUARIO  (nome, login,senha,inicio) values
('Aluno x', 'loginx', '123',  getdate()) ,
('Aluno Y', 'loginY', NULL,  getdate()) ,
('CANTINA A', 'LOGINA', '123',  getdate()) ,
('Aluno DO PIM', 'PIM', '123',  getdate())

insert into usuapERFIL (chUsuario, chperfil,dataativa)  
values(1,3,GETDATE()), (2,3,GETDATE()), (3,1,GETDATE()), (4,3,GETDATE())

insert into APLIFUNCAO (descricao) values
('Dasboards'),
('Baixar entrega'),
('Realizar pedido'),
('Pedido de um usuario'),
('Relatorio Venda'),
('Manual do Usuário'),
('Impressao da Nota')

insert into apliperfiLfuncao (chfuncao, chperfil)
values (1,3),(2,2),(3,1),(4,2),(5,1),(5,2), (6,2), (7,1),(8,1),(8,2)