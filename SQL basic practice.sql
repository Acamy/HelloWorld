select * from Student

Create table Teacher
(
	tId int identity(1,1) primary key,
	--创建表的同时，直接添加约束
	tName nvarchar(32) not null unique,
	tSex nchar(1) not null check(tSex='男' or tSex='女'),
	tAge int not null check(tAge>0 and tAge<100),
	tSalary money not null
)

drop table teacher

insert into Teacher(tName,tSex,tAge,tSalary) values('罗永浩','男',30,3000)
insert into Teacher(tName,tSex,tAge,tSalary) values('俞敏洪','男',40,900)
insert into Teacher(tName,tSex,tAge,tSalary) values('李开复','男',50,1000)
insert into Teacher(tName,tSex,tAge,tSalary) values('张飞','男',60,10000)

select * from Teacher

--改名
update Teacher set tName='刘德华' where tId=1
--删除
delete from Teacher where tName='李开复'


--把表中全部数据清空，但是自动增长的字段不还原
delete from Teacher

--把表中全部数据清空，而且自动增长的字段还原
truncate table Teacher 

--添加唯一约束
alter table Teacher add constraint UQ_Teacher_TName unique(tName)

alter table Teacher drop constraint UQ_Teacher_TName

--添加默认约束
alter table Teacher add constraint DF_Teacher_TSalary default(1000) for tSalary


Create table Class
(
	cId int identity(1,1) primary key,
	--创建表的同时，直接添加约束
	cName nvarchar(32) not null,
	cDescription nvarchar(32) not null
)

insert into Class
select '高一一班','快班'union all
select '高一二班','中班'union all
select '高一三班','慢班'union all
select '高一一班','快班'union all
select '高一二班','中班'union all
select '高一三班','慢班'



--给Class添加一列数据
alter table Class add teacherID int

--添加外键约束
alter table Class add constraint FK_Class_TeacherId foreign key(teacherID)
references Teacher(tID)
on delete cascade



--添加外键成功后就可以执行级联删除了
delete from Teacher where tId=2


-----------------------数据检索----------------
-- *代表所有的列
select * from Class

select * from Teacher

--as仅仅是对结果集进行操作，不会改变元数据
select cName as'姓名',cDescription as '部门' from Class

select 1+1

select GETDATE()

--只有一列数据
select tName as '姓名' from Teacher where tId=1

--有两列数据
select '姓名',tName from Teacher where tId=1

加号，就是相加
select '我的工资是'+2000
