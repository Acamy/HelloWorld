--�������ݿ�
create database MySchool2 
--ɾ�����ݿ�


on primary
(
    name='MySchool2',
    filename='D:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\MySchool2.mdf',
    size=3MB,
    filegrowth=1MB,
    maxsize=100MB 

)
log on
(
    name='MySchool2_log',
    filename='D:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\MySchool2_log.ldf',
    size=1MB,
    filegrowth=10%

)
go
use MySchool2
go--������

create table Class
(
	cid int identity(1,1) primary key,
	cname nvarchar(16) not null,
	cDesciption nvarchar(256)
)

--����֪�ı����������
alter table Class add cCount int not null
--����֪�ı���ɾ��ĳһ��
alter table Class drop column cCount

--set IDENTITY INSERT Class on,
--����в�������
insert into Class values('�������','ѧϰ���õ�һ����')
insert into Class values('�������','ѧϰ���õ�һ����')
insert into Class values('�������','ѧϰ���õ�һ����')
insert into Class values('�������','ѧϰ���õ�һ����')

--��������
insert into Class
select '�������','ѧϰ���õ�һ����'union all
select '�������','ѧϰ���õ�һ����'union all
select '�������','ѧϰ���õ�һ����'union all
select '�������','ѧϰ���õ�һ����'

--�Ƴ���������,���ỹԭ�Զ���������
delete from Class where cid=15

--�ѱ�ֱ��ɾ��
drop table Class

--�Ƴ���������,�ỹԭ�Զ���������
truncate table Class

--�鿴��������Щ���� *��������
select * from Class

create table Student
(
	sId int primary key identity(1,1),
	sname nvarchar(16) not null,
	sgender char(2) not null,
	saddress nvarchar(128) null,
	sphone nvarchar(16),
	sage int not null,
	sbirthday smalldatetime null,
	scid int not null
)

insert into Student values('�α���','��','�人��','15927358616',23,'1992-06-16',2)

update Student set scid=5 where sId=2
select * from Student



create table Score
(
	studentId int identity(1,1) primary key,
	english int not null,
	--english int not null
)
--drop table Score
--set IDENTITY_INSERT Score on
insert into Score
select 80 union all
select 82 union all
select 90 union all
select 95

update Score set english+=3 where english<90
select * from Score


--ͨ���������ʽ���Լ��

--�������Լ��
alter table Test add constraint PK_Test_ID primary key(id)
--ɾ��Լ��
alter table Test drop constraint PK_Test_ID

--���ΨһԼ��
alter table Test add constraint UQ_Test_Name unique(name)

--���Ĭ��Լ��
alter table Test add constraint DF_Test_Sex default('��') for sex
alter table Test add constraint CK_Test_Sex check(sex='��' or sex='Ů')

--��Ӽ��Լ��
alter table Test add constraint CK_Test_Age check(age>0 and age<100)

insert into Test(name,age,sex) values('����',18,'��')
insert into Test(name,age,sex) values('����',13,'Ů')
insert into Test(name,age) values('��2',14)

select * from Test 

delete from Test where id=3
--�ѱ�ֱ��ɾ��
drop table Test

--�Ƴ���������,�ỹԭ�Զ���������
truncate table Test
