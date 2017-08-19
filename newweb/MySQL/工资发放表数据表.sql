USE [MyPersonnelDB]
GO
/****** 对象:  Table [dbo].[工资发放表]    脚本日期: 05/15/2007 08:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[工资发放表](
	[自编号] [int] IDENTITY(1,1) NOT NULL,
	[员工编号] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[员工姓名] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[基本工资] [float] NULL,
	[津贴] [float] NULL,
	[奖金] [float] NULL,
	[工龄工资] [float] NULL,
	[岗位工资] [float] NULL,
	[其他应增项] [float] NULL,
	[应发合计]  AS ((((([基本工资]+[津贴])+[奖金])+[工龄工资])+[岗位工资])+[其他应增项]),
	[所得税] [float] NULL,
	[养老险] [float] NULL,
	[医疗险] [float] NULL,
	[住房基金] [float] NULL,
	[其他应减项] [float] NULL,
	[应减合计]  AS (((([所得税]+[养老险])+[医疗险])+[住房基金])+[其他应减项]),
	[实发金额]  AS (((((([基本工资]+[津贴])+[奖金])+[工龄工资])+[岗位工资])+[其他应增项])-(((([所得税]+[养老险])+[医疗险])+[住房基金])+[其他应减项])),
	[银行账号] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[养老保险账号] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[医疗保险账号] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[住房基金账号] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[身份证号码] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[发放年份] [int] NULL,
	[发放月份] [int] NULL,
	[补充说明] [nvarchar](150) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_工资发放表] PRIMARY KEY CLUSTERED 
(
	[自编号] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [MyPersonnelDB]
GO
ALTER TABLE [dbo].[工资发放表]  WITH CHECK ADD  CONSTRAINT [FK_工资发放表_基本档案1] FOREIGN KEY([员工编号])
REFERENCES [dbo].[基本档案] ([员工编号])