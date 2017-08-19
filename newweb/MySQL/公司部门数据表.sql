USE [MyPersonnelDB]
GO
/****** 对象:  Table [dbo].[公司部门]    脚本日期: 05/15/2007 08:05:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[公司部门](
	[部门名称] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[部门负责人] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[人事文员] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[联系电话] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[额定人数] [int] NULL,
	[补充说明] [nvarchar](150) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_公司部门] PRIMARY KEY CLUSTERED 
(
	[部门名称] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
