USE [MyPersonnelDB]
--51aspx.com
GO
/****** 对象:  Table [dbo].[工资核算表]    脚本日期: 05/15/2007 08:04:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[工资核算表](
	[自编号] [int] IDENTITY(1,1) NOT NULL,
	[员工编号] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[员工姓名] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[基本工资] [float] NULL,
	[津贴] [float] NULL,
	[奖金] [float] NULL,
	[工龄工资] [float] NULL,
	[岗位工资] [float] NULL,
	[其他应增项] [float] NULL,
	[所得税] [float] NULL,
	[养老险] [float] NULL,
	[医疗险] [float] NULL,
	[住房基金] [float] NULL,
	[其他应减项] [float] NULL,
	[补充说明] [nvarchar](250) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_工资核算表] PRIMARY KEY CLUSTERED 
(
	[自编号] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [MyPersonnelDB]
GO
ALTER TABLE [dbo].[工资核算表]  WITH CHECK ADD  CONSTRAINT [FK_工资核算表_基本档案1] FOREIGN KEY([员工编号])
REFERENCES [dbo].[基本档案] ([员工编号])