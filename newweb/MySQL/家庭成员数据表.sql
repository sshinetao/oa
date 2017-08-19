USE [MyPersonnelDB]
GO
/****** 对象:  Table [dbo].[家庭成员]    脚本日期: 05/15/2007 08:06:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[家庭成员](
	[自编号] [int] IDENTITY(1,1) NOT NULL,
	[员工编号] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[员工姓名] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[家庭成员姓名] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[与员工关系] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[工作单位] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[担任职务] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[政治面貌] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[联系电话] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[补充说明] [nvarchar](250) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_家庭成员] PRIMARY KEY CLUSTERED 
(
	[自编号] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [MyPersonnelDB]
GO
ALTER TABLE [dbo].[家庭成员]  WITH CHECK ADD  CONSTRAINT [FK_家庭成员_基本档案1] FOREIGN KEY([员工编号])
REFERENCES [dbo].[基本档案] ([员工编号])