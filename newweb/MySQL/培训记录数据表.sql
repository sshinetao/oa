USE [MyPersonnelDB]
GO
/****** 对象:  Table [dbo].[培训记录]    脚本日期: 05/15/2007 08:08:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[培训记录](
	[自编号] [int] IDENTITY(1,1) NOT NULL,
	[员工编号] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[员工姓名] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[开始日期] [datetime] NULL,
	[结束日期] [datetime] NULL,
	[培训单位] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[培训地点] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[培训内容] [nvarchar](250) COLLATE Chinese_PRC_CI_AS NULL,
	[培训经费] [float] NULL,
	[证书名称] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[补充说明] [nvarchar](250) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_培训记录] PRIMARY KEY CLUSTERED 
(
	[自编号] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [MyPersonnelDB]
GO
ALTER TABLE [dbo].[培训记录]  WITH CHECK ADD  CONSTRAINT [FK_培训记录_基本档案1] FOREIGN KEY([员工编号])
REFERENCES [dbo].[基本档案] ([员工编号])