USE [MyPersonnelDB]
GO
/****** 对象:  Table [dbo].[考勤记录]    脚本日期: 05/15/2007 08:07:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[考勤记录](
	[自编号] [int] IDENTITY(1,1) NOT NULL,
	[员工编号] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[员工姓名] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C1] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C2] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C3] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C4] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C5] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C6] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C7] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C8] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C9] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C10] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C11] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C12] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C13] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C14] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C15] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C16] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C17] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C18] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C19] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C20] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C21] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C22] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C23] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C24] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C25] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C26] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C27] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C28] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C29] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C30] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[C31] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[考勤年份] [int] NULL,
	[考勤月份] [int] NULL,
 CONSTRAINT [PK_考勤记录] PRIMARY KEY CLUSTERED 
(
	[自编号] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [MyPersonnelDB]
GO
ALTER TABLE [dbo].[考勤记录]  WITH CHECK ADD  CONSTRAINT [FK_考勤记录_基本档案1] FOREIGN KEY([员工编号])
REFERENCES [dbo].[基本档案] ([员工编号])