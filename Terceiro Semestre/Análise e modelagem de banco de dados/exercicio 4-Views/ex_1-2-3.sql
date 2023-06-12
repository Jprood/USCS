
--1
create view vmPlatinum as
Select *
From cliente
where limitecredito > 50000

--2
select * from vmPlatinum

insert into CLIENTE (fantasia,limitecredito)
values ('Shein' , 300000)

--3
create view vmSilver as
Select *
From cliente
where limitecredito < 10000

select * from vmSilver

create view vmGold as
Select *
From cliente
where limitecredito > 10000 AND limitecredito <= 50000

select * from vmGold

