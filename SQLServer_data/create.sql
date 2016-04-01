create database path
use path
go
--创建省表
create table T_Province (
P_ID int not null identity primary key,
P_name nvarchar(20),
)
go
--创建市表，其中P_ID为省表的外键
create table T_City (
C_ID int not null identity primary key,
C_name nvarchar(20),
P_ID int not null,
constraint id_fk foreign key (P_ID) references T_Province (P_ID),
)
go
--创建用户表，可以进行用户的登录，并且将用户与景点联接，即记录用户每次浏览的景点
create table T_User
(
	U_ID int not null identity primary key,
	U_name nvarchar(20),
	U_Secret nvarchar(20)
)
go
--创建景点表，S_like为用户对景点的喜欢程度，为从多个景点中筛选合适的几个做参数，你两可以在想想还要哪些参数
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
--创建景点之间路程所需时间表，为路线图中景点的先后顺序提供参数，得出最佳路线。我准备先写个深度优先的算法吧
create table T_Distance
(
	D_ID int not null identity primary key,
	D_time nvarchar(20),
	D_Scence1 nvarchar(20),
	D_Scence2 nvarchar(20)
)
go
insert into T_Province (P_name) values
('北京'),

('上海'),

('天津'),

('重庆'),

('黑龙江'),

('吉林'),
('辽宁'),
('山东'),

('山西'),

('陕西'),

('河北'),

('河南'),

('湖北'),

('湖南'),

('海南'),

('江苏'),

('江西'),

('广东'),

('广西'),

('云南'),

('贵州'),

('四川'),

('内蒙古'),

('宁夏'),

('甘肃'),

('青海'),

('安徽'),

('浙江'),

('福建'),

('西藏'),

('台湾'),

('香港'),

('澳门'),
('新疆')
