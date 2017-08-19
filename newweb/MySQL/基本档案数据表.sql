USE [MyPersonnelDB]
GO
/****** 对象:  Table [dbo].[基本档案]    脚本日期: 05/15/2007 08:06:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[基本档案](
	[自编号] [int] IDENTITY(1,1) NOT NULL,
	[员工编号] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[所属部门] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[姓名] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[性别] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[民族] [nvarchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[籍贯] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[出生日期] [datetime] NULL,
	[身份证号码] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[政治面貌] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[婚姻状况] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[文化程度] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[职称] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[职务] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[专业] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[毕业院校] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[进入公司时间] [datetime] NULL,
	[合同服务年限] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[基本工资] [float] NULL,
	[银行账号] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[养老保险账号] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[医疗保险账号] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[住房基金账号] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[联系电话] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[手机号码] [nvarchar](20) COLLATE Chinese_PRC_CI_AS NULL,
	[电子信箱] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[家庭住址] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[邮政编码] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[补充说明] [nvarchar](250) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_基本档案_1] PRIMARY KEY CLUSTERED 
(
	[员工编号] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [MyPersonnelDB]
GO
ALTER TABLE [dbo].[基本档案]  WITH CHECK ADD  CONSTRAINT [FK_基本档案_公司部门1] FOREIGN KEY([所属部门])
REFERENCES [dbo].[公司部门] ([部门名称])