/*1*/
SELECT 
perfil = p.descricao,
nome = u.nome
FROM usuario u 
INNER JOIN USUAPERFIL up
ON u.chusuario = up.chusuario
INNER JOIN apliperfil p
ON p.chperfil = up.chperfil

order by 2,1

/*2*/
SELECT 
perfil = p.descricao,
nome = u.nome
FROM usuario u 
INNER JOIN USUAPERFIL up
ON u.chusuario = up.chusuario
INNER JOIN apliperfil p
ON p.chperfil = up.chperfil
WHERE desativacao IS NOT NULL

/*3*/
SELECT
FUNCAO =f.descricao,
PERFIL = p.descricao
FROM aplifuncao f
INNER JOIN APLIPERFILFUNCAO pf
ON f.chfuncao = pf.chfuncao
INNER JOIN apliperfil p
ON p.chperfil = pf.chperfil
ORDER BY 2,1

/*4*/ 
SELECT TOP 1
perfil = p.descricao, total=count(*)
FROM apliperfil p
INNER JOIN apliperfilfuncao pf
ON p.chperfil= pf.chperfil
INNER JOIN aplifuncao f
ON f.chfuncao = pf.chfuncao

GROUP BY p.descricao
ORDER BY 2 desc

/*5*/
SELECT 
Perfil = p.descricao, 
Funcao = f.descricao
FROM apliperfil p
INNER JOIN apliperfilfuncao pf
ON p.chperfil = pf.chperfil
INNER JOIN aplifuncao f
ON f.chfuncao = pf.chfuncao
WHERE f.descricao = 'impressao da nota'

/*6*/
INSERT INTO apliperfilfuncao (chperfil, chfuncao)
VALUES (2,7),(3,7)
/* ou*/
INSERT INTO APLIPERFILFUNCAO (chperfil, chfuncao)
SELECT p.chperfil, f.chfuncao
FROM APLIPERFIL p, APLIFUNCAO f
WHERE f.descricao = 'Impressao da Nota'
  AND NOT EXISTS (
    SELECT 1
    FROM APLIPERFILFUNCAO pf
    WHERE pf.chperfil = p.chperfil AND pf.chfuncao = f.chfuncao
  )

/*7*/
SELECT u.nome, u.senha
FROM usuario u
WHERE senha IS null

/*8*/
SELECT u.nome, u.chusuario, u.senha,
novasenha = substring(nome, 1,2)+ convert(varchar(10),chusuario)+ substring(senha, 1,1)
FROM usuario u

UPDATE usuario 
SET senha = substring(nome, 1,2)+ convert(varchar(10),chusuario)+ substring(senha, 1,1)
  