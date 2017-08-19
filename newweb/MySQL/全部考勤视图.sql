USE [MyPersonnelDB]
GO
/****** 对象:  View [dbo].[全部考勤视图]    脚本日期: 05/15/2007 08:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[全部考勤视图]
AS
SELECT dbo.考勤记录.员工编号, dbo.在职员工视图.所属部门, dbo.在职员工视图.姓名, 
      dbo.考勤记录.C1, dbo.考勤记录.C2, dbo.考勤记录.C3, dbo.考勤记录.C4, 
      dbo.考勤记录.C5, dbo.考勤记录.C6, dbo.考勤记录.C7, dbo.考勤记录.C8, 
      dbo.考勤记录.C9, dbo.考勤记录.C10, dbo.考勤记录.C11, dbo.考勤记录.C12, 
      dbo.考勤记录.C13, dbo.考勤记录.C14, dbo.考勤记录.C15, dbo.考勤记录.C16, 
      dbo.考勤记录.C17, dbo.考勤记录.C18, dbo.考勤记录.C19, dbo.考勤记录.C20, 
      dbo.考勤记录.C21, dbo.考勤记录.C22, dbo.考勤记录.C23, dbo.考勤记录.C24, 
      dbo.考勤记录.C25, dbo.考勤记录.C26, dbo.考勤记录.C27, dbo.考勤记录.C28, 
      dbo.考勤记录.C29, dbo.考勤记录.C30, dbo.考勤记录.C31, dbo.考勤记录.考勤年份, 
      dbo.考勤记录.考勤月份
FROM dbo.考勤记录 INNER JOIN
      dbo.在职员工视图 ON dbo.考勤记录.员工编号 = dbo.在职员工视图.员工编号

GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[58] 4[14] 2[10] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "考勤记录"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 335
               Right = 173
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "在职员工视图"
            Begin Extent = 
               Top = 6
               Left = 211
               Bottom = 332
               Right = 364
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'VIEW', @level1name=N'全部考勤视图'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'VIEW', @level1name=N'全部考勤视图'
