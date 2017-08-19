USE [MyPersonnelDB]
GO
/****** 对象:  Table [dbo].[公司信息]    脚本日期: 05/15/2007 08:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[公司信息](
	[公司名称] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[法人代表] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[公司地址] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[邮政编码] [char](10) COLLATE Chinese_PRC_CI_AS NULL,
	[服务电话] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[电子信箱] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[公司网站] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[首页图像] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[标志图标] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[系统名称] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[优先级] [int] NULL,
 CONSTRAINT [PK_公司信息] PRIMARY KEY CLUSTERED 
(
	[公司名称] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF