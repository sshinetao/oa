USE [MyPersonnelDB]
GO
/****** 对象:  Table [dbo].[操作用户]    脚本日期: 05/15/2007 08:03:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[操作用户](
	[用户名称] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[用户姓名] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[所在部门] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[联系电话] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[职责说明] [nvarchar](250) COLLATE Chinese_PRC_CI_AS NULL,
	[人事管理之员工基本档案] [int] NULL CONSTRAINT [DF_操作用户_人事管理之员工基本档案]  DEFAULT ((0)),
	[人事管理之员工家庭成员] [int] NULL CONSTRAINT [DF_操作用户_人事管理之员工家庭成员]  DEFAULT ((0)),
	[人事管理之员工工作简历] [int] NULL CONSTRAINT [DF_操作用户_人事管理之员工工作简历]  DEFAULT ((0)),
	[人事管理之员工奖惩记录] [int] NULL CONSTRAINT [DF_操作用户_人事管理之员工奖惩记录]  DEFAULT ((0)),
	[人事管理之员工培训记录] [int] NULL CONSTRAINT [DF_操作用户_人事管理之员工培训记录]  DEFAULT ((0)),
	[人事管理之员工工作业绩] [int] NULL CONSTRAINT [DF_操作用户_人事管理之员工工作业绩]  DEFAULT ((0)),
	[人事管理之员工离职管理] [int] NULL CONSTRAINT [DF_操作用户_人事管理之员工离职管理]  DEFAULT ((0)),
	[考勤管理之月度部门考勤] [int] NULL CONSTRAINT [DF_操作用户_考勤管理之月度部门考勤]  DEFAULT ((0)),
	[考勤管理之年度个人考勤] [int] NULL CONSTRAINT [DF_操作用户_考勤管理之年度个人考勤]  DEFAULT ((0)),
	[工资管理之月度工资核算] [int] NULL CONSTRAINT [DF_操作用户_工资管理之月度工资核算]  DEFAULT ((0)),
	[工资管理之月度工资发放] [int] NULL CONSTRAINT [DF_操作用户_工资管理之月度工资发放]  DEFAULT ((0)),
	[查询管理之查询个人档案] [int] NULL CONSTRAINT [DF_操作用户_查询管理之查询个人档案]  DEFAULT ((0)),
	[查询管理之查询部门档案] [int] NULL CONSTRAINT [DF_操作用户_查询管理之查询部门档案]  DEFAULT ((0)),
	[查询管理之查询考勤信息] [int] NULL CONSTRAINT [DF_操作用户_查询管理之查询考勤信息]  DEFAULT ((0)),
	[查询管理之查询工资信息] [int] NULL CONSTRAINT [DF_操作用户_查询管理之查询工资信息]  DEFAULT ((0)),
	[系统管理之分配用户权限] [int] NULL CONSTRAINT [DF_操作用户_系统管理之分配用户权限]  DEFAULT ((0)),
	[系统管理之公司信息设置] [int] NULL CONSTRAINT [DF_操作用户_系统管理之公司信息设置]  DEFAULT ((0)),
	[系统管理之公司部门设置] [int] NULL CONSTRAINT [DF_操作用户_系统管理之公司部门设置]  DEFAULT ((0)),
 CONSTRAINT [PK_操作用户] PRIMARY KEY CLUSTERED 
(
	[用户名称] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [MyPersonnelDB]
GO
ALTER TABLE [dbo].[操作用户]  WITH CHECK ADD  CONSTRAINT [FK_操作用户_公司部门] FOREIGN KEY([所在部门])
REFERENCES [dbo].[公司部门] ([部门名称])