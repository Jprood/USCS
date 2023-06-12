IF EXISTS (SELECT * FROM sys.objects
WHERE object_id =OBJECT_ID(N'[dbo].[Cliente]') AND
type in (N'U'))
DROP TABLE Cliente
GO

CREATE TABLE Cliente (
chCliente int IDENTITY(1,1) NOT NULL,
fantasia varchar(100) NULL,
limitecredito decimal (10,2)
)
GO

insert into cliente (fantasia, limitecredito)

values ('ABC Pneus', 20000),
('Magazine Luiza', 100000),
('Hortifruti da Vila', 30000),
('Esquinao LavaRapido', 5000)