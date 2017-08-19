
--20170531 liushui±í´´½¨  sshinetao
  IF  not EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[liushui]') AND type in (N'U'))
create table liushui(
	id int not null Primary key identity(4,1),
	title nvarchar(50),
	pingzheng nvarchar(500),
	duifang nvarchar(50),
	zaiyao nvarchar(50),
	inMoney decimal,
	outMoney decimal,
	nowMoney decimal,
	Year int,
	Monty int,
	Day int,
	CreateTime datetime,
	Usernum nvarchar(50),
	RealName nvarchar(50),
	itemid nvarchar(50) 
)
go 