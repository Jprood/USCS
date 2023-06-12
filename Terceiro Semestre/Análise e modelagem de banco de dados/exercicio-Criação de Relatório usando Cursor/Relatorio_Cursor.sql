DECLARE @ch int
DECLARE @Fantasia varchar(50)
-- --------------------------------------
DECLARE nivelcli
CURSOR FOR  SELECT chcliente, fantasia FROM vmSilver
-- --------------------------------------
OPEN nivelcli
FETCH NEXT FROM nivelcli INTO @ch,@fantasia 

PRINT 'CLIENTE SILVER'
WHILE @@FETCH_STATUS = 0  
BEGIN  
      PRINT '>>' + @fantasia
      FETCH NEXT FROM nivelcli INTO @ch,@fantasia
END  
CLOSE nivelcli  
DEALLOCATE nivelcli
--------------------------------------------------
DECLARE nivelcli
CURSOR FOR  SELECT chcliente, fantasia FROM vmGold
-- --------------------------------------
OPEN nivelcli
FETCH NEXT FROM nivelcli INTO @ch,@fantasia 

PRINT 'CLIENTE GOLD'
WHILE @@FETCH_STATUS = 0  
BEGIN  
      PRINT '>>' + @fantasia
      FETCH NEXT FROM nivelcli INTO @ch,@fantasia
END  
CLOSE nivelcli  
DEALLOCATE nivelcli
----------------------------------------------------
DECLARE nivelcli
CURSOR FOR  SELECT chcliente, fantasia FROM vmPlatinum
-- --------------------------------------
OPEN nivelcli
FETCH NEXT FROM nivelcli INTO @ch,@fantasia 

PRINT 'CLIENTE PLATINUM'
WHILE @@FETCH_STATUS = 0  
BEGIN  
      PRINT '>>' + @fantasia
      FETCH NEXT FROM nivelcli INTO @ch,@fantasia
END  
CLOSE nivelcli  
DEALLOCATE nivelcli