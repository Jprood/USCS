CREATE PROCEDURE geraMensagem
AS BEGIN
DECLARE @i int=1
DECLARE @msg varchar(1000)=''

while @i <= 5 BEGIN
SET @msg = CONCAT(@msg,@i, ',')
SET @i = @i +1
END

SELECT Resultado=@msg
END

EXEC geraMensagem