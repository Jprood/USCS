ALTER PROCEDURE geraMensagem (@LIMITE int)
AS BEGIN

DECLARE @i int=1
DECLARE @mensa varchar(1000)=''

while @i <= @LIMITE BEGIN
SET @mensa = CONCAT(@mensa,@i, ',')
SET @i = @i +1
END

SELECT Resultado=@mensa
END

EXEC geraMensagem 10