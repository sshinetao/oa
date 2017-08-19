
if not exists(select * from  [ERPTreeList] where [TextStr]='二手车管理')
begin
INSERT [ERPTreeList] ([TextStr],[ImageUrlStr],[ValueStr],[Target],[ParentID],[PaiXuStr]) 
VALUES ( N'二手车管理',N'~/images/TreeImages/vehicle.gif',N'二手车管理',N'rform',174,50)
end
go
 

delete from [ERPTreeList] where [TextStr]='我的二手车销售' or [TextStr]='添加二手车销售记录'
INSERT [ERPTreeList] ([TextStr],[ImageUrlStr],[ValueStr],[NavigateUrlStr],[Target],[ParentID],[QuanXianList],[PaiXuStr]) 
select N'我的二手车销售',N'~/images/TreeImages/source.gif',N'066',N'oldcar/list.aspx',N'rform',(select id from [ERPTreeList]  where [TextStr] = '二手车管理'),N'A_添加|M_修改|D_删除|E_导出',49
union 
select    N'添加二手车销售记录',N'~/images/TreeImages/person_info.gif',N'068',N'oldcar/oldcarinfo.aspx',N'rform',(select id from [ERPTreeList]  where [TextStr] = '二手车管理'),N'A_添加|M_修改|D_删除|E_导出',49
 