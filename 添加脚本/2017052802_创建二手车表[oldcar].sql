--创建二手车表[oldcar]
  IF  not EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[oldcar]') AND type in (N'U'))
create table oldcar(
	 id int not null Primary key identity(4,1),
	 tasknum varchar(150),
	 htnum varchar(150),
	 seller varchar(50),
	 sell_tel varchar(50),
	 sell_address varchar(150),
	 buyer varchar(50),
	 buy_tel varchar(50),
	 buy_address varchar(50),
	 plat_num varchar(50),
	 dengji_num varchar(50),
	 cartype varchar(50),
	 chejianum varchar(50),
	 changpai varchar(500),
	 zhuanru varchar(150),
	 fapiaofile varchar(250),
	 chejiafile varchar(50),
	 Userid varchar(50),
	 CreateTime datetime,
	 sell_coder varchar(50),
	 buy_coder varchar(50),
	 offer_time datetime
)
 
go