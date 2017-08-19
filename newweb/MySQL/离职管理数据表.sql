USE [MyPersonnelDB]
GO
/****** 对象:  Table [dbo].[离职管理]    脚本日期: 05/15/2007 08:07:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[离职管理](
	[自编号] [int] IDENTITY(1,1) NOT NULL,
	[员工编号] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[员工姓名] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[离职日期] [datetime] NULL,
	[离职原因] [nvarchar](250) COLLATE Chinese_PRC_CI_AS NULL,
	[批准人] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[补充说明] [nvarchar](250) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_离职管理_1] PRIMARY KEY CLUSTERED 
(
	[自编号] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [MyPersonnelDB]
GO
ALTER TABLE [dbo].[离职管理]  WITH CHECK ADD  CONSTRAINT [FK_离职管理_基本档案2] FOREIGN KEY([员工编号])
REFERENCES [dbo].[基本档案] ([员工编号])