USE [MyPersonnelDB]
GO
/****** 对象:  Table [dbo].[奖惩记录]    脚本日期: 05/15/2007 08:07:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[奖惩记录](
	[自编号] [int] IDENTITY(1,1) NOT NULL,
	[员工编号] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[员工姓名] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[奖惩日期] [datetime] NULL,
	[奖惩类型] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[奖惩原因] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[奖惩批准单位] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[解除处分日期] [datetime] NULL,
	[补充说明] [nvarchar](250) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_奖惩记录] PRIMARY KEY CLUSTERED 
(
	[自编号] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [MyPersonnelDB]
GO
ALTER TABLE [dbo].[奖惩记录]  WITH CHECK ADD  CONSTRAINT [FK_奖惩记录_基本档案1] FOREIGN KEY([员工编号])
REFERENCES [dbo].[基本档案] ([员工编号])