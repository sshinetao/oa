
if not exists(select * from  [ERPTreeList] where [TextStr]='���ֳ�����')
begin
INSERT [ERPTreeList] ([TextStr],[ImageUrlStr],[ValueStr],[Target],[ParentID],[PaiXuStr]) 
VALUES ( N'���ֳ�����',N'~/images/TreeImages/vehicle.gif',N'���ֳ�����',N'rform',174,50)
end
go
 

delete from [ERPTreeList] where [TextStr]='�ҵĶ��ֳ�����' or [TextStr]='��Ӷ��ֳ����ۼ�¼'
INSERT [ERPTreeList] ([TextStr],[ImageUrlStr],[ValueStr],[NavigateUrlStr],[Target],[ParentID],[QuanXianList],[PaiXuStr]) 
select N'�ҵĶ��ֳ�����',N'~/images/TreeImages/source.gif',N'066',N'oldcar/list.aspx',N'rform',(select id from [ERPTreeList]  where [TextStr] = '���ֳ�����'),N'A_���|M_�޸�|D_ɾ��|E_����',49
union 
select    N'��Ӷ��ֳ����ۼ�¼',N'~/images/TreeImages/person_info.gif',N'068',N'oldcar/oldcarinfo.aspx',N'rform',(select id from [ERPTreeList]  where [TextStr] = '���ֳ�����'),N'A_���|M_�޸�|D_ɾ��|E_����',49
 