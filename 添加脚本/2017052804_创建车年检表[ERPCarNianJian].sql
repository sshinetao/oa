--创建车年检表[ERPCarNianJian]
 IF  not EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ERPCarNianJian]') AND type in (N'U'))

create table ERPCarNianJian(
	 id int not null Primary key identity(4,1),
	 Carname varchar(50),
	 Username varchar(50),
	 Chejiandate datetime,
	 Timestr datetime,
	 Backinfo varchar(500) 
)
 go 