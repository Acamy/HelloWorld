--创建数据库
create database MySchool2 
--删除数据库


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
go--批处理

create table Class
(
	cid int identity(1,1) primary key,
	cname nvarchar(16) not null,
	cDesciption nvarchar(256)
)

--向已知的表中添加新列
alter table Class add cCount int not null
--向已知的表中删除某一列
alter table Class drop column cCount

--set IDENTITY INSERT Class on,
--向表中插入数据
insert into Class values('高三五班','学习最烂的一个班')
insert into Class values('高三五班','学习最烂的一个班')
insert into Class values('高三五班','学习最烂的一个班')
insert into Class values('高三五班','学习最烂的一个班')

--批量插入
insert into Class
select '高三五班','学习最烂的一个班'union all
select '高三五班','学习最烂的一个班'union all
select '高三五班','学习最烂的一个班'union all
select '高三五班','学习最烂的一个班'

--移除表中数据,不会还原自动增长的列
delete from Class where cid=15

--把表直接删除
drop table Class

--移除表中数据,会还原自动增长的列
truncate table Class

--查看表中有哪些数据 *代表所有
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

insert into Student values('何宝华','男','武汉市','15927358616',23,'1992-06-16',2)

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


--通过代码的形式添加约束

--添加主键约束
alter table Test add constraint PK_Test_ID primary key(id)
--删除约束
alter table Test drop constraint PK_Test_ID

--添加唯一约束
alter table Test add constraint UQ_Test_Name unique(name)

--添加默认约束
alter table Test add constraint DF_Test_Sex default('男') for sex
alter table Test add constraint CK_Test_Sex check(sex='男' or sex='女')

--添加检查约束
alter table Test add constraint CK_Test_Age check(age>0 and age<100)

insert into Test(name,age,sex) values('张三',18,'男')
insert into Test(name,age,sex) values('张四',13,'女')
insert into Test(name,age) values('张2',14)

select * from Test 

delete from Test where id=3
--把表直接删除
drop table Test

--移除表中数据,会还原自动增长的列
truncate table Test
