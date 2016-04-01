create database path
use path
go
--����ʡ��
create table T_Province (
P_ID int not null identity primary key,
P_name nvarchar(20),
)
go
--�����б�����P_IDΪʡ������
create table T_City (
C_ID int not null identity primary key,
C_name nvarchar(20),
P_ID int not null,
constraint id_fk foreign key (P_ID) references T_Province (P_ID),
)
go
--�����û������Խ����û��ĵ�¼�����ҽ��û��뾰�����ӣ�����¼�û�ÿ������ľ���
create table T_User
(
	U_ID int not null identity primary key,
	U_name nvarchar(20),
	U_Secret nvarchar(20)
)
go
--���������S_likeΪ�û��Ծ����ϲ���̶ȣ�Ϊ�Ӷ��������ɸѡ���ʵļ������������������������뻹Ҫ��Щ����
create table T_Scene (
S_ID int not null identity primary key,
S_name nvarchar(20),
C_ID int not null,
S_like nvarchar(20),
U_ID int not null,
FOREIGN KEY (U_ID) REFERENCES T_User(U_ID),
FOREIGN KEY (C_ID) REFERENCES T_City(C_ID) 
)
go 
--��������֮��·������ʱ���Ϊ·��ͼ�о�����Ⱥ�˳���ṩ�������ó����·�ߡ���׼����д��������ȵ��㷨��
create table T_Distance
(
	D_ID int not null identity primary key,
	D_time nvarchar(20),
	D_Scence1 nvarchar(20),
	D_Scence2 nvarchar(20)
)
go
insert into T_Province (P_name) values
('����'),

('�Ϻ�'),

('���'),

('����'),

('������'),

('����'),
('����'),
('ɽ��'),

('ɽ��'),

('����'),

('�ӱ�'),

('����'),

('����'),

('����'),

('����'),

('����'),

('����'),

('�㶫'),

('����'),

('����'),

('����'),

('�Ĵ�'),

('���ɹ�'),

('����'),

('����'),

('�ຣ'),

('����'),

('�㽭'),

('����'),

('����'),

('̨��'),

('���'),

('����'),
('�½�')
